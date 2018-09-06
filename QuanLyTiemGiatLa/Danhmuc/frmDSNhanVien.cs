using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSNhanVien : Form
	{
		public frmDSNhanVien()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSNhanVien_Load);
		}

		private void frmDSNhanVien_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSNhanVien.DataSource = Business.UserBO.SelectAll();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTNhanVien frm = new frmCTNhanVien();
			frm.onsaved = new OnSaved(this.LoadData);
			frm.ShowDialog(this);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				Entity.UserEntity nhanvien = bndsrcDSNhanVien.Current as Entity.UserEntity;
				if (nhanvien != null)
				{
					frmCTNhanVien frm = new frmCTNhanVien();
					frm.onsaved = new OnSaved(this.LoadData);
					frm.NhanVien = nhanvien;
					frm.ShowDialog(this);
				}
				else
					MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.UserEntity nhanvien = bndsrcDSNhanVien.Current as Entity.UserEntity;
			if (nhanvien != null)
			{
				if (nhanvien.UserName == "admin")
				{
					MessageBox.Show("Bạn không được xóa tài khoản 'admin'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (MessageBox.Show("Bạn có chắc chắn xóa tài khoản '" + nhanvien.UserName + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.UserBO.Delete(nhanvien.UserName);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được '" + nhanvien.UserName + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvDSNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
