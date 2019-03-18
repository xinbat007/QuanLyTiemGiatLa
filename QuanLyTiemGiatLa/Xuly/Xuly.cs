using System;
using System.Management;
using System.Windows.Forms;
using Entity;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyTiemGiatLa.Xuly
{
    public class Xuly
    {
        private static readonly string[] VietnameseSigns = new string[] { "aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ" };

        public static string RemoveSign4VietnameseString(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }

        public static void LoadConfig()
        {
            //Entity.Common.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TiemGiatLa"].ConnectionString;
            //pathImage
            //C:\\imageQLTGL
            Business.MatHangBO.defaultDirectory = "C:\\imageQLTGL"; // QuanLyTiemGiatLa.Properties.Settings.Default.pathImage;
        }

        public static Int64 TinhTienGiamGia(Int64 tongtientruocgiamgia, Int32 giamgia)
        {
            // ví dụ 9000 giảm 50 % thì đúng là 4500 phải trả ra 4000 thôi, ko đc lên 5000
            // tongtientruocgiamgia: 9000
            // giamgia: 50
            Int64 sotiengiam = tongtientruocgiamgia * giamgia / 100;//chỗ này ra 4500
            Int64 phandu = sotiengiam % 1000;// chỗ này ra 500
            sotiengiam = sotiengiam - phandu;// chỗ này ra 4000
            return sotiengiam;// return 4000
        }

        public static Int64 TinhTienTangGia(Int64 tongtientruoctanggia, Int32 tanggia)
        {
            // ví dụ 9000 tăng 50 % thì phải trả ra 5000, ko đc xuống 4000
            // tongtientruoctanggia: 9000
            // tanggia: 50
            Int64 sotientang = tongtientruoctanggia * tanggia / 100;    //chỗ này ra 4500
            Int64 phandu = sotientang % 1000;// chỗ này ra 500
            if (phandu > 0)
                sotientang = sotientang + 1000 - phandu;    // chỗ này ra 5000
            return sotientang;// return 5000
        }

        public static Int64 TinhTienVanChuyen(Int64 tongtiencuoicung, Int32 phivc)
        {
            // ví dụ tổng tiền của hđ là 110.000 trong đó phi v/c là 10%
            // tức là tổng tiền trước vc là 100.000, phải return 10.000.
            // ví dụ sau giảm là 175.000, v/c 10% tức 17.500 làm tròn nên return 18.000
            Int64 sotienvc = phivc * tongtiencuoicung / (100 + phivc);
            Int64 phandu = sotienvc % 1000;
            if (phandu > 0) return sotienvc + 1000 - phandu;
            else return sotienvc;
        }

        public static string UNI2VNI(string s)
        {
            string result = s;
            ConvertDB.ConvertFont cv = new ConvertDB.ConvertFont();
            cv.Convert(ref result, ConvertDB.FontIndex.iUNI, ConvertDB.FontIndex.iVNI);
            return result;
        }

        public static string VNI2UNI(string s)
        {
            string result = s;
            ConvertDB.ConvertFont cv = new ConvertDB.ConvertFont();
            cv.Convert(ref result, ConvertDB.FontIndex.iVNI, ConvertDB.FontIndex.iUNI);
            return result;
        }

        public static void ControlFocus(KeyEventArgs e, Control ctr)
        {
            if (e.KeyCode == Keys.Enter) ctr.Focus();
        }

        public static void SapxepDataGrid(System.Windows.Forms.DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            }
        }

        public static string getSerialNumber()
        {
            string _serialNo = string.Empty;

            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("Select * from Win32_OperatingSystem");
            ManagementObjectCollection objMOC;

            objMOC = objMOS.Get();

            foreach (ManagementObject objMO in objMOC)
            {
                _serialNo = objMO["SerialNumber"].ToString();
            }

            return _serialNo;
        }

        public static string getlogonUser()
        {
            string _user = string.Empty;
            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectCollection objMOC;
            objMOC = objMOS.Get();
            foreach (ManagementObject objMO in objMOC)
            {
                _user = objMO["UserName"].ToString();
            }
            return _user;
        }

        public static String TaoIDPhieu(Int32 id)
        {
            DateTime now = DateTime.Now;
            String sodautien = now.Day > 9 ? now.Day.ToString() : "0" + now.Day.ToString();
            String sothu2 = now.Month > 9 ? now.Month.ToString() : "0" + now.Month.ToString();
            String sothu3 = now.Year.ToString().Remove(0, 2);
            String idtrongngay = id > 99 ? id.ToString() :
                id > 9 ? "0" + id.ToString() : "00" + id.ToString();
            return sodautien + sothu2 + sothu3 + idtrongngay;
        }

        //public static String ThemVaoMacacPhieuDangSuDung(String chuoidauvao, Int64 maphieuthemvao)
        //{
        //    if (!String.IsNullOrEmpty(chuoidauvao))
        //    {
        //        String[] mangphieu = chuoidauvao.Split(',');
        //        for (int i = 0; i < mangphieu.Length; i++)
        //        {
        //            if (String.IsNullOrEmpty(mangphieu[i])) continue;
        //            Int64 maphieu = Int64.Parse(mangphieu[i]);
        //            if (maphieu == maphieuthemvao) return chuoidauvao;// ko chỉnh sửa gì
        //        }
        //    }
        //    return chuoidauvao + maphieuthemvao.ToString() + ",";
        //}

        //public static String XoaDiMacacPhieuDangSuDung(String chuoidauvao, Int64 maphieucanxoa)
        //{
        //    String[] mangphieu = chuoidauvao.Split(',');
        //    String kq = String.Empty;
        //    for (int i = 0; i < mangphieu.Length; i++)
        //    {
        //        if (String.IsNullOrEmpty(mangphieu[i])) continue;
        //        Int64 maphieu = Int64.Parse(mangphieu[i]);
        //        if (maphieu != maphieucanxoa)
        //            kq += mangphieu[i] + ",";
        //    }
        //    return kq;
        //}

        //public static ListPhieuSlotEntity ChuanHoaDuLieuPhieuSlot(ListChiTietPhieuEntity lstCTPhieu, Int64 maphieu)
        //{
        //    ListPhieuSlotEntity phieuSlotTrenCSDL = Business.PhieuSlotBO.SelectByMaPhieu(maphieu);
        //    if (ChuanHoa(phieuSlotTrenCSDL, lstCTPhieu))
        //        phieuSlotTrenCSDL = Business.PhieuSlotBO.SelectByMaPhieu(maphieu);
        //    return phieuSlotTrenCSDL;
        //}

        //private static ChiTietPhieuEntity GetCTPhieuByMaHangMaKieuGiat(ListChiTietPhieuEntity lstCT, int mahang, int makieugiat)
        //{
        //    foreach (ChiTietPhieuEntity ct in lstCT)
        //    {
        //        if (ct.MaHang == mahang && ct.MaKieuGiat == makieugiat) return ct;
        //    }
        //    return null;
        //}

        //private static ListChiTietPhieuEntity ChuanHoaListCTPhieu(ListChiTietPhieuEntity lstCTPhieu)
        //{
        //    ListChiTietPhieuEntity lstChuan = new ListChiTietPhieuEntity();
        //    foreach (ChiTietPhieuEntity ct in lstCTPhieu)
        //    {
        //        ChiTietPhieuEntity ctMoi = GetCTPhieuByMaHangMaKieuGiat(lstChuan, ct.MaHang, ct.MaKieuGiat);
        //        if (ctMoi == null)
        //            lstChuan.Add(new ChiTietPhieuEntity(){ 
        //                MaHang = ct.MaHang,
        //                MaKieuGiat = ct.MaKieuGiat,
        //                Soluong = ct.Soluong
        //            });
        //        else
        //            ctMoi.Soluong += ct.Soluong;
        //    }
        //    return lstChuan;
        //}

        //private static bool ChuanHoa(ListPhieuSlotEntity phieuSlotTrenCSDL, ListChiTietPhieuEntity lstCTPhieu)
        //{
        //    /* 
        //     * duyệt từng thằng trong lstChitiet ví dụ: 2 áo giặt khô, 3 quần giặt ướt
        //     * duyệt mỗi thằng theo số lượng
        //     * duyệt các thằng trên csdl
        //     * nếu nó chưa có thì add mới
        //     * */
        //    //--------------- Bước 0: Chuẩn hóa lstCTPhieu về số lượng
        //    lstCTPhieu = ChuanHoaListCTPhieu(lstCTPhieu);
        //    //--------------- Bước 1: phân loại phiếu slot
        //    ListPhieuSlotEntity _phieuSlotMoi = new ListPhieuSlotEntity();
        //    ListPhieuSlotEntity _phieuSlotCuDeXoa = new ListPhieuSlotEntity();
        //    ListPhieuSlotEntity _phieuSlotPassedBigger = new ListPhieuSlotEntity();
        //    int sttmax = FindMax(phieuSlotTrenCSDL);
        //    bool cophairequest = false;

        //    foreach (ChiTietPhieuEntity ctphieu in lstCTPhieu)
        //    {
        //        ListPhieuSlotEntity _phieuSlotPassed = new ListPhieuSlotEntity();
        //        for (int i = 0; i < ctphieu.Soluong; i++)
        //        {
        //            foreach (PhieuSlotEntity phieuslot in phieuSlotTrenCSDL)
        //            {
        //                if (phieuslot.MaHang == ctphieu.MaHang && phieuslot.MaKieuGiat == ctphieu.MaKieuGiat
        //                    && !_phieuSlotPassed.Contains(phieuslot))
        //                {
        //                    _phieuSlotPassed.Add(phieuslot);	// cái nào có rồi
        //                    _phieuSlotPassedBigger.Add(phieuslot);
        //                    break;
        //                }
        //            }
        //        }
        //        if (_phieuSlotPassed.Count == ctphieu.Soluong) { }// ko có gì thay đổi
        //        else if (_phieuSlotPassed.Count < ctphieu.Soluong)	// thiếu thì phải add thêm vào
        //        {
        //            for (int i = 0; i < ctphieu.Soluong - _phieuSlotPassed.Count; i++)
        //            {
        //                _phieuSlotMoi.Add(new PhieuSlotEntity()
        //                {
        //                    MaPhieu = ctphieu.MaPhieu,
        //                    STT = ++sttmax,
        //                    MaHang = ctphieu.MaHang,
        //                    MaKieuGiat = ctphieu.MaKieuGiat,
        //                    Kho = String.Empty,
        //                    Slot = 0,
        //                    DaTra = false
        //                });
        //            }
        //        }
        //    }
        //    foreach (PhieuSlotEntity phieuslot in phieuSlotTrenCSDL)
        //    {
        //        if (!_phieuSlotPassedBigger.Contains(phieuslot)) _phieuSlotCuDeXoa.Add(phieuslot);
        //    }
        //    //------ Bước 2: cập nhật lên csdl
        //    // Xóa những thằng thừa
        //    if (_phieuSlotCuDeXoa.Count > 0)
        //    {
        //        Business.PhieuSlotBO.DeleteByMaPhieuSTT(_phieuSlotCuDeXoa);
        //        cophairequest = true;
        //    }
        //    // Thêm những thằng mới
        //    if (_phieuSlotMoi.Count > 0)
        //    {
        //        Business.PhieuSlotBO.Insert(_phieuSlotMoi);
        //        cophairequest = true;
        //    }
        //    //------ the end ----------------
        //    return cophairequest;
        //}

        private static Int32 FindMax(ListPhieuSlotEntity phieuSlotTrenCSDL)
        {
            int max = 0;
            foreach (var item in phieuSlotTrenCSDL)
            {
                max = max < item.STT ? item.STT : max;
            }
            return max;
        }

        public static String CreateConnectionString(Boolean blnWindow, String strServer, String strData, String strUID, String strPwd)
        {
            if (!blnWindow)
                return "Data Source=" + strServer + ";Initial Catalog=" + strData + ";Trusted_Connection=False;User Id=" + strUID + ";Password=" + strPwd + ";";
            else
                return "Data Source=" + strServer + ";Initial Catalog=" + strData + ";Trusted_Connection=True;";//Integrated Security=SSPI;";
        }

        public static String DocPhutSangNgayGio(Int64 sophut)//403
        {
            Int64 songay = sophut / DangKySuDungPhanMem.sogio1ngay / 60;//28
            Int64 sophutdu = sophut % (DangKySuDungPhanMem.sogio1ngay * 60);//11
            Int64 sogio = sophutdu / 60;
            Int64 sophutdura = sophutdu % 60;
            return songay + " ngày " + sogio + " giờ " + sophutdura + " phút";
        }

        public static Int64 ReadInt64(string s)
        {
            Int64 result;
            Int64.TryParse(s, out result);
            return result;
        }

        public static Int32 ReadInt32(string s)
        {
            Int32 result;
            Int32.TryParse(s, out result);
            return result;
        }

        public static String MaHoaPassword(string pass)
        {
            MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(pass);
            bs = _md5Hasher.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }

        private static string chuanHoaThuMuc(string path)
        {
            return path + (path[path.Length - 1] == '\\' ? "" : @"\") + "QuanLyTiemGiatLa.bak";
        }

        public static int AutoBackup(string duongdanThumucLuuFileBackUp, string duongdanThuMucLuuFileCopyTo)
        {
            string duongdanFileBackUp = chuanHoaThuMuc(duongdanThumucLuuFileBackUp);
            string duongdanThuMucCopyTo = string.IsNullOrEmpty(duongdanThuMucLuuFileCopyTo) ? string.Empty : chuanHoaThuMuc(duongdanThuMucLuuFileCopyTo);
            string strBackUp = @"BACKUP DATABASE [QuanLyTiemGiatLa] TO 
					DISK = N'" + duongdanFileBackUp + @"'
					WITH NOFORMAT, INIT, NAME = N'QuanLyTiemGiatLa-Full Database Backup',
					SKIP, NOREWIND, NOUNLOAD, STATS = 10";
            //string strConnection = @"Data Source=thienpq\sqlexpress;Initial Catalog=master;User ID=sa;Password=sa";
            SqlConnection connection = new SqlConnection(Entity.Common.connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = strBackUp;
            command.Connection = connection;
            try
            {

                connection.Open();
                command.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(duongdanThuMucCopyTo))
                    System.IO.File.Copy(duongdanFileBackUp, duongdanThuMucCopyTo, true);
                if (!string.IsNullOrEmpty(duongdanThuMucCopyTo) && !System.IO.File.Exists(duongdanThuMucCopyTo))
                    return 1;//MessageBox.Show("Không copy được sang thư mục: " + duongdanThuMucCopyTo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    return 2;//MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ToanManHinh(Form f)
        {
            if (BienChung.isToanManHinh) f.WindowState = FormWindowState.Maximized;
        }

        public static void CapNhatThoiDiemLuu(ListPhieuSlotEntity lstPS_Before, ListPhieuSlotEntity lstPS_After)
        {
            if (lstPS_After == null || lstPS_Before == null || lstPS_After.Count != lstPS_Before.Count) return;
            for (int i = 0; i < lstPS_After.Count; i++)
            {
                PhieuSlotEntity psAfter = lstPS_After[i];
                PhieuSlotEntity psBefore = lstPS_Before[i];
                if (psAfter.Kho != psBefore.Kho ||
                    psAfter.Slot != psBefore.Slot ||
                    psAfter.DaTra != psBefore.DaTra ||
                    psAfter.GhiChu != psBefore.GhiChu)
                {
                    psAfter.ThoiDiemLuu = DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " " + BienChung.userCurrent.UserName;
                }
            }
        }

        public static ListPhieuSlotEntity CopyListPhieuSlot(ListPhieuSlotEntity source)
        {
            if (source == null) return null;
            ListPhieuSlotEntity lstPSBefore = new ListPhieuSlotEntity();
            for (int i = 0; i < source.Count; i++)
            {
                PhieuSlotEntity ps = source[i];
                lstPSBefore.Add(new PhieuSlotEntity() { Kho = ps.Kho, Slot = ps.Slot, DaTra = ps.DaTra, GhiChu = ps.GhiChu });
            }
            return lstPSBefore;
        }

    }
}
