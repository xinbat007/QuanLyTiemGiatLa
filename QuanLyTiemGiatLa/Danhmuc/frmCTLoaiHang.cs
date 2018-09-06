using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTLoaiHang : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTLoaiHang()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmCTLoaiHang_Load);
		}

		private void frmCTLoaiHang_Load(object sender, EventArgs e)
		{
			TrangThai = this.LoaiHang == null ? TrangThai.Them : TrangThai.Sua;
		}

		public Entity.LoaiHangEntity LoaiHang
		{
			set
			{
				bndsrcLoaiHang.DataSource = value;
			}
			get
			{
				return bndsrcLoaiHang.DataSource as Entity.LoaiHangEntity;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private Boolean CheckForm()
		{
			txtTenLoaiHang.Text = txtTenLoaiHang.Text.Trim();
			if (String.IsNullOrEmpty(txtTenLoaiHang.Text))
			{
				txtTenLoaiHang.Focus();
				MessageBox.Show("Tên loại hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;				
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			Entity.LoaiHangEntity lh = new Entity.LoaiHangEntity()
			{
				TenLoaiHang = txtTenLoaiHang.Text
			};
			if (TrangThai == TrangThai.Them)
			{
				Int32 kq = Business.LoaiHangBO.Insert(lh);
				onsaved();
				this.Close();
			}
			else
			{
				lh.MaLoaiHang = (bndsrcLoaiHang.DataSource as Entity.LoaiHangEntity).MaLoaiHang;
				Int32 kq = Business.LoaiHangBO.Update(lh);
				onsaved();
				this.Close();
			}
		}

		private void frmCTLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
		{
			bndsrcLoaiHang.EndEdit();
			bndsrcLoaiHang.CancelEdit();			
		}
	}
}
