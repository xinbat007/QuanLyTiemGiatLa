namespace QuanLyTiemGiatLa.HeThong
{
    partial class frmCauHinhGhiChu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCauHinhGhiChu));
			this.dgvGhiChu = new System.Windows.Forms.DataGridView();
			this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnGhi = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKCGhiChu = new System.Windows.Forms.TextBox();
			this.txtChieuNgangForm = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvGhiChu)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvGhiChu
			// 
			this.dgvGhiChu.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvGhiChu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGhiChu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GhiChu});
			this.dgvGhiChu.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvGhiChu.Location = new System.Drawing.Point(0, 0);
			this.dgvGhiChu.Name = "dgvGhiChu";
			this.dgvGhiChu.RowHeadersWidth = 25;
			this.dgvGhiChu.Size = new System.Drawing.Size(426, 291);
			this.dgvGhiChu.TabIndex = 0;
			// 
			// GhiChu
			// 
			this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.GhiChu.HeaderText = "Ghi chú";
			this.GhiChu.Name = "GhiChu";
			// 
			// btnGhi
			// 
			this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGhi.Image = global::QuanLyTiemGiatLa.Properties.Resources._45;
			this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGhi.Location = new System.Drawing.Point(263, 297);
			this.btnGhi.Name = "btnGhi";
			this.btnGhi.Size = new System.Drawing.Size(71, 54);
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
			this.btnThoat.Location = new System.Drawing.Point(340, 297);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(74, 54);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 298);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "K/c ghi chú:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 327);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Chiều ngang form:";
			// 
			// txtKCGhiChu
			// 
			this.txtKCGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtKCGhiChu.Location = new System.Drawing.Point(143, 295);
			this.txtKCGhiChu.Name = "txtKCGhiChu";
			this.txtKCGhiChu.Size = new System.Drawing.Size(55, 24);
			this.txtKCGhiChu.TabIndex = 7;
			this.txtKCGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtChieuNgangForm
			// 
			this.txtChieuNgangForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChieuNgangForm.Location = new System.Drawing.Point(143, 324);
			this.txtChieuNgangForm.Name = "txtChieuNgangForm";
			this.txtChieuNgangForm.Size = new System.Drawing.Size(55, 24);
			this.txtChieuNgangForm.TabIndex = 8;
			this.txtChieuNgangForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// frmCauHinhGhiChu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(426, 363);
			this.Controls.Add(this.txtChieuNgangForm);
			this.Controls.Add(this.txtKCGhiChu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGhi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.dgvGhiChu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCauHinhGhiChu";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cấu hình ghi chú";
			((System.ComponentModel.ISupportInitialize)(this.dgvGhiChu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKCGhiChu;
		private System.Windows.Forms.TextBox txtChieuNgangForm;
    }
}