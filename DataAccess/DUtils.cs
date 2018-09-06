using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class DUtils
	{
		private static String _conStr = Entity.Common.connectionString;
		private static SqlConnection _connecion;
		private static SqlCommand _command;

		private static SqlConnection GetConnection()
		{
			if (_connecion == null)	_connecion = new SqlConnection(_conStr);
			if (_connecion.State == System.Data.ConnectionState.Closed) _connecion.Open();
			return _connecion;
		}

		public static SqlCommand GetCommand()
		{
			if (_command == null) _command = new SqlCommand();
			_command.Connection = GetConnection();
			_command.Parameters.Clear();
			return _command;
		}

		public static Byte ReadByte(object reader)
		{
			if (reader == DBNull.Value) return 0;
			else return Convert.ToByte(reader);
		}

		public static Int16 ReadInt16(object reader)	// short
		{
			if (reader == DBNull.Value) return 0;
			else return Convert.ToInt16(reader);
		}

		public static Int32 ReadInt32(object reader)
		{
			if (reader == DBNull.Value) return 0;
			else return Convert.ToInt32(reader);
		}

		public static Int64 ReadInt64(object reader)
		{
			return reader == DBNull.Value ? 0 : Convert.ToInt64(reader);
		}

		public static String ReadString(object reader)
		{
			return reader == DBNull.Value ? String.Empty : reader.ToString();
		}

		public static Boolean ReadBoolean(object reader)
		{
			return reader == DBNull.Value ? false : Convert.ToBoolean(reader);
		}

		public static DateTime ReadDateTime(object reader)
		{
			return reader == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader);
		}

		public static object SetString(String s)
		{
			if (String.IsNullOrEmpty(s)) return DBNull.Value;
			else return s;
		}

		public static DataTable SelectBySql(String sql)
		{
			SqlCommand command = GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_SelectBySql";
			SqlParameter param = new SqlParameter("@sql", SqlDbType.NVarChar, 2000);
			param.Value = sql;
			command.Parameters.Add(param);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

	}
}
