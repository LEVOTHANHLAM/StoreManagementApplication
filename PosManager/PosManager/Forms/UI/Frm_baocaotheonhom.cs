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
    public partial class Frm_baocaotheonhom : Form
    {
        public Frm_baocaotheonhom()
        {
            InitializeComponent();
        }
        private void loadnhom()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand("SELECT MANHOM,TENNHOM FROM TB_NHOMCHU ORDER BY TENNHOM", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.listBox1.DataSource = dataTable;
            //    this.listBox1.DisplayMember = "TENNHOM";
            //    this.listBox1.ValueMember = "MANHOM";
            //    this.listBox1.SelectedIndex = 0;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000664 RID: 1636 RVA: 0x00128C80 File Offset: 0x00126E80
        private void chitiet()
        {
            //try
            //{
            //    if (this.dgvchitiethanghoa.Rows.Count > 0)
            //    {
            //        this.dgvchitiethanghoa.Rows.Clear();
            //        this.dgvchitiethanghoa.Refresh();
            //    }
            //}
            //catch
            //{
            //    try
            //    {
            //        if (this.dgvchitiethanghoa.Rows.Count > 0)
            //        {
            //            this.dgvchitiethanghoa.Rows.RemoveAt(0);
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
            //string text = "";
            //string text2 = "";
            //if (this.txtmkh.Text != this.txtmkh.Tag.ToString())
            //{
            //    text = "AND KH.MAKHACHHANG='" + this.txtmkh.Text + "'";
            //    text2 = "AND MAKHACHHANG='" + this.txtmkh.Text + "'";
            //}
            //DataTable dataTable = new DataTable();
            //string text3 = Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy");
            //string text4 = Convert.ToDateTime(this.dateTimePicker2.Text).ToString("MM/dd/yyyy");
            //string cmdText = string.Concat(new string[]
            //{
            //    "select ISNULL( KH.TENKHACHHANG,N'Khách lẻ')+ ' ' +ISNULL(SDT,'') AS KHACHHANG, CT.TENHANGHOA,CT.DONVITINH,SUM(CT.TONGSOLUONG)AS SOLUONG, SUM(CT.DONGIABAN*TONGSOLUONG)/SUM(TONGSOLUONG), SUM(THANHTIEN)AS THANHTIEN ,CT.MAHANGHOA,ISNULL(KH.MAKHACHHANG,'') AS TENDONVI\r\nfrom TB_CHITIETHOADON CT, TB_HANGHOA HH,TB_NHOMHANG NH,TB_HOADONBANHANG HD LEFT JOIN Tb_KHACHHANG KH ON HD.MAKHACHHANG=KH.MAKHACHHANG  WHERE HN.NHOMCHU='",
            //    this.listBox1.SelectedValue.ToString(),
            //    "' AND HD.SOHOADON=CT.MAHOADON AND CT.HUY='FALSE' AND CT.MAHANGHOA=HH.MAHANGHOA AND HH.MANHOM=NH.MANHOM AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //    text3,
            //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //    text4,
            //    "' ",
            //    text,
            //    " GROUP BY  CT.TANG,NH.TENNHOM, CT.TENHANGHOA,CT.DONVITINH,CT.MAHANGHOA,KH.TENKHACHHANG,KH.SDT,ISNULL(KH.MAKHACHHANG,'') HAVING SUM(TONGSOLUONG)!=0 ORDER BY ISNULL(KH.MAKHACHHANG,'')"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //double num = 0.0;
            //double num2 = 0.0;
            //int num3 = 0;
            //string text5 = "";
            //double num4 = 0.0;
            //double num5 = 0.0;
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    this.dgvchitiethanghoa.Rows.Add(1);
            //    int num6 = this.dgvchitiethanghoa.Rows.Count - 1;
            //    if (i > 0 && dataTable.Rows[i][0].ToString() != dataTable.Rows[i - 1][0].ToString())
            //    {
            //        text5 = dataTable.Rows[i][0].ToString();
            //        this.dgvchitiethanghoa["tendonvi", num6].Value = dataTable.Rows[i - 1][7].ToString();
            //        this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i - 1][0].ToString().ToUpper();
            //        this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "CỘNG";
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.BackColor = Color.Yellow;
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
            //        this.dgvchitiethanghoa["thanhtien", num6].Value = num.ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //        this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //        num2 += num;
            //        num5 += num4;
            //        num4 = 0.0;
            //        num = 0.0;
            //        num3 = 0;
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num6++;
            //    }
            //    num3++;
            //    num += Convert.ToDouble(dataTable.Rows[i][5].ToString());
            //    this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i][1].ToString();
            //    this.dgvchitiethanghoa["dvt", num6].Value = dataTable.Rows[i][2].ToString();
            //    this.dgvchitiethanghoa["soluong", num6].Value = double.Parse(dataTable.Rows[i][3].ToString()).ToString("#,##0.##");
            //    this.dgvchitiethanghoa["dongia", num6].Value = double.Parse(dataTable.Rows[i][4].ToString()).ToString("#,##0");
            //    this.dgvchitiethanghoa["thanhtien", num6].Value = double.Parse(dataTable.Rows[i][5].ToString()).ToString("#,##0");
            //    this.dgvchitiethanghoa["MAHANG", num6].Value = dataTable.Rows[i][6].ToString();
            //    this.dgvchitiethanghoa["tendonvi", num6].Value = dataTable.Rows[i][7].ToString();
            //    this.dgvchitiethanghoa["TT", num6].Value = num3;
            //    num4 += double.Parse(dataTable.Rows[i][3].ToString());
            //}
            //this.dgvchitiethanghoa.Rows.Add(1);
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "CỘNG";
            //this.dgvchitiethanghoa["tenhang", this.dgvchitiethanghoa.Rows.Count - 1].Value = text5.ToUpper();
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //this.dgvchitiethanghoa["thanhtien", this.dgvchitiethanghoa.Rows.Count - 1].Value = num.ToString("#,##0");
            //this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //num2 += num;
            //num5 += num4;
            //this.dgvchitiethanghoa.Rows.Add(1);
            //int num7 = this.dgvchitiethanghoa.Rows.Count - 1;
            //this.dgvchitiethanghoa["MAHANG", num7].Value = "TỔNG CỘNG";
            //this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //this.dgvchitiethanghoa["thanhtien", num7].Value = num2.ToString("#,##0");
            //this.dgvchitiethanghoa["soluong", num7].Value = num5.ToString("#,##0");
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
            //if (dataTable.Rows.Count > 0)
            //{
            //    DataTable dataTable2 = new DataTable();
            //    sqlConnection.Close();
            //    string cmdText2 = string.Concat(new string[]
            //    {
            //        "SELECT ISNULL(SUM(GIAMTIEN),0) AS CONGGIAM,ISNULL(SUM(CASE WHEN PHANTRAM<0 THEN -TIENPHANTRAM ELSE TIENPHANTRAM END),0) AS PHANTRAM,SUM(TIENVAT) AS TIENVAT\r\n FROM TB_HOADONBANHANG HD WHERE HUYHD='FALSE' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //        text3,
            //        "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //        text4,
            //        "' ",
            //        text2
            //    });
            //    SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
            //    sqlDataAdapter2.Fill(dataTable2);
            //    if (dataTable2.Rows.Count > 0)
            //    {
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "+/- Tiền";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][0].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num8 = double.Parse(dataTable2.Rows[0][0].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "+/- %";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][1].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num9 = double.Parse(dataTable2.Rows[0][1].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "Thuế VAT";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][2].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num10 = double.Parse(dataTable2.Rows[0][2].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "TỔNG CỘNG";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = (num2 + this.tienck + this.ptck + num10).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
            //    }
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000665 RID: 1637 RVA: 0x00129B28 File Offset: 0x00127D28
        private void loaddiem()
        {
            //try
            //{
            //    string text = "";
            //    if (this.dgvchitiethanghoa["tendonvi", this.dgvchitiethanghoa.CurrentRow.Index].Value.ToString() != "")
            //    {
            //        text = this.dgvchitiethanghoa["tendonvi", this.dgvchitiethanghoa.CurrentRow.Index].Value.ToString();
            //    }
            //    if (text != "")
            //    {
            //        string cmdText = "select isnull(SUM(DIEMCONG),0), isnull(SUM(DIEMTRU),0), isnull(SUM(DIEM),0) from tb_DIEMKM where MAKHACHHANG ='" + text + "'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            double num = double.Parse(Convert.ToString(sqlDataReader.GetValue(0))) - double.Parse(Convert.ToString(sqlDataReader.GetValue(1))) + double.Parse(Convert.ToString(sqlDataReader.GetValue(2)));
            //            this.txtdiem.Text = num.ToString("#,##0.##");
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txtdiem.Text = "0";
            //        }
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.txtdiem.Text = "0";
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000666 RID: 1638 RVA: 0x00129CD0 File Offset: 0x00127ED0
        private void Frm_baocaotheonhom_Load(object sender, EventArgs e)
        {
            base.SetBounds(-10, -10, Screen.PrimaryScreen.WorkingArea.Width + 19, Screen.PrimaryScreen.WorkingArea.Height + 20);
            this.loadnhom();
            if (this.listBox1.Items.Count > 0)
            {
                this.chitiet();
            }
        }

        // Token: 0x06000667 RID: 1639 RVA: 0x00129D3C File Offset: 0x00127F3C
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                this.chitiet();
            }
        }

        // Token: 0x06000668 RID: 1640 RVA: 0x0001CB80 File Offset: 0x0001AD80
        private void dgvchitiethanghoa_MouseClick(object sender, MouseEventArgs e)
        {
            this.loaddiem();
        }

        // Token: 0x06000669 RID: 1641 RVA: 0x00129D6C File Offset: 0x00127F6C
        private void xuatexcel()
        {
            //if (this.dgvchitiethanghoa.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETBANHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_baocaotheonhom)));
            //    }
            //    Worksheet worksheet = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    int num = 6;
            //    for (int i = 0; i < this.dgvchitiethanghoa.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvchitiethanghoa.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 7, j + 1] = this.dgvchitiethanghoa.Rows[i].Cells[j].Value;
            //        }
            //        if (this.dgvchitiethanghoa.Rows[i].Cells[0].Value == null && this.dgvchitiethanghoa.Rows[i].Cells[1].Value != null)
            //        {
            //            if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site2 == null)
            //            {
            //                Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //                }));
            //            }
            //            Func<CallSite, object, bool, object> target = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site2.Target;
            //            CallSite<> p__Site = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site2;
            //            if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site3 == null)
            //            {
            //                Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //                }));
            //            }
            //            target(<> p__Site, Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site3.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site3, worksheet.Cells[i + 7, 2]), true);
            //            if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site4 == null)
            //            {
            //                Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //                }));
            //            }
            //            Func<CallSite, object, bool, object> target2 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site4.Target;
            //            CallSite<> p__Site2 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site4;
            //            if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site5 == null)
            //            {
            //                Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //                }));
            //            }
            //            target2(<> p__Site2, Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site5.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site5, worksheet.Cells[i + 7, 3]), true);
            //        }
            //        Range range = worksheet.get_Range("A" + num, "G" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    Range range2 = worksheet.get_Range("B" + 7, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("D" + 7, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 7, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 8, 6] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site6 == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target3 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site6.Target;
            //    CallSite<> p__Site3 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site6;
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site7 == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Site3, Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site7.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 2]), true);
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site8 == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site8 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target4 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site8.Target;
            //    CallSite<> p__Site4 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site8;
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site9 == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target4(<> p__Site4, Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site9.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Site9, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 8, 2]), true);
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Sitea == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Sitea = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, HorizontalAlignment, object> target5 = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Sitea.Target;
            //    CallSite<> p__Sitea = Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Sitea;
            //    if (Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Siteb == null)
            //    {
            //        Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frm_baocaotheonhom), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target5(<> p__Sitea, Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Siteb.Target(Frm_baocaotheonhom.< xuatexcel > o__SiteContainer0.<> p__Siteb, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6]), HorizontalAlignment.Center);
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6] = "NGƯỜI LẬP";
            //    application.WindowState = XlWindowState.xlMaximized;
            //}
        }

        // Token: 0x0600066A RID: 1642 RVA: 0x0001CB8A File Offset: 0x0001AD8A
        private void button1_Click(object sender, EventArgs e)
        {
            this.xuatexcel();
        }

        // Token: 0x0600066B RID: 1643 RVA: 0x0012A550 File Offset: 0x00128750
        private void txtmkh_Leave(object sender, EventArgs e)
        {
            if (this.txtmkh.Text.Trim() == "")
            {
                this.txtmkh.Text = this.txtmkh.Tag.ToString();
            }
        }

        // Token: 0x0600066C RID: 1644 RVA: 0x0012A59C File Offset: 0x0012879C
        private void txtmkh_Enter(object sender, EventArgs e)
        {
            if (this.txtmkh.Text.Trim() == this.txtmkh.Tag.ToString())
            {
                this.txtmkh.Text = "";
            }
        }

        // Token: 0x0600066D RID: 1645 RVA: 0x0012A5E8 File Offset: 0x001287E8
        private void button2_Click(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //this.txtmkh.Text = Frmkhachhang.makhachhang;
        }
    }
}
