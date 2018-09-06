using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class LoaiHangDA
	{
		public static ListLoaiHangEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_LoaiHang_SelectAll";

			ListLoaiHangEntity kq = new ListLoaiHangEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new LoaiHangEntity()
					{
						MaLoaiHang = (Int32) reader["MaLoaiHang"],
						TenLoaiHang = reader["TenLoaiHang"].ToString()
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(LoaiHangEntity loaihang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_LoaiHang_Insert";
			SqlParameter param = new SqlParameter("@TenLoaiHang", SqlDbType.NVarChar, 100);
			param.Value = loaihang.TenLoaiHang;
			command.Parameters.Add(param);
			return Int32.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(LoaiHangEntity loaihang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_LoaiHang_Update";

			SqlParameter param = new SqlParameter("@MaLoaiHang", SqlDbType.Int);
			param.Value = loaihang.MaLoaiHang;
			command.Parameters.Add(param);
			
			param = new SqlParameter("@TenLoaiHang", SqlDbType.NVarChar, 100);
			param.Value = loaihang.TenLoaiHang;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int32 MaLoaiHang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_LoaiHang_Delete";
			SqlParameter param = new SqlParameter("@MaLoaiHang", SqlDbType.Int, 4);
			param.Value = MaLoaiHang;
			command.Parameters.Add(param);
			return command.ExecuteNonQuery();			
		}
	}
}
