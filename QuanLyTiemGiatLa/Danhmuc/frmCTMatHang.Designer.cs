namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTMatHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTMatHang));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChonAnh = new System.Windows.Forms.Button();
			this.cboLoaiHang = new QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox();
			this.bndsrcMatHang = new System.Windows.Forms.BindingSource(this.components);
			this.bndsrcDSLoaiHang = new System.Windows.Forms.BindingSource(this.components);
			this.txtTenHang = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.ptbImage = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcMatHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSLoaiHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnChonAnh);
			this.groupBox1.Controls.Add(this.cboLoaiHang);
			this.groupBox1.Controls.Add(this.txtTenHang);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(323, 157);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnChonAnh
			// 
			this.btnChonAnh.Image = global::QuanLyTiemGiatLa.Properties.Resources.find18;
			this.btnChonAnh.Location = new System.Drawing.Point(109, 107);
			this.btnChonAnh.Name = "btnChonAnh";
			this.btnChonAnh.Size = new System.Drawing.Size(43, 40);
			this.btnChonAnh.TabIndex = 2;
			this.btnChonAnh.UseVisualStyleBackColor = true;
			this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
			// 
			// cboLoaiHang
			// 
			this.cboLoaiHang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsrcMatHang, "MaLoaiHang", true));
			this.cboLoaiHang.DataSource = this.bndsrcDSLoaiHang;
			this.cboLoaiHang.DisplayMember = "TenLoaiHang";
			this.cboLoaiHang.FormattingEnabled = true;
			this.cboLoaiHang.Location = new System.Drawing.Point(109, 64);
			this.cboLoaiHang.Name = "cboLoaiHang";
			this.cboLoaiHang.Size = new System.Drawing.Size(207, 28);
			this.cboLoaiHang.TabIndex = 1;
			this.cboLoaiHang.ValueMember = "MaLoaiHang";
			this.cboLoaiHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLoaiHang_KeyDown);
			// 
			// bndsrcMatHang
			// 
			this.bndsrcMatHang.DataSource = typeof(Entity.MatHangEntity);
			// 
			// bndsrcDSLoaiHang
			// 
			this.bndsrcDSLoaiHang.DataSource = typeof(Entity.ListLoaiHangEntity);
			// 
			// txtTenHang
			// 
			this.txtTenHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcMatHang, "TenHang", true));
			this.txtTenHang.Location = new System.Drawing.Point(109, 16);
			this.txtTenHang.Name = "txtTenHang";
			this.txtTenHang.Size = new System.Drawing.Size(207, 26);
			this.txtTenHang.TabIndex = 0;
			this.txtTenHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenHang_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Chọn ảnh:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Loại hàng:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên hàng:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(239, 165);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(96, 69);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(137, 165);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(96, 69);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// ptbImage
			// 
			this.ptbImage.Location = new System.Drawing.Point(341, 12);
			this.ptbImage.Name = "ptbImage";
			this.ptbImage.Size = new System.Drawing.Size(92, 92);
			this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImage.TabIndex = 3;
			this.ptbImage.TabStop = false;
			// 
			// frmCTMatHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(440, 246);
			this.Controls.Add(this.ptbImage);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTMatHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mặt hàng";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcMatHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSLoaiHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenHang;
		private System.Windows.Forms.BindingSource bndsrcDSLoaiHang;
		private System.Windows.Forms.BindingSource bndsrcMatHang;
		private QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox cboLoaiHang;
		private System.Windows.Forms.Button btnChonAnh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox ptbImage;
	}
}