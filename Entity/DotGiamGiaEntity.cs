using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class DotGiamGiaEntity
	{
		public Int32 MaDotGiamGia { get; set; }
		public String TenDotGiamGia { get; set; }
		public DateTime TuNgay { get; set; }
		public DateTime DenNgay { get; set; }
		public Int32 GiamGia { get; set; }
	}

	public class ListDotGiamGiaEntity : List<DotGiamGiaEntity>
	{
	}

}
