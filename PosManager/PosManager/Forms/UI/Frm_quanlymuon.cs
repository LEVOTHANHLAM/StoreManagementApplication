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
    public partial class Frm_quanlymuon : Form
    {
        public Frm_quanlymuon()
        {
            InitializeComponent();
        }
        private void loadtra_muon(string dk1, string dk2, string dk3)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "SELECT MADONHANG,TENNCC,NGAY,NOIDUNGMUON,ISNULL(NGAYTRA,'')AS NGAYTRA,NOIDUNGTRA FROM TB_DONHANGCONGNO_MUON WHERE ",
            //    dk1,
            //    " ",
            //    dk2,
            //    " ",
            //    dk3
            //}), sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
        }

        // Token: 0x060011E9 RID: 4585 RVA: 0x00123DDC File Offset: 0x00121FDC
        private void button2_Click(object sender, EventArgs e)
        {
            //Frmkhachhang.chon = "nk";
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
        }

        // Token: 0x060011EA RID: 4586 RVA: 0x00207EF4 File Offset: 0x002060F4
        private void button5_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    if (TrangChu.XOANHAP == "True")
            //    {
            //        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn " + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["TEN"].Value.ToString() + " không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //            SqlCommand sqlCommand = new SqlCommand("DELETE FROM TB_DONHANGCONGNO_MUON WHERE MADONHANG='" + this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString() + "'", sqlConnection);
            //            sqlConnection.Open();
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("BẠN KHÔNG ĐƯỢC PHÉP XÓA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
        }

        // Token: 0x060011EB RID: 4587 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
        private void button4_Click(object sender, EventArgs e)
        {
            this.loadtra_muon("NGAYTRA!=''", "", " ORDER BY CONVERT(DATETIME,NGAYTRA,103) DESC");
        }

        // Token: 0x060011EC RID: 4588 RVA: 0x0001F5E1 File Offset: 0x0001D7E1
        private void button6_Click(object sender, EventArgs e)
        {
            this.loadtra_muon("NGAYTRA=''", "", " ORDER BY CONVERT(DATETIME,NGAY,103)");
        }

        // Token: 0x060011ED RID: 4589 RVA: 0x00208040 File Offset: 0x00206240
        private void button3_Click(object sender, EventArgs e)
        {
            this.loadtra_muon("", string.Concat(new string[]
            {
                "CONVERT(DATETIME, NGAY,103)>='",
                Convert.ToDateTime(this.dt1.Text).ToString("MM/dd/yyyy 00:00"),
                "' AND CONVERT(DATETIME, NGAY,103)<='",
                Convert.ToDateTime(this.dt2.Text).ToString("MM/dd/yyyy 23:59"),
                "'"
            }), " ORDER BY CONVERT(DATETIME,NGAY,103)");
        }

        // Token: 0x060011EE RID: 4590 RVA: 0x002080C4 File Offset: 0x002062C4
        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_themmuon.themmoi = 0;
            //Frm_themmuon frm_themmuon = new Frm_themmuon();
            //frm_themmuon.ShowDialog();
            //this.button6_Click(null, null);
        }

        // Token: 0x060011EF RID: 4591 RVA: 0x002080F0 File Offset: 0x002062F0
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (this.dataGridView1.RowCount > 0)
            //    {
            //        int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
            //        if (this.dataGridView1.Columns[columnIndex].Name == "ngaytra")
            //        {
            //            if (this.dataGridView1.CurrentRow.Cells["ngaytra"].Value.ToString() == "")
            //            {
            //                Frm_themmuon.maso = this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString();
            //                Frm_themmuon.nd = this.dataGridView1.CurrentRow.Cells["nd"].Value.ToString();
            //                Frm_themmuon.ten = this.dataGridView1.CurrentRow.Cells["ten"].Value.ToString();
            //                Frm_themmuon.themmoi = 1;
            //                Frm_themmuon frm_themmuon = new Frm_themmuon();
            //                frm_themmuon.ShowDialog();
            //                this.button4_Click(null, null);
            //            }
            //        }
            //        else if (this.dataGridView1.Columns[columnIndex].Name == "Hinh")
            //        {
            //            Frm_phonghinhcongno.mahang = "Select HINH FROM TB_DONHANGCONGNO_MUON WHERE MADONHANG ='" + this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString() + "'";
            //            Frm_phonghinhcongno frm_phonghinhcongno = new Frm_phonghinhcongno();
            //            frm_phonghinhcongno.ShowDialog();
            //        }
            //        else if (this.dataGridView1.Columns[columnIndex].Name == "hinhtra" && this.dataGridView1.CurrentRow.Cells["ngaytra"].Value.ToString() != "")
            //        {
            //            Frm_phonghinhcongno.mahang = "Select HINHTRA FROM TB_DONHANGCONGNO_MUON WHERE MADONHANG ='" + this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString() + "'";
            //            Frm_phonghinhcongno frm_phonghinhcongno = new Frm_phonghinhcongno();
            //            frm_phonghinhcongno.ShowDialog();
            //        }
            //    }
            //}
        }

        // Token: 0x060011F0 RID: 4592 RVA: 0x00208354 File Offset: 0x00206554
        private void Frm_quanlymuon_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            this.button6_Click(null, null);
        }

        // Token: 0x060011F1 RID: 4593 RVA: 0x002083A8 File Offset: 0x002065A8
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != "")
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //    SqlCommand selectCommand = new SqlCommand("SELECT MADONHANG,TENNCC,NGAY,NOIDUNGMUON,ISNULL(NGAYTRA,'')AS NGAYTRA,NOIDUNGTRA FROM TB_DONHANGCONGNO_MUON WHERE TENNCC LIKE N'%" + this.textBox1.Text + "%' ", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dataGridView1.DataSource = dataTable;
            //}
        }
    }
}
