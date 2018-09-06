using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entity;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSKhachHang : Form
	{
		public frmDSKhachHang()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSKhachHang_Load);
		}

		private void frmDSKhachHang_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			bndsrcDSKhachHang.DataSource = Business.KhachHangBO.SelectAll(dtpTuNgay.Value, dtpDenNgay.Value, chkTatCa.Checked);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTKhachHang frm = new frmCTKhachHang();
			frm.onsaved = new OnSaved(LoadData);
			frm.ShowDialog(this);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.KhachHangEntity khachhang = bndsrcDSKhachHang.Current as Entity.KhachHangEntity;
			if (khachhang != null)
			{
				frmCTKhachHang frm = new frmCTKhachHang();
				frm.onsaved = new OnSaved(this.LoadData);
				frm.KhachHang = khachhang;
				frm.ShowDialog(this);
				this.LoadData();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.KhachHangEntity khachhang = bndsrcDSKhachHang.Current as Entity.KhachHangEntity;
			if (khachhang != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa khách hàng '" + khachhang.TenKhachHang + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.KhachHangBO.Delete(khachhang.MaKhachHang);
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được khách hàng '" + khachhang.TenKhachHang + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCollapse_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
			btnCollapse.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			ListKhachHangEntity listKH = Business.KhachHangBO.SearchByWhere(this.FilterCondition(), dtpTuNgay.Value, dtpDenNgay.Value, chkTatCa.Checked);
			listKH.Sort(delegate(KhachHangEntity k1, KhachHangEntity k2)
			{
				int kq = k2.DaTungThanhToan.CompareTo(k1.DaTungThanhToan);
				if (kq == 0) kq = k1.TenKhachHang.CompareTo(k2.TenKhachHang);
				return kq; 
			});
			//listKH.Reverse();
			bndsrcDSKhachHang.DataSource = listKH;
			//bndsrcDSKhachHang.Sort
		}

		private String FilterCondition()
		{
			String where = "where 1=1";
			if (!String.IsNullOrEmpty(txtTenKhachHang.Text))
			{
				if (chkTimGanDung.Checked)
					where = where + " AND TenKhachHang LIKE N'%" + txtTenKhachHang.Text + "%'";
				else
					where = where + " AND TenKhachHang = N'" + txtTenKhachHang.Text + "'";
			}
			if (!String.IsNullOrEmpty(txtDienThoai.Text))
			{
				if (chkTimGanDung.Checked)
					where = where + " AND DienThoai LIKE N'%" + txtDienThoai.Text + "%'";
				else
					where = where + " AND DienThoai = N'" + txtDienThoai.Text + "'";
			}
			if (!String.IsNullOrEmpty(txtSoTheVip.Text))
			{
				where += " AND SoTheVip = N'" + txtSoTheVip.Text + "'";
			}
			return where;
		}

		private void btnSearchAgain_Click(object sender, EventArgs e)
		{
			txtTenKhachHang.Text = "";
			txtDienThoai.Text = "";
			chkTimGanDung.Checked = true;
			this.LoadData();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			Entity.KhachHangEntity khachhang = bndsrcDSKhachHang.Current as Entity.KhachHangEntity;
			sửaToolStripMenuItem.Enabled = khachhang != null;
			xóaToolStripMenuItem.Enabled = khachhang != null;
		}

		private void txtTenKhachHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearch_Click(sender, e);
			}
		}

		private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearch_Click(sender, e);
			}
		}

		private void chkTimGanDung_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearch_Click(sender, e);
			}
		}

		private void dgvDSKhachHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSua_Click(sender, e);
			}
		}

		private void dgvDSKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}

		private void chkTatCa_CheckedChanged(object sender, EventArgs e)
		{
			dtpTuNgay.Enabled = !chkTatCa.Checked;
			dtpDenNgay.Enabled = !chkTatCa.Checked;
		}
	}
}
