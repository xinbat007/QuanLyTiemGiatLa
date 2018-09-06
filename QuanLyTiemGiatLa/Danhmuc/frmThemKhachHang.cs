using System.Windows.Forms;
using System;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmThemKhachHang : Form
	{
		public Entity.KhachHangEntity khachhang;//ket qua tra ve form lap phieu
		private Entity.ListKhachHangEntity _listKH;

        public frmThemKhachHang()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmThemKhachHang_Load);
		}

		private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            dgvDSKhachHang.AutoGenerateColumns = false;
			if (!string.IsNullOrEmpty(txtTenKhachHang.Text)) this.LoadData();
		}

		private void LoadData()
		{
            _listKH = Business.KhachHangBO.Search(new Entity.KhachHangEntity()
			{
				TenKhachHang = txtTenKhachHang.Text,
				DiaChi = txtDiaChi.Text,
				DienThoai = txtDienThoai.Text,
				SoTheVip = txtSoTheVIP.Text.Trim()
			});
            dgvDSKhachHang.DataSource = null;
            dgvDSKhachHang.DataSource = _listKH;
        }

        private void dgvDSKhachHang_SelectionChanged(object sender, EventArgs e)
        {
			//if (dgvDSKhachHang.SelectedRows.Count == 0) return;
			//khachhang = _listKH[dgvDSKhachHang.SelectedRows[0].Index];
			//txtDiaChi.Text = khachhang.DiaChi;
			//txtTenKhachHang.Text = khachhang.TenKhachHang;
			//txtDienThoai.Text = khachhang.DienThoai;
			//txtSoTheVIP.Text = khachhang.SoTheVip;
        }

        //public Entity.KhachHangEntity ShowLoc()
        //{
        //    this.ShowDialog();
        //    return khachhang;
        //}

		private void dgvDSKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvDSKhachHang.SelectedRows.Count == 0)
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DataGridViewRow row = dgvDSKhachHang.SelectedRows[0]; //.Cells["MaKhachHang"]
			khachhang = new Entity.KhachHangEntity()
			{
				MaKhachHang = Convert.ToInt64(row.Cells["MaKhachHang"].Value),
				TenKhachHang = row.Cells["TenKhachHang"].Value.ToString(),
				DienThoai = row.Cells["DienThoai"].Value.ToString(),
				DiaChi = row.Cells["DiaChi"].Value.ToString(),
				TenVip = row.Cells["TenVip"].Value.ToString(),
				GiamGia = Convert.ToInt32( row.Cells["GiamGia"].Value),
				SoTheVip = row.Cells["SoTheVip"].Value.ToString()
			};
			this.DialogResult = DialogResult.OK;
			//this.Hide();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			this.LoadData();
			if (dgvDSKhachHang.RowCount == 0) btnGhi.Focus();
			else dgvDSKhachHang.Focus();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private Boolean CheckForm()
		{
			txtTenKhachHang.Text = txtTenKhachHang.Text.Trim();
			txtDiaChi.Text = txtDiaChi.Text.Trim();
			txtDienThoai.Text = txtDienThoai.Text.Trim();
			if (String.IsNullOrEmpty(txtTenKhachHang.Text))
			{
				txtTenKhachHang.Focus();
				MessageBox.Show("Bạn chưa điền tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}		

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!CheckForm()) return;
			if (MessageBox.Show("Bạn có muốn thêm khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
			khachhang = new Entity.KhachHangEntity()
			{
				TenKhachHang = String.Empty,
				DiaChi = String.Empty,
				DienThoai = txtDienThoai.Text
			};
			Entity.ListKhachHangEntity timKHtheodienthoai = Business.KhachHangBO.Search(khachhang);
			if (timKHtheodienthoai.Count > 0)
			{
				if (MessageBox.Show("Đã có khách hàng trùng số điện thoại này!"
					+ "\nBạn nên chọn 'Yes' để dừng lại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					txtTenKhachHang.Text = String.Empty;
					txtDiaChi.Text = String.Empty;
					dgvDSKhachHang.DataSource = timKHtheodienthoai;
					dgvDSKhachHang.Focus();
					return;
				}
			}
			khachhang.TenKhachHang = txtTenKhachHang.Text;
			khachhang.DiaChi = txtDiaChi.Text;
			khachhang.MaKhachHang = Business.KhachHangBO.Insert(khachhang);
			this.DialogResult = DialogResult.OK;
			//this.Hide();
		}

		private void dgvDSKhachHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) dgvDSKhachHang_CellDoubleClick(sender, null);
		}

		private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnTim.Enabled) btnTim_Click(sender, e);
		}

		private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnGhi.Enabled) btnGhi_Click(sender, e);
		}

		private void tênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtTenKhachHang.Focus();
		}

		private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtDienThoai.Focus();
		}

		private void địaChỉToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtDiaChi.Focus();
		}

		private void thẻVIPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtSoTheVIP.Focus();
		}
	}
}
