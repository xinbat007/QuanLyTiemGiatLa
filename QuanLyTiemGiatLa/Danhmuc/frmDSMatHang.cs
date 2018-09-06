using System;
using System.Windows.Forms;
using System.IO;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmDSMatHang : Form
	{
		public frmDSMatHang()
		{
			InitializeComponent();			
			this.Load += new EventHandler(frmDSMatHang_Load);
		}

		private void frmDSMatHang_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void LoadData()
		{
			//try
			//{
			//    this.ptbImage = new PictureBox();
			//    ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
			//    this.ptbImage.Location = new System.Drawing.Point(341, 12);
			//    this.ptbImage.Name = "ptbImage";
			//    this.ptbImage.Size = new System.Drawing.Size(92, 92);
			//    this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			//    this.ptbImage.TabIndex = 3;
			//    this.ptbImage.TabStop = false;
			//    ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
			//}
			//catch { }
			bndsrcDSLoaiHang.DataSource = Business.LoaiHangBO.SelectAll();
			bndsrcDSMatHang.DataSource = Business.MatHangBO.SelectAll();

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmCTMatHang frm = new frmCTMatHang();
			frm.onsaved = new OnSaved(LoadData);
			frm.Show();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Entity.MatHangEntity mathang = bndsrcDSMatHang.Current as Entity.MatHangEntity;
			if (mathang != null)
			{
				frmCTMatHang frm = new frmCTMatHang();
				frm.MatHang = mathang;
				frm.onsaved = new OnSaved(LoadData);				
				frm.Show();
			}
			else
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Entity.MatHangEntity mathang = bndsrcDSMatHang.Current as Entity.MatHangEntity;
			if (mathang != null)
			{
				if (MessageBox.Show("Bạn có chắc chắn xóa mặt hàng '" + mathang.TenHang + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Business.MatHangBO.Delete(mathang.MaHang);
						try
						{
							Business.MatHangBO.XoaAnh(mathang.ImageStringFile);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Không xóa được ảnh vì: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);							
						}
						this.LoadData();
					}
					catch
					{
						MessageBox.Show("Không xóa được mặt hàng '" + mathang.TenHang + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}					
				}
			}
			else
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void dgvDSMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua_Click(sender, e);
		}

		private void bndsrcDSMatHang_CurrentChanged(object sender, EventArgs e)
		{
			Entity.MatHangEntity mathang = bndsrcDSMatHang.Current as Entity.MatHangEntity;
			if (mathang != null)
			{
				try
				{
					if (System.IO.File.Exists(mathang.ImageStringFile))
					{
						FileStream fs = new FileStream(mathang.ImageStringFile, FileMode.Open);
						System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
						ptbImage.Image = img;
						fs.Close();
					}
					else ptbImage.Image = System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath);
				}
				catch { }
			}
			else
			{
				try { ptbImage.Image = System.Drawing.Image.FromFile(Business.MatHangBO.defaultImagePath); }
				catch { }
			}
		}
	}
}
