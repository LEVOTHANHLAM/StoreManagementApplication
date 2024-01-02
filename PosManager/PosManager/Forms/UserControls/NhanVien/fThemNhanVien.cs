﻿using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using PosManager.APIServices.CaiDat;
using PosManager.APIServices.ChiNhanh;
using PosManager.APIServices.User;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.ChiNhanh;
using PosManager.Model.User;

namespace Krypton_toolKitDemo
{
    public partial class fThemNhanVien : KryptonForm
    {
        private AuthenticateController _authenticateController;
        private StoresController _storesController;
        List<StoreModel> _storeModels = new List<StoreModel>();
        private string _idUser { get; set; }
        private string maCuaHang { get; set; }
        public fThemNhanVien(string? idUser)
        {
            InitializeComponent();
            _idUser = idUser;
            _authenticateController = new AuthenticateController();
            cbbChucVu.SelectedIndex = 0;
            _storesController = new StoresController();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var resultStore = await _storesController.Search(GlobalModel.AccsessToken, "1", "99999");
            if (resultStore != null && resultStore.Data.Result.Any())
            {
                _storeModels.AddRange(resultStore.Data.Result);
                if (_storeModels.Any())
                {
                    cbbMaCuaHang.Items.Clear();
                    foreach (var item in _storeModels)
                    {
                        cbbMaCuaHang.Items.Add(item.MaCuaHang);
                    }

                }
            }
            cbbMaCuaHang.SelectedIndex = 0;
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
                    cbbMaCuaHang.SelectedItem = result.Data.MaCuaHang;
                    cbbMaCuaHang_SelectedIndexChanged(null, null);
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
                user.MaCuaHang = maCuaHang;
                var result = await _authenticateController.Create(GlobalModel.AccsessToken, user);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
        }

        private void cbbMaCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaCuaHang.Items.Count > 0)
            {
                var ma = cbbMaCuaHang.SelectedItem.ToString();
                foreach (var item in _storeModels)
                {
                    if (item.MaCuaHang == ma)
                    {
                        txtTenCuaHang.Text = item.TenCuaHang;
                        maCuaHang = item.MaCuaHang;
                        break;
                    }
                }
            }
        }
    }
}
