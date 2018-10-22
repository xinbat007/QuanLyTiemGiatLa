using System;
using System.Windows.Forms;
using Entity;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmDSChotKet : Form
    {
        private bool _daLoadXongForm = false;
        public frmDSChotKet()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmDSChotKet_Load);
        }

        private void frmDSChotKet_Load(object sender, EventArgs e)
        {
            Xuly.Xuly.ToanManHinh(this);
            _daLoadXongForm = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                bndsrcDSChotKet.DataSource = null;
                bndsrcDSChotKet.DataSource = Business.ChotKetBO.Select(chkTatca.Checked, dtpTuNgay.Value, dtpDenNgay.Value);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChotKet_Click(object sender, EventArgs e)
        {
            frmCTChotKet frm = new frmCTChotKet();
            frm.onsaved = new OnSaved(LoadData);
            frm.ShowDialog(this);
        }

        private void bndsrcDSChotKet_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (!_daLoadXongForm) return;
                ChotKetEntity chotket = bndsrcDSChotKet.Current as ChotKetEntity;
                if (chotket != null)
                {
                    dgvDSPhieu.AutoGenerateColumns = false;
                    ListPhieuEntity listPhieu = Business.PhieuBO.SelectByTuPhieuDenPhieu(chotket.TuPhieu, chotket.DenPhieu);
                    dgvDSPhieu.DataSource = listPhieu;
                    VeDataGrid(listPhieu);
                }
                else
                {
                    dgvDSPhieu.DataSource = null;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            for (int k = 0; k < dgvDSPhieu.ColumnCount; k++)
                            {
                                dgvDSPhieu.Rows[i].Cells[k].Style.ForeColor = BienChung.mautrangthaido.PhieuHuy;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                        UserName = selectedRows[0].Cells["UserName"].Value.ToString()
                    };
                    frmLapPhieu frm = new frmLapPhieu();
                    frm._phieu = phieu;
                    //frm.onsaved = new OnSaved(this.LoadData);
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

        private void chkTatca_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtpTuNgay.Enabled = !chkTatca.Checked;
                dtpDenNgay.Enabled = !chkTatca.Checked;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
