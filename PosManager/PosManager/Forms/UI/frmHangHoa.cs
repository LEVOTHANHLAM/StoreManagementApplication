using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class frmHangHoa : Form
    {
        // Token: 0x04000DA7 RID: 3495
        // private HanghoanhapObj hhnObj = new HanghoanhapObj();

        // Token: 0x04000DA8 RID: 3496
        //   private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        // Token: 0x04000DA9 RID: 3497
        private int chonnhom = 1;

        // Token: 0x04000DAA RID: 3498
        private int key = 0;

        // Token: 0x04000DAB RID: 3499
        private string manhapkho = string.Empty;

        // Token: 0x04000DAC RID: 3500
        //  private DongiaObj dgObj = new DongiaObj();

        // Token: 0x04000DAD RID: 3501
        public static string chon = string.Empty;

        // Token: 0x04000DAE RID: 3502
        //   private HangHoaCtr hhCrt = new HangHoaCtr();

        // Token: 0x04000DAF RID: 3503
        //  private HangHoaObj hhObj = new HangHoaObj();

        // Token: 0x04000DB0 RID: 3504
        public static string Ma_hanghoa = string.Empty;

        // Token: 0x04000DB1 RID: 3505
        private int flag = 0;

        // Token: 0x04000DB2 RID: 3506
        public frmHangHoa.GetData mahang;

        // Token: 0x04000DB3 RID: 3507
        public static int chon_suanhom = 0;

        // Token: 0x04000DB4 RID: 3508
        private string makho = "00";

        // Token: 0x04000DB5 RID: 3509
        public static string tennhom_sua = "";

        // Token: 0x04000DB6 RID: 3510
        public static string manhom_sua = "";

        // Token: 0x02000094 RID: 148
        // (Invoke) Token: 0x06000B39 RID: 2873
        public delegate void GetData(string mahang, string tenhang);
        public frmHangHoa()
        {
            InitializeComponent();
            tudongcapnhatnhom();
        }

        // Token: 0x06000A82 RID: 2690 RVA: 0x001AA178 File Offset: 0x001A8378
        private void tudongcapnhatnhom()
        {
            //this.txtmanhom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtmanhom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select TENNHOM from Tb_NHOMHANG";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtmanhom.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000A83 RID: 2691 RVA: 0x001AA214 File Offset: 0x001A8414
        private void tudonghanghoa()
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "Select MANHOM, TENNHOM from TB_NHOMHANG WHERE TENNHOM = N'" + this.txtmanhom.Text + "'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txtmanhom.Text = sqlDataReader.GetString(0);
            //        this.txttennhom.Text = sqlDataReader.GetString(1);
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.txttennhom.Text = "";
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A84 RID: 2692 RVA: 0x001AA2E8 File Offset: 0x001A84E8
        private void tudonghanghoaMA()
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "Select TENNHOM from TB_NHOMHANG WHERE MANHOM = N'" + this.txtmanhom.Text.Trim() + "'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txttennhom.Text = sqlDataReader.GetString(0);
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.txttennhom.Text = "";
            //        MessageBox.Show("Mã nhóm không tồn tại, Vui lòng thêm vào nhóm hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txtmanhom.Focus();
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A85 RID: 2693 RVA: 0x001AA3CC File Offset: 0x001A85CC
        private void LOADNHOMHANG()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT * FROM TB_NHOMHANG";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        this.cobnhom.DataSource = dataTable;
            //        this.cobnhom.DisplayMember = "TENNHOM";
            //        this.cobnhom.ValueMember = "MANHOM";
            //        this.cobnhom.SelectedIndex = -1;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A86 RID: 2694 RVA: 0x001AA494 File Offset: 0x001A8694
        private void LOADGIA()
        {
            //try
            //{
            //    int num = 0;
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "Select TEN from TB_GIA";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        if (num == 0)
            //        {
            //            this.txtgia1.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //        else if (num == 1)
            //        {
            //            this.txtgia2.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //        else if (num == 2)
            //        {
            //            this.txtgia3.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //        else if (num == 3)
            //        {
            //            this.txtgia4.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //        else if (num == 4)
            //        {
            //            this.txtgia5.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //        else if (num == 5)
            //        {
            //            this.txtgia6.Text = sqlDataReader.GetString(0);
            //            num++;
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A87 RID: 2695 RVA: 0x001AA61C File Offset: 0x001A881C
        private void nhacungcap()
        {
            //try
            //{
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.hhCrt.GetData_NHACUNGCAP();
            //    this.cobnhacungcap.DataSource = dataSource;
            //    this.cobnhacungcap.DisplayMember = "TENDONVI";
            //    this.cobnhacungcap.ValueMember = "MAKHACHHANG";
            //}
            //catch
            //{
            //    this.cobnhacungcap.DisplayMember = "Nhà Cung Cấp";
            //    this.cobnhacungcap.ValueMember = "CTY";
            //}
        }

        // Token: 0x06000A88 RID: 2696 RVA: 0x001AA6A8 File Offset: 0x001A88A8
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            //base.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //if (TrangChu.bantonkho == "True")
            //{
            //    this.load_kho();
            //}
            //try
            //{
            //    if (TrangChu.INTEM == "False")
            //    {
            //        this.button3.Visible = false;
            //    }
            //    if (TrangChu.codeEAN13 == "True")
            //    {
            //        this.txtMaHH.MaxLength = 15;
            //    }
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    if (TrangChu.bantonkho == "True")
            //    {
            //        string cmdText;
            //        if (TrangChu.dungnhieukho == "False")
            //        {
            //            string text = " AND HN.LOAI='" + frmLogIn.makho + "'";
            //            string text2 = " AND HHX.NCC='" + frmLogIn.makho + "'";
            //            cmdText = string.Concat(new string[]
            //            {
            //                "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,HN.LOAI,ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1    FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA ",
            //                text,
            //                " GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI,HN.NCC) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'',HHX.NCC,CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when HHX.DONVITINH=HH.DONVITINH  THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                " ELSE '0' END END AS SOLUONGTONG,   CASE WHEN HH.TONDONVI='FALSE' THEN    case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //                TrangChu.tile,
            //                ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                "*HH.QUYDOI1 END   END ELSE case when HHX.DONVITINH=HH.DONVITINH THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //                TrangChu.tile,
            //                ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                "*HH.QUYDOI1 END   END END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' ",
            //                text2,
            //                " GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.NCC,HH.TONDONVI) DELETE TB_LAILO INSERT INTO TB_LAILO(MAHOADON,KHACHHANG,THANHTIEN,LAILO)(SELECT MAHANGHOA,NCC,SUM(ISNULL(SOLUONGTONG,0)),'0' FROM TB_TONGHANGHOANHAP GROUP BY MAHANGHOA,NCC) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.MAHOADON,HHN.KHACHHANG, '0', '0', '0', '0', '0', '0',(isnull(hhn.THANHTIEN,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_LAILO HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHOADON=HHX.MAHANGHOA  group by hhn.MAHOADON,isnull(hhn.THANHTIEN,0),HHN.KHACHHANG)  UPDATE TB_HANGHOA  SET DONVITINHLON3 = (SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA)"
            //            });
            //        }
            //        else
            //        {
            //            cmdText = string.Concat(new string[]
            //            {
            //                "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1 \r\n                             FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when HHX.DONVITINH=HH.DONVITINH  THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                " ELSE '0' END END AS SOLUONGTONG,   CASE WHEN HH.TONDONVI='FALSE' THEN    case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //                TrangChu.tile,
            //                ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                "*HH.QUYDOI1 END   END ELSE case when HHX.DONVITINH=HH.DONVITINH THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //                TrangChu.tile,
            //                ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //                TrangChu.doicm,
            //                "*HH.QUYDOI1 END   END END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HH.TONDONVI) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_TONGHANGHOANHAP HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHANGHOA=HHX.MAHANGHOA group by hhn.mahanghoa,isnull(hhn.soluongTONG,0))  UPDATE TB_HANGHOA  SET DONVITINHLON3 = (SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA)"
            //            });
            //        }
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.dgvhanghoa.Columns["SLTON"].Visible = false;
            //    }
            //    this.dgvhanghoa.EnableHeadersVisualStyles = false;
            //    this.dgvhanghoa.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            //    this.groupBox1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, -8);
            //    if (TrangChu.XEMGIAVON == "True")
            //    {
            //        this.dgvhanghoa.Columns["Giavon"].Visible = true;
            //    }
            //    else
            //    {
            //        this.dgvhanghoa.Columns["Giavon"].Visible = false;
            //    }
            //    if (TrangChu.THEMHANG == "True")
            //    {
            //        this.btThem.Enabled = true;
            //    }
            //    else
            //    {
            //        this.btThem.Enabled = false;
            //    }
            //    if (TrangChu.SUAHANG == "True")
            //    {
            //        this.btSua.Enabled = true;
            //    }
            //    else
            //    {
            //        this.btSua.Enabled = false;
            //        this.checkBox2.Enabled = false;
            //    }
            //    if (TrangChu.XOAHANG != "True")
            //    {
            //        this.btXoa.Enabled = false;
            //        this.dgvhanghoa.Columns["xoa"].Visible = false;
            //    }
            //    if (TrangChu.diem == "0")
            //    {
            //        this.textBox12.Visible = false;
            //        this.txttichdiem.Visible = false;
            //        this.dgvhanghoa.Columns["diem"].Visible = false;
            //    }
            //    if (TrangChu.bantonkho == "False")
            //    {
            //        this.textBox11.Visible = false;
            //        this.textBox14.Visible = false;
            //        this.dgvhanghoa.Columns["SL_CANHBAO"].Visible = false;
            //    }
            //    if (TrangChu.MUAA_TANGB == "False")
            //    {
            //        this.textBox17.Visible = false;
            //        this.txtsltang.Visible = false;
            //        this.txtslban.Visible = false;
            //        this.txtmahangtang.Visible = false;
            //        this.textBox10.Visible = false;
            //        this.dgvhanghoa.Columns["matang"].Visible = false;
            //        this.dgvhanghoa.Columns["slban"].Visible = false;
            //        this.dgvhanghoa.Columns["sltang"].Visible = false;
            //    }
            //    if (!(TrangChu.GIA1 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia1"].Visible = false;
            //        this.txtgia1.Visible = false;
            //        this.txtDongia1.Visible = false;
            //    }
            //    if (!(TrangChu.GIA2 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia2"].Visible = false;
            //        this.txtgia2.Visible = false;
            //        this.txtdongia2.Visible = false;
            //        this.txtsl2.Visible = false;
            //    }
            //    if (!(TrangChu.GIA3 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia3"].Visible = false;
            //        this.txtgia3.Visible = false;
            //        this.txtdongia3.Visible = false;
            //        this.txtsl3.Visible = false;
            //    }
            //    if (!(TrangChu.GIA4 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia4"].Visible = false;
            //        this.txtgia4.Visible = false;
            //        this.txtdongia4.Visible = false;
            //        this.txtsl4.Visible = false;
            //    }
            //    if (!(TrangChu.GIA5 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia5"].Visible = false;
            //        this.txtgia5.Visible = false;
            //        this.txtdongia5.Visible = false;
            //        this.txtsl5.Visible = false;
            //    }
            //    if (!(TrangChu.GIA6 == "True"))
            //    {
            //        this.dgvhanghoa.Columns["gia6"].Visible = false;
            //        this.txtgia6.Visible = false;
            //        this.txtdongia6.Visible = false;
            //        this.txtsl6.Visible = false;
            //    }
            //    if (!(TrangChu.CK == "True"))
            //    {
            //        this.dgvhanghoa.Columns["Ck"].Visible = false;
            //        this.txtchietkhau.Visible = false;
            //        this.lbck.Visible = false;
            //    }
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.hhCrt.GetData();
            //    this.dgvhanghoa.DataSource = dataSource;
            //    this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
            //    if (TrangChu.mancc == "False")
            //    {
            //        this.cobnhacungcap.Visible = false;
            //        this.lbnhacungcap.Visible = false;
            //        this.cobnhacungcap.ValueMember = "CTY";
            //    }
            //    else
            //    {
            //        this.nhacungcap();
            //    }
            //    if (TrangChu.dvt_2 == "False")
            //    {
            //        this.textBox6.Visible = false;
            //        this.txtdonvilon.Visible = false;
            //        this.ldv1.Visible = false;
            //        this.txtquydoi2.Visible = false;
            //        this.ldv2.Visible = false;
            //        this.dgvhanghoa.Columns["dvt2"].Visible = false;
            //        this.dgvhanghoa.Columns["quydoi1"].Visible = false;
            //    }
            //    if (Settings.Default.mahangtudong == "True")
            //    {
            //        this.cbmahangtudong.Checked = true;
            //    }
            //    if (TrangChu.bantheo_soluong == "False")
            //    {
            //        this.txtsl1.Visible = false;
            //        this.txtsl2.Visible = false;
            //        this.txtsl3.Visible = false;
            //        this.txtsl4.Visible = false;
            //        this.txtsl5.Visible = false;
            //        this.txtsl6.Visible = false;
            //        this.textBox14.Width = 86;
            //        this.txtgianhap.Width = 86;
            //        this.txtchietkhau.Width = 77;
            //        this.txttichdiem.Width = 77;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A89 RID: 2697 RVA: 0x001AB08C File Offset: 0x001A928C
        private void bingding1()
        {
            //try
            //{
            //    this.txtmanhom.DataBindings.Clear();
            //    this.txtmanhom.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Manhom");
            //    this.txttennhom.DataBindings.Clear();
            //    this.txttennhom.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "tennhom");
            //    this.txtMaHH.DataBindings.Clear();
            //    this.txtMaHH.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "mahanghoa");
            //    this.txtTenHH.DataBindings.Clear();
            //    this.txtTenHH.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "TenHanghoa");
            //    this.txtDVT.DataBindings.Clear();
            //    this.txtDVT.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Donvitinh");
            //    this.txtdonvilon.DataBindings.Clear();
            //    this.txtdonvilon.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "DONVITINHLON");
            //    this.txtGhichu.DataBindings.Clear();
            //    this.txtGhichu.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "GhiChu");
            //    this.txtquydoi.DataBindings.Clear();
            //    this.txtquydoi.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "QUYDOI");
            //    this.txtquydoi2.DataBindings.Clear();
            //    this.txtquydoi2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "QUYDOI1");
            //    this.txtdonvitinhlon3.DataBindings.Clear();
            //    this.txtdonvitinhlon3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "DONVITINHLON3");
            //    this.txtDongia1.DataBindings.Clear();
            //    this.txtDongia1.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia");
            //    this.txtdongia2.DataBindings.Clear();
            //    this.txtdongia2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia2");
            //    this.txtdongia3.DataBindings.Clear();
            //    this.txtdongia3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia3");
            //    this.txtdongia4.DataBindings.Clear();
            //    this.txtdongia4.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia4");
            //    this.txtdongia5.DataBindings.Clear();
            //    this.txtdongia5.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia5");
            //    this.txtdongia6.DataBindings.Clear();
            //    this.txtdongia6.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia6");
            //    this.txtchietkhau.DataBindings.Clear();
            //    this.txtchietkhau.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "chietkhau");
            //    this.txtsl1.DataBindings.Clear();
            //    this.txtsl1.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL1");
            //    this.txtsl2.DataBindings.Clear();
            //    this.txtsl2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL2");
            //    this.txtsl3.DataBindings.Clear();
            //    this.txtsl3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL3");
            //    this.txtsl4.DataBindings.Clear();
            //    this.txtsl4.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL4");
            //    this.txtsl5.DataBindings.Clear();
            //    this.txtsl5.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL5");
            //    this.txtsl6.DataBindings.Clear();
            //    this.txtsl6.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL6");
            //    this.textBox14.DataBindings.Clear();
            //    this.textBox14.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL_CANHBAO");
            //    this.txtslban.DataBindings.Clear();
            //    this.txtslban.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SLBAN");
            //    this.txtsltang.DataBindings.Clear();
            //    this.txtsltang.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "sltang");
            //    this.txtmahangtang.DataBindings.Clear();
            //    this.txtmahangtang.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "mahang");
            //    this.txtgianhap.DataBindings.Clear();
            //    this.txtgianhap.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "giavon");
            //    this.txtmanhom.DataBindings.Clear();
            //    this.txtmanhom.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Manhom");
            //    if (this.txtMaHH.Text != "" && TrangChu.bantonkho == "True")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        string cmdText = "select SOLUONG,DONGIA from TB_HANGHOANHAP WHERE MAHANGHOA='" + this.txtMaHH.Text + "' AND STT='2222'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txtsl.Text = (double.Parse(sqlDataReader.GetValue(0).ToString()) / double.Parse(this.txtquydoi2.Text)).ToString();
            //            this.txtgianhap.Text = sqlDataReader.GetValue(1).ToString();
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txtsl.Text = "0";
            //            this.txtgianhap.Text = "0";
            //        }
            //        sqlConnection.Close();
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A8A RID: 2698 RVA: 0x001AB818 File Offset: 0x001A9A18
        private void bingding()
        {
            //try
            //{
            //    this.txtmanhom.DataBindings.Clear();
            //    this.txtmanhom.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Manhom");
            //    this.txttennhom.DataBindings.Clear();
            //    this.txttennhom.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "tennhom");
            //    this.txtMaHH.DataBindings.Clear();
            //    this.txtMaHH.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "mahanghoa");
            //    this.txtTenHH.DataBindings.Clear();
            //    this.txtTenHH.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "TenHanghoa");
            //    this.txtDVT.DataBindings.Clear();
            //    this.txtDVT.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Donvitinh");
            //    this.txtdonvilon.DataBindings.Clear();
            //    this.txtdonvilon.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "DONVITINHLON");
            //    this.txtGhichu.DataBindings.Clear();
            //    this.txtGhichu.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "GhiChu");
            //    this.txtquydoi.DataBindings.Clear();
            //    this.txtquydoi.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "QUYDOI");
            //    this.txtquydoi2.DataBindings.Clear();
            //    this.txtquydoi2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "QUYDOI1");
            //    this.txtdonvitinhlon3.DataBindings.Clear();
            //    this.txtdonvitinhlon3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "DONVITINHLON3");
            //    this.txtDongia1.DataBindings.Clear();
            //    this.txtDongia1.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia");
            //    this.txtdongia2.DataBindings.Clear();
            //    this.txtdongia2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia2");
            //    this.txtdongia3.DataBindings.Clear();
            //    this.txtdongia3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia3");
            //    this.txtdongia4.DataBindings.Clear();
            //    this.txtdongia4.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia4");
            //    this.txtdongia5.DataBindings.Clear();
            //    this.txtdongia5.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia5");
            //    this.txtdongia6.DataBindings.Clear();
            //    this.txtdongia6.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "Dongia6");
            //    this.txtchietkhau.DataBindings.Clear();
            //    this.txtchietkhau.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "chietkhau");
            //    this.txtsl1.DataBindings.Clear();
            //    this.txtsl1.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL1");
            //    this.txtsl2.DataBindings.Clear();
            //    this.txtsl2.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL2");
            //    this.txtsl3.DataBindings.Clear();
            //    this.txtsl3.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL3");
            //    this.txtsl4.DataBindings.Clear();
            //    this.txtsl4.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL4");
            //    this.txtsl5.DataBindings.Clear();
            //    this.txtsl5.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL5");
            //    this.txtsl6.DataBindings.Clear();
            //    this.txtsl6.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL6");
            //    this.textBox14.DataBindings.Clear();
            //    this.textBox14.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SL_CANHBAO");
            //    this.txtslban.DataBindings.Clear();
            //    this.txtslban.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "SLBAN");
            //    this.txtsltang.DataBindings.Clear();
            //    this.txtsltang.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "sltang");
            //    this.txtmahangtang.DataBindings.Clear();
            //    this.txtmahangtang.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "mahang");
            //    this.txtgianhap.DataBindings.Clear();
            //    this.txtgianhap.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "giavon");
            //    this.txttichdiem.DataBindings.Clear();
            //    this.txttichdiem.DataBindings.Add("Text", this.dgvhanghoa.DataSource, "DIEM");
            //    if (this.txtMaHH.Text != "" && TrangChu.bantonkho == "True")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        string cmdText = "select SOLUONGQUYDOI from TB_HANGHOANHAP WHERE MAHANGHOA='" + this.txtMaHH.Text + "' AND STT='2222'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            if (Convert.ToBoolean(this.dgvhanghoa.Rows[this.dgvhanghoa.CurrentRow.Index].Cells["TONDV"].Value.ToString()))
            //            {
            //                this.txtsl.Text = double.Parse(sqlDataReader.GetValue(0).ToString()).ToString("#,##0.##");
            //            }
            //            else
            //            {
            //                this.txtsl.Text = (double.Parse(sqlDataReader.GetValue(0).ToString()) / double.Parse(this.txtquydoi2.Text)).ToString("#,##0.##");
            //            }
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txtsl.Text = "0";
            //        }
            //        sqlConnection.Close();
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A8B RID: 2699 RVA: 0x001ABFF8 File Offset: 0x001AA1F8
        private void dis_en(bool e)
        {
            this.txtmahangtang.Enabled = e;
            this.txtsltang.Enabled = e;
            this.txtslban.Enabled = e;
            this.txtgianhap.Enabled = e;
            this.txtsl.Enabled = e;
            this.textBox14.Enabled = e;
            this.txtdonvitinhlon3.Enabled = e;
            this.txtquydoi2.Enabled = e;
            this.txtchietkhau.Enabled = e;
            this.txtdonvilon.Enabled = e;
            this.txtquydoi.Enabled = e;
            this.txtmanhom.Enabled = e;
            this.txtMaHH.Enabled = e;
            this.txtTenHH.Enabled = e;
            this.txtDVT.Enabled = e;
            this.txtDongia1.Enabled = e;
            this.txtdongia2.Enabled = e;
            this.txtdongia3.Enabled = e;
            this.txtdongia4.Enabled = e;
            this.txttichdiem.Enabled = e;
            this.txtdongia5.Enabled = e;
            this.txtdongia6.Enabled = e;
            this.txtSoluong.Enabled = e;
            this.txtGhichu.Enabled = e;
            this.btThem.Enabled = !e;
            this.btSua.Enabled = !e;
            this.btXoa.Enabled = !e;
            this.btLuu.Enabled = e;
            this.bthuy.Enabled = e;
            this.textBox3.Enabled = e;
            this.textBox4.Enabled = e;
            this.textBox5.Enabled = e;
            this.textBox6.Enabled = e;
            this.textBox7.Enabled = e;
            this.textBox8.Enabled = e;
            this.lbck.Enabled = e;
            this.ldv1.Enabled = e;
            this.ldv2.Enabled = e;
            this.txtsl1.Enabled = e;
            this.txtsl2.Enabled = e;
            this.txtsl3.Enabled = e;
            this.txtsl4.Enabled = e;
            this.txtsl5.Enabled = e;
            this.txtsl6.Enabled = e;
        }

        // Token: 0x06000A8C RID: 2700 RVA: 0x0009B888 File Offset: 0x00099A88
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

        // Token: 0x06000A8D RID: 2701 RVA: 0x001AC24C File Offset: 0x001AA44C
        //private void ganDulieu(HangHoaObj hhObj)
        //{
        //    if (this.txtDongia1.Text == "")
        //    {
        //        this.txtDongia1.Text = "0";
        //    }
        //    if (this.txtdongia2.Text == "")
        //    {
        //        this.txtdongia2.Text = "0";
        //    }
        //    if (this.txtdongia3.Text == "")
        //    {
        //        this.txtdongia3.Text = "0";
        //    }
        //    if (this.txtdongia4.Text == "")
        //    {
        //        this.txtdongia4.Text = "0";
        //    }
        //    if (this.txtdongia5.Text == "")
        //    {
        //        this.txtdongia5.Text = "0";
        //    }
        //    if (this.txtdongia6.Text == "")
        //    {
        //        this.txtdongia6.Text = "0";
        //    }
        //    if (this.txtsl1.Text == "")
        //    {
        //        this.txtsl1.Text = "0";
        //    }
        //    if (this.txtsl2.Text == "")
        //    {
        //        this.txtsl2.Text = "0";
        //    }
        //    if (this.txtsl3.Text == "")
        //    {
        //        this.txtsl3.Text = "0";
        //    }
        //    if (this.txtsl4.Text == "")
        //    {
        //        this.txtsl4.Text = "0";
        //    }
        //    if (this.txtsl5.Text == "")
        //    {
        //        this.txtsl5.Text = "0";
        //    }
        //    if (this.txtsl6.Text == "")
        //    {
        //        this.txtsl6.Text = "0";
        //    }
        //    if (this.txttichdiem.Text.Trim() == "")
        //    {
        //        this.txttichdiem.Text = "0";
        //    }
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    if (TrangChu.codeEAN13 == "True")
        //    {
        //        hhObj.MaHH = this.richTextBox1.Text;
        //    }
        //    else
        //    {
        //        hhObj.MaHH = this.txtMaHH.Text.Trim();
        //    }
        //    hhObj.TenHangHoa = this.txtTenHH.Text.Trim();
        //    hhObj.Donvitinh = this.txtDVT.Text.Trim();
        //    if (this.txtmahangtang.Text == this.txtmahangtang.Tag.ToString())
        //    {
        //        hhObj.Mahangtang = "";
        //    }
        //    else
        //    {
        //        hhObj.Mahangtang = this.txtmahangtang.Text;
        //    }
        //    hhObj.Slban = float.Parse(float.Parse(this.txtslban.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sltang = float.Parse(float.Parse(this.txtsltang.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Giavon = float.Parse(decimal.Parse(this.txtgianhap.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia1 = decimal.Parse(decimal.Parse(this.txtDongia1.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia2 = decimal.Parse(decimal.Parse(this.txtdongia2.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia3 = decimal.Parse(decimal.Parse(this.txtdongia3.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia4 = decimal.Parse(decimal.Parse(this.txtdongia4.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia5 = decimal.Parse(decimal.Parse(this.txtdongia5.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia6 = decimal.Parse(decimal.Parse(this.txtdongia6.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Soluong = decimal.Parse(decimal.Parse(this.txtSoluong.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Ghichu = this.txtGhichu.Text.Trim();
        //    if (this.txtchietkhau.Text == "")
        //    {
        //        this.txtchietkhau.Text = "0";
        //    }
        //    if (this.textBox14.Text == "")
        //    {
        //        this.textBox14.Text = "0";
        //    }
        //    hhObj.Chietkhau = decimal.Parse(decimal.Parse(this.txtchietkhau.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Manhom = this.txtmanhom.Text;
        //    hhObj.Quydoi = decimal.Parse(this.txtquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Ncc = "CTY";
        //    if (this.cobnhacungcap.SelectedValue != null)
        //    {
        //        hhObj.Ncc = this.cobnhacungcap.SelectedValue.ToString();
        //    }
        //    if (this.txtdonvilon.Text == "")
        //    {
        //        this.txtdonvilon.Text = this.txtDVT.Text;
        //    }
        //    hhObj.Donvitinhlon = this.txtdonvilon.Text;
        //    hhObj.Donvitinhlon3 = this.txtsl.Text;
        //    if (this.txtquydoi2.Text == "")
        //    {
        //        this.txtquydoi2.Text = "1";
        //    }
        //    if (this.txtquydoi2.Text == "0")
        //    {
        //        this.txtquydoi2.Text = "1";
        //    }
        //    hhObj.Quydoi1 = double.Parse(double.Parse(this.txtquydoi2.Text).ToString()).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Diem = decimal.Parse(this.txttichdiem.Text.Trim()).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Tenhang_khongdau = this.NonUnicode(this.txtTenHH.Text.Trim()).Trim();
        //    hhObj.Sl1 = float.Parse(float.Parse(this.txtsl1.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl2 = float.Parse(float.Parse(this.txtsl2.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl3 = float.Parse(float.Parse(this.txtsl3.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl4 = float.Parse(float.Parse(this.txtsl4.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl5 = float.Parse(float.Parse(this.txtsl5.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl6 = float.Parse(float.Parse(this.txtsl6.Text).ToString("", cultureInfo.NumberFormat));
        //    if (this.textBox14.Text == "")
        //    {
        //        this.textBox14.Text = "0";
        //    }
        //    hhObj.Sl_canhbao = float.Parse(float.Parse(this.textBox14.Text).ToString("", cultureInfo.NumberFormat));
        //    string text = "";
        //    string[] array = hhObj.Tenhang_khongdau.Split(new char[]
        //    {
        //        ' '
        //    });
        //    foreach (string text2 in array)
        //    {
        //        if (text2.ToString().Length > 0)
        //        {
        //            text += text2.ToString().Substring(0, 1);
        //        }
        //    }
        //    hhObj.Kytudau = text;
        //    if (this.cbton.Checked)
        //    {
        //        hhObj.Tondonvi = "True";
        //    }
        //    else
        //    {
        //        hhObj.Tondonvi = "False";
        //    }
        //}

        // Token: 0x06000A8E RID: 2702 RVA: 0x001ACC24 File Offset: 0x001AAE24
        //private void ganDulieusua(HangHoaObj hhObj)
        //{
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    hhObj.MaHH = this.txtMaHH.Text.Trim();
        //    hhObj.TenHangHoa = this.txtTenHH.Text.Trim();
        //    hhObj.Donvitinh = this.txtDVT.Text.Trim();
        //    hhObj.Dongia1 = decimal.Parse(decimal.Parse(this.txtDongia1.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia2 = decimal.Parse(decimal.Parse(this.txtdongia2.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia3 = decimal.Parse(decimal.Parse(this.txtdongia3.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia4 = decimal.Parse(decimal.Parse(this.txtdongia4.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia5 = decimal.Parse(decimal.Parse(this.txtdongia5.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Dongia6 = decimal.Parse(decimal.Parse(this.txtdongia6.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Soluong = decimal.Parse(decimal.Parse(this.txtSoluong.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Ghichu = this.txtGhichu.Text.Trim();
        //    hhObj.Chietkhau = decimal.Parse(this.txtchietkhau.Text.Trim());
        //    hhObj.Manhom = this.txtmanhom.Text;
        //    hhObj.Quydoi = decimal.Parse(this.txtquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Ncc = "CTY";
        //    if (this.cobnhacungcap.SelectedValue != null)
        //    {
        //        hhObj.Ncc = this.cobnhacungcap.SelectedValue.ToString();
        //    }
        //    hhObj.Donvitinhlon = this.txtdonvilon.Text;
        //    hhObj.Quydoi1 = double.Parse(double.Parse(this.txtquydoi2.Text).ToString()).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Diem = decimal.Parse(this.txttichdiem.Text.Trim()).ToString("", cultureInfo.NumberFormat);
        //    hhObj.Tenhang_khongdau = this.NonUnicode(this.txtTenHH.Text.Trim()).Trim();
        //    hhObj.Sl1 = float.Parse(float.Parse(this.txtsl1.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl2 = float.Parse(float.Parse(this.txtsl2.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl3 = float.Parse(float.Parse(this.txtsl3.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl4 = float.Parse(float.Parse(this.txtsl4.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl5 = float.Parse(float.Parse(this.txtsl5.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl6 = float.Parse(float.Parse(this.txtsl6.Text).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sl_canhbao = float.Parse(float.Parse(this.textBox14.Text).ToString("", cultureInfo.NumberFormat));
        //    if (this.txtmahangtang.Text == this.txtmahangtang.Tag.ToString())
        //    {
        //        hhObj.Mahangtang = "";
        //    }
        //    else
        //    {
        //        hhObj.Mahangtang = this.txtmahangtang.Text;
        //    }
        //    hhObj.Slban = float.Parse(float.Parse(this.txtslban.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Sltang = float.Parse(float.Parse(this.txtsltang.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    hhObj.Giavon = float.Parse(decimal.Parse(this.txtgianhap.Text.Trim()).ToString("", cultureInfo.NumberFormat));
        //    string text = "";
        //    string[] array = hhObj.Tenhang_khongdau.Split(new char[]
        //    {
        //        ' '
        //    });
        //    foreach (string text2 in array)
        //    {
        //        text += text2.ToString().Substring(0, 1);
        //    }
        //    hhObj.Kytudau = text;
        //    if (this.cbton.Checked)
        //    {
        //        hhObj.Tondonvi = "True";
        //    }
        //    else
        //    {
        //        hhObj.Tondonvi = "False";
        //    }
        //}

        // Token: 0x06000A8F RID: 2703 RVA: 0x001AD204 File Offset: 0x001AB404
        //private void ganDulieu_DONGIA(DongiaObj dgObj)
        //{
        //    dgObj.Mahanghoa = this.txtMaHH.Text.Trim();
        //    dgObj.Dongia1 = decimal.Parse(this.txtDongia1.Text.Trim()).ToString();
        //    dgObj.Dongia2 = decimal.Parse(this.txtdongia2.Text.Trim()).ToString();
        //    dgObj.Dongia3 = decimal.Parse(this.txtdongia3.Text.Trim()).ToString();
        //    dgObj.Dongia4 = decimal.Parse(this.txtdongia4.Text.Trim()).ToString();
        //    dgObj.Dongia5 = decimal.Parse(this.txtdongia5.Text.Trim()).ToString();
        //    dgObj.Dongia6 = decimal.Parse(this.txtdongia6.Text.Trim()).ToString();
        //    dgObj.Chietkhau = decimal.Parse(this.txtchietkhau.Text.Trim()).ToString();
        //    this.hhObj.Ncc = "CTY";
        //    if (this.cobnhacungcap.SelectedValue != null)
        //    {
        //        dgObj.Ncc = this.cobnhacungcap.SelectedValue.ToString();
        //    }
        //}

        // Token: 0x06000A90 RID: 2704 RVA: 0x001AD360 File Offset: 0x001AB560
        private void cleardata()
        {
            this.checkBox1.Checked = false;
            this.txtTenHH.Text = "";
            this.txtDongia1.Text = "0";
            this.txtdongia2.Text = "0";
            this.txtdongia3.Text = "0";
            this.txtdongia4.Text = "0";
            this.txtdongia5.Text = "0";
            this.txtdongia6.Text = "0";
            this.txtSoluong.Text = "0";
            this.txtGhichu.Text = "";
            this.txtquydoi.Text = "1";
            this.txtquydoi2.Text = "1";
            this.txtsl.Text = this.txtsl.Tag.ToString();
            this.txtsl1.Text = "0";
            this.txtsl2.Text = "0";
            this.txtsl3.Text = "0";
            this.txtsl4.Text = "0";
            this.txtsl5.Text = "0";
            this.txtsl6.Text = "0";
            this.txtgianhap.Text = this.txtgianhap.Tag.ToString();
            if (!this.cbmahangtudong.Checked)
            {
                this.txtMaHH.Text = "";
                this.txtMaHH.Focus();
            }
            else
            {
                this.mahanghoa();
                this.txtTenHH.Focus();
            }
        }

        // Token: 0x06000A91 RID: 2705 RVA: 0x001AD51C File Offset: 0x001AB71C
        private bool kiemtratontai(string mahanghoa)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand;
            //if (TrangChu.codeEAN13 == "True")
            //{
            //    sqlCommand = new SqlCommand("Select MAHANGHOA from Tb_HANGHOA WHERE MAHANGHOA='" + this.richTextBox1.Text + "'", sqlConnection);
            //}
            //else
            //{
            //    sqlCommand = new SqlCommand("Select MAHANGHOA from Tb_HANGHOA WHERE MAHANGHOA='" + mahanghoa + "'", sqlConnection);
            //}
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    if (mahanghoa == sqlDataReader.GetString(0))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //sqlConnection.Close();
            return result;
        }

        // Token: 0x06000A92 RID: 2706 RVA: 0x001AD5E4 File Offset: 0x001AB7E4
        private bool kiemtratontai_dongia(string mahanghoa, string ncc)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select MAHANGHOA,NCC from Tb_DONGIA WHERE MAHANGHOA='" + this.txtMaHH.Text + "'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    if (mahanghoa == sqlDataReader.GetString(0) && ncc == sqlDataReader.GetString(1))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //sqlConnection.Close();
            return result;
        }

        // Token: 0x06000A93 RID: 2707 RVA: 0x001AD68C File Offset: 0x001AB88C
        private void mahanghoa()
        {
            //try
            //{
            //    if (TrangChu.codeEAN13 == "True")
            //    {
            //        this.mahanghoa_code13();
            //    }
            //    else
            //    {
            //        string selectCommandText = "select isnull(MAX(mahanghoa),'0') from Tb_HANGHOA where len(mahanghoa)='5' group by MAHANGHOA having ISNUMERIC(mahanghoa)=1 order by MAHANGHOA desc";
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //        {
            //            ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //        });
            //        DataTable dataTable = new DataTable();
            //        sqlDataAdapter.Fill(dataTable);
            //        string text = "";
            //        if (dataTable.Rows.Count <= 0)
            //        {
            //            text = "00001";
            //        }
            //        else
            //        {
            //            double num = Convert.ToDouble(dataTable.Rows[0][0].ToString());
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
            //        this.txtMaHH.Text = text;
            //    }
            //}
            //catch
            //{
            //    this.txtMaHH.Text = "";
            //    this.txtMaHH.Focus();
            //}
        }

        // Token: 0x06000A94 RID: 2708 RVA: 0x001AD844 File Offset: 0x001ABA44
        private void mahanghoa_code13()
        {
            //string text = DateTime.Now.ToString("yy");
            //string selectCommandText = "select TOP 1 isnull(SUBSTRING(mahanghoa,6,7),'00000') from Tb_HANGHOA where len(MAHANGHOA)='13' AND SUBSTRING(mahanghoa,6,2)='" + text + "'  group by MAHANGHOA having ISNUMERIC(mahanghoa)=1 ORDER BY isnull(SUBSTRING(mahanghoa,6,7),'00000')DESC";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //{
            //    ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //});
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //string text2;
            //if (dataTable.Rows.Count <= 0)
            //{
            //    text2 = text + "00001";
            //}
            //else
            //{
            //    string a = Convert.ToString(dataTable.Rows[0][0].ToString().Substring(0, 2));
            //    text2 = text;
            //    if (a == text2)
            //    {
            //        double num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(2, 5));
            //        num += 1.0;
            //        if (num < 10.0)
            //        {
            //            text2 += "0000";
            //        }
            //        else if (num < 100.0)
            //        {
            //            text2 += "000";
            //        }
            //        else if (num < 1000.0)
            //        {
            //            text2 += "00";
            //        }
            //        else if (num < 10000.0)
            //        {
            //            text2 += "0";
            //        }
            //        text2 += num.ToString();
            //    }
            //    else
            //    {
            //        text2 = text + "00001";
            //    }
            //}
            //this.txtMaHH.Text = text2;
        }

        // Token: 0x06000A95 RID: 2709 RVA: 0x001ADA14 File Offset: 0x001ABC14
        private void btThem_Click(object sender, EventArgs e)
        {
            if (this.txtmanhom.Text.Trim() == "")
            {
                this.btnhom_Click(null, null);
            }
            this.flag = 0;
            this.dis_en(true);
            this.cleardata();
        }

        // Token: 0x06000A96 RID: 2710 RVA: 0x0001DA41 File Offset: 0x0001BC41
        private void btSua_Click(object sender, EventArgs e)
        {
            this.flag = 1;
            this.dis_en(true);
            this.txtMaHH.Enabled = false;
            this.txtTenHH.Focus();
        }

        // Token: 0x06000A97 RID: 2711 RVA: 0x001ADA64 File Offset: 0x001ABC64
        private void btXoa_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    if (this.hhCrt.DelData(this.txtMaHH.Text.Trim()))
            //    {
            //        try
            //        {
            //            int index = this.dgvhanghoa.CurrentRow.Index;
            //            this.dgvhanghoa.Rows.RemoveAt(index);
            //            this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            if (sqlConnection.State == ConnectionState.Open)
            //            {
            //                sqlConnection.Close();
            //            }
            //            SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //            {
            //                "DELETE TB_HINHHANGHOA WHERE MAHANG='",
            //                this.txtMaHH.Text,
            //                "' UPDATE TB_CHITIETHOADON SET MAHANGHOA=MAHANGHOA+'(DEL)' WHERE MAHANGHOA='",
            //                this.txtMaHH.Text,
            //                "' DELETE TB_HANGHOANHAP WHERE MAHANGHOA='",
            //                this.txtMaHH.Text,
            //                "'"
            //            }), sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            sqlConnection.Close();
            //        }
            //        catch
            //        {
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //}
        }

        // Token: 0x06000A98 RID: 2712 RVA: 0x001ADBE8 File Offset: 0x001ABDE8
        private void btLuu_Click(object sender, EventArgs e)
        {
            //if (this.txtsl.Text == this.txtsl.Tag.ToString())
            //{
            //    this.txtsl.Text = "0";
            //}
            //if (this.txtgianhap.Text == this.txtgianhap.Tag.ToString())
            //{
            //    this.txtgianhap.Text = "0";
            //}
            //if (this.flag == 0 || this.flag == 2)
            //{
            //    if (this.txtMaHH.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP MÃ HÀNG HÓA", "THÔNG BÁO");
            //        this.txtMaHH.Focus();
            //    }
            //    else if (this.txtTenHH.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP TÊN HÀNG HÓA", "THÔNG BÁO");
            //        this.txtTenHH.Focus();
            //    }
            //    else if (this.txttennhom.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP TÊN NHÓM", "THÔNG BÁO");
            //        this.txtmanhom.Text = "";
            //        this.txtmanhom.Focus();
            //    }
            //    else
            //    {
            //        this.ganDulieu(this.hhObj);
            //        this.txtmaphu.Text = this.txtMaHH.Text;
            //        if (this.hhCrt.AddData(this.hhObj))
            //        {
            //            if (this.txtsl.Text != "0")
            //            {
            //                this.nhaphanghoa(this.hhnObj);
            //                this.txtsl.Text = "0";
            //                this.txtgianhap.Text = "0";
            //            }
            //            if (TrangChu.codeEAN13 == "True")
            //            {
            //                this.txtMaHH.Text = this.richTextBox1.Text;
            //            }
            //            DataTable dataTable = new DataTable();
            //            dataTable = this.hhCrt.GetData();
            //            this.dgvhanghoa.DataSource = dataTable;
            //            this.txtsodong.Text = dataTable.Rows.Count.ToString();
            //            for (int i = 0; i < this.dgvhanghoa.Rows.Count; i++)
            //            {
            //                if (this.dgvhanghoa["mahanghoa1", i].Value.ToString() == this.txtMaHH.Text.ToUpper())
            //                {
            //                    this.dgvhanghoa.ClearSelection();
            //                    this.dgvhanghoa.Rows[i].Selected = true;
            //                    this.dgvhanghoa.CurrentCell = this.dgvhanghoa.Rows[i].Cells["tenhang"];
            //                    break;
            //                }
            //            }
            //            if (this.flag == 0)
            //            {
            //                if (this.cbthemlientuc.Checked)
            //                {
            //                    this.flag = 0;
            //                    this.cleardata();
            //                    if (!this.cbmahangtudong.Checked)
            //                    {
            //                        this.txtMaHH.Focus();
            //                    }
            //                    else
            //                    {
            //                        this.txtTenHH.Focus();
            //                        this.mahanghoa();
            //                        this.txtmahangtang.Text = this.txtMaHH.Text;
            //                    }
            //                }
            //            }
            //            else if (this.flag == 2)
            //            {
            //                this.bingding();
            //                if (!this.cbmahangtudong.Checked)
            //                {
            //                    this.txtMaHH.Focus();
            //                    this.txtMaHH.SelectionStart = this.txtMaHH.TextLength;
            //                }
            //                else
            //                {
            //                    this.mahanghoa();
            //                    this.txtTenHH.Focus();
            //                    this.txtTenHH.SelectionStart = this.txtTenHH.TextLength;
            //                    this.txtmahangtang.Text = this.txtMaHH.Text;
            //                }
            //                this.txtsl.Text = "0";
            //                this.txtgianhap.Text = "0";
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thêm không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }
            //    }
            //}
            //else if (this.flag == 1)
            //{
            //    if (this.txtMaHH.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP MÃ HÀNG HÓA", "THÔNG BÁO");
            //        this.txtMaHH.Focus();
            //    }
            //    else if (this.txtTenHH.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP TÊN HÀNG HÓA", "THÔNG BÁO");
            //        this.txtTenHH.Focus();
            //    }
            //    else if (this.txttennhom.Text == "" || this.txtmanhom.Text == "")
            //    {
            //        MessageBox.Show("CHƯA NHẬP NHÓM", "THÔNG BÁO");
            //        this.txtmanhom.Focus();
            //    }
            //    else
            //    {
            //        this.ganDulieusua(this.hhObj);
            //        if (this.hhCrt.UpdData(this.hhObj))
            //        {
            //            if (this.txtMaHH.Text != "" && this.txtsl.Text != "0")
            //            {
            //                SqlConnection sqlConnection = new SqlConnection();
            //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //                SqlCommand sqlCommand = new SqlCommand("SELECT MAHANGHOA FROM TB_HANGHOANHAP WHERE MAHANGHOA='" + this.txtMaHH.Text + "' AND STT='2222'", sqlConnection);
            //                sqlConnection.Open();
            //                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //                if (sqlDataReader.HasRows)
            //                {
            //                    sqlConnection.Close();
            //                    decimal num;
            //                    if (!this.cbton.Checked)
            //                    {
            //                        num = decimal.Parse(this.txtquydoi2.Text) * decimal.Parse(this.txtsl.Text);
            //                    }
            //                    else
            //                    {
            //                        num = decimal.Parse(this.txtsl.Text);
            //                    }
            //                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //                    SqlCommand sqlCommand2 = new SqlCommand(string.Concat(new object[]
            //                    {
            //                        "UPDATE TB_HANGHOANHAP SET SOLUONG='",
            //                        num.ToString("", cultureInfo.NumberFormat),
            //                        "',SOLUONGQUYDOI='",
            //                        num.ToString("", cultureInfo.NumberFormat),
            //                        "',DONGIA='",
            //                        double.Parse(this.txtgianhap.Text),
            //                        "' WHERE MAHANGHOA='",
            //                        this.txtMaHH.Text,
            //                        "' AND STT='2222'"
            //                    }), sqlConnection);
            //                    sqlConnection.Open();
            //                    SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            //                    sqlConnection.Close();
            //                }
            //                else
            //                {
            //                    this.nhaphanghoa(this.hhnObj);
            //                }
            //                this.txtsl.Text = "0";
            //                this.txtgianhap.Text = "0";
            //            }
            //            if (this.txtgianhap.Text != "0")
            //            {
            //                SqlConnection sqlConnection = new SqlConnection();
            //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //                CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //                SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //                {
            //                    "UPDATE TB_CHITIETHOADON set GIAVON='",
            //                    double.Parse(this.txtgianhap.Text).ToString("", cultureInfo.NumberFormat),
            //                    "' where MAHANGHOA='",
            //                    this.txtMaHH.Text,
            //                    "' AND RIGHT(NGAYXUAT,10)='",
            //                    DateTime.Now.ToString("dd/MM/yyyy"),
            //                    "'"
            //                }), sqlConnection);
            //                sqlConnection.Open();
            //                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //                sqlConnection.Close();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Sửa không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }
            //        this.dis_en(false);
            //        DataTable dataTable = new DataTable();
            //        dataTable = this.hhCrt.GetData();
            //        this.dgvhanghoa.DataSource = dataTable;
            //        for (int i = 0; i < this.dgvhanghoa.Rows.Count; i++)
            //        {
            //            if (this.dgvhanghoa["mahanghoa1", i].Value.ToString() == this.txtMaHH.Text.ToUpper())
            //            {
            //                this.dgvhanghoa.ClearSelection();
            //                this.dgvhanghoa.Rows[i].Selected = true;
            //                this.dgvhanghoa.CurrentCell = this.dgvhanghoa.Rows[i].Cells["tenhang"];
            //                break;
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000A99 RID: 2713 RVA: 0x0001DA6C File Offset: 0x0001BC6C
        private void bthuy_Click(object sender, EventArgs e)
        {
            this.dis_en(false);
        }

        // Token: 0x06000A9A RID: 2714 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button1_Click(object sender, EventArgs e)
        {
            // base.Close();
        }

        // Token: 0x06000A9B RID: 2715 RVA: 0x001AE560 File Offset: 0x001AC760
        private void txtmanhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txttennhom.Text != "")
                {
                    this.txtMaHH.Focus();
                }
                else
                {
                    MessageBox.Show("KHÔNG TÌM THẤY TÊN NHÓM ", "THÔNG BÁO");
                }
            }
        }

        // Token: 0x06000A9C RID: 2716 RVA: 0x001AE5C0 File Offset: 0x001AC7C0
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            //    {
            //        if (this.txttimkiem.Text != "")
            //        {
            //            DataTable dataSource = new DataTable();
            //            dataSource = this.hhCrt.GetData_KD(this.txttimkiem.Text);
            //            this.dgvhanghoa.DataSource = dataSource;
            //            this.bingding();
            //        }
            //    }
            //    else
            //    {
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.hhCrt.GetData();
            //        this.dgvhanghoa.DataSource = dataSource;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A9D RID: 2717 RVA: 0x001AE684 File Offset: 0x001AC884
        private void btchon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (frmHangHoa.chon == "chon")
            //    {
            //        if (this.txtMaHH.Text == "")
            //        {
            //            int index = this.dgvhanghoa.CurrentRow.Index;
            //            string text = this.dgvhanghoa.Rows[index].Cells["MAHANGHOA1"].Value.ToString();
            //            string text2 = this.dgvhanghoa.Rows[index].Cells["tenhang"].Value.ToString();
            //            this.mahang(text, text2);
            //        }
            //        else
            //        {
            //            this.mahang(this.txtMaHH.Text, this.txtTenHH.Text);
            //        }
            //        base.Close();
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A9E RID: 2718 RVA: 0x001AE788 File Offset: 0x001AC988
        private void txtgia1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia1.Text + "' WHERE MA='MA1'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000A9F RID: 2719 RVA: 0x001AE7F8 File Offset: 0x001AC9F8
        private void txtgia2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia2.Text + "' WHERE MA='MA2'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000AA0 RID: 2720 RVA: 0x001AE868 File Offset: 0x001ACA68
        private void txtgia3_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia3.Text + "' WHERE MA='MA3'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000AA1 RID: 2721 RVA: 0x001AE8D8 File Offset: 0x001ACAD8
        private void txtgia4_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia4.Text + "' WHERE MA='MA4'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000AA2 RID: 2722 RVA: 0x001AE948 File Offset: 0x001ACB48
        private void txtgia5_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia5.Text + "' WHERE MA='MA5'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000AA3 RID: 2723 RVA: 0x001AE9B8 File Offset: 0x001ACBB8
        private void txtgia6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "UPDATE TB_GIA SET TEN=N'" + this.txtgia6.Text + "' WHERE MA='MA6'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000AA4 RID: 2724 RVA: 0x001AEA28 File Offset: 0x001ACC28
        private void txtgia1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.txtgia1, "Nhấn Enter để lưu lại");
        }

        // Token: 0x06000AA5 RID: 2725 RVA: 0x0001B637 File Offset: 0x00019837
        private void cbthemnhom_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000AA6 RID: 2726 RVA: 0x001AEA50 File Offset: 0x001ACC50
        private void txtDongia1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtsl1.Visible)
                {
                    this.txtsl1.Focus();
                }
                else
                {
                    this.txtdongia2.Focus();
                }
            }
        }

        // Token: 0x06000AA7 RID: 2727 RVA: 0x001AEA9C File Offset: 0x001ACC9C
        private void txtdongia2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtsl2.Visible)
                {
                    this.txtsl2.Focus();
                }
                else
                {
                    this.txtdongia3.Focus();
                }
            }
        }

        // Token: 0x06000AA8 RID: 2728 RVA: 0x001AEAE8 File Offset: 0x001ACCE8
        private void txtdongia3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtsl3.Visible)
                {
                    this.txtsl3.Focus();
                }
                else if (this.txtdongia4.Visible)
                {
                    this.txtdongia4.Focus();
                }
                else if (this.txtsl.Visible)
                {
                    this.txtsl.Focus();
                }
                else
                {
                    this.btLuu_Click(null, null);
                }
            }
        }

        // Token: 0x06000AA9 RID: 2729 RVA: 0x001AEB70 File Offset: 0x001ACD70
        private void txtdongia4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtsl4.Visible)
                {
                    this.txtsl4.Focus();
                }
                else
                {
                    this.txtdongia5.Focus();
                }
            }
        }

        // Token: 0x06000AAA RID: 2730 RVA: 0x001AEBBC File Offset: 0x001ACDBC
        private void txtdongia5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtsl5.Visible)
                {
                    this.txtsl5.Focus();
                }
                else
                {
                    this.txtdongia6.Focus();
                }
            }
        }

        // Token: 0x06000AAB RID: 2731 RVA: 0x001AEC08 File Offset: 0x001ACE08
        private void txtdongia6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.txtsl6.Visible)
            //    {
            //        this.txtsl6.Focus();
            //    }
            //    else if (this.txtchietkhau.Visible)
            //    {
            //        this.txtchietkhau.Focus();
            //    }
            //    else if (this.txttichdiem.Visible)
            //    {
            //        this.txttichdiem.Focus();
            //    }
            //    else if (TrangChu.bantonkho == "True")
            //    {
            //        this.txtsl.Focus();
            //    }
            //    else
            //    {
            //        this.btLuu_Click(null, null);
            //    }
            //}
        }

        // Token: 0x06000AAC RID: 2732 RVA: 0x001AECBC File Offset: 0x001ACEBC
        private void txtchietkhau_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.txttichdiem.Visible)
            //    {
            //        this.txttichdiem.Focus();
            //    }
            //    else if (TrangChu.bantonkho == "True")
            //    {
            //        this.txtsl.Focus();
            //    }
            //    else
            //    {
            //        this.btLuu_Click(null, null);
            //    }
            //}
        }

        // Token: 0x06000AAD RID: 2733 RVA: 0x001AED28 File Offset: 0x001ACF28
        private void txtMaHH_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    string text;
            //    if (TrangChu.codeEAN13 == "True")
            //    {
            //        text = this.richTextBox1.Text;
            //    }
            //    else
            //    {
            //        text = this.txtMaHH.Text;
            //    }
            //    if (!this.kiemtratontai(text))
            //    {
            //        MessageBox.Show("MÃ HÀNG ĐÃ TỒN TẠI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        this.txtMaHH.Focus();
            //    }
            //    else
            //    {
            //        this.txtTenHH.Focus();
            //    }
            //}
        }

        // Token: 0x06000AAE RID: 2734 RVA: 0x001AEDBC File Offset: 0x001ACFBC
        private void txtTenHH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtDVT.Focus();
            }
        }

        // Token: 0x06000AAF RID: 2735 RVA: 0x001AEDE8 File Offset: 0x001ACFE8
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        if (this.txttimkiem.Text != "" | this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            //        {
            //            this.dgvhanghoa.Focus();
            //        }
            //        else
            //        {
            //            DataTable dataSource = new DataTable();
            //            dataSource = this.hhCrt.GetData();
            //            this.dgvhanghoa.DataSource = dataSource;
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    try
            //    {
            //        if (this.txttimkiem.Text != "" | this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            //        {
            //            this.dgvhanghoa.Focus();
            //        }
            //        else
            //        {
            //            DataTable dataSource = new DataTable();
            //            dataSource = this.hhCrt.GetData();
            //            this.dgvhanghoa.DataSource = dataSource;
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000AB0 RID: 2736 RVA: 0x001AEF28 File Offset: 0x001AD128
        private void txtmanhom_TextChanged(object sender, EventArgs e)
        {
            if (this.txtmanhom.Text != "")
            {
                if (this.chonnhom == 0)
                {
                    this.tudonghanghoaMA();
                    this.chonnhom = 1;
                }
            }
        }

        // Token: 0x06000AB1 RID: 2737 RVA: 0x001AEF74 File Offset: 0x001AD174
        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            //if (this.txtMaHH.Text != "")
            //{
            //    this.txtmaphu.Text = this.txtMaHH.Text;
            //    if (TrangChu.codeEAN13 == "True" && !this.btThem.Enabled)
            //    {
            //        if (this.txtMaHH.Text.Length != 13)
            //        {
            //            string text = "";
            //            if (this.txtMaHH.Text.Length == 1)
            //            {
            //                text = "80000000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 2)
            //            {
            //                text = "8000000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 3)
            //            {
            //                text = "800000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 4)
            //            {
            //                text = "80000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 5)
            //            {
            //                text = "8000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 6)
            //            {
            //                text = "800000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 7)
            //            {
            //                text = "80000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 8)
            //            {
            //                text = "8000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 9)
            //            {
            //                text = "800" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 10)
            //            {
            //                text = "80" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 11)
            //            {
            //                text = "8" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 12)
            //            {
            //                text = this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length > 12)
            //            {
            //                text = this.txtMaHH.Text.Substring(0, 12);
            //            }
            //            string chaine = text;
            //            string text2 = EAN13Class.EAN13(chaine);
            //            if (!string.Equals(EAN13Class.Barcode13Digits, "") || EAN13Class.Barcode13Digits != "")
            //            {
            //                this.richTextBox1.Text = EAN13Class.Barcode13Digits.ToString();
            //            }
            //        }
            //        else
            //        {
            //            this.richTextBox1.Text = this.txtMaHH.Text;
            //        }
            //    }
            //}
        }

        // Token: 0x06000AB2 RID: 2738 RVA: 0x001AF308 File Offset: 0x001AD508
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
            this.txttimkiem.BackColor = Color.Yellow;
        }

        // Token: 0x06000AB3 RID: 2739 RVA: 0x001AF360 File Offset: 0x001AD560
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
            this.txttimkiem.BackColor = Color.White;
        }

        // Token: 0x06000AB4 RID: 2740 RVA: 0x0001DA77 File Offset: 0x0001BC77
        private void GETCHANHXE(string Makh, string tenkh)
        {
            this.txtmanhom.Text = Makh;
            this.txttennhom.Text = tenkh;
        }

        // Token: 0x06000AB5 RID: 2741 RVA: 0x001AF3B8 File Offset: 0x001AD5B8
        private void btnhom_Click(object sender, EventArgs e)
        {
            //frmHangHoa.chon_suanhom = 0;
            //this.chonnhom = 0;
            //new Frmnhomhang
            //{
            //    mahang = new Frmnhomhang.GetData(this.GETCHANHXE)
            //}.ShowDialog();
            //if (this.txtmanhom.Enabled)
            //{
            //    this.txtMaHH.Focus();
            //}
            //else if (!this.txtMaHH.Enabled)
            //{
            //    this.btThem_Click(null, null);
            //}
        }

        // Token: 0x06000AB6 RID: 2742 RVA: 0x001AF430 File Offset: 0x001AD630
        private void txttennhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtMaHH.Focus();
            }
        }

        // Token: 0x06000AB7 RID: 2743 RVA: 0x001AF45C File Offset: 0x001AD65C
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.textBox1.Text != this.textBox1.Tag.ToString())
            //    {
            //        if (this.textBox1.Text != "")
            //        {
            //            DataTable dataSource = new DataTable();
            //            dataSource = this.hhCrt.GetData_MA(this.textBox1.Text);
            //            this.dgvhanghoa.DataSource = dataSource;
            //            this.bingding();
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000AB8 RID: 2744 RVA: 0x001AF4FC File Offset: 0x001AD6FC
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == this.textBox1.Tag.ToString())
            {
                this.textBox1.Text = "";
            }
            this.textBox1.BackColor = Color.Yellow;
        }

        // Token: 0x06000AB9 RID: 2745 RVA: 0x001AF554 File Offset: 0x001AD754
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = this.textBox1.Tag.ToString();
            }
            this.textBox1.BackColor = Color.White;
        }

        // Token: 0x06000ABA RID: 2746 RVA: 0x001AF5AC File Offset: 0x001AD7AC
        private void txtDongia1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtDongia1.Text);
                if (num > 999.0)
                {
                    this.txtDongia1.Text = num.ToString("#,###");
                    this.txtDongia1.SelectionStart = this.txtDongia1.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000ABB RID: 2747 RVA: 0x001AF62C File Offset: 0x001AD82C
        private void txtdongia2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtdongia2.Text);
                if (num > 999.0)
                {
                    this.txtdongia2.Text = num.ToString("#,###");
                    this.txtdongia2.SelectionStart = this.txtdongia2.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000ABC RID: 2748 RVA: 0x001AF6AC File Offset: 0x001AD8AC
        private void txtDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtdonvilon.Visible)
                {
                    this.txtdonvilon.Focus();
                }
                else
                {
                    this.txtDongia1.Focus();
                }
            }
        }

        // Token: 0x06000ABD RID: 2749 RVA: 0x001AF6F8 File Offset: 0x001AD8F8
        private void txtdonvilon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtquydoi2.Focus();
            }
        }

        // Token: 0x06000ABE RID: 2750 RVA: 0x001AF724 File Offset: 0x001AD924
        private void txtquydoi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtDongia1.Focus();
            }
        }

        // Token: 0x06000ABF RID: 2751 RVA: 0x001AF750 File Offset: 0x001AD950
        private void txtdongia3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtdongia3.Text);
                if (num > 999.0)
                {
                    this.txtdongia3.Text = num.ToString("#,###");
                    this.txtdongia3.SelectionStart = this.txtdongia3.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000AC0 RID: 2752 RVA: 0x001AF7D0 File Offset: 0x001AD9D0
        private void txtquydoi1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtdongia4.Text);
                if (num > 999.0)
                {
                    this.txtdongia4.Text = num.ToString("#,###");
                    this.txtdongia4.SelectionStart = this.txtdongia4.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000AC1 RID: 2753 RVA: 0x001AF850 File Offset: 0x001ADA50
        private void txtdongia5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtdongia5.Text);
                if (num > 999.0)
                {
                    this.txtdongia5.Text = num.ToString("#,###");
                    this.txtdongia5.SelectionStart = this.txtdongia5.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000AC2 RID: 2754 RVA: 0x001AF8D0 File Offset: 0x001ADAD0
        private void txtdongia6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtdongia6.Text);
                if (num > 999.0)
                {
                    this.txtdongia6.Text = num.ToString("#,###");
                    this.txtdongia6.SelectionStart = this.txtdongia6.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000AC3 RID: 2755 RVA: 0x001AF950 File Offset: 0x001ADB50
        private void txtDongia1_Leave(object sender, EventArgs e)
        {
            if (this.txtDongia1.Text == "")
            {
                this.txtDongia1.Text = "0";
            }
            this.txtDongia1.BackColor = Color.White;
        }

        // Token: 0x06000AC4 RID: 2756 RVA: 0x001AF99C File Offset: 0x001ADB9C
        private void txtdongia2_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia2.Text == "")
            {
                this.txtdongia2.Text = "0";
            }
            this.txtdongia2.BackColor = Color.White;
        }

        // Token: 0x06000AC5 RID: 2757 RVA: 0x001AF9E8 File Offset: 0x001ADBE8
        private void txtdongia3_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia3.Text == "")
            {
                this.txtdongia3.Text = "0";
            }
            this.txtdongia3.BackColor = Color.White;
        }

        // Token: 0x06000AC6 RID: 2758 RVA: 0x001AFA34 File Offset: 0x001ADC34
        private void txtquydoi1_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia4.Text == "")
            {
                this.txtdongia4.Text = "0";
            }
            this.txtdongia4.BackColor = Color.White;
        }

        // Token: 0x06000AC7 RID: 2759 RVA: 0x001AFA80 File Offset: 0x001ADC80
        private void txtdongia5_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia5.Text == "")
            {
                this.txtdongia5.Text = "0";
            }
            this.txtdongia5.BackColor = Color.White;
        }

        // Token: 0x06000AC8 RID: 2760 RVA: 0x001AFACC File Offset: 0x001ADCCC
        private void txtdongia6_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia6.Text == "")
            {
                this.txtdongia6.Text = "0";
            }
            this.txtdongia6.BackColor = Color.White;
        }

        // Token: 0x06000AC9 RID: 2761 RVA: 0x001AFB18 File Offset: 0x001ADD18
        private void txtchietkhau_Leave(object sender, EventArgs e)
        {
            if (this.txtchietkhau.Text == "")
            {
                this.txtchietkhau.Text = "0";
            }
            this.txtchietkhau.BackColor = Color.White;
        }

        // Token: 0x06000ACA RID: 2762 RVA: 0x001AFB64 File Offset: 0x001ADD64
        private void txtquydoi2_Leave(object sender, EventArgs e)
        {
            if (this.txtquydoi2.Text == "")
            {
                this.txtquydoi2.Text = "1";
            }
            if (this.txtquydoi2.Text == "0")
            {
                this.txtquydoi2.Text = "1";
            }
            this.txtquydoi2.BackColor = Color.White;
        }

        // Token: 0x06000ACB RID: 2763 RVA: 0x001AFBE0 File Offset: 0x001ADDE0
        private void txtDVT_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDVT.Text != "")
            {
                this.ldv1.Text = this.txtDVT.Text;
            }
            else
            {
                this.ldv1.Text = "ĐVT (1)";
                this.txtdonvilon.Text = "";
            }
        }

        // Token: 0x06000ACC RID: 2764 RVA: 0x001AFC4C File Offset: 0x001ADE4C
        private void txtdonvilon_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdonvilon.Text != "")
            {
                this.ldv2.Text = this.txtdonvilon.Text;
            }
            else
            {
                this.ldv2.Text = "ĐVT (2)";
            }
        }

        // Token: 0x06000ACD RID: 2765 RVA: 0x001AFCA4 File Offset: 0x001ADEA4
        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    if (sqlConnection.State == ConnectionState.Closed)
            //    {
            //        sqlConnection.Open();
            //    }
            //    string cmdText = "      DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,HN.LOAI,ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),'0'  FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND STT='2222' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI,HN.NCC ) UPDATE TB_HANGHOA  SET DONVITINHLON3 = (SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA)";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand.Dispose();
            //    sqlConnection.Close();
            //    string cmdText2;
            //    if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            //    {
            //        cmdText2 = string.Concat(new string[]
            //        {
            //            "SELECT MANHOM,MAHANGHOA,TENHANGHOA,DONVITINH,DONVITINHLON,DONGIA,DONGIA2,DONGIA3,DONGIA4,DONGIA5,DONGIA6,VAT,GHICHU,CHIETKHAU,QUYDOI1,DIEM,TENHANGHOA_KHONGDAU,SL1,SL2,SL3,SL4,SL5,SL6,SL_CANHBAO,SLBAN,SLTANG,MAHANG,CASE WHEN TONDONVI='TRUE' THEN ISNULL(DONVITINHLON3,0) ELSE ISNULL(DONVITINHLON3,0)/QUYDOI1 END AS SLTON,GIANHAP,TONDONVI  from TB_HANGHOA WHERE TENHANGHOA LIKE N'%",
            //            this.txttimkiem.Text,
            //            "%' OR TENHANGHOA_KHONGDAU LIKE N'%",
            //            this.txttimkiem.Text,
            //            "%'"
            //        });
            //    }
            //    else if (this.cobnhom.Text != "")
            //    {
            //        cmdText2 = "SELECT MANHOM,MAHANGHOA,TENHANGHOA,DONVITINH,DONVITINHLON,DONGIA,DONGIA2,DONGIA3,DONGIA4,DONGIA5,DONGIA6,VAT,GHICHU,CHIETKHAU,QUYDOI1,DIEM,TENHANGHOA_KHONGDAU,SL1,SL2,SL3,SL4,SL5,SL6,SL_CANHBAO,SLBAN,SLTANG,MAHANG,CASE WHEN TONDONVI='TRUE' THEN ISNULL(DONVITINHLON3,0) ELSE ISNULL(DONVITINHLON3,0)/QUYDOI1 END AS SLTON,GIANHAP,TONDONVI  from TB_HANGHOA WHERE MANHOM=N'" + this.cobnhom.SelectedValue.ToString() + "'";
            //    }
            //    else
            //    {
            //        cmdText2 = "SELECT MANHOM,MAHANGHOA,TENHANGHOA,DONVITINH,DONVITINHLON,DONGIA,DONGIA2,DONGIA3,DONGIA4,DONGIA5,DONGIA6,VAT,GHICHU,CHIETKHAU,QUYDOI1,DIEM,TENHANGHOA_KHONGDAU,SL1,SL2,SL3,SL4,SL5,SL6,SL_CANHBAO,SLBAN,SLTANG,MAHANG,CASE WHEN TONDONVI='TRUE' THEN ISNULL(DONVITINHLON3,0) ELSE ISNULL(DONVITINHLON3,0)/QUYDOI1 END AS SLTON,GIANHAP,TONDONVI  from TB_HANGHOA ";
            //    }
            //    if (sqlConnection.State == ConnectionState.Closed)
            //    {
            //        sqlConnection.Open();
            //    }
            //    DataTable dataTable = new DataTable();
            //    sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //        Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\HH.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //        if (frmHangHoa.< button2_Click > o__SiteContainer0.<> p__Site1 == null)
            //        {
            //            frmHangHoa.< button2_Click > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(frmHangHoa)));
            //        }
            //        Worksheet worksheet = frmHangHoa.< button2_Click > o__SiteContainer0.<> p__Site1.Target(frmHangHoa.< button2_Click > o__SiteContainer0.<> p__Site1, application.ActiveSheet);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < dataTable.Columns.Count; j++)
            //            {
            //                worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
            //            }
            //        }
            //        application.Visible = true;
            //    }
            //    else
            //    {
            //        new Process
            //        {
            //            StartInfo =
            //            {
            //                FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\HH.xlsx"
            //            }
            //        }.Start();
            //    }
            //    sqlConnection.Dispose();
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    new Process
            //    {
            //        StartInfo =
            //        {
            //            FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\HH.xlsx"
            //        }
            //    }.Start();
            //}
            this.button2.Enabled = true;
        }

        // Token: 0x06000ACE RID: 2766 RVA: 0x001B0028 File Offset: 0x001AE228
        private void NHAPEXCEL()
        {
            //this.openFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx|Excel File(2003)|*.xls";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //if (File.Exists(this.openFileDialog1.FileName))
            //{
            //    string[] array = this.openFileDialog1.FileName.Split(new char[]
            //    {
            //        '.'
            //    });
            //    string connectionString = string.Empty;
            //    if (this.openFileDialog1.FileName.Length > 1 && array[1] == "xls")
            //    {
            //        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.openFileDialog1.FileName + ";Extended Properties = Excel 8.0";
            //    }
            //    else
            //    {
            //        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.openFileDialog1.FileName + ";Extended Properties = Excel 12.0";
            //    }
            //    OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            //    oleDbConnection.Open();
            //    try
            //    {
            //        this.mahoadontieptheo();
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        DataTable dataTable = new DataTable();
            //        oleDbDataAdapter.Fill(dataTable);
            //        string selectCommandText = "select isnull(MAX(mahanghoa),'0') from Tb_HANGHOA where len(mahanghoa)='5' group by MAHANGHOA having ISNUMERIC(mahanghoa)=1 order by MAHANGHOA desc";
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //        {
            //            ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //        });
            //        DataTable dataTable2 = new DataTable();
            //        sqlDataAdapter.Fill(dataTable2);
            //        double num = 0.0;
            //        if (dataTable2.Rows.Count > 0)
            //        {
            //            num = Convert.ToDouble(dataTable2.Rows[0][0].ToString());
            //        }
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            this.hhObj.TenHangHoa = dataTable.Rows[i]["TENHANG"].ToString().Replace("'", "");
            //            if (this.hhObj.TenHangHoa != "")
            //            {
            //                this.hhObj.MaHH = dataTable.Rows[i]["MAHANG"].ToString().Replace("'", "");
            //                if (this.hhObj.MaHH == "")
            //                {
            //                    string text = "";
            //                    num += 1.0;
            //                    if (num < 10.0)
            //                    {
            //                        text += "0000";
            //                    }
            //                    else if (num < 100.0)
            //                    {
            //                        text += "000";
            //                    }
            //                    else if (num < 1000.0)
            //                    {
            //                        text += "00";
            //                    }
            //                    else if (num < 10000.0)
            //                    {
            //                        text += "0";
            //                    }
            //                    text += num.ToString();
            //                    this.hhObj.MaHH = text;
            //                }
            //                try
            //                {
            //                    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //                    this.hhObj.Donvitinh = dataTable.Rows[i]["DONVITINHLON"].ToString().Replace("'", "");
            //                    string s = "0";
            //                    if (dataTable.Rows[i]["DONGIA"].ToString() != "")
            //                    {
            //                        s = dataTable.Rows[i]["DONGIA"].ToString();
            //                    }
            //                    this.hhObj.Dongia1 = decimal.Parse(decimal.Parse(s).ToString("", cultureInfo.NumberFormat));
            //                    string s2 = "0";
            //                    if (dataTable.Rows[i]["DONGIA2"].ToString() != "")
            //                    {
            //                        s2 = dataTable.Rows[i]["DONGIA2"].ToString();
            //                    }
            //                    string s3 = "0";
            //                    if (dataTable.Rows[i]["DONGIA3"].ToString() != "")
            //                    {
            //                        s3 = dataTable.Rows[i]["DONGIA3"].ToString();
            //                    }
            //                    string s4 = "0";
            //                    if (dataTable.Rows[i]["DONGIA4"].ToString() != "")
            //                    {
            //                        s4 = dataTable.Rows[i]["DONGIA4"].ToString();
            //                    }
            //                    string s5 = "0";
            //                    if (dataTable.Rows[i]["DONGIA5"].ToString() != "")
            //                    {
            //                        s5 = dataTable.Rows[i]["DONGIA5"].ToString();
            //                    }
            //                    string s6 = "0";
            //                    if (dataTable.Rows[i]["DONGIA6"].ToString() != "")
            //                    {
            //                        s6 = dataTable.Rows[i]["DONGIA6"].ToString();
            //                    }
            //                    string s7 = "0";
            //                    if (dataTable.Rows[i]["CHIETKHAU"].ToString() != "")
            //                    {
            //                        s7 = dataTable.Rows[i]["CHIETKHAU"].ToString();
            //                    }
            //                    this.hhObj.Dongia2 = decimal.Parse(decimal.Parse(s2).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Dongia3 = decimal.Parse(decimal.Parse(s3).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Dongia4 = decimal.Parse(decimal.Parse(s4).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Dongia5 = decimal.Parse(decimal.Parse(s5).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Dongia6 = decimal.Parse(decimal.Parse(s6).ToString("", cultureInfo.NumberFormat));
            //                    string s8 = "0";
            //                    if (dataTable.Rows[i]["VAT"].ToString() != "")
            //                    {
            //                        s8 = dataTable.Rows[i]["VAT"].ToString();
            //                    }
            //                    this.hhObj.Soluong = decimal.Parse(decimal.Parse(s8).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Ghichu = dataTable.Rows[i]["GHICHU"].ToString().Replace("'", "");
            //                    this.hhObj.Chietkhau = decimal.Parse(decimal.Parse(s7).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Manhom = dataTable.Rows[i]["MANHOM"].ToString();
            //                    if (this.hhObj.Manhom == "")
            //                    {
            //                        this.hhObj.Manhom = "HH";
            //                    }
            //                    this.hhObj.Quydoi = "1";
            //                    this.hhObj.Ncc = "CTY";
            //                    if (dataTable.Rows[i]["DONVITINHLE"].ToString() == "")
            //                    {
            //                        this.hhObj.Donvitinhlon = dataTable.Rows[i]["DONVITINHLON"].ToString().Replace("'", "");
            //                    }
            //                    else
            //                    {
            //                        this.hhObj.Donvitinhlon = dataTable.Rows[i]["DONVITINHLE"].ToString().Replace("'", "");
            //                    }
            //                    string text2 = "1";
            //                    if (dataTable.Rows[i]["QUYDOI1"].ToString() != "")
            //                    {
            //                        text2 = dataTable.Rows[i]["QUYDOI1"].ToString();
            //                    }
            //                    if (text2 == "0")
            //                    {
            //                        text2 = "1";
            //                    }
            //                    this.hhObj.Quydoi1 = decimal.Parse(text2).ToString("", cultureInfo.NumberFormat);
            //                    string s9 = "0";
            //                    if (dataTable.Rows[i]["DIEM"].ToString() != "")
            //                    {
            //                        s9 = dataTable.Rows[i]["DIEM"].ToString();
            //                    }
            //                    this.hhObj.Diem = decimal.Parse(s9).ToString("", cultureInfo.NumberFormat);
            //                    if (dataTable.Rows[i]["TENHANG_KHONGDAU"].ToString().Trim() != "")
            //                    {
            //                        this.hhObj.Tenhang_khongdau = dataTable.Rows[i]["TENHANG_KHONGDAU"].ToString().Replace("'", "");
            //                    }
            //                    else
            //                    {
            //                        this.hhObj.Tenhang_khongdau = this.NonUnicode(dataTable.Rows[i]["TENHANG"].ToString()).Replace("'", "");
            //                    }
            //                    string s10 = "0";
            //                    if (dataTable.Rows[i]["SL1"].ToString() != "")
            //                    {
            //                        s10 = dataTable.Rows[i]["SL1"].ToString();
            //                    }
            //                    string s11 = "0";
            //                    if (dataTable.Rows[i]["SL2"].ToString() != "")
            //                    {
            //                        s11 = dataTable.Rows[i]["SL2"].ToString();
            //                    }
            //                    string s12 = "0";
            //                    if (dataTable.Rows[i]["SL3"].ToString() != "")
            //                    {
            //                        s12 = dataTable.Rows[i]["SL3"].ToString();
            //                    }
            //                    string s13 = "0";
            //                    if (dataTable.Rows[i]["SL4"].ToString() != "")
            //                    {
            //                        s13 = dataTable.Rows[i]["SL4"].ToString();
            //                    }
            //                    string s14 = "0";
            //                    if (dataTable.Rows[i]["SL5"].ToString() != "")
            //                    {
            //                        s14 = dataTable.Rows[i]["SL5"].ToString();
            //                    }
            //                    string s15 = "0";
            //                    if (dataTable.Rows[i]["SL6"].ToString() != "")
            //                    {
            //                        s15 = dataTable.Rows[i]["SL6"].ToString();
            //                    }
            //                    this.hhObj.Sl1 = float.Parse(float.Parse(s10).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Sl2 = float.Parse(float.Parse(s11).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Sl3 = float.Parse(float.Parse(s12).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Sl4 = float.Parse(float.Parse(s13).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Sl5 = float.Parse(float.Parse(s14).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Sl6 = float.Parse(float.Parse(s15).ToString("", cultureInfo.NumberFormat));
            //                    string s16 = "0";
            //                    if (dataTable.Rows[i]["SL_CANHBAO"].ToString() != "")
            //                    {
            //                        s16 = dataTable.Rows[i]["SL_CANHBAO"].ToString();
            //                    }
            //                    this.hhObj.Sl_canhbao = float.Parse(float.Parse(s16).ToString("", cultureInfo.NumberFormat));
            //                    string s17 = "0";
            //                    if (dataTable.Rows[i]["SLBAN"].ToString() != "")
            //                    {
            //                        s17 = dataTable.Rows[i]["SLBAN"].ToString();
            //                    }
            //                    this.hhObj.Slban = float.Parse(float.Parse(s17).ToString("", cultureInfo.NumberFormat));
            //                    string s18 = "0";
            //                    if (dataTable.Rows[i]["SLTANG"].ToString() != "")
            //                    {
            //                        s18 = dataTable.Rows[i]["SLTANG"].ToString();
            //                    }
            //                    this.hhObj.Sltang = float.Parse(float.Parse(s18).ToString("", cultureInfo.NumberFormat));
            //                    this.hhObj.Mahangtang = dataTable.Rows[i]["MAHANGTANG"].ToString();
            //                    string s19 = "0";
            //                    if (dataTable.Rows[i]["GIAVON"].ToString() != "")
            //                    {
            //                        s19 = dataTable.Rows[i]["GIAVON"].ToString();
            //                    }
            //                    this.hhObj.Giavon = float.Parse(float.Parse(s19).ToString("", cultureInfo.NumberFormat));
            //                    string s20 = "0";
            //                    if (dataTable.Rows[i]["SOLUONGTON"].ToString() != "")
            //                    {
            //                        s20 = dataTable.Rows[i]["SOLUONGTON"].ToString();
            //                    }
            //                    this.hhObj.Donvitinhlon3 = float.Parse(s20).ToString("", cultureInfo.NumberFormat);
            //                    string text3 = "";
            //                    string[] array2 = this.hhObj.Tenhang_khongdau.Trim().Split(new char[]
            //                    {
            //                        ' '
            //                    });
            //                    foreach (string text4 in array2)
            //                    {
            //                        if (text4.ToString().Length > 1)
            //                        {
            //                            text3 += text4.ToString().Substring(0, 1);
            //                        }
            //                    }
            //                    this.hhObj.Kytudau = text3;
            //                    this.hhObj.Tondonvi = "FALSE";
            //                    if (dataTable.Rows[i]["TON_DONVILE"].ToString() != "")
            //                    {
            //                        this.hhObj.Tondonvi = dataTable.Rows[i]["TON_DONVILE"].ToString();
            //                    }
            //                    if (this.kiemtratontai(this.hhObj.MaHH))
            //                    {
            //                        if (this.hhCrt.AddData(this.hhObj))
            //                        {
            //                            if (float.Parse(s20) > 0f)
            //                            {
            //                                try
            //                                {
            //                                    this.hhnObj.Stt = 2222;
            //                                    this.hhnObj.Mahoadon = this.manhapkho;
            //                                    this.hhnObj.Mahanghoa = dataTable.Rows[i]["MAHANG"].ToString();
            //                                    this.hhnObj.Soluong2 = "0";
            //                                    this.hhnObj.Soluong3 = "0";
            //                                    this.hhnObj.Soluong4 = "0";
            //                                    this.hhnObj.Soluong5 = "0";
            //                                    this.hhnObj.Soluong6 = "0";
            //                                    this.hhnObj.Soluong = float.Parse(s20).ToString();
            //                                    this.hhnObj.Dongia = float.Parse(s19).ToString();
            //                                    this.hhnObj.Ngaynhap = DateTime.Now.ToString("dd/MM/yyyy");
            //                                    this.hhnObj.Ghichu = "";
            //                                    this.hhnObj.Soluongquydoi = float.Parse(s20).ToString();
            //                                    this.hhnObj.Vat = "0";
            //                                    this.hhnObj.Loai = this.makho;
            //                                    this.hhnObj.Maloai = "0";
            //                                    this.hhnObj.Ncc = "CTY";
            //                                    this.hhnObj.Giavon2 = "0";
            //                                    this.xhdCtr.ADD_HANGHOANHAP(this.hhnObj);
            //                                }
            //                                catch
            //                                {
            //                                }
            //                            }
            //                        }
            //                    }
            //                    else if (this.hhCrt.UpdData(this.hhObj))
            //                    {
            //                        if (float.Parse(s20) > 0f)
            //                        {
            //                            try
            //                            {
            //                                this.hhnObj.Stt = 2222;
            //                                this.hhnObj.Mahoadon = this.manhapkho;
            //                                this.hhnObj.Mahanghoa = dataTable.Rows[i]["MAHANG"].ToString();
            //                                this.hhnObj.Soluong2 = "0";
            //                                this.hhnObj.Soluong3 = "0";
            //                                this.hhnObj.Soluong4 = "0";
            //                                this.hhnObj.Soluong5 = "0";
            //                                this.hhnObj.Soluong6 = "0";
            //                                this.hhnObj.Soluong = float.Parse(s20).ToString();
            //                                this.hhnObj.Dongia = float.Parse(s19).ToString();
            //                                this.hhnObj.Ngaynhap = DateTime.Now.ToString("dd/MM/yyyy");
            //                                this.hhnObj.Ghichu = "";
            //                                this.hhnObj.Soluongquydoi = float.Parse(s20).ToString();
            //                                this.hhnObj.Vat = "0";
            //                                this.hhnObj.Loai = this.makho;
            //                                this.hhnObj.Maloai = "0";
            //                                this.hhnObj.Ncc = "CTY";
            //                                this.hhnObj.Giavon2 = "0";
            //                                this.xhdCtr.ADD_HANGHOANHAP(this.hhnObj);
            //                            }
            //                            catch
            //                            {
            //                            }
            //                        }
            //                    }
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show(ex.Message.ToString());
            //                }
            //            }
            //        }
            //        MessageBox.Show("NHẬP THÀNH CÔNG");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("KHÔNG NHẬP ĐƯỢC DỮ LIỆU");
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            //    finally
            //    {
            //        oleDbConnection.Close();
            //    }
            //}
        }

        // Token: 0x06000ACF RID: 2767 RVA: 0x001B1660 File Offset: 0x001AF860
        private void btnhapexcel_Click(object sender, EventArgs e)
        {
            //this.btnhapexcel.Enabled = false;
            //this.NHAPEXCEL();
            //this.btnhapexcel.SendToBack();
            //DataTable dataSource = new DataTable();
            //dataSource = this.hhCrt.GetData();
            //this.dgvhanghoa.DataSource = dataSource;
            //this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
            //this.btnhapexcel.Enabled = true;
        }

        // Token: 0x06000AD0 RID: 2768 RVA: 0x001B16DC File Offset: 0x001AF8DC
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.textBox1.Text == "")
            //    {
            //        this.txttimkiem.Focus();
            //    }
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.hhCrt.GetData();
            //    this.dgvhanghoa.DataSource = dataSource;
            //}
        }

        // Token: 0x06000AD1 RID: 2769 RVA: 0x001B1744 File Offset: 0x001AF944
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.textBox1, "NHẤN PHÍM ENTER ĐỂ TÌM THEO TÊN HÀNG");
        }

        // Token: 0x06000AD2 RID: 2770 RVA: 0x001B176C File Offset: 0x001AF96C
        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        this.bingding();
            //        if (this.txtMaHH.Text != "")
            //        {
            //            try
            //            {
            //                string selectCommandText = "select HINH FROM TB_HINHHANGHOA WHERE MAHANG ='" + this.txtMaHH.Text + "'";
            //                SqlConnection sqlConnection = new SqlConnection();
            //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //                sqlConnection.Open();
            //                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
            //                DataTable dataTable = new DataTable();
            //                sqlDataAdapter.Fill(dataTable);
            //                if (dataTable.Rows.Count > 0)
            //                {
            //                    byte[] buffer = new byte[0];
            //                    buffer = (byte[])dataTable.Rows[0][0];
            //                    MemoryStream stream = new MemoryStream(buffer);
            //                    this.ptlogo.Image = Image.FromStream(stream);
            //                }
            //                else
            //                {
            //                    this.ptlogo.Image = null;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                string message = ex.Message;
            //            }
            //        }
            //        int columnIndex = this.dgvhanghoa.CurrentCell.ColumnIndex;
            //        if (this.dgvhanghoa.Columns[columnIndex].Name == "xoa")
            //        {
            //            this.btXoa_Click(null, null);
            //        }
            //        else if (this.checkBox2.Checked)
            //        {
            //            if (this.dgvhanghoa.Columns[columnIndex].Name == "mahanghoa1" || this.dgvhanghoa.Columns[columnIndex].Name == "Nhom" || this.dgvhanghoa.Columns[columnIndex].Name == "slban" || this.dgvhanghoa.Columns[columnIndex].Name == "Sltang" || this.dgvhanghoa.Columns[columnIndex].Name == "matang")
            //            {
            //                this.dgvhanghoa.ReadOnly = true;
            //            }
            //            else
            //            {
            //                this.dgvhanghoa.ReadOnly = false;
            //            }
            //        }
            //        this.txtSoluong.Text = this.dgvhanghoa.CurrentRow.Cells["vat"].Value.ToString();
            //        if (this.txtSoluong.Text == "0")
            //        {
            //            this.checkBox1.Checked = false;
            //        }
            //        else
            //        {
            //            this.checkBox1.Checked = true;
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000AD3 RID: 2771 RVA: 0x001B1A70 File Offset: 0x001AFC70
        private void dgvhanghoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (frmHangHoa.chon == "chon")
                {
                    if (this.txtMaHH.Text == "")
                    {
                        int index = this.dgvhanghoa.CurrentRow.Index;
                        string text = this.dgvhanghoa.Rows[index].Cells["MAHANGHOA1"].Value.ToString();
                        string text2 = this.dgvhanghoa.Rows[index].Cells["tenhang"].Value.ToString();
                        this.mahang(text, text2);
                    }
                    else
                    {
                        this.mahang(this.txtMaHH.Text, this.txtTenHH.Text);
                    }
                    // base.Close();
                }
                else
                {
                    this.bingding();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000AD4 RID: 2772 RVA: 0x001B1B7C File Offset: 0x001AFD7C
        private void cobnhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cobnhom.DataSource != null)
            {
                if (this.cobnhom.Text != "System.Data.DataRowView")
                {
                    if (this.cobnhom.Text != "")
                    {
                        DataTable dataSource = new DataTable();
                        // dataSource = this.hhCrt.GetData_MANHOM(this.cobnhom.SelectedValue.ToString());
                        // this.dgvhanghoa.DataSource = dataSource;
                        this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
                    }
                }
            }
        }

        // Token: 0x06000AD5 RID: 2773 RVA: 0x001B1C2C File Offset: 0x001AFE2C
        private void frmHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.bthuy_Click(null, null);
                this.flag = 1;
            }
            else if (e.KeyCode == Keys.F1)
            {
                this.btLuu_Click(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                //if (TrangChu.bantonkho == "True")
                //{
                //    SqlConnection sqlConnection = new SqlConnection();
                //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                //    sqlConnection.Open();
                //    string cmdText = string.Concat(new string[]
                //    {
                //        "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1 \r\n                             FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0) ELSE '0' END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
                //        TrangChu.doicm,
                //        " ELSE '0' END END AS SOLUONGTONG,case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
                //        TrangChu.tile,
                //        ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
                //        TrangChu.doicm,
                //        "*HH.QUYDOI1 END   END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_TONGHANGHOANHAP HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHANGHOA=HHX.MAHANGHOA group by hhn.mahanghoa,isnull(hhn.soluongTONG,0)) UPDATE TB_HANGHOA  SET DONVITINHLON3 = (SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA)"
                //    });
                //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //    sqlCommand.ExecuteNonQuery();
                //    sqlConnection.Close();
                //}
                //DataTable dataTable = new DataTable();
                //dataTable = this.hhCrt.GetData();
                //this.dgvhanghoa.DataSource = dataTable;
                //this.txtsodong.Text = dataTable.Rows.Count.ToString();
                //for (int i = 0; i < this.dgvhanghoa.Rows.Count; i++)
                //{
                //    if (this.dgvhanghoa["mahanghoa1", i].Value.ToString() == this.txtMaHH.Text.ToUpper())
                //    {
                //        this.dgvhanghoa.ClearSelection();
                //        this.dgvhanghoa.Rows[i].Selected = true;
                //        this.dgvhanghoa.CurrentCell = this.dgvhanghoa.Rows[i].Cells["tenhang"];
                //        break;
                //    }
                //}
            }
        }

        // Token: 0x06000AD6 RID: 2774 RVA: 0x001B1E40 File Offset: 0x001B0040
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.txtTenHH.Text == "")
            {
                this.bingding();
            }
            this.flag = 2;
            this.dis_en(true);
            this.dgvhanghoa.Enabled = true;
            if (this.cbmahangtudong.Checked)
            {
                this.txtTenHH.Focus();
                this.mahanghoa();
                this.txtTenHH.SelectionStart = this.txtTenHH.TextLength;
            }
            else
            {
                this.txtMaHH.Focus();
                this.txtMaHH.SelectionStart = this.txtMaHH.TextLength;
            }
        }

        // Token: 0x06000AD7 RID: 2775 RVA: 0x001B1EF4 File Offset: 0x001B00F4
        private void textBox2_Enter(object sender, EventArgs e)
        {
            try
            {
                this.cobnhom.Focus();
                this.cobnhom.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        // Token: 0x06000AD8 RID: 2776 RVA: 0x0001DA94 File Offset: 0x0001BC94
        private void txtMaHH_Enter(object sender, EventArgs e)
        {
            this.txtMaHH.BackColor = Color.Yellow;
        }

        // Token: 0x06000AD9 RID: 2777 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
        private void txtMaHH_Leave(object sender, EventArgs e)
        {
            this.txtMaHH.BackColor = Color.White;
        }

        // Token: 0x06000ADA RID: 2778 RVA: 0x0001DABC File Offset: 0x0001BCBC
        private void txtTenHH_Leave(object sender, EventArgs e)
        {
            this.txtTenHH.BackColor = Color.White;
        }

        // Token: 0x06000ADB RID: 2779 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
        private void txtTenHH_Enter(object sender, EventArgs e)
        {
            //  this.txtTenHH.BackColor = Color.Yellow;
        }

        // Token: 0x06000ADC RID: 2780 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
        private void txtDVT_Enter(object sender, EventArgs e)
        {
            // this.txtDVT.BackColor = Color.Yellow;
        }

        // Token: 0x06000ADD RID: 2781 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
        private void txtDVT_Leave(object sender, EventArgs e)
        {
            // this.txtDVT.BackColor = Color.White;
        }

        // Token: 0x06000ADE RID: 2782 RVA: 0x0001DB0C File Offset: 0x0001BD0C
        private void txtdonvilon_Enter(object sender, EventArgs e)
        {
            //this.txtdonvilon.BackColor = Color.Yellow;
        }

        // Token: 0x06000ADF RID: 2783 RVA: 0x0001DB20 File Offset: 0x0001BD20
        private void txtdonvilon_Leave(object sender, EventArgs e)
        {
            // this.txtdonvilon.BackColor = Color.White;
        }

        // Token: 0x06000AE0 RID: 2784 RVA: 0x0001DB34 File Offset: 0x0001BD34
        private void txtGhichu_Leave(object sender, EventArgs e)
        {// this.txtGhichu.BackColor = Color.White;
        }

        // Token: 0x06000AE1 RID: 2785 RVA: 0x0001DB48 File Offset: 0x0001BD48
        private void txtGhichu_Enter(object sender, EventArgs e)
        {
            // this.txtGhichu.BackColor = Color.Yellow;
        }

        // Token: 0x06000AE2 RID: 2786 RVA: 0x001B1F38 File Offset: 0x001B0138
        private void txtDongia1_Enter(object sender, EventArgs e)
        {
            //this.txtDongia1.BackColor = Color.Yellow;
            //if (this.txtDongia1.Text == "0")
            //{
            //    this.txtDongia1.Text = "";
            //}
        }

        // Token: 0x06000AE3 RID: 2787 RVA: 0x001B1F84 File Offset: 0x001B0184
        private void txtdongia2_Enter(object sender, EventArgs e)
        {
            //this.txtdongia2.BackColor = Color.Yellow;
            //if (this.txtdongia2.Text == "0")
            //{
            //    this.txtdongia2.Text = "";
            //}
        }

        // Token: 0x06000AE4 RID: 2788 RVA: 0x001B1FD0 File Offset: 0x001B01D0
        private void txtdongia3_Enter(object sender, EventArgs e)
        {
            //this.txtdongia3.BackColor = Color.Yellow;
            //if (this.txtdongia3.Text == "0")
            //{
            //    this.txtdongia3.Text = "";
            //}
        }

        // Token: 0x06000AE5 RID: 2789 RVA: 0x001B201C File Offset: 0x001B021C
        private void txtquydoi1_Enter(object sender, EventArgs e)
        {
            //this.txtdongia4.BackColor = Color.Yellow;
            //if (this.txtdongia4.Text == "0")
            //{
            //    this.txtdongia4.Text = "";
            //}
        }

        // Token: 0x06000AE6 RID: 2790 RVA: 0x001B2068 File Offset: 0x001B0268
        private void txtdongia5_Enter(object sender, EventArgs e)
        {
            //this.txtdongia5.BackColor = Color.Yellow;
            //if (this.txtdongia5.Text == "0")
            //{
            //    this.txtdongia5.Text = "";
            //}
        }

        // Token: 0x06000AE7 RID: 2791 RVA: 0x001B20B4 File Offset: 0x001B02B4
        private void txtdongia6_Enter(object sender, EventArgs e)
        {
            //this.txtdongia6.BackColor = Color.Yellow;
            //if (this.txtdongia6.Text == "0")
            //{
            //    this.txtdongia6.Text = "";
            //}
        }

        // Token: 0x06000AE8 RID: 2792 RVA: 0x0001DB5C File Offset: 0x0001BD5C
        private void txtquydoi2_Enter(object sender, EventArgs e)
        {
            //this.txtquydoi2.BackColor = Color.Yellow;
        }

        // Token: 0x06000AE9 RID: 2793 RVA: 0x001B2100 File Offset: 0x001B0300
        private void dgvhanghoa_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        if (frmHangHoa.chon == "chon")
            //        {
            //            this.bingding();
            //            this.mahang(this.txtMaHH.Text, this.txtTenHH.Text);
            //            base.Close();
            //        }
            //        else
            //        {
            //            this.bingding();
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000AEA RID: 2794 RVA: 0x001B218C File Offset: 0x001B038C
        private void dgvhanghoa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int columnIndex = this.dgvhanghoa.CurrentCell.ColumnIndex;
            //int rowIndex = this.dgvhanghoa.CurrentCell.RowIndex;
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string text = this.dgvhanghoa.Rows[rowIndex].Cells["mahanghoa1"].Value.ToString();
            //    if (this.dgvhanghoa.Columns[columnIndex].Name == "tenhang")
            //    {
            //        string text2 = this.dgvhanghoa.Rows[rowIndex].Cells["tenhang"].Value.ToString();
            //        string text3 = this.NonUnicode(text2);
            //        string text4 = "";
            //        string[] array = text3.Split(new char[]
            //        {
            //            ' '
            //        });
            //        foreach (string text5 in array)
            //        {
            //            if (text5.ToString().Trim().Length > 0)
            //            {
            //                text4 += text5.ToString().Substring(0, 1);
            //            }
            //        }
            //        if (text2 != "")
            //        {
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOA SET TENHANGHOA=N'",
            //                text2,
            //                "' , TENHANGHOA_KHONGDAU=N'",
            //                text3,
            //                "',KYTUDAU ='",
            //                text4,
            //                "'  where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Đvt1")
            //    {
            //        string text2 = this.dgvhanghoa.Rows[rowIndex].Cells["Đvt1"].Value.ToString();
            //        if (text2 != "")
            //        {
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONVITINH=N'",
            //                text2,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "dvt2")
            //    {
            //        string text2 = this.dgvhanghoa.Rows[rowIndex].Cells["dvt2"].Value.ToString();
            //        if (text2 != "")
            //        {
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONVITINHLON=N'",
            //                text2,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "gia1")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia1"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Gia2")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia2"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA2='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Gia3")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia3"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA3='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Gia4")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia4"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA4='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "gia5")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia5"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA5='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "gia6")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["gia6"].Value.ToString());
            //        if (num > 0.0)
            //        {
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "UPDATE TB_HANGHOA SET DONGIA6='",
            //                num,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Ck")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["Ck"].Value.ToString());
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_HANGHOA SET CHIETKHAU='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "quydoi1")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["quydoi1"].Value.ToString());
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_HANGHOA SET QUYDOI1='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "diem")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["diem"].Value.ToString());
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_HANGHOA SET DIEM='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "SL_CANHBAO")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["SL_CANHBAO"].Value.ToString());
            //        if (num.ToString() == "")
            //        {
            //            num = 0.0;
            //        }
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_HANGHOA SET SL_CANHBAO='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Giavon")
            //    {
            //        double num = double.Parse(this.dgvhanghoa.Rows[rowIndex].Cells["Giavon"].Value.ToString());
            //        if (num.ToString() == "")
            //        {
            //            num = 0.0;
            //        }
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_CHITIETHOADON set GIAVON='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'and  RIGHT(NGAYXUAT,10)='",
            //            DateTime.Now.ToString("dd/MM/yyyy"),
            //            "' UPDATE TB_HANGHOA SET GIANHAP='",
            //            num,
            //            "' where MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else if (this.dgvhanghoa.Columns[columnIndex].Name == "Ghichu")
            //    {
            //        string text2 = this.dgvhanghoa.Rows[rowIndex].Cells["Ghichu"].Value.ToString();
            //        if (text2 != "")
            //        {
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOA SET GHICHU=N'",
            //                text2,
            //                "' where MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000AEB RID: 2795 RVA: 0x0001DB70 File Offset: 0x0001BD70
        private void textBox3_Enter(object sender, EventArgs e)
        {
            // this.txtmanhom.Focus();
        }

        // Token: 0x06000AEC RID: 2796 RVA: 0x0001DB7F File Offset: 0x0001BD7F
        private void textBox4_Enter(object sender, EventArgs e)
        {
            // this.txtMaHH.Focus();
        }

        // Token: 0x06000AED RID: 2797 RVA: 0x0001DB8E File Offset: 0x0001BD8E
        private void textBox5_Enter(object sender, EventArgs e)
        {
            // this.txtDVT.Focus();
        }

        // Token: 0x06000AEE RID: 2798 RVA: 0x0001DB9D File Offset: 0x0001BD9D
        private void textBox6_Enter(object sender, EventArgs e)
        {
            // this.txtdonvilon.Focus();
        }

        // Token: 0x06000AEF RID: 2799 RVA: 0x0001B637 File Offset: 0x00019837
        private void textBox7_Leave(object sender, EventArgs e)
        {
        }

        // Token: 0x06000AF0 RID: 2800 RVA: 0x0001B637 File Offset: 0x00019837
        private void textBox8_Leave(object sender, EventArgs e)
        {
        }

        // Token: 0x06000AF1 RID: 2801 RVA: 0x0001DBAC File Offset: 0x0001BDAC
        private void textBox8_Enter(object sender, EventArgs e)
        {
            //  this.txtGhichu.Focus();
        }

        // Token: 0x06000AF2 RID: 2802 RVA: 0x0001DBBB File Offset: 0x0001BDBB
        private void textBox9_Enter(object sender, EventArgs e)
        {
            // this.textBox1.Focus();
        }

        // Token: 0x06000AF3 RID: 2803 RVA: 0x0001DBCA File Offset: 0x0001BDCA
        private void textBox7_Enter(object sender, EventArgs e)
        {
            // this.txtTenHH.Focus();
        }

        // Token: 0x06000AF4 RID: 2804 RVA: 0x0001DBD9 File Offset: 0x0001BDD9
        private void lbck_Enter(object sender, EventArgs e)
        {
            // this.txtchietkhau.Focus();
        }

        // Token: 0x06000AF5 RID: 2805 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
        private void txtchietkhau_Enter(object sender, EventArgs e)
        {
            // this.txtchietkhau.BackColor = Color.Yellow;
        }

        // Token: 0x06000AF6 RID: 2806 RVA: 0x001B2E90 File Offset: 0x001B1090
        private void mahoadontieptheo()
        {
            //if (this.manhapkho == string.Empty)
            //{
            //    string selectCommandText = "select isnull(MAX(MAHOADON),'000000000') from TB_HANGHOANHAP where CONVERT(DATETIME,NGAYNHAP,103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    string text;
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        text = DateTime.Now.ToString("MMyy") + "00001";
            //    }
            //    else
            //    {
            //        string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(0, 4));
            //        text = DateTime.Now.ToString("MMyy");
            //        if (a == text)
            //        {
            //            double num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(4, 5));
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
            //            text = DateTime.Now.ToString("MMyy") + "00001";
            //        }
            //    }
            //    this.manhapkho = text;
            //}
        }

        // Token: 0x06000AF7 RID: 2807 RVA: 0x001B30C0 File Offset: 0x001B12C0
        private void load_kho()
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText;
            //    if (TrangChu.dungnhieukho == "True")
            //    {
            //        cmdText = "SELECT TOP 1 MAKHO FROM TB_KHO ORDER BY MAKHO";
            //    }
            //    else
            //    {
            //        cmdText = "SELECT TOP 1 MAKHO FROM TB_KHO WHERE MAKHO='" + frmLogIn.makho + "' ORDER BY MAKHO ";
            //    }
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.makho = Convert.ToString(sqlDataReader.GetValue(0));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    this.makho = "00";
            //}
        }

        // Token: 0x06000AF8 RID: 2808 RVA: 0x001B318C File Offset: 0x001B138C
        //private void nhaphanghoa(HanghoanhapObj hhnObj)
        //{
        //    if (this.txtsl.Text == "")
        //    {
        //        this.txtsl.Text = "0";
        //    }
        //    if (this.txtgianhap.Text == "")
        //    {
        //        this.txtgianhap.Text = "0";
        //    }
        //    decimal num;
        //    if (!this.cbton.Checked)
        //    {
        //        num = decimal.Parse(this.txtquydoi2.Text) * decimal.Parse(this.txtsl.Text);
        //    }
        //    else
        //    {
        //        num = decimal.Parse(this.txtsl.Text);
        //    }
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    this.mahoadontieptheo();
        //    hhnObj.Stt = 2222;
        //    hhnObj.Mahoadon = this.manhapkho;
        //    hhnObj.Mahanghoa = this.txtMaHH.Text;
        //    hhnObj.Soluong2 = "0";
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Soluong = num.ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Dongia = float.Parse(this.txtgianhap.Text).ToString();
        //    hhnObj.Ngaynhap = DateTime.Now.AddDays(-1.0).ToString("dd/MM/yyyy");
        //    hhnObj.Ghichu = "tdk";
        //    hhnObj.Soluongquydoi = num.ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Loai = this.makho;
        //    hhnObj.Vat = "0";
        //    hhnObj.Maloai = "0";
        //    hhnObj.Ncc = "CTY";
        //    if (this.xhdCtr.ADD_HANGHOANHAP(hhnObj))
        //    {
        //        if (float.Parse(this.txtgianhap.Text) > 0f)
        //        {
        //            SqlConnection sqlConnection = new SqlConnection();
        //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //            SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
        //            {
        //                "DELETE TB_GIAVON WHERE MAHANG='",
        //                this.txtMaHH.Text,
        //                "' INSERT INTO TB_GIAVON (MAHANG,GIAVON) VALUES('",
        //                this.txtMaHH.Text,
        //                "','",
        //                double.Parse(this.txtgianhap.Text),
        //                "')"
        //            }), sqlConnection);
        //            sqlConnection.Open();
        //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //            sqlConnection.Close();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x06000AF9 RID: 2809 RVA: 0x001B3474 File Offset: 0x001B1674
        private void txtsl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                // this.txtgianhap.Focus();
            }
        }

        // Token: 0x06000AFA RID: 2810 RVA: 0x001B34A0 File Offset: 0x001B16A0
        private void txtgianhap_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.txtgianhap.Text == "")
            //    {
            //        this.txtgianhap.Text = "0";
            //    }
            //    if (this.textBox14.Visible)
            //    {
            //        this.textBox14.Focus();
            //    }
            //    else
            //    {
            //        this.btLuu_Click(null, null);
            //    }
            //}
        }

        // Token: 0x06000AFB RID: 2811 RVA: 0x0001DBFC File Offset: 0x0001BDFC
        private void textBox13_Enter(object sender, EventArgs e)
        {
            // this.txtsl.Focus();
        }

        // Token: 0x06000AFC RID: 2812 RVA: 0x001B3518 File Offset: 0x001B1718
        private void txtsl_Leave(object sender, EventArgs e)
        {
            //if (this.txtsl.Text == "")
            //{
            //    this.txtsl.Text = this.txtsl.Tag.ToString();
            //}
            //this.txtsl.BackColor = Color.White;
        }

        // Token: 0x06000AFD RID: 2813 RVA: 0x001B3570 File Offset: 0x001B1770
        private void txtsl_Enter(object sender, EventArgs e)
        {
            //if (this.txtsl.Text == this.txtsl.Tag.ToString())
            //{
            //    this.txtsl.Text = "";
            //}
            //this.txtsl.BackColor = Color.Yellow;
        }

        // Token: 0x06000AFE RID: 2814 RVA: 0x001B35C8 File Offset: 0x001B17C8
        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtgianhap.Text != this.txtgianhap.Tag.ToString())
            //    {
            //        if (this.txtgianhap.Text != "")
            //        {
            //            double num = Convert.ToDouble(this.txtgianhap.Text);
            //            this.txtgianhap.Text = num.ToString("#,##0");
            //            this.txtgianhap.SelectionStart = this.txtgianhap.TextLength;
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000AFF RID: 2815 RVA: 0x00089160 File Offset: 0x00087360
        private void txtDongia1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B00 RID: 2816 RVA: 0x00089160 File Offset: 0x00087360
        private void txtdongia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B01 RID: 2817 RVA: 0x00089160 File Offset: 0x00087360
        private void txtdongia3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B02 RID: 2818 RVA: 0x00089160 File Offset: 0x00087360
        private void txtquydoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B03 RID: 2819 RVA: 0x00089160 File Offset: 0x00087360
        private void txtdongia5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B04 RID: 2820 RVA: 0x00089160 File Offset: 0x00087360
        private void txtdongia6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x06000B05 RID: 2821 RVA: 0x001B3678 File Offset: 0x001B1878
        private void txtchietkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //char c = Convert.ToChar(currencyDecimalSeparator);
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtchietkhau.Text.IndexOf(currencyDecimalSeparator) != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000B06 RID: 2822 RVA: 0x001B3704 File Offset: 0x001B1904
        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //char c = Convert.ToChar(currencyDecimalSeparator);
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtgianhap.Text.IndexOf(currencyDecimalSeparator) != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000B07 RID: 2823 RVA: 0x001B3790 File Offset: 0x001B1990
        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //char c = Convert.ToChar(currencyDecimalSeparator);
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtsl.Text.IndexOf(currencyDecimalSeparator) != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000B08 RID: 2824 RVA: 0x001B381C File Offset: 0x001B1A1C
        private void txtquydoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //char c = Convert.ToChar(currencyDecimalSeparator);
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtquydoi2.Text.IndexOf(currencyDecimalSeparator) != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000B09 RID: 2825 RVA: 0x001B38A8 File Offset: 0x001B1AA8
        private void txtMaHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (TrangChu.codeEAN13 == "True")
            //{
            //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000B0A RID: 2826 RVA: 0x001B38F8 File Offset: 0x001B1AF8
        private void button3_Click(object sender, EventArgs e)
        {
            //frmHangHoa.Ma_hanghoa = this.txtMaHH.Text;
            //FrmInmavach frmInmavach = new FrmInmavach();
            //frmInmavach.ShowDialog();
        }

        // Token: 0x06000B0B RID: 2827 RVA: 0x001B3924 File Offset: 0x001B1B24
        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (double.Parse(this.txtchietkhau.Text) > 999.0)
            //    {
            //        this.txtchietkhau.Text = double.Parse(this.txtchietkhau.Text).ToString("#,##0");
            //        this.txtchietkhau.SelectionStart = this.txtchietkhau.TextLength;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000B0C RID: 2828 RVA: 0x001B39B0 File Offset: 0x001B1BB0
        private void cbmahangtudong_MouseClick(object sender, MouseEventArgs e)
        {
            //string mahangtudong = "True";
            //if (this.cbmahangtudong.Checked)
            //{
            //    this.txtTenHH.Focus();
            //    this.mahanghoa();
            //    if (TrangChu.codeEAN13 == "True")
            //    {
            //        if (this.txtMaHH.Text.Length != 13)
            //        {
            //            string text = "";
            //            if (this.txtMaHH.Text.Length == 1)
            //            {
            //                text = "80000000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 2)
            //            {
            //                text = "8000000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 3)
            //            {
            //                text = "800000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 4)
            //            {
            //                text = "80000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 5)
            //            {
            //                text = "8000000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 6)
            //            {
            //                text = "800000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 7)
            //            {
            //                text = "80000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 8)
            //            {
            //                text = "8000" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 9)
            //            {
            //                text = "800" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 10)
            //            {
            //                text = "80" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 11)
            //            {
            //                text = "8" + this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length == 12)
            //            {
            //                text = this.txtMaHH.Text;
            //            }
            //            else if (this.txtMaHH.Text.Length > 12)
            //            {
            //                text = this.txtMaHH.Text.Substring(0, 12);
            //            }
            //            string chaine = text;
            //            string text2 = EAN13Class.EAN13(chaine);
            //            if (!string.Equals(EAN13Class.Barcode13Digits, "") || EAN13Class.Barcode13Digits != "")
            //            {
            //                this.richTextBox1.Text = EAN13Class.Barcode13Digits.ToString();
            //            }
            //        }
            //        else
            //        {
            //            this.richTextBox1.Text = this.txtMaHH.Text;
            //        }
            //    }
            //}
            //else
            //{
            //    mahangtudong = "False";
            //    this.txtMaHH.Focus();
            //}
            //Settings.Default.mahangtudong = mahangtudong;
            //Settings.Default.Save();
        }

        // Token: 0x06000B0D RID: 2829 RVA: 0x001B3D80 File Offset: 0x001B1F80
        private void cobnhom_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cobnhom.DataSource == null)
            //{
            //    this.LOADNHOMHANG();
            //}
        }

        // Token: 0x06000B0E RID: 2830 RVA: 0x001B3DAC File Offset: 0x001B1FAC
        private void txtgianhap_Leave(object sender, EventArgs e)
        {
            //if (this.txtgianhap.Text == "")
            //{
            //    this.txtgianhap.Text = this.txtgianhap.Tag.ToString();
            //}
            //this.txtgianhap.BackColor = Color.White;
        }

        // Token: 0x06000B0F RID: 2831 RVA: 0x001B3E04 File Offset: 0x001B2004
        private void txtgianhap_Enter(object sender, EventArgs e)
        {
            //if (this.txtgianhap.Text == this.txtgianhap.Tag.ToString())
            //{
            //    this.txtgianhap.Text = "";
            //}
            //this.txtgianhap.BackColor = Color.Yellow;
        }

        // Token: 0x06000B10 RID: 2832 RVA: 0x0001DC0B File Offset: 0x0001BE0B
        private void frmHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            // frmHangHoa.Ma_hanghoa = this.txtMaHH.Text;
        }

        // Token: 0x06000B11 RID: 2833 RVA: 0x001B3E5C File Offset: 0x001B205C
        private void txttichdiem_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (TrangChu.bantonkho == "False")
            //    {
            //        this.btLuu.Focus();
            //    }
            //    else
            //    {
            //        this.txtsl.Focus();
            //    }
            //}
        }

        // Token: 0x06000B12 RID: 2834 RVA: 0x001B3EB0 File Offset: 0x001B20B0
        private void txttichdiem_Leave(object sender, EventArgs e)
        {
            //if (this.txttichdiem.Text == "")
            //{
            //    this.txttichdiem.Text = "0";
            //}
        }

        // Token: 0x06000B13 RID: 2835 RVA: 0x001B3EEC File Offset: 0x001B20EC
        private void txtsl1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtdongia2.Focus();
            //}
        }

        // Token: 0x06000B14 RID: 2836 RVA: 0x001B3F18 File Offset: 0x001B2118
        private void txtsl2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtdongia3.Focus();
            //}
        }

        // Token: 0x06000B15 RID: 2837 RVA: 0x001B3F44 File Offset: 0x001B2144
        private void txtsl3_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtdongia4.Focus();
            //}
        }

        // Token: 0x06000B16 RID: 2838 RVA: 0x001B3F70 File Offset: 0x001B2170
        private void txtsl4_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtdongia5.Focus();
            //}
        }

        // Token: 0x06000B17 RID: 2839 RVA: 0x001B3F9C File Offset: 0x001B219C
        private void txtsl5_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtdongia6.Focus();
            //}
        }

        // Token: 0x06000B18 RID: 2840 RVA: 0x001B3FC8 File Offset: 0x001B21C8
        private void txtsl6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.txtchietkhau.Focus();
            //}
        }

        // Token: 0x06000B19 RID: 2841 RVA: 0x001B3FF4 File Offset: 0x001B21F4
        private void textBox14_Leave(object sender, EventArgs e)
        {
            //if (this.textBox14.Text == "")
            //{
            //    this.textBox14.Text = "0";
            //}
            //this.textBox14.BackColor = Color.White;
        }

        // Token: 0x06000B1A RID: 2842 RVA: 0x001B4040 File Offset: 0x001B2240
        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    this.btLuu.Focus();
            //}
        }

        // Token: 0x06000B1B RID: 2843 RVA: 0x0001DC1E File Offset: 0x0001BE1E
        private void textBox14_Enter(object sender, EventArgs e)
        {
            // this.textBox14.BackColor = Color.Yellow;
        }

        // Token: 0x06000B1C RID: 2844 RVA: 0x001B406C File Offset: 0x001B226C
        private void txtmanhom_Leave(object sender, EventArgs e)
        {
            //if (this.txtmanhom.Text.Trim() != "")
            //{
            //    this.tudonghanghoaMA();
            //}
        }

        // Token: 0x06000B1D RID: 2845 RVA: 0x001B40A4 File Offset: 0x001B22A4
        private void txtDongia1_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 1";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtDongia1.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B1E RID: 2846 RVA: 0x001B40DC File Offset: 0x001B22DC
        private void txtdongia2_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 2";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongia2.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B1F RID: 2847 RVA: 0x001B4114 File Offset: 0x001B2314
        private void txtdongia3_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 3";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongia3.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B20 RID: 2848 RVA: 0x001B414C File Offset: 0x001B234C
        private void txtdongia4_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 4";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongia4.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B21 RID: 2849 RVA: 0x001B4184 File Offset: 0x001B2384
        private void txtdongia5_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 5";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongia5.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B22 RID: 2850 RVA: 0x001B41BC File Offset: 0x001B23BC
        private void txtdongia6_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá bán 6";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongia6.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B23 RID: 2851 RVA: 0x001B41F4 File Offset: 0x001B23F4
        private void txtchietkhau_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Chiết khấu";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtchietkhau.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B24 RID: 2852 RVA: 0x001B422C File Offset: 0x001B242C
        private void txttichdiem_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Tích điểm";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txttichdiem.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B25 RID: 2853 RVA: 0x001B4264 File Offset: 0x001B2464
        private void txtsl_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Tồn kho";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B26 RID: 2854 RVA: 0x001B429C File Offset: 0x001B249C
        private void textBox14_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng tối thiểu";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.textBox14.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B27 RID: 2855 RVA: 0x001B42D4 File Offset: 0x001B24D4
        private void txtgianhap_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Giá vốn";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtgianhap.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B28 RID: 2856 RVA: 0x001B430C File Offset: 0x001B250C
        private void txtquydoi2_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Quy đổi số lượng";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtquydoi2.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B29 RID: 2857 RVA: 0x001B4344 File Offset: 0x001B2544
        private void txtsltang_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng tặng";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsltang.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2A RID: 2858 RVA: 0x001B437C File Offset: 0x001B257C
        private void txtslban_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng bán";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtslban.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2B RID: 2859 RVA: 0x001B43B4 File Offset: 0x001B25B4
        private void txtsl1_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 1";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl1.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2C RID: 2860 RVA: 0x001B43EC File Offset: 0x001B25EC
        private void txtsl2_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 2";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl2.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2D RID: 2861 RVA: 0x001B4424 File Offset: 0x001B2624
        private void txtsl3_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 3";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl3.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2E RID: 2862 RVA: 0x001B445C File Offset: 0x001B265C
        private void txtsl4_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 4";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl4.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B2F RID: 2863 RVA: 0x001B4494 File Offset: 0x001B2694
        private void txtsl5_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 5";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl5.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B30 RID: 2864 RVA: 0x001B44CC File Offset: 0x001B26CC
        private void txtsl6_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số lượng 6";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsl6.Text = Frmbangso.soluong;
        }

        // Token: 0x06000B31 RID: 2865 RVA: 0x001B4504 File Offset: 0x001B2704
        private void dgvhanghoa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (this.dgvhanghoa.RowCount > 0)
            //{
            //    if (TrangChu.SUAHANG == "True")
            //    {
            //        int columnIndex = this.dgvhanghoa.CurrentCell.ColumnIndex;
            //        if (this.dgvhanghoa.Columns[columnIndex].Name == "Nhom")
            //        {
            //            frmHangHoa.chon_suanhom = 1;
            //            Frmnhomhang frmnhomhang = new Frmnhomhang();
            //            frmnhomhang.ShowDialog();
            //            if (frmHangHoa.manhom_sua != "")
            //            {
            //                this.dgvhanghoa.CurrentRow.Cells["Nhom"].Value = frmHangHoa.tennhom_sua;
            //                SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //                sqlConnection.Open();
            //                string cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET MANHOM='",
            //                    frmHangHoa.manhom_sua,
            //                    "' WHERE MAHANGHOA='",
            //                    this.dgvhanghoa.CurrentRow.Cells["mahanghoa1"].Value.ToString(),
            //                    "' "
            //                });
            //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                sqlConnection.Close();
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000B32 RID: 2866 RVA: 0x001B4670 File Offset: 0x001B2870
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand;
            //if (TrangChu.codeEAN13 == "True")
            //{
            //    sqlCommand = new SqlCommand("Select MAHANGHOA from Tb_HANGHOA WHERE MAHANGHOA='" + this.richTextBox1.Text + "'", sqlConnection);
            //}
            //else
            //{
            //    sqlCommand = new SqlCommand("Select MAHANGHOA from Tb_HANGHOA WHERE MAHANGHOA='" + this.txtMaHH.Text.Trim() + "'", sqlConnection);
            //}
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //this.txtSoluong.Text = "0";
            //if (this.checkBox1.Checked)
            //{
            //    this.txtSoluong.Text = "1";
            //}
            //while (sqlDataReader.Read())
            //{
            //    if (this.txtMaHH.Text.Trim() == sqlDataReader.GetString(0).Trim())
            //    {
            //        if (sqlConnection.State == ConnectionState.Open)
            //        {
            //            sqlConnection.Close();
            //        }
            //        sqlConnection.Open();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "UPDATE TB_HANGHOA SET VAT='",
            //            this.txtSoluong.Text,
            //            "' WHERE MAHANGHOA='",
            //            this.txtMaHH.Text.Trim(),
            //            "' "
            //        });
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand2.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        this.dgvhanghoa.CurrentRow.Cells["vat"].Value = this.txtSoluong.Text;
            //        break;
            //    }
            //}
        }

        // Token: 0x06000B33 RID: 2867 RVA: 0x001B4838 File Offset: 0x001B2A38
        private void ptlogo_Click(object sender, EventArgs e)
        {
            //if (this.txtMaHH.Text != "")
            //{
            //    try
            //    {
            //        this.openFileDialog1.Filter = "Select Images |*.jpg||*.png";
            //        if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            this.ptlogo.Load(this.openFileDialog1.FileName);
            //        }
            //        byte[] buffer;
            //        try
            //        {
            //            MemoryStream memoryStream = new MemoryStream();
            //            this.ptlogo.Image.Save(memoryStream, ImageFormat.Jpeg);
            //            buffer = memoryStream.GetBuffer();
            //            memoryStream.Close();
            //        }
            //        catch
            //        {
            //            MemoryStream memoryStream = new MemoryStream();
            //            this.ptlogo.Image = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
            //            Bitmap bitmap = new Bitmap(this.ptlogo.Image);
            //            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //            buffer = memoryStream.GetBuffer();
            //            memoryStream.Close();
            //        }
            //        string cmdText = "DELETE TB_HINHHANGHOA WHERE MAHANG ='" + this.txtMaHH.Text + "'INSERT INTO TB_HINHHANGHOA values(@mahang,@hinh)";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.Parameters.AddWithValue("@mahang", this.txtMaHH.Text);
            //        sqlCommand.Parameters.AddWithValue("@hinh", buffer);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Dispose();
            //        sqlConnection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        string message = ex.Message;
            //    }
            //}
        }

        // Token: 0x06000B34 RID: 2868 RVA: 0x001B4A10 File Offset: 0x001B2C10
        private void ptlogo_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    if (this.ptlogo.Image != null)
            //    {
            //        Frm_hinhsanpham.mahang = this.txtMaHH.Text;
            //        Frm_hinhsanpham frm_hinhsanpham = new Frm_hinhsanpham();
            //        frm_hinhsanpham.ShowDialog();
            //    }
            //}
        }

        // Token: 0x06000B35 RID: 2869 RVA: 0x001B4A68 File Offset: 0x001B2C68
        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox2.Checked)
            //{
            //    this.checkBox2.Checked = true;
            //}
            //else
            //{
            //    this.dgvhanghoa.ReadOnly = true;
            //}
        }

        // Token: 0x06000B36 RID: 2870 RVA: 0x001B4AA8 File Offset: 0x001B2CA8
        private void txtquydoi2_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.txtquydoi2.Text = double.Parse(this.txtquydoi2.Text).ToString("#,##0.####");
            //    this.txtquydoi2.SelectionStart = this.txtquydoi2.TextLength;
            //}
            //catch
            //{
            //}
        }
    }
}
