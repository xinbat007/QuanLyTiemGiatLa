using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using Business;
using QuanLyTiemGiatLa.Danhmuc;
using QuanLyTiemGiatLa.HeThong;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Timers;
using QuanLyTiemGiatLa.Xuly;
using Entity;
using System.Threading;

namespace QuanLyTiemGiatLa
{
    public delegate void OnSaved();
    public delegate void NoticeSyncOnline();

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
            this.tsslbPhienBan.Text = "Phiên bản ngày 19/03/2019";
            this.label1.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadTenCuaHang();
            this.label2.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadDiaChiCuaHang();
            this.label3.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadSoDienThoai();
            this.tslSyncMessage.Text = "";
            this.tspSyncProgress.Visible = false;
            this.KhoiDongTimerAutoBackup();
            this.InitTimerAutoSyncOnline();
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
                _frmLapPhieu.m_notice += startThreadSyncOnline;
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

        private void KhoiDongTimerAutoBackup()
        {
            try
            {
                System.Timers.Timer m_timerAutoBackup;
                Xuly.ThaoTacIniBackup iniBackup = new QuanLyTiemGiatLa.Xuly.ThaoTacIniBackup();
                iniBackup.Read();
                if (!String.IsNullOrEmpty(iniBackup.DuongDanLuuThuMucFileBackup))
                {
                    int elapseTime = calculateElapseTimeToSync(iniBackup.ThoiGianTuDongBackUp);
                    m_timerAutoBackup = new System.Timers.Timer();
                    m_timerAutoBackup.AutoReset = false;
                    m_timerAutoBackup.Interval = elapseTime;
                    m_timerAutoBackup.Elapsed += new ElapsedEventHandler(delegate (object s, ElapsedEventArgs e)
                    {
                        try
                        {
                            m_timerAutoBackup.Stop();
                            m_timerAutoBackup.Dispose();
                            int result = Xuly.Xuly.AutoBackup(iniBackup.DuongDanLuuThuMucFileBackup, iniBackup.DuongDanLuuThuMucCopyTo);
                            if (result == 1)
                            {
                                MessageBox.Show("Không copy được sang thư mục: " + iniBackup.DuongDanLuuThuMucCopyTo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (System.Exception ex)
                        {
                            m_timerAutoBackup.Stop();
                            m_timerAutoBackup.Dispose();
                            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                    m_timerAutoBackup.Start();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int calculateElapseTimeToSync(int hourToSync)
        {
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;
            Console.WriteLine("Current time is: " + currentHour + ":" + currentMinute);
            int elapseTime = 0;
            if (currentHour < hourToSync)
            {
                int elapseMinuteToNextHour = (60 - currentMinute) * 60 * 1000;
                int elapseHour = (hourToSync - currentHour - 1) * 60 * 60 * 1000;
                elapseTime = elapseMinuteToNextHour + elapseHour;
            }
            else
            {
                int elapseMinuteToNextHour = (60 - currentMinute) * 60 * 1000;
                int elapseTimeTo24h = (24 - currentHour - 1) * 60 * 60 * 1000;
                int elapseTimeHour = hourToSync * 60 * 60 * 1000;
                elapseTime = elapseMinuteToNextHour + elapseTimeTo24h + elapseTimeHour;
            }
            int hourWait = elapseTime / (60 * 60 * 1000);
            int minuteWait = (elapseTime - (hourWait * 60 * 60 * 1000)) / (1000 * 60);
            Console.WriteLine("Wait " + hourWait + " hour " + minuteWait + " minute to trigger!");
            return elapseTime;
        }

        private static System.Timers.Timer m_timerAutoSync;
        private void InitTimerAutoSyncOnline()
        {
            try
            {
                int typeAutoSync = Properties.Settings.Default.AutoSync;
                switch (typeAutoSync)
                {
                    case 0:
                        System.Console.WriteLine("Config ko sync");
                        break;
                    case 1:
                        int elapseTime = calculateElapseTimeToSync(Properties.Settings.Default.HourAutoSync);
                        if (isTest)
                            elapseTime = 2000;
                        m_timerAutoSync = new System.Timers.Timer();
                        m_timerAutoSync.Interval = elapseTime;
                        m_timerAutoSync.Elapsed += OnTimedAutoSync;
                        m_timerAutoSync.AutoReset = false;
                        m_timerAutoSync.Start();
                        break;
                    case 2:
                        System.Console.WriteLine("Cấu hình sync mỗi khi tạo xong phiếu");
                        break;
                    default:
                        System.Console.WriteLine("Ko biết cấu hình kiểu gì luôn");
                        break;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isTest = false;
        private ListKhachHangEntity listCustomers = null;
        private int countCustomerSync = 0;
        private ListPhieuEntity listPhieuSync = null;
        private int countPhieuSync = 0;
        private bool m_isSyncing = false;

        private void startThreadSyncOnline()
        {
            int typeAutoSync = Properties.Settings.Default.AutoSync;
            if (typeAutoSync == 2)
            {
                Thread thread = new Thread(new ThreadStart(noticeSyncOnline));
                thread.Start();
            }
        }
        
        private void noticeSyncOnline()
        {
            if (m_isSyncing)
            {
                return;
            }
            m_isSyncing = true;
            // ===================================
            // 0: check internet connection
            // 1: login
            // 2: lấy tất cả khách hàng chưa sync
            // 3: sync khách hàng trc
            // 4: lấy tất cả phiếu chưa sync
            // 5: sync phiếu
            // 6: reset screen
            // ===================================
            // Step 0
            bool hasInternet = HttpUtil.IsInternetAvailable();
            if (!hasInternet)
            {
                tslSyncMessage.Text = "Ko có kết nối mạng.";
                m_isSyncing = false;
                return;
            }
            // Step 1
            tslSyncMessage.Text = "Đang kết nối vào server";
            string pathServer = Properties.Settings.Default.PathServerSync;
            string userNameServerSync = Properties.Settings.Default.UserNameServerSync;
            string passwordServerSync = Properties.Settings.Default.PasswordServerSync;
            if (!isTest)
            {
                ResultHttp result = HttpUtil.Login(pathServer, userNameServerSync, passwordServerSync);
                if (result.Code != "200")
                {
                    tslSyncMessage.Text = "Không thể kết nối vào server online. Dừng đồng bộ.";
                    tslSyncMessage.ForeColor = Color.Red;
                    m_isSyncing = false;
                    return;
                }
            }
            // Step 2
            tslSyncMessage.ForeColor = Color.Black;
            tslSyncMessage.Text = "Đang lấy dữ liệu khách hàng chưa đồng bộ";
            listCustomers = Business.KhachHangBO.SelectCustomerNotSync();
            // Step 3 
            int countSuccessCustomer = 0;
            this.SyncCustomers(pathServer, ref countSuccessCustomer);
            // Step 4
            tslSyncMessage.Text = "Đang lấy dữ liệu phiếu chưa đồng bộ";
            listPhieuSync = Business.PhieuBO.SelectOrderNotSync();
            // Step 5
            int countSuccessOrder = 0;
            this.SyncOrders(pathServer, ref countSuccessOrder);
            // Step 6
            tslSyncMessage.Text = "Đã đồng bộ xong " + countSuccessCustomer + "/" + countCustomerSync +
                " khách hàng, " + countSuccessOrder + "/" + countPhieuSync +
                " phiếu. Chi tiết xem ở '" + Const.PATH_LOG_SYNC_CUSTOMERS + "' và '" + Const.PATH_LOG_SYNC_ORDERS + "'";
            tspSyncProgress.Visible = false;
            m_isSyncing = false;
        }

        private void OnTimedAutoSync(Object source, ElapsedEventArgs e)
        {
            m_timerAutoSync.Stop();
            m_timerAutoSync.Dispose();
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
            this.noticeSyncOnline();
        }

        private void SyncOrders(String baseUrl, ref int countSuccess)
        {
            StreamWriter sw = new StreamWriter(Const.PATH_LOG_SYNC_ORDERS);
            try
            {
                countPhieuSync = isTest ? 50 : listPhieuSync.Count;
                //================
                tspSyncProgress.Minimum = 0;
                tspSyncProgress.Maximum = countPhieuSync;
                tspSyncProgress.Value = 0;
                tspSyncProgress.Visible = true;
                //================
                for (int i = 0; i < countPhieuSync; i++)
                {
                    bgwSyncOrders_ProgressChanged(i, countPhieuSync);
                    if (isTest)
                    {
                        Thread.Sleep(100); countSuccess++;
                    }
                    else
                    {
                        HttpUtil.SyncPhieu(baseUrl, listPhieuSync[i], sw, ref countSuccess);
                    }
                }
                bgwSyncOrders_ProgressChanged(countPhieuSync, countPhieuSync);
                tspSyncProgress.Visible = false;
            }
            catch
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }

        private void bgwSyncOrders_ProgressChanged(int i, int countPhieuSync)
        {
            tslSyncMessage.Text = "Đang đồng bộ " + i + " / " + countPhieuSync + " phiếu";
            tspSyncProgress.Value = i;
        }

        private void SyncCustomers(String baseUrl, ref int countSuccess)
        {
            StreamWriter sw = new StreamWriter(Const.PATH_LOG_SYNC_CUSTOMERS);
            try
            {
                tslSyncMessage.Text = "Đang đồng bộ khách hàng";
                countCustomerSync = isTest ? 50 : listCustomers.Count;
                //================
                tspSyncProgress.Minimum = 0;
                tspSyncProgress.Maximum = countCustomerSync;
                tspSyncProgress.Value = 0;
                tspSyncProgress.Visible = true;
                //================
                for (int i = 0; i < countCustomerSync; i++)
                {
                    bgwSyncCustomers_ProgressChanged(i, countCustomerSync);
                    if (isTest)
                    {
                        Thread.Sleep(100); countSuccess++;
                    }
                    else
                    {
                        HttpUtil.SyncCustomer(baseUrl, listCustomers[i], sw, ref countSuccess);
                    }
                }
                bgwSyncCustomers_ProgressChanged(countCustomerSync, countCustomerSync);
                tspSyncProgress.Visible = false;
            }
            catch
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }

        private void bgwSyncCustomers_ProgressChanged(int i, int countCustomerSync)
        {
            tslSyncMessage.Text = "Đang đồng bộ " + i + " / " + countCustomerSync + " khách hàng";
            tspSyncProgress.Value = i;
        }
    }
}
