using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCTChotKet : Form
	{
		public OnSaved onsaved;
		private TrangThai TrangThai;

		public frmCTChotKet()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmCTChotKet_Load);
		}

		private void frmCTChotKet_Load(object sender, EventArgs e)
		{
			try
			{
				TrangThai = _ChotKet == null ? TrangThai.Them : TrangThai.Sua;
				if (TrangThai == TrangThai.Them)
				{
					_infor = Business.InformationBO.Select();
					this._ChotKet = new Entity.ChotKetEntity()
					{
						ThoiDiemChot = DateTime.Now,
						TuPhieu = _infor.PhieuChotKetGanNhat + 1,
						DenPhieu = Business.PhieuBO.SelectMaxMaPhieu(),
						NguoiChot = BienChung.userCurrent.UserName
					};
					_ChotKet.SoTienChot = Business.PhieuBO.SelectSumTongTienByMaPhieu(_ChotKet.TuPhieu, _ChotKet.DenPhieu);
					txtTuPhieu.Text = _ChotKet.TuPhieu.ToString();
					txtDenPhieu.Text = _ChotKet.DenPhieu.ToString();
					dtpThoiDiemChot.Value = _ChotKet.ThoiDiemChot;
					txtNguoiChot.Text = _ChotKet.NguoiChot;
					txtSoTienChot.Text = _ChotKet.SoTienChot.ToString("N0");
					string lstPhieuHuy = Business.PhieuBO.SelectMaPhieuHuy(_ChotKet.TuPhieu, _ChotKet.DenPhieu);
					if (!string.IsNullOrEmpty(lblDSPhieuHuy.Text))
					{
						lblDSPhieuHuy.Text = "Ds phiếu hủy: " + lstPhieuHuy;
						this.Height = 380;
					}
				}
				else
				{
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public Entity.ChotKetEntity _ChotKet { get; set; }
		private Entity.InformationEntity _infor { get; set; }

		private Boolean CheckForm()
		{
			if (_ChotKet.SoTienChot <=0)
			{
				MessageBox.Show("Không có tiền để cất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.CheckForm()) return;
				if (TrangThai == TrangThai.Them)
				{
					if (MessageBox.Show("Bạn có chắc chắn chốt két không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						return;
					_ChotKet.GhiChu = txtGhiChu.Text;
					_infor.PhieuChotKetGanNhat = _ChotKet.DenPhieu;
					Business.InformationBO.UpdatePhieuChotKetGanNhat(_infor);
					Business.ChotKetBO.Insert(_ChotKet);
					if (onsaved != null) onsaved();
					this.Close();
				}
				else
				{
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
