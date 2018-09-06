using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class MucDoVipEntity
	{
		public Int32 MaVip { get; set; }
		public String TenVip { get; set; }
		public Int32 GiamGia { get; set; }
	}
	public class ListMucDoVipEntity : List<MucDoVipEntity>
	{
	}
}
