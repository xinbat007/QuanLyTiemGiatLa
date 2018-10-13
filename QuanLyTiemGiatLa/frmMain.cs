using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using Business;
using QuanLyTiemGiatLa.Danhmuc;
using QuanLyTiemGiatLa.HeThong;
using Newtonsoft.Json;

namespace QuanLyTiemGiatLa
{
    public delegate void OnSaved();

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmMain_Load);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadQuyenButton();
            this.LoadMauTrangThaiDo();
            this.KhoiDongTimerAutoBackup();
            this.tsslbPhienBan.Text = "Phiên bản ngày 30/09/2018";
            this.label1.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadTenCuaHang();
            this.label2.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadDiaChiCuaHang();
            this.label3.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadSoDienThoai();
        }

        private void LoadMauTrangThaiDo()
        {
            BienChung.mautrangthaido = Xuly.ThaoTacIniCauHinhPhanMem.ReadMauTrangThaiDo();
        }

        private void Enable1Button(char c, Button btn)
        {
            btn.Enabled = c == '1';
        }

        private void Enable1Menuitem(char c, ToolStripMenuItem mnu)
        {
            mnu.Enabled = c == '1';
        }

        private void LoadQuyenButton()
        {
            if (BienChung.userCurrent == null) {
                return;
            }
            lblUser.Text = BienChung.userCurrent.UserName;
            foreach (Control item in this.Controls)
            {
                if (item is Button) item.Enabled = true;
            }
            if (BienChung.userCurrent.UserName == "admin")
            {   // ko làm gì cả, enable tất cả button
            }
            else
            {
                if (BienChung.userCurrent.QuyenHan.Length == 17)
                {
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.BangChotKet], btnDSChotKet);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.BangGia], btnBangGia);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.CatDo], btnCatDo);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.CauHinh], btnCauHinhHeThong);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.DanhSachPhieu], btnDanhSachPhieu);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.DoiMatKhau], btnDoiMatKhau);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.DotGiamGia], btnDotGiamGia);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.GiaDeDo], btnCauHinhGiaDeDo);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.KieuGiat], btnKieuGiat);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.KhachHang], btnKhachHang);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.LapPhieu], btnLapPhieu);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.LoaiHang], btnLoaiHang);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.LoaiKhachHang], btnMucDoVip);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.MatHang], btnMatHang);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.NhanVien], btnNhanVien);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.NhungViecCanLam], btnNhungViecCanLam);
                    Enable1Button(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.ThongKeThuNhap], btnThongKeThuNhap);
                    Enable1Menuitem(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.DanhSachPhieu], danhSachPhieuToolStripMenuItem);
                    Enable1Menuitem(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.LapPhieu], lapPhieuToolStripMenuItem);
                    Enable1Menuitem(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.NhungViecCanLam], nhungViecCanLamToolStripMenuItem);
                    Enable1Menuitem(BienChung.userCurrent.QuyenHan[(Int32)ThuTuButton.CatDo], catDoToolStripMenuItem);
                }
                else
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button) item.Enabled = false;
                    }
                    btnDangXuat.Enabled = true;
                }
            }
        }

        frmDSKhachHang _frmDSKhachHang = null;
        frmDSLoaiHang _frmDSLoaiHang = null;
        frmDSMatHang _frmDSMatHang = null;
        frmDSGiaDeDo _frmDSGiaDeDo = null;
        frmLapPhieu _frmLapPhieu = null;
        frmDSKieuGiat _frmDSKieuGiat = null;
        frmDSBangGia _frmDSBangGia = null;
        frmDSPhieu _frmDSPhieu = null;
        frmDSDotGiamGia _frmDSDotGiamGia = null;
        frmDoanhThuCuaTiem _frmDoanhThuCuaTiem = null;
        frmDSMucDoVip _frmDSMucDoVip = null;
        frmDSViecCanLam _frmDSViecCanLam = null;
        frmDSNhanVien _frmDSNhanVien = null;
        frmDoiMatKhau _frmDoiMatKhau = null;
        frmThongKeTheoNhanVien _frmThongKeTheoNhanVien = null;
        frmCauHinhHeThong _frmCauHinhHeThong = null;
        frmDSChotKet _frmDSChotKet = null;
        frmCatDo _frmCatDo = null;

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (_frmDSKhachHang == null || _frmDSKhachHang.IsDisposed)
            {
                _frmDSKhachHang = new frmDSKhachHang();
                _frmDSKhachHang.Show(this);
            }
            else _frmDSKhachHang.Activate();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            if (_frmDSLoaiHang == null || _frmDSLoaiHang.IsDisposed)
            {
                _frmDSLoaiHang = new frmDSLoaiHang();
                _frmDSLoaiHang.Show(this);
            }
            else _frmDSLoaiHang.Activate();
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            if (_frmDSMatHang == null || _frmDSMatHang.IsDisposed)
            {
                _frmDSMatHang = new frmDSMatHang();
                _frmDSMatHang.Show(this);
            }
            else _frmDSMatHang.Activate();
        }

        private void btnCauHinhGiaDeDo_Click(object sender, EventArgs ev)
        {
            if (_frmDSGiaDeDo == null || _frmDSGiaDeDo.IsDisposed)
            {
                _frmDSGiaDeDo = new frmDSGiaDeDo();
                _frmDSGiaDeDo.Show(this);
            }
            else _frmDSGiaDeDo.Activate();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (_frmLapPhieu == null || _frmLapPhieu.IsDisposed)
            {
                _frmLapPhieu = new frmLapPhieu();
                _frmLapPhieu.Show(this);
            }
            else _frmLapPhieu.Activate();
        }

        private void btnKieuGiat_Click(object sender, EventArgs e)
        {
            if (_frmDSKieuGiat == null || _frmDSKieuGiat.IsDisposed)
            {
                _frmDSKieuGiat = new frmDSKieuGiat();
                _frmDSKieuGiat.Show(this);
            }
            else _frmDSKieuGiat.Activate();
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            if (_frmDSBangGia == null || _frmDSBangGia.IsDisposed)
            {
                _frmDSBangGia = new frmDSBangGia();
                _frmDSBangGia.Show(this);
            }
            else _frmDSBangGia.Activate();
        }

        private void btnDanhSachPhieu_Click(object sender, EventArgs e)
        {
            if (_frmDSPhieu == null || _frmDSPhieu.IsDisposed)
            {
                _frmDSPhieu = new frmDSPhieu();
                _frmDSPhieu.Show(this);
            }
            else _frmDSPhieu.Activate();
        }

        private void btnDotGiamGia_Click(object sender, EventArgs e)
        {
            if (_frmDSDotGiamGia == null || _frmDSDotGiamGia.IsDisposed)
            {
                _frmDSDotGiamGia = new frmDSDotGiamGia();
                _frmDSDotGiamGia.Show(this);
            }
            else _frmDSDotGiamGia.Activate();
        }

        private void btnThongKeThuNhap_Click(object sender, EventArgs e)
        {
            if (_frmDoanhThuCuaTiem == null || _frmDoanhThuCuaTiem.IsDisposed)
            {
                _frmDoanhThuCuaTiem = new frmDoanhThuCuaTiem();
                _frmDoanhThuCuaTiem.Show(this);
            }
            else _frmDoanhThuCuaTiem.Activate();
        }

        private void btnMucDoVip_Click(object sender, EventArgs e)
        {
            if (_frmDSMucDoVip == null || _frmDSMucDoVip.IsDisposed)
            {
                _frmDSMucDoVip = new frmDSMucDoVip();
                _frmDSMucDoVip.Show(this);
            }
            else _frmDSMucDoVip.Activate();
        }

        private void btnNhungViecCanLam_Click(object sender, EventArgs e)
        {
            if (_frmDSViecCanLam == null || _frmDSViecCanLam.IsDisposed)
            {
                _frmDSViecCanLam = new frmDSViecCanLam();
                _frmDSViecCanLam.Show(this);
                _frmDSViecCanLam.focusMaPhieu();
            }
            else _frmDSViecCanLam.Activate();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.OwnedForms.Length; i++)
            {
                this.OwnedForms[i].Close();
            }
            frmLogin _frmLogin = new frmLogin();
            if (_frmLogin.ShowDialog() == DialogResult.OK)
            {
                LoadQuyenButton();
            }
            else
            {
                this.Close();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (_frmDSNhanVien == null || _frmDSNhanVien.IsDisposed)
            {
                _frmDSNhanVien = new frmDSNhanVien();
                _frmDSNhanVien.Show(this);
            }
            else _frmDSNhanVien.Activate();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (_frmDoiMatKhau == null || _frmDoiMatKhau.IsDisposed)
            {
                _frmDoiMatKhau = new frmDoiMatKhau();
                _frmDoiMatKhau.Show(this);
            }
            else _frmDoiMatKhau.Activate();
        }

        private void btnThongKeTheoNhanVien_Click(object sender, EventArgs e)
        {
            if (_frmThongKeTheoNhanVien == null || _frmThongKeTheoNhanVien.IsDisposed)
            {
                _frmThongKeTheoNhanVien = new frmThongKeTheoNhanVien();
                _frmThongKeTheoNhanVien.Show(this);
            }
            else _frmThongKeTheoNhanVien.Activate();
        }

        private void btnCauHinhHeThong_Click(object sender, EventArgs e)
        {
            if (_frmCauHinhHeThong == null || _frmCauHinhHeThong.IsDisposed)
            {
                _frmCauHinhHeThong = new frmCauHinhHeThong();
                _frmCauHinhHeThong.Show(this);
            }
            else _frmCauHinhHeThong.Activate();
        }

        private void btnDSChotKet_Click(object sender, EventArgs e)
        {
            if (_frmDSChotKet == null || _frmDSChotKet.IsDisposed)
            {
                _frmDSChotKet = new frmDSChotKet();
                _frmDSChotKet.Show(this);
            }
            else _frmDSChotKet.Activate();
        }

        private void btnCatDo_Click(object sender, EventArgs e)
        {
            if (_frmCatDo == null || _frmCatDo.IsDisposed)
            {
                _frmCatDo = new frmCatDo();
                _frmCatDo.Show(this);
                _frmCatDo.focusMa();
            }
            else _frmCatDo.Activate();
        }

        private void danhSachPhieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDanhSachPhieu_Click(sender, e);
        }

        private void lapPhieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLapPhieu_Click(sender, e);
        }

        private void nhungViecCanLamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNhungViecCanLam_Click(sender, e);
        }

        private void catDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCatDo_Click(sender, e);
        }

        private Timer _timerAutoBackup;
        private void KhoiDongTimerAutoBackup()
        {
            try
            {
                Xuly.ThaoTacIniBackup iniBackup = new QuanLyTiemGiatLa.Xuly.ThaoTacIniBackup();
                iniBackup.Read();
                if (!String.IsNullOrEmpty(iniBackup.DuongDanLuuThuMucFileBackup))
                {
                    _timerAutoBackup = new Timer();
                    _timerAutoBackup.Interval = 900000;//15 phut * 60 = 900 giay * 1000 = 900.000
                    _timerAutoBackup.Tick += new EventHandler(delegate (object s, EventArgs e)
                    {
                        try
                        {
                            if (DateTime.Now.Hour == iniBackup.ThoiGianTuDongBackUp)
                            {
                                _timerAutoBackup.Stop();
                                _timerAutoBackup.Dispose();
                                int result = Xuly.Xuly.AutoBackup(iniBackup.DuongDanLuuThuMucFileBackup, iniBackup.DuongDanLuuThuMucCopyTo);
                                if (result == 1)
                                {
                                    MessageBox.Show("Không copy được sang thư mục: " + iniBackup.DuongDanLuuThuMucCopyTo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            _timerAutoBackup.Stop();
                            _timerAutoBackup.Dispose();
                            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                    _timerAutoBackup.Start();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
