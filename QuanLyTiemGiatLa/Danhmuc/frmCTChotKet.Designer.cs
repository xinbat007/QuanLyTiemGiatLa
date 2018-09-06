namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTChotKet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTChotKet));
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDenPhieu = new System.Windows.Forms.TextBox();
			this.txtTuPhieu = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpThoiDiemChot = new System.Windows.Forms.DateTimePicker();
			this.txtSoTienChot = new System.Windows.Forms.TextBox();
			this.txtNguoiChot = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDSPhieuHuy = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGhi
			// 
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(165, 240);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(82, 52);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(253, 240);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 52);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtDenPhieu);
			this.groupBox1.Controls.Add(this.txtTuPhieu);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtpThoiDiemChot);
			this.groupBox1.Controls.Add(this.txtSoTienChot);
			this.groupBox1.Controls.Add(this.txtNguoiChot);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtGhiChu);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, -1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 234);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDenPhieu
			// 
			this.txtDenPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDenPhieu.Location = new System.Drawing.Point(120, 111);
			this.txtDenPhieu.Name = "txtDenPhieu";
			this.txtDenPhieu.ReadOnly = true;
			this.txtDenPhieu.Size = new System.Drawing.Size(206, 26);
			this.txtDenPhieu.TabIndex = 3;
			// 
			// txtTuPhieu
			// 
			this.txtTuPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTuPhieu.Location = new System.Drawing.Point(120, 80);
			this.txtTuPhieu.Name = "txtTuPhieu";
			this.txtTuPhieu.ReadOnly = true;
			this.txtTuPhieu.Size = new System.Drawing.Size(206, 26);
			this.txtTuPhieu.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Đến phiếu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Từ phiếu:";
			// 
			// dtpThoiDiemChot
			// 
			this.dtpThoiDiemChot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpThoiDiemChot.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpThoiDiemChot.Enabled = false;
			this.dtpThoiDiemChot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpThoiDiemChot.Location = new System.Drawing.Point(120, 49);
			this.dtpThoiDiemChot.Name = "dtpThoiDiemChot";
			this.dtpThoiDiemChot.Size = new System.Drawing.Size(206, 26);
			this.dtpThoiDiemChot.TabIndex = 1;
			// 
			// txtSoTienChot
			// 
			this.txtSoTienChot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoTienChot.ForeColor = System.Drawing.Color.Red;
			this.txtSoTienChot.Location = new System.Drawing.Point(120, 143);
			this.txtSoTienChot.Name = "txtSoTienChot";
			this.txtSoTienChot.ReadOnly = true;
			this.txtSoTienChot.Size = new System.Drawing.Size(206, 26);
			this.txtSoTienChot.TabIndex = 4;
			this.txtSoTienChot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtNguoiChot
			// 
			this.txtNguoiChot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNguoiChot.Location = new System.Drawing.Point(120, 21);
			this.txtNguoiChot.Name = "txtNguoiChot";
			this.txtNguoiChot.ReadOnly = true;
			this.txtNguoiChot.Size = new System.Drawing.Size(206, 26);
			this.txtNguoiChot.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(46, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ghi chú:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số tiền chốt:";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtGhiChu.Location = new System.Drawing.Point(120, 174);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(206, 54);
			this.txtGhiChu.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-2, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thời điểm chốt:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Người chốt:";
			// 
			// lblDSPhieuHuy
			// 
			this.lblDSPhieuHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblDSPhieuHuy.Location = new System.Drawing.Point(10, 307);
			this.lblDSPhieuHuy.Name = "lblDSPhieuHuy";
			this.lblDSPhieuHuy.Size = new System.Drawing.Size(334, 0);
			this.lblDSPhieuHuy.TabIndex = 4;
			this.lblDSPhieuHuy.Text = "label7";
			// 
			// frmCTChotKet
			// 
			this.AcceptButton = this.btnGhi;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(356, 302);
			this.Controls.Add(this.lblDSPhieuHuy);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTChotKet";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chốt két";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSoTienChot;
		private System.Windows.Forms.TextBox txtNguoiChot;
		private System.Windows.Forms.DateTimePicker dtpThoiDiemChot;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDenPhieu;
		private System.Windows.Forms.TextBox txtTuPhieu;
		private System.Windows.Forms.Label lblDSPhieuHuy;
	}
}