using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class FrmcapnhatSQL : Form
    {
        public FrmcapnhatSQL()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string cmdText = this.textBox1.Text ?? "";
                //SqlConnection sqlConnection = new SqlConnection();
                //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                //sqlConnection.Open();
                //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //sqlCommand.ExecuteNonQuery();
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO");
               // sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("KHÔNG CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO");
            }
        }

        // Token: 0x06000B3E RID: 2878 RVA: 0x001B4BA8 File Offset: 0x001B2DA8
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.A && e.Control)
            {
                if (!string.IsNullOrEmpty(this.textBox1.Text))
                {
                    this.textBox1.SelectionStart = 0;
                    this.textBox1.SelectionLength = this.textBox1.Text.Length;
                }
            }
        }

        // Token: 0x06000B3F RID: 2879 RVA: 0x001B4C30 File Offset: 0x001B2E30
        private void button2_Click(object sender, EventArgs e)
        {
            string arguments = "/c <%windir%\\Microsoft.NET\\Framework64/v4.0.30319\\aspnet_regiis.exe -i>";
            Process.Start("CMD.exe", arguments);
        }

        // Token: 0x06000B40 RID: 2880 RVA: 0x001B4C50 File Offset: 0x001B2E50
        private void button3_Click(object sender, EventArgs e)
        {
            string arguments = "/c <%windir%\\Microsoft.NET\\Framework/v4.0.30319\\aspnet_regiis.exe -i>";
            Process.Start("CMD.exe", arguments);
        }

        // Token: 0x06000B41 RID: 2881 RVA: 0x001B4C70 File Offset: 0x001B2E70
        private void button4_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT MAHANGHOA,TENHANGHOA_KHONGDAU FROM TB_HANGHOA ";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        string text = "";
            //        string[] array = dataTable.Rows[i][1].ToString().Trim().Split(new char[]
            //        {
            //            ' '
            //        });
            //        foreach (string text2 in array)
            //        {
            //            if (text2.ToString().Trim().Length > 0)
            //            {
            //                text += text2.ToString().Substring(0, 1);
            //            }
            //        }
            //        sqlConnection.Close();
            //        sqlConnection.Open();
            //        string cmdText2 = string.Concat(new string[]
            //        {
            //            "UPDATE TB_HANGHOA SET KYTUDAU='",
            //            text,
            //            "' WHERE MAHANGHOA='",
            //            dataTable.Rows[i][0].ToString(),
            //            "' "
            //        });
            //        sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000B42 RID: 2882 RVA: 0x001B4E24 File Offset: 0x001B3024
        private void button5_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //string cmdText = "update TB_HANGHOA set DONVITINHLON3='0' update TB_HANGHOA set MANHOM= (SELECT TOP 1 MANHOM FROM TB_NHOMHANG) where not exists (select * from TB_NHOMHANG where TB_HANGHOA.MANHOM=TB_NHOMHANG.MANHOM)";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Token: 0x06000B43 RID: 2883 RVA: 0x001B4E84 File Offset: 0x001B3084
        private void button6_Click(object sender, EventArgs e)
        {
            //string cmdText = "update TB_HANGHOA set KYTUDAU=dbo.removeAllSpecialChars(KYTUDAU)\r\nupdate TB_HANGHOA set KYTUDAU=REPLACE(KYTUDAU,' ','')\r\nupdate TB_HANGHOA set TENHANGHOA_KHONGDAU=dbo.removeAllSpecialChars(TENHANGHOA_KHONGDAU)";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Token: 0x06000B44 RID: 2884 RVA: 0x001B4EE4 File Offset: 0x001B30E4
        private void button7_Click(object sender, EventArgs e)
        {
            //string cmdText = "update TB_HANGHOA set MAHANGHOA=REPLACE(dbo.removeAllSpecialChars(MAHANGHOA),' ','')\r\nupdate TB_KHACHHANG set MAKHACHHANG=REPLACE(dbo.removeAllSpecialChars(MAKHACHHANG),' ','')\r\nupdate TB_HOADONBANHANG set MAKHACHHANG=REPLACE(dbo.removeAllSpecialChars(MAKHACHHANG),' ','')\r\nupdate TB_DIEMKM set MAKHACHHANG=REPLACE(dbo.removeAllSpecialChars(MAKHACHHANG),' ','')\r\nupdate TB_THUCHI set MAKH=REPLACE(dbo.removeAllSpecialChars(MAKH),' ','')\r\nupdate TB_TONDAUKY set MAKH=REPLACE(dbo.removeAllSpecialChars(MAKH),' ','')\r\n\r\n";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Token: 0x06000B45 RID: 2885 RVA: 0x001B4F44 File Offset: 0x001B3144
        private void button8_Click(object sender, EventArgs e)
        {
            //string cmdText = "update TB_HANGHOA set TENHANGHOA=UPPER(TENHANGHOA), DONVITINH=UPPER(DONVITINH),DONVITINHLON=UPPER(DONVITINHLON) ";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
