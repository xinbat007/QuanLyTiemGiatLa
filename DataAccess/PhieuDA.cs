using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class PhieuDA
    {
        public static PhieuEntity SelectByMaPhieu(Int64 maphieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_SelectByMaPhieu]";

            SqlParameter param = new SqlParameter("@maphieu", SqlDbType.BigInt, 8);
            param.Value = maphieu;
            command.Parameters.Add(param);

            PhieuEntity phieu = new PhieuEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    phieu.MaPhieu = maphieu;
                    phieu.MaKhachHang = reader["MaKhachHang"] == DBNull.Value ? 0 : (Int64)reader["MaKhachHang"];
                    phieu.NgayLap = (DateTime)reader["NgayLap"];
                    phieu.NgayHenTra = (DateTime)reader["NgayHenTra"];
                    if (reader["GiamGia"] != DBNull.Value)
                        phieu.GiamGia = Convert.ToInt32(reader["GiamGia"]);
                    phieu.DaThanhToan = (Boolean)reader["DaThanhToan"];
                    phieu.DaTraDo = (Boolean)reader["DaTraDo"];
                    if (reader["GhiChu"] != DBNull.Value)
                        phieu.GhiChu = reader["GhiChu"].ToString();
                    phieu.UserName = reader["UserName"].ToString();
                    phieu.TongTien = DUtils.ReadInt64(reader["TongTien"]);
                    phieu.SoLanIn = DUtils.ReadInt32(reader["SoLanIn"]);
                    phieu.PhiGiaoNhan = DUtils.ReadInt32(reader["PhiGiaoNhan"]);
                }
                reader.Close();
            }
            command.Connection.Close();
            return phieu;
        }

        public static ListPhieuEntity SelectNangCao(Boolean tatca, Boolean datrado, Int64 maphieu, String dienthoai,
                                        String tenkhachhang, Boolean timtheongay, DateTime tungay, DateTime denngay)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_SearchNangCao]";

            if (!tatca)
            {
                SqlParameter param = new SqlParameter("@DaTraDo", SqlDbType.Bit, 1);
                param.Value = datrado;
                command.Parameters.Add(param);

                if (maphieu != 0)
                {
                    param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
                    param.Value = maphieu;
                    command.Parameters.Add(param);
                }

                if (!String.IsNullOrEmpty(dienthoai))
                {
                    param = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
                    param.Value = dienthoai;
                    command.Parameters.Add(param);
                }

                if (!String.IsNullOrEmpty(tenkhachhang))
                {
                    param = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 100);
                    param.Value = tenkhachhang;
                    command.Parameters.Add(param);
                }

                if (timtheongay)
                {
                    param = new SqlParameter("@tungay", SqlDbType.DateTime);
                    param.Value = tungay;
                    command.Parameters.Add(param);

                    param = new SqlParameter("@denngay", SqlDbType.DateTime);
                    param.Value = denngay;
                    command.Parameters.Add(param);
                }
            }

            ListPhieuEntity kq = new ListPhieuEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                PhieuEntity phieu = null;
                while (reader.Read())
                {
                    phieu = new PhieuEntity();
                    phieu.MaPhieu = (Int64)reader["MaPhieu"];
                    phieu.MaKhachHang = DUtils.ReadInt64(reader["MaKhachHang"]);
                    phieu.TenKhachHang = reader["TenKhachHang"].ToString();
                    phieu.NgayLap = (DateTime)reader["NgayLap"];
                    phieu.NgayHenTra = (DateTime)reader["NgayHenTra"];
                    phieu.GiamGia = DUtils.ReadInt32(reader["GiamGia"]);
                    phieu.DaThanhToan = (Boolean)reader["DaThanhToan"];
                    phieu.DaTraDo = (Boolean)reader["DaTraDo"];
                    phieu.TongTien = DUtils.ReadInt64(reader["TongTien"]);
                    phieu.GhiChu = DUtils.ReadString(reader["GhiChu"]);
                    phieu.UserName = DUtils.ReadString(reader["UserName"]);
                    phieu.PhiGiaoNhan = DUtils.ReadInt32(reader["PhiGiaoNhan"]);
                    phieu.IsPhieuHuy = DUtils.ReadBoolean(reader["IsPhieuHuy"]);
                    kq.Add(phieu);
                }
                reader.Close();
            }
            command.Connection.Close();
            kq.Sort(delegate (PhieuEntity p1, PhieuEntity p2)
            {
                return p1.MaPhieu.CompareTo(p2.MaPhieu);
            });
            return kq;
        }

        public static ListPhieuEntity SelectByNgayLap(DateTime tungay, DateTime denngay)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_Phieu_SelectByNgayLap";

            SqlParameter param = new SqlParameter("@TuNgay", SqlDbType.DateTime);
            param.Value = tungay;
            command.Parameters.Add(param);

            param = new SqlParameter("@DenNgay", SqlDbType.DateTime);
            param.Value = denngay;
            command.Parameters.Add(param);

            ListPhieuEntity kq = new ListPhieuEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                PhieuEntity phieu = null;
                while (reader.Read())
                {
                    phieu = new PhieuEntity();
                    phieu.MaPhieu = Convert.ToInt64(reader["MaPhieu"]);
                    phieu.MaKhachHang = reader["MaKhachHang"] == DBNull.Value ? 0 : (Int64)reader["MaKhachHang"];
                    phieu.TenKhachHang = reader["TenKhachHang"].ToString();
                    phieu.NgayLap = (DateTime)reader["NgayLap"];
                    phieu.NgayHenTra = (DateTime)reader["NgayHenTra"];
                    if (reader["GiamGia"] != DBNull.Value)
                        phieu.GiamGia = Convert.ToInt32(reader["GiamGia"]);
                    phieu.DaThanhToan = (Boolean)reader["DaThanhToan"];
                    phieu.DaTraDo = (Boolean)reader["DaTraDo"];
                    phieu.TongTien = DUtils.ReadInt64(reader["TongTien"]);
                    if (reader["GhiChu"] != DBNull.Value)
                        phieu.GhiChu = reader["GhiChu"].ToString();
                    phieu.UserName = reader["UserName"].ToString();
                    phieu.PhiGiaoNhan = DUtils.ReadInt32(reader["PhiGiaoNhan"]);
                    phieu.IsPhieuHuy = DUtils.ReadBoolean(reader["IsPhieuHuy"]);
                    kq.Add(phieu);
                }
                reader.Close();
            }
            command.Connection.Close();
            return kq;
        }

        public static ListPhieuEntity SelectByTuPhieuDenPhieu(Int64 tuphieu, Int64 denphieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_SelectBy_TuPhieu_DenPhieu]";

            SqlParameter param = new SqlParameter("@tuphieu", SqlDbType.BigInt);
            param.Value = tuphieu;
            command.Parameters.Add(param);

            param = new SqlParameter("@denphieu", SqlDbType.BigInt);
            param.Value = denphieu;
            command.Parameters.Add(param);

            ListPhieuEntity kq = new ListPhieuEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                PhieuEntity phieu = null;
                while (reader.Read())
                {
                    phieu = new PhieuEntity();
                    phieu.MaPhieu = Convert.ToInt64(reader["MaPhieu"]);
                    phieu.MaKhachHang = reader["MaKhachHang"] == DBNull.Value ? 0 : (Int64)reader["MaKhachHang"];
                    phieu.TenKhachHang = reader["TenKhachHang"].ToString();
                    phieu.NgayLap = (DateTime)reader["NgayLap"];
                    phieu.NgayHenTra = (DateTime)reader["NgayHenTra"];
                    if (reader["GiamGia"] != DBNull.Value)
                        phieu.GiamGia = Convert.ToInt32(reader["GiamGia"]);
                    phieu.DaThanhToan = (Boolean)reader["DaThanhToan"];
                    phieu.DaTraDo = (Boolean)reader["DaTraDo"];
                    phieu.TongTien = DUtils.ReadInt64(reader["TongTien"]);
                    if (reader["GhiChu"] != DBNull.Value)
                        phieu.GhiChu = reader["GhiChu"].ToString();
                    phieu.UserName = reader["UserName"].ToString();
                    phieu.PhiGiaoNhan = DUtils.ReadInt32(reader["PhiGiaoNhan"]);
                    phieu.IsPhieuHuy = DUtils.ReadBoolean(reader["IsPhieuHuy"]);
                    kq.Add(phieu);
                }
                reader.Close();
            }
            command.Connection.Close();
            return kq;
        }

        public static Int64 SelectSumTongTienByMaPhieu(Int64 tuphieu, Int64 denphieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT SUM (TongTien) FROM dbo.Phieu
	WHERE (IsPhieuHuy IS NULL OR IsPhieuHuy=0)
    AND
	MaPhieu >= @TuPhieu
	AND
	MaPhieu <= @DenPhieu";// "[dbo].[sp_Phieu_SelectTongTienByMaPhieu]";

            SqlParameter param = new SqlParameter("@TuPhieu", SqlDbType.BigInt);
            param.Value = tuphieu;
            command.Parameters.Add(param);

            param = new SqlParameter("@DenPhieu", SqlDbType.BigInt);
            param.Value = denphieu;
            command.Parameters.Add(param);

            Int64 kq = 0;
            Int64.TryParse(command.ExecuteScalar().ToString(), out kq);
            command.Connection.Close();
            return kq;
        }

        public static string SelectMaPhieuHuy(Int64 tuphieu, Int64 denphieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT maphieu FROM dbo.Phieu
	WHERE IsPhieuHuy=1
    AND
	MaPhieu >= @TuPhieu
	AND
	MaPhieu <= @DenPhieu";

            SqlParameter param = new SqlParameter("@TuPhieu", SqlDbType.BigInt);
            param.Value = tuphieu;
            command.Parameters.Add(param);

            param = new SqlParameter("@DenPhieu", SqlDbType.BigInt);
            param.Value = denphieu;
            command.Parameters.Add(param);

            string kq = string.Empty;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    kq += reader[0] + ", ";
                }
                reader.Close();
            }
            command.Connection.Close();
            return kq.TrimEnd(',', ' ');
        }

        public static Int64 SelectMaxMaPhieu()
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_SelectByMaxMaPhieu]";

            Int64 kq = 0;
            Int64.TryParse(command.ExecuteScalar().ToString(), out kq);
            command.Connection.Close();
            return kq;
        }

        public static Int64 Insert(PhieuEntity phieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_Phieu_Insert";

            SqlParameter param = new SqlParameter("@NgayLap", SqlDbType.DateTime);
            param.Value = phieu.NgayLap;
            command.Parameters.Add(param);

            if (phieu.MaKhachHang != 0)
            {
                param = new SqlParameter("@MaKhachHang", SqlDbType.BigInt, 8);
                param.Value = phieu.MaKhachHang;
                command.Parameters.Add(param);
            }

            param = new SqlParameter("@NgayHenTra", SqlDbType.DateTime);
            param.Value = phieu.NgayHenTra;
            command.Parameters.Add(param);

            param = new SqlParameter("@GiamGia", SqlDbType.Int, 4);
            param.Value = phieu.GiamGia;
            command.Parameters.Add(param);

            param = new SqlParameter("@DaThanhToan", SqlDbType.Bit, 1);
            param.Value = phieu.DaThanhToan;
            command.Parameters.Add(param);

            param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param.Value = phieu.UserName;
            command.Parameters.Add(param);

            param = new SqlParameter("@TongTien", SqlDbType.BigInt, 8);
            param.Value = phieu.TongTien;
            command.Parameters.Add(param);

            if (!String.IsNullOrEmpty(phieu.GhiChu))
            {
                param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 200);
                param.Value = phieu.GhiChu;
                command.Parameters.Add(param);
            }

            if (phieu.PhiGiaoNhan > 0)
            {
                param = new SqlParameter("@PhiGiaoNhan", SqlDbType.Int, 4);
                param.Value = phieu.PhiGiaoNhan;
                command.Parameters.Add(param);
            }

            return Convert.ToInt64(command.ExecuteScalar());
        }

        public static Int32 Delete(Int64 maphieu, Boolean dathanhtoan, Boolean datrado)
        {
            SqlCommand command = DUtils.GetCommand();
            if (dathanhtoan && datrado)
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = @"DELETE FROM ChiTietPhieu WHERE MaPhieu=" + maphieu;
                command.ExecuteNonQuery();
            }
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_Delete]";
            SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
            param.Value = maphieu;
            command.Parameters.Add(param);
            return command.ExecuteNonQuery();
        }

        public static Int32 UpdateDaTraDo(Int64 maphieu)    // update datrado=1, dathanhtoan=1
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_UpdateDaTraDo]";

            SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
            param.Value = maphieu;
            command.Parameters.Add(param);

            param = new SqlParameter("@DaTraDo", SqlDbType.Bit, 1);
            param.Value = true;
            command.Parameters.Add(param);

            return command.ExecuteNonQuery();
        }

        public static Int32 UpdateDaHuyPhieu(Int64 maphieu)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update phieu set isphieuhuy=1 where maphieu=" + maphieu;

            return command.ExecuteNonQuery();
        }

        public static Int32 UpdateSoLanIn(Int64 maphieu, Int32 solanin)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Phieu_UpdateSoLanIn]";

            SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
            param.Value = maphieu;
            command.Parameters.Add(param);

            param = new SqlParameter("@SoLanIn", SqlDbType.Int);
            param.Value = solanin;
            command.Parameters.Add(param);

            return command.ExecuteNonQuery();
        }

    }
}
