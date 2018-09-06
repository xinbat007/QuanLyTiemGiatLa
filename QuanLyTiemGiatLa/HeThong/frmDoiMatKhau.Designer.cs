namespace QuanLyTiemGiatLa.HeThong
{
	partial class frmDoiMatKhau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassOld = new System.Windows.Forms.TextBox();
			this.txtPassNew = new System.Windows.Forms.TextBox();
			this.txtRepassNew = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtRepassNew);
			this.groupBox1.Controls.Add(this.txtPassNew);
			this.groupBox1.Controls.Add(this.txtPassOld);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu cũ:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật khẩu mới:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Đánh lại:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(262, 159);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 41);
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
			this.btnGhi.Location = new System.Drawing.Point(174, 159);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(82, 41);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.Enabled = false;
			this.txtUsername.Location = new System.Drawing.Point(120, 19);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(215, 26);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassOld
			// 
			this.txtPassOld.Location = new System.Drawing.Point(120, 52);
			this.txtPassOld.Name = "txtPassOld";
			this.txtPassOld.PasswordChar = '*';
			this.txtPassOld.Size = new System.Drawing.Size(215, 26);
			this.txtPassOld.TabIndex = 1;
			this.txtPassOld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassOld_KeyDown);
			// 
			// txtPassNew
			// 
			this.txtPassNew.Location = new System.Drawing.Point(120, 85);
			this.txtPassNew.Name = "txtPassNew";
			this.txtPassNew.PasswordChar = '*';
			this.txtPassNew.Size = new System.Drawing.Size(215, 26);
			this.txtPassNew.TabIndex = 2;
			this.txtPassNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassNew_KeyDown);
			// 
			// txtRepassNew
			// 
			this.txtRepassNew.Location = new System.Drawing.Point(120, 118);
			this.txtRepassNew.Name = "txtRepassNew";
			this.txtRepassNew.PasswordChar = '*';
			this.txtRepassNew.Size = new System.Drawing.Size(215, 26);
			this.txtRepassNew.TabIndex = 3;
			this.txtRepassNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRepassNew_KeyDown);
			// 
			// frmDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(365, 212);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDoiMatKhau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi mật khẩu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.TextBox txtRepassNew;
		private System.Windows.Forms.TextBox txtPassNew;
		private System.Windows.Forms.TextBox txtPassOld;
	}
}