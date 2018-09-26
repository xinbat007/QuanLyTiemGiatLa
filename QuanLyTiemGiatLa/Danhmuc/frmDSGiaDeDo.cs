using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmDSGiaDeDo : Form
    {
        public frmDSGiaDeDo()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmDSGiaDeDo_Load);
            this.LoadData();
        }

        private void frmDSGiaDeDo_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            bndsrcDSKho.DataSource = Business.KhoBO.SelectAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmCTGiaDeDo frm = new frmCTGiaDeDo();
            frm.onsaved = new OnSaved(LoadData);
            frm.ShowDialog(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Entity.KhoEntity kho = bndsrcDSKho.Current as Entity.KhoEntity;
            if (kho != null)
            {
                frmCTGiaDeDo frm = new frmCTGiaDeDo();
                frm.onsaved = new OnSaved(this.LoadData);
                frm.Kho = kho;
                frm.ShowDialog(this);
            }
            else
                MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Entity.KhoEntity kho = bndsrcDSKho.Current as Entity.KhoEntity;
            if (kho != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa kho '" + kho.TenKho + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Business.KhoBO.Delete(kho.MaKho);
                        this.LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được kho '" + kho.TenKho + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSGiaDeDo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);
        }
    }
}
