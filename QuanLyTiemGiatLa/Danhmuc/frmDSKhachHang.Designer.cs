namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmDSKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSKhachHang));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bndsrcDSKhachHang = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCollapse = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSearchAgain = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
			this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chkTatCa = new System.Windows.Forms.CheckBox();
			this.chkTimGanDung = new System.Windows.Forms.CheckBox();
			this.txtSoTheVip = new System.Windows.Forms.TextBox();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTenKhachHang = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDSKhachHang = new System.Windows.Forms.DataGridView();
			this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DaTungThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoTheVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenVip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKhachHang)).BeginInit();
			this.panel1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(114, 98);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.thêmToolStripMenuItem.Text = "Thêm";
			this.thêmToolStripMenuItem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// sửaToolStripMenuItem
			// 
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.sửaToolStripMenuItem.Text = "Sửa";
			this.sửaToolStripMenuItem.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// xóaToolStripMenuItem
			// 
			this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
			this.xóaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.xóaToolStripMenuItem.Text = "Xóa";
			this.xóaToolStripMenuItem.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.frmDSKhachHang_Load);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.bndsrcDSKhachHang;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.CountItemFormat = "trong tổng số {0}";
			this.bindingNavigator1.DeleteItem = null;
			this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(759, 25);
			this.bindingNavigator1.TabIndex = 0;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bndsrcDSKhachHang
			// 
			this.bndsrcDSKhachHang.DataSource = typeof(Entity.ListKhachHangEntity);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(108, 22);
			this.bindingNavigatorCountItem.Text = "trong tổng số {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCollapse);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 470);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(759, 88);
			this.panel1.TabIndex = 2;
			// 
			// btnCollapse
			// 
			this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCollapse.Location = new System.Drawing.Point(12, 18);
			this.btnCollapse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCollapse.Name = "btnCollapse";
			this.btnCollapse.Size = new System.Drawing.Size(60, 53);
			this.btnCollapse.TabIndex = 0;
			this.btnCollapse.Text = "<<";
			this.btnCollapse.UseVisualStyleBackColor = true;
			this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(673, 18);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(72, 53);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Image = global::QuanLyTiemGiatLa.Properties.Resources.b_drop;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.Location = new System.Drawing.Point(598, 18);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(67, 53);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "&Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Image = global::QuanLyTiemGiatLa.Properties.Resources._new;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.Location = new System.Drawing.Point(520, 18);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(70, 53);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "&Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::QuanLyTiemGiatLa.Properties.Resources._11;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.Location = new System.Drawing.Point(437, 18);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 53);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thê&m";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel1.Controls.Add(this.btnSearchAgain);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvDSKhachHang);
			this.splitContainer1.Panel2.Controls.Add(this.bindingNavigator1);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(984, 562);
			this.splitContainer1.SplitterDistance = 217;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Image = global::QuanLyTiemGiatLa.Properties.Resources.search_4824;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.Location = new System.Drawing.Point(118, 349);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(92, 53);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnSearchAgain
			// 
			this.btnSearchAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearchAgain.Image = global::QuanLyTiemGiatLa.Properties.Resources._271;
			this.btnSearchAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchAgain.Location = new System.Drawing.Point(31, 349);
			this.btnSearchAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearchAgain.Name = "btnSearchAgain";
			this.btnSearchAgain.Size = new System.Drawing.Size(80, 53);
			this.btnSearchAgain.TabIndex = 2;
			this.btnSearchAgain.Text = "Tìm &lại    ";
			this.btnSearchAgain.UseVisualStyleBackColor = true;
			this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpTuNgay);
			this.groupBox1.Controls.Add(this.dtpDenNgay);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.chkTatCa);
			this.groupBox1.Controls.Add(this.chkTimGanDung);
			this.groupBox1.Controls.Add(this.txtSoTheVip);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTenKhachHang);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(213, 345);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// dtpTuNgay
			// 
			this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTuNgay.Location = new System.Drawing.Point(13, 233);
			this.dtpTuNgay.Name = "dtpTuNgay";
			this.dtpTuNgay.Size = new System.Drawing.Size(193, 24);
			this.dtpTuNgay.TabIndex = 4;
			// 
			// dtpDenNgay
			// 
			this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDenNgay.Location = new System.Drawing.Point(13, 290);
			this.dtpDenNgay.Name = "dtpDenNgay";
			this.dtpDenNgay.Size = new System.Drawing.Size(193, 24);
			this.dtpDenNgay.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Đến ngày:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Từ ngày:";
			// 
			// chkTatCa
			// 
			this.chkTatCa.AutoSize = true;
			this.chkTatCa.Location = new System.Drawing.Point(13, 319);
			this.chkTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTatCa.Name = "chkTatCa";
			this.chkTatCa.Size = new System.Drawing.Size(68, 22);
			this.chkTatCa.TabIndex = 6;
			this.chkTatCa.Text = "Tất cả";
			this.chkTatCa.UseVisualStyleBackColor = true;
			this.chkTatCa.CheckedChanged += new System.EventHandler(this.chkTatCa_CheckedChanged);
			this.chkTatCa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTimGanDung_KeyDown);
			// 
			// chkTimGanDung
			// 
			this.chkTimGanDung.AutoSize = true;
			this.chkTimGanDung.Checked = true;
			this.chkTimGanDung.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTimGanDung.Location = new System.Drawing.Point(14, 173);
			this.chkTimGanDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTimGanDung.Name = "chkTimGanDung";
			this.chkTimGanDung.Size = new System.Drawing.Size(116, 22);
			this.chkTimGanDung.TabIndex = 3;
			this.chkTimGanDung.Text = "Tìm gần đúng";
			this.chkTimGanDung.UseVisualStyleBackColor = true;
			this.chkTimGanDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTimGanDung_KeyDown);
			// 
			// txtSoTheVip
			// 
			this.txtSoTheVip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoTheVip.Location = new System.Drawing.Point(14, 145);
			this.txtSoTheVip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSoTheVip.Name = "txtSoTheVip";
			this.txtSoTheVip.Size = new System.Drawing.Size(193, 24);
			this.txtSoTheVip.TabIndex = 2;
			this.txtSoTheVip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDienThoai_KeyDown);
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDienThoai.Location = new System.Drawing.Point(15, 91);
			this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(193, 24);
			this.txtDienThoai.TabIndex = 1;
			this.txtDienThoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDienThoai_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Số thẻ VIP:";
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTenKhachHang.Location = new System.Drawing.Point(15, 44);
			this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(193, 24);
			this.txtTenKhachHang.TabIndex = 0;
			this.txtTenKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenKhachHang_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Điện thoại:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên khách hàng:";
			// 
			// dgvDSKhachHang
			// 
			this.dgvDSKhachHang.AllowUserToAddRows = false;
			this.dgvDSKhachHang.AllowUserToDeleteRows = false;
			this.dgvDSKhachHang.AutoGenerateColumns = false;
			this.dgvDSKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.DaTungThanhToan,
            this.SoTheVip,
            this.TenVip});
			this.dgvDSKhachHang.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvDSKhachHang.DataSource = this.bndsrcDSKhachHang;
			this.dgvDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSKhachHang.Location = new System.Drawing.Point(0, 25);
			this.dgvDSKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDSKhachHang.MultiSelect = false;
			this.dgvDSKhachHang.Name = "dgvDSKhachHang";
			this.dgvDSKhachHang.ReadOnly = true;
			this.dgvDSKhachHang.RowHeadersWidth = 20;
			this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSKhachHang.Size = new System.Drawing.Size(759, 445);
			this.dgvDSKhachHang.TabIndex = 1;
			this.dgvDSKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhachHang_CellDoubleClick);
			// 
			// maKhachHangDataGridViewTextBoxColumn
			// 
			this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
			this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
			this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
			this.maKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
			this.maKhachHangDataGridViewTextBoxColumn.Visible = false;
			// 
			// tenKhachHangDataGridViewTextBoxColumn
			// 
			this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
			this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
			this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
			this.tenKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenKhachHangDataGridViewTextBoxColumn.Width = 150;
			// 
			// dienThoaiDataGridViewTextBoxColumn
			// 
			this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
			this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
			this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
			this.dienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
			this.dienThoaiDataGridViewTextBoxColumn.Width = 120;
			// 
			// diaChiDataGridViewTextBoxColumn
			// 
			this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
			this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
			this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
			this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
			this.diaChiDataGridViewTextBoxColumn.Width = 130;
			// 
			// DaTungThanhToan
			// 
			this.DaTungThanhToan.DataPropertyName = "DaTungThanhToan";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
			dataGridViewCellStyle1.Format = "N0";
			this.DaTungThanhToan.DefaultCellStyle = dataGridViewCellStyle1;
			this.DaTungThanhToan.HeaderText = "Đã thanh toán";
			this.DaTungThanhToan.Name = "DaTungThanhToan";
			this.DaTungThanhToan.ReadOnly = true;
			this.DaTungThanhToan.Width = 130;
			// 
			// SoTheVip
			// 
			this.SoTheVip.DataPropertyName = "SoTheVip";
			this.SoTheVip.HeaderText = "Số thẻ VIP";
			this.SoTheVip.Name = "SoTheVip";
			this.SoTheVip.ReadOnly = true;
			// 
			// TenVip
			// 
			this.TenVip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenVip.DataPropertyName = "TenVip";
			this.TenVip.HeaderText = "Mức độ VIP";
			this.TenVip.Name = "TenVip";
			this.TenVip.ReadOnly = true;
			// 
			// frmDSKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(984, 562);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDSKhachHang";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách khách hàng";
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKhachHang)).EndInit();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource bndsrcDSKhachHang;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnCollapse;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.TextBox txtTenKhachHang;
		private System.Windows.Forms.CheckBox chkTimGanDung;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnSearchAgain;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvDSKhachHang;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkTatCa;
		private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DaTungThanhToan;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoTheVip;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenVip;
		private System.Windows.Forms.TextBox txtSoTheVip;
		private System.Windows.Forms.Label label5;
	}
}