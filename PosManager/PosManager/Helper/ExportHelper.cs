namespace PosManager.Helper
{
    public class ExportHelper
    {
        public static void ExportStringDataFromDataGridViewToExcel(DataGridView dataGridView)
        {
            //if (dataGridView.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "Excel Files|*.xlsx";
            //    sfd.FileName = "ExportedData.xlsx";

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        string path = sfd.FileName;

            //        using (var workbook = new XLWorkbook())
            //        {
            //            var worksheet = workbook.Worksheets.Add("Data");

            //            // Ghi tiêu đề cột
            //            int columnIndex = 1;
            //            foreach (DataGridViewColumn column in dataGridView.Columns)
            //            {
            //                worksheet.Cell(1, columnIndex).Value = column.HeaderText;
            //                columnIndex++;
            //            }

            //            // Ghi dữ liệu từ DataGridView vào file Excel
            //            int rowIndex = 2;
            //            foreach (DataGridViewRow row in dataGridView.Rows)
            //            {
            //                columnIndex = 1;
            //                foreach (DataGridViewCell cell in row.Cells)
            //                {
            //                    worksheet.Cell(rowIndex, columnIndex).Value = cell.Value?.ToString();
            //                    columnIndex++;
            //                }
            //                rowIndex++;
            //            }

            //            workbook.SaveAs(path);
            //            MessageBox.Show("Dữ liệu đã được xuất thành công vào file Excel!");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu để xuất!");
            //}
        }
    }
 }
    
            