using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTMucDoVip : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTMucDoVip()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmCTMucDoVip_Load);
			this.FormClosed += new FormClosedEventHandler(frmCTMucDoVip_FormClosed);
		}

		void frmCTMucDoVip_FormClosed(object sender, FormClosedEventArgs e)
		{
			onsaved();
		}

		private void frmCTMucDoVip_Load(object sender, EventArgs e)
		{
			TrangThai = this.MucDoVip == null ? TrangThai.Them : TrangThai.Sua;
			if (TrangThai == TrangThai.Sua)
			{
				nudGiamGia.Value =(bndsrcMucDoVip.DataSource as Entity.MucDoVipEntity).GiamGia;
			}
		}

		public Entity.MucDoVipEntity MucDoVip
		{
			set
			{
				bndsrcMucDoVip.DataSource = value;
			}
			get
			{
				return bndsrcMucDoVip.DataSource as Entity.MucDoVipEntity;
			}
		}

		private Boolean CheckForm()
		{
			txtTenVip.Text = txtTenVip.Text.Trim();
			if (String.IsNullOrEmpty(txtTenVip.Text))
			{
				txtTenVip.Focus();
				MessageBox.Show("Tên mức độ VIP trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if ((Int32)nudGiamGia.Value == 0)
			{
				nudGiamGia.Focus();
				MessageBox.Show("Bạn chưa chọn giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			bndsrcMucDoVip.EndEdit();			
			if (TrangThai == TrangThai.Them)
			{
				Entity.MucDoVipEntity mdv = new Entity.MucDoVipEntity()
				{
					TenVip = txtTenVip.Text,
					GiamGia = (Int32)nudGiamGia.Value
				};
				mdv.MaVip = Business.MucDoVipBO.Insert(mdv);
				onsaved();
				this.Close();
			}
			else
			{
				Entity.MucDoVipEntity mdv = bndsrcMucDoVip.DataSource as Entity.MucDoVipEntity;
				mdv.TenVip = txtTenVip.Text;
				mdv.GiamGia = (Int32)nudGiamGia.Value;
				Int32 kq = Business.MucDoVipBO.Update(mdv);
				onsaved();
				this.Close();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtTenVip_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, nudGiamGia);
		}

		private void nudGiamGia_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) btnGhi_Click(sender, e);
		}
	}
}
