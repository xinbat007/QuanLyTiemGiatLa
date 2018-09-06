using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class DotGiamGiaDA
	{
		public static ListDotGiamGiaEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_DotGiamGia_SelectAll";

			ListDotGiamGiaEntity kq = new ListDotGiamGiaEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new DotGiamGiaEntity()
					{
						MaDotGiamGia = (Int32)reader["MaDotGiamGia"],
						TenDotGiamGia = reader["TenDotGiamGia"] == DBNull.Value ? String.Empty : reader["TenDotGiamGia"].ToString(),
						TuNgay = (DateTime)reader["TuNgay"],
						DenNgay = (DateTime)reader["DenNgay"],
						GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32) reader["GiamGia"]						
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListDotGiamGiaEntity SelectByNgay(DateTime ngay)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_DotGiamGia_SelectByNgay";

			SqlParameter param = new SqlParameter("@ngay", ngay);
			command.Parameters.Add(param);

			ListDotGiamGiaEntity kq = new ListDotGiamGiaEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new DotGiamGiaEntity()
					{
						MaDotGiamGia = (Int32)reader["MaDotGiamGia"],
						TenDotGiamGia = reader["TenDotGiamGia"] == DBNull.Value ? String.Empty : reader["TenDotGiamGia"].ToString(),
						TuNgay = (DateTime)reader["TuNgay"],
						DenNgay = (DateTime)reader["DenNgay"],
						GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32)reader["GiamGia"]
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(DotGiamGiaEntity dotgiamgia)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_DotGiamGia_Insert";

			SqlParameter param = new SqlParameter("@TuNgay", dotgiamgia.TuNgay);
			command.Parameters.Add(param);

			param = new SqlParameter("@DenNgay", dotgiamgia.DenNgay);
			command.Parameters.Add(param);

			param = new SqlParameter("@GiamGia", SqlDbType.Int, 4);
			param.Value = dotgiamgia.GiamGia;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(dotgiamgia.TenDotGiamGia))
			{
				param = new SqlParameter("@TenDotGiamGia", SqlDbType.NVarChar, 200);
				param.Value = dotgiamgia.TenDotGiamGia;
				command.Parameters.Add(param);
			}

			return Int32.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(DotGiamGiaEntity dotgiamgia)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_DotGiamGia_Update";

			SqlParameter param = new SqlParameter("@TuNgay", dotgiamgia.TuNgay);
			command.Parameters.Add(param);

			param = new SqlParameter("@DenNgay", dotgiamgia.DenNgay);
			command.Parameters.Add(param);

			param = new SqlParameter("@GiamGia", SqlDbType.Int, 4);
			param.Value = dotgiamgia.GiamGia;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaDotGiamGia", SqlDbType.Int, 4);
			param.Value = dotgiamgia.MaDotGiamGia;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(dotgiamgia.TenDotGiamGia))
			{
				param = new SqlParameter("@TenDotGiamGia", SqlDbType.NVarChar, 200);
				param.Value = dotgiamgia.TenDotGiamGia;
				command.Parameters.Add(param);
			}

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int32 madotgiamgia)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_DotGiamGia_Delete";
			
			SqlParameter param = new SqlParameter("@MaDotGiamGia", SqlDbType.Int, 4);
			param.Value = madotgiamgia;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

	}
}
