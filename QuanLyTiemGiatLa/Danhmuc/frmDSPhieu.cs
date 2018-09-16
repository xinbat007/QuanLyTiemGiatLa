using System;
using System.Windows.Forms;
using Entity;
using Business;
using Newtonsoft.Json;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmDSPhieu : Form
    {
        public frmDSPhieu()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmDSPhieu_Load);
        }

        private void frmDSPhieu_Load(object sender, EventArgs e)
        {
            Xuly.Xuly.ToanManHinh(this);
            dgvDSPhieu.AutoGenerateColumns = false;
            lblMessage.Text = "";
            //this.LoadData();
        }

        public void LoadData()
        {
            //dgvDSPhieu.DataSource = Business.PhieuBO.SelectByDaThanhToan(chkTatCa.Checked, !chkTimChuaThanhToan.Checked);
            Int64 maphieu;
            ListPhieuEntity lstPhieu = Business.PhieuBO.SelectNangCao(
                        chkTatCa.Checked,
                        !chkTimChuaTraDo.Checked,
                        String.IsNullOrEmpty(txtMaPhieu.Text) ? 0 : Int64.TryParse(txtMaPhieu.Text, out maphieu) ? maphieu : 0,
                        txtSoDienThoai.Text.Trim(),
                        txtTenKhachHang.Text.Trim(),
                        chkTimTheoNgay.Checked,
                        dtpTuNgay.Value,
                        dtpDenNgay.Value);
            dgvDSPhieu.DataSource = lstPhieu;
            VeDataGrid(lstPhieu);
            //TinhTienDaGiam();
            lblMessage.Text = "";
            //Xuly.Xuly.SapxepDataGrid(dgvDSPhieu);// Ko đc

            //string json = JsonConvert.SerializeObject(lstPhieu);
        }

        private void VeDataGrid(ListPhieuEntity lstPhieu)
        {
            try
            {
                if (lstPhieu != null)
                {
                    for (int i = 0; i < lstPhieu.Count; i++)
                    {
                        if (lstPhieu[i].IsPhieuHuy)
                        {
                            dgvDSPhieu.Rows[i].Cells[7].Style.BackColor = BienChung.mautrangthaido.PhieuHuy;
                            for (int k = 0; k < dgvDSPhieu.ColumnCount; k++)
                            {
                                dgvDSPhieu.Rows[i].Cells[k].Style.ForeColor = BienChung.mautrangthaido.PhieuHuy;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void TinhTienDaGiam()
        //{
        //    for (int i = 0; i < dgvDSPhieu.RowCount; i++)
        //    {
        //        Int32 giamgia;
        //        Int32.TryParse(dgvDSPhieu["GiamGia", i].Value.ToString(), out giamgia);
        //        Int64 tongtientruocgiam;
        //        Int64.TryParse(dgvDSPhieu["TongTien", i].Value.ToString(), out tongtientruocgiam);
        //        Int64 tongtiensaugiam = tongtientruocgiam - Xuly.Xuly.TinhTienGiamGia(tongtientruocgiam, giamgia);
        //        dgvDSPhieu["TongTienDaGiam", i].Value = tongtiensaugiam;
        //        if (!Convert.ToBoolean(dgvDSPhieu["DaThanhToan", i].Value))
        //        {
        //            for (int k = 0; k < dgvDSPhieu.ColumnCount; k++)
        //            {
        //                dgvDSPhieu[k, i].Style.ForeColor = System.Drawing.Color.Red;
        //            }
        //        }
        //    }
        //}

        private void chkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            chkTimChuaTraDo.Enabled = !chkTatCa.Checked;
            txtMaPhieu.Enabled = !chkTatCa.Checked;
            txtSoDienThoai.Enabled = !chkTatCa.Checked;
            txtTenKhachHang.Enabled = !chkTatCa.Checked;
            chkTimTheoNgay.Checked = false;
            chkTimTheoNgay.Enabled = !chkTatCa.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            this.LoadData();
            if (dgvDSPhieu.RowCount == 1) btnCatDo.Focus();
            else if (dgvDSPhieu.RowCount > 0) dgvDSPhieu.Focus();
            btnSearch.Enabled = true;
        }

        //private void btnCollapse_Click(object sender, EventArgs e)
        //{
        //    splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        //    btnCollapse.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLapPhieu frm = new frmLapPhieu();
            frm.onsaved = new OnSaved(this.LoadData);
            frm.ShowDialog();
        }

        private void LapPhieuCoMaKhachHang(long makh)
        {
            frmLapPhieu frm = new frmLapPhieu();
            frm.onsaved = new OnSaved(this.LoadData);
            KhachHangEntity kh = KhachHangBO.SelectByMaKhachHang(makh);
            frm._khachhang = kh;
            if (kh != null)
            {
                frm.LoadDataKhachHang();
            }
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = dgvDSPhieu.SelectedRows;
                if (selectedRows.Count != 0)
                {
                    Entity.PhieuEntity phieu = new Entity.PhieuEntity()
                    {
                        MaPhieu = (Int64)selectedRows[0].Cells["MaPhieu"].Value,
                        MaKhachHang = (Int64)selectedRows[0].Cells["MaKhachHang"].Value,
                        TenKhachHang = selectedRows[0].Cells["TenKhachHang"].Value.ToString(),
                        NgayLap = (DateTime)selectedRows[0].Cells["NgayLap"].Value,
                        NgayHenTra = (DateTime)selectedRows[0].Cells["NgayHenTra"].Value,
                        DaThanhToan = (Boolean)selectedRows[0].Cells["DaThanhToan"].Value,
                        UserName = selectedRows[0].Cells["UserName"].Value.ToString(),
                        PhiGiaoNhan = (Int32)selectedRows[0].Cells["PhiGiaoNhan"].Value
                    };
                    frmLapPhieu frm = new frmLapPhieu();
                    frm._phieu = phieu;
                    frm.onsaved = new OnSaved(this.LoadData);
                    frm.ShowDialog();

                }
                else
                    MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvDSPhieu.SelectedRows;
            if (selectedRows.Count != 0)
            {
                if (BienChung.userCurrent.ChucVu != ChucVu.Admin)
                {
                    MessageBox.Show("Bạn không đủ quyền để xóa phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < selectedRows.Count; i++)
                {
                    Int64 maphieu = (Int64)selectedRows[i].Cells["MaPhieu"].Value;
                    if (MessageBox.Show("Bạn có chắc chắn xóa phiếu '" + maphieu + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    Boolean dathanhtoan = Convert.ToBoolean(selectedRows[0].Cells["DaThanhToan"].Value);
                    Boolean datrado = Convert.ToBoolean(selectedRows[0].Cells["DaTraDo"].Value);
                    try
                    {
                        Business.PhieuBO.Delete(maphieu,
                                                dathanhtoan,
                                                datrado);
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được phiếu, bạn hãy kiểm tra lại!\nPhiếu phải được trả hết đồ và đã thanh toán thì mới xóa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                //if (BienChung.userCurrent.ChucVu != ChucVu.Admin)
                //{
                //    MessageBox.Show("Bạn không đủ quyền để hủy phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                DataGridViewSelectedRowCollection selectedRows = dgvDSPhieu.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Int64 maphieu = (Int64)selectedRows[0].Cells["MaPhieu"].Value;
                Int64 tongtien = (Int64)selectedRows[0].Cells["TongTien"].Value;
                Boolean datra = (Boolean)selectedRows[0].Cells["DaTraDo"].Value;
                if (datra)
                {
                    MessageBox.Show("Phiếu '" + maphieu + "' đã trả.\nBạn hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Int64 maphieumax = PhieuBO.SelectMaxMaPhieu();
                //if (maphieu < maphieumax)
                //{
                //    MessageBox.Show("Bạn chỉ có thể hủy phiếu cuối cùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                ListPhieuSlotEntity lstPhieuSlot = PhieuSlotBO.SelectByMaPhieu(maphieu);
                bool chuatontaipsnaobisua = true;
                foreach (PhieuSlotEntity pslot in lstPhieuSlot)
                {
                    if (!string.IsNullOrEmpty(pslot.Kho) ||
                        pslot.Slot != 0 ||
                        pslot.DaTra)
                    {
                        chuatontaipsnaobisua = false;
                        break;
                    }
                }
                if (!chuatontaipsnaobisua)
                {
                    MessageBox.Show("Đã tồn tại một đồ của phiếu '" + maphieu + "' đã được cất vào kho hoặc đã trả.\nBạn hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn hủy phiếu '" + maphieu + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //--------------------------------
                // xóa kho slot của phiếu đấy
                PhieuSlotBO.DeleteByMaPhieu(maphieu);
                // cập nhật phiếu là bị hủy
                PhieuBO.UpdateDaHuyPhieu(maphieu);
                // cập nhật phiếu là đã trả đồ
                PhieuBO.UpdateDaTraDo(maphieu);
                // cập nhật lại mã vạch nếu dùng mã vạch và đúng mã vạch của máy này
                if (lstPhieuSlot.Count > 0)
                {
                    Int64 mavachmaxhientai = Xuly.ThaoTacIniMaVach.Read();
                    if (lstPhieuSlot[lstPhieuSlot.Count - 1].MaVach == mavachmaxhientai)
                    {
                        mavachmaxhientai = lstPhieuSlot[0].MaVach - 1;
                        Xuly.ThaoTacIniMaVach.Write(mavachmaxhientai);
                    }
                }
                // hết
                LoadData();
                MessageBox.Show("Hủy phiếu '" + maphieu + "' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvDSPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void dgvDSPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dgvDSPhieu_CellDoubleClick(sender, null);
        }

        private void btnCatDo_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvDSPhieu.SelectedRows;
            if (selectedRows.Count != 0)
            {
                Entity.PhieuEntity phieu = new Entity.PhieuEntity()
                {
                    MaPhieu = (Int64)selectedRows[0].Cells["MaPhieu"].Value,
                    MaKhachHang = (Int64)selectedRows[0].Cells["MaKhachHang"].Value,
                    TenKhachHang = selectedRows[0].Cells["TenKhachHang"].Value.ToString(),
                    NgayLap = (DateTime)selectedRows[0].Cells["NgayLap"].Value,
                    NgayHenTra = (DateTime)selectedRows[0].Cells["NgayHenTra"].Value,
                    DaThanhToan = (Boolean)selectedRows[0].Cells["DaThanhToan"].Value,
                    DaTraDo = (Boolean)selectedRows[0].Cells["DaTraDo"].Value,
                    GhiChu = selectedRows[0].Cells["GhiChu"].Value.ToString()
                };
                if (!phieu.DaTraDo)
                {
                    frmTraDo frm = new frmTraDo(phieu.MaPhieu, this, phieu.DaThanhToan);
                    frm.OnTraDoRoiLapPhieu = new TraDoRoiLapPhieu(LapPhieuCoMaKhachHang);
                    frm.ShowDialog(this);
                }
                else
                    MessageBox.Show("Phiếu '" + phieu.MaPhieu + "' đã trả đồ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void chkTimTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            lblTuNgay.Visible = chkTimTheoNgay.Checked;
            lblDenNgay.Visible = chkTimTheoNgay.Checked;
            dtpTuNgay.Visible = chkTimTheoNgay.Checked;
            dtpDenNgay.Visible = chkTimTheoNgay.Checked;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mnuHuyPhieu.Enabled = !(dgvDSPhieu.RowCount == 0);
            mnuSuaPhieu.Enabled = !(dgvDSPhieu.RowCount == 0);
            mnuCatDo.Enabled = !(dgvDSPhieu.RowCount == 0);
            mnuXemTTKhachHang.Enabled = dgvDSPhieu.RowCount > 0;
        }

        private void mnuCatDo_Click(object sender, EventArgs e)
        {
            btnCatDo_Click(sender, e);
        }

        private void mnuLapPhieu_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        private void mnuSuaPhieu_Click(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void mnuHuyPhieu_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        private void mnuXemTTKhachHang_Click(object sender, EventArgs e)
        {
            btnXemTTKhachHang_Click(sender, e);
        }

        private void btnXemTTKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSPhieu.RowCount > 0)
                {
                    DataGridViewSelectedRowCollection selectedRows = dgvDSPhieu.SelectedRows;
                    if (selectedRows.Count != 0 && !string.IsNullOrEmpty(selectedRows[0].Cells["MaKhachHang"].Value.ToString()))
                    {
                        Int64 MaKhachHang = (Int64)selectedRows[0].Cells["MaKhachHang"].Value;
                        KhachHangEntity kh = KhachHangBO.SelectByMaKhachHang(MaKhachHang);
                        lblMessage.Text = kh == null ? "empty" : kh.DienThoai;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

