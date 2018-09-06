using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class ChotKetDA
	{
		public static ListChotKetEntity Select(Boolean tatca, DateTime tungay, DateTime denngay)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_ChotKet_Select]";

			if (!tatca)
			{
				SqlParameter param = new SqlParameter("@tungay", SqlDbType.DateTime);
				param.Value = tungay;
				command.Parameters.Add(param);

				param = new SqlParameter("@denngay", SqlDbType.DateTime);
				param.Value = denngay;
				command.Parameters.Add(param);
			}

			ListChotKetEntity kq = new ListChotKetEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new ChotKetEntity()
					{
						MaChotKet = DUtils.ReadInt32(reader["MaChotKet"]),
						ThoiDiemChot = DUtils.ReadDateTime(reader["ThoiDiemChot"]),
						TuPhieu = DUtils.ReadInt64(reader["TuPhieu"]),
						DenPhieu = DUtils.ReadInt64(reader["DenPhieu"]),
						SoTienChot = DUtils.ReadInt64(reader["SoTienChot"]),
						NguoiChot = DUtils.ReadString(reader["NguoiChot"]),
						GhiChu = DUtils.ReadString(reader["GhiChu"])
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(ChotKetEntity chotket)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_ChotKet_Insert]";

			SqlParameter param = new SqlParameter("@ThoiDiemChot", SqlDbType.DateTime);
			param.Value = chotket.ThoiDiemChot;
			command.Parameters.Add(param);

			param = new SqlParameter("@TuPhieu", SqlDbType.BigInt);
			param.Value = chotket.TuPhieu;
			command.Parameters.Add(param);

			param = new SqlParameter("@DenPhieu", SqlDbType.BigInt);
			param.Value = chotket.DenPhieu;
			command.Parameters.Add(param);

			param = new SqlParameter("@SoTienChot", SqlDbType.BigInt);
			param.Value = chotket.SoTienChot;
			command.Parameters.Add(param);

			param = new SqlParameter("@NguoiChot", SqlDbType.VarChar, 50);
			param.Value = chotket.NguoiChot;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(chotket.GhiChu))
			{
				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 200);
				param.Value = chotket.GhiChu;
				command.Parameters.Add(param);
			}

			return Int32.Parse(command.ExecuteScalar().ToString());
		}
	}
}
