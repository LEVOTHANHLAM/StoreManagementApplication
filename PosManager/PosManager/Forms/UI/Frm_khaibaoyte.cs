using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_khaibaoyte : Form
    {
        public Frm_khaibaoyte()
        {
            InitializeComponent();
        }
        private void Connet()
        {
            try
            {
                string[] array = File.ReadAllLines(System.Windows.Forms.Application.StartupPath + "\\name_QR.txt");
                this.button1.Text = array[0];
                this.button4.Text = array[1];
            }
            catch
            {
            }
        }

        // Token: 0x0600092F RID: 2351 RVA: 0x0001D61B File Offset: 0x0001B81B
        private void Frm_khaibaoyte_Load(object sender, EventArgs e)
        {
            this.Connet();
            this.timer1.Start();
        }

        // Token: 0x06000930 RID: 2352 RVA: 0x00169A14 File Offset: 0x00167C14
        private void button2_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != "")
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "INSERT INTO TB_QR VALUES (N'",
            //        this.textBox1.Text,
            //        "' ,'",
            //        DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //        "')"
            //    }), sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.textBox2.Text = this.textBox1.Text;
            //    this.textBox1.Text = "";
            //    this.textBox1.Focus();
            //}
        }

        // Token: 0x06000931 RID: 2353 RVA: 0x0001D631 File Offset: 0x0001B831
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.timer1.Stop();
        }

        // Token: 0x06000932 RID: 2354 RVA: 0x00169AF8 File Offset: 0x00167CF8
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button2_Click(null, null);
            }
        }

        // Token: 0x06000933 RID: 2355 RVA: 0x00169B20 File Offset: 0x00167D20
        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Concat(new string[]
            //{
            //    "SELECT NOIDUNG,NGAY FROM TB_QR WHERE CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //    "' AND  CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //    "' ORDER BY  CONVERT(DATETIME,NGAY,103) DESC "
            //}), sqlConnection);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //this.textBox5.Text = this.dataGridView1.RowCount.ToString();
        }

        // Token: 0x06000934 RID: 2356 RVA: 0x00169BFC File Offset: 0x00167DFC
        private void xuatexcel()
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\QR.xls", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frm_khaibaoyte.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frm_khaibaoyte.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_khaibaoyte)));
            //    }
            //    Worksheet worksheet = Frm_khaibaoyte.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frm_khaibaoyte.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    int num = 1;
            //    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "B" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    application.Visible = true;
            //}
        }

        // Token: 0x06000935 RID: 2357 RVA: 0x0001D64C File Offset: 0x0001B84C
        private void button5_Click(object sender, EventArgs e)
        {
            this.xuatexcel();
        }

    }
}
