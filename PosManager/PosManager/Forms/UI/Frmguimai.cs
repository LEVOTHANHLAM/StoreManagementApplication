using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmguimai : Form
    {
        public Frmguimai()
        {
            InitializeComponent();
        }
        private void xuatexcel()
        {
            //string text = DateTime.Now.ToString("MM/dd/yyyy");
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,SUM(TONGSOLUONG)AS TONGSOLUONG,DONGIABAN ,SUM(THANHTIEN)AS THANHTIEN FROM TB_CHITIETHOADON \r\n            WHERE NHANVIEN='",
            //    frmLogIn.MADANGNHAP,
            //    "' AND HUY='FALSE' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //    text,
            //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //    text,
            //    "' GROUP BY MAHANGHOA,TENHANGHOA,DONVITINH,DONGIABAN ORDER BY SUM(TONGSOLUONG) DESC, TENHANGHOA"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvchitiethanghoa.DataSource = dataTable;
            //if (this.dgvchitiethanghoa.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETBANHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmguimai)));
            //    }
            //    Worksheet worksheet = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    worksheet.Cells[1, 1] = this.tencongty;
            //    worksheet.Cells[2, 1] = this.diachi;
            //    worksheet.Cells[3, 1] = this.dienthoai;
            //    worksheet.Cells[5, 1] = "Từ 00:00 " + DateTime.Now.ToString("dd/MM/yyyy") + "đến 23:59 " + DateTime.Now.ToString("dd/MM/yyyy");
            //    int num = 6;
            //    for (int i = 0; i < this.dgvchitiethanghoa.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvchitiethanghoa.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 7, j + 1] = this.dgvchitiethanghoa.Rows[i].Cells[j].Value;
            //            worksheet.Cells[i + 7, 1] = i + 1;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "G" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 7, 2] = "TỔNG CỘNG: ";
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 7, 7] = "=SUM(G7:G" + num + ")";
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
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site2 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site2.Target;
            //    CallSite<> p__Site = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site2;
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site3 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Site, Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site3.Target(Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site3, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 2]), true);
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site4 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site4.Target;
            //    CallSite<> p__Site2 = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site4;
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site5 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Site2, Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site5.Target(Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site5, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 8, 2]), true);
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site6 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, HorizontalAlignment, object> target3 = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site6.Target;
            //    CallSite<> p__Site3 = Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site6;
            //    if (Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site7 == null)
            //    {
            //        Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Site3, Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site7.Target(Frmguimai.< xuatexcel > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6]), HorizontalAlignment.Center);
            //    worksheet.Cells[this.dgvchitiethanghoa.RowCount + 9, 6] = "NGƯỜI LẬP";
            //    string str = "BAOCAOCHITIET" + DateTime.Now.ToString("dd.MM.yy");
            //    File.Delete(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\" + str);
            //    application.ActiveWorkbook.SaveCopyAs(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\" + str + ".xlsx");
            //    application.ActiveWorkbook.Saved = true;
            //    application.Quit();
            //    int num2;
            //    Frmguimai.GetWindowThreadProcessId(application.Hwnd, out num2);
            //    Process[] processesByName = Process.GetProcessesByName("EXCEL");
            //    foreach (Process process in processesByName)
            //    {
            //        if (process.Id == num2)
            //        {
            //            process.Kill();
            //        }
            //    }
            //}
        }

        // Token: 0x060011F6 RID: 4598
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(int handle, out int processId);

        // Token: 0x060011F7 RID: 4599 RVA: 0x0001F61E File Offset: 0x0001D81E
        private void Frmguimai_Load(object sender, EventArgs e)
        {
         //   this.timer1.Start();
        }

        // Token: 0x060011F8 RID: 4600 RVA: 0x0001F62D File Offset: 0x0001D82D
        private void timer1_Tick(object sender, EventArgs e)
        {
           // this.button1_Click(null, null);
          //  this.timer1.Stop();
        }

        // Token: 0x060011F9 RID: 4601 RVA: 0x0020A23C File Offset: 0x0020843C
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "SELECT MAILGUI,MATKHAU,MAILNHAN,TENCONGTY,DIACHI,DIENTHOAI,CHITIETHANGHOA,GUIHOADON,CHITIETLAILO,GUIMAI FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.tencongty = Convert.ToString(sqlDataReader.GetValue(3));
            //        this.diachi = Convert.ToString(sqlDataReader.GetValue(4));
            //        this.dienthoai = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.hanghoa = Convert.ToString(sqlDataReader.GetValue(6));
            //        this.hoadon = Convert.ToString(sqlDataReader.GetValue(7));
            //        this.hanghoalailo = Convert.ToString(sqlDataReader.GetValue(8));
            //        try
            //        {
            //            if (!Directory.Exists(this.dicrectoryPath + "\\EMAIL"))
            //            {
            //                Directory.CreateDirectory(this.dicrectoryPath + "\\EMAIL");
            //            }
            //            if (this.hanghoa == "True")
            //            {
            //                this.xuatexcel();
            //            }
            //            if (this.hoadon == "True")
            //            {
            //                this.xuatexcel_hoadon();
            //            }
            //            if (this.hanghoalailo == "True")
            //            {
            //                this.xuatexcel_lailo();
            //            }
            //            if (Convert.ToString(sqlDataReader.GetValue(9)) == "True")
            //            {
            //                string[] array = Convert.ToString(sqlDataReader.GetValue(2)).Split(new char[]
            //                {
            //                    ','
            //                });
            //                string to = array[0];
            //                MailMessage mailMessage = new MailMessage(Convert.ToString(sqlDataReader.GetValue(0)), to, "BÁO CÁO BÁN HÀNG", "BÁO CÁO BÁN HÀNG NGÀY " + DateTime.Now.ToString("MM/dd/yyyy"));
            //                string text = System.Windows.Forms.Application.StartupPath + "\\EMAIL\\BAOCAOCHITIET" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx";
            //                string text2 = System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HOADONBANHANG" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx";
            //                string text3 = System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HANGHOALAILO" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx";
            //                if (File.Exists(text))
            //                {
            //                    mailMessage.Attachments.Add(new Attachment(text));
            //                }
            //                if (File.Exists(text2))
            //                {
            //                    mailMessage.Attachments.Add(new Attachment(text2));
            //                }
            //                if (File.Exists(text3))
            //                {
            //                    mailMessage.Attachments.Add(new Attachment(text3));
            //                }
            //                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //                smtpClient.Port = 587;
            //                smtpClient.Credentials = new NetworkCredential(Convert.ToString(sqlDataReader.GetValue(0)), Convert.ToString(sqlDataReader.GetValue(1)));
            //                smtpClient.EnableSsl = true;
            //                foreach (string text4 in array)
            //                {
            //                    string text5 = text4.ToString();
            //                    if (text5 != array[0])
            //                    {
            //                        mailMessage.CC.Add(text5);
            //                    }
            //                }
            //                smtpClient.Send(mailMessage);
            //                mailMessage.Dispose();
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            this.timer1.Stop();
            //            MessageBox.Show("Xuất file bị lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //    }
            //    sqlConnection.Close();
            //    this.timer1.Stop();
            //}
            //catch
            //{
            //    this.timer1.Stop();
            //}
            //base.Close();
        }

        // Token: 0x060011FA RID: 4602 RVA: 0x0020A64C File Offset: 0x0020884C
        private void xuatexcel_hoadon()
        {
            //string text = DateTime.Now.ToString("MM/dd/yyyy");
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT SOHOADON,ISNULL(KH.TENDONVI,N'Khách Lẻ') as tendonvi,TONGCONG,GIAMTIEN,TIENPHANTRAM,THANHTOAN,CASE WHEN HINHTHUC=1 THEN N'Tiền Mặt' ELSE N'Công Nợ' END as ht, NGAY FROM TB_HOADONBANHANG HD LEFT JOIN Tb_KHACHHANG KH ON HD.MAKHACHHANG=KH.MAKHACHHANG WHERE CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //    text,
            //    "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //    text,
            //    "' and huyhd='False' AND NHANVIEN='",
            //    frmLogIn.MADANGNHAP,
            //    "' ORDER BY CONVERT(DATETIME,RIGHT(NGAY,10),103),SOHOADON"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvhoadon.DataSource = dataTable;
            //if (this.dgvhoadon.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\HOADONBANHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site9 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site9 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmguimai)));
            //    }
            //    Worksheet worksheet = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site9.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site9, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    worksheet.Cells[1, 1] = this.tencongty;
            //    worksheet.Cells[2, 1] = this.diachi;
            //    worksheet.Cells[3, 1] = this.dienthoai;
            //    worksheet.Cells[5, 1] = "Từ 00:00 " + DateTime.Now.ToString("dd/MM/yyyy") + "đến 23:59 " + DateTime.Now.ToString("dd/MM/yyyy");
            //    int num = 6;
            //    for (int i = 0; i < this.dgvhoadon.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvhoadon.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 7, j + 1] = this.dgvhoadon.Rows[i].Cells[j].Value;
            //            worksheet.Cells[i + 7, 1] = i + 1;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "I" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    worksheet.Cells[this.dgvhoadon.RowCount + 7, 2] = "TỔNG CỘNG: ";
            //    worksheet.Cells[this.dgvhoadon.RowCount + 7, 4] = "=SUM(D7:D" + num + ")";
            //    worksheet.Cells[this.dgvhoadon.RowCount + 7, 5] = "=SUM(E7:E" + num + ")";
            //    worksheet.Cells[this.dgvhoadon.RowCount + 7, 6] = "=SUM(F7:F" + num + ")";
            //    worksheet.Cells[this.dgvhoadon.RowCount + 7, 7] = "=SUM(G7:G" + num + ")";
            //    num++;
            //    Range range2 = worksheet.get_Range("A" + num, "I" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("D" + 7, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("H" + 7, "H" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 7, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("B" + 7, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitea == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitea = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitea.Target;
            //    CallSite<> p__Sitea = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitea;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Siteb == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Sitea, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Siteb.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Siteb, worksheet.Cells[this.dgvhoadon.RowCount + 7, 2]), true);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitec == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitec = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitec.Target;
            //    CallSite<> p__Sitec = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitec;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sited == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sited = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Sitec, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sited.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sited, worksheet.Cells[this.dgvhoadon.RowCount + 7, 4]), true);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitee == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitee = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target3 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitee.Target;
            //    CallSite<> p__Sitee = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitee;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitef == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitef = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Sitee, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitef.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Sitef, worksheet.Cells[this.dgvhoadon.RowCount + 7, 5]), true);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site10 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site10 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target4 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site10.Target;
            //    CallSite<> p__Site = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site10;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site11 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target4(<> p__Site, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site11.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site11, worksheet.Cells[this.dgvhoadon.RowCount + 7, 6]), true);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site12 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site12 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target5 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site12.Target;
            //    CallSite<> p__Site2 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site12;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site13 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site13 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target5(<> p__Site2, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site13.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site13, worksheet.Cells[this.dgvhoadon.RowCount + 7, 7]), true);
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site14 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site14 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target6 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site14.Target;
            //    CallSite<> p__Site3 = Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site14;
            //    if (Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site15 == null)
            //    {
            //        Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target6(<> p__Site3, Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site15.Target(Frmguimai.< xuatexcel_hoadon > o__SiteContainer8.<> p__Site15, worksheet.Cells[this.dgvhoadon.RowCount + 9, 7]), true);
            //    worksheet.Cells[this.dgvhoadon.RowCount + 8, 7] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    worksheet.Cells[this.dgvhoadon.RowCount + 9, 7] = "NGƯỜI LẬP";
            //    File.Delete(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HOADONBANHANG" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx");
            //    application.ActiveWorkbook.SaveCopyAs(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HOADONBANHANG" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx");
            //    application.ActiveWorkbook.Saved = true;
            //    application.Quit();
            //    int num2;
            //    Frmguimai.GetWindowThreadProcessId(application.Hwnd, out num2);
            //    Process[] processesByName = Process.GetProcessesByName("EXCEL");
            //    foreach (Process process in processesByName)
            //    {
            //        if (process.Id == num2)
            //        {
            //            process.Kill();
            //        }
            //    }
            }


        // Token: 0x060011FB RID: 4603 RVA: 0x0020B2D0 File Offset: 0x002094D0
        private void xuatexcel_lailo()
        {
            //string text = "";
            //string text2 = "AND CT.NHANVIEN='" + frmLogIn.MADANGNHAP + "'";
            //DataTable dataTable = new DataTable();
            //string text3 = DateTime.Now.ToString("MM/dd/yyyy");
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_KHONHAPHANG_DAUKY INSERT INTO TB_KHONHAPHANG_DAUKY(MAHANG,SOLUONG,DONGIA) ( SELECT HH.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),'",
            //    text3,
            //    "'),101)AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //    text3,
            //    "'))-1),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101) GROUP BY HH.MAHANGHOA,HH.QUYDOI1) DELETE TB_KHOXUAT_DAUKY1 INSERT INTO TB_KHOXUAT_DAUKY1(MAHANG,SOLUONG,DONGIA) (  SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A' THEN CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)  ELSE SUM(CT.TONGSOLUONG)  END END AS SL, '0' FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)<= '23:59 '+CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),'",
            //    text3,
            //    "'),101) AND CONVERT(datetime,CT.NGAYXUAT,103)>='00:00 ' + CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //    text3,
            //    "'))-1),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101) GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI)      DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY)   (SELECT * FROM TB_TON0 WHERE MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101)))   DELETE TB_KHOXUAT_DAUKY2 INSERT INTO TB_KHOXUAT_DAUKY2(MAHANG,SOLUONG, DONGIA) (SELECT MAHANG,SUM(ISNULL(SOLUONG,0)),'0' FROM TB_KHOXUAT_DAUKY1 GROUP BY MAHANG)     DELETE TB_TON0_2 INSERT INTO TB_TON0_2(MAHANG,SOLUONG,DONGIA)  (SELECT T.MAHANG,ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0),T.DONGIA FROM TB_TON0 T LEFT JOIN TB_KHOXUAT_DAUKY2 K ON T.MAHANG=K.MAHANG WHERE ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0)>0 AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),DATEADD(mm,-1,'",
            //    text3,
            //    "')),101)))     DELETE TB_KHOXUAT_DAUKY INSERT INTO TB_KHOXUAT_DAUKY(MAHANG,SOLUONG,DONGIA) (SELECT K.MAHANG,ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0),'0' FROM TB_KHOXUAT_DAUKY2 K LEFT JOIN TB_TON0_1 T ON T.MAHANG=K.MAHANG       WHERE ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)>0)  DELETE [TB_TON1]  INSERT INTO [TB_TON1](MAHANG,SOLUONG,DONGIA,NGAY)   (SELECT B1.MAHANG,SUM( ISNULL(B1.SOLUONG,0))-ISNULL(B2.SOLUONG,0),SUM(B1.SOLUONG * B1.DONGIA)/SUM(B1.SOLUONG),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text3,
            //    "')),'00:00 ",
            //    text3,
            //    "'),101)  FROM TB_KHONHAPHANG_DAUKY B1 LEFT JOIN TB_KHOXUAT_DAUKY B2 ON B1.MAHANG=B2.MAHANG GROUP BY B1.MAHANG,B2.SOLUONG HAVING sum(ISNULL(B1.SOLUONG,0))-ISNULL(B2.SOLUONG,0)>0) DELETE TB_KHONHAPHANG INSERT INTO TB_KHONHAPHANG(MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND CONVERT(datetime,ngaynhap,103)> CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),'",
            //    text3,
            //    "'),101) AND CONVERT(datetime,ngaynhap,103)<'",
            //    text3,
            //    "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1)  DELETE TB_KHOXUAT INSERT INTO TB_KHOXUAT(MAHANG,SOLUONG,DONGIA) (SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A' THEN CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
            //    TrangChu.doicm,
            //    " ELSE SUM(CT.TONGSOLUONG)  END END AS SL, '0' FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)>'23:59 '+CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text3,
            //    "')),'",
            //    text3,
            //    "'),101)AND CONVERT(datetime,CT.NGAYXUAT,103)<'00:00 '+'",
            //    text3,
            //    "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI)  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(SOLUONG),'0' FROM TB_KHOXUAT GROUP BY MAHANG)  DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON0_2 B1 ON HH.MAHANGHOA=  B1.MAHANG)LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG WHERE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)>0 )   DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA)   (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0) END,ISNULL(B1.DONGIA ,0)                        FROM (TB_HANGHOA HH                          LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA=   B1.MAHANG)                         LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG                          LEFT JOIN TB_TON0_2 T2                          ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)  DELETE [TB_TON3] INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,ISNULL(B2.DONGIA ,0) FROM ((TB_HANGHOA HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0)HAVING (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))!=0) DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)     (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP     WHERE CONVERT(datetime,ngaynhap,103)>='",
            //    text3,
            //    "' AND CONVERT(datetime,ngaynhap,103)<='",
            //    text3,
            //    "' GROUP BY MAHANGHOA)      DELETE [TB_XUAT_TAM] INSERT INTO [TB_XUAT_TAM](MAHANG,SOLUONG,DONGIA)     (SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A' THEN CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.DONVITINH=CT.DONVITINH THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)  ELSE SUM(CT.TONGSOLUONG)  END END AS SL,SUM(CT.THANHTIEN) AS GIABAN    FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)>= '00:00 ",
            //    text3,
            //    "' AND CONVERT(datetime,CT.NGAYXUAT,103)<='23:59 ",
            //    text3,
            //    "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI)   DELETE [TB_XUATTAM_1] INSERT INTO [TB_XUATTAM_1](MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(SOLUONG),'0' FROM [TB_XUAT_TAM] GROUP BY MAHANG)      DELETE [TB_TON0_4] INSERT INTO [TB_TON0_4](MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON0_3 B1 ON HH.MAHANGHOA=    B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG WHERE B1.SOLUONG>0)    DELETE [TB_TON4]    INSERT INTO [TB_TON4](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,ISNULL(B2.SOLUONG,0)-(ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA=    B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_3 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)  DELETE [TB_TON5] INSERT INTO [TB_TON5](MAHANG,SOLUONG,DONGIA)   (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>=0THEN ISNULL(B2.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0)END,ISNULL(B2.DONGIA ,0) FROM ((TB_HANGHOA HH LEFT JOIN TB_TON4 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_TON3 B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0)HAVING (ISNULL(B1.SOLUONG,0)+SUM(ISNULL(B2.SOLUONG,0)))!=0)     DELETE [TB_TON6] INSERT INTO [TB_TON6](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B.SOLUONG,0)END,ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON5 B ON HH.MAHANGHOA=B.MAHANG)LEFT JOIN [TB_TONKHOCUOI] B1 ON HH.MAHANGHOA=B1.MAHANG GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B.SOLUONG,0) HAVING ISNULL(B1.SOLUONG,0)!=0 AND SUM(ISNULL(B.SOLUONG,0))!=0 ) DELETE TB_KHONHAPHANG_HIENTAI INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT * FROM TB_TON0_3 WHERE SOLUONG>0) INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT * FROM TB_TON2 WHERE SOLUONG>0)INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON3 WHERE SOLUONG>0) DELETE TB_KHOXUAT_MOI INSERT INTO TB_KHOXUAT_MOI(MAHANG,SOLUONG,DONGIA) (SELECT MAHANG,SUM(SOLUONG),SUM(SOLUONG*DONGIA)/SUM(SOLUONG)FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG)DELETE TB_TON0 WHERE YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text3,
            //    "')),'00:00 ",
            //    text3,
            //    "'),101)) AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text3,
            //    "')),'00:00 ",
            //    text3,
            //    "'),101)) INSERT INTO [TB_TON0](MAHANG,SOLUONG,DONGIA,NGAY)(SELECT HH.MAHANGHOA,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))/(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text3,
            //    "')),'00:00 ",
            //    text3,
            //    "'),101) FROM TB_HANGHOA HH LEFT JOIN TB_TON1 T1 ON T1.MAHANG=HH.MAHANGHOA LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)>0) DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)(  SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG>0 GROUP BY MAHANG) DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)>0 GROUP BY NK.MAHANG) DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK  WHERE ISNULL(NK.SOLUONG,0)>0 GROUP BY NK.MAHANG) DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM [TB_XUATTRONGKY] NK  WHERE ISNULL(NK.SOLUONG,0)>0 GROUP BY NK.MAHANG)  DELETE TB_LAILO_1 INSERT INTO TB_LAILO_1(MAHANG,SOLUONG,DONGIA,GIABAN)                        (SELECT B2.MAHANG ,CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(B1.SOLUONG,0)>=0 THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B2.SOLUONG,0)END AS SL,ISNULL(B1.DONGIA ,0) ,ISNULL(B2.DONGIA,0)                       FROM TB_XTK1 B2 LEFT JOIN TB_DK1 B1 ON B2.MAHANG=B1.MAHANG WHERE B1.SOLUONG>0)    DELETE TB_LAILO_2 INSERT INTO TB_LAILO_2(MAHANG,SOLUONG,DONGIA,GIABAN)                        (SELECT B2.MAHANG ,CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(B1.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(B1.SOLUONG,0)<=ISNULL(TK.SOLUONG,0) THEN ISNULL(B2.SOLUONG,0)-ISNULL(B1.SOLUONG,0)ELSE ISNULL(TK.SOLUONG,0)END ELSE '0' END AS SL,ISNULL(TK.DONGIA ,0) ,ISNULL(B2.DONGIA,0)                       FROM TB_XTK1 B2 LEFT JOIN TB_DK1 B1 ON B2.MAHANG=B1.MAHANG LEFT JOIN TB_TK1 TK ON B2.MAHANG=TK.MAHANG WHERE ISNULL(TK.SOLUONG,0)>0)   DELETE TB_LAILO_3 INSERT INTO TB_LAILO_3(MAHANG,SOLUONG,DONGIA,GIABAN)                       (SELECT HH.MAHANGHOA,ISNULL(L1.SOLUONG,0)+ISNULL(L2.SOLUONG,0)AS SL,(ISNULL(L1.SOLUONG,0)*ISNULL(L1.DONGIA,0)+ISNULL(L2.DONGIA,0)*ISNULL(L2.SOLUONG,0))/(ISNULL(L1.SOLUONG,0)+ISNULL(L2.SOLUONG,0)),'0' FROM TB_HANGHOA HH LEFT JOIN TB_LAILO_1 L1  ON HH.MAHANGHOA=L1.MAHANG LEFT JOIN TB_LAILO_2 L2 ON HH.MAHANGHOA=L2.MAHANG WHERE ISNULL(L2.SOLUONG,0)+ISNULL(L1.SOLUONG,0)>0)           SELECT CT.MAHANGHOA,CT.TENHANGHOA,CASE WHEN CT.DONVITINH=HH.DONVITINH THEN HH.DONVITINH ELSE CT.DONVITINH END AS DONVITINH,       CASE WHEN CT.LOAI='A' THEN SUM(CT.TONGSOLUONG) ELSE SUM(CT.TONGSOLUONG)  END AS TONGSOLUONG,CASE WHEN CT.DONVITINH=HH.DONVITINH THEN CT.DONGIABAN ELSE CT.DONGIABAN  END AS DONGIABAN,        SUM(CT.THANHTIEN)AS THANHTIEN,CASE WHEN CT.DONVITINH!=HH.DONVITINH THEN ISNULL(HN.DONGIA,0)/HH.QUYDOI1 ELSE ISNULL(HN.DONGIA,0) END AS GIAVON,      CASE WHEN CT.LOAI='A' THEN CASE WHEN CT.DONVITINH!=HH.DONVITINH THEN SUM(THANHTIEN-(ISNULL(HN.DONGIA,0)*TONGSOLUONG/HH.QUYDOI1)) ELSE SUM(THANHTIEN-(ISNULL(HN.DONGIA,0)*TONGSOLUONG))END ELSE            CASE WHEN CT.DONVITINH!=HH.DONVITINH THEN SUM(THANHTIEN-(ISNULL(HN.DONGIA,0)*(TONGSOLUONG/HH.QUYDOI1))) ELSE SUM(THANHTIEN-(ISNULL(HN.DONGIA,0)*(TONGSOLUONG)))END END AS LAILO      FROM TB_CHITIETHOADON CT LEFT JOIN TB_LAILO_3 HN ON HN.MAHANG=CT.MAHANGHOA,TB_HANGHOA HH     WHERE HH.MAHANGHOA=CT.MAHANGHOA AND CT.HUY='FALSE' ",
            //    text,
            //    "  AND convert(datetime,ct.ngayxuat,103)>='00:00 ",
            //    text3,
            //    "' AND convert(datetime,ct.ngayxuat,103)<='23:59 ",
            //    text3,
            //    "' ",
            //    text2,
            //    " GROUP BY CT.MAHANGHOA,CT.TENHANGHOA,CT.DONVITINH,CT.DONGIABAN,ISNULL(HN.DONGIA,0),HH.DONVITINH,HH.QUYDOI1,CT.LOAI ORDER BY CT.TENHANGHOA"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvlailo.DataSource = dataTable;
            //if (this.dgvlailo.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETLAILO.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site17 == null)
            //    {
            //        Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site17 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmguimai)));
            //    }
            //    Worksheet worksheet = Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site17.Target(Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site17, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    worksheet.Cells[1, 1] = this.tencongty;
            //    worksheet.Cells[2, 1] = this.diachi;
            //    worksheet.Cells[3, 1] = this.dienthoai;
            //    worksheet.Cells[5, 1] = "Từ 00:00 " + DateTime.Now.ToString("dd/MM/yyyy") + "đến 23:59 " + DateTime.Now.ToString("dd/MM/yyyy");
            //    int num = 6;
            //    for (int i = 0; i < this.dgvlailo.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvlailo.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 7, j + 1] = this.dgvlailo.Rows[i].Cells[j].Value;
            //            worksheet.Cells[i + 7, 1] = i + 1;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "K" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    worksheet.Cells[this.dgvlailo.RowCount + 7, 2] = "TỔNG CỘNG: ";
            //    worksheet.Cells[this.dgvlailo.RowCount + 7, 9] = "=SUM(I7:I" + num + ")";
            //    worksheet.Cells[this.dgvlailo.RowCount + 7, 11] = "=SUM(K7:K" + num + ")";
            //    Range range2 = worksheet.get_Range("D" + 7, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("H" + 7, "H" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 7, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("J" + 7, "J" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    if (Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site18 == null)
            //    {
            //        Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site18 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site18.Target;
            //    CallSite<> p__Site = Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site18;
            //    if (Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site19 == null)
            //    {
            //        Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site19 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Site, Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site19.Target(Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site19, worksheet.Cells[this.dgvlailo.RowCount + 9, 2]), true);
            //    if (Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1a == null)
            //    {
            //        Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1a = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1a.Target;
            //    CallSite<> p__Site1a = Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1a;
            //    if (Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1b == null)
            //    {
            //        Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1b = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmguimai), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Site1a, Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1b.Target(Frmguimai.< xuatexcel_lailo > o__SiteContainer16.<> p__Site1b, worksheet.Cells[this.dgvlailo.RowCount + 8, 2]), true);
            //    worksheet.Cells[this.dgvlailo.RowCount + 8, 9] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    worksheet.Cells[this.dgvlailo.RowCount + 9, 9] = "NGƯỜI LẬP";
            //    File.Delete(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HANGHOALAILO" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx");
            //    application.ActiveWorkbook.SaveCopyAs(System.Windows.Forms.Application.StartupPath + "\\EMAIL\\HANGHOALAILO" + DateTime.Now.ToString("dd.MM.yy") + ".xlsx");
            //    application.ActiveWorkbook.Saved = true;
            //    application.Quit();
            //    int num2;
            //    Frmguimai.GetWindowThreadProcessId(application.Hwnd, out num2);
            //    Process[] processesByName = Process.GetProcessesByName("EXCEL");
            //    foreach (Process process in processesByName)
            //    {
            //        if (process.Id == num2)
            //        {
            //            process.Kill();
            //        }
            //    }
            //}
        }
        // Token: 0x04001304 RID: 4868
        private string dicrectoryPath = System.Windows.Forms.Application.StartupPath;

        // Token: 0x04001305 RID: 4869
        private string tencongty;

        // Token: 0x04001306 RID: 4870
        private string diachi;

        // Token: 0x04001307 RID: 4871
        private string dienthoai;

        // Token: 0x04001308 RID: 4872
        private string hoadon;

        // Token: 0x04001309 RID: 4873
        private string hanghoa;

        // Token: 0x0400130A RID: 4874
        private string hanghoalailo;

  //      // Token: 0x020000E5 RID: 229
  //      [CompilerGenerated]
  //      private static class <xuatexcel>o__SiteContainer0
		//{
		//	// Token: 0x0400130B RID: 4875
		//	public static CallSite<Func<CallSite, object, Worksheet>> <>p__Site1;

		//	// Token: 0x0400130C RID: 4876
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Site2;

		//	// Token: 0x0400130D RID: 4877
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site3;

		//	// Token: 0x0400130E RID: 4878
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Site4;

		//	// Token: 0x0400130F RID: 4879
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site5;

		//	// Token: 0x04001310 RID: 4880
		//	public static CallSite<Func<CallSite, object, HorizontalAlignment, object>> <>p__Site6;

		//	// Token: 0x04001311 RID: 4881
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site7;
		//}

  //  // Token: 0x020000E6 RID: 230
  //  [CompilerGenerated]
  //  private static class <xuatexcel_hoadon>o__SiteContainer8
		//{
		//	// Token: 0x04001312 RID: 4882
		//	public static CallSite<Func<CallSite, object, Worksheet>> <>p__Site9;

		//	// Token: 0x04001313 RID: 4883
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Sitea;

		//	// Token: 0x04001314 RID: 4884
		//	public static CallSite<Func<CallSite, object, object>> <>p__Siteb;

		//	// Token: 0x04001315 RID: 4885
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Sitec;

		//	// Token: 0x04001316 RID: 4886
		//	public static CallSite<Func<CallSite, object, object>> <>p__Sited;

		//	// Token: 0x04001317 RID: 4887
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Sitee;

		//	// Token: 0x04001318 RID: 4888
		//	public static CallSite<Func<CallSite, object, object>> <>p__Sitef;

		//	// Token: 0x04001319 RID: 4889
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Site10;

		//	// Token: 0x0400131A RID: 4890
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site11;

		//	// Token: 0x0400131B RID: 4891
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Site12;

		//	// Token: 0x0400131C RID: 4892
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site13;

		//	// Token: 0x0400131D RID: 4893
		//	public static CallSite<Func<CallSite, object, bool, object>> <>p__Site14;

		//	// Token: 0x0400131E RID: 4894
		//	public static CallSite<Func<CallSite, object, object>> <>p__Site15;
		//}

//// Token: 0x020000E7 RID: 231
//[CompilerGenerated]
//private static class <xuatexcel_lailo>o__SiteContainer16
//		{
//            // Token: 0x0400131F RID: 4895
//            public static CallSite<Func<CallSite, object, Worksheet>> <> p__Site17;

//// Token: 0x04001320 RID: 4896
//public static CallSite<Func<CallSite, object, bool, object>> <> p__Site18;

//// Token: 0x04001321 RID: 4897
//public static CallSite<Func<CallSite, object, object>> <> p__Site19;

//// Token: 0x04001322 RID: 4898
//public static CallSite<Func<CallSite, object, bool, object>> <> p__Site1a;

//// Token: 0x04001323 RID: 4899
//public static CallSite<Func<CallSite, object, object>> <> p__Site1b;
//		}
    }
}
