using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmxuatexcel : Form
    {
        public Frmxuatexcel()
        {
            InitializeComponent();
        }
        private void Frmxuatexcel_Load(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT * FROM TB_HANGHOA";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //if (dataTable.Rows.Count > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Add(XlSheetType.xlWorksheet);
            //    if (Frmxuatexcel.< Frmxuatexcel_Load > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frmxuatexcel.< Frmxuatexcel_Load > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmxuatexcel)));
            //    }
            //    Worksheet worksheet = Frmxuatexcel.< Frmxuatexcel_Load > o__SiteContainer0.<> p__Site1.Target(Frmxuatexcel.< Frmxuatexcel_Load > o__SiteContainer0.<> p__Site1, application.ActiveSheet);
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = "MANHOM";
            //    worksheet.Cells[1, 2] = "MAHANG";
            //    worksheet.Cells[1, 3] = "TENHANG";
            //    worksheet.Cells[1, 4] = "DONVITINH";
            //    worksheet.Cells[1, 5] = "DONGIA";
            //    worksheet.Cells[1, 6] = "DONGIA2";
            //    worksheet.Cells[1, 7] = "DONGIA3";
            //    worksheet.Cells[1, 8] = "DONGIA4";
            //    worksheet.Cells[1, 9] = "DONGIA5";
            //    worksheet.Cells[1, 10] = "DONGIA6";
            //    worksheet.Cells[1, 11] = "VAT";
            //    worksheet.Cells[1, 12] = "GHICHU";
            //    worksheet.Cells[1, 13] = "QUYDOI";
            //    worksheet.Cells[1, 14] = "DONVITINHLON";
            //    worksheet.Cells[1, 15] = "CHIETKHAU";
            //    worksheet.Cells[1, 16] = "NCC";
            //    worksheet.Cells[1, 17] = "QUYDOI1";
            //    worksheet.Cells[1, 18] = "DONVITINHLON3";
            //    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    this.dataGridView1.DataSource = null;
            //}
        }
    }
}
