namespace QuanLyTiemGiatLa.HeThong
{
	partial class frmBackUpDuLieu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUpDuLieu));
			this.btnBrowseCopyTo = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCopyTo = new System.Windows.Forms.TextBox();
			this.btnBackUp = new System.Windows.Forms.Button();
			this.txtDuongDanFile = new System.Windows.Forms.TextBox();
			this.txtThoiGianBackup = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLuuCauHinh = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBrowseCopyTo
			// 
			this.btnBrowseCopyTo.Location = new System.Drawing.Point(363, 89);
			this.btnBrowseCopyTo.Name = "btnBrowseCopyTo";
			this.btnBrowseCopyTo.Size = new System.Drawing.Size(29, 26);
			this.btnBrowseCopyTo.TabIndex = 15;
			this.btnBrowseCopyTo.Text = "...";
			this.btnBrowseCopyTo.UseVisualStyleBackColor = true;
			this.btnBrowseCopyTo.Click += new System.EventHandler(this.btnBrowseCopyTo_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(220, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Đường dẫn lưu trên máy khác:";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(363, 37);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(29, 26);
			this.btnBrowse.TabIndex = 16;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(286, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "Đường dẫn lưu file *.bak (trên máy chủ):";
			// 
			// txtCopyTo
			// 
			this.txtCopyTo.Location = new System.Drawing.Point(16, 89);
			this.txtCopyTo.Name = "txtCopyTo";
			this.txtCopyTo.Size = new System.Drawing.Size(341, 26);
			this.txtCopyTo.TabIndex = 10;
			// 
			// btnBackUp
			// 
			this.btnBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackUp.Location = new System.Drawing.Point(108, 165);
			this.btnBackUp.Name = "btnBackUp";
			this.btnBackUp.Size = new System.Drawing.Size(75, 47);
			this.btnBackUp.TabIndex = 12;
			this.btnBackUp.Text = "Back up";
			this.btnBackUp.UseVisualStyleBackColor = true;
			this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
			// 
			// txtDuongDanFile
			// 
			this.txtDuongDanFile.Location = new System.Drawing.Point(16, 37);
			this.txtDuongDanFile.Name = "txtDuongDanFile";
			this.txtDuongDanFile.Size = new System.Drawing.Size(341, 26);
			this.txtDuongDanFile.TabIndex = 11;
			// 
			// txtThoiGianBackup
			// 
			this.txtThoiGianBackup.Location = new System.Drawing.Point(169, 124);
			this.txtThoiGianBackup.Name = "txtThoiGianBackup";
			this.txtThoiGianBackup.Size = new System.Drawing.Size(48, 26);
			this.txtThoiGianBackup.TabIndex = 17;
			this.txtThoiGianBackup.Text = "19";
			this.txtThoiGianBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Tự động backup lúc:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(223, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "giờ";
			// 
			// btnLuuCauHinh
			// 
			this.btnLuuCauHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLuuCauHinh.Location = new System.Drawing.Point(189, 165);
			this.btnLuuCauHinh.Name = "btnLuuCauHinh";
			this.btnLuuCauHinh.Size = new System.Drawing.Size(108, 47);
			this.btnLuuCauHinh.TabIndex = 20;
			this.btnLuuCauHinh.Text = "Lưu cấu hình";
			this.btnLuuCauHinh.UseVisualStyleBackColor = true;
			this.btnLuuCauHinh.Click += new System.EventHandler(this.btnLuuCauHinh_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(303, 165);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(89, 47);
			this.btnThoat.TabIndex = 21;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmBackUpDuLieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 224);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLuuCauHinh);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtThoiGianBackup);
			this.Controls.Add(this.btnBrowseCopyTo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCopyTo);
			this.Controls.Add(this.btnBackUp);
			this.Controls.Add(this.txtDuongDanFile);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmBackUpDuLieu";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Back up dữ liệu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowseCopyTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCopyTo;
		private System.Windows.Forms.Button btnBackUp;
		private System.Windows.Forms.TextBox txtDuongDanFile;
		private System.Windows.Forms.TextBox txtThoiGianBackup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLuuCauHinh;
		private System.Windows.Forms.Button btnThoat;
	}
}