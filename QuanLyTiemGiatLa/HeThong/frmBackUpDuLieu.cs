using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;
//using System.Web.Script.Serialization;
using QuanLyTiemGiatLa.Xuly;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace QuanLyTiemGiatLa.HeThong
{
    public partial class frmBackUpDuLieu : Form
    {
        public frmBackUpDuLieu()
        {
            InitializeComponent();
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

        private void btnTryConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                string s = "";
                // Create the web request  
                HttpWebRequest request = WebRequest.Create("http://139.180.211.168/api/v1.0/auth/login") as HttpWebRequest;
                //request.Accept = "application/atom+xml";
                var postData = "username=admin";
                postData += "&" + "password=Taolaadmin";
                var dataEncode = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dataEncode.Length;
                request.Credentials = CredentialCache.DefaultCredentials;
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(dataEncode, 0, dataEncode.Length);
                    dataStream.Close();
                }


                // Get response
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string json = reader.ReadToEnd();
                    s += json + "\nStatus: " + ((HttpWebResponse)response).StatusDescription;
                    reader.Close();
                    response.Close();

                    //{
                    //    "code": 400,
                    //    "message": "User post method with {clientId, password}",
                    //    "data": null
                    //}
                    Dictionary<string, object> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                    string code = htmlAttributes["codee"] == null ? "" : htmlAttributes["code"].ToString();
                    string message = htmlAttributes["message"].ToString();
                    string data = htmlAttributes["data"].ToString();
                    MessageBox.Show(s + "\n\n" + code + message + data, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSync_Click(object sender, System.EventArgs e)
        {
            try
            {

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

        private void btnImportCustomer_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPathJsonKH.Text))
                {
                    MessageBox.Show("Đường dẫn file để import rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                btnImportCustomer.Enabled = false;
                Entity.ListKhachHangEntity lst = new Entity.ListKhachHangEntity();
                if (this.checkFileJson(ref lst))
                {
                    pgbImportCustomer.Minimum = 0;
                    pgbImportCustomer.Maximum = lst.Count;
                    pgbImportCustomer.Visible = true;
                    int countSuccess = 0;
                    StreamWriter sw = new StreamWriter(".\\log_ImportCustomers.txt");
                    for (int i = 0; i < lst.Count; ++i)
                    {
                        pgbImportCustomer.Value = i;
                        Entity.KhachHangEntity kh = lst[i];
                        if (string.IsNullOrEmpty(kh.DienThoai))
                        {
                            sw.WriteLine("Khách hàng mã '" + kh.MaKhachHang + " - " + kh.TenKhachHang + "' ko có SĐT");
                            continue;
                        }
                        Int64 result = Business.KhachHangBO.InsertFromImport(kh);
                        if (result <= 0)
                        {
                            sw.WriteLine("Khách hàng mã '" + kh.MaKhachHang + " - " + kh.TenKhachHang + "' đã trùng SĐT '" + kh.DienThoai + "'" +  result);
                            continue;
                        }
                        countSuccess++;
                        // muc do vip chua lam
                    }
                    sw.WriteLine("Thành công " + countSuccess + "/" + lst.Count + ". Loại " + (lst.Count - countSuccess) + " khách hàng.");
                    sw.Close();
                    MessageBox.Show("Nhập thành công " + countSuccess + "/" + lst.Count + ". Chi tiết xem ở file 'log_ImportCustomers.txt'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pgbImportCustomer.Visible = false;
                btnImportCustomer.Enabled = true;
            }
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
    }
}
