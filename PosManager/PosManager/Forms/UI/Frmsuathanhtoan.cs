using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmsuathanhtoan : Form
    {
        public Frmsuathanhtoan()
        {
            InitializeComponent();
        }
        private void Frmsuathanhtoan_Load(object sender, EventArgs e)
        {
            if (int.Parse(Frmsuathanhtoan.ht) == 1)
            {
                this.comboBox1.SelectedIndex = 0;
            }
            else if (int.Parse(Frmsuathanhtoan.ht) == 4)
            {
                this.comboBox1.SelectedIndex = 1;
            }
            if (int.Parse(Frmsuathanhtoan.ht) == 5)
            {
                this.comboBox1.SelectedIndex = 2;
            }
            this.txtsohoadon.Text = Frmsuathanhtoan.hd;
            if (Frmsuathanhtoan.makh != "")
            {
                this.txtmancc.Text = Frmsuathanhtoan.makh;
            }
            this.txttt.Text = Frmsuathanhtoan.thanhtoan;
            this.txttongcong.Text = Frmsuathanhtoan.tongcong;
            this.txtduatruoc.Text = Frmsuathanhtoan.duatruoc;
            this.txtnocu.Text = Frmsuathanhtoan.nocu;
            this.txtpt.Text = Frmsuathanhtoan.phantram;
            this.txttrutien.Text = Frmsuathanhtoan.giamtien;
        }

        // Token: 0x0600015C RID: 348 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button1_Click(object sender, EventArgs e)
        {
            //base.Close();
        }

        // Token: 0x0600015D RID: 349 RVA: 0x000313D4 File Offset: 0x0002F5D4
        private void bttim_Click(object sender, EventArgs e)
        {
            //Frmkhachhang.chon = "kh";
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //this.txtmancc.Text = Frmkhachhang.makhachhang;
        }

        // Token: 0x0600015E RID: 350 RVA: 0x0003140C File Offset: 0x0002F60C
        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtmancc.Text != "")
            //    {
            //        string cmdText = "SELECT ISNULL(TENDONVI,'') FROM tb_KHACHHANG where MAKHACHHANG=N'" + this.txtmancc.Text + "'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txttenncc.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txttenncc.Text = "";
            //        }
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.txttenncc.Text = "";
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600015F RID: 351 RVA: 0x00031508 File Offset: 0x0002F708
        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //string text = double.Parse(this.txtpt.Text.Trim()).ToString("", cultureInfo.NumberFormat);
            //string text2 = double.Parse(this.txttrutien.Text.Trim()).ToString("", cultureInfo.NumberFormat);
            //string text3 = decimal.Parse(this.txttt.Text.Trim()).ToString("", cultureInfo.NumberFormat);
            //string text4 = decimal.Parse(this.txtnocu.Text.Trim()).ToString("", cultureInfo.NumberFormat);
            //string text5 = decimal.Parse(this.txtduatruoc.Text.Trim()).ToString("", cultureInfo.NumberFormat);
            //string text6 = "";
            //if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //{
            //    text6 = this.txtmancc.Text;
            //}
            //if (this.comboBox1.SelectedIndex == 0)
            //{
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "UPDATE TB_HOADONBANHANG SET HINHTHUC='1' , MAKHACHHANG='",
            //        text6,
            //        "',PHANTRAM='",
            //        text,
            //        "',GIAMTIEN='",
            //        text2,
            //        "',THANHTOAN='",
            //        text3,
            //        "',NOCU='",
            //        text4,
            //        "',DUATRUOC='",
            //        text5,
            //        "',TIENPHANTRAM='",
            //        this.phantramgiam,
            //        "'  WHERE SOHOADON='",
            //        this.txtsohoadon.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    base.Close();
            //}
            //else if (this.comboBox1.SelectedIndex == 1)
            //{
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "UPDATE TB_HOADONBANHANG SET HINHTHUC='4' , MAKHACHHANG='",
            //        text6,
            //        "',PHANTRAM='",
            //        text,
            //        "',GIAMTIEN='",
            //        text2,
            //        "',THANHTOAN='",
            //        text3,
            //        "',NOCU='",
            //        text4,
            //        "',DUATRUOC='",
            //        text5,
            //        "',TIENPHANTRAM='",
            //        this.phantramgiam,
            //        "'  WHERE SOHOADON='",
            //        this.txtsohoadon.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    base.Close();
            //}
            //else if (this.comboBox1.SelectedIndex == 2)
            //{
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "UPDATE TB_HOADONBANHANG SET HINHTHUC='5' , MAKHACHHANG='",
            //        text6,
            //        "',PHANTRAM='",
            //        text,
            //        "',GIAMTIEN='",
            //        text2,
            //        "',THANHTOAN='",
            //        text3,
            //        "',NOCU='",
            //        text4,
            //        "',DUATRUOC='",
            //        text5,
            //        "',TIENPHANTRAM='",
            //        this.phantramgiam,
            //        "'  WHERE SOHOADON='",
            //        this.txtsohoadon.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    base.Close();
            //}
        }

        // Token: 0x06000160 RID: 352 RVA: 0x00031900 File Offset: 0x0002FB00
        private void txtmancc_Enter(object sender, EventArgs e)
        {
            if (this.txtmancc.Text.Trim() == this.txtmancc.Tag.ToString())
            {
                this.txtmancc.Text = "";
            }
        }

        // Token: 0x06000161 RID: 353 RVA: 0x0003194C File Offset: 0x0002FB4C
        private void txtmancc_Leave(object sender, EventArgs e)
        {
            if (this.txtmancc.Text.Trim() == "")
            {
                this.txtmancc.Text = this.txtmancc.Tag.ToString();
            }
        }

        // Token: 0x06000162 RID: 354 RVA: 0x00031998 File Offset: 0x0002FB98
        private void txttongcong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txttongcong.Text = decimal.Parse(this.txttongcong.Text).ToString("#,##0");
            }
            catch
            {
            }
        }

        // Token: 0x06000163 RID: 355 RVA: 0x000319EC File Offset: 0x0002FBEC
        private void txtduatruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000164 RID: 356 RVA: 0x00031A48 File Offset: 0x0002FC48
        private void txtpt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtpt.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    if (e.KeyChar != Convert.ToChar("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // Token: 0x06000165 RID: 357 RVA: 0x00031AF0 File Offset: 0x0002FCF0
        private void txttrutien_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txttrutien.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    if (e.KeyChar != Convert.ToChar("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // Token: 0x06000166 RID: 358 RVA: 0x00031B98 File Offset: 0x0002FD98
        private void txttt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txttt.Text = decimal.Parse(this.txttt.Text).ToString("#,##0");
            }
            catch
            {
            }
        }

        // Token: 0x06000167 RID: 359 RVA: 0x00031BEC File Offset: 0x0002FDEC
        private void txtduatruoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtduatruoc.Text = decimal.Parse(this.txtduatruoc.Text).ToString("#,##0");
                this.txtduatruoc.SelectionStart = this.txtduatruoc.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000168 RID: 360 RVA: 0x00031C54 File Offset: 0x0002FE54
        private void tinh()
        {
            decimal d = decimal.Parse(this.txttongcong.Text);
            decimal d2 = decimal.Parse(this.txttrutien.Text);
            decimal d3 = decimal.Parse(this.txtpt.Text);
            decimal d4 = d + d2;
            decimal d5 = d4 * d3 / 100m;
            this.phantramgiam = "0";
            this.phantramgiam = d5.ToString().Replace("-", "");
            decimal num = d4 + d5;
            this.txttt.Text = num.ToString();
        }

        // Token: 0x06000169 RID: 361 RVA: 0x00031D00 File Offset: 0x0002FF00
        private void loadcongno()
        {
            //this.loadtranotrongky();
            //this.loadcongnodauky();
            //string cmdText = "select case when hinhthuc='2' then isnull(SUM(THANHTOAN-DUATRUOC),0) when hinhthuc='3' then isnull(SUM(THANHTOAN),0) else '0' end from tb_hoadonbanhang where HUYHD='FALSE' AND MAKHACHHANG ='" + this.txtmancc.Text + "' GROUP BY HINHTHUC";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //decimal d = 0m;
            //while (sqlDataReader.Read())
            //{
            //    d += decimal.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //this.txtnocu.Text = (d + this.tientondauky - this.tientratrongky).ToString("#,##0");
            //sqlConnection.Close();
        }

        // Token: 0x0600016A RID: 362 RVA: 0x00031DD4 File Offset: 0x0002FFD4
        private void loadcongnodauky()
        {
            //string cmdText = "select isnull(SUM(SOTIEN),0) from tb_TONDAUKY where MA='thu' and MAKH ='" + this.txtmancc.Text.Trim() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tientondauky = decimal.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x0600016B RID: 363 RVA: 0x00031E64 File Offset: 0x00030064
        private void loadtranotrongky()
        {
            //this.tientratrongky = 0m;
            //string cmdText = "select isnull(SUM(SOTIEN),0)+ isnull(SUM(TIENTRANO),0) from Tb_THUCHI where MAKH ='" + this.txtmancc.Text.Trim() + "'  AND Thuchi='THU' AND CHIPHI='0' ";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tientratrongky = decimal.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x0600016C RID: 364 RVA: 0x00031F00 File Offset: 0x00030100
        private void txtpt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttt.Text != "")
                {
                    this.tinh();
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600016D RID: 365 RVA: 0x00031F50 File Offset: 0x00030150
        private void txttrutien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttrutien.Text != "")
                {
                    try
                    {
                        this.txttrutien.Text = decimal.Parse(this.txttrutien.Text).ToString("#,##0");
                        this.txttrutien.SelectionStart = this.txttrutien.TextLength;
                    }
                    catch
                    {
                    }
                    this.tinh();
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600016E RID: 366 RVA: 0x00031FF4 File Offset: 0x000301F4
        private void txttrutien_Leave(object sender, EventArgs e)
        {
            if (this.txttrutien.Text == "")
            {
                this.txttrutien.Text = "0";
            }
        }

        // Token: 0x0600016F RID: 367 RVA: 0x00032030 File Offset: 0x00030230
        private void txtpt_Leave(object sender, EventArgs e)
        {
            if (this.txtpt.Text == "")
            {
                this.txtpt.Text = "0";
            }
        }

        // Token: 0x06000170 RID: 368 RVA: 0x0003206C File Offset: 0x0003026C
        private void txtnocu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtnocu.Text = decimal.Parse(this.txtnocu.Text).ToString("#,##0");
                this.txtnocu.SelectionStart = this.txtnocu.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000171 RID: 369 RVA: 0x000320D4 File Offset: 0x000302D4
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            {
                this.loadcongno();
            }
        }

        // Token: 0x06000172 RID: 370 RVA: 0x00032114 File Offset: 0x00030314
        private void txtduatruoc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtduatruoc.Text == "")
                {
                    this.txtduatruoc.Text = "0";
                }
                else if (decimal.Parse(this.txtduatruoc.Text) > 0m)
                {
                    if (this.comboBox1.SelectedIndex == 0)
                    {
                        if (decimal.Parse(this.txtduatruoc.Text) < decimal.Parse(this.txttt.Text))
                        {
                            MessageBox.Show("SỐ TIỀN ĐƯA TRƯỚC PHẢI LỚN HƠN HOẠC BẰNG SỐ TIỀN THANH TOÁN");
                            this.txtduatruoc.Focus();
                            this.txtduatruoc.SelectionStart = this.txtduatruoc.TextLength;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x04000124 RID: 292
        public static string tongcong = string.Empty;

        // Token: 0x04000125 RID: 293
        public static string thanhtoan = string.Empty;

        // Token: 0x04000126 RID: 294
        public static string phantram = string.Empty;

        // Token: 0x04000127 RID: 295
        public static string giamtien = string.Empty;

        // Token: 0x04000128 RID: 296
        public static string nocu = string.Empty;

        // Token: 0x04000129 RID: 297
        public static string duatruoc = string.Empty;

        // Token: 0x0400012A RID: 298
        public static string ht = string.Empty;

        // Token: 0x0400012B RID: 299
        public static string hd = string.Empty;

        // Token: 0x0400012C RID: 300
        public static string makh = string.Empty;

        // Token: 0x0400012D RID: 301
        private string phantramgiam = "0";

        // Token: 0x0400012E RID: 302
        private decimal tientondauky;

        // Token: 0x0400012F RID: 303
        private decimal tientratrongky;
    }
}
