using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using QuanLyTiemGiatLa.Xuly;

namespace QuanLyTiemGiatLa.HeThong
{
    public partial class frmCauHinhGhiChu : Form
    {
        private List<string> _dsGhiChu;
        private string _fileName;

        public frmCauHinhGhiChu(List<string> listghichu, string fileName)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(frmCauHinhGhiChu_Load);
            _dsGhiChu = listghichu;
            _fileName = fileName;
            dgvGhiChu.AutoGenerateColumns = false;
        }

        private void frmCauHinhGhiChu_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < _dsGhiChu.Count; i++)
            {
                dgvGhiChu.Rows.Add(_dsGhiChu[i]);
            }
            txtKCGhiChu.Text = ThaoTacIniCauHinhGhiChu.ReadKCGhiChu().ToString();
            txtChieuNgangForm.Text = ThaoTacIniCauHinhGhiChu.ReadChieuNgangForm().ToString();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, System.EventArgs e)
        {
            using (StreamWriter outfile = new StreamWriter(_fileName, false, System.Text.Encoding.Unicode))
            {
                for (int i = 0; i < dgvGhiChu.Rows.Count - 1; i++)
                {
                    string s = dgvGhiChu[0, i].Value.ToString().Trim();
                    if (string.IsNullOrEmpty(s)) break;
                    outfile.WriteLine(s);
                }
                outfile.Close();
            }
            int kcghichu, chieungangform;
            int.TryParse(txtKCGhiChu.Text, out kcghichu);
            int.TryParse(txtChieuNgangForm.Text, out chieungangform);
            ThaoTacIniCauHinhGhiChu.Write(kcghichu, chieungangform);
        }
    }
}
