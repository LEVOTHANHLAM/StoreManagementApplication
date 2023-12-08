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
    public partial class Frmnguyenlieu : Form
    {
        public Frmnguyenlieu()
        {
            InitializeComponent();
        }
        private void txtma_Leave(object sender, EventArgs e)
        {
            if (this.txtma.Text == "")
            {
                this.txtma.Text = this.txtma.Tag.ToString();
            }
        }

        // Token: 0x06000F8B RID: 3979 RVA: 0x0020328C File Offset: 0x0020148C
        private void txtma_Enter(object sender, EventArgs e)
        {
            if (this.txtma.Text == this.txtma.Tag.ToString())
            {
                this.txtma.Text = "";
            }
        }

        // Token: 0x06000F8C RID: 3980 RVA: 0x002032D4 File Offset: 0x002014D4
        private void txtten_Enter(object sender, EventArgs e)
        {
            if (this.txtten.Text == this.txtten.Tag.ToString())
            {
                this.txtten.Text = "";
            }
        }

        // Token: 0x06000F8D RID: 3981 RVA: 0x0020331C File Offset: 0x0020151C
        private void txtten_Leave(object sender, EventArgs e)
        {
            if (this.txtten.Text == "")
            {
                this.txtten.Text = this.txtten.Tag.ToString();
            }
        }

        // Token: 0x06000F8E RID: 3982 RVA: 0x00203364 File Offset: 0x00201564
        private void txtdvt_Leave(object sender, EventArgs e)
        {
            if (this.txtdvt.Text == "")
            {
                this.txtdvt.Text = this.txtdvt.Tag.ToString();
            }
        }

        // Token: 0x06000F8F RID: 3983 RVA: 0x002033AC File Offset: 0x002015AC
        private void txtdvt_Enter(object sender, EventArgs e)
        {
            if (this.txtdvt.Text == this.txtdvt.Tag.ToString())
            {
                this.txtdvt.Text = "";
            }
        }

        // Token: 0x06000F90 RID: 3984 RVA: 0x002033F4 File Offset: 0x002015F4
        private void txtdg_Leave(object sender, EventArgs e)
        {
            if (this.txtdg.Text == "")
            {
                this.txtdg.Text = this.txtdg.Tag.ToString();
            }
        }

        // Token: 0x06000F91 RID: 3985 RVA: 0x0020343C File Offset: 0x0020163C
        private void txtdg_Enter(object sender, EventArgs e)
        {
            if (this.txtdg.Text == this.txtdg.Tag.ToString())
            {
                this.txtdg.Text = "";
            }
        }

        // Token: 0x06000F92 RID: 3986 RVA: 0x00203484 File Offset: 0x00201684
        private void txtmancc_Enter(object sender, EventArgs e)
        {
            if (this.txtmancc.Text == this.txtmancc.Tag.ToString())
            {
                this.txtmancc.Text = "";
            }
        }

        // Token: 0x06000F93 RID: 3987 RVA: 0x002034CC File Offset: 0x002016CC
        private void txtmancc_Leave(object sender, EventArgs e)
        {
            if (this.txtmancc.Text == "")
            {
                this.txtmancc.Text = this.txtmancc.Tag.ToString();
            }
        }

        // Token: 0x06000F94 RID: 3988 RVA: 0x00203514 File Offset: 0x00201714
        private void Frmnguyenlieu_Load(object sender, EventArgs e)
        {
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 879) / 2, 0, 879, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(KH.TENDONVI,'')AS TENDONVI,NL.Ghichu FROM TB_NGUYENLIEU NL LEFT JOIN  Tb_KHACHHANG KH ON NL.NCC=KH.MAKHACHHANG";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvnl.DataSource = dataTable;
            //this.txtma.Focus();
        }

        // Token: 0x06000F95 RID: 3989 RVA: 0x002035C0 File Offset: 0x002017C0
        private void luu()
        {
            //if (this.txtten.Text == this.txtten.Tag.ToString() || this.txtdvt.Text == this.txtdvt.Tag.ToString())
            //{
            //    MessageBox.Show("Tên nguyên liệu và Đơn vị tính là bắt buộc nhập", "THÔNG BÁO");
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string text = "";
            //    string text2 = "";
            //    string text3 = "";
            //    string text4 = "";
            //    string text5;
            //    if (this.txtma.Text != this.txtma.Tag.ToString())
            //    {
            //        text5 = this.txtma.Text;
            //    }
            //    else
            //    {
            //        string text6 = DateTime.Now.ToString("yy");
            //        string selectCommandText = string.Concat(new string[]
            //        {
            //            "select isnull(MAX(mahanghoa),'",
            //            text6,
            //            "00000') from Tb_NGUYENLIEU where left(MAHANGHOA,2)='",
            //            text6,
            //            "' and len(mahanghoa)='7'"
            //        });
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
            //        DataTable dataTable = new DataTable();
            //        sqlDataAdapter.Fill(dataTable);
            //        string text7;
            //        if (dataTable.Rows.Count <= 0)
            //        {
            //            text7 = text6 + "00001";
            //        }
            //        else
            //        {
            //            string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(0, 2));
            //            text7 = text6;
            //            if (a == text7)
            //            {
            //                double num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2, 5));
            //                num += 1.0;
            //                if (num < 10.0)
            //                {
            //                    text7 += "0000";
            //                }
            //                else if (num < 100.0)
            //                {
            //                    text7 += "000";
            //                }
            //                else if (num < 1000.0)
            //                {
            //                    text7 += "00";
            //                }
            //                else if (num < 10000.0)
            //                {
            //                    text7 += "0";
            //                }
            //                text7 += num.ToString();
            //            }
            //            else
            //            {
            //                text7 = text6 + "00001";
            //            }
            //        }
            //        text5 = text7;
            //    }
            //    if (this.txtten.Text != this.txtten.Tag.ToString())
            //    {
            //        text = this.txtten.Text;
            //    }
            //    if (this.txtdvt.Text != this.txtdvt.Tag.ToString())
            //    {
            //        text2 = this.txtdvt.Text;
            //    }
            //    if (this.txtdg.Text != this.txtdg.Tag.ToString())
            //    {
            //        text3 = this.txtdg.Text;
            //    }
            //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //    {
            //        text4 = this.txtmancc.Text;
            //    }
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "INSERT INTO TB_NGUYENLIEU (MAHANGHOA,TENHANGHOA,DONVITINH,GHICHU,NCC) values('",
            //        text5,
            //        "',N'",
            //        text,
            //        "',N'",
            //        text2,
            //        "',N'",
            //        text3,
            //        "',N'",
            //        text4,
            //        "')"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    DataTable dataTable2 = new DataTable();
            //    string cmdText2 = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(KH.TENDONVI,'')AS TENDONVI,NL.Ghichu FROM TB_NGUYENLIEU NL LEFT JOIN  Tb_KHACHHANG KH ON NL.NCC=KH.MAKHACHHANG";
            //    SqlCommand selectCommand = new SqlCommand(cmdText2, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter2.Fill(dataTable2);
            //    this.dgvnl.DataSource = dataTable2;
            //    for (int i = 0; i < this.dgvnl.Rows.Count; i++)
            //    {
            //        if (this.dgvnl["MA", i].Value.ToString() == this.txtma.Text.ToUpper())
            //        {
            //            this.dgvnl.ClearSelection();
            //            this.dgvnl.Rows[i].Selected = true;
            //            this.dgvnl.CurrentCell = this.dgvnl.Rows[i].Cells["MA"];
            //            break;
            //        }
            //    }
            //    this.txtmancc.Text = this.txtmancc.Tag.ToString();
            //    this.txtma.Text = this.txtma.Tag.ToString();
            //    this.txtten.Text = this.txtten.Tag.ToString();
            //    this.txtdg.Text = this.txtdg.Tag.ToString();
            //    this.txtdvt.Text = this.txtdvt.Tag.ToString();
            //    this.txtma.Focus();
            //}
        }

        // Token: 0x06000F96 RID: 3990 RVA: 0x0001EC55 File Offset: 0x0001CE55
        private void btluu_Click(object sender, EventArgs e)
        {
            this.luu();
        }

        // Token: 0x06000F97 RID: 3991 RVA: 0x00203B78 File Offset: 0x00201D78
        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            //if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //{
            //    if (this.txtmancc.Text != "")
            //    {
            //        string cmdText = "SELECT TENDONVI FROM tb_KHACHHANG where MAKHACHHANG=N'" + this.txtmancc.Text + "'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txttenncc.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txttenncc.Text = this.txttenncc.Tag.ToString();
            //        }
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.txttenncc.Text = this.txttenncc.Tag.ToString();
            //    }
            //}
        }

        // Token: 0x06000F98 RID: 3992 RVA: 0x00203C9C File Offset: 0x00201E9C
        private void dgvnl_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvnl.RowCount > 0)
            //{
            //    int index = this.dgvnl.CurrentRow.Index;
            //    int columnIndex = this.dgvnl.CurrentCell.ColumnIndex;
            //    if (this.dgvnl.Columns[columnIndex].Name == "xoa")
            //    {
            //        Frmyesno.caption = "THÔNG BÁO XÓA";
            //        Frmyesno.text = "Bạn có muốn xóa " + this.dgvnl.CurrentRow.Cells["ten"].Value + " không?";
            //        Frmyesno frmyesno = new Frmyesno();
            //        frmyesno.ShowDialog();
            //        if (Frmyesno.dongy == "ok")
            //        {
            //            string cmdText = "SELECT MAHANGHOA FROM TB_HANGHOANHAP_NL where MAHANGHOA ='" + this.dgvnl.Rows[index].Cells["MA"].Value.ToString() + "'";
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.HasRows)
            //            {
            //                MessageBox.Show("Mặt hàng này đã có trong nhập kho", "THÔNG BÁO");
            //            }
            //            if (!sqlDataReader.HasRows)
            //            {
            //                sqlConnection.Close();
            //                sqlConnection.Open();
            //                string cmdText2 = "DELETE TB_NGUYENLIEU WHERE MAHANGHOA ='" + this.dgvnl.Rows[index].Cells["MA"].Value.ToString() + "'";
            //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //                sqlCommand2.ExecuteNonQuery();
            //                this.dgvnl.Rows.RemoveAt(index);
            //            }
            //            this.txtma.Focus();
            //            sqlConnection.Close();
            //        }
            //    }
            //}
        }

        // Token: 0x06000F99 RID: 3993 RVA: 0x00203EA8 File Offset: 0x002020A8
        private void txtma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtten.Focus();
            }
        }

        // Token: 0x06000F9A RID: 3994 RVA: 0x00203ED4 File Offset: 0x002020D4
        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdvt.Focus();
            }
        }

        // Token: 0x06000F9B RID: 3995 RVA: 0x00203F00 File Offset: 0x00202100
        private void txtdvt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdg.Focus();
            }
        }

        // Token: 0x06000F9C RID: 3996 RVA: 0x00203F2C File Offset: 0x0020212C
        private void txtdg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtmancc.Focus();
            }
        }

        // Token: 0x06000F9D RID: 3997 RVA: 0x00203F58 File Offset: 0x00202158
        private void txtmancc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btluu.Focus();
            }
        }
    }
}
