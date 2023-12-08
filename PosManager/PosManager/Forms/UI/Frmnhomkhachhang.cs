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
    public partial class Frmnhomkhachhang : Form
    {
        public Frmnhomkhachhang()
        {
            InitializeComponent();
        }
        // Token: 0x06000CB2 RID: 3250 RVA: 0x001BB380 File Offset: 0x001B9580
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.textBox3.Focus();
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.textBox2.Focus();
            }
        }
        // Token: 0x06000CB3 RID: 3251 RVA: 0x001BB3AC File Offset: 0x001B95AC
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000CB4 RID: 3252 RVA: 0x001BB3D4 File Offset: 0x001B95D4
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập", "Thông báo");
            //    this.textBox1.Focus();
            //}
            //else if (this.textBox2.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập", "Thông báo");
            //    this.textBox2.Focus();
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "INSERT INTO TB_NHOMKHACHHANG (MANHOM,TENNHOM,GHICHU) VALUES('",
            //        this.textBox1.Text,
            //        "',N'",
            //        this.textBox2.Text,
            //        "',N'",
            //        this.textBox3.Text,
            //        "')"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    if (frmLogIn.fileconnect != frmLogIn.fileconnect_khachhang)
            //    {
            //        SqlConnection sqlConnection2 = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection2.Open();
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection2);
            //        sqlCommand2.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlConnection2.Close();
            //    }
            //    this.textBox1.Text = "";
            //    this.textBox1.Focus();
            //    this.textBox2.Text = "";
            //    this.textBox3.Text = "";
            //    this.LOAD();
            }
        

        // Token: 0x06000CB5 RID: 3253 RVA: 0x001BB594 File Offset: 0x001B9794
        private void LOAD()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //    SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_NHOMKHACHHANG ORDER BY MANHOM", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dataGridView1.DataSource = dataTable;
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000CB6 RID: 3254 RVA: 0x001BB614 File Offset: 0x001B9814
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
            //    if (this.dataGridView1.Columns[columnIndex].Name == "xoa")
            //    {
            //        int num = this.dataGridView1.CurrentRow.Index;
            //        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhóm đơn vị " + this.dataGridView1.Rows[num].Cells["tennhom"].Value.ToString() + "   không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            string str = this.dataGridView1.Rows[num].Cells["manhom"].Value.ToString();
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //            sqlConnection.Open();
            //            string cmdText = "DELETE TB_NHOMKHACHHANG where MANHOM='" + str + "'";
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlCommand.Dispose();
            //            sqlConnection.Close();
            //            if (frmLogIn.fileconnect != frmLogIn.fileconnect_khachhang)
            //            {
            //                SqlConnection sqlConnection2 = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                sqlConnection2.Open();
            //                SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection2);
            //                sqlCommand2.ExecuteNonQuery();
            //                sqlCommand.Dispose();
            //                sqlConnection2.Close();
            //            }
            //            this.dataGridView1.Rows.RemoveAt(num);
            //        }
            //    }
            //    if (this.dataGridView1.Columns[columnIndex].Name == "Chon")
            //    {
            //        if (this.dataGridView1.RowCount > 0)
            //        {
            //            Frmnhomkhachhang.index = this.dataGridView1.CurrentRow.Index;
            //            Frmnhomkhachhang.tendonvi = this.dataGridView1.Rows[Frmnhomkhachhang.index].Cells["tennhom"].Value.ToString();
            //            Frmnhomkhachhang.madonvi = this.dataGridView1.Rows[Frmnhomkhachhang.index].Cells["manhom"].Value.ToString();
            //            Frmnhomkhachhang.nhomkhachhang = "ok";
            //        }
            //       // base.Close();
            //    }
            //}
        }

        // Token: 0x06000CB7 RID: 3255 RVA: 0x001BB8A8 File Offset: 0x001B9AA8
        private void Frmnhomkhachhang_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 873) / 2, 0, 873, Screen.PrimaryScreen.WorkingArea.Height + 10);
            this.LOAD();
        }

        // Token: 0x06000CB8 RID: 3256 RVA: 0x001BB8FC File Offset: 0x001B9AFC
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dataGridView1.RowCount > 0)
                {
                    Frmnhomkhachhang.index = this.dataGridView1.CurrentRow.Index;
                    Frmnhomkhachhang.tendonvi = this.dataGridView1.Rows[Frmnhomkhachhang.index].Cells["tennhom"].Value.ToString();
                    Frmnhomkhachhang.madonvi = this.dataGridView1.Rows[Frmnhomkhachhang.index].Cells["manhom"].Value.ToString();
                    Frmnhomkhachhang.nhomkhachhang = "ok";
                }
               // base.Close();
            }
            catch
            {
            }
        }
    }
}

