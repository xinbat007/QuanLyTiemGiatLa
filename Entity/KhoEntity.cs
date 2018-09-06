using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class KhoEntity
	{
		public Int32 MaKho { get; set; }
		public String TenKho { get; set; }
		public String GhiChu { get; set; }
		public Int32 SoluongSlot { get; set; }
	}
	public class ListKhoEntity : List<KhoEntity>
	{
	}


}
