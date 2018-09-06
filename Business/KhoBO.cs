using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class KhoBO
	{
		public static ListKhoEntity SelectAll()
		{
			return DataAccess.KhoDA.SelectAll();
		}

		public static Int32 Insert(KhoEntity kho)
		{
			return DataAccess.KhoDA.Insert(kho);
		}

		public static Int32 Update(KhoEntity kho)
		{
			return DataAccess.KhoDA.Update(kho);
		}

		public static Int32 Delete(Int32 Makho)
		{
			return DataAccess.KhoDA.Delete(Makho);
		}


	}
}
