namespace QuanLyTiemGiatLa.HeThong
{
	partial class frmDangKySuDungPhanMem
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMaDangKy = new System.Windows.Forms.TextBox();
			this.txtMaMay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChapNhan = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLayMaMay = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMaDangKy);
			this.groupBox1.Controls.Add(this.txtMaMay);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 87);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtMaDangKy
			// 
			this.txtMaDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMaDangKy.Location = new System.Drawing.Point(112, 51);
			this.txtMaDangKy.Name = "txtMaDangKy";
			this.txtMaDangKy.Size = new System.Drawing.Size(292, 26);
			this.txtMaDangKy.TabIndex = 1;
			// 
			// txtMaMay
			// 
			this.txtMaMay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMaMay.Location = new System.Drawing.Point(112, 19);
			this.txtMaMay.Name = "txtMaMay";
			this.txtMaMay.Size = new System.Drawing.Size(292, 26);
			this.txtMaMay.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã đăng ký:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã máy:";
			// 
			// btnChapNhan
			// 
			this.btnChapNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChapNhan.Location = new System.Drawing.Point(225, 93);
			this.btnChapNhan.Name = "btnChapNhan";
			this.btnChapNhan.Size = new System.Drawing.Size(98, 43);
			this.btnChapNhan.TabIndex = 2;
			this.btnChapNhan.Text = "&Chấp nhận";
			this.btnChapNhan.UseVisualStyleBackColor = true;
			this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Location = new System.Drawing.Point(329, 93);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 43);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLayMaMay
			// 
			this.btnLayMaMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLayMaMay.Location = new System.Drawing.Point(112, 93);
			this.btnLayMaMay.Name = "btnLayMaMay";
			this.btnLayMaMay.Size = new System.Drawing.Size(107, 43);
			this.btnLayMaMay.TabIndex = 1;
			this.btnLayMaMay.Text = "Lấy mã máy";
			this.btnLayMaMay.UseVisualStyleBackColor = true;
			this.btnLayMaMay.Click += new System.EventHandler(this.btnLayMaMay_Click);
			// 
			// frmDangKySuDungPhanMem
			// 
			this.AcceptButton = this.btnChapNhan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(416, 144);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLayMaMay);
			this.Controls.Add(this.btnChapNhan);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDangKySuDungPhanMem";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng ký sử dụng phần mềm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMaDangKy;
		private System.Windows.Forms.TextBox txtMaMay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChapNhan;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLayMaMay;
	}
}