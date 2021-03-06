﻿using System;
using System.Windows.Forms;
using Entity;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSViecCanLam : Form
	{
		private Boolean _cothaydoi = false;
		private String _khoBefore = String.Empty;
		private Int32 _slotBefore = 0;
		private Int32 _cotKho = 0;
		private Int32 _cotSlot = 0;
		private Int32 _cotDaTra = 0;
		private Int32 _cotNgayTra = 0;
		private ListPhieuSlotEntity _lstPhieuSlotBefore = null;

		public frmDSViecCanLam()
		{
			InitializeComponent();
			this.Load += new EventHandler(frmDSViecCanLam_Load);
			dgvDSCatDo.CellEndEdit += new DataGridViewCellEventHandler(dgvDSCatDo_CellEndEdit);
			dgvDSCatDo.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvDSCatDo_CellBeginEdit);
			this.FormClosing += new FormClosingEventHandler(frmDSViecCanLam_FormClosing);
		}

		private void frmDSViecCanLam_Load(object sender, EventArgs e)
		{
			Xuly.Xuly.ToanManHinh(this);
			if (BienChung.isToanManHinh)
				dgvDSCatDo.Columns["ghichuDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			else
				dgvDSCatDo.Columns["ghichuDataGridViewTextBoxColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dtpTuNgay.Value = DateTime.Now;
			dtpDenNgay.Value = DateTime.Now.AddDays(Xuly.ThaoTacIniCauHinhPhanMem.ReadViecCanLam());
			this.LoadData();
			//lblMauDaTra.Text = "Xanh lá: đã trả";
			//lblMauDaGiat.Text = "Da trời:  đã giặt";
			//lblMauChuaGiat.Text = "Màu đỏ: chưa giặt";
			//lblMauDaTra.ForeColor = colordatra;
			//lblMauDaGiat.ForeColor = colordalam;
			//lblMauChuaGiat.ForeColor = colorchualam;
			this.TimCotKhoSlot();
		}

		private void frmDSViecCanLam_FormClosing(object sender, FormClosingEventArgs e)
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
			}
		}

		public void focusMaPhieu()
		{
			txtMaPhieu.Focus();
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

		private void LoadData()
		{
			Int64 maphieu = 0, mavach = 0;
			if (!String.IsNullOrEmpty(txtMaPhieu.Text) && !Int64.TryParse(txtMaPhieu.Text, out maphieu))
			{
				MessageBox.Show("Mã phiếu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!String.IsNullOrEmpty(txtMaVach.Text) && !Int64.TryParse(txtMaVach.Text, out mavach))
			{
				MessageBox.Show("Mã vạch không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ListPhieuSlotEntity lstPSTemp = Business.PhieuSlotBO.SelectViecCanLam(maphieu, dtpTuNgay.Value, dtpDenNgay.Value,
															mavach, chkTatca.Checked, chkTatcaDo.Checked, txtTenDo.Text.Trim());
			bndsrcDSViecCanLam.DataSource = lstPSTemp;
			_lstPhieuSlotBefore = Xuly.Xuly.CopyListPhieuSlot(lstPSTemp);
			VeDataGrid();
			//if (dgvDSCatDo.RowCount > 0)
			//{
			//    dgvDSCatDo.Focus();
			//    dgvDSCatDo.CurrentCell = dgvDSCatDo[_cotKho, 0];
			//    dgvDSCatDo.CurrentCell.Selected = true;
			//};
        }

		private void VeDataGrid()
		{
			System.Drawing.Color colorve;
			ListPhieuSlotEntity phieuSlotTrenCSDL = bndsrcDSViecCanLam.DataSource as ListPhieuSlotEntity;
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
				txtTongSoSanPham.Text = dgvDSCatDo.Rows.Count.ToString();
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
			ListPhieuSlotEntity listPhieuSlot = bndsrcDSViecCanLam.DataSource as ListPhieuSlotEntity;
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

		private void chkTatca_CheckedChanged(object sender, EventArgs e)
		{
			dtpTuNgay.Enabled = !chkTatca.Checked;
			dtpDenNgay.Enabled = !chkTatca.Checked;
			txtMaPhieu.Enabled = !chkTatca.Checked;
			txtMaVach.Enabled = !chkTatca.Checked;
			txtTenDo.Enabled = !chkTatca.Checked;
		}

		private void bndsrcDSViecCanLam_DataMemberChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Message", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtMaPhieu_TextChanged(object sender, EventArgs e)
		{
			chkTatcaDo.Checked = !(String.IsNullOrEmpty(txtMaPhieu.Text));
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
					MaVach = Convert.ToInt64(row.Cells["MaVach"].Value),
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

		private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnGhi.Enabled) btnGhi_Click(sender, e);
		}
	}
}
