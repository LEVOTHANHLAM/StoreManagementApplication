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
    public partial class Frmtiepnhan_xuly : Form
    {
        public Frmtiepnhan_xuly()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.load_dulieu();
        }

        // Token: 0x06000F03 RID: 3843 RVA: 0x001FE8A0 File Offset: 0x001FCAA0
        private void txtnoidung_Leave(object sender, EventArgs e)
        {
            if (this.txtnoidung.Text == "")
            {
                this.txtnoidung.Text = this.txtnoidung.Tag.ToString();
            }
        }

        // Token: 0x06000F04 RID: 3844 RVA: 0x001FE8E8 File Offset: 0x001FCAE8
        private void txtnoidung_Enter(object sender, EventArgs e)
        {
            if (this.txtnoidung.Text == this.txtnoidung.Tag.ToString())
            {
                this.txtnoidung.Text = "";
            }
        }

        // Token: 0x06000F05 RID: 3845 RVA: 0x001FE930 File Offset: 0x001FCB30
        private void txttenkhachhang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //if (Frmkhachhang.makhachhang != "")
            //{
            //    this.txtma.Text = Frmkhachhang.makhachhang;
            //    this.txttenkhachhang.Text = Frmkhachhang.tenkhachhang;
            //    this.txtsdt.Text = Frmkhachhang.sodienthoai;
            //}
        }

        // Token: 0x06000F06 RID: 3846 RVA: 0x001FE998 File Offset: 0x001FCB98
        private void txtnhanvien_nhan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //FrmNhanVien frmNhanVien = new FrmNhanVien();
            //frmNhanVien.ShowDialog();
            //if (FrmNhanVien.maphucvu != "")
            //{
            //    this.txtsdt_nhanviennhan.Text = FrmNhanVien.sodienthoai;
            //    this.txtma_nhanvien_nhan.Text = FrmNhanVien.maphucvu;
            //    this.txtnhanvien_nhan.Text = FrmNhanVien.tenphucvu;
            //}
        }

        // Token: 0x06000F07 RID: 3847 RVA: 0x001FEA00 File Offset: 0x001FCC00
        private void txtnhanvien_xuly_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //FrmNhanVien frmNhanVien = new FrmNhanVien();
            //frmNhanVien.ShowDialog();
            //if (FrmNhanVien.maphucvu != "")
            //{
            //    this.txtsdt_nhanvienxuly.Text = FrmNhanVien.sodienthoai;
            //    this.txtma_nhanvienxuly.Text = FrmNhanVien.maphucvu;
            //    this.txtnhanvien_xuly.Text = FrmNhanVien.tenphucvu;
            //}
        }

        // Token: 0x06000F08 RID: 3848 RVA: 0x001FEA68 File Offset: 0x001FCC68
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtnoidung.Text == this.txtnoidung.Tag.ToString())
            //{
            //    MessageBox.Show("Bạn chưa nhập nội dung yêu cầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtnoidung.Focus();
            //}
            //else if (this.txtnhanvien_nhan.Text == this.txtnhanvien_nhan.Tag.ToString())
            //{
            //    MessageBox.Show("Bạn chưa chọn nhân viên tiếp nhận", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtnhanvien_nhan.Focus();
            //}
            //else if (this.txtnhanvien_xuly.Text == this.txtnhanvien_xuly.Tag.ToString())
            //{
            //    MessageBox.Show("Bạn chưa chọn nhân viên xử lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtnhanvien_xuly.Focus();
            //}
            //else if (this.txtsdt.Text.Length < 10)
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtsdt.ReadOnly = false;
            //    this.txtsdt.Focus();
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "INSERT INTO [DATASHOP].[dbo].[TB_TIEPNHAN_XULY]([MAKHACHHANG],[MANHANVIENNHAN],[MANHANVIENXULY],[NGAYNHAN],[NGAYXULY],[NOIDUNGYEUCAU],[NOIDUNGXULY],[GUIKHACHHANG],[GUINHANVIEN],TINHTRANG,[sdt_kh],[sdt_nvn],[sdt_nvxl],[TENKHACHHANG],[TENNHANVIEN_NHAN],[TENNHANVIEN_XULY],SONGAY)\r\nVALUES('",
            //        this.txtma.Text,
            //        "','",
            //        this.txtma_nhanvien_nhan.Text,
            //        "','",
            //        this.txtma_nhanvienxuly.Text,
            //        "','",
            //        DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //        "','',N'",
            //        this.txtnoidung.Text,
            //        "','','False','False','False','",
            //        this.txtsdt.Text,
            //        "','",
            //        this.txtsdt_nhanviennhan.Text,
            //        "','",
            //        this.txtsdt_nhanvienxuly.Text,
            //        "',N'",
            //        this.txttenkhachhang.Text,
            //        "',N'",
            //        this.txtnhanvien_nhan.Text,
            //        "',N'",
            //        this.txtnhanvien_xuly.Text,
            //        "','",
            //        this.txt_songay.Text,
            //        "')"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    try
            //    {
            //        string cmdText2 = string.Concat(new string[]
            //        {
            //            "INSERT INTO [DATASHOP].[dbo].[TB_CONGVIEC]([NGUOITAO],[NGUOITHUCHIEN],[NGAYTAO],[DENNGAY],[NOIDUNG],[NHANVIEC],[GHICHU],[MANGUOITAO],[MANGUOITHUCHIEN])VALUES \r\n( N'",
            //            this.txtnhanvien_nhan.Text,
            //            "',N'",
            //            this.txtnhanvien_xuly.Text,
            //            "','",
            //            DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //            "','",
            //            DateTime.Now.AddDays((double)int.Parse(this.txt_songay.Text)).ToString("dd/MM/yyyy"),
            //            "',N'",
            //            this.txtnoidung.Text,
            //            "',N'Nhận việc','',N'",
            //            this.txtma_nhanvien_nhan.Text,
            //            "',N'",
            //            this.txtma_nhanvienxuly.Text,
            //            "')"
            //        });
            //        sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //        sqlConnection.Open();
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    catch
            //    {
            //    }
            //    this.load_dulieu();
            //    if (this.dataGridView1.RowCount > 0)
            //    {
            //        for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //        {
            //            if (this.dataGridView1["tenkhachhang", i].Value.ToString() == this.txttenkhachhang.Text)
            //            {
            //                this.dataGridView1.ClearSelection();
            //                this.dataGridView1.Rows[i].Selected = true;
            //                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[i].Cells["tenkhachhang"];
            //            }
            //        }
            //    }
            //    this.txtnoidung.Text = this.txtnoidung.Tag.ToString();
            //    this.txttenkhachhang.Text = this.txttenkhachhang.Tag.ToString();
            //    this.txtnhanvien_nhan.Text = this.txtnhanvien_nhan.Tag.ToString();
            //    this.txtnhanvien_xuly.Text = this.txtnhanvien_xuly.Tag.ToString();
            //    this.txtsdt.Text = this.txtsdt.Tag.ToString();
            //    this.txtsdt_nhanviennhan.Text = this.txtsdt_nhanviennhan.Tag.ToString();
            //    this.txtsdt_nhanvienxuly.Text = this.txtsdt_nhanvienxuly.Tag.ToString();
            //}
        }

        // Token: 0x06000F09 RID: 3849 RVA: 0x001FF008 File Offset: 0x001FD208
        private void load_dulieu()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT *,DATEADD(DD,SONGAY,CONVERT(DATETIME,NGAYNHAN,103))AS HANXULY  FROM TB_TIEPNHAN_XULY WHERE TINHTRANG='False'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //this.dataGridView1.AutoResizeRows();
        }

        // Token: 0x06000F0A RID: 3850 RVA: 0x001FF074 File Offset: 0x001FD274
        private void load_dulieu_ok()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT *,DATEADD(DD,SONGAY,CONVERT(DATETIME,NGAYNHAN,103))AS HANXULY  FROM TB_TIEPNHAN_XULY WHERE TINHTRANG='True'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //this.dataGridView1.AutoResizeRows();
        }

        // Token: 0x06000F0B RID: 3851 RVA: 0x001FF0E0 File Offset: 0x001FD2E0
        private void load_dulieu_timkiem()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "SELECT *,DATEADD(DD,SONGAY,CONVERT(DATETIME,NGAYNHAN,103))AS HANXULY  FROM TB_TIEPNHAN_XULY WHERE sdt_kh like '%",
            //    this.txttimkiem.Text,
            //    "%' or TENKHACHHANG like N'%",
            //    this.txttimkiem.Text,
            //    "%' "
            //}), sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //this.dataGridView1.AutoResizeRows();
        }

        // Token: 0x06000F0C RID: 3852 RVA: 0x0001EA48 File Offset: 0x0001CC48
        private void button3_Click(object sender, EventArgs e)
        {
            this.load_dulieu_ok();
        }

        // Token: 0x06000F0D RID: 3853 RVA: 0x001FF190 File Offset: 0x001FD390
        private void Frmtiepnhan_xuly_Load(object sender, EventArgs e)
        {
            //if (Screen.PrimaryScreen.WorkingArea.Width > 1025)
            //{
            //    base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1280) / 2, 0, 1280, Screen.PrimaryScreen.WorkingArea.Height + 10);
            //}
            //else if (Screen.PrimaryScreen.WorkingArea.Width > 1280)
            //{
            //    base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1366) / 2, 0, 1366, Screen.PrimaryScreen.WorkingArea.Height + 10);
            //}
            //if (Screen.PrimaryScreen.WorkingArea.Width > 1366)
            //{
            //    base.SetBounds(0, 0, 1400, Screen.PrimaryScreen.WorkingArea.Height + 10);
            //}
            //if (TrangChu.guimai == "True")
            //{
            //    try
            //    {
            //        if (this.P.IsOpen)
            //        {
            //            this.P.Close();
            //        }
            //        else
            //        {
            //            try
            //            {
            //                this.P.PortName = Settings.Default.PortName;
            //                this.P.Parity = Parity.None;
            //                this.P.BaudRate = 9600;
            //                this.P.DataBits = 8;
            //                this.P.StopBits = StopBits.One;
            //                this.P.Open();
            //            }
            //            catch
            //            {
            //                MessageBox.Show("Không thể mở cổng COM", "Lỗi", MessageBoxButtons.OK);
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
            //this.load_dulieu();
        }

        // Token: 0x06000F0E RID: 3854 RVA: 0x001FF37C File Offset: 0x001FD57C
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
        }

        // Token: 0x06000F0F RID: 3855 RVA: 0x001FF3C4 File Offset: 0x001FD5C4
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
        }

        // Token: 0x06000F10 RID: 3856 RVA: 0x001FF40C File Offset: 0x001FD60C
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            {
                if (this.txttimkiem.Text != "")
                {
                    this.load_dulieu_timkiem();
                }
            }
        }

        // Token: 0x06000F11 RID: 3857 RVA: 0x001FF468 File Offset: 0x001FD668
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    if (this.dataGridView1.Columns[this.dataGridView1.CurrentCell.ColumnIndex].Name == "nhanvienxuly" && !Convert.ToBoolean(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Tinhtrang"].Value.ToString()))
            //    {
            //        FrmNhanVien frmNhanVien = new FrmNhanVien();
            //        frmNhanVien.ShowDialog();
            //        if (FrmNhanVien.maphucvu != "")
            //        {
            //            this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_nvxl"].Value = FrmNhanVien.sodienthoai;
            //            this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["ten_nvxl"].Value = FrmNhanVien.maphucvu;
            //            this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["nhanvienxuly"].Value = FrmNhanVien.tenphucvu;
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_TIEPNHAN_XULY SET MANHANVIENXULY= '",
            //                FrmNhanVien.maphucvu,
            //                "',[sdt_nvxl]= '",
            //                FrmNhanVien.sodienthoai,
            //                "',[TENNHANVIEN_XULY]= N'",
            //                FrmNhanVien.tenphucvu,
            //                "' where MA='",
            //                this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MA"].Value.ToString(),
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //        }
            //    }
            //}
        }

        // Token: 0x06000F12 RID: 3858 RVA: 0x001FF6B0 File Offset: 0x001FD8B0
        private void button6_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    if (!Convert.ToBoolean(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Tinhtrang"].Value.ToString()))
            //    {
            //        DialogResult dialogResult = MessageBox.Show(string.Concat(new string[]
            //        {
            //            "Bạn có muốn xóa yêu cầu  ",
            //            this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Noidungnhan"].Value.ToString(),
            //            " của khách hàng ",
            //            this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["tenkhachhang"].Value.ToString(),
            //            "  không?"
            //        }), "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = "DELETE TB_TIEPNHAN_XULY where MA='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MA"].Value.ToString() + "'";
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
            //        }
            //    }
            //}
        }

        // Token: 0x06000F13 RID: 3859 RVA: 0x001FF884 File Offset: 0x001FDA84
        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!this.P.IsOpen)
            //    {
            //        this.P.Open();
            //    }
            //    if (this.P.IsOpen)
            //    {
            //        this.P.Handshake = Handshake.RequestToSend;
            //        this.P.DtrEnable = true;
            //        try
            //        {
            //            if (this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_nvxl"].Value.ToString() != "")
            //            {
            //                string text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["Noidungnhan"].Value.ToString();
            //                string str = "+84" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_nvxl"].Value.ToString();
            //                this.P.WriteLine("AT" + Environment.NewLine);
            //                Thread.Sleep(100);
            //                this.P.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //                Thread.Sleep(100);
            //                this.P.WriteLine("AT+CSCS=\"Unicode\"" + Environment.NewLine);
            //                Thread.Sleep(100);
            //                this.P.WriteLine("AT+CMGS=\"" + str + "\"" + Environment.NewLine);
            //                Thread.Sleep(100);
            //                this.P.WriteLine(text);
            //                Thread.Sleep(100);
            //                this.P.Write(new byte[]
            //                {
            //                    26
            //                }, 0, 1);
            //                Thread.Sleep(100);
            //                SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                sqlConnection.Open();
            //                string cmdText = "UPDATE TB_TIEPNHAN_XULY SET GUINHANVIEN='TRUE' where MA='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MA"].Value.ToString() + "'";
            //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //                MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            }
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Không gửi được tin nhắn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }
            //        this.P.Close();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
        }

        // Token: 0x06000F14 RID: 3860 RVA: 0x001FFB88 File Offset: 0x001FDD88
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = this.textBox1.Tag.ToString();
            }
        }

        // Token: 0x06000F15 RID: 3861 RVA: 0x001FFBD0 File Offset: 0x001FDDD0
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == this.textBox1.Tag.ToString())
            {
                this.textBox1.Text = "";
            }
        }

        // Token: 0x06000F16 RID: 3862 RVA: 0x001FFC18 File Offset: 0x001FDE18
        private void button7_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != this.textBox1.Tag.ToString())
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "UPDATE TB_TIEPNHAN_XULY SET NOIDUNGXULY= N'",
            //        this.textBox1.Text,
            //        "',NGAYXULY= '",
            //        DateTime.Now.ToString("HH:mm dd/MM/yyyy"),
            //        "', TINHTRANG='TRUE' where MA='",
            //        this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MA"].Value.ToString(),
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["noidungxuly"].Value = this.textBox1.Text;
            //    this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["ngayxuly"].Value = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            //}
        }

        // Token: 0x06000F17 RID: 3863 RVA: 0x0009B888 File Offset: 0x00099A88
        private string NonUnicode(string text)
        {
            string[] array = new string[]
            {
                "á",
                "à",
                "ả",
                "ã",
                "ạ",
                "â",
                "ấ",
                "ầ",
                "ẩ",
                "ẫ",
                "ậ",
                "ă",
                "ắ",
                "ằ",
                "ẳ",
                "ẵ",
                "ặ",
                "đ",
                "é",
                "è",
                "ẻ",
                "ẽ",
                "ẹ",
                "ê",
                "ế",
                "ề",
                "ể",
                "ễ",
                "ệ",
                "í",
                "ì",
                "ỉ",
                "ĩ",
                "ị",
                "ó",
                "ò",
                "ỏ",
                "õ",
                "ọ",
                "ô",
                "ố",
                "ồ",
                "ổ",
                "ỗ",
                "ộ",
                "ơ",
                "ớ",
                "ờ",
                "ở",
                "ỡ",
                "ợ",
                "ú",
                "ù",
                "ủ",
                "ũ",
                "ụ",
                "ư",
                "ứ",
                "ừ",
                "ử",
                "ữ",
                "ự",
                "ý",
                "ỳ",
                "ỷ",
                "ỹ",
                "ỵ"
            };
            string[] array2 = new string[]
            {
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "a",
                "d",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "e",
                "i",
                "i",
                "i",
                "i",
                "i",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "o",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "u",
                "y",
                "y",
                "y",
                "y",
                "y"
            };
            for (int i = 0; i < array.Length; i++)
            {
                text = text.Replace(array[i], array2[i]);
                text = text.Replace(array[i].ToUpper(), array2[i].ToUpper());
            }
            return text;
        }

        // Token: 0x06000F18 RID: 3864 RVA: 0x001FFDA4 File Offset: 0x001FDFA4
        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.dataGridView1.RowCount > 0)
            //    {
            //        if (!this.P.IsOpen)
            //        {
            //            this.P.Open();
            //        }
            //        if (this.P.IsOpen)
            //        {
            //            this.P.Handshake = Handshake.RequestToSend;
            //            this.P.DtrEnable = true;
            //            try
            //            {
            //                if (this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_kh"].Value.ToString() == "")
            //                {
            //                    MessageBox.Show("SỐ ĐIỆN THOẠI KHÁCH HÀNG KHÔNG HỢP LỆ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                }
            //                else if (this.textBox1.Text == this.textBox1.Tag.ToString())
            //                {
            //                    MessageBox.Show("VUI LÒNG NHẬP NỘI DUNG CẦN GỬI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                    this.textBox1.Focus();
            //                }
            //                else
            //                {
            //                    string text = this.textBox1.Text.Trim();
            //                    string str = "+84" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_kh"].Value.ToString().Substring(1, this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["sdt_kh"].Value.ToString().Trim().Length - 1);
            //                    this.P.WriteLine("AT" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CSCS=\"Unicode\"" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CMGS=\"" + str + "\"" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine(text);
            //                    Thread.Sleep(100);
            //                    this.P.Write(new byte[]
            //                    {
            //                        26
            //                    }, 0, 1);
            //                    Thread.Sleep(100);
            //                    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                    sqlConnection.Open();
            //                    string cmdText = "UPDATE TB_TIEPNHAN_XULY SET GUIKHACHHANG='TRUE' where MA='" + this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["MA"].Value.ToString() + "'";
            //                    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                    sqlCommand.ExecuteNonQuery();
            //                    sqlConnection.Close();
            //                    MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                }
            //            }
            //            catch
            //            {
            //                MessageBox.Show("Không gửi được tin nhắn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //            }
            //            this.P.Close();
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
        }

        // Token: 0x06000F19 RID: 3865 RVA: 0x0020014C File Offset: 0x001FE34C
        private void txt_songay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtnoidung.Focus();
            }
        }
        // Token: 0x04001189 RID: 4489
       // private SerialPort P = new SerialPort();
    }
}
