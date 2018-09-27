using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using Entity;
using QuanLyTiemGiatLa.Xuly;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmLapPhieu : Form
    {
        public OnSaved onsaved;
        private TrangThai TrangThai;
        private Boolean _dainform = true;
        private Boolean _daloadxongform = false;
        private Boolean _dungmavach = false;
        private Int32 _phigiaonhan = 0; // don vi: %
        private ListPhieuSlotEntity _listPhieuSlot = null;
        private ListChiTietPhieuEntity _listChitietPhieu = null;
        public KhachHangEntity _khachhang = null;
        public PhieuEntity _phieu = null;

        public frmLapPhieu()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmLapPhieu_Load);
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            try
            {
                TrangThai = _phieu == null ? TrangThai.Them : TrangThai.Sua;
                if (TrangThai == TrangThai.Them)
                {
                    dtpNgayLap.Value = DateTime.Now;
                    dtpNgayHenTra.Value = DateTime.Now.AddDays(Xuly.ThaoTacIniCauHinhPhanMem.ReadNgayLapNgayHenTra());
                    txtUserName.Text = BienChung.userCurrent.HoTen;
                    ListDotGiamGiaEntity listdotGiamgia = Business.DotGiamGiaBO.SelectByNgay(DateTime.Now);
                    if (listdotGiamgia.Count != 0)
                    {
                        nudGiamGia.Value = listdotGiamgia[listdotGiamgia.Count - 1].GiamGia;
                    }
                    _listPhieuSlot = new ListPhieuSlotEntity();
                    _listChitietPhieu = new ListChiTietPhieuEntity();
                    _phieu = new PhieuEntity();
                    txtMaVachDauTien.Text = (Xuly.ThaoTacIniMaVach.Read() + 1).ToString();
                    _dungmavach = Xuly.ThaoTacIniCauHinhPhanMem.ReadDungMaVach();
                    txtMaVachDauTien.Enabled = _dungmavach;
                    txtMaVachCuoi.Enabled = _dungmavach;
                    LoadDataPhieuSlotMaVach();
                    _phigiaonhan = Xuly.ThaoTacIniCauHinhPhanMem.ReadPhiVanChuyen();
                    _dainform = false;
                }
                else
                {
                    _phieu = Business.PhieuBO.SelectByMaPhieu(_phieu.MaPhieu);
                    if (_phieu.MaKhachHang == 0) _khachhang = null;
                    else
                    {
                        _khachhang = Business.KhachHangBO.SelectByMaKhachHang(_phieu.MaKhachHang);
                        txtTenKhachHang.Text = _khachhang.TenKhachHang;
                        _phieu.TenKhachHang = _khachhang.TenKhachHang;
                        txtLoaiKhach.Text = String.IsNullOrEmpty(_khachhang.TenVip) ? String.Empty : _khachhang.TenVip;
                    }

                    dtpNgayLap.Value = _phieu.NgayLap;
                    dtpNgayHenTra.Value = _phieu.NgayHenTra;
                    txtMaPhieu.Text = _phieu.MaPhieu.ToString();
                    nudGiamGia.Value = _phieu.GiamGia;
                    //nudPhiGiaoNhan.Value = _phieu.PhiGiaoNhan;
                    _phigiaonhan = _phieu.PhiGiaoNhan;
                    chkPhiGiaoNhan.Checked = _phieu.PhiGiaoNhan > 0;
                    txtGhiChu.Text = _phieu.GhiChu;
                    txtUserName.Text = _phieu.UserName == BienChung.userCurrent.UserName ? BienChung.userCurrent.HoTen : _phieu.UserName;
                    chkDaThanhToan.Checked = _phieu.DaThanhToan;
                    this.LoadData(false);
                    this.LockControl();
                }
                chkPhiGiaoNhan.Text = "Phí giao nhận: " + _phigiaonhan + " %";
                _daloadxongform = true;
                if (TrangThai == TrangThai.Them && _khachhang != null)
                {
                    btnThemDo.Focus();
                    btnThemDo_Click(null, null);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLapPhieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_phieu != null && (!_dainform) && TrangThai == TrangThai.Them && _khachhang == null && (MessageBox.Show("Bạn chưa lưu khách hàng, bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
                txtTenKhachHang.Focus();
            }
            else if (_phieu != null && !_dainform && MessageBox.Show("Bạn chưa in hóa đơn, bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                btnInHoaDon.Focus();
            }
        }

        public void LoadDataKhachHang()
        {
            //if (khachhang != null && khachhang.MaKhachHang > 0)
            //{
            //    Double sotiendatungthanhtoan = Business.KhachHangBO.CountSoTienDaTungThanhToan(khachhang.MaKhachHang);
            //    txtLoaiKhach.Text = sotiendatungthanhtoan == 0 ? "0" : String.Format("{0:0,0}", sotiendatungthanhtoan);
            //}
            txtLoaiKhach.Text = String.IsNullOrEmpty(_khachhang.TenVip) ? String.Empty : _khachhang.TenVip;
            txtTenKhachHang.Text = _khachhang.TenKhachHang;
            nudGiamGia.Value = _khachhang.GiamGia > (Int32)nudGiamGia.Value ? _khachhang.GiamGia : nudGiamGia.Value;
        }

        private Boolean CheckForm()
        {
            //if (khachhang == null || khachhang.MaKhachHang == 0)
            //{
            //    txtTenKhachHang.Focus();
            //    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            if (dtpNgayHenTra.Value < dtpNgayLap.Value)
            {
                dtpNgayHenTra.Focus();
                MessageBox.Show("Ngày hẹn trả phải lớn hơn ngày lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //if (phieu == null)	// TH thêm
            //{
            //    if (!CheckForm()) return;
            //    phieu = new Entity.PhieuEntity()
            //    {
            //        NgayLap = dtpNgayLap.Value,
            //        NgayHenTra = dtpNgayHenTra.Value,
            //        MaKhachHang = khachhang == null ? 0 : khachhang.MaKhachHang,
            //        GhiChu = txtGhiChu.Text,
            //        DaThanhToan = rdoDaThanhToan.Checked,
            //        GiamGia = Convert.ToInt32(nudGiamGia.Value),
            //        UserName = BienChung.userCurrent.UserName
            //    };
            //    phieu.MaPhieu = Business.PhieuBO.Insert(phieu);
            //    txtMaPhieu.Text = phieu.MaPhieu.ToString();
            //    if (onsaved != null) onsaved();
            //	  btnThemDo_Click(sender, e);
            //    nudGiamGia.Focus();
            //    nudGiamGia_ValueChanged(sender, e);
            //}
            //else	// TH sửa
            //{
            //    if (!CheckForm()) return;
            //    phieu.MaPhieu = phieu.MaPhieu;
            //    phieu.MaKhachHang = khachhang == null ? 0 : khachhang.MaKhachHang;
            //    phieu.NgayLap = dtpNgayLap.Value;
            //    phieu.NgayHenTra = dtpNgayHenTra.Value;
            //    phieu.GiamGia = Convert.ToInt32(nudGiamGia.Value);
            //    phieu.GhiChu = txtGhiChu.Text.Trim();
            //    phieu.DaThanhToan = rdoDaThanhToan.Checked;
            //    phieu.UserName = BienChung.userCurrent.UserName;
            //    if (phieu.MaPhieu == -1)
            //    {

            //    }
            //    else
            //    {
            //        Business.PhieuBO.UpdateThongTin(phieu);
            //        if (onsaved != null) onsaved();
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        btnInHoaDon.Focus();
            //    }
            //}
        }

        private void btnThemDo_Click(object sender, EventArgs e)
        {
            //if (phieu != null && phieu.MaPhieu != 0)
            //{
            frmCTPhieu frm = new frmCTPhieu(_listPhieuSlot, _listChitietPhieu);
            frm.onsaved = new OnSaved(LoadData);
            frm.Show(this);
            frm.btnLayDoNhanh_Click(null, null);
            frm.FormClosed += new FormClosedEventHandler((s, ex) =>
            {
                dtpNgayHenTra.Focus();
            });
            //}
            //else
            //    MessageBox.Show("Bạn chưa lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private long TinhTongTien()
        {
            long tongtien = 0;
            for (int i = 0; i < _listChitietPhieu.Count; i++)
            {
                tongtien += _listChitietPhieu[i].DonGia * _listChitietPhieu[i].Soluong;
            }
            return tongtien;
        }

        private void LoadData(Boolean coOnSave)
        {
            if (TrangThai == TrangThai.Them)
            {
                LoadDataPhieuSlotMaVach();
                bndsrcDSCTPhieu.DataSource = null;
                bndsrcDSPhieuSlot.DataSource = null;
                bndsrcDSCTPhieu.DataSource = _listChitietPhieu;
                bndsrcDSPhieuSlot.DataSource = _listPhieuSlot;
                TinhTien();
                if (coOnSave && onsaved != null) onsaved();
            }
            else if (_phieu != null && _phieu.MaPhieu != 0)
            {
                Int64 tongtien;
                _listChitietPhieu = Business.ChiTietPhieuBO.SelectByMaPhieu(_phieu.MaPhieu, out tongtien);
                if (_phieu.DaTraDo)
                    _listPhieuSlot = Business.PhieuSlotBO.SelectByMaPhieu_DaTra(_phieu.MaPhieu);
                else
                    _listPhieuSlot = Business.PhieuSlotBO.SelectByMaPhieu(_phieu.MaPhieu);
                bndsrcDSCTPhieu.DataSource = null;
                bndsrcDSPhieuSlot.DataSource = null;
                bndsrcDSCTPhieu.DataSource = _listChitietPhieu;
                bndsrcDSPhieuSlot.DataSource = _listPhieuSlot;
                lblThanhTien.Text = (tongtien == 0 ? "0" : String.Format("{0,8:0,0}", tongtien));
                lblTongTien.Text = _phieu.TongTien == 0 ? "0" : String.Format("{0,8:0,0}", _phieu.TongTien);
                if (coOnSave && onsaved != null) onsaved();
                txtMaVachDauTien.Text = _listPhieuSlot.Count > 0 ? _listPhieuSlot[0].MaVach.ToString() : "0";
                txtMaVachCuoi.Text = _listPhieuSlot.Count > 0 ? _listPhieuSlot[_listPhieuSlot.Count - 1].MaVach.ToString() : "0";
                txtTongSoSanPham.Text = _listPhieuSlot.Count.ToString();
            }
        }

        private void LoadData()
        {
            LoadData(true);
        }

        //private void btnSuaDo_Click(object sender, EventArgs e)
        //{
        //    Entity.ChiTietPhieuEntity chitietphieu = bndsrcDSCTPhieu.Current as Entity.ChiTietPhieuEntity;
        //    if (chitietphieu != null)
        //    {
        //        frmCTPhieu frm = new frmCTPhieu(chitietphieu.MaPhieu);
        //        frm.onsaved = new OnSaved(this.LoadData);
        //        frm.chitietphieu = chitietphieu;
        //        frm.ShowDialog();
        //    }
        //    else
        //        MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        private void btnXoaDo_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = dgvDSDo.SelectedRows;
                if (selectedRows.Count != 0)
                {
                    string tenhang = selectedRows[0].Cells["tenHangDataGridViewTextBoxColumn"].Value.ToString();
                    string tenkieugiat = selectedRows[0].Cells["tenKieuGiatDataGridViewTextBoxColumn"].Value.ToString();
                    int mahang = (int)selectedRows[0].Cells["maHangDataGridViewTextBoxColumn"].Value;
                    int makieugiat = (int)selectedRows[0].Cells["maKieuGiatDataGridViewTextBoxColumn"].Value;
                    int soluong = (int)selectedRows[0].Cells["soluongDataGridViewTextBoxColumn"].Value;

                    if (MessageBox.Show("Bạn có chắc chắn xóa '" + tenhang + "-" + tenkieugiat + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Business.ChiTietPhieuBO.Delete(chitietphieu.IDChiTietPhieu);
                        _listChitietPhieu.RemoveAt(selectedRows[0].Index);
                        this.XoaPhieuSlot(mahang, makieugiat, soluong);
                        this.CapNhatMaDoPhieuSlot();
                        this.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatMaDoPhieuSlot()
        {
            int i = 0;
            while (i < _listPhieuSlot.Count)
            {
                _listPhieuSlot[i].STT = ++i;
            }
        }

        private void XoaPhieuSlot(int mahang, int makieugiat, int soluongcanxoa)
        {
            int soluong = 0;
            for (int i = _listPhieuSlot.Count - 1; i >= 0; i--)
            {
                if (soluong == soluongcanxoa) break;
                if (_listPhieuSlot[i].MaHang == mahang &&
                    _listPhieuSlot[i].MaKieuGiat == makieugiat)
                {
                    if (String.IsNullOrEmpty(_listPhieuSlot[i].SoHieuSanPham))
                    {
                        _listPhieuSlot.RemoveAt(i);
                    }
                    else
                    {
                        int sosp = Int32.Parse(_listPhieuSlot[i].SoHieuSanPham.Split('/')[1]);
                        for (int k = 0; k < sosp; k++)
                        {
                            _listPhieuSlot.RemoveAt(i);
                            i--;
                        }
                        i++;
                    }
                    soluong++;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LockControl()
        {
            btnGhi.Enabled = false;
            btnThemDo.Enabled = false;
            btnXoaDo.Enabled = false;
            btnFind.Enabled = false;
            dtpNgayLap.Enabled = false;
            dtpNgayHenTra.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtMaVachDauTien.Enabled = false;
            txtMaVachCuoi.Enabled = false;
            //chkCoDungMaVach.Enabled = false;
            chkDaThanhToan.Enabled = false;
            chkPhiGiaoNhan.Enabled = false;
            contextMenuStrip1.Enabled = false;
            if (_phieu.DaTraDo) btnCatDo.Enabled = false;
            txtGhiChu.ReadOnly = true;
            nudGiamGia.Enabled = false;
            //nudPhiGiaoNhan.Enabled = false;
            //if (onsaved != null) onsaved();
        }

        #region Chức năng in

        private void printDoc_PrintHoaDon(object sender, PrintPageEventArgs e)
        {
            ListChiTietPhieuEntity lstctphieu = Business.ChiTietPhieuBO.SelectByMaPhieu(_phieu.MaPhieu);
            if (_phieu == null || lstctphieu == null)
            {
                MessageBox.Show("Bạn chưa có chi tiết phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.InTheoTemplate(lstctphieu, e);
            //this.InKhoTo(lstctphieu, e);
        }

        private void InChiTietPhieuTemplate(ListChiTietPhieuEntity lstctphieu, PrintPageEventArgs e, ref int topMargin)
        {
            string filePrintCTPhieuTemplate = @"template_In_ChiTietPhieu.txt";
            String line = String.Empty;
            if (System.IO.File.Exists(filePrintCTPhieuTemplate))
            {
                System.Drawing.Font fontCurrent = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular);
                Brush br = Brushes.Black;
                foreach (ChiTietPhieuEntity item in lstctphieu)
                {
                    var filestream = new System.IO.FileStream(filePrintCTPhieuTemplate, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    var file = new System.IO.StreamReader(filestream);
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line == "")
                        {
                            continue;
                        }
                        if (line.StartsWith("#"))
                        {
                            continue;
                        }
                        String[] mangChuoi = line.Split(';');
                        int lineBreakHeight = 0;
                        String content = String.Empty;
                        if (mangChuoi.Length == 5)
                        {
                            int fontsize = 8;
                            if (true != Int32.TryParse(mangChuoi[1], out fontsize))
                                fontsize = 8;
                            if (true != Int32.TryParse(mangChuoi[4], out lineBreakHeight))
                                lineBreakHeight = 0;
                            fontCurrent = new System.Drawing.Font(mangChuoi[0], fontsize, mangChuoi[2] == "b" ? System.Drawing.FontStyle.Bold : (mangChuoi[2] == "i" ? System.Drawing.FontStyle.Italic : (mangChuoi[2] == "u" ? System.Drawing.FontStyle.Underline : System.Drawing.FontStyle.Regular)));
                            content = mangChuoi[3];
                        }
                        else if (mangChuoi.Length == 2)
                        {
                            if (true != Int32.TryParse(mangChuoi[1], out lineBreakHeight))
                                lineBreakHeight = 0;
                            content = mangChuoi[0];
                        }
                        //===============
                        if (content.Contains("{TenHang}"))
                        {
                            content = content.Replace("{TenHang}", item.TenHang);
                        }
                        if (content.Contains("{KieuGiat}"))
                        {
                            content = content.Replace("{KieuGiat}", item.TenKieuGiat);
                        }
                        if (content.Contains("{SoLuong}"))
                        {
                            content = content.Replace("{SoLuong}", String.Format("{0,10}", item.Soluong));
                        }
                        if (content.Contains("{DonGia}"))
                        {
                            content = content.Replace("{DonGia}", String.Format("{0,10:0,0}", item.DonGia));
                        }
                        if (content.Contains("{ThanhTien}"))
                        {
                            content = content.Replace("{ThanhTien}", String.Format("{0,10:0,0}", item.DonGia * item.Soluong));
                        }
                        if (content.Contains("{GhiChu}"))
                        {
                            if (item.GhiChu != String.Empty)
                                content = content.Replace("{GhiChu}", item.GhiChu);
                            else
                                content = "";
                        }
                        //===============
                        if (content != String.Empty)
                        {
                            e.Graphics.DrawString(content, fontCurrent, br, 0, topMargin); topMargin += lineBreakHeight;
                        }
                    }
                    file.Close();
                }
            }
        }

        private void InTheoTemplate(ListChiTietPhieuEntity lstctphieu, PrintPageEventArgs e)
        {
            string filePrintTemplate = @"template_In.txt";
            String line = String.Empty;
            Int64 tongtien = 0;
            foreach (ChiTietPhieuEntity item in lstctphieu)
            {
                tongtien += item.Soluong * item.DonGia;
            }
            Int64 sotiendcgiam = Xuly.Xuly.TinhTienGiamGia(tongtien, (Int32)nudGiamGia.Value);
            Int64 sotienphaitt = tongtien - sotiendcgiam;
            Int64 sotiengiaonhan = 0;
            if (chkPhiGiaoNhan.Checked)
                sotiengiaonhan = Xuly.Xuly.TinhTienTangGia(sotienphaitt, _phigiaonhan);
            sotienphaitt += sotiengiaonhan;
            Int64 sotienkhtra = 0;
            if (chkDaThanhToan.Checked)
            {
                if (string.IsNullOrEmpty(txtSoTienKHDaTra.Text.Trim()) || !Int64.TryParse(txtSoTienKHDaTra.Text.Trim(), out sotienkhtra))
                    sotienkhtra = sotienphaitt;
            }
            if (System.IO.File.Exists(filePrintTemplate))
            {
                var filestream = new System.IO.FileStream(filePrintTemplate, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                var file = new System.IO.StreamReader(filestream);
                int lineCount = 0;
                System.Drawing.Font fontCurrent = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular);
                Brush br = Brushes.Black;
                int topMargin = 0;
                while ((line = file.ReadLine()) != null)
                {
                    lineCount++;
                    if (line == "")
                    {
                        continue;
                    }
                    if (line.StartsWith("#"))
                    {
                        continue;
                    }
                    String[] mangChuoi = line.Split(';');
                    int lineBreakHeight = 0;
                    String content = String.Empty;
                    if (mangChuoi.Length == 5)
                    {
                        int fontsize = 8;
                        if (true != Int32.TryParse(mangChuoi[1], out fontsize))
                            fontsize = 8;
                        if (true != Int32.TryParse(mangChuoi[4], out lineBreakHeight))
                            lineBreakHeight = 0;
                        fontCurrent = new System.Drawing.Font(mangChuoi[0], fontsize, mangChuoi[2] == "b" ? System.Drawing.FontStyle.Bold : (mangChuoi[2] == "i" ? System.Drawing.FontStyle.Italic : (mangChuoi[2] == "u" ? System.Drawing.FontStyle.Underline : System.Drawing.FontStyle.Regular)));
                        content = mangChuoi[3];
                    }
                    else if (mangChuoi.Length == 2)
                    {
                        if (true != Int32.TryParse(mangChuoi[1], out lineBreakHeight))
                            lineBreakHeight = 0;
                        content = mangChuoi[0];
                    }
                    //===============
                    if (content.Contains("{KhachHang}"))
                    {
                        if (!String.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
                            content = content.Replace("{KhachHang}", txtTenKhachHang.Text);
                    }
                    if (content.Contains("{MaPhieu}"))
                    {
                        content = content.Replace("{MaPhieu}", _phieu.MaPhieu.ToString());
                    }
                    if (content.Contains("{NgayNhan}"))
                    {
                        content = content.Replace("{NgayNhan}", String.Format("{0:dd/MM/yyyy HH:mm}", _phieu.NgayLap));
                    }
                    if (content.Contains("{ChiTietPhieu}"))
                    {
                        this.InChiTietPhieuTemplate(lstctphieu, e, ref topMargin);
                        content = "";
                    }
                    if (content.Contains("{SLDo}"))
                    {
                        content = content.Replace("{SLDo}", String.Format("{0,2:0,0}", txtTongSoSanPham.Text));
                    }
                    if (content.Contains("{ThanhTien}"))
                    {
                        content = content.Replace("{ThanhTien}", String.Format("{0,10:0,0}", tongtien));
                    }
                    if (content.Contains("{GiamGia}"))
                    {
                        if (sotiendcgiam != 0)
                            content = content.Replace("{GiamGia}", Convert.ToInt32(nudGiamGia.Value).ToString());
                        else
                            content = "";
                    }
                    if (content.Contains("{TienDuocGiam}"))
                    {
                        if (sotiendcgiam != 0)
                            content = content.Replace("{TienDuocGiam}", String.Format("{0,10:0,0}", -sotiendcgiam));
                        else
                            content = "";
                    }
                    if (content.Contains("{PhiGiaoNhan}"))
                    {
                        if (sotiengiaonhan != 0)
                            content = content.Replace("{PhiGiaoNhan}", _phigiaonhan.ToString());
                        else
                            content = "";
                    }
                    if (content.Contains("{TienGiaoNhan}"))
                    {
                        if (sotiengiaonhan != 0)
                            content = content.Replace("{TienGiaoNhan}", String.Format("{0,10:0,0}", sotiengiaonhan));
                        else
                            content = "";
                    }
                    if (content.Contains("{TongTien}"))
                    {
                        content = content.Replace("{TongTien}", String.Format("{0,10:0,0}", sotienphaitt));
                    }
                    if (content.Contains("{KHTra}"))
                    {
                        content = content.Replace("{KHTra}", sotienkhtra == 0 ? "         0" : String.Format("{0,10:0,0}", -sotienkhtra));
                    }
                    if (content.Contains("{TienThua}"))
                    {
                        content = content.Replace("{TienThua}", (sotienkhtra - sotienphaitt) == 0 ? "         0" : String.Format("{0,10:0,0}", sotienkhtra - sotienphaitt));
                    }
                    if (content.Contains("{GhiChu}"))
                    {
                        if (!String.IsNullOrEmpty(txtGhiChu.Text))
                            content = content.Replace("{GhiChu}", txtGhiChu.Text.Trim());
                        else
                            content = "";
                    }
                    if (content.Contains("{DaThanhToan}"))
                    {
                        if (chkDaThanhToan.Checked)
                            content = "";
                        else
                            content = content.Replace("{DaThanhToan}", "");
                    }
                    if (content.Contains("{MaVach}"))
                    {
                        content = content.Replace("{MaVach}", txtMaVachDauTien.Text == txtMaVachCuoi.Text ? txtMaVachCuoi.Text : (txtMaVachDauTien.Text + " -> " + txtMaVachCuoi.Text));
                    }
                    if (content.Contains("{NgayHenTra}"))
                    {
                        content = content.Replace("{NgayHenTra}", String.Format("{0:dd/MM/yyyy}", _phieu.NgayHenTra));
                    }
                    if (content.Contains("{NhanVien}"))
                    {
                        if (!String.IsNullOrEmpty(txtUserName.Text))
                            content = content.Replace("{NhanVien}", txtUserName.Text);
                        else
                            content = "";
                    }
                    if (content.Contains("{LienKH}"))
                    {
                        if (_phieu.SoLanIn == 0 /*|| !BienChung.isTrienKhai*/)
                            content = content.Replace("{LienKH}", "");
                        else
                            content = "";
                    }
                    if (content.Contains("{Lien}"))
                    {
                        content = content.Replace("{Lien}", (_phieu.SoLanIn + 1) + (_phieu.SoLanIn == 0 ? ": Khách hàng" : ": Nội bộ"));
                    }
                    //===============
                    if (content != String.Empty) {
                        e.Graphics.DrawString(content, fontCurrent, br, 0, topMargin); topMargin += lineBreakHeight;
                    }
                }
                file.Close();
            }
        }

        [Obsolete("Cửa hàng in khổ to, ko chơi khổ nhỏ")]
        private void InKhoNho(ListChiTietPhieuEntity lstctphieu, PrintPageEventArgs e)
        {
            Int32 leftMargin = 0;
            Int32 topMargin = 0;
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);
            Font fontItalic = new Font("Arial", 8, FontStyle.Italic);
            Font fontSo = new Font("Courier New", 8, FontStyle.Bold);
            Int32 RHeight = fontRegular.Height; // 16
            Int32 BHeight = fontBold.Height;
            Brush br = Brushes.Black;

            Int32 chinhno = RHeight;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadTenCuaHang(), fontBold, br, leftMargin, topMargin); RHeight += 4;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadDiaChiCuaHang(), fontRegular, br, leftMargin, RHeight); RHeight += chinhno + 2;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadSoDienThoai(), fontRegular, br, leftMargin + 25, RHeight); RHeight += 5;
            e.Graphics.DrawString("*********************************", fontBold, br, leftMargin, RHeight + 10); RHeight += chinhno;
            e.Graphics.DrawString(_phieu.MaPhieu.ToString(), new Font("Arial", 12, FontStyle.Bold), br, leftMargin + 70, RHeight); RHeight += 5;
            e.Graphics.DrawString("*********************************", fontItalic, br, leftMargin + 10, RHeight + 10); RHeight += chinhno + 3;
            if (!String.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
            {
                e.Graphics.DrawString(txtTenKhachHang.Text, fontBold, br,
                                    txtTenKhachHang.Text.Split(' ').Length > 3 ? 0 : 20,
                                    RHeight); RHeight += chinhno + 3;
            }
            e.Graphics.DrawString("Ngày nhận: " + String.Format("{0:dd/MM/yyyy HH:mm}", _phieu.NgayLap), fontRegular, br, leftMargin, RHeight); RHeight += chinhno - 5;
            e.Graphics.DrawString("______________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno;
            Int64 tongtien = 0;
            fontRegular = new Font("Arial", 8, FontStyle.Regular); chinhno = fontRegular.Height;    // 13
            e.Graphics.DrawString("Đồ", fontRegular, br, leftMargin + 40, RHeight);
            e.Graphics.DrawString("SL", fontRegular, br, leftMargin + 85, RHeight);
            e.Graphics.DrawString("Đơn giá", fontRegular, br, leftMargin + 115, RHeight); RHeight += chinhno + 8;
            foreach (ChiTietPhieuEntity item in lstctphieu)
            {
                RHeight += 3;
                e.Graphics.DrawString(item.TenHang, fontRegular, br, leftMargin + 10, RHeight); RHeight += chinhno;
                e.Graphics.DrawString(item.TenKieuGiat, fontItalic, br, leftMargin + 30, RHeight);
                e.Graphics.DrawString(item.Soluong.ToString(), fontSo, br, leftMargin + 90, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", item.DonGia), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
                tongtien += item.Soluong * item.DonGia;
                if (item.GhiChu != String.Empty)
                {
                    RHeight += 2;
                    e.Graphics.DrawString("(" + item.GhiChu + ")", fontItalic, br, leftMargin + 30, RHeight); RHeight += chinhno;
                }
            }
            e.Graphics.DrawString("_____________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno + 5;
            e.Graphics.DrawString("Mục tổng cộng", fontRegular, br, leftMargin, RHeight); RHeight += chinhno;
            fontRegular = new Font("Arial", 10, FontStyle.Regular); chinhno = fontRegular.Height;
            fontBold = new Font("Arial", 8, FontStyle.Bold);
            e.Graphics.DrawString("_________________", fontBold, br, leftMargin + 80, RHeight); RHeight += chinhno;
            e.Graphics.DrawString("Thành tiền: ", fontBold, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,10:0,0}", tongtien), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
            Int64 sotiendcgiam = Xuly.Xuly.TinhTienGiamGia(tongtien, (Int32)nudGiamGia.Value);
            Int64 sotienphaitt = tongtien - sotiendcgiam;
            Int64 sotiengiaonhan = 0;
            if (chkPhiGiaoNhan.Checked)
                sotiengiaonhan = Xuly.Xuly.TinhTienTangGia(sotienphaitt, _phigiaonhan);
            sotienphaitt += sotiengiaonhan;
            if (sotiendcgiam != 0)
            {
                e.Graphics.DrawString("Giảm giá: (" + Convert.ToInt32(nudGiamGia.Value) + "%)", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(nudGiamGia.Value == 0 ? String.Format("{0,10}", "0") :
                    String.Format("{0,10:0,0}", sotiendcgiam), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
            }
            if (sotiengiaonhan != 0)
            {
                e.Graphics.DrawString("Phí giao nhận: (" + _phigiaonhan + "%)", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(_phigiaonhan == 0 ? String.Format("{0,10}", "0") :
                    String.Format("{0,10:0,0}", sotiengiaonhan), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
            }
            e.Graphics.DrawString("Tổng cộng: ", fontBold, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienphaitt), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
            Int64 sotienkhtra;
            if (Int64.TryParse(txtSoTienKHDaTra.Text.Trim(), out sotienkhtra))
            {
                e.Graphics.DrawString("Khách hàng trả: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienkhtra), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
                e.Graphics.DrawString("Tiền thừa: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienkhtra - sotienphaitt), fontSo, br, leftMargin + 90, RHeight); RHeight += chinhno;
            }
            if (!String.IsNullOrEmpty(txtGhiChu.Text))
            {
                RHeight += 3;
                e.Graphics.DrawString("Ghi chú: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(txtGhiChu.Text.Trim(), fontItalic, br, leftMargin + 50, RHeight); RHeight += chinhno;
            }
            if (!chkDaThanhToan.Checked)
            { e.Graphics.DrawString("Chưa thanh toán", fontBold, br, leftMargin, RHeight); RHeight += chinhno; }
            fontRegular = new Font("Arial", 8, FontStyle.Regular); chinhno = fontBold.Height + 2;
            e.Graphics.DrawString("______________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno;
            e.Graphics.DrawString("Ngày hẹn trả hàng: " + String.Format("{0:dd/MM/yyyy}", _phieu.NgayHenTra), fontBold, br, leftMargin + 10, RHeight); RHeight += 5;
            e.Graphics.DrawString("______________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno;
            String str = "Khách hàng đã được phổ biến và" + "\n";
            str += " đồng ý với các lỗi có thể xảy ra" + "\n";
            str += " sau khi sử dụng dịch vụ giặt là" + "\n";
            str += "và đồng ý rằng sau 15 ngày kể từ" + "\n";
            str += "  ngày hẹn trả hàng Công ty sẽ" + "\n";
            str += "không chịu trách nhiệm đối với" + "\n";
            str += "    đồ giặt của khách hàng";
            e.Graphics.DrawString(str, fontBold, br, leftMargin, RHeight); RHeight += 94;
            if (!String.IsNullOrEmpty(txtUserName.Text))
                e.Graphics.DrawString("NV: " + txtUserName.Text, fontRegular, br, leftMargin, RHeight);
        }

        private void InKhoTo(ListChiTietPhieuEntity lstctphieu, PrintPageEventArgs e)
        {
            Int32 leftMargin = 0;
            Int32 topMargin = 0;
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);//Palatino Linotype
            Font fontRegular = new Font("Arial", 10, FontStyle.Regular);//Times New Roman
            Font fontItalic = new Font("Arial", 8, FontStyle.Italic);
            Font fontSo = new Font("Courier New", 8, FontStyle.Bold);
            Int32 RHeight = fontRegular.Height;
            Int32 BHeight = fontBold.Height;
            Brush br = Brushes.Black;
            Int32 chinhno = RHeight;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadTenCuaHang(), fontBold, br, leftMargin + 60, topMargin); RHeight += 4;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadDiaChiCuaHang(), fontRegular, br, leftMargin + 60, RHeight); RHeight += chinhno + 2;
            e.Graphics.DrawString(Xuly.ThaoTacIniCauHinhPhanMem.ReadSoDienThoai(), fontRegular, br, leftMargin + 85, RHeight); RHeight += 5;
            e.Graphics.DrawString("*********************************************", fontRegular, br, leftMargin + 20, RHeight + 10); RHeight += chinhno;
            e.Graphics.DrawString(_phieu.MaPhieu.ToString(), new Font("Arial", 12, FontStyle.Bold), br, leftMargin + 110, RHeight); RHeight += 5;
            e.Graphics.DrawString("**********************************", fontRegular, br, leftMargin + 50, RHeight + 10); RHeight += chinhno + 3;
            if (!String.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
            {
                e.Graphics.DrawString(txtTenKhachHang.Text, fontBold, br, leftMargin + 80, RHeight); RHeight += chinhno + 3;
            }
            e.Graphics.DrawString("Ngày nhận: " + String.Format("{0:dd/MM/yyyy HH:mm}", _phieu.NgayLap), fontRegular, br, leftMargin + 55, RHeight); RHeight += chinhno - 5;
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, 0, RHeight); RHeight += chinhno;
            Int64 tongtien = 0;
            fontRegular = new Font("Arial", 8, FontStyle.Regular); chinhno = fontRegular.Height;
            e.Graphics.DrawString("Đồ", fontRegular, br, leftMargin + 30, RHeight);
            e.Graphics.DrawString("SL", fontRegular, br, leftMargin + 145, RHeight);
            e.Graphics.DrawString("Đơn giá", fontRegular, br, leftMargin + 220, RHeight); RHeight += chinhno + 2;
            foreach (ChiTietPhieuEntity item in lstctphieu)
            {
                RHeight += 3;
                e.Graphics.DrawString(item.TenHang, fontRegular, br, leftMargin + 10, RHeight); RHeight += chinhno;
                e.Graphics.DrawString(item.TenKieuGiat, fontItalic, br, leftMargin + 30, RHeight);
                e.Graphics.DrawString(item.Soluong.ToString(), fontSo, br, leftMargin + 150, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", item.DonGia), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
                tongtien += item.Soluong * item.DonGia;
                if (item.GhiChu != String.Empty)
                {
                    RHeight += 2;
                    e.Graphics.DrawString("(" + item.GhiChu + ")", fontItalic, br, 30, RHeight); RHeight += chinhno;
                }
            }
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, 0, RHeight); RHeight += chinhno + 5;
            e.Graphics.DrawString("Tổng số đồ:", fontRegular, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,2:0,0}", txtTongSoSanPham.Text), fontSo, br, leftMargin + 142, RHeight); RHeight += chinhno - 4;
            fontRegular = new Font("Arial", 10, FontStyle.Regular); chinhno = fontRegular.Height;
            fontBold = new Font("Arial", 8, FontStyle.Bold);
            e.Graphics.DrawString("________________", fontBold, br, leftMargin + 178, RHeight); RHeight += chinhno;
            e.Graphics.DrawString("Thành tiền: ", fontBold, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,10:0,0}", tongtien), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
            Int64 sotiendcgiam = Xuly.Xuly.TinhTienGiamGia(tongtien, (Int32)nudGiamGia.Value);
            Int64 sotienphaitt = tongtien - sotiendcgiam;
            Int64 sotiengiaonhan = 0;
            if (chkPhiGiaoNhan.Checked)
                sotiengiaonhan = Xuly.Xuly.TinhTienTangGia(sotienphaitt, _phigiaonhan);
            sotienphaitt += sotiengiaonhan;
            if (sotiendcgiam != 0)
            {
                e.Graphics.DrawString("Giảm giá: (" + Convert.ToInt32(nudGiamGia.Value) + "%)", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(nudGiamGia.Value == 0 ? String.Format("{0,10}", "0") :
                    String.Format("{0,10:0,0}", sotiendcgiam), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
            }
            if (sotiengiaonhan != 0)
            {
                e.Graphics.DrawString("Phí giao nhận: (" + _phigiaonhan + "%)", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(_phigiaonhan == 0 ? String.Format("{0,10}", "0") :
                    String.Format("{0,10:0,0}", sotiengiaonhan), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
            }
            e.Graphics.DrawString("Tổng cộng: ", fontBold, br, leftMargin, RHeight);
            e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienphaitt), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
            Int64 sotienkhtra;
            if (Int64.TryParse(txtSoTienKHDaTra.Text.Trim(), out sotienkhtra))
            {
                e.Graphics.DrawString("Khách hàng trả: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienkhtra), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
                e.Graphics.DrawString("Tiền thừa: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(String.Format("{0,10:0,0}", sotienkhtra - sotienphaitt), fontSo, br, leftMargin + 190, RHeight); RHeight += chinhno;
            }
            if (!String.IsNullOrEmpty(txtGhiChu.Text))
            {
                RHeight += 3;
                e.Graphics.DrawString("Ghi chú: ", fontBold, br, leftMargin, RHeight);
                e.Graphics.DrawString(txtGhiChu.Text.Trim(), fontItalic, br, leftMargin + 50, RHeight); RHeight += chinhno;
            }
            if (!chkDaThanhToan.Checked)
            { e.Graphics.DrawString("Chưa thanh toán", fontBold, br, leftMargin, RHeight); RHeight += chinhno; }

            String str = string.Empty;
            //--------------------------------------------
            if (_phieu.SoLanIn == 0)
            {
                str += " Quý khách đã đồng ý rủi ro khi giặt đồ được in";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Regular), br, leftMargin, RHeight + 3); RHeight += chinhno * 3 - 5;
                str = string.Empty;
                str += "trên hóa đơn: . . . . . . . . . . . . . . . . . . . . . . . . . . .";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Regular), br, leftMargin, RHeight); RHeight += chinhno - 5;
            }
            //--------------------------------------------
            if (_dungmavach)
            {
                RHeight += chinhno - 7;
                e.Graphics.DrawString("(Mã vạch: " + txtMaVachDauTien.Text + " đến " + txtMaVachCuoi.Text + ")", fontRegular, br, leftMargin, RHeight); RHeight += chinhno - 7;
            }
            fontRegular = new Font("Arial", 8, FontStyle.Regular); chinhno = fontBold.Height + 2; RHeight -= 3;
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno;
            e.Graphics.DrawString("Ngày hẹn trả hàng: chiều " + String.Format("{0:dd/MM/yyyy}", _phieu.NgayHenTra), fontBold, br, leftMargin + 35, RHeight); RHeight += 5;
            e.Graphics.DrawString(" ____________________________________________", fontItalic, br, leftMargin, RHeight); RHeight += chinhno;

            if (_phieu.SoLanIn == 0)
            {
                str = string.Empty;
                str += "Công ty không chịu trách nhiệm đối với đồ giặt bị" + "\n";
                str += "   co, loang màu và các hư hỏng khác như khuy," + "\n";
                str += "  khóa, vật trang trí... khi nguyên nhân là do chất" + "\n";
                str += "  lượng của vải, nhuộm, khuy,khóa, vật trang trí" + "\n";
                str += "             của đồ giặt không đảm bảo.";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Regular), br, leftMargin, RHeight); RHeight += 5 * chinhno - 2;
                str = string.Empty;
                str += "Đền bù với mọi rủi ro, hư hỏng, mất mát không" + "\n";
                str += " vượt quá 10 lần giá dịch vụ giặt là của đồ giặt" + "\n";
                str += "               và phải có hóa đơn gốc.";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Bold), br, leftMargin, RHeight); RHeight += 3 * chinhno;
                str = string.Empty;
                str += "Đề nghị Quý khách kiểm tra hàng cẩn thận trước" + "\n";
                str += "khi nhận. Mọi khiếu nại sau đó sẽ không được" + "\n";
                str += "                         giải quyết." + "\n";
                str += " Quý khách đã được phổ biến và đồng ý với các" + "\n";
                str += "         nội quy sử dụng dịch vụ của Mr.Clean.";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Regular), br, leftMargin, RHeight); RHeight += 5 * chinhno;
                str = string.Empty;
                str += "     Xin cám ơn Quý khách đã chọn Mr.Clean";
                e.Graphics.DrawString(str, new Font("Arial", 9, FontStyle.Bold), br, leftMargin, RHeight); RHeight += chinhno + 2;
            }
            //------------------------------------------
            str = string.Empty;
            if (!String.IsNullOrEmpty(txtUserName.Text)) str += "NV: " + txtUserName.Text;
            str += "   (Liên " + (_phieu.SoLanIn + 1);
            str += (_phieu.SoLanIn == 0) ? ": Khách hàng)" : " Nội bộ)";
            e.Graphics.DrawString(str, fontRegular, br, leftMargin, RHeight);
            //------------------------------------------
        }
        #endregion

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            btnInHoaDon.Enabled = false;
            bool canloadlaiform = false;
            try
            {
                if (TrangThai == TrangThai.Them)
                {
                    if (!this.CheckForm()) return;
                    if (_listChitietPhieu.Count == 0)
                    {
                        MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_khachhang == null && MessageBox.Show("Bạn chưa lưu khách hàng, bạn có chắc chắn in không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    {
                        _phieu.TongTien = _phieu.TongTien;  // số tiền sau khi giảm
                        _phieu.NgayLap = dtpNgayLap.Value;
                        _phieu.NgayHenTra = dtpNgayHenTra.Value;
                        _phieu.MaKhachHang = _khachhang == null ? 0 : _khachhang.MaKhachHang;
                        _phieu.GhiChu = txtGhiChu.Text;
                        _phieu.DaThanhToan = chkDaThanhToan.Checked;
                        _phieu.GiamGia = Convert.ToInt32(nudGiamGia.Value);
                        _phieu.PhiGiaoNhan = chkPhiGiaoNhan.Checked ? _phigiaonhan : 0;
                        _phieu.UserName = BienChung.userCurrent.UserName;
                        _phieu.SoLanIn = 0;
                    };
                    _phieu.MaPhieu = Business.PhieuBO.Insert(_phieu);
                    txtMaPhieu.Text = _phieu.MaPhieu.ToString();
                    if (onsaved != null) onsaved();
                    //-----------------------------------
                    for (int i = 0; i < _listChitietPhieu.Count; i++)
                    {
                        _listChitietPhieu[i].MaPhieu = _phieu.MaPhieu;
                        Business.ChiTietPhieuBO.Insert(_listChitietPhieu[i]);
                    }
                    //-----------------------------------
                    for (int i = 0; i < _listPhieuSlot.Count; i++)
                    {
                        _listPhieuSlot[i].MaPhieu = _phieu.MaPhieu;
                    }
                    Business.PhieuSlotBO.Insert(_listPhieuSlot);
                    TrangThai = TrangThai.Sua;
                    canloadlaiform = true;
                }
                if (_phieu == null || _phieu.MaPhieu == 0)
                {
                    MessageBox.Show("Bạn chưa lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _dainform = true;
                //--------------------------
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintHoaDon);
                if (true == BienChung.isTrienKhai)
                {
                    for (int i = 0; i < Xuly.ThaoTacIniCauHinhPhanMem.ReadSoLanIn(); i++)
                    {
                        printDoc.Print();
                        _phieu.SoLanIn += 1;
                    }
                }
                else
                {
                    _phieu.SoLanIn = 0;
                    PrintPreviewDialog printPreview = new PrintPreviewDialog();
                    printPreview.Document = printDoc;
                    printPreview.PrintPreviewControl.Zoom = 1.0;
                    printPreview.ClientSize = new Size(1030, 600);
                    printPreview.Show(this);
                }
                //---------------------------
                Business.PhieuBO.UpdateSoLanIn(_phieu.MaPhieu, _phieu.SoLanIn);
                txtSoTienKHDaTra.Focus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnInHoaDon.Enabled = true;
                if (canloadlaiform)
                {
                    this.LoadData(false);
                    this.LockControl();
                    this.CapNhatMaVachMax();
                }
            }
        }

        private void CapNhatMaVachMax()
        {
            if (_dungmavach)
            {
                Int64 mavachmax;
                if (Int64.TryParse(txtMaVachCuoi.Text, out mavachmax))
                {
                    Xuly.ThaoTacIniMaVach.Write(mavachmax);
                }
                else
                {
                    MessageBox.Show("Mã vạch không hợp lệ nên không thể cập nhật mã vạch max được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #region Chức năng linh tinh

        private void txtTenKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_khachhang == null) this.btnFind_Click(sender, e);
                else dtpNgayLap.Focus();
            }
        }

        private frmThemKhachHang _frmKH;
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_frmKH == null || _frmKH.IsDisposed) _frmKH = new frmThemKhachHang();
            _frmKH.txtTenKhachHang.Text = txtTenKhachHang.Text.Trim();
            _frmKH.ShowDialog(this);
            _khachhang = _frmKH.khachhang;
            if (_khachhang != null)
            {
                this.LoadDataKhachHang();
                btnThemDo.Focus();
            }
            //frmLoc frm = new frmLoc();
            //String[] kq = frm.ShowLoc("khachhang", "tenkhachhang,dienthoai,diachi", "Tên khách hàng, Điện thoại, Địa chỉ", txtTenKhachHang.Text);
            //txtTenKhachHang.Text = kq[0];
        }

        private void nudGiamGia_ValueChanged(object sender, EventArgs e)
        {
            if (_daloadxongform) TinhTien();
        }

        private void dtpNgayLap_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, dtpNgayHenTra);
        }

        private void dtpNgayHenTra_KeyDown(object sender, KeyEventArgs e)
        {
            //Xuly.Xuly.ControlFocus(e, btnGhi);
            if (e.KeyCode == Keys.Enter)
            {
                txtGhiChu.Focus();
                //btnThemDo.Focus();
                //btnThemDo_Click(sender, e);
            }
        }

        private void nudGiamGia_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, chkPhiGiaoNhan);
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (!nudGiamGia.Enabled)
                Xuly.Xuly.ControlFocus(e, chkPhiGiaoNhan);
        }

        private void chkPhiGiaoNhan_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, btnInHoaDon);
        }

        private void txtSoTienKHDaTra_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void TinhTien()
        {
            if (_phieu != null)
            {
                Int64 tongtien = TinhTongTien();    // thành tiền
                Int64 sotiendcgiam = Xuly.Xuly.TinhTienGiamGia(tongtien, (Int32)nudGiamGia.Value);
                _phieu.TongTien = tongtien - sotiendcgiam;  // tiền sau khi giảm giá
                Int64 sotienvanchuyen = 0;
                if (chkPhiGiaoNhan.Checked)
                    sotienvanchuyen = Xuly.Xuly.TinhTienTangGia(_phieu.TongTien, _phigiaonhan);
                _phieu.TongTien += sotienvanchuyen;
                lblThanhTien.Text = tongtien == 0 ? "0" : String.Format("{0,8:0,0}", tongtien);
                lblTongTien.Text = _phieu.TongTien == 0 ? "0" : String.Format("{0,8:0,0}", _phieu.TongTien);
                string tienKH = txtSoTienKHDaTra.Text.Trim();
                Int64 sotienkhtra = 0;
                if (!string.IsNullOrEmpty(tienKH) && Int64.TryParse(tienKH, out sotienkhtra))
                {
                    lblTienTraLai.Text = String.Format("{0,8:0,0}", sotienkhtra - _phieu.TongTien);
                }
                else
                {
                    lblTienTraLai.Text = "0";
                }
            }
        }

        private void txtSoTienKHDaTra_Enter(object sender, EventArgs e)
        {
            txtSoTienKHDaTra.SelectAll();
        }

        #endregion

        private void btnCatDo_Click(object sender, EventArgs e)
        {
            if (_phieu != null && _phieu.MaPhieu != 0 && bndsrcDSCTPhieu.Count > 0)
            {
                frmTraDo frm = new frmTraDo(_phieu.MaPhieu, null, _phieu.DaThanhToan);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dữ liệu trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mnuXoa.Enabled = dgvDSDo.SelectedRows.Count > 0;
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            btnXoaDo_Click(sender, e);
        }

        private void LoadDataPhieuSlotMaVach()
        {
            txtTongSoSanPham.Text = _listPhieuSlot.Count.ToString();
            if (_dungmavach)
            {
                Int64 mavachxoayvongtu = ThaoTacIniMaVach.ReadMaVachBatDau();
                Int64 mavachxoayvongden = ThaoTacIniMaVach.ReadMaVachKetThuc();
                Int64 mavach;
                if (Int64.TryParse(txtMaVachDauTien.Text, out mavach))
                {
                    for (int i = 0; i < _listPhieuSlot.Count; i++)
                    {
                        _listPhieuSlot[i].MaVach = mavach;
                        mavach += 1;
                        if (mavachxoayvongtu < mavachxoayvongden && mavach > mavachxoayvongden) mavach = mavachxoayvongtu;
                    }
                    if (_listPhieuSlot.Count > 0)
                        txtMaVachCuoi.Text = (mavach - 1).ToString();
                    else
                        txtMaVachCuoi.Text = mavach.ToString();
                }
            }
            else
            {
                for (int i = 0; i < _listPhieuSlot.Count; i++)
                {
                    _listPhieuSlot[i].MaVach = 0;
                }
                txtMaVachDauTien.Text = "";
                txtMaVachCuoi.Text = "";
                //txtMaVachCuoi.Text = txtMaVachDauTien.Text;
            }
        }

        private void chkPhiGiaoNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (_daloadxongform)
            {
                TinhTien();
            }
        }

    }
}
