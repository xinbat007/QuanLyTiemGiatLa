using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTiemGiatLa.HeThong
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmLogin_Load);
            this.FormClosing += new FormClosingEventHandler(frmLogin_FormClosing);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Xuly.ThaoTacIniServer.Write(txtServerName.Text, chkIsWindow.Checked, txtSA.Text, txt123456.Text,
                                                chkRemember.Checked,
                                                chkRemember.Checked ? txtUsername.Text : "",
                                                chkRemember.Checked ? txtPassword.Text : "");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
            txtUsername.Text = Properties.Settings.Default.TenLoginHT;
            txtPassword.Text = Properties.Settings.Default.PassLoginHT;
            //txtUsername.Text = Xuly.ThaoTacIniServer.ReadTenLogin();
            //txtPassword.Text = Xuly.ThaoTacIniServer.ReadPassLogin();
            chkRemember.Checked = Xuly.ThaoTacIniServer.ReadRememberMe();
            //------------------------------
            txtServerName.Text = Xuly.ThaoTacIniServer.ReadServer();
            chkIsWindow.Checked = Xuly.ThaoTacIniServer.ReadIsWindow();
            txtSA.Text = Xuly.ThaoTacIniServer.ReadUserName();
            txt123456.Text = Xuly.ThaoTacIniServer.ReadPassword();
            //------------------------------
            if (String.IsNullOrEmpty(txtServerName.Text)) txtServerName.Text = ".\\SQLEXPRESS"; // TEL-6D64FC3A93F
            if (String.IsNullOrEmpty(txtSA.Text)) txtSA.Text = "sa";
            if (String.IsNullOrEmpty(txt123456.Text)) txt123456.Text = "sa";

        }

        private Boolean CheckForm()
        {
            if (txtUsername.Text == String.Empty)
            {
                lblMessage.Text = "Bạn chưa nhập tên tài khoản";
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text == String.Empty)
            {
                lblMessage.Text = "Bạn chưa điền mật khẩu";
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
                return;
                /** Chú ý: phải có ít nhất 1 account trong database thì mới đăng nhập đc, cụ thể account admin */
                if (!this.CheckForm()) return;
                if (!this.TestConnect()) return;
                Entity.UserEntity user = Business.UserBO.SelectByUserName(txtUsername.Text);
                if (user == null)
                {
                    lblMessage.Text = "Không tồn tại tài khoản '" + txtUsername.Text + "'";
                }
                else
                {
                    if (Xuly.Xuly.MaHoaPassword(txtPassword.Text) != user.Password)
                    {
                        lblMessage.Text = "Mật khẩu không đúng!";
                    }
                    else
                    {
                        BienChung.userCurrent = user;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (TestConnect())
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkIsWindow_CheckedChanged(object sender, EventArgs e)
        {
            txtSA.Enabled = !chkIsWindow.Checked;
            txt123456.Enabled = !chkIsWindow.Checked;
        }

        private Boolean TestConnect()
        {
            Entity.Common.connectionString = Xuly.Xuly.CreateConnectionString(
                                                    chkIsWindow.Checked,
                                                    txtServerName.Text,
                                                    "QuanLyTiemGiatLa",
                                                    txtSA.Text,
                                                    txt123456.Text);
            SqlConnection connect = new SqlConnection(Entity.Common.connectionString);
            try
            {
                connect.Open();
                connect.Close();
                return true;
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Không thể kết nối.\nNguyên nhân: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
