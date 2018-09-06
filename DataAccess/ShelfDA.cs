
using System;
using Entity;
using System.Data.SqlClient;
using System.Data;
namespace DataAccess
{
	public class ShelfDA
	{
		public static ListShelfEntity SelectSlotByMaKho(Int32 makho)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Shelf_SelectByMaKho]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = makho;
			command.Parameters.Add(param);

			ListShelfEntity kq = new ListShelfEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new ShelfEntity()
					{
						MaKho = makho,
						Slot = (Int32)reader["Slot"]
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static void Insert(Int32 makho, Int32 soluongslot)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Shelf_Insert]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = makho;
			command.Parameters.Add(param);

			param = new SqlParameter("@Slot", SqlDbType.Int, 4);
			command.Parameters.Add(param);
			for (int i = 1; i <=  soluongslot; i++)
			{
				param.Value = i;
				try
				{
					command.ExecuteNonQuery();
				}
				catch
				{
				}
			}
			command.CommandText = "[dbo].[sp_Shelf_DeleteBigger]";
			command.ExecuteNonQuery();
		}

		public static ListShelfEntity SelectSlotChuaSuDungByMaKho(Int32 makho)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Shelf_SelectByMaKho]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = makho;
			command.Parameters.Add(param);

			ListShelfEntity kq = new ListShelfEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					if (String.IsNullOrEmpty(reader["MaCacPhieuDangSuDung"].ToString()))
					{
						kq.Add(new ShelfEntity()
						{
							MaKho = makho,
							Slot = (Int32)reader["Slot"]
						});
					}
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Boolean CheckIsExist(Int32 makho, Int32 slot, out String macacphieudangsudung)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Shelf_IsExist]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = makho;
			command.Parameters.Add(param);

			param = new SqlParameter("@Slot", SqlDbType.Int, 4);
			param.Value = slot;
			command.Parameters.Add(param);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{				
				macacphieudangsudung = reader["MaCacPhieuDangSuDung"].ToString();
				reader.Close();
				return true;
			}
			else
			{
				reader.Close();
				macacphieudangsudung = String.Empty;
				return false;
			}
			
		}

		public static Int32 Update(Int32 makho, Int32 slot, String MaCacPhieuDangSuDung)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_Shelf_Update]";

			SqlParameter param = new SqlParameter("@MaKho", SqlDbType.Int, 4);
			param.Value = makho;
			command.Parameters.Add(param);

			param = new SqlParameter("@Slot", SqlDbType.Int, 4);
			param.Value = slot;
			command.Parameters.Add(param);

			if (!String.IsNullOrEmpty(MaCacPhieuDangSuDung))
			{
				param = new SqlParameter("@MaCacPhieuDangSuDung", SqlDbType.VarChar, 100);
				param.Value = MaCacPhieuDangSuDung;
				command.Parameters.Add(param);
			}
			return command.ExecuteNonQuery();
		}
	}
}
