using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTKieuGiatLa : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTKieuGiatLa()
		{
			InitializeComponent();			
			this.Load += new EventHandler(frmCTKieuGiatLa_Load);
		}

		private void frmCTKieuGiatLa_Load(object sender, EventArgs e)
		{
			TrangThai = this.KieuGiatLa == null ? TrangThai.Them : TrangThai.Sua;		
		}

		public Entity.KieuGiatLaEntity KieuGiatLa
		{
			set
			{
				bndsrcKieuGiatLa.DataSource = value;
			}
			get
			{
				return bndsrcKieuGiatLa.DataSource as Entity.KieuGiatLaEntity;
			}
		}

		private Boolean CheckForm()
		{
			txtTenKieuGiat.Text = txtTenKieuGiat.Text.Trim();
			if (String.IsNullOrEmpty(txtTenKieuGiat.Text))
			{
				txtTenKieuGiat.Focus();
				MessageBox.Show("Tên kiểu giặt trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			Entity.KieuGiatLaEntity kg = new Entity.KieuGiatLaEntity()
			{
				TenKieuGiat = txtTenKieuGiat.Text
			};
			if (TrangThai == TrangThai.Them)
			{
				Int32 kq = Business.KieuGiatLaBO.Insert(kg);
				onsaved();
				this.Close();
			}
			else
			{
				kg.MaKieuGiat = (bndsrcKieuGiatLa.DataSource as Entity.KieuGiatLaEntity).MaKieuGiat;
				Int32 kq = Business.KieuGiatLaBO.Update(kg);
				onsaved();
				this.Close();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
