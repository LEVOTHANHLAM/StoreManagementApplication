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
    public partial class Frmnodauky : Form
    {
       // private TondaukyCtr t = new TondaukyCtr();

        // Token: 0x04000A94 RID: 2708
        private int ncc = 0;
        public Frmnodauky()
        {
            InitializeComponent();
        }
        private void GETDULIEU()
        {
            DataTable dataSource = new DataTable();
            //if (this.rbnophaithu.Checked)
            //{
            //    dataSource = this.t.GET_TONDAU();
            //}
            //else
            //{
            //    dataSource = this.t.GET_TONDAUTRA();
            //}
            this.dgvtondau.DataSource = dataSource;
        }

        // Token: 0x06000938 RID: 2360 RVA: 0x0001D681 File Offset: 0x0001B881
        private void GETMAKH(string Makh, string tenkh, string diachi, string sdt)
        {
            this.txtmakhachhang.Text = Makh;
            this.txttenkhachhang.Text = tenkh;
        }

        // Token: 0x06000939 RID: 2361 RVA: 0x00169E40 File Offset: 0x00168040
        private void bttim_Click(object sender, EventArgs e)
        {
            Frmkhachhang frmkhachhang = new Frmkhachhang();
            if (this.ncc == 0)
            {
                Frmkhachhang.chon = "1";
            }
            else
            {
                Frmkhachhang.chon = "nk";
            }
            frmkhachhang.MaKH = new Frmkhachhang.GetData(this.GETMAKH);
           // frmkhachhang.ShowDialog();
            this.txtsotien.Focus();
        }

        // Token: 0x0600093A RID: 2362 RVA: 0x00169EA0 File Offset: 0x001680A0
        private void Frmnodauky_Load(object sender, EventArgs e)
        {
            try
            {
                base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
                this.txtmakhachhang.Focus();
                this.GETDULIEU();
            }
            catch
            {
            }
        }

        // Token: 0x0600093B RID: 2363 RVA: 0x00169F18 File Offset: 0x00168118
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtmakhachhang.Text != "")
            //{
            //    if (this.txtsotien.Text != "0")
            //    {
            //        string text = "";
            //        if (this.txtghichu.Text != this.txtghichu.Tag.ToString())
            //        {
            //            text = this.txtghichu.Text;
            //        }
            //        if (this.rbnophaithu.Checked)
            //        {
            //            string text2 = this.rbnophaithu.Text;
            //            string ma = "thu";
            //            if (this.t.AddData_TONDAUKY(ma, text2, this.txtmakhachhang.Text, this.txttenkhachhang.Text, decimal.Parse(this.txtsotien.Text).ToString(), "0", text))
            //            {
            //                this.GETDULIEU();
            //                for (int i = 0; i < this.dgvtondau.Rows.Count; i++)
            //                {
            //                    if (this.dgvtondau["MAKH", i].Value.ToString().ToUpper() == this.txtmakhachhang.Text.ToUpper())
            //                    {
            //                        this.dgvtondau.ClearSelection();
            //                        this.dgvtondau.Rows[i].Selected = true;
            //                        this.dgvtondau.CurrentCell = this.dgvtondau.Rows[i].Cells["TENKH"];
            //                        break;
            //                    }
            //                }
            //                this.txtmakhachhang.Text = "";
            //                this.txttenkhachhang.Text = "";
            //                this.txtsotien.Text = "0";
            //                this.txtghichu.Text = this.txtghichu.Tag.ToString();
            //            }
            //        }
            //        else
            //        {
            //            string ma = "tra";
            //            string text2 = this.rbnophaitra.Text;
            //            if (this.t.AddData_TONDAUKY(ma, text2, this.txtmakhachhang.Text, this.txttenkhachhang.Text, "0", decimal.Parse(this.txtsotien.Text).ToString(), text))
            //            {
            //                this.GETDULIEU();
            //                for (int i = 0; i < this.dgvtondau.Rows.Count; i++)
            //                {
            //                    if (this.dgvtondau["MAKH", i].Value.ToString().ToUpper() == this.txtmakhachhang.Text.ToUpper())
            //                    {
            //                        this.dgvtondau.ClearSelection();
            //                        this.dgvtondau.Rows[i].Selected = true;
            //                        this.dgvtondau.CurrentCell = this.dgvtondau.Rows[i].Cells["TENKH"];
            //                        break;
            //                    }
            //                }
            //                this.txtmakhachhang.Text = "";
            //                this.txttenkhachhang.Text = "";
            //                this.txtsotien.Text = "0";
            //                this.txtghichu.Text = this.txtghichu.Tag.ToString();
            //            }
            //        }
            //        this.txtmakhachhang.Focus();
            //    }
            //    else
            //    {
            //        MessageBox.Show("SỐ TIỀN PHẢI LỚN HƠN  0", "THÔNG BÁO");
            //        this.txtsotien.Focus();
            //    }
            //}
        }

        // Token: 0x0600093C RID: 2364 RVA: 0x0016A2E0 File Offset: 0x001684E0
        private void rbnophaithu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbnophaithu.Checked)
            {
                this.GETDULIEU();
                this.ncc = 0;
                this.bttim.Text = "Chọn khách hàng";
            }
        }

        // Token: 0x0600093D RID: 2365 RVA: 0x0016A324 File Offset: 0x00168524
        private void rbnophaitra_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbnophaitra.Checked)
            {
                this.GETDULIEU();
                this.bttim.Text = "Chọn nhà cung cấp";
                this.ncc = 1;
            }
        }

        // Token: 0x0600093E RID: 2366 RVA: 0x0016A368 File Offset: 0x00168568
        private void btxoa_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("BẠN MUỐN XÓA KHÔNG", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    if (this.dgvtondau.RowCount > 0)
            //    {
            //        int rowIndex = this.dgvtondau.CurrentCell.RowIndex;
            //        string str = this.dgvtondau.Rows[rowIndex].Cells["STT"].Value.ToString();
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = "DELETE FROM TB_TONDAUKY WHERE STT='" + str + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO");
            //        this.GETDULIEU();
            //    }
            //}
        }

        // Token: 0x0600093F RID: 2367 RVA: 0x0016A44C File Offset: 0x0016864C
        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal num = decimal.Parse(this.txtsotien.Text);
                this.txtsotien.Text = num.ToString("#,##0");
                this.txtsotien.SelectionStart = this.txtsotien.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000940 RID: 2368 RVA: 0x0016A4B4 File Offset: 0x001686B4
        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "select TENDONVI,DIACHI,SDT from tb_khachhang WHERE makhachhang='" + this.txtmakhachhang.Text + "'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txttenkhachhang.Text = sqlDataReader.GetString(0);
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txttenkhachhang.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000941 RID: 2369 RVA: 0x00089160 File Offset: 0x00087360
        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000942 RID: 2370 RVA: 0x0016A558 File Offset: 0x00168758
        private void txtsotien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtghichu.Focus();
            }
        }

        // Token: 0x06000943 RID: 2371 RVA: 0x0001D69E File Offset: 0x0001B89E
        private void txtghichu_Enter(object sender, EventArgs e)
        {
            this.txtghichu.Text = "";
        }

        // Token: 0x06000944 RID: 2372 RVA: 0x0016A584 File Offset: 0x00168784
        private void txtghichu_Leave(object sender, EventArgs e)
        {
            if (this.txtghichu.Text == "")
            {
                this.txtghichu.Text = this.txtghichu.Tag.ToString();
            }
        }

        // Token: 0x06000945 RID: 2373 RVA: 0x0016A5CC File Offset: 0x001687CC
        private void txtghichu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1.Focus();
            }
        }

        // Token: 0x06000946 RID: 2374 RVA: 0x0016A5F8 File Offset: 0x001687F8
        private void txtmakhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtsotien.Focus();
            }
        }

        // Token: 0x06000947 RID: 2375 RVA: 0x0016A624 File Offset: 0x00168824
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvtondau.Rows.Count; i++)
            {
                if (this.dgvtondau["MAKH", i].Value.ToString().ToUpper() == this.txtmakhachhang.Text.ToUpper())
                {
                    this.dgvtondau.ClearSelection();
                    this.dgvtondau.Rows[i].Selected = true;
                    this.dgvtondau.CurrentCell = this.dgvtondau.Rows[i].Cells["TENKH"];
                    break;
                }
            }
        }

        // Token: 0x06000948 RID: 2376 RVA: 0x0001D6B2 File Offset: 0x0001B8B2
        private void txtsotien_Leave(object sender, EventArgs e)
        {
            this.txtsotien.BackColor = Color.White;
        }

        // Token: 0x06000949 RID: 2377 RVA: 0x0001D6C6 File Offset: 0x0001B8C6
        private void txtsotien_Enter(object sender, EventArgs e)
        {
            this.txtsotien.BackColor = Color.Yellow;
        }

        // Token: 0x0600094A RID: 2378 RVA: 0x0016A6E8 File Offset: 0x001688E8
        private void button3_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo =
                {
                    FileName = Application.StartupPath + "\\EXCEL\\CONGNODAUKY.xlsx"
                }
            }.Start();
            this.NHAPEXCEL();
        }

        // Token: 0x0600094B RID: 2379 RVA: 0x0016A728 File Offset: 0x00168928
        private void NHAPEXCEL()
        {
            //this.openFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //if (File.Exists(this.openFileDialog1.FileName))
            //{
            //    string connectionString = string.Empty;
            //    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.openFileDialog1.FileName + ";Extended Properties = Excel 12.0";
            //    OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            //    oleDbConnection.Open();
            //    try
            //    {
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        DataTable dataTable = new DataTable();
            //        oleDbDataAdapter.Fill(dataTable);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            try
            //            {
            //                if (dataTable.Rows[i]["MA"].ToString() != "")
            //                {
            //                    if (this.t.AddData_TONDAUKY(dataTable.Rows[i]["MA"].ToString(), dataTable.Rows[i]["NỘI DUNG"].ToString(), dataTable.Rows[i]["MÃ KHÁCH HÀNG"].ToString(), dataTable.Rows[i]["TÊN KHÁCH HÀNG"].ToString(), decimal.Parse(dataTable.Rows[i]["SỐ TIỀN"].ToString()).ToString(), decimal.Parse(dataTable.Rows[i]["SỐ TIỀN TRẢ"].ToString()).ToString(), dataTable.Rows[i]["GHI CHÚ"].ToString()))
            //                    {
            //                        this.GETDULIEU();
            //                    }
            //                }
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        MessageBox.Show("NHẬP THÀNH CÔNG");
            //    }
            //    catch
            //    {
            //        MessageBox.Show("KHÔNG NHẬP ĐƯỢC DỮ LIỆU");
            //    }
            //    finally
            //    {
            //        oleDbConnection.Close();
            //    }
            //}
        }

        // Token: 0x0600094C RID: 2380 RVA: 0x0016A9C0 File Offset: 0x00168BC0
        private void txtsotien_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số tiền";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsotien.Text = Frmbangso.soluong;
        }
    }
}
