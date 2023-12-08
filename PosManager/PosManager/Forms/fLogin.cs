using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.User;
using PosManager.Helper;
using Serilog;

namespace Krypton_toolKitDemo
{
    public partial class fLogin : KryptonForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = (string)PosManager.Properties.Settings.Default["username"];
            txtPassword.Text = (string)PosManager.Properties.Settings.Default["password"];
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text.Trim();
                string username = txtUsername.Text.Trim();
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
                {
                    MessageCommon.ShowMessageBox("Vui lòng đầy đủ thông tin!");
                    return;
                }
                AuthenticateController login = new AuthenticateController();
                var user = await login.Login(username, password);
                if (user == null)
                {
                    MessageCommon.ShowMessageBox("Lỗi Hệ Thống Vui Lòng Liên Hệ Admin!", 4);
                    return;
                }
                else
                {
                    if (user.StatusCode == 200 && user.Message == "Success" && !string.IsNullOrEmpty(user.Data.Token))
                    {
                        // login thanh cong
                        PosManager.Properties.Settings.Default["username"] = username;
                        PosManager.Properties.Settings.Default["password"] = password;
                        PosManager.Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageCommon.ShowMessageBox(user.Message, 4);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(fLogin)}, params; {nameof(btnLogin_Click)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);
                return;
            }

        }
    }
}
