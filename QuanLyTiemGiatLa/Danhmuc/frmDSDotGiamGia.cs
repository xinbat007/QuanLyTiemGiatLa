using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSDotGiamGia : Form
	{
		public frmDSDotGiamGia()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSDotGiamGia_Load);
		}

		private void frmDSDotGiamGia_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSDotGiamGia.DataSource = Business.DotGiamGiaBO.SelectAll();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTDotGiamGia frm = new frmCTDotGiamGia();
			frm.onsaved = new OnSaved(LoadData);
			frm.ShowDialog(this);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.DotGiamGiaEntity dotgiamgia = bndsrcDSDotGiamGia.Current as Entity.DotGiamGiaEntity;
			if (dotgiamgia != null)
			{
				frmCTDotGiamGia frm = new frmCTDotGiamGia();
				frm.onsaved = new OnSaved(this.LoadData);
				frm.DotGiamGia = dotgiamgia;
				frm.ShowDialog(this);
				this.LoadData();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.DotGiamGiaEntity dotgiamgia = bndsrcDSDotGiamGia.Current as Entity.DotGiamGiaEntity;
			if (dotgiamgia != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa '" + dotgiamgia.TenDotGiamGia + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.DotGiamGiaBO.Delete(dotgiamgia.MaDotGiamGia);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được '" + dotgiamgia.TenDotGiamGia + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void dgvDSDotGiamGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
