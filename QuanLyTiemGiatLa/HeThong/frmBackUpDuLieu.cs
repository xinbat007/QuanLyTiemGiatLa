using System.Windows.Forms;
using QuanLyTiemGiatLa.Xuly;

namespace QuanLyTiemGiatLa.HeThong
{
	public partial class frmBackUpDuLieu : Form
	{
		public frmBackUpDuLieu()
		{
			InitializeComponent();
			this.Load += new System.EventHandler(frmBackUpDuLieu_Load);
		}

		private void frmBackUpDuLieu_Load(object sender, System.EventArgs e)
		{
			try
			{
				Xuly.ThaoTacIniBackup iniBackup = new QuanLyTiemGiatLa.Xuly.ThaoTacIniBackup();
				iniBackup.Read();
				txtDuongDanFile.Text = iniBackup.DuongDanLuuThuMucFileBackup;
				txtCopyTo.Text = iniBackup.DuongDanLuuThuMucCopyTo;
				if (iniBackup.ThoiGianTuDongBackUp == 0)
					iniBackup.ThoiGianTuDongBackUp = 19;
				txtThoiGianBackup.Text = iniBackup.ThoiGianTuDongBackUp.ToString();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/* Mô tả:
		 * - Cho người dùng chọn thời gian backup sau 1 ngày (mặc định là 7h tối)
		 * - Người dùng chọn thư mục muốn backup ra. Có nút Backup = tay
		 */

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnBrowse_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
				txtDuongDanFile.Text = fbd.SelectedPath;
		}

		private void btnBrowseCopyTo_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog()== DialogResult.OK)
				txtCopyTo.Text = fbd.SelectedPath;
		}

		private bool CheckForm()
		{
			if (string.IsNullOrEmpty(txtDuongDanFile.Text))
			{
				MessageBox.Show("Đường dẫn file rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtDuongDanFile.Focus();
				return false;
			}
			if (!string.IsNullOrEmpty(txtThoiGianBackup.Text))
			{
				int temp;
				if (int.TryParse(txtThoiGianBackup.Text, out temp))
				{
					if (temp < 8 || temp > 21)
					{
						MessageBox.Show("Thời gian backup phải nằm trong khoảng 8h - 21h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtThoiGianBackup.Focus();
						return false;
					}
				}
				else
				{
					MessageBox.Show("Thời gian backup phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtThoiGianBackup.Focus();
					return false;
				}
			}
			return true;
		}

		private void btnBackUp_Click(object sender, System.EventArgs e)
		{
			if (!this.CheckForm()) return;			
			btnBackUp.Enabled = false;
			int result = Xuly.Xuly.AutoBackup(txtDuongDanFile.Text, txtCopyTo.Text);
			btnBackUp.Enabled = true;
			if (result == 1)
			{
				MessageBox.Show("Không copy được sang thư mục: " + txtCopyTo.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (result == 2)
			{
				MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnLuuCauHinh_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtDuongDanFile.Text))
				{
					int temp;
					if (int.TryParse(txtThoiGianBackup.Text, out temp))
					{
						if (temp < 8 || temp > 21)
						{
							MessageBox.Show("Thời gian backup phải nằm trong khoảng 8h - 21h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtThoiGianBackup.Focus();
							return;
						}
					}
					else
					{
						MessageBox.Show("Thời gian backup phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtThoiGianBackup.Focus();
						return;
					}
				}
				ThaoTacIniBackup thaotacini = new ThaoTacIniBackup();
				thaotacini.Write(txtDuongDanFile.Text, txtCopyTo.Text, int.Parse(txtThoiGianBackup.Text));
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
