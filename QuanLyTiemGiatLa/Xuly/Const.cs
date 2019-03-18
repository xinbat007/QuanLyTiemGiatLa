using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTiemGiatLa
{
    public enum TrangThai
    {
        Them,
        Sua
    }

    public enum ThuTuButton
    {
        DanhSachPhieu = 0,
        LapPhieu = 1,
        CatDo = 2,
        NhungViecCanLam = 3,
        DoiMatKhau = 4,
        CauHinh = 5,
        DotGiamGia = 6,
        NhanVien = 7,
        KhachHang = 8,
        LoaiKhachHang = 9,
        MatHang = 10,
        LoaiHang = 11,
        KieuGiat = 12,
        BangGia = 13,
        GiaDeDo = 14,
        BangChotKet = 15,
        ThongKeThuNhap = 16
    }

    public class Const
    {
        public static String PATH_LOG_SYNC_CUSTOMERS = ".\\log_SyncCustomers.txt";
        public static String PATH_LOG_SYNC_ORDERS = ".\\log_SyncOrders.txt";
        public static String PATH_LOG_IMPORT_CUSTOMERS = ".\\log_ImportCustomers.txt";
    }
}
