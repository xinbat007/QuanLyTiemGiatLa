using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class KhachHangEntity
    {
        public Int64 MaKhachHang { get; set; }
        public String TenKhachHang { get; set; }
        public String DiaChi { get; set; }
        public String DienThoai { get; set; }
        public Int32 MaVip { get; set; }
        public String TenVip { get; set; }
        public Int32 GiamGia { get; set; }
        public Int64 DaTungThanhToan { get; set; }
        public String SoTheVip { get; set; }
    }

    public class ListKhachHangEntity : List<KhachHangEntity>
    {
    }

}
