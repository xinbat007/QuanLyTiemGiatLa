using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class ChiTietPhieuBO
    {
        public static ListChiTietPhieuEntity SelectAll()
        {
            return DataAccess.ChiTietPhieuDA.SelectAll();
        }

        public static ListChiTietPhieuEntity SelectByMaPhieu(Int64 maphieu)
        {
            return DataAccess.ChiTietPhieuDA.SelectByMaPhieu(maphieu);
        }

        public static ListChiTietPhieuEntity SelectByMaPhieu(Int64 maphieu, out Int64 tongtien)
        {
            return DataAccess.ChiTietPhieuDA.SelectByMaPhieu(maphieu, out tongtien);
        }

        public static Int64 Insert(ChiTietPhieuEntity chitietphieu)
        {
            return DataAccess.ChiTietPhieuDA.Insert(chitietphieu);
        }

        public static Int32 Update(ChiTietPhieuEntity chitietphieu)
        {
            return DataAccess.ChiTietPhieuDA.Update(chitietphieu);
        }

        public static Int32 Delete(Int64 IDChiTietPhieu)
        {
            return DataAccess.ChiTietPhieuDA.Delete(IDChiTietPhieu);
        }

    }
}
