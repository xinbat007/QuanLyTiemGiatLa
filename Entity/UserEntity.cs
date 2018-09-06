using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
	public enum ChucVu
	{
		NhanVien = 0,
		KeToan = 1,
		Admin = 2
	}
	public class UserEntity
	{
		public String UserName { get; set; }
		public String Password { get; set; }
		public String HoTen { get; set; }
		public String QuyenHan { get; set; }
		private Byte _quyen;
		public Byte Quyen
		{
			get { return _quyen; }
			set
			{
				_quyen = value;
				switch (value)
				{
					case 0:
						_chucvu = ChucVu.NhanVien;
						break;
					case 1:
						_chucvu = ChucVu.KeToan;
						break;
					case 2:
						_chucvu = ChucVu.Admin;
						break;
					default:
						_chucvu = ChucVu.NhanVien;
						break;
				}
			}
		}
		private ChucVu _chucvu;
		public ChucVu ChucVu
		{
			get { return _chucvu; }
			set
			{
				_chucvu = value;
				switch (value)
				{
					case ChucVu.NhanVien:
						_quyen = 0;
						break;
					case ChucVu.KeToan:
						_quyen = 1;
						break;
					case ChucVu.Admin:
						_quyen = 2;
						break;
					default:
						_quyen = 0;
						break;
				}
			}
		}
		public String TenChucVu
		{
			get
			{
				switch (_chucvu)
				{
					case ChucVu.NhanVien:
						return "Nhân viên";
					case ChucVu.KeToan:
						return "Kế toán";
					case ChucVu.Admin:
						return "Admin";
					default:
						return "Nhân viên";
				}
			}
		}
	}
	public class ListUserEntity : List<UserEntity>
	{
	}
}
