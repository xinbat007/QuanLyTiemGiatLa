using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;
using QuanLyTiemGiatLa.Xuly;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using Entity;
using System.ComponentModel;
using System.Threading;

namespace QuanLyTiemGiatLa.HeThong
{
    public partial class frmBackUpDuLieu : Form
    {
        public frmBackUpDuLieu()
        {
            InitializeComponent();
            lblMessage.Text = "";
            this.Load += new System.EventHandler(frmBackUpDuLieu_Load);
        }

        private void frmBackUpDuLieu_Load(object sender, System.EventArgs e)
        {
            try
            {
                Xuly.ThaoTacIniBackup iniBackup = new QuanLyTiemGiatLa.Xuly.ThaoTacIniBackup();
                iniBackup.Read();
                txtDuongDanFile.Text = iniBackup.DuongDanLuuThuMucFileBackup;
                txtCopyTo.Text = iniBackup.DuongDanLuuThuMucCopyTo;
                if (iniBackup.ThoiGianTuDongBackUp == 0)
                    iniBackup.ThoiGianTuDongBackUp = 19;
                txtThoiGianBackup.Text = iniBackup.ThoiGianTuDongBackUp.ToString();
                txtPathServer.Text = Properties.Settings.Default.PathServerSync;
                txtUserNameServerSync.Text = Properties.Settings.Default.UserNameServerSync;
                txtPasswordServerSync.Text = Properties.Settings.Default.PasswordServerSync;
                btnSyncOrder.Enabled = Xuly.HttpUtil.Token() != "";
                btnSyncCustomer.Enabled = Xuly.HttpUtil.Token() != "";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Mô tả:
         * - Cho người dùng chọn thời gian backup sau 1 ngày (mặc định là 7h tối)
         * - Người dùng chọn thư mục muốn backup ra. Có nút Backup = tay
         **/

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtDuongDanFile.Text = fbd.SelectedPath;
        }

        private void btnBrowseCopyTo_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtCopyTo.Text = fbd.SelectedPath;
        }

