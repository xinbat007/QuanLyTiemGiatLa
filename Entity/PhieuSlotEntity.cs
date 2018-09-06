using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class PhieuSlotEntity
	{
		public Int64 MaPhieu { get; set; }
		public Int32 STT { get; set; }
		public Int32 MaHang { get; set; }
		public Int32 MaKieuGiat { get; set; }
		public String TenHang { get; set; }
		public String TenKieuGiat { get; set; }
		public String Kho { get; set; }
		public Int32 Slot { get; set; }
		public Boolean DaTra { get; set; }
		public Int64 MaVach { get; set; }
		public String GhiChu { get; set; }
		public String SoHieuSanPham { get; set; }
		public String NgayTra { get; set; }
		public string ThoiDiemLuu { get; set; }
		public String MaHienThi
		{
			get
			{
				return "" + MaPhieu + "-" + String.Format("{0,0:00}", STT);
			}
		}
	}
	public class ListPhieuSlotEntity : List<PhieuSlotEntity>
	{
	}
}
