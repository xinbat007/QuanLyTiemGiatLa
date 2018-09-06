using System;
using Entity;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace DataAccess
{
	public class KhachHangDA
	{
		public static ListKhachHangEntity SelectAll(DateTime tungay, DateTime denngay, Boolean tatca)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_SelectAll";

			ListKhachHangEntity kq = new ListKhachHangEntity();
			Dictionary<long, KhachHangEntity> dic = new Dictionary<long, KhachHangEntity>();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					KhachHangEntity khachhang = new KhachHangEntity()
					{
						MaKhachHang = (Int64)reader["MaKhachHang"],
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == DBNull.Value ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == DBNull.Value ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					};
					kq.Add(khachhang);
					dic.Add(khachhang.MaKhachHang, khachhang);
				}
				reader.Close();
			}
			command.Connection.Close();
			//---------------------------
			ListPhieuEntity listPhieu = SelectPhieuByNgayLap(tungay, denngay, tatca);
			foreach (PhieuEntity phieu in listPhieu)
			{
				if (phieu.MaKhachHang == 0 && !dic.ContainsKey(0))
				{
					KhachHangEntity empty = new KhachHangEntity();
					dic.Add(0, empty);
					kq.Add(empty);
				}
				if (phieu.DaThanhToan)
				{
					dic[phieu.MaKhachHang].DaTungThanhToan += phieu.TongTien;
				}
			}
			return kq;
		}

		private static ListPhieuEntity SelectPhieuByNgayLap(DateTime tungay, DateTime denngay, Boolean tatca)
		{
            string strSQL = @"SELECT
	MaKhachHang,
	GiamGia,
	TongTien
	FROM dbo.Phieu
	WHERE DaThanhToan = 1 and (IsPhieuHuy is null or IsPhieuHuy=0) ";

			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.Text;

			if (!tatca)
			{
                strSQL += " AND datediff(day, CAST(@TuNgay AS VARCHAR), NgayLap) >= 0";
			    strSQL += " AND	datediff(day, CAST(@DenNgay AS VARCHAR), NgayLap) <= 0";

				SqlParameter param = new SqlParameter("@TuNgay", SqlDbType.DateTime);
				param.Value = tungay;
				command.Parameters.Add(param);

				param = new SqlParameter("@DenNgay", SqlDbType.DateTime);
				param.Value = denngay;
				command.Parameters.Add(param);
            }
            command.CommandText = strSQL; //"[dbo].[sp_KhachHang_Phieu_SelectByNgayLap]";

			ListPhieuEntity kq = new ListPhieuEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
                    //bool isphieuhuy = DUtils.ReadBoolean(reader["IsPhieuHuy"]);
                    //if (!isphieuhuy)
				    kq.Add(new PhieuEntity()
				    {
					    MaKhachHang = reader["MaKhachHang"] == DBNull.Value ? 0 : Convert.ToInt64(reader["MaKhachHang"]),
					    GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : Convert.ToInt32(reader["GiamGia"]),
					    TongTien = DUtils.ReadInt64(reader["TongTien"]),
					    DaThanhToan = true	// trong câu select đã select những phiếu đã thanh toán rồi
				    });
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static KhachHangEntity SelectByMaKhachHang(Int64 makh)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_SelectByMaKhachHang";

			SqlParameter param = new SqlParameter("@MaKhachHang", SqlDbType.BigInt, 8);
			param.Value = makh;
			command.Parameters.Add(param);

			KhachHangEntity kq = null;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq = new KhachHangEntity()
					{
						MaKhachHang = makh,
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == null ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == null ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32)reader["GiamGia"],
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					};
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static KhachHangEntity SelectBySoTheVip(String sothevip, out Int32 kqTimthay)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_SelectBySoTheVip";

			SqlParameter param = new SqlParameter("@SoTheVip", SqlDbType.VarChar);
			param.Value = sothevip;
			command.Parameters.Add(param);

			kqTimthay = 0;
			KhachHangEntity kq = null;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq = new KhachHangEntity()
					{
						MaKhachHang = DUtils.ReadInt64("MaKhachHang"),
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == null ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == null ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32)reader["GiamGia"],
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					};
					kqTimthay++;
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static KhachHangEntity SelectByMaPhieu(Int64 maphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.Text;
			command.CommandText = "SELECT KhachHang.* FROM KhachHang INNER JOIN Phieu ON KhachHang.MaKhachHang = Phieu.MaKhachHang WHERE Phieu.MaPhieu=" + maphieu;

			KhachHangEntity kq = null;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					kq = new KhachHangEntity()
					{
						MaKhachHang = DUtils.ReadInt64(reader["MaKhachHang"]),
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == null ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == null ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						//TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						//GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32)reader["GiamGia"],
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					};
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListKhachHangEntity SearchByWhere(String where, DateTime tungay, DateTime denngay, Boolean tatca)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_KhachHang_SearchByWhere]";
			SqlParameter param = new SqlParameter("@where", SqlDbType.NVarChar, 400);
			param.Value = where;
			command.Parameters.Add(param);
			ListKhachHangEntity kq = new ListKhachHangEntity();
			Dictionary<long, KhachHangEntity> dic = new Dictionary<long, KhachHangEntity>();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					KhachHangEntity khachhang =new KhachHangEntity()
					{
						MaKhachHang = (Int64)reader["MaKhachHang"],
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == DBNull.Value ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == DBNull.Value ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					};
					kq.Add(khachhang);
					dic.Add(khachhang.MaKhachHang, khachhang);
				}
				reader.Close();
			}
			command.Connection.Close();
			//---------------------------
			ListPhieuEntity listPhieu = SelectPhieuByNgayLap(tungay, denngay, tatca);
			foreach (PhieuEntity phieu in listPhieu)
			{
				if (phieu.MaKhachHang == 0 && !dic.ContainsKey(0))
					dic.Add(0, new KhachHangEntity() { TenKhachHang = String.Empty });
				if (!dic.ContainsKey(phieu.MaKhachHang)) continue;
				if (phieu.DaThanhToan)
				{
					dic[phieu.MaKhachHang].DaTungThanhToan += phieu.TongTien;
				}
			}
			return kq;
		}

		public static ListKhachHangEntity Search(KhachHangEntity khachhang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_KhachHang_Search]";

			SqlParameter param = null;
			if (!String.IsNullOrEmpty(khachhang.TenKhachHang))
			{
				param = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 100);
				param.Value = khachhang.TenKhachHang;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.DiaChi))
			{
				param = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
				param.Value = khachhang.DiaChi;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.DienThoai))
			{
				param = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
				param.Value = khachhang.DienThoai;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.SoTheVip))
			{
				param = new SqlParameter("@SoTheVip", SqlDbType.VarChar);
				param.Value = khachhang.SoTheVip;
				command.Parameters.Add(param);
			}

			ListKhachHangEntity kq = new ListKhachHangEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new KhachHangEntity()
					{
						MaKhachHang = (Int64)reader["MaKhachHang"],
						TenKhachHang = reader["TenKhachHang"].ToString(),
						DiaChi = reader["DiaChi"] == DBNull.Value ? String.Empty : reader["DiaChi"].ToString(),
						DienThoai = reader["DienThoai"] == DBNull.Value ? String.Empty : reader["DienThoai"].ToString(),
						MaVip = reader["MaVip"] == DBNull.Value ? 0 : (Int32)reader["MaVip"],
						TenVip = reader["TenVip"] == DBNull.Value ? String.Empty : reader["TenVip"].ToString(),
						GiamGia = reader["GiamGia"] == DBNull.Value ? 0 : (Int32)reader["GiamGia"],
						SoTheVip = DUtils.ReadString(reader["SoTheVip"])
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int64 Insert(KhachHangEntity khachhang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_Insert";
			SqlParameter param = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 100);
			param.Value = khachhang.TenKhachHang;
			command.Parameters.Add(param);
			if (!String.IsNullOrEmpty(khachhang.DiaChi))
			{
				param = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
				param.Value = khachhang.DiaChi;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.DienThoai))
			{
				param = new SqlParameter("@DienThoai", SqlDbType.NVarChar, 20);
				param.Value = khachhang.DienThoai;
				command.Parameters.Add(param);
			}
			if (khachhang.MaVip > 0)
			{
				param = new SqlParameter("@MaVip", SqlDbType.Int, 4);
				param.Value = khachhang.MaVip;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.SoTheVip))
			{
				param = new SqlParameter("@SoTheVip", SqlDbType.VarChar);
				param.Value = khachhang.SoTheVip;
				command.Parameters.Add(param);
			}
			return Int64.Parse(command.ExecuteScalar().ToString());
		}

		public static Int32 Update(KhachHangEntity khachhang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_Update";

			SqlParameter param = new SqlParameter("@MaKhachHang", SqlDbType.BigInt);
			param.Value = khachhang.MaKhachHang;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(khachhang.TenKhachHang))
			{
				param = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 100);
				param.Value = khachhang.TenKhachHang;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.DiaChi))
			{
				param = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 200);
				param.Value = khachhang.DiaChi;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.DienThoai))
			{
				param = new SqlParameter("@DienThoai", SqlDbType.NVarChar, 20);
				param.Value = khachhang.DienThoai;
				command.Parameters.Add(param);
			}
			if (khachhang.MaVip > 0)
			{
				param = new SqlParameter("@MaVip", SqlDbType.Int, 4);
				param.Value = khachhang.MaVip;
				command.Parameters.Add(param);
			}
			if (!String.IsNullOrEmpty(khachhang.SoTheVip))
			{
				param = new SqlParameter("@SoTheVip", SqlDbType.VarChar);
				param.Value = khachhang.SoTheVip;
				command.Parameters.Add(param);
			}
			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(Int64 MaKhachHang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_KhachHang_Delete";
			SqlParameter param = new SqlParameter("@MaKhachHang", SqlDbType.BigInt);
			param.Value = MaKhachHang;
			command.Parameters.Add(param);
			return command.ExecuteNonQuery();
		}


	}
}
