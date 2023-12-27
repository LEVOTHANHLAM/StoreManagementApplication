using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.Kho;
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
                    cbbChucVu.Items.Clear();
                    foreach (var item in stocks)
                    {
                        cbbChucVu.Items.Add(item.MaKho);
                    }

                }
            }
            cbbChucVu.SelectedIndex = 0;
            if (_store != null)
            {
                if (cbbChucVu.Items.Count > 0)
                {
                    cbbChucVu.SelectedItem = _store.MaKho;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
              

            if (_store != null)
            {

            }
            else
            {

            }
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.Items.Count > 0)
            {
                var maKho = cbbChucVu.SelectedItem.ToString();
                foreach (var item in stocks)
                {
                    if (item.MaKho == maKho)
                    {
                        txtUsername.Text = item.TenKho;
                        break;
                    }
                }
            }
        }
    }
}
