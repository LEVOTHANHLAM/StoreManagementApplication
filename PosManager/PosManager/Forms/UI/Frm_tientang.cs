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
    public partial class Frm_tientang : Form
    {
        public Frm_tientang()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //double num = double.Parse(this.txtdiem.Text);
            //if (this.txttenkhachhang.Text != this.txttenkhachhang.Tag.ToString() && this.txtdiem.Text != "0")
            //{
            //    if (this.comboBox1.SelectedIndex == 0)
            //    {
            //        num = -double.Parse(this.txtdiem.Text);
            //    }
            //    string text = "";
            //    if (this.txtghichu.Text != this.txtghichu.Tag.ToString())
            //    {
            //        text = this.txtghichu.Text;
            //    }
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //    sqlConnection.Open();
            //    if (sqlConnection.State == ConnectionState.Closed)
            //    {
            //        sqlConnection.Open();
            //    }
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
            //    {
            //        " INSERT INTO TB_TIENKHUYENMAI(MAKHACHHANG,SOTIEN,NGAY,GHICHU)VALUES ('",
            //        this.txtmakh.Text,
            //        "', '",
            //        num,
            //        "','",
            //        DateTime.Now.ToString("dd/MM/yyyy"),
            //        "',N'",
            //        text,
            //        "')"
            //    }), sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand.Dispose();
            //    sqlConnection.Close();
            //    this.loadtien_kh();
            //    MessageBox.Show("THỰC HIỆN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }

        // Token: 0x0600014D RID: 333 RVA: 0x0002FC4C File Offset: 0x0002DE4C
        private void loadtien_kh()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //sqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlCommand selectCommand = new SqlCommand("SELECT NGAY,SOTIEN,GHICHU FROM TB_TIENKHUYENMAI WHERE MAKHACHHANG='" + this.txtmakh.Text.Trim() + "' ORDER BY CONVERT(DATETIME,NGAY,103)", sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvdiem.DataSource = dataTable;
            //sqlConnection.Close();
            //this.dgvdiem.BringToFront();
            //this.btsotien.Text = "0";
            //double num = 0.0;
            //for (int i = 0; i < this.dgvdiem.RowCount; i++)
            //{
            //    num += double.Parse(this.dgvdiem.Rows[i].Cells["sotien"].Value.ToString());
            //}
            //this.btsotien.Text = num.ToString("#,##0");
        }

        // Token: 0x0600014E RID: 334 RVA: 0x0002FD74 File Offset: 0x0002DF74
        private void loadtien(string dk)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //sqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlCommand selectCommand = new SqlCommand("SELECT KH.TENKHACHHANG,SUM( SOTIEN) AS SOTIEN,'' AS GHICHU FROM TB_TIENKHUYENMAI T, TB_KHACHHANG KH WHERE T.MAKHACHHANG=KH.MAKHACHHANG GROUP BY KH.TENKHACHHANG " + dk + " ORDER BY SUM(SOTIEN)", sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtien.DataSource = dataTable;
            //sqlConnection.Close();
            //this.dgvtien.BringToFront();
            //this.btsotien.Text = "0";
            //double num = 0.0;
            //for (int i = 0; i < this.dgvtien.RowCount; i++)
            //{
            //    num += double.Parse(this.dgvtien.Rows[i].Cells["sotien2"].Value.ToString());
            //}
            //this.btsotien.Text = num.ToString("#,##0");
        }

        // Token: 0x0600014F RID: 335 RVA: 0x0002FE8C File Offset: 0x0002E08C
        private void Frm_tientang_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            this.comboBox1.SelectedIndex = 0;
            this.button1_Click(null, null);
        }

        // Token: 0x06000150 RID: 336 RVA: 0x0002FEEC File Offset: 0x0002E0EC
        private void txtghichu_Leave(object sender, EventArgs e)
        {
            if (this.txtghichu.Text == "")
            {
                this.txtghichu.Text = this.txtghichu.Tag.ToString();
            }
        }

        // Token: 0x06000151 RID: 337 RVA: 0x0002FF34 File Offset: 0x0002E134
        private void txtghichu_Enter(object sender, EventArgs e)
        {
            if (this.txtghichu.Text == this.txtghichu.Tag.ToString())
            {
                this.txtghichu.Text = "";
            }
        }

        // Token: 0x06000152 RID: 338 RVA: 0x0002FF7C File Offset: 0x0002E17C
        private void button2_Click(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //this.txtmakh.Text = Frmkhachhang.makhachhang;
            //this.txtdiem.Focus();
        }

        // Token: 0x06000153 RID: 339 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            //if (this.txtmakh.Text != this.txtmakh.Tag.ToString())
            //{
            //    if (this.txtmakh.Text != "")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        string cmdText = "select TENKHACHHANG from tb_khachhang WHERE makhachhang=N'" + this.txtmakh.Text + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txttenkhachhang.Text = sqlDataReader.GetString(0);
            //            this.loadtien_kh();
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txttenkhachhang.Text = this.txttenkhachhang.Tag.ToString();
            //        }
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.txttenkhachhang.Text = this.txttenkhachhang.Tag.ToString();
            //    }
            //}
        }

        // Token: 0x06000154 RID: 340 RVA: 0x0001BA97 File Offset: 0x00019C97
        private void button1_Click(object sender, EventArgs e)
        {
            this.loadtien("");
        }

        // Token: 0x06000155 RID: 341 RVA: 0x000300DC File Offset: 0x0002E2DC
        private void txtmakh_Leave(object sender, EventArgs e)
        {
            if (this.txtmakh.Text == "")
            {
                this.txtmakh.Text = this.txtmakh.Tag.ToString();
            }
        }

        // Token: 0x06000156 RID: 342 RVA: 0x00030124 File Offset: 0x0002E324
        private void txtmakh_Enter(object sender, EventArgs e)
        {
            if (this.txtmakh.Text == this.txtmakh.Tag.ToString())
            {
                this.txtmakh.Text = "";
            }
        }

        // Token: 0x06000157 RID: 343 RVA: 0x0001BAA6 File Offset: 0x00019CA6
        private void button4_Click(object sender, EventArgs e)
        {
            this.loadtien("  HAVING SUM( SOTIEN)  >0");
        }
    }
}
