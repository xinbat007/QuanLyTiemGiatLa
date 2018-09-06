using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class UserDA
	{
		public static ListUserEntity SelectAll()
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_SelectAll]";

			ListUserEntity kq = new ListUserEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					kq.Add(new UserEntity()
					{
						UserName = reader["UserName"].ToString(),
						Password = reader["Password"].ToString(),
						HoTen = reader["HoTen"].ToString(),
						Quyen = DUtils.ReadByte(reader["Quyen"]),
						QuyenHan = DUtils.ReadString(reader["QuyenHan"])
					});
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static UserEntity SelectByUserName(String username)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_SelectByUserName]";

			SqlParameter param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
			param.Value = username;
			command.Parameters.Add(param);

			UserEntity kq = null;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					kq = new UserEntity()
					{
						UserName = username,
						Password = DUtils.ReadString(reader["Password"]),
						HoTen = DUtils.ReadString(reader["HoTen"]),
						Quyen = DUtils.ReadByte(reader["Quyen"]),
						QuyenHan = DUtils.ReadString(reader["QuyenHan"])
					};
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static Int32 Insert(UserEntity user)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_Insert]";

			SqlParameter param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
			param.Value = user.UserName;
			command.Parameters.Add(param);

			param = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
			param.Value = user.Password;
			command.Parameters.Add(param);

			param = new SqlParameter("@Quyen", SqlDbType.TinyInt, 2);
			param.Value = user.Quyen;
			command.Parameters.Add(param);

			param = new SqlParameter("@HoTen", SqlDbType.NVarChar, 50);
			param.Value = user.HoTen;
			command.Parameters.Add(param);

			param = new SqlParameter("@QuyenHan", SqlDbType.VarChar, 30);
			param.Value = user.QuyenHan;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 Update(UserEntity user)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_Update]";

			SqlParameter param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
			param.Value = user.UserName;
			command.Parameters.Add(param);

			param = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
			param.Value = user.Password;
			command.Parameters.Add(param);

			param = new SqlParameter("@Quyen", SqlDbType.TinyInt, 2);
			param.Value = user.Quyen;
			command.Parameters.Add(param);

			param = new SqlParameter("@HoTen", SqlDbType.NVarChar, 50);
			param.Value = user.HoTen;
			command.Parameters.Add(param);

			param = new SqlParameter("@QuyenHan", SqlDbType.VarChar, 30);
			param.Value = user.QuyenHan;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 ChangePass(String username, String password)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_ChangePass]";

			SqlParameter param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
			param.Value = username;
			command.Parameters.Add(param);

			param = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
			param.Value = password;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}

		public static Int32 Delete(String username)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_User_Delete]";

			SqlParameter param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
			param.Value = username;
			command.Parameters.Add(param);

			return command.ExecuteNonQuery();
		}
	}
}
