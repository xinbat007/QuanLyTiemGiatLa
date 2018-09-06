using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class MucDoVipDA
	{
		public static ListMucDoVipEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_MucDoVip_SelectAll]";

			ListMucDoVipEntity kq = new ListMucDoVipEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new MucDoVipEntity()
					{
						MaVip = (Int32)reader["MaVip"],
						TenVip = reader["TenVip"].ToString(),
						GiamGia = (Int32)reader["GiamGia"]
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(MucDoVipEntity mucdovip)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_MucDoVip_Insert]";

			SqlParameter param = new SqlParameter("@TenVip", SqlDbType.NVarChar, 50);
			param.Value = mucdovip.TenVip;
			command.Parameters.Add(param);

			param = new SqlParameter("@GiamGia", SqlDbType.Int, 4);
			param.Value = mucdovip.GiamGia;
			command.Parameters.Add(param);
			
			return Int32.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(MucDoVipEntity mucdovip)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_MucDoVip_Update]";

			SqlParameter param = new SqlParameter("@MaVip", SqlDbType.Int, 4);
			param.Value = mucdovip.MaVip;
			command.Parameters.Add(param);

			param = new SqlParameter("@TenVip", SqlDbType.NVarChar, 50);
			param.Value = mucdovip.TenVip;
			command.Parameters.Add(param);

			param = new SqlParameter("@GiamGia", SqlDbType.Int, 4);
			param.Value = mucdovip.GiamGia;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int32 mamucdovip)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_MucDoVip_Delete]";

			SqlParameter param = new SqlParameter("@MaVip", SqlDbType.Int, 4);
			param.Value = mamucdovip;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

	}
}
