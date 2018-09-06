using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class BangGiaEntity
	{
		public Int32 IDGia { get; set; }
		public Int32 MaHang { get; set; }
		public Int32 MaKieuGiat { get; set; }
		public Int64 DonGia { get; set; }
		public String TenHang { get; set; }
		public String TenKieuGiat { get; set; }
		public Byte SoSanPham { get; set; }
	}
	public class ListBangGiaEntity : List<BangGiaEntity>
	{
	}

}
