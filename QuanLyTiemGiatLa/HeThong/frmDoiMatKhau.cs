using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.HeThong
{
	public partial class frmDoiMatKhau : Form
	{
		public frmDoiMatKhau()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDoiMatKhau_Load);
		}

		private void frmDoiMatKhau_Load(object sender, EventArgs e)
		{
			txtUsername.Text = BienChung.userCurrent.UserName;
		}

		private Boolean CheckForm()
		{
			if (Xuly.Xuly.MaHoaPassword(txtPassOld.Text) != BienChung.userCurrent.Password)
			{
				txtPassOld.Focus();
				MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(txtPassNew.Text))
			{
				txtPassNew.Focus();
				MessageBox.Show("Mật khẩu mới trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (txtRepassNew.Text != txtPassNew.Text)
			{
				txtRepassNew.Focus();
				txtRepassNew.SelectAll();
				MessageBox.Show("Đánh lại mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			try
			{
				Business.UserBO.ChangePass(BienChung.userCurrent.UserName, Xuly.Xuly.MaHoaPassword(txtPassNew.Text));
				BienChung.userCurrent.Password = Xuly.Xuly.MaHoaPassword(txtPassNew.Text);
				MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
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

		private void txtPassOld_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, txtPassNew);
		}

		private void txtPassNew_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, txtRepassNew);
		}

		private void txtRepassNew_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) btnGhi_Click(sender, e);
		}
	}
}
