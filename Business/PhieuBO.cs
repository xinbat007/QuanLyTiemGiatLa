using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
	public class PhieuBO
	{
		public static PhieuEntity SelectByMaPhieu(Int64 maphieu)
		{
			return DataAccess.PhieuDA.SelectByMaPhieu(maphieu);
		}

		public static ListPhieuEntity SelectNangCao(Boolean tatca, Boolean datrado, Int64 maphieu, String dienthoai,
										String tenkhachhang, Boolean timtheongay, DateTime tungay, DateTime denngay)
		{
			return DataAccess.PhieuDA.SelectNangCao(tatca, datrado, maphieu, dienthoai,
											tenkhachhang, timtheongay, tungay, denngay);
		}

		public static ListPhieuEntity SelectByNgayLap(DateTime tungay, DateTime denngay)
		{
			return DataAccess.PhieuDA.SelectByNgayLap(tungay, denngay);
		}

		public static ListPhieuEntity SelectByTuPhieuDenPhieu(Int64 tuphieu, Int64 denphieu)
		{
			return DataAccess.PhieuDA.SelectByTuPhieuDenPhieu(tuphieu, denphieu);
		}

		public static Int64 SelectSumTongTienByMaPhieu(Int64 tuphieu, Int64 denphieu)
		{
			return DataAccess.PhieuDA.SelectSumTongTienByMaPhieu(tuphieu, denphieu);
		}

		public static string SelectMaPhieuHuy(Int64 tuphieu, Int64 denphieu)
		{
			return DataAccess.PhieuDA.SelectMaPhieuHuy(tuphieu, denphieu);
		}

		public static Int64 SelectMaxMaPhieu()
		{
			return DataAccess.PhieuDA.SelectMaxMaPhieu();
		}

		public static Int64 Insert(PhieuEntity phieu)
		{
			return DataAccess.PhieuDA.Insert(phieu);
		}

		public static Int32 Delete(Int64 maphieu, Boolean dathanhtoan, Boolean datrado)
		{
			return DataAccess.PhieuDA.Delete(maphieu, dathanhtoan, datrado);
		}

		public static Int32 UpdateDaTraDo(Int64 maphieu)
		{
			return DataAccess.PhieuDA.UpdateDaTraDo(maphieu);
		}

        public static Int32 UpdateDaHuyPhieu(Int64 maphieu)
        {
            return DataAccess.PhieuDA.UpdateDaHuyPhieu(maphieu);
        }

		public static Int32 UpdateSoLanIn(Int64 maphieu, Int32 solanin)
		{
			return DataAccess.PhieuDA.UpdateSoLanIn(maphieu, solanin);
		}

	}
}