        private bool CheckForm()
        {
            if (string.IsNullOrEmpty(txtDuongDanFile.Text))
            {
                MessageBox.Show("Đường dẫn file rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuongDanFile.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(txtThoiGianBackup.Text))
            {
                int temp;
                if (int.TryParse(txtThoiGianBackup.Text, out temp))
                {
                    if (temp < 8 || temp > 21)
                    {
                        MessageBox.Show("Thời gian backup phải nằm trong khoảng 8h - 21h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtThoiGianBackup.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Thời gian backup phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThoiGianBackup.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnBackUp_Click(object sender, System.EventArgs e)
        {
            if (!this.CheckForm()) return;
            btnBackUp.Enabled = false;
            int result = Xuly.Xuly.AutoBackup(txtDuongDanFile.Text, txtCopyTo.Text);
            btnBackUp.Enabled = true;
            if (result == 1)
            {
                MessageBox.Show("Không copy được sang thư mục: " + txtCopyTo.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == 2)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveServerSyncInfo()
        {
            try
            {
                Properties.Settings.Default.PathServerSync = txtPathServer.Text;
                Properties.Settings.Default.UserNameServerSync = txtUserNameServerSync.Text;
                Properties.Settings.Default.PasswordServerSync = txtPasswordServerSync.Text;
                Properties.Settings.Default.Save();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuCauHinh_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.SaveServerSyncInfo();
                if (!string.IsNullOrEmpty(txtDuongDanFile.Text))
                {
                    int temp;
                    if (int.TryParse(txtThoiGianBackup.Text, out temp))
                    {
                        if (temp < 8 || temp > 21)
                        {
                            MessageBox.Show("Thời gian backup phải nằm trong khoảng 8h - 21h", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtThoiGianBackup.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thời gian backup phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtThoiGianBackup.Focus();
                        return;
                    }
                }
                ThaoTacIniBackup thaotacini = new ThaoTacIniBackup();
                thaotacini.Write(txtDuongDanFile.Text, txtCopyTo.Text, int.Parse(txtThoiGianBackup.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowsePathCustomer_Click(object sender, System.EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "Json file (*.json)|*.json|" +
                        "All file (*.*)|*.*";
            FD.FilterIndex = 0;
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string fileToOpen = FD.FileName;
                    txtPathJsonKH.Text = fileToOpen;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Không hỗ trợ định dạng này: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool checkFileJson(ref Entity.ListKhachHangEntity lst)
        {
            try
            {
                // read file into a string and deserialize JSON to a type
                lst = JsonConvert.DeserializeObject<Entity.ListKhachHangEntity>(File.ReadAllText(txtPathJsonKH.Text));
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Json sai format:\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Entity.ListKhachHangEntity lstImportCustomers = null;

        private void btnImportCustomer_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPathJsonKH.Text))
            {
                MessageBox.Show("Đường dẫn file để import rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnImportCustomer.Enabled = false;
            lstImportCustomers = new Entity.ListKhachHangEntity();
            if (this.checkFileJson(ref lstImportCustomers))
            {
                pgbProgress.Minimum = 0;
                pgbProgress.Maximum = lstImportCustomers.Count;
                pgbProgress.Visible = true;
                countSuccess = 0;
                lblMessage.Text = "";
                bgwImportCustomers.RunWorkerAsync();
            }
        }

        private void bgwImportCustomers_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(".\\log_ImportCustomers.txt");
                for (int i = 0; i < lstImportCustomers.Count; ++i)
                {
                    bgwImportCustomers.ReportProgress(i);
                    if (isTest)
                    {
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Entity.KhachHangEntity kh = lstImportCustomers[i];
                        if (string.IsNullOrEmpty(kh.DienThoai))
                        {
                            sw.WriteLine("Lỗi: Khách hàng mã '" + kh.MaKhachHang + " - " + kh.TenKhachHang + "' ko có SĐT.");
                            continue;
                        }
                        Int64 result = Business.KhachHangBO.InsertFromImport(kh);
                        if (result <= 0)
                        {
                            sw.WriteLine("Lỗi: Khách hàng mã '" + kh.MaKhachHang + " - " + kh.TenKhachHang + "' đã trùng SĐT '" + kh.DienThoai + "'.");
                            continue;
                        }
                        sw.WriteLine("Thành công: Khách hàng mã '" + kh.MaKhachHang + " - " + kh.TenKhachHang + " - " + kh.DienThoai + "' đc thêm vào với mã '" + result + "'");
                        countSuccess++;
                        // muc do vip chua lam
                    }
                }
                bgwImportCustomers.ReportProgress(lstImportCustomers.Count);
                sw.WriteLine("====================");
                sw.WriteLine("Thành công " + countSuccess + "/" + lstImportCustomers.Count + ". Loại " + (lstImportCustomers.Count - countSuccess) + " khách hàng.");
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwImportCustomers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bgwImportCustomers.CancellationPending != true)
            {
                lblMessage.Text = "Đang nhập khách hàng " + e.ProgressPercentage + "/" + lstImportCustomers.Count;
                pgbProgress.Value = e.ProgressPercentage;
            }
        }

        private void bgwImportCustomers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
            }
            MessageBox.Show("Nhập thành công " + countSuccess + "/" + lstImportCustomers.Count + ".\nChi tiết xem ở file 'log_ImportCustomers.txt'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMessage.Text = "";
            pgbProgress.Visible = false;
            btnImportCustomer.Enabled = true;
        }

        private void btnExportCustomer_Click(object sender, System.EventArgs e)
        {
            try
            {
                btnExportCustomer.Enabled = false;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json|*.json";
                saveFileDialog1.Title = "Save an Json File";
                saveFileDialog1.ShowDialog();
                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog1.FileName != "")
                {
                    var khachhang = new Entity.KhachHangEntity();
                    Entity.ListKhachHangEntity lst = Business.KhachHangBO.Search(khachhang);
                    //https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm
                    // serialize JSON to a string and then write string to a file
                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(lst, Formatting.Indented));
                    MessageBox.Show("Thành công " + lst.Count + " khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExportCustomer.Enabled = true;
            }
        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            try
            {
                btnExportBill.Enabled = false;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json|*.json";
                saveFileDialog1.Title = "Save an Json File";
                saveFileDialog1.ShowDialog();
                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog1.FileName != "")
                {
                    var khachhang = new Entity.KhachHangEntity();
                    ListPhieuEntity lst = Business.PhieuBO.SelectNangCao(true, false, 0, "", "", false, DateTime.Now, DateTime.Now);
                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(lst, Formatting.Indented));
                    MessageBox.Show("Thành công " + lst.Count + " phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExportBill.Enabled = true;
            }
        }

        private void btnExportBillDetail_Click(object sender, EventArgs e)
        {
            try
            {
                btnExportBillDetail.Enabled = false;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json|*.json";
                saveFileDialog1.Title = "Save an Json File";
                saveFileDialog1.ShowDialog();
                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog1.FileName != "")
                {
                    var khachhang = new Entity.KhachHangEntity();
                    ListChiTietPhieuEntity lst = Business.ChiTietPhieuBO.SelectAll();
                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(lst, Formatting.Indented));
                    MessageBox.Show("Thành công " + lst.Count + " chi tiết phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExportBillDetail.Enabled = true;
            }
        }

        private void btnTryConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                ResultHttp result = HttpUtil.Login(txtPathServer.Text, txtUserNameServerSync.Text, txtPasswordServerSync.Text);
                MessageBox.Show("Kết nối: " + result.Message + "!", "Thông báo", MessageBoxButtons.OK,
                    result.Code != "200" ? MessageBoxIcon.Error : MessageBoxIcon.Asterisk);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSyncOrder.Enabled = Xuly.HttpUtil.Token() != "";
                btnSyncCustomer.Enabled = Xuly.HttpUtil.Token() != "";
            }
        }

        private void frmBackUpDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwSyncOrders.IsBusy)
            {
                DialogResult dialogResult = MessageBox.Show("Đang đồng bộ phiếu, bạn có chắc chắn muốn thoát?", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bgwSyncOrders.CancelAsync();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (bgwSyncCustomers.IsBusy)
            {
                DialogResult dialogResult = MessageBox.Show("Đang đồng bộ khách hàng, bạn có chắc chắn muốn thoát?", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bgwSyncCustomers.CancelAsync();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSyncOrder_Click(object sender, EventArgs e)
        {
            if (bgwSyncOrders.IsBusy)
            {
                bgwSyncOrders.CancelAsync();
            }
            else
            {
                btnSyncOrder.Text = "Dừng";
                btnSyncOrder.Enabled = false;
                btnSyncCustomer.Enabled = false;
                listPhieuSync = Business.PhieuBO.SelectNangCao(true, false, 0, "", "", false, DateTime.Now, DateTime.Now);
                btnSyncOrder.Enabled = true;
                countPhieuSync = isTest ? 50 : listPhieuSync.Count;
                //================
                pgbProgress.Minimum = 0;
                pgbProgress.Maximum = countPhieuSync;
                pgbProgress.Value = 0;
                pgbProgress.Visible = true;
                bgwSyncOrders.RunWorkerAsync();
            }
        }

        private bool isTest = false;
        private int countSuccess = 0;
        //=======================
        private ListPhieuEntity listPhieuSync = null;
        private int countPhieuSync = 0;

        private void SyncPhieu(PhieuEntity phieu, StreamWriter sw)
        {
            ListChiTietPhieuEntity lstCTPhieu = Business.ChiTietPhieuBO.SelectByMaPhieu(phieu.MaPhieu);
            ListChiTietPhieuSyncEntity lstCTPhieuSync = new ListChiTietPhieuSyncEntity();
            for (int k = 0; k < lstCTPhieu.Count; k++)
            {
                ChiTietPhieuEntity ctPhieu = lstCTPhieu[k];
                ChiTietPhieuSyncEntity ctPhieuSync = new ChiTietPhieuSyncEntity();
                ctPhieuSync.CopyFromPhieu(phieu);
                ctPhieuSync.CopyFromCTPhieu(ctPhieu);
                lstCTPhieuSync.Add(ctPhieuSync);
            }
            ResultHttp result = Xuly.HttpUtil.SyncOrder(txtPathServer.Text, lstCTPhieuSync);
            if (result.Code == "200")
            {
                sw.WriteLine("Thành công phiếu '" + phieu.MaPhieu + "': " + result.Message);
                countSuccess++;
            }
            else
            {
                sw.WriteLine("Lỗi phiếu '" + phieu.MaPhieu + "': " + result.Message);
            }
        }

        private void bgwSyncOrders_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                countSuccess = 0;
                StreamWriter sw = new StreamWriter(".\\log_SyncOrders.txt");
                for (int i = 0; i < countPhieuSync; i++)
                {
                    if (bgwSyncOrders.CancellationPending == true)
                    {
                        e.Cancel = true;
                        sw.Close();
                        return;
                    }
                    bgwSyncOrders.ReportProgress(i);
                    if (isTest)
                    {
                        Thread.Sleep(100);
                    }
                    else
                    {
                        SyncPhieu(listPhieuSync[i], sw);
                    }
                }
                bgwSyncOrders.ReportProgress(countPhieuSync);
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void ResetForm()
        {
            lblMessage.Text = "";
            pgbProgress.Value = 0;
            pgbProgress.Visible = false;
            btnSyncOrder.Text = "Đồng bộ phiếu";
            btnSyncCustomer.Text = "Đồng bộ khách hàng";
            btnSyncOrder.Enabled = Xuly.HttpUtil.Token() != "";
            btnSyncCustomer.Enabled = Xuly.HttpUtil.Token() != "";
            pgbProgress.Visible = false;
        }

        private void bgwSyncOrders_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResetForm();
            if (!e.Cancelled)
            {
                MessageBox.Show("Thành công: " + countSuccess + "/" + countPhieuSync + " phiếu.\nChi tiết xem ở file 'log_SyncOrder.txt'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Bạn đã dừng đồng bộ " + countSuccess + "/" + countPhieuSync + " phiếu.\nChi tiết xem ở file 'log_SyncOrder.txt'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bgwSyncOrders_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblMessage.Text = "Đang đồng bộ " + e.ProgressPercentage + " / " + countPhieuSync + " phiếu";
            if (bgwSyncOrders.CancellationPending != true)
            {
                pgbProgress.Value = e.ProgressPercentage;
            }
        }

        private int countCustomerSync = 0;
        private ListKhachHangEntity listCustomers = null;

        private void btnSyncCustomer_Click(object sender, EventArgs e)
        {
            if (bgwSyncCustomers.IsBusy)
            {
                bgwSyncCustomers.CancelAsync();
            }
            else
            {
                btnSyncCustomer.Text = "Dừng";
                btnSyncOrder.Enabled = false;
                btnSyncCustomer.Enabled = false;
                var khachhang = new Entity.KhachHangEntity();
                listCustomers = Business.KhachHangBO.Search(khachhang);
                btnSyncCustomer.Enabled = true;
                countCustomerSync = isTest ? 50 : listCustomers.Count;
                //================
                pgbProgress.Minimum = 0;
                pgbProgress.Maximum = countCustomerSync;
                pgbProgress.Value = 0;
                pgbProgress.Visible = true;
                bgwSyncCustomers.RunWorkerAsync();
            }
        }

        private void SyncCustomer(KhachHangEntity khach, StreamWriter sw)
        {
            ResultHttp result = Xuly.HttpUtil.SyncCustomer(txtPathServer.Text, khach);
            if (result.Code == "200")
            {
                sw.WriteLine("Thành công khách hàng '" + khach.TenKhachHang + "', '" + khach.DienThoai + "': " + result.Message);
                countSuccess++;
            }
            else
            {
                sw.WriteLine("Lỗi khách hàng '" +
                    khach.MaKhachHang + "', '" +
                    khach.TenKhachHang + "', '" +
                    khach.DienThoai + "': " + result.Message);
            }
        }

        private void bgwSyncCustomers_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                countSuccess = 0;
                StreamWriter sw = new StreamWriter(".\\log_SyncCustomers.txt");
                for (int i = 0; i < countCustomerSync; i++)
                {
                    if (bgwSyncCustomers.CancellationPending == true)
                    {
                        e.Cancel = true;
                        sw.Close();
                        return;
                    }
                    bgwSyncCustomers.ReportProgress(i);
                    if (isTest)
                    {
                        Thread.Sleep(100);
                    }
                    else
                    {
                        SyncCustomer(listCustomers[i], sw);
                    }
                }
                bgwSyncCustomers.ReportProgress(countCustomerSync);
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void bgwSyncCustomers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblMessage.Text = "Đang đồng bộ " + e.ProgressPercentage + " / " + countCustomerSync + " khách hàng";
            if (bgwSyncCustomers.CancellationPending != true)
            {
                pgbProgress.Value = e.ProgressPercentage;
            }
        }

        private void bgwSyncCustomers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResetForm();
            if (!e.Cancelled)
            {
                MessageBox.Show("Thành công: " + countSuccess + "/" + countCustomerSync + " khách hàng.\nChi tiết xem ở file 'log_SyncCustomers.txt'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Bạn đã dừng đồng bộ " + countSuccess + "/" + countCustomerSync + " khách hàng.\nChi tiết xem ở file 'log_SyncCustomers.txt'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
