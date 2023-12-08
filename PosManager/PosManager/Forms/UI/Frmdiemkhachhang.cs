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
    public partial class Frmdiemkhachhang : Form
    {

        public Frmdiemkhachhang()
        {
            InitializeComponent();
            tudongcapnhattendonvi();
        }
      
        // Token: 0x06000759 RID: 1881 RVA: 0x00142F14 File Offset: 0x00141114
        private void tudongcapnhattendonvi()
        {
            //this.textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //string cmdText = "Select tendonvi from Tb_khachhang";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.textBox1.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x0600075A RID: 1882 RVA: 0x00142FB0 File Offset: 0x001411B0
        private void Frmdiemkhachhang_Load(object sender, EventArgs e)
        {
            //this.dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 938) / 2, 0, 938, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.comboBox1.SelectedIndex = 1;
            //this.button2_Click(null, null);
        }

        // Token: 0x0600075B RID: 1883 RVA: 0x00143030 File Offset: 0x00141230
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{
            //    this.textBox1.Text = this.textBox1.Tag.ToString();
            //}
            //this.textBox1.BackColor = Color.White;
        }

        // Token: 0x0600075C RID: 1884 RVA: 0x0001CE0A File Offset: 0x0001B00A
        private void textBox1_Enter(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            //this.textBox1.BackColor = Color.Yellow;
        }

        // Token: 0x0600075D RID: 1885 RVA: 0x00143088 File Offset: 0x00141288
        private void btthuchien_Click(object sender, EventArgs e)
        {
            //if (double.Parse(this.txtdiem.Text) > 0.0)
            //{
            //    if (this.txttenkhachhang.Text != this.txttenkhachhang.Tag.ToString())
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string text = "";
            //        if (this.txtghichu.Text != this.txtghichu.Tag.ToString())
            //        {
            //            text = this.txtghichu.Text;
            //        }
            //        string text2 = DateTime.Now.ToString("ddMMyyyyHHmmss");
            //        string cmdText;
            //        if (this.comboBox1.SelectedIndex == 0)
            //        {
            //            cmdText = string.Concat(new object[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_DIEMKM]\r\n           ([MAHOADON] ,[MAKHACHHANG]   ,[NGAY]  ,[SOTIEN]  ,[SOLUONG]   ,[DIEMCONG]    ,[DIEMTRU]  ,[DIEM],GHICHU) VALUES ('",
            //                text2,
            //                "','",
            //                this.textBox1.Text,
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
            //                this.textBox1.Text,
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
            //        MessageBox.Show("THỰC HIỆN XONG", "THÔNG BÁO");
            //        this.button1_Click(null, null);
            //        for (int i = 0; i < this.dgvdiem.Rows.Count; i++)
            //        {
            //            if (this.dgvdiem["MAHOADON", i].Value.ToString() == text2)
            //            {
            //                this.dgvdiem.ClearSelection();
            //                this.dgvdiem.Rows[i].Selected = true;
            //                this.dgvdiem.CurrentCell = this.dgvdiem.Rows[i].Cells["MAHOADON"];
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("BẠN CHƯA CHỌN KHÁCH HÀNG", "THÔNG BÁO");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ĐIỂM PHẢI LỚN HƠN 0", "THÔNG BÁO");
            //}
        }

        // Token: 0x0600075E RID: 1886 RVA: 0x00143400 File Offset: 0x00141600
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != this.textBox1.Tag.ToString())
            //{
            //    if (this.textBox1.Text != "")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        string cmdText = "select TENDONVI,DIACHI,SDT from tb_khachhang WHERE makhachhang=N'" + this.textBox1.Text + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txttenkhachhang.Text = sqlDataReader.GetString(0);
            //            this.button1_Click(null, null);
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

        // Token: 0x0600075F RID: 1887 RVA: 0x00143528 File Offset: 0x00141728
        private void tudongloadkhachhang()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //string cmdText = string.Concat(new string[]
            //{
            //    "select MAKHACHHANG,TENDONVI+' '+SDT AS TENDONVI from tb_khachhang WHERE makhachhang=N'",
            //    this.textBox1.Text,
            //    "' or Tendonvi =N'",
            //    this.textBox1.Text,
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.textBox1.Text = sqlDataReader.GetString(0);
            //    this.txtdiem.Focus();
            //    this.button1_Click(null, null);
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000760 RID: 1888 RVA: 0x001435F4 File Offset: 0x001417F4
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.tudongloadkhachhang();
            }
        }

        // Token: 0x06000761 RID: 1889 RVA: 0x0014361C File Offset: 0x0014181C
        private void button1_Click(object sender, EventArgs e)
        {
            //this.dgvdiem.BringToFront();
            //if (this.txttenkhachhang.Text != this.txttenkhachhang.Tag.ToString())
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "SELECT D.MAHOADON,D.NGAY,D.DIEM,D.DIEMCONG,D.DIEMTRU,ISNULL(D.GHICHU,'') AS GHICHU FROM TB_DIEMKM D WHERE D.MAKHACHHANG='",
            //        this.textBox1.Text,
            //        "' AND CONVERT(DATETIME,D.NGAY,103)<='23:59 ",
            //        Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        this.dgvdiem.DataSource = dataTable;
            //        double num = 0.0;
            //        for (int i = 0; i < this.dgvdiem.RowCount; i++)
            //        {
            //            num += Convert.ToDouble(this.dgvdiem.Rows[i].Cells["diem"].Value.ToString()) + Convert.ToDouble(this.dgvdiem.Rows[i].Cells["diemcong"].Value.ToString()) - Convert.ToDouble(this.dgvdiem.Rows[i].Cells["diemtru"].Value.ToString());
            //        }
            //        this.txttongdiem.Text = num.ToString("#,###.##");
            //    }
            //    else
            //    {
            //        this.txttongdiem.Text = "0";
            //    }
            //}
        }

        // Token: 0x06000762 RID: 1890 RVA: 0x00143820 File Offset: 0x00141A20
        private void button2_Click(object sender, EventArgs e)
        {
            //this.dgvtonghop.BringToFront();
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT D.MAKHACHHANG,KH.TENDONVI, ISNULL(SUM(D.DIEM),0)AS DIEM, ISNULL(SUM(D.DIEMCONG),0)AS DIEMCONG, ISNULL(SUM(D.DIEMTRU),0)AS DIEMTRU, ISNULL(SUM(D.DIEM+D.DIEMCONG-D.DIEMTRU),0)AS TONGDIEM FROM TB_DIEMKM D ,TB_KHACHHANG KH WHERE D.MAKHACHHANG=KH.MAKHACHHANG AND CONVERT(DATETIME,D.NGAY,103)<='23:59 " + Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy") + "' GROUP BY D.MAKHACHHANG,KH.TENDONVI";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    this.dgvtonghop.DataSource = dataTable;
            //    double num = 0.0;
            //    for (int i = 0; i < this.dgvtonghop.RowCount; i++)
            //    {
            //        num += Convert.ToDouble(this.dgvtonghop.Rows[i].Cells["tongdiem"].Value.ToString()) + Convert.ToDouble(this.dgvtonghop.Rows[i].Cells["tongdiemcong"].Value.ToString()) - Convert.ToDouble(this.dgvtonghop.Rows[i].Cells["tongdiemtru"].Value.ToString());
            //    }
            //    this.txttongdiem.Text = num.ToString("#,###.##");
            //}
            //else
            //{
            //    this.txttongdiem.Text = "0";
            //}
        }

        // Token: 0x06000763 RID: 1891 RVA: 0x001439C8 File Offset: 0x00141BC8
        private void dgvtonghop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvtonghop.RowCount > 0)
            //{
            //    int index = this.dgvtonghop.CurrentRow.Index;
            //    this.textBox1.Text = this.dgvtonghop.Rows[index].Cells["makhachhang"].Value.ToString();
            //    this.button1_Click(null, null);
            //}
        }

        // Token: 0x06000764 RID: 1892 RVA: 0x0001CE2F File Offset: 0x0001B02F
        private void GETMAKH(string Makh, string tenkh, string diachi, string sdt)
        {
            //this.textBox1.Text = Makh;
            //this.txttenkhachhang.Text = tenkh;
        }

        // Token: 0x06000765 RID: 1893 RVA: 0x00143A40 File Offset: 0x00141C40
        private void button3_Click(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //Frmkhachhang.chon = "1";
            //frmkhachhang.MaKH = new Frmkhachhang.GetData(this.GETMAKH);
            //frmkhachhang.ShowDialog();
            //this.txtdiem.Focus();
        }

        // Token: 0x06000766 RID: 1894 RVA: 0x0001CE4C File Offset: 0x0001B04C
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //this.txtdiem.Focus();
        }

        // Token: 0x06000767 RID: 1895 RVA: 0x00143A84 File Offset: 0x00141C84
        private void txtghichu_Leave(object sender, EventArgs e)
        {
            //if (this.txtghichu.Text == "")
            //{
            //    this.txtghichu.Text = this.txtghichu.Tag.ToString();
            //}
        }

        // Token: 0x06000768 RID: 1896 RVA: 0x00143ACC File Offset: 0x00141CCC
        private void txtghichu_Enter(object sender, EventArgs e)
        {
            //if (this.txtghichu.Text == this.txtghichu.Tag.ToString())
            //{
            //    this.txtghichu.Text = "";
            //}
        }

        // Token: 0x06000769 RID: 1897 RVA: 0x00143B14 File Offset: 0x00141D14
        private void txtdiem_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtghichu.Focus();
            //}
        }

    }
}
