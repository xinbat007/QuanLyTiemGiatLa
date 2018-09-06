using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class LoaiHangEntity
	{
		public int MaLoaiHang { get; set; }
		public String TenLoaiHang { get; set; }
	}

	public class ListLoaiHangEntity : List<LoaiHangEntity>
	{
	}
}
