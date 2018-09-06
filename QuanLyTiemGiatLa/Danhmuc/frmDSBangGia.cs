using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSBangGia : Form
	{
		public frmDSBangGia()
		{
			InitializeComponent();
			this.Load += new System.EventHandler(frmDSBangGia_Load);
		}

		private void frmDSBangGia_Load(object sender, System.EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSBangGia.DataSource = Business.BangGiaBO.SelectAll();
		}

		private void btnThem_Click(object sender, System.EventArgs e)
		{
			frmCTBangGia frm = new frmCTBangGia();
			frm.onsaved = new OnSaved(LoadData);
			frm.ShowDialog();
		}

		private void btnSua_Click(object sender, System.EventArgs e)
		{
			Entity.BangGiaEntity banggia = bndsrcDSBangGia.Current as Entity.BangGiaEntity;
			if (banggia != null)
			{
				frmCTBangGia frm = new frmCTBangGia();
				frm.BangGia = banggia;
				frm.onsaved = new OnSaved(LoadData);
				frm.ShowDialog();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, System.EventArgs e)
		{
			Entity.BangGiaEntity banggia = bndsrcDSBangGia.Current as Entity.BangGiaEntity;
			if (banggia != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa '" + banggia.TenHang + " - " + banggia.TenKieuGiat +"' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.BangGiaBO.Delete(banggia.IDGia);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được '" + banggia.TenHang + " - " + banggia.TenKieuGiat + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void dgvDSBangGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
