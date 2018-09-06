using System;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace DataAccess
{
	public class ChiTietPhieuDA
	{
		public static ListChiTietPhieuEntity SelectByMaPhieu(Int64 maphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_ChiTietPhieu_SelectByMaPhieu]";

			SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
			param.Value = maphieu;
			command.Parameters.Add(param);

			ListChiTietPhieuEntity kq = new ListChiTietPhieuEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				ChiTietPhieuEntity ctphieu = null;
				while (reader.Read())
				{
					ctphieu = new ChiTietPhieuEntity()
					{
						IDChiTietPhieu = (Int64)reader["IDChiTietPhieu"],
						MaPhieu = maphieu,
						MaHang = (Int32)reader["MaHang"],
						Soluong = (Int32)reader["Soluong"],
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						DonGia = (Int64)reader["DonGia"],
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						GhiChu = reader["GhiChu"].ToString()
					};
					kq.Add(ctphieu);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListChiTietPhieuEntity SelectByMaPhieu(Int64 maphieu, out Int64 tongtien)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_ChiTietPhieu_SelectByMaPhieu]";

			SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
			param.Value = maphieu;
			command.Parameters.Add(param);

			ListChiTietPhieuEntity kq = new ListChiTietPhieuEntity();
			tongtien = 0;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				ChiTietPhieuEntity ctphieu = null;
				while (reader.Read())
				{
					ctphieu = new ChiTietPhieuEntity()
					{
						IDChiTietPhieu = (Int64)reader["IDChiTietPhieu"],
						MaPhieu = maphieu,
						MaHang = (Int32)reader["MaHang"],
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						Soluong = (Int32)reader["Soluong"],
						DonGia = (Int64)reader["DonGia"],
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						GhiChu = reader["GhiChu"].ToString()
					};
					kq.Add(ctphieu);
					tongtien += ctphieu.DonGia * ctphieu.Soluong;
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int64 Insert(ChiTietPhieuEntity chitietphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_ChiTietPhieu_Insert]";

			SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
			param.Value = chitietphieu.MaPhieu;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
			param.Value = chitietphieu.MaHang;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
			param.Value = chitietphieu.MaKieuGiat;
			command.Parameters.Add(param);

			param = new SqlParameter("@Soluong", SqlDbType.Int, 4);
			param.Value = chitietphieu.Soluong;
			command.Parameters.Add(param);

			param = new SqlParameter("@DonGia", SqlDbType.BigInt, 8);
			param.Value = chitietphieu.DonGia;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(chitietphieu.GhiChu))
			{
				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50);
				param.Value = chitietphieu.GhiChu;
				command.Parameters.Add(param);
			}
			return Int64.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(ChiTietPhieuEntity chitietphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_ChiTietPhieu_Update";

			SqlParameter param = new SqlParameter("@IDChiTietPhieu", SqlDbType.BigInt, 8);
			param.Value = chitietphieu.IDChiTietPhieu;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
			param.Value = chitietphieu.MaHang;
			command.Parameters.Add(param);

			param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
			param.Value = chitietphieu.MaKieuGiat;
			command.Parameters.Add(param);

			param = new SqlParameter("@Soluong", SqlDbType.Int, 4);
			param.Value = chitietphieu.Soluong;
			command.Parameters.Add(param);

			param = new SqlParameter("@DonGia", SqlDbType.BigInt, 8);
			param.Value = chitietphieu.DonGia;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(chitietphieu.GhiChu))
			{
				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50);
				param.Value = chitietphieu.GhiChu;
				command.Parameters.Add(param);
			}

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int64 IDChiTietPhieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_ChiTietPhieu_Delete";

			SqlParameter param = new SqlParameter("@IDChiTietPhieu", SqlDbType.BigInt, 8);
			param.Value = IDChiTietPhieu;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}
	}
}
