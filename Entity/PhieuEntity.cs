using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class PhieuEntity
	{
		public Int64 MaPhieu { get; set; }
		public Int64 MaKhachHang { get; set; }
		public DateTime NgayLap { get; set; }
		public DateTime NgayHenTra { get; set; }
		public Int32 GiamGia { get; set; }
		public Int64 TongTien { get; set; }
		public Boolean DaThanhToan { get; set; }
		public Boolean DaTraDo { get; set; }
		public String TenKhachHang { get; set; }
		public String GhiChu { get; set; }
		public String UserName { get; set; }
		public Int32 SoLanIn { get; set; }
		public Int32 PhiGiaoNhan { get; set; }
        public Boolean IsPhieuHuy { get; set; }
        public Boolean IsSynced { get; set; }
	}
	public class ListPhieuEntity : List<PhieuEntity>
	{
    }
    public class PhieuSyncEntity
    {
        // Phieu
        public Int64 MaPhieu { get; set; }
        public Int64 MaKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHenTra { get; set; }
        public Int32 GiamGia { get; set; }
        public Int64 TongTien { get; set; }
        public Boolean DaThanhToan { get; set; }
        public Boolean DaTraDo { get; set; }
        public String TenKhachHang { get; set; }
        public String GhiChu { get; set; }
        public String UserName { get; set; }
        public Int32 SoLanIn { get; set; }
        public Int32 PhiGiaoNhan { get; set; }
        public Boolean IsPhieuHuy { get; set; }
        public ListChiTietPhieuEntity ChiTietPhieu { get; set; }

        public void CopyFromPhieu(PhieuEntity phieu)
        {
            this.MaPhieu = phieu.MaPhieu;
            this.MaKhachHang = phieu.MaKhachHang;
            this.NgayLap = phieu.NgayLap;
            this.NgayHenTra = phieu.NgayHenTra;
            this.GiamGia = phieu.GiamGia;
            this.TongTien = phieu.TongTien;
            this.DaThanhToan = phieu.DaThanhToan;
            this.DaTraDo = phieu.DaTraDo;
            this.TenKhachHang = phieu.TenKhachHang;
            this.GhiChu = phieu.GhiChu;
            this.UserName = phieu.UserName;
            this.SoLanIn = phieu.SoLanIn;
            this.PhiGiaoNhan = phieu.PhiGiaoNhan;
            this.IsPhieuHuy = phieu.IsPhieuHuy;
        }
    }
}
