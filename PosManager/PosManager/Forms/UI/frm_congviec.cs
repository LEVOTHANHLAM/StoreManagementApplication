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
    public partial class frm_congviec : Form
    {
        public frm_congviec()
        {
            InitializeComponent();
        }
        // Token: 0x060007CA RID: 1994 RVA: 0x0001B637 File Offset: 0x00019837
        private void txt_manguoitao_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060007CB RID: 1995 RVA: 0x00145A3C File Offset: 0x00143C3C
        private void txt_manguoitao_Enter(object sender, EventArgs e)
        {
            if (this.txt_manguoitao.Text == this.txt_manguoitao.Tag.ToString())
            {
                this.txt_manguoitao.Text = "";
            }
        }

        // Token: 0x060007CC RID: 1996 RVA: 0x00145A84 File Offset: 0x00143C84
        private void frm_congviec_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Width > 1025)
            {
                base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1280) / 2, 0, 1280, Screen.PrimaryScreen.WorkingArea.Height + 10);
            }
            else if (Screen.PrimaryScreen.WorkingArea.Width > 1280)
            {
                base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1366) / 2, 0, 1366, Screen.PrimaryScreen.WorkingArea.Height + 10);
            }
            else
            {
                base.SetBounds(0, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 10);
            }
            this.load_nhanvien();
            this.txt_manguoitao.Text = frm_congviec.manhanvien_yeucau;
            if (this.txt_manguoitao.Text != this.txt_manguoitao.Tag.ToString())
            {
                this.bt_thuchien_Click(null, null);
            }
            this.txt_manguoitao.Focus();
        }

        // Token: 0x060007CD RID: 1997 RVA: 0x00145BC8 File Offset: 0x00143DC8
        private void load_dulieu(string dk)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT *  FROM TB_CONGVIEC " + dk + " ORDER BY CONVERT(DATETIME,NGAYTAO,103) DESC", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgv_congviec.DataSource = dataTable;
            //this.dgv_congviec.AutoResizeRows();
        }

        // Token: 0x060007CE RID: 1998 RVA: 0x00145C40 File Offset: 0x00143E40
        private void load_nhanvien()
        {
            //if (frmLogIn.MADANGNHAP == "ADMIN")
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand("SELECT MANV,TENNV FROM TB_NHANVIEN ORDER BY TENNV", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.cob_locnhanvien.DataSource = dataTable;
            //    this.cob_locnhanvien.DisplayMember = "TENNV";
            //    this.cob_locnhanvien.ValueMember = "MANV";
            //    this.txt_manguoitao.Text = this.cob_locnhanvien.SelectedValue.ToString();
            //    this.loadxong = 1;
            //    this.cob_locnhanvien.SelectedIndex = 0;
            //}
        }

        // Token: 0x060007CF RID: 1999 RVA: 0x00145D10 File Offset: 0x00143F10
        private void txt_manguoitao_Leave(object sender, EventArgs e)
        {
            if (this.txt_manguoitao.Text == "")
            {
                this.txt_manguoitao.Text = this.txt_manguoitao.Tag.ToString();
            }
        }

        // Token: 0x060007D0 RID: 2000 RVA: 0x00145D58 File Offset: 0x00143F58
        private void txt_manguoitao_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        string cmdText = "SELECT TENNV FROM Tb_NhanVien WHERE MaNV='" + this.txt_manguoitao.Text.Trim() + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txt_tennguoitao.Text = sqlDataReader.GetString(0);
            //            this.txt_nguoithuchien.Focus();
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txt_tennguoitao.Text = this.txt_tennguoitao.Tag.ToString();
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x060007D1 RID: 2001 RVA: 0x00145E44 File Offset: 0x00144044
        private void txt_nguoithuchien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.manhanvien_thuchien = "";
            //FrmNhanVien frmNhanVien = new FrmNhanVien();
            //frmNhanVien.ShowDialog();
            //if (FrmNhanVien.maphucvu != "")
            //{
            //    this.manhanvien_thuchien = FrmNhanVien.maphucvu;
            //    this.txt_nguoithuchien.Text = FrmNhanVien.tenphucvu;
            //    this.txt_songay.Focus();
            //}
        }

        // Token: 0x060007D2 RID: 2002 RVA: 0x00145EAC File Offset: 0x001440AC
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txt_tennguoitao.Text == this.txt_tennguoitao.Tag.ToString())
            //{
            //    MessageBox.Show("VUI LÒNG NHẬP NHÂN VIÊN YÊU CẦU", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txt_manguoitao.Focus();
            //}
            //else if (this.txt_nguoithuchien.Text == this.txt_nguoithuchien.Tag.ToString())
            //{
            //    MessageBox.Show("VUI LÒNG NHẬP NHÂN VIÊN THỰC HIỆN", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txt_nguoithuchien.Focus();
            //}
            //else if (this.txt_noidung.Text == this.txt_noidung.Tag.ToString())
            //{
            //    MessageBox.Show("VUI LÒNG NHẬP NHÂN VIÊN THỰC HIỆN", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txt_noidung.Focus();
            //}
            //else
            //{
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "INSERT INTO [DATASHOP].[dbo].[TB_CONGVIEC]([NGUOITAO],[NGUOITHUCHIEN],[NGAYTAO],[DENNGAY],[NOIDUNG],[NHANVIEC],[GHICHU],[MANGUOITAO],[MANGUOITHUCHIEN])VALUES \r\n( N'",
            //        this.txt_tennguoitao.Text,
            //        "',N'",
            //        this.txt_nguoithuchien.Text,
            //        "','",
            //        DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //        "','",
            //        DateTime.Now.AddDays((double)int.Parse(this.txt_songay.Text)).ToString("dd/MM/yyyy"),
            //        "',N'",
            //        this.txt_noidung.Text,
            //        "',N'Nhận việc','',N'",
            //        this.txt_manguoitao.Text,
            //        "',N'",
            //        this.manhanvien_thuchien,
            //        "')"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.bt_yeucau_Click(null, null);
            //    this.txt_noidung.Text = this.txt_noidung.Tag.ToString();
            //    this.txt_tennguoitao.Text = this.txt_tennguoitao.Tag.ToString();
            //    this.txt_nguoithuchien.Text = this.txt_nguoithuchien.Tag.ToString();
            //    this.txt_manguoitao.Text = "";
            //    this.txt_manguoitao.Focus();
            //}
        }

        // Token: 0x060007D3 RID: 2003 RVA: 0x00146144 File Offset: 0x00144344
        private void txt_noidung_Leave(object sender, EventArgs e)
        {
            if (this.txt_noidung.Text == "")
            {
                this.txt_noidung.Text = this.txt_noidung.Tag.ToString();
            }
        }

        // Token: 0x060007D4 RID: 2004 RVA: 0x0014618C File Offset: 0x0014438C
        private void txt_noidung_Enter(object sender, EventArgs e)
        {
            if (this.txt_noidung.Text == this.txt_noidung.Tag.ToString())
            {
                this.txt_noidung.Text = "";
            }
        }

        // Token: 0x060007D5 RID: 2005 RVA: 0x001461D4 File Offset: 0x001443D4
        private void txt_songay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt_noidung.Focus();
            }
        }

        // Token: 0x060007D6 RID: 2006 RVA: 0x0001D035 File Offset: 0x0001B235
        private void bt_yeucau_Click(object sender, EventArgs e)
        {
            this.chophep = 1;
            this.load_dulieu(" WHERE MANGUOITAO=N'" + this.txt_manguoitao.Text + "'");
        }

        // Token: 0x060007D7 RID: 2007 RVA: 0x0001D060 File Offset: 0x0001B260
        private void bt_thuchien_Click(object sender, EventArgs e)
        {
            this.chophep = 0;
            this.load_dulieu(" WHERE MANGUOITHUCHIEN=N'" + this.txt_manguoitao.Text + "'");
        }

        // Token: 0x060007D8 RID: 2008 RVA: 0x00146200 File Offset: 0x00144400
        private void cob_locnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loadxong == 1)
            {
                this.txt_manguoitao.Text = this.cob_locnhanvien.SelectedValue.ToString();
                this.load_dulieu(" WHERE MANGUOITHUCHIEN=N'" + this.txt_manguoitao.Text + "'");
            }
        }

        // Token: 0x060007D9 RID: 2009 RVA: 0x00146260 File Offset: 0x00144460
        private void dgv_congviec_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgv_congviec.RowCount > 0)
            //{
            //    int columnIndex = this.dgv_congviec.CurrentCell.ColumnIndex;
            //    int rowIndex = this.dgv_congviec.CurrentCell.RowIndex;
            //    try
            //    {
            //        if (this.chophep == 0)
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            if (this.dgv_congviec.Columns[columnIndex].Name == "Nhanviec")
            //            {
            //                if (this.dgv_congviec.Rows[rowIndex].Cells["Nhanviec"].Value.ToString() == "Nhận việc")
            //                {
            //                    this.dgv_congviec.Rows[rowIndex].Cells["Nhanviec"].Value = "Đang xử lý";
            //                    SqlCommand sqlCommand = new SqlCommand("UPDATE TB_CONGVIEC SET NHANVIEC=N'Đang xử lý' WHERE MACONGVIEC='" + this.dgv_congviec.Rows[rowIndex].Cells["MACONGVIEC"].Value.ToString() + "'", sqlConnection);
            //                    sqlCommand.ExecuteNonQuery();
            //                    sqlConnection.Close();
            //                }
            //                else if (this.dgv_congviec.Rows[rowIndex].Cells["Nhanviec"].Value.ToString() == "Đang xử lý")
            //                {
            //                    this.dgv_congviec.Rows[rowIndex].Cells["Nhanviec"].Value = "Hoàn thành";
            //                    SqlCommand sqlCommand = new SqlCommand("UPDATE TB_CONGVIEC SET NHANVIEC=N'Hoàn thành' WHERE MACONGVIEC='" + this.dgv_congviec.Rows[rowIndex].Cells["MACONGVIEC"].Value.ToString() + "'", sqlConnection);
            //                    sqlCommand.ExecuteNonQuery();
            //                    sqlConnection.Close();
            //                }
            //            }
            //            else if (this.dgv_congviec.Columns[columnIndex].Name == "ghichu")
            //            {
            //                this.dgv_congviec.ReadOnly = false;
            //                this.dgv_congviec.BeginEdit(false);
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x060007DA RID: 2010 RVA: 0x001464F4 File Offset: 0x001446F4
        private void dgv_congviec_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgv_congviec.Columns[this.dgv_congviec.CurrentCell.ColumnIndex].Name == "ghichu")
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "UPDATE TB_CONGVIEC SET GHICHU=N'",
            //        this.dgv_congviec.Rows[this.dgv_congviec.CurrentCell.RowIndex].Cells["GHICHU"].Value.ToString(),
            //        "' WHERE MACONGVIEC='",
            //        this.dgv_congviec.Rows[this.dgv_congviec.CurrentCell.RowIndex].Cells["MACONGVIEC"].Value.ToString(),
            //        "'"
            //    }), sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060007DB RID: 2011 RVA: 0x0014660C File Offset: 0x0014480C
        private void button2_Click(object sender, EventArgs e)
        {
            //if (this.dgv_congviec.RowCount > 0)
            //{
            //    if (frmLogIn.MADANGNHAP == "ADMIN")
            //    {
            //        DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            SqlCommand sqlCommand = new SqlCommand("DELETE TB_CONGVIEC WHERE MACONGVIEC='" + this.dgv_congviec.Rows[this.dgv_congviec.CurrentCell.RowIndex].Cells["MACONGVIEC"].Value.ToString() + "'", sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            this.dgv_congviec.Rows.RemoveAt(this.dgv_congviec.CurrentCell.RowIndex);
            //        }
            //    }
            //}
        }


        // Token: 0x040008A4 RID: 2212
        public static string manhanvien_yeucau;

        // Token: 0x040008A5 RID: 2213
        private string manhanvien_thuchien = "";

        // Token: 0x040008A6 RID: 2214
        private int chophep = 1;

        // Token: 0x040008A7 RID: 2215
        private int loadxong = 0;
    }
}
