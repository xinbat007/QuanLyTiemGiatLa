using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmLoc : Form
	{
		public frmLoc()
		{
			InitializeComponent();
		}

		private String[] ketqua = null;
		private String[] cactruong = null;
		private String[] tieudecaccot = null;
		private String dieukien = null;
		private String tenbang = null;

		public String[] ShowLoc(String tenBang, String tenTruong, String tenCot, String dieukien)
		{
			this.tenbang = tenBang;
			this.cactruong = this.FormatString(tenTruong.Split(','));
			this.tieudecaccot = this.FormatString(tenCot.Split(','));
			this.dieukien = dieukien;
			this.txt.Text = dieukien;
			this.ketqua = new String[cactruong.Length];

			this.LoadData();
			for (int i = 0; i < tieudecaccot.Length; i++)
			{
				dgv.Columns[i].HeaderText = tieudecaccot[i];
				dgv.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
				dgv.Columns[i].Width = 150;
			}
			dgv.Columns[dgv.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ShowDialog();
			return this.ketqua;
		}

		private void LoadData()
		{
			this.dgv.DataSource = Business.BUtils.SelectBySql(this.taochuoiSql(tenbang, cactruong, dieukien));
		}

		private String[] FormatString(String[] chuaformat)
		{
			for (int i = 0; i < chuaformat.Length; i++)
			{
				chuaformat[i] = chuaformat[i].Trim();
			}
			return chuaformat;
		}

		private String taochuoiSql(String tenBang, String[] tenTruong, String dieukien)
		{
			StringBuilder sql = new StringBuilder();
			sql.Append("SELECT ");
			for (int i = 0; i < tenTruong.Length; i++)
			{
				sql.Append(tenTruong[i]);
				sql.Append(',');
			}
			sql.Remove(sql.Length - 1, 1);
			sql.Append(" FROM ");
			sql.Append(tenBang);
			sql.Append(" WHERE");
			if (String.IsNullOrEmpty(dieukien))
			{
				sql.Append(" 1=1");
			}
			else
			{
				for (int i = 0; i < tenTruong.Length; i++)
				{
					sql.Append(" ");
					sql.Append(tenTruong[i]);
					sql.Append(" LIKE N'%");
					sql.Append(dieukien);
					sql.Append("%' OR");
				}
				sql.Remove(sql.Length - 3, 3);
			}
			return sql.ToString();
		}

		private void txt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.btnFind_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Down)
			{
				this.dgv.Focus();
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			this.dieukien = txt.Text.Trim();
			this.LoadData();
		}

		private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv.SelectedCells.Count == 0)
			{
				MessageBox.Show("Dữ liệu trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			for (int i = 0; i < cactruong.Length; i++)
			{
				ketqua[i] = dgv.SelectedRows[0].Cells[i].Value.ToString();
			}
			this.DialogResult = DialogResult.OK;
		}

		private void dgv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.dgv_CellDoubleClick(sender, null);
			}
		}
	}
}
