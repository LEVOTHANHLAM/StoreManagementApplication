using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class FrmInmavach : Form
    {

        // Token: 0x0400014C RID: 332
        private int intu_phieunhap = 0;

        // Token: 0x0400014D RID: 333
        private int sl = 0;

        // Token: 0x0400014E RID: 334
        private int sotrang = 0;

        // Token: 0x0400014F RID: 335
        private int sotem = 0;

        // Token: 0x04000150 RID: 336
        private int i = 0;

        // Token: 0x04000151 RID: 337
        private int sodong = 0;

        // Token: 0x04000152 RID: 338
        private int lanin = 0;

        // Token: 0x04000153 RID: 339
        private int dong = 0;

        // Token: 0x04000154 RID: 340
        private int numberOfItemsPerPage = 0;

        // Token: 0x04000155 RID: 341
        private string dongia_in = "DONGIA";

        // Token: 0x04000156 RID: 342
        private string donvitinh_in = "DONVITINH";
        public FrmInmavach()
        {
            InitializeComponent();
        }
        private void DrawRotatedTextAt(Graphics gr, float angle, string txt, int x, int y, Font the_font, Brush the_brush)
        {
            GraphicsState gstate = gr.Save();
            gr.ResetTransform();
            gr.RotateTransform(angle);
            gr.TranslateTransform((float)x, (float)y, MatrixOrder.Append);
            gr.DrawString(txt, the_font, the_brush, 0f, 0f);
            gr.Restore(gstate);
        }
        private void printDocument1_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
            //int num = int.Parse(this.txtleft.Text);
            //int num2 = int.Parse(this.txtletop.Text);
            //double num3 = double.Parse(this.txtso.Text) * double.Parse(this.txth.Text) * 37.7953;
            //num2 += (int)num3;
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //int num4 = 0;
            //double num5 = double.Parse(this.txtw.Text) * 37.7953;
            //double num6 = double.Parse(this.txth.Text) * 37.7953;
            //for (int i = 0; i < this.dgvHangHoa.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(this.dgvHangHoa.Rows[i].Cells["STT"].Value))
            //    {
            //        for (int j = 0; j < int.Parse(this.dgvHangHoa.Rows[i].Cells["SLTEM"].Value.ToString()); j++)
            //        {
            //            this.sl++;
            //            e.Graphics.DrawString(this.txttieude.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleten.Text), num2));
            //            Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //            Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //            e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString(), new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + 13), stringFormat);
            //            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular, GraphicsUnit.Point))
            //            {
            //                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num5 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 4) * int.Parse(this.txtdong.Text)));
            //                e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, layoutRectangle, stringFormat);
            //            }
            //            string str = Convert.ToDouble(this.dgvHangHoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,###");
            //            if (this.cbgia.Checked)
            //            {
            //                e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text) + 60, num2 + int.Parse(this.txthd.Text) + 13 + image.Height + 10));
            //                e.Graphics.DrawString(str + " đ", new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10));
            //            }
            //            else
            //            {
            //                e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
            //                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                {
            //                    int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                    int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                    this.DrawRotatedTextAt(e.Graphics, -90f, str + " đ", x, y, font2, Brushes.Black);
            //                }
            //            }
            //            e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //            if (this.sl < int.Parse(this.txtsotem.Text))
            //            {
            //                num += (int)num5;
            //            }
            //            else
            //            {
            //                num4++;
            //                this.sl = 0;
            //                num = int.Parse(this.txtleft.Text);
            //                num2 = num4 * (int)num6 + int.Parse(this.txtletop.Text) + (int)num3;
            //            }
            //        }
            //    }
            //}
            //this.lanin = 1;
        }

        // Token: 0x06000181 RID: 385 RVA: 0x0003428C File Offset: 0x0003248C
        private void loadlai()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT 'True' as chon,MAHANGHOA,TENHANGHOA,",
            //    this.donvitinh_in,
            //    " AS DONVITINH,",
            //    this.dongia_in,
            //    " AS DONGIA,DONVITINHLON3 AS SL,' ' AS GHICHU,MANHOM FROM TB_HANGHOA WHERE QUYDOI='2'"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvHangHoa.DataSource = dataTable;
        }

        // Token: 0x06000182 RID: 386 RVA: 0x00034328 File Offset: 0x00032528
        private void luumavach()
        {
            //if (this.intu_phieunhap == 0)
            //{
            //    this.loadlai();
            //}
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //SqlConnection sqlConnection2 = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection2.Open();
            //SqlCommand sqlCommand = new SqlCommand("DELETE tb_mavach", sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //for (int i = 0; i < this.dgvHangHoa.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(this.dgvHangHoa.Rows[i].Cells["STT"].Value))
            //    {
            //        if (sqlConnection2.State == ConnectionState.Closed)
            //        {
            //            sqlConnection2.Open();
            //        }
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "INSERT INTO TB_MAVACH(MAHANG,TENHANGHOA,DVT,DONGIA,SL,GHICHU,MANHOM)VALUES(N'",
            //            this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString(),
            //            "',N'",
            //            this.dgvHangHoa.Rows[i].Cells["tenhang"].Value.ToString(),
            //            "',N'",
            //            this.dgvHangHoa.Rows[i].Cells["DVT"].Value.ToString(),
            //            "','",
            //            double.Parse(this.dgvHangHoa.Rows[i].Cells["dongia"].Value.ToString()),
            //            "','",
            //            this.dgvHangHoa.Rows[i].Cells["SLTEM"].Value.ToString(),
            //            "',N'",
            //            this.dgvHangHoa.Rows[i].Cells["manhom"].Value.ToString(),
            //            "')"
            //        });
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection2);
            //        sqlCommand2.ExecuteNonQuery();
            //        sqlConnection2.Close();
            //    }
            //}
            //SqlCommand sqlCommand3 = new SqlCommand("Select MAHANG,dbo.Unicode2TCVN(TENHANGHOA)as TENHANGHOA,DVT,DONGIA,SL from tb_mavach", sqlConnection2);
            //SqlDataReader sqlDataReader2 = sqlCommand3.ExecuteReader();
            //OleDbConnection oleDbConnection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =" + Application.StartupPath + "\\MAVACH\\MAVACH.mdb;Jet OLEDB:Database Password = 123456;User ID = admin");
            //oleDbConnection.Open();
            //OleDbCommand oleDbCommand = new OleDbCommand();
            //oleDbCommand.Connection = oleDbConnection;
            //oleDbCommand.CommandType = CommandType.Text;
            //oleDbCommand.CommandText = "DELETE From  INMAVACH";
            //oleDbCommand.ExecuteNonQuery();
            //while (sqlDataReader2.Read())
            //{
            //    oleDbCommand.CommandText = string.Concat(new string[]
            //    {
            //        "Insert into INMAVACH values('",
            //        Convert.ToString(sqlDataReader2.GetValue(0)),
            //        "','",
            //        Convert.ToString(sqlDataReader2.GetValue(1)),
            //        "','",
            //        Convert.ToString(sqlDataReader2.GetValue(2)),
            //        "','",
            //        double.Parse(Convert.ToString(sqlDataReader2.GetValue(3))).ToString("#,##0"),
            //        "','",
            //        Convert.ToString(sqlDataReader2.GetValue(4)),
            //        "')"
            //    });
            //    oleDbCommand.ExecuteNonQuery();
            //}
            //oleDbConnection.Close();
            //sqlConnection2.Close();
        }

        // Token: 0x06000183 RID: 387 RVA: 0x000346F4 File Offset: 0x000328F4
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.dong = 0;
            //    this.sl = 0;
            //    this.sotrang = 0;
            //    this.sotem = 0;
            //    this.numberOfItemsPerPage = 0;
            //    this.i = 0;
            //    this.sodong = 0;
            //    if (this.dgvHangHoa.RowCount > 0)
            //    {
            //        if (this.cbinpm.Checked)
            //        {
            //            this.button2_Click(null, null);
            //        }
            //        else
            //        {
            //            DataTable dataTable = new DataTable();
            //            string cmdText = "SELECT 'True'AS CHON, MAHANG AS MAHANGHOA, TENHANGHOA, DVT AS DONVITINH,DONGIA, SL, GHICHU,MANHOM FROM TB_MAVACH ORDER BY MAHANG,DONGIA";
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //            sqlDataAdapter.Fill(dataTable);
            //            this.dgvHangHoa.DataSource = dataTable;
            //            if (this.dgvHangHoa.RowCount > 0)
            //            {
            //                if (this.cobmauin.Text == "1")
            //                {
            //                    this.printDocument1.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                    if (this.cbxemin.Checked)
            //                    {
            //                        new PrintPreviewDialog
            //                        {
            //                            Document = this.printDocument1,
            //                            WindowState = FormWindowState.Maximized
            //                        }.ShowDialog();
            //                    }
            //                    else
            //                    {
            //                        this.printDocument1.Print();
            //                    }
            //                }
            //                else if (this.cobmauin.Text == "2")
            //                {
            //                    if (this.txtghichu.Text == "")
            //                    {
            //                        this.printDocument2.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                        if (this.cbxemin.Checked)
            //                        {
            //                            new PrintPreviewDialog
            //                            {
            //                                Document = this.printDocument2,
            //                                WindowState = FormWindowState.Maximized,
            //                                PrintPreviewControl =
            //                                {
            //                                    Zoom = 1.4
            //                                }
            //                            }.ShowDialog();
            //                        }
            //                        else
            //                        {
            //                            this.printDocument2.Print();
            //                        }
            //                    }
            //                    else
            //                    {
            //                        this.printDocument6.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                        if (this.cbxemin.Checked)
            //                        {
            //                            new PrintPreviewDialog
            //                            {
            //                                Document = this.printDocument6,
            //                                WindowState = FormWindowState.Maximized,
            //                                PrintPreviewControl =
            //                                {
            //                                    Zoom = 1.4
            //                                }
            //                            }.ShowDialog();
            //                        }
            //                        else
            //                        {
            //                            this.printDocument6.Print();
            //                        }
            //                    }
            //                }
            //                else if (this.cobmauin.Text == "3")
            //                {
            //                    this.printDocument3.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                    if (this.cbxemin.Checked)
            //                    {
            //                        new PrintPreviewDialog
            //                        {
            //                            Document = this.printDocument3,
            //                            WindowState = FormWindowState.Maximized
            //                        }.ShowDialog();
            //                    }
            //                    else
            //                    {
            //                        this.printDocument3.Print();
            //                    }
            //                }
            //                else if (this.cobmauin.Text == "4")
            //                {
            //                    if (this.cbxemin.Checked)
            //                    {
            //                        new PrintPreviewDialog
            //                        {
            //                            Document = this.printDocument4,
            //                            WindowState = FormWindowState.Maximized
            //                        }.ShowDialog();
            //                    }
            //                    else
            //                    {
            //                        this.printDocument4.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                        this.printDocument4.Print();
            //                    }
            //                }
            //                else if (this.cobmauin.Text == "5")
            //                {
            //                    if (this.cbxemin.Checked)
            //                    {
            //                        new PrintPreviewDialog
            //                        {
            //                            Document = this.printDocument5,
            //                            WindowState = FormWindowState.Maximized
            //                        }.ShowDialog();
            //                    }
            //                    else
            //                    {
            //                        this.printDocument5.PrinterSettings.PrinterName = this.txtmayin.Text;
            //                        this.printDocument5.Print();
            //                    }
            //                }
            //            }
            //            this.txtso.Text = "0";
            //            this.button3.BackColor = Color.Red;
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000184 RID: 388 RVA: 0x00034BA0 File Offset: 0x00032DA0
        private void FrmInmavach_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.dtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //    this.loadlemavach();
            //    base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //    DataTable dataTable = new DataTable();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE TB_MAVACH SELECT 'False' as chon,MAHANGHOA,TENHANGHOA,",
            //        this.donvitinh_in,
            //        " AS DONVITINH,",
            //        this.dongia_in,
            //        " AS DONGIA,'1' AS SL,' ' AS GHICHU,MANHOM FROM TB_HANGHOA ORDER BY TENHANGHOA,DONGIA"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvHangHoa.DataSource = dataTable;
            //    if (frmHangHoa.Ma_hanghoa != string.Empty)
            //    {
            //        this.txttimkiem.Text = frmHangHoa.Ma_hanghoa;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000185 RID: 389 RVA: 0x00034CF0 File Offset: 0x00032EF0
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
            this.txttimkiem.BackColor = Color.Yellow;
        }

        // Token: 0x06000186 RID: 390 RVA: 0x0001BB30 File Offset: 0x00019D30
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            this.txttimkiem.BackColor = Color.LemonChiffon;
            this.txttimkiem.Text = "";
        }

        // Token: 0x06000187 RID: 391 RVA: 0x00034D48 File Offset: 0x00032F48
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.intu_phieunhap = 0;
            //    if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            //    {
            //        if (this.txttimkiem.Text != "")
            //        {
            //            DataTable dataTable = new DataTable();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "SELECT CASE WHEN EXISTS (SELECT TB_MAVACH.MAHANG FROM TB_MAVACH WHERE MAHANG=TB_HANGHOA.MAHANGHOA) THEN 'True' else 'False' end as chon,MAHANGHOA,TB_HANGHOA.TENHANGHOA,",
            //                this.donvitinh_in,
            //                " AS DONVITINH,CASE WHEN EXISTS (SELECT TB_MAVACH.MAHANG FROM TB_MAVACH WHERE MAHANG=TB_HANGHOA.MAHANGHOA) THEN ISNULL(TB_MAVACH.DONGIA,'0') else ISNULL(TB_HANGHOA.",
            //                this.dongia_in,
            //                ",'0') end as DONGIA,ISNULL(TB_MAVACH.SL,1) AS SL,ISNULL(TB_MAVACH.GHICHU,' ') AS GHICHU,TB_HANGHOA.MANHOM  FROM TB_HANGHOA LEFT JOIN TB_MAVACH ON TB_MAVACH.MAHANG=TB_HANGHOA.MAHANGHOA WHERE TB_HANGHOA.MAHANGHOA LIKE N'%",
            //                this.txttimkiem.Text,
            //                "%' OR TB_HANGHOA.TENHANGHOA LIKE N'%",
            //                this.txttimkiem.Text,
            //                "%' OR TB_HANGHOA.TENHANGHOA_KHONGDAU LIKE N'%",
            //                this.txttimkiem.Text,
            //                "%'  OR TB_HANGHOA.KYTUDAU LIKE N'%",
            //                this.txttimkiem.Text,
            //                "%' ORDER BY CHON DESC,TB_HANGHOA.TENHANGHOA,TB_HANGHOA.DONGIA"
            //            });
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //            sqlDataAdapter.Fill(dataTable);
            //            this.dgvHangHoa.DataSource = dataTable;
            //        }
            //        else
            //        {
            //            DataTable dataTable = new DataTable();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "SELECT CASE WHEN EXISTS (SELECT TB_MAVACH.MAHANG FROM TB_MAVACH WHERE MAHANG=TB_HANGHOA.MAHANGHOA) THEN 'True' else 'False' end as chon,MAHANGHOA,TB_HANGHOA.TENHANGHOA,",
            //                this.donvitinh_in,
            //                " AS DONVITINH,CASE WHEN EXISTS (SELECT TB_MAVACH.MAHANG FROM TB_MAVACH WHERE MAHANG=TB_HANGHOA.MAHANGHOA) THEN ISNULL(TB_MAVACH.DONGIA,'0') else ISNULL(TB_HANGHOA.",
            //                this.dongia_in,
            //                ",'0') end AS DONGIA,ISNULL(TB_MAVACH.SL,1) AS SL,ISNULL(TB_MAVACH.GHICHU,' ') AS GHICHU,TB_HANGHOA.MANHOM  FROM TB_HANGHOA LEFT JOIN TB_MAVACH ON TB_MAVACH.MAHANG=TB_HANGHOA.MAHANGHOA ORDER BY CHON DESC,TB_HANGHOA.TENHANGHOA,TB_HANGHOA.DONGIA"
            //            });
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //            sqlDataAdapter.Fill(dataTable);
            //            this.dgvHangHoa.DataSource = dataTable;
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000188 RID: 392 RVA: 0x00034F5C File Offset: 0x0003315C
        private void btluu_Click(object sender, EventArgs e)
        {
            //string text = "False";
            //if (this.checkBox1.Checked)
            //{
            //    text = "True";
            //}
            //decimal num = decimal.Parse(this.txtw.Text);
            //CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //decimal num2 = decimal.Parse(this.txth.Text);
            //string text2 = "false";
            //if (this.cbinpm.Checked)
            //{
            //    text2 = "True";
            //}
            //string text3 = "False";
            //string text4 = "False";
            //string text5 = "False";
            //if (this.cbgia.Checked)
            //{
            //    text3 = "True";
            //}
            //if (this.cbinten.Checked)
            //{
            //    text4 = "True";
            //}
            //if (this.cbxemin.Checked)
            //{
            //    text5 = "True";
            //}
            //string text6 = "False";
            //if (this.cbingia.Checked)
            //{
            //    text6 = "True";
            //}
            //string cmdText = string.Concat(new string[]
            //{
            //    " UPDATE [DATASHOP].[dbo].[TB_LEMAVACH]SET [LETOP] = '",
            //    this.txtletop.Text,
            //    "',[LELEFT] = '",
            //    this.txtleft.Text,
            //    "',[CACHDONG] = '",
            //    this.txthd.Text,
            //    "',[SOTEM] = '",
            //    this.txtsotem.Text,
            //    "',[WIDTH] = '",
            //    num.ToString("", cultureInfo.NumberFormat),
            //    "',[HIEGHT] = '",
            //    num2.ToString("", cultureInfo.NumberFormat),
            //    "',[WIDTHMA] ='",
            //    this.txtwm.Text,
            //    "',[HEIGHTMA] ='",
            //    this.txthm.Text,
            //    "',[CUAHANG] =N'",
            //    this.txttieude.Text,
            //    "',[GHICHU] = N'",
            //    this.txtghichu.Text,
            //    "',[COCHUGIA] = '",
            //    this.txtgia.Text,
            //    "',[COCHUHANG] = '",
            //    this.txtcotenhang.Text,
            //    "',[COCHUTEN] = '",
            //    this.txtcoten.Text,
            //    "',[COCHUGHICHU] ='",
            //    this.txtcoghichu.Text,
            //    "',[LETEN] = '",
            //    this.txtleten.Text,
            //    "',[LEGHICHU] = '",
            //    this.txtleghichu.Text,
            //    "',[LEGIA] = '",
            //    this.txtlegia.Text,
            //    "',[LEHANG] = '",
            //    this.txtlehang.Text,
            //    "',[TOPMA] = '",
            //    this.txttopm.Text,
            //    "',LEFTMA='",
            //    this.txtleftma.Text,
            //    "',TENMAYIN='",
            //    this.txtmayin.Text,
            //    "',KIEUTEN='",
            //    this.cobten.Text,
            //    "',KIEUGIA='",
            //    this.cobgia.Text,
            //    "',KIEUTENHANG='",
            //    this.cobtenhang.Text,
            //    "',GIANGANG='",
            //    text3,
            //    "',INTEN='",
            //    text4,
            //    "',XEMIN='",
            //    text5,
            //    "',MAUIN='",
            //    this.cobmauin.Text,
            //    "',SODONG='",
            //    this.txtsodong.Text,
            //    "',ACCESS='",
            //    text2,
            //    "',INGIA='",
            //    text6,
            //    "',INMAHANG='",
            //    text,
            //    "'  ,SOKYTU='",
            //    this.txtso_kytu.Text.Trim(),
            //    "' WHERE MAUIN ='",
            //    this.cobmauin.Text,
            //    "'"
            //});
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
        }

        // Token: 0x06000189 RID: 393 RVA: 0x000353F8 File Offset: 0x000335F8
        private void loadlemavach()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "SELECT * FROM TB_LEMAVACH";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.txtletop.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //    this.txtleft.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.txthd.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //    this.txtsotem.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //    this.txtw.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //    this.txth.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //    this.txtwm.Text = Convert.ToString(sqlDataReader.GetValue(6));
            //    this.txthm.Text = Convert.ToString(sqlDataReader.GetValue(7));
            //    this.txttieude.Text = Convert.ToString(sqlDataReader.GetValue(8));
            //    this.txtghichu.Text = Convert.ToString(sqlDataReader.GetValue(9));
            //    this.txtgia.Text = Convert.ToString(sqlDataReader.GetValue(10));
            //    this.txtcotenhang.Text = Convert.ToString(sqlDataReader.GetValue(11));
            //    this.txtcoten.Text = Convert.ToString(sqlDataReader.GetValue(12));
            //    this.txtcoghichu.Text = Convert.ToString(sqlDataReader.GetValue(13));
            //    this.txtleten.Text = Convert.ToString(sqlDataReader.GetValue(14));
            //    this.txtleghichu.Text = Convert.ToString(sqlDataReader.GetValue(15));
            //    this.txtlegia.Text = Convert.ToString(sqlDataReader.GetValue(16));
            //    this.txtlehang.Text = Convert.ToString(sqlDataReader.GetValue(17));
            //    this.txttopm.Text = Convert.ToString(sqlDataReader.GetValue(18));
            //    this.txtleftma.Text = Convert.ToString(sqlDataReader.GetValue(19));
            //    this.txtmayin.Text = Convert.ToString(sqlDataReader.GetValue(20));
            //    this.cobten.Text = sqlDataReader.GetString(21);
            //    this.cobgia.Text = sqlDataReader.GetString(22);
            //    this.cobtenhang.Text = sqlDataReader.GetString(23);
            //    string a = Convert.ToString(sqlDataReader.GetValue(24));
            //    if (a == "True")
            //    {
            //        this.cbgia.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbgia.Checked = false;
            //    }
            //    string a2 = Convert.ToString(sqlDataReader.GetValue(25));
            //    if (a2 == "True")
            //    {
            //        this.cbinten.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbinten.Checked = false;
            //    }
            //    string a3 = Convert.ToString(sqlDataReader.GetValue(26));
            //    if (a3 == "True")
            //    {
            //        this.cbxemin.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbxemin.Checked = false;
            //    }
            //    this.cobmauin.Text = Convert.ToString(sqlDataReader.GetValue(27));
            //    this.txtsodong.Text = Convert.ToString(sqlDataReader.GetValue(28));
            //    if (Convert.ToString(sqlDataReader.GetValue(29)) == "True")
            //    {
            //        this.cbinpm.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbinpm.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(30)) == "True")
            //    {
            //        this.cbingia.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbingia.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(31)) == "True")
            //    {
            //        this.checkBox1.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox1.Checked = false;
            //    }
            //    if (this.txtsodong.Text == "1")
            //    {
            //        this.checkBox2.Checked = true;
            //    }
            //    this.txtso_kytu.Text = Convert.ToString(sqlDataReader.GetValue(32));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x0600018A RID: 394 RVA: 0x00035888 File Offset: 0x00033A88
        private void printDocument2_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
            //int num = int.Parse(this.txtleft.Text);
            //int num2 = int.Parse(this.txtletop.Text);
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //string str = "";
            //if (this.checkBox2.Checked)
            //{
            //    str = " Vnđ/" + this.dgvHangHoa.Rows[this.i].Cells["DVT"].Value.ToString();
            //}
            //double num3 = double.Parse(this.txtw.Text) * 37.7953;
            //double num4 = double.Parse(this.txth.Text) * 37.7953;
            //if (this.sl < int.Parse(this.txtsotem.Text))
            //{
            //    int num5 = 0;
            //    this.i = this.sodong;
            //    while (this.i < this.dgvHangHoa.RowCount)
            //    {
            //        if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
            //        {
            //            if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
            //            {
            //                for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
            //                {
            //                    this.sotem++;
            //                    if (this.sotem > int.Parse(this.txtsotem.Text))
            //                    {
            //                        this.sodong = this.i;
            //                        this.sotem = 0;
            //                        num = int.Parse(this.txtleft.Text);
            //                        e.HasMorePages = true;
            //                        return;
            //                    }
            //                    e.Graphics.DrawString(this.txttieude.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleten.Text), num2));
            //                    Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //                    Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //                    if (this.checkBox1.Checked)
            //                    {
            //                        e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString(), new Font("Arial", (float)(int.Parse(this.txtcotenhang.Text) - 1), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + 13), stringFormat);
            //                    }
            //                    if (this.cbinten.Checked)
            //                    {
            //                        if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > int.Parse(this.txtso_kytu.Text))
            //                        {
            //                            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                            {
            //                                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 6) * 2));
            //                                e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                            }
            //                            num5 = 10;
            //                        }
            //                        else
            //                        {
            //                            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                            {
            //                                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 6));
            //                                e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                            }
            //                            num5 = 0;
            //                        }
            //                    }
            //                    if (!this.cbingia.Checked)
            //                    {
            //                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                        using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                        {
            //                            int x = num + int.Parse(this.txtleghichu.Text);
            //                            int y = (num2 + int.Parse(this.txthd.Text) + image.Height + 5) / 2 + this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim().Length * 3;
            //                            this.DrawRotatedTextAt(e.Graphics, -90f, this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), x, y, font2, Brushes.Black);
            //                        }
            //                    }
            //                    if (this.cbingia.Checked)
            //                    {
            //                        string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###") + str;
            //                        if (this.cbgia.Checked)
            //                        {
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtleghichu.Text);
            //                                int y = (num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5) / 2 + this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim().Length * 3;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), x, y, font2, Brushes.Black);
            //                            }
            //                            if (this.cbinten.Checked)
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
            //                                if (!this.checkBox2.Checked)
            //                                {
            //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
            //                                }
            //                            }
            //                            else
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
            //                                if (!this.checkBox2.Checked)
            //                                {
            //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
            //                                }
            //                            }
            //                        }
            //                        else
            //                        {
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                                if (!this.checkBox2.Checked)
            //                                {
            //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
            //                                }
            //                                else
            //                                {
            //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text, x, y, font2, Brushes.Black);
            //                                }
            //                            }
            //                        }
            //                    }
            //                    e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //                    num += (int)num3;
            //                    if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
            //                    {
            //                        this.sl++;
            //                    }
            //                    else
            //                    {
            //                        this.sl = 0;
            //                    }
            //                }
            //            }
            //            this.sl = 0;
            //        }
            //        this.i++;
            //    }
            //    this.lanin = 1;
            //}
            //else
            //{
            //    this.i = this.sodong;
            //    while (this.i < this.dgvHangHoa.RowCount)
            //    {
            //        int num5 = 0;
            //        if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
            //        {
            //            if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
            //            {
            //                for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
            //                {
            //                    this.sotem++;
            //                    if (this.sotem > int.Parse(this.txtsotem.Text))
            //                    {
            //                        this.sodong = this.i;
            //                        this.sotem = 0;
            //                        num = int.Parse(this.txtleft.Text);
            //                        e.HasMorePages = true;
            //                        return;
            //                    }
            //                    e.Graphics.DrawString(this.txttieude.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleten.Text), num2));
            //                    Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //                    Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //                    if (this.checkBox1.Checked)
            //                    {
            //                        e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString(), new Font("Arial", (float)(int.Parse(this.txtcotenhang.Text) - 1), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + 13), stringFormat);
            //                    }
            //                    if (this.cbinten.Checked)
            //                    {
            //                        if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > int.Parse(this.txtso_kytu.Text))
            //                        {
            //                            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                            {
            //                                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 4) * 2));
            //                                e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                            }
            //                            num5 = 10;
            //                        }
            //                        else
            //                        {
            //                            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                            {
            //                                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 4));
            //                                e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                            }
            //                            num5 = 0;
            //                        }
            //                    }
            //                    if (!this.cbingia.Checked)
            //                    {
            //                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                        using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                        {
            //                            int x = num + int.Parse(this.txtleghichu.Text);
            //                            int y = (num2 + int.Parse(this.txthd.Text) + image.Height + 5) / 2 + this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim().Length * 3;
            //                            this.DrawRotatedTextAt(e.Graphics, -90f, this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), x, y, font2, Brushes.Black);
            //                        }
            //                    }
            //                    if (this.cbingia.Checked)
            //                    {
            //                        string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###") + str;
            //                        if (this.cbgia.Checked)
            //                        {
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtleghichu.Text);
            //                                int y = (num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5) / 2 + this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim().Length * 3;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), x, y, font2, Brushes.Black);
            //                            }
            //                            if (this.cbinten.Checked)
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
            //                                if (this.checkBox2.Checked)
            //                                {
            //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
            //                                }
            //                            }
            //                            else
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
            //                                if (this.checkBox2.Checked)
            //                                {
            //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
            //                                }
            //                            }
            //                        }
            //                        else
            //                        {
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["GHICHU"].Value.ToString().Trim(), new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                                if (!this.checkBox2.Checked)
            //                                {
            //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
            //                                }
            //                                else
            //                                {
            //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text, x, y, font2, Brushes.Black);
            //                                }
            //                            }
            //                        }
            //                    }
            //                    e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //                    num += (int)num3;
            //                    if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
            //                    {
            //                        this.sl++;
            //                    }
            //                    else
            //                    {
            //                        this.sl = 0;
            //                    }
            //                }
            //                this.sl = 0;
            //            }
            //        }
            //        this.i++;
            //    }
            //}
        }

        // Token: 0x0600018B RID: 395 RVA: 0x00037348 File Offset: 0x00035548
        private void dtngay_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT MAHOADON FROM TB_HANGHOANHAP WHERE NGAYNHAP='" + this.dtngay.Text + "' GROUP BY MAHOADON ORDER BY MAHOADON DESC";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.cobma.DataSource = null;
            //    this.cobma.DataSource = dataTable;
            //    this.cobma.DisplayMember = "MAHOADON";
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600018C RID: 396 RVA: 0x000373F8 File Offset: 0x000355F8
        private void cobma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.intu_phieunhap = 1;
            //if (this.cobma.Text != "")
            //{
            //    try
            //    {
            //        DataTable dataTable = new DataTable();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE TB_MAVACH SELECT 'True' as chon,HH.MAHANGHOA,HH.TENHANGHOA,HH.DONVITINH,HH.DONGIA,CAST(HN.SOLUONG/HH.QUYDOI1 AS INT) AS SL,' ' AS GHICHU,MANHOM FROM TB_HANGHOA HH, TB_HANGHOANHAP HN WHERE HN.MAHOADON='",
            //            this.cobma.Text,
            //            "' AND HH.MAHANGHOA=HN.MAHANGHOA and NGAYNHAP='",
            //            this.dtngay.Text,
            //            "' ORDER BY HH.MAHANGHOA"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvHangHoa.DataSource = dataTable;
            //        if (this.dgvHangHoa.RowCount > 0)
            //        {
            //            for (int i = 0; i < this.dgvHangHoa.RowCount; i++)
            //            {
            //                this.dgvHangHoa.Rows[i].Cells["STT"].Value = true;
            //                if (sqlConnection.State == ConnectionState.Closed)
            //                {
            //                    sqlConnection.Open();
            //                }
            //                string cmdText2 = string.Concat(new object[]
            //                {
            //                    "DELETE TB_MAVACH WHERE MAHANG ='",
            //                    this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString(),
            //                    "' INSERT INTO TB_MAVACH(MAHANG,TENHANGHOA,DVT,DONGIA,SL,GHICHU,MANHOM)VALUES(N'",
            //                    this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString(),
            //                    "',N'",
            //                    this.dgvHangHoa.Rows[i].Cells["tenhang"].Value.ToString(),
            //                    "',N'",
            //                    this.dgvHangHoa.Rows[i].Cells["dvt"].Value.ToString(),
            //                    "','",
            //                    double.Parse(this.dgvHangHoa.Rows[i].Cells["dongia"].Value.ToString()),
            //                    "','",
            //                    this.dgvHangHoa.Rows[i].Cells["SLTEM"].Value.ToString(),
            //                    "','",
            //                    this.dgvHangHoa.Rows[i].Cells["GHICHU"].Value.ToString(),
            //                    "',N'",
            //                    this.dgvHangHoa.Rows[i].Cells["manhom"].Value.ToString(),
            //                    "')"
            //                });
            //                SqlCommand sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x0600018D RID: 397 RVA: 0x0001B637 File Offset: 0x00019837
        //private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //}

        // Token: 0x0600018E RID: 398 RVA: 0x00037780 File Offset: 0x00035980
        private void dgvHangHoa_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvHangHoa.RowCount > 0)
            //{
            //    int index = this.dgvHangHoa.CurrentRow.Index;
            //    int columnIndex = this.dgvHangHoa.CurrentCell.ColumnIndex;
            //    if (this.dgvHangHoa.Columns[columnIndex].Name == "SLTEM")
            //    {
            //        DataGridViewCell currentCell = this.dgvHangHoa.CurrentCell;
            //        string text = this.dgvHangHoa.CurrentCell.Value.ToString();
            //        for (int i = 0; i < text.Length; i++)
            //        {
            //            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //            char c = Convert.ToChar(currencyDecimalSeparator);
            //            if (!char.IsDigit(text[i]) && !char.IsControl(text[i]))
            //            {
            //                if (text[i] != Convert.ToChar(currencyDecimalSeparator))
            //                {
            //                    MessageBox.Show("Chỉ được nhập số, và phải != 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                    this.dgvHangHoa.CurrentCell.Value = 1;
            //                    break;
            //                }
            //            }
            //        }
            //        if (int.Parse(this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value.ToString()) > 1)
            //        {
            //            this.dgvHangHoa.Rows[index].Cells["STT"].Value = true;
            //            this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value = Frmbangso.soluong;
            //            this.dgvHangHoa.Rows[index].Cells["STT"].Value = true;
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "DELETE TB_MAVACH WHERE MAHANG ='",
            //                this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
            //                "' INSERT INTO TB_MAVACH(MAHANG,TENHANGHOA,DVT,DONGIA,SL,GHICHU,MANHOM)VALUES(N'",
            //                this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
            //                "',N'",
            //                this.dgvHangHoa.Rows[index].Cells["tenhang"].Value.ToString(),
            //                "',N'",
            //                this.dgvHangHoa.Rows[index].Cells["dvt"].Value.ToString(),
            //                "','",
            //                double.Parse(this.dgvHangHoa.Rows[index].Cells["dongia"].Value.ToString()),
            //                "','",
            //                this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value.ToString(),
            //                "','",
            //                this.dgvHangHoa.Rows[index].Cells["GHICHU"].Value.ToString(),
            //                "',N'",
            //                this.dgvHangHoa.Rows[index].Cells["manhom"].Value.ToString(),
            //                "')"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //        }
            //    }
            //}
        }

        // Token: 0x0600018F RID: 399 RVA: 0x00037BB8 File Offset: 0x00035DB8
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHangHoa.RowCount > 0)
            {
                int index = this.dgvHangHoa.CurrentRow.Index;
                int columnIndex = this.dgvHangHoa.CurrentCell.ColumnIndex;
                if (this.dgvHangHoa.Columns[columnIndex].Name == "STT" || this.dgvHangHoa.Columns[columnIndex].Name == "SLTEM" || this.dgvHangHoa.Columns[columnIndex].Name == "GHICHU")
                {
                    this.dgvHangHoa.ReadOnly = false;
                }
                else
                {
                    this.dgvHangHoa.ReadOnly = true;
                }
            }
        }

        // Token: 0x06000190 RID: 400 RVA: 0x00037C90 File Offset: 0x00035E90
        private void dgvHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //if (this.dgvHangHoa.RowCount > 0)
                //{
                //    int index = this.dgvHangHoa.CurrentRow.Index;
                //    int columnIndex = this.dgvHangHoa.CurrentCell.ColumnIndex;
                //    if (this.dgvHangHoa.Columns[columnIndex].Name == "STT")
                //    {
                //        if (this.dgvHangHoa.Rows[index].Cells["STT"].Value != null)
                //        {
                //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                //            sqlConnection.Open();
                //            if (Convert.ToBoolean(this.dgvHangHoa.Rows[index].Cells["STT"].Value.ToString()))
                //            {
                //                this.dgvHangHoa.Rows[index].Cells["STT"].Value = false;
                //                string cmdText = "DELETE TB_MAVACH WHERE MAHANG ='" + this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString() + "'";
                //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //                sqlCommand.ExecuteNonQuery();
                //                sqlConnection.Close();
                //            }
                //            else
                //            {
                //                this.dgvHangHoa.Rows[index].Cells["STT"].Value = true;
                //                string cmdText2 = string.Concat(new object[]
                //                {
                //                    "DELETE TB_MAVACH WHERE MAHANG ='",
                //                    this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
                //                    "' INSERT INTO TB_MAVACH(MAHANG,TENHANGHOA,DVT,DONGIA,SL,GHICHU,MANHOM)VALUES(N'",
                //                    this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
                //                    "',N'",
                //                    this.dgvHangHoa.Rows[index].Cells["tenhang"].Value.ToString(),
                //                    "',N'",
                //                    this.dgvHangHoa.Rows[index].Cells["dvt"].Value.ToString(),
                //                    "','",
                //                    double.Parse(this.dgvHangHoa.Rows[index].Cells["dongia"].Value.ToString()),
                //                    "','",
                //                    this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value.ToString(),
                //                    "','",
                //                    this.dgvHangHoa.Rows[index].Cells["GHICHU"].Value.ToString(),
                //                    "',N'",
                //                    this.dgvHangHoa.Rows[index].Cells["manhom"].Value.ToString(),
                //                    "')"
                //                });
                //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
                //                sqlCommand2.ExecuteNonQuery();
                //                sqlConnection.Close();
                //            }
                //        }
                //    }
                //    else if (this.dgvHangHoa.Columns[columnIndex].Name == "SLTEM")
                //    {
                //        Frmbangso frmbangso = new Frmbangso();
                //        frmbangso.ShowDialog();
                //        if (Frmbangso.ok == "ok")
                //        {
                //            this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value = Frmbangso.soluong;
                //            this.dgvHangHoa.Rows[index].Cells["STT"].Value = true;
                //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                //            sqlConnection.Open();
                //            string cmdText2 = string.Concat(new object[]
                //            {
                //                "DELETE TB_MAVACH WHERE MAHANG ='",
                //                this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
                //                "' INSERT INTO TB_MAVACH(MAHANG,TENHANGHOA,DVT,DONGIA,SL,GHICHU,MANHOM)VALUES(N'",
                //                this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString(),
                //                "',N'",
                //                this.dgvHangHoa.Rows[index].Cells["tenhang"].Value.ToString(),
                //                "',N'",
                //                this.dgvHangHoa.Rows[index].Cells["dvt"].Value.ToString(),
                //                "','",
                //                double.Parse(this.dgvHangHoa.Rows[index].Cells["dongia"].Value.ToString()),
                //                "','",
                //                this.dgvHangHoa.Rows[index].Cells["SLTEM"].Value.ToString(),
                //                "','",
                //                this.dgvHangHoa.Rows[index].Cells["GHICHU"].Value.ToString(),
                //                "',N'",
                //                this.dgvHangHoa.Rows[index].Cells["manhom"].Value.ToString(),
                //                "')"
                //            });
                //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
                //            sqlCommand2.ExecuteNonQuery();
                //            sqlConnection.Close();
                //        }
                //    }
                //    else if (this.dgvHangHoa.Columns[columnIndex].Name == "X")
                //    {
                //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                //        sqlConnection.Open();
                //        this.dgvHangHoa.Rows[index].Cells["STT"].Value = false;
                //        string cmdText = "DELETE TB_MAVACH WHERE MAHANG ='" + this.dgvHangHoa.Rows[index].Cells["mahanghoa"].Value.ToString() + "'";
                //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //        sqlCommand.ExecuteNonQuery();
                //        sqlConnection.Close();
                //    }
                //}
            }
            catch
            {
            }
        }

        // Token: 0x06000191 RID: 401 RVA: 0x00038408 File Offset: 0x00036608
        private void printDocument3_PrintPage_1(object sender/*, PrintPageEventArgs e*/)
        {
            //int num = int.Parse(this.txtleft.Text);
            //int num2 = int.Parse(this.txtletop.Text);
            //double num3 = double.Parse(this.txtso.Text) * double.Parse(this.txth.Text) * 37.7953;
            //num2 += (int)num3;
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //double num4 = double.Parse(this.txtw.Text) * 37.7953;
            //double num5 = double.Parse(this.txth.Text) * 37.7953;
            //for (int i = this.sotrang; i < this.dgvHangHoa.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(this.dgvHangHoa.Rows[i].Cells["STT"].Value))
            //    {
            //        for (int j = this.sotem; j < int.Parse(this.dgvHangHoa.Rows[i].Cells["SLTEM"].Value.ToString()); j++)
            //        {
            //            this.sl++;
            //            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular, GraphicsUnit.Point))
            //            {
            //                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num4 - (float)int.Parse(this.txtlehang.Text) - (float)int.Parse(this.txtleft.Text), (float)(int.Parse(this.txtcotenhang.Text) + 5));
            //                e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, layoutRectangle);
            //            }
            //            using (Font font2 = new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Regular))
            //            {
            //                int x = num + int.Parse(this.txtleten.Text);
            //                int y = num2 + (int)num5 - 15;
            //                this.DrawRotatedTextAt(e.Graphics, -90f, this.txttieude.Text, x, y, font2, Brushes.Black);
            //            }
            //            Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //            Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //            e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString(), new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + int.Parse(this.txthd.Text)), stringFormat);
            //            int num6 = num2 + image.Height + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text);
            //            e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["MANHOM"].Value.ToString(), new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num6));
            //            e.Graphics.DrawString("Đ", new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + (int)num4 - int.Parse(this.txtlegia.Text), num6), stringFormat2);
            //            e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num6 + int.Parse(this.txthd.Text)));
            //            e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //            string text = Convert.ToDouble(this.dgvHangHoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,###");
            //            if (this.cbgia.Checked)
            //            {
            //                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + (int)num4 - int.Parse(this.txtlegia.Text), num6 + int.Parse(this.txthd.Text)), stringFormat2);
            //            }
            //            else
            //            {
            //                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                {
            //                    int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                    int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " đ", x, y, font2, Brushes.Black);
            //                }
            //            }
            //            if (this.sl < int.Parse(this.txtsotem.Text))
            //            {
            //                num += (int)num4;
            //            }
            //            else
            //            {
            //                this.dong++;
            //                this.sl = 0;
            //                num = int.Parse(this.txtleft.Text);
            //                num2 = this.dong * (int)num5 + int.Parse(this.txtletop.Text) + (int)num3;
            //                if (this.dong == int.Parse(this.txtsodong.Text))
            //                {
            //                    this.sotrang = i;
            //                    this.sotem = j + 1;
            //                    this.dong = 0;
            //                    e.HasMorePages = true;
            //                    return;
            //                }
            //            }
            //        }
            //        this.sotem = 0;
            //    }
            //}
            //this.lanin = 1;
        }

        // Token: 0x06000192 RID: 402 RVA: 0x00038C28 File Offset: 0x00036E28
        private void button2_Click(object sender, EventArgs e)
        {
            //this.luumavach();
            //new Process
            //{
            //    StartInfo =
            //    {
            //        FileName = Application.StartupPath + "\\MAVACH\\hiL.exe"
            //    }
            //}.Start();
        }

        // Token: 0x06000193 RID: 403 RVA: 0x0001B637 File Offset: 0x00019837
        private void cobten_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000194 RID: 404 RVA: 0x0001B637 File Offset: 0x00019837
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000195 RID: 405 RVA: 0x0001B637 File Offset: 0x00019837
        private void cobmauin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000196 RID: 406 RVA: 0x00038C68 File Offset: 0x00036E68
        private void printDocument4_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
            //int num = int.Parse(this.txtleft.Text);
            //int num2 = int.Parse(this.txtletop.Text);
            //double num3 = double.Parse(this.txtso.Text) * double.Parse(this.txth.Text) * 37.7953;
            //num2 += (int)num3;
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //double num4 = double.Parse(this.txtw.Text) * 37.7953;
            //double num5 = double.Parse(this.txth.Text) * 37.7953;
            //for (int i = this.sotrang; i < this.dgvHangHoa.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(this.dgvHangHoa.Rows[i].Cells["STT"].Value))
            //    {
            //        for (int j = this.sotem; j < int.Parse(this.dgvHangHoa.Rows[i].Cells["SLTEM"].Value.ToString()); j++)
            //        {
            //            string chaine = this.dgvHangHoa.Rows[i].Cells["mahanghoa"].Value.ToString().Trim().PadRight(12, '0');
            //            string s = EAN13Class.EAN13(chaine);
            //            this.sl++;
            //            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //            using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular, GraphicsUnit.Point))
            //            {
            //                RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num4 - (float)int.Parse(this.txtlehang.Text) - (float)int.Parse(this.txtleft.Text), (float)(int.Parse(this.txtcotenhang.Text) + 5));
            //                e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, layoutRectangle);
            //            }
            //            using (Font font2 = new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Regular))
            //            {
            //                int x = num + int.Parse(this.txtleten.Text);
            //                int y = num2 + (int)num5 - 15;
            //                this.DrawRotatedTextAt(e.Graphics, -90f, this.txttieude.Text, x, y, font2, Brushes.Black);
            //            }
            //            e.Graphics.DrawString(s, new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + 25 + int.Parse(this.txthd.Text)), stringFormat);
            //            int num6 = num2 + 25 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text);
            //            e.Graphics.DrawString(this.dgvHangHoa.Rows[i].Cells["MANHOM"].Value.ToString(), new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num6));
            //            e.Graphics.DrawString("Đ", new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + (int)num4 - int.Parse(this.txtlegia.Text), num6), stringFormat2);
            //            e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num6 + int.Parse(this.txthd.Text)));
            //            string text = Convert.ToDouble(this.dgvHangHoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,###");
            //            if (this.cbgia.Checked)
            //            {
            //                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + (int)num4 - int.Parse(this.txtlegia.Text), num6 + int.Parse(this.txthd.Text)), stringFormat2);
            //            }
            //            else
            //            {
            //                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                {
            //                    int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                    int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " đ", x, y, font2, Brushes.Black);
            //                }
            //            }
            //            if (this.sl < int.Parse(this.txtsotem.Text))
            //            {
            //                num += (int)num4;
            //            }
            //            else
            //            {
            //                this.dong++;
            //                this.sl = 0;
            //                num = int.Parse(this.txtleft.Text);
            //                num2 = this.dong * (int)num5 + int.Parse(this.txtletop.Text) + (int)num3;
            //                if (this.dong == int.Parse(this.txtsodong.Text))
            //                {
            //                    this.sotrang = i;
            //                    this.sotem = j + 1;
            //                    this.dong = 0;
            //                    e.HasMorePages = true;
            //                    return;
            //                }
            //            }
            //        }
            //        this.sotem = 0;
            //    }
            //}
            //this.lanin = 1;
        }

        // Token: 0x06000197 RID: 407 RVA: 0x0001B637 File Offset: 0x00019837
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000198 RID: 408 RVA: 0x0001B637 File Offset: 0x00019837
        private void FrmInmavach_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        // Token: 0x06000199 RID: 409 RVA: 0x000393E8 File Offset: 0x000375E8
        private void button3_Click(object sender, EventArgs e)
        {
            //this.intu_phieunhap = 0;
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_MAVACH SELECT 'False' as chon,MAHANGHOA,TENHANGHOA,",
            //    this.donvitinh_in,
            //    " AS DONVITINH,",
            //    this.dongia_in,
            //    " AS DONGIA,'1' AS SL,' ' AS GHICHU,MANHOM FROM TB_HANGHOA ORDER BY TENHANGHOA,DONGIA"
            //});
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvHangHoa.DataSource = dataTable;
            //this.button3.BackColor = Color.Blue;
            //this.txttimkiem.Focus();
        }

        // Token: 0x0600019A RID: 410 RVA: 0x0001B637 File Offset: 0x00019837
        private void cbinpm_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x0600019B RID: 411 RVA: 0x000394BC File Offset: 0x000376BC
        private void button4_Click(object sender, EventArgs e)
        {
            //frmHangHoa frmHangHoa = new frmHangHoa();
            //frmHangHoa.ShowDialog();
        }

        // Token: 0x0600019C RID: 412 RVA: 0x0001B637 File Offset: 0x00019837
        private void cbingia_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x0600019D RID: 413 RVA: 0x000394D8 File Offset: 0x000376D8
        private void printDocument5_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
            //int num = int.Parse(this.txtleft.Text);
            //int num2 = int.Parse(this.txtletop.Text);
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //StringFormat stringFormat2 = new StringFormat();
            //stringFormat2.Alignment = StringAlignment.Far;
            //double num3 = double.Parse(this.txtw.Text) * 37.7953;
            //double num4 = double.Parse(this.txth.Text) * 37.7953;
            //if (this.sl < int.Parse(this.txtsotem.Text))
            //{
            //    int num5 = 0;
            //    this.i = this.sodong;
            //    while (this.i < this.dgvHangHoa.RowCount)
            //    {
            //        if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
            //        {
            //            if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
            //            {
            //                for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
            //                {
            //                    this.sotem++;
            //                    if (this.sotem > int.Parse(this.txtsotem.Text))
            //                    {
            //                        this.sodong = this.i;
            //                        this.sotem = 0;
            //                        num = int.Parse(this.txtleft.Text);
            //                        e.HasMorePages = true;
            //                        return;
            //                    }
            //                    if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > 25)
            //                    {
            //                        using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                        {
            //                            RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 4) * 2));
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                        }
            //                        num5 = 0;
            //                    }
            //                    else
            //                    {
            //                        using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                        {
            //                            RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 4));
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                        }
            //                        num5 = 0;
            //                    }
            //                    Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //                    Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //                    if (this.cbinten.Checked)
            //                    {
            //                        num5 -= 10;
            //                    }
            //                    if (!this.cbingia.Checked)
            //                    {
            //                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                        using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                        {
            //                            int x = num + int.Parse(this.txtleghichu.Text);
            //                            int y = num2 + int.Parse(this.txthd.Text) + image.Height + 5;
            //                            this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text, x, y, font2, Brushes.Black);
            //                        }
            //                    }
            //                    if (this.cbingia.Checked)
            //                    {
            //                        string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###");
            //                        if (this.cbgia.Checked)
            //                        {
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtleghichu.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text, x, y, font2, Brushes.Black);
            //                            }
            //                            if (this.cbinten.Checked)
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
            //                                e.Graphics.DrawString(" VNĐ", new Font("Arial Narrow", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
            //                            }
            //                            else
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
            //                                e.Graphics.DrawString(" VNĐ", new Font("Arial Narrow", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
            //                            }
            //                        }
            //                        else
            //                        {
            //                            e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
            //                            }
            //                        }
            //                    }
            //                    e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //                    num += (int)num3;
            //                    if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
            //                    {
            //                        this.sl++;
            //                    }
            //                    else
            //                    {
            //                        this.sl = 0;
            //                    }
            //                }
            //            }
            //            this.sl = 0;
            //        }
            //        this.i++;
            //    }
            //}
            //else
            //{
            //    this.i = this.sodong;
            //    while (this.i < this.dgvHangHoa.RowCount)
            //    {
            //        int num5 = 0;
            //        if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
            //        {
            //            if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
            //            {
            //                for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
            //                {
            //                    this.sotem++;
            //                    if (this.sotem > int.Parse(this.txtsotem.Text))
            //                    {
            //                        this.sodong = this.i;
            //                        this.sotem = 0;
            //                        num = int.Parse(this.txtleft.Text);
            //                        e.HasMorePages = true;
            //                        return;
            //                    }
            //                    if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > 25)
            //                    {
            //                        using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                        {
            //                            RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 4) * 2));
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                        }
            //                        num5 = 0;
            //                    }
            //                    else
            //                    {
            //                        using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
            //                        {
            //                            RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)num2, (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 4));
            //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
            //                        }
            //                        num5 = 0;
            //                    }
            //                    Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //                    Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
            //                    if (this.cbinten.Checked)
            //                    {
            //                        num5 -= 10;
            //                    }
            //                    if (!this.cbingia.Checked)
            //                    {
            //                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                        using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                        {
            //                            int x = num + int.Parse(this.txtleghichu.Text);
            //                            int y = num2 + int.Parse(this.txthd.Text) + image.Height + 5;
            //                            this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text, x, y, font2, Brushes.Black);
            //                        }
            //                    }
            //                    if (this.cbingia.Checked)
            //                    {
            //                        string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###");
            //                        if (this.cbgia.Checked)
            //                        {
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtleghichu.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text, x, y, font2, Brushes.Black);
            //                            }
            //                            if (this.cbinten.Checked)
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
            //                                e.Graphics.DrawString(" VNĐ", new Font("Arial Narrow", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
            //                            }
            //                            else
            //                            {
            //                                e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
            //                                e.Graphics.DrawString(" VNĐ", new Font("Arial Narrow", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
            //                            }
            //                        }
            //                        else
            //                        {
            //                            e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
            //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
            //                            {
            //                                int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
            //                                int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
            //                                this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
            //                            }
            //                        }
            //                    }
            //                    e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
            //                    num += (int)num3;
            //                    if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
            //                    {
            //                        this.sl++;
            //                    }
            //                    else
            //                    {
            //                        this.sl = 0;
            //                    }
            //                }
            //                this.sl = 0;
            //            }
            //        }
            //        this.i++;
            //    }
            //}
        }

        // Token: 0x0600019E RID: 414 RVA: 0x0003A9E8 File Offset: 0x00038BE8
        private void printDocument6_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
        //    int num = int.Parse(this.txtleft.Text);
        //    int num2 = int.Parse(this.txtletop.Text);
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    double num3 = double.Parse(this.txtw.Text) * 37.7953;
        //    double num4 = double.Parse(this.txth.Text) * 37.7953;
        //    if (this.sl < int.Parse(this.txtsotem.Text))
        //    {
        //        int num5 = 0;
        //        this.i = this.sodong;
        //        while (this.i < this.dgvHangHoa.RowCount)
        //        {
        //            if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
        //            {
        //                if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
        //                {
        //                    for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
        //                    {
        //                        this.sotem++;
        //                        if (this.sotem > int.Parse(this.txtsotem.Text))
        //                        {
        //                            this.sodong = this.i;
        //                            this.sotem = 0;
        //                            num = int.Parse(this.txtleft.Text);
        //                            e.HasMorePages = true;
        //                            return;
        //                        }
        //                        e.Graphics.DrawString(this.txttieude.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleten.Text), num2));
        //                        Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
        //                        Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
        //                        if (this.checkBox1.Checked)
        //                        {
        //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString(), new Font("Arial", (float)(int.Parse(this.txtcotenhang.Text) - 1), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + 13), stringFormat);
        //                        }
        //                        if (this.cbinten.Checked)
        //                        {
        //                            if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > int.Parse(this.txtso_kytu.Text))
        //                            {
        //                                using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
        //                                {
        //                                    RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 6) * 2));
        //                                    e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
        //                                }
        //                                num5 = 10;
        //                            }
        //                            else
        //                            {
        //                                using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
        //                                {
        //                                    RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 6));
        //                                    e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
        //                                }
        //                                num5 = 0;
        //                            }
        //                        }
        //                        if (!this.cbingia.Checked)
        //                        {
        //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
        //                            {
        //                                int x = num + int.Parse(this.txtleghichu.Text);
        //                                int y = (num2 + int.Parse(this.txthd.Text) + image.Height + 5) / 2 + this.txtghichu.Text.Length * 3;
        //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text.Trim(), x, y, font2, Brushes.Black);
        //                            }
        //                        }
        //                        if (this.cbingia.Checked)
        //                        {
        //                            string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###");
        //                            if (this.cbgia.Checked)
        //                            {
        //                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
        //                                {
        //                                    int x = num + int.Parse(this.txtleghichu.Text);
        //                                    int y = (num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5) / 2 + this.txtghichu.Text.Length * 3;
        //                                    this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text.Trim(), x, y, font2, Brushes.Black);
        //                                }
        //                                if (this.cbinten.Checked)
        //                                {
        //                                    e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
        //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
        //                                }
        //                                else
        //                                {
        //                                    e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
        //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
        //                                }
        //                            }
        //                            else
        //                            {
        //                                e.Graphics.DrawString(this.txtghichu.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
        //                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
        //                                {
        //                                    int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
        //                                    int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
        //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
        //                                }
        //                            }
        //                        }
        //                        e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
        //                        num += (int)num3;
        //                        if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
        //                        {
        //                            this.sl++;
        //                        }
        //                        else
        //                        {
        //                            this.sl = 0;
        //                        }
        //                    }
        //                }
        //                this.sl = 0;
        //            }
        //            this.i++;
        //        }
        //        this.lanin = 1;
        //    }
        //    else
        //    {
        //        this.i = this.sodong;
        //        while (this.i < this.dgvHangHoa.RowCount)
        //        {
        //            int num5 = 0;
        //            if (this.dgvHangHoa.Rows[this.i].Cells["STT"].Value.ToString() != "")
        //            {
        //                if (Convert.ToBoolean(this.dgvHangHoa.Rows[this.i].Cells["STT"].Value))
        //                {
        //                    for (int i = this.sl; i < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()); i++)
        //                    {
        //                        this.sotem++;
        //                        if (this.sotem > int.Parse(this.txtsotem.Text))
        //                        {
        //                            this.sodong = this.i;
        //                            this.sotem = 0;
        //                            num = int.Parse(this.txtleft.Text);
        //                            e.HasMorePages = true;
        //                            return;
        //                        }
        //                        e.Graphics.DrawString(this.txttieude.Text, new Font(this.cobten.Text, (float)int.Parse(this.txtcoten.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleten.Text), num2));
        //                        Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
        //                        Image image = code128WithChecksum.Draw(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString().Trim(), int.Parse(this.txthm.Text));
        //                        if (this.checkBox1.Checked)
        //                        {
        //                            e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["mahanghoa"].Value.ToString(), new Font("Arial", (float)(int.Parse(this.txtcotenhang.Text) - 1), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text) / 2, num2 + image.Height + 13), stringFormat);
        //                        }
        //                        if (this.cbinten.Checked)
        //                        {
        //                            if (this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim().Length > int.Parse(this.txtso_kytu.Text))
        //                            {
        //                                using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
        //                                {
        //                                    RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)((int.Parse(this.txtcotenhang.Text) + 4) * 2));
        //                                    e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
        //                                }
        //                                num5 = 10;
        //                            }
        //                            else
        //                            {
        //                                using (Font font = new Font(this.cobtenhang.Text, (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold, GraphicsUnit.Point))
        //                                {
        //                                    RectangleF layoutRectangle = new RectangleF((float)(num + int.Parse(this.txtlehang.Text)), (float)(num2 + int.Parse(this.txthd.Text) + image.Height + 10), (float)num3 - 20f, (float)(int.Parse(this.txtcotenhang.Text) + 4));
        //                                    e.Graphics.DrawString(this.dgvHangHoa.Rows[this.i].Cells["tenhang"].Value.ToString().Trim(), font, Brushes.Black, layoutRectangle, stringFormat);
        //                                }
        //                                num5 = 0;
        //                            }
        //                        }
        //                        if (!this.cbingia.Checked)
        //                        {
        //                            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                            using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular))
        //                            {
        //                                int x = num + int.Parse(this.txtleghichu.Text);
        //                                int y = (num2 + int.Parse(this.txthd.Text) + image.Height + 5) / 2 + this.txtghichu.Text.Length * 3;
        //                                this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text.Trim(), x, y, font2, Brushes.Black);
        //                            }
        //                        }
        //                        if (this.cbingia.Checked)
        //                        {
        //                            string text = Convert.ToDouble(this.dgvHangHoa.Rows[this.i].Cells["dongia"].Value.ToString()).ToString("#,###");
        //                            if (this.cbgia.Checked)
        //                            {
        //                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Bold))
        //                                {
        //                                    int x = num + int.Parse(this.txtleghichu.Text);
        //                                    int y = (num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + image.Height + 5) / 2 + this.txtghichu.Text.Length * 3;
        //                                    this.DrawRotatedTextAt(e.Graphics, -90f, this.txtghichu.Text.Trim(), x, y, font2, Brushes.Black);
        //                                }
        //                                if (this.cbinten.Checked)
        //                                {
        //                                    e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 10 + num5), stringFormat);
        //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + 12 + image.Height + 13 + num5), stringFormat2);
        //                                }
        //                                else
        //                                {
        //                                    e.Graphics.DrawString(text, new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text) / 2, num2 + int.Parse(this.txthd.Text) + image.Height + 10), stringFormat);
        //                                    e.Graphics.DrawString(" VNĐ", new Font("Arial", (float)int.Parse(this.txtcotenhang.Text), FontStyle.Bold), Brushes.Black, new Point(num + int.Parse(this.txtleftma.Text) + int.Parse(this.txtwm.Text), num2 + int.Parse(this.txthd.Text) + image.Height + 13), stringFormat2);
        //                                }
        //                            }
        //                            else
        //                            {
        //                                e.Graphics.DrawString(this.txtghichu.Text.Trim(), new Font(this.cobten.Text, (float)int.Parse(this.txtcoghichu.Text), FontStyle.Regular), Brushes.Black, new Point(num + int.Parse(this.txtleghichu.Text), num2 + int.Parse(this.txthd.Text) + int.Parse(this.txtcotenhang.Text) + image.Height + 10));
        //                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //                                using (Font font2 = new Font(this.cobgia.Text, (float)int.Parse(this.txtgia.Text), FontStyle.Bold))
        //                                {
        //                                    int x = num + int.Parse(this.txtlegia.Text) + int.Parse(this.txtwm.Text);
        //                                    int y = num2 + int.Parse(this.txthd.Text) + int.Parse(this.txthm.Text) + 15;
        //                                    this.DrawRotatedTextAt(e.Graphics, -90f, text + " Đ", x, y, font2, Brushes.Black);
        //                                }
        //                            }
        //                        }
        //                        e.Graphics.DrawImage(image, num + int.Parse(this.txtleftma.Text), num2 + int.Parse(this.txthd.Text) - int.Parse(this.txttopm.Text), int.Parse(this.txtwm.Text), image.Height);
        //                        num += (int)num3;
        //                        if (this.sl < int.Parse(this.dgvHangHoa.Rows[this.i].Cells["SLTEM"].Value.ToString()))
        //                        {
        //                            this.sl++;
        //                        }
        //                        else
        //                        {
        //                            this.sl = 0;
        //                        }
        //                    }
        //                    this.sl = 0;
        //                }
        //            }
        //            this.i++;
        //        }
        //    }
        }

        // Token: 0x0600019F RID: 415 RVA: 0x0003C20C File Offset: 0x0003A40C
        private void cbgia2_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.cbgia2.Checked)
            {
                this.dongia_in = "DONGIA2";
                this.donvitinh_in = "DONVITINHLON";
            }
            else
            {
                this.dongia_in = "DONGIA";
                this.donvitinh_in = "DONVITINH";
            }
            this.button3_Click(null, null);
        }

        // Token: 0x060001A0 RID: 416 RVA: 0x0003C268 File Offset: 0x0003A468
        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.txtsodong.Text = "1";
            }
            else
            {
                this.txtsodong.Text = "2";
            }
        }
    }
}

