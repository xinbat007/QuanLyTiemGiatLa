using System;
using Entity;

namespace Business
{
	public class ShelfBO
	{
		public static ListShelfEntity SelectSlotByMaKho(Int32 makho)
		{
			return DataAccess.ShelfDA.SelectSlotByMaKho(makho);
		}

		public static ListShelfEntity SelectSlotChuaSuDungByMaKho(Int32 makho)
		{
			return DataAccess.ShelfDA.SelectSlotChuaSuDungByMaKho(makho);
		}

		public static Boolean CheckIsExist(Int32 makho, Int32 slot, out String macacphieudangsudung)
		{
			return DataAccess.ShelfDA.CheckIsExist(makho, slot, out macacphieudangsudung);
		}

		public static Int32 Update(Int32 makho, Int32 slot, String MaCacPhieuDangSuDung)
		{
			return DataAccess.ShelfDA.Update(makho, slot, MaCacPhieuDangSuDung);
		}
	}
}
