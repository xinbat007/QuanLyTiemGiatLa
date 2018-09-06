
using Entity;
using System.Data.SqlClient;
using System;
using System.Data;

namespace DataAccess
{
	public class InformationDA
	{
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
