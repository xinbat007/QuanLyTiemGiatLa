using System.Windows.Forms;
using System;
using Entity;
using System.Collections.Generic;
using QuanLyTiemGiatLa.HeThong;
using System.IO;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmCTPhieu : Form
    {
        // form này chỉ làm việc thêm, không cho sửa
        public OnSaved onsaved;
        private TrangThai TrangThai;
        private Boolean daloadxongform = false;
        public ListChiTietPhieuEntity _listChitietPhieu = null;// chỉ dùng list này để sửa slot
        private ListPhieuSlotEntity _listPhieuSlot = null;
        private ChiTietPhieuEntity ctphieu = null;
        private BangGiaEntity _banggia = null;
        private List<string> _listGhiChu = null;
        private string _textFile;

        public frmCTPhieu(ListPhieuSlotEntity lstPSlot, ListChiTietPhieuEntity lstCTPhieu)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(frmCTPhieu_Load);
            _listPhieuSlot = lstPSlot;
            _listChitietPhieu = lstCTPhieu;
        }

        private void frmCTPhieu_Load(object sender, System.EventArgs e)
        {
            TrangThai = this.chitietphieu == null ? TrangThai.Them : TrangThai.Sua;
            this.LoadData();
            this.LoadGhiChu();
        }

        private void LoadGhiChu()
        {
            try
            {
                _listGhiChu = new List<string>();
                _textFile = Application.StartupPath + "\\GhiChu.txt";
                if (!File.Exists(_textFile))
                {
                    return;
                }
                using (StreamReader sr = File.OpenText(_textFile))
                {
                    string input;
                    while ((input = sr.ReadLine()) != null)
                    {
                        _listGhiChu.Add(input);
                    }
                    sr.Close();
                }
                //---------------------------
                int kcghichu = Xuly.ThaoTacIniCauHinhGhiChu.ReadKCGhiChu();
                this.Width = Xuly.ThaoTacIniCauHinhGhiChu.ReadChieuNgangForm();
                pnlGhiChu.Controls.Clear();
                for (int i = 0; i < _listGhiChu.Count; i++)
                {
                    int cot = i / 6;
                    int dong = i % 6;
                    CheckBox checkBox = new CheckBox();
                    checkBox.AutoSize = true;
                    checkBox.Location = new System.Drawing.Point(3 + cot * kcghichu, 11 + dong * 30);//41
                    checkBox.Name = "chkGhiChu" + i;
                    checkBox.Size = new System.Drawing.Size(106, 24);
                    checkBox.TabIndex = i;
                    checkBox.Text = _listGhiChu[i];
                    checkBox.UseVisualStyleBackColor = true;
                    checkBox.BackColor = System.Drawing.Color.Transparent;
                    checkBox.CheckedChanged += new System.EventHandler(checkBoxGhiChu_CheckChanged);
                    pnlGhiChu.Controls.Add(checkBox);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxGhiChu_CheckChanged(object sender, EventArgs e)
        {
            LoadTextGhiChu();
        }

        private void LoadTextGhiChu()
        {
            String ghichu = String.Empty;
            if (chkTreEm.Checked && chkGiatNhanh.Checked)
                ghichu = "trẻ em, giặt nhanh";
            else if (chkTreEm.Checked)
                ghichu = "trẻ em";
            else if (chkGiatNhanh.Checked)
                ghichu = "giặt nhanh";
            else
                ghichu = "";
            for (int i = 0; i < pnlGhiChu.Controls.Count; i++)
            {
                CheckBox chk = pnlGhiChu.Controls[i] as CheckBox;
                if (chk != null && chk.Checked)
                {
                    ghichu += ", " + chk.Text.ToLower();
                }
            }
            if (ghichu.StartsWith(", ")) ghichu = ghichu.Remove(0, 2);
            if (ghichu.Length > 1)
                ghichu = ghichu.Substring(0, 1).ToUpper() + ghichu.Substring(1, ghichu.Length - 1);
            txtGhiChu.Text = ghichu;
        }

        private void frmCTPhieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            onsaved();
        }

        private void LoadData()
        {
            daloadxongform = false;
            if (TrangThai == TrangThai.Them)
            {
                txtSoLuong.Text = "1";
            }
            daloadxongform = true;
            if (TrangThai == TrangThai.Sua)
            {
                Entity.ChiTietPhieuEntity ct = bndsrcCTPhieu.DataSource as Entity.ChiTietPhieuEntity;
                txtTenHang.Text = ct.TenHang;
                txtKieuGiat.Text = ct.TenKieuGiat;
                txtSoLuong.Text = ct.Soluong.ToString();
                txtDonGia.Text = ct.DonGia.ToString();
                //banggia = Business.BangGiaBO.SelectByMaHangMaKieuGiat(ct.MaHang, ct.MaKieuGiat);
            }
        }

        public Entity.ChiTietPhieuEntity chitietphieu
        {
            set
            {
                bndsrcCTPhieu.DataSource = value;
                ctphieu = value;
            }
            get
            {
                return bndsrcCTPhieu.DataSource as Entity.ChiTietPhieuEntity;
            }
        }

        #region sau khi lấy đồ thì được banggia

        private frmLayDoNhanh frmLaydo = null;

        public void btnLayDoNhanh_Click(object sender, EventArgs e)
        {
            if (frmLaydo == null || frmLaydo.IsDisposed)
                frmLaydo = new frmLayDoNhanh();
            _banggia = frmLaydo.ShowForm();
            if (_banggia != null)
            {
                txtDonGia.Text = _banggia.DonGia.ToString();
                txtTenHang.Text = _banggia.TenHang;
                txtKieuGiat.Text = _banggia.TenKieuGiat;
                txtSoLuong.Focus();
            }
            else
            {
                txtTenHang.Text = String.Empty;
                txtKieuGiat.Text = String.Empty;
                txtDonGia.Text = "0";
            }
        }

        #endregion

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!this.CheckForm()) return;
            ctphieu = new Entity.ChiTietPhieuEntity();
            //ctphieu.MaPhieu = ctphieu.MaPhieu;
            ctphieu.MaHang = _banggia.MaHang;
            ctphieu.MaKieuGiat = _banggia.MaKieuGiat;
            ctphieu.TenHang = txtTenHang.Text;
            ctphieu.TenKieuGiat = txtKieuGiat.Text;
            ctphieu.DonGia = TinhDonGia(_banggia.DonGia);
            ctphieu.Soluong = Int32.Parse(txtSoLuong.Text);
            ctphieu.GhiChu = txtGhiChu.Text.Trim();
            if (TrangThai == TrangThai.Them)
            {
                //ctphieu.IDChiTietPhieu = Business.ChiTietPhieuBO.Insert(ctphieu);
                _listChitietPhieu.Add(ctphieu);
                this.ThemPhieuSlot(ctphieu);
                onsaved();
                btnLayDoNhanh.Focus();
                txtTenHang.Text = String.Empty;
                txtKieuGiat.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
                txtSoLuong.Text = "1";
                txtDonGia.Text = "0";
                chkTreEm.Checked = false;
                chkGiatNhanh.Checked = false;
                for (int i = 0; i < pnlGhiChu.Controls.Count; i++)
                {
                    var chk = pnlGhiChu.Controls[i] as CheckBox;
                    if (chk != null) chk.Checked = false;
                }
                _banggia = null;
            }
        }

        private int FindMax()
        {
            int sttmax = 0;
            foreach (PhieuSlotEntity pslot in _listPhieuSlot)
            {
                sttmax = sttmax > pslot.STT ? sttmax : pslot.STT;
            }
            return sttmax;
        }

        private void ThemPhieuSlot(ChiTietPhieuEntity ctp)
        {
            //int sttmax = FindMax();
            var phieuSlotMoi = new ListPhieuSlotEntity();
            for (int i = 0; i < ctp.Soluong; i++)
            {
                for (int k = 0; k < _banggia.SoSanPham; k++)
                {
                    phieuSlotMoi.Add(new PhieuSlotEntity()
                    {
                        //MaPhieu = ctp.MaPhieu,
                        //STT = ++sttmax,
                        MaHang = ctp.MaHang,
                        MaKieuGiat = ctp.MaKieuGiat,
                        TenHang = ctp.TenHang,
                        TenKieuGiat = ctp.TenKieuGiat,
                        GhiChu = ctp.GhiChu,
                        Kho = String.Empty,
                        Slot = 0,
                        DaTra = false,
                        SoHieuSanPham = _banggia.SoSanPham == 1 ? "" :
                                        String.Format("{0}/{1}", k + 1, _banggia.SoSanPham)
                    });
                }
            }
            if (phieuSlotMoi.Count > 0)
            {
                //Business.PhieuSlotBO.Insert(phieuSlotMoi);
                _listPhieuSlot.AddRange(phieuSlotMoi.ToArray());
                int i = 0;
                while (i < _listPhieuSlot.Count)
                {
                    _listPhieuSlot[i].STT = ++i;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Chức năng linh tinh

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, chkTreEm);
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGhi_Click(sender, e);
        }

        private Int64 TinhDonGia(Int64 dongia)
        {
            Int32 giamgiatreem = chkTreEm.Checked ? Xuly.ThaoTacIniCauHinhPhanMem.ReadTreEmGiamGia() : 0;
            Int32 tanggiagiatnhanh = chkGiatNhanh.Checked ? Xuly.ThaoTacIniCauHinhPhanMem.ReadGiatNhanhTangGia() : 0;
            Int64 tiensaugiamgiatreem = dongia - Xuly.Xuly.TinhTienGiamGia(dongia, giamgiatreem);
            Int64 tiensautanggiagiatnhanh = tiensaugiamgiatreem + Xuly.Xuly.TinhTienTangGia(tiensaugiamgiatreem, tanggiagiatnhanh);
            return tiensautanggiagiatnhanh;
        }

        private void LoadDonGia()
        {
            if (_banggia != null)
            {
                txtDonGia.Text = TinhDonGia(_banggia.DonGia).ToString();
                LoadTextGhiChu();
            }
        }

        private void chkTreEm_CheckedChanged(object sender, EventArgs e)
        {
            LoadDonGia();
        }

        private void chkGiatNhanh_CheckedChanged(object sender, EventArgs e)
        {
            LoadDonGia();
        }

        private void chkTreEm_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, chkGiatNhanh);
        }

        private void chkGiatNhanh_KeyDown(object sender, KeyEventArgs e)
        {
            Xuly.Xuly.ControlFocus(e, pnlGhiChu);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            this.LoadThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            this.LoadThanhTien();
        }

        private void LoadThanhTien()
        {
            if (!daloadxongform) return;
            Int32 soluong;
            Int64 dongia;
            if (Int32.TryParse(txtSoLuong.Text, out soluong))
            {
                if (Int64.TryParse(txtDonGia.Text, out dongia))
                {
                    txtThanhTien.Text = (soluong * dongia).ToString();
                }
            }
        }

        private Boolean CheckForm()
        {
            if (_banggia == null)
            {
                btnLayDoNhanh.Focus();
                MessageBox.Show("Bạn chưa chọn đồ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                txtSoLuong.Focus();
                MessageBox.Show("Số lượng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Int32 sl;
            if (!Int32.TryParse(txtSoLuong.Text, out sl))
            {
                txtSoLuong.Focus();
                MessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sl <= 0)
            {
                txtSoLuong.Focus();
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return true;
        }

        #endregion

        private void btnCauHinhGhiChu_Click(object sender, EventArgs e)
        {
            var f = new frmCauHinhGhiChu(_listGhiChu, _textFile);
            f.ShowDialog();
            this.LoadGhiChu();
        }

    }
}
