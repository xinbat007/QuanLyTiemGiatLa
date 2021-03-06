using System.Text;
using System.Runtime.InteropServices;
using System;
using Entity;
using System.Drawing;

namespace QuanLyTiemGiatLa.Xuly
{
    public class ThaoTacIniCauHinhPhanMem
    {
        private static string _Section = "CauHinhPhanMem";
        private static string _KeyTreEmGiamGia = "TreEmGiamGia";
        private static string _KeyGiatNhanhTangGia = "GiatNhanhTangGia";
        private static string _KeyPhiVanChuyen = "PhiVanChuyen";
        private static string _KeyNgayLapNgayHenTraCachNhau = "NgayLapNgayHenTra";
        private static string _KeyViecCanLamCachNhau = "ViecCanLam";
        private static string _KeyCatDoFocus = "CatDoFocus"; // 0:mã phiếu, 1:mã vạch
        private static string _KeySoLanIn = "SoLanIn";
        private static string _KeyTenCuaHang = "TenCuaHang";
        private static string _KeyDiaChiCuaHang = "DiaChiCuaHang";
        private static string _KeySoDienThoai = "SoDienThoai";
        private static string _KeyMauDoChuaGiat = "MauDoChuaGiat";
        private static string _KeyMauDoDaGiat = "MauDoDaGiat";
        private static string _KeyMauDoGhiChu = "MauDoGhiChu";
        private static string _KeyMauDoDaTra = "MauDoDaTra";
        private static string _KeyMauPhieuHuy = "MauPhieuHuy";
        private static string _KeyDungMaVach = "DungMaVach";
        private static string _KeyToanManHinh = "ToanManHinh";

        public static void Write(Int32 treemgiamgia, Int32 giatnhanhtanggia, Int32 phivanchuyen, Int32 ngaylapngayhentra, Int32 vieccanlam, Int32 catdofocus, Int32 solanin, string tencuahang, string diachicuahang, string dienthoaicuahang, MauTrangThaiDo mauttdo, bool dungmavach, bool toanmanhinh)
        {
            Ini.WriteValue(_Section, _KeyTreEmGiamGia, treemgiamgia.ToString());
            Ini.WriteValue(_Section, _KeyGiatNhanhTangGia, giatnhanhtanggia.ToString());
            Ini.WriteValue(_Section, _KeyPhiVanChuyen, phivanchuyen.ToString());
            Ini.WriteValue(_Section, _KeyNgayLapNgayHenTraCachNhau, ngaylapngayhentra.ToString());
            Ini.WriteValue(_Section, _KeyViecCanLamCachNhau, vieccanlam.ToString());
            Ini.WriteValue(_Section, _KeyCatDoFocus, catdofocus.ToString());
            Ini.WriteValue(_Section, _KeySoLanIn, solanin.ToString());
            Ini.WriteValue(_Section, _KeyTenCuaHang, Xuly.UNI2VNI(tencuahang));
            Ini.WriteValue(_Section, _KeyDiaChiCuaHang, Xuly.UNI2VNI(diachicuahang));
            Ini.WriteValue(_Section, _KeySoDienThoai, Xuly.UNI2VNI(dienthoaicuahang));
            Ini.WriteValue(_Section, _KeyMauDoChuaGiat, mauttdo.ChuaGiat.ToArgb().ToString());
            Ini.WriteValue(_Section, _KeyMauDoDaGiat, mauttdo.DaGiat.ToArgb().ToString());
            Ini.WriteValue(_Section, _KeyMauDoGhiChu, mauttdo.GhiChu.ToArgb().ToString());
            Ini.WriteValue(_Section, _KeyMauDoDaTra, mauttdo.DaTra.ToArgb().ToString());
            Ini.WriteValue(_Section, _KeyMauPhieuHuy, mauttdo.PhieuHuy.ToArgb().ToString());
            Ini.WriteValue(_Section, _KeyDungMaVach, dungmavach.ToString());
            Ini.WriteValue(_Section, _KeyToanManHinh, toanmanhinh.ToString());
            BienChung.isToanManHinh = toanmanhinh;
        }

