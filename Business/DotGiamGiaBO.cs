using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class DotGiamGiaBO
	{
		public static ListDotGiamGiaEntity SelectAll()
		{
			return DataAccess.DotGiamGiaDA.SelectAll();
		}

		public static ListDotGiamGiaEntity SelectByNgay(DateTime ngay)
		{
			return DataAccess.DotGiamGiaDA.SelectByNgay(ngay);
		}

		public static Int32 Insert(DotGiamGiaEntity dotgiamgia)
		{
			return DataAccess.DotGiamGiaDA.Insert(dotgiamgia);
		}

		public static Int32 Update(DotGiamGiaEntity dotgiamgia)
		{
			return DataAccess.DotGiamGiaDA.Update(dotgiamgia);
		}

		public static Int32 Delete(Int32 madotgiamgia)
		{
			return DataAccess.DotGiamGiaDA.Delete(madotgiamgia);
		}

	}
}
