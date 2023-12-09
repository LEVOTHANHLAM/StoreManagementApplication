using Krypton_toolKitDemo;
using PosManager.Helper;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UserControls.KhachHang
{
    public partial class NhaCungCapUserControl : UserControl
    {
        public NhaCungCapUserControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemNhaCungCap themNhaCungCap = new fThemNhaCungCap();
            themNhaCungCap.ShowDialog();
        }

        private void ChiNhanhUserControl_Load(object sender, EventArgs e)
        {
            loadAccount();
        }
        private void loadAccount()
        {
            try
            {
                var data = new[]
{
    new { STT = 1, Ten = "Tên 1", DiaChi = "Địa chỉ 1", SoDienThoai = "123456789", NgayTao = DateTime.Now, Id = 1 },
    new { STT = 2, Ten = "Tên 2", DiaChi = "Địa chỉ 2", SoDienThoai = "987654321", NgayTao = DateTime.Now, Id = 2 },
    // Thêm dữ liệu cho các hàng khác tương tự
};
                //var accounts = _accountRepository.GetAll();
                //if (accounts.Count > 0)
                //{
                //    dtgvAccount.Invoke((MethodInvoker)delegate
                //    {
                //        dtgvAccount.Rows.Clear();
                //        int i = 1;
                //        foreach (var a in accounts)
                //        {

                foreach (var item in data)
                {
                    dtgvAccount.Rows.Add(false, item.STT, item.Id, item.Ten, item.DiaChi, item.SoDienThoai, item.NgayTao.ToString("dd/MM/yyyy HH:mm:ss"), Properties.Resources.Edit);
                }
                //            i++;
                //        }
                //    });
                //}
            }
            catch (Exception ex)
            {
                Log.Error($"{nameof(ChiNhanhUserControl)}, params; {nameof(loadAccount)}, Error; {ex.Message}, Exception; {ex}");
                MessageCommon.ShowMessageBox(ex.Message, 4);
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

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cEdit"].Index)
            {
                fThemNhaCungCap themNhaCungCap = new fThemNhaCungCap();
                themNhaCungCap.ShowDialog();
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
    }
}
