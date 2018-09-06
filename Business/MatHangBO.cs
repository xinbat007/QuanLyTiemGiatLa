using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.IO;

namespace Business
{
    public class MatHangBO
    {
        public static String defaultImagePath = "default.jpg";
        public static String defaultDirectory = "";// cái này đc set trong setting

        public static String CopyAnhVaoThuMuc(Int32 mahang, String sourceFileName)
        {
            if (!File.Exists(sourceFileName)) return String.Empty;
            // đặt tên ảnh là mahang.ext
            // trả về ảnh đường dẫn mới vd: C:\imageQLTGL\32.jpg // chú ý phần mở rộng

            FileStream file = File.OpenRead(sourceFileName);
            String[] c = file.Name.Split('\\');
            String onlyfilename = c[c.Length - 1];
            String[] s = onlyfilename.Split('.');
            String ext = s[s.Length - 1];
            if (!Directory.Exists(defaultDirectory))
            {
                try
                {
                    Directory.CreateDirectory(defaultDirectory);
                }
                catch
                {
                    throw new Exception("Không tạo được thư mục");
                }
            }
            String kq = defaultDirectory + "\\" + mahang + "." + ext;
            try
            {
                File.Copy(sourceFileName, kq, true);
            }
            catch
            {
                kq = String.Empty;
                throw;
            }
            return kq;
        }

        public static void XoaAnh(String fileName)
        {
            if (!File.Exists(fileName)) return;
            File.Delete(fileName);
        }

        public static ListMatHangEntity SelectAll()
        {
            return DataAccess.MatHangDA.SelectAll();
        }

        public static ListMatHangEntity SelectByMaKieuGiat(Int32 makieugiat)
        {
            return DataAccess.MatHangDA.SelectByMaKieuGiat(makieugiat);
        }

        public static Int32 Insert(MatHangEntity mathang)
        {
            return DataAccess.MatHangDA.Insert(mathang);
        }

        public static Int32 Update(MatHangEntity mathang)
        {
            return DataAccess.MatHangDA.Update(mathang);
        }

        public static Int32 Delete(Int32 MaLoaiHang)
        {
            return DataAccess.MatHangDA.Delete(MaLoaiHang);
        }
    }
}
