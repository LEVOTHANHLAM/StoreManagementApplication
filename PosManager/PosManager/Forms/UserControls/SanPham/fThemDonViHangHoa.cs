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
    public partial class fThemDonViHangHoa : KryptonForm
    {
        private ProductUnitsController _productUnitsController;
        private List<CategoryModel> categoryModels = new List<CategoryModel>();
        private string _id { get; set; }
        public fThemDonViHangHoa(string? id)
        {
            InitializeComponent();
            _id = id;
            _productUnitsController = new ProductUnitsController();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_id))
            {
                var resultCategories = await _productUnitsController.GetById(GlobalModel.AccsessToken, _id);
                if (resultCategories != null && resultCategories.Data != null)
                {
                    txtMaDonViHH.Text = resultCategories.Data.MaDonViHangHoa;
                    txtTenDonViHH.Text = resultCategories.Data.TenDonViHangHoa;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDonViHH.Text) || string.IsNullOrEmpty(txtTenDonViHH.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                return;
            }
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            try
            {
                DonViHangHoaModel donViHangHoaModel = new DonViHangHoaModel();
                donViHangHoaModel.TenDonViHangHoa = txtTenDonViHH.Text;
                donViHangHoaModel.MaDonViHangHoa = txtMaDonViHH.Text.Trim();
                if (string.IsNullOrEmpty(_id))
                {
                    var result = await _productUnitsController.Add(GlobalModel.AccsessToken, donViHangHoaModel);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox("Vui Lòng Thử Lại!");
                    }
                }
                else
                {
                    donViHangHoaModel.Id = Guid.Parse(_id);
                    var result = await _productUnitsController.Edit(GlobalModel.AccsessToken, donViHangHoaModel);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox("Vui Lòng Thử Lại!");
                    }
                }
                txtMaDonViHH.Text = "";
                txtTenDonViHH.Text = "";
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message, 3);
            }
            SplashScreenManager.CloseForm(false);
        }
    }
}
