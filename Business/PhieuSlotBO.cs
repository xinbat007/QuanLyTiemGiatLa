using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class PhieuSlotBO
	{
		public static ListPhieuSlotEntity SelectByMaPhieu(Int64 maphieu)
		{
			return DataAccess.PhieuSlotDA.SelectByMaPhieu(maphieu);
		}

		public static ListPhieuSlotEntity SelectByMaPhieu_DaTra(Int64 maphieu)
		{
			return DataAccess.PhieuSlotDA.SelectByMaPhieu_DaTra(maphieu);
		}

		public static ListPhieuSlotEntity SelectByMaPhieu_TenDo(Int64 maphieu, string tendo, bool timtheongaytra, DateTime tungay, DateTime denngay, bool chuatra)
		{
			return DataAccess.PhieuSlotDA.SelectByMaPhieu_TenDo(maphieu, tendo, timtheongaytra, tungay, denngay, chuatra);
		}

		public static ListPhieuSlotEntity SelectByMaVach(Int64 mavach)
		{
			return DataAccess.PhieuSlotDA.SelectByMaVach(mavach);
		}

		public static ListPhieuSlotEntity SelectByMaVach_TenDo(Int64 mavach, string tendo, bool timtheongaytra, DateTime tungay, DateTime denngay, bool chuatra)
		{
			return DataAccess.PhieuSlotDA.SelectByMaVach_TenDo(mavach, tendo, timtheongaytra, tungay, denngay, chuatra);
		}

		public static ListPhieuSlotEntity SelectViecCanLam(Int64 maphieu, DateTime tungay, DateTime denngay, Int64 mavach,
								Boolean tatca, Boolean hienthihet, String tenhang)
		{
			return DataAccess.PhieuSlotDA.SelectViecCanLam(maphieu, tungay, denngay, mavach, tatca, hienthihet, tenhang);
		}

		public static String SelectByKhoSlot(String kho, Int32 slot, Int64 ngoaitrumaphieunay)
		{
			return DataAccess.PhieuSlotDA.SelectByKhoSlot(kho, slot, ngoaitrumaphieunay);
		}

		public static void Insert(ListPhieuSlotEntity listPhieuSlot)
		{
			DataAccess.PhieuSlotDA.Insert(listPhieuSlot);
		}

		public static void InsertPhieuSlot_DaTra(ListPhieuSlotEntity listPhieuSlot)
		{
			DataAccess.PhieuSlotDA.InsertPhieuSlot_DaTra(listPhieuSlot);
		}

		public static void Update(ListPhieuSlotEntity listPhieuSlot)
		{
			DataAccess.PhieuSlotDA.Update(listPhieuSlot);
		}

		public static Int32 Update(PhieuSlotEntity phieuSlot)
		{
			return DataAccess.PhieuSlotDA.Update(phieuSlot);
		}

		public static void DeleteByMaPhieu(Int64 maphieu)
		{
			DataAccess.PhieuSlotDA.DeleteByMaPhieu(maphieu);
		}

	}
}
