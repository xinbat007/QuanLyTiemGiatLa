namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmDSGiaDeDo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSGiaDeDo));
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bndsrcDSKho = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.dgvDSGiaDeDo = new System.Windows.Forms.DataGridView();
			this.maKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soluongSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKho)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaDeDo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.bndsrcDSKho;
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
			this.bindingNavigator1.Size = new System.Drawing.Size(440, 25);
			this.bindingNavigator1.TabIndex = 2;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bndsrcDSKho
			// 
			this.bndsrcDSKho.DataSource = typeof(Entity.ListKhoEntity);
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
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::QuanLyTiemGiatLa.Properties.Resources._11;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.Location = new System.Drawing.Point(111, 10);
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
			this.btnXoa.Location = new System.Drawing.Point(274, 10);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(65, 53);
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
			this.btnSua.Location = new System.Drawing.Point(194, 10);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(72, 53);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "&Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// dgvDSGiaDeDo
			// 
			this.dgvDSGiaDeDo.AllowUserToAddRows = false;
			this.dgvDSGiaDeDo.AllowUserToDeleteRows = false;
			this.dgvDSGiaDeDo.AutoGenerateColumns = false;
			this.dgvDSGiaDeDo.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvDSGiaDeDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSGiaDeDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoDataGridViewTextBoxColumn,
            this.tenKhoDataGridViewTextBoxColumn,
            this.soluongSlotDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
			this.dgvDSGiaDeDo.DataSource = this.bndsrcDSKho;
			this.dgvDSGiaDeDo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSGiaDeDo.Location = new System.Drawing.Point(0, 25);
			this.dgvDSGiaDeDo.MultiSelect = false;
			this.dgvDSGiaDeDo.Name = "dgvDSGiaDeDo";
			this.dgvDSGiaDeDo.ReadOnly = true;
			this.dgvDSGiaDeDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSGiaDeDo.Size = new System.Drawing.Size(440, 247);
			this.dgvDSGiaDeDo.TabIndex = 0;
			this.dgvDSGiaDeDo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGiaDeDo_CellDoubleClick);
			// 
			// maKhoDataGridViewTextBoxColumn
			// 
			this.maKhoDataGridViewTextBoxColumn.DataPropertyName = "MaKho";
			this.maKhoDataGridViewTextBoxColumn.HeaderText = "MaKho";
			this.maKhoDataGridViewTextBoxColumn.Name = "maKhoDataGridViewTextBoxColumn";
			this.maKhoDataGridViewTextBoxColumn.ReadOnly = true;
			this.maKhoDataGridViewTextBoxColumn.Visible = false;
			// 
			// tenKhoDataGridViewTextBoxColumn
			// 
			this.tenKhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tenKhoDataGridViewTextBoxColumn.DataPropertyName = "TenKho";
			this.tenKhoDataGridViewTextBoxColumn.HeaderText = "Tên kho";
			this.tenKhoDataGridViewTextBoxColumn.Name = "tenKhoDataGridViewTextBoxColumn";
			this.tenKhoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// soluongSlotDataGridViewTextBoxColumn
			// 
			this.soluongSlotDataGridViewTextBoxColumn.DataPropertyName = "SoluongSlot";
			this.soluongSlotDataGridViewTextBoxColumn.HeaderText = "Số lượng slot";
			this.soluongSlotDataGridViewTextBoxColumn.Name = "soluongSlotDataGridViewTextBoxColumn";
			this.soluongSlotDataGridViewTextBoxColumn.ReadOnly = true;
			this.soluongSlotDataGridViewTextBoxColumn.Width = 130;
			// 
			// ghiChuDataGridViewTextBoxColumn
			// 
			this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
			this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
			this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
			this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
			this.ghiChuDataGridViewTextBoxColumn.Width = 150;
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(347, 10);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(80, 53);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 272);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 76);
			this.panel1.TabIndex = 1;
			// 
			// frmDSGiaDeDo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(440, 348);
			this.Controls.Add(this.dgvDSGiaDeDo);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDSGiaDeDo";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách giá để đồ";
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcDSKho)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSGiaDeDo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.DataGridView dgvDSGiaDeDo;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.BindingSource bndsrcDSKho;
		private System.Windows.Forms.DataGridViewTextBoxColumn maKhoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soluongSlotDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;


	}
}