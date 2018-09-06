namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTKhachHang));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboMucDoVip = new QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox();
			this.bndsrcKhachHang = new System.Windows.Forms.BindingSource(this.components);
			this.bndsrcDSMucDoVip = new System.Windows.Forms.BindingSource(this.components);
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.txtTenKhachHang = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSoTheVip = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcKhachHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSMucDoVip)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cboMucDoVip);
			this.groupBox1.Controls.Add(this.txtSoTheVip);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.txtTenKhachHang);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(401, 198);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// cboMucDoVip
			// 
			this.cboMucDoVip.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bndsrcKhachHang, "MaVip", true));
			this.cboMucDoVip.DataSource = this.bndsrcDSMucDoVip;
			this.cboMucDoVip.DisplayMember = "TenVip";
			this.cboMucDoVip.FormattingEnabled = true;
			this.cboMucDoVip.Location = new System.Drawing.Point(144, 160);
			this.cboMucDoVip.Name = "cboMucDoVip";
			this.cboMucDoVip.Size = new System.Drawing.Size(249, 28);
			this.cboMucDoVip.TabIndex = 4;
			this.cboMucDoVip.ValueMember = "MaVip";
			// 
			// bndsrcKhachHang
			// 
			this.bndsrcKhachHang.DataSource = typeof(Entity.KhachHangEntity);
			// 
			// bndsrcDSMucDoVip
			// 
			this.bndsrcDSMucDoVip.DataSource = typeof(Entity.ListMucDoVipEntity);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKhachHang, "DiaChi", true));
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(143, 90);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(249, 26);
			this.txtDiaChi.TabIndex = 2;
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKhachHang, "DienThoai", true));
			this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDienThoai.Location = new System.Drawing.Point(144, 54);
			this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(249, 26);
			this.txtDienThoai.TabIndex = 1;
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKhachHang, "TenKhachHang", true));
			this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenKhachHang.Location = new System.Drawing.Point(144, 21);
			this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(249, 26);
			this.txtTenKhachHang.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 163);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mức độ VIP:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(74, 93);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Điện thoại:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(287, 207);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(117, 68);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(180, 207);
			this.btnGhi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(99, 68);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(46, 129);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Số thẻ VIP:";
			// 
			// txtSoTheVip
			// 
			this.txtSoTheVip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoTheVip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKhachHang, "SoTheVip", true));
			this.txtSoTheVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoTheVip.Location = new System.Drawing.Point(143, 126);
			this.txtSoTheVip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSoTheVip.Name = "txtSoTheVip";
			this.txtSoTheVip.Size = new System.Drawing.Size(249, 26);
			this.txtSoTheVip.TabIndex = 3;
			// 
			// frmCTKhachHang
			// 
			this.AcceptButton = this.btnGhi;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(408, 278);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTKhachHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khách hàng";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcKhachHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSMucDoVip)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTenKhachHang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.BindingSource bndsrcKhachHang;
		private System.Windows.Forms.Label label4;
		private QuanLyTiemGiatLa.UserCtrl.AutoCompleteCombobox cboMucDoVip;
		private System.Windows.Forms.BindingSource bndsrcDSMucDoVip;
		private System.Windows.Forms.TextBox txtSoTheVip;
		private System.Windows.Forms.Label label5;
	}
}