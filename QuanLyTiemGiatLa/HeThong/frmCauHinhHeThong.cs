using System.Windows.Forms;
using System;
using System.Drawing;

namespace QuanLyTiemGiatLa.HeThong
{
    public partial class frmCauHinhHeThong : Form
    {
        public frmCauHinhHeThong()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(frmCauHinhHeThong_Load);
        }

        private void frmCauHinhHeThong_Load(object sender, System.EventArgs e)
        {
            try
            {
                nudTreEmGiamGia.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadTreEmGiamGia();
                nudGiatNhanhTangGia.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadGiatNhanhTangGia();
                nudPhiVanChuyen.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadPhiVanChuyen();
                nudNgayLapTra.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadNgayLapNgayHenTra();
                nudViecCanLam.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadViecCanLam();
                cboCatDoFocus.SelectedIndex = Xuly.ThaoTacIniCauHinhPhanMem.ReadCatdoFocus();
                nudSoLanIn.Value = Xuly.ThaoTacIniCauHinhPhanMem.ReadSoLanIn();
                chkDungMaVach.Checked = Xuly.ThaoTacIniCauHinhPhanMem.ReadDungMaVach();
                chkToanManHinh.Checked = BienChung.isToanManHinh;
                txtTenCuaHang.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadTenCuaHang();
                txtDiaChi.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadDiaChiCuaHang();
                txtDienThoaiCuaHang.Text = Xuly.ThaoTacIniCauHinhPhanMem.ReadSoDienThoai();
                txtMaVach.Text = (Xuly.ThaoTacIniMaVach.Read() + 1).ToString();
                txtXoayVongTu.Text = Xuly.ThaoTacIniMaVach.ReadMaVachBatDau().ToString();
                txtXoayVongDen.Text = Xuly.ThaoTacIniMaVach.ReadMaVachKetThuc().ToString();
                BienChung.mautrangthaido = Xuly.ThaoTacIniCauHinhPhanMem.ReadMauTrangThaiDo();
                this.DoiMauButton();
                if (BienChung.isTrienKhai)
                    btnBackUp.Enabled = (BienChung.userCurrent != null) ? (BienChung.userCurrent.ChucVu == Entity.ChucVu.Admin) : false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoiMauButton()
        {
            btnMauDoChuaGiat.BackColor = BienChung.mautrangthaido.ChuaGiat;
            btnMauDoDaGiat.BackColor = BienChung.mautrangthaido.DaGiat;
            btnMauDoGhiChu.BackColor = BienChung.mautrangthaido.GhiChu;
            btnMauDoDaTra.BackColor = BienChung.mautrangthaido.DaTra;
            btnMauDoPhieuHuy.BackColor = BienChung.mautrangthaido.PhieuHuy;
        }

        private bool CheckForm()
        {
            txtMaVach.Text = txtMaVach.Text.Trim();
            long mavach;
            if (!Int64.TryParse(txtMaVach.Text, out mavach))
            {
                MessageBox.Show("Mã vạch phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVach.Focus();
                return false;
            }
            long mavachbd, mavachkt;
            mavachbd = Int64.Parse(txtXoayVongTu.Text);
            mavachkt = Int64.Parse(txtXoayVongDen.Text);
            if (mavachbd > mavachkt)
            {
                MessageBox.Show("Mã vạch bắt đầu phải nhỏ hơn mã vạch kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXoayVongTu.Focus();
                return false;
            }
            if (mavachbd != mavachkt && !(mavachbd <= mavach && mavach <= mavachkt))
            {
                MessageBox.Show("Mã vạch phải nằm trong khoảng bắt đầu đến kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGhi_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!this.CheckForm()) return;
                Xuly.ThaoTacIniCauHinhPhanMem.Write(Convert.ToInt32(nudTreEmGiamGia.Value),
                                                    Convert.ToInt32(nudGiatNhanhTangGia.Value),
                                                    Convert.ToInt32(nudPhiVanChuyen.Value),
                                                    Convert.ToInt32(nudNgayLapTra.Value),
                                                    Convert.ToInt32(nudViecCanLam.Value),
                                                    cboCatDoFocus.SelectedIndex,
                                                    Convert.ToInt32(nudSoLanIn.Value),
                                                    txtTenCuaHang.Text,
                                                    txtDiaChi.Text,
                                                    txtDienThoaiCuaHang.Text,
                                                    BienChung.mautrangthaido,
                                                    chkDungMaVach.Checked,
                                                    chkToanManHinh.Checked
                                                    );
                Xuly.ThaoTacIniMaVach.Write(Int64.Parse(txtMaVach.Text) - 1);
                Xuly.ThaoTacIniMaVach.Write(Int64.Parse(txtXoayVongTu.Text), Int64.Parse(txtXoayVongDen.Text));
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                frmBackUpDuLieu frm = new frmBackUpDuLieu();
                frm.ShowDialog(this);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMauDoChuaGiat_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;   // allow custom colors
            cd.FullOpen = true;   // shows custom colors automatically
            cd.Color = BienChung.mautrangthaido.ChuaGiat;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnMauDoChuaGiat.BackColor = cd.Color;
                BienChung.mautrangthaido.ChuaGiat = cd.Color;
            }
        }

        private void btnMauDoDaGiat_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;   // allow custom colors
            cd.FullOpen = true;   // shows custom colors automatically
            cd.Color = BienChung.mautrangthaido.DaGiat;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnMauDoDaGiat.BackColor = cd.Color;
                BienChung.mautrangthaido.DaGiat = cd.Color;
            }
        }

        private void btnMauDoGhiChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;   // allow custom colors
            cd.FullOpen = true;   // shows custom colors automatically
            cd.Color = BienChung.mautrangthaido.GhiChu;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnMauDoGhiChu.BackColor = cd.Color;
                BienChung.mautrangthaido.GhiChu = cd.Color;
            }
        }

        private void btnMauDoDaTra_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;   // allow custom colors
            cd.FullOpen = true;   // shows custom colors automatically
            cd.Color = BienChung.mautrangthaido.DaTra;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnMauDoDaTra.BackColor = cd.Color;
                BienChung.mautrangthaido.DaTra = cd.Color;
            }
        }

        private void btnMauDoPhieuHuy_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;   // allow custom colors
            cd.FullOpen = true;   // shows custom colors automatically
            cd.Color = BienChung.mautrangthaido.PhieuHuy;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnMauDoPhieuHuy.BackColor = cd.Color;
                BienChung.mautrangthaido.PhieuHuy = cd.Color;
            }
        }
    }
}
