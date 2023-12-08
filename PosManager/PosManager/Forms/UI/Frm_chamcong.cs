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
    public partial class Frm_chamcong : Form
    {
        public Frm_chamcong()
        {
            InitializeComponent();
        }
        private void Frm_chamcong_Load(object sender, EventArgs e)
        {
            BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
            bindingList.Add(new KeyValuePair<string, string>("01", "01/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("02", "02/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("03", "03/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("04", "04/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("05", "05/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("06", "06/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("07", "07/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("08", "08/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("09", "09/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("10", "10/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("11", "11/" + DateTime.Now.ToString("yyyy")));
            bindingList.Add(new KeyValuePair<string, string>("12", "12/" + DateTime.Now.ToString("yyyy")));
            this.cob_thang.Items.Clear();
            this.cob_thang.DataSource = bindingList;
            this.cob_thang.ValueMember = "Key";
            this.cob_thang.DisplayMember = "Value";
            this.cob_thang.SelectedValue = DateTime.Now.ToString("MM");
            this.txtthoigian.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, -5, 1024, Screen.PrimaryScreen.WorkingArea.Height);
          //  this.timer1.Start();
        }

        // Token: 0x0600057F RID: 1407 RVA: 0x00111838 File Offset: 0x0010FA38
        private void txtmara_Leave(object sender, EventArgs e)
        {
            if (this.txtmara.Text.Trim() == "")
            {
                this.txtmara.Text = this.txtmara.Tag.ToString();
            }
        }

        // Token: 0x06000580 RID: 1408 RVA: 0x00111884 File Offset: 0x0010FA84
        private void txtmara_Enter(object sender, EventArgs e)
        {
            if (this.txtmara.Text.Trim() == this.txtmara.Tag.ToString())
            {
                this.txtmara.Text = "";
            }
        }

        // Token: 0x06000581 RID: 1409 RVA: 0x001118D0 File Offset: 0x0010FAD0
        private void txtmavao_Leave(object sender, EventArgs e)
        {
            if (this.txtmavao.Text.Trim() == "")
            {
                this.txtmavao.Text = this.txtmavao.Tag.ToString();
            }
        }

        // Token: 0x06000582 RID: 1410 RVA: 0x0011191C File Offset: 0x0010FB1C
        private void txtmavao_Enter(object sender, EventArgs e)
        {
            if (this.txtmavao.Text.Trim() == this.txtmavao.Tag.ToString())
            {
                this.txtmavao.Text = "";
            }
        }

        // Token: 0x06000583 RID: 1411 RVA: 0x00111968 File Offset: 0x0010FB68
        private void button1_Click(object sender, EventArgs e)
        {
            //this.xuat_excel = 0;
            //if (this.txtmavao.Text.Trim() != this.txtmavao.Tag.ToString())
            //{
            //    if (this.txtmavao.Text.Trim() != "")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "SELECT ISNULL(VAO1,''),ISNULL(VAO2,''),ISNULL(VAO3,'') FROM TB_CHAMCONG WHERE CONVERT(DATETIME,NGAY,103)='",
            //            Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //            "' AND MANHANVIEN='",
            //            this.txtmavao.Text.Trim(),
            //            "'"
            //        }), sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            if (Convert.ToString(sqlDataReader.GetValue(0)) == "")
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET VAO1='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmavao.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //            else if (Convert.ToString(sqlDataReader.GetValue(1)) == "")
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET VAO2='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmavao.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //            else
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET VAO3='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmavao.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //        }
            //        try
            //        {
            //            if (!sqlDataReader.HasRows)
            //            {
            //                sqlConnection.Close();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "INSERT INTO TB_CHAMCONG ([MANHANVIEN],[NGAY],[VAO1],[RA1],[VAO2],[RA2],[VAO3],[RA3]) VALUES ( '",
            //                    this.txtmavao.Text.Trim(),
            //                    "','",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("dd/MM/yyyy"),
            //                    "','",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "','','','','','') "
            //                }), sqlConnection);
            //                sqlConnection.Open();
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //        catch
            //        {
            //        }
            //        this.load_chamcong(this.txtmavao.Text.Trim(), Convert.ToDateTime(this.txtthoigian.Text).ToString("MM"), Convert.ToDateTime(this.txtthoigian.Text).ToString("yyyy"));
            //        frm_congviec.manhanvien_yeucau = this.txtmavao.Text;
            //        frm_congviec frm_congviec = new frm_congviec();
            //        frm_congviec.ShowDialog();
            //        this.txtmavao.Text = "";
            //    }
            //}
            //if (this.txtmara.Text.Trim() != this.txtmara.Tag.ToString())
            //{
            //    if (this.txtmara.Text.Trim() != "")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "SELECT ISNULL(RA1,''),ISNULL(RA2,''),ISNULL(RA3,'') FROM TB_CHAMCONG WHERE CONVERT(DATETIME,NGAY,103)='",
            //            Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //            "' AND MANHANVIEN='",
            //            this.txtmara.Text.Trim(),
            //            "'"
            //        }), sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            if (Convert.ToString(sqlDataReader.GetValue(0)) == "")
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET RA1='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmara.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //            else if (Convert.ToString(sqlDataReader.GetValue(1)) == "")
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET RA2='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmara.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //            else
            //            {
            //                if (sqlConnection.State == ConnectionState.Open)
            //                {
            //                    sqlConnection.Close();
            //                }
            //                sqlConnection.Open();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHAMCONG SET RA3='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "'  WHERE CONVERT(DATETIME,NGAY,103)='",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("MM/dd/yyyy"),
            //                    "' AND MANHANVIEN='",
            //                    this.txtmara.Text.Trim(),
            //                    "'"
            //                }), sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //            }
            //        }
            //        try
            //        {
            //            if (!sqlDataReader.HasRows)
            //            {
            //                sqlConnection.Close();
            //                sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "INSERT INTO TB_CHAMCONG ([MANHANVIEN],[NGAY],[VAO1],[RA1],[VAO2],[RA2],[VAO3],[RA3]) VALUES ( '",
            //                    this.txtmara.Text.Trim(),
            //                    "','",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("dd/MM/yyyy"),
            //                    "','','",
            //                    Convert.ToDateTime(this.txtthoigian.Text).ToString("HH:mm dd/MM/yyyy"),
            //                    "','','','','') "
            //                }), sqlConnection);
            //                sqlConnection.Open();
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //        catch
            //        {
            //        }
            //        this.load_chamcong(this.txtmara.Text.Trim(), Convert.ToDateTime(this.txtthoigian.Text).ToString("MM"), Convert.ToDateTime(this.txtthoigian.Text).ToString("yyyy"));
            //        this.txtmara.Text = "";
            //    }
            //}
        }

        // Token: 0x06000584 RID: 1412 RVA: 0x00112310 File Offset: 0x00110510
        private void load_chamcong(string nhanvien, string thang, string nam)
        {
            //double num = 0.0;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT NV.MaNV,NV.TenNV,NGAY,LEFT(VAO1,5) AS VAO1 ,LEFT( RA1,5) AS RA1, LEFT(VAO2,5) AS VAO2,LEFT(RA2,5) AS RA2,LEFT(VAO3,5)AS VAO3,LEFT(RA3,5)AS RA3, CASE WHEN VAO1!='' AND RA1!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO1,103), CONVERT(DATETIME,RA1,103) ) ELSE '0' END  +  CASE WHEN VAO2!='' AND RA2!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO2,103), CONVERT(DATETIME,RA2,103) ) ELSE '0' END +  CASE WHEN VAO3!='' AND RA3!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO3,103), CONVERT(DATETIME,RA3,103) ) ELSE '0' END AS TONGGIO  FROM Tb_NhanVien NV,TB_CHAMCONG C WHERE NV.MaNV=C.MANHANVIEN AND month( CONVERT(DATETIME,NGAY,103))='",
            //    thang,
            //    "' AND year( CONVERT(DATETIME,NGAY,103))='",
            //    nam,
            //    "' AND C.MANHANVIEN='",
            //    nhanvien,
            //    "' ORDER BY STT DESC"
            //});
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgv_chamcong.BringToFront();
            //this.dgv_chamcong.DataSource = dataTable;
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < this.dgv_chamcong.RowCount; i++)
            //    {
            //        this.dgv_chamcong.Rows[i].Cells["Tonggio"].Value = double.Parse(this.dgv_chamcong.Rows[i].Cells["PHUT"].Value.ToString()) / 60.0;
            //        num += double.Parse(this.dgv_chamcong.Rows[i].Cells["PHUT"].Value.ToString());
            //    }
            //}
            //this.txttong.Text = this.txttong.Tag.ToString() + ": " + (num / 60.0).ToString("#,###.#");
        }

        // Token: 0x06000585 RID: 1413 RVA: 0x001124E4 File Offset: 0x001106E4
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtthoigian.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        }

        // Token: 0x06000586 RID: 1414 RVA: 0x00112510 File Offset: 0x00110710
        private void dgv_chamcong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgv_chamcong.RowCount; i++)
            {
                this.dgv_chamcong.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000587 RID: 1415 RVA: 0x00112564 File Offset: 0x00110764
        private void txtmavao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000588 RID: 1416 RVA: 0x00112564 File Offset: 0x00110764
        private void txtmara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000589 RID: 1417 RVA: 0x00112590 File Offset: 0x00110790
        private void button2_Click(object sender, EventArgs e)
        {
            //this.xuat_excel = 1;
            //double num = 0.0;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT NV.MaNV,NV.TenNV, SUM(CASE WHEN VAO1!='' AND RA1!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO1,103),CONVERT(DATETIME, RA1,103) ) ELSE '0' END  +  CASE WHEN VAO2!='' AND RA2!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO2,103), CONVERT(DATETIME,RA2,103) ) ELSE '0' END +  CASE WHEN VAO3!='' AND RA3!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO3,103), CONVERT(DATETIME,RA3,103) ) ELSE '0' END ) AS TONGGIO  FROM Tb_NhanVien NV,TB_CHAMCONG C WHERE NV.MaNV=C.MANHANVIEN AND YEAR(CONVERT(DATETIME,NGAY,103))='",
            //    this.cob_thang.Text.Substring(3, 4),
            //    "' AND MONTH(CONVERT(DATETIME,NGAY,103))='",
            //    this.cob_thang.Text.Substring(0, 2),
            //    "' GROUP BY NV.MaNV,NV.TenNV HAVING SUM(CASE WHEN VAO1!='' AND RA1!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO1,103),CONVERT(DATETIME, RA1,103) ) ELSE '0' END  +  CASE WHEN VAO2!='' AND RA2!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO2,103), CONVERT(DATETIME,RA2,103) ) ELSE '0' END +  CASE WHEN VAO3!='' AND RA3!='' THEN DATEDIFF ( minute ,CONVERT(DATETIME,VAO3,103), CONVERT(DATETIME,RA3,103) ) ELSE '0' END )>0"
            //});
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtonghop.BringToFront();
            //this.dgvtonghop.DataSource = dataTable;
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < this.dgvtonghop.RowCount; i++)
            //    {
            //        this.dgvtonghop.Rows[i].Cells[0].Value = i + 1;
            //        this.dgvtonghop.Rows[i].Cells["SOGIO"].Value = double.Parse(this.dgvtonghop.Rows[i].Cells["SOPHUT"].Value.ToString()) / 60.0;
            //        num += double.Parse(this.dgvtonghop.Rows[i].Cells["SOPHUT"].Value.ToString());
            //    }
            //}
            //this.txttong.Text = this.txttong.Tag.ToString() + ": " + (num / 60.0).ToString("#,###.#");
        }

        // Token: 0x0600058A RID: 1418 RVA: 0x001127AC File Offset: 0x001109AC
        private void dgvtonghop_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.load_chamcong(this.dgvtonghop.CurrentRow.Cells["nhanvien"].Value.ToString(), this.cob_thang.Text.Substring(0, 2), this.cob_thang.Text.Substring(3, 4));
        }

        // Token: 0x0600058B RID: 1419 RVA: 0x0011280C File Offset: 0x00110A0C
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = this.textBox1.Tag.ToString();
            }
        }

        // Token: 0x0600058C RID: 1420 RVA: 0x0001C7F6 File Offset: 0x0001A9F6
        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        // Token: 0x0600058D RID: 1421 RVA: 0x00112854 File Offset: 0x00110A54
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != this.textBox1.Tag.ToString())
            {
                if (this.textBox1.Text != "")
                {
                    this.xuat_excel = 0;
                    this.load_chamcong(this.textBox1.Text.Trim(), this.cob_thang.Text.Substring(0, 2), this.cob_thang.Text.Substring(3, 4));
                }
            }
        }

        // Token: 0x0600058E RID: 1422 RVA: 0x001128EC File Offset: 0x00110AEC
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.xuat_excel == 0)
            {
                this.xuatexcel();
            }
            else
            {
                this.xuatexcel_tonghop();
            }
        }

        // Token: 0x0600058F RID: 1423 RVA: 0x0011291C File Offset: 0x00110B1C
        private void xuatexcel()
        {
            //if (this.dgv_chamcong.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETCHAMCONG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_chamcong)));
            //    }
            //    Worksheet worksheet = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    worksheet.Cells[4, 1] = "Tháng:   " + this.cob_thang.Text;
            //    int num = 6;
            //    for (int i = 0; i < this.dgv_chamcong.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgv_chamcong.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 7, j + 1] = this.dgv_chamcong.Rows[i].Cells[j].Value;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "L" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    Range range2 = worksheet.get_Range("E" + 7, "E" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("G" + 7, "G" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("I" + 7, "I" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("K" + 7, "K" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgv_chamcong.RowCount + 8, 3] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site2 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site2.Target;
            //    CallSite<> p__Site = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site2;
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site3 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Site, Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site3.Target(Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site3, worksheet.Cells[this.dgv_chamcong.RowCount + 9, 3]), true);
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site4 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site4.Target;
            //    CallSite<> p__Site2 = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site4;
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site5 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Site2, Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site5.Target(Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site5, worksheet.Cells[this.dgv_chamcong.RowCount + 8, 2]), true);
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site6 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, HorizontalAlignment, object> target3 = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site6.Target;
            //    CallSite<> p__Site3 = Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site6;
            //    if (Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site7 == null)
            //    {
            //        Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Site3, Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site7.Target(Frm_chamcong.< xuatexcel > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgv_chamcong.RowCount + 9, 3]), HorizontalAlignment.Center);
            //    worksheet.Cells[this.dgv_chamcong.RowCount + 9, 3] = "KÝ TÊN";
            //    application.Visible = true;
            //}
        }

        // Token: 0x06000590 RID: 1424 RVA: 0x00112F88 File Offset: 0x00111188
        private void xuatexcel_tonghop()
        {
            //if (this.dgvtonghop.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\TONGHOPCHAMCONG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Site9 == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Site9 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frm_chamcong)));
            //    }
            //    Worksheet worksheet = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Site9.Target(Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Site9, workbook.Worksheets.get_Item(1));
            //    application.Visible = false;
            //    worksheet.Cells[4, 1] = "Tháng:   " + this.cob_thang.Text;
            //    int num = 6;
            //    for (int i = 0; i < this.dgvtonghop.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvtonghop.Columns.Count; j++)
            //        {
            //            if (this.dgvtonghop.Columns[j].Name == "th_tt")
            //            {
            //                worksheet.Cells[i + 7, 1] = this.dgvtonghop.Rows[i].Cells[j].Value;
            //            }
            //            else if (this.dgvtonghop.Columns[j].Name == "nhanvien")
            //            {
            //                worksheet.Cells[i + 7, 2] = this.dgvtonghop.Rows[i].Cells[j].Value;
            //            }
            //            else if (this.dgvtonghop.Columns[j].Name == "th_nhanvien")
            //            {
            //                worksheet.Cells[i + 7, 3] = this.dgvtonghop.Rows[i].Cells[j].Value;
            //            }
            //            else if (this.dgvtonghop.Columns[j].Name == "sogio")
            //            {
            //                worksheet.Cells[i + 7, 4] = this.dgvtonghop.Rows[i].Cells[j].Value;
            //            }
            //        }
            //        Range range = worksheet.get_Range("A" + num, "D" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    Range range2 = worksheet.get_Range("B" + 7, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("D" + 7, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvtonghop.RowCount + 8, 10] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitea == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitea = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitea.Target;
            //    CallSite<> p__Sitea = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitea;
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Siteb == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Sitea, Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Siteb.Target(Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Siteb, worksheet.Cells[this.dgvtonghop.RowCount + 9, 10]), true);
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitec == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitec = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitec.Target;
            //    CallSite<> p__Sitec = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitec;
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sited == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sited = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Sitec, Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sited.Target(Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sited, worksheet.Cells[this.dgvtonghop.RowCount + 8, 2]), true);
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitee == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitee = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, HorizontalAlignment, object> target3 = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitee.Target;
            //    CallSite<> p__Sitee = Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitee;
            //    if (Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitef == null)
            //    {
            //        Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitef = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frm_chamcong), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Sitee, Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitef.Target(Frm_chamcong.< xuatexcel_tonghop > o__SiteContainer8.<> p__Sitef, worksheet.Cells[this.dgvtonghop.RowCount + 9, 10]), HorizontalAlignment.Center);
            //    worksheet.Cells[this.dgvtonghop.RowCount + 9, 10] = "KÝ TÊN";
            //    application.Visible = true;
            //}
        }

        // Token: 0x040005DA RID: 1498
        private int xuat_excel = 0;
    }
}
