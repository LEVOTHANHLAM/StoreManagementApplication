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
    public partial class Frm_soquytienmat : Form
    {
        // Token: 0x04000256 RID: 598
        public static string tungay = "";

        // Token: 0x04000257 RID: 599
        private double thu_vnpay = 0.0;

        // Token: 0x04000258 RID: 600
        private double tontienmat1 = 0.0;

        // Token: 0x04000259 RID: 601
        private double tontienmat2 = 0.0;

        // Token: 0x0400025A RID: 602
        private double tongthu = 0.0;

        // Token: 0x0400025B RID: 603
        private double tongchi = 0.0;

        // Token: 0x0400025C RID: 604
        private double tongthu_tk = 0.0;

        // Token: 0x0400025D RID: 605
        private double tongchi_tk = 0.0;
        public Frm_soquytienmat()
        {
            InitializeComponent();
        }
        private void tatca_cu(string dk)
        {
            //try
            //{
            //    this.dataGridView1.AllowUserToAddRows = false;
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand("SELECT RIGHT( NGAY,10) AS NGAY,CHUNGTU,DIENGIAI,SOTIENTHU,SOTIENCHI,TON,NGUOINHAN,GHICHU FROM TB_SOQUYTIENMAT WHERE SOTIENCHI+SOTIENTHU+TON!=0 " + dk + " GROUP BY NGAY,CHUNGTU,DIENGIAI,SOTIENTHU,SOTIENCHI,TON,NGUOINHAN,GHICHU order by CONVERT(datetime,ngay,103),CHUNGTU", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dataGridView1.DataSource = dataTable;
            //    this.tongthu = 0.0;
            //    this.tongchi = 0.0;
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        if (!(this.dataGridView1.Rows[0].Cells["ngay"].Value.ToString() == ""))
            //        {
            //            this.dataGridView1.Rows[0].Cells["TON"].Value = double.Parse(this.dataGridView1.Rows[0].Cells["THU"].Value.ToString()) - double.Parse(this.dataGridView1.Rows[0].Cells["CHI"].Value.ToString());
            //        }
            //        if (i == 0)
            //        {
            //            this.tongthu = double.Parse(this.dataGridView1.Rows[0].Cells["THU"].Value.ToString());
            //            this.tongchi = double.Parse(this.dataGridView1.Rows[0].Cells["CHI"].Value.ToString());
            //            if (double.Parse(this.dataGridView1.Rows[0].Cells["CHI"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[0].Cells["CHI"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[0].Cells["THU"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[0].Cells["THU"].Style.ForeColor = Color.White;
            //            }
            //        }
            //        if (i > 0)
            //        {
            //            this.dataGridView1.Rows[i].Cells["TON"].Value = double.Parse(this.dataGridView1.Rows[i - 1].Cells["TON"].Value.ToString()) + double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString()) - double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString());
            //            this.tongthu += double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString());
            //            this.tongchi += double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString());
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["CHI"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["THU"].Style.ForeColor = Color.White;
            //            }
            //        }
            //    }
            //    this.dataGridView1.AllowUserToAddRows = true;
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dataGridView1["diengiai", this.dataGridView1.Rows.Count - 1].Value = "TỔNG CỘNG";
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 16f, FontStyle.Bold);
            //    this.dataGridView1["thu", this.dataGridView1.Rows.Count - 1].Value = this.tongthu.ToString("#,##0");
            //    this.dataGridView1["chi", this.dataGridView1.Rows.Count - 1].Value = this.tongchi.ToString("#,##0");
            //    this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = decimal.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 2].Value.ToString()).ToString("#,##0");
            //    this.dataGridView1.AutoResizeRows();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000211 RID: 529 RVA: 0x00083D7C File Offset: 0x00081F7C
        private void tatca(string dk)
        {
            //try
            //{
            //    this.dataGridView1.AllowUserToAddRows = false;
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand("SELECT RIGHT( NGAY,10) AS NGAY,CHUNGTU,DIENGIAI,ISNULL(SOTIENTHU,0) AS SOTIENTHU,CASE WHEN GHICHU='0' THEN ISNULL(SOTIENTHU,0) ELSE '0' END AS THUTIENMAT,CASE WHEN GHICHU='1' THEN ISNULL(SOTIENTHU,0) ELSE '0' END AS THUTAIKHOAN, ISNULL(SOTIENCHI,0) AS SOTIENCHI ,CASE WHEN GHICHU='0' THEN ISNULL(SOTIENCHI,0) ELSE '0' END AS CHITIENMAT,CASE WHEN GHICHU='1' THEN ISNULL(SOTIENCHI,0) ELSE '0' END AS CHITAIKHOAN ,ISNULL(TON,0) AS TON,NGUOINHAN,GHICHU ,CASE WHEN GHICHU='2' THEN ISNULL(SOTIENTHU,0) ELSE '0' END AS vnpay FROM TB_SOQUYTIENMAT WHERE SOTIENCHI+SOTIENTHU+TON!=0 " + dk + " GROUP BY NGAY,CHUNGTU,DIENGIAI,SOTIENTHU,SOTIENCHI,TON,NGUOINHAN,GHICHU order by CONVERT(datetime,ngay,103),CHUNGTU", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.tongthu = 0.0;
            //    this.tongchi = 0.0;
            //    this.tongthu_tk = 0.0;
            //    this.tongchi_tk = 0.0;
            //    this.thu_vnpay = 0.0;
            //    this.tontienmat1 = 0.0;
            //    this.tontienmat2 = 0.0;
            //    this.dataGridView1.Rows.Clear();
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        this.dataGridView1.Rows.Add(1);
            //        this.dataGridView1.Rows[i].Cells["ngay"].Value = dataTable.Rows[i][0].ToString();
            //        this.dataGridView1.Rows[i].Cells["sct"].Value = dataTable.Rows[i][1].ToString();
            //        this.dataGridView1.Rows[i].Cells["diengiai"].Value = dataTable.Rows[i][2].ToString();
            //        this.dataGridView1.Rows[i].Cells["thu"].Value = dataTable.Rows[i][3].ToString();
            //        this.dataGridView1.Rows[i].Cells["thutienmat"].Value = double.Parse(dataTable.Rows[i][4].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["thutaikhoan"].Value = double.Parse(dataTable.Rows[i][5].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["vnpay"].Value = double.Parse(dataTable.Rows[i][12].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["chi"].Value = dataTable.Rows[i][6].ToString();
            //        this.dataGridView1.Rows[i].Cells["chitienmat"].Value = double.Parse(dataTable.Rows[i][7].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["chitaikhoan"].Value = double.Parse(dataTable.Rows[i][8].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["ton"].Value = double.Parse(dataTable.Rows[i][9].ToString()).ToString("#,##0");
            //        this.dataGridView1.Rows[i].Cells["nn"].Value = dataTable.Rows[i][10].ToString();
            //        this.dataGridView1.Rows[i].Cells["ghichu"].Value = dataTable.Rows[i][11].ToString();
            //    }
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        if (this.dataGridView1.Rows[i].Cells["ngay"].Value.ToString() == "")
            //        {
            //            this.tontienmat1 = double.Parse(this.dataGridView1.Rows[0].Cells["TON"].Value.ToString());
            //            if (i == 1)
            //            {
            //                this.tontienmat2 = double.Parse(this.dataGridView1.Rows[i].Cells["TON"].Value.ToString());
            //            }
            //        }
            //        else
            //        {
            //            double num = 0.0;
            //            if (i > 0)
            //            {
            //                num = double.Parse(this.dataGridView1.Rows[i - 1].Cells["TON"].Value.ToString());
            //            }
            //            this.dataGridView1.Rows[i].Cells["TON"].Value = num + double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString()) - double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString());
            //        }
            //        if (i == 0)
            //        {
            //            this.tongthu = double.Parse(this.dataGridView1.Rows[0].Cells["THU"].Value.ToString());
            //            this.tongchi = double.Parse(this.dataGridView1.Rows[0].Cells["CHI"].Value.ToString());
            //            if (double.Parse(this.dataGridView1.Rows[0].Cells["CHI"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[0].Cells["CHI"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[0].Cells["THU"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[0].Cells["THU"].Style.ForeColor = Color.White;
            //            }
            //        }
            //        if (i >= 0)
            //        {
            //            if (this.tontienmat2 == 0.0)
            //            {
            //                double num = 0.0;
            //                if (i > 0)
            //                {
            //                    num = double.Parse(this.dataGridView1.Rows[i - 1].Cells["TON"].Value.ToString());
            //                }
            //                this.dataGridView1.Rows[i].Cells["TON"].Value = num + double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString()) - double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString());
            //            }
            //            else if (i == 2)
            //            {
            //                this.dataGridView1.Rows[i].Cells["TON"].Value = double.Parse(this.dataGridView1.Rows[i - 1].Cells["TON"].Value.ToString()) + double.Parse(this.dataGridView1.Rows[i].Cells["THU"].Value.ToString()) - double.Parse(this.dataGridView1.Rows[i].Cells["CHI"].Value.ToString()) + this.tontienmat1;
            //                this.tontienmat1 = 0.0;
            //            }
            //            this.tongthu += double.Parse(this.dataGridView1.Rows[i].Cells["THUtienmat"].Value.ToString());
            //            this.tongchi += double.Parse(this.dataGridView1.Rows[i].Cells["CHItienmat"].Value.ToString());
            //            this.tongthu_tk += double.Parse(this.dataGridView1.Rows[i].Cells["thutaikhoan"].Value.ToString());
            //            this.tongchi_tk += double.Parse(this.dataGridView1.Rows[i].Cells["chitaikhoan"].Value.ToString());
            //            this.thu_vnpay += double.Parse(this.dataGridView1.Rows[i].Cells["vnpay"].Value.ToString());
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["CHItienmat"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["CHItienmat"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["THUtienmat"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["THUtienmat"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["chitaikhoan"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["chitaikhoan"].Style.ForeColor = Color.White;
            //            }
            //            if (double.Parse(this.dataGridView1.Rows[i].Cells["thutaikhoan"].Value.ToString()) == 0.0)
            //            {
            //                this.dataGridView1.Rows[i].Cells["thutaikhoan"].Style.ForeColor = Color.White;
            //            }
            //        }
            //    }
            //    this.dataGridView1.Rows.Add(1);
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dataGridView1["diengiai", this.dataGridView1.Rows.Count - 1].Value = "TỔNG CỘNG";
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 16f, FontStyle.Bold);
            //    this.dataGridView1["thutienmat", this.dataGridView1.Rows.Count - 1].Value = this.tongthu.ToString("#,##0");
            //    this.dataGridView1["chitienmat", this.dataGridView1.Rows.Count - 1].Value = this.tongchi.ToString("#,##0");
            //    this.dataGridView1["thutaikhoan", this.dataGridView1.Rows.Count - 1].Value = this.tongthu_tk.ToString("#,##0");
            //    this.dataGridView1["chitaikhoan", this.dataGridView1.Rows.Count - 1].Value = this.tongchi_tk.ToString("#,##0");
            //    this.dataGridView1["vnpay", this.dataGridView1.Rows.Count - 1].Value = this.thu_vnpay.ToString("#,##0");
            //    if (this.dataGridView1.RowCount == 3 && this.tontienmat2 != 0.0)
            //    {
            //        this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = (this.tontienmat1 + double.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 2].Value.ToString())).ToString("#,##0");
            //    }
            //    else
            //    {
            //        this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = decimal.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 2].Value.ToString()).ToString("#,##0");
            //    }
            //    if (double.Parse(this.textBox1.Text) != 0.0)
            //    {
            //        this.dataGridView1.Rows.Add(1);
            //        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //        this.dataGridView1["diengiai", this.dataGridView1.Rows.Count - 1].Value = "TIỀN NHẬP ĐẦU NGÀY";
            //        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 16f, FontStyle.Bold);
            //        this.dataGridView1["thutienmat", this.dataGridView1.Rows.Count - 1].Value = this.textBox1.Text;
            //        if (this.dataGridView1.RowCount == 3 && this.tontienmat2 != 0.0)
            //        {
            //            this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = (this.tontienmat1 + double.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 2].Value.ToString())).ToString("#,##0");
            //        }
            //        else
            //        {
            //            this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = double.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 2].Value.ToString()).ToString("#,##0");
            //        }
            //    }
            //    this.dataGridView1.Rows.Add(1);
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dataGridView1["diengiai", this.dataGridView1.Rows.Count - 1].Value = "SỐ TIỀN CẦN NỘP";
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 16f, FontStyle.Bold);
            //    if (this.dataGridView1.RowCount == 3 && this.tontienmat2 != 0.0)
            //    {
            //        this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = (this.tontienmat1 + double.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 3].Value.ToString()) - this.tongthu_tk - this.thu_vnpay).ToString("#,##0");
            //    }
            //    else
            //    {
            //        this.dataGridView1["TON", this.dataGridView1.Rows.Count - 1].Value = (double.Parse(this.dataGridView1["TON", this.dataGridView1.Rows.Count - 3].Value.ToString()) - this.tongthu_tk - this.thu_vnpay).ToString("#,##0");
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000212 RID: 530 RVA: 0x000851D4 File Offset: 0x000833D4
        private void Frm_soquytienmat_Load(object sender, EventArgs e)
        {
            //if (Screen.PrimaryScreen.WorkingArea.Width < 1280)
            //{
            //    base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1034, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //}
            //else
            //{
            //    base.SetBounds(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //}
            //BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("SELECT MACUAHANG,TENCUAHANG FROM TB_CUAHANG ORDER BY MACUAHANG", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(1)));
            //}
            //this.comboBox1.DataSource = null;
            //this.comboBox1.DataSource = bindingList;
            //this.comboBox1.ValueMember = "Key";
            //this.comboBox1.DisplayMember = "Value";
            //this.button5_Click(null, null);
        }

        // Token: 0x06000213 RID: 531 RVA: 0x00085320 File Offset: 0x00083520
        private void xuatexcel()
        {
            //Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\SO_QUY_TIEN_MAT.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //if (Frm_soquytienmat.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //{
            //    Frm_soquytienmat.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_soquytienmat)));
            //}
            //Worksheet worksheet = Frm_soquytienmat.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frm_soquytienmat.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //application.Visible = true;
            //worksheet.Cells[2, 1] = Frm_soquytienmat.tungay;
            //int num = 4;
            //if (this.dataGridView1.Rows.Count > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
            //        {
            //            try
            //            {
            //                worksheet.Cells[i + 5, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        Range range = worksheet.get_Range("A" + num, "K" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //}
            //Range range2 = worksheet.get_Range("A" + num, "K" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("B5", "B" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("E5", "E" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("H5", "H" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("J5", "J" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //application.WindowState = XlWindowState.xlMaximized;
        }

        // Token: 0x06000214 RID: 532 RVA: 0x0001BC4F File Offset: 0x00019E4F
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.xuatexcel();
        }

        // Token: 0x06000215 RID: 533 RVA: 0x0001BC59 File Offset: 0x00019E59
        private void button2_Click(object sender, EventArgs e)
        {
            this.tatca("");
        }

        // Token: 0x06000216 RID: 534 RVA: 0x0001BC68 File Offset: 0x00019E68
        private void button3_Click(object sender, EventArgs e)
        {
            this.tatca(" AND GHICHU='1'");
        }

        // Token: 0x06000217 RID: 535 RVA: 0x0001BC77 File Offset: 0x00019E77
        private void button4_Click(object sender, EventArgs e)
        {
            this.tatca(" AND GHICHU='0' OR SOTIENCHI+SOTIENTHU+TON!=0 AND GHICHU=''");
        }

        // Token: 0x06000218 RID: 536 RVA: 0x0001B637 File Offset: 0x00019837
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Token: 0x06000219 RID: 537 RVA: 0x00085688 File Offset: 0x00083888
        private void button4_Click_1(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != "0")
            //{
            //    DialogResult dialogResult = MessageBox.Show("BẠN CHẮC CHẮN MUỐN LƯU KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        if (this.textBox2.Text.Trim() == this.textBox2.Tag.ToString())
            //        {
            //            this.textBox2.Text = "Tiền nhập đầu ngày";
            //        }
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
            //        {
            //            "INSERT INTO [DATASHOP].[dbo].[TB_TIENDAUNGAY]([NGAY],[NHANVIEN],[SOTIEN],[TIENMAT],[NOIDUNG],MACUAHANG)     VALUES('",
            //            DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //            "','",
            //            frmLogIn.MADANGNHAP,
            //            "','",
            //            float.Parse(this.textBox1.Text),
            //            "','0',N'",
            //            this.textBox2.Text,
            //            "','",
            //            frmLogIn.macuahang,
            //            "')"
            //        }), sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //}
        }

        // Token: 0x0600021A RID: 538 RVA: 0x000857E8 File Offset: 0x000839E8
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "0";
            }
        }

        // Token: 0x0600021B RID: 539 RVA: 0x00085824 File Offset: 0x00083A24
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text = double.Parse(this.textBox1.Text).ToString("#,##0");
                this.textBox1.SelectionStart = this.textBox1.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0600021C RID: 540 RVA: 0x0008588C File Offset: 0x00083A8C
        private void TongtienBANHANG()
        {
            //string text = "";
            //DateTime dateTime = DateTime.Parse(this.dateTimePicker1.Text);
            //DateTime dateTime2 = DateTime.Parse(this.dateTimePicker1.Text);
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_SOQUYTIENMAT  DELETE TB_TIENCU  INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU]) \r\nSelect right(NGAY,10),SOHOADON,\r\nCASE WHEN CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0)  WHEN HINHTHUC='4' THEN isnull(sum(THANHTOAN),0) WHEN HINHTHUC='5' THEN isnull(sum(THANHTOAN),0) ELSE '0' END >0 \r\nTHEN  CASE WHEN HINHTHUC='1' THEN N'Thu tiền mặt bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='2' AND isnull(sum(DUATRUOC),0) >0 THEN N'Thu tiền mặt bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ')\r\n WHEN HINHTHUC='4' AND isnull(sum(DUATRUOC),0) =0 THEN N'Thu tiền tài khoản bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='4' AND isnull(sum(DUATRUOC),0) >0 THEN N'Thu tiền mặt bán hàng (còn lại tài khoản) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') \r\n  WHEN HINHTHUC='5' AND isnull(sum(DUATRUOC),0) =0 THEN N'Thu tiền VN Pay bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='5' AND isnull(sum(DUATRUOC),0) >0 THEN N'Thu tiền mặt bán hàng (còn lại VN Pay) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') END\r\n ELSE  CASE WHEN HINHTHUC='1' THEN N'Chi tiền mặt bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='2' AND isnull(sum(DUATRUOC),0) >0 THEN N'Chi tiền mặt bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ')\r\n WHEN HINHTHUC='4' AND isnull(sum(DUATRUOC),0) =0 THEN N'Chi tiền tài khoản bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='4' AND isnull(sum(DUATRUOC),0) >0 THEN N'Chi tiền mặt bán hàng (còn lại tài khoản) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') \r\n  WHEN HINHTHUC='5' AND isnull(sum(DUATRUOC),0) =0 THEN N'Thu tiền VN Pay bán hàng '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') WHEN HINHTHUC='5' AND isnull(sum(DUATRUOC),0) >0 THEN N'Thu tiền mặt bán hàng (còn lại VN Pay) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') \r\n   END  END  AS DIENGIAI,  \r\nCASE WHEN  CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='4' THEN isnull(sum(THANHTOAN),0) WHEN HINHTHUC='5' THEN isnull(sum(THANHTOAN),0) ELSE '0' END >0 THEN CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='4' THEN CASE WHEN isnull(sum(DUATRUOC),0)>0 THEN isnull(sum(DUATRUOC),0) ELSE isnull(sum(THANHTOAN),0)END  WHEN HINHTHUC='5' THEN CASE WHEN isnull(sum(DUATRUOC),0)>0 THEN isnull(sum(DUATRUOC),0) ELSE isnull(sum(THANHTOAN),0)END ELSE '0' END ELSE '0' END AS THU \r\n,-CASE WHEN  CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='4' THEN isnull(sum(THANHTOAN),0) ELSE '0' END <0 THEN CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='4' THEN CASE WHEN isnull(sum(DUATRUOC),0)>0 THEN isnull(sum(DUATRUOC),0)ELSE isnull(sum(THANHTOAN),0)END  ELSE '0' END ELSE '0' END AS CHI,'0',NHANVIEN, CASE WHEN HINHTHUC='4' AND isnull(sum(DUATRUOC),0)=0 THEN 1 WHEN HINHTHUC='5' AND isnull(sum(DUATRUOC),0)=0 THEN 2 ELSE 0 END AS HINHTHUC\r\nfrom tb_hoadonbanhang HD LEFT JOIN TB_KHACHHANG KH ON KH.MAKHACHHANG=HD.MAKHACHHANG where huyhd='False'  and convert(datetime,ngay,103)>='",
            //    dateTime2.ToString("yyyy/MM/dd 00:00"),
            //    "'    and convert(datetime,ngay,103)<='",
            //    dateTime.ToString("yyyy/MM/dd 23:59"),
            //    "' ",
            //    text,
            //    " AND  HD.MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' GROUP BY HINHTHUC,right(NGAY,10),NHANVIEN,SOHOADON,ISNULL( KH.TENKHACHHANG,N'Khách lẻ')"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //string cmdText2 = string.Concat(new string[]
            //{
            //    "INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU]) \r\nSelect right(NGAY,10),SOHOADON,CASE WHEN HINHTHUC='4' AND isnull(sum(THANHTOAN),0) >0 \r\nTHEN  N'Thu tiền tài khoản bán hàng (còn lại tiền mặt) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') \r\nELSE  N'Chi tiền tài khoản bán hàng (còn lại tiền mặt) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') END  AS DIENGIAI, \r\nCASE WHEN  HINHTHUC='4' AND isnull(sum(DUATRUOC),0)>0 THEN isnull(sum(THANHTOAN-DUATRUOC),0) ELSE '0' END AS THU ,\r\n-CASE WHEN  HINHTHUC='4' AND isnull(sum(DUATRUOC),0)<0 THEN -isnull(sum(THANHTOAN-DUATRUOC),0) ELSE '0' END  AS CHI,'0',NHANVIEN, '1' AS HINHTHUC\r\n\r\nfrom tb_hoadonbanhang HD LEFT JOIN TB_KHACHHANG KH ON KH.MAKHACHHANG=HD.MAKHACHHANG where huyhd='False'  and convert(datetime,ngay,103)>='",
            //    dateTime2.ToString("yyyy/MM/dd 00:00"),
            //    "'  AND HINHTHUC='4' AND isnull(DUATRUOC,0)>0    and convert(datetime,ngay,103)<='",
            //    dateTime.ToString("yyyy/MM/dd 23:59"),
            //    "' ",
            //    text,
            //    "  AND HD.MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' GROUP BY HINHTHUC,right(NGAY,10),NHANVIEN,SOHOADON,ISNULL( KH.TENKHACHHANG,N'Khách lẻ')"
            //});
            //sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //string cmdText3 = string.Concat(new string[]
            //{
            //    "INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU]) \r\nSelect right(NGAY,10),SOHOADON,CASE WHEN HINHTHUC='5' AND isnull(sum(THANHTOAN),0) >0 \r\nTHEN  N'Thu tiền tài khoản bán hàng (còn lại tiền mặt) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') \r\nELSE  N'Chi tiền tài khoản bán hàng (còn lại tiền mặt) '+ ISNULL( KH.TENKHACHHANG,N'Khách lẻ') END  AS DIENGIAI, \r\nCASE WHEN  HINHTHUC='5' AND isnull(sum(DUATRUOC),0)>0 THEN isnull(sum(THANHTOAN-DUATRUOC),0) ELSE '0' END AS THU ,\r\n-CASE WHEN  HINHTHUC='5' AND isnull(sum(DUATRUOC),0)<0 THEN -isnull(sum(THANHTOAN-DUATRUOC),0) ELSE '0' END  AS CHI,'0',NHANVIEN, '2' AS HINHTHUC\r\n\r\nfrom tb_hoadonbanhang HD LEFT JOIN TB_KHACHHANG KH ON KH.MAKHACHHANG=HD.MAKHACHHANG where huyhd='False'  and convert(datetime,ngay,103)>='",
            //    dateTime2.ToString("yyyy/MM/dd 00:00"),
            //    "'  AND HINHTHUC='5' AND isnull(DUATRUOC,0)>0    and convert(datetime,ngay,103)<='",
            //    dateTime.ToString("yyyy/MM/dd 23:59"),
            //    "' ",
            //    text,
            //    "  AND HD.MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' GROUP BY HINHTHUC,right(NGAY,10),NHANVIEN,SOHOADON,ISNULL( KH.TENKHACHHANG,N'Khách lẻ')"
            //});
            //sqlCommand = new SqlCommand(cmdText3, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //cmdText = string.Concat(new string[]
            //{
            //    "INSERT INTO TB_TIENCU([NGAY] ,SOTIEN) (Select '',isnull( CASE WHEN HINHTHUC='1' THEN isnull(sum(thanhtoan),0) WHEN HINHTHUC='2' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='4' THEN isnull(sum(DUATRUOC),0) WHEN HINHTHUC='5' THEN isnull(sum(DUATRUOC),0) ELSE '0' END ,0) from tb_hoadonbanhang where huyhd='False' and convert(datetime,ngay,103)<'",
            //    dateTime2.ToString("yyyy/MM/dd 00:00"),
            //    "' ",
            //    text,
            //    "  AND MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' GROUP BY HINHTHUC)"
            //});
            //sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        // Token: 0x0600021D RID: 541 RVA: 0x00085B2C File Offset: 0x00083D2C
        private void LOADDULIEUTHUCHI()
        {
            //DateTime dateTime = DateTime.Parse(this.dateTimePicker1.Text);
            //DateTime dateTime2 = DateTime.Parse(this.dateTimePicker1.Text);
            //string text = "";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //string cmdText = string.Concat(new string[]
            //{
            //    "INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU]) (SELECT tc.Ngay,tc.Mathuchi,tc.Lydo+' '+isnull(kh.tenkhachhang,tc.CHUNGTU),tc.Sotien,tc.TIENTRANO,'0',TC.MANV,TC.TAIKHOAN\r\n from tb_thuchi tc left join tb_khachhang kh on tc.MaKH=kh.MAKHACHHANG where convert(datetime,tc.ngay,103)>='00:00 ",
            //    dateTime2.ToString("yyyy/MM/dd"),
            //    "' and convert(datetime,tc.ngay,103)<='23:59 ",
            //    dateTime.ToString("yyyy/MM/dd"),
            //    "' ",
            //    text,
            //    " AND TC.MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' GROUP BY tc.Ngay,tc.Mathuchi,tc.Lydo+' '+isnull(kh.tenkhachhang,tc.CHUNGTU),tc.Sotien,tc.TIENTRANO,TC.MANV,TC.TAIKHOAN )"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //cmdText = string.Concat(new string[]
            //{
            //    "INSERT INTO TB_TIENCU([NGAY] ,SOTIEN) (SELECT '', ISNULL(SUM(SOTIEN-TIENTRANO),0) from tb_thuchi tc where convert(datetime,ngay,103)<'00:00 ",
            //    dateTime2.ToString("yyyy/MM/dd"),
            //    "' ",
            //    text,
            //    " AND TAIKHOAN='0' AND TC.MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "' )"
            //});
            //sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //string cmdText2 = string.Concat(new string[]
            //{
            //    "INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU])(select '23:59 '+RIGHT( NGAY,10) AS NGAY,'DAUKY',NOIDUNG,ISNULL(SOTIEN,0), '0','0',NHANVIEN,'0' from TB_TIENDAUNGAY  WHERE CONVERT(DATETIME,NGAY,103) >='00:00 ",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //    "' AND CONVERT(DATETIME,NGAY,103) <='23:59 ",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //    "' AND MACUAHANG='",
            //    this.comboBox1.SelectedValue.ToString(),
            //    "')"
            //});
            //sqlConnection.Close();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //string cmdText3 = "INSERT INTO [DATASHOP].[dbo].[TB_SOQUYTIENMAT] ([NGAY] ,[CHUNGTU] ,[DIENGIAI] ,[SOTIENTHU] ,[SOTIENCHI] ,[TON] ,[NGUOINHAN] ,[GHICHU])(select '','',N'Số dư đầu kỳ','0', '0',ISNULL(SUM(SOTIEN),0),'','' from TB_TIENCU) \r\n                                        SELECT ISNULL(SUM(SOTIEN),0) FROM TB_TIENCU";
            //sqlConnection.Close();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //sqlCommand = new SqlCommand(cmdText3, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
        }

        // Token: 0x0600021E RID: 542 RVA: 0x00085DAC File Offset: 0x00083FAC
        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.textBox1.Text = "0";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "SELECT ISNULL( SUM(SOTIEN),0) FROM TB_TIENDAUNGAY WHERE CONVERT(DATETIME,NGAY,103) >='00:00 ",
            //        Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //        "' AND CONVERT(DATETIME,NGAY,103) <='23:59 ",
            //        Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //        "' AND MACUAHANG='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "'"
            //    }), sqlConnection);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.textBox1.Text = double.Parse(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("KHÔNG LOAD ĐƯỢC SỐ TIỀN ĐẦU NGÀY BẠN Ạ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
            //this.TongtienBANHANG();
            //this.LOADDULIEUTHUCHI();
            //this.tatca("");
        }

        // Token: 0x0600021F RID: 543 RVA: 0x00085F10 File Offset: 0x00084110
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim() == "")
            {
                this.textBox2.Text = this.textBox2.Tag.ToString();
            }
        }

        // Token: 0x06000220 RID: 544 RVA: 0x00085F5C File Offset: 0x0008415C
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim() == this.textBox2.Tag.ToString())
            {
                this.textBox2.Text = "";
            }
        }
    }
}
