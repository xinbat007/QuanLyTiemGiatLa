using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class ChiTietPhieuEntity
	{
		public Int64 IDChiTietPhieu { get; set; }
		public Int64 MaPhieu { get; set; }
		public Int32 MaHang { get; set; }
		public Int32 Soluong { get; set; }
		public Int32 MaKieuGiat { get; set; }
		public Int64 DonGia { get; set; }
		public String TenHang { get; set; }
		public String TenKieuGiat { get; set; }
		public String GhiChu { get; set; }
	}
	public class ListChiTietPhieuEntity : List<ChiTietPhieuEntity>
	{
	}
}
