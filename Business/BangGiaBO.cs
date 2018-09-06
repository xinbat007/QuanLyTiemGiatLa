using System;
using Entity;

namespace Business
{
	public class BangGiaBO
	{
		public static ListBangGiaEntity SelectAll()
		{
			return DataAccess.BangGiaDA.SelectAll();
		}

		public static Int32 CheckExist(Int32 idgia, Int32 mahang, Int32 makieugiat)
		{
			return DataAccess.BangGiaDA.CheckExist(idgia, mahang, makieugiat);
		}

		public static Int32 Insert(BangGiaEntity banggia)
		{
			return DataAccess.BangGiaDA.Insert(banggia);
		}

		public static Int32 Update(BangGiaEntity banggia)
		{
			return DataAccess.BangGiaDA.Update(banggia);
		}

		public static Int32 Delete(Int32 idgia)
		{
			return DataAccess.BangGiaDA.Delete(idgia);
		}

	}
}
