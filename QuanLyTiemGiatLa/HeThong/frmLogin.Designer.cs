namespace QuanLyTiemGiatLa.HeThong
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.chkRemember = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txt123456 = new System.Windows.Forms.TextBox();
			this.txtSA = new System.Windows.Forms.TextBox();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.btnTestConnect = new System.Windows.Forms.Button();
			this.chkIsWindow = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblMessage);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.chkRemember);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(9, 124);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(51, 20);
			this.lblMessage.TabIndex = 3;
			this.lblMessage.Text = "label3";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(94, 64);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(201, 26);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(94, 25);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(201, 26);
			this.txtUsername.TabIndex = 0;
			// 
			// chkRemember
			// 
			this.chkRemember.AutoSize = true;
			this.chkRemember.Location = new System.Drawing.Point(94, 99);
			this.chkRemember.Name = "chkRemember";
			this.chkRemember.Size = new System.Drawing.Size(201, 24);
			this.chkRemember.TabIndex = 2;
			this.chkRemember.Text = "Lưu thông tin đăng nhập";
			this.chkRemember.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(215, 158);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(92, 52);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDangNhap.Location = new System.Drawing.Point(111, 158);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(98, 53);
			this.btnDangNhap.TabIndex = 1;
			this.btnDangNhap.Text = "Đăng &nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(321, 250);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.btnDangNhap);
			this.tabPage1.Controls.Add(this.btnThoat);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(313, 217);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Đăng nhập";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txt123456);
			this.tabPage2.Controls.Add(this.txtSA);
			this.tabPage2.Controls.Add(this.txtServerName);
			this.tabPage2.Controls.Add(this.btnTestConnect);
			this.tabPage2.Controls.Add(this.chkIsWindow);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(313, 217);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chọn máy chủ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txt123456
			// 
			this.txt123456.Location = new System.Drawing.Point(105, 129);
			this.txt123456.Name = "txt123456";
			this.txt123456.PasswordChar = '*';
			this.txt123456.Size = new System.Drawing.Size(200, 26);
			this.txt123456.TabIndex = 3;
			// 
			// txtSA
			// 
			this.txtSA.Location = new System.Drawing.Point(105, 89);
			this.txtSA.Name = "txtSA";
			this.txtSA.Size = new System.Drawing.Size(200, 26);
			this.txtSA.TabIndex = 2;
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(105, 12);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(200, 26);
			this.txtServerName.TabIndex = 0;
			// 
			// btnTestConnect
			// 
			this.btnTestConnect.Location = new System.Drawing.Point(192, 164);
			this.btnTestConnect.Name = "btnTestConnect";
			this.btnTestConnect.Size = new System.Drawing.Size(113, 45);
			this.btnTestConnect.TabIndex = 4;
			this.btnTestConnect.Text = "Thử kết nối";
			this.btnTestConnect.UseVisualStyleBackColor = true;
			this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
			// 
			// chkIsWindow
			// 
			this.chkIsWindow.AutoSize = true;
			this.chkIsWindow.Location = new System.Drawing.Point(12, 50);
			this.chkIsWindow.Name = "chkIsWindow";
			this.chkIsWindow.Size = new System.Drawing.Size(159, 24);
			this.chkIsWindow.TabIndex = 1;
			this.chkIsWindow.Text = "Xác thực Windows";
			this.chkIsWindow.UseVisualStyleBackColor = true;
			this.chkIsWindow.CheckedChanged += new System.EventHandler(this.chkIsWindow_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "User name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Máy chủ:";
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnDangNhap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(321, 250);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MR. Clean";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.CheckBox chkRemember;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnTestConnect;
		private System.Windows.Forms.CheckBox chkIsWindow;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt123456;
		private System.Windows.Forms.TextBox txtSA;
		private System.Windows.Forms.TextBox txtServerName;
	}
}