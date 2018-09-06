using System;
using System.Windows.Forms;
using System.Text;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTNhanVien : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;
		private string _passBefore;

		public frmCTNhanVien()
		{
			InitializeComponent();
			this.LoadComboQuyen();
			this.Load += new EventHandler(frmCTNhanVien_Load);
		}

		private void LoadComboQuyen()
		{
			cboQuyen.Items.Clear();
			cboQuyen.Items.Insert(0, "Nhân viên");
			cboQuyen.Items.Insert(1, "Kế toán");
			cboQuyen.Items.Insert(2, "Admin");
			cboQuyen.SelectedIndex = 0;
		}

		private void frmCTNhanVien_Load(object sender, EventArgs e)
		{
			try
			{
				TrangThai = this.NhanVien == null ? TrangThai.Them : TrangThai.Sua;
				if (TrangThai == TrangThai.Them) { }
				else
				{
					_passBefore = NhanVien.Password;
					txtRePass.Text = NhanVien.Password;
					cboQuyen.SelectedIndex = NhanVien.Quyen;
					txtUsername.Enabled = false;
					if (NhanVien.UserName == "admin")
					{
						cboQuyen.Enabled = false;
						for (int i = 0; i < this.groupBox2.Controls.Count; i++)
						{
							if (this.groupBox2.Controls[i] is CheckBox)
							{
								CheckBox chk = this.groupBox2.Controls[i] as CheckBox;
								if (chk != null)
								{
									chk.Checked = true;
									chk.Enabled = false;
								}
							}
						}
					}
					else
					{
						if (NhanVien.QuyenHan.Length == 17)
						{
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.BangChotKet], chkBangChotKet);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.BangGia], chkBangGia);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.CatDo], chkCatDo);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.CauHinh], chkCauHinh);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.DanhSachPhieu], chkDanhSachPhieu);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.DoiMatKhau], chkDoiMatKhau);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.DotGiamGia], chkDotGiamGia);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.GiaDeDo], chkGiaDeDo);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.KieuGiat], chkKieuGiat);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.KhachHang], chkKhachHang);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.LapPhieu], chkLapPhieu);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.LoaiHang], chkLoaiHang);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.LoaiKhachHang], chkLoaiKhachHang);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.MatHang], chkMatHang);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.NhanVien], chkNhanVien);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.NhungViecCanLam], chkNhungViecCanLam);
							Check1QuyenHan(NhanVien.QuyenHan[(Int32)ThuTuButton.ThongKeThuNhap], chkThongKeThuNhap);
						}
					}
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Check1QuyenHan(char c, CheckBox chk)
		{
			chk.Checked = c == '1';
		}

		public Entity.UserEntity NhanVien
		{
			set
			{
				bndsrcNhanVien.DataSource = value;
			}
			get
			{
				return bndsrcNhanVien.DataSource as Entity.UserEntity;
			}
		}

		private Boolean CheckForm()
		{
			if (String.IsNullOrEmpty(txtUsername.Text))
			{
				txtUsername.Focus();
				MessageBox.Show("Tài khoản trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			txtHoten.Text = txtHoten.Text.Trim();
			if (String.IsNullOrEmpty(txtHoten.Text))
			{
				txtHoten.Focus();
				MessageBox.Show("Họ tên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(txtPassword.Text))
			{
				txtPassword.Focus();
				MessageBox.Show("Mật khẩu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(txtRePass.Text))
			{
				txtRePass.Focus();
				MessageBox.Show("Đánh lại mật khẩu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txtRePass.Text != txtPassword.Text)
			{
				txtRePass.Focus();
				txtRePass.SelectAll();
				MessageBox.Show("Đánh lại mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (cboQuyen.SelectedIndex == -1)
			{
				cboQuyen.Focus();
				MessageBox.Show("Bạn chưa chọn quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.CheckForm()) return;
				Entity.UserEntity nv = new Entity.UserEntity()
				{
					UserName = txtUsername.Text,
					Password = txtPassword.Text,
					HoTen = txtHoten.Text,
					Quyen = Convert.ToByte(cboQuyen.SelectedIndex),
					QuyenHan = BuildQuyenhan()
				};
				if (TrangThai == TrangThai.Them)
				{
					try
					{
						nv.Password = Xuly.Xuly.MaHoaPassword(nv.Password);
						Business.UserBO.Insert(nv);
					}
					catch
					{
						MessageBox.Show("Đã tồn tại tài khoản '" + nv.UserName + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					onsaved();
					this.Close();
				}
				else
				{
					if (_passBefore != txtPassword.Text)
					{
						nv.Password = Xuly.Xuly.MaHoaPassword(nv.Password);
					}
					Int32 kq = Business.UserBO.Update(nv);
					onsaved();
					this.Close();
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private String BuildQuyenhan()
		{
			Char[] str = new Char[17];	// dộ dài chuỗi là 17
			for (int i = 0; i < str.Length; i++)
			{
				str[i] = '0';
			}
			str[(Int32)ThuTuButton.BangChotKet]	= BuildMotBit(chkBangChotKet.Checked);
			str[(Int32)ThuTuButton.BangGia]		= BuildMotBit(chkBangGia.Checked);
			str[(Int32)ThuTuButton.CatDo]			= BuildMotBit(chkCatDo.Checked);
			str[(Int32)ThuTuButton.CauHinh]		= BuildMotBit(chkCauHinh.Checked);
			str[(Int32)ThuTuButton.DanhSachPhieu]	= BuildMotBit(chkDanhSachPhieu.Checked);
			str[(Int32)ThuTuButton.DoiMatKhau]		= BuildMotBit(chkDoiMatKhau.Checked);
			str[(Int32)ThuTuButton.DotGiamGia]		= BuildMotBit(chkDotGiamGia.Checked);
			str[(Int32)ThuTuButton.GiaDeDo]		= BuildMotBit(chkGiaDeDo.Checked);
			str[(Int32)ThuTuButton.KieuGiat]		= BuildMotBit(chkKieuGiat.Checked);
			str[(Int32)ThuTuButton.KhachHang]		= BuildMotBit(chkKhachHang.Checked);
			str[(Int32)ThuTuButton.LapPhieu]		= BuildMotBit(chkLapPhieu.Checked);
			str[(Int32)ThuTuButton.LoaiHang]		= BuildMotBit(chkLoaiHang.Checked);
			str[(Int32)ThuTuButton.LoaiKhachHang]	= BuildMotBit(chkLoaiKhachHang.Checked);
			str[(Int32)ThuTuButton.MatHang]		= BuildMotBit(chkMatHang.Checked);
			str[(Int32)ThuTuButton.NhanVien]		= BuildMotBit(chkNhanVien.Checked);
			str[(Int32)ThuTuButton.NhungViecCanLam]= BuildMotBit(chkNhungViecCanLam.Checked);
			str[(Int32)ThuTuButton.ThongKeThuNhap] = BuildMotBit(chkThongKeThuNhap.Checked);
			return new String(str);
		}

		private char BuildMotBit(Boolean b)
		{
			return b ? '1' : '0';
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, txtHoten);
		}

		private void txtHoten_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, txtPassword);
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, txtRePass);
		}

		private void txtRePass_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, cboQuyen);
		}

		private void cboQuyen_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) btnGhi_Click(sender, e);
		}
	}
}