        public static Int32 ReadTreEmGiamGia()
        {
            string s = Ini.ReadValue(_Section, _KeyTreEmGiamGia);
            if (string.IsNullOrEmpty(s)) return 50;
            else
            {
                Int32 kq;
                Int32.TryParse(s, out kq);
                return kq;
            }
        }

        public static Int32 ReadGiatNhanhTangGia()
        {
            string s = Ini.ReadValue(_Section, _KeyGiatNhanhTangGia);
            if (string.IsNullOrEmpty(s)) return 100;
            else
            {
                Int32 kq;
                Int32.TryParse(s, out kq);
                return kq;
            }
        }

        public static Int32 ReadPhiVanChuyen()
        {
            string s = Ini.ReadValue(_Section, _KeyPhiVanChuyen);
            Int32 kq;
            Int32.TryParse(s, out kq);
            return kq;
        }

        public static Int32 ReadNgayLapNgayHenTra()
        {
            Int32 kq;
            Int32.TryParse(Ini.ReadValue(_Section, _KeyNgayLapNgayHenTraCachNhau), out kq);
            return kq;
        }

        public static Int32 ReadViecCanLam()
        {
            Int32 kq;
            Int32.TryParse(Ini.ReadValue(_Section, _KeyViecCanLamCachNhau), out kq);
            return kq;
        }

        public static Int32 ReadCatdoFocus()
        {
            Int32 kq;
            Int32.TryParse(Ini.ReadValue(_Section, _KeyCatDoFocus), out kq);
            return kq;
        }

        public static Int32 ReadSoLanIn()
        {
            Int32 kq;
            Int32.TryParse(Ini.ReadValue(_Section, _KeySoLanIn), out kq);
            if (kq == 0) kq = 1;
            return kq;
        }

        public static String ReadTenCuaHang()
        {
            string s = Ini.ReadValue(_Section, _KeyTenCuaHang);
            s = s == string.Empty ? "TIỆM GIẶT LÀ MR.CLEAN" : Xuly.VNI2UNI(s);
            return s;
        }

        public static String ReadDiaChiCuaHang()
        {
            string s = Ini.ReadValue(_Section, _KeyDiaChiCuaHang);
            s = s == string.Empty ? "149 Mai Hắc Đế, Hà Nội" : Xuly.VNI2UNI(s);
            return s;
        }

        public static String ReadSoDienThoai()
        {
            string s = Ini.ReadValue(_Section, _KeySoDienThoai);
            s = s == string.Empty ? "ĐT: 04.3974 9000" : Xuly.VNI2UNI(s);
            return s;
        }

        public static MauTrangThaiDo ReadMauTrangThaiDo()
        {
            string maudochuagiat = Ini.ReadValue(_Section, _KeyMauDoChuaGiat);
            string maudodagiat = Ini.ReadValue(_Section, _KeyMauDoDaGiat);
            string maudoghichu = Ini.ReadValue(_Section, _KeyMauDoGhiChu);
            string maudodatra = Ini.ReadValue(_Section, _KeyMauDoDaTra);
            string mauphieuhuy = Ini.ReadValue(_Section, _KeyMauPhieuHuy);
            maudochuagiat = maudochuagiat == string.Empty ? Color.Red.ToArgb().ToString() : maudochuagiat;
            maudodagiat = maudodagiat == string.Empty ? Color.Blue.ToArgb().ToString() : maudodagiat;
            maudoghichu = maudoghichu == string.Empty ? Color.Orange.ToArgb().ToString() : maudoghichu;
            maudodatra = maudodatra == string.Empty ? Color.Green.ToArgb().ToString() : maudodatra;
            mauphieuhuy = string.IsNullOrEmpty(mauphieuhuy) ? Color.Chocolate.ToArgb().ToString() : mauphieuhuy;
            var mauttdo = new MauTrangThaiDo();
            mauttdo.ChuaGiat = Color.FromArgb(int.Parse(maudochuagiat));
            mauttdo.DaGiat = Color.FromArgb(int.Parse(maudodagiat));
            mauttdo.GhiChu = Color.FromArgb(int.Parse(maudoghichu));
            mauttdo.DaTra = Color.FromArgb(int.Parse(maudodatra));
            mauttdo.PhieuHuy = Color.FromArgb(int.Parse(mauphieuhuy));
            return mauttdo;
        }

