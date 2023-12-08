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
    public partial class Frm_suagia : Form
    {
        public Frm_suagia()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.txtsoluong.Text = this.txtsoluong.Text + button.Text;
        }

        // Token: 0x0600091F RID: 2335 RVA: 0x00166AD8 File Offset: 0x00164CD8
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtsoluong.Text != "")
                {
                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
                    string s = double.Parse(this.txtsoluong.Text).ToString("", cultureInfo.NumberFormat);
                    string text = "DONGIA";
                    if (Frm_suagia.magia == 0)
                    {
                        text = "DONGIA";
                    }
                    if (Frm_suagia.magia == 1)
                    {
                        text = "DONGIA2";
                    }
                    if (Frm_suagia.magia == 2)
                    {
                        text = "DONGIA3";
                    }
                    if (Frm_suagia.magia == 3)
                    {
                        text = "DONGIA4";
                    }
                    if (Frm_suagia.magia == 4)
                    {
                        text = "DONGIA5";
                    }
                    if (Frm_suagia.magia == 5)
                    {
                        text = "DONGIA6";
                    }
                //    SqlConnection sqlConnection = new SqlConnection();
                //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                //    sqlConnection.Open();
                //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
                //    {
                //        "UPDATE TB_HANGHOA SET ",
                //        text,
                //        "='",
                //        double.Parse(s),
                //        "' WHERE MAHANGHOA ='",
                //        Frm_suagia.mahanghoa,
                //        "'"
                //    }), sqlConnection);
                //    sqlCommand.ExecuteNonQuery();
                //    sqlConnection.Close();
                }
            }
            catch
            {
            }
            this.button3_Click(null, null);
        }

        // Token: 0x06000920 RID: 2336 RVA: 0x00166C84 File Offset: 0x00164E84
        private void button3_Click(object sender, EventArgs e)
        {
            Frm_suagia.ok = "ok";
            if (this.txtsoluong.Text == "")
            {
                this.txtsoluong.Text = this.txtgiacu.Text;
            }
            Frm_suagia.sotien = this.txtsoluong.Text;
            base.Close();
        }

        // Token: 0x06000921 RID: 2337 RVA: 0x00166CE8 File Offset: 0x00164EE8
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(this.txtsoluong.Text) != 0.0)
                {
                    this.txtsoluong.Text = double.Parse(this.txtsoluong.Text).ToString("#,##0.##");
                    this.txtsoluong.SelectionStart = this.txtsoluong.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000922 RID: 2338 RVA: 0x0001D5BE File Offset: 0x0001B7BE
        private void button2_Click(object sender, EventArgs e)
        {
            Frm_suagia.ok = "ok_boqua";
            base.Close();
        }

        // Token: 0x06000923 RID: 2339 RVA: 0x00166D74 File Offset: 0x00164F74
        private void Frm_suagia_Load(object sender, EventArgs e)
        {
            if (Frm_suagia.magia == 0)
            {
                this.txtgiacu.Text = "Giá1: " + Frm_suagia.sotien_cu;
            }
            else if (Frm_suagia.magia == 1)
            {
                this.txtgiacu.Text = "Giá2: " + Frm_suagia.sotien_cu;
            }
            if (Frm_suagia.magia == 2)
            {
                this.txtgiacu.Text = "Giá3: " + Frm_suagia.sotien_cu;
            }
            else if (Frm_suagia.magia == 3)
            {
                this.txtgiacu.Text = "Giá4: " + Frm_suagia.sotien_cu;
            }
            else if (Frm_suagia.magia == 4)
            {
                this.txtgiacu.Text = "Giá5: " + Frm_suagia.sotien_cu;
            }
            else if (Frm_suagia.magia == 5)
            {
                this.txtgiacu.Text = "Giá6: " + Frm_suagia.sotien_cu;
            }
        }

        // Token: 0x06000924 RID: 2340 RVA: 0x00166E8C File Offset: 0x0016508C
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtsoluong.Text.Length > 0)
                {
                    this.txtsoluong.Text = this.txtsoluong.Text.Substring(0, this.txtsoluong.Text.Length - 1);
                }
                this.txtsoluong.Focus();
                this.txtsoluong.SelectionStart = this.txtsoluong.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000925 RID: 2341 RVA: 0x00166F20 File Offset: 0x00165120
        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button3_Click(null, null);
            }
        }

        // Token: 0x06000926 RID: 2342 RVA: 0x00166F48 File Offset: 0x00165148
        private void Frm_suagia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Frm_suagia.ok = "ok_boqua";
                base.Close();
            }
        }

        // Token: 0x06000927 RID: 2343 RVA: 0x00089160 File Offset: 0x00087360
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static int magia = 0;

        // Token: 0x04000A65 RID: 2661
        public static string mahanghoa = string.Empty;

        // Token: 0x04000A66 RID: 2662
        public static string sotien = string.Empty;

        // Token: 0x04000A67 RID: 2663
        public static string ok = string.Empty;

        // Token: 0x04000A68 RID: 2664
        public static string sotien_cu = string.Empty;
    }
}
