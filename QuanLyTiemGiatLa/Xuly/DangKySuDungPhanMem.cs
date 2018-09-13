
using System;
using System.Management;
using System.Text;

namespace QuanLyTiemGiatLa
{
    public class DangKySuDungPhanMem
    {
        /// <summary>
        /// return Volume Serial Number from hard drive example "C", "D", "E" ....
        /// </summary>
        /// <param name="strDriveLetter">[optional] Drive letter</param>
        /// <returns>[string] VolumeSerialNumber</returns>
        /// 
        private static string GetVolumeSerial(string strDriveLetter)
        {
            if ((string.IsNullOrEmpty(strDriveLetter) | strDriveLetter == null))
                strDriveLetter = "C";
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");
            // & Chr(34) 
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }

        /// <summary>
        /// Returns MAC Address from first Network Card in Computer
        /// </summary>
        /// <returns>[string] MAC Address</returns>
        private static string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = string.Empty;
            foreach (ManagementObject mo in moc)
            {
                // only return MAC Address from first card
                if (MACAddress == string.Empty)
                {
                    if ((Convert.ToBoolean(mo["IPEnabled"]) == true))
                        MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }
            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }

        /// <summary>
        /// Return processorId from first CPU in machine
        /// </summary>
        /// <returns>[string] ProcessorId</returns>
        private static string GetCPUId()
        {
            string cpuInfo = string.Empty;
            string temp = string.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                // only return cpuInfo from first CPU
                if ((cpuInfo == string.Empty))
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }
            }
            return cpuInfo;
        }

        /// <summary>
        /// Return processorId from first CPU in machine
        /// </summary>
        /// <returns>[string] ProcessorId</returns>
        private static string GetProcessorID()
        {
            string sProcessorID = "";
            string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                sProcessorID += (string)oManagementObject["ProcessorId"];
            }
            return (sProcessorID);
        }

        public static string taoID()
        {
            string str = GetCPUId();
            //str += GetInfo.GetProcessorID(+vbNewLine)
            //str += GetInfo.GetMACAddress() + vbNewLine
            //str += GetInfo.GetVolumeSerial("C") + vbNewLine
            //str += GetInfo.GetVolumeSerial("D") + vbNewLine
            //str += GetInfo.GetVolumeSerial("E") + vbNewLine
            //str += GetInfo.Getdatetime()
            return str;
        }

        // Mã hóa Base64 với chuỗi Unicode.
        public static string Encrypt(string src)
        {
            byte[] b = Encoding.Unicode.GetBytes(src);
            return Convert.ToBase64String(b);
        }
        // Giải mã một chuỗi Unicode được mã hóa theo Base64.
        public static string Decrypt(string src)
        {
            byte[] b = Convert.FromBase64String(src);
            return Encoding.Unicode.GetString(b);
        }

        private static char kytuphancach = '$';
        public static string MahoaTumangString(params string[] s)
        {
            string chuoi = NoiTumangString(s);
            return Encrypt(chuoi);
        }

        public static string NoiTumangString(params string[] s)
        {
            string chuoi = "";
            foreach (var item_loopVariable in s)
            {
                chuoi += kytuphancach + item_loopVariable;
            }
            if (s.Length > 0) chuoi = chuoi.Substring(1);
            return chuoi;
        }

        // IDCPU + $ + solandatungupdate + $ + sophut + $ + 5kitu
        // neu sophut = -1 thi tuc la mua full
        public static string[] GiaimaSangmangString(string encrypttext)
        {
            string plantext = Decrypt(encrypttext);
            return plantext.Split(kytuphancach);
        }
        public static string[] CatSangmangString(string text)
        {
            return text.Split(kytuphancach);
        }

        public static string RandomString(Int32 size)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            // ký tự '*' là 42
            // ky tu '$' la 36
            // http://www.google.com.vn/imglanding?imgurl=http://www.webtutoriales.com/images/tutoriales/tabla_ascii.gif&imgrefurl=http://www.webtutoriales.com/tutoriales/html-css/mapa-caracteres-ascii.1.html&h=485&w=576&sz=20&tbnid=yfLbVd30RDqKaM:&tbnh=113&tbnw=134&prev=/search%3Fq%3Dascii%26tbm%3Disch%26tbo%3Du&zoom=1&q=ascii&hl=vi&usg=__3byJc_gma_v-gOc3PpJ7AG1ZHII%3D&sa=X&ei=GfPFTcK4GIa6vQOy-aGVAQ&ved=0CEUQ9QEwBw
            for (Int32 i = 0; i < size; i++)
            {
                sb.Append(Convert.ToChar(rand.Next(48, 126)));
            }
            return sb.ToString();
        }

        public const Int32 sogio1ngay = 14; // 1 ngay cho dung 14 tieng;
        public static void GhiThoiHanSuDung(String idcpu, Int32 songay, bool muafull, Int32 solankichhoat)
        {
            Int32 sophut = songay * sogio1ngay * 60;
            BienChung.checkKey.SoPhutConLai += sophut;
            BienChung.checkKey.SoPhutConLaiMaHoa = Encrypt(BienChung.checkKey.SoPhutConLai.ToString());
            Xuly.ThaoTacIniBanQuyen.Write(idcpu,
                BienChung.checkKey.SoPhutConLaiMaHoa,
                MahoaTumangString(RandomString(20), muafull ? "1" : "0", RandomString(7)),
                Encrypt(solankichhoat.ToString()));
        }
    }
}