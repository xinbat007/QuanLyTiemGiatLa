namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTPhieu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieu));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnlGhiChu = new System.Windows.Forms.Panel();
			this.chkGiatNhanh = new System.Windows.Forms.CheckBox();
			this.chkTreEm = new System.Windows.Forms.CheckBox();
			this.txtKieuGiat = new System.Windows.Forms.TextBox();
			this.txtTenHang = new System.Windows.Forms.TextBox();
			this.btnLayDoNhanh = new System.Windows.Forms.Button();
			this.txtThanhTien = new System.Windows.Forms.TextBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.bndsrcCTPhieu = new System.Windows.Forms.BindingSource(this.components);
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCauHinhGhiChu = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcCTPhieu)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.pnlGhiChu);
			this.groupBox1.Controls.Add(this.chkGiatNhanh);
			this.groupBox1.Controls.Add(this.chkTreEm);
			this.groupBox1.Controls.Add(this.txtKieuGiat);
			this.groupBox1.Controls.Add(this.txtTenHang);
			this.groupBox1.Controls.Add(this.btnLayDoNhanh);
			this.groupBox1.Controls.Add(this.txtThanhTien);
			this.groupBox1.Controls.Add(this.txtDonGia);
			this.groupBox1.Controls.Add(this.txtGhiChu);
			this.groupBox1.Controls.Add(this.txtSoLuong);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, -1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 214);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// pnlGhiChu
			// 
			this.pnlGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlGhiChu.AutoSize = true;
			this.pnlGhiChu.Location = new System.Drawing.Point(368, 12);
			this.pnlGhiChu.Name = "pnlGhiChu";
			this.pnlGhiChu.Size = new System.Drawing.Size(226, 199);
			this.pnlGhiChu.TabIndex = 9;
			// 
			// chkGiatNhanh
			// 
			this.chkGiatNhanh.AutoSize = true;
			this.chkGiatNhanh.Location = new System.Drawing.Point(255, 84);
			this.chkGiatNhanh.Name = "chkGiatNhanh";
			this.chkGiatNhanh.Size = new System.Drawing.Size(107, 24);
			this.chkGiatNhanh.TabIndex = 5;
			this.chkGiatNhanh.Text = "Giặt nhanh";
			this.chkGiatNhanh.UseVisualStyleBackColor = true;
			this.chkGiatNhanh.CheckedChanged += new System.EventHandler(this.chkGiatNhanh_CheckedChanged);
			this.chkGiatNhanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkGiatNhanh_KeyDown);
			// 
			// chkTreEm
			// 
			this.chkTreEm.AutoSize = true;
			this.chkTreEm.Location = new System.Drawing.Point(172, 84);
			this.chkTreEm.Name = "chkTreEm";
			this.chkTreEm.Size = new System.Drawing.Size(77, 24);
			this.chkTreEm.TabIndex = 4;
			this.chkTreEm.Text = "Trẻ em";
			this.chkTreEm.UseVisualStyleBackColor = true;
			this.chkTreEm.CheckedChanged += new System.EventHandler(this.chkTreEm_CheckedChanged);
			this.chkTreEm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTreEm_KeyDown);
			// 
			// txtKieuGiat
			// 
			this.txtKieuGiat.Enabled = false;
			this.txtKieuGiat.Location = new System.Drawing.Point(94, 49);
			this.txtKieuGiat.Name = "txtKieuGiat";
			this.txtKieuGiat.Size = new System.Drawing.Size(179, 26);
			this.txtKieuGiat.TabIndex = 1;
			// 
			// txtTenHang
			// 
			this.txtTenHang.Enabled = false;
			this.txtTenHang.Location = new System.Drawing.Point(94, 17);
			this.txtTenHang.Name = "txtTenHang";
			this.txtTenHang.Size = new System.Drawing.Size(179, 26);
			this.txtTenHang.TabIndex = 0;
			// 
			// btnLayDoNhanh
			// 
			this.btnLayDoNhanh.Location = new System.Drawing.Point(279, 12);
			this.btnLayDoNhanh.Name = "btnLayDoNhanh";
			this.btnLayDoNhanh.Size = new System.Drawing.Size(83, 64);
			this.btnLayDoNhanh.TabIndex = 2;
			this.btnLayDoNhanh.Text = "Chọn đồ nhanh";
			this.btnLayDoNhanh.UseVisualStyleBackColor = true;
			this.btnLayDoNhanh.Click += new System.EventHandler(this.btnLayDoNhanh_Click);
			// 
			// txtThanhTien
			// 
			this.txtThanhTien.Enabled = false;
			this.txtThanhTien.Location = new System.Drawing.Point(96, 178);
			this.txtThanhTien.Name = "txtThanhTien";
			this.txtThanhTien.Size = new System.Drawing.Size(266, 26);
			this.txtThanhTien.TabIndex = 8;
			this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDonGia
			// 
			this.txtDonGia.Enabled = false;
			this.txtDonGia.Location = new System.Drawing.Point(96, 146);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(266, 26);
			this.txtDonGia.TabIndex = 7;
			this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcCTPhieu, "GhiChu", true));
			this.txtGhiChu.Location = new System.Drawing.Point(94, 114);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(268, 26);
			this.txtGhiChu.TabIndex = 6;
			this.txtGhiChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyDown);
			// 
			// bndsrcCTPhieu
			// 
			this.bndsrcCTPhieu.DataSource = typeof(Entity.ChiTietPhieuEntity);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcCTPhieu, "Soluong", true));
			this.txtSoLuong.Location = new System.Drawing.Point(94, 82);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(73, 26);
			this.txtSoLuong.TabIndex = 3;
			this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
			this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Thành tiền:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ghi chú:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số lượng:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kiểu giặt:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đồ:";
			// 
			// btnCauHinhGhiChu
			// 
			this.btnCauHinhGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCauHinhGhiChu.Location = new System.Drawing.Point(12, 219);
			this.btnCauHinhGhiChu.Name = "btnCauHinhGhiChu";
			this.btnCauHinhGhiChu.Size = new System.Drawing.Size(86, 54);
			this.btnCauHinhGhiChu.TabIndex = 1;
			this.btnCauHinhGhiChu.Text = "Cấu hình ghi chú";
			this.btnCauHinhGhiChu.UseVisualStyleBackColor = true;
			this.btnCauHinhGhiChu.Click += new System.EventHandler(this.btnCauHinhGhiChu_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(141, 30);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(537, 219);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 54);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(453, 219);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(74, 54);
			this.btnGhi.TabIndex = 2;
			this.btnGhi.Text = "&Ghi (F4)";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// frmCTPhieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(624, 275);
			this.Controls.Add(this.btnCauHinhGhiChu);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTPhieu";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiết phiếu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCTPhieu_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcCTPhieu)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtThanhTien;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.BindingSource bndsrcCTPhieu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLayDoNhanh;
		private System.Windows.Forms.TextBox txtKieuGiat;
		private System.Windows.Forms.TextBox txtTenHang;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkGiatNhanh;
		private System.Windows.Forms.CheckBox chkTreEm;
        private System.Windows.Forms.Button btnCauHinhGhiChu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGhiChu;
	}
}