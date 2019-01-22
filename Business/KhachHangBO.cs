using System;
using DataAccess;
using Entity;

namespace Business
{
    public class KhachHangBO
    {
        public static ListKhachHangEntity SelectAll(DateTime tungay, DateTime denngay, Boolean tatca)
        {
            return KhachHangDA.SelectAll(tungay, denngay, tatca);
        }

        public static KhachHangEntity SelectByMaKhachHang(Int64 makh)
        {
            return KhachHangDA.SelectByMaKhachHang(makh);
        }

        public static KhachHangEntity SelectBySoTheVip(String sothevip, out Int32 kqTimthay)
        {
            return KhachHangDA.SelectBySoTheVip(sothevip, out kqTimthay);
        }

        public static KhachHangEntity SelectByMaPhieu(Int64 maphieu)
        {
            return KhachHangDA.SelectByMaPhieu(maphieu);
        }

        public static ListKhachHangEntity SelectCustomerNotSync()
        {
            return KhachHangDA.SelectCustomerNotSync();
        }

        public static ListKhachHangEntity SearchByWhere(String where, DateTime tungay, DateTime denngay, Boolean tatca)
        {
            return KhachHangDA.SearchByWhere(where, tungay, denngay, tatca);
        }

        public static ListKhachHangEntity Search(KhachHangEntity khachhang)
        {
            return KhachHangDA.Search(khachhang);
        }

        public static Int64 Insert(KhachHangEntity khachhang)
        {
            return KhachHangDA.Insert(khachhang);
        }

        public static Int64 InsertFromImport(KhachHangEntity khachhang)
        {
            return KhachHangDA.InsertFromImport(khachhang);
        }

        public static Int32 Update(KhachHangEntity khachhang)
        {
            return KhachHangDA.Update(khachhang);
        }

        public static Int32 UpdateIsSync(Int64 makhachhang, bool isSynced)
        {
            return KhachHangDA.UpdateIsSync(makhachhang, isSynced);
        }

        public static Int32 Delete(Int64 MaKhachHang)
        {
            return KhachHangDA.Delete(MaKhachHang);
        }
    }
}
