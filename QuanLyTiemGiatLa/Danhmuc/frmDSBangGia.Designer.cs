namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmDSBangGia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSBangGia));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgvDSBangGia = new System.Windows.Forms.DataGridView();
			this.iDGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maKieuGiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKieuGiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bndsrcDSBangGia = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSBangGia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 433);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(676, 76);
			this.panel1.TabIndex = 2;
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::QuanLyTiemGiatLa.Properties.Resources._11;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.Location = new System.Drawing.Point(342, 10);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 53);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thê&m";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Image = global::QuanLyTiemGiatLa.Properties.Resources.b_drop;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.Location = new System.Drawing.Point(507, 10);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(68, 53);
			this.btnXoa.TabIndex = 2;
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
			this.btnSua.Location = new System.Drawing.Point(425, 10);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(74, 53);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "&Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(583, 10);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(80, 53);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dgvDSBangGia
			// 
			this.dgvDSBangGia.AllowUserToAddRows = false;
			this.dgvDSBangGia.AllowUserToDeleteRows = false;
			this.dgvDSBangGia.AutoGenerateColumns = false;
			this.dgvDSBangGia.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDSBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGiaDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.maKieuGiatDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.tenKieuGiatDataGridViewTextBoxColumn,
            this.SoSanPham,
            this.donGiaDataGridViewTextBoxColumn});
			this.dgvDSBangGia.DataSource = this.bndsrcDSBangGia;
			this.dgvDSBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSBangGia.Location = new System.Drawing.Point(0, 25);
			this.dgvDSBangGia.MultiSelect = false;
			this.dgvDSBangGia.Name = "dgvDSBangGia";
			this.dgvDSBangGia.ReadOnly = true;
			this.dgvDSBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSBangGia.Size = new System.Drawing.Size(676, 408);
			this.dgvDSBangGia.TabIndex = 1;
			this.dgvDSBangGia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBangGia_CellDoubleClick);
			// 
			// iDGiaDataGridViewTextBoxColumn
			// 
			this.iDGiaDataGridViewTextBoxColumn.DataPropertyName = "IDGia";
			this.iDGiaDataGridViewTextBoxColumn.HeaderText = "IDGia";
			this.iDGiaDataGridViewTextBoxColumn.Name = "iDGiaDataGridViewTextBoxColumn";
			this.iDGiaDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDGiaDataGridViewTextBoxColumn.Visible = false;
			// 
			// maHangDataGridViewTextBoxColumn
			// 
			this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
			this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
			this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
			this.maHangDataGridViewTextBoxColumn.ReadOnly = true;
			this.maHangDataGridViewTextBoxColumn.Visible = false;
			// 
			// maKieuGiatDataGridViewTextBoxColumn
			// 
			this.maKieuGiatDataGridViewTextBoxColumn.DataPropertyName = "MaKieuGiat";
			this.maKieuGiatDataGridViewTextBoxColumn.HeaderText = "MaKieuGiat";
			this.maKieuGiatDataGridViewTextBoxColumn.Name = "maKieuGiatDataGridViewTextBoxColumn";
			this.maKieuGiatDataGridViewTextBoxColumn.ReadOnly = true;
			this.maKieuGiatDataGridViewTextBoxColumn.Visible = false;
			// 
			// tenHangDataGridViewTextBoxColumn
			// 
			this.tenHangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
			this.tenHangDataGridViewTextBoxColumn.HeaderText = "Tên đồ";
			this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
			this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tenKieuGiatDataGridViewTextBoxColumn
			// 
			this.tenKieuGiatDataGridViewTextBoxColumn.DataPropertyName = "TenKieuGiat";
			this.tenKieuGiatDataGridViewTextBoxColumn.HeaderText = "Kiểu giặt";
			this.tenKieuGiatDataGridViewTextBoxColumn.Name = "tenKieuGiatDataGridViewTextBoxColumn";
			this.tenKieuGiatDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenKieuGiatDataGridViewTextBoxColumn.Width = 120;
			// 
			// SoSanPham
			// 
			this.SoSanPham.DataPropertyName = "SoSanPham";
			this.SoSanPham.HeaderText = "Số sản phẩm";
			this.SoSanPham.Name = "SoSanPham";
			this.SoSanPham.ReadOnly = true;
			this.SoSanPham.Width = 130;
			// 
			// donGiaDataGridViewTextBoxColumn
			// 
			this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "N0";
			this.donGiaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
			this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
			this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
			this.donGiaDataGridViewTextBoxColumn.Width = 200;
			// 
			// bndsrcDSBangGia
			// 
			this.bndsrcDSBangGia.DataSource = typeof(Entity.ListBangGiaEntity);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.bndsrcDSBangGia;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.CountItemFormat = "trong tổng số {0}";
			this.bindingNavigator1.DeleteItem = null;
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
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(676, 25);
			this.bindingNavigator1.TabIndex = 0;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(96, 22);
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
			// frmDSBangGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(676, 509);
			this.Controls.Add(this.dgvDSBangGia);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDSBangGia";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng giá";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSBangGia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSBangGia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvDSBangGia;
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
		private System.Windows.Forms.BindingSource bndsrcDSBangGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDGiaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maKieuGiatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKieuGiatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoSanPham;
		private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;

	}
}