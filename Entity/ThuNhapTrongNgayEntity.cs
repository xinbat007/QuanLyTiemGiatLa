using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public class ThuNhapTrongNgayEntity
	{
		public DateTime NgayLap { get; set; }
		public Int64 TongTienTruocGiamGia { get; set; }
		public Int64 TongTienSauGiamGia { get; set; }
		public Int64 TongTienHuyHoaDon { get; set; }
		public Int64 TongTienPhiVanChuyen { get; set; }
		public Int64 TongTienCuoiCung { get; set; }
	}
	public class ListThuNhapTrongNgayEntity : List<ThuNhapTrongNgayEntity>
	{
	}
}
