using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSMucDoVip : Form
	{
		public frmDSMucDoVip()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSMucDoVip_Load);
		}

		void frmDSMucDoVip_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSMucDoVip.DataSource = Business.MucDoVipBO.SelectAll();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTMucDoVip frm = new frmCTMucDoVip();
			frm.onsaved = new OnSaved(LoadData);
			frm.ShowDialog();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.MucDoVipEntity mucdovip = bndsrcDSMucDoVip.Current as Entity.MucDoVipEntity;
			if (mucdovip != null)
			{
				frmCTMucDoVip frm = new frmCTMucDoVip();
				frm.MucDoVip = mucdovip;
				frm.onsaved = new OnSaved(LoadData);
				frm.ShowDialog();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.MucDoVipEntity mucdovip = bndsrcDSMucDoVip.Current as Entity.MucDoVipEntity;
			if (mucdovip != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa '" + mucdovip.TenVip + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.MucDoVipBO.Delete(mucdovip.MaVip);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được '" + mucdovip.TenVip + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void dgvDSGiaDeDo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
