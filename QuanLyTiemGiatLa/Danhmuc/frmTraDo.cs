using System.Windows.Forms;
using Entity;
using System;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public delegate void TraDoRoiLapPhieu(long makh);
	public partial class frmTraDo : Form
	{
		public TraDoRoiLapPhieu OnTraDoRoiLapPhieu;
		private Int64 _maphieu;
		private frmDSPhieu _formcha;
		private Boolean _dathanhtoan;
		private Boolean _cothaydoi;
		private String _khoBefore = String.Empty;
		private Int32 _slotBefore = 0;
		private Int32 _cotKho = 0;
		private Int32 _cotSlot = 0;
		private Int32 _cotDaTra = 0;
		private Int32 _cotNgayTra = 0;
		private ListPhieuSlotEntity _lstPhieuSlotBefore = null;

		public frmTraDo(Int64 maph, frmDSPhieu fcha, Boolean datt)
		{
			InitializeComponent();
			dgvDSCatDo.AutoGenerateColumns = false;
			_maphieu = maph;
			_formcha = fcha;
			_dathanhtoan = datt;
			this.Load += new System.EventHandler(frmCatDo_Load);
			dgvDSCatDo.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvDSCatDo_CellBeginEdit);
			dgvDSCatDo.CellEndEdit += new DataGridViewCellEventHandler(dgvDSCatDo_CellEndEdit);
			this.FormClosing += new FormClosingEventHandler(frmCatDo_FormClosing);
		}

		private void frmCatDo_Load(object sender, System.EventArgs e)
		{
			this.TimCotKhoSlot();
			this.LoadData();
			if (_formcha == null) btnTraHetDo.Enabled = false;
			lblMessage.Visible = !_dathanhtoan;
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
				String kho = dgvDSCatDo[_cotKho, e.RowIndex].Value == null ? String.Empty : dgvDSCatDo[_cotKho, e.RowIndex].Value.ToString();
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
					}
				}
				_cothaydoi = true;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadData()
		{
			ListPhieuSlotEntity lstPSTemp = Business.PhieuSlotBO.SelectByMaPhieu(_maphieu);
			bndsrcDSCatDo.DataSource = lstPSTemp;
			_lstPhieuSlotBefore = Xuly.Xuly.CopyListPhieuSlot(lstPSTemp);
			VeDataGrid();
			if (dgvDSCatDo.RowCount > 0)
			{
				dgvDSCatDo.Focus();
				dgvDSCatDo.CurrentCell = dgvDSCatDo[_cotKho, 0];
				dgvDSCatDo.CurrentCell.Selected = true;
			};
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
					{
						dgvDSCatDo.Rows[i].Cells[k].Style.ForeColor = colorve;
						dgvDSCatDo.Rows[i].Cells[k].ReadOnly = datra;
					}
				}
			}
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

		private void btnTraHetDo_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn thu tiền và trả hết đồ cho khách không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				ListPhieuSlotEntity listPhieuSlot = bndsrcDSCatDo.DataSource as ListPhieuSlotEntity;
				if (listPhieuSlot != null)
				{
					for (int i = 0; i < listPhieuSlot.Count; i++)
					{
						if (String.IsNullOrEmpty(listPhieuSlot[i].NgayTra))
						{
							listPhieuSlot[i].DaTra = true;
							listPhieuSlot[i].NgayTra = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
							//listPhieuSlot[i].ThoiDiemLuu = DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " " + BienChung.userCurrent.UserName;
						}
					}
					//-------------------------------------
					Business.PhieuBO.UpdateDaTraDo(_maphieu);
					this.LockControl();
					Business.PhieuSlotBO.InsertPhieuSlot_DaTra(listPhieuSlot);
					Business.PhieuSlotBO.DeleteByMaPhieu(_maphieu);
					_cothaydoi = false;
				}
				else
				{
					MessageBox.Show("Không thấy phiếu slot", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void LockControl()
		{
			dgvDSCatDo.Enabled = false;
			btnTraHetDo.Enabled = false;
			btnGhi.Enabled = false;
			if (_formcha != null) _formcha.LoadData();
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
					DaTra = (bool) row.Cells[_cotDaTra].Value
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

		private void traHetDoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnTraHetDo.Enabled) btnTraHetDo_Click(sender, e);
		}

		private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnGhi.Enabled) btnGhi_Click(sender, e);
		}

		private void lapPhieuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnLapPhieu.Enabled) btnLapPhieu_Click(null, null);
		}

		private void btnLapPhieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (OnTraDoRoiLapPhieu == null) return;
				PhieuEntity phieu = Business.PhieuBO.SelectByMaPhieu(_maphieu);
				if (phieu != null && phieu.MaPhieu > 0)
				{
					this.Close();
					OnTraDoRoiLapPhieu(phieu.MaKhachHang);
				}
				else
				{
					MessageBox.Show("Không có thấy phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
