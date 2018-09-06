using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class MatHangDA
	{
		public static ListMatHangEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_MatHang_SelectAll";

			ListMatHangEntity kq = new ListMatHangEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new MatHangEntity()
					{
						MaHang = (Int32)reader["MaHang"],
						MaLoaiHang = (Int32)reader["MaLoaiHang"],
						TenHang = reader["TenHang"].ToString(),
						ImageStringFile = reader["ImageStringFile"] == DBNull.Value ? String.Empty : reader["ImageStringFile"].ToString()
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListMatHangEntity SelectByMaKieuGiat(Int32 makieugiat)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_MatHang_SelectByMaKieuGiat]";

			SqlParameter param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
			param.Value = makieugiat;
			command.Parameters.Add(param);

			ListMatHangEntity kq = new ListMatHangEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new MatHangEntity()
					{
						MaHang = (Int32)reader["MaHang"],
						TenHang = reader["TenHang"].ToString(),
						ImageStringFile = reader["ImageStringFile"] == DBNull.Value ? String.Empty : reader["ImageStringFile"].ToString()
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(MatHangEntity mathang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_MatHang_Insert";
			SqlParameter param = new SqlParameter("@TenHang", SqlDbType.NVarChar, 200);
			param.Value = mathang.TenHang;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaLoaiHang", SqlDbType.Int, 4);
			param.Value = mathang.MaLoaiHang;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(mathang.ImageStringFile))
			{
				param = new SqlParameter("@ImageStringFile", SqlDbType.NVarChar, 500);
				param.Value = mathang.ImageStringFile;
				command.Parameters.Add(param);
			}

			return Int32.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(MatHangEntity mathang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_MatHang_Update";

			SqlParameter param = new SqlParameter("@TenHang", SqlDbType.NVarChar, 200);
			param.Value = mathang.TenHang;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaLoaiHang", SqlDbType.Int, 4);
			param.Value = mathang.MaLoaiHang;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaHang", SqlDbType.BigInt, 4);
			param.Value = mathang.MaHang;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(mathang.ImageStringFile))
			{
				param = new SqlParameter("@ImageStringFile", SqlDbType.NVarChar, 500);
				param.Value = mathang.ImageStringFile;
				command.Parameters.Add(param);
			}

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int32 MaLoaiHang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_MatHang_Delete";
			SqlParameter param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
			param.Value = MaLoaiHang;
			command.Parameters.Add(param);
			return command.ExecuteNonQuery();
		}
	}
}
