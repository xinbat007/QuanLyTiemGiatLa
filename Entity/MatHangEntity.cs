using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class MatHangEntity
	{
		public Int32 MaHang { get; set; }
		public String TenHang { get; set; }
		public Int32 MaLoaiHang { get; set; }
		public String ImageStringFile { get; set; }
	}
	public class ListMatHangEntity : List<MatHangEntity>
	{
	}

}
