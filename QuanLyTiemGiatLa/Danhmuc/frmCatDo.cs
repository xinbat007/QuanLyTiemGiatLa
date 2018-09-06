using System;
using System.Windows.Forms;
using Entity;
using Business;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmCatDo : Form
	{
		private Boolean _cothaydoi = false;
		private String _khoBefore = String.Empty;
		private Int32 _slotBefore = 0;
		private Int32 _cotKho = 0;
		private Int32 _cotSlot = 0;
		private Int32 _cotDaTra = 0;
		private Int32 _cotNgayTra = 0;
		private Int32 _cotMaVach = 0;
		private ListPhieuSlotEntity _lstPhieuSlotBefore = null;

		public frmCatDo()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmCatDo_Load);
			this.FormClosing += new FormClosingEventHandler(frmCatDo_FormClosing);
			dgvDSCatDo.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvDSCatDo_CellBeginEdit);
			dgvDSCatDo.CellEndEdit += new DataGridViewCellEventHandler(dgvDSCatDo_CellEndEdit);
		}

		private void frmCatDo_Load(object sender, EventArgs e)
		{
			Xuly.Xuly.ToanManHinh(this);
			if (BienChung.isToanManHinh)
				dgvDSCatDo.Columns["ghichuDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			else
				dgvDSCatDo.Columns["ghichuDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.TimCotKhoSlot();
		}

		public void focusMa()
		{
			if (Xuly.ThaoTacIniCauHinhPhanMem.ReadCatdoFocus() == 0)
				txtMaPhieu.Focus();
			else
				txtMaVach.Focus();
		}

		private void frmCatDo_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_cothaydoi && MessageBox.Show("Bạn chưa lưu, bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				btnGhi_Click(sender, e);
			}
		}

		private void TimCotKhoSlot()
		{
			for (int i = 0; i < dgvDSCatDo.ColumnCount; i++)
			{
				if (dgvDSCatDo.Columns[i].Name == "khoDataGridViewTextBoxColumn")
					_cotKho = i;
				else if (dgvDSCatDo.Columns[i].Name == "slotDataGridViewTextBoxColumn")
					_cotSlot = i;
				else if (dgvDSCatDo.Columns[i].Name == "daTraDataGridViewCheckBoxColumn")
					_cotDaTra = i;
				else if (dgvDSCatDo.Columns[i].Name == "NgayTraDataGridViewTextBoxColumn")
					_cotNgayTra = i;
				else if (dgvDSCatDo.Columns[i].Name == "maVachDataGridViewTextBoxColumn")
					_cotMaVach = i;
			}
		}

		private void dgvDSCatDo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			try
			{
				if ((e.ColumnIndex != _cotKho) && (e.ColumnIndex != _cotSlot)) return;
				_khoBefore = dgvDSCatDo[_cotKho, e.RowIndex].Value.ToString();
				_slotBefore = Convert.ToInt32(dgvDSCatDo[_cotSlot, e.RowIndex].Value);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RollBack(Int32 rowIndex)
		{
			dgvDSCatDo[_cotKho, rowIndex].Value = _khoBefore;
			dgvDSCatDo[_cotSlot, rowIndex].Value = _slotBefore;
		}

		private void dgvDSCatDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == _cotDaTra)
				{
					bool datra = (bool)dgvDSCatDo[_cotDaTra, e.RowIndex].Value;
					if (datra)
					{
						dgvDSCatDo[_cotNgayTra, e.RowIndex].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
					}
					else
					{
						dgvDSCatDo[_cotNgayTra, e.RowIndex].Value = "";
					}
				}
				if ((e.ColumnIndex != _cotKho) && (e.ColumnIndex != _cotSlot)) return;
				String kho = dgvDSCatDo[_cotKho, e.RowIndex].Value == null ?
								String.Empty :
								dgvDSCatDo[_cotKho, e.RowIndex].Value.ToString();
				Int32 slot = Convert.ToInt32(dgvDSCatDo[_cotSlot, e.RowIndex].Value);
				if (slot == 0) return;
				Int64 ngoaitrumaphieunay = Convert.ToInt64(dgvDSCatDo[0, e.RowIndex].Value);
				String findMaphieuTreoCungMoc = Business.PhieuSlotBO.SelectByKhoSlot(kho, slot, ngoaitrumaphieunay);
				if (!String.IsNullOrEmpty(findMaphieuTreoCungMoc))
				{
					if (MessageBox.Show("Giá này đã được sử dụng bởi phiếu '" + findMaphieuTreoCungMoc + "'"
						+ "\nBạn có muốn chèn vào không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						== DialogResult.No)
					{
						this.RollBack(e.RowIndex);
						return;
					}
				}
				_cothaydoi = true;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void VeDataGrid()
		{
			System.Drawing.Color colorve;
			ListPhieuSlotEntity phieuSlotTrenCSDL = bndsrcDSCatDo.DataSource as ListPhieuSlotEntity;
			if (phieuSlotTrenCSDL != null)
			{
				for (int i = 0; i < phieuSlotTrenCSDL.Count; i++)
				{
					bool datra = (bool)phieuSlotTrenCSDL[i].DaTra;
					if (datra) colorve = BienChung.mautrangthaido.DaTra;
					else if (!String.IsNullOrEmpty(phieuSlotTrenCSDL[i].GhiChu))
                        colorve = BienChung.mautrangthaido.GhiChu;
					else if (phieuSlotTrenCSDL[i].Slot != 0)
                        colorve = BienChung.mautrangthaido.DaGiat;
                    else colorve = BienChung.mautrangthaido.ChuaGiat;
					for (int k = 0; k < dgvDSCatDo.ColumnCount; k++)
						dgvDSCatDo.Rows[i].Cells[k].Style.ForeColor = colorve;
					dgvDSCatDo.Rows[i].Cells["daTraDataGridViewCheckBoxColumn"].ReadOnly = datra;
					dgvDSCatDo.Rows[i].Cells["khoDataGridViewTextBoxColumn"].ReadOnly = datra;
					dgvDSCatDo.Rows[i].Cells["slotDataGridViewTextBoxColumn"].ReadOnly = datra;
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				btnSearch.Enabled = false;
				this.LoadData();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btnSearch.Enabled = true;
			}
		}

		private Boolean CheckForm(out Int64 maphieu, out Int64 mavach)
		{
			maphieu = 0;
			mavach = 0;
			txtTenDo.Text = txtTenDo.Text.Trim();
			//if (String.IsNullOrEmpty(txtMaPhieu.Text) && String.IsNullOrEmpty(txtMaVach.Text) && string.IsNullOrEmpty(txtTenDo.Text))
			//{
			//    MessageBox.Show("Chưa có tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//    txtMaPhieu.Focus();
			//    return false;
			//}
			if (!String.IsNullOrEmpty(txtMaPhieu.Text) && !Int64.TryParse(txtMaPhieu.Text, out maphieu))
			{
				MessageBox.Show("Mã phiếu phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaPhieu.Focus();
				txtMaPhieu.SelectAll();
				return false;
			}
			if (!String.IsNullOrEmpty(txtMaVach.Text) && !Int64.TryParse(txtMaVach.Text, out mavach))
			{
				MessageBox.Show("Mã vạch phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaVach.Focus();
				txtMaVach.SelectAll();
				return false;
			}
			//if (maphieu > 0 && mavach > 0)
			//{
			//    MessageBox.Show("Bạn chỉ được điền mã phiếu hoặc mã vạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//    txtMaPhieu.Focus();
			//    txtMaPhieu.SelectAll();
			//    return false;
			//}
			return true;
		}

		private void LoadData()
		{
			try
			{
				Int64 maphieu, mavach;
				if (!this.CheckForm(out maphieu, out mavach)) return;
				ListPhieuSlotEntity lstPSTemp = null;
				if (maphieu > 0 && mavach == 0)
					lstPSTemp = Business.PhieuSlotBO.SelectByMaPhieu_TenDo(maphieu, txtTenDo.Text, chkTimTheoNgay.Checked, dtpTuNgay.Value, dtpDenNgay.Value, chkPhieuChuaTra.Checked);
				else if (maphieu == 0 && mavach > 0)
					lstPSTemp = Business.PhieuSlotBO.SelectByMaVach_TenDo(mavach, txtTenDo.Text, chkTimTheoNgay.Checked, dtpTuNgay.Value, dtpDenNgay.Value, chkPhieuChuaTra.Checked);
				else if (maphieu == 0 && mavach == 0)
					lstPSTemp = Business.PhieuSlotBO.SelectByMaPhieu_TenDo(maphieu, txtTenDo.Text, chkTimTheoNgay.Checked, dtpTuNgay.Value, dtpDenNgay.Value, chkPhieuChuaTra.Checked);
				else
				{	// chả bao h nhảy vào đây
					lstPSTemp = null;
					MessageBox.Show("Bạn chưa chọn tiêu chí tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				bndsrcDSCatDo.DataSource = lstPSTemp;
				_lstPhieuSlotBefore = Xuly.Xuly.CopyListPhieuSlot(lstPSTemp);
				VeDataGrid();
				if (dgvDSCatDo.RowCount > 0)
				{
					int focusrow = 0;
					if (mavach > 0 && _cotMaVach > 0)
						for (int i = 0; i < dgvDSCatDo.RowCount; i++)
							if (dgvDSCatDo[_cotMaVach, i].Value.ToString() == mavach.ToString()) { focusrow = i; break; }
					dgvDSCatDo.Focus();
					dgvDSCatDo.CurrentCell = dgvDSCatDo[_cotKho, focusrow];
					dgvDSCatDo.CurrentCell.Selected = true;
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCollapse_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
			btnCollapse.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
		}

		private void btnGhi_Click(object sender, EventArgs e)
		{
			dgvDSCatDo.EndEdit();
			ListPhieuSlotEntity listPhieuSlot = bndsrcDSCatDo.DataSource as ListPhieuSlotEntity;
			if (listPhieuSlot != null)
			{
				Xuly.Xuly.CapNhatThoiDiemLuu(_lstPhieuSlotBefore, listPhieuSlot);
				Business.PhieuSlotBO.Update(listPhieuSlot);
				_lstPhieuSlotBefore = Xuly.Xuly.CopyListPhieuSlot(listPhieuSlot);
				VeDataGrid();
				MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			_cothaydoi = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvDSCatDo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0) return;
				var row = dgvDSCatDo.Rows[e.RowIndex];
				var phieuslot = new PhieuSlotEntity()
				{
					MaPhieu = Convert.ToInt64(row.Cells["maPhieuDataGridViewTextBoxColumn"].Value),
					STT = Convert.ToInt32(row.Cells["sTTDataGridViewTextBoxColumn"].Value),
					MaVach = Convert.ToInt64(row.Cells["maVachDataGridViewTextBoxColumn"].Value),
					TenHang = row.Cells["tenHangDataGridViewTextBoxColumn"].Value.ToString(),
					TenKieuGiat = row.Cells["tenKieuGiatDataGridViewTextBoxColumn"].Value.ToString(),
					Kho = row.Cells["khoDataGridViewTextBoxColumn"].Value.ToString(),
					Slot = Convert.ToInt32(row.Cells["slotDataGridViewTextBoxColumn"].Value),
					GhiChu = row.Cells["ghichuDataGridViewTextBoxColumn"].Value.ToString(),
					DaTra = (bool)row.Cells[_cotDaTra].Value
				};
				frmCTCatDo frm = new frmCTCatDo(phieuslot);
				frm.onsaved = new OnSaved(this.LoadData);
				frm.ShowDialog(this);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnGhi.Enabled) btnGhi_Click(sender, e);
		}

		private void btnXemPhieu_Click(object sender, EventArgs e)
		{
			try
			{
				Int64 maphieu = Convert.ToInt64(dgvDSCatDo.Rows[dgvDSCatDo.SelectedCells[0].RowIndex].Cells["maPhieuDataGridViewTextBoxColumn"].Value);
				frmLapPhieu frm = new frmLapPhieu();
				frm._phieu = new PhieuEntity() { MaPhieu = maphieu };
				frm.onsaved = new OnSaved(this.LoadData);
				frm.ShowDialog();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void xemPhieuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnXemPhieu.Enabled) btnXemPhieu_Click(sender, e);
		}

		private void xemKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnXemKhachHang_Click(null, null);
		}

		private void btnXemKhachHang_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvDSCatDo.RowCount == 0) return;
				var rowIndex = dgvDSCatDo.SelectedCells[0].RowIndex;
				Int64 maphieu = Convert.ToInt64(dgvDSCatDo["maPhieuDataGridViewTextBoxColumn", rowIndex].Value);
				KhachHangEntity kh = KhachHangBO.SelectByMaPhieu(maphieu);
				if (kh != null)
				{
					txtTenKhachHang.Text = kh.TenKhachHang;
					txtSoDienThoai.Text = kh.DienThoai;
				}
				else
				{
					txtTenKhachHang.Text = string.Empty;
					txtSoDienThoai.Text = string.Empty;
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void chkTimTheoNgay_CheckedChanged(object sender, EventArgs e)
		{
			lblTuNgay.Visible = chkTimTheoNgay.Checked;
			lblDenNgay.Visible = chkTimTheoNgay.Checked;
			dtpTuNgay.Visible = chkTimTheoNgay.Checked;
			dtpDenNgay.Visible = chkTimTheoNgay.Checked;
		}
	}
}
