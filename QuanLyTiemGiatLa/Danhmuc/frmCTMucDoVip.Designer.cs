namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmCTMucDoVip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTMucDoVip));
			this.bndsrcMucDoVip = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
			this.txtTenVip = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bndsrcMucDoVip)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
			this.SuspendLayout();
			// 
			// bndsrcMucDoVip
			// 
			this.bndsrcMucDoVip.DataSource = typeof(Entity.MucDoVipEntity);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudGiamGia);
			this.groupBox1.Controls.Add(this.txtTenVip);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(9, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 95);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// nudGiamGia
			// 
			this.nudGiamGia.Location = new System.Drawing.Point(89, 54);
			this.nudGiamGia.Name = "nudGiamGia";
			this.nudGiamGia.Size = new System.Drawing.Size(86, 26);
			this.nudGiamGia.TabIndex = 2;
			this.nudGiamGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGiamGia_KeyDown);
			// 
			// txtTenVip
			// 
			this.txtTenVip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bndsrcMucDoVip, "TenVip", true));
			this.txtTenVip.Location = new System.Drawing.Point(90, 19);
			this.txtTenVip.Name = "txtTenVip";
			this.txtTenVip.Size = new System.Drawing.Size(237, 26);
			this.txtTenVip.TabIndex = 1;
			this.txtTenVip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenVip_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Giảm giá:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên loại:";
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(163, 106);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(82, 52);
			this.btnGhi.TabIndex = 3;
			this.btnGhi.Text = "&Ghi";
			this.btnGhi.UseVisualStyleBackColor = true;
			this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(251, 106);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 52);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmCTMucDoVip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(354, 170);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCTMucDoVip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại khách hàng";
			((System.ComponentModel.ISupportInitialize)(this.bndsrcMucDoVip)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource bndsrcMucDoVip;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudGiamGia;
		private System.Windows.Forms.TextBox txtTenVip;
		private System.Windows.Forms.Button btnGhi;
		private System.Windows.Forms.Button btnThoat;
	}
}