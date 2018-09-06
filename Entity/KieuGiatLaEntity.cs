using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class KieuGiatLaEntity
	{
		public Int32 MaKieuGiat { get; set; }
		public String TenKieuGiat { get; set; }
	}
	public class ListKieuGiatLaEntity : List<KieuGiatLaEntity>
	{
	}

}
