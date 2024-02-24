﻿using DevExpress.XtraSplashScreen;
using PosManager;
using PosManager.APIServices.SanPham;
using PosManager.Helper;
using PosManager.Helper.CustomControls;
using PosManager.Model;
using PosManager.Model.User;
using Serilog;

namespace PosManager.Forms.UserControls.SanPham
{
    public partial class QuanLySanPhamUserControl : UserControl
    {
        private ProductsController _productsController;
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10; // Số phần tử trên mỗi trang
        private int Total = 1000;
        private int row = 0;
        private PermissionModel permissionModel;
        private fHome _fHome;
        public QuanLySanPhamUserControl(fHome fHome )
        {
            InitializeComponent();
            _productsController = new ProductsController();
            cbbCuonTrang.SelectedIndex = 0;
            _fHome = fHome;
            if (txtSearch == null)
            {
                txtSearch = new Helper.CustomControls.PlaceholderTextBox();
                PlaceholderTextBox.CreatTextBox(txtSearch);
                panel4.Controls.Add(txtSearch);
                txtSearch.TextChanged += txtSearch_TextChanged;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemHangHoa them = new fThemHangHoa();
            them.ShowDialog();
            loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
        }

        private void ChiNhanhUserControl_Load(object sender, EventArgs e)
        {
            loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            if (GlobalModel.UserInfo.Permissions != null)
            {
                permissionModel = GlobalModel.UserInfo.Permissions.FirstOrDefault(x => x.FunctionName == "QuanLySanPhamUserControl");
                if (permissionModel != null)
                {
                    btnAdd.Enabled = permissionModel.HasCreate;
                }
            }
        }
        private async void loadAccount(int pageIndex = 1, int pageSize = 1, string? searchString = "")
        {
            try
            {
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                if (searchString == "Tìm Kiếm")
                {
                    searchString = "";
                }
                var accounts = await _productsController.Search(GlobalModel.AccsessToken, pageIndex.ToString(), pageSize.ToString(), searchString);
                dtgvAccount.Rows.Clear();
                if (accounts != null && accounts.StatusCode == 200 && accounts.Data.Result.Count > 0)
                {
                    Total = accounts.Data.Total;
                    totalPages = (int)Math.Ceiling((double)Total / pageSize);

                    dtgvAccount.Invoke((MethodInvoker)delegate
                    {
                        int i = (currentPage - 1) * pageSize + 1; // Số thứ tự bắt đầu
                        foreach (var a in accounts.Data.Result)
                        {
                            if (a.MaNhomHang == "ROOT")
                            {
                                a.MaNhomHang = "";
                                a.TenNhomHang = "";
                            }
                            dtgvAccount.Rows.Add(false, i, a.MaHangHoa, a.TenHangHoa, a.TenHangHoaKhongDau, a.MaNhomHang, a.TenNhomHang, a.VAT, a.GhiChu, Properties.Resources.Show, Properties.Resources.delete15, a.Id);
                            i++;
                        }
                        row = i;
                    });

                    DisplayDataOnCurrentPage();
                }
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(loadAccount)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);
            }
        }

