using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.ChiNhanh;
using PosManager.APIServices.Kho;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.ChiNhanh;
using PosManager.Model.Kho;

namespace Krypton_toolKitDemo
{
    public partial class fThemChiNhanh : KryptonForm
    {
        private StoreModel _store { get; set; }
        List<StockModel> stocks = new List<StockModel>();
        public fThemChiNhanh(StoreModel? storeModel)
        {
            InitializeComponent();
            if (storeModel != null)
            {
                _store = storeModel;
                txtMaCuaHang.Text = storeModel.MaCuaHang;
                txtTenCuaHang.Text = storeModel.TenCuaHang;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            StocksController stocksController = new StocksController();
            var result = await stocksController.Search(GlobalModel.AccsessToken, "1", "99999");
            if (result != null && result.Data.Result.Any())
            {
                stocks.AddRange(result.Data.Result);
                if (stocks.Any())
                {
                    cbbMaKho.Items.Clear();
                    foreach (var item in stocks)
                    {
                        cbbMaKho.Items.Add(item.MaKho);
                    }

                }
            }
            cbbMaKho.SelectedIndex = 0;
            if (_store != null)
            {
                if (cbbMaKho.Items.Count > 0)
                {
                    cbbMaKho.SelectedItem = _store.MaKho;
                    cbbChucVu_SelectedIndexChanged(null, null);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaCuaHang.Text) || string.IsNullOrEmpty(txtTenCuaHang.Text))
                {
                    MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                    return;
                }
                StoresController storesController = new StoresController();
                StoreModel storeModel = new StoreModel();
                storeModel.MaCuaHang = txtMaCuaHang.Text.Trim();
                storeModel.TenCuaHang = txtTenCuaHang.Text.Trim();
                storeModel.MaKho = cbbMaKho.SelectedItem.ToString();
                if (_store != null)
                {
                   storeModel.Id = _store.Id;
                    var result = await storesController.Edit(GlobalModel.AccsessToken, storeModel);
                    if (result != null)
                    {
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                else
                {
                    var result = await storesController.Add(GlobalModel.AccsessToken, storeModel);
                    if (result != null)
                    {
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }

            }
            catch (Exception ex)
            {

            }

          
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaKho.Items.Count > 0)
            {
                var maKho = cbbMaKho.SelectedItem.ToString();
                foreach (var item in stocks)
                {
                    if (item.MaKho == maKho)
                    {
                        txtTenKho.Text = item.TenKho;
                        break;
                    }
                }
            }
        }
    }
}
