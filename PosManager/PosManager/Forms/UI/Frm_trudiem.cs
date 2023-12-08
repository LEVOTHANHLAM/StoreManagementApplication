using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_trudiem : Form
    {
        public Frm_trudiem()
        {
            InitializeComponent();
        }
        private void Frm_trudiem_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
            this.txtdiemhientai.Text = Frm_trudiem.diemkhachhang;
            this.button2.Text = "Đổi hết điểm";
            if (Frm_trudiem.doidiem == 1)
            {
                this.button2.Text = "Đổi hết tiền";
            }
        }

        // Token: 0x06000D10 RID: 3344 RVA: 0x001CC604 File Offset: 0x001CA804
        private void button1_Click(object sender, EventArgs e)
        {
            //if (double.Parse(this.txtdiem.Text) > 0.0)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string text = "";
            //    if (this.txtghichu.Text != this.txtghichu.Tag.ToString())
            //    {
            //        text = this.txtghichu.Text;
            //    }
            //    if (Frm_trudiem.doidiem == 0)
            //    {
            //        string text2 = DateTime.Now.ToString("ddMMyyyyHHmmss");
            //        string cmdText;
            //        if (this.comboBox1.SelectedIndex == 0)
            //        {
            //            cmdText = string.Concat(new object[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_DIEMKM]\r\n           ([MAHOADON] ,[MAKHACHHANG]   ,[NGAY]  ,[SOTIEN]  ,[SOLUONG]   ,[DIEMCONG]    ,[DIEMTRU]  ,[DIEM],GHICHU) VALUES ('",
            //                text2,
            //                "','",
            //                Frm_trudiem.makhachhang,
            //                "','",
            //                DateTime.Now.ToString("dd/MM/yyyy HH:MM"),
            //                "',0,0,'",
            //                double.Parse(this.txtdiem.Text),
            //                "',0,0,N'",
            //                text,
            //                "')"
            //            });
            //        }
            //        else
            //        {
            //            cmdText = string.Concat(new object[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_DIEMKM]\r\n           ([MAHOADON] ,[MAKHACHHANG]   ,[NGAY]  ,[SOTIEN]  ,[SOLUONG]   ,[DIEMCONG]    ,[DIEMTRU]  ,[DIEM],GHICHU) VALUES ('",
            //                text2,
            //                "','",
            //                Frm_trudiem.makhachhang,
            //                "','",
            //                DateTime.Now.ToString("dd/MM/yyyy HH:MM"),
            //                "',0,0,0,'",
            //                double.Parse(this.txtdiem.Text),
            //                "',0,N'",
            //                text,
            //                "')"
            //            });
            //        }
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        if (frmLogIn.fileconnect != frmLogIn.fileconnect_khachhang)
            //        {
            //            string connectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //            SqlConnection sqlConnection2 = new SqlConnection(connectionString);
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection2);
            //            sqlConnection2.Open();
            //            sqlCommand2.ExecuteNonQuery();
            //            sqlConnection2.Close();
            //        }
            //    }
            //    else
            //    {
            //        double num = double.Parse(this.txtdiem.Text);
            //        if (this.comboBox1.SelectedIndex == 1)
            //        {
            //            num = -double.Parse(this.txtdiem.Text);
            //        }
            //        if (sqlConnection.State == ConnectionState.Closed)
            //        {
            //            sqlConnection.Open();
            //        }
            //        SqlCommand sqlCommand3 = new SqlCommand(string.Concat(new object[]
            //        {
            //            " INSERT INTO TB_TIENKHUYENMAI(MAKHACHHANG,SOTIEN,NGAY,GHICHU)VALUES ('",
            //            Frm_trudiem.makhachhang,
            //            "', '",
            //            num,
            //            "','",
            //            DateTime.Now.ToString("dd/MM/yyyy"),
            //            "',N'",
            //            text,
            //            "')"
            //        }), sqlConnection);
            //        sqlCommand3.ExecuteNonQuery();
            //        sqlCommand3.Dispose();
            //        sqlConnection.Close();
            //    }
            //    MessageBox.Show("THỰC HIỆN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    base.Close();
            //}
            //else
            //{
            //    MessageBox.Show("ĐIỂM PHẢI LỚN HƠN 0", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000D11 RID: 3345 RVA: 0x001CC984 File Offset: 0x001CAB84
        private void txtdiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtdiem.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x06000D12 RID: 3346 RVA: 0x001CCA10 File Offset: 0x001CAC10
        private void txtghichu_Leave(object sender, EventArgs e)
        {
            if (this.txtghichu.Text == "")
            {
                this.txtghichu.Text = this.txtghichu.Tag.ToString();
            }
        }

        // Token: 0x06000D13 RID: 3347 RVA: 0x001CCA58 File Offset: 0x001CAC58
        private void txtghichu_Enter(object sender, EventArgs e)
        {
            if (this.txtghichu.Text == this.txtghichu.Tag.ToString())
            {
                this.txtghichu.Text = "";
            }
        }

        // Token: 0x06000D14 RID: 3348 RVA: 0x0001E4C5 File Offset: 0x0001C6C5
        private void button2_Click(object sender, EventArgs e)
        {
            this.txtdiem.Text = this.txtdiemhientai.Text;
            this.button1.Focus();
        }
        public static string makhachhang = string.Empty;

        // Token: 0x04000F16 RID: 3862
        public static string diemkhachhang = string.Empty;

        // Token: 0x04000F17 RID: 3863
        public static int doidiem = 0;
    }
}
