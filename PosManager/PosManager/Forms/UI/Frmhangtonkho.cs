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
    public partial class Frmhangtonkho : Form
    {
        public Frmhangtonkho()
        {
            InitializeComponent();
        }
        //private void themhanghoa(HanghoaHdObj hhObj)
        //{
        //    hhObj.Mahanghoa = this.txtmahang.Text;
        //    hhObj.Tenhanghoa = this.txttenhang.Text;
        //    hhObj.Dongia = "0";
        //    hhObj.Ghichu = this.txtghichu.Text;
        //    hhObj.Donvitinh = this.txtdonvi.Text;
        //    this.xhdCtr.ADD_HANGHOA(hhObj);
        //}

        // Token: 0x06000D75 RID: 3445 RVA: 0x001DF668 File Offset: 0x001DD868
        //private void loadcauhinh()
        //{
        //    string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //    sqlConnection.Open();
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    while (sqlDataReader.Read())
        //    {
        //        this.chObj.Tencongty = sqlDataReader.GetString(1);
        //        this.chObj.Diachi = sqlDataReader.GetString(2);
        //        this.chObj.Dienthoai = sqlDataReader.GetString(3);
        //        this.chObj.Kyten = sqlDataReader.GetString(4);
        //        this.chObj.Canhle = sqlDataReader.GetString(5);
        //        this.chObj.Sotrangin = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
        //        this.chObj.Ghichu = sqlDataReader.GetString(7);
        //        this.chObj.Cochuten = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
        //        this.chObj.Cochudienthoai = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
        //        this.chObj.Cochukyten = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
        //        this.chObj.Cochudiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
        //        this.chObj.Letrai = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
        //        this.chObj.Mayin = sqlDataReader.GetString(12);
        //        this.chObj.Tenmayin = sqlDataReader.GetString(14);
        //        this.chObj.Hoadon = sqlDataReader.GetString(15);
        //        this.chObj.Tieude1 = sqlDataReader.GetString(16);
        //        this.chObj.Tieude2 = sqlDataReader.GetString(17);
        //        this.chObj.Tieude3 = sqlDataReader.GetString(18);
        //    }
        //    sqlConnection.Close();
        //}

        // Token: 0x06000D76 RID: 3446 RVA: 0x001DF878 File Offset: 0x001DDA78
        //private void GET_HANGHOA()
        //{
        //    DataTable dataSource = new DataTable();
        //    if (this.cobnhom.Text == "")
        //    {
        //        string dk;
        //        if (this.cobdk.SelectedIndex == 0)
        //        {
        //            dk = "";
        //        }
        //        else
        //        {
        //            dk = "where isnull(hhn.soluongTONG,0)" + this.cobdk.Text + "0";
        //        }
        //        dataSource = this.xhdCtr.GET_HANGHOA(dk);
        //    }
        //    else
        //    {
        //        string dk;
        //        if (this.cobdk.SelectedIndex == 0)
        //        {
        //            dk = "";
        //        }
        //        else
        //        {
        //            dk = " isnull(hhn.soluongTONG,0)" + this.cobdk.Text + "0 and";
        //        }
        //        dataSource = this.xhdCtr.GET_HANGHOATHEONHOM(dk, this.cobnhom.SelectedValue.ToString());
        //    }
        //    this.dgvtonkho.DataSource = dataSource;
        //}

        //// Token: 0x06000D77 RID: 3447 RVA: 0x001DF964 File Offset: 0x001DDB64
        //private void GET_HANGHOA1()
        //{
        //    DataTable dataSource = new DataTable();
        //    if (this.cobnhom.Text == "")
        //    {
        //        dataSource = this.xhdCtr.GET_HANGHOA1(this.cobdk.Text);
        //    }
        //    else
        //    {
        //        dataSource = this.xhdCtr.GET_HANGHOATHEONHOM1(this.cobdk.Text, this.cobnhom.SelectedValue.ToString());
        //    }
        //    this.dgvhanghoa.DataSource = dataSource;
        //}

        // Token: 0x06000D78 RID: 3448 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button2_Click(object sender, EventArgs e)
        {
            //base.Close();
        }

        // Token: 0x06000D79 RID: 3449 RVA: 0x001DF9E8 File Offset: 0x001DDBE8
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txttenhang.Text == "")
            //{
            //    this.txttenhang.Focus();
            //}
            //else if (this.txtmahang.Text == "")
            //{
            //    this.txtmahang.Focus();
            //}
            //else if (this.txtdonvi.Text == "")
            //{
            //    this.txtdonvi.Focus();
            //}
            //else
            //{
            //    this.themhanghoa(this.hhObj);
            //    this.GET_HANGHOA();
            //    this.txttenhang.Focus();
            //}
        }

        // Token: 0x06000D7A RID: 3450 RVA: 0x001DFA9C File Offset: 0x001DDC9C
        private void LOAD_kho()
        {
            //try
            //{
            //    BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText;
            //    if (TrangChu.dungnhieukho == "True")
            //    {
            //        bindingList.Add(new KeyValuePair<string, string>("00", "Tất cả KHO"));
            //        cmdText = "SELECT * FROM TB_KHO ORDER BY MAKHO";
            //    }
            //    else
            //    {
            //        cmdText = "SELECT * FROM TB_KHO WHERE MAKHO='" + frmLogIn.makho + "' ORDER BY MAKHO ";
            //    }
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(1)));
            //    }
            //    this.cob_kho.Items.Clear();
            //    this.cob_kho.DataSource = bindingList;
            //    this.cob_kho.ValueMember = "Key";
            //    this.cob_kho.DisplayMember = "Value";
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    Frm_kho frm_kho = new Frm_kho();
            //    frm_kho.ShowDialog();
            //}
        }

        // Token: 0x06000D7B RID: 3451 RVA: 0x001DFBE0 File Offset: 0x001DDDE0
        private void Frmhangtonkho_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.LOAD_kho();
            //    base.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //    this.cobdk.SelectedIndex = 1;
            //    this.dttungay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //    this.dtdenngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //    this.dgvhanghoa.BringToFront();
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.xhdCtr.GET_NHOMHANG();
            //    this.cobnhom.DataSource = dataSource;
            //    this.cobnhom.DisplayMember = "TENNHOM";
            //    this.cobnhom.ValueMember = "MANHOM";
            //    this.cobnhom.SelectedIndex = -1;
            //    if (TrangChu.INBAOCAO == "True")
            //    {
            //        this.button8.Enabled = true;
            //        this.button7.Enabled = true;
            //        this.button6.Enabled = true;
            //        this.button5.Enabled = true;
            //    }
            //    else
            //    {
            //        this.button8.Enabled = false;
            //        this.button7.Enabled = false;
            //        this.button6.Enabled = false;
            //        this.button5.Enabled = false;
            //    }
            //    if (TrangChu.dungkhonguyenlieu == "True")
            //    {
            //        this.panel4.Visible = true;
            //    }
            //    if (!(TrangChu.XEMGIAVON == "True"))
            //    {
            //        this.dgvtonsoluong.Columns["THANHTIENTK"].Visible = false;
            //        this.dgvtonsoluong.Columns["dgd"].Visible = false;
            //        this.dgvtonsoluong.Columns["dgnhap"].Visible = false;
            //        this.dgvtonsoluong.Columns["dgxuat"].Visible = false;
            //        this.dgvtonsoluong.Columns["dgton"].Visible = false;
            //        this.dgvhanghoa.Columns["dg"].Visible = false;
            //        this.dgvhanghoa.Columns["thanhtien"].Visible = false;
            //        this.dgvchitietnhap.Columns["giavon"].Visible = false;
            //        this.dgvtonkho.Columns["gia"].Visible = false;
            //        this.dgvtonkho.Columns["tt"].Visible = false;
            //    }
            //    if (TrangChu.giavon2 == "False")
            //    {
            //        this.dgvchitietnhap.Columns["Giavon2"].Visible = false;
            //    }
            //    this.dgvtonsoluong.CellPainting += this.dgvtonsoluong_CellPainting;
            //    this.dgvtonsoluong.Paint += this.dgvtonsoluong_Paint;
            //    this.dgvtonsoluong.Scroll += this.dgvtonsoluong_Scroll;
            //    this.dgvtonsoluong.ColumnWidthChanged += this.dgvtonsoluong_ColumnWidthChanged;
            //    this.dgvtonsoluong.EnableHeadersVisualStyles = false;
            //    this.dgvtonsoluong.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            //    this.dgvtonkho.EnableHeadersVisualStyles = false;
            //    this.dgvtonkho.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            //    if (TrangChu.hiengiavon == "True")
            //    {
            //        this.btonsl_Click(null, null);
            //    }
            //    else
            //    {
            //        this.bttonkho_Click(null, null);
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D7C RID: 3452 RVA: 0x001DFFD4 File Offset: 0x001DE1D4
        private void btnhapkho_Click(object sender, EventArgs e)
        {
            string makho = "";
            if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            {
                makho = " AND hhx.loai='" + this.cob_kho.SelectedValue.ToString() + "'";
            }
            string text = "";
            if (this.textBox3.Text != this.textBox3.Tag.ToString())
            {
                text = "AND HHX.NCC='" + this.textBox3.Text + "'";
            }
            this.IN = 2;
            string nhom = "";
            if (this.cobnhom.Text != "")
            {
                nhom = " AND HH.MANHOM='" + this.cobnhom.SelectedValue.ToString() + " '";
            }
            this.dgvhanghoa.BringToFront();
            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            DataTable dataSource = new DataTable();
            //  dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), nhom, text, makho);
            // this.dgvhanghoa.DataSource = dataSource;
            this.tongcong();
            this.txttongcong.Visible = true;
            this.txttt.Visible = true;
        }

        // Token: 0x06000D7D RID: 3453 RVA: 0x001E0158 File Offset: 0x001DE358
        private void dttungay_ValueChanged(object sender, EventArgs e)
        {
            if (this.dttungay.Value > this.dtdenngay.Value)
            {
                this.dtdenngay.Value = this.dttungay.Value;
            }
        }

        // Token: 0x06000D7E RID: 3454 RVA: 0x001E01A4 File Offset: 0x001DE3A4
        private void bttonkho_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.IN = 1;
            //    this.dgvtonkho.BringToFront();
            //    string makho = "";
            //    string text = "";
            //    if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //    {
            //        makho = " AND HN.LOAI='" + this.cob_kho.SelectedValue.ToString() + "'";
            //        text = " AND hhx.NCC='" + this.cob_kho.SelectedValue.ToString() + "'";
            //    }
            //    this.xhdCtr.THEMTONGHANGHOANHAP(makho);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE FROM TB_XUATTAM INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM]           ([MAHANGHOA]           ,[TENHANGHOA]           ,[DONVITINH]           ,[TENDONVI]           ,[SOLUONGTONG]           ,[SOLUONGLE]            ,[QUIDOI],DONGIA)\r\n           (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'',''AS tendonvi,\r\nCASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        " ELSE '0' END END AS SOLUONGTONG,ISNULL( CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH!=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        " ELSE '0' END END ,0)AS SOLUONGLE,HH.QUYDOI1,HHX.DONGIA FROM TB_CHITIETHOADON hhx, TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA and  HUY='FALSE' ",
            //        text,
            //        "  GROUP BY hhx.MAHANGHOA,hhx.TENHANGHOA ,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.DONGIA,LOAI,HH.TONDONVI)"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.xhdCtr.GET_TONKHO();
            //    this.GET_HANGHOA();
            //    this.dgvtonkho.BringToFront();
            //    this.tongcong1();
            //    this.txttongcong.Visible = true;
            //    this.txttt.Visible = true;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D7F RID: 3455 RVA: 0x001E0338 File Offset: 0x001DE538
        private void tongcong()
        {
            if (this.dgvhanghoa.RowCount > 0)
            {
                decimal d = 0m;
                for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
                {
                    d += decimal.Parse(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
                }
                this.txttongcong.Text = d.ToString("#,###");
            }
            else
            {
                this.txttongcong.Text = "0";
            }
        }

        // Token: 0x06000D80 RID: 3456 RVA: 0x001E03E4 File Offset: 0x001DE5E4
        private void tongcong1()
        {
            if (this.dgvtonkho.RowCount > 0)
            {
                this.thanhtoan = 0.0;
                this.tondau = 0.0;
                this.nhapvao = 0.0;
                this.xuatra = 0.0;
                this.conlai = 0.0;
                decimal num = 0m;
                for (int i = 0; i < this.dgvtonkho.RowCount; i++)
                {
                    this.thanhtoan += double.Parse(this.dgvtonkho.Rows[i].Cells["tt"].Value.ToString());
                    this.tondau += Convert.ToDouble(this.dgvtonkho["NHAP", i].Value.ToString());
                    this.nhapvao += Convert.ToDouble(this.dgvtonkho["XUAT", i].Value.ToString());
                    if (Convert.ToDouble(this.dgvtonkho["slt", i].Value.ToString()) > 0.0)
                    {
                        this.xuatra += Convert.ToDouble(this.dgvtonkho["slt", i].Value.ToString());
                    }
                }
                this.txttongcong.Text = num.ToString("#,##0");
                this.dgvtonkho.AllowUserToAddRows = true;
                this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                this.dgvtonkho["mh", this.dgvtonkho.Rows.Count - 1].Value = "TỔNG CỘNG";
                this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
                this.dgvtonkho["tt", this.dgvtonkho.Rows.Count - 1].Value = this.thanhtoan.ToString("#,##0");
                this.dgvtonkho["NHAP", this.dgvtonkho.Rows.Count - 1].Value = this.tondau.ToString("#,##0.##");
                this.dgvtonkho["XUAT", this.dgvtonkho.Rows.Count - 1].Value = this.nhapvao.ToString("#,##0.##");
                this.dgvtonkho["slt", this.dgvtonkho.Rows.Count - 1].Value = this.xuatra.ToString("#,##0.##");
            }
            else
            {
                this.txttongcong.Text = "0";
            }
        }

        // Token: 0x06000D81 RID: 3457 RVA: 0x001E0764 File Offset: 0x001DE964
        private void dgvhanghoa_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            {
                this.dgvhanghoa.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000D82 RID: 3458 RVA: 0x0001B637 File Offset: 0x00019837
        private void button3_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000D83 RID: 3459 RVA: 0x001E07B8 File Offset: 0x001DE9B8
        private void copyAlltoClipboard()
        {
            this.dgvchitietnhap.SelectAll();
            DataObject clipboardContent = this.dgvchitietnhap.GetClipboardContent();
            if (clipboardContent != null)
            {
                Clipboard.SetDataObject(clipboardContent);
            }
        }

        // Token: 0x06000D84 RID: 3460
        //   [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(int handle, out int processId);

        // Token: 0x06000D85 RID: 3461 RVA: 0x001E07F0 File Offset: 0x001DE9F0
        private void button4_Click(object sender, EventArgs e)
        {
            //if (TrangChu.XEMGIAVON == "True")
            //{
            //    string makho = "";
            //    if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //    {
            //        makho = " AND hhn.loai='" + this.cob_kho.SelectedValue.ToString() + "'";
            //    }
            //    this.dgvchitietnhap.BringToFront();
            //    Frmhangtonkho.nl = "1";
            //    this.IN = 4;
            //    string text = "";
            //    if (this.textBox3.Text != this.textBox3.Tag.ToString())
            //    {
            //        text = "AND HHN.NCC='" + this.textBox3.Text + "'";
            //    }
            //    string nhom = "";
            //    if (this.cobnhom.Text != "")
            //    {
            //        nhom = " AND HH.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            //    }
            //    DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //    DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_NHAP(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), text, nhom, makho);
            //    this.dgvchitietnhap.DataSource = dataSource;
            //    decimal d = 0m;
            //    if (this.dgvchitietnhap.RowCount > 0)
            //    {
            //        for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
            //        {
            //            d += Convert.ToDecimal(this.dgvchitietnhap["thanhtienct", i].Value.ToString());
            //            this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
            //        }
            //    }
            //    this.txttongcong.Text = d.ToString("#,##0");
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa được phân quyền xem giá vốn", "Thông báo");
            //}
        }

        // Token: 0x06000D86 RID: 3462 RVA: 0x001E0A34 File Offset: 0x001DEC34
        private void dgvchitietnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (this.dgvchitietnhap.RowCount > 0)
            //    {
            //        if (Convert.ToDateTime(this.dgvchitietnhap.Rows[this.dgvchitietnhap.CurrentCell.RowIndex].Cells["NGAYNHAP"].Value.ToString()).Month < DateTime.Now.AddMonths(-1).Month)
            //        {
            //            MessageBox.Show("Không được thay đổi phiếu nhập của tháng " + Convert.ToDateTime(this.dgvchitietnhap.Rows[this.dgvchitietnhap.CurrentCell.RowIndex].Cells["NGAYNHAP"].Value.ToString()).ToString("MM/yyyy"), "Thông báo");
            //        }
            //        else
            //        {
            //            int columnIndex = this.dgvchitietnhap.CurrentCell.ColumnIndex;
            //            if (this.dgvchitietnhap.Columns[columnIndex].Name == "XOA")
            //            {
            //                if (TrangChu.XOANHAP == "True")
            //                {
            //                    int index = this.dgvchitietnhap.CurrentRow.Index;
            //                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa  " + this.dgvchitietnhap.Rows[index].Cells["hanghoa"].Value.ToString() + "   không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //                    if (dialogResult == DialogResult.Yes)
            //                    {
            //                        string text = this.dgvchitietnhap.Rows[index].Cells["MAHANHOA"].Value.ToString();
            //                        string text2 = this.dgvchitietnhap.Rows[index].Cells["mahoadon"].Value.ToString();
            //                        string text3 = this.dgvchitietnhap.Rows[index].Cells["NGAYNHAP"].Value.ToString();
            //                        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                        sqlConnection.Open();
            //                        string cmdText;
            //                        if (Frmhangtonkho.nl == "1")
            //                        {
            //                            cmdText = string.Concat(new string[]
            //                            {
            //                                "DELETE FROM TB_HANGHOANHAP WHERE MAHANGHOA='",
            //                                text,
            //                                "' AND MAHOADON='",
            //                                text2,
            //                                "' and NGAYNHAP='",
            //                                text3,
            //                                "'"
            //                            });
            //                        }
            //                        else
            //                        {
            //                            cmdText = string.Concat(new string[]
            //                            {
            //                                "DELETE FROM TB_HANGHOANHAP_NL WHERE MAHANGHOA='",
            //                                text,
            //                                "' AND MAHOADON='",
            //                                text2,
            //                                "' and NGAYNHAP='",
            //                                text3,
            //                                "'"
            //                            });
            //                        }
            //                        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                        sqlCommand.ExecuteNonQuery();
            //                        this.dgvchitietnhap.Rows.RemoveAt(index);
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("BẠN KHÔNG ĐƯỢC QUYỀN XÓA", "THÔNG BÁO");
            //                }
            //            }
            //            if (this.dgvchitietnhap.Columns[columnIndex].Name == "sua")
            //            {
            //                if (TrangChu.XOANHAP == "True")
            //                {
            //                    int index = this.dgvchitietnhap.CurrentRow.Index;
            //                    Frmsuanhapkho.mahanghoa = this.dgvchitietnhap.Rows[index].Cells["MAHANHOA"].Value.ToString();
            //                    Frmsuanhapkho.gia_von2 = this.dgvchitietnhap.Rows[index].Cells["giavon2"].Value.ToString();
            //                    Frmsuanhapkho.mahoadon = this.dgvchitietnhap.Rows[index].Cells["mahoadon"].Value.ToString();
            //                    Frmsuanhapkho.soluongtong = this.dgvchitietnhap.Rows[index].Cells["SL5"].Value.ToString();
            //                    Frmsuanhapkho.soluongle = this.dgvchitietnhap.Rows[index].Cells["SL6"].Value.ToString();
            //                    Frmsuanhapkho.tenhanghoa = this.dgvchitietnhap.Rows[index].Cells["hanghoa"].Value.ToString();
            //                    Frmsuanhapkho.dongia = this.dgvchitietnhap.Rows[index].Cells["giavon"].Value.ToString();
            //                    Frmsuanhapkho.mancc = this.dgvchitietnhap.Rows[index].Cells["nccnhap"].Value.ToString();
            //                    Frmsuanhapkho.ngaynhap = this.dgvchitietnhap.Rows[index].Cells["NGAYNHAP"].Value.ToString();
            //                    Frmsuanhapkho frmsuanhapkho = new Frmsuanhapkho();
            //                    frmsuanhapkho.ShowDialog();
            //                    if (Frmhangtonkho.nl == "1")
            //                    {
            //                        this.button4_Click(null, null);
            //                    }
            //                    else
            //                    {
            //                        this.btchitietnhap_Click_1(null, null);
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("BẠN KHÔNG ĐƯỢC QUYỀN SỬA", "THÔNG BÁO");
            //                }
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000D87 RID: 3463 RVA: 0x001E0FEC File Offset: 0x001DF1EC
        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    int num = 5;
        //    int letrai = this.chObj.Letrai;
        //    int num2 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num2 + num));
        //    e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num2 + num + 25));
        //    e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num2 + num + 50));
        //    int num3 = num2 + num + 75 + 25;
        //    e.Graphics.DrawString("HÀNG TỒN KHO", new Font("Arial", 16f, FontStyle.Bold), Brushes.Black, new Point(370 + letrai, num3 - 25), stringFormat);
        //    int num4 = num3;
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num4 + 7));
        //    e.Graphics.DrawString("Tên Hàng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(80 + letrai, num4 + 7));
        //    e.Graphics.DrawString("ĐVT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(395 + letrai, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("SL Tổng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(455 + letrai, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("SL Lẻ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(505 + letrai, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("Đơn Giá", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(553 + letrai, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Thành Tiền", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(655 + letrai, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Ghi Chú", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(740 + letrai, num4 + 7), stringFormat2);
        //    int num5 = num4 + 40;
        //    using (Font font = new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num4 - 5), 780f, 40f);
        //        e.Graphics.DrawString("", font, Brushes.Blue, rectangleF);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    this.numberOfItemsPrintedSoFar = 0;
        //    this.numberOfItemsPerPage = 0;
        //    decimal d = 0m;
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvhanghoa.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > 25)
        //        {
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvhanghoa.Rows.Count)
        //        {
        //            using (Font font = new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num5 - 5), 780f, 30f);
        //                e.Graphics.DrawString("", font, Brushes.Blue, rectangleF);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + letrai, num5), stringFormat);
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["tenhang"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(35 + letrai, num5));
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["donvitinh"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(395 + letrai, num5), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.###"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(460 + letrai, num5), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(560 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDateTime(this.dgvhanghoa.Rows[i].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(730 + letrai, num5), stringFormat2);
        //            d += Convert.ToDecimal(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
        //            num5 += 30;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //    }
        //    int num6 = num5 - 165;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num3 + 50), 30f, (float)num6);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(365 + letrai), (float)(num3 + 50), 55f, (float)num6);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(420 + letrai), (float)(num3 + 50), 65f, (float)num6);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(560 + letrai), (float)(num3 + 50), 100f, (float)num6);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(660 + letrai), (float)(num3 + 50), 125f, (float)num6);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //}

        // Token: 0x06000D88 RID: 3464 RVA: 0x001E1A44 File Offset: 0x001DFC44
        private void button5_Click(object sender, EventArgs e)
        {
            //if (this.IN == 1)
            //{
            //    if (this.dgvtonkho.RowCount > 0)
            //    {
            //        new DGVPrinter
            //        {
            //            Title = "TỒN KHO",
            //            SubTitle = string.Format("Ngày In: {0}", DateTime.Now.ToString("HH:mm dd/MM/yyyy")),
            //            SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
            //            PageNumbers = true,
            //            PageNumberAlignment = StringAlignment.Center,
            //            PorportionalColumns = true,
            //            HeaderCellAlignment = StringAlignment.Near,
            //            FooterSpacing = 10f,
            //            FooterAlignment = StringAlignment.Far,
            //            printDocument =
            //            {
            //                DefaultPageSettings =
            //                {
            //                    Landscape = true
            //                }
            //            }
            //        }.PrintPreviewDataGridView(this.dgvtonkho);
            //    }
            //}
        }

        // Token: 0x06000D89 RID: 3465 RVA: 0x001E1B18 File Offset: 0x001DFD18
        private void button8_Click(object sender, EventArgs e)
        {
            if (this.IN == 4)
            {
                if (this.dgvchitietnhap.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "CHI TIẾT NHẬP",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 0f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvchitietnhap);
                }
            }
        }

        // Token: 0x06000D8A RID: 3466 RVA: 0x001E1BEC File Offset: 0x001DFDEC
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.IN == 3)
            {
                if (this.dgvhanghoa.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "THỐNG KÊ XUẤT",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 30f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvhanghoa);
                }
            }
        }

        // Token: 0x06000D8B RID: 3467 RVA: 0x001E1CC0 File Offset: 0x001DFEC0
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.IN == 2)
            {
                if (this.dgvhanghoa.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "THỐNG KÊ NHẬP",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 30f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvhanghoa);
                }
            }
        }

        // Token: 0x06000D8C RID: 3468 RVA: 0x001E1D94 File Offset: 0x001DFF94
        private void txttim_Leave(object sender, EventArgs e)
        {
            if (this.txttim.Text == "")
            {
                this.txttim.Text = this.txttim.Tag.ToString();
            }
        }

        // Token: 0x06000D8D RID: 3469 RVA: 0x001E1DDC File Offset: 0x001DFFDC
        private void txttim_Enter(object sender, EventArgs e)
        {
            if (this.txttim.Text == this.txttim.Tag.ToString())
            {
                this.txttim.Text = "";
            }
        }

        // Token: 0x06000D8E RID: 3470 RVA: 0x001E1E24 File Offset: 0x001E0024
        private void btxuat_Click(object sender, EventArgs e)
        {
            //string text = "";
            //if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //{
            //    text = " AND hhx.NCC='" + this.cob_kho.SelectedValue.ToString() + "'";
            //}
            //string text2 = "";
            //if (this.cobnhom.Text != "")
            //{
            //    text2 = " AND HH.MANHOM='" + this.cobnhom.SelectedValue.ToString() + " '";
            //}
            //this.IN = 3;
            //this.dgvhanghoa.BringToFront();
            //DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //DataTable dataSource = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE FROM TB_XUATTAM INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM]\r\n           ([MAHANGHOA]           ,[TENHANGHOA]           ,[DONVITINH]           ,[TENDONVI]           ,[SOLUONGTONG]           ,[SOLUONGLE]            ,[QUIDOI],[DONGIA],[NGAY])\r\n           (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,case when (HHX.DONVITINH)!=(HH.DONVITINH) then (HH.DONVITINHLON) ELSE (HH.DONVITINH) END AS DONVITINH,ISNULL(KH.TENDONVI,N'Khách lẻ') AS tendonvi,\r\ncase when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGTONG,\r\ncase when (HHX.DONVITINH)!=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGLE,HH.QUYDOI1,case when (HHX.DONVITINH)=(HH.DONVITINH) THEN HHX.DONGIABAN\r\nELSE HHX.DONGIABAN/",
            //    TrangChu.tile,
            //    " END AS DONGIABAN,RIGHT(HHX.NGAYXUAT,10) AS NGAY  FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH ,TB_HOADONBANHANG BH LEFT JOIN TB_KHACHHANG KH ON BH.MAKHACHHANG=KH.MAKHACHHANG WHERE BH.SOHOADON=HHX.MAHOADON AND HH.MAHANGHOA=HHX.MAHANGHOA ",
            //    text2,
            //    " ",
            //    text,
            //    " AND HHX.HUY='FALSE' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //    dateTime.ToString("MM/dd/yyyy"),
            //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //    dateTime2.ToString("MM/dd/yyyy"),
            //    "' GROUP BY RIGHT(HHX.NGAYXUAT,10),KH.TENDONVI, hhx.MAHANGHOA,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.DONGIABAN,(HH.DONVITINHLON))"
            //});
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //dataSource = this.xhdCtr.THEMTONGHANGHOAXUATNGAY(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
            //this.dgvhanghoa.DataSource = dataSource;
            //this.tongcong();
            //this.txttongcong.Visible = true;
            //this.txttt.Visible = true;
        }

        // Token: 0x06000D8F RID: 3471 RVA: 0x001E2008 File Offset: 0x001E0208
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            //string text = "";
            //if (this.cobnhom.Text != "")
            //{
            //    text = "and hh.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            //}
            //string makhoban = "";
            //if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //{
            //    makhoban = "and hhn.LOAI='" + this.cob_kho.SelectedValue.ToString() + "'";
            //}
            //string text2 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            //string text3 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            //if (this.txttim.Text != this.txttim.Tag.ToString())
            //{
            //    if (this.txttim.Text != "")
            //    {
            //        if (this.IN == 0)
            //        {
            //            try
            //            {
            //                DataTable dataTable = new DataTable();
            //                string text4;
            //                if (this.cobdk.SelectedIndex == 0)
            //                {
            //                    text4 = "";
            //                }
            //                else
            //                {
            //                    text4 = "AND ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0) " + this.cobdk.Text + " " + this.txtsl.Text;
            //                }
            //                string cmdText = string.Concat(new string[]
            //                {
            //                    "SELECT HH.MAHANGHOA,HH.TENHANGHOA,CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN HH.DONVITINH ELSE HH.DONVITINHLON END AS DONVITINH, CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(TD.SOLUONG,0)/HH.QUYDOI1 ELSE  ISNULL(TD.SOLUONG,0) END AS DAUKY,  ISNULL(TD.DONGIA ,0)  AS GIATON ,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(N.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(N.SOLUONG,0) END AS NHAP,  ISNULL(N.DONGIA,0)  AS GIANHAP,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(X.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(X.SOLUONG,0) END AS XUAT  ,ISNULL(X.DONGIA,0)  AS GIAXUAT , CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0))/HH.QUYDOI1 ELSE (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0)) END AS TON,   CASE WHEN  (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG ,0)-ISNULL(X.SOLUONG,0))>0 THEN(ISNULL(TD.DONGIA,0) *ISNULL(TD.SOLUONG,0) +ISNULL (N.DONGIA,0) * ISNULL( N.SOLUONG ,0) ) /(ISNULL(TD.SOLUONG,0)+ ISNULL( N.SOLUONG ,0))ELSE '0' END AS GIAVON   ,HH.MANHOM AS TENNHOM FROM ((TB_HANGHOA HH LEFT JOIN TB_TON0_3 TD ON HH.MAHANGHOA=TD.MAHANG )LEFT JOIN TB_TON0_4 N  ON HH.MAHANGHOA=N.MAHANG )LEFT JOIN TB_TON0_2 X ON HH.MAHANGHOA=X.MAHANG WHERE HH.TENHANGHOA LIKE N'%",
            //                    this.txttim.Text,
            //                    "%' ",
            //                    text4,
            //                    " ",
            //                    text,
            //                    "  OR HH.TENHANGHOA_KHONGDAU LIKE N'%",
            //                    this.txttim.Text,
            //                    "%' ",
            //                    text4,
            //                    " ",
            //                    text
            //                });
            //                SqlConnection sqlConnection = new SqlConnection();
            //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //                SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlConnection.Open();
            //                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //                sqlDataAdapter.Fill(dataTable);
            //                this.dgvtonsoluong.DataSource = dataTable;
            //                this.dgvtonsoluong.BringToFront();
            //                double num = 0.0;
            //                if (this.dgvtonsoluong.RowCount > 0)
            //                {
            //                    for (int i = 0; i < this.dgvtonsoluong.RowCount; i++)
            //                    {
            //                        try
            //                        {
            //                            this.dgvtonsoluong.Rows[i].Cells["THANHTIENTK"].Value = Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //                            this.dgvtonsoluong.Rows[i].Cells[0].Value = i + 1;
            //                        }
            //                        catch
            //                        {
            //                        }
            //                    }
            //                }
            //                this.txttongcong.Text = "0";
            //                this.txttongcong.Text = num.ToString("#,##0");
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        else if (this.IN == 4)
            //        {
            //            this.dgvchitietnhap.BringToFront();
            //            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //            DataTable dataTable = new DataTable();
            //            dataTable = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_CHITIET_DK(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txttim.Text, makhoban);
            //            this.dgvchitietnhap.DataSource = dataTable;
            //            if (this.dgvchitietnhap.RowCount > 0)
            //            {
            //                for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
            //                {
            //                    this.dgvchitietnhap["XOA", i].Value = "xóa";
            //                    this.dgvchitietnhap["sua", i].Value = "sửa";
            //                    this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
            //                }
            //            }
            //        }
            //        else if (this.IN == 2)
            //        {
            //            this.dgvhanghoa.BringToFront();
            //            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //            DataTable dataTable = new DataTable();
            //            dataTable = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_TIM(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txttim.Text);
            //            this.dgvhanghoa.DataSource = dataTable;
            //        }
            //        else if (this.IN == 3)
            //        {
            //            this.dgvhanghoa.BringToFront();
            //            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //            DataTable dataTable = new DataTable();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "DELETE FROM TB_XUATTAM INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM]\r\n           ([MAHANGHOA]           ,[TENHANGHOA]           ,[DONVITINH]           ,[TENDONVI]           ,[SOLUONGTONG]           ,[SOLUONGLE]            ,[QUIDOI],[DONGIA],[NGAY])\r\n           (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,case when (HHX.DONVITINH)!=(HH.DONVITINH) then (HH.DONVITINHLON) ELSE (HH.DONVITINH) END AS DONVITINH,ISNULL(KH.TENDONVI,N'Khách lẻ') AS tendonvi,\r\ncase when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGTONG,\r\ncase when (HHX.DONVITINH)!=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGLE,HH.QUYDOI1,case when (HHX.DONVITINH)=(HH.DONVITINH) THEN HHX.DONGIABAN\r\nELSE HHX.DONGIABAN/",
            //                TrangChu.tile,
            //                " END AS DONGIABAN,RIGHT(HHX.NGAYXUAT,10) AS NGAY  FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH ,TB_HOADONBANHANG BH LEFT JOIN TB_KHACHHANG KH ON BH.MAKHACHHANG=KH.MAKHACHHANG WHERE BH.SOHOADON=HHX.MAHOADON AND HH.MAHANGHOA=HHX.MAHANGHOA AND HH.TENHANGHOA LIKE '%",
            //                this.txttim.Text,
            //                "%' AND HHX.XUAT='XB' AND HHX.HUY='FALSE' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //                dateTime.ToString("MM/dd/yyyy"),
            //                "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //                dateTime2.ToString("MM/dd/yyyy"),
            //                "' GROUP BY RIGHT(HHX.NGAYXUAT,10),KH.TENDONVI, hhx.MAHANGHOA,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.DONGIABAN,(HH.DONVITINHLON))"
            //            });
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            dataTable = this.xhdCtr.THEMTONGHANGHOAXUATNGAY(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
            //            this.dgvhanghoa.DataSource = dataTable;
            //        }
            //        else if (this.IN == 1)
            //        {
            //            try
            //            {
            //                this.IN = 1;
            //                this.dgvtonkho.BringToFront();
            //                for (int i = 0; i < this.dgvtonkho.Rows.Count; i++)
            //                {
            //                    if (this.dgvtonkho["th", i].Value.ToString().ToUpper().Substring(0, this.txttim.Text.Length) == this.txttim.Text.ToUpper())
            //                    {
            //                        this.dgvtonkho.ClearSelection();
            //                        this.dgvtonkho.Rows[i].Selected = true;
            //                        this.dgvtonkho.CurrentCell = this.dgvtonkho.Rows[i].Cells["th"];
            //                        break;
            //                    }
            //                }
            //                this.txttongcong.Visible = true;
            //                this.txttt.Visible = true;
            //            }
            //            catch
            //            {
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000D90 RID: 3472 RVA: 0x001E2830 File Offset: 0x001E0A30
        private void txttim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txttim.Text != "")
                {
                    this.txttim_TextChanged(null, null);
                }
                else
                {
                    this.txttimma.Focus();
                }
            }
        }

        // Token: 0x06000D91 RID: 3473 RVA: 0x001E2884 File Offset: 0x001E0A84
        private void dgvtonkho_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvtonkho.RowCount; i++)
            {
                this.dgvtonkho.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000D92 RID: 3474 RVA: 0x001E28D8 File Offset: 0x001E0AD8
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text == this.textBox2.Tag.ToString())
            {
                this.textBox2.Text = "";
            }
        }

        // Token: 0x06000D93 RID: 3475 RVA: 0x001E2920 File Offset: 0x001E0B20
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                this.textBox2.Text = this.textBox2.Tag.ToString();
            }
        }

        // Token: 0x06000D94 RID: 3476 RVA: 0x001E2968 File Offset: 0x001E0B68
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != this.textBox2.Tag.ToString())
            {
                if (this.textBox2.Text != "")
                {
                    this.IN = 4;
                    string makho = "";
                    if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
                    {
                        makho = " AND HHX.LOAI='" + this.cob_kho.SelectedValue.ToString() + "'";
                    }
                    this.dgvchitietnhap.BringToFront();
                    DataTable dataSource = new DataTable();
                    // dataSource = this.xhdCtr.SOHOADONNHAP(this.textBox2.Text, this.timngay, makho);
                    this.dgvchitietnhap.DataSource = dataSource;
                    double num = 0.0;
                    if (this.dgvchitietnhap.RowCount > 0)
                    {
                        for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
                        {
                            num += Convert.ToDouble(this.dgvchitietnhap["thanhtienct", i].Value.ToString());
                        }
                    }
                    this.txttongcong.Visible = true;
                    this.txttt.Visible = false;
                    this.txttongcong.Text = num.ToString("#,##0");
                }
            }
        }

        // Token: 0x06000D95 RID: 3477 RVA: 0x001E2AF0 File Offset: 0x001E0CF0
        private void button9_Click(object sender, EventArgs e)
        {
            string makho = "";
            if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            {
                makho = " AND hN.loai='" + this.cob_kho.SelectedValue.ToString() + "'";
            }
            string text = "";
            if (this.textBox3.Text != this.textBox3.Tag.ToString())
            {
                text = " AND HN.NCC = '" + this.textBox3.Text + "'";
            }
            this.textBox2.Text = this.textBox2.Tag.ToString();
            this.txttongcong.Visible = true;
            this.txttt.Visible = true;
            this.dgvbangke.BringToFront();
            DataTable dataSource = new DataTable();
            // dataSource = this.xhdCtr.BANGKE_SOHOADONNHAP(Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"), text, makho);
            this.dgvbangke.DataSource = dataSource;
            double num = 0.0;
            for (int i = 0; i < this.dgvbangke.RowCount; i++)
            {
                num += double.Parse(this.dgvbangke.Rows[i].Cells["TONGTIEN"].Value.ToString());
                this.dgvbangke.Rows[i].Cells[0].Value = i + 1;
                this.dgvbangke.Rows[i].Cells["suaphieu"].Value = "sửa";
            }
            this.txttongcong.Text = num.ToString("#,##0");
        }

        // Token: 0x06000D96 RID: 3478 RVA: 0x001E2D10 File Offset: 0x001E0F10
        private void dgvbangke_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = this.dgvbangke.CurrentCell.RowIndex;
            this.timngay = " AND HHX.NGAYNHAP= '" + this.dgvbangke["Ngayhoadon", rowIndex].Value.ToString() + "'";
            this.textBox2.Text = this.dgvbangke["Sohoadon", rowIndex].Value.ToString();
        }

        // Token: 0x06000D97 RID: 3479 RVA: 0x001E2D88 File Offset: 0x001E0F88
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Frmnhapkhohanghoa.ngaynhapkho = "Ngày nhập kho:";
            //Frmnhapkhohanghoa.nhapkh = "True";
            //Frmnhapkhohanghoa frmnhapkhohanghoa = new Frmnhapkhohanghoa();
            //frmnhapkhohanghoa.ShowDialog();
        }

        // Token: 0x06000D98 RID: 3480 RVA: 0x001E2DB8 File Offset: 0x001E0FB8
        private void dgvbangke_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hóa đơn nhập số " + this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["Sohoadon"].Value.ToString() + "   không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = "DELETE FROM TB_HANGHOANHAP WHERE MAHOADON='" + this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["Sohoadon"].Value.ToString() + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        this.dgvbangke.Rows.RemoveAt(this.dgvbangke.CurrentRow.Index);
            //    }
            //}
        }

        // Token: 0x06000D99 RID: 3481 RVA: 0x001E2EDC File Offset: 0x001E10DC
        private void dgvbangke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvbangke.RowCount > 0)
            {
                int columnIndex = this.dgvbangke.CurrentCell.ColumnIndex;
                if (this.dgvbangke.Columns[columnIndex].Name == "suaphieu")
                {
                    //if (TrangChu.XOANHAP == "True")
                    //{
                    //    Frmsuancc.ngaynhapkho = this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["Ngayhoadon"].Value.ToString();
                    //    Frmsuancc.thanhtoan = this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["thanhtoan"].Value.ToString();
                    //    Frmsuancc.sohoadon = this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["Sohoadon"].Value.ToString();
                    //    Frmsuancc.makh = this.dgvbangke.Rows[this.dgvbangke.CurrentRow.Index].Cells["npp"].Value.ToString();
                    //    Frmsuancc frmsuancc = new Frmsuancc();
                    //    frmsuancc.ShowDialog();
                    //    if (Frmsuancc.sua == "1")
                    //    {
                    //        this.button9_Click(null, null);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("BẠN CHƯA PHÂN QUYỀN XÓA");
                    //}
                }
            }
        }

        // Token: 0x06000D9A RID: 3482 RVA: 0x001E3090 File Offset: 0x001E1290
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                this.textBox3.Text = this.textBox3.Tag.ToString();
            }
            this.textBox3.BackColor = Color.WhiteSmoke;
        }

        // Token: 0x06000D9B RID: 3483 RVA: 0x001E30E8 File Offset: 0x001E12E8
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (this.textBox3.Text == this.textBox3.Tag.ToString())
            {
                this.textBox3.Text = "";
            }
            this.textBox3.BackColor = Color.Yellow;
        }

        // Token: 0x06000D9C RID: 3484 RVA: 0x001E3140 File Offset: 0x001E1340
        private void button10_Click(object sender, EventArgs e)
        {
            //Frmkhachhang.chon = "nk";
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
            //this.textBox3.Text = Frmkhachhang.makhachhang;
        }

        // Token: 0x06000D9D RID: 3485 RVA: 0x001E3178 File Offset: 0x001E1378
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox3.Text != "")
                {
                    //string cmdText = "SELECT TENDONVI FROM tb_KHACHHANG where MAKHACHHANG=N'" + this.textBox3.Text + "'";
                    //SqlConnection sqlConnection = new SqlConnection();
                    //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                    //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                    //sqlConnection.Open();
                    //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    //if (sqlDataReader.Read())
                    //{
                    //    this.textBox4.Text = Convert.ToString(sqlDataReader.GetValue(0));
                    //}
                    //if (!sqlDataReader.HasRows)
                    //{
                    //    this.textBox4.Text = this.textBox4.Tag.ToString();
                    //}
                    //sqlConnection.Close();
                }
                else
                {
                    this.textBox4.Text = this.textBox4.Tag.ToString();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000D9E RID: 3486 RVA: 0x001E3288 File Offset: 0x001E1488
        private void btonsl_Click(object sender, EventArgs e)
        {
            this.IN = 0;
            this.IN = 0;
            if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            {
                string text = "MAKHO='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
                string text2 = "CT.NCC='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
                string text3 = "HN.LOAI='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
            }
            this.tonkho_nhieukho();
        }

        // Token: 0x06000D9F RID: 3487 RVA: 0x001E3348 File Offset: 0x001E1548
        private void tonkho_nhieukho()
        {
            //string text = "";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //DataTable dataTable = new DataTable();
            //DateTime dateTime = Convert.ToDateTime(this.dttungay.Text).AddMonths(-1);
            //int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            //string text2 = Convert.ToDateTime(this.dttungay.Text).AddMonths(-2).ToString("MM/01/yyyy");
            //string text3 = dateTime.ToString("MM/01/yyyy");
            //string text4 = dateTime.ToString("MM/" + num + "/yyyy");
            //string text5 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/01/yyyy").Substring(0, 10);
            //string text6 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy").Substring(0, 10);
            //string text7 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy").Substring(0, 10);
            //string text8 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy").Substring(0, 10);
            //string text9 = "";
            //if (this.cobnhom.Text != "")
            //{
            //    text = "hh.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            //}
            //if (this.cobdk.SelectedIndex == 0)
            //{
            //    if (text != "")
            //    {
            //        text9 = " WHERE ";
            //    }
            //}
            //else if (text != "")
            //{
            //    text9 = string.Concat(new string[]
            //    {
            //        " WHERE  (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0)) ",
            //        this.cobdk.Text,
            //        " ",
            //        this.txtsl.Text,
            //        " AND "
            //    });
            //}
            //else
            //{
            //    text9 = string.Concat(new string[]
            //    {
            //        " WHERE  (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0))",
            //        this.cobdk.Text,
            //        " ",
            //        this.txtsl.Text,
            //        " "
            //    });
            //}
            //string text10 = "";
            //string text11 = "";
            //string text12 = "";
            //if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //{
            //    text10 = "MAKHO='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
            //    text11 = "CT.NCC='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
            //    text12 = "HN.LOAI='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
            //}
            //SqlCommand sqlCommand = new SqlCommand("DELETE FROM TB_KHONHAPHANG_DAUKY", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT HH.MAHANGHOA as MAHANG,SUM( HN.SOLUONGQUYDOI ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA,HN.LOAI AS MAKHO FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE ",
            //    text12,
            //    " HN.MAHANGHOA=HH.MAHANGHOA AND convert(datetime, ngaynhap,103) >= '",
            //    text3,
            //    "' AND convert(datetime, ngaynhap,103)<='",
            //    text4,
            //    "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI having SUM( HN.SOLUONGQUYDOI )!=0"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT HN.MAHANG,SUM( HN.SOLUONG ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA,HN.MAKHO FROM TB_TON0 HN,TB_HANGHOA HH WHERE ",
            //    text10,
            //    " HN.MAHANG=HH.MAHANGHOA AND  NGAY = '",
            //    text2,
            //    "' GROUP BY HN.MAHANG,HH.QUYDOI1,HN.MAKHO having SUM( HN.SOLUONG)!=0"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT CT.MAHANGHOA,-CASE WHEN CT.LOAI='A'THEN \tCASE WHEN ((HH.DONVITINH))=(CT.DONVITINH) THEN CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG)ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)END  END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)  END AS SL, '0' , CT.NCC  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
            //    text11,
            //    " CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND convert(datetime,  CT.NGAYXUAT,103) >= '00:00 ",
            //    text3,
            //    "' AND  convert(datetime,  CT.NGAYXUAT,103) <='23:59 ",
            //    text4,
            //    "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI,HH.QUYDOI1,CT.NCC,HH.TONDONVI"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "DELETE FROM TB_TON0 WHERE ",
            //    text10,
            //    " NGAY='",
            //    text3,
            //    "'"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("INSERT INTO TB_TON0 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG ,MAX(DONGIA),'" + text3 + "' AS NGAY, MAKHO FROM TB_KHONHAPHANG_DAUKY  GROUP BY MAHANG, MAKHO", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_TON0_1", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_TON0_1 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG, MAX(DONGIA),'' as ngay,'",
            //    this.cob_kho.SelectedValue.ToString(),
            //    "' as makho FROM TB_TON0 WHERE ",
            //    text10,
            //    " NGAY='",
            //    text3,
            //    "' GROUP BY MAHANG HAVING SUM(SOLUONG)!=0"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_TON0_1 SELECT HH.MAHANGHOA as MAHANG,SUM( HN.SOLUONGQUYDOI ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA,'' as ngay,'",
            //    this.cob_kho.SelectedValue.ToString(),
            //    "' as makho FROM TB_HANGHOANHAP HN,TB_HANGHOA HH  WHERE ",
            //    text12,
            //    " HN.MAHANGHOA=HH.MAHANGHOA AND convert(datetime, ngaynhap,103)>= '00:00 ",
            //    text5,
            //    "' AND convert(datetime, ngaynhap,103)<'00:00 ",
            //    text6,
            //    "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI having SUM( HN.SOLUONGQUYDOI )!=0"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_TON0_1 SELECT CT.MAHANGHOA,-CASE WHEN CT.LOAI='A'THEN \tCASE WHEN ((HH.DONVITINH))=(CT.DONVITINH) THEN CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG)ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)END  END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  SUM(CT.TONGSOLUONG*HH.QUYDOI1)  END AS SL, SUM(CT.THANHTIEN) AS DONGIA,'' as ngay,'",
            //    this.cob_kho.SelectedValue.ToString(),
            //    "' as makho  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
            //    text11,
            //    " CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND convert(datetime,  CT.NGAYXUAT,103) >= '00:00 ",
            //    text5,
            //    "' AND  convert(datetime,  CT.NGAYXUAT,103) <'00:00 ",
            //    text6,
            //    "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI,HH.QUYDOI1,HH.TONDONVI"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_KHONHAPHANG_HIENTAI", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_KHONHAPHANG_HIENTAI SELECT HH.MAHANGHOA as MAHANG,SUM( HN.SOLUONGQUYDOI ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA FROM TB_HANGHOANHAP HN,TB_HANGHOA HH  WHERE ",
            //    text12,
            //    " HN.MAHANGHOA=HH.MAHANGHOA AND convert(datetime, ngaynhap,103)>= '",
            //    text7,
            //    "' AND convert(datetime, ngaynhap,103)<='",
            //    text8,
            //    "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI having SUM( HN.SOLUONGQUYDOI )!=0"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_KHOXUAT_MOI", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "INSERT INTO TB_KHOXUAT_MOI SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A'THEN \tCASE WHEN ((HH.DONVITINH))=(CT.DONVITINH) THEN CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END ELSE CASE WHEN HH.TONDONVI='FALSE' THEN SUM(CT.TONGSOLUONG)ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)END  END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  SUM(CT.TONGSOLUONG*HH.QUYDOI1)  END AS SL, SUM(CT.THANHTIEN) AS DONGIA  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
            //    text11,
            //    " CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND convert(datetime,  CT.NGAYXUAT,103) >= '00:00 ",
            //    text7,
            //    "' AND  convert(datetime,  CT.NGAYXUAT,103) <='23:59 ",
            //    text8,
            //    "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI,HH.QUYDOI1,HH.TONDONVI"
            //}), sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("INSERT INTO TB_KHONHAPHANG_HIENTAI SELECT MAHANG, -SUM(SOLUONG) AS SOLUONG,ROUND( MAX(DONGIA)/SUM(SOLUONG),0) FROM TB_KHOXUAT_MOI GROUP BY MAHANG  HAVING SUM(SOLUONG)<0", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_TON0_3", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("INSERT INTO TB_TON0_3 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG, MAX(DONGIA) FROM TB_TON0_1 GROUP BY MAHANG HAVING SUM(SOLUONG)!=0", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_TON0_4", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("INSERT INTO TB_TON0_4 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG,MAX(DONGIA) FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG  HAVING SUM(SOLUONG)!=0", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlCommand = new SqlCommand("DELETE FROM TB_TON0_2", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand = new SqlCommand("INSERT INTO TB_TON0_2 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG,SUM(DONGIA)/SUM(SOLUONG),'00' FROM TB_KHOXUAT_MOI GROUP BY MAHANG  HAVING SUM(SOLUONG)>0", sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //string cmdText = string.Concat(new string[]
            //{
            //    " SELECT HH.MAHANGHOA,HH.TENHANGHOA,HH.DONVITINH, CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(TD.SOLUONG,0)/HH.QUYDOI1 ELSE  ISNULL(TD.SOLUONG,0) END AS DAUKY,  ISNULL(TD.DONGIA ,0)  AS GIATON ,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(N.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(N.SOLUONG,0) END AS NHAP,  ISNULL(N.DONGIA,0)  AS GIANHAP,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(X.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(X.SOLUONG,0) END AS XUAT  ,ISNULL(X.DONGIA,0)  AS GIAXUAT , CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0))/HH.QUYDOI1 ELSE (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0)) END AS TON,   CASE WHEN ISNULL(TD.SOLUONG,0)>0 AND ISNULL(N.SOLUONG ,0)>0 THEN(ISNULL(TD.DONGIA,0) *ISNULL(TD.SOLUONG,0) +ISNULL (N.DONGIA,0) * ISNULL( N.SOLUONG ,0) ) /(ISNULL(TD.SOLUONG,0)+ ISNULL( N.SOLUONG ,0))  WHEN ISNULL(TD.SOLUONG,0)>0 AND ISNULL(N.SOLUONG ,0)<=0 THEN ISNULL(TD.DONGIA,0) WHEN ISNULL(TD.SOLUONG,0)<=0 AND ISNULL(N.SOLUONG ,0)>0 THEN ISNULL(N.DONGIA,0)  ELSE '0' END AS GIAVON   ,HH.MANHOM AS TENNHOM    FROM ((TB_HANGHOA HH LEFT JOIN TB_TON0_3 TD ON HH.MAHANGHOA=TD.MAHANG )LEFT JOIN TB_TON0_4 N  ON HH.MAHANGHOA=N.MAHANG )LEFT JOIN TB_TON0_2 X ON HH.MAHANGHOA=X.MAHANG    ",
            //    text9,
            //    " ",
            //    text,
            //    "  ORDER BY HH.MANHOM, HH.TENHANGHOA"
            //});
            //sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtonsoluong.DataSource = dataTable;
            //this.dgvtonsoluong.BringToFront();
            //this.thanhtoan = 0.0;
            //this.tondau = 0.0;
            //this.nhapvao = 0.0;
            //this.xuatra = 0.0;
            //this.conlai = 0.0;
            //if (this.dgvtonsoluong.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dgvtonsoluong.RowCount; i++)
            //    {
            //        try
            //        {
            //            this.dgvtonsoluong.Rows[i].Cells["THANHTIENTK"].Value = Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //            this.thanhtoan += Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //            this.tondau += Convert.ToDouble(this.dgvtonsoluong["SLD", i].Value.ToString());
            //            this.nhapvao += Convert.ToDouble(this.dgvtonsoluong["sltk", i].Value.ToString());
            //            this.xuatra += Convert.ToDouble(this.dgvtonsoluong["Xuattk", i].Value.ToString());
            //            if (Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString()) > 0.0)
            //            {
            //                this.conlai += Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString());
            //            }
            //            this.dgvtonsoluong.Rows[i].Cells[0].Value = i + 1;
            //        }
            //        catch
            //        {
            //        }
            //    }
            //    this.dgvtonsoluong.AllowUserToAddRows = true;
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dgvtonsoluong["Mahanghoa", this.dgvtonsoluong.Rows.Count - 1].Value = "TỔNG CỘNG";
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //    this.dgvtonsoluong["THANHTIENTK", this.dgvtonsoluong.Rows.Count - 1].Value = this.thanhtoan.ToString("#,##0");
            //    this.dgvtonsoluong["SLD", this.dgvtonsoluong.Rows.Count - 1].Value = this.tondau.ToString("#,##0.##");
            //    this.dgvtonsoluong["sltk", this.dgvtonsoluong.Rows.Count - 1].Value = this.nhapvao.ToString("#,##0.##");
            //    this.dgvtonsoluong["Xuattk", this.dgvtonsoluong.Rows.Count - 1].Value = this.xuatra.ToString("#,##0.##");
            //    this.dgvtonsoluong["tck", this.dgvtonsoluong.Rows.Count - 1].Value = this.conlai.ToString("#,##0.##");
            //}
            //this.txttongcong.Text = "0";
            //this.txttongcong.Text = this.thanhtoan.ToString("#,##0");
        }

        // Token: 0x06000DA0 RID: 3488 RVA: 0x001E40EC File Offset: 0x001E22EC
        private void tonkho_nhieukho(string makho, string makhoxuat, string makhoton)
        {
            string text = "";
            DataTable dataTable = new DataTable();
            string text2 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            string text3 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/01/yyyy");
            string text4 = Convert.ToDateTime(this.dttungay.Text).AddMonths(-1).ToString("MM/01/yyyy");
            string text5 = Convert.ToDateTime(Convert.ToDateTime(this.dttungay.Text).ToString("01/MM/yyyy")).AddDays(-1.0).ToString("MM/dd/yyyy");
            string text6 = Convert.ToDateTime(Convert.ToDateTime(this.dttungay.Text).ToString("01/MM/yyyy")).AddDays(-1.0).ToString("dd/MM/yyyy");
            string text7 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            string text8 = "";
            if (this.cobnhom.Text != "")
            {
                text = "hh.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            }
            if (this.cobdk.SelectedIndex == 0)
            {
                if (text != "")
                {
                    text8 = " WHERE ";
                }
            }
            else if (text != "")
            {
                text8 = string.Concat(new string[]
                {
                    " WHERE  ISNULL(NK.SOLUONG,0)- ISNULL(XK.SOLUONG,0)+ISNULL(TK.SOLUONG,0) ",
                    this.cobdk.Text,
                    " ",
                    this.txtsl.Text,
                    " AND "
                });
            }
            else
            {
                text8 = string.Concat(new string[]
                {
                    " WHERE  ISNULL(NK.SOLUONG,0)- ISNULL(XK.SOLUONG,0)+ISNULL(TK.SOLUONG,0) ",
                    this.cobdk.Text,
                    " ",
                    this.txtsl.Text,
                    " "
                });
            }
            string text9 = "";
            string text10 = "";
            if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            {
                text9 = "T.MAKHO='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
                text10 = "MAKHO='" + this.cob_kho.SelectedValue.ToString() + "' AND ";
            }
            string cmdText = string.Concat(new string[]
            {
                //"DELETE TB_KHONHAPHANG_DAUKY  INSERT INTO TB_KHONHAPHANG_DAUKY(MAHANG,SOLUONG,DONGIA,MAKHO) ( SELECT HH.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1,HN.LOAI FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE ",
                //makho,
                //" HN.MAHANGHOA=HH.MAHANGHOA AND CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),'",
                //text2,
                //"'),101)AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,-1,'",
                //text2,
                //"'))-1),DATEADD(mm,-1,'",
                //text2,
                //"')),101) GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI having SUM(ISNULL(HN.SOLUONGQUYDOI,0))!=0)  DELETE TB_KHOXUAT_DAUKY1  INSERT INTO TB_KHOXUAT_DAUKY1(MAHANG,SOLUONG,DONGIA,MAKHO) (SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A'THEN \tCASE WHEN ((HH.DONVITINH))=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
                //TrangChu.tile,
                //")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" END END AS SL, '0' , CT.NCC FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
                //makhoxuat,
                //" CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)<= '23:59 '+CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),'",
                //text2,
                //"'),101) AND CONVERT(datetime,CT.NGAYXUAT,103)>='00:00 ' + CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,-1,'",
                //text2,
                //"'))-1),DATEADD(mm,-1,'",
                //text2,
                //"')),101) GROUP BY CT.MAHANGHOA,(CT.DONVITINH),(HH.DONVITINH),CT.LOAI,HH.QUYDOI1,CT.NCC)      DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY,MAKHO)   (SELECT * FROM TB_TON0 WHERE ",
                //makhoton,
                //" MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),DATEADD(mm,-1,'",
                //text2,
                //"')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),DATEADD(mm,-1,'",
                //text2,
                //"')),101)))  DELETE TB_KHOXUAT_DAUKY2 INSERT INTO TB_KHOXUAT_DAUKY2(MAHANG,SOLUONG, DONGIA,MAKHO)(SELECT MAHANG,SUM(ISNULL(SOLUONG,0)),'0' , MAKHO FROM TB_KHOXUAT_DAUKY1 GROUP BY MAHANG,MAKHO)     DELETE TB_TON0_2 INSERT INTO TB_TON0_2(MAHANG,SOLUONG,DONGIA,MAKHO)  (SELECT T.MAHANG,ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0),T.DONGIA,CASE WHEN ISNULL(T.SOLUONG,0)!=0 THEN T.MAKHO ELSE K.MAKHO END AS MAKHO FROM TB_TON0 T LEFT JOIN TB_KHOXUAT_DAUKY2 K ON T.MAHANG=K.MAHANG AND T.MAKHO=K.MAKHO WHERE ",
                //text9,
                //" T.SOLUONG>0 AND ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0)>0 AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),DATEADD(mm,-1,'",
                //text2,
                //"')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),DATEADD(mm,-1,'",
                //text2,
                //"')),101)))   DELETE TB_KHOXUAT_DAUKY INSERT INTO TB_KHOXUAT_DAUKY(MAHANG,SOLUONG,DONGIA,MAKHO)      (SELECT CASE WHEN SUM(ISNULL(K.SOLUONG,0))!=0 THEN K.MAHANG ELSE T.MAHANG END AS MAHANG,CASE WHEN ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)>0         THEN ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)WHEN ISNULL(T.SOLUONG,0)=0     THEN ISNULL(K.SOLUONG,0) ELSE'0'END,'0', CASE WHEN ISNULL(T.SOLUONG,0)!=0 THEN T.MAKHO         ELSE K.MAKHO END AS MAKHO FROM TB_KHOXUAT_DAUKY2 K  FULL JOIN TB_TON0_1 T ON T.MAHANG=K.MAHANG AND T.MAKHO=K.MAKHO WHERE ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)!=0  GROUP BY K.MAHANG,T.MAHANG,T.SOLUONG,K.SOLUONG,K.MAKHO,T.MAKHO)  DELETE [TB_TON1]  INSERT INTO [TB_TON1](MAHANG,SOLUONG,DONGIA,NGAY,MAKHO)   (SELECT CASE WHEN SUM(ISNULL(B1.SOLUONG,0))!=0 THEN B1.MAHANG ELSE B2.MAHANG END AS MAHANG,SUM( ISNULL(B1.SOLUONG,0))-ISNULL(B2.SOLUONG,0),SUM(ISNULL(B1.SOLUONG,0) *ISNULL(B1.DONGIA,0))/SUM(ISNULL(B1.SOLUONG,1)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
                //text2,
                //"')),'00:00 ",
                //text2,
                //"'),101) ,case when sum(ISNULL(B1.SOLUONG,0))!=0 then B1.MAKHO ELSE B2.MAKHO END AS MAKHO FROM TB_KHONHAPHANG_DAUKY B1 FULL JOIN TB_KHOXUAT_DAUKY B2 ON B1.MAHANG=B2.MAHANG AND B1.MAKHO=B2.MAKHO GROUP BY B1.MAHANG,B2.MAHANG,B2.SOLUONG,B1.MAKHO,B2.MAKHO HAVING sum(ISNULL(B1.SOLUONG,0))-ISNULL(B2.SOLUONG,0)!=0) DELETE TB_KHONHAPHANG INSERT INTO TB_KHONHAPHANG(MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE ",
                //makho,
                //" HN.MAHANGHOA=HH.MAHANGHOA AND CONVERT(datetime,ngaynhap,103)> CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),'",
                //text2,
                //"'),101) AND CONVERT(datetime,ngaynhap,103)<'",
                //text2,
                //"' GROUP BY HH.MAHANGHOA,HH.QUYDOI1 HAVING SUM(HN.SOLUONG)*HH.QUYDOI1!=0)  DELETE TB_KHOXUAT  INSERT INTO TB_KHOXUAT(MAHANG,SOLUONG,DONGIA,MAKHO)(SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
                //TrangChu.tile,
                //")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" END END AS SL, '0',CT.NCC  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
                //makhoxuat,
                //" CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)>'23:59 '+CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
                //text2,
                //"')),'",
                //text2,
                //"'),101)AND CONVERT(datetime,CT.NGAYXUAT,103)<'00:00 '+'",
                //text2,
                //"' GROUP BY CT.MAHANGHOA,(CT.DONVITINH),(HH.DONVITINH),CT.LOAI,HH.QUYDOI1,CT.NCC)  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA,MAKHO)(SELECT MAHANG,SUM(SOLUONG),'0',MAKHO FROM TB_KHOXUAT GROUP BY MAHANG,MAKHO)   DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)   (SELECT CASE WHEN ISNULL(B1.SOLUONG,0)!=0 THEN B1.MAHANG ELSE B2.MAHANG END AS MAHANG ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)ELSE '0' END,ISNULL(B1.DONGIA ,0)    FROM TB_TON0_2 B1 FULL JOIN TB_KHOXUAT_1 B2 ON B1.MAHANG=B2.MAHANG AND B1.MAKHO=B2.MAKHO   WHERE ISNULL(B1.SOLUONG,0)>0 AND ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)!=0 )    DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA,MAKHO)       (SELECT CASE WHEN ISNULL(T2.SOLUONG,0)!=0 THEN T2.MAHANG WHEN ISNULL(B2.SOLUONG,0)!=0 THEN B2.MAHANG ELSE B1.MAHANG END AS MAHANG       ,CASE WHEN ISNULL(T2.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-SUM(ISNULL(T2.SOLUONG,0))>0        THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0) END ELSE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)      END,ISNULL(B1.DONGIA ,0) ,CASE WHEN ISNULL(T2.SOLUONG,0)!=0 THEN T2.MAKHO WHEN ISNULL(B2.SOLUONG,0)!=0 THEN B2.MAKHO ELSE B1.MAKHO END as makho           FROM TB_TON1 B1 FULL JOIN TB_KHOXUAT_1 B2 ON B1.MAHANG=B2.MAHANG AND B1.MAKHO=B2.MAKHO FULL JOIN TB_TON0_2 T2 ON B2.MAHANG=T2.MAHANG        AND T2.MAKHO=B2.MAKHO  GROUP BY B1.MAHANG,B2.MAHANG,T2.MAHANG ,B1.DONGIA, T2.MAKHO,B1.MAKHO ,B2.MAKHO,ISNULL(B1.SOLUONG,0),ISNULL(B2.SOLUONG,0),ISNULL(T2.SOLUONG,0)) DELETE [TB_TON3]  INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,ISNULL(B2.DONGIA ,0) FROM ((TB_HANGHOA HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0)HAVING (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))!=0) DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)     (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP   HN  WHERE ",
                //makho,
                //" CONVERT(datetime,ngaynhap,103)>='",
                //text2,
                //"' AND CONVERT(datetime,ngaynhap,103)<='",
                //text7,
                //"' GROUP BY MAHANGHOA HAVING SUM(ISNULL(SOLUONGQUYDOI,1))!=0)      DELETE [TB_XUAT_TAM] INSERT INTO [TB_XUAT_TAM](MAHANG,SOLUONG,DONGIA) (SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A'THEN \tCASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
                //TrangChu.tile,
                //")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
                //TrangChu.doicm,
                //" END END AS SL,SUM(CT.THANHTIEN) AS GIABAN  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
                //makhoxuat,
                //" CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND CONVERT(datetime,CT.NGAYXUAT,103)>= '00:00 ",
                //text2,
                //"' AND CONVERT(datetime,CT.NGAYXUAT,103)<='23:29 ",
                //text7,
                //"' GROUP BY CT.MAHANGHOA,(CT.DONVITINH),(HH.DONVITINH),CT.LOAI,HH.QUYDOI1)   DELETE [TB_XUATTAM_1] INSERT INTO [TB_XUATTAM_1](MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(SOLUONG),'0' FROM [TB_XUAT_TAM] GROUP BY MAHANG)      DELETE [TB_TON0_4] INSERT INTO [TB_TON0_4](MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON0_3 B1 ON HH.MAHANGHOA=    B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG WHERE B1.SOLUONG!=0)    DELETE [TB_TON4]    INSERT INTO [TB_TON4](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,ISNULL(B2.SOLUONG,0)-(ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA=    B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_3 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)  DELETE [TB_TON5] INSERT INTO [TB_TON5](MAHANG,SOLUONG,DONGIA)   (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>=0THEN ISNULL(B2.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0)END,ISNULL(B2.DONGIA ,0) FROM ((TB_HANGHOA HH LEFT JOIN TB_TON4 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_TON3 B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0)HAVING (ISNULL(B1.SOLUONG,0)+SUM(ISNULL(B2.SOLUONG,0)))!=0)     DELETE [TB_TON6] INSERT INTO [TB_TON6](MAHANG,SOLUONG,DONGIA) (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B.SOLUONG,0)END,ISNULL(B1.DONGIA ,0) FROM (TB_HANGHOA HH LEFT JOIN TB_TON5 B ON HH.MAHANGHOA=B.MAHANG)LEFT JOIN [TB_TONKHOCUOI] B1 ON HH.MAHANGHOA=B1.MAHANG GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B.SOLUONG,0) HAVING ISNULL(B1.SOLUONG,0)!=0 AND SUM(ISNULL(B.SOLUONG,0))!=0 )  DELETE TB_KHONHAPHANG_HIENTAI INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON0_3 WHERE SOLUONG>0)     INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SOLUONG,DONGIA FROM TB_TON2 WHERE SOLUONG>0)INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON3 WHERE SOLUONG!=0) INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_KHONHAPHANG WHERE SOLUONG<0  AND NOT EXISTS (SELECT MAHANG from tb_ton3 where TB_KHONHAPHANG.MAHANG= TB_TON3.MAHANG)) DELETE TB_KHOXUAT_MOI INSERT INTO TB_KHOXUAT_MOI(MAHANG,SOLUONG,DONGIA) (SELECT MAHANG,SUM(SOLUONG),SUM(SOLUONG*DONGIA)/sum(ISNULL(SOLUONG,0)) FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG HAVING SUM(SOLUONG)!=0)  DELETE TB_TON0 WHERE ",
                //text10,
                //" YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
                //text2,
                //"')),'00:00 ",
                //text2,
                //"'),101)) AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
                //text2,
                //"')),'00:00 ",
                //text2,
                //"'),101))  INSERT INTO [TB_TON0](MAHANG,SOLUONG,DONGIA,NGAY,MAKHO)(SELECT CASE WHEN ISNULL(T1.SOLUONG,0)!=0 THEN T1.MAHANG ELSE T2.MAHANG END AS MAHANG,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))/(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
                //text2,
                //"')),'00:00 ",
                //text2,
                //"'),101),CASE WHEN ISNULL(T1.SOLUONG,0)!=0 THEN T1.MAKHO ELSE T2.MAKHO END AS MAKHO FROM TB_TON1 T1  FULL JOIN TB_TON0_2 T2 ON T1.MAHANG=T2.MAHANG AND T1.MAKHO=T2.MAKHO WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)!=0)  DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)(  SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG!=0  GROUP BY MAHANG) DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG) DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)  DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)(SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM [TB_XUATTRONGKY] NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG having SUM(SOLUONG)!=0)  SELECT HH.MAHANGHOA,HH.TENHANGHOA,CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN HH.DONVITINH ELSE HH.DONVITINHLON END AS DONVITINH,CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(NK.SOLUONG,0)/HH.QUYDOI1 ELSE  ISNULL(NK.SOLUONG,0) END AS DAUKY,ISNULL(NK.DONGIA,0) AS GIATON ,   CASE WHEN ISNULL(XK.SOLUONG,0)/HH.QUYDOI1<0 THEN CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN (ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))/HH.QUYDOI1 ELSE (ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)) END  ELSE CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(TK.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(TK.SOLUONG,0)/HH.QUYDOI1 END END AS NHAP, ISNULL(TK.DONGIA,0)AS GIANHAP,  CASE WHEN ISNULL(XK.SOLUONG,0)/HH.QUYDOI1>0 THEN CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(XK.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(XK.SOLUONG,0) END ELSE '0' END AS XUAT,CASE WHEN ISNULL(XK.SOLUONG,0)/HH.QUYDOI1>0 THEN ISNULL(XK.DONGIA,0)*HH.QUYDOI1 ELSE'0' END   AS GIAXUAT ,CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN (ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))/HH.QUYDOI1 ELSE (ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)) END AS TON,     CASE WHEN ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)!=0  THEN CASE WHEN ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)>0   THEN CASE WHEN ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)!=0 THEN  ((ISNULL(NK.DONGIA,0)*(ISNULL(NK.SOLUONG,0)))+(ISNULL(TK.DONGIA,0)*ISNULL(TK.SOLUONG,0)))  /(ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0))  ELSE '0' END   ELSE ISNULL(TK.DONGIA,0) END ELSE '0' END AS GIAVON   ,HH.MANHOM AS TENNHOM    FROM ((TB_HANGHOA HH LEFT JOIN TB_DK1 NK ON HH.MAHANGHOA=NK.MAHANG )LEFT JOIN TB_TK1 TK      ON HH.MAHANGHOA=TK.MAHANG )LEFT JOIN TB_XTK1 XK ON HH.MAHANGHOA=XK.MAHANG    ",
                //text8,
                //" ",
                //text,
                //"  ORDER BY HH.MANHOM, HH.TENHANGHOA"
            });
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtonsoluong.DataSource = dataTable;
            //this.dgvtonsoluong.BringToFront();
            //this.thanhtoan = 0.0;
            //this.tondau = 0.0;
            //this.nhapvao = 0.0;
            //this.xuatra = 0.0;
            //this.conlai = 0.0;
            //if (this.dgvtonsoluong.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dgvtonsoluong.RowCount; i++)
            //    {
            //        try
            //        {
            //            this.dgvtonsoluong.Rows[i].Cells["THANHTIENTK"].Value = Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //            this.thanhtoan += Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //            this.tondau += Convert.ToDouble(this.dgvtonsoluong["SLD", i].Value.ToString());
            //            this.nhapvao += Convert.ToDouble(this.dgvtonsoluong["sltk", i].Value.ToString());
            //            this.xuatra += Convert.ToDouble(this.dgvtonsoluong["Xuattk", i].Value.ToString());
            //            if (Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString()) > 0.0)
            //            {
            //                this.conlai += Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString());
            //            }
            //            this.dgvtonsoluong.Rows[i].Cells[0].Value = i + 1;
            //        }
            //        catch
            //        {
            //        }
            //    }
            //    this.dgvtonsoluong.AllowUserToAddRows = true;
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //    this.dgvtonsoluong["Mahanghoa", this.dgvtonsoluong.Rows.Count - 1].Value = "TỔNG CỘNG";
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //    this.dgvtonsoluong["THANHTIENTK", this.dgvtonsoluong.Rows.Count - 1].Value = this.thanhtoan.ToString("#,##0");
            //    this.dgvtonsoluong["SLD", this.dgvtonsoluong.Rows.Count - 1].Value = this.tondau.ToString("#,##0.##");
            //    this.dgvtonsoluong["sltk", this.dgvtonsoluong.Rows.Count - 1].Value = this.nhapvao.ToString("#,##0.##");
            //    this.dgvtonsoluong["Xuattk", this.dgvtonsoluong.Rows.Count - 1].Value = this.xuatra.ToString("#,##0.##");
            //    this.dgvtonsoluong["tck", this.dgvtonsoluong.Rows.Count - 1].Value = this.conlai.ToString("#,##0.##");
            //}
            this.txttongcong.Text = "0";
            this.txttongcong.Text = this.thanhtoan.ToString("#,##0");
        }

        // Token: 0x06000DA1 RID: 3489 RVA: 0x001E4CB0 File Offset: 0x001E2EB0
        private void dgvtonsoluong_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle displayRectangle = this.dgvtonsoluong.DisplayRectangle;
            displayRectangle.Height = this.dgvtonsoluong.ColumnHeadersHeight / 2;
            this.dgvtonsoluong.Invalidate(displayRectangle);
        }

        // Token: 0x06000DA2 RID: 3490 RVA: 0x001E4CB0 File Offset: 0x001E2EB0
        private void dgvtonsoluong_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle displayRectangle = this.dgvtonsoluong.DisplayRectangle;
            displayRectangle.Height = this.dgvtonsoluong.ColumnHeadersHeight / 2;
            this.dgvtonsoluong.Invalidate(displayRectangle);
        }

        // Token: 0x06000DA3 RID: 3491 RVA: 0x001E4CEC File Offset: 0x001E2EEC
        private void dgvtonsoluong_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string[] array = new string[]
                {
                    "",
                    "",
                    "Tồn đầu kỳ",
                    "Nhập trong kỳ",
                    "Xuất trong kỳ",
                    "Còn Tồn"
                };
                for (int i = 5; i < 13; i += 2)
                {
                    Rectangle cellDisplayRectangle = this.dgvtonsoluong.GetCellDisplayRectangle(i, -1, true);
                    int width = this.dgvtonsoluong.GetCellDisplayRectangle(i + 1, -1, true).Width;
                    cellDisplayRectangle.X++;
                    cellDisplayRectangle.Y++;
                    cellDisplayRectangle.Width = cellDisplayRectangle.Width + width - 2;
                    cellDisplayRectangle.Height = cellDisplayRectangle.Height / 2 - 2;
                    e.Graphics.FillRectangle(new SolidBrush(this.dgvtonsoluong.ColumnHeadersDefaultCellStyle.BackColor), cellDisplayRectangle);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(array[i / 2], this.dgvtonsoluong.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(this.dgvtonsoluong.ColumnHeadersDefaultCellStyle.ForeColor), cellDisplayRectangle, stringFormat);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000DA4 RID: 3492 RVA: 0x001E4E64 File Offset: 0x001E3064
        private void dgvtonsoluong_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle cellBounds = e.CellBounds;
                cellBounds.Y += e.CellBounds.Height / 2;
                cellBounds.Height = e.CellBounds.Height / 2;
                e.PaintBackground(cellBounds, true);
                e.PaintContent(cellBounds);
                e.Handled = true;
            }
        }

        // Token: 0x06000DA5 RID: 3493 RVA: 0x001E4EE8 File Offset: 0x001E30E8
        private void xuatexcel_tonkho()
        {
            //if (this.dgvtonsoluong.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\tonkho.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmhangtonkho.< xuatexcel_tonkho > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frmhangtonkho.< xuatexcel_tonkho > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmhangtonkho)));
            //    }
            //    Worksheet worksheet = Frmhangtonkho.< xuatexcel_tonkho > o__SiteContainer0.<> p__Site1.Target(Frmhangtonkho.< xuatexcel_tonkho > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //    worksheet.Cells[2, 1] = this.chObj.Diachi;
            //    worksheet.Cells[3, 1] = this.chObj.Dienthoai;
            //    worksheet.Cells[1, 7] = this.chObj.Tieude1;
            //    worksheet.Cells[2, 7] = this.chObj.Tieude2;
            //    worksheet.Cells[3, 7] = this.chObj.Tieude3;
            //    worksheet.Cells[5, 1] = "Từ " + this.dttungay.Text + " đến " + this.dtdenngay.Text;
            //    int num = 7;
            //    for (int i = 0; i < this.dgvtonsoluong.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvtonsoluong.Columns.Count; j++)
            //        {
            //            if (j == this.dgvtonsoluong.Columns.Count - 1)
            //            {
            //                worksheet.Cells[i + 8, j + 2] = this.dgvtonsoluong.Rows[i].Cells[j].Value;
            //            }
            //            else
            //            {
            //                worksheet.Cells[i + 8, j + 1] = this.dgvtonsoluong.Rows[i].Cells[j].Value;
            //            }
            //        }
            //        Range range = worksheet.get_Range("A" + num, "O" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //        worksheet.Cells[num, 14] = worksheet.Cells[num, 2];
            //    }
            //    Range range2 = worksheet.get_Range("D" + 8, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("H" + 8, "H" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 8, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("B" + 8, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("J" + 8, "J" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("L" + 8, "L" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("N" + 8, "N" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvtonsoluong.RowCount + 8, 7] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    worksheet.Cells[this.dgvtonsoluong.RowCount + 9, 7] = "NGƯỜI LẬP";
            //}
        }

        // Token: 0x06000DA6 RID: 3494 RVA: 0x0001E649 File Offset: 0x0001C849
        private void btxcel_ton_Click(object sender, EventArgs e)
        {
            //this.loadcauhinh();
            this.xuatexcel_tonkho();
        }

        // Token: 0x06000DA7 RID: 3495 RVA: 0x0001E65A File Offset: 0x0001C85A
        private void cobnhom_Enter(object sender, EventArgs e)
        {
            this.cobnhom.BackColor = Color.Yellow;
        }

        // Token: 0x06000DA8 RID: 3496 RVA: 0x0001E66E File Offset: 0x0001C86E
        private void cobnhom_Leave(object sender, EventArgs e)
        {
            this.cobnhom.BackColor = Color.WhiteSmoke;
        }

        // Token: 0x06000DA9 RID: 3497 RVA: 0x0001E682 File Offset: 0x0001C882
        private void cobdk_Leave(object sender, EventArgs e)
        {
            this.cobdk.BackColor = Color.WhiteSmoke;
        }

        // Token: 0x06000DAA RID: 3498 RVA: 0x0001E696 File Offset: 0x0001C896
        private void cobdk_Enter(object sender, EventArgs e)
        {
            this.cobdk.BackColor = Color.Yellow;
        }

        // Token: 0x06000DAB RID: 3499 RVA: 0x001E5520 File Offset: 0x001E3720
        private void txttimma_Leave(object sender, EventArgs e)
        {
            if (this.txttimma.Text == "")
            {
                this.txttimma.Text = this.txttimma.Tag.ToString();
            }
        }

        // Token: 0x06000DAC RID: 3500 RVA: 0x001E5568 File Offset: 0x001E3768
        private void txttimma_Enter(object sender, EventArgs e)
        {
            if (this.txttimma.Text == this.txttimma.Tag.ToString())
            {
                this.txttimma.Text = "";
            }
        }

        // Token: 0x06000DAD RID: 3501 RVA: 0x001E55B0 File Offset: 0x001E37B0
        private void txttimma_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            if (this.cobnhom.Text != "")
            {
                text = "and hh.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            }
            string text2 = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            string text3 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            if (this.txttimma.Text != this.txttimma.Tag.ToString())
            {
                if (this.txttimma.Text != "")
                {
                    if (this.IN == 0)
                    {
                        try
                        {
                            DataTable dataTable = new DataTable();
                            string text4;
                            if (this.cobdk.SelectedIndex == 0)
                            {
                                text4 = "";
                            }
                            else
                            {
                                text4 = "AND ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0) " + this.cobdk.Text + " " + this.txtsl.Text;
                            }
                            string cmdText = string.Concat(new string[]
                            {
                                "SELECT HH.MAHANGHOA,HH.TENHANGHOA,CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN HH.DONVITINH ELSE HH.DONVITINHLON END AS DONVITINH, CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(TD.SOLUONG,0)/HH.QUYDOI1 ELSE  ISNULL(TD.SOLUONG,0) END AS DAUKY,  ISNULL(TD.DONGIA ,0)  AS GIATON ,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(N.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(N.SOLUONG,0) END AS NHAP,  ISNULL(N.DONGIA,0)  AS GIANHAP,  CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN ISNULL(X.SOLUONG,0)/HH.QUYDOI1 ELSE ISNULL(X.SOLUONG,0) END AS XUAT  ,ISNULL(X.DONGIA,0)  AS GIAXUAT , CASE WHEN ISNULL(HH.TONDONVI,'FALSE')='FALSE' THEN (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0))/HH.QUYDOI1 ELSE (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG,0)-ISNULL(X.SOLUONG,0)) END AS TON,   CASE WHEN  (ISNULL(TD.SOLUONG,0)+ISNULL(N.SOLUONG ,0)-ISNULL(X.SOLUONG,0))>0 THEN(ISNULL(TD.DONGIA,0) *ISNULL(TD.SOLUONG,0) +ISNULL (N.DONGIA,0) * ISNULL( N.SOLUONG ,0) ) /(ISNULL(TD.SOLUONG,0)+ ISNULL( N.SOLUONG ,0))ELSE '0' END AS GIAVON   ,HH.MANHOM AS TENNHOM FROM ((TB_HANGHOA HH LEFT JOIN TB_TON0_3 TD ON HH.MAHANGHOA=TD.MAHANG )LEFT JOIN TB_TON0_4 N  ON HH.MAHANGHOA=N.MAHANG )LEFT JOIN TB_TON0_2 X ON HH.MAHANGHOA=X.MAHANG WHERE  HH.MAHANGHOA LIKE '",
                                this.txttimma.Text,
                                "%' ",
                                text4,
                                " ",
                                text
                            });
                            //SqlConnection sqlConnection = new SqlConnection();
                            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
                            //sqlConnection.Open();
                            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                            //sqlDataAdapter.Fill(dataTable);
                            //this.dgvtonsoluong.DataSource = dataTable;
                            //this.dgvtonsoluong.BringToFront();
                            //if (this.dgvtonsoluong.RowCount > 0)
                            //{
                            //    for (int i = 0; i < this.dgvtonsoluong.RowCount; i++)
                            //    {
                            //        try
                            //        {
                            //            this.dgvtonsoluong.Rows[i].Cells["THANHTIENTK"].Value = Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
                            //            this.dgvtonsoluong.Rows[i].Cells[0].Value = i + 1;
                            //        }
                            //        catch
                            //        {
                            //        }
                            //    }
                            //}
                        }
                        catch
                        {
                        }
                    }
                    else if (this.IN == 4)
                    {
                        string makho = "";
                        if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
                        {
                            makho = "and hhn.LOAI='" + this.cob_kho.SelectedValue.ToString() + "'";
                        }
                        this.dgvchitietnhap.BringToFront();
                        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                        DataTable dataTable = new DataTable();
                        // dataTable = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_MAHANG(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txttimma.Text, makho);
                        this.dgvchitietnhap.DataSource = dataTable;
                        if (this.dgvchitietnhap.RowCount > 0)
                        {
                            for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
                            {
                                this.dgvchitietnhap["XOA", i].Value = "xóa";
                                this.dgvchitietnhap["sua", i].Value = "sửa";
                                this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
                            }
                        }
                    }
                    else if (this.IN == 2)
                    {
                        this.dgvhanghoa.BringToFront();
                        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                        DataTable dataTable = new DataTable();
                        //  dataTable = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_TIMMA(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txttimma.Text);
                        this.dgvhanghoa.DataSource = dataTable;
                    }
                    else if (this.IN == 3)
                    {
                        //this.dgvhanghoa.BringToFront();
                        //DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                        //DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                        //DataTable dataTable = new DataTable();
                        //string cmdText = string.Concat(new string[]
                        //{
                        //    "DELETE FROM TB_XUATTAM INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM]\r\n           ([MAHANGHOA]           ,[TENHANGHOA]           ,[DONVITINH]           ,[TENDONVI]           ,[SOLUONGTONG]           ,[SOLUONGLE]            ,[QUIDOI],[DONGIA],[NGAY])\r\n           (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,case when (HHX.DONVITINH)!=(HH.DONVITINH) then (HH.DONVITINHLON) ELSE (HH.DONVITINH) END AS DONVITINH,ISNULL(KH.TENDONVI,N'Khách lẻ') AS tendonvi,\r\ncase when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGTONG,\r\ncase when (HHX.DONVITINH)!=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGLE,HH.QUYDOI1,case when (HHX.DONVITINH)=(HH.DONVITINH) THEN HHX.DONGIABAN\r\nELSE HHX.DONGIABAN/",
                        //    TrangChu.tile,
                        //    " END AS DONGIABAN,RIGHT(HHX.NGAYXUAT,10) AS NGAY  FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH ,TB_HOADONBANHANG BH LEFT JOIN TB_KHACHHANG KH ON BH.MAKHACHHANG=KH.MAKHACHHANG WHERE BH.SOHOADON=HHX.MAHOADON AND HH.MAHANGHOA=HHX.MAHANGHOA AND HH.MAHANGHOA LIKE '%",
                        //    this.txttimma.Text,
                        //    "%' AND HHX.XUAT='XB' AND HHX.HUY='FALSE' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
                        //    dateTime.ToString("MM/dd/yyyy"),
                        //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
                        //    dateTime2.ToString("MM/dd/yyyy"),
                        //    "' GROUP BY RIGHT(HHX.NGAYXUAT,10),KH.TENDONVI, hhx.MAHANGHOA,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.DONGIABAN,(HH.DONVITINHLON))"
                        //});
                        //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                        //sqlConnection.Open();
                        //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                        //sqlCommand.ExecuteNonQuery();
                        //dataTable = this.xhdCtr.THEMTONGHANGHOAXUATNGAY(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
                        //this.dgvhanghoa.DataSource = dataTable;
                    }
                    else if (this.IN == 1)
                    {
                        try
                        {
                            for (int i = 0; i < this.dgvtonkho.Rows.Count; i++)
                            {
                                if (this.dgvtonkho["Mh", i].Value.ToString().ToUpper() == this.txttimma.Text.ToUpper())
                                {
                                    this.dgvtonkho.ClearSelection();
                                    this.dgvtonkho.Rows[i].Selected = true;
                                    this.dgvtonkho.CurrentCell = this.dgvtonkho.Rows[i].Cells["Mh"];
                                    break;
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        // Token: 0x06000DAE RID: 3502 RVA: 0x001E5D2C File Offset: 0x001E3F2C
        private void txttimma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txttimma.Text != "")
                {
                    this.txttimma_TextChanged(null, null);
                }
                else
                {
                    this.txttim.Focus();
                }
            }
        }

        // Token: 0x06000DAF RID: 3503 RVA: 0x00190A80 File Offset: 0x0018EC80
        private void Frmhangtonkho_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //string cmdText = "DELETE TB_KHONHAPHANG_HIENTAI DELETE [TB_TONKHOCUOI] DELETE TB_KHOXUAT_MOI DELETE TB_KHOXUAT_DAUKY2 DELETE TB_KHONHAPHANG_DAUKY DELETE TB_KHOXUAT_DAUKY1 DELETE TB_KHOXUAT_DAUKY2 DELETE TB_KHOXUAT_DAUKY1 DELETE TB_KHOXUAT_DAUKY2 DELETE TB_KHONHAPHANG DELETE TB_KHOXUAT DELETE TB_KHOXUAT_1 DELETE [TB_XUAT_TAM] DELETE [TB_XUATTAM_1]";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        // Token: 0x06000DB0 RID: 3504 RVA: 0x0001E649 File Offset: 0x0001C849
        private void button11_Click_1(object sender, EventArgs e)
        {
            //this.loadcauhinh();
            this.xuatexcel_tonkho();
        }

        // Token: 0x06000DB1 RID: 3505 RVA: 0x001E5D80 File Offset: 0x001E3F80
        private void btchitietnhap_Click_1(object sender, EventArgs e)
        {
            Frmhangtonkho.slam = "";
            Frmhangtonkho.nl = "2";
            this.IN = 4;
            string text = "";
            if (this.textBox3.Text != this.textBox3.Tag.ToString())
            {
                text = "AND HHN.NCC='" + this.textBox3.Text + "'";
            }
            this.dgvchitietnhap.BringToFront();
            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            DataTable dataSource = new DataTable();
            //  dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_NHAPNL(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), text);
            this.dgvchitietnhap.DataSource = dataSource;
            decimal d = 0m;
            if (this.dgvchitietnhap.RowCount > 0)
            {
                for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
                {
                    d += Convert.ToDecimal(this.dgvchitietnhap["thanhtienct", i].Value.ToString());
                    this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
                }
            }
            this.txttongcong.Text = d.ToString("#,##0");
        }

        // Token: 0x06000DB2 RID: 3506 RVA: 0x001E1B18 File Offset: 0x001DFD18
        private void button12_Click_1(object sender, EventArgs e)
        {
            if (this.IN == 4)
            {
                if (this.dgvchitietnhap.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "CHI TIẾT NHẬP",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 0f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvchitietnhap);
                }
            }
        }

        // Token: 0x06000DB3 RID: 3507 RVA: 0x001E1BEC File Offset: 0x001DFDEC
        private void button13_Click(object sender, EventArgs e)
        {
            if (this.IN == 3)
            {
                if (this.dgvhanghoa.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "THỐNG KÊ XUẤT",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 30f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvhanghoa);
                }
            }
        }

        // Token: 0x06000DB4 RID: 3508 RVA: 0x001E5F00 File Offset: 0x001E4100
        private void button14_Click(object sender, EventArgs e)
        {
            //string text = "";
            //if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //{
            //    text = " AND hhx.NCC='" + this.cob_kho.SelectedValue.ToString() + "'";
            //}
            //string text2 = "";
            //if (this.cobnhom.Text != "")
            //{
            //    text2 = " AND HH.MANHOM='" + this.cobnhom.SelectedValue.ToString() + " '";
            //}
            //this.IN = 3;
            //this.dgvhanghoa.BringToFront();
            //DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //DataTable dataSource = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE FROM TB_XUATTAM INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM]\r\n           ([MAHANGHOA]           ,[TENHANGHOA]           ,[DONVITINH]           ,[TENDONVI]           ,[SOLUONGTONG]           ,[SOLUONGLE]            ,[QUIDOI],[DONGIA])\r\n           (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,case when (HHX.DONVITINH)!=(HH.DONVITINH) then (HH.DONVITINHLON) ELSE (HH.DONVITINH) END AS DONVITINH,'' AS tendonvi,\r\ncase when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGTONG,\r\ncase when (HHX.DONVITINH)!=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END AS SOLUONGLE,HH.QUYDOI1,case when (HHX.DONVITINH)=(HH.DONVITINH) THEN HHX.DONGIABAN\r\nELSE HHX.DONGIABAN/",
            //    TrangChu.tile,
            //    " END AS DONGIABAN FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE  HH.MAHANGHOA=HHX.MAHANGHOA ",
            //    text2,
            //    " ",
            //    text,
            //    " AND HHX.XUAT='XH' AND HHX.HUY='FALSE' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //    dateTime.ToString("MM/dd/yyyy"),
            //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //    dateTime2.ToString("MM/dd/yyyy"),
            //    "' GROUP BY hhx.MAHANGHOA,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.DONGIABAN,(HH.DONVITINHLON))"
            //});
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //dataSource = this.xhdCtr.THEMTONGHANGHOAXUATNGAY(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
            //this.dgvhanghoa.DataSource = dataSource;
            //this.tongcong();
            //this.txttongcong.Visible = true;
            //this.txttt.Visible = true;
        }

        // Token: 0x06000DB5 RID: 3509 RVA: 0x001E1B18 File Offset: 0x001DFD18
        private void button15_Click_1(object sender, EventArgs e)
        {
            if (this.IN == 4)
            {
                if (this.dgvchitietnhap.RowCount > 0)
                {
                    //new DGVPrinter
                    //{
                    //    Title = "CHI TIẾT NHẬP",
                    //    SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    //    SubTitleFormatFlags = (StringFormatFlags.LineLimit | StringFormatFlags.NoClip),
                    //    PageNumbers = true,
                    //    PageNumberAlignment = StringAlignment.Center,
                    //    PorportionalColumns = true,
                    //    HeaderCellAlignment = StringAlignment.Near,
                    //    FooterSpacing = 0f,
                    //    FooterAlignment = StringAlignment.Far,
                    //    printDocument =
                    //    {
                    //        DefaultPageSettings =
                    //        {
                    //            Landscape = true
                    //        }
                    //    }
                    //}.PrintDataGridView(this.dgvchitietnhap);
                }
            }
        }

        // Token: 0x06000DB6 RID: 3510 RVA: 0x001E60E4 File Offset: 0x001E42E4
        private void button16_Click_1(object sender, EventArgs e)
        {
            Frmhangtonkho.slam = " HHN.SOLUONG<0 AND ";
            Frmhangtonkho.nl = "2";
            this.IN = 4;
            string text = "";
            if (this.textBox3.Text != this.textBox3.Tag.ToString())
            {
                text = "AND HHN.NCC='" + this.textBox3.Text + "'";
            }
            this.dgvchitietnhap.BringToFront();
            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            DataTable dataSource = new DataTable();
            //  dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_NHAPNL(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), text);
            this.dgvchitietnhap.DataSource = dataSource;
            decimal d = 0m;
            if (this.dgvchitietnhap.RowCount > 0)
            {
                for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
                {
                    d += Convert.ToDecimal(this.dgvchitietnhap["thanhtienct", i].Value.ToString());
                    this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
                }
            }
            this.txttongcong.Text = d.ToString("#,##0");
        }

        // Token: 0x06000DB7 RID: 3511 RVA: 0x001E6264 File Offset: 0x001E4464
        private void btnhapxuattonnl_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string text = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            //    string text2 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE TB_KHONHAPHANG_DAUKY INSERT INTO TB_KHONHAPHANG_DAUKY(MAHANG,SOLUONG,DONGIA)  ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM((HN.DONGIA)*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),'",
            //        text,
            //        "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //        text,
            //        "'))-1), DATEADD(mm,-1,'",
            //        text,
            //        "')),101) GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0) DELETE TB_KHOXUAT_DAUKY1  INSERT INTO TB_KHOXUAT_DAUKY1(MAHANG,SOLUONG,DONGIA)   ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),'",
            //        text,
            //        "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //        text,
            //        "'))-1), DATEADD(mm,-1,'",
            //        text,
            //        "')),101) GROUP BY HN.MAHANGHOA)         DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT * FROM TB_TON0_NL WHERE MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),DATEADD(mm,-1,'",
            //        text,
            //        "')),101))    AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),DATEADD(mm,-1,'",
            //        text,
            //        "')),101)))      DELETE TB_KHOXUAT_DAUKY2 INSERT INTO TB_KHOXUAT_DAUKY2(MAHANG,SOLUONG, DONGIA)   (SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT_DAUKY1 X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)    DELETE TB_TON0_2 INSERT INTO TB_TON0_2(MAHANG,SOLUONG,DONGIA)   (SELECT DL.MAHANGHOA,ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0),T.DONGIA FROM TB_NGUYENLIEU DL  LEFT JOIN TB_TON0_NL T   ON T.MAHANG= DL.MAHANGHOA LEFT JOIN TB_KHOXUAT_DAUKY2 K ON DL.MAHANGHOA=K.MAHANG  WHERE T.SOLUONG>0 AND ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0)>0 AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),   DATEADD(mm,-1,'",
            //        text,
            //        "')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),DATEADD(mm,-1,'",
            //        text,
            //        "')),101)) GROUP BY DL.MAHANGHOA,ISNULL(T.SOLUONG,0),ISNULL(K.SOLUONG,0),T.DONGIA)   DELETE TB_KHOXUAT_DAUKY INSERT INTO TB_KHOXUAT_DAUKY(MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA,ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0),'0' FROM TB_NGUYENLIEU HH LEFT JOIN TB_KHOXUAT_DAUKY2 K ON HH.MAHANGHOA=K.MAHANG LEFT JOIN TB_TON0_1 T ON T.MAHANG=HH.MAHANGHOA WHERE ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)>0)  DELETE [TB_TON1]  INSERT INTO [TB_TON1](MAHANG,SOLUONG,DONGIA,NGAY)       (SELECT NL.MAHANGHOA,SUM( ISNULL(B1.SOLUONG,0))-SUM(ISNULL(B2.SOLUONG,0)),SUM(ISNULL(B1.SOLUONG,0) *ISNULL(B1.DONGIA,0))/SUM(ISNULL(B1.SOLUONG,1)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //        text,
            //        "')),'00:00 ",
            //        text,
            //        "'),101)  FROM TB_NGUYENLIEU NL LEFT JOIN TB_KHONHAPHANG_DAUKY B1 ON NL.MAHANGHOA=B1.MAHANG LEFT JOIN TB_KHOXUAT_DAUKY B2 ON NL.MAHANGHOA=B2.MAHANG GROUP BY NL.MAHANGHOA HAVING sum(ISNULL(B1.SOLUONG,0))-sum(ISNULL(B2.SOLUONG,0))!=0)       DELETE TB_KHONHAPHANG INSERT INTO TB_KHONHAPHANG(MAHANG,SOLUONG,DONGIA)       (SELECT HN.MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG))     FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)> CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),'",
            //        text,
            //        "'),101) AND CONVERT(datetime,ngaynhap,103)<'",
            //        text,
            //        "'GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0)       DELETE TB_KHOXUAT INSERT INTO TB_KHOXUAT(MAHANG,SOLUONG,DONGIA)      ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)>'23:59 '      +CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //        text,
            //        "')),'",
            //        text,
            //        "'),101)AND CONVERT(datetime,ngaynhap,103)<'00:00 '+'",
            //        text,
            //        "'     GROUP BY HN.MAHANGHOA HAVING SUM(HN.SOLUONG))  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY D.MANGUYENLIEU)   DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)        (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)ELSE '0' END,ISNULL(B1.DONGIA ,0)    FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_2 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG    WHERE ISNULL(B1.SOLUONG,0)>0 AND ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)!=0 )         DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(T2.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0)>0  THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0)    END ELSE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0) END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG) LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG   WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)      DELETE [TB_TON3] INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END AS DONGIA      FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) WHERE CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END!=0    GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0))       DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)           (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP_NL           WHERE CONVERT(datetime,ngaynhap,103)>='",
            //        text,
            //        "' AND CONVERT(datetime,ngaynhap,103)<='",
            //        text2,
            //        "' GROUP BY MAHANGHOA HAVING SUM(SOLUONG)!=0)             DELETE [TB_XUAT_TAM] INSERT INTO [TB_XUAT_TAM](MAHANG,SOLUONG,DONGIA)       ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE  CONVERT(datetime,NGAYNHAP,103)>= '00:00 ",
            //        text,
            //        "' AND CONVERT(datetime,NGAYNHAP,103)<='23:29 ",
            //        text2,
            //        "'        GROUP BY HN.MAHANGHOA HAVING SUM(HN.SOLUONG)!=0)         DELETE [TB_XUATTAM_1] INSERT INTO [TB_XUATTAM_1](MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM [TB_XUAT_TAM] X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)       DELETE [TB_TON0_4] INSERT INTO [TB_TON0_4](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0)FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_3 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG WHERE B1.SOLUONG!=0)     DELETE [TB_TON4]    INSERT INTO [TB_TON4](MAHANG,SOLUONG,DONGIA)     (SELECT HH.MAHANGHOA ,ISNULL(B2.SOLUONG,0)-(ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),ISNULL(B1.DONGIA ,0) FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_3 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)     DELETE [TB_TON5] INSERT INTO [TB_TON5](MAHANG,SOLUONG,DONGIA)      (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>=0THEN ISNULL(B2.SOLUONG,0)ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0)END,ISNULL(B2.DONGIA ,0)     FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON4 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_TON3 B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0) HAVING (ISNULL(B1.SOLUONG,0)+SUM(ISNULL(B2.SOLUONG,0)))!=0)     DELETE [TB_TON6] INSERT INTO [TB_TON6](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B.SOLUONG,0)END,ISNULL(B1.DONGIA ,0)     FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON5 B ON HH.MAHANGHOA=B.MAHANG)LEFT JOIN [TB_TONKHOCUOI] B1 ON HH.MAHANGHOA=B1.MAHANG GROUP BY HH.MAHANGHOA,    ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B.SOLUONG,0) HAVING ISNULL(B1.SOLUONG,0)!=0 AND SUM(ISNULL(B.SOLUONG,0))!=0 )      DELETE TB_KHONHAPHANG_HIENTAI INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON0_3 WHERE SOLUONG>0)       INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT * FROM TB_TON2 WHERE SOLUONG>0)INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)     (SELECT * FROM TB_TON3 WHERE SOLUONG!=0) DELETE TB_KHOXUAT_MOI INSERT INTO TB_KHOXUAT_MOI(MAHANG,SOLUONG,DONGIA)      (SELECT MAHANG,SUM(SOLUONG),SUM(SOLUONG*DONGIA)/SUM(ISNULL(SOLUONG,0)) FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG HAVING SUM(SOLUONG)!=0)     DELETE TB_TON0_NL WHERE YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //        text,
            //        "')),'00:00 ",
            //        text,
            //        "'),101))      AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //        text,
            //        "')),'00:00 ",
            //        text,
            //        "'),101))       INSERT INTO [TB_TON0_NL](MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT HH.MAHANGHOA,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))       /(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //        text2,
            //        "')),'00:00 ",
            //        text2,
            //        "'),101)        FROM TB_NGUYENLIEU HH LEFT JOIN TB_TON1 T1 ON T1.MAHANG=HH.MAHANGHOA LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG        WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)!=0)        DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG!=0  GROUP BY MAHANG)       DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG)        FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK          WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)        (SELECT DL.MANGUYENLIEU,SUM(ISNULL(NK.SOLUONG*DL.SL,0)),0 FROM TB_DINHLUONG DL LEFT JOIN [TB_XUATTRONGKY] NK         ON DL.MAHANGHOA=NK.MAHANG WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY DL.MANGUYENLIEU having SUM(SOLUONG)!=0)         SELECT HH.MAHANGHOA,HH.TENHANGHOA,HH.DONVITINH,ISNULL(NK.SOLUONG,0) AS DAUKY,ISNULL(NK.DONGIA,0) AS GIATON ,   ISNULL(TK.SOLUONG,0) AS NHAP, ISNULL(TK.DONGIA,0)AS GIANHAP,ISNULL(XK.SOLUONG,0) AS XUAT,ISNULL(XK.DONGIA,0)AS GIAXUAT ,       (ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)) AS TON,     CASE WHEN ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)!=0         THEN CASE WHEN ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)>0   THEN CASE WHEN ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)!=0 THEN  ((ISNULL(NK.DONGIA,0)*(ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)))+(ISNULL(TK.DONGIA,0)*ISNULL(TK.SOLUONG,0)))         /(ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))  ELSE '0' END   ELSE ISNULL(TK.DONGIA,0) END ELSE '0' END AS GIAVON                FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_DK1 NK ON HH.MAHANGHOA=NK.MAHANG )LEFT JOIN TB_TK1 TK ON HH.MAHANGHOA=TK.MAHANG )LEFT JOIN TB_XTK1 XK        ON HH.MAHANGHOA=XK.MAHANG WHERE ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0) ",
            //        this.cobdk.Text,
            //        " ",
            //        this.txtsl.Text
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvtonsoluong.DataSource = dataTable;
            //    this.dgvtonsoluong.BringToFront();
            //    this.thanhtoan = 0.0;
            //    this.tondau = 0.0;
            //    this.nhapvao = 0.0;
            //    this.xuatra = 0.0;
            //    this.conlai = 0.0;
            //    if (this.dgvtonsoluong.RowCount > 0)
            //    {
            //        for (int i = 0; i < this.dgvtonsoluong.RowCount; i++)
            //        {
            //            try
            //            {
            //                this.dgvtonsoluong.Rows[i].Cells["THANHTIENTK"].Value = Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //                this.thanhtoan += Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["dgton"].Value.ToString()) * Convert.ToDouble(this.dgvtonsoluong.Rows[i].Cells["Tck"].Value.ToString());
            //                this.tondau += Convert.ToDouble(this.dgvtonsoluong["SLD", i].Value.ToString());
            //                this.nhapvao += Convert.ToDouble(this.dgvtonsoluong["sltk", i].Value.ToString());
            //                this.xuatra += Convert.ToDouble(this.dgvtonsoluong["Xuattk", i].Value.ToString());
            //                if (Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString()) > 0.0)
            //                {
            //                    this.conlai += Convert.ToDouble(this.dgvtonsoluong["tck", i].Value.ToString());
            //                }
            //                this.dgvtonsoluong.Rows[i].Cells[0].Value = i + 1;
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        this.dgvtonsoluong.AllowUserToAddRows = true;
            //        this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //        this.dgvtonsoluong["Mahanghoa", this.dgvtonsoluong.Rows.Count - 1].Value = "TỔNG CỘNG";
            //        this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //        this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //        this.dgvtonsoluong["THANHTIENTK", this.dgvtonsoluong.Rows.Count - 1].Value = this.thanhtoan.ToString("#,##0");
            //        this.dgvtonsoluong["SLD", this.dgvtonsoluong.Rows.Count - 1].Value = this.tondau.ToString("#,##0.##");
            //        this.dgvtonsoluong["sltk", this.dgvtonsoluong.Rows.Count - 1].Value = this.nhapvao.ToString("#,##0.##");
            //        this.dgvtonsoluong["Xuattk", this.dgvtonsoluong.Rows.Count - 1].Value = this.xuatra.ToString("#,##0.##");
            //        this.dgvtonsoluong["tck", this.dgvtonsoluong.Rows.Count - 1].Value = this.conlai.ToString("#,##0.##");
            //    }
            //    this.txttongcong.Text = "0";
            //    this.txttongcong.Text = this.thanhtoan.ToString("#,##0");
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000DB8 RID: 3512 RVA: 0x0001B637 File Offset: 0x00019837
        private void dgvtonsoluong_MouseClick(object sender, MouseEventArgs e)
        {
        }

        // Token: 0x06000DB9 RID: 3513 RVA: 0x001E6A84 File Offset: 0x001E4C84
        private void dgvtonsoluong_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvtonsoluong.RowCount > 0)
            {
                if (this.dgvtonsoluong.CurrentRow.Index == this.dgvtonsoluong.Rows.Count - 1)
                {
                    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                    this.dgvtonsoluong["Mahanghoa", this.dgvtonsoluong.Rows.Count - 1].Value = "TỔNG CỘNG";
                    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    this.dgvtonsoluong.Rows[this.dgvtonsoluong.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
                    this.dgvtonsoluong["THANHTIENTK", this.dgvtonsoluong.Rows.Count - 1].Value = this.thanhtoan.ToString("#,##0");
                    this.dgvtonsoluong["SLD", this.dgvtonsoluong.Rows.Count - 1].Value = this.tondau.ToString();
                    this.dgvtonsoluong["sltk", this.dgvtonsoluong.Rows.Count - 1].Value = this.nhapvao.ToString();
                    this.dgvtonsoluong["Xuattk", this.dgvtonsoluong.Rows.Count - 1].Value = this.xuatra.ToString();
                    this.dgvtonsoluong["tck", this.dgvtonsoluong.Rows.Count - 1].Value = this.conlai.ToString();
                }
            }
        }

        // Token: 0x06000DBA RID: 3514 RVA: 0x001E6CB4 File Offset: 0x001E4EB4
        private void dgvtonkho_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvtonkho.RowCount > 0)
            {
                if (this.dgvtonkho.CurrentRow.Index == this.dgvtonkho.Rows.Count - 1)
                {
                    this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                    this.dgvtonkho["mh", this.dgvtonkho.Rows.Count - 1].Value = "TỔNG CỘNG";
                    this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    this.dgvtonkho.Rows[this.dgvtonkho.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
                    this.dgvtonkho["tt", this.dgvtonkho.Rows.Count - 1].Value = this.thanhtoan.ToString();
                    this.dgvtonkho["NHAP", this.dgvtonkho.Rows.Count - 1].Value = this.tondau.ToString();
                    this.dgvtonkho["XUAT", this.dgvtonkho.Rows.Count - 1].Value = this.nhapvao.ToString();
                    this.dgvtonkho["slt", this.dgvtonkho.Rows.Count - 1].Value = this.xuatra.ToString();
                }
            }
        }

        // Token: 0x06000DBB RID: 3515 RVA: 0x001E6EAC File Offset: 0x001E50AC
        private void dgvhanghoa_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.IN == 3)
            {
                if (this.dgvhanghoa.Rows.Count > 0)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã hàng " + this.dgvhanghoa.Rows[this.dgvhanghoa.CurrentRow.Index].Cells["Mahang"].Value.ToString().ToUpper() + "   không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if (dialogResult == DialogResult.Yes)
                        //{
                        //    string text = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
                        //    string text2 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
                        //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
                        //    sqlConnection.Open();
                        //    string cmdText = string.Concat(new string[]
                        //    {
                        //        "DELETE TB_CHITIETHOADON WHERE MAHANGHOA='",
                        //        this.dgvhanghoa.Rows[this.dgvhanghoa.CurrentRow.Index].Cells["Mahang"].Value.ToString(),
                        //        "' AND XUAT='XH' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
                        //        text,
                        //        "' AND CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
                        //        text2,
                        //        "'"
                        //    });
                        //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                        //    sqlCommand.ExecuteNonQuery();
                        //    sqlConnection.Close();
                        //    this.dgvhanghoa.Rows.RemoveAt(this.dgvhanghoa.CurrentRow.Index);
                        //}
                    }
                }
            }
        }

        // Token: 0x06000DBC RID: 3516 RVA: 0x0001E6AA File Offset: 0x0001C8AA
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.timngay = "";
        }

        // Token: 0x06000DBD RID: 3517 RVA: 0x001E708C File Offset: 0x001E528C
        private void button17_Click(object sender, EventArgs e)
        {
            //if (TrangChu.XEMGIAVON == "True")
            //{
            //    string makhoxuat = "";
            //    if (this.cob_kho.Text != this.cob_kho.Tag.ToString())
            //    {
            //        makhoxuat = " AND hhn.loai='" + this.cob_kho.SelectedValue.ToString() + "'";
            //    }
            //    Frmhangtonkho.nl = "1";
            //    this.IN = 4;
            //    string text = "";
            //    if (this.textBox3.Text != this.textBox3.Tag.ToString())
            //    {
            //        text = "AND HHN.NCC='" + this.textBox3.Text + "'";
            //    }
            //    this.dgvchitietnhap.BringToFront();
            //    string nhom = "";
            //    if (this.cobnhom.Text != "")
            //    {
            //        nhom = " AND HH.MANHOM='" + this.cobnhom.SelectedValue.ToString() + "'";
            //    }
            //    DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //    DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_XUAT(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), text, nhom, makhoxuat);
            //    this.dgvchitietnhap.DataSource = dataSource;
            //    decimal d = 0m;
            //    if (this.dgvchitietnhap.RowCount > 0)
            //    {
            //        for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
            //        {
            //            d += Convert.ToDecimal(this.dgvchitietnhap["thanhtienct", i].Value.ToString());
            //            this.dgvchitietnhap["sua", i].Style.BackColor = Color.SkyBlue;
            //        }
            //    }
            //    this.txttongcong.Text = d.ToString("#,##0");
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa được phân quyền xem giá vốn", "Thông báo");
            //}
        }

        // Token: 0x06000DBE RID: 3518 RVA: 0x001E72D0 File Offset: 0x001E54D0
        private void mahoadontieptheo()
        {
            //try
            //{
            //    string selectCommandText = "select top 1 isnull(MAX(MAHOADON),'000000000') from TB_HANGHOANHAP where CONVERT(DATETIME,NGAYNHAP,103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "' group by MAHOADON having ISNUMERIC(MAHOADON)=1 order by MAHOADON desc";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    string text;
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        text = DateTime.Now.ToString("ddMMyy") + "00001";
            //    }
            //    else
            //    {
            //        double num = 0.0;
            //        string a = Convert.ToString(dataTable.Rows[0][0].ToString().Substring(0, 6));
            //        text = DateTime.Now.ToString("ddMMyy");
            //        if (a == text)
            //        {
            //            if (dataTable.Rows[0][0].ToString().Length == 6)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(6, 2));
            //            }
            //            if (dataTable.Rows[0][0].ToString().Length == 7)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(6, 3));
            //            }
            //            if (dataTable.Rows[0][0].ToString().Length == 8)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(6, 4));
            //            }
            //            if (dataTable.Rows[0][0].ToString().Length == 9)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(6, 5));
            //            }
            //            if (dataTable.Rows[0][0].ToString().Length > 9)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(6, 5));
            //            }
            //            num += 1.0;
            //            if (num < 10.0)
            //            {
            //                text += "0000";
            //            }
            //            else if (num < 100.0)
            //            {
            //                text += "000";
            //            }
            //            else if (num < 1000.0)
            //            {
            //                text += "00";
            //            }
            //            else if (num < 10000.0)
            //            {
            //                text += "0";
            //            }
            //            text += num.ToString();
            //        }
            //        else
            //        {
            //            text = DateTime.Now.ToString("ddMMyy") + "00001";
            //        }
            //    }
            //    this.mahoadon_suakho = text;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000DBF RID: 3519 RVA: 0x001E7658 File Offset: 0x001E5858
        private void dgvtonsoluong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    try
            //    {
            //        if (TrangChu.XOANHAP == "True")
            //        {
            //            int columnIndex = this.dgvtonsoluong.CurrentCell.ColumnIndex;
            //            if (this.dgvtonsoluong.Columns[columnIndex].Name == "Tck")
            //            {
            //                Frmsuanhapkho.makho = this.cob_kho.SelectedValue.ToString();
            //                Frmsuanhapkho.suachitietnhap = 1;
            //                int index = this.dgvtonsoluong.CurrentRow.Index;
            //                Frmsuanhapkho.mahanghoa = this.dgvtonsoluong.Rows[index].Cells["MAHANgHOA"].Value.ToString();
            //                if (this.mahoadon_suakho == "")
            //                {
            //                    this.mahoadontieptheo();
            //                }
            //                Frmsuanhapkho.mahoadon = this.mahoadon_suakho;
            //                Frmsuanhapkho.tenhanghoa = this.dgvtonsoluong.Rows[index].Cells["tenhanghoa"].Value.ToString();
            //                Frmsuanhapkho.dongia = this.dgvtonsoluong.Rows[index].Cells["dgton"].Value.ToString();
            //                Frmsuanhapkho frmsuanhapkho = new Frmsuanhapkho();
            //                frmsuanhapkho.ShowDialog();
            //                if (Frmsuanhapkho.ok_luu == 1)
            //                {
            //                    this.dgvtonsoluong.Rows[index].Cells["Tck"].Value = Convert.ToDouble(Frmsuanhapkho.soluongtong) + Convert.ToDouble(this.dgvtonsoluong.Rows[index].Cells["Tck"].Value.ToString());
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            //}
        }

        // Token: 0x06000DC0 RID: 3520 RVA: 0x001E7878 File Offset: 0x001E5A78
        private void xuatexcel_tonkho_cuoi()
        {
            //if (this.dgvtonkho.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\TONCUOI.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmhangtonkho.< xuatexcel_tonkho_cuoi > o__SiteContainer2.<> p__Site3 == null)
            //    {
            //        Frmhangtonkho.< xuatexcel_tonkho_cuoi > o__SiteContainer2.<> p__Site3 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmhangtonkho)));
            //    }
            //    Worksheet worksheet = Frmhangtonkho.< xuatexcel_tonkho_cuoi > o__SiteContainer2.<> p__Site3.Target(Frmhangtonkho.< xuatexcel_tonkho_cuoi > o__SiteContainer2.<> p__Site3, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //    worksheet.Cells[2, 1] = this.chObj.Diachi;
            //    worksheet.Cells[3, 1] = this.chObj.Dienthoai;
            //    worksheet.Cells[5, 1] = "Từ " + this.dttungay.Text + " đến " + this.dtdenngay.Text;
            //    int num = 7;
            //    for (int i = 0; i < this.dgvtonkho.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvtonkho.Columns.Count; j++)
            //        {
            //            if (j == this.dgvtonkho.Columns.Count - 1)
            //            {
            //                worksheet.Cells[i + 8, j + 2] = this.dgvtonkho.Rows[i].Cells[j].Value;
            //            }
            //            else
            //            {
            //                worksheet.Cells[i + 8, j + 1] = this.dgvtonkho.Rows[i].Cells[j].Value;
            //            }
            //        }
            //        Range range = worksheet.get_Range("A" + num, "O" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //        worksheet.Cells[num, 14] = worksheet.Cells[num, 2];
            //    }
            //    Range range2 = worksheet.get_Range("D" + 8, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("H" + 8, "H" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 8, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("B" + 8, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("J" + 8, "J" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("L" + 8, "L" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("N" + 8, "N" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvtonkho.RowCount + 8, 8] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    worksheet.Cells[this.dgvtonkho.RowCount + 9, 8] = "NGƯỜI LẬP";
            //}
        }

        // Token: 0x06000DC1 RID: 3521 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
        private void button2_Click_2(object sender, EventArgs e)
        {
            // this.loadcauhinh();
            this.xuatexcel_tonkho_cuoi();
        }




        // Token: 0x0400103C RID: 4156
        private string timngay = "";

        // Token: 0x0400103D RID: 4157
        private double thanhtoan = 0.0;

        // Token: 0x0400103E RID: 4158
        private double tondau = 0.0;

        // Token: 0x0400103F RID: 4159
        private double nhapvao = 0.0;

        // Token: 0x04001040 RID: 4160
        private double xuatra = 0.0;

        // Token: 0x04001041 RID: 4161
        private double conlai = 0.0;

        // Token: 0x04001042 RID: 4162
        private int IN;

        // Token: 0x04001043 RID: 4163
        public static string nl = "1";

        // Token: 0x04001044 RID: 4164
        public static string slam = "";

        // Token: 0x04001045 RID: 4165
        //private CauhinhObj chObj = new CauhinhObj();

        //// Token: 0x04001046 RID: 4166
        //private int numberOfItemsPrintedSoFar = 0;

        //// Token: 0x04001047 RID: 4167
        //private int numberOfItemsPerPage = 0;

        //// Token: 0x04001048 RID: 4168
        //private HanghoaHdObj hhObj = new HanghoaHdObj();

        //// Token: 0x04001049 RID: 4169
        //private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        //// Token: 0x0400104A RID: 4170
        //private HangHoaCtr hhCrt = new HangHoaCtr();

        // Token: 0x0400104B RID: 4171
        private string mahoadon_suakho = "";
    }
}
