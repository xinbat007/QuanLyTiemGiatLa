using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class KhoDA
	{
		public static ListKhoEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Kho_SelectAll]";

			ListKhoEntity kq = new ListKhoEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new KhoEntity()
					{
						MaKho = (Int32)reader["MaKho"],
						TenKho = reader["TenKho"].ToString(),
						GhiChu = reader["GhiChu"].ToString(),
						SoluongSlot = String.IsNullOrEmpty(reader["SoluongSlot"].ToString()) ? 0 : (Int32)reader["SoluongSlot"]
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(KhoEntity kho)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Kho_Insert]";

			SqlParameter param = new SqlParameter("@TenKho", SqlDbType.NVarChar, 50);
			param.Value = kho.TenKho;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(kho.GhiChu))
			{
				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50);
				param.Value = kho.GhiChu;
				command.Parameters.Add(param);
			}

			Int32 makho = Int32.Parse(command.ExecuteScalar().ToString());
			ShelfDA.Insert(makho, kho.SoluongSlot);
			return makho;
		}

		public static Int32 Update(KhoEntity kho)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Kho_Update]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = kho.MaKho;
			command.Parameters.Add(param);

			param = new SqlParameter("@TenKho", SqlDbType.NVarChar, 50);
			param.Value = kho.TenKho;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(kho.GhiChu))
			{
				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50);
				param.Value = kho.GhiChu;
				command.Parameters.Add(param);
			}
			Int32 kq = command.ExecuteNonQuery();
			ShelfDA.Insert(kho.MaKho, kho.SoluongSlot);
			return kq;
		}

		public static Int32 Delete(Int32 Makho)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Kho_Delete]";
			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = Makho;
			command.Parameters.Add(param);
			return command.ExecuteNonQuery();
		}
	}
}
