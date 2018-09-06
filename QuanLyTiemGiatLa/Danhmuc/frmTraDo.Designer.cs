namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmTraDo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraDo));
			this.dgvDSCatDo = new System.Windows.Forms.DataGridView();
			this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maKieuGiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maHienThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaVach = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoHieuSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKieuGiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.khoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.daTraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiDiemLuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bndsrcDSCatDo = new System.Windows.Forms.BindingSource(this.components);
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnTraHetDo = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.traHetDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lapPhieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLapPhieu = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSCatDo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSCatDo)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDSCatDo
			// 
			this.dgvDSCatDo.AllowUserToAddRows = false;
			this.dgvDSCatDo.AllowUserToDeleteRows = false;
			this.dgvDSCatDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDSCatDo.AutoGenerateColumns = false;
			this.dgvDSCatDo.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDSCatDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSCatDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.maKieuGiatDataGridViewTextBoxColumn,
            this.maHienThiDataGridViewTextBoxColumn,
            this.MaVach,
            this.tenHangDataGridViewTextBoxColumn,
            this.SoHieuSanPham,
            this.tenKieuGiatDataGridViewTextBoxColumn,
            this.khoDataGridViewTextBoxColumn,
            this.slotDataGridViewTextBoxColumn,
            this.daTraDataGridViewCheckBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.ThoiDiemLuu,
            this.NgayTraDataGridViewTextBoxColumn});
			this.dgvDSCatDo.DataSource = this.bndsrcDSCatDo;
			this.dgvDSCatDo.Location = new System.Drawing.Point(1, 2);
			this.dgvDSCatDo.Name = "dgvDSCatDo";
			this.dgvDSCatDo.RowHeadersWidth = 30;
			this.dgvDSCatDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvDSCatDo.Size = new System.Drawing.Size(952, 256);
			this.dgvDSCatDo.TabIndex = 0;
			this.dgvDSCatDo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCatDo_CellDoubleClick);
			// 
			// maPhieuDataGridViewTextBoxColumn
			// 
			this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
			this.maPhieuDataGridViewTextBoxColumn.HeaderText = "MaPhieu";
			this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
			this.maPhieuDataGridViewTextBoxColumn.Visible = false;
			// 
			// sTTDataGridViewTextBoxColumn
			// 
			this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
			this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
			this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
			this.sTTDataGridViewTextBoxColumn.Visible = false;
			// 
			// maHangDataGridViewTextBoxColumn
			// 
			this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
			this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
			this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
			this.maHangDataGridViewTextBoxColumn.Visible = false;
			this.maHangDataGridViewTextBoxColumn.Width = 90;
			// 
			// maKieuGiatDataGridViewTextBoxColumn
			// 
			this.maKieuGiatDataGridViewTextBoxColumn.DataPropertyName = "MaKieuGiat";
			this.maKieuGiatDataGridViewTextBoxColumn.HeaderText = "MaKieuGiat";
			this.maKieuGiatDataGridViewTextBoxColumn.Name = "maKieuGiatDataGridViewTextBoxColumn";
			this.maKieuGiatDataGridViewTextBoxColumn.Visible = false;
			// 
			// maHienThiDataGridViewTextBoxColumn
			// 
			this.maHienThiDataGridViewTextBoxColumn.DataPropertyName = "MaHienThi";
			this.maHienThiDataGridViewTextBoxColumn.HeaderText = "Mã đồ";
			this.maHienThiDataGridViewTextBoxColumn.Name = "maHienThiDataGridViewTextBoxColumn";
			this.maHienThiDataGridViewTextBoxColumn.ReadOnly = true;
			this.maHienThiDataGridViewTextBoxColumn.Width = 90;
			// 
			// MaVach
			// 
			this.MaVach.DataPropertyName = "MaVach";
			this.MaVach.HeaderText = "Mã vạch";
			this.MaVach.Name = "MaVach";
			this.MaVach.ReadOnly = true;
			this.MaVach.Width = 90;
			// 
			// tenHangDataGridViewTextBoxColumn
			// 
			this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
			this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên đồ";
			this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
			this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// SoHieuSanPham
			// 
			this.SoHieuSanPham.DataPropertyName = "SoHieuSanPham";
			this.SoHieuSanPham.HeaderText = "SHSP";
			this.SoHieuSanPham.Name = "SoHieuSanPham";
			this.SoHieuSanPham.Width = 50;
			// 
			// tenKieuGiatDataGridViewTextBoxColumn
			// 
			this.tenKieuGiatDataGridViewTextBoxColumn.DataPropertyName = "TenKieuGiat";
			this.tenKieuGiatDataGridViewTextBoxColumn.HeaderText = "Kiểu giặt";
			this.tenKieuGiatDataGridViewTextBoxColumn.Name = "tenKieuGiatDataGridViewTextBoxColumn";
			this.tenKieuGiatDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenKieuGiatDataGridViewTextBoxColumn.Width = 87;
			// 
			// khoDataGridViewTextBoxColumn
			// 
			this.khoDataGridViewTextBoxColumn.DataPropertyName = "Kho";
			this.khoDataGridViewTextBoxColumn.HeaderText = "Kho";
			this.khoDataGridViewTextBoxColumn.Name = "khoDataGridViewTextBoxColumn";
			this.khoDataGridViewTextBoxColumn.Width = 50;
			// 
			// slotDataGridViewTextBoxColumn
			// 
			this.slotDataGridViewTextBoxColumn.DataPropertyName = "Slot";
			this.slotDataGridViewTextBoxColumn.HeaderText = "Slot";
			this.slotDataGridViewTextBoxColumn.Name = "slotDataGridViewTextBoxColumn";
			this.slotDataGridViewTextBoxColumn.Width = 60;
			// 
			// daTraDataGridViewCheckBoxColumn
			// 
			this.daTraDataGridViewCheckBoxColumn.DataPropertyName = "DaTra";
			this.daTraDataGridViewCheckBoxColumn.HeaderText = "Đã trả";
			this.daTraDataGridViewCheckBoxColumn.Name = "daTraDataGridViewCheckBoxColumn";
			this.daTraDataGridViewCheckBoxColumn.Width = 60;
			// 
			// ghiChuDataGridViewTextBoxColumn
			// 
			this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
			this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
			this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
			this.ghiChuDataGridViewTextBoxColumn.Width = 200;
			// 
			// ThoiDiemLuu
			// 
			this.ThoiDiemLuu.DataPropertyName = "ThoiDiemLuu";
			this.ThoiDiemLuu.HeaderText = "Tg lưu";
			this.ThoiDiemLuu.Name = "ThoiDiemLuu";
			this.ThoiDiemLuu.ReadOnly = true;
			this.ThoiDiemLuu.Width = 95;
			// 
			// NgayTraDataGridViewTextBoxColumn
			// 
			this.NgayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
			this.NgayTraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
			this.NgayTraDataGridViewTextBoxColumn.Name = "NgayTraDataGridViewTextBoxColumn";
			this.NgayTraDataGridViewTextBoxColumn.Width = 150;
			// 
			// bndsrcDSCatDo
			// 
			this.bndsrcDSCatDo.DataSource = typeof(Entity.ListPhieuSlotEntity);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(853, 264);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(89, 52);
			this.btnThoat.TabIndex = 10;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnTraHetDo
			// 
			this.btnTraHetDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTraHetDo.Image = global::QuanLyTiemGiatLa.Properties.Resources.goleft;
			this.btnTraHetDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTraHetDo.Location = new System.Drawing.Point(12, 264);
			this.btnTraHetDo.Name = "btnTraHetDo";
			this.btnTraHetDo.Size = new System.Drawing.Size(168, 52);
			this.btnTraHetDo.TabIndex = 11;
			this.btnTraHetDo.Text = "T&rả hết đồ (F1)";
			this.btnTraHetDo.UseVisualStyleBackColor = true;
			this.btnTraHetDo.Click += new System.EventHandler(this.btnTraHetDo_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(740, 264);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(107, 52);
			this.btnGhi.TabIndex = 9;
			this.btnGhi.Text = "&Ghi (F4)";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(382, 281);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(143, 20);
			this.lblMessage.TabIndex = 12;
			this.lblMessage.Text = "Chưa thanh toán";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traHetDoToolStripMenuItem,
            this.ghiToolStripMenuItem,
            this.lapPhieuToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(178, 82);
			// 
			// traHetDoToolStripMenuItem
			// 
			this.traHetDoToolStripMenuItem.Name = "traHetDoToolStripMenuItem";
			this.traHetDoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.traHetDoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
			this.traHetDoToolStripMenuItem.Text = "Tra het do";
			this.traHetDoToolStripMenuItem.Visible = false;
			this.traHetDoToolStripMenuItem.Click += new System.EventHandler(this.traHetDoToolStripMenuItem_Click);
			// 
			// ghiToolStripMenuItem
			// 
			this.ghiToolStripMenuItem.Name = "ghiToolStripMenuItem";
			this.ghiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.ghiToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
			this.ghiToolStripMenuItem.Text = "Ghi";
			this.ghiToolStripMenuItem.Visible = false;
			this.ghiToolStripMenuItem.Click += new System.EventHandler(this.ghiToolStripMenuItem_Click);
			// 
			// lapPhieuToolStripMenuItem
			// 
			this.lapPhieuToolStripMenuItem.Name = "lapPhieuToolStripMenuItem";
			this.lapPhieuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.lapPhieuToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
			this.lapPhieuToolStripMenuItem.Text = "Lập phiếu";
			this.lapPhieuToolStripMenuItem.Visible = false;
			this.lapPhieuToolStripMenuItem.Click += new System.EventHandler(this.lapPhieuToolStripMenuItem_Click);
			// 
			// btnLapPhieu
			// 
			this.btnLapPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLapPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLapPhieu.Location = new System.Drawing.Point(186, 264);
			this.btnLapPhieu.Name = "btnLapPhieu";
			this.btnLapPhieu.Size = new System.Drawing.Size(115, 52);
			this.btnLapPhieu.TabIndex = 11;
			this.btnLapPhieu.Text = "&Lập phiếu (F3)";
			this.btnLapPhieu.UseVisualStyleBackColor = true;
			this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
			// 
			// frmTraDo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(954, 319);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.btnTraHetDo);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnLapPhieu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.dgvDSCatDo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmTraDo";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cất đồ đã giặt";
			((System.ComponentModel.ISupportInitialize)(this.dgvDSCatDo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSCatDo)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDSCatDo;
		private System.Windows.Forms.BindingSource bndsrcDSCatDo;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnTraHetDo;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem traHetDoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ghiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lapPhieuToolStripMenuItem;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKieuGiatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHienThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHieuSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKieuGiatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn daTraDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiemLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraDataGridViewTextBoxColumn;
	}
}