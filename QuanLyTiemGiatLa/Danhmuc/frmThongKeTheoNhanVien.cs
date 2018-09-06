using System;
using System.Windows.Forms;
using Entity;

namespace QuanLyTiemGiatLa.Danhmuc
{
	public partial class frmThongKeTheoNhanVien : Form
	{
		private ListUserEntity _listUser = null;
		private ListPhieuEntity _listPhieu = null;
		private Boolean _daloadxongform = false;

		public frmThongKeTheoNhanVien()
		{
			InitializeComponent();
			_listUser = Business.UserBO.SelectAll();
			this.Load += new EventHandler(frmThongKeTheoNhanVien_Load);
		}

		private void frmThongKeTheoNhanVien_Load(object sender, EventArgs e)
		{
			//this.LoadData();
		}	

		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private Entity.UserEntity FindUser(String username)
		{
			foreach (UserEntity item in _listUser)
			{
				if (item.UserName == username) return item;
			}
			return null;
		}

		private void LoadData()
		{
			_listPhieu = Business.PhieuBO.SelectByNgayLap(dtpTuNgay.Value, dtpDenNgay.Value);
			ListUserEntity listUser = new ListUserEntity();
			foreach (PhieuEntity phieu in _listPhieu)
			{
				UserEntity find = FindUser(phieu.UserName);
				if (find != null && !listUser.Contains(find))
					listUser.Add(find);
			}
			_daloadxongform = false;
			bndsrcDSNhanVien.DataSource = listUser;
			_daloadxongform = true;
			bndsrcDSNhanVien_CurrentChanged(null, null);
		}

		private void btnCollapse_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
			btnCollapse.Text = splitContainer1.Panel1Collapsed ? ">>" : "<<";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bndsrcDSNhanVien_CurrentChanged(object sender, EventArgs e)
		{
			if (!_daloadxongform) return;
			Entity.UserEntity user = bndsrcDSNhanVien.Current as Entity.UserEntity;
			bndsrcDSPhieu.Clear();
			if (user == null)
			{
				txtTongCong.Text = "0";
				return;
			}
			Int64 tongcong = 0;
			foreach (PhieuEntity phieu in _listPhieu)
			{
				if (phieu.UserName == user.UserName)
				{
					bndsrcDSPhieu.Add(phieu);
					tongcong += phieu.TongTien;
				}
			}
			txtTongCong.Text = tongcong == 0 ? "0" : String.Format("{0:0,0}", tongcong);
			//LoadTongTienSauGiamGia();
		}

		//private void LoadTongTienSauGiamGia()
		//{
		//    Int64 tongtien = 0;
		//    for (int i = 0; i < dgvDSPhieu.RowCount; i++)
		//    {
		//        Int64 tongtientruocgiam = Convert.ToInt64(dgvDSPhieu["tongTienDataGridViewTextBoxColumn", i].Value);
		//        Int32 giamgia = Convert.ToInt32(dgvDSPhieu["giamGiaDataGridViewTextBoxColumn", i].Value);
		//        Int64 tongtiensaugiam = tongtientruocgiam - Xuly.Xuly.TinhTienGiamGia(tongtientruocgiam, giamgia);
		//        dgvDSPhieu["TongTienDaGiam", i].Value = tongtiensaugiam;
		//        tongtien += tongtiensaugiam;
		//    }
		//    txtTongCong.Text = tongtien == 0 ? "0" : String.Format("{0:0,0}", tongtien);
		//}
	}
}
