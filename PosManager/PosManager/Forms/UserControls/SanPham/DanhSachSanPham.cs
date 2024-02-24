using DevExpress.XtraSplashScreen;
using PosManager;
using PosManager.APIServices.SanPham;
using PosManager.Helper;
using PosManager.Model;
using Serilog;

namespace PosManager.Forms.UserControls.SanPham
{
    public partial class DanhSachSanPham : UserControl
    {
        private fHome _fHome;
        public DanhSachSanPham(fHome fHome)
        {
            _fHome = fHome;
            InitializeComponent();
            GetAllProduct(1, 9999999, txtSearchSanPham.Text.Trim());
        }

        private void panelMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtSearchSanPham_TextChanged(object sender, EventArgs e)
        {
            GetAllProduct(1, 9999999, txtSearchSanPham.Text.Trim());
        }
        private async void GetAllProduct(int pageIndex = 1, int pageSize = 9999999, string? searchString = "")
        {
            try
            {
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                if (searchString == "Tìm Kiếm")
                {
                    searchString = "";
                }
                else if (searchString.Contains("NGAYNHAP"))
                {
                    searchString = searchString.Split("NGAYNHAP").FirstOrDefault();
                }
                ProductsController productsController = new ProductsController();
                var accounts = await productsController.Search(GlobalModel.AccsessToken, pageIndex.ToString(), pageSize.ToString(), searchString);
                if (accounts != null && accounts.StatusCode == 200 && accounts.Data.Result.Count > 0)
                {
                    LayoutMain.Controls.Clear();
                    foreach (var account in accounts.Data.Result)
                    {
                        ItemProduct itemProduct = new ItemProduct(account, LayoutMain);
                        LayoutMain.Controls.Add(itemProduct);
                    }
                }
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(GetAllProduct)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            fThemHangHoa themHangHoa = new fThemHangHoa();
            themHangHoa.ShowDialog();
            GetAllProduct(1, 9999999, txtSearchSanPham.Text.Trim());
        }
    }
}
