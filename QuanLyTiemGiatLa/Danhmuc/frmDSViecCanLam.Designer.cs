namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmDSViecCanLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSViecCanLam));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDo = new System.Windows.Forms.TextBox();
            this.txtMaVach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTatcaDo = new System.Windows.Forms.CheckBox();
            this.chkTatca = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiemLuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndsrcDSViecCanLam = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongSoSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemPhieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCatDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcDSViecCanLam)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDSCatDo);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1134, 531);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::QuanLyTiemGiatLa.Properties.Resources.search_4824;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(58, 325);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tì&m";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenDo);
            this.groupBox1.Controls.Add(this.txtMaVach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkTatcaDo);
            this.groupBox1.Controls.Add(this.chkTatca);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTenDo
            // 
            this.txtTenDo.Location = new System.Drawing.Point(2, 296);
            this.txtTenDo.Name = "txtTenDo";
            this.txtTenDo.Size = new System.Drawing.Size(143, 24);
            this.txtTenDo.TabIndex = 1;
            // 
            // txtMaVach
            // 
            this.txtMaVach.Location = new System.Drawing.Point(2, 249);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(143, 24);
            this.txtMaVach.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên đồ:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(2, 202);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(143, 24);
            this.txtMaPhieu.TabIndex = 0;
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã vạch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phiếu:";
            // 
            // chkTatcaDo
            // 
            this.chkTatcaDo.AutoSize = true;
            this.chkTatcaDo.Location = new System.Drawing.Point(0, 151);
            this.chkTatcaDo.Name = "chkTatcaDo";
            this.chkTatcaDo.Size = new System.Drawing.Size(128, 22);
            this.chkTatcaDo.TabIndex = 5;
            this.chkTatcaDo.Text = "Tất cả thông tin";
            this.chkTatcaDo.UseVisualStyleBackColor = true;
            // 
            // chkTatca
            // 
            this.chkTatca.AutoSize = true;
            this.chkTatca.Location = new System.Drawing.Point(0, 124);
            this.chkTatca.Name = "chkTatca";
            this.chkTatca.Size = new System.Drawing.Size(144, 22);
            this.chkTatca.TabIndex = 4;
            this.chkTatca.Text = "Tất cả đồ cần giặt";
            this.chkTatca.UseVisualStyleBackColor = true;
            this.chkTatca.CheckedChanged += new System.EventHandler(this.chkTatca_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(2, 95);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(136, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(2, 40);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(136, 24);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // dgvDSCatDo
            // 
            this.dgvDSCatDo.AllowUserToAddRows = false;
            this.dgvDSCatDo.AllowUserToDeleteRows = false;
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
            this.ghichuDataGridViewTextBoxColumn,
            this.ThoiDiemLuu,
            this.NgayTraDataGridViewTextBoxColumn});
            this.dgvDSCatDo.DataSource = this.bndsrcDSViecCanLam;
            this.dgvDSCatDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCatDo.Location = new System.Drawing.Point(0, 0);
            this.dgvDSCatDo.Name = "dgvDSCatDo";
            this.dgvDSCatDo.RowHeadersWidth = 24;
            this.dgvDSCatDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDSCatDo.Size = new System.Drawing.Size(971, 462);
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
            this.maHienThiDataGridViewTextBoxColumn.Width = 80;
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
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.Width = 200;
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
            this.NgayTraDataGridViewTextBoxColumn.Width = 130;
            // 
            // bndsrcDSViecCanLam
            // 
            this.bndsrcDSViecCanLam.DataSource = typeof(Entity.ListPhieuSlotEntity);
            this.bndsrcDSViecCanLam.DataMemberChanged += new System.EventHandler(this.bndsrcDSViecCanLam_DataMemberChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTongSoSanPham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhi);
            this.panel1.Controls.Add(this.btnXemPhieu);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 65);
            this.panel1.TabIndex = 1;
            // 
            // txtTongSoSanPham
            // 
            this.txtTongSoSanPham.Location = new System.Drawing.Point(348, 20);
            this.txtTongSoSanPham.Name = "txtTongSoSanPham";
            this.txtTongSoSanPham.ReadOnly = true;
            this.txtTongSoSanPham.Size = new System.Drawing.Size(122, 24);
            this.txtTongSoSanPham.TabIndex = 4;
            this.txtTongSoSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng số sản phẩm:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(872, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 52);
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
            this.btnGhi.Location = new System.Drawing.Point(761, 6);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(105, 52);
            this.btnGhi.TabIndex = 1;
            this.btnGhi.Text = "&Ghi (F4)";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemPhieu.Location = new System.Drawing.Point(78, 6);
            this.btnXemPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(98, 50);
            this.btnXemPhieu.TabIndex = 0;
            this.btnXemPhieu.Text = "&Xem phiếu (F1)";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollapse.Location = new System.Drawing.Point(3, 6);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(69, 50);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.Text = "<<";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemPhieuToolStripMenuItem,
            this.ghiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 56);
            // 
            // xemPhieuToolStripMenuItem
            // 
            this.xemPhieuToolStripMenuItem.Name = "xemPhieuToolStripMenuItem";
            this.xemPhieuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.xemPhieuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xemPhieuToolStripMenuItem.Text = "Xem phieu";
            this.xemPhieuToolStripMenuItem.Click += new System.EventHandler(this.xemPhieuToolStripMenuItem_Click);
            // 
            // ghiToolStripMenuItem
            // 
            this.ghiToolStripMenuItem.Name = "ghiToolStripMenuItem";
            this.ghiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ghiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ghiToolStripMenuItem.Text = "Ghi";
            this.ghiToolStripMenuItem.Click += new System.EventHandler(this.ghiToolStripMenuItem_Click);
            // 
            // frmDSViecCanLam
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1134, 531);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSViecCanLam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách việc cần làm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCatDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcDSViecCanLam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnCollapse;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.DataGridView dgvDSCatDo;
		private System.Windows.Forms.BindingSource bndsrcDSViecCanLam;
		private System.Windows.Forms.CheckBox chkTatca;
		private System.Windows.Forms.CheckBox chkTatcaDo;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaVach;
		private System.Windows.Forms.TextBox txtMaPhieu;
		private System.Windows.Forms.Button btnXemPhieu;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem xemPhieuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ghiToolStripMenuItem;
		private System.Windows.Forms.TextBox txtTongSoSanPham;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTenDo;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiemLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraDataGridViewTextBoxColumn;
	}
}