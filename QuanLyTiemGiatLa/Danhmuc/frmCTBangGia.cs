using System.Windows.Forms;
using System;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTBangGia : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTBangGia()
		{
			InitializeComponent();
			bndsrcDSMatHang.DataSource = Business.MatHangBO.SelectAll();
			bndsrcDSKieuGiatLa.DataSource = Business.KieuGiatLaBO.SelectAll();
			this.Load += new System.EventHandler(frmCTBangGia_Load);
		}

		private void frmCTBangGia_Load(object sender, System.EventArgs e)
		{
			TrangThai = this.BangGia == null ? TrangThai.Them : TrangThai.Sua;
			txtDonGia.Text = TrangThai == TrangThai.Them ? "" : (this.BangGia as Entity.BangGiaEntity).DonGia.ToString();
			if (TrangThai == TrangThai.Them)
			{
				cboKieuGiatLa.SelectedIndex = -1;
				cboMatHang.SelectedIndex = -1;
			}
		}

		public Entity.BangGiaEntity BangGia
		{
			set
			{
				bndsrcBaogia.DataSource = value;
			}
			get
			{
				return bndsrcBaogia.DataSource as Entity.BangGiaEntity;
			}
		}

		private Boolean CheckForm()
		{
			txtDonGia.Text = txtDonGia.Text.Trim();
			if (String.IsNullOrEmpty(txtDonGia.Text))
			{
				txtDonGia.Focus();
				MessageBox.Show("Đơn giá trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (cboMatHang.SelectedIndex == -1)
			{
				cboMatHang.Focus();
				MessageBox.Show("Bạn chưa chọn đồ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (cboKieuGiatLa.SelectedIndex == -1)
			{
				cboKieuGiatLa.Focus();
				MessageBox.Show("Bạn chưa chọn kiểu giặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (nudSoSanPham.Value < 1)
			{
				nudSoSanPham.Focus();
				MessageBox.Show("Số sản phẩm phải > 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			Entity.BangGiaEntity bg = new Entity.BangGiaEntity()
			{
				DonGia = Int64.Parse(txtDonGia.Text),
				MaHang = Int32.Parse(cboMatHang.SelectedValue.ToString()),
				MaKieuGiat = Int32.Parse(cboKieuGiatLa.SelectedValue.ToString()),
				SoSanPham = Convert.ToByte(nudSoSanPham.Value)
			};
			if (TrangThai == TrangThai.Them)
			{
				Int32 count = Business.BangGiaBO.CheckExist(0, bg.MaHang, bg.MaKieuGiat);
				if (count > 0)
				{
					MessageBox.Show("Đã tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					Int32 kq = Business.BangGiaBO.Insert(bg);
					onsaved();
					this.Close();
				}
			}
			else
			{
				bg.IDGia = (bndsrcBaogia.DataSource as Entity.BangGiaEntity).IDGia;
				Int32 count = Business.BangGiaBO.CheckExist(bg.IDGia, bg.MaHang, bg.MaKieuGiat);
				if (count > 0)
				{
					MessageBox.Show("Đã tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					Int32 kq = Business.BangGiaBO.Update(bg);
					onsaved();
					this.Close();
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cboMatHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) cboKieuGiatLa.Focus();
		}

		private void cboKieuGiatLa_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) txtDonGia.Focus();
		}

		private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) btnGhi_Click(sender, e);
		}
	}
}
