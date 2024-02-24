using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.SanPham;
using PosManager.Forms.UI;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.SanPham;
using Serilog;

namespace PosManager
{
    public partial class fChiTietDVT_HangHoa : KryptonForm
    {
        private string Id;
        private ProductUnitsController _productUnitsController;
        private List<DonViHangHoaModel> donViHangHoaModesl = new List<DonViHangHoaModel>();
        private List<ProductUnitDetailModel> unitDetailModels = new List<ProductUnitDetailModel>();
        public fChiTietDVT_HangHoa(string id)
        {
            InitializeComponent();
            _productUnitsController = new ProductUnitsController();
            Id = id;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var donViHangHoas = await _productUnitsController.GetAll(GlobalModel.AccsessToken);
            if (donViHangHoas != null && donViHangHoas.Data.Any())
            {
                donViHangHoaModesl.Clear();
                donViHangHoaModesl.AddRange(donViHangHoas.Data);
                cbbMaDonviCoBan.Items.Clear();
            }
            foreach (var model in donViHangHoaModesl)
            {
                cbbMaDonviCoBan.Items.Add($"{model.MaDonViHangHoa} - {model.TenDonViHangHoa}");
            }
            cbbMaDonviCoBan.SelectedIndex = 0;
            if (!string.IsNullOrEmpty(Id))
            {
                var result = await _productUnitsController.GetDetailByProductId(GlobalModel.AccsessToken, Id);
                if (result != null && result.Data != null)
                {
                    dtgvDonViTinh.Rows.Clear();
                    unitDetailModels = result.Data;
                    foreach (var model in unitDetailModels)
                    {
                        if (model.TyLeChuyenDoi == 1)
                        {
                            cbbMaDonviCoBan.SelectedItem = $"{model.MaDonViHangHoa} - {model.TenDonViHangHoa}";
                        }
                        else
                        {
                            int rowIndex = dtgvDonViTinh.Rows.Add(PosManager.Properties.Resources.delete15, null, model.TyLeChuyenDoi, model.MaDonViHangHoa, model.MaHangHoa, model.Id);
                            int columnIndex = dtgvDonViTinh.Columns["cTenDonViTinh"].Index;
                            foreach (var model1 in donViHangHoaModesl)
                            {
                                var name = $"{model1.MaDonViHangHoa} - {model1.TenDonViHangHoa}";
                                // Thêm một mục vào ComboBox trong ô ComboBox tại hàng và cột đã xác định
                                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dtgvDonViTinh.Rows[rowIndex].Cells[columnIndex];
                                cell.Items.Add(name); // Thêm mục vào ComboBox
                                if (cell.Items.Count > 0)
                                {
                                    cell.Value = $"{model.MaDonViHangHoa} - {model.TenDonViHangHoa}";
                                }
                            }


                        }
                    }
                }
            }
        }
        private void btnAddColumdtgvDonViTinh_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgvDonViTinh.Rows.Add(PosManager.Properties.Resources.delete15, null, "0", null, null, null);
            foreach (var donViTinh in donViHangHoaModesl)
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
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message, 3);
            }

        }
        private void dtgvDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvDonViTinh.Columns["cQuyDoi"].Index)
            {
                fNhapSo fNhap = new fNhapSo(null);
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvDonViTinh_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
            }
        }
    }
}
