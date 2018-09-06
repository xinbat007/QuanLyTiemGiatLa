using System.Windows.Forms;
using Entity;
using System;
using System.IO;

namespace QuanLyTiemGiatLa.Danhmuc
{
    public partial class frmLayDoNhanh : Form
    {
        private Entity.ListLoaiHangEntity listLoaiHang = null;
        private Entity.ListMatHangEntity listMatHang = null;
        private Entity.ListBangGiaEntity listBangGia = null;
        private Entity.BangGiaEntity banggiatrave = null;

        public frmLayDoNhanh()
        {
            InitializeComponent();
            listLoaiHang = Business.LoaiHangBO.SelectAll();
            listMatHang = Business.MatHangBO.SelectAll();
            listBangGia = Business.BangGiaBO.SelectAll();
            InitImageList();
            InitButtonLoaiHang(listLoaiHang);
            this.Load += new System.EventHandler(frmLayDoNhanh_Load);
        }

        private void frmLayDoNhanh_Load(object sender, System.EventArgs e)
        {
            // đừng làm gì ở đây
            txtLoc.TabIndex = 0;
            txtLoc.Focus();
        }

        public Entity.BangGiaEntity ShowForm()
        {
            this.ShowDialog();
            if (DialogResult == DialogResult.OK)
                return banggiatrave;
            else
                return null;
        }

        private void InitImageList()
        {
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlMatHang.SuspendLayout();
            this.SuspendLayout();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayDoNhanh));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(32, 32);
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.Clear();
            for (int i = 0; i < listMatHang.Count; i++)
            {
                if (File.Exists(listMatHang[i].ImageStringFile))
                    this.imgList.Images.Add(System.Drawing.Image.FromFile(listMatHang[i].ImageStringFile));
                else
                    try { this.imgList.Images.Add(System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath)); }
                    catch { }
            }

            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlMatHang.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void InitButtonLoaiHang(ListLoaiHangEntity listLoaiHang)
        {
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            int chieucaopanel = this.splitContainer1.Panel1.Height;
            int chieucao1button = 40;// chieucaopanel / listLoaiHang.Count;
            Button[] btn = new Button[listLoaiHang.Count];
            for (int i = 0; i < listLoaiHang.Count; i++)
            {
                btn[i] = new Button();
                btn[i].Location = new System.Drawing.Point(10, chieucao1button * i);
                btn[i].Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                btn[i].Name = "btnLoaiHang" + listLoaiHang[i].MaLoaiHang;
                btn[i].Size = new System.Drawing.Size(110, 35);
                btn[i].TabIndex = i;
                btn[i].Text = listLoaiHang[i].TenLoaiHang;
                btn[i].UseVisualStyleBackColor = true;
                btn[i].Click += new System.EventHandler(btnLoaiHang_Click);
                this.splitContainer1.Panel1.Controls.Add(btn[i]);
            }
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            if (btn.Length > 0) btnLoaiHang_Click(btn[0], null);
        }

        private void btnLoaiHang_Click(object sender, System.EventArgs e)
        {
            _maloaihang = Int32.Parse(((Button)sender).Name.Remove(0, 11));//xóa chữ btnLoaiHang
            LoadMatHangToListView(_maloaihang, "");
            txtLoc.Focus();
            Application.DoEvents();
            txtLoc.TabIndex = 0;
        }

        private void LoadMatHangToListView(int idLoaiHang, String contain)
        {
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlMatHang.SuspendLayout();
            this.pnlKieuGiat.SuspendLayout();
            this.SuspendLayout();

            this.pnlKieuGiat.Controls.Clear();
            lsvMatHang.BeginUpdate();
            lsvMatHang.Items.Clear();
            lsvMatHang.LargeImageList = imgList;
            lsvMatHang.Scrollable = true;
            for (int i = 0; i < listMatHang.Count; i++)
            {
                if (listMatHang[i].MaLoaiHang == idLoaiHang &&
                        (listMatHang[i].TenHang.ToLower().Contains(contain.ToLower()) ||
                        Xuly.Xuly.RemoveSign4VietnameseString(listMatHang[i].TenHang).ToLower().Contains(contain.ToLower())
                    ))
                {
                    ListViewItem listItem = new ListViewItem(listMatHang[i].TenHang.ToString());
                    listItem.ImageIndex = 0;
                    listItem.Name = "lsvItem" + listMatHang[i].MaHang.ToString();
                    listItem.ImageIndex = i;
                    lsvMatHang.Items.Add(listItem);
                }
            }
            lsvMatHang.SelectedIndexChanged += new EventHandler(lsvMatHang_Click);
            lsvMatHang.EndUpdate();

            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlMatHang.ResumeLayout(false);
            this.pnlMatHang.PerformLayout();
            this.pnlKieuGiat.ResumeLayout(false);
            this.pnlKieuGiat.PerformLayout();
            this.ResumeLayout(false);
        }

        private void lsvMatHang_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection selected = lsvMatHang.SelectedItems;
            if (selected.Count != 0)
            {
                int mahang = Int32.Parse(selected[0].Name.Remove(0, 7));
                LoadBangGia(mahang, selected[0].Text);
            }
            else
            {
                pnlKieuGiat.Controls.Clear();
            }
        }

        private void LoadBangGia(int mahang, string tenhang)
        {
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlKieuGiat.SuspendLayout();
            this.SuspendLayout();

            this.pnlKieuGiat.Controls.Clear();
            Label lblMsg = new Label();
            lblMsg.AutoSize = true;
            lblMsg.Location = new System.Drawing.Point(10, 20);
            lblMsg.Name = "lblMatHang";
            lblMsg.Size = new System.Drawing.Size(0, 0);
            lblMsg.TabIndex = 40;
            lblMsg.Text = tenhang;
            this.pnlKieuGiat.Controls.Add(lblMsg);
            int vitribatdau = 30;   // cách lblMessage 1 khoảng
            int chieudaidcphepve = pnlKieuGiat.Height - vitribatdau;
            int chieucao1button = 80;
            int k = 0;
            for (int i = 0; i < listBangGia.Count; i++)
            {
                if (listBangGia[i].MaHang == mahang)
                {
                    int top = chieucao1button * k + vitribatdau + 30;
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(10, top);
                    btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    btn.Name = "btnKieuGiat," + listBangGia[i].MaHang + "," + listBangGia[i].MaKieuGiat;
                    btn.Size = new System.Drawing.Size(110, 50);
                    btn.TabIndex = 10 + k;
                    btn.Text = listBangGia[i].TenKieuGiat
                                    + (listBangGia[i].SoSanPham > 1 ?
                                    String.Format(" ({0})", listBangGia[i].SoSanPham) : "")
                                    + "\n" + String.Format("{0:0,0}", listBangGia[i].DonGia);
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(btnBangGia_Click);
                    this.pnlKieuGiat.Controls.Add(btn);
                    k += 1;
                }
            }

            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlKieuGiat.ResumeLayout(false);
            this.pnlKieuGiat.PerformLayout();
            this.ResumeLayout(false);
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            Button btnBangGia = (Button)sender;
            String[] mang = btnBangGia.Name.Split(',');
            int mahang = Int32.Parse(mang[1]);
            int makieugiat = Int32.Parse(mang[2]);
            for (int i = 0; i < listBangGia.Count; i++)
            {
                if (listBangGia[i].MaHang == mahang && listBangGia[i].MaKieuGiat == makieugiat)
                {
                    banggiatrave = listBangGia[i];
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {
            LoadMatHangToListView(_maloaihang, txtLoc.Text);
        }

        private int _maloaihang;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
