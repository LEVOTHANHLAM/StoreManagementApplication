using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.SanPham;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.SanPham;
using Serilog;

namespace Krypton_toolKitDemo
{
    public partial class fThemLoaiSanPham : KryptonForm
    {
        private CategoriesController _categoriesController;
        private List<CategoryModel> categoryModels = new List<CategoryModel>();
        private string _id { get; set; }
        public fThemLoaiSanPham(string? id)
        {
            InitializeComponent();
            _id = id;
            _categoriesController = new CategoriesController();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            loadComboBox();
            if (!string.IsNullOrEmpty(_id))
            {
                var resultCategories = await _categoriesController.GetById(GlobalModel.AccsessToken, _id);
                if (resultCategories != null && resultCategories.Data != null)
                {
                    txtMaNhomHang.Text = resultCategories.Data.MaNhomHang;
                    txtTenNhomHang.Text = resultCategories.Data.TenNhomHang;
                    if (resultCategories.Data.ParentCode != "ROOT")
                    {
                        cbbMaNhomChu.SelectedItem = $"{resultCategories.Data.ParentCode} - {resultCategories.Data.ParentName}";
                    }

                }
            }
        }
        private async void loadComboBox()
        {
            var result = await _categoriesController.Search(GlobalModel.AccsessToken, "1", "99999");
            if (result != null && result.Data.Result.Any())
            {
                categoryModels.AddRange(result.Data.Result);
                if (categoryModels.Count > 0)
                {
                    cbbMaNhomChu.Items.Clear();
                    cbbMaNhomChu.Items.Add("None");
                    foreach (var categoryModel in categoryModels)
                    {
                        if (categoryModel.MaNhomHang != "ROOT")
                        {
                            cbbMaNhomChu.Items.Add($"{categoryModel.MaNhomHang} - {categoryModel.TenNhomHang}");
                        }

                    }
                    cbbMaNhomChu.SelectedIndex = 0;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhomHang.Text) || string.IsNullOrEmpty(txtTenNhomHang.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                return;
            }
            fLoading loading = new fLoading();
            loading.StartLoading();
            try
            {
                CategoryModel category = new CategoryModel();
                category.TenNhomHang = txtTenNhomHang.Text;
                category.MaNhomHang = txtMaNhomHang.Text.Trim();
                var value = "ROOT";
                if (cbbMaNhomChu.Text != "None")
                {
                    value = cbbMaNhomChu.Text.Split(" - ").FirstOrDefault();
                }
                category.ParentId = categoryModels.FirstOrDefault(x => x.MaNhomHang == value).Id;
                if (string.IsNullOrEmpty(_id))
                {
                    var result = await _categoriesController.Add(GlobalModel.AccsessToken, category);
                    if (result != null)
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                else
                {
                    category.Id = Guid.Parse(_id);
                    var result = await _categoriesController.Edit(GlobalModel.AccsessToken, category);
                    if (result != null)
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox("Vui Lòng Thử Lại Sau!", 3);
                    }
                }
                loadComboBox();
                txtMaNhomHang.Text = "";
                txtTenNhomHang.Text = "";
                loading.Close();
            }
            catch (Exception ex)
            {
                loading.Close();
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message);
            }
            loading.Close();
        }
    }
}
