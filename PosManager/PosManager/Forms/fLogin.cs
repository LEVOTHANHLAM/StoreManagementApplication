using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PosManager.APIServices.User;
using PosManager.Helper;
using PosManager.Model;
using Serilog;
using System.IdentityModel.Tokens.Jwt;

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
                btnLogin.Enabled = false;
                string password = txtPassword.Text.Trim();
                string username = txtUsername.Text.Trim();
                PosManager.Properties.Settings.Default["username"] = username;
                PosManager.Properties.Settings.Default["password"] = password;
                PosManager.Properties.Settings.Default.Save();
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
                {
                    MessageCommon.ShowMessageBox("Vui lòng đầy đủ thông tin!");
                    btnLogin.Enabled = true;
                    return;
                }
                AuthenticateController login = new AuthenticateController();
                var user = await login.Login(username, password);
                if (user == null)
                {
                    MessageCommon.ShowMessageBox("Lỗi Hệ Thống Vui Lòng Liên Hệ Admin!", 4);
                    btnLogin.Enabled = true;
                    return;
                }
                else
                {
                    if (user.StatusCode == 200 && user.Message == "Success" && !string.IsNullOrEmpty(user.Data.Token))
                    {
                        GlobalModel.AccsessToken = user.Data.Token;
                        var s = ConvertTokenToJson(user.Data.Token);
                        fMain form1 = new fMain();
                        form1.Show();
                        this.Hide();
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
        private string ConvertTokenToJson(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var claims = tokenHandler.ReadJwtToken(token).Claims.ToList();
                foreach (var claim in claims)
                {
                    Console.WriteLine($"Type: {claim.Type}, Value: {claim.Value}");
                    // Xử lý các thông tin claim tại đây
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null; // Trả về null nếu có lỗi xảy ra
            }
            return null;
        }
    }
}
