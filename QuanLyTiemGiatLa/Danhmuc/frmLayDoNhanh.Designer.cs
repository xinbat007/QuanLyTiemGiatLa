namespace QuanLyTiemGiatLa.Danhmuc
{
	partial class frmLayDoNhanh
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayDoNhanh));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pnlMatHang = new System.Windows.Forms.Panel();
			this.lsvMatHang = new System.Windows.Forms.ListView();
			this.pnlTextLoc = new System.Windows.Forms.Panel();
			this.txtLoc = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlKieuGiat = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThoat = new System.Windows.Forms.Button();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.pnlMatHang.SuspendLayout();
			this.pnlTextLoc.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pnlMatHang);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(929, 662);
			this.splitContainer1.SplitterDistance = 152;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 0;
			// 
			// pnlMatHang
			// 
			this.pnlMatHang.AutoScroll = true;
			this.pnlMatHang.Controls.Add(this.lsvMatHang);
			this.pnlMatHang.Controls.Add(this.pnlTextLoc);
			this.pnlMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMatHang.Location = new System.Drawing.Point(0, 0);
			this.pnlMatHang.Name = "pnlMatHang";
			this.pnlMatHang.Size = new System.Drawing.Size(639, 660);
			this.pnlMatHang.TabIndex = 0;
			// 
			// lsvMatHang
			// 
			this.lsvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvMatHang.HideSelection = false;
			this.lsvMatHang.Location = new System.Drawing.Point(0, 33);
			this.lsvMatHang.MultiSelect = false;
			this.lsvMatHang.Name = "lsvMatHang";
			this.lsvMatHang.ShowItemToolTips = true;
			this.lsvMatHang.Size = new System.Drawing.Size(639, 627);
			this.lsvMatHang.TabIndex = 1;
			this.lsvMatHang.UseCompatibleStateImageBehavior = false;
			// 
			// pnlTextLoc
			// 
			this.pnlTextLoc.Controls.Add(this.txtLoc);
			this.pnlTextLoc.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTextLoc.Location = new System.Drawing.Point(0, 0);
			this.pnlTextLoc.Name = "pnlTextLoc";
			this.pnlTextLoc.Size = new System.Drawing.Size(639, 33);
			this.pnlTextLoc.TabIndex = 0;
			// 
			// txtLoc
			// 
			this.txtLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtLoc.Location = new System.Drawing.Point(5, 3);
			this.txtLoc.Name = "txtLoc";
			this.txtLoc.Size = new System.Drawing.Size(630, 26);
			this.txtLoc.TabIndex = 0;
			this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pnlKieuGiat);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(639, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(130, 660);
			this.panel1.TabIndex = 0;
			// 
			// pnlKieuGiat
			// 
			this.pnlKieuGiat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlKieuGiat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlKieuGiat.Location = new System.Drawing.Point(0, 0);
			this.pnlKieuGiat.Name = "pnlKieuGiat";
			this.pnlKieuGiat.Size = new System.Drawing.Size(130, 586);
			this.pnlKieuGiat.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnThoat);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 586);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(130, 74);
			this.panel2.TabIndex = 0;
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Image = global::QuanLyTiemGiatLa.Properties.Resources.Exit16;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThoat.Location = new System.Drawing.Point(15, 11);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(104, 52);
			this.btnThoat.TabIndex = 0;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// imgList
			// 
			this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgList.ImageSize = new System.Drawing.Size(48, 48);
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// frmLayDoNhanh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(929, 662);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmLayDoNhanh";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lấy đồ nhanh";
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.pnlMatHang.ResumeLayout(false);
			this.pnlTextLoc.ResumeLayout(false);
			this.pnlTextLoc.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel pnlMatHang;
		private System.Windows.Forms.Panel pnlKieuGiat;
		private System.Windows.Forms.ListView lsvMatHang;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.Panel pnlTextLoc;
		private System.Windows.Forms.TextBox txtLoc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnThoat;
	}
}