using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.ChiNhanh;
using PosManager.APIServices.SanPham;
using PosManager.Forms.UI;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.ChiNhanh;
using PosManager.Model.SanPham;
using Serilog;

namespace PosManager
{
    public partial class fChiTietHangHoa : KryptonForm
    {
        private string Id;
        private ProductsModel Products;
        private StoresController _storesController;
        private CategoriesController _categoriesController;
        private ProductUnitsController _productUnitsController;
        private ProductsController _productsController;
        private List<StoreModel> storeModels = new List<StoreModel>();
        private List<DonViHangHoaModel> donViHangHoaModesl = new List<DonViHangHoaModel>();
        private List<CategoryModel> categoryModels = new List<CategoryModel>();
        public fChiTietHangHoa(string id)
        {
            InitializeComponent();
            _storesController = new StoresController();
            _productUnitsController = new ProductUnitsController();
            _productsController = new ProductsController();
            _categoriesController = new CategoriesController();
            txtVAT.Text = "0 %";
            Id = id;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                var result = await _productsController.GetById(GlobalModel.AccsessToken, Id);
                if (result != null && result.Data != null)
                {
                    Products = result.Data;
                    txtMaVach.Text = Products.MaHangHoa;
                    txtGhiChu.Text = Products.GhiChu;
                    txtTenHangHoa.Text = Products.TenHangHoa;
                    txtTenHangHoaKhongDau.Text = Products.TenHangHoaKhongDau;
                    txtVAT.Text = Products.VAT.ToString() + " %";

                    var stores = await _storesController.GetAll(GlobalModel.AccsessToken);
                    if (stores != null && stores.Data.Any())
                    {
                        storeModels.Clear();
                        storeModels.AddRange(stores.Data);
                    }
                    var donViHangHoas = await _productUnitsController.GetAll(GlobalModel.AccsessToken);
                    if (donViHangHoas != null && donViHangHoas.Data.Any())
                    {
                        donViHangHoaModesl.Clear();
                        donViHangHoaModesl.AddRange(donViHangHoas.Data);
                    }
                    var loaiSanPhams = await _categoriesController.Search(GlobalModel.AccsessToken, "1", "99999", "");
                    if (loaiSanPhams != null && loaiSanPhams.Data.Result.Any())
                    {
                        categoryModels.Clear();
                        categoryModels.AddRange(loaiSanPhams.Data.Result);
                    }
                    if (!storeModels.Any() || !donViHangHoaModesl.Any() || !categoryModels.Any())
                    {
                        MessageCommon.ShowMessageBox("Đã xảy ra lỗi vui lòng thử lại!", 3);
                        Close();
                        return;
                    }
                    var details = await _productUnitsController.GetDetailByProductId(GlobalModel.AccsessToken, Id);
                    if (details != null && details.Data.Any())
                    {
                        Products.DonViKhac = new List<ProductUnitDetailModel>();
                        Products.DonViKhac.AddRange(details.Data);
                        if (Products.DonViKhac.Any())
                        {
                            SetRowDonViTinh();
                        }
                    }
                    dtgvCuaHang.Rows.Clear();
                    foreach (var item in Products.GiaBan)
                    {
                        var donviHH = item.MaDonViHangHoa + " - " + item.TenDonViHangHoa;
                        dtgvCuaHang.Rows.Add(item.TenCuaHang, donviHH, item.Gia, item.MaCuaHang, item.MaDonViHangHoa);
                    }
                }

            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetRowDonViTinh()
        {

        }


        private void dtgvDonViTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bool checker = true;
            //    if (string.IsNullOrEmpty(txtMaVach.Text.Trim()) || string.IsNullOrEmpty(txtTenHangHoa.Text.Trim()) || string.IsNullOrEmpty(txtTenHangHoaKhongDau.Text.Trim()))
            //    {
            //        MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
            //        return;
            //    }
            //    Products.MaHangHoa = txtMaVach.Text.Trim();
            //    Products.TenHangHoa = txtTenHangHoa.Text.Trim();
            //    Products.TenHangHoaKhongDau = txtTenHangHoaKhongDau.Text.Trim();
                
            //    products.MaDonViCoBan = cbbMaDonviCoBan.SelectedItem.ToString().Split(" - ").FirstOrDefault();
            //    products.MaVach = txtMaVach.Text.Trim();
            //    products.VAT = double.Parse(txtVAT.Text.Trim().Split(" %").FirstOrDefault());
            //    products.DonViKhac = new List<ProductUnitDetailModel>();
            //    products.GiaBan = new List<PriceModel>();
            //    foreach (DataGridViewRow row in dtgvDonViTinh.Rows)
            //    {
            //        if (string.IsNullOrEmpty(row.Cells["cQuyDoi"].Value.ToString()))
            //        {
            //            MessageCommon.ShowMessageBox("Chưa Nhập Số Lượng Quy Đổi");
            //            checker = false;
            //            break;
            //        }
            //        ProductUnitDetailModel donViHangHoa = new ProductUnitDetailModel();
            //        donViHangHoa.MaHangHoa = txtMaVach.Text.Trim();
            //        var madonviHangHoa = row.Cells["cTenDonViTinh"].Value.ToString().Split(" - ").FirstOrDefault();
            //        donViHangHoa.MaDonViHangHoa = madonviHangHoa;
            //        donViHangHoa.TyLeChuyenDoi = float.Parse(row.Cells["cQuyDoi"].Value.ToString());
            //        products.DonViKhac.Add(donViHangHoa);
            //    }
            //    foreach (DataGridViewRow row in dtgvCuaHang.Rows)
            //    {
            //        PriceModel priceModel = new PriceModel();
            //        priceModel.MaHangHoa = txtMaVach.Text.Trim();
            //        priceModel.MaCuaHang = row.Cells["cMaCuaHang"].Value.ToString();
            //        priceModel.MaDonViHangHoa = row.Cells["cMaDonViTinh"].Value.ToString();
            //        priceModel.Gia = decimal.Parse(row.Cells["cGia"].Value.ToString());
            //        products.GiaBan.Add(priceModel);
            //    }
            //    if (checker == true)
            //    {
            //        var result = await _productsController.Add(GlobalModel.AccsessToken, products);
            //        if (result != null)
            //        {
            //            MessageCommon.ShowMessageBox(result.Message);
            //            if (result.StatusCode == 200)
            //            {
            //                Close();
            //            }
            //        }
            //        else
            //        {
            //            MessageCommon.ShowMessageBox("Vui Lòng Thử Lại!");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log.Error(ex, ex.Message);
            //    MessageCommon.ShowMessageBox(ex.Message, 3);
            //}
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAT_Click(object sender, EventArgs e)
        {
            fNhapSo fNhap = new fNhapSo(null);
            fNhap.ShowDialog();
            if (!string.IsNullOrEmpty(fNhap.SoLuong))
            {
                txtVAT.Text = fNhap.SoLuong + " %";
            }
        }

        private void dtgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvCuaHang.Columns["cGia"].Index)
            {
                fNhapSo fNhap = new fNhapSo(null);
                fNhap.ShowDialog();
                if (!string.IsNullOrEmpty(fNhap.SoLuong))
                {
                    dtgvCuaHang.Rows[e.RowIndex].Cells["cGia"].Value = fNhap.SoLuong;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChiTietDVT_Click(object sender, EventArgs e)
        {
            fChiTietDVT_HangHoa fChiTietDVT_Hang = new fChiTietDVT_HangHoa(Id);
            fChiTietDVT_Hang.ShowDialog();
        }

        private void txtVAT_MouseEnter(object sender, EventArgs e)
        {
            fNhapSo fNhap = new fNhapSo(txtVAT.Text.Trim().Split(" %").FirstOrDefault());
            fNhap.ShowDialog();
            decimal value;
            if (!string.IsNullOrEmpty(fNhap.SoLuong) && decimal.TryParse(fNhap.SoLuong, out value))
            {
                if (value < 100)
                {
                    txtVAT.Text = fNhap.SoLuong + " %";
                }

            }
        }
    }
}
