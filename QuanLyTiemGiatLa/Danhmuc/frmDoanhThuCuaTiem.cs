using System;
using System.Windows.Forms;
using Entity;
using System.Collections;
using System.Drawing.Printing;
using System.Drawing;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmDoanhThuCuaTiem : Form
    {
        private bool daloadxongform = false;

        public frmDoanhThuCuaTiem()
        {
            InitializeComponent();
            Xuly.Xuly.ToanManHinh(this);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            btnCollapse.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _listPhieu = Business.PhieuBO.SelectByNgayLap(dtpTuNgay.Value, dtpDenNgay.Value);
            _listPhieu.Sort(delegate (PhieuEntity p1, PhieuEntity p2)
            {
                return p1.MaPhieu.CompareTo(p2.MaPhieu);
            });
            this.LoadDataTongThu();
        }

        private void LoadDataTongThu()
        {
            ListThuNhapTrongNgayEntity kq = new ListThuNhapTrongNgayEntity();
            foreach (PhieuEntity phieu in _listPhieu)
            {
                int index = indexNgay(kq, phieu.NgayLap);
                if (index == -1)
                {
                    ThuNhapTrongNgayEntity thunhap = new ThuNhapTrongNgayEntity()
                    {
                        NgayLap = phieu.NgayLap,
                        //TongTienTruocGiamGia = phieu.TongTien,
                        //TongTienSauGiamGia = phieu.TongTien - Xuly.Xuly.TinhTienGiamGia(phieu.TongTien, phieu.GiamGia)						
                        TongTienPhiVanChuyen = Xuly.Xuly.TinhTienVanChuyen(phieu.TongTien, phieu.PhiGiaoNhan),
                    };
                    thunhap.TongTienSauGiamGia = phieu.TongTien - thunhap.TongTienPhiVanChuyen;
                    if (phieu.IsPhieuHuy)
                    {
                        thunhap.TongTienHuyHoaDon = phieu.TongTien;
                        thunhap.TongTienCuoiCung = 0;
                    }
                    else
                    {
                        thunhap.TongTienHuyHoaDon = 0;
                        thunhap.TongTienCuoiCung = phieu.TongTien;
                    }
                    kq.Add(thunhap);
                }
                else
                {
                    //kq[index].TongTienTruocGiamGia += phieu.TongTien;
                    //kq[index].TongTienSauGiamGia += phieu.TongTien - Xuly.Xuly.TinhTienGiamGia(phieu.TongTien, phieu.GiamGia);
                    Int64 tienvc = Xuly.Xuly.TinhTienVanChuyen(phieu.TongTien, phieu.PhiGiaoNhan);
                    kq[index].TongTienPhiVanChuyen += tienvc;
                    kq[index].TongTienSauGiamGia += phieu.TongTien - tienvc;
                    if (phieu.IsPhieuHuy)
                    {
                        kq[index].TongTienHuyHoaDon += phieu.TongTien;
                    }
                    else
                    {
                        kq[index].TongTienCuoiCung += phieu.TongTien;
                    }
                }
            }
            daloadxongform = false;
            bndsrcDSThuNhap.DataSource = kq;
            daloadxongform = true;
            bndsrcDSThuNhap_CurrentChanged(null, null);
            long tongcong = 0;
            foreach (ThuNhapTrongNgayEntity thu in kq)
            {
                tongcong += thu.TongTienCuoiCung;
            }
            txtTongCong.Text = tongcong == 0 ? "0" : String.Format("{0:0,0}", tongcong);
        }

        private int indexNgay(ListThuNhapTrongNgayEntity list, DateTime ngay)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (compareNgay(list[i].NgayLap, ngay))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool compareNgay(DateTime dt, DateTime other)
        {
            return dt.Year == other.Year &&
                dt.Month == other.Month &&
                dt.Day == other.Day;
        }

        private ListPhieuEntity _listPhieu;

        private void bndsrcDSThuNhap_CurrentChanged(object sender, EventArgs e)
        {
            if (!daloadxongform) return;
            bndsrcDSPhieuTrongNgay.Clear();
            bndsrcDSPhieuTrongNgay.DataSource = null;
            ListPhieuEntity lstPhieu = new ListPhieuEntity();
            ThuNhapTrongNgayEntity thunhap = bndsrcDSThuNhap.Current as ThuNhapTrongNgayEntity;
            if (thunhap != null)
            {
                foreach (PhieuEntity phieu in _listPhieu)
                {
                    if (compareNgay(phieu.NgayLap, thunhap.NgayLap))
                        lstPhieu.Add(phieu);
                }
            }
            bndsrcDSPhieuTrongNgay.DataSource = lstPhieu;
            VeDataGrid(lstPhieu);
            //this.LoadTongTienSauGiamGia();
        }

        private void VeDataGrid(ListPhieuEntity lstPhieu)
        {
            try
            {
                if (lstPhieu != null)
                {
                    for (int i = 0; i < lstPhieu.Count; i++)
                    {
                        if (lstPhieu[i].IsPhieuHuy)
                            for (int k = 0; k < dgvDSPhieuTrongNgay.ColumnCount; k++)
                            {
                                dgvDSPhieuTrongNgay.Rows[i].Cells[k].Style.ForeColor = BienChung.mautrangthaido.PhieuHuy;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDoc_PrintDoanhThu(object sender, PrintPageEventArgs e)
        {
            ListThuNhapTrongNgayEntity dsthunhap = bndsrcDSThuNhap.DataSource as ListThuNhapTrongNgayEntity;
            if (dsthunhap == null)
            {
                MessageBox.Show("Sai định dạng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InKhoTo(e, dsthunhap);
        }

        private void InKhoTo(PrintPageEventArgs e, ListThuNhapTrongNgayEntity dsthunhap)
        {
            Int32 leftMargin = 0;
            Int32 topMargin = 0;
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);//Palatino Linotype
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);//Times New Roman
            Font fontItalic = new Font("Arial", 8, FontStyle.Italic);
            Font fontSo = new Font("Courier New", 10, FontStyle.Regular);
            Int32 RHeight = fontRegular.Height;
            Brush br = Brushes.Black;
            Int32 chinhno = RHeight;

            e.Graphics.DrawString("Thống kê doanh thu của tiệm", fontBold, br, leftMargin + 45, topMargin); RHeight += 4;
            e.Graphics.DrawString("   Từ " + dtpTuNgay.Value.ToString("dd/MM/yyyy") +
                " đến " + dtpDenNgay.Value.ToString("dd/MM/yyyy") +
                " (" + (dtpDenNgay.Value.Subtract(dtpTuNgay.Value).Days + 1) + " ngày)", fontRegular, br, leftMargin, RHeight); RHeight += chinhno - 5;
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, 0, RHeight); RHeight += chinhno + 5;
            e.Graphics.DrawString("STT\t     Ngày\t\tSố tiền thu được", fontRegular, br, leftMargin, RHeight); RHeight += chinhno - 3;
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, 0, RHeight); RHeight += chinhno + 3;
            Int64 tongtien = 0;
            //dsthunhap.Add(new ThuNhapTrongNgayEntity() { NgayLap = DateTime.Now, TongTienSauGiamGia = 50000 });
            for (int i = 0; i < dsthunhap.Count; i++)
            {
                var thunhapngay = dsthunhap[i];
                e.Graphics.DrawString(String.Format("{0,2:0}.", i + 1), fontRegular, br, leftMargin, RHeight);
                //e.Graphics.DrawString("|", fontRegular, br, leftMargin + 30, RHeight);
                e.Graphics.DrawString(thunhapngay.NgayLap.ToString("dd/MM/yyyy"), fontRegular, br, leftMargin + 65, RHeight);
                //e.Graphics.DrawString("|", fontRegular, br, leftMargin + 140, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", thunhapngay.TongTienSauGiamGia), fontSo, br, leftMargin + 178, RHeight);
                tongtien += thunhapngay.TongTienSauGiamGia;
                RHeight += chinhno + 3;
            }
            fontBold = new Font("Arial", 9, FontStyle.Bold);
            RHeight -= 8;
            e.Graphics.DrawString("________________", fontBold, br, leftMargin + 160, RHeight); RHeight += chinhno + 3;
            e.Graphics.DrawString("Tổng cộng: ", fontBold, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,10:0,0}", tongtien), fontSo, br, leftMargin + 178, RHeight); RHeight += chinhno;
        }

        private void btnInDoanhThu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có " + dgvDSThuNhap.RowCount + " bản ghi, bạn có muốn in không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintDoanhThu);
                if (true == BienChung.isTrienKhai)
                {
                    printDoc.Print();
                }
                else
                {
                    PrintPreviewDialog printPreview = new PrintPreviewDialog();
                    printPreview.Document = printDoc;
                    printPreview.PrintPreviewControl.Zoom = 1.0;
                    printPreview.ClientSize = new Size(1030, 600);
                    printPreview.Show(this);
                }
            }
        }

    }
}
