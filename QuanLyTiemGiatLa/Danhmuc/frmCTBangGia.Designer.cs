namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTBangGia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTBangGia));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboKieuGiatLa = new QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox();
			this.bndsrcBaogia = new System.Windows.Forms.BindingSource(this.components);
			this.bndsrcDSKieuGiatLa = new System.Windows.Forms.BindingSource(this.components);
			this.cboMatHang = new QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox();
			this.bndsrcDSMatHang = new System.Windows.Forms.BindingSource(this.components);
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.nudSoSanPham = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcBaogia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKieuGiatLa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSMatHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSoSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudSoSanPham);
			this.groupBox1.Controls.Add(this.cboKieuGiatLa);
			this.groupBox1.Controls.Add(this.cboMatHang);
			this.groupBox1.Controls.Add(this.txtDonGia);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 163);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// cboKieuGiatLa
			// 
			this.cboKieuGiatLa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsrcBaogia, "MaKieuGiat", true));
			this.cboKieuGiatLa.DataSource = this.bndsrcDSKieuGiatLa;
			this.cboKieuGiatLa.DisplayMember = "TenKieuGiat";
			this.cboKieuGiatLa.FormattingEnabled = true;
			this.cboKieuGiatLa.Location = new System.Drawing.Point(125, 59);
			this.cboKieuGiatLa.Name = "cboKieuGiatLa";
			this.cboKieuGiatLa.Size = new System.Drawing.Size(246, 28);
			this.cboKieuGiatLa.TabIndex = 1;
			this.cboKieuGiatLa.ValueMember = "MaKieuGiat";
			this.cboKieuGiatLa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboKieuGiatLa_KeyDown);
			// 
			// bndsrcBaogia
			// 
			this.bndsrcBaogia.DataSource = typeof(Entity.BangGiaEntity);
			// 
			// bndsrcDSKieuGiatLa
			// 
			this.bndsrcDSKieuGiatLa.DataSource = typeof(Entity.ListKieuGiatLaEntity);
			// 
			// cboMatHang
			// 
			this.cboMatHang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsrcBaogia, "MaHang", true));
			this.cboMatHang.DataSource = this.bndsrcDSMatHang;
			this.cboMatHang.DisplayMember = "TenHang";
			this.cboMatHang.FormattingEnabled = true;
			this.cboMatHang.Location = new System.Drawing.Point(125, 24);
			this.cboMatHang.Name = "cboMatHang";
			this.cboMatHang.Size = new System.Drawing.Size(246, 28);
			this.cboMatHang.TabIndex = 0;
			this.cboMatHang.ValueMember = "MaHang";
			this.cboMatHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMatHang_KeyDown);
			// 
			// bndsrcDSMatHang
			// 
			this.bndsrcDSMatHang.AllowNew = true;
			this.bndsrcDSMatHang.DataSource = typeof(Entity.ListMatHangEntity);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(125, 94);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(246, 26);
			this.txtDonGia.TabIndex = 2;
			this.txtDonGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDonGia_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Đơn giá:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kiểu giặt:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đồ:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(280, 168);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 52);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(192, 168);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(82, 52);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số sản phẩm:";
			// 
			// nudSoSanPham
			// 
			this.nudSoSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bndsrcBaogia, "SoSanPham", true));
			this.nudSoSanPham.Location = new System.Drawing.Point(125, 127);
			this.nudSoSanPham.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSoSanPham.Name = "nudSoSanPham";
			this.nudSoSanPham.Size = new System.Drawing.Size(246, 26);
			this.nudSoSanPham.TabIndex = 3;
			this.nudSoSanPham.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// frmCTBangGia
			// 
			this.AcceptButton = this.btnGhi;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(383, 232);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTBangGia";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiết giá";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcBaogia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKieuGiatLa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSMatHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSoSanPham)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.BindingSource bndsrcDSMatHang;
		private System.Windows.Forms.BindingSource bndsrcDSKieuGiatLa;
		private System.Windows.Forms.BindingSource bndsrcBaogia;
		private QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox cboMatHang;
		private QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox cboKieuGiatLa;
		private System.Windows.Forms.NumericUpDown nudSoSanPham;
		private System.Windows.Forms.Label label4;
	}
}