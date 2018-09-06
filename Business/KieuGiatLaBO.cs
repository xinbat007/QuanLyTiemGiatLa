using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class KieuGiatLaBO
	{
		public static ListKieuGiatLaEntity SelectAll()
		{
			return DataAccess.KieuGiatLaDA.SelectAll();
		}

		public static ListKieuGiatLaEntity SelectByMaHang(Int32 mahang)
		{
			return DataAccess.KieuGiatLaDA.SelectByMaHang(mahang);
		}

		public static Int32 Insert(KieuGiatLaEntity kieugiatla)
		{
			return DataAccess.KieuGiatLaDA.Insert(kieugiatla);
		}

		public static Int32 Update(KieuGiatLaEntity kieugiatla)
		{
			return DataAccess.KieuGiatLaDA.Update(kieugiatla);
		}

		public static Int32 Delete(Int32 MaKieuGiat)
		{
			return DataAccess.KieuGiatLaDA.Delete(MaKieuGiat);
		}
	}
}
