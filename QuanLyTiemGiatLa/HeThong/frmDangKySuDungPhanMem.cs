using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.HeThong
{
	public partial class frmDangKySuDungPhanMem : Form
	{
		public frmDangKySuDungPhanMem()
		{
			InitializeComponent();
		}

		private Boolean CheckForm()
		{
			txtMaDangKy.Text = txtMaDangKy.Text.Trim();
			if (string.IsNullOrEmpty(txtMaDangKy.Text))
			{
				MessageBox.Show("Mã đăng ký trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaDangKy.Focus();
				return false;
			}
			return true;
		}

		private void btnChapNhan_Click(object sender, EventArgs e)
		{
			try
			{
				if (!CheckForm()) return;
				// IDCPU + $ + solanupdate(da cong 1) + $ + sophutsd
				string[] mangDecrypt = DangKySuDungPhanMem.GiaimaSangmangString(txtMaDangKy.Text);
				if (mangDecrypt.Length != 3)
				{
					MessageBox.Show("Độ dài chuỗi ko hợp lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (BienChung.checkKey.IDCPU != mangDecrypt[0])
				{
					MessageBox.Show("Mã máy không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (BienChung.checkKey.SoLanDaUpdate + 1 != Int32.Parse(mangDecrypt[1]))
				{
					MessageBox.Show("Số lần kích hoạt không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				Int32 songaysd = Int32.Parse(mangDecrypt[2]);
				BienChung.checkKey.SoLanDaUpdate += 1;
				if (songaysd == -1)
				{
					DangKySuDungPhanMem.GhiThoiHanSuDung(BienChung.checkKey.IDCPU, 1, true, BienChung.checkKey.SoLanDaUpdate);
					MessageBox.Show("Chúc mừng, bạn đã đăng ký full", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					BienChung.DaMuaFull = true;
					BienChung.DuocPhepSuDung = true;
				}
				else
				{
					DangKySuDungPhanMem.GhiThoiHanSuDung(BienChung.checkKey.IDCPU, songaysd, false, BienChung.checkKey.SoLanDaUpdate);
					MessageBox.Show("Bạn được sử dụng thêm " + songaysd + " ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					BienChung.DuocPhepSuDung = true;
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLayMaMay_Click(object sender, EventArgs e)
		{
			string idcpu = DangKySuDungPhanMem.taoID();
			txtMaMay.Text = DangKySuDungPhanMem.MahoaTumangString(idcpu, BienChung.checkKey.SoLanDaUpdate.ToString());
		}
	}
}
