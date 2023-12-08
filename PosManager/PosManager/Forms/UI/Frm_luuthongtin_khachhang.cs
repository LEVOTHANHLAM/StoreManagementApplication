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
    public partial class Frm_luuthongtin_khachhang : Form
    {
        public Frm_luuthongtin_khachhang()
        {
            InitializeComponent();
        }
        private void load_kh()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT MANHOM,SDT,TENKHACHHANG,SUM(SOTIEN) AS TONGTIEN FROM TB_KH_NHOMSUA WHERE MANHOM='" + this.Manhom + "' GROUP BY MANHOM,SDT,TENKHACHHANG", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
        }

        // Token: 0x06000037 RID: 55 RVA: 0x00020E54 File Offset: 0x0001F054
        public void bt_Click(object sender, EventArgs e)
        {
            if (this.them == 1)
            {
                this.textBox2.Text = ((Button)sender).Text;
            }
            this.Manhom = ((Button)sender).Name;
            this.load_kh();
        }

        // Token: 0x06000038 RID: 56 RVA: 0x00020EA4 File Offset: 0x0001F0A4
        public void loadNhom()
        {
            //this.flnhom.Controls.Clear();
            //this.tableLayoutPanel1.BringToFront();
            //List<NhomHang> list = NhomhangDAO.Instence.LoadtableList();
            //foreach (NhomHang nhomHang in list)
            //{
            //    Button button = new Button
            //    {
            //        Width = (this.flnhom.Width - 20) / 2,
            //        Height = NhomhangDAO.TableHeight
            //    };
            //    button.Text = nhomHang.Name;
            //    button.Name = nhomHang.Id;
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.BackColor = Color.Blue;
            //    button.ForeColor = Color.White;
            //    button.Click += this.bt_Click;
            //    this.flnhom.Controls.Add(button);
            //}
        }

        // Token: 0x06000039 RID: 57 RVA: 0x00020FC0 File Offset: 0x0001F1C0
        private void Frm_luuthongtin_khachhang_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height);
            this.loadNhom();
        }

        // Token: 0x0600003A RID: 58 RVA: 0x00021010 File Offset: 0x0001F210
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "SELECT K.SDT,D.THANHTOAN,K.TENKHACHHANG FROM TB_HOADONBANHANG D, Tb_KHACHHANG K WHERE D.MAKHACHHANG=K.MAKHACHHANG AND SOHOADON='" + this.textBox1.Text + "' AND HUYHD='FALSE'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (!sqlDataReader.HasRows)
            //    {
            //        MessageBox.Show("KHÔNG TÌM THẤY HÓA ĐƠN NÀY", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        this.textBox1.Focus();
            //    }
            //    if (sqlDataReader.Read())
            //    {
            //        if (this.Manhom != "")
            //        {
            //            SqlCommand sqlCommand2 = new SqlCommand(string.Concat(new string[]
            //            {
            //                "INSERT INTO TB_KH_NHOMSUA VALUES ('",
            //                this.Manhom,
            //                "','",
            //                Convert.ToString(sqlDataReader.GetValue(0)),
            //                "',N'",
            //                Convert.ToString(sqlDataReader.GetValue(2)),
            //                "','",
            //                Convert.ToString(sqlDataReader.GetValue(1)),
            //                "' )"
            //            }), sqlConnection);
            //            sqlConnection.Close();
            //            sqlConnection.Open();
            //            sqlCommand2.ExecuteNonQuery();
            //            this.load_kh();
            //            this.Manhom = "";
            //        }
            //        else
            //        {
            //            MessageBox.Show("BẠN CHƯA CHỌN NHÓM", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //            this.textBox1.Focus();
            //        }
            //    }
            //}
        }

        // Token: 0x0600003B RID: 59 RVA: 0x000211B0 File Offset: 0x0001F3B0
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Visible = true;
            this.button3.Visible = true;
            this.them = 0;
            this.textBox2.Text = "";
            this.textBox2.Focus();
        }

        // Token: 0x0600003C RID: 60 RVA: 0x000211FC File Offset: 0x0001F3FC
        private void button3_Click(object sender, EventArgs e)
        {
            //if (this.textBox2.Text != "")
            //{
            //    if (this.them == 0)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand("INSERT INTO TB_NHOMSUA VALUES (N'" + this.textBox2.Text + "')", sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "UPDATE TB_NHOMSUA SET NOIDUNG= N'",
            //            this.textBox2.Text,
            //            "' WHERE ID='",
            //            this.Manhom,
            //            "'"
            //        }), sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    this.loadNhom();
            //}
            //this.them = 0;
            //this.textBox2.Text = "";
        }

        // Token: 0x0600003D RID: 61 RVA: 0x0001B5EE File Offset: 0x000197EE
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Visible = true;
            this.button3.Visible = true;
            this.them = 1;
            this.textBox2.Focus();
        }
        private string Manhom = "";

        // Token: 0x0400002D RID: 45
        private int them = 0;
    }
}