        private void DisplayDataOnCurrentPage()
        {
            try
            {
                int startItem = (currentPage - 1) * pageSize + 1; // Số thứ tự bắt đầu
                int endItem = Math.Min(currentPage * pageSize, Total); // Số thứ tự kết thúc

                lbThongBaoSoTrang.Text = $" Hiển thị từ {startItem} đến {endItem} trong tổng số {Total} mục";
                // Disable nút Previous khi ở trang đầu tiên
                btnQuayLaiTrang.Enabled = currentPage > 1;
                // Disable nút Next khi ở trang cuối cùng
                btnTiepTucTrang.Enabled = currentPage < totalPages;
                // Tính toán và hiển thị các nút trang
                // Ví dụ: Button 1 là trang trước đó của trang hiện tại
                btnTrang1.Enabled = currentPage != 1;
                // Button 2 là trang trước trang hiện tại
                btnTrang2.Visible = totalPages > 1;
                btnTrang2.Enabled = currentPage != 2;

                // Button 3 là trang sau trang hiện tại
                btnTrang3.Visible = totalPages > 2;
                btnTrang3.Enabled = currentPage != totalPages;
                // Button 11 là trang sau trang tiếp theo của trang hiện tại
                label3.Visible = totalPages > 4;
                btnTrangCuoi.Visible = totalPages > 3;
                btnTrangCuoi.Enabled = currentPage < totalPages;
                btnTrangCuoi.Text = totalPages.ToString();
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(DisplayDataOnCurrentPage)}, Error; {ex.Message}, Exception; {ex}");
            }
        }
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                try
                {
                    dtgvAccount.CurrentRow.Cells["cChon"].Value = !Convert.ToBoolean(dtgvAccount.CurrentRow.Cells["cChon"].Value);
                }
                catch (Exception ex)
                {
                    Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(dtgvAccount_CellClick)}, Error; {ex.Message}, Exception; {ex}");
                    MessageCommon.ShowMessageBox(ex.Message, 4);
                }
            }
        }

        private async void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cShow"].Index)
            {
                if (permissionModel != null && !permissionModel.HasUpdate)
                {
                    MessageCommon.ShowMessageBox("Bạn không có quyền  sửa", 2);
                    return;
                }
                SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cId"].Value.ToString();
                fChiTietHangHoa update = new fChiTietHangHoa(id);
                update.ShowDialog();
                SplashScreenManager.CloseForm(false);
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cDelete"].Index)
            {
                if (permissionModel != null && !permissionModel.HasDelete)
                {
                    MessageCommon.ShowMessageBox("Bạn không có quyền xoá và sửa", 2);
                    return;
                }
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cId"].Value.ToString();
                if (MessageCommon.ShowConfirmationBox("Bạn Có Chắc Chắn Muốn Xoá Sản Phẩm Này Không?") == DialogResult.Yes)
                {
                    SplashScreenManager.ShowForm(_fHome, typeof(WaitForm1), true, true, false);
                    var result = await _productsController.Delete(GlobalModel.AccsessToken, id);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                        loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox("Đã gặp lỗi vui lòng thử lại!", 2);
                    }
                }
            }
        }

        private void dtgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    dtgvAccount.CurrentRow.Cells["cChon"].Value = !Convert.ToBoolean(dtgvAccount.CurrentRow.Cells["cChon"].Value);
                }
                catch (Exception ex)
                {
                    Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(dtgvAccount_CellDoubleClick)}, Error; {ex.Message}, Exception; {ex}");
                    MessageCommon.ShowMessageBox(ex.Message, 4);
                }
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("All");
        }

        private void selectAllHighlightedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("SelectHighline");
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformAction("UnAll");
        }
        private List<string> GetListSelect()
        {
            List<string> list = new List<string>();
            try
            {
                for (int i = 0; i < dtgvAccount.RowCount; i++)
                {
                    if (Convert.ToBoolean(dtgvAccount.Rows[i].Cells["cChon"].Value))
                    {
                        list.Add(dtgvAccount.Rows[i].Cells["cId"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(GetListSelect)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);
            }
            return list;
        }
        private void PerformAction(string action)
        {
            try
            {
                switch (action)
                {
                    case "ToggleCheck":
                        {
                            for (int k = 0; k < dtgvAccount.SelectedRows.Count; k++)
                            {
                                int index = dtgvAccount.SelectedRows[k].Index;
                                SetCellAccount(index, "cChon", !Convert.ToBoolean(GetCellValue(index, "cChon")));
                            }
                            break;
                        }
                    case "SelectHighline":
                        {
                            DataGridViewSelectedRowCollection selectedRows = dtgvAccount.SelectedRows;
                            for (int j = 0; j < selectedRows.Count; j++)
                            {
                                SetCellAccount(selectedRows[j].Index, "cChon", true);
                            }
                            break;
                        }
                    case "UnAll":
                        {
                            for (int l = 0; l < dtgvAccount.RowCount; l++)
                            {
                                SetCellAccount(l, "cChon", false);
                            }
                            break;
                        }
                    case "All":
                        {
                            for (int i = 0; i < dtgvAccount.RowCount; i++)
                            {
                                SetCellAccount(i, "cChon", true);
                            }
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                MessageCommon.ShowMessageBox(ex.Message, 4);
                Log.Error(ex, ex.Message);
            }

        }
        private void SetCellAccount(int rowIndex, string columnName, object cellValue, bool allowNull = true)
        {
            if (allowNull || !(cellValue.ToString().Trim() == ""))
            {
                DataGridViewHelper.SetCellValue(dtgvAccount, rowIndex, columnName, cellValue);

            }
        }
        private string GetCellValue(int rowIndex, string columnName)
        {
            return DataGridViewHelper.GetCellValue(dtgvAccount, rowIndex, columnName);
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
            }
            else if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm Kiếm";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbCuonTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(cbbCuonTrang.Text);
            currentPage = 1;
            //loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
        }

        private void btnQuayLaiTrang_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void btnTiepTucTrang_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void btnTrang1_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage = 1;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void btnTrang2_Click(object sender, EventArgs e)
        {
            if (currentPage != 2)
            {
                currentPage = 2;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void btnTrang3_Click(object sender, EventArgs e)
        {
            if (currentPage != 3)
            {
                currentPage = 3;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {
            if (currentPage != totalPages)
            {
                currentPage = totalPages;
                loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //currentPage = 1;
            loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportStringDataFromDataGridViewToExcel(dtgvAccount);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var listDelete = GetListSelect();
            if (listDelete.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa {listDelete.Count} dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var item in listDelete)
                    {
                        // var accounts = await _categoriesController.Delete(GlobalModel.AccsessToken, item);
                    }
                    loadAccount(currentPage, pageSize, txtSearch.Text.Trim());
                }
            }
            else
            {
                MessageCommon.ShowMessageBox("Vui lòng chọn dữ liệu cần xóa", 4);
            }
        }
    }
}
