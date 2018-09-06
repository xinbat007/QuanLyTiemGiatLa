using System.Windows.Forms;
using System;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTGiaDeDo : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTGiaDeDo()
		{
			InitializeComponent();
			this.Load += new System.EventHandler(frmCTGiaDeDo_Load);
		}

		private void frmCTGiaDeDo_Load(object sender, System.EventArgs e)
		{
			TrangThai = this.Kho == null ? TrangThai.Them : TrangThai.Sua;
		}

		public Entity.KhoEntity Kho
		{
			set
			{
				bndsrcKho.DataSource = value;
			}
			get
			{
				return bndsrcKho.DataSource as Entity.KhoEntity;
			}
		}
		
		private Boolean CheckForm()
		{
			txtTenKho.Text = txtTenKho.Text.Trim();
			txtGhiChu.Text = txtGhiChu.Text.Trim();
			txtSoLuongSlot.Text = txtSoLuongSlot.Text.Trim();			
			if (String.IsNullOrEmpty(txtTenKho.Text))
			{
				txtTenKho.Focus();
				MessageBox.Show("Tên kho trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (String.IsNullOrEmpty(txtSoLuongSlot.Text))
			{
				txtSoLuongSlot.Focus();
				MessageBox.Show("Số lượng slot trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			Int32 soluong;
			if (!Int32.TryParse( txtSoLuongSlot.Text, out soluong))
			{
				txtSoLuongSlot.Focus();
				MessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (soluong < 1)
			{
				txtSoLuongSlot.Focus();
				MessageBox.Show("Phải có ít nhất 1 slot", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, System.EventArgs e)
		{
			if (!this.CheckForm()) return;
			Entity.KhoEntity kho = new Entity.KhoEntity()
			{
				TenKho = txtTenKho.Text,
				GhiChu = txtGhiChu.Text,
				SoluongSlot = Int32.Parse(txtSoLuongSlot.Text)
			};
			if (TrangThai == TrangThai.Them)
			{
				Int32 kq = Business.KhoBO.Insert(kho);
				onsaved();
				this.Close();
			}
			else
			{
				kho.MaKho = (bndsrcKho.DataSource as Entity.KhoEntity).MaKho;
				Int32 kq = Business.KhoBO.Update(kho);
				onsaved();
				this.Close();
			}
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
