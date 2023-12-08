using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_themdonhangcongno : Form
    {
        public Frm_themdonhangcongno()
        {
            InitializeComponent();
        }
        private void mahoadontieptheo()
        {
            //try
            //{
            //    string selectCommandText = "select isnull(MAX(RIGHT(MADONHANG,5)),'0') from TB_DONHANGCONGNO where CONVERT(DATETIME,LEFT(NGAY,10),103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    string text = "";
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        text = "00001";
            //    }
            //    else
            //    {
            //        double num = Convert.ToDouble(dataTable.Rows[0][0].ToString());
            //        num += 1.0;
            //        if (num < 10.0)
            //        {
            //            text += "0000";
            //        }
            //        else if (num < 100.0)
            //        {
            //            text += "000";
            //        }
            //        else if (num < 1000.0)
            //        {
            //            text += "00";
            //        }
            //        else if (num < 10000.0)
            //        {
            //            text += "0";
            //        }
            //        text += num.ToString();
            //    }
            //    this.txtma.Text = DateTime.Now.ToString("ddMMyyyy") + text;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D1A RID: 3354 RVA: 0x001CD7A8 File Offset: 0x001CB9A8
        private void loadncc()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT MAKHACHHANG, TENDONVI FROM TB_KHACHHANG WHERE NCC='NCC' ORDER BY TENDONVI", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    this.comboBox1.DataSource = dataTable;
            //    this.comboBox1.DisplayMember = "TENDONVI";
            //    this.comboBox1.ValueMember = "MAKHACHHANG";
            //    this.comboBox1.SelectedIndex = -1;
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000D1B RID: 3355 RVA: 0x001CD858 File Offset: 0x001CBA58
        private void Frm_themdonhangcongno_Load(object sender, EventArgs e)
        {
            if (Frm_themdonhangcongno.taomoi == 0)
            {
                this.txttienno.ReadOnly = false;
                this.mahoadontieptheo();
                this.loadncc();
            }
            else
            {
                this.txtma.Text = Frm_themdonhangcongno.madonhang;
                BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
                this.button3.Text = "In Phiếu";
                bindingList.Add(new KeyValuePair<string, string>(Frm_themdonhangcongno.mancc, Frm_themdonhangcongno.tenncc));
                this.comboBox1.Items.Clear();
                this.comboBox1.DataSource = bindingList;
                this.comboBox1.ValueMember = "Key";
                this.comboBox1.DisplayMember = "Value";
                this.txttienno.ReadOnly = true;
                this.txttienno.Text = Frm_themdonhangcongno.sotienno;
                this.txttientra.Focus();
            }
        }

        // Token: 0x06000D1C RID: 3356 RVA: 0x001CD944 File Offset: 0x001CBB44
        private void txttienno_Leave(object sender, EventArgs e)
        {
            if (this.txttienno.Text == "")
            {
                this.txttienno.Text = "0";
            }
        }

        // Token: 0x06000D1D RID: 3357 RVA: 0x001CD980 File Offset: 0x001CBB80
        private void txttientra_Leave(object sender, EventArgs e)
        {
            if (this.txttientra.Text == "")
            {
                this.txttientra.Text = "0";
            }
        }

        // Token: 0x06000D1E RID: 3358 RVA: 0x001CD9BC File Offset: 0x001CBBBC
        private void button1_Click(object sender, EventArgs e)
        {
            //if (!(this.txttienno.Text == "0"))
            //{
            //    if (this.comboBox1.Text == "")
            //    {
            //        MessageBox.Show("BẠN CHƯA CHỌN NHÀ CUNG CẤP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.comboBox1.Focus();
            //    }
            //    else
            //    {
            //        byte[] buffer;
            //        try
            //        {
            //            MemoryStream memoryStream = new MemoryStream();
            //            this.ptlogo.Image.Save(memoryStream, ImageFormat.Jpeg);
            //            buffer = memoryStream.GetBuffer();
            //            memoryStream.Close();
            //        }
            //        catch
            //        {
            //            MemoryStream memoryStream = new MemoryStream();
            //            this.ptlogo.Image = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
            //            Bitmap bitmap = new Bitmap(this.ptlogo.Image);
            //            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //            buffer = memoryStream.GetBuffer();
            //            memoryStream.Close();
            //        }
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        if (Frm_themdonhangcongno.taomoi == 0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_DONHANGCONGNO]([MADONHANG],[MANCC],[TENNCC],[NGAY],[SOTIENNO],[SOTIENTRA],[NHANVIEN])  VALUES\r\n              ('",
            //                this.txtma.Text,
            //                "','",
            //                this.comboBox1.SelectedValue.ToString(),
            //                "',N'",
            //                this.comboBox1.Text,
            //                "','",
            //                DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            //                "','",
            //                decimal.Parse(this.txttienno.Text),
            //                "','",
            //                decimal.Parse(this.txttientra.Text),
            //                "','",
            //                frmLogIn.MADANGNHAP,
            //                "')"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            if (this.ptlogo.Image != null)
            //            {
            //                string cmdText2 = "UPDATE TB_DONHANGCONGNO SET HINH=@HINH WHERE MADONHANG='" + this.txtma.Text + "'";
            //                sqlConnection.Open();
            //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //                sqlCommand2.Parameters.AddWithValue("@mahang", this.txtma.Text);
            //                sqlCommand2.Parameters.AddWithValue("@hinh", buffer);
            //                sqlCommand2.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //        if (this.txttientra.Text != "0")
            //        {
            //            string text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //            if (sqlConnection.State == ConnectionState.Open)
            //            {
            //                sqlConnection.Close();
            //            }
            //            sqlConnection.Open();
            //            string cmdText3 = string.Concat(new object[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_CHITETQUANLYCONGNO]([MADONHANG],[NGAYTHANHTOAN],[SOTIENTRA],[NHANVIEN])  VALUES\r\n              ('",
            //                this.txtma.Text,
            //                "','",
            //                text,
            //                "','",
            //                decimal.Parse(this.txttientra.Text),
            //                "','",
            //                frmLogIn.MADANGNHAP,
            //                "')"
            //            });
            //            SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //            sqlCommand3.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            if (this.ptlogo.Image != null)
            //            {
            //                string cmdText2 = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHITETQUANLYCONGNO SET HINH=@HINH WHERE MADONHANG='",
            //                    this.txtma.Text,
            //                    "' AND NGAYTHANHTOAN='",
            //                    text,
            //                    "'"
            //                });
            //                sqlConnection.Open();
            //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //                sqlCommand2.Parameters.AddWithValue("@mahang", this.txtma.Text);
            //                sqlCommand2.Parameters.AddWithValue("@hinh", buffer);
            //                sqlCommand2.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //        this.button3_Click(null, null);
            //        base.Close();
            //    }
            //}
        }

        // Token: 0x06000D1F RID: 3359 RVA: 0x001CDE20 File Offset: 0x001CC020
        private void txttienno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttienno.Text != "")
                {
                    this.txttienno.Text = decimal.Parse(this.txttienno.Text).ToString("#,##0");
                    this.txttienno.SelectionStart = this.txttienno.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000D20 RID: 3360 RVA: 0x001CDEA8 File Offset: 0x001CC0A8
        private void txttientra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttientra.Text != "")
                {
                    this.txttientra.Text = decimal.Parse(this.txttientra.Text).ToString("#,##0");
                    this.txttientra.SelectionStart = this.txttientra.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000D21 RID: 3361 RVA: 0x0001E520 File Offset: 0x0001C720
        private void button2_Click(object sender, EventArgs e)
        {
            this.txttientra.Text = this.txttienno.Text;
        }

        // Token: 0x06000D22 RID: 3362 RVA: 0x00089160 File Offset: 0x00087360
        private void txttienno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000D23 RID: 3363 RVA: 0x00089160 File Offset: 0x00087360
        private void txttientra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000D24 RID: 3364 RVA: 0x001CDF30 File Offset: 0x001CC130
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num = -5;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            using (Font font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF layoutRectangle = new RectangleF((float)(num + 20), 5f, 132f, 50f);
                e.Graphics.DrawString("NPP: " + this.comboBox1.Text.ToUpper(), font, Brushes.Black, layoutRectangle, stringFormat);
            }
           // Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
           // Image image = code128WithChecksum.Draw(this.txtma.Text, 50);
          //  e.Graphics.DrawImage(image, num + 20, 40, 140, 50);
           // e.Graphics.DrawString(this.txtma.Text, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(num + 40, 90));
        }

        // Token: 0x06000D25 RID: 3365 RVA: 0x001CE048 File Offset: 0x001CC248
        private void button3_Click(object sender, EventArgs e)
        {
            if (Frm_themdonhangcongno.taomoi == 0)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                DialogResult dialogResult = printDialog.ShowDialog();
                printDocument.PrintPage += this.printDocument1_PrintPage;
                if (dialogResult == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            if (this.txttientra.Text != "0")
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                DialogResult dialogResult = printDialog.ShowDialog();
                printDocument.PrintPage += this.printDocument2_PrintPage;
                if (dialogResult == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        // Token: 0x06000D26 RID: 3366 RVA: 0x001CE10C File Offset: 0x001CC30C
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int num = 10;
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                StringFormat stringFormat2 = new StringFormat();
                stringFormat2.Alignment = StringAlignment.Far;
                e.Graphics.DrawString("PHIẾU CHI TIỀN", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(350 + num, 70), stringFormat);
                e.Graphics.DrawString(string.Concat(new string[]
                {
                    "Ngày   ",
                    DateTime.Now.ToString("dd"),
                    "   tháng   ",
                    DateTime.Now.ToString("MM"),
                    "   năm   ",
                    DateTime.Now.ToString("yyyy")
                }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(350 + num, 100), stringFormat);
                e.Graphics.DrawString("Họ tên người nhận tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 130));
                e.Graphics.DrawString("Địa chỉ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 155));
                e.Graphics.DrawString("Lý do chi:  Thanh toán đơn hàng " + this.txtma.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 180));
                e.Graphics.DrawString("Số Tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 205));
                e.Graphics.DrawString("(viết bằng chữ)", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + num, 205));
                e.Graphics.DrawString("Kèm theo: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 255));
                e.Graphics.DrawString("chứng từ gốc", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + num, 255), stringFormat2);
                e.Graphics.DrawString("..................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(154 + num, 138));
                e.Graphics.DrawString(".........................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num, 163));
                e.Graphics.DrawString("...................................... ..................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num, 188));
                e.Graphics.DrawString("..................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num, 213));
                e.Graphics.DrawString("..................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(420 + num, 213));
                e.Graphics.DrawString(".......................................................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(5 + num, 238));
                e.Graphics.DrawString(".............................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num, 261));
                e.Graphics.DrawString(this.comboBox1.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num, 128));
                e.Graphics.DrawString(Convert.ToDecimal(this.txttientra.Text).ToString("#,##0") + "   VNĐ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(130 + num, 203));
                e.Graphics.DrawString(Frm_themdonhangcongno.So_chu(Convert.ToDouble(this.txttientra.Text)), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(90 + num, 230));
                int num2 = 288;
                e.Graphics.DrawString(string.Concat(new string[]
                {
                    "Ngày   ",
                    DateTime.Now.ToString("dd"),
                    "   tháng   ",
                    DateTime.Now.ToString("MM"),
                    "   năm   ",
                    DateTime.Now.ToString("yyyy")
                }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + num, num2), stringFormat2);
                e.Graphics.DrawString("Người nhận tiền                                  Thủ quỹ                                   Người lập phiếu", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(380 + num, num2 + 25), stringFormat);
                e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(115 + num, num2 + 45), stringFormat);
                e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(375 + num, num2 + 45), stringFormat);
                e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(640 + num, num2 + 45), stringFormat);
                e.Graphics.DrawString("Đã nhận đủ số tiền (viết bằng chữ):", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + num, num2 + 172));
                e.Graphics.DrawString(".....................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(720 + num, num2 + 180), stringFormat2);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000D27 RID: 3367 RVA: 0x001CE878 File Offset: 0x001CCA78
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        // Token: 0x06000D28 RID: 3368 RVA: 0x00062194 File Offset: 0x00060394
        private static string Donvi(string so)
        {
            string result = "";
            if (so.Equals("1"))
            {
                result = "";
            }
            if (so.Equals("2"))
            {
                result = "nghìn";
            }
            if (so.Equals("3"))
            {
                result = "triệu";
            }
            if (so.Equals("4"))
            {
                result = "tỷ";
            }
            if (so.Equals("5"))
            {
                result = "nghìn tỷ";
            }
            if (so.Equals("6"))
            {
                result = "triệu tỷ";
            }
            if (so.Equals("7"))
            {
                result = "tỷ tỷ";
            }
            return result;
        }

        // Token: 0x06000D29 RID: 3369 RVA: 0x001CE9C0 File Offset: 0x001CCBC0
        private static string Tach(string tach3)
        {
            string text = "";
            string result;
            if (tach3.Equals("000"))
            {
                result = "";
            }
            else
            {
                if (tach3.Length == 3)
                {
                    string text2 = tach3.Trim().Substring(0, 1).ToString().Trim();
                    string text3 = tach3.Trim().Substring(1, 1).ToString().Trim();
                    string text4 = tach3.Trim().Substring(2, 1).ToString().Trim();
                    if (text2.Equals("0") && text3.Equals("0"))
                    {
                        text = " không trăm lẻ " + Frm_themdonhangcongno.Chu(text4.ToString().Trim()) + " ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && text4.Equals("0"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.ToString().Trim()).Trim() + " trăm ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && !text4.Equals("0"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.ToString().Trim()).Trim() + " trăm lẻ " + Frm_themdonhangcongno.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            " không trăm ",
                            Frm_themdonhangcongno.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frm_themdonhangcongno.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
                    {
                        text = " không trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
                    {
                        text = " không trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("1"))
                    {
                        text = " không trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = " không trăm mười " + Frm_themdonhangcongno.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = " không trăm mười ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = " không trăm mười lăm ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && Convert.ToDouble(text4) > 0.0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            Frm_themdonhangcongno.Chu(text2.Trim()).Trim(),
                            " trăm ",
                            Frm_themdonhangcongno.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frm_themdonhangcongno.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("0"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("5"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("1"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm " + Frm_themdonhangcongno.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && Convert.ToDouble(text4) > 0.0 && !text4.Equals("5"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm mười " + Frm_themdonhangcongno.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm mười ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = Frm_themdonhangcongno.Chu(text2.Trim()).Trim() + " trăm mười lăm ";
                    }
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000D2A RID: 3370 RVA: 0x001CF080 File Offset: 0x001CD280
        public static string So_chu(double gNum)
        {
            string result = string.Empty;
            if (gNum == 0.0)
            {
                //result = "Không " + Settings.Default.vnd;
            }
            else
            {
                string text = "";
                string tach = "";
                string text2 = "";
                double value = Math.Round(gNum, 0);
                string text3 = Convert.ToString(value);
                int num = Convert.ToInt32(text3.Length / 3);
                int num2 = text3.Length - num * 3;
                if (gNum < 0.0)
                {
                }
                string text4 = "";
                if (num2.Equals(1))
                {
                    tach = "00" + Convert.ToString(value.ToString().Trim().Substring(0, 1)).Trim();
                }
                if (num2.Equals(2))
                {
                    tach = "0" + Convert.ToString(value.ToString().Trim().Substring(0, 2)).Trim();
                }
                if (num2.Equals(0))
                {
                    tach = "000";
                }
                if (value.ToString().Length > 2)
                {
                    text2 = Convert.ToString(value.ToString().Trim().Substring(num2, value.ToString().Length - num2)).Trim();
                }
                int num3 = num + 1;
                if (num2 > 0)
                {
                    text = Frm_themdonhangcongno.Tach(tach).ToString().Trim() + " " + Frm_themdonhangcongno.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frm_themdonhangcongno.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frm_themdonhangcongno.Donvi(num.ToString().Trim()).Trim();
                    }
                    text2 = text2.Trim().Substring(3, text2.Trim().Length - 3);
                    i--;
                    num5++;
                }
                if (text.Trim().Substring(0, 1).Equals("k"))
                {
                    text = text.Trim().Substring(10, text.Trim().Length - 10).Trim();
                }
                if (text.Trim().Substring(0, 1).Equals("l"))
                {
                    text = text.Trim().Substring(2, text.Trim().Length - 2).Trim();
                }
                if (text.Trim().Length > 0)
                {
                    text = string.Concat(new string[]
                    {
                        text4.Trim(),
                        " ",
                        text.Trim().Substring(0, 1).Trim().ToUpper(),
                        text.Trim().Substring(1, text.Trim().Length - 1).Trim(),
                      //  Settings.Default.vnd,
                        "."
                    });
                }
                result = text.ToString().Trim();
            }
            return result;
        }

        // Token: 0x06000D2B RID: 3371 RVA: 0x001CF428 File Offset: 0x001CD628
        private void ptlogo_Click(object sender, EventArgs e)
        {
            if (this.txtma.Text != "")
            {
                try
                {
                    this.openFileDialog1.Filter = "Select Images |*.jpg||*.png";
                    if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.ptlogo.Load(this.openFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }

        // Token: 0x06000D2C RID: 3372 RVA: 0x001CF4B4 File Offset: 0x001CD6B4
        private void txttienno_Enter(object sender, EventArgs e)
        {
            if (this.txttienno.Text == "0")
            {
                this.txttienno.Text = "";
            }
        }

        // Token: 0x06000D2D RID: 3373 RVA: 0x001CF4F0 File Offset: 0x001CD6F0
        private void txttientra_Enter(object sender, EventArgs e)
        {
            if (this.txttientra.Text == "0")
            {
                this.txttientra.Text = "";
            }
        }
        public static string sotienno = string.Empty;

        // Token: 0x04000F2A RID: 3882
        public static string madonhang = string.Empty;

        // Token: 0x04000F2B RID: 3883
        public static string mancc = string.Empty;

        // Token: 0x04000F2C RID: 3884
        public static string tenncc = string.Empty;

        // Token: 0x04000F2D RID: 3885
        public static int taomoi = 0;
    }
}
