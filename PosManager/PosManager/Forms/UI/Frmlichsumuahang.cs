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
    public partial class Frmlichsumuahang : Form
    {
        public Frmlichsumuahang()
        {
            InitializeComponent();
        }
        // Token: 0x06000A63 RID: 2659 RVA: 0x001A12F8 File Offset: 0x0019F4F8
        private void chitiet_khachhang()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "select NH.TENNHOM, CT.TENHANGHOA,CT.DONVITINH,SUM(CT.TONGSOLUONG)AS SOLUONG, SUM(CT.DONGIABAN*TONGSOLUONG)/SUM(TONGSOLUONG), SUM(THANHTIEN)AS THANHTIEN ,CT.MAHANGHOA\r\nfrom TB_CHITIETHOADON CT, TB_HANGHOA HH,TB_NHOMHANG NH,TB_HOADONBANHANG HD \r\nWHERE HD.SOHOADON=CT.MAHOADON AND CT.HUY='FALSE' AND CT.MAHANGHOA=HH.MAHANGHOA AND HH.MANHOM=NH.MANHOM AND HD.MAKHACHHANG='" + Frmlichsumuahang.makhachhang + "' GROUP BY CT.TANG,NH.TENNHOM, CT.TENHANGHOA,CT.DONVITINH,CT.MAHANGHOA HAVING SUM(TONGSOLUONG)!=0 ORDER BY NH.TENNHOM";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //double num = 0.0;
            //double num2 = 0.0;
            //int num3 = 0;
            //string text = "";
            //double num4 = 0.0;
            //double num5 = 0.0;
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    this.dgvchitiethanghoa.Rows.Add(1);
            //    int num6 = this.dgvchitiethanghoa.Rows.Count - 1;
            //    if (i > 0 && dataTable.Rows[i][0].ToString() != dataTable.Rows[i - 1][0].ToString())
            //    {
            //        text = dataTable.Rows[i][0].ToString();
            //        this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i - 1][0].ToString().ToUpper();
            //        this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "CỘNG";
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.BackColor = Color.Yellow;
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
            //        this.dgvchitiethanghoa["thanhtien", num6].Value = num.ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //        this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //        num2 += num;
            //        num5 += num4;
            //        num4 = 0.0;
            //        num = 0.0;
            //        num3 = 0;
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num6++;
            //    }
            //    num3++;
            //    num += Convert.ToDouble(dataTable.Rows[i][5].ToString());
            //    this.dgvchitiethanghoa["tenhang", num6].Value = dataTable.Rows[i][1].ToString();
            //    this.dgvchitiethanghoa["dvt", num6].Value = dataTable.Rows[i][2].ToString();
            //    this.dgvchitiethanghoa["soluong", num6].Value = double.Parse(dataTable.Rows[i][3].ToString()).ToString("#,##0.##");
            //    this.dgvchitiethanghoa["dongia", num6].Value = double.Parse(dataTable.Rows[i][4].ToString()).ToString("#,##0");
            //    this.dgvchitiethanghoa["thanhtien", num6].Value = double.Parse(dataTable.Rows[i][5].ToString()).ToString("#,##0");
            //    this.dgvchitiethanghoa["MAHANG", num6].Value = dataTable.Rows[i][6].ToString();
            //    this.dgvchitiethanghoa["TT", num6].Value = num3;
            //    num4 += double.Parse(dataTable.Rows[i][3].ToString());
            //}
            //this.dgvchitiethanghoa.Rows.Add(1);
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            //this.dgvchitiethanghoa["MAHANG", this.dgvchitiethanghoa.Rows.Count - 1].Value = "CỘNG";
            //this.dgvchitiethanghoa["tenhang", this.dgvchitiethanghoa.Rows.Count - 1].Value = text.ToUpper();
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
            //this.dgvchitiethanghoa["thanhtien", this.dgvchitiethanghoa.Rows.Count - 1].Value = num.ToString("#,##0");
            //this.dgvchitiethanghoa["soluong", this.dgvchitiethanghoa.Rows.Count - 1].Value = num4.ToString("#,##0");
            //num2 += num;
            //num5 += num4;
            //this.dgvchitiethanghoa.Rows.Add(1);
            //int num7 = this.dgvchitiethanghoa.Rows.Count - 1;
            //this.dgvchitiethanghoa["MAHANG", num7].Value = "TỔNG";
            //this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //this.dgvchitiethanghoa["thanhtien", num7].Value = num2.ToString("#,##0");
            //this.dgvchitiethanghoa["soluong", num7].Value = num5.ToString("#,##0");
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
            //this.dgvchitiethanghoa.BringToFront();
            //double num8 = 0.0;
            //double num9 = 0.0;
            //if (dataTable.Rows.Count > 0)
            //{
            //    DataTable dataTable2 = new DataTable();
            //    sqlConnection.Close();
            //    string cmdText2 = "SELECT ISNULL(SUM(GIAMTIEN),0) AS CONGGIAM,ISNULL(SUM(CASE WHEN PHANTRAM<0 THEN -TIENPHANTRAM ELSE TIENPHANTRAM END),0) AS PHANTRAM,SUM(TIENVAT) AS TIENVAT\r\n FROM TB_HOADONBANHANG WHERE HUYHD='FALSE' AND MAKHACHHANG='" + Frmlichsumuahang.makhachhang + "'";
            //    SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
            //    sqlDataAdapter2.Fill(dataTable2);
            //    if (dataTable2.Rows.Count > 0)
            //    {
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "+/- Tiền";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][0].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num10 = double.Parse(dataTable2.Rows[0][0].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "+/- %";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][1].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num11 = double.Parse(dataTable2.Rows[0][1].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "Thuế VAT";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = double.Parse(dataTable2.Rows[0][2].ToString()).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 13f, FontStyle.Bold);
            //        double num12 = double.Parse(dataTable2.Rows[0][2].ToString());
            //        this.dgvchitiethanghoa.Rows.Add(1);
            //        num7++;
            //        this.dgvchitiethanghoa["MAHANG", num7].Value = "TỔNG CỘNG";
            //        this.dgvchitiethanghoa.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
            //        this.dgvchitiethanghoa["thanhtien", num7].Value = (num2 + num8 + num9 + num12).ToString("#,##0");
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            //        this.dgvchitiethanghoa.Rows[this.dgvchitiethanghoa.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
            //    }
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000A64 RID: 2660 RVA: 0x001A1F94 File Offset: 0x001A0194
        private void Frmlichsumuahang_Load(object sender, EventArgs e)
        {
            base.SetBounds(0, 0, Screen.PrimaryScreen.WorkingArea.Width + 10, Screen.PrimaryScreen.WorkingArea.Height + 10);
            this.load_diem();
            this.chitiet_khachhang();
            this.load_tongnam();
            this.LOADTIMKIEM();
            this.load_tien();
            this.load_tiepnhan();
            this.LOAD_DULIEU(" WHERE G.NCC= '" + Frmlichsumuahang.makhachhang + "'");
        }

        // Token: 0x06000A65 RID: 2661 RVA: 0x001A201C File Offset: 0x001A021C
        private void load_tongnam()
        {
            //string cmdText = "select RIGHT(NGAY,4), SUM(THANHTOAN) FROM TB_HOADONBANHANG WHERE HUYHD='FALSE' AND MAKHACHHANG='" + Frmlichsumuahang.makhachhang + "' GROUP BY  RIGHT(NGAY,4) ORDER BY RIGHT(NGAY,4)";
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgv_nam.DataSource = null;
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            //        DataGridViewCell cellTemplate = new DataGridViewTextBoxCell();
            //        dataGridViewColumn.CellTemplate = cellTemplate;
            //        dataGridViewColumn.HeaderText = "Năm " + dataTable.Rows[i][0].ToString();
            //        dataGridViewColumn.Name = "Nam " + dataTable.Rows[i][0].ToString();
            //        dataGridViewColumn.Visible = true;
            //        dataGridViewColumn.Width = 120;
            //        dataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //        this.dgv_nam.Columns.Add(dataGridViewColumn);
            //    }
            //    this.dgv_nam.AllowUserToAddRows = true;
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        this.dgv_nam.Rows[0].Cells[i].Value = double.Parse(dataTable.Rows[i][1].ToString()).ToString("#,##0");
            //    }
            //}
        }

        // Token: 0x06000A66 RID: 2662 RVA: 0x001A21F0 File Offset: 0x001A03F0
        private void LOAD_NHOMCHU()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_NHOMCHU ORDER BY TENNHOM", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.cobnhomchu.DataSource = dataTable;
            //this.cobnhomchu.DisplayMember = "TENNHOM";
            //this.cobnhomchu.ValueMember = "MANHOM";
        }

        // Token: 0x06000A67 RID: 2663 RVA: 0x001A2274 File Offset: 0x001A0474
        private void LOAD_DULIEU(string dk)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT G.MA,NGAY,ISNULL(K.TENKHACHHANG,G.NCC) AS TENKHACHHANG,NOIDUNG,NOIDUNG1,G.NCC  FROM TB_GHICHU G LEFT JOIN Tb_KHACHHANG K ON K.MAKHACHHANG=G.NCC " + dk + "  ORDER BY CONVERT(DATETIME,NGAY,103) DESC", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvghichu.DataSource = dataTable;
        }

        // Token: 0x06000A68 RID: 2664 RVA: 0x001A22E0 File Offset: 0x001A04E0
        private void load_tiepnhan()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_TIEPNHAN_XULY WHERE MAKHACHHANG= '" + Frmlichsumuahang.makhachhang + "' ORDER BY CONVERT(DATETIME,NGAYNHAN,103) DESC", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView2.DataSource = dataTable;
            //this.dataGridView2.AutoResizeRows();
        }

        // Token: 0x06000A69 RID: 2665 RVA: 0x001A235C File Offset: 0x001A055C
        private void load_tien()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect_khachhang);
            //sqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlCommand selectCommand = new SqlCommand("SELECT NGAY,SOTIEN,GHICHU FROM TB_TIENKHUYENMAI WHERE MAKHACHHANG='" + Frmlichsumuahang.makhachhang + "' ORDER BY CONVERT(DATETIME,NGAY,103) DESC", sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvdiem.DataSource = dataTable;
            //sqlConnection.Close();
        }

        // Token: 0x06000A6A RID: 2666 RVA: 0x001A23E4 File Offset: 0x001A05E4
        private void load_diem()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT D.MAHOADON,D.NGAY,D.DIEM,D.DIEMCONG,D.DIEMTRU,ISNULL(D.GHICHU,'') AS GHICHU FROM TB_DIEMKM D WHERE D.MAKHACHHANG='" + Frmlichsumuahang.makhachhang + "'  ORDER BY CONVERT(DATETIME,NGAY,103) DESC";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //    }
            //}
        }

        // Token: 0x06000A6B RID: 2667 RVA: 0x001A2494 File Offset: 0x001A0694
        private void LOADTIMKIEM()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT SOHOADON,isnull(kh.tendonvi,'') as tendonvi,TONGCONG,GIAMTIEN,PHANTRAM,TIENPHANTRAM,VAT,TIENVAT,THANHTOAN,DUATRUOC,NOCU,case when HINHTHUC='1' then N'Tiền Mặt' WHEN HINHTHUC='3' THEN N'Đặt trước' else N'Nợ' end as hinhthuc1,HINHTHUC,NGAY,HUYHD,MAXE,NHANVIEN,HD.NHANVIENBANHANG FROM TB_HOADONBANHANG hd left join Tb_KHACHHANG kh on kh.MAKHACHHANG=hd.MAKHACHHANG\r\n                WHERE HD.HUYHD='FALSE'  AND kh.MAKHACHHANG ='" + Frmlichsumuahang.makhachhang + "' ORDER BY CONVERT(DATETIME,NGAY,103) DESC";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvhoadon.DataSource = dataTable;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A6C RID: 2668 RVA: 0x001A2520 File Offset: 0x001A0720
        private void dgvhoadon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (this.dgvhanghoa.RowCount > 0)
            //    {
            //        for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            //        {
            //            this.dgvhanghoa.Rows.RemoveAt(0);
            //        }
            //    }
            //    int rowIndex = this.dgvhoadon.CurrentCell.RowIndex;
            //    string text = this.dgvhoadon.Rows[rowIndex].Cells["sohoadon"].Value.ToString();
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.hdctr.GET_CHITIETHOADON(text);
            //    this.dgvhanghoa.DataSource = dataSource;
            //}
        }

        // Token: 0x06000A6D RID: 2669 RVA: 0x001A25E4 File Offset: 0x001A07E4
        private void dgvhanghoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            {
                this.dgvhanghoa.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000A6E RID: 2670 RVA: 0x001A2638 File Offset: 0x001A0838
        private void dgvhoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvhoadon.RowCount; i++)
            {
                this.dgvhoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000A6F RID: 2671 RVA: 0x001A268C File Offset: 0x001A088C
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = this.dataGridView1.RowCount - 1; i >= 0; i--)
            //    {
            //        this.dataGridView1.Rows[i].Cells[0].Value = i;
            //        if (i == this.dataGridView1.RowCount - 1)
            //        {
            //            this.dataGridView1["tongdiem", i].Value = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diem_diem"].Value.ToString()) + Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diemcong"].Value.ToString()) - Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diemtru"].Value.ToString());
            //        }
            //        else
            //        {
            //            this.dataGridView1["tongdiem", i].Value = Convert.ToDouble(this.dataGridView1.Rows[i + 1].Cells["tongdiem"].Value.ToString()) + Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diem_diem"].Value.ToString()) + Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diemcong"].Value.ToString()) - Convert.ToDouble(this.dataGridView1.Rows[i].Cells["diemtru"].Value.ToString());
            //        }
            //    }
            //    this.dataGridView1.Rows[0].Cells["tongdiem"].Style.BackColor = Color.Blue;
            //    this.dataGridView1.Rows[0].Cells["tongdiem"].Style.ForeColor = Color.Yellow;
            //}
        }

        // Token: 0x06000A70 RID: 2672 RVA: 0x001A290C File Offset: 0x001A0B0C
        private void dgvdiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (this.dgvdiem.RowCount > 0)
            //{
            //    for (int i = this.dgvdiem.RowCount - 1; i >= 0; i--)
            //    {
            //        this.dgvdiem.Rows[i].Cells[0].Value = i;
            //        if (i == this.dgvdiem.RowCount - 1)
            //        {
            //            this.dgvdiem["Tongtien_tang", i].Value = Convert.ToDouble(this.dgvdiem.Rows[i].Cells["sotien"].Value.ToString());
            //        }
            //        else
            //        {
            //            this.dgvdiem["Tongtien_tang", i].Value = Convert.ToDouble(this.dgvdiem.Rows[i + 1].Cells["Tongtien_tang"].Value.ToString()) + Convert.ToDouble(this.dgvdiem.Rows[i].Cells["sotien"].Value.ToString());
            //        }
            //    }
            //    this.dgvdiem.Rows[0].Cells["Tongtien_tang"].Style.BackColor = Color.Blue;
            //    this.dgvdiem.Rows[0].Cells["Tongtien_tang"].Style.ForeColor = Color.Yellow;
            //}
        }

        // Token: 0x06000A71 RID: 2673 RVA: 0x001A2AC8 File Offset: 0x001A0CC8
        private void dgvghichu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvghichu.RowCount > 0)
            //{
            //    if (this.dgvghichu.Columns[this.dgvghichu.CurrentCell.ColumnIndex].Name == "Hinh")
            //    {
            //        Frm_phonghinhcongno.mahang = "Select HINH FROM tb_ghichu WHERE ma ='" + this.dgvghichu.CurrentRow.Cells["ma_ghichu"].Value.ToString() + "'";
            //        Frm_phonghinhcongno frm_phonghinhcongno = new Frm_phonghinhcongno();
            //        frm_phonghinhcongno.ShowDialog();
            //    }
            //}
        }

        // Token: 0x06000A72 RID: 2674 RVA: 0x001A2B6C File Offset: 0x001A0D6C
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.txtsotien.Text == "")
            {
                this.txtsotien.Text = this.txtsotien.Tag.ToString();
            }
        }

        // Token: 0x06000A73 RID: 2675 RVA: 0x001A2BB4 File Offset: 0x001A0DB4
        private void txtsotien_Enter(object sender, EventArgs e)
        {
            if (this.txtsotien.Text == this.txtsotien.Tag.ToString())
            {
                this.txtsotien.Text = "";
            }
        }

        // Token: 0x06000A74 RID: 2676 RVA: 0x001A2BFC File Offset: 0x001A0DFC
        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtsotien.Text != this.txtsotien.Tag.ToString())
                {
                    if (this.txtsotien.Text != "")
                    {
                        this.txtsotien.Text = double.Parse(this.txtsotien.Text).ToString("#,###");
                        this.txtsotien.SelectionStart = this.txtsotien.TextLength;
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000A75 RID: 2677 RVA: 0x001A2CAC File Offset: 0x001A0EAC
        private void cobnhomchu_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.cobnhomchu.DataSource == null)
            {
                this.LOAD_NHOMCHU();
            }
        }

        // Token: 0x06000A76 RID: 2678 RVA: 0x001A2CD8 File Offset: 0x001A0ED8
        private void load_phieukhachhang()
        {
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_SOPHIEU_KH INSERT INTO TB_SOPHIEU_KH ( MAKHACHHANG,TENKHACHHANG,SDT,SOTIEN,MANHOM) (SELECT HD.MAKHACHHANG,KH.TENKHACHHANG,KH.SDT,SUM( BH.THANHTIEN) AS SOTIEN,NH.NHOMCHU\r\nFROM TB_HANGHOA HH,TB_CHITIETHOADON BH ,TB_NHOMHANG NH,TB_HOADONBANHANG HD,Tb_KHACHHANG KH,TB_NHOMCHU NC\r\nWHERE NH.MANHOM=HH.MANHOM AND NH.NHOMCHU=NC.MANHOM AND HH.MAHANGHOA=BH.MAHANGHOA AND HD.SOHOADON=BH.MAHOADON AND KH.MAKHACHHANG=HD.MAKHACHHANG AND HUY='FALSE' AND XUAT='XB'  \r\nAND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
            //    Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //    "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
            //    Convert.ToDateTime(this.dateTimePicker2.Text).ToString("MM/dd/yyyy"),
            //    "' AND NC.MANHOM='",
            //    this.cobnhomchu.SelectedValue.ToString(),
            //    "' GROUP BY HD.MAKHACHHANG,KH.TENKHACHHANG,KH.SDT,NH.NHOMCHU) SELECT KH.MAKHACHHANG,SP.TENDUNG  ,KH.TENKHACHHANG,KH.SDT,KH.SOTIEN, ISNULL(SP.SOPHIEU,'0')AS SOPHIEU,ISNULL(SP.TENPHIEU,'') AS TENPHIEU FROM TB_SOPHIEU_KH KH LEFT JOIN TB_SOPHIEU SP ON KH.manhom=SP.manhom and kh.makhachhang=sp.makhachhang WHERE KH.MANHOM='",
            //    this.cobnhomchu.SelectedValue.ToString(),
            //    "' GROUP BY KH.MAKHACHHANG,KH.TENKHACHHANG,KH.SDT,KH.SOTIEN, ISNULL(SP.SOPHIEU,'0'),TENPHIEU,KH.MANHOM,SP.TENDUNG ORDER BY KH.SOTIEN DESC"
            //});
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvphieumuahang.DataSource = dataTable;
            //for (int i = 0; i < this.dgvphieumuahang.RowCount; i++)
            //{
            //    this.sophieu_dainroi += int.Parse(this.dgvphieumuahang.Rows[i].Cells["Sophieu_phieu"].Value.ToString());
            //}
            //this.textBox4.Text = this.sophieu_dainroi.ToString();
        }

        // Token: 0x06000A77 RID: 2679 RVA: 0x0001DA2B File Offset: 0x0001BC2B
        private void cobnhomchu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_phieukhachhang();
        }

        // Token: 0x06000A78 RID: 2680 RVA: 0x001A2E54 File Offset: 0x001A1054
        private void txtsotien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000A79 RID: 2681 RVA: 0x001A2E80 File Offset: 0x001A1080
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtsotien.Text != this.txtsotien.Tag.ToString())
            //{
            //    if (double.Parse(this.txtsotien.Text) > 0.0)
            //    {
            //        for (int i = 0; i < this.dgvphieumuahang.RowCount; i++)
            //        {
            //            this.dgvphieumuahang.Rows[i].Cells["Sotienconlai_phieu"].Value = double.Parse(this.dgvphieumuahang.Rows[i].Cells["Sotien_phieu"].Value.ToString()) - double.Parse(this.dgvphieumuahang.Rows[i].Cells["Sophieu_phieu"].Value.ToString()) * double.Parse(this.txtsotien.Text);
            //            this.dgvphieumuahang.Rows[i].Cells["sophieu"].Value = double.Parse(this.dgvphieumuahang.Rows[i].Cells["Sotienconlai_phieu"].Value.ToString()) / double.Parse(this.txtsotien.Text);
            //            this.sophieu_canin += int.Parse(this.dgvphieumuahang.Rows[i].Cells["sophieu"].Value.ToString().Split(new char[]
            //            {
            //                '.'
            //            })[0]);
            //        }
            //        this.textBox3.Text = this.sophieu_canin.ToString();
            //    }
            //}
        }

        // Token: 0x06000A7A RID: 2682 RVA: 0x001A3070 File Offset: 0x001A1270
        private void mahanghoa()
        {
            //try
            //{
            //    this.maphieu_duocin = "";
            //    string selectCommandText = "select isnull(MAX(PHIEUCUOI),'0') from TB_SOPHIEU where len(PHIEUCUOI)='5' group by PHIEUCUOI having ISNUMERIC(PHIEUCUOI)=1 order by PHIEUCUOI desc";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        this.k = 1.0;
            //    }
            //    else
            //    {
            //        this.k = Convert.ToDouble(dataTable.Rows[0][0].ToString());
            //        this.k += 1.0;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A7B RID: 2683 RVA: 0x001A313C File Offset: 0x001A133C
        private void dgvphieumuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int columnIndex = this.dgvphieumuahang.CurrentCell.ColumnIndex;
            //    if (this.dgvphieumuahang.Columns[columnIndex].Name == "TENDUNG")
            //    {
            //        this.dgvphieumuahang.ReadOnly = false;
            //        this.dgvphieumuahang.BeginEdit(false);
            //    }
            //    else
            //    {
            //        this.dgvphieumuahang.ReadOnly = true;
            //    }
            //    if (this.dgvphieumuahang.Columns[columnIndex].Name == "INPHIEU")
            //    {
            //        if (this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value != null)
            //        {
            //            if (double.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value.ToString()) >= 1.0 && this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENDUNG"].Value.ToString().Trim() != "")
            //            {
            //                SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                sqlConnection.Open();
            //                this.mahanghoa();
            //                for (int i = 0; i < int.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value.ToString().Split(new char[]
            //                {
            //                    '.'
            //                })[0]); i++)
            //                {
            //                    this.s = "";
            //                    if (this.k < 10.0)
            //                    {
            //                        this.s += "1000";
            //                    }
            //                    else if (this.k < 100.0)
            //                    {
            //                        this.s += "100";
            //                    }
            //                    else if (this.k < 1000.0)
            //                    {
            //                        this.s += "10";
            //                    }
            //                    else if (this.k < 10000.0)
            //                    {
            //                        this.s += "1";
            //                    }
            //                    this.s += this.k.ToString();
            //                    if (this.maphieu_duocin == "")
            //                    {
            //                        this.maphieu_duocin = this.s;
            //                    }
            //                    else
            //                    {
            //                        this.maphieu_duocin = this.maphieu_duocin + ";" + this.s;
            //                    }
            //                    this.k += 1.0;
            //                }
            //                int num = int.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value.ToString());
            //                this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENPHIEU"].Value = this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENPHIEU"].Value.ToString() + ";" + this.maphieu_duocin;
            //                this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value = int.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value.ToString()) + int.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value.ToString().Split(new char[]
            //                {
            //                    '.'
            //                })[0]);
            //                this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value = double.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value.ToString()) - (double)int.Parse(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sophieu"].Value.ToString().Split(new char[]
            //                {
            //                    '.'
            //                })[0]);
            //                string cmdText;
            //                if (num > 0)
            //                {
            //                    cmdText = string.Concat(new string[]
            //                    {
            //                        "UPDATE TB_SOPHIEU SET TENPHIEU=N'",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENPHIEU"].Value.ToString(),
            //                        "',SOPHIEU='",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value.ToString(),
            //                        "',PHIEUCUOI='",
            //                        this.s,
            //                        "' WHERE MAKHACHHANG=N'",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["makhachhang_phieu"].Value.ToString(),
            //                        "' AND MANHOM=N'",
            //                        this.cobnhomchu.SelectedValue.ToString(),
            //                        "'"
            //                    });
            //                }
            //                else
            //                {
            //                    cmdText = string.Concat(new string[]
            //                    {
            //                        "INSERT INTO TB_SOPHIEU VALUES(N'",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["makhachhang_phieu"].Value.ToString(),
            //                        "',N'",
            //                        this.cobnhomchu.SelectedValue.ToString(),
            //                        "',N'",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENPHIEU"].Value.ToString(),
            //                        "','",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["Sophieu_phieu"].Value.ToString(),
            //                        "','",
            //                        this.s,
            //                        "',N'",
            //                        this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENDUNG"].Value.ToString().Trim(),
            //                        "')"
            //                    });
            //                }
            //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //                string[] array = this.maphieu_duocin.Split(new char[]
            //                {
            //                    ';'
            //                });
            //                foreach (string text in array)
            //                {
            //                    this.matem = text.ToString();
            //                    if (this.matem.Length == 5)
            //                    {
            //                        this.printDocument1.Print();
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        // Token: 0x06000A7C RID: 2684 RVA: 0x001A3A64 File Offset: 0x001A1C64
        private void printDocument1_PrintPage(object sender/*, PrintPageEventArgs e*/)
        {
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["TENDUNG"].Value.ToString(), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(80, 5), stringFormat);
            //e.Graphics.DrawString(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["tenkhachhang_phieu"].Value.ToString(), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(80, 23), stringFormat);
            //e.Graphics.DrawString(this.dgvphieumuahang.Rows[this.dgvphieumuahang.CurrentCell.RowIndex].Cells["sdt"].Value.ToString(), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(80, 43), stringFormat);
            //Code128BarcodeDraw code128WithChecksum = BarcodeDrawFactory.Code128WithChecksum;
            //Image image = code128WithChecksum.Draw(this.matem, 50);
            //e.Graphics.DrawImage(image, 20, 58, 120, 42);
            //e.Graphics.DrawString(this.matem, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(80, 100), stringFormat);
        }

        // Token: 0x06000A7D RID: 2685 RVA: 0x001A3C1C File Offset: 0x001A1E1C
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox5.Text != "")
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "SELECT KH.MAKHACHHANG,SP.TENDUNG  ,KH.TENKHACHHANG,KH.SDT,KH.SOTIEN, ISNULL(SP.SOPHIEU,'0')AS SOPHIEU,ISNULL(SP.TENPHIEU,'') AS TENPHIEU FROM TB_SOPHIEU_KH KH LEFT JOIN TB_SOPHIEU SP ON KH.manhom=SP.manhom and kh.makhachhang=sp.makhachhang  WHERE KH.MANHOM='",
            //        this.cobnhomchu.SelectedValue.ToString(),
            //        "' AND SP.TENPHIEU LIKE '%",
            //        this.textBox5.Text,
            //        "%' OR  KH.MANHOM='",
            //        this.cobnhomchu.SelectedValue.ToString(),
            //        "' AND SP.TENDUNG LIKE N'%",
            //        this.textBox5.Text,
            //        "%' OR KH.MANHOM='",
            //        this.cobnhomchu.SelectedValue.ToString(),
            //        "' AND KH.SDT LIKE '%",
            //        this.textBox5.Text,
            //        "%' OR KH.MANHOM='",
            //        this.cobnhomchu.SelectedValue.ToString(),
            //        "' AND KH.TENKHACHHANG LIKE N'%",
            //        this.textBox5.Text,
            //        "%'   GROUP BY KH.MAKHACHHANG,KH.TENKHACHHANG,KH.SDT,KH.SOTIEN, ISNULL(SP.SOPHIEU,'0'),TENPHIEU,KH.MANHOM,SP.TENDUNG ORDER BY KH.SOTIEN DESC"
            //    }), sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvphieumuahang.DataSource = dataTable;
            //    for (int i = 0; i < this.dgvphieumuahang.RowCount; i++)
            //    {
            //        this.sophieu_dainroi += int.Parse(this.dgvphieumuahang.Rows[i].Cells["Sophieu_phieu"].Value.ToString());
            //    }
            //    this.textBox4.Text = this.sophieu_dainroi.ToString();
            //}
        }

        // Token: 0x04000D23 RID: 3363
        public static string makhachhang = "";

        //// Token: 0x04000D24 RID: 3364
        //private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        //// Token: 0x04000D25 RID: 3365
        //private HoadonBanhangCtr hdctr = new HoadonBanhangCtr();

        // Token: 0x04000D26 RID: 3366
        private int sophieu_canin = 0;

        // Token: 0x04000D27 RID: 3367
        private int sophieu_dainroi = 0;

        // Token: 0x04000D28 RID: 3368
        private string maphieu_duocin = "";

        // Token: 0x04000D29 RID: 3369
        private double k;

        // Token: 0x04000D2A RID: 3370
        private string s = "";

        // Token: 0x04000D2B RID: 3371
        private string matem = "";
    }
}
