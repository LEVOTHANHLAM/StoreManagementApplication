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
    public partial class Frm_kho : Form
    {
        public Frm_kho()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (e.ColumnIndex == this.xoa.Index)
            //    {
            //        if (frmLogIn.MADANGNHAP == "ADMIN")
            //        {
            //            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn " + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["TENKHO"].Value.ToString() + " không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //            if (dialogResult == DialogResult.Yes)
            //            {
            //                SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                sqlConnection.Open();
            //                string cmdText = "DELETE TB_KHO WHERE MAKHO='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MAKHO"].Value.ToString() + "'";
            //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x0600057A RID: 1402 RVA: 0x0011137C File Offset: 0x0010F57C
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtmakho.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập mã kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtmakho.Focus();
            //}
            //else if (this.txttenkho.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập tên kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtmakho.Focus();
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE TB_KHO WHERE MAKHO='",
            //        this.txtmakho.Text,
            //        "' INSERT INTO TB_KHO (MAKHO,TENKHO) VALUES (N'",
            //        this.txtmakho.Text.Trim(),
            //        "',N'",
            //        this.txttenkho.Text.Trim(),
            //        "')"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.LOAD_KHO();
            //    this.txtmakho.Text = "";
            //    this.txttenkho.Text = "";
            //    this.txtmakho.Focus();
            //}
        }

        // Token: 0x0600057B RID: 1403 RVA: 0x001114E4 File Offset: 0x0010F6E4
        private void LOAD_KHO()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_KHO ORDER BY MAKHO", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
        }

        // Token: 0x0600057C RID: 1404 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
        private void Frm_kho_Load(object sender, EventArgs e)
        {
            this.LOAD_KHO();
            this.txtmakho.Focus();
        }

    }
}
