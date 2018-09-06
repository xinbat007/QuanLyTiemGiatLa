using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class KieuGiatLaDA
	{
		public static ListKieuGiatLaEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KieuGiatLa_SelectAll";

			ListKieuGiatLaEntity kq = new ListKieuGiatLaEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new KieuGiatLaEntity()
					{
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						TenKieuGiat = reader["TenKieuGiat"].ToString()
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListKieuGiatLaEntity SelectByMaHang(Int32 mahang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_KieuGiatLa_SelectByMaHang]";

			SqlParameter param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
			param.Value = mahang;
			command.Parameters.Add(param);

			ListKieuGiatLaEntity kq = new ListKieuGiatLaEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new KieuGiatLaEntity()
					{
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						TenKieuGiat = reader["TenKieuGiat"].ToString()
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(KieuGiatLaEntity kieugiatla)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KieuGiatLa_Insert";

			SqlParameter param = new SqlParameter("@TenKieuGiat", SqlDbType.NVarChar, 100);
			param.Value = kieugiatla.TenKieuGiat;
			command.Parameters.Add(param);

			return Int32.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(KieuGiatLaEntity kieugiatla)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KieuGiatLa_Update";

			SqlParameter param = new SqlParameter("@TenKieuGiat", SqlDbType.NVarChar, 100);
			param.Value = kieugiatla.TenKieuGiat;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
			param.Value = kieugiatla.MaKieuGiat;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int32 MaKieuGiat)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KieuGiatLa_Delete";
			SqlParameter param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
			param.Value = MaKieuGiat;
			command.Parameters.Add(param);
			return command.ExecuteNonQuery();
		}
	}
}