        public static bool ReadDungMaVach()
        {
            bool kq;
            bool.TryParse(Ini.ReadValue(_Section, _KeyDungMaVach), out kq);
            return kq;
        }

        public static bool ReadToanManHinh()
        {
            bool kq;
            bool.TryParse(Ini.ReadValue(_Section, _KeyToanManHinh), out kq);
            BienChung.isToanManHinh = kq;
            return kq;
        }
    }

    public class ThaoTacIniMaVach
    {
        private static string _Section = "CauHinhMaVach";
        private static string _KeyMaVachMax = "MaVachMax";
        private static string _KeyMaVachBatDau = "MaVachBatDau";
        private static string _KeyMaVachKetThuc = "MaVachKetThuc";

        public static void Write(Int64 mavachmax)
        {
            Ini.WriteValue(_Section, _KeyMaVachMax, mavachmax.ToString());
        }
        public static void Write(Int64 mavachbatdau, Int64 mavachketthuc)
        {
            Ini.WriteValue(_Section, _KeyMaVachBatDau, mavachbatdau.ToString());
            Ini.WriteValue(_Section, _KeyMaVachKetThuc, mavachketthuc.ToString());
        }

        public static Int64 Read()
        {
            Int64 mavachmax = 0;
            Int64.TryParse(Ini.ReadValue(_Section, _KeyMaVachMax), out mavachmax);
            return mavachmax;
        }
        public static Int64 ReadMaVachBatDau()
        {
            Int64 mavachbd = 0;
            Int64.TryParse(Ini.ReadValue(_Section, _KeyMaVachBatDau), out mavachbd);
            return mavachbd;
        }
        public static Int64 ReadMaVachKetThuc()
        {
            Int64 mavachkt = 0;
            Int64.TryParse(Ini.ReadValue(_Section, _KeyMaVachKetThuc), out mavachkt);
            return mavachkt;
        }
    }

    public class ThaoTacIniBanQuyen
    {
        private const string _Section = "BanQuyen";
        private const string _Idcpu = "IDCPU";
        private const string _SoPhutConLai = "SoPhutConLai";
        private const string _DaMuaFull = "CheckFull"; //mahoa(IDCPU + @ + Boolean(damua) + @ + 5 kitungaunhien)
        private const string _SoLanDaUpdate = "SoLanDaUpdate";

        public static void Write(string idcpu, string sophutconlai, string damuafull, string solandaupdate)
        {
            Ini.WriteValue(_Section, _Idcpu, idcpu);
            Ini.WriteValue(_Section, _SoPhutConLai, sophutconlai);
            Ini.WriteValue(_Section, _DaMuaFull, damuafull);
            Ini.WriteValue(_Section, _SoLanDaUpdate, solandaupdate);
        }

        public static void WriteSoPhut(string sophutconlai)
        {
            Ini.WriteValue(_Section, _SoPhutConLai, sophutconlai);
        }

