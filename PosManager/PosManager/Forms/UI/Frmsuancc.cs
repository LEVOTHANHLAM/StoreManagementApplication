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
    public partial class Frmsuancc : Form
    {
        public Frmsuancc()
        {
            InitializeComponent();
        }
        // Token: 0x06000CA6 RID: 3238 RVA: 0x001BA7D0 File Offset: 0x001B89D0
        private void bttim_Click(object sender, EventArgs e)
        {
            //Frmkhachhang.chon = "nk";
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //this.txtmancc.Text = Frmsuancc.mancc;
        }

        // Token: 0x06000CA7 RID: 3239 RVA: 0x001BA808 File Offset: 0x001B8A08
        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtmancc.Text != "")
            //    {
            //        string cmdText = "SELECT TENDONVI FROM tb_KHACHHANG where MAKHACHHANG=N'" + this.txtmancc.Text + "'";
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

        // Token: 0x06000CA8 RID: 3240 RVA: 0x0001E2A2 File Offset: 0x0001C4A2
        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.txtmancc.Focus();
        }

        // Token: 0x06000CA9 RID: 3241 RVA: 0x0001E2B1 File Offset: 0x0001C4B1
        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.txttenncc.Focus();
        }

        // Token: 0x06000CAA RID: 3242 RVA: 0x001BA904 File Offset: 0x001B8B04
        private void Frmsuancc_Load(object sender, EventArgs e)
        {
            this.txtsohoadon.Text = Frmsuancc.sohoadon;
            this.txtmancc.Text = Frmsuancc.makh;
            this.MANCC_CU = Frmsuancc.makh;
            if (Frmsuancc.thanhtoan == "Tiền Mặt")
            {
                this.cobtienmat.SelectedIndex = 0;
            }
            else
            {
                this.cobtienmat.SelectedIndex = 1;
            }
        }

        // Token: 0x06000CAB RID: 3243 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
        private void button1_Click(object sender, EventArgs e)
        {
            //Frmsuancc.sua = "0";
            //base.Close();
        }

        // Token: 0x06000CAC RID: 3244 RVA: 0x001BA974 File Offset: 0x001B8B74
        private void button2_Click(object sender, EventArgs e)
        {
        //    Frmsuancc.sua = "1";
        //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
        //    sqlConnection.Open();
        //    if (this.txtmancc.Text == "")
        //    {
        //        this.txtmancc.Text = "CTY";
        //    }
        //    string cmdText = string.Concat(new object[]
        //    {
        //        "UPDATE TB_HANGHOANHAP SET MALOAI='",
        //        this.cobtienmat.SelectedIndex,
        //        "' , NCC='",
        //        this.txtmancc.Text,
        //        "' WHERE MAHOADON='",
        //        this.txtsohoadon.Text,
        //        "' AND NGAYNHAP='",
        //        Frmsuancc.ngaynhapkho,
        //        "' AND NCC='",
        //        this.MANCC_CU,
        //        "'"
        //    });
        //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //    sqlCommand.ExecuteNonQuery();
        //    base.Close();
        }

        // Token: 0x04000E58 RID: 3672
        private string MANCC_CU = "";

        // Token: 0x04000E59 RID: 3673
        public static string ngaynhapkho = "";

        // Token: 0x04000E5A RID: 3674
        public static string mancc = "";

        // Token: 0x04000E5B RID: 3675
        public static string sohoadon = string.Empty;

        // Token: 0x04000E5C RID: 3676
        public static string makh = string.Empty;

        // Token: 0x04000E5D RID: 3677
        public static string thanhtoan = string.Empty;

        // Token: 0x04000E5E RID: 3678
        public static string sua = "0";
    }
}
