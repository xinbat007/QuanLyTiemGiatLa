using System;
using System.Windows.Forms;
using Entity;
using QuanLyTiemGiatLa.Danhmuc;

namespace QuanLyTiemGiatLa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BienChung.isTrienKhai = false;
            if (true == BienChung.isTrienKhai)
            {
                if (!KiemTraBanQuyen()) return;
                KhoiDongTimer();
            }
            Xuly.Xuly.LoadConfig();
            Xuly.ThaoTacIniCauHinhPhanMem.ReadToanManHinh();
            QuanLyTiemGiatLa.HeThong.frmLogin _frmLogin = new QuanLyTiemGiatLa.HeThong.frmLogin();
            if (_frmLogin.ShowDialog() == DialogResult.OK)
            {
                //Application.Run(new frmDSPhieu());
                Application.Run(new frmMain());
            }
        }

        private const Int32 sogiayupdate1lan = 60000;   //1 (phut) thì update lại số phút sử dụng
        private static void KhoiDongTimer()
        {
            try
            {
                if (!BienChung.DaMuaFull && BienChung.DuocPhepSuDung)
                {
                    Timer timer = new Timer();
                    timer.Interval = sogiayupdate1lan;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                BienChung.checkKey.SoPhutConLai -= sogiayupdate1lan / 60000;// nếu 5' tức 300.000ms/60.000ms = 5
                BienChung.checkKey.SoPhutConLaiMaHoa = DangKySuDungPhanMem.Encrypt(BienChung.checkKey.SoPhutConLai.ToString());
                Xuly.ThaoTacIniBanQuyen.WriteSoPhut(BienChung.checkKey.SoPhutConLaiMaHoa);
                if (BienChung.checkKey.SoPhutConLai <= 0)
                {
                    Timer timer = (Timer)sender;
                    timer.Stop();
                    MessageBox.Show("Bạn đã hết hạn sử dụng phần mềm, hãy đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BienChung.DuocPhepSuDung = false;
                    HeThong.frmDangKySuDungPhanMem frmDangKy = new QuanLyTiemGiatLa.HeThong.frmDangKySuDungPhanMem();
                    frmDangKy.ShowDialog();
                    if (BienChung.DaMuaFull)
                    {
                        timer.Dispose();
                    }
                    else if (BienChung.DuocPhepSuDung)
                    {
                        timer.Start();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (System.Exception ex)
            {
                Timer timer = (Timer)sender;
                timer.Stop();
                timer.Dispose();
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool KiemTraBanQuyen()
        {
            try
            {
                String idcpu = DangKySuDungPhanMem.taoID();
                CheckKeyEntity checkKey = Xuly.ThaoTacIniBanQuyen.Read();
                BienChung.checkKey = checkKey;
                BienChung.DaMuaFull = false;
                BienChung.DuocPhepSuDung = false;
                if (String.IsNullOrEmpty(checkKey.IDCPU))
                {
                    // ghi cho phép s/d 30 ngày, mỗi ngày 14 tiếng
                    DangKySuDungPhanMem.GhiThoiHanSuDung(idcpu, 30, false, 0);
                    MessageBox.Show("Bạn được sử dụng phần mềm " + 30 + " ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BienChung.DuocPhepSuDung = true;
                    return true;
                }
                else
                {
                    if (idcpu != checkKey.IDCPU)
                    {
                        MessageBox.Show("Số hiệu IDCPU không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    string[] s = DangKySuDungPhanMem.GiaimaSangmangString(checkKey.DaMuaFull);// 20 ki tu + '$' + bool (da full) + '$' + 7 ki tu
                    if (s.Length != 3)
                    {
                        MessageBox.Show("Định dạng mã hóa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (s[1] == "1")
                    {
                        BienChung.DaMuaFull = true;
                        BienChung.DuocPhepSuDung = true;
                        return true;
                    }
                    BienChung.DaMuaFull = false;
                    if (checkKey.SoPhutConLai > 0)
                    {
                        if (MessageBox.Show("Bạn còn " + Xuly.Xuly.DocPhutSangNgayGio(checkKey.SoPhutConLai) +
                            "\nBạn có muốn đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            HeThong.frmDangKySuDungPhanMem frmDangKy = new QuanLyTiemGiatLa.HeThong.frmDangKySuDungPhanMem();
                            frmDangKy.ShowDialog();
                        }
                        BienChung.DuocPhepSuDung = true;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã hết hạn sử dụng phần mềm, hãy đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        HeThong.frmDangKySuDungPhanMem frmDangKy = new QuanLyTiemGiatLa.HeThong.frmDangKySuDungPhanMem();
                        frmDangKy.ShowDialog();
                        return false;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
