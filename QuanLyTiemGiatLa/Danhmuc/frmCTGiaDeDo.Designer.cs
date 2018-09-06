namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTGiaDeDo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTGiaDeDo));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.bndsrcKho = new System.Windows.Forms.BindingSource(this.components);
			this.txtSoLuongSlot = new System.Windows.Forms.TextBox();
			this.txtTenKho = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnGhi = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcKho)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtGhiChu);
			this.groupBox1.Controls.Add(this.txtSoLuongSlot);
			this.groupBox1.Controls.Add(this.txtTenKho);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(368, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKho, "GhiChu", true));
			this.txtGhiChu.Location = new System.Drawing.Point(120, 93);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(236, 26);
			this.txtGhiChu.TabIndex = 2;
			// 
			// bndsrcKho
			// 
			this.bndsrcKho.DataSource = typeof(Entity.KhoEntity);
			// 
			// txtSoLuongSlot
			// 
			this.txtSoLuongSlot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKho, "SoluongSlot", true));
			this.txtSoLuongSlot.Location = new System.Drawing.Point(120, 59);
			this.txtSoLuongSlot.Name = "txtSoLuongSlot";
			this.txtSoLuongSlot.Size = new System.Drawing.Size(236, 26);
			this.txtSoLuongSlot.TabIndex = 1;
			// 
			// txtTenKho
			// 
			this.txtTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcKho, "TenKho", true));
			this.txtTenKho.Location = new System.Drawing.Point(120, 25);
			this.txtTenKho.Name = "txtTenKho";
			this.txtTenKho.Size = new System.Drawing.Size(236, 26);
			this.txtTenKho.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ghi chú:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số lượng slot:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên kho:";
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(284, 137);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(72, 69);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(202, 137);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(76, 69);
			this.btnGhi.TabIndex = 1;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// frmCTGiaDeDo
			// 
			this.AcceptButton = this.btnGhi;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(368, 215);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTGiaDeDo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giá để đồ";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcKho)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtSoLuongSlot;
		private System.Windows.Forms.TextBox txtTenKho;
		private System.Windows.Forms.BindingSource bndsrcKho;
	}
}