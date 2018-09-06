using System;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
	public class PhieuSlotDA
	{
		public static ListPhieuSlotEntity SelectByMaPhieu(Int64 maphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_PhieuSlot_SelectByMaPhieu]";

			SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
			param.Value = maphieu;
			command.Parameters.Add(param);

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					phieuslot = new PhieuSlotEntity()
					{
						MaPhieu = maphieu,
						STT = (Int32)reader["STT"],
						MaHang = (Int32)reader["MaHang"],
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						Kho = reader["Kho"].ToString(),
						Slot = (Int32)reader["Slot"],
						GhiChu = DUtils.ReadString(reader["GhiChu"]),
						SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
						DaTra = (Boolean)reader["DaTra"],
						MaVach = DUtils.ReadInt64(reader["MaVach"]),
						NgayTra = DUtils.ReadString(reader["NgayTra"]),
						ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
					};
					kq.Add(phieuslot);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListPhieuSlotEntity SelectByMaPhieu_DaTra(Int64 maphieu)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_PhieuSlot_DaTra_SelectByMaPhieu]";

			SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
			param.Value = maphieu;
			command.Parameters.Add(param);

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					phieuslot = new PhieuSlotEntity()
					{
						MaPhieu = maphieu,
						STT = (Int32)reader["STT"],
						MaHang = (Int32)reader["MaHang"],
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						Kho = reader["Kho"].ToString(),
						Slot = (Int32)reader["Slot"],
						GhiChu = DUtils.ReadString(reader["GhiChu"]),
						SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
						DaTra = (Boolean)reader["DaTra"],
						MaVach = DUtils.ReadInt64(reader["MaVach"]),
						NgayTra = DUtils.ReadString(reader["NgayTra"]),
						ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
					};
					kq.Add(phieuslot);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListPhieuSlotEntity SelectByMaPhieu_TenDo(Int64 maphieu, string tendo, bool timtheongaytra, DateTime tungay, DateTime denngay, bool chuatra)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.Text;
			command.CommandText = @"SELECT
	pslot.*,
	MatHang.TenHang, 
	KieuGiatLa.TenKieuGiat
	FROM " + (chuatra ? "Phieu_Slot" : "Phieu_Slot_DaTra")
	+ @" pslot
	INNER JOIN MatHang		ON pslot.MaHang = MatHang.MaHang 
	INNER JOIN KieuGiatLa	ON pslot.MaKieuGiat = KieuGiatLa.MaKieuGiat
	INNER JOIN Phieu		ON pslot.MaPhieu = Phieu.MaPhieu
	WHERE 1=1";
			if(maphieu > 0)
				command.CommandText += " AND pslot.MaPhieu=" + maphieu;
			if (!string.IsNullOrEmpty(tendo))
				command.CommandText += " AND MatHang.TenHang LIKE N'%" + tendo + "%'";
			if (timtheongaytra)
			{
				command.CommandText += @" AND datediff(day, @tungay, NgayHenTra) >= 0 AND datediff(day, @denngay, NgayHenTra) <= 0";
				command.Parameters.Add(new SqlParameter("@tungay", tungay));
				command.Parameters.Add(new SqlParameter("@denngay", denngay));
			}

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					phieuslot = new PhieuSlotEntity()
					{
						MaPhieu = DUtils.ReadInt64(reader["MaPhieu"]),
						STT = (Int32)reader["STT"],
						MaHang = (Int32)reader["MaHang"],
						MaKieuGiat = (Int32)reader["MaKieuGiat"],
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						Kho = reader["Kho"].ToString(),
						Slot = (Int32)reader["Slot"],
						GhiChu = DUtils.ReadString(reader["GhiChu"]),
						SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
						DaTra = (Boolean)reader["DaTra"],
						MaVach = DUtils.ReadInt64(reader["MaVach"]),
						NgayTra = DUtils.ReadString(reader["NgayTra"]),
						ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
					};
					kq.Add(phieuslot);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListPhieuSlotEntity SelectByMaVach_TenDo(Int64 mavach, string tendo, bool timtheongaytra, DateTime tungay, DateTime denngay, bool chuatra)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.Text;
			command.CommandText = @"SELECT
	pslot.*,
	MatHang.TenHang, 
	KieuGiatLa.TenKieuGiat
	FROM " + (chuatra ? "Phieu_Slot" : "Phieu_Slot_DaTra") +
	@" pslot
	INNER JOIN MatHang		ON pslot.MaHang = MatHang.MaHang 
	INNER JOIN KieuGiatLa	ON pslot.MaKieuGiat = KieuGiatLa.MaKieuGiat
	INNER JOIN Phieu		ON pslot.MaPhieu = Phieu.MaPhieu
	WHERE 1=1";
			if (mavach > 0)
				command.CommandText += @" AND pslot.MaPhieu IN
	(SELECT pslot.MaPhieu FROM " + (chuatra ? "Phieu_Slot" : "Phieu_Slot_DaTra") + " pslot WHERE pslot.MaVach=" + mavach + ")";
			if (!string.IsNullOrEmpty(tendo))
				command.CommandText += " AND MatHang.TenHang LIKE N'" + tendo + "'";
			if (timtheongaytra)
			{
				command.CommandText += @" AND datediff(day, @tungay, NgayHenTra) >= 0 AND datediff(day, @denngay, NgayHenTra) <= 0";
				command.Parameters.Add(new SqlParameter("@tungay", tungay));
				command.Parameters.Add(new SqlParameter("@denngay", denngay));
			}

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					phieuslot = new PhieuSlotEntity()
					{
						MaPhieu = DUtils.ReadInt64(reader["MaPhieu"]),
						STT = DUtils.ReadInt32(reader["STT"]),
						MaHang = DUtils.ReadInt32(reader["MaHang"]),
						MaKieuGiat = DUtils.ReadInt32(reader["MaKieuGiat"]),
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						Kho = reader["Kho"].ToString(),
						Slot = DUtils.ReadInt32(reader["Slot"]),
						DaTra = DUtils.ReadBoolean(reader["DaTra"]),
						GhiChu = DUtils.ReadString(reader["GhiChu"]),
						SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
						MaVach = DUtils.ReadInt64(reader["MaVach"]),
						NgayTra = DUtils.ReadString(reader["NgayTra"]),
						ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
					};
					kq.Add(phieuslot);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListPhieuSlotEntity SelectByMaVach(Int64 mavach)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "sp_PhieuSlot_SelectByMavach";

			SqlParameter param = new SqlParameter("@MaVach", SqlDbType.BigInt);
			param.Value = mavach;
			command.Parameters.Add(param);

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					phieuslot = new PhieuSlotEntity()
					{
						MaPhieu = DUtils.ReadInt64(reader["MaPhieu"]) ,
						STT = DUtils.ReadInt32(reader["STT"]),
						MaHang =DUtils.ReadInt32(reader["MaHang"]),
						MaKieuGiat = DUtils.ReadInt32(reader["MaKieuGiat"]),
						TenHang = reader["TenHang"].ToString(),
						TenKieuGiat = reader["TenKieuGiat"].ToString(),
						Kho = reader["Kho"].ToString(),
						Slot = DUtils.ReadInt32(reader["Slot"]),
						DaTra = DUtils.ReadBoolean(reader["DaTra"]),
						GhiChu = DUtils.ReadString(reader["GhiChu"]),
						SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
						MaVach = DUtils.ReadInt64(reader["MaVach"]),
						NgayTra = DUtils.ReadString(reader["NgayTra"]),
						ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
					};
					kq.Add(phieuslot);
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static ListPhieuSlotEntity SelectViecCanLam(Int64 maphieu, DateTime tungay, DateTime denngay, Int64 mavach,
								Boolean tatca, Boolean hienthihet, String tenhang)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_PhieuSlot_SelectViecCanLam]";

			if (!tatca)
			{
				SqlParameter param = new SqlParameter("@tungay", SqlDbType.DateTime);
				param.Value = tungay;
				command.Parameters.Add(param);

				param = new SqlParameter("@denngay", SqlDbType.DateTime);
				param.Value = denngay;
				command.Parameters.Add(param);

				if (maphieu != 0)
				{
					param = new SqlParameter("@maphieu", SqlDbType.BigInt, 8);
					param.Value = maphieu;
					command.Parameters.Add(param);
				}

				if (mavach != 0)
				{
					param = new SqlParameter("@mavach", SqlDbType.BigInt, 8);
					param.Value = mavach;
					command.Parameters.Add(param);
				}

				if (!String.IsNullOrEmpty(tenhang))
				{
					param = new SqlParameter("@TenHang", SqlDbType.NVarChar);
					param.Value = tenhang;
					command.Parameters.Add(param);
				}
			}

			ListPhieuSlotEntity kq = new ListPhieuSlotEntity();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				PhieuSlotEntity phieuslot = null;
				while (reader.Read())
				{
					if (hienthihet)
					{
						phieuslot = new PhieuSlotEntity()
						{
							MaPhieu = (Int64)reader["MaPhieu"],
							STT = (Int32)reader["STT"],
							MaHang = (Int32)reader["MaHang"],
							MaKieuGiat = (Int32)reader["MaKieuGiat"],
							TenHang = reader["TenHang"].ToString(),
							TenKieuGiat = reader["TenKieuGiat"].ToString(),
							Kho = reader["Kho"].ToString(),
							Slot = (Int32)reader["Slot"],
							DaTra = (Boolean)reader["DaTra"],
							GhiChu = DUtils.ReadString(reader["GhiChu"]),
							SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
							MaVach = DUtils.ReadInt64(reader["MaVach"]),
							NgayTra = DUtils.ReadString(reader["NgayTra"]),
							ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
						};
						kq.Add(phieuslot);
					}
					else if (DUtils.ReadInt32(reader["Slot"]) != 0 ||
							DUtils.ReadBoolean(reader["DaTra"]))
					{
						continue;
					}
					else
					{
						phieuslot = new PhieuSlotEntity()
						{
							MaPhieu = (Int64)reader["MaPhieu"],
							STT = (Int32)reader["STT"],
							MaHang = (Int32)reader["MaHang"],
							MaKieuGiat = (Int32)reader["MaKieuGiat"],
							TenHang = reader["TenHang"].ToString(),
							TenKieuGiat = reader["TenKieuGiat"].ToString(),
							Kho = reader["Kho"].ToString(),
							Slot = (Int32)reader["Slot"],
							DaTra = (Boolean)reader["DaTra"],
							GhiChu = DUtils.ReadString(reader["GhiChu"]),
							SoHieuSanPham = DUtils.ReadString(reader["SoHieuSanPham"]),
							MaVach = DUtils.ReadInt64(reader["MaVach"]),
							NgayTra = DUtils.ReadString(reader["NgayTra"]),
							ThoiDiemLuu = DUtils.ReadString(reader["ThoiDiemLuu"])
						};
						kq.Add(phieuslot);
					}
				}
				reader.Close();
			}
			command.Connection.Close();
			return kq;
		}

		public static String SelectByKhoSlot(String kho, Int32 slot, Int64 ngoaitrumaphieunay)
		{
			SqlCommand command = DUtils.GetCommand();
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.CommandText = "[dbo].[sp_PhieuSlot_SelectByKhoSlot]";

			SqlParameter param = new SqlParameter("@Kho", SqlDbType.NVarChar, 50);
			param.Value = kho;
			command.Parameters.Add(param);

			param = new SqlParameter("@Slot", SqlDbType.Int, 4);
			param.Value = slot;
			command.Parameters.Add(param);

			String kq = String.Empty;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					if (Convert.ToInt64(reader[0]) != ngoaitrumaphieunay)
						kq += reader[0].ToString() + ",";
				}
				reader.Close();
			}
			command.Connection.Close();
			if (kq.EndsWith(",")) kq = kq.Remove(kq.Length - 1);
			return kq;
		}

		public static void Insert(ListPhieuSlotEntity listPhieuSlot)
		{
			try
			{
				DataTable dt = ListPhieuSlotToDataTable(listPhieuSlot);	// úp cả table này lên csdl
				SqlCommand command = DUtils.GetCommand();
				command.CommandType = CommandType.Text;
				string field = "", value = "";
				foreach (DataColumn col in dt.Columns)
				{
					field += "," + col.ColumnName;
					value += ",@" + col.ColumnName;
					SqlParameter param = new SqlParameter();
					param.ParameterName = "@" + col.ColumnName;
					param.SourceColumn = col.ColumnName;
					command.Parameters.Add(param);
				}
				if (field.StartsWith(",")) field = field.Substring(1);
				if (value.StartsWith(",")) value = value.Substring(1);
				command.CommandText = "insert into Phieu_Slot(" + field + ") values (" + value + ")";
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.InsertCommand = command;
				adapter.Update(dt);
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

		public static void InsertPhieuSlot_DaTra(ListPhieuSlotEntity listPhieuSlot)
		{
			try
			{
				DataTable dt = ListPhieuSlotToDataTable(listPhieuSlot);	// úp cả table này lên csdl
				SqlCommand command = DUtils.GetCommand();
				command.CommandType = CommandType.Text;
				string field = "", value = "";
				foreach (DataColumn col in dt.Columns)
				{
					field += "," + col.ColumnName;
					value += ",@" + col.ColumnName;
					SqlParameter param = new SqlParameter();
					param.ParameterName = "@" + col.ColumnName;
					param.SourceColumn = col.ColumnName;
					command.Parameters.Add(param);
				}
				if (field.StartsWith(",")) field = field.Substring(1);
				if (value.StartsWith(",")) value = value.Substring(1);
				command.CommandText = "insert into Phieu_Slot_DaTra(" + field + ") values (" + value + ")";
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.InsertCommand = command;
				adapter.Update(dt);
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

		public static void Update(ListPhieuSlotEntity listPhieuSlot)
		{
			try
			{
				DataTable dt = ListPhieuSlotToDataTable(listPhieuSlot);// úp cả table này lên csdl
				SqlCommand insertCommand = DUtils.GetCommand();
				insertCommand.CommandType = CommandType.Text;
				string query = "";
				foreach (DataColumn col in dt.Columns)
				{
					if (col.ColumnName.ToLower() != "MaPhieu".ToLower() &&
						col.ColumnName.ToLower() != "STT".ToLower())
					{
						if (col.ColumnName.ToLower() == "MaHang".ToLower() ||
							col.ColumnName.ToLower() == "MaKieuGiat".ToLower() ||
							col.ColumnName.ToLower() == "MaVach".ToLower() ||
							col.ColumnName.ToLower() == "SoHieuSanPham".ToLower())
							continue;
						query += "," + col.ColumnName + " = " + "@" + col.ColumnName;
					}
					SqlParameter param = new SqlParameter();
					param.ParameterName = "@" + col.ColumnName;
					param.SourceColumn = col.ColumnName;
					insertCommand.Parameters.Add(param);
				}
				if (query.StartsWith(",")) query = query.Substring(1);
				insertCommand.CommandText = "update Phieu_Slot set " + query + " where MaPhieu=@MaPhieu AND STT=@STT";
				SqlDataAdapter da = new SqlDataAdapter();
				da.UpdateCommand = insertCommand;
				dt.AcceptChanges();
				foreach (DataRow row in dt.Rows)
				{
					row.SetModified();
				}
				da.Update(dt);
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
		}

		public static Int32 Update(PhieuSlotEntity phieuSlot)
		{
			try
			{
				String query = "update Phieu_Slot set Kho=@Kho," +
								" Slot=@Slot, GhiChu=@GhiChu, ThoiDiemLuu=@ThoiDiemLuu" +
								" WHERE MaPhieu=@MaPhieu AND STT=@STT";

				SqlCommand updateCommand = DUtils.GetCommand();
				updateCommand.CommandType = CommandType.Text;
				updateCommand.CommandText = query;

				SqlParameter param = new SqlParameter("@Kho", SqlDbType.NVarChar, 50);
				param.Value = phieuSlot.Kho;
				updateCommand.Parameters.Add(param);

				param = new SqlParameter("@Slot", SqlDbType.Int, 4);
				param.Value = phieuSlot.Slot;
				updateCommand.Parameters.Add(param);

				param = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 200);
				param.Value = phieuSlot.GhiChu;
				updateCommand.Parameters.Add(param);

				param = new SqlParameter("@ThoiDiemLuu", SqlDbType.VarChar, 50);
				param.Value = phieuSlot.ThoiDiemLuu;
				updateCommand.Parameters.Add(param);

				param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
				param.Value = phieuSlot.MaPhieu;
				updateCommand.Parameters.Add(param);

				param = new SqlParameter("@STT", SqlDbType.Int, 4);
				param.Value = phieuSlot.STT;
				updateCommand.Parameters.Add(param);

				return updateCommand.ExecuteNonQuery();
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
		}

		private static DataTable ListPhieuSlotToDataTable(ListPhieuSlotEntity listPhieuSlot)
		{
			DataTable table = new DataTable();
			table.Columns.Add("MaPhieu", typeof(Int64));
			table.Columns.Add("STT", typeof(int));
			table.Columns.Add("MaHang", typeof(int));
			table.Columns.Add("MaKieuGiat", typeof(int));
			table.Columns.Add("Kho", typeof(string));
			table.Columns.Add("Slot", typeof(int));
			table.Columns.Add("DaTra", typeof(bool));
			table.Columns.Add("MaVach", typeof(Int64));
			table.Columns.Add("GhiChu", typeof(string));
			table.Columns.Add("SoHieuSanPham", typeof(string));
			table.Columns.Add("NgayTra", typeof(string));
			table.Columns.Add("ThoiDiemLuu", typeof(string));
			foreach (PhieuSlotEntity phieuslot in listPhieuSlot)
			{
				DataRow row = table.NewRow();
				row["MaPhieu"] = phieuslot.MaPhieu;
				row["STT"] = phieuslot.STT;
				row["MaHang"] = phieuslot.MaHang;
				row["MaKieuGiat"] = phieuslot.MaKieuGiat;
				row["Kho"] = phieuslot.Kho;
				row["Slot"] = phieuslot.Slot;
				row["DaTra"] = phieuslot.DaTra;
				row["MaVach"] = phieuslot.MaVach;
				row["GhiChu"] = DUtils.SetString(phieuslot.GhiChu);
				row["SoHieuSanPham"] = DUtils.SetString(phieuslot.SoHieuSanPham);
				row["NgayTra"] = DUtils.SetString(phieuslot.NgayTra);
				row["ThoiDiemLuu"] = DUtils.SetString(phieuslot.ThoiDiemLuu);
				table.Rows.Add(row);
			}
			return table;
		}

		public static void DeleteByMaPhieu(Int64 maphieu)
		{
			try
			{
				SqlCommand command = DUtils.GetCommand();
				command.CommandType = System.Data.CommandType.StoredProcedure;
				command.CommandText = "sp_PhieuSlot_DeleteByMaPhieu";
				SqlParameter param = new SqlParameter("@MaPhieu", SqlDbType.BigInt, 8);
				param.Value = maphieu;
				command.Parameters.Add(param);
				command.ExecuteNonQuery();
				command.Connection.Close();
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
		}

	}
}
