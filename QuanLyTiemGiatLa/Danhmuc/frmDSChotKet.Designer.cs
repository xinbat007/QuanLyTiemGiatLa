namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmDSChotKet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSChotKet));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTatca = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvDSChotKet = new System.Windows.Forms.DataGridView();
            this.maChotKetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiChotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiemChot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienChotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndsrcDSChotKet = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDSPhieu = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaTraDo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPhieuHuy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiGiaoNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChotKet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChotKet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcDSChotKet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(994, 506);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::QuanLyTiemGiatLa.Properties.Resources._49;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(14, 158);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 48);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tì&m";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkTatca);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkTatca
            // 
            this.chkTatca.AutoSize = true;
            this.chkTatca.Location = new System.Drawing.Point(6, 129);
            this.chkTatca.Name = "chkTatca";
            this.chkTatca.Size = new System.Drawing.Size(68, 22);
            this.chkTatca.TabIndex = 2;
            this.chkTatca.Text = "Tất cả";
            this.chkTatca.UseVisualStyleBackColor = true;
            this.chkTatca.CheckedChanged += new System.EventHandler(this.chkTatca_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(6, 100);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(96, 24);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(6, 42);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(96, 24);
            this.dtpTuNgay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvDSChotKet);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvDSPhieu);
            this.splitContainer2.Size = new System.Drawing.Size(870, 444);
            this.splitContainer2.SplitterDistance = 154;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgvDSChotKet
            // 
            this.dgvDSChotKet.AllowUserToAddRows = false;
            this.dgvDSChotKet.AllowUserToDeleteRows = false;
            this.dgvDSChotKet.AutoGenerateColumns = false;
            this.dgvDSChotKet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSChotKet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChotKet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChotKetDataGridViewTextBoxColumn,
            this.nguoiChotDataGridViewTextBoxColumn,
            this.ThoiDiemChot,
            this.TuPhieu,
            this.DenPhieu,
            this.soTienChotDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvDSChotKet.DataSource = this.bndsrcDSChotKet;
            this.dgvDSChotKet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSChotKet.Location = new System.Drawing.Point(0, 0);
            this.dgvDSChotKet.Name = "dgvDSChotKet";
            this.dgvDSChotKet.ReadOnly = true;
            this.dgvDSChotKet.RowHeadersWidth = 20;
            this.dgvDSChotKet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSChotKet.Size = new System.Drawing.Size(866, 150);
            this.dgvDSChotKet.TabIndex = 1;
            // 
            // maChotKetDataGridViewTextBoxColumn
            // 
            this.maChotKetDataGridViewTextBoxColumn.DataPropertyName = "MaChotKet";
            this.maChotKetDataGridViewTextBoxColumn.HeaderText = "MaChotKet";
            this.maChotKetDataGridViewTextBoxColumn.Name = "maChotKetDataGridViewTextBoxColumn";
            this.maChotKetDataGridViewTextBoxColumn.ReadOnly = true;
            this.maChotKetDataGridViewTextBoxColumn.Visible = false;
            // 
            // nguoiChotDataGridViewTextBoxColumn
            // 
            this.nguoiChotDataGridViewTextBoxColumn.DataPropertyName = "NguoiChot";
            this.nguoiChotDataGridViewTextBoxColumn.HeaderText = "Người chốt";
            this.nguoiChotDataGridViewTextBoxColumn.Name = "nguoiChotDataGridViewTextBoxColumn";
            this.nguoiChotDataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiChotDataGridViewTextBoxColumn.Width = 110;
            // 
            // ThoiDiemChot
            // 
            this.ThoiDiemChot.DataPropertyName = "ThoiDiemChot";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.ThoiDiemChot.DefaultCellStyle = dataGridViewCellStyle1;
            this.ThoiDiemChot.HeaderText = "Thời điểm chốt";
            this.ThoiDiemChot.Name = "ThoiDiemChot";
            this.ThoiDiemChot.ReadOnly = true;
            this.ThoiDiemChot.Width = 150;
            // 
            // TuPhieu
            // 
            this.TuPhieu.DataPropertyName = "TuPhieu";
            this.TuPhieu.HeaderText = "Từ phiếu";
            this.TuPhieu.Name = "TuPhieu";
            this.TuPhieu.ReadOnly = true;
            // 
            // DenPhieu
            // 
            this.DenPhieu.DataPropertyName = "DenPhieu";
            this.DenPhieu.HeaderText = "Đến phiếu";
            this.DenPhieu.Name = "DenPhieu";
            this.DenPhieu.ReadOnly = true;
            this.DenPhieu.Width = 120;
            // 
            // soTienChotDataGridViewTextBoxColumn
            // 
            this.soTienChotDataGridViewTextBoxColumn.DataPropertyName = "SoTienChot";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "N0";
            this.soTienChotDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.soTienChotDataGridViewTextBoxColumn.HeaderText = "Số tiền chốt";
            this.soTienChotDataGridViewTextBoxColumn.Name = "soTienChotDataGridViewTextBoxColumn";
            this.soTienChotDataGridViewTextBoxColumn.ReadOnly = true;
            this.soTienChotDataGridViewTextBoxColumn.Width = 140;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bndsrcDSChotKet
            // 
            this.bndsrcDSChotKet.DataSource = typeof(Entity.ListChotKetEntity);
            this.bndsrcDSChotKet.CurrentChanged += new System.EventHandler(this.bndsrcDSChotKet_CurrentChanged);
            // 
            // dgvDSPhieu
            // 
            this.dgvDSPhieu.AllowUserToAddRows = false;
            this.dgvDSPhieu.AllowUserToDeleteRows = false;
            this.dgvDSPhieu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.MaKhachHang,
            this.MaPhieu,
            this.TenKhachHang,
            this.TongTien,
            this.DaThanhToan,
            this.DaTraDo,
            this.isPhieuHuy,
            this.GhiChu,
            this.GiamGia,
            this.PhiGiaoNhan,
            this.NgayLap,
            this.NgayHenTra});
            this.dgvDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhieu.Location = new System.Drawing.Point(0, 0);
            this.dgvDSPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSPhieu.Name = "dgvDSPhieu";
            this.dgvDSPhieu.ReadOnly = true;
            this.dgvDSPhieu.RowHeadersWidth = 20;
            this.dgvDSPhieu.Size = new System.Drawing.Size(866, 282);
            this.dgvDSPhieu.TabIndex = 1;
            this.dgvDSPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieu_CellDoubleClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Visible = false;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Visible = false;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Width = 70;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 115;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Format = "N0";
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongTien.HeaderText = "Tổng tiền (đã giảm)";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 95;
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.DataPropertyName = "DaThanhToan";
            this.DaThanhToan.HeaderText = "Đã thanh toán";
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.ReadOnly = true;
            this.DaThanhToan.Width = 50;
            // 
            // DaTraDo
            // 
            this.DaTraDo.DataPropertyName = "DaTraDo";
            this.DaTraDo.HeaderText = "Đã trả đồ";
            this.DaTraDo.Name = "DaTraDo";
            this.DaTraDo.ReadOnly = true;
            this.DaTraDo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaTraDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DaTraDo.Width = 50;
            // 
            // isPhieuHuy
            // 
            this.isPhieuHuy.DataPropertyName = "isPhieuHuy";
            this.isPhieuHuy.HeaderText = "Phiếu hủy";
            this.isPhieuHuy.Name = "isPhieuHuy";
            this.isPhieuHuy.ReadOnly = true;
            this.isPhieuHuy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPhieuHuy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isPhieuHuy.Width = 50;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.GiamGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            this.GiamGia.Width = 50;
            // 
            // PhiGiaoNhan
            // 
            this.PhiGiaoNhan.DataPropertyName = "PhiGiaoNhan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PhiGiaoNhan.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhiGiaoNhan.HeaderText = "Phí giao nhận";
            this.PhiGiaoNhan.Name = "PhiGiaoNhan";
            this.PhiGiaoNhan.ReadOnly = true;
            this.PhiGiaoNhan.Width = 50;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 90;
            // 
            // NgayHenTra
            // 
            this.NgayHenTra.DataPropertyName = "NgayHenTra";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.NgayHenTra.DefaultCellStyle = dataGridViewCellStyle7;
            this.NgayHenTra.HeaderText = "Ngày hẹn trả";
            this.NgayHenTra.Name = "NgayHenTra";
            this.NgayHenTra.ReadOnly = true;
            this.NgayHenTra.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChotKet);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnChotKet
            // 
            this.btnChotKet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChotKet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChotKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChotKet.Image = global::QuanLyTiemGiatLa.Properties.Resources.safe_ket;
            this.btnChotKet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChotKet.Location = new System.Drawing.Point(652, 6);
            this.btnChotKet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChotKet.Name = "btnChotKet";
            this.btnChotKet.Size = new System.Drawing.Size(110, 48);
            this.btnChotKet.TabIndex = 1;
            this.btnChotKet.Text = "&Chốt két";
            this.btnChotKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChotKet.UseVisualStyleBackColor = true;
            this.btnChotKet.Click += new System.EventHandler(this.btnChotKet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(770, 6);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 48);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollapse.Location = new System.Drawing.Point(3, 6);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(60, 48);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.Text = "<<";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // frmDSChotKet
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(994, 506);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSChotKet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chốt két";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChotKet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcDSChotKet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnCollapse;
		private System.Windows.Forms.BindingSource bndsrcDSChotKet;
		private System.Windows.Forms.DataGridView dgvDSChotKet;
		private System.Windows.Forms.CheckBox chkTatca;
		private System.Windows.Forms.Button btnChotKet;
		private System.Windows.Forms.DataGridViewTextBoxColumn maChotKetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nguoiChotDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiemChot;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuPhieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn DenPhieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn soTienChotDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dgvDSPhieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DaThanhToan;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DaTraDo;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isPhieuHuy;
		private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
		private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhiGiaoNhan;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayHenTra;
	}
}