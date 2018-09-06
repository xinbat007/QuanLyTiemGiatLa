using System;
using System.Windows.Forms;
using Business;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTKhachHang : Form
	{
		public OnSaved onsaved;
		public TrangThai TrangThai;
		private String _sothevip;

		public frmCTKhachHang()
		{
			InitializeComponent();
			bndsrcDSMucDoVip.DataSource = Business.MucDoVipBO.SelectAll();
			this.Load += new EventHandler(frmCTKhachHang_Load);
		}

		private void frmCTKhachHang_Load(object sender, EventArgs e)
		{
			TrangThai = this.KhachHang == null ? TrangThai.Them : TrangThai.Sua;
			if (TrangThai == TrangThai.Them)
			{
				cboMucDoVip.SelectedIndex = -1;
			}
			else
			{
				_sothevip = KhachHang.SoTheVip;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public Entity.KhachHangEntity KhachHang
		{
			set
			{
				bndsrcKhachHang.DataSource = value;
			}
			get
			{
				return bndsrcKhachHang.DataSource as Entity.KhachHangEntity;
			}
		}

		private Boolean CheckForm()
		{
			txtTenKhachHang.Text = txtTenKhachHang.Text.Trim();
			txtDiaChi.Text = txtDiaChi.Text.Trim();
			txtDienThoai.Text = txtDienThoai.Text.Trim();
			txtSoTheVip.Text = txtSoTheVip.Text.Trim();
			if (!String.IsNullOrEmpty(txtDienThoai.Text))
			{
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			Entity.KhachHangEntity kh = new Entity.KhachHangEntity
			{
				TenKhachHang = txtTenKhachHang.Text,
				DiaChi = txtDiaChi.Text,
				DienThoai = txtDienThoai.Text,
				SoTheVip = txtSoTheVip.Text,
				MaVip = cboMucDoVip.Text == String.Empty ? 0 : (Int32) cboMucDoVip.SelectedValue
			};
			if (TrangThai == TrangThai.Them)
			{
				if (!String.IsNullOrEmpty(kh.SoTheVip))
				{
					Int32 kqtimthay;
					KhachHangBO.SelectBySoTheVip(kh.SoTheVip, out kqtimthay);
					if (kqtimthay > 0)
					{
						if (MessageBox.Show("Đã tồn tại số thẻ vip này" +
							"\nBạn có muốn tiếp tục cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							return;
						}
					}
				}
				Int64 kq = Business.KhachHangBO.Insert(kh);
				onsaved();
				this.Close();
			}
			else
			{
				if (!String.IsNullOrEmpty(kh.SoTheVip) && kh.SoTheVip != _sothevip)
				{
					Int32 kqtimthay;
					KhachHangBO.SelectBySoTheVip(kh.SoTheVip, out kqtimthay);
					if (kqtimthay > 0)
					{
						if (MessageBox.Show("Đã tồn tại số thẻ vip này" +
							"\nBạn có muốn tiếp tục cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							return;
						}
					}
				}
				kh.MaKhachHang = (bndsrcKhachHang.DataSource as Entity.KhachHangEntity).MaKhachHang;
				Int32 kq = Business.KhachHangBO.Update(kh);
				onsaved();
				this.Close();
			}
		}
	}
}
