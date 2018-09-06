using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class MucDoVipBO
	{
		public static ListMucDoVipEntity SelectAll()
		{
			return DataAccess.MucDoVipDA.SelectAll();
		}

		public static Int32 Insert(MucDoVipEntity mucdovip)
		{
			return DataAccess.MucDoVipDA.Insert(mucdovip);
		}

		public static Int32 Update(MucDoVipEntity mucdovip)
		{
			return DataAccess.MucDoVipDA.Update(mucdovip);
		}

		public static Int32 Delete(Int32 mamucdovip)
		{
			return DataAccess.MucDoVipDA.Delete(mamucdovip);
		}

	}
}
