using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSKieuGiat : Form
	{
		public frmDSKieuGiat()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSKieuGiat_Load);
		}

		private void frmDSKieuGiat_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSKieuGiatLa.DataSource = Business.KieuGiatLaBO.SelectAll();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTKieuGiatLa frm = new frmCTKieuGiatLa();
			frm.onsaved = new OnSaved(LoadData);
			frm.Show();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.KieuGiatLaEntity kieugiat = bndsrcDSKieuGiatLa.Current as Entity.KieuGiatLaEntity;
			if (kieugiat != null)
			{
				frmCTKieuGiatLa frm = new frmCTKieuGiatLa();
				frm.KieuGiatLa = kieugiat;
				frm.onsaved = new OnSaved(LoadData);
				frm.Show();
				this.LoadData();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.KieuGiatLaEntity kieugiat = bndsrcDSKieuGiatLa.Current as Entity.KieuGiatLaEntity;
			if (kieugiat != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa '" + kieugiat.TenKieuGiat + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.KieuGiatLaBO.Delete(kieugiat.MaKieuGiat);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được '" + kieugiat.TenKieuGiat + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void dgvDSMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
