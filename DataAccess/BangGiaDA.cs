using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class BangGiaDA
    {
        public static ListBangGiaEntity SelectAll()
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_BangGia_SelectAll]";

            ListBangGiaEntity kq = new ListBangGiaEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    kq.Add(new BangGiaEntity()
                    {
                        DonGia = (Int64)reader["DonGia"],
                        IDGia = (Int32)reader["IDGia"],
                        MaHang = (Int32)reader["MaHang"],
                        MaKieuGiat = (Int32)reader["MaKieuGiat"],
                        SoSanPham = DUtils.ReadByte(reader["SoSanPham"]),
                        TenHang = reader["TenHang"].ToString(),
                        TenKieuGiat = reader["TenKieuGiat"].ToString()
                    });
                }
                reader.Close();
            }
            command.Connection.Close();
            return kq;
        }

        public static Int32 CheckExist(Int32 idgia, Int32 mahang, Int32 makieugiat)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_BangGia_CheckExist]";

            SqlParameter param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
            param.Value = mahang;
            command.Parameters.Add(param);

            param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
            param.Value = makieugiat;
            command.Parameters.Add(param);

            if (idgia != 0)
            {
                param = new SqlParameter("@IDGia", SqlDbType.Int, 4);
                param.Value = idgia;
                command.Parameters.Add(param);
            }

            return Int32.Parse(command.ExecuteScalar().ToString());
        }

        public static Int32 Insert(BangGiaEntity banggia)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_BangGia_Insert";

            SqlParameter param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
            param.Value = banggia.MaHang;
            command.Parameters.Add(param);

            param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
            param.Value = banggia.MaKieuGiat;
            command.Parameters.Add(param);

            param = new SqlParameter("@DonGia", SqlDbType.BigInt, 8);
            param.Value = banggia.DonGia;
            command.Parameters.Add(param);

            param = new SqlParameter("@SoSanPham", SqlDbType.TinyInt);
            param.Value = banggia.SoSanPham;
            command.Parameters.Add(param);

            return Int32.Parse(command.ExecuteScalar().ToString());
        }

        public static Int32 Update(BangGiaEntity banggia)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_BangGia_Update";

            SqlParameter param = new SqlParameter("@MaHang", SqlDbType.Int, 4);
            param.Value = banggia.MaHang;
            command.Parameters.Add(param);

            param = new SqlParameter("@MaKieuGiat", SqlDbType.Int, 4);
            param.Value = banggia.MaKieuGiat;
            command.Parameters.Add(param);

            param = new SqlParameter("@DonGia", SqlDbType.BigInt, 8);
            param.Value = banggia.DonGia;
            command.Parameters.Add(param);

            param = new SqlParameter("@SoSanPham", SqlDbType.TinyInt);
            param.Value = banggia.SoSanPham;
            command.Parameters.Add(param);

            param = new SqlParameter("@IDGia", SqlDbType.Int, 4);
            param.Value = banggia.IDGia;
            command.Parameters.Add(param);

            return command.ExecuteNonQuery();
        }

        public static Int32 Delete(Int32 idgia)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_BangGia_Delete";
            SqlParameter param = new SqlParameter("@IDGia", SqlDbType.Int, 4);
            param.Value = idgia;
            command.Parameters.Add(param);
            return command.ExecuteNonQuery();
        }

    }
}
