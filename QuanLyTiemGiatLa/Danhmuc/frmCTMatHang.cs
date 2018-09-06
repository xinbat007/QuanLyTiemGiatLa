using System;
using System.Windows.Forms;
using System.IO;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmCTMatHang : Form
    {
        public OnSaved onsaved;
        private TrangThai TrangThai;

        private String imgPath = String.Empty;

        public frmCTMatHang()
        {
            InitializeComponent();
            bndsrcDSLoaiHang.DataSource = Business.LoaiHangBO.SelectAll();
            this.Load += new EventHandler(frmCTMatHang_Load);
        }

        private void frmCTMatHang_Load(object sender, EventArgs e)
        {
            TrangThai = this.MatHang == null ? TrangThai.Them : TrangThai.Sua;
            if (TrangThai == TrangThai.Them)
            {
                try
                {
                    ptbImage.Image = System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath);
                }
                catch { }
            }
            else
            {
                Entity.MatHangEntity mathang = bndsrcMatHang.DataSource as Entity.MatHangEntity;
                if (mathang != null && !String.IsNullOrEmpty(mathang.ImageStringFile))
                {
                    imgPath = mathang.ImageStringFile;
                    try
                    {
                        if (File.Exists(mathang.ImageStringFile))
                        {
                            FileStream fs = new FileStream(mathang.ImageStringFile, FileMode.Open);
                            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                            ptbImage.Image = img;
                            fs.Close();
                        }
                        else
                            ptbImage.Image = System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath);
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        ptbImage.Image = System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath);
                    }
                    catch { }
                }
            }
        }

        public Entity.MatHangEntity MatHang
        {
            set
            {
                bndsrcMatHang.DataSource = value;
            }
            get
            {
                return bndsrcMatHang.DataSource as Entity.MatHangEntity;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean CheckForm()
        {
            txtTenHang.Text = txtTenHang.Text.Trim();
            if (String.IsNullOrEmpty(txtTenHang.Text))
            {
                txtTenHang.Focus();
                MessageBox.Show("Tên hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(cboLoaiHang.Text))
            {
                cboLoaiHang.Focus();
                MessageBox.Show("Bạn chưa chọn loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!this.CheckForm()) return;
            Entity.MatHangEntity mh = new Entity.MatHangEntity()
            {
                TenHang = txtTenHang.Text,
                MaLoaiHang = (Int32)cboLoaiHang.SelectedValue
            };
            if (TrangThai == TrangThai.Them)
            {
                mh.MaHang = Business.MatHangBO.Insert(mh);
                if (!String.IsNullOrEmpty(imgPath))
                {
                    // 1. copy ảnh vào thư mục
                    try
                    {
                        imgPath = Business.MatHangBO.CopyAnhVaoThuMuc(mh.MaHang, imgPath);
                        mh.ImageStringFile = imgPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không copy được ảnh vì: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // 2. update vào csdl
                    if (!String.IsNullOrEmpty(mh.ImageStringFile))
                    {
                        Business.MatHangBO.Update(mh);
                    }
                }
                onsaved();
                this.Close();
            }
            else
            {
                mh.MaHang = (bndsrcMatHang.DataSource as Entity.MatHangEntity).MaHang;
                mh.ImageStringFile = (bndsrcMatHang.DataSource as Entity.MatHangEntity).ImageStringFile;
                try
                {
                    if (mh.ImageStringFile != imgPath)  // có sửa ảnh
                    {
                        // 1. ko cần xóa vì copy kiểu overwrite// Business.MatHangBO.XoaAnh(mh.MaHang, mh.ImageStringFile);
                        // 2. copy ảnh vào thư mục
                        imgPath = Business.MatHangBO.CopyAnhVaoThuMuc(mh.MaHang, imgPath);
                        mh.ImageStringFile = imgPath;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được ảnh vì: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Int32 kq = Business.MatHangBO.Update(mh);
                onsaved();
                this.Close();
            }
        }

        private void txtTenHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) cboLoaiHang.Focus();
        }

        private void cboLoaiHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGhi.Focus();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file (*.jpg)|*.jpg|" +
                            //*.jpeg|
                            //*.jpe|
                            //*.tif|
                            "Png (*.png)|*.png|" +
                            "Gif (*.gif)|*.gif|" +
                            "Bitmap (*.bmp)|*.bmp|" +
                            "Icon (*.ico)|*.ico|" +
                            "All file (*.*)|*.*";
            open.FilterIndex = 6;
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgPath = open.FileName;
                    ptbImage.Image = System.Drawing.Image.FromFile(imgPath);
                }
                catch (Exception)
                {
                    imgPath = String.Empty;
                    MessageBox.Show("Không hỗ trợ định dạng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
