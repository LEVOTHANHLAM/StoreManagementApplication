﻿using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using PosManager.APIServices.User;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.User;
using Serilog;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using static PosManager.Model.GlobalModel;

namespace PosManager
{
    public partial class fLogin : KryptonForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
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

                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                AuthenticateController login = new AuthenticateController();
                var user = await login.Login(username, password);
                if (user == null)
                {
                    SplashScreenManager.CloseForm(false);
                    MessageCommon.ShowMessageBox("Lỗi Hệ Thống Vui Lòng Liên Hệ Admin!", 4);
                    btnLogin.Enabled = true;

                    return;
                }
                else
                {
                    if (user.StatusCode == 200 && user.Message == "Success" && !string.IsNullOrEmpty(user.Data.Token))
                    {
                        GlobalModel.AccsessToken = user.Data.Token;
                        GlobalModel.UserInfo = await GetUserInfoFromToken(user.Data.Token);
                        if (GlobalModel.UserInfo != null)
                        {
                            fHome form1 = new fHome();
                            form1.Show();
                            SplashScreenManager.CloseForm(false);
                            btnLogin.Enabled = true;
                            this.Hide();
                        }
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(user.Message, 4);
                        btnLogin.Enabled = true;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Log.Error($"{nameof(fLogin)}, params; {nameof(btnLogin_Click)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);

                return;
            }
            SplashScreenManager.CloseForm(false);
        }
        public async Task<TokenInfo> GetUserInfoFromToken(string jwtToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtTokenObj = tokenHandler.ReadJwtToken(jwtToken);

            var permissionsClaim = jwtTokenObj.Claims.FirstOrDefault(claim => claim.Type == "permissions")?.Value;
            var storeClaim = jwtTokenObj.Claims.FirstOrDefault(claim => claim.Type == "store")?.Value;
            var userIdClaim = jwtTokenObj.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value;
            var userNameClaim = jwtTokenObj.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Name)?.Value;

            List<PermissionModel> permissions = new List<PermissionModel>();
            //if (!string.IsNullOrEmpty(permissionsClaim))
            //{
            //    permissions = JsonConvert.DeserializeObject<List<PermissionModel>>(permissionsClaim);
            //}
            UsersController usersController = new UsersController();
            var result = await usersController.GetPermissionsByIdUser(jwtToken, userIdClaim);
            if(result != null)
            {
                permissions.AddRange(result.Data);
            }

            string store = null;
            if (!string.IsNullOrEmpty(storeClaim))
            {
                store = storeClaim;
            }

            var userInfo = new TokenInfo
            {
                Permissions = permissions ?? new List<PermissionModel>(),
                StoreCode = store,
                Id = userIdClaim,
                Name = userNameClaim
            };

            return userInfo;
        }
    }
}
