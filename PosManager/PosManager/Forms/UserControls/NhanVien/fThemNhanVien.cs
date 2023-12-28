using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using PosManager.APIServices.CaiDat;
using PosManager.APIServices.User;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.User;

namespace Krypton_toolKitDemo
{
    public partial class fThemNhanVien : KryptonForm
    {
        private AuthenticateController _authenticateController;
        private string _idUser { get; set; }
        public fThemNhanVien(string? idUser)
        {
            InitializeComponent();
            _idUser = idUser;
            _authenticateController = new AuthenticateController();
            cbbChucVu.SelectedIndex = 0;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_idUser))
            {
                UsersController usersController = new UsersController();
                var result = await usersController.GetById(GlobalModel.AccsessToken, _idUser);
                if (result != null && result.Data != null)
                {
                    txtEmail.Text = result.Data.Email;
                    label7.Visible = false;
                    txtPassword.Visible = false;
                    txtDiaChi.Text = result.Data.Address;
                    txtUsername.Text = result.Data.UserName;
                    txtCCCD.Text = result.Data.CCCD;
                    txtPhonenumber.Text = result.Data.PhoneNumber;
                    dateNgaySinh.Value = (DateTime)result.Data.DateOfBirth;
                    txtTen.Text = result.Data.FullName;
                    cbbChucVu.SelectedIndex = 1;
                    if (result.Data.Role == "SysAdmin")
                    {
                        cbbChucVu.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtPhonenumber.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                return;
            }
            if (string.IsNullOrEmpty(_idUser))
            {
                UserModel user = new UserModel();
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.Address = txtDiaChi.Text;
                user.UserName = txtUsername.Text;
                user.CCCD = txtCCCD.Text;
                user.PhoneNumber = txtPhonenumber.Text;
                user.DateOfBirth = dateNgaySinh.Value;
                user.FullName = txtTen.Text;
                user.Role = "SysAdmin";
                if (cbbChucVu.SelectedIndex == 1)
                {
                    user.Role = "NhanVien";
                }
                var result = await _authenticateController.Create(GlobalModel.AccsessToken, user);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
        }
    }
}
