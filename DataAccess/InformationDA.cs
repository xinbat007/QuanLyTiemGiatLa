
using Entity;
using System.Data.SqlClient;
using System;
using System.Data;

namespace DataAccess
{
    public class InformationDA
    {
        public static void Insert1RowIfNeeded()
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT count(*) FROM dbo.Information";

            int count = Int32.Parse(command.ExecuteScalar().ToString());
            if (count == 0)
            {
                command.CommandText = "INSERT INTO dbo.[Information](PhieuChotKetGanNhat) VALUES(0)";
                command.ExecuteNonQuery();
            }
            command.Connection.Close();
        }

        public static InformationEntity Select()
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Information_Select]";

            InformationEntity kq = new InformationEntity();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    kq.PhieuChotKetGanNhat = DUtils.ReadInt64(reader["PhieuChotKetGanNhat"]);
                }
                reader.Close();
            }
            command.Connection.Close();
            return kq;
        }

        public static Int32 UpdatePhieuChotKetGanNhat(InformationEntity information)
        {
            SqlCommand command = DUtils.GetCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[sp_Information_Update_PhieuChotKetGanNhat]";

            SqlParameter param = new SqlParameter("@PhieuChotKetGanNhat", SqlDbType.BigInt);
            param.Value = information.PhieuChotKetGanNhat;
            command.Parameters.Add(param);

            return command.ExecuteNonQuery();
        }
    }
}
