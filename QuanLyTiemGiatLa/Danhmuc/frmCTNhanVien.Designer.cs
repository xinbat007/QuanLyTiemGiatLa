namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTNhanVien));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboQuyen = new System.Windows.Forms.ComboBox();
			this.txtRePass = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.bndsrcNhanVien = new System.Windows.Forms.BindingSource(this.components);
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.chkDanhSachPhieu = new System.Windows.Forms.CheckBox();
			this.chkNhungViecCanLam = new System.Windows.Forms.CheckBox();
			this.chkDoiMatKhau = new System.Windows.Forms.CheckBox();
			this.chkThongKeThuNhap = new System.Windows.Forms.CheckBox();
			this.chkLapPhieu = new System.Windows.Forms.CheckBox();
			this.chkCatDo = new System.Windows.Forms.CheckBox();
			this.chkLoaiHang = new System.Windows.Forms.CheckBox();
			this.chkMatHang = new System.Windows.Forms.CheckBox();
			this.chkKieuGiat = new System.Windows.Forms.CheckBox();
			this.chkCauHinh = new System.Windows.Forms.CheckBox();
			this.chkNhanVien = new System.Windows.Forms.CheckBox();
			this.chkLoaiKhachHang = new System.Windows.Forms.CheckBox();
			this.chkDotGiamGia = new System.Windows.Forms.CheckBox();
			this.chkBangGia = new System.Windows.Forms.CheckBox();
			this.chkKhachHang = new System.Windows.Forms.CheckBox();
			this.chkBangChotKet = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkGiaDeDo = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcNhanVien)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cboQuyen);
			this.groupBox1.Controls.Add(this.txtRePass);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtHoten);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(11, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(761, 83);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// cboQuyen
			// 
			this.cboQuyen.FormattingEnabled = true;
			this.cboQuyen.Location = new System.Drawing.Point(571, 45);
			this.cboQuyen.Name = "cboQuyen";
			this.cboQuyen.Size = new System.Drawing.Size(181, 28);
			this.cboQuyen.TabIndex = 4;
			this.cboQuyen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboQuyen_KeyDown);
			// 
			// txtRePass
			// 
			this.txtRePass.Location = new System.Drawing.Point(374, 48);
			this.txtRePass.Name = "txtRePass";
			this.txtRePass.PasswordChar = '*';
			this.txtRePass.Size = new System.Drawing.Size(179, 26);
			this.txtRePass.TabIndex = 3;
			this.txtRePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRePass_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcNhanVien, "Password", true));
			this.txtPassword.Location = new System.Drawing.Point(374, 19);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(179, 26);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// bndsrcNhanVien
			// 
			this.bndsrcNhanVien.DataSource = typeof(Entity.UserEntity);
			// 
			// txtHoten
			// 
			this.txtHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcNhanVien, "HoTen", true));
			this.txtHoten.Location = new System.Drawing.Point(94, 48);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(179, 26);
			this.txtHoten.TabIndex = 1;
			this.txtHoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoten_KeyDown);
			// 
			// txtUsername
			// 
			this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcNhanVien, "UserName", true));
			this.txtUsername.Location = new System.Drawing.Point(94, 19);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(179, 26);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(297, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Đánh lại:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Họ tên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(567, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Chức vụ:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(289, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản:";
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGhi.Location = new System.Drawing.Point(588, 273);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(83, 46);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(677, 273);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(95, 46);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// chkDanhSachPhieu
			// 
			this.chkDanhSachPhieu.AutoSize = true;
			this.chkDanhSachPhieu.Location = new System.Drawing.Point(19, 25);
			this.chkDanhSachPhieu.Name = "chkDanhSachPhieu";
			this.chkDanhSachPhieu.Size = new System.Drawing.Size(148, 24);
			this.chkDanhSachPhieu.TabIndex = 3;
			this.chkDanhSachPhieu.Text = "Danh sách phiếu";
			this.chkDanhSachPhieu.UseVisualStyleBackColor = true;
			// 
			// chkNhungViecCanLam
			// 
			this.chkNhungViecCanLam.AutoSize = true;
			this.chkNhungViecCanLam.Location = new System.Drawing.Point(19, 115);
			this.chkNhungViecCanLam.Name = "chkNhungViecCanLam";
			this.chkNhungViecCanLam.Size = new System.Drawing.Size(165, 24);
			this.chkNhungViecCanLam.TabIndex = 4;
			this.chkNhungViecCanLam.Text = "Những việc cần làm";
			this.chkNhungViecCanLam.UseVisualStyleBackColor = true;
			// 
			// chkDoiMatKhau
			// 
			this.chkDoiMatKhau.AutoSize = true;
			this.chkDoiMatKhau.Location = new System.Drawing.Point(19, 145);
			this.chkDoiMatKhau.Name = "chkDoiMatKhau";
			this.chkDoiMatKhau.Size = new System.Drawing.Size(122, 24);
			this.chkDoiMatKhau.TabIndex = 5;
			this.chkDoiMatKhau.Text = "Đổi mật khẩu";
			this.chkDoiMatKhau.UseVisualStyleBackColor = true;
			// 
			// chkThongKeThuNhap
			// 
			this.chkThongKeThuNhap.AutoSize = true;
			this.chkThongKeThuNhap.Location = new System.Drawing.Point(571, 55);
			this.chkThongKeThuNhap.Name = "chkThongKeThuNhap";
			this.chkThongKeThuNhap.Size = new System.Drawing.Size(161, 24);
			this.chkThongKeThuNhap.TabIndex = 6;
			this.chkThongKeThuNhap.Text = "Thống kê thu nhập";
			this.chkThongKeThuNhap.UseVisualStyleBackColor = true;
			// 
			// chkLapPhieu
			// 
			this.chkLapPhieu.AutoSize = true;
			this.chkLapPhieu.Location = new System.Drawing.Point(19, 55);
			this.chkLapPhieu.Name = "chkLapPhieu";
			this.chkLapPhieu.Size = new System.Drawing.Size(98, 24);
			this.chkLapPhieu.TabIndex = 7;
			this.chkLapPhieu.Text = "Lập phiếu";
			this.chkLapPhieu.UseVisualStyleBackColor = true;
			// 
			// chkCatDo
			// 
			this.chkCatDo.AutoSize = true;
			this.chkCatDo.Location = new System.Drawing.Point(19, 85);
			this.chkCatDo.Name = "chkCatDo";
			this.chkCatDo.Size = new System.Drawing.Size(75, 24);
			this.chkCatDo.TabIndex = 8;
			this.chkCatDo.Text = "Cất đồ";
			this.chkCatDo.UseVisualStyleBackColor = true;
			// 
			// chkLoaiHang
			// 
			this.chkLoaiHang.AutoSize = true;
			this.chkLoaiHang.Location = new System.Drawing.Point(413, 55);
			this.chkLoaiHang.Name = "chkLoaiHang";
			this.chkLoaiHang.Size = new System.Drawing.Size(98, 24);
			this.chkLoaiHang.TabIndex = 9;
			this.chkLoaiHang.Text = "Loại hàng";
			this.chkLoaiHang.UseVisualStyleBackColor = true;
			// 
			// chkMatHang
			// 
			this.chkMatHang.AutoSize = true;
			this.chkMatHang.Location = new System.Drawing.Point(413, 25);
			this.chkMatHang.Name = "chkMatHang";
			this.chkMatHang.Size = new System.Drawing.Size(95, 24);
			this.chkMatHang.TabIndex = 10;
			this.chkMatHang.Text = "Mặt hàng";
			this.chkMatHang.UseVisualStyleBackColor = true;
			// 
			// chkKieuGiat
			// 
			this.chkKieuGiat.AutoSize = true;
			this.chkKieuGiat.Location = new System.Drawing.Point(413, 85);
			this.chkKieuGiat.Name = "chkKieuGiat";
			this.chkKieuGiat.Size = new System.Drawing.Size(89, 24);
			this.chkKieuGiat.TabIndex = 11;
			this.chkKieuGiat.Text = "Kiểu giặt";
			this.chkKieuGiat.UseVisualStyleBackColor = true;
			// 
			// chkCauHinh
			// 
			this.chkCauHinh.AutoSize = true;
			this.chkCauHinh.Location = new System.Drawing.Point(220, 25);
			this.chkCauHinh.Name = "chkCauHinh";
			this.chkCauHinh.Size = new System.Drawing.Size(91, 24);
			this.chkCauHinh.TabIndex = 12;
			this.chkCauHinh.Text = "Cấu hình";
			this.chkCauHinh.UseVisualStyleBackColor = true;
			// 
			// chkNhanVien
			// 
			this.chkNhanVien.AutoSize = true;
			this.chkNhanVien.Location = new System.Drawing.Point(220, 85);
			this.chkNhanVien.Name = "chkNhanVien";
			this.chkNhanVien.Size = new System.Drawing.Size(98, 24);
			this.chkNhanVien.TabIndex = 13;
			this.chkNhanVien.Text = "Nhân viên";
			this.chkNhanVien.UseVisualStyleBackColor = true;
			// 
			// chkLoaiKhachHang
			// 
			this.chkLoaiKhachHang.AutoSize = true;
			this.chkLoaiKhachHang.Location = new System.Drawing.Point(220, 145);
			this.chkLoaiKhachHang.Name = "chkLoaiKhachHang";
			this.chkLoaiKhachHang.Size = new System.Drawing.Size(145, 24);
			this.chkLoaiKhachHang.TabIndex = 14;
			this.chkLoaiKhachHang.Text = "Loại khách hàng";
			this.chkLoaiKhachHang.UseVisualStyleBackColor = true;
			// 
			// chkDotGiamGia
			// 
			this.chkDotGiamGia.AutoSize = true;
			this.chkDotGiamGia.Location = new System.Drawing.Point(220, 55);
			this.chkDotGiamGia.Name = "chkDotGiamGia";
			this.chkDotGiamGia.Size = new System.Drawing.Size(117, 24);
			this.chkDotGiamGia.TabIndex = 15;
			this.chkDotGiamGia.Text = "Đợt giảm giá";
			this.chkDotGiamGia.UseVisualStyleBackColor = true;
			// 
			// chkBangGia
			// 
			this.chkBangGia.AutoSize = true;
			this.chkBangGia.Location = new System.Drawing.Point(413, 115);
			this.chkBangGia.Name = "chkBangGia";
			this.chkBangGia.Size = new System.Drawing.Size(91, 24);
			this.chkBangGia.TabIndex = 16;
			this.chkBangGia.Text = "Bảng giá";
			this.chkBangGia.UseVisualStyleBackColor = true;
			// 
			// chkKhachHang
			// 
			this.chkKhachHang.AutoSize = true;
			this.chkKhachHang.Location = new System.Drawing.Point(220, 115);
			this.chkKhachHang.Name = "chkKhachHang";
			this.chkKhachHang.Size = new System.Drawing.Size(113, 24);
			this.chkKhachHang.TabIndex = 17;
			this.chkKhachHang.Text = "Khách hàng";
			this.chkKhachHang.UseVisualStyleBackColor = true;
			// 
			// chkBangChotKet
			// 
			this.chkBangChotKet.AutoSize = true;
			this.chkBangChotKet.Location = new System.Drawing.Point(571, 25);
			this.chkBangChotKet.Name = "chkBangChotKet";
			this.chkBangChotKet.Size = new System.Drawing.Size(127, 24);
			this.chkBangChotKet.TabIndex = 18;
			this.chkBangChotKet.Text = "Bảng chốt két";
			this.chkBangChotKet.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.chkGiaDeDo);
			this.groupBox2.Controls.Add(this.chkDanhSachPhieu);
			this.groupBox2.Controls.Add(this.chkBangChotKet);
			this.groupBox2.Controls.Add(this.chkNhungViecCanLam);
			this.groupBox2.Controls.Add(this.chkKhachHang);
			this.groupBox2.Controls.Add(this.chkDoiMatKhau);
			this.groupBox2.Controls.Add(this.chkBangGia);
			this.groupBox2.Controls.Add(this.chkThongKeThuNhap);
			this.groupBox2.Controls.Add(this.chkDotGiamGia);
			this.groupBox2.Controls.Add(this.chkLapPhieu);
			this.groupBox2.Controls.Add(this.chkLoaiKhachHang);
			this.groupBox2.Controls.Add(this.chkCatDo);
			this.groupBox2.Controls.Add(this.chkNhanVien);
			this.groupBox2.Controls.Add(this.chkLoaiHang);
			this.groupBox2.Controls.Add(this.chkCauHinh);
			this.groupBox2.Controls.Add(this.chkMatHang);
			this.groupBox2.Controls.Add(this.chkKieuGiat);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(11, 89);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(761, 178);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Phân quyền";
			// 
			// chkGiaDeDo
			// 
			this.chkGiaDeDo.AutoSize = true;
			this.chkGiaDeDo.Location = new System.Drawing.Point(413, 145);
			this.chkGiaDeDo.Name = "chkGiaDeDo";
			this.chkGiaDeDo.Size = new System.Drawing.Size(97, 24);
			this.chkGiaDeDo.TabIndex = 19;
			this.chkGiaDeDo.Text = "Giá để đồ";
			this.chkGiaDeDo.UseVisualStyleBackColor = true;
			// 
			// frmCTNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(784, 331);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTNhanVien";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Người dùng";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcNhanVien)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRePass;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtHoten;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboQuyen;
		private System.Windows.Forms.BindingSource bndsrcNhanVien;
		private System.Windows.Forms.CheckBox chkDanhSachPhieu;
		private System.Windows.Forms.CheckBox chkNhungViecCanLam;
		private System.Windows.Forms.CheckBox chkDoiMatKhau;
		private System.Windows.Forms.CheckBox chkThongKeThuNhap;
		private System.Windows.Forms.CheckBox chkLapPhieu;
		private System.Windows.Forms.CheckBox chkCatDo;
		private System.Windows.Forms.CheckBox chkLoaiHang;
		private System.Windows.Forms.CheckBox chkMatHang;
		private System.Windows.Forms.CheckBox chkKieuGiat;
		private System.Windows.Forms.CheckBox chkCauHinh;
		private System.Windows.Forms.CheckBox chkNhanVien;
		private System.Windows.Forms.CheckBox chkLoaiKhachHang;
		private System.Windows.Forms.CheckBox chkDotGiamGia;
		private System.Windows.Forms.CheckBox chkBangGia;
		private System.Windows.Forms.CheckBox chkKhachHang;
		private System.Windows.Forms.CheckBox chkBangChotKet;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkGiaDeDo;
	}
}