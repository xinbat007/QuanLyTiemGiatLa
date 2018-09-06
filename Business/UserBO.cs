using System;
using Entity;

namespace Business
{
	public class UserBO
	{
		public static ListUserEntity SelectAll()
		{
			return DataAccess.UserDA.SelectAll();
		}

		public static UserEntity SelectByUserName(String username)
		{
			return DataAccess.UserDA.SelectByUserName(username);
		}

		public static Int32 Insert(UserEntity user)
		{
			return DataAccess.UserDA.Insert(user);
		}

		public static Int32 Update(UserEntity user)
		{
			return DataAccess.UserDA.Update(user);
		}

		public static Int32 ChangePass(String username, String password)
		{
			return DataAccess.UserDA.ChangePass(username, password);
		}

		public static Int32 Delete(String username)
		{
			return DataAccess.UserDA.Delete(username);
		}
	}
}
