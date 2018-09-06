using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class ChotKetEntity
	{
		public Int64 MaChotKet { get; set; }
		public DateTime ThoiDiemChot { get; set; }
		public Int64 TuPhieu { get; set; }
		public Int64 DenPhieu { get; set; }
		public Int64 SoTienChot { get; set; }
		public String NguoiChot { get; set; }
		public String GhiChu { get; set; }
	}
	public class ListChotKetEntity : List<ChotKetEntity>
	{
	}
}
