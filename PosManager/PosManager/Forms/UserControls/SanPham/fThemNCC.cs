using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using PosManager.APIServices.SanPham;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.SanPham;
using Serilog;

namespace Krypton_toolKitDemo
{
    public partial class fThemNCC : KryptonForm
    {
        private SuppliersController _suppliersController;
        private string _id { get; set; }
        public fThemNCC(string? id)
        {
            InitializeComponent();
            _id = id;
            _suppliersController = new SuppliersController();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_id))
            {
                var resultCategories = await _suppliersController.GetById(GlobalModel.AccsessToken, _id);
                if (resultCategories != null && resultCategories.Data != null)
                {
                    txtMaNCC.Text = resultCategories.Data.MaNhaCungCap;
                    txtTenNCC.Text = resultCategories.Data.TenNhaCungCap;
                    txtDiaChi.Text = resultCategories.Data.DiaChi;
                    txtSDT.Text = resultCategories.Data.SoDienThoai;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                return;
            }
          
            try
            {
               SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                SupplierModel supplierModel = new SupplierModel();
                supplierModel.TenNhaCungCap = txtTenNCC.Text.Trim();
                supplierModel.MaNhaCungCap = txtMaNCC.Text.Trim();
                supplierModel.DiaChi = txtDiaChi.Text.Trim();
                supplierModel.SoDienThoai = txtSDT.Text.Trim();
                if (string.IsNullOrEmpty(_id))
                {
                    var result = await _suppliersController.Add(GlobalModel.AccsessToken, supplierModel);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                else
                {
                    supplierModel.Id = Guid.Parse(_id);
                    var result = await _suppliersController.Edit(GlobalModel.AccsessToken, supplierModel);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message);
            }
            SplashScreenManager.CloseForm(false);
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
