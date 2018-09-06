namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmThemKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhachHang));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.txtSoTheVIP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenKhachHang = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDSKhachHang = new System.Windows.Forms.DataGridView();
			this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoTheVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.điệnThoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.địaChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thẻVIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnGhi);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 442);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 70);
			this.panel1.TabIndex = 2;
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._11;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(509, 6);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(102, 58);
			this.btnGhi.TabIndex = 0;
			this.btnGhi.Text = "Thê&m (F2)";
			this.btnGhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(617, 6);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 58);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTim);
			this.groupBox1.Controls.Add(this.txtSoTheVIP);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTenKhachHang);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(720, 94);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnTim
			// 
			this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTim.Image = global::QuanLyTiemGiatLa.Properties.Resources._49;
			this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTim.Location = new System.Drawing.Point(623, 44);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(91, 33);
			this.btnTim.TabIndex = 4;
			this.btnTim.Text = "Tìm (F1)";
			this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// txtSoTheVIP
			// 
			this.txtSoTheVIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoTheVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoTheVIP.Location = new System.Drawing.Point(487, 44);
			this.txtSoTheVIP.Name = "txtSoTheVIP";
			this.txtSoTheVIP.Size = new System.Drawing.Size(130, 26);
			this.txtSoTheVIP.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(388, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Thẻ VIP (F6):";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(487, 15);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(227, 26);
			this.txtDiaChi.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(388, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Địa chỉ (F5):";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDienThoai.Location = new System.Drawing.Point(160, 15);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(222, 26);
			this.txtDienThoai.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Điện thoại (F3):";
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKhachHang.Location = new System.Drawing.Point(160, 44);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(222, 26);
			this.txtTenKhachHang.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng (F4):";
			// 
			// dgvDSKhachHang
			// 
			this.dgvDSKhachHang.AllowUserToAddRows = false;
			this.dgvDSKhachHang.AllowUserToDeleteRows = false;
			this.dgvDSKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DienThoai,
            this.DiaChi,
            this.SoTheVip,
            this.TenVip,
            this.GiamGia});
			this.dgvDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSKhachHang.Location = new System.Drawing.Point(0, 94);
			this.dgvDSKhachHang.MultiSelect = false;
			this.dgvDSKhachHang.Name = "dgvDSKhachHang";
			this.dgvDSKhachHang.ReadOnly = true;
			this.dgvDSKhachHang.RowHeadersWidth = 20;
			this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSKhachHang.Size = new System.Drawing.Size(720, 348);
			this.dgvDSKhachHang.TabIndex = 1;
			this.dgvDSKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhachHang_CellDoubleClick);
			this.dgvDSKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDSKhachHang_KeyDown);
			this.dgvDSKhachHang.SelectionChanged += new System.EventHandler(this.dgvDSKhachHang_SelectionChanged);
			// 
			// MaKhachHang
			// 
			this.MaKhachHang.DataPropertyName = "MaKhachHang";
			this.MaKhachHang.HeaderText = "Mã khách hàng";
			this.MaKhachHang.Name = "MaKhachHang";
			this.MaKhachHang.ReadOnly = true;
			this.MaKhachHang.Visible = false;
			// 
			// TenKhachHang
			// 
			this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenKhachHang.DataPropertyName = "TenKhachHang";
			this.TenKhachHang.HeaderText = "Tên khách hàng";
			this.TenKhachHang.Name = "TenKhachHang";
			this.TenKhachHang.ReadOnly = true;
			// 
			// DienThoai
			// 
			this.DienThoai.DataPropertyName = "DienThoai";
			this.DienThoai.HeaderText = "Điện thoại";
			this.DienThoai.Name = "DienThoai";
			this.DienThoai.ReadOnly = true;
			this.DienThoai.Width = 150;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			this.DiaChi.Width = 200;
			// 
			// SoTheVip
			// 
			this.SoTheVip.DataPropertyName = "SoTheVip";
			this.SoTheVip.HeaderText = "Số thẻ VIP";
			this.SoTheVip.Name = "SoTheVip";
			this.SoTheVip.ReadOnly = true;
			this.SoTheVip.Width = 120;
			// 
			// TenVip
			// 
			this.TenVip.DataPropertyName = "TenVip";
			this.TenVip.HeaderText = "TenVip";
			this.TenVip.Name = "TenVip";
			this.TenVip.ReadOnly = true;
			this.TenVip.Visible = false;
			// 
			// GiamGia
			// 
			this.GiamGia.DataPropertyName = "GiamGia";
			this.GiamGia.HeaderText = "GiamGia";
			this.GiamGia.Name = "GiamGia";
			this.GiamGia.ReadOnly = true;
			this.GiamGia.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.tênToolStripMenuItem,
            this.điệnThoạiToolStripMenuItem,
            this.địaChỉToolStripMenuItem,
            this.thẻVIPToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(179, 160);
			// 
			// tìmToolStripMenuItem
			// 
			this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
			this.tìmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.tìmToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.tìmToolStripMenuItem.Text = "Tìm";
			this.tìmToolStripMenuItem.Click += new System.EventHandler(this.tìmToolStripMenuItem_Click);
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.thêmToolStripMenuItem.Text = "Thêm";
			this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
			// 
			// tênToolStripMenuItem
			// 
			this.tênToolStripMenuItem.Name = "tênToolStripMenuItem";
			this.tênToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.tênToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.tênToolStripMenuItem.Text = "Tên";
			this.tênToolStripMenuItem.Click += new System.EventHandler(this.tênToolStripMenuItem_Click);
			// 
			// điệnThoạiToolStripMenuItem
			// 
			this.điệnThoạiToolStripMenuItem.Name = "điệnThoạiToolStripMenuItem";
			this.điệnThoạiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.điệnThoạiToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.điệnThoạiToolStripMenuItem.Text = "Điện thoại";
			this.điệnThoạiToolStripMenuItem.Click += new System.EventHandler(this.điệnThoạiToolStripMenuItem_Click);
			// 
			// địaChỉToolStripMenuItem
			// 
			this.địaChỉToolStripMenuItem.Name = "địaChỉToolStripMenuItem";
			this.địaChỉToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.địaChỉToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.địaChỉToolStripMenuItem.Text = "Địa chỉ";
			this.địaChỉToolStripMenuItem.Click += new System.EventHandler(this.địaChỉToolStripMenuItem_Click);
			// 
			// thẻVIPToolStripMenuItem
			// 
			this.thẻVIPToolStripMenuItem.Name = "thẻVIPToolStripMenuItem";
			this.thẻVIPToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.thẻVIPToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.thẻVIPToolStripMenuItem.Text = "Thẻ VIP";
			this.thẻVIPToolStripMenuItem.Click += new System.EventHandler(this.thẻVIPToolStripMenuItem_Click);
			// 
			// frmThemKhachHang
			// 
			this.AcceptButton = this.btnTim;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(720, 512);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.dgvDSKhachHang);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmThemKhachHang";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khách hàng";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvDSKhachHang;
		public System.Windows.Forms.TextBox txtTenKhachHang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.TextBox txtSoTheVIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoTheVip;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenVip;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
		private System.Windows.Forms.ToolStripMenuItem tênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem điệnThoạiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem địaChỉToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thẻVIPToolStripMenuItem;
	}
}