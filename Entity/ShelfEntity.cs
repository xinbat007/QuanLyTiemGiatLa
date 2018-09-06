using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class ShelfEntity
	{
		public Int32 MaKho { get; set; }
		public Int32 Slot { get; set; }
		public String TenKho { get; set; }		
		public String MaCacPhieuDangSuDung { get; set; }
	}

	public class ListShelfEntity : List<ShelfEntity>
	{
	}
}
