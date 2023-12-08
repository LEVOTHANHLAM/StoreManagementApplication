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
    public partial class FRM_QUANLYCONGNO : Form
    {
        public FRM_QUANLYCONGNO()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Frmkhachhang.chon = "nk";
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
        }

        // Token: 0x06000641 RID: 1601 RVA: 0x00123E04 File Offset: 0x00122004
        private void load_congno_ncc()
        {
            //if (this.textBox3.Text != this.textBox3.Tag.ToString())
            //{
            //    if (this.textBox3.Text != "")
            //    {
            //        DataTable dataTable = new DataTable();
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "SELECT CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[SOTIENNO],CN.[NGAY],SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENTRA ,CN.[SOTIENNO]-SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENCONNO FROM TB_DONHANGCONGNO CN LEFT JOIN TB_CHITETQUANLYCONGNO CT ON CN.MADONHANG =CT.MADONHANG WHERE MANCC LIKE '%",
            //            this.textBox3.Text.Trim(),
            //            "%' OR TENNCC LIKE N'%",
            //            this.textBox3.Text.Trim(),
            //            "%' GROUP BY CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[NGAY],CN.[SOTIENNO]"
            //        }), sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dataGridView1.DataSource = dataTable;
            //        if (this.dataGridView1.RowCount > 0)
            //        {
            //            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //            {
            //                if (decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENNO"].Value.ToString()) > 0m)
            //                {
            //                    this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Thanh Toán";
            //                }
            //                else
            //                {
            //                    this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Đã trả hết";
            //                }
            //            }
            //            this.load_donhang(this.dataGridView1.Rows[0].Cells["MADONHANG"].Value.ToString());
            //        }
            //        sqlConnection.Close();
            //        this.loadtongcong();
            //    }
            //}
        }

        // Token: 0x06000642 RID: 1602 RVA: 0x00124024 File Offset: 0x00122224
        private void load_congno()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[SOTIENNO],CN.[NGAY],SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENTRA ,CN.[SOTIENNO]-SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENCONNO FROM TB_DONHANGCONGNO CN LEFT JOIN TB_CHITETQUANLYCONGNO CT ON CN.MADONHANG =CT.MADONHANG GROUP BY CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[NGAY],CN.[SOTIENNO]", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        if (decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENNO"].Value.ToString()) > 0m)
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Thanh Toán";
            //        }
            //        else
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Đã trả hết";
            //        }
            //    }
            //    this.load_donhang(this.dataGridView1.Rows[0].Cells["MADONHANG"].Value.ToString());
            //}
            //sqlConnection.Close();
            //this.loadtongcong();
        }

        // Token: 0x06000643 RID: 1603 RVA: 0x001241A8 File Offset: 0x001223A8
        private void load_congno_theongay()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "SELECT CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[SOTIENNO],CN.[NGAY],SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENTRA ,CN.[SOTIENNO]-SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENCONNO FROM TB_DONHANGCONGNO CN LEFT JOIN TB_CHITETQUANLYCONGNO CT ON CN.MADONHANG =CT.MADONHANG WHERE CONVERT(DATETIME,NGAY,103)>='",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("00:00 MM/dd/yyyy"),
            //    "' AND CONVERT(DATETIME,NGAY,103)<='",
            //    Convert.ToDateTime(this.dateTimePicker2.Text).ToString("23:59 MM/dd/yyyy"),
            //    "' GROUP BY CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[NGAY],CN.[SOTIENNO]"
            //}), sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        if (decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENNO"].Value.ToString()) > 0m)
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Thanh Toán";
            //        }
            //        else
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Đã trả hết";
            //        }
            //    }
            //    this.load_donhang(this.dataGridView1.Rows[0].Cells["MADONHANG"].Value.ToString());
            //}
            //sqlConnection.Close();
            //this.loadtongcong();
        }

        // Token: 0x06000644 RID: 1604 RVA: 0x00124394 File Offset: 0x00122594
        private void load_congno_theoma()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[SOTIENNO],CN.[NGAY],SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENTRA ,CN.[SOTIENNO]-SUM(ISNULL(CT.SOTIENTRA,0)) AS SOTIENCONNO FROM TB_DONHANGCONGNO CN LEFT JOIN TB_CHITETQUANLYCONGNO CT ON CN.MADONHANG =CT.MADONHANG WHERE CN.MADONHANG='" + this.textBox1.Text + "' GROUP BY CN.[MADONHANG],CN.[MANCC],CN.[TENNCC],CN.[NGAY],CN.[SOTIENNO]", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        if (decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENNO"].Value.ToString()) > 0m)
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Thanh Toán";
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Style.BackColor = Color.RoyalBlue;
            //        }
            //        else
            //        {
            //            this.dataGridView1.Rows[i].Cells["trangthai"].Value = "Đã trả hết";
            //        }
            //    }
            //    this.load_donhang(this.dataGridView1.Rows[0].Cells["MADONHANG"].Value.ToString());
            //    this.dataGridView3.Rows.Add(1);
            //    this.dataGridView3.Rows[0].Cells["TTNO"].Value = "0";
            //    this.dataGridView3.Rows[0].Cells["TTTRA"].Value = "0";
            //    this.dataGridView3.Rows[0].Cells["TTCON"].Value = "0";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000645 RID: 1605 RVA: 0x001245E8 File Offset: 0x001227E8
        private void load_donhang(string madon)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT NGAYTHANHTOAN, SOTIENTRA FROM TB_CHITETQUANLYCONGNO WHERE MADONHANG='" + madon + "'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView2.DataSource = dataTable;
            //if (dataTable.Rows.Count == 0)
            //{
            //    this.dataGridView2.Visible = false;
            //}
            //else
            //{
            //    this.dataGridView2.Visible = true;
            //}
        }

        // Token: 0x06000646 RID: 1606 RVA: 0x00124688 File Offset: 0x00122888
        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_themdonhangcongno.taomoi = 0;
            //Frm_themdonhangcongno frm_themdonhangcongno = new Frm_themdonhangcongno();
            //frm_themdonhangcongno.ShowDialog();
            //this.load_congno();
        }

        // Token: 0x06000647 RID: 1607 RVA: 0x0001CAFE File Offset: 0x0001ACFE
        private void button3_Click(object sender, EventArgs e)
        {
            this.load_congno_theongay();
        }

        // Token: 0x06000648 RID: 1608 RVA: 0x001246B0 File Offset: 0x001228B0
        private void loadtongcong()
        {
            //if (TrangChu.XOANHAP == "True")
            //{
            //    if (this.dataGridView1.RowCount > 0)
            //    {
            //        this.dataGridView3.Rows.Add(1);
            //        this.dataGridView3.Rows[0].Cells["TTNO"].Value = "0";
            //        this.dataGridView3.Rows[0].Cells["TTTRA"].Value = "0";
            //        this.dataGridView3.Rows[0].Cells["TTCON"].Value = "0";
            //        this.dataGridView3.Visible = true;
            //        decimal d = 0m;
            //        decimal d2 = 0m;
            //        decimal d3 = 0m;
            //        for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //        {
            //            d3 += decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENNO"].Value.ToString());
            //            d2 += decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENTRA"].Value.ToString());
            //            d += decimal.Parse(this.dataGridView1.Rows[i].Cells["SOTIENCONGNO"].Value.ToString());
            //        }
            //        this.dataGridView3.Rows[0].Cells["TTNO"].Value = d.ToString("#,##0");
            //        this.dataGridView3.Rows[0].Cells["TTTRA"].Value = d2.ToString("#,##0");
            //        this.dataGridView3.Rows[0].Cells["TTCON"].Value = d3.ToString("#,##0");
            //        this.dataGridView3.Rows[0].Cells["TT"].Value = "TỔNG CỘNG";
            //    }
            //    else
            //    {
            //        this.dataGridView3.Rows.Add(1);
            //        this.dataGridView3.Rows[0].Cells["TTNO"].Value = "0";
            //        this.dataGridView3.Rows[0].Cells["TTTRA"].Value = "0";
            //        this.dataGridView3.Rows[0].Cells["TTCON"].Value = "0";
            //    }
            //}
        }

        // Token: 0x06000649 RID: 1609 RVA: 0x001249D0 File Offset: 0x00122BD0
        private void FRM_QUANLYCONGNO_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 10);
            this.load_congno();
            this.textBox1.Focus();
        }

        // Token: 0x0600064A RID: 1610 RVA: 0x0001CB08 File Offset: 0x0001AD08
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.load_congno_theoma();
        }

        // Token: 0x0600064B RID: 1611 RVA: 0x00124A30 File Offset: 0x00122C30
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                //this.load_donhang(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MADONHANG"].Value.ToString());
                //if (this.dataGridView1.Columns[this.dataGridView1.CurrentCell.ColumnIndex].Name == "trangthai" && decimal.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["SOTIENNO"].Value.ToString()) > 0m)
                //{
                //    Frm_themdonhangcongno.madonhang = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MADONHANG"].Value.ToString();
                //    Frm_themdonhangcongno.taomoi = 2;
                //    Frm_themdonhangcongno.sotienno = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["SOTIENNO"].Value.ToString();
                //    Frm_themdonhangcongno.tenncc = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["TENNCC"].Value.ToString();
                //    Frm_themdonhangcongno.mancc = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MANCC"].Value.ToString();
                //    Frm_themdonhangcongno frm_themdonhangcongno = new Frm_themdonhangcongno();
                //    frm_themdonhangcongno.ShowDialog();
                //    this.button4_Click(null, null);
                //}
            }
        }

        // Token: 0x0600064C RID: 1612 RVA: 0x0001CB12 File Offset: 0x0001AD12
        private void button4_Click(object sender, EventArgs e)
        {
            this.load_congno();
        }

        // Token: 0x0600064D RID: 1613 RVA: 0x00124C38 File Offset: 0x00122E38
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                //if (TrangChu.XOANHAP == "True")
                //{
                //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn " + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MADONHANG"].Value.ToString() + " không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (dialogResult == DialogResult.Yes)
                //    {
                //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                //        sqlConnection.Open();
                //        string cmdText = "DELETE [TB_CHITETQUANLYCONGNO] WHERE MADONHANG='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MADONHANG"].Value.ToString() + "'";
                //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //        sqlCommand.ExecuteNonQuery();
                //        sqlConnection.Close();
                //        if (sqlConnection.State == ConnectionState.Open)
                //        {
                //            sqlConnection.Close();
                //        }
                //        sqlConnection.Open();
                //        string cmdText2 = "DELETE [TB_DONHANGCONGNO] WHERE MADONHANG='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MADONHANG"].Value.ToString() + "'";
                //        SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
                //        sqlCommand2.ExecuteNonQuery();
                //        sqlConnection.Close();
                //        this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Bạn đang phân quyên không cho xóa", "Thông báo");
                //}
            }
        }

        // Token: 0x0600064E RID: 1614 RVA: 0x00124E1C File Offset: 0x0012301C
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (this.textBox3.Text == this.textBox3.Tag.ToString())
            {
                this.textBox3.Text = "";
            }
        }

        // Token: 0x0600064F RID: 1615 RVA: 0x00124E64 File Offset: 0x00123064
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                this.textBox3.Text = this.textBox3.Tag.ToString();
            }
        }

        // Token: 0x06000650 RID: 1616 RVA: 0x0001CB1C File Offset: 0x0001AD1C
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.load_congno_ncc();
        }

        // Token: 0x06000651 RID: 1617 RVA: 0x0001B637 File Offset: 0x00019837
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        // Token: 0x06000652 RID: 1618 RVA: 0x00124EAC File Offset: 0x001230AC
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView1.RowCount > 0)
                {
                    int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
                    if (this.dataGridView1.Columns[columnIndex].Name == "HINH")
                    {
                        if (this.dataGridView1.CurrentRow.Cells["HINH"].Value != null)
                        {
                            Frm_phonghinhcongno.mahang = "Select HINH FROM TB_DONHANGCONGNO WHERE MADONHANG ='" + this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString() + "'";
                            Frm_phonghinhcongno frm_phonghinhcongno = new Frm_phonghinhcongno();
                            frm_phonghinhcongno.ShowDialog();
                        }
                    }
                }
            }
        }

        // Token: 0x06000653 RID: 1619 RVA: 0x00124F90 File Offset: 0x00123190
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridView2.RowCount > 0)
                {
                    int columnIndex = this.dataGridView2.CurrentCell.ColumnIndex;
                    if (this.dataGridView2.Columns[columnIndex].Name == "IM_HINH")
                    {
                        Frm_phonghinhcongno.mahang = string.Concat(new string[]
                        {
                            "Select HINH FROM TB_CHITETQUANLYCONGNO WHERE MADONHANG ='",
                            this.dataGridView1.CurrentRow.Cells["MADONHANG"].Value.ToString(),
                            "' AND NGAYTHANHTOAN='",
                            this.dataGridView2.CurrentRow.Cells["NGAY"].Value.ToString(),
                            "'"
                        });
                        Frm_phonghinhcongno frm_phonghinhcongno = new Frm_phonghinhcongno();
                        frm_phonghinhcongno.ShowDialog();
                    }
                }
            }
        }
    }
}
