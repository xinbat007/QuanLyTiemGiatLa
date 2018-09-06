using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTDotGiamGia : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTDotGiamGia()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmCTDotGiamGia_Load);
		}

		private void frmCTDotGiamGia_Load(object sender, EventArgs e)
		{
			TrangThai = this.DotGiamGia == null ? TrangThai.Them : TrangThai.Sua;
			if (TrangThai == TrangThai.Them)
			{
				DotGiamGia = new Entity.DotGiamGiaEntity();
				dtpTuNgay.Value = DateTime.Now;
				dtpDenNgay.Value = DateTime.Now;
			}
			else
			{
				txtTenDotGiamGia.Text = DotGiamGia.TenDotGiamGia;
				dtpTuNgay.Value = DotGiamGia.TuNgay;
				dtpDenNgay.Value = DotGiamGia.DenNgay;
				nudGiamGia.Value = DotGiamGia.GiamGia;
			}
		}

		public Entity.DotGiamGiaEntity DotGiamGia { get; set; }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private Boolean CheckForm()
		{
			txtTenDotGiamGia.Text = txtTenDotGiamGia.Text.Trim();
			if (String.IsNullOrEmpty(txtTenDotGiamGia.Text))
			{
				txtTenDotGiamGia.Focus();
				MessageBox.Show("Tên đợt giảm giá trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			Int32 giamgia;
			Int32.TryParse(nudGiamGia.Value.ToString(), out giamgia);
			if (giamgia == 0)
			{
				nudGiamGia.Focus();
				MessageBox.Show("Bạn chưa chọn giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (dtpTuNgay.Value > dtpDenNgay.Value)
			{
				dtpDenNgay.Focus();
				MessageBox.Show("Từ ngày phải nhỏ hơn đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			DotGiamGia.TenDotGiamGia = txtTenDotGiamGia.Text;
			DotGiamGia.TuNgay = dtpTuNgay.Value;
			DotGiamGia.DenNgay = dtpDenNgay.Value;
			DotGiamGia.GiamGia = (Int32)nudGiamGia.Value;			
			if (TrangThai == TrangThai.Them)
			{
				DotGiamGia.MaDotGiamGia = Business.DotGiamGiaBO.Insert(DotGiamGia);
				onsaved();
				this.Close();
			}
			else
			{
				Int32 kq = Business.DotGiamGiaBO.Update(DotGiamGia);
				onsaved();
				this.Close();
			}
		}

		private void txtTenDotGiamGia_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, dtpTuNgay);
		}

		private void dtpTuNgay_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, dtpDenNgay);
		}

		private void dtpDenNgay_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, nudGiamGia);
		}

		private void nudGiamGia_KeyDown(object sender, KeyEventArgs e)
		{
			Xuly.Xuly.ControlFocus(e, btnGhi);
		}
	}
}
