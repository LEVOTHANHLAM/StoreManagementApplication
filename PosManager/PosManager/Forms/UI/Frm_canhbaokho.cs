using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_canhbaokho : Form
    {
        public Frm_canhbaokho()
        {
            InitializeComponent();
        }
        private void canhbaokho()
        {
            //if (this.dgvchitiethanghoa.Rows.Count > 0)
            //{
            //    this.dgvchitiethanghoa.Rows.Clear();
            //    this.dgvchitiethanghoa.Refresh();
            //}
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1 \r\n                             FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when HHX.DONVITINH=HH.DONVITINH  THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //    TrangChu.doicm,
            //    " ELSE '0' END END AS SOLUONGTONG,   CASE WHEN HH.TONDONVI='FALSE' THEN    case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //    TrangChu.doicm,
            //    "*HH.QUYDOI1 END   END ELSE case when HHX.DONVITINH=HH.DONVITINH THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //    TrangChu.doicm,
            //    "*HH.QUYDOI1 END   END END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HH.TONDONVI) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_TONGHANGHOANHAP HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHANGHOA=HHX.MAHANGHOA group by hhn.mahanghoa,isnull(hhn.soluongTONG,0))  SELECT  NH.TENNHOM,HH.TENHANGHOA,HH.DONVITINH,ISNULL(HH.SL_CANHBAO,0) AS TONTOITHIEU,CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(TK.SOLUONGTONG,0)/HH.QUYDOI1 ELSE  ISNULL(TK.SOLUONGTONG,0) END  AS TON, ISNULL(HH.SL_CANHBAO,0)-(CASE WHEN HH.TONDONVI='FALSE' THEN (ISNULL(TK.SOLUONGTONG,0)/HH.QUYDOI1) ELSE ISNULL(TK.SOLUONGTONG,0) END ) AS CHENHLECH ,HH.MAHANGHOA  FROM TB_HANGHOA HH LEFT JOIN TB_TONKHO TK ON HH.MAHANGHOA=TK.MAHANGHOA ,TB_NHOMHANG NH WHERE HH.MANHOM=NH.MANHOM AND ISNULL(HH.SL_CANHBAO,0)> (CASE WHEN HH.TONDONVI='FALSE' THEN (ISNULL(TK.SOLUONGTONG,0)/HH.QUYDOI1) ELSE ISNULL(TK.SOLUONGTONG,0) END )AND ISNULL(HH.SL_CANHBAO,0)>0     ORDER BY NH.TENNHOM, HH.TENHANGHOA"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    double num = 0.0;
            //    double num2 = 0.0;
            //    int num3 = 0;
            //    string text = "";
            //    double num4 = 0.0;
            //    double num5 = 0.0;
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        int num6 = this.dgvchitiethanghoa.Rows.Count - 1;
            //        if (i > 0 && dataTable.Rows[i][0].ToString() != dataTable.Rows[i - 1][0].ToString())
            //        {
            //            text = dataTable.Rows[i][0].ToString();
            //            this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i - 1][0].ToString().ToUpper();
            //            this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "NHÓM";
            //            this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.BackColor = Color.Yellow;
            //            this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
            //            this.dgvchitiethanghoa["cl", num6].Value = num.ToString("#,##0");
            //            this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //            this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //            num2 += num;
            //            num5 += num4;
            //            num4 = 0.0;
            //            num = 0.0;
            //            num3 = 0;
            //            this.dgvchitiethanghoa.Rows.Add(1);
            //            num6++;
            //        }
            //        num3++;
            //        num += Convert.ToDouble(dataTable.Rows[i][5].ToString());
            //        this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i][1].ToString();
            //        this.dgvchitiethanghoa["dvt", num6].Value = dataTable.Rows[i][2].ToString();
            //        this.dgvchitiethanghoa["soluong", num6].Value = double.Parse(dataTable.Rows[i][3].ToString()).ToString("#,##0.##");
            //        this.dgvchitiethanghoa["sl_ton", num6].Value = double.Parse(dataTable.Rows[i][4].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa["cl", num6].Value = double.Parse(dataTable.Rows[i][5].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa["MAHANG", num6].Value = dataTable.Rows[i][6].ToString();
            //        this.dgvchitiethanghoa["TT", num6].Value = num3;
            //        num4 += double.Parse(dataTable.Rows[i][3].ToString());
            //    }
            //    this.dgvchitiethanghoa.Rows.Add(1);
            //    this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "NHÓM";
            //    this.dgvchitiethanghoa["tenhang", this.dgvchitiethanghoa.Rows.Count - 1].Value = text.ToUpper();
            //    this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //    this.dgvchitiethanghoa["cl", this.dgvchitiethanghoa.Rows.Count - 1].Value = num.ToString("#,##0");
            //    this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //    num2 += num;
            //    this.dgvchitiethanghoa.AutoResizeRows();
            //}
            //else
            //{
            //    base.Close();
            //}
        }

        // Token: 0x060007E0 RID: 2016 RVA: 0x00147E70 File Offset: 0x00146070
        private void loadcauhinh()
        {
            //try
            //{
            //    string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.chObj.Tencongty = sqlDataReader.GetString(1);
            //        this.chObj.Diachi = sqlDataReader.GetString(2);
            //        this.chObj.Dienthoai = sqlDataReader.GetString(3);
            //        this.chObj.Kyten = sqlDataReader.GetString(4);
            //        this.chObj.Canhle = sqlDataReader.GetString(5);
            //        this.chObj.Sotrangin = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
            //        this.chObj.Ghichu = sqlDataReader.GetString(7);
            //        this.chObj.Cochuten = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
            //        this.chObj.Cochudienthoai = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
            //        this.chObj.Cochukyten = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
            //        this.chObj.Cochudiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
            //        this.chObj.Letrai = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
            //        this.chObj.Mayin = sqlDataReader.GetString(12);
            //        this.chObj.Tenmayin = sqlDataReader.GetString(14);
            //        this.chObj.Hoadon = sqlDataReader.GetString(15);
            //        this.chObj.Tieude1 = sqlDataReader.GetString(16);
            //        this.chObj.Tieude2 = sqlDataReader.GetString(17);
            //        this.chObj.Tieude3 = sqlDataReader.GetString(18);
            //        this.chObj.Diachi1 = Convert.ToString(sqlDataReader.GetValue(20));
            //        this.chObj.Diachi2 = Convert.ToString(sqlDataReader.GetValue(21));
            //        this.chObj.Kytu = Convert.ToString(sqlDataReader.GetValue(43));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("CẬP NHẬT THÊM VÀO BẢNG TB_CAUHINH", "THÔNG BÁO");
            //}
        }

        // Token: 0x060007E1 RID: 2017 RVA: 0x00148100 File Offset: 0x00146300
        private void Frm_canhbaokho_Load(object sender, EventArgs e)
        {
            this.loadcauhinh();
            this.canhbaokho();
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 988) / 2, 0, 988, Screen.PrimaryScreen.WorkingArea.Height - 20);
        }

        // Token: 0x060007E2 RID: 2018 RVA: 0x00148158 File Offset: 0x00146358
        private void xuatexcel()
        {
            //if (this.dgvchitiethanghoa.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CANHBAOKHO.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_canhbaokho)));
            //    }
            //    Worksheet worksheet = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //    worksheet.Cells[2, 1] = this.chObj.Diachi;
            //    worksheet.Cells[3, 1] = this.chObj.Dienthoai;
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
            //            if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site2 == null)
            //            {
            //                Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //                }));
            //            }
            //            Func<CallSite, object, bool, object> target = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site2.Target;
            //            CallSite<> p__Site = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site2;
            //            if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site3 == null)
            //            {
            //                Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //                }));
            //            }
            //            target(<> p__Site, Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site3.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site3, worksheet.Cells[i + 7, 2]), true);
            //            if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site4 == null)
            //            {
            //                Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //                }));
            //            }
            //            Func<CallSite, object, bool, object> target2 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site4.Target;
            //            CallSite<> p__Site2 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site4;
            //            if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site5 == null)
            //            {
            //                Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //                {
            //                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //                }));
            //            }
            //            target2(<> p__Site2, Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site5.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site5, worksheet.Cells[i + 7, 3]), true);
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
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site6 == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target3 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site6.Target;
            //    CallSite<> p__Site3 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site6;
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site7 == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Site3, Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site7.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 2]), true);
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site8 == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site8 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target4 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site8.Target;
            //    CallSite<> p__Site4 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site8;
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site9 == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target4(<> p__Site4, Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site9.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Site9, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 8, 2]), true);
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Sitea == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Sitea = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, HorizontalAlignment, object> target5 = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Sitea.Target;
            //    CallSite<> p__Sitea = Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Sitea;
            //    if (Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Siteb == null)
            //    {
            //        Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frm_canhbaokho), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target5(<> p__Sitea, Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Siteb.Target(Frm_canhbaokho.< xuatexcel > o__SiteContainer0.<> p__Siteb, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6]), HorizontalAlignment.Center);
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6] = "NGƯỜI LẬP";
            //}
        }

        // Token: 0x060007E3 RID: 2019 RVA: 0x0001D08B File Offset: 0x0001B28B
        private void button1_Click(object sender, EventArgs e)
        {
            this.xuatexcel();
        }

        // Token: 0x060007E4 RID: 2020 RVA: 0x0001B637 File Offset: 0x00019837
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x060007E5 RID: 2021 RVA: 0x00148998 File Offset: 0x00146B98
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //int letrai = this.chObj.Letrai;
            //int num = int.Parse(this.chObj.Canhle);
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //int num2 = 0;
            //int num3 = 40;
            //if (this.lan == 0)
            //{
            //    e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num));
            //    e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 25));
            //    e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 50));
            //    int num4 = num + 100;
            //    e.Graphics.DrawString("BẢNG KÊ TỒN KHO TỐI THIỂU", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(370 + letrai, num4 - 25), stringFormat);
            //    e.Graphics.DrawString("Ngày " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(370 + letrai, num4), stringFormat);
            //    num2 = num4 + 25;
            //}
            //else
            //{
            //    int num4 = num - 5;
            //    num2 = num;
            //}
            //e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num2 + 7));
            //e.Graphics.DrawString("Mã Hàng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(50 + letrai, num2 + 7));
            //e.Graphics.DrawString("Tên Hàng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(290 + letrai, num2 + 7), stringFormat);
            //e.Graphics.DrawString("ĐVT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(455 + letrai, num2 + 7), stringFormat);
            //e.Graphics.DrawString("Tối thiểu ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(553 + letrai, num2 + 7), stringFormat2);
            //e.Graphics.DrawString("Hiện tại", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(655 + letrai, num2 + 7), stringFormat2);
            //e.Graphics.DrawString("Còn thiếu", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(760 + letrai, num2 + 7), stringFormat2);
            //int num5 = num2 + 40;
            //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //{
            //    RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 780f, 40f);
            //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //}
            //for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvchitiethanghoa.RowCount; i++)
            //{
            //    this.numberOfItemsPerPage++;
            //    if (this.numberOfItemsPerPage > this.sodong)
            //    {
            //        this.lan = 1;
            //        this.sodong = 32;
            //        this.numberOfItemsPerPage = 0;
            //        e.HasMorePages = true;
            //        return;
            //    }
            //    this.numberOfItemsPrintedSoFar++;
            //    if (this.numberOfItemsPrintedSoFar <= this.dgvchitiethanghoa.Rows.Count)
            //    {
            //        int length = this.dgvchitiethanghoa.Rows[i].Cells["tenhang"].Value.ToString().Length;
            //        decimal num6 = Math.Ceiling(Convert.ToDecimal(length) / int.Parse(this.chObj.Kytu));
            //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //        {
            //            RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num5 - 5), 780f, (float)(15 * int.Parse(num6.ToString()) + 15));
            //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //        }
            //        if (this.dgvchitiethanghoa.Rows[i].Cells["TT"].Value != null)
            //        {
            //            e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["TT"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + letrai, num5), stringFormat);
            //            e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["mahang"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(40 + letrai, num5));
            //            using (Font font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point))
            //            {
            //                RectangleF rectangleF = new RectangleF((float)(140 + letrai), (float)num5, 355f, (float)(17 * int.Parse(num6.ToString())));
            //                e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, rectangleF);
            //            }
            //        }
            //        else
            //        {
            //            e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["mahang"].Value.ToString(), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(40 + letrai, num5));
            //            using (Font font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Point))
            //            {
            //                RectangleF rectangleF = new RectangleF((float)(140 + letrai), (float)num5, 355f, (float)(17 * int.Parse(num6.ToString())));
            //                e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, rectangleF);
            //            }
            //        }
            //        if (this.dgvchitiethanghoa.Rows[i].Cells["dvt"].Value != null)
            //        {
            //            e.Graphics.DrawString(this.dgvchitiethanghoa.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(460 + letrai, num5), stringFormat);
            //        }
            //        e.Graphics.DrawString(Convert.ToDouble(this.dgvchitiethanghoa.Rows[i].Cells["soluong"].Value.ToString()).ToString("#,##0.##"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(560 + letrai, num5), stringFormat2);
            //        string s = "0";
            //        if (this.dgvchitiethanghoa.Rows[i].Cells["sl_ton"].Value != null)
            //        {
            //            if (Convert.ToDouble(this.dgvchitiethanghoa.Rows[i].Cells["sl_ton"].Value.ToString()) != 0.0)
            //            {
            //                s = Convert.ToDouble(this.dgvchitiethanghoa.Rows[i].Cells["sl_ton"].Value.ToString()).ToString("#,###");
            //            }
            //            else
            //            {
            //                s = this.dgvchitiethanghoa.Rows[i].Cells["sl_ton"].Value.ToString();
            //            }
            //        }
            //        string s2;
            //        if (Convert.ToDouble(this.dgvchitiethanghoa.Rows[i].Cells["cl"].Value.ToString()) != 0.0)
            //        {
            //            s2 = Convert.ToDouble(this.dgvchitiethanghoa.Rows[i].Cells["cl"].Value.ToString()).ToString("#,###");
            //        }
            //        else
            //        {
            //            s2 = this.dgvchitiethanghoa.Rows[i].Cells["cl"].Value.ToString();
            //        }
            //        e.Graphics.DrawString(s, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + letrai, num5), stringFormat2);
            //        e.Graphics.DrawString(s2, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(775 + letrai, num5), stringFormat2);
            //        num3 += 15 * int.Parse(num6.ToString()) + 15;
            //        num5 += 15 * int.Parse(num6.ToString()) + 15;
            //    }
            //    else
            //    {
            //        e.HasMorePages = false;
            //    }
            //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //    {
            //        RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 30f, (float)num3);
            //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //    }
            //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //    {
            //        RectangleF rectangleF = new RectangleF((float)(139 + letrai), (float)(num2 - 5), 291f, (float)num3);
            //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //    }
            //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //    {
            //        RectangleF rectangleF = new RectangleF((float)(430 + letrai), (float)(num2 - 5), 50f, (float)num3);
            //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //    }
            //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //    {
            //        RectangleF rectangleF = new RectangleF((float)(580 + letrai), (float)(num2 - 5), 100f, (float)num3);
            //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //    }
            //}
            //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
            //{
            //    RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num5 - 5), 780f, 27f);
            //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
            //}
        }

        // Token: 0x060007E6 RID: 2022 RVA: 0x001496FC File Offset: 0x001478FC
        private void button2_Click(object sender, EventArgs e)
        {
            this.lan = 0;
            this.sodong = 28;
            this.numberOfItemsPerPage = 0;
            this.numberOfItemsPrintedSoFar = 0;
            if (this.dgvchitiethanghoa.RowCount > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = this.printDocument1;
                DialogResult dialogResult = printDialog.ShowDialog();
                printDocument.PrintPage += this.printDocument1_PrintPage;
                if (dialogResult == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        // Token: 0x040008BF RID: 2239
      //  private CauhinhObj chObj = new CauhinhObj();

        // Token: 0x040008C0 RID: 2240
        private int lan = 0;

        // Token: 0x040008C1 RID: 2241
        private int numberOfItemsPerPage = 0;

        // Token: 0x040008C2 RID: 2242
        private int numberOfItemsPrintedSoFar = 0;

        // Token: 0x040008C3 RID: 2243
        private int sodong = 28;
    }
}
