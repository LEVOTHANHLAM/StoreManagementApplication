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
    public partial class Frm_phannhomkhachhang : Form
    {
        public Frm_phannhomkhachhang()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string text = "True";
            //    if (!this.checkBox1.Checked)
            //    {
            //        text = "False";
            //    }
            //    string text2 = "True";
            //    if (!this.checkBox2.Checked)
            //    {
            //        text2 = "False";
            //    }
            //    string text3 = "True";
            //    if (!this.checkBox3.Checked)
            //    {
            //        text3 = "False";
            //    }
            //    string text4 = "True";
            //    if (!this.checkBox4.Checked)
            //    {
            //        text4 = "False";
            //    }
            //    string cmdText = string.Concat(new object[]
            //    {
            //        "UPDATE TB_LOAIKHACHHANG SET NOIDUNG=N'",
            //        this.textBox1.Text.Trim(),
            //        "',SOTIEN='",
            //        float.Parse(this.textBox2.Text.Trim()),
            //        "',GIAM='",
            //        this.textBox12.Text.Trim(),
            //        "',DUNG='",
            //        text,
            //        "' WHERE MA='",
            //        this.ma1,
            //        "' UPDATE TB_LOAIKHACHHANG SET NOIDUNG=N'",
            //        this.textBox4.Text.Trim(),
            //        "',SOTIEN='",
            //        float.Parse(this.textBox3.Text.Trim()),
            //        "',GIAM='",
            //        this.textBox11.Text.Trim(),
            //        "',DUNG='",
            //        text2,
            //        "'  WHERE MA='",
            //        this.ma2,
            //        "' UPDATE TB_LOAIKHACHHANG SET NOIDUNG=N'",
            //        this.textBox6.Text.Trim(),
            //        "',SOTIEN='",
            //        float.Parse(this.textBox5.Text.Trim()),
            //        "',GIAM='",
            //        this.textBox10.Text.Trim(),
            //        "' ,DUNG='",
            //        text3,
            //        "' WHERE MA='",
            //        this.ma3,
            //        "' UPDATE TB_LOAIKHACHHANG SET NOIDUNG=N'",
            //        this.textBox8.Text.Trim(),
            //        "',SOTIEN='",
            //        float.Parse(this.textBox7.Text.Trim()),
            //        "',GIAM='",
            //        this.textBox9.Text.Trim(),
            //        "' ,DUNG='",
            //        text4,
            //        "' WHERE MA='",
            //        this.ma4,
            //        "' UPDATE TB_LOAIKHACHHANG SET NOIDUNG=N'",
            //        this.textBox13.Text.Trim(),
            //        "',SOTIEN='0',GIAM='0' WHERE MA='",
            //        this.ma5,
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    base.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        // Token: 0x0600065A RID: 1626 RVA: 0x00127668 File Offset: 0x00125868
        private void LOAD()
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TB_LOAIKHACHHANG ORDER BY MA", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    int num = 0;
            //    while (sqlDataReader.Read())
            //    {
            //        if (num == 0)
            //        {
            //            num++;
            //            this.ma1 = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.textBox1.Text = sqlDataReader.GetString(1);
            //            this.textBox2.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //            this.textBox12.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //            if (Convert.ToString(sqlDataReader.GetValue(4)) == "True")
            //            {
            //                this.checkBox1.Checked = true;
            //            }
            //        }
            //        else if (num == 1)
            //        {
            //            num++;
            //            this.ma2 = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.textBox4.Text = sqlDataReader.GetString(1);
            //            this.textBox3.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //            this.textBox11.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //            if (Convert.ToString(sqlDataReader.GetValue(4)) == "True")
            //            {
            //                this.checkBox2.Checked = true;
            //            }
            //        }
            //        else if (num == 2)
            //        {
            //            num++;
            //            this.ma3 = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.textBox6.Text = sqlDataReader.GetString(1);
            //            this.textBox5.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //            this.textBox10.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //            if (Convert.ToString(sqlDataReader.GetValue(4)) == "True")
            //            {
            //                this.checkBox3.Checked = true;
            //            }
            //        }
            //        else if (num == 3)
            //        {
            //            num++;
            //            this.ma4 = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.textBox8.Text = sqlDataReader.GetString(1);
            //            this.textBox7.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //            this.textBox9.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //            if (Convert.ToString(sqlDataReader.GetValue(4)) == "True")
            //            {
            //                this.checkBox4.Checked = true;
            //            }
            //        }
            //        else if (num == 4)
            //        {
            //            num++;
            //            this.ma5 = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.textBox13.Text = sqlDataReader.GetString(1);
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600065B RID: 1627 RVA: 0x0001CB3F File Offset: 0x0001AD3F
        private void Frm_phannhomkhachhang_Load(object sender, EventArgs e)
        {
            this.LOAD();
        }

        // Token: 0x0600065C RID: 1628 RVA: 0x00127998 File Offset: 0x00125B98
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox2.Text = double.Parse(this.textBox2.Text).ToString("#,###");
                this.textBox2.SelectionStart = this.textBox2.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0600065D RID: 1629 RVA: 0x00127A00 File Offset: 0x00125C00
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox3.Text = double.Parse(this.textBox3.Text).ToString("#,###");
                this.textBox3.SelectionStart = this.textBox3.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0600065E RID: 1630 RVA: 0x00127A68 File Offset: 0x00125C68
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox5.Text = double.Parse(this.textBox5.Text).ToString("#,###");
                this.textBox5.SelectionStart = this.textBox5.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0600065F RID: 1631 RVA: 0x00127AD0 File Offset: 0x00125CD0
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBox7.Text = double.Parse(this.textBox7.Text).ToString("#,###");
                this.textBox7.SelectionStart = this.textBox7.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0400070B RID: 1803
        private string ma1;

        // Token: 0x0400070C RID: 1804
        private string ma2;

        // Token: 0x0400070D RID: 1805
        private string ma3;

        // Token: 0x0400070E RID: 1806
        private string ma4;

        // Token: 0x0400070F RID: 1807
        private string ma5;
    }
}
