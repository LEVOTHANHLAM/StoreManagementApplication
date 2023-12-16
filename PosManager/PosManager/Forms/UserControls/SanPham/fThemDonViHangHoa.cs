using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.SanPham;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.SanPham;

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
            DonViHangHoaModel donViHangHoaModel = new DonViHangHoaModel();
            donViHangHoaModel.TenDonViHangHoa = txtTenDonViHH.Text;
            donViHangHoaModel.MaDonViHangHoa = txtMaDonViHH.Text.Trim();
            if (string.IsNullOrEmpty(_id))
            {
                var result = await _productUnitsController.Add(GlobalModel.AccsessToken, donViHangHoaModel);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
            else
            {
                donViHangHoaModel.Id = Guid.Parse(_id);
                var result = await _productUnitsController.Edit(GlobalModel.AccsessToken, donViHangHoaModel);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
            txtMaDonViHH.Text = "";
            txtTenDonViHH.Text = "";
        }
    }
}
