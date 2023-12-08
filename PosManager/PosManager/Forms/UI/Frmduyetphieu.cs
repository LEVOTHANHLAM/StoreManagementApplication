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
    public partial class Frmduyetphieu : Form
    {
        private string maphieunhapkho = "";
        public Frmduyetphieu()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.maphieunhapkho = "";
            //    if (this.textBox1.Text != "")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand("SELECT ISNULL(TIENTRANO ,0),SOPHIEU FROM TB_THUCHI WHERE MATHUCHI='" + this.textBox1.Text + "'", sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.textBox2.Text = "";
            //            this.textBox3.Text = "";
            //            this.textBox4.Text = "0";
            //            this.textBox5.Text = "0";
            //            this.textBox7.Text = "";
            //        }
            //        if (sqlDataReader.Read())
            //        {
            //            this.textBox4.Text = double.Parse(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0");
            //            this.maphieunhapkho = Convert.ToString(sqlDataReader.GetValue(1));
            //            this.textBox2.Text = this.maphieunhapkho;
            //            sqlConnection.Close();
            //            sqlConnection.Open();
            //            sqlCommand = new SqlCommand("SELECT ISNULL( SUM(SOLUONGQUYDOI*N.DONGIA/H.QUYDOI1),0),NHANVIEN FROM TB_HANGHOANHAP N,TB_HANGHOA H WHERE H.MAHANGHOA=N.MAHANGHOA AND MAHOADON='" + this.maphieunhapkho + "' GROUP BY NHANVIEN", sqlConnection);
            //            sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.Read())
            //            {
            //                this.textBox5.Text = double.Parse(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0");
            //                this.textBox3.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //                this.textBox2.Text = this.maphieunhapkho;
            //            }
            //            sqlConnection.Close();
            //        }
            //        this.textBox7.Focus();
            //    }
            //    else
            //    {
            //        this.textBox2.Text = "";
            //        this.textBox3.Text = "";
            //        this.textBox4.Text = "0";
            //        this.textBox5.Text = "0";
            //        this.textBox7.Text = "";
            //    }
            //}
        }

        // Token: 0x06000CC6 RID: 3270 RVA: 0x001BD9C8 File Offset: 0x001BBBC8
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != "" && this.textBox6.Text == "Mexiu@123" && double.Parse(this.textBox4.Text) > 0.0 && this.textBox7.Text != "")
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "UPDATE TB_THUCHI SET NGUOIDUYET='",
            //        this.textBox7.Text,
            //        "', NGAYDUYET='",
            //        DateTime.Now.ToString(),
            //        "' WHERE MATHUCHI='",
            //        this.textBox1.Text,
            //        "' "
            //    }), sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteReader();
            //    MessageBox.Show("DUYỆT PHIẾU THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.textBox1.Text = "";
            //    this.textBox2.Text = "";
            //    this.textBox3.Text = "";
            //    this.textBox4.Text = "0";
            //    this.textBox5.Text = "0";
            //    this.textBox1.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("ĐIỀU KIỆN DUYỆT PHIẾU KHÔNG HỢP LỆ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }

        // Token: 0x06000CC7 RID: 3271 RVA: 0x001BDB60 File Offset: 0x001BBD60
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.textBox6.Focus();
            //}
        }

        // Token: 0x06000CC8 RID: 3272 RVA: 0x001BDB8C File Offset: 0x001BBD8C
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.button1.Focus();
            //}
        }

        // Token: 0x06000CC9 RID: 3273 RVA: 0x001BDBB8 File Offset: 0x001BBDB8
        private void textBox7_Leave(object sender, EventArgs e)
        {
            //if (this.textBox7.Text != "")
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand("SELECT MANV FROM TB_NHANVIEN WHERE MANV='" + this.textBox7.Text + "'", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (!sqlDataReader.HasRows)
            //    {
            //        MessageBox.Show("MÃ NHÂN VIÊN NÀY KHÔNG TỒN TẠI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.textBox7.Focus();
            //    }
            //}
        }

        // Token: 0x06000CCA RID: 3274 RVA: 0x0001E38E File Offset: 0x0001C58E
        private void Frmduyetphieu_Load(object sender, EventArgs e)
        {
           // this.textBox1.Focus();
        }

        // Token: 0x06000CCB RID: 3275 RVA: 0x001BDC5C File Offset: 0x001BBE5C
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{
            //    this.textBox2.Text = "";
            //    this.textBox3.Text = "";
            //    this.textBox4.Text = "0";
            //    this.textBox5.Text = "0";
            //    this.textBox7.Text = "";
            //}
        }
    }
}
