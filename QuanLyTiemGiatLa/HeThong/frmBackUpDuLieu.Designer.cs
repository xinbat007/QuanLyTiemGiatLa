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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTryConnect = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.txtPathServer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseCopyTo
            // 
            this.btnBrowseCopyTo.Location = new System.Drawing.Point(357, 97);
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
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đường dẫn lưu trên máy khác:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(357, 45);
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
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đường dẫn lưu file *.bak (trên máy chủ):";
            // 
            // txtCopyTo
            // 
            this.txtCopyTo.Location = new System.Drawing.Point(10, 97);
            this.txtCopyTo.Name = "txtCopyTo";
            this.txtCopyTo.Size = new System.Drawing.Size(341, 26);
            this.txtCopyTo.TabIndex = 2;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(262, 168);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(124, 47);
            this.btnBackUp.TabIndex = 12;
            this.btnBackUp.Text = "Back up ngay";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // txtDuongDanFile
            // 
            this.txtDuongDanFile.Location = new System.Drawing.Point(10, 45);
            this.txtDuongDanFile.Name = "txtDuongDanFile";
            this.txtDuongDanFile.Size = new System.Drawing.Size(341, 26);
            this.txtDuongDanFile.TabIndex = 1;
            // 
            // txtThoiGianBackup
            // 
            this.txtThoiGianBackup.Location = new System.Drawing.Point(163, 132);
            this.txtThoiGianBackup.Name = "txtThoiGianBackup";
            this.txtThoiGianBackup.Size = new System.Drawing.Size(48, 26);
            this.txtThoiGianBackup.TabIndex = 3;
            this.txtThoiGianBackup.Text = "19";
            this.txtThoiGianBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tự động backup lúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "giờ";
            // 
            // btnLuuCauHinh
            // 
            this.btnLuuCauHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuCauHinh.Location = new System.Drawing.Point(627, 180);
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
            this.btnThoat.Location = new System.Drawing.Point(741, 180);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 47);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDuongDanFile);
            this.groupBox1.Controls.Add(this.btnBackUp);
            this.groupBox1.Controls.Add(this.txtCopyTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtThoiGianBackup);
            this.groupBox1.Controls.Add(this.btnBrowseCopyTo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 221);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPathServer);
            this.groupBox2.Controls.Add(this.btnSync);
            this.groupBox2.Controls.Add(this.btnTryConnect);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 155);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đường dẫn server tổng";
            // 
            // btnTryConnect
            // 
            this.btnTryConnect.Location = new System.Drawing.Point(152, 87);
            this.btnTryConnect.Name = "btnTryConnect";
            this.btnTryConnect.Size = new System.Drawing.Size(113, 47);
            this.btnTryConnect.TabIndex = 1;
            this.btnTryConnect.Text = "Thử kết nối";
            this.btnTryConnect.UseVisualStyleBackColor = true;
            this.btnTryConnect.Click += new System.EventHandler(this.btnTryConnect_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(271, 87);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(144, 47);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Đồng bộ lên tổng";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtPathServer
            // 
            this.txtPathServer.Location = new System.Drawing.Point(10, 45);
            this.txtPathServer.Name = "txtPathServer";
            this.txtPathServer.Size = new System.Drawing.Size(405, 26);
            this.txtPathServer.TabIndex = 4;
            // 
            // frmBackUpDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuuCauHinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackUpDuLieu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back up dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPathServer;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnTryConnect;
        private System.Windows.Forms.Label label5;
    }
}