        public static CheckKeyEntity Read()
        {
            CheckKeyEntity kq = new CheckKeyEntity()
            {
                IDCPU = Ini.ReadValue(_Section, _Idcpu),
                SoPhutConLaiMaHoa = Ini.ReadValue(_Section, _SoPhutConLai),
                DaMuaFull = Ini.ReadValue(_Section, _DaMuaFull),
                SoLanDaUpdateMaHoa = Ini.ReadValue(_Section, _SoLanDaUpdate)
            };
            kq.SoPhutConLai = Xuly.ReadInt64(DangKySuDungPhanMem.Decrypt(kq.SoPhutConLaiMaHoa));
            kq.SoLanDaUpdate = Xuly.ReadInt32(DangKySuDungPhanMem.Decrypt(kq.SoLanDaUpdateMaHoa));
            return kq;
        }
    }

    public class ThaoTacIniBackup
    {
        public string DuongDanLuuThuMucFileBackup { get; set; }
        public string DuongDanLuuThuMucCopyTo { get; set; }
        public int ThoiGianTuDongBackUp { get; set; }

        private static string _Section = "CauHinhBackUp";
        private static string _KeyDuongDanLuuThuMucFileBackUp = "DuongDanLuuThuMucFileBackUp";
        private static string _KeyDuongDanLuuThuMucCopySangMayKhac = "DuongDanLuuThuMucCopySangMayKhac";
        private static string _KeyThoiGianTuDongBackup = "ThoiGianTuDongBackup";

        public void Write(string duongdanluuthumucfilebackup, string duongdanluuthumuccopysangmaykhac, int tgtudongbackup)
        {
            Ini.WriteValue(_Section, _KeyDuongDanLuuThuMucFileBackUp, duongdanluuthumucfilebackup);
            Ini.WriteValue(_Section, _KeyDuongDanLuuThuMucCopySangMayKhac, duongdanluuthumuccopysangmaykhac);
            Ini.WriteValue(_Section, _KeyThoiGianTuDongBackup, tgtudongbackup.ToString());
        }

        public void Read()
        {
            DuongDanLuuThuMucFileBackup = Ini.ReadValue(_Section, _KeyDuongDanLuuThuMucFileBackUp);
            DuongDanLuuThuMucCopyTo = Ini.ReadValue(_Section, _KeyDuongDanLuuThuMucCopySangMayKhac);
            int temp;
            if (int.TryParse(Ini.ReadValue(_Section, _KeyThoiGianTuDongBackup), out temp))
                ThoiGianTuDongBackUp = temp;
        }
    }

    public class ThaoTacIniCauHinhGhiChu
    {
        private static string _Section = "CauHinhGhiChu";
        private static string _KeyKhoangCachGhiChu = "KhoangCachGhiChu";
        private static string _KeyChieuNgangForm = "ChieuNgangForm";

        public static void Write(int kcGhiChu, int chieungangform)
        {
            Ini.WriteValue(_Section, _KeyKhoangCachGhiChu, kcGhiChu.ToString());
            Ini.WriteValue(_Section, _KeyChieuNgangForm, chieungangform.ToString());
        }

        public static int ReadKCGhiChu()
        {
            int result;
            int.TryParse(Ini.ReadValue(_Section, _KeyKhoangCachGhiChu), out result);
            if (result <= 0) result = 110;
            return result;
        }

        public static int ReadChieuNgangForm()
        {
            int result;
            int.TryParse(Ini.ReadValue(_Section, _KeyChieuNgangForm), out result);
            if (result <= 0) result = 640;
            return result;
        }
    }

    /// <summary>
    /// Ini ini = new Ini("D:\\demo.ini");
    /// ini.WriteValue("Section", "Key", "Value");
    /// Console.WriteLine(ini.ReadValue("Section", "Key"));	// "Value"
    /// </summary>
    class Ini
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        private static string _path = ".\\QuanLyTiemGiatLa.ini";

        public Ini() { }

        public static string ReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, _path);
            return temp.ToString();
        }

        public static void WriteValue(string Section, string Key, string Value)
        {
            string dir = System.IO.Path.GetDirectoryName(_path);
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }
            WritePrivateProfileString(Section, Key, Value, _path);
        }
    }
}
