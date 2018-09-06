using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entity;

namespace Business
{
	public class LoaiHangBO
	{
		public static ListLoaiHangEntity SelectAll()
		{
			return LoaiHangDA.SelectAll();
		}

		public static Int32 Insert(LoaiHangEntity loaihang)
		{
			return LoaiHangDA.Insert(loaihang);
		}

		public static Int32 Update(LoaiHangEntity loaihang)
		{
			return LoaiHangDA.Update(loaihang);
		}

		public static Int32 Delete(Int32 MaLoaiHang)
		{
			return LoaiHangDA.Delete(MaLoaiHang);
		}
	}
}
