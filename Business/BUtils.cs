using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Business
{
	public class BUtils
	{
		public static DataTable SelectBySql(String sql)
		{
			return DataAccess.DUtils.SelectBySql(sql);
		}
	}
}
