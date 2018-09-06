using System;
using Entity;

namespace Business
{
	public class ChotKetBO
	{
		public static ListChotKetEntity Select(Boolean tatca, DateTime tungay, DateTime denngay)
		{
			return DataAccess.ChotKetDA.Select(tatca, tungay, denngay);
		}

		public static Int32 Insert(ChotKetEntity chotket)
		{
			return DataAccess.ChotKetDA.Insert(chotket);
		}
	}
}
