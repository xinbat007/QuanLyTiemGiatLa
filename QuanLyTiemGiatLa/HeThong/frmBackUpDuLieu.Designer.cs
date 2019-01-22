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
            this.btnSyncCustomer = new System.Windows.Forms.Button();
            this.lblCustomerNotSync = new System.Windows.Forms.Label();
            this.lblOrderNotSync = new System.Windows.Forms.Label();
            this.txtPasswordServerSync = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserNameServerSync = new System.Windows.Forms.TextBox();
            this.txtPathServer = new System.Windows.Forms.TextBox();
            this.btnSyncOrder = new System.Windows.Forms.Button();
            this.btnTryConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportCustomer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportBillDetail = new System.Windows.Forms.Button();
            this.btnBrowsePathCustomer = new System.Windows.Forms.Button();
            this.btnExportBill = new System.Windows.Forms.Button();
            this.txtPathJsonKH = new System.Windows.Forms.TextBox();
            this.btnImportCustomer = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.bgwSyncOrders = new System.ComponentModel.BackgroundWorker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.bgwSyncCustomers = new System.ComponentModel.BackgroundWorker();
            this.bgwImportCustomers = new System.ComponentModel.BackgroundWorker();
            this.bgwGetSyncInfo = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.btnBackUp.Location = new System.Drawing.Point(262, 135);
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
            this.btnLuuCauHinh.Location = new System.Drawing.Point(652, 340);
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
            this.btnThoat.Location = new System.Drawing.Point(766, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 47);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(397, 196);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offline";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSyncCustomer);
            this.groupBox2.Controls.Add(this.lblCustomerNotSync);
            this.groupBox2.Controls.Add(this.lblOrderNotSync);
            this.groupBox2.Controls.Add(this.txtPasswordServerSync);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUserNameServerSync);
            this.groupBox2.Controls.Add(this.txtPathServer);
            this.groupBox2.Controls.Add(this.btnSyncOrder);
            this.groupBox2.Controls.Add(this.btnTryConnect);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 321);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Online";
            // 
            // btnSyncCustomer
            // 
            this.btnSyncCustomer.Location = new System.Drawing.Point(201, 261);
            this.btnSyncCustomer.Name = "btnSyncCustomer";
            this.btnSyncCustomer.Size = new System.Drawing.Size(170, 47);
            this.btnSyncCustomer.TabIndex = 11;
            this.btnSyncCustomer.Text = "Đồng bộ khách hàng";
            this.btnSyncCustomer.UseVisualStyleBackColor = true;
            this.btnSyncCustomer.Click += new System.EventHandler(this.btnSyncCustomer_Click);
            // 
            // lblCustomerNotSync
            // 
            this.lblCustomerNotSync.AutoSize = true;
            this.lblCustomerNotSync.Location = new System.Drawing.Point(12, 214);
            this.lblCustomerNotSync.Name = "lblCustomerNotSync";
            this.lblCustomerNotSync.Size = new System.Drawing.Size(275, 20);
            this.lblCustomerNotSync.TabIndex = 10;
            this.lblCustomerNotSync.Text = "Bạn có ...... khách hàng chưa đồng bộ";
            // 
            // lblOrderNotSync
            // 
            this.lblOrderNotSync.AutoSize = true;
            this.lblOrderNotSync.Location = new System.Drawing.Point(12, 176);
            this.lblOrderNotSync.Name = "lblOrderNotSync";
            this.lblOrderNotSync.Size = new System.Drawing.Size(231, 20);
            this.lblOrderNotSync.TabIndex = 9;
            this.lblOrderNotSync.Text = "Bạn có ...... phiếu chưa đồng bộ";
            // 
            // txtPasswordServerSync
            // 
            this.txtPasswordServerSync.Location = new System.Drawing.Point(105, 126);
            this.txtPasswordServerSync.Name = "txtPasswordServerSync";
            this.txtPasswordServerSync.PasswordChar = '*';
            this.txtPasswordServerSync.Size = new System.Drawing.Size(191, 26);
            this.txtPasswordServerSync.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username:";
            // 
            // txtUserNameServerSync
            // 
            this.txtUserNameServerSync.Location = new System.Drawing.Point(105, 87);
            this.txtUserNameServerSync.Name = "txtUserNameServerSync";
            this.txtUserNameServerSync.Size = new System.Drawing.Size(191, 26);
            this.txtUserNameServerSync.TabIndex = 5;
            // 
            // txtPathServer
            // 
            this.txtPathServer.Location = new System.Drawing.Point(10, 45);
            this.txtPathServer.Name = "txtPathServer";
            this.txtPathServer.Size = new System.Drawing.Size(405, 26);
            this.txtPathServer.TabIndex = 4;
            // 
            // btnSyncOrder
            // 
            this.btnSyncOrder.Location = new System.Drawing.Point(16, 261);
            this.btnSyncOrder.Name = "btnSyncOrder";
            this.btnSyncOrder.Size = new System.Drawing.Size(144, 47);
            this.btnSyncOrder.TabIndex = 2;
            this.btnSyncOrder.Text = "Đồng bộ phiếu";
            this.btnSyncOrder.UseVisualStyleBackColor = true;
            this.btnSyncOrder.Click += new System.EventHandler(this.btnSyncOrder_Click);
            // 
            // btnTryConnect
            // 
            this.btnTryConnect.Location = new System.Drawing.Point(302, 105);
            this.btnTryConnect.Name = "btnTryConnect";
            this.btnTryConnect.Size = new System.Drawing.Size(113, 47);
            this.btnTryConnect.TabIndex = 1;
            this.btnTryConnect.Text = "Thử kết nối";
            this.btnTryConnect.UseVisualStyleBackColor = true;
            this.btnTryConnect.Click += new System.EventHandler(this.btnTryConnect_Click);
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
            // btnExportCustomer
            // 
            this.btnExportCustomer.Location = new System.Drawing.Point(229, 73);
            this.btnExportCustomer.Name = "btnExportCustomer";
            this.btnExportCustomer.Size = new System.Drawing.Size(157, 33);
            this.btnExportCustomer.TabIndex = 25;
            this.btnExportCustomer.Text = "Xuất dữ liệu KH";
            this.btnExportCustomer.UseVisualStyleBackColor = true;
            this.btnExportCustomer.Click += new System.EventHandler(this.btnExportCustomer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExportBillDetail);
            this.groupBox3.Controls.Add(this.btnBrowsePathCustomer);
            this.groupBox3.Controls.Add(this.btnExportBill);
            this.groupBox3.Controls.Add(this.txtPathJsonKH);
            this.groupBox3.Controls.Add(this.btnExportCustomer);
            this.groupBox3.Controls.Add(this.btnImportCustomer);
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 119);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // btnExportBillDetail
            // 
            this.btnExportBillDetail.Location = new System.Drawing.Point(10, 88);
            this.btnExportBillDetail.Name = "btnExportBillDetail";
            this.btnExportBillDetail.Size = new System.Drawing.Size(150, 25);
            this.btnExportBillDetail.TabIndex = 28;
            this.btnExportBillDetail.Text = "Xuất chi tiết phiếu";
            this.btnExportBillDetail.UseVisualStyleBackColor = true;
            this.btnExportBillDetail.Visible = false;
            this.btnExportBillDetail.Click += new System.EventHandler(this.btnExportBillDetail_Click);
            // 
            // btnBrowsePathCustomer
            // 
            this.btnBrowsePathCustomer.Location = new System.Drawing.Point(194, 25);
            this.btnBrowsePathCustomer.Name = "btnBrowsePathCustomer";
            this.btnBrowsePathCustomer.Size = new System.Drawing.Size(29, 26);
            this.btnBrowsePathCustomer.TabIndex = 20;
            this.btnBrowsePathCustomer.Text = "...";
            this.btnBrowsePathCustomer.UseVisualStyleBackColor = true;
            this.btnBrowsePathCustomer.Click += new System.EventHandler(this.btnBrowsePathCustomer_Click);
            // 
            // btnExportBill
            // 
            this.btnExportBill.Location = new System.Drawing.Point(10, 59);
            this.btnExportBill.Name = "btnExportBill";
            this.btnExportBill.Size = new System.Drawing.Size(98, 25);
            this.btnExportBill.TabIndex = 27;
            this.btnExportBill.Text = "Xuất phiếu";
            this.btnExportBill.UseVisualStyleBackColor = true;
            this.btnExportBill.Visible = false;
            this.btnExportBill.Click += new System.EventHandler(this.btnExportBill_Click);
            // 
            // txtPathJsonKH
            // 
            this.txtPathJsonKH.Location = new System.Drawing.Point(10, 25);
            this.txtPathJsonKH.Name = "txtPathJsonKH";
            this.txtPathJsonKH.ReadOnly = true;
            this.txtPathJsonKH.Size = new System.Drawing.Size(178, 26);
            this.txtPathJsonKH.TabIndex = 27;
            // 
            // btnImportCustomer
            // 
            this.btnImportCustomer.Location = new System.Drawing.Point(229, 25);
            this.btnImportCustomer.Name = "btnImportCustomer";
            this.btnImportCustomer.Size = new System.Drawing.Size(157, 33);
            this.btnImportCustomer.TabIndex = 26;
            this.btnImportCustomer.Text = "Nhập dữ liệu KH";
            this.btnImportCustomer.UseVisualStyleBackColor = true;
            this.btnImportCustomer.Click += new System.EventHandler(this.btnImportCustomer_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pgbProgress.Location = new System.Drawing.Point(12, 364);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(553, 23);
            this.pgbProgress.TabIndex = 28;
            this.pgbProgress.Visible = false;
            // 
            // bgwSyncOrders
            // 
            this.bgwSyncOrders.WorkerReportsProgress = true;
            this.bgwSyncOrders.WorkerSupportsCancellation = true;
            this.bgwSyncOrders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSyncOrders_DoWork);
            this.bgwSyncOrders.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSyncOrders_ProgressChanged);
            this.bgwSyncOrders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSyncOrders_RunWorkerCompleted);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(18, 340);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(89, 20);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.Text = "lblMessage";
            // 
            // bgwSyncCustomers
            // 
            this.bgwSyncCustomers.WorkerReportsProgress = true;
            this.bgwSyncCustomers.WorkerSupportsCancellation = true;
            this.bgwSyncCustomers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSyncCustomers_DoWork);
            this.bgwSyncCustomers.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSyncCustomers_ProgressChanged);
            this.bgwSyncCustomers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSyncCustomers_RunWorkerCompleted);
            // 
            // bgwImportCustomers
            // 
            this.bgwImportCustomers.WorkerReportsProgress = true;
            this.bgwImportCustomers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwImportCustomers_DoWork);
            this.bgwImportCustomers.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwImportCustomers_ProgressChanged);
            this.bgwImportCustomers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwImportCustomers_RunWorkerCompleted);
            // 
            // bgwGetSyncInfo
            // 
            this.bgwGetSyncInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetSyncInfo_DoWork);
            this.bgwGetSyncInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetSyncInfo_RunWorkerCompleted);
            // 
            // frmBackUpDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 405);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuuCauHinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackUpDuLieu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back up dữ liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackUpDuLieu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPathServer;
        private System.Windows.Forms.Button btnSyncOrder;
        private System.Windows.Forms.Button btnTryConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExportCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowsePathCustomer;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.TextBox txtPathJsonKH;
        private System.Windows.Forms.Button btnImportCustomer;
        private System.Windows.Forms.Button btnExportBill;
        private System.Windows.Forms.Button btnExportBillDetail;
        private System.Windows.Forms.Button btnSyncCustomer;
        private System.Windows.Forms.Label lblCustomerNotSync;
        private System.Windows.Forms.Label lblOrderNotSync;
        private System.Windows.Forms.TextBox txtPasswordServerSync;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserNameServerSync;
        private System.ComponentModel.BackgroundWorker bgwSyncOrders;
        private System.Windows.Forms.Label lblMessage;
        private System.ComponentModel.BackgroundWorker bgwSyncCustomers;
        private System.ComponentModel.BackgroundWorker bgwImportCustomers;
        private System.ComponentModel.BackgroundWorker bgwGetSyncInfo;
    }
}