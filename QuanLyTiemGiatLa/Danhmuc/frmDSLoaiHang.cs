using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSLoaiHang : Form
	{
		public frmDSLoaiHang()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSLoaiHang_Load);
		}

		private void frmDSLoaiHang_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSLoaiHang.DataSource = Business.LoaiHangBO.SelectAll();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTLoaiHang frm = new frmCTLoaiHang();
			frm.onsaved = new OnSaved(LoadData);
			frm.ShowDialog(this);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.LoaiHangEntity loaihang = bndsrcDSLoaiHang.Current as Entity.LoaiHangEntity;
			if (loaihang != null)
			{
				frmCTLoaiHang frm = new frmCTLoaiHang();
				frm.onsaved = new OnSaved(this.LoadData);
				frm.LoaiHang = loaihang;
				frm.ShowDialog(this);
				this.LoadData();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.LoaiHangEntity loaihang = bndsrcDSLoaiHang.Current as Entity.LoaiHangEntity;
			if (loaihang != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa loại hàng '" + loaihang.TenLoaiHang + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.LoaiHangBO.Delete(loaihang.MaLoaiHang);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được loại hàng '" + loaihang.TenLoaiHang + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void dgvDSLoaiHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}
	}
}
