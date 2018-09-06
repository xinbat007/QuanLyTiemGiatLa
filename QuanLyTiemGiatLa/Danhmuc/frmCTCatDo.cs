using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTCatDo : Form
	{
		private Entity.PhieuSlotEntity _phieuslot = null;
		public OnSaved onsaved;

		public frmCTCatDo(Entity.PhieuSlotEntity pslot)
		{
			InitializeComponent();
			_phieuslot = pslot;
			this.Load += new EventHandler(frmCTCatDo_Load);
		}

		private void frmCTCatDo_Load(object sender, EventArgs e)
		{
			txtGhiChu.Text = _phieuslot.GhiChu;
			txtKieuGiat.Text = _phieuslot.TenKieuGiat;
			txtKho.Text = _phieuslot.Kho;
			txtMaDo.Text = _phieuslot.MaHienThi;
			txtMaVach.Text = _phieuslot.MaVach.ToString();
			txtSlot.Text = _phieuslot.Slot.ToString();
			txtTenDo.Text = _phieuslot.TenHang;
			if (_phieuslot.DaTra) btnGhi.Enabled = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private Boolean CheckForm()
		{
			Int32 slot;
			if (!Int32.TryParse(txtSlot.Text, out slot))
			{
				MessageBox.Show("Slot phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSlot.Focus();
				txtSlot.SelectAll();
				return false;
			}
			_phieuslot.Slot = slot;
			_phieuslot.Kho = txtKho.Text;
			_phieuslot.GhiChu = txtGhiChu.Text;
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			if (!this.CheckForm()) return;
			_phieuslot.ThoiDiemLuu = DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " " + BienChung.userCurrent.UserName;
			if (Business.PhieuSlotBO.Update(_phieuslot) != 1)
			{
				MessageBox.Show("Số bản ghi update không bằng 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				onsaved();
				this.Close();
			}
		}

		private void btnLayGioHienTai_Click(object sender, EventArgs e)
		{
			try
			{
				txtGhiChu.Text = txtGhiChu.Text + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
