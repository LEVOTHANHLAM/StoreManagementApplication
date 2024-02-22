using DevExpress.XtraBars.Navigation;
using DevExpress.XtraSplashScreen;
using Krypton_toolKitDemo;
using PosManager.APIServices.HoaDon;
using PosManager.APIServices.Kho;
using PosManager.APIServices.SanPham;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.Kho;
using PosManager.Model.SanPham;
using Serilog;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class fNhapKhoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        private fHome _fHome;
        private List<ProductsModel> products = new List<ProductsModel>();
        private List<StockModel> stocks = new List<StockModel>();
        private List<SupplierModel> suppliers = new List<SupplierModel>();
        public fNhapKhoHangHoa(fHome home)
        {
            _fHome = home;
            InitializeComponent();
        }
        private async Task<List<ProductsModel>> GetAllProduct()
        {
            try
            {
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                ProductsController productsController = new ProductsController();
                var result = await productsController.Search(GlobalModel.AccsessToken, "1", "9999999", "");
                SplashScreenManager.CloseForm(false);
                if (result != null && result.StatusCode == 200 && result.Data.Total > 0)
                {
                    return result.Data.Result;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

            }
            SplashScreenManager.CloseForm(false);
            return null;
        }
        private async Task<List<StockModel>> GetAllStock()
        {
            try
            {
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                StocksController stocksController = new StocksController();
                var result = await stocksController.GetAll(GlobalModel.AccsessToken);
                SplashScreenManager.CloseForm(false);
                if (result != null && result.StatusCode == 200 && result.Data.Count > 0)
                {
                    return result.Data;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

            }
            SplashScreenManager.CloseForm(false);
            return null;
        }
        private async Task<List<SupplierModel>> GetAllNhaCungCap()
        {
            try
            {
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                SuppliersController suppliersController = new SuppliersController();
                var result = await suppliersController.Search(GlobalModel.AccsessToken, "1", "9999999", "");
                SplashScreenManager.CloseForm(false);
                if (result != null && result.StatusCode == 200 && result.Data.Total > 0)
                {
                    return result.Data.Result;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

            }
            SplashScreenManager.CloseForm(false);
            return null;
        }

        private List<AccordionControlElement> CreateProduct(List<ProductsModel> products)
        {
            List<AccordionControlElement> accordionControlElements = new List<AccordionControlElement>();
            foreach (var product in products)
            {
                ///
                DevExpress.XtraEditors.TextEdit text = new DevExpress.XtraEditors.TextEdit();
                text.Enabled = false;
                text.Location = new Point(374, 45);
                text.MenuManager = fluentFormDefaultManager1;
                text.Name = "textEdit1";
                text.Size = new Size(117, 20);
                text.TabIndex = 2;
                text.Visible = false;
                ///
                AccordionControlElement accordionControlElement = new AccordionControlElement();
                accordionControlElement.Name = product.Id.ToString();
                accordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                accordionControlElement.Text = $" {product.MaHangHoa}  -  {product.TenHangHoa}";
                accordionControlElement.Click += accordionControlElement_Click;
                //
                //accordionControlElement.Controls.Add(text);
                accordionControlElements.Add(accordionControlElement);
            }
            return accordionControlElements;
        }

        private void accordionControlElement_Click(object? sender, EventArgs e)
        {
            AccordionControlElement accordionControlElement = (AccordionControlElement)sender;
            string name = accordionControlElement.Text.Split("  -  ").FirstOrDefault();
            string id = accordionControlElement.Name;
            var model = products.FirstOrDefault(x => x.Id.ToString() == id);
            ItemControlProductImportKho control1 = new ItemControlProductImportKho(model, flowLayoutPanel1);
            control1.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(control1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private async void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            fThemHangHoa fThemHangHoa = new fThemHangHoa();
            fThemHangHoa.ShowDialog();
            accordionControl1.Elements.Clear();
            var listProduct = await GetAllProduct();
        }

        private async void btnThemNCC_Click(object sender, EventArgs e)
        {
            fThemNCC themNCC = new fThemNCC(null);
            themNCC.ShowDialog();
            var listsupplier = await GetAllNhaCungCap();
            if (listsupplier != null)
            {
                suppliers.Clear();
                suppliers.AddRange(listsupplier);
                cbbNCC.Items.Clear();
                foreach (var supplier in suppliers)
                {
                    cbbNCC.Items.Add($"{supplier.SoDienThoai} - {supplier.TenNhaCungCap}");
                    cbbNCC.SelectedItem = $"{supplier.SoDienThoai} - {supplier.TenNhaCungCap}";
                }
                if (!string.IsNullOrEmpty(themNCC.Message))
                {
                    cbbNCC.SelectedItem = $"{suppliers.FirstOrDefault(x => x.SoDienThoai == themNCC.Message).SoDienThoai} - {suppliers.FirstOrDefault(x => x.SoDienThoai == themNCC.Message).TenNhaCungCap}";
                }

            }
        }

        private void cbbKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (MessageCommon.ShowConfirmationBox($"Bạn chắc chắn muốn nhập hàng hoá vào kho {cbbKho.SelectedItem.ToString()}!") == DialogResult.Yes)
            {
                WarehousesController warehouses = new WarehousesController();
                WarehouseModel model = new WarehouseModel();
                model.MaKho = stocks.FirstOrDefault(x => x.TenKho == cbbKho.SelectedItem.ToString()).MaKho;
                model.MaNhaCungCap = suppliers.FirstOrDefault(x => x.SoDienThoai == cbbNCC.SelectedItem.ToString().Split(" - ").FirstOrDefault()).MaNhaCungCap;
                model.Details = new List<WarehouseDetailModel>();
                foreach (var control in flowLayoutPanel1.Controls)
                {
                    ItemControlProductImportKho itemControl = control as ItemControlProductImportKho;
                    WarehouseDetailModel detailModel = new WarehouseDetailModel();
                    detailModel.MaHangHoa = itemControl.labelMaSanPham.Text.ToString();
                    detailModel.MaDonViNhap = products.FirstOrDefault(x => x.MaHangHoa == detailModel.MaHangHoa).GiaBan.FirstOrDefault(x => x.TenDonViHangHoa == itemControl.cbbTenDonViTinh.SelectedItem.ToString()).MaDonViHangHoa;
                    detailModel.DonGiaNhap = decimal.Parse(itemControl.LabelSubtotal.Text.ToString());
                    detailModel.SoLuongNhap = float.Parse(itemControl.txtSoLuong.Text.ToString());
                    detailModel.HanSuDung = itemControl.dateHSD.Value;
                    model.Details.Add(detailModel);
                }
                var result = await warehouses.Add(GlobalModel.AccsessToken, model);
                if (result != null && result.StatusCode == 200 && !string.IsNullOrEmpty(result.Data))
                {
                    HoaDonNhapController hoaDonNhapController = new HoaDonNhapController();
                    var hoadonnhap = await hoaDonNhapController.GetById(GlobalModel.AccsessToken, result.Data);
                    if (hoadonnhap != null && hoadonnhap.StatusCode == 200)
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        fUpdateHoaDonNhapKho fUpdateHoaDonNhapKho = new fUpdateHoaDonNhapKho(splitContainer1.Panel2, panel5, hoadonnhap.Data);
                        fUpdateHoaDonNhapKho.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(fUpdateHoaDonNhapKho);
                    }
                    else
                    {
                        MessageCommon.ShowMessageBox("Vui lòng thử lại!");
                    }

                }
                else
                {
                    MessageCommon.ShowMessageBox("Vui lòng thử lại!");
                }

            }

        }

        private async void fNhapKhoHangHoa_Load(object sender, EventArgs e)
        {
            accordionControl1.Elements.Clear();
            var listProduct = await GetAllProduct();
            if (listProduct != null)
            {
                products.Clear();
                products.AddRange(listProduct);
                foreach (var control in CreateProduct(products))
                {
                    accordionControl1.Elements.Add(control);
                }
            }
            var listStock = await GetAllStock();
            if (listStock != null)
            {
                stocks.Clear();
                cbbKho.Items.Clear();
                stocks.AddRange(listStock);
                foreach (var stock in stocks)
                {
                    cbbKho.Items.Add(stock.TenKho);
                }
                cbbKho.SelectedItem = stocks.FirstOrDefault().TenKho;
            }
            var listsupplier = await GetAllNhaCungCap();
            if (listsupplier != null)
            {
                suppliers.Clear();
                suppliers.AddRange(listsupplier);
                cbbNCC.Items.Clear();
                foreach (var supplier in suppliers)
                {
                    cbbNCC.Items.Add($"{supplier.SoDienThoai} - {supplier.TenNhaCungCap}");

                }
                cbbNCC.SelectedItem = $"{suppliers.Last().SoDienThoai} - {suppliers.Last().TenNhaCungCap}";
            }
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
