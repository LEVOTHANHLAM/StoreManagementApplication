using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using PosManager.APIServices.ChiNhanh;
using PosManager.APIServices.SanPham;
using PosManager.Forms;
using PosManager.Forms.UI;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.ChiNhanh;
using PosManager.Model.SanPham;
using Serilog;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PosManager
{
    public partial class fThemHangHoa : KryptonForm
    {
        private StoresController _storesController;
        private CategoriesController _categoriesController;
        private ProductUnitsController _productUnitsController;
        private ProductsController _productsController;
        private List<StoreModel> storeModels = new List<StoreModel>();
        private List<DonViHangHoaModel> donViHangHoaModesl = new List<DonViHangHoaModel>();
        private List<CategoryModel> categoryModels = new List<CategoryModel>();
        public fThemHangHoa()
        {
            InitializeComponent();
            _storesController = new StoresController();
            _productUnitsController = new ProductUnitsController();
            _productsController = new ProductsController();
            _categoriesController = new CategoriesController();
            txtVAT.Text = "0 %";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
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
            cbbMaDonviCoBan.Items.Clear();
            foreach (var donViHangHoa in donViHangHoaModesl)
            {
                var name = donViHangHoa.MaDonViHangHoa + " - " + donViHangHoa.TenDonViHangHoa;
                cbbMaDonviCoBan.Items.Add(name);
            }
            cbbMaDonviCoBan.SelectedIndex = 0;

            cbbMaNhomHang.Items.Clear();
            cbbMaNhomHang.Items.Add("None");
            foreach (var categoryModel in categoryModels)
            {
                if (categoryModel.MaNhomHang != "ROOT")
                {
                    cbbMaNhomHang.Items.Add($"{categoryModel.MaNhomHang} - {categoryModel.TenNhomHang}");
                }
            }
            cbbMaNhomHang.SelectedIndex = 0;
            AddRowtgvCuaHang();
        }
        private void AddRowtgvCuaHang()
        {
            dtgvCuaHang.Rows.Clear();
            var maDonviTinhCoBan = cbbMaDonviCoBan.SelectedItem.ToString().Split(" - ").FirstOrDefault();
            var tenDonViTinhCoBan = cbbMaDonviCoBan.SelectedItem.ToString().Split(" - ").Last();
            if (!string.IsNullOrEmpty(maDonviTinhCoBan))
            {
                foreach (var store in storeModels)
                {
                    dtgvCuaHang.Rows.Add(store.TenCuaHang, tenDonViTinhCoBan, "0", store.MaCuaHang, tenDonViTinhCoBan);
                }
            }
            if (dtgvDonViTinh.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvDonViTinh.Rows)
                {
                    var cellValue = row.Cells["cTenDonViTinh"].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        var maDonviTinh = cellValue.ToString().Split(" - ").FirstOrDefault();
                        var tenDonViTinh = cellValue.ToString().Split(" - ").Last();
                        foreach (var store in storeModels)
                        {
                            dtgvCuaHang.Rows.Add(store.TenCuaHang, tenDonViTinh, "0", store.MaCuaHang, maDonviTinh);
                        }
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

        private void btnAddColumdtgvDonViTinh_Click(object sender, EventArgs e)
        {
            var maDonviTinhCoBan = cbbMaDonviCoBan.SelectedItem.ToString().Split(" - ").FirstOrDefault();
            List<string> list = new List<string>();
            list.Clear();
            foreach (DataGridViewRow row in dtgvDonViTinh.Rows)
            {
                var cellValue = row.Cells["cTenDonViTinh"].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    var maDonviTinh = cellValue.ToString().Split(" - ").FirstOrDefault();
                    var tenDonViTinh = cellValue.ToString().Split(" - ").Last();
                    list.Add(maDonviTinh);
                }

            }
            list.Add(maDonviTinhCoBan);
            int rowIndex = dtgvDonViTinh.Rows.Add(PosManager.Properties.Resources.delete15, null, "0");
            foreach (var donViTinh in donViHangHoaModesl)
            {
                if (!list.Contains(donViTinh.MaDonViHangHoa))
                {
                    // Lấy index của ô ComboBox trong hàng vừa thêm
                    int columnIndex = dtgvDonViTinh.Columns["cTenDonViTinh"].Index;
                    var name = donViTinh.MaDonViHangHoa + " - " + donViTinh.TenDonViHangHoa;
                    // Thêm một mục vào ComboBox trong ô ComboBox tại hàng và cột đã xác định
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dtgvDonViTinh.Rows[rowIndex].Cells[columnIndex];
                    cell.Items.Add(name); // Thêm mục vào ComboBox
                    if (cell.Items.Count > 0)
                    {
                        cell.Value = cell.Items[0];
                    }
                }
            }
            AddRowtgvCuaHang();
        }

        private void dtgvDonViTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
          
            try
            {
                bool checker = true;
                if (string.IsNullOrEmpty(txtMaVach.Text.Trim()) || string.IsNullOrEmpty(txtTenHangHoa.Text.Trim()) || string.IsNullOrEmpty(txtTenHangHoaKhongDau.Text.Trim()))
                {
                    MessageCommon.ShowMessageBox("Vui lòng nhập thông tin?");
                    return;
                }

                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                try
                {
                    ProductsModel products = new ProductsModel();
                    products.MaHangHoa = txtMaVach.Text.Trim();
                    products.TenHangHoa = txtTenHangHoa.Text.Trim();
                    products.TenHangHoaKhongDau = txtTenHangHoaKhongDau.Text.Trim();
                    if (cbbMaNhomHang.SelectedItem.ToString() == "None")
                    {
                        products.MaNhomHang = "ROOT";
                    }
                    else
                    {
                        products.MaNhomHang = cbbMaNhomHang.SelectedItem.ToString().Split(" - ").FirstOrDefault();
                    }
                    products.MaDonViCoBan = cbbMaDonviCoBan.SelectedItem.ToString().Split(" - ").FirstOrDefault();
                    products.MaVach = txtMaVach.Text.Trim();
                    products.VAT = double.Parse(txtVAT.Text.Trim().Split(" %").FirstOrDefault());
                    products.DonViKhac = new List<ProductUnitDetailModel>();
                    products.GiaBan = new List<PriceModel>();
                    foreach (DataGridViewRow row in dtgvDonViTinh.Rows)
                    {
                        if (string.IsNullOrEmpty(row.Cells["cQuyDoi"].Value.ToString()))
                        {
                            SplashScreenManager.CloseForm(false);
                            MessageCommon.ShowMessageBox("Chưa Nhập Số Lượng Quy Đổi");
                            checker = false;
                            break;
                        }
                        ProductUnitDetailModel donViHangHoa = new ProductUnitDetailModel();
                        donViHangHoa.MaHangHoa = txtMaVach.Text.Trim();
                        var madonviHangHoa = row.Cells["cTenDonViTinh"].Value.ToString().Split(" - ").FirstOrDefault();
                        donViHangHoa.MaDonViHangHoa = madonviHangHoa;
                        donViHangHoa.TyLeChuyenDoi = float.Parse(row.Cells["cQuyDoi"].Value.ToString());
                        products.DonViKhac.Add(donViHangHoa);
                    }
                    foreach (DataGridViewRow row in dtgvCuaHang.Rows)
                    {
                        PriceModel priceModel = new PriceModel();
                        priceModel.MaHangHoa = txtMaVach.Text.Trim();
                        priceModel.MaCuaHang = row.Cells["cMaCuaHang"].Value.ToString();
                        priceModel.MaDonViHangHoa = row.Cells["cMaDonViTinh"].Value.ToString();
                        priceModel.Gia = decimal.Parse(row.Cells["cGia"].Value.ToString());
                        products.GiaBan.Add(priceModel);
                    }
                    if (checker == true)
                    {
                        var result = await _productsController.Add(GlobalModel.AccsessToken, products);
                        if (result != null)
                        {
                            SplashScreenManager.CloseForm(false);
                            MessageCommon.ShowMessageBox(result.Message);
                            if (result.StatusCode == 200)
                            {
                                Close();
                            }
                        }
                        else
                        {
                            SplashScreenManager.CloseForm(false);
                            MessageCommon.ShowMessageBox("Vui Lòng Thử Lại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    SplashScreenManager.CloseForm(false);
                    Log.Error(ex, ex.Message);
                    MessageCommon.ShowMessageBox(ex.Message, 3);
                }
              
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message, 3);
            }

        }

        private void dtgvDonViTinh_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgvDonViTinh.CurrentCell.ColumnIndex == 1) // Thay columnIndex bằng chỉ số cột chứa ComboBox
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= comboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
                }
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbMaDonviCoBan.Text))
            {
                AddRowtgvCuaHang();
            }
        }
        private void dtgvDonViTinh_EditModeChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDonViTinh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbMaDonviCoBan.Text))
            {
                AddRowtgvCuaHang();
            }

        }

        private void dtgvDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvDonViTinh.Columns["cQuyDoi"].Index)
            {
                fNhapSo fNhap = new fNhapSo(dtgvDonViTinh.Rows[e.RowIndex].Cells["cQuyDoi"].Value.ToString());
                fNhap.ShowDialog();
                if (!string.IsNullOrEmpty(fNhap.SoLuong))
                {
                    dtgvDonViTinh.Rows[e.RowIndex].Cells["cQuyDoi"].Value = fNhap.SoLuong;
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvDonViTinh.Columns["cDelete"].Index)
            {
                DataGridViewRow row = dtgvDonViTinh.Rows[e.RowIndex];
                dtgvDonViTinh.Rows.Remove(row);
                AddRowtgvCuaHang();
            }
        }

        private void cbbMaDonviCoBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvDonViTinh.Rows.Clear();
            AddRowtgvCuaHang();
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAT_Click(object sender, EventArgs e)
        {
            fNhapSo fNhap = new fNhapSo(txtVAT.Text.Trim());
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
                fNhapSo fNhap = new fNhapSo(dtgvCuaHang.Rows[e.RowIndex].Cells["cGia"].Value.ToString());
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

        private void txtVAT_MouseHover(object sender, EventArgs e)
        {
            //fNhapSo fNhap = new fNhapSo(txtVAT.Text.Trim());
            //fNhap.ShowDialog();
            //if (!string.IsNullOrEmpty(fNhap.SoLuong))
            //{
            //    txtVAT.Text = fNhap.SoLuong + " %";
            //}
        }

        private void txtVAT_MouseEnter(object sender, EventArgs e)
        {
            fNhapSo fNhap = new fNhapSo(txtVAT.Text.Trim().Split(" %").FirstOrDefault());
            fNhap.ShowDialog();
            decimal value;
            if (!string.IsNullOrEmpty(fNhap.SoLuong) && decimal.TryParse(fNhap.SoLuong, out value))
            {
                if(value < 100)
                {
                    txtVAT.Text = fNhap.SoLuong + " %";
                }
               
            }
        }
    }
}
