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
    public partial class Frmcongnophaitra : Form
    {
        public Frmcongnophaitra()
        {
            InitializeComponent();
        }
        private void loadcauhinh()
        {
            //try
            //{
            //    string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.chObj.Tencongty = sqlDataReader.GetString(1);
            //        this.chObj.Diachi = sqlDataReader.GetString(2);
            //        this.chObj.Dienthoai = sqlDataReader.GetString(3);
            //        this.chObj.Kyten = sqlDataReader.GetString(4);
            //        this.chObj.Ghichu = sqlDataReader.GetString(7);
            //        this.chObj.Cochuten = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
            //        this.chObj.Cochudienthoai = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
            //        this.chObj.Cochukyten = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
            //        this.chObj.Cochudiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
            //        this.chObj.Hoadon = sqlDataReader.GetString(15);
            //        this.chObj.Tieude1 = sqlDataReader.GetString(16);
            //        this.chObj.Tieude2 = sqlDataReader.GetString(17);
            //        this.chObj.Tieude3 = sqlDataReader.GetString(18);
            //        this.chObj.Diachi1 = Convert.ToString(sqlDataReader.GetValue(20));
            //        this.chObj.Diachi2 = Convert.ToString(sqlDataReader.GetValue(21));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("CẬP NHẬT THÊM VÀO BẢNG TB_CAUHINH", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000831 RID: 2097 RVA: 0x001557DC File Offset: 0x001539DC
        private void loadmayin()
        {
            //try
            //{
            //    string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.chObj.Canhle = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.chObj.Sotrangin = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
            //        this.chObj.Letrai = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
            //        this.chObj.Mayin = sqlDataReader.GetString(12);
            //        this.chObj.Tenmayin = sqlDataReader.GetString(14);
            //        this.chObj.Hoadon = sqlDataReader.GetString(15);
            //        this.chObj.Kytu = Convert.ToString(sqlDataReader.GetValue(43));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("CẬP NHẬT THÊM VÀO BẢNG TB_CAUHINH", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000832 RID: 2098 RVA: 0x00155930 File Offset: 0x00153B30
        private void tudongcapnhattendonvi()
        {
            //this.txtmakh.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.txtmakh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select tendonvi from Tb_khachhang WHERE NCC='TRUE'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtmakh.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000833 RID: 2099 RVA: 0x001559CC File Offset: 0x00153BCC
        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtmakh.Text != "")
            //    {
            //        string cmdText = "SELECT TENDONVI FROM tb_KHACHHANG where MAKHACHHANG='" + this.txtmakh.Text + "'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txttenkh.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txttenkh.Text = "";
            //            this.lanhacungcap = "";
            //        }
            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        this.txttenkh.Text = "";
            //        this.lanhacungcap = "";
            //        this.btbaocao_Click(null, null);
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000834 RID: 2100 RVA: 0x00155AE8 File Offset: 0x00153CE8
        private void txtmakh_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        string cmdText = "SELECT MAKHACHHANG, TENDONVI FROM tb_KHACHHANG where TENDONVI LIKE N'%" + this.txtmakh.Text + "%'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txtmakh.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.txttenkh.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txttenkh.Text = "";
            //        }
            //        sqlConnection.Close();
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000835 RID: 2101 RVA: 0x00155BDC File Offset: 0x00153DDC
        private void btbaocao_Click(object sender, EventArgs e)
        {
            //this.chitiet = 1;
            //try
            //{
            //    if (this.txtmakh.Text != "")
            //    {
            //        string text = this.txtmakh.Text;
            //        DataTable dataTable = new DataTable();
            //        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //        string text2 = dateTime.ToString("MM/dd/yyyy");
            //        string text3 = dateTime2.ToString("MM/dd/yyyy");
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE TB_CHITIETPHAITRA WHERE DAUKY!='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=ISNULL((SELECT SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC='",
            //            text,
            //            "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //            text2,
            //            "'),0)  + ISNULL((SELECT SUM(HN.DONGIA*HN.SOLUONGQUYDOI) AS TONGTIEN FROM TB_HANGHOANHAP_NL HN WHERE HN.NCC='",
            //            text,
            //            "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //            text2,
            //            "'),0) -ISNULL(( SELECT SUM(TIENTRANO) FROM Tb_THUCHI WHERE MaKH='",
            //            text,
            //            "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //            text2,
            //            "'),0),TRA='0' WHERE DAUKY='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=NO+ISNULL((select SUM(ISNULL(SOTIENTRA,0)) from TB_TONDAUKY where ma='tra' AND MAKH='",
            //            text,
            //            "'),0) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MAHOADON,NGAYNHAP,SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI),'0','FALSE' FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC='",
            //            text,
            //            "' AND MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //            text2,
            //            "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //            text3,
            //            "' GROUP BY MAHOADON,NGAYNHAP) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MAHOADON,NGAYNHAP,SUM(HN.DONGIA*HN.SOLUONGQUYDOI),'0','FALSE' FROM TB_HANGHOANHAP_NL HN WHERE HN.NCC='",
            //            text,
            //            "' AND MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //            text2,
            //            "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //            text3,
            //            "' GROUP BY MAHOADON,NGAYNHAP) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MATHUCHI,NGAY,'0',SUM(TIENTRANO),'FALSE' FROM Tb_THUCHI WHERE MaKH='",
            //            text,
            //            "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //            text2,
            //            "' AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //            text3,
            //            "' GROUP BY MATHUCHI,NGAY)SELECT CHUNGTU,NGAY,ISNULL(NO,0) AS NO,ISNULL(TRA,0) AS TRA FROM TB_CHITIETPHAITRA ORDER BY STT"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvchitiet.DataSource = dataTable;
            //        this.dgvchitiet.BringToFront();
            //        if (this.dgvchitiet.RowCount > 0)
            //        {
            //            decimal d = 0m;
            //            decimal num = 0m;
            //            this.dgvchitiet.AllowUserToAddRows = false;
            //            for (int i = 0; i < this.dgvchitiet.RowCount; i++)
            //            {
            //                d += Convert.ToDecimal(this.dgvchitiet.Rows[i].Cells["no"].Value.ToString());
            //                num += Convert.ToDecimal(this.dgvchitiet.Rows[i].Cells["tra"].Value.ToString());
            //                this.dgvchitiet.Rows[i].Cells[0].Value = i + 1;
            //            }
            //            this.dgvchitiet.AllowUserToAddRows = true;
            //            int num2 = this.dgvchitiet.Rows.Count - 1;
            //            decimal num3 = d - num;
            //            if (num3 > 0m)
            //            {
            //                this.dgvchitiet["no", num2].Value = num3;
            //                this.dgvchitiet["tra", num2].Value = "0";
            //                this.dgvchitiet["ngaychungtu", num2].Value = "NỢ CUỐI KỲ";
            //            }
            //            else
            //            {
            //                this.dgvchitiet["no", num2].Value = "0";
            //                this.dgvchitiet["tra", num2].Value = num3;
            //                this.dgvchitiet["ngaychungtu", num2].Value = "DƯ CUỐI KỲ";
            //            }
            //            this.dgvchitiet.Rows[num2].DefaultCellStyle.BackColor = Color.SkyBlue;
            //        }
            //    }
            //    else
            //    {
            //        string text4 = "";
            //        if (this.cobdk.SelectedIndex == 0)
            //        {
            //            text4 = "and ISNULL(DK.SOTIEN,0) + ISNULL(TK.SOTIEN,0)-ISNULL(TDK.SOTIEN,0)-ISNULL(TTK.SOTIEN,0)>" + double.Parse(this.txtdk.Text);
            //        }
            //        if (this.cobdk.SelectedIndex == 1)
            //        {
            //            text4 = "and ISNULL(DK.SOTIEN,0) + ISNULL(TK.SOTIEN,0)-ISNULL(TDK.SOTIEN,0)-ISNULL(TTK.SOTIEN,0)<" + double.Parse(this.txtdk.Text);
            //        }
            //        if (this.cobdk.SelectedIndex == 2)
            //        {
            //            text4 = "";
            //        }
            //        DataTable dataTable = new DataTable();
            //        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE TB_CONGNODAUKY INSERT INTO TB_CONGNODAUKY(MAKH,SOTIEN)(SELECT HN.NCC, SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' GROUP BY HN.NCC)  INSERT INTO TB_CONGNODAUKY(MAKH,SOTIEN)(SELECT HN.NCC, SUM((HN.DONGIA)*HN.SOLUONGQUYDOI) AS TONGTIEN  FROM TB_HANGHOANHAP_NL HN WHERE HN.MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' GROUP BY HN.NCC) DELETE TB_CONGNOTRONGKY INSERT INTO TB_CONGNOTRONGKY(MAKH,SOTIEN)(SELECT HN.NCC, SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN FROM TB_HANGHOANHAP HN, TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //            dateTime2.ToString("MM/dd/yyyy"),
            //            "' GROUP BY HN.NCC)  INSERT INTO TB_CONGNOTRONGKY(MAKH,SOTIEN)(SELECT HN.NCC, SUM(HN.DONGIA*HN.SOLUONGQUYDOI) AS TONGTIEN FROM TB_HANGHOANHAP_NL HN WHERE HN.MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //            dateTime2.ToString("MM/dd/yyyy"),
            //            "' GROUP BY HN.NCC) DELETE TB_THUDAUKY INSERT INTO TB_THUDAUKY(MAKH,SOTIEN)(SELECT MAKH,SUM(TIENTRANO) FROM Tb_THUCHI WHERE CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<='00:00 ",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' GROUP BY MaKH HAVING SUM(TIENTRANO)!=0) DELETE TB_THUTRONGKY INSERT INTO TB_THUTRONGKY(MAKH,SOTIEN)(SELECT MAKH,SUM(TIENTRANO) FROM Tb_THUCHI WHERE CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:01 ",
            //            dateTime.ToString("MM/dd/yyyy"),
            //            "' AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //            dateTime2.ToString("MM/dd/yyyy"),
            //            "' GROUP BY MaKH HAVING SUM(TIENTRANO)!=0) INSERT INTO TB_CONGNODAUKY(MAKH,SOTIEN)(select MAKH,SOTIENTRA FROM TB_TONDAUKY WHERE MA='TRA')DELETE TB_CONGNODAUKY_1 INSERT INTO TB_CONGNODAUKY_1(MAKH,SOTIEN)(SELECT MAKH, SUM(SOTIEN) FROM TB_CONGNODAUKY GROUP BY MAKH) DELETE TB_CONGNOTRONGKY_1 INSERT INTO TB_CONGNOTRONGKY_1(MAKH,SOTIEN)(SELECT MAKH, SUM(SOTIEN)       FROM TB_CONGNOTRONGKY GROUP BY MAKH) SELECT KH.MAKHACHHANG,KH.TENDONVI,SUM(ISNULL(DK.SOTIEN,0))-ISNULL(TDK.SOTIEN,0) AS DAUKY,ISNULL(TDK.SOTIEN,0) AS TRADAUKY,ISNULL(TK.SOTIEN,0)AS TRONGKY,ISNULL(TTK.SOTIEN,0) AS TRATRONGKY,SUM(ISNULL(DK.SOTIEN,0)) + ISNULL(TK.SOTIEN,0)-ISNULL(TDK.SOTIEN,0)-ISNULL(TTK.SOTIEN,0)AS CONLAI FROM Tb_KHACHHANG KH LEFT JOIN TB_CONGNODAUKY_1 DK ON KH.MAKHACHHANG=DK.MAKH LEFT JOIN TB_CONGNOTRONGKY_1 TK ON KH.MAKHACHHANG=TK.MAKH LEFT JOIN TB_THUDAUKY TDK ON TDK.MAKH=KH.MAKHACHHANG LEFT JOIN TB_THUTRONGKY TTK ON TTK.MAKH=KH.MAKHACHHANG WHERE ISNULL(DK.SOTIEN,0)+ISNULL(TK.SOTIEN,0)+ISNULL(TDK.SOTIEN,0)+ISNULL(TTK.SOTIEN,0)>0 ",
            //            text4,
            //            " GROUP BY KH.MAKHACHHANG,KH.TENDONVI,ISNULL(TDK.SOTIEN,0),ISNULL(TK.SOTIEN,0),ISNULL(TTK.SOTIEN,0)"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvcongno.DataSource = dataTable;
            //        this.dgvcongno.BringToFront();
            //        if (this.dgvcongno.RowCount > 0)
            //        {
            //            decimal num4 = 0m;
            //            decimal num5 = 0m;
            //            decimal num6 = 0m;
            //            decimal num7 = 0m;
            //            decimal num8 = 0m;
            //            this.dgvcongno.AllowUserToAddRows = false;
            //            for (int i = 0; i < this.dgvcongno.RowCount; i++)
            //            {
            //                num4 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString());
            //                num5 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["tradauky"].Value.ToString());
            //                num6 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["notrongky"].Value.ToString());
            //                num7 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["tratrongky"].Value.ToString());
            //                num8 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["conno"].Value.ToString());
            //                this.dgvcongno.Rows[i].Cells[0].Value = i + 1;
            //            }
            //            this.dgvcongno.AllowUserToAddRows = true;
            //            int num2 = this.dgvcongno.Rows.Count - 1;
            //            this.dgvcongno["makh", num2].Value = "Total:";
            //            this.dgvcongno["nodauky", num2].Value = num4;
            //            this.dgvcongno["tradauky", num2].Value = num5;
            //            this.dgvcongno["notrongky", num2].Value = num6;
            //            this.dgvcongno["tratrongky", num2].Value = num7;
            //            this.dgvcongno["conno", num2].Value = num8;
            //            this.dgvcongno.Rows[num2].DefaultCellStyle.BackColor = Color.SkyBlue;
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000836 RID: 2102 RVA: 0x00156514 File Offset: 0x00154714
        private void chitietnhap()
        {
            //string npp = "AND HHN.NCC='" + this.txtmakh.Text + "'";
            //this.dgvchitietnhap.BringToFront();
            //DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.THEMTONGHANGHOANHAPNGAY_CHITIET(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), npp, "");
            //this.dgvchitietnhap.DataSource = dataSource;
        }

        // Token: 0x06000837 RID: 2103 RVA: 0x001565B0 File Offset: 0x001547B0
        private void chitietnhap_nhomnhacungcap()
        {
            //string text = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            //string text2 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_HANGHOANHAP_BC INSERT INTO [DATASHOP].[dbo].[TB_HANGHOANHAP_BC] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[DONGIA] ,[TENDONVI] ,[SOLUONG] ,[SOLUONG2] ,[SOLUONG3] ,[SOLUONG4] ,[SOLUONG5] ,[SOLUONG6] ,[SOLUONGTONG] ,[SOLUONGLE] ,[THANHTIEN] ,[NGAYNHAP] ,[MAHOADON]) (SELECT HH.MAHANGHOA,HH.TENHANGHOA+ '- ' +hhn.GHICHU ,CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN HH.DONVITINH ELSE HH.DONVITINHLON END AS DONVITINH,CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN HHN.DONGIA ELSE HHN.DONGIA/HH.QUYDOI1 END AS DONGIA,KH.TENDONVI as tendonvi ,ISNULL(SUM(HHN.SOLUONG),0) AS SOLUONG,ISNULL(SUM(HHN.SOLUONG2),0) AS SOLUONG2,ISNULL(HHN.DONGIA/HH.QUYDOI1,0) AS SOLUONG3,HH.DONVITINHLON AS SOLUONG4,isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0) AS SOLUONG5,FLOOR(ISNULL(SUM(hhn.SOLUONGQUYDOI)%hh.QUYDOI1,0)) AS SOLUONG6,case when hh.DONVITINH!=hh.DONVITINHLON then CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN CAST(isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)as varchar)+' '+LOWER(hh.DONVITINH)ELSE '' END \r\n+CAST(FLOOR(SUM(hhn.SOLUONGQUYDOI)%hh.QUYDOI1) AS VARCHAR(2)) +LOWER(hh.DONVITINHLON)\r\nelse cast((replace(convert (varchar, convert (money, convert (money,ISNULL(SUM(hhn.SOLUONGQUYDOI),0))/hh.quydoi1), 1), '.00','')) as varchar(10))+ LOWER(hh.DONVITINH) end as SOLUONGTONG\r\n,'0' AS SOLUONGLE,(HHN.DONGIA/hh.QUYDOI1)*SUM(HHN.SOLUONGQUYDOI) as thanhtien,HHN.NGAYNHAP,HHN.MAHOADON FROM TB_HANGHOA HH, TB_HANGHOANHAP HHN,TB_KHACHHANG KH  WHERE KH.MAKHACHHANG=HHN.NCC AND HHN.MALOAI='1' AND HH.MAHANGHOA=HHN.MAHANGHOA AND CONVERT(DATETIME,HHN.NGAYNHAP,103)>= '",
            //    text,
            //    "' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)<='",
            //    text2,
            //    "' AND KH.NCC='",
            //    this.txtmakh.Text,
            //    "' GROUP BY hhn.GHICHU,KH.TENDONVI,HH.MAHANGHOA,HH.TENHANGHOA,HH.DONVITINH,HH.QUYDOI1,HHN.DONGIA,HHN.MAHOADON,HHN.NGAYNHAP,HH.DONVITINHLON) INSERT INTO [DATASHOP].[dbo].[TB_HANGHOANHAP_BC] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[DONGIA] ,[TENDONVI] ,[SOLUONG] ,[SOLUONG2] ,[SOLUONG3] ,[SOLUONG4] ,[SOLUONG5] ,[SOLUONG6] ,[SOLUONGTONG] ,[SOLUONGLE] ,[THANHTIEN] ,[NGAYNHAP] ,[MAHOADON])  (SELECT NL.MAHANGHOA,NL.TENHANGHOA +' - ' + hhn.GHICHU,NL.DONVITINH,HHN.DONGIA,KH.TENDONVI,HHN.SOLUONG,'0',HHN.DONGIA,NL.DONVITINH,HHN.SOLUONG,'0',CAST(HHN.SOLUONG as varchar)+LOWER(NL.DONVITINH),'0',DONGIA*SOLUONG,NGAYNHAP,MAHOADON  FROM TB_NGUYENLIEU NL, TB_HANGHOANHAP_NL HHN ,TB_KHACHHANG KH WHERE KH.MAKHACHHANG=HHN.NCC AND NL.MAHANGHOA=HHN.MAHANGHOA AND MALOAI='1' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)>= '",
            //    text,
            //    "' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)<='",
            //    text2,
            //    "' AND KH.NCC='",
            //    this.txtmakh.Text,
            //    "' ) SELECT TENDONVI,NGAYNHAP,MAHANGHOA,TENHANGHOA,DONVITINH,DONGIA,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,SOLUONGLE,THANHTIEN,MAHOADON FROM TB_HANGHOANHAP_BC ORDER BY CONVERT(DATETIME,NGAYNHAP,103),TENDONVI"
            //});
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvnhomdonvi.DataSource = dataTable;
            //this.dgvnhomdonvi.BringToFront();
        }

        // Token: 0x06000838 RID: 2104 RVA: 0x001566E4 File Offset: 0x001548E4
        private void chitietnhap_nhomnhacungcap_cotienmat()
        {
            //string text = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
            //string text2 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_HANGHOANHAP_BC INSERT INTO [DATASHOP].[dbo].[TB_HANGHOANHAP_BC] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[DONGIA] ,[TENDONVI] ,[SOLUONG] ,[SOLUONG2] ,[SOLUONG3] ,[SOLUONG4] ,[SOLUONG5] ,[SOLUONG6] ,[SOLUONGTONG] ,[SOLUONGLE] ,[THANHTIEN] ,[NGAYNHAP] ,[MAHOADON]) (SELECT HH.MAHANGHOA,HH.TENHANGHOA+ '- ' +hhn.GHICHU ,CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN HH.DONVITINH ELSE HH.DONVITINHLON END AS DONVITINH,CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN HHN.DONGIA ELSE HHN.DONGIA/HH.QUYDOI1 END AS DONGIA,KH.TENDONVI as tendonvi ,ISNULL(SUM(HHN.SOLUONG),0) AS SOLUONG,ISNULL(SUM(HHN.SOLUONG2),0) AS SOLUONG2,ISNULL(HHN.DONGIA/HH.QUYDOI1,0) AS SOLUONG3,HH.DONVITINHLON AS SOLUONG4,isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0) AS SOLUONG5,FLOOR(ISNULL(SUM(hhn.SOLUONGQUYDOI)%hh.QUYDOI1,0)) AS SOLUONG6,case when hh.DONVITINH!=hh.DONVITINHLON then CASE WHEN isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)>0 THEN CAST(isnull(FLOOR(SUM(hhn.SOLUONGQUYDOI)/hh.QUYDOI1),0)as varchar)+' '+LOWER(hh.DONVITINH)ELSE '' END \r\n+CAST(FLOOR(SUM(hhn.SOLUONGQUYDOI)%hh.QUYDOI1) AS VARCHAR(2)) +LOWER(hh.DONVITINHLON)\r\nelse cast((replace(convert (varchar, convert (money, convert (money,ISNULL(SUM(hhn.SOLUONGQUYDOI),0))/hh.quydoi1), 1), '.00','')) as varchar(10))+ LOWER(hh.DONVITINH) end as SOLUONGTONG\r\n,'0' AS SOLUONGLE,CASE WHEN HHN.MALOAI='1' THEN(HHN.DONGIA/hh.QUYDOI1)*SUM(HHN.SOLUONGQUYDOI)ELSE '0' END as thanhtien,HHN.NGAYNHAP,HHN.MAHOADON FROM TB_HANGHOA HH, TB_HANGHOANHAP HHN,TB_KHACHHANG KH  WHERE KH.MAKHACHHANG=HHN.NCC AND HH.MAHANGHOA=HHN.MAHANGHOA AND CONVERT(DATETIME,HHN.NGAYNHAP,103)>= '",
            //    text,
            //    "' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)<='",
            //    text2,
            //    "' AND KH.NCC='",
            //    this.txtmakh.Text,
            //    "' GROUP BY HHN.MALOAI,hhn.GHICHU,KH.TENDONVI,HH.MAHANGHOA,HH.TENHANGHOA,HH.DONVITINH,HH.QUYDOI1,HHN.DONGIA,HHN.MAHOADON,HHN.NGAYNHAP,HH.DONVITINHLON) INSERT INTO [DATASHOP].[dbo].[TB_HANGHOANHAP_BC] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[DONGIA] ,[TENDONVI] ,[SOLUONG] ,[SOLUONG2] ,[SOLUONG3] ,[SOLUONG4] ,[SOLUONG5] ,[SOLUONG6] ,[SOLUONGTONG] ,[SOLUONGLE] ,[THANHTIEN] ,[NGAYNHAP] ,[MAHOADON])  (SELECT NL.MAHANGHOA,NL.TENHANGHOA +' - ' + hhn.GHICHU,NL.DONVITINH,HHN.DONGIA,KH.TENDONVI,HHN.SOLUONG,'0',HHN.DONGIA,NL.DONVITINH,HHN.SOLUONG,'0',CAST(HHN.SOLUONG as varchar)+LOWER(NL.DONVITINH),'0',CASE WHEN HHN.MALOAI='1' THEN DONGIA*SOLUONG ELSE '0' END ,NGAYNHAP,MAHOADON  FROM TB_NGUYENLIEU NL, TB_HANGHOANHAP_NL HHN ,TB_KHACHHANG KH WHERE KH.MAKHACHHANG=HHN.NCC AND NL.MAHANGHOA=HHN.MAHANGHOA AND MALOAI='1' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)>= '",
            //    text,
            //    "' AND CONVERT(DATETIME,HHN.NGAYNHAP,103)<='",
            //    text2,
            //    "' AND KH.NCC='",
            //    this.txtmakh.Text,
            //    "' ) SELECT TENDONVI,NGAYNHAP,MAHANGHOA,TENHANGHOA,DONVITINH,DONGIA,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,SOLUONGLE,THANHTIEN,MAHOADON FROM TB_HANGHOANHAP_BC ORDER BY CONVERT(DATETIME,NGAYNHAP,103),TENDONVI,THANHTIEN"
            //});
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvnhomdonvi.DataSource = dataTable;
            //this.dgvnhomdonvi.BringToFront();
        }

        // Token: 0x06000839 RID: 2105 RVA: 0x00156818 File Offset: 0x00154A18
        private void Frmcongnophaitra_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.dttungay.Text = DateTime.Now.ToString("01/MM/yyyy");
            this.dtdenngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.cobdk.SelectedIndex = 0;
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height - 20);
            this.btbaocao_Click(null, null);
        }

        // Token: 0x0600083A RID: 2106 RVA: 0x001568C4 File Offset: 0x00154AC4
        private void dttungay_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtdenngay.Value < this.dttungay.Value)
            {
                this.dtdenngay.Value = this.dttungay.Value;
            }
        }

        // Token: 0x0600083B RID: 2107 RVA: 0x0015690C File Offset: 0x00154B0C
        private void dgvcongno_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dgvcongno.RowCount > 0)
                {
                    if (this.dgvcongno.CurrentRow.Index == this.dgvcongno.RowCount - 1)
                    {
                        decimal num = 0m;
                        decimal num2 = 0m;
                        decimal num3 = 0m;
                        decimal num4 = 0m;
                        decimal num5 = 0m;
                        this.dgvcongno.AllowUserToAddRows = false;
                        for (int i = 0; i < this.dgvcongno.RowCount - 1; i++)
                        {
                            num += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString());
                            num2 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["tradauky"].Value.ToString());
                            num3 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["notrongky"].Value.ToString());
                            num4 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["tratrongky"].Value.ToString());
                            num5 += Convert.ToDecimal(this.dgvcongno.Rows[i].Cells["conno"].Value.ToString());
                        }
                        int num6 = this.dgvcongno.Rows.Count - 1;
                        this.dgvcongno["makh", num6].Value = "Total:";
                        this.dgvcongno["nodauky", num6].Value = num;
                        this.dgvcongno["tradauky", num6].Value = num2;
                        this.dgvcongno["notrongky", num6].Value = num3;
                        this.dgvcongno["tratrongky", num6].Value = num4;
                        this.dgvcongno["conno", num6].Value = num5;
                        this.dgvcongno.Rows[num6].DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600083C RID: 2108 RVA: 0x00156BE4 File Offset: 0x00154DE4
        private void txtdk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtdk.Text != "")
                {
                    double num = double.Parse(this.txtdk.Text);
                    if (num > 999.0)
                    {
                        this.txtdk.Text = num.ToString("#,###");
                    }
                    this.txtdk.SelectionStart = this.txtdk.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600083D RID: 2109 RVA: 0x00156C80 File Offset: 0x00154E80
        private void dgvcongno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvcongno.Rows.Count - 1 > 0)
                {
                    int index = this.dgvcongno.CurrentRow.Index;
                    if (this.dgvcongno.Rows[index].Cells["MAKH"].Value != null)
                    {
                        this.txtmakh.Text = this.dgvcongno.Rows[index].Cells["MAKH"].Value.ToString();
                    }
                    this.btdoichi_Click(null, null);
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600083E RID: 2110 RVA: 0x00156D44 File Offset: 0x00154F44
        private void dgvchitiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvchitiet.RowCount > 0)
            {
                if (this.dgvchitiet.CurrentRow.Index == this.dgvchitiet.RowCount - 1)
                {
                    decimal d = 0m;
                    decimal num = 0m;
                    this.dgvchitiet.AllowUserToAddRows = false;
                    for (int i = 0; i < this.dgvchitiet.RowCount - 1; i++)
                    {
                        d += Convert.ToDecimal(this.dgvchitiet.Rows[i].Cells["no"].Value.ToString());
                        num += Convert.ToDecimal(this.dgvchitiet.Rows[i].Cells["tra"].Value.ToString());
                        this.dgvchitiet.Rows[i].Cells[0].Value = i + 1;
                    }
                    int num2 = this.dgvchitiet.Rows.Count - 1;
                    decimal num3 = d - num;
                    if (num3 > 0m)
                    {
                        this.dgvchitiet["no", num2].Value = num3;
                        this.dgvchitiet["tra", num2].Value = "0";
                        this.dgvchitiet["ngaychungtu", num2].Value = "NỢ CUỐI KỲ";
                    }
                    else
                    {
                        this.dgvchitiet["no", num2].Value = "0";
                        this.dgvchitiet["tra", num2].Value = num3;
                        this.dgvchitiet["ngaychungtu", num2].Value = "DƯ CUỐI KỲ";
                    }
                    this.dgvchitiet.Rows[num2].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }

        // Token: 0x0600083F RID: 2111 RVA: 0x00156F78 File Offset: 0x00155178
        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.cong = 0m;
        //        this.tongcong = 0m;
        //        this.congdauky = 0m;
        //        this.lan = 0;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //    }
        //    int letrai = this.chObj.Letrai;
        //    int num = int.Parse(this.chObj.Canhle);
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num2 = 0;
        //    int num3 = 40;
        //    if (this.lan == 0)
        //    {
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 50));
        //        int num4 = num + 100;
        //        e.Graphics.DrawString("BẢNG KÊ CÔNG NỢ PHẢI TRẢ NHÀ CUNG CẤP", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(500 + letrai, num4 - 25), stringFormat);
        //        e.Graphics.DrawString("Từ: " + this.dttungay.Text + " - " + this.dtdenngay.Text, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(500 + letrai, num4), stringFormat);
        //        num2 = num4 + 25;
        //    }
        //    else
        //    {
        //        int num4 = num - 5;
        //        num2 = num;
        //    }
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num2 + 7));
        //    e.Graphics.DrawString("Mã KH", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(50 + letrai, num2 + 7));
        //    e.Graphics.DrawString("Khách Hàng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(290 + letrai, num2 + 7), stringFormat);
        //    e.Graphics.DrawString("Nợ đầu kỳ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(655 + letrai, num2 + 7), stringFormat2);
        //    e.Graphics.DrawString("Nợ trong kỳ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(760 + letrai, num2 + 7), stringFormat2);
        //    e.Graphics.DrawString("Trả trong kỳ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(870 + letrai, num2 + 7), stringFormat2);
        //    e.Graphics.DrawString("Còn nợ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(960 + letrai, num2 + 7), stringFormat2);
        //    int num5 = num2 + 40;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 980f, 40f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvcongno.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > this.sodong)
        //        {
        //            this.lan = 1;
        //            this.sodong = 24;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvcongno.Rows.Count)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num5 - 5), 980f, 25f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            if (this.dgvcongno.Rows[i].Cells["KHACHHANG"].Value != null)
        //            {
        //                using (Font font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(140 + letrai), (float)num5, 430f, 25f);
        //                    e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["KHACHHANG"].Value.ToString(), font, Brushes.Black, rectangleF);
        //                }
        //            }
        //            string s;
        //            if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString()) > 999.0)
        //            {
        //                s = Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s = this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString();
        //            }
        //            if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["tradauky"].Value.ToString()) > 999.0)
        //            {
        //                string text = Convert.ToDouble(this.dgvcongno.Rows[i].Cells["tradauky"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                string text = this.dgvcongno.Rows[i].Cells["tradauky"].Value.ToString();
        //            }
        //            string s2;
        //            if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["notrongky"].Value.ToString()) > 999.0)
        //            {
        //                s2 = Convert.ToDouble(this.dgvcongno.Rows[i].Cells["notrongky"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s2 = this.dgvcongno.Rows[i].Cells["notrongky"].Value.ToString();
        //            }
        //            string s3;
        //            if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["tratrongky"].Value.ToString()) > 999.0)
        //            {
        //                s3 = Convert.ToDouble(this.dgvcongno.Rows[i].Cells["tratrongky"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s3 = this.dgvcongno.Rows[i].Cells["tratrongky"].Value.ToString();
        //            }
        //            string s4;
        //            if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["conno"].Value.ToString()) > 999.0)
        //            {
        //                s4 = Convert.ToDouble(this.dgvcongno.Rows[i].Cells["conno"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s4 = this.dgvcongno.Rows[i].Cells["conno"].Value.ToString();
        //            }
        //            if (this.dgvcongno.Rows[i].Cells["STT"].Value != null)
        //            {
        //                e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + letrai, num5), stringFormat);
        //            }
        //            if (this.dgvcongno.Rows[i].Cells["Makh"].Value != null)
        //            {
        //                e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["Makh"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(40 + letrai, num5));
        //            }
        //            e.Graphics.DrawString(s, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(s2, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(775 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(s3, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(870 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(s4, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(979 + letrai, num5), stringFormat2);
        //            num3 += 25;
        //            num5 += 25;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 30f, (float)num3);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(139 + letrai), (float)(num2 - 5), 421f, (float)num3);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(560 + letrai), (float)(num2 - 5), 110f, (float)num3);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(778 + letrai), (float)(num2 - 5), 100f, (float)num3);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //    }
        //    e.Graphics.DrawString(string.Concat(new string[]
        //    {
        //        "Ngày  ",
        //        DateTime.Now.ToString("dd"),
        //        "  tháng  ",
        //        DateTime.Now.ToString("MM"),
        //        "   năm  ",
        //        DateTime.Now.ToString("yyyy")
        //    }), new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(870 + letrai, num5), stringFormat2);
        //    e.Graphics.DrawString(this.chObj.Diachi2, new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(500 + letrai, num5 + 20), stringFormat);
        //    this.xem = 1;
        //}

        // Token: 0x06000840 RID: 2112 RVA: 0x00157DF0 File Offset: 0x00155FF0
        private void btin_Click(object sender, EventArgs e)
        {
            this.loadcauhinh();
            this.loadmayin();
            this.xem = 0;
            this.xem = 0;
            this.cong = 0m;
            this.tongcong = 0m;
            this.congdauky = 0m;
            this.lan = 0;
            this.numberOfItemsPrintedSoFar = 0;
            this.numberOfItemsPerPage = 0;
            if (this.chitiet == 1)
            {
                if (this.dgvcongno.RowCount > 0)
                {
                    if (this.txtmakh.Text != "")
                    {
                        this.sodong = int.Parse(this.txtsd.Text);
                        new PrintPreviewDialog
                        {
                            Document = this.printDocument2,
                            WindowState = FormWindowState.Maximized,
                            PrintPreviewControl =
                            {
                                Zoom = 1.2
                            }
                        }.ShowDialog();
                    }
                    else
                    {
                        this.sodong = int.Parse(this.txtsd.Text);
                        this.printDocument1.DefaultPageSettings.Landscape = true;
                        new PrintPreviewDialog
                        {
                            Document = this.printDocument1,
                            WindowState = FormWindowState.Maximized,
                            PrintPreviewControl =
                            {
                                Zoom = 1.2
                            }
                        }.ShowDialog();
                    }
                }
            }
            else if (this.chitiet == 0)
            {
                this.sodong = int.Parse(this.txtsd.Text);
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = this.print_dc;
                this.print_dc.DefaultPageSettings.Landscape = true;
                printPreviewDialog.WindowState = FormWindowState.Maximized;
                printPreviewDialog.PrintPreviewControl.Zoom = 1.2;
                printPreviewDialog.ShowDialog();
            }
            this.chitiet = 1;
        }

        // Token: 0x06000841 RID: 2113 RVA: 0x00157FCC File Offset: 0x001561CC
        //private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.cong = 0m;
        //        this.tongcong = 0m;
        //        this.congdauky = 0m;
        //        this.lan = 0;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //    }
        //    int letrai = this.chObj.Letrai;
        //    int num = int.Parse(this.chObj.Canhle);
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num2 = 0;
        //    int num3 = 40;
        //    if (this.lan == 0)
        //    {
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 50));
        //        int num4 = num + 100;
        //        e.Graphics.DrawString("BẢNG KÊ CHI TIẾT CÔNG NỢ", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(370 + letrai, num4 - 25), stringFormat);
        //        e.Graphics.DrawString("Từ: " + this.dttungay.Text + " - " + this.dtdenngay.Text, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(370 + letrai, num4), stringFormat);
        //        num2 = num4 + 25;
        //    }
        //    else
        //    {
        //        int num4 = num - 5;
        //        num2 = num;
        //    }
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num2 + 7));
        //    e.Graphics.DrawString("Số chứng từ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(40 + letrai, num2 + 7));
        //    e.Graphics.DrawString("Nội dung", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(320 + letrai, num2 + 7), stringFormat);
        //    e.Graphics.DrawString("NỢ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(523 + letrai, num2 + 7), stringFormat2);
        //    e.Graphics.DrawString("TRẢ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(635 + letrai, num2 + 7), stringFormat2);
        //    e.Graphics.DrawString("Ghi Chú", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(760 + letrai, num2 + 7), stringFormat2);
        //    int num5 = num2 + 40;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 780f, 40f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvchitiet.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > 28)
        //        {
        //            this.lan = 1;
        //            this.sodong = 34;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 30f, (float)num3);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(135 + letrai), (float)(num2 - 5), 325f, (float)num3);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(460 + letrai), (float)(num2 - 5), 100f, (float)num3);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(560 + letrai), (float)(num2 - 5), 110f, (float)num3);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvchitiet.Rows.Count)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + letrai), (float)(num5 - 5), 780f, 25f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            string s;
        //            if (Convert.ToDouble(this.dgvchitiet.Rows[i].Cells["no"].Value.ToString()) > 999.0)
        //            {
        //                s = Convert.ToDouble(this.dgvchitiet.Rows[i].Cells["no"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s = this.dgvchitiet.Rows[i].Cells["no"].Value.ToString();
        //            }
        //            string s2;
        //            if (Convert.ToDouble(this.dgvchitiet.Rows[i].Cells["tra"].Value.ToString()) > 999.0)
        //            {
        //                s2 = Convert.ToDouble(this.dgvchitiet.Rows[i].Cells["tra"].Value.ToString()).ToString("#,###");
        //            }
        //            else
        //            {
        //                s2 = this.dgvchitiet.Rows[i].Cells["tra"].Value.ToString();
        //            }
        //            if (this.dgvchitiet.Rows[i].Cells["t"].Value != null)
        //            {
        //                e.Graphics.DrawString(this.dgvchitiet.Rows[i].Cells["t"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + letrai, num5), stringFormat);
        //            }
        //            if (this.dgvchitiet.Rows[i].Cells["mct"].Value != null)
        //            {
        //                e.Graphics.DrawString(this.dgvchitiet.Rows[i].Cells["mct"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(40 + letrai, num5));
        //            }
        //            if (this.dgvchitiet.Rows[i].Cells["ngaychungtu"].Value != null)
        //            {
        //                e.Graphics.DrawString(this.dgvchitiet.Rows[i].Cells["ngaychungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(140 + letrai, num5));
        //            }
        //            e.Graphics.DrawString(s2, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(670 + letrai, num5), stringFormat2);
        //            e.Graphics.DrawString(s, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(560 + letrai, num5), stringFormat2);
        //            num3 += 25;
        //            num5 += 25;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + letrai), (float)(num2 - 5), 30f, (float)num3);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(135 + letrai), (float)(num2 - 5), 325f, (float)num3);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(460 + letrai), (float)(num2 - 5), 100f, (float)num3);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(560 + letrai), (float)(num2 - 5), 110f, (float)num3);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    e.Graphics.DrawString(string.Concat(new string[]
        //    {
        //        "Ngày  ",
        //        DateTime.Now.ToString("dd"),
        //        "  tháng  ",
        //        DateTime.Now.ToString("MM"),
        //        "   năm  ",
        //        DateTime.Now.ToString("yyyy")
        //    }), new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(700 + letrai, num5), stringFormat2);
        //    e.Graphics.DrawString(this.chObj.Diachi2, new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(370 + letrai, num5 + 20), stringFormat);
        //    this.xem = 1;
        //}

        // Token: 0x06000842 RID: 2114 RVA: 0x00158CDC File Offset: 0x00156EDC
        private void dgvchitietnhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvchitietnhap.RowCount; i++)
            {
                this.dgvchitietnhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000843 RID: 2115 RVA: 0x00158D30 File Offset: 0x00156F30
        private void btdoichi_Click(object sender, EventArgs e)
        {
            //this.chitiet = 0;
            //this.tongtra = 0m;
            //if (this.txtmakh.Text != "")
            //{
            //    DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //    DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //    string text = dateTime.ToString("MM/dd/yyyy");
            //    string text2 = dateTime2.ToString("MM/dd/yyyy");
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    this.congdauky = 0m;
            //    this.txtnodauky.Text = "0";
            //    DataTable dataTable = new DataTable();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE TB_CHITIETPHAITRA WHERE DAUKY!='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=(ISNULL((SELECT SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC='",
            //        this.txtmakh.Text,
            //        "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //        text,
            //        "'),0)+ISNULL((SELECT SUM((HN.DONGIA)*HN.SOLUONGQUYDOI) AS TONGTIEN  FROM TB_HANGHOANHAP_NL HN WHERE HN.NCC='",
            //        this.txtmakh.Text,
            //        "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //        text,
            //        "'),0)+ISNULL((SELECT SUM(ISNULL(SOTIENTRA,0)) FROM TB_TONDAUKY WHERE MaKH='",
            //        this.txtmakh.Text,
            //        "' AND MA='TRA'),0))-ISNULL(( SELECT SUM(TIENTRANO) FROM Tb_THUCHI WHERE MaKH='",
            //        this.txtmakh.Text,
            //        "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //        text,
            //        "'),0),TRA='0' WHERE DAUKY='TRUE' select ISNULL(NO,0) from TB_CHITIETPHAITRA WHERE DAUKY='TRUE'"
            //    });
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.txtnodauky.Text = dataTable.Rows[0][0].ToString();
            //    this.chitietnhap();
            //    if (this.dgvchitietnhap.RowCount > 0)
            //    {
            //        this.button6_Click(null, null);
            //    }
            //}
        }

        // Token: 0x06000844 RID: 2116 RVA: 0x00158F10 File Offset: 0x00157110
        //private void print_dc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.sodong = int.Parse(this.txtsd.Text);
        //        this.xem = 0;
        //        this.cong = 0m;
        //        this.tongcong = 0m;
        //        this.congdauky = 0m;
        //        this.lan = 0;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.tongtientra = 0m;
        //    }
        //    int num = 5;
        //    int num2 = int.Parse(Settings.Default.letrai);
        //    int num3 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num4 = 0;
        //    int num5 = 40;
        //    if (this.lan == 0)
        //    {
        //        this.sodong = int.Parse(this.textBox7.Text);
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //        int num6 = num3 + num + 75 + 25;
        //        e.Graphics.DrawString("CHI TIẾT CÔNG NỢ PHẢI TRẢ THEO MẶT HÀNG", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num6 - 25), stringFormat);
        //        num6 += 25;
        //        e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(500 + num2, num6 - 25), stringFormat);
        //        e.Graphics.DrawString("NCC: " + this.txttenkh.Text, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num6));
        //        e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(700 + num2, num3 + num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(700 + num2, num3 + num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(700 + num2, num3 + num + 45), stringFormat);
        //        num5 = 40;
        //        num4 = num6 + 25;
        //        this.congdauky = Convert.ToDecimal(this.txtnodauky.Text);
        //    }
        //    else
        //    {
        //        num4 = num3;
        //        num5 = 40;
        //    }
        //    e.Graphics.DrawString("Ngày nhập", new Font("Arial Narrow", 10f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num4 + 7));
        //    e.Graphics.DrawString("Số HĐ", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(90 + num2, num4 + 7));
        //    e.Graphics.DrawString("Mặt hàng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num2, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("Đơn vị", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(458 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("tính", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(458 + num2, num4 + 15), stringFormat);
        //    e.Graphics.DrawString("Số", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(520 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("lượng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(520 + num2, num4 + 15), stringFormat);
        //    e.Graphics.DrawString("Đơn giá", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(629 + num2, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Thành tiền", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(760 + num2, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Số tiền trả", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(880 + num2, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Nợ cuối kỳ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(1000 + num2, num4 + 7), stringFormat2);
        //    int num7 = num4 + 40;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 1020f, 40f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    if (this.txtnodauky.Text != "0")
        //    {
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        e.Graphics.DrawString("Nợ đầu kỳ", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(148 + num2, num7));
        //        e.Graphics.DrawString(Convert.ToDecimal(this.txtnodauky.Text).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //        num7 += 25;
        //        num5 += 25;
        //    }
        //    this.tongtientra = 0m;
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvchitietnhap.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > this.sodong)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 280f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            this.lan = 1;
        //            this.sodong = int.Parse(this.textBox7.Text) + 4;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvchitietnhap.Rows.Count)
        //        {
        //            if (i == 0)
        //            {
        //                this.tongtra = 0m;
        //                this.ngaytra1 = this.dttungay.Text;
        //                this.ngaytra2 = this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //                DataTable dataTable = new DataTable();
        //                string cmdText = string.Concat(new string[]
        //                {
        //                    "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //                    this.txtmakh.Text,
        //                    "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>'00:00 ",
        //                    Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //                    "' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //                    Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //                    "'"
        //                });
        //                SqlConnection sqlConnection = new SqlConnection();
        //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //                SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //                sqlConnection.Open();
        //                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //                sqlDataAdapter.Fill(dataTable);
        //                this.dgvdathu.DataSource = dataTable;
        //                sqlConnection.Close();
        //                if (this.dgvdathu.RowCount > 0)
        //                {
        //                    for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //                    {
        //                        this.numberOfItemsPerPage++;
        //                        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                        {
        //                            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //                            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                        }
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + " " + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7 + 2));
        //                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7 + 2), stringFormat2);
        //                        this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //                        num7 += 25;
        //                        num5 += 25;
        //                    }
        //                    this.tongtientra += this.tongtra;
        //                }
        //                e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //                e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //                this.ngaytra1 = this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //            }
        //            else if (i > 0 && this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString() != this.dgvchitietnhap.Rows[i - 1].Cells["NGAYNHAP"].Value.ToString())
        //            {
        //                this.ngaytra2 = this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //                DataTable dataTable = new DataTable();
        //                string cmdText = string.Concat(new string[]
        //                {
        //                    "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //                    this.txtmakh.Text,
        //                    "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //                    Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //                    "' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //                    Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //                    "'"
        //                });
        //                SqlConnection sqlConnection = new SqlConnection();
        //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //                SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //                sqlConnection.Open();
        //                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //                sqlDataAdapter.Fill(dataTable);
        //                this.dgvdathu.DataSource = dataTable;
        //                sqlConnection.Close();
        //                if (this.dgvdathu.RowCount > 0)
        //                {
        //                    for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //                    {
        //                        this.numberOfItemsPerPage++;
        //                        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                        {
        //                            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //                            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                        }
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //                        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7));
        //                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7), stringFormat2);
        //                        this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //                        num7 += 25;
        //                    }
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 282f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                e.Graphics.DrawString("Cộng:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //                e.Graphics.DrawString((this.congdauky + this.cong).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7 + 2), stringFormat2);
        //                e.Graphics.DrawString(Convert.ToDecimal(this.tongtra).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(900 + num2, num7 + 2), stringFormat2);
        //                e.Graphics.DrawString((this.congdauky + this.cong - this.tongtra).ToString("#,##0"), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(1020 + num2, num7), stringFormat2);
        //                this.congdauky += this.cong - this.tongtra;
        //                this.cong = 0m;
        //                num5 = -25;
        //                this.txtnodauky.Text = "0";
        //                num7 += 25;
        //                num5 += 25;
        //                e.Graphics.DrawString(Convert.ToDateTime(this.dgvchitietnhap.Rows[i].Cells["ngaynhap"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //                e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial Narrow", 8f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //                num4 = num7;
        //                this.ngaytra1 = this.dgvchitietnhap.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //                this.tongtientra += this.tongtra;
        //                this.tongtra = 0m;
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            if (this.dgvchitietnhap.Rows[i].Cells["dvt"].Value.ToString() != this.dgvchitietnhap.Rows[i].Cells["g4"].Value.ToString())
        //            {
        //                if (Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g5"].Value.ToString()) > 0.0)
        //                {
        //                    using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //                    {
        //                        RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //                        e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //                    }
        //                    e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //                    e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g5"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //                    e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["giavon"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //                    e.Graphics.DrawString((Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["giavon"].Value.ToString()) * Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g5"].Value.ToString())).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //                    this.cong += Convert.ToDecimal(this.dgvchitietnhap.Rows[i].Cells["g5"].Value.ToString()) * Convert.ToDecimal(this.dgvchitietnhap.Rows[i].Cells["giavon"].Value.ToString());
        //                    if (i > 0 && this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString() != this.dgvchitietnhap.Rows[i - 1].Cells["mahoadon"].Value.ToString())
        //                    {
        //                        e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial Narrow", 8f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //                    }
        //                }
        //                else
        //                {
        //                    num7 += -30;
        //                    num5 -= 30;
        //                }
        //                if (Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g6"].Value.ToString()) > 0.0)
        //                {
        //                    num7 += 30;
        //                    num5 += 30;
        //                    if (i > 0 && this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString() != this.dgvchitietnhap.Rows[i - 1].Cells["mahoadon"].Value.ToString())
        //                    {
        //                        e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial Narrow", 8f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //                    }
        //                    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                    {
        //                        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //                        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                    }
        //                    using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //                    {
        //                        RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //                        e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //                    }
        //                    e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["g4"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //                    e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g6"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //                    e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g3"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //                    e.Graphics.DrawString((Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g3"].Value.ToString()) * Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g6"].Value.ToString())).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //                    this.cong += Convert.ToDecimal(this.dgvchitietnhap.Rows[i].Cells["g3"].Value.ToString()) * Convert.ToDecimal(this.dgvchitietnhap.Rows[i].Cells["g6"].Value.ToString());
        //                    this.tongcong = this.tongcong;
        //                }
        //            }
        //            else
        //            {
        //                using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //                    e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //                }
        //                e.Graphics.DrawString(this.dgvchitietnhap.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //                e.Graphics.DrawString((Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g5"].Value.ToString()) + Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["g6"].Value.ToString())).ToString("#,##0.##"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //                e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["giavon"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //                e.Graphics.DrawString(Convert.ToDouble(this.dgvchitietnhap.Rows[i].Cells["thanhtienct"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //                this.cong += Convert.ToDecimal(this.dgvchitietnhap.Rows[i].Cells["thanhtienct"].Value.ToString());
        //            }
        //            num7 += 30;
        //            num5 += 30;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //    }
        //    e.Graphics.DrawString("Cộng:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //    e.Graphics.DrawString(this.cong.ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7 + 2), stringFormat2);
        //    e.Graphics.DrawString(Convert.ToDecimal(this.tongtra).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(900 + num2, num7 + 2), stringFormat2);
        //    e.Graphics.DrawString((this.congdauky + this.cong - this.tongtra).ToString("#,##0"), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(1020 + num2, num7), stringFormat2);
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    num7 += 30;
        //    num5 += 30;
        //    this.ngaytra2 = this.dtdenngay.Text;
        //    DataTable dataTable2 = new DataTable();
        //    string cmdText2 = string.Concat(new string[]
        //    {
        //        "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //        this.txtmakh.Text,
        //        "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>'00:00 ",
        //        Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //        "' AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //        Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //        "'"
        //    });
        //    SqlConnection sqlConnection2 = new SqlConnection();
        //    sqlConnection2.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection2);
        //    sqlConnection2.Open();
        //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
        //    sqlDataAdapter2.Fill(dataTable2);
        //    this.dgvdathu.DataSource = dataTable2;
        //    if (this.dgvdathu.RowCount > 0)
        //    {
        //        this.tongtra = 0m;
        //        for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //        {
        //            this.numberOfItemsPerPage++;
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //            e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //            e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7));
        //            e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7), stringFormat2);
        //            this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //            num7 += 30;
        //        }
        //    }
        //    this.tongtientra = this.tongtra;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    num5 += 30;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 280f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    e.Graphics.DrawString("TỔNG CỘNG:", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num7));
        //    e.Graphics.DrawString((this.congdauky + this.cong).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString(this.tongtientra.ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(900 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString((this.congdauky + this.cong - this.tongtientra).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(1020 + num2, num7), stringFormat2);
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    this.xem = 1;
        //}

        // Token: 0x06000845 RID: 2117 RVA: 0x0015BED0 File Offset: 0x0015A0D0
        private void button1_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //PrintDocument printDocument = new PrintDocument();
            //printDialog.Document = printDocument;
            //DialogResult dialogResult = printDialog.ShowDialog();
            //this.loadcauhinh();
            //this.loadmayin();
            //this.xem = 0;
            //this.xem = 0;
            //this.cong = 0m;
            //this.tongcong = 0m;
            //this.congdauky = 0m;
            //this.lan = 0;
            //this.numberOfItemsPrintedSoFar = 0;
            //this.numberOfItemsPerPage = 0;
            //if (this.chitiet == 1)
            //{
            //    if (this.dgvcongno.RowCount > 0)
            //    {
            //        if (this.txtmakh.Text != "")
            //        {
            //            this.sodong = int.Parse(this.txtsd.Text);
            //            printDocument.PrintPage += this.printDocument2_PrintPage;
            //            if (dialogResult == DialogResult.OK)
            //            {
            //                printDocument.Print();
            //            }
            //        }
            //        else
            //        {
            //            this.sodong = int.Parse(this.txtsd.Text);
            //            printDocument.DefaultPageSettings.Landscape = true;
            //            printDocument.PrintPage += this.printDocument1_PrintPage;
            //            if (dialogResult == DialogResult.OK)
            //            {
            //                printDocument.Print();
            //            }
            //        }
            //    }
            //}
            //else if (this.chitiet == 0)
            //{
            //    this.txtnodauky.Text = this.nodauky.ToString();
            //    this.sodong = int.Parse(this.txtsd.Text);
            //    printDocument.PrintPage += this.print_dc_PrintPage;
            //    printDocument.DefaultPageSettings.Landscape = true;
            //    if (dialogResult == DialogResult.OK)
            //    {
            //        printDocument.Print();
            //    }
            //}
        }

        // Token: 0x06000846 RID: 2118 RVA: 0x0015C09C File Offset: 0x0015A29C
        private void button2_Click(object sender, EventArgs e)
        {
            //if (this.txtmakh.Text != "")
            //{
            //    frmThuChi.makhachhang = this.txtmakh.Text;
            //    frmThuChi.tenkhachhang = this.txttenkh.Text;
            //    frmThuChi.sophieu = 3;
            //    frmThuChi frmThuChi = new frmThuChi();
            //    frmThuChi.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn nhà cung cấp", "Thông báo");
            //}
        }

        // Token: 0x06000847 RID: 2119 RVA: 0x0015C110 File Offset: 0x0015A310
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.txtmakh.Text != "")
            {
                this.btbaocao_Click(null, null);
            }
        }

        // Token: 0x06000848 RID: 2120 RVA: 0x0001D102 File Offset: 0x0001B302
        private void textBox4_Enter(object sender, EventArgs e)
        {
            this.txtmakh.Focus();
        }

        // Token: 0x06000849 RID: 2121 RVA: 0x0015C148 File Offset: 0x0015A348
        private void xuatexcel_chitiet_nhomkhachhang()
        {
            //if (this.dgvnhomdonvi.RowCount > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETCONGNO_NHOMKHACHHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmcongnophaitra)));
            //    }
            //    Worksheet worksheet = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //    worksheet.Cells[2, 1] = this.chObj.Diachi;
            //    worksheet.Cells[3, 1] = this.chObj.Dienthoai;
            //    worksheet.Cells[5, 1] = "Từ " + this.dttungay.Text + " đến " + this.dtdenngay.Text;
            //    worksheet.Cells[6, 1] = "Đơn vị: " + this.txttenkh.Text;
            //    int num = 7;
            //    Range range;
            //    for (int i = 0; i < this.dgvnhomdonvi.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvnhomdonvi.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 8, j + 1] = this.dgvnhomdonvi.Rows[i].Cells[j].Value;
            //        }
            //        range = worksheet.get_Range("A" + num, "P" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 2] = "TỔNG CỘNG:";
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 16] = "=SUM(P7:P" + num + ")";
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 8] = "=SUM(H7:H" + num + ")";
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2.Target;
            //    CallSite<> p__Site = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Site, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3, worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 16]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target2 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4.Target;
            //    CallSite<> p__Site2 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target2(<> p__Site2, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5, worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 2]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target3 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6.Target;
            //    CallSite<> p__Site3 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target3(<> p__Site3, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgvnhomdonvi.RowCount + 8, 8]), true);
            //    int num2 = this.dgvnhomdonvi.RowCount + 8;
            //    num++;
            //    range = worksheet.get_Range("A" + num, "P" + num);
            //    range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 9, 2] = "NỢ ĐẦU KỲ:";
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 9, 16] = this.txtnodauky.Text;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target4 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8.Target;
            //    CallSite<> p__Site4 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target4(<> p__Site4, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9, worksheet.Cells[this.dgvnhomdonvi.RowCount + 9, 2]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitea == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitea = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target5 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitea.Target;
            //    CallSite<> p__Sitea = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitea;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Siteb == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target5(<> p__Sitea, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Siteb.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Siteb, worksheet.Cells[this.dgvnhomdonvi.RowCount + 9, 16]), true);
            //    int num3 = this.dgvnhomdonvi.RowCount + 9;
            //    num++;
            //    range = worksheet.get_Range("A" + num, "P" + num);
            //    range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 10, 2] = "ĐÃ TRẢ";
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 10, 16] = this.txttratrongky.Text;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitec == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitec = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target6 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitec.Target;
            //    CallSite<> p__Sitec = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitec;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sited == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sited = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target6(<> p__Sitec, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sited.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sited, worksheet.Cells[this.dgvnhomdonvi.RowCount + 10, 2]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitee == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitee = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target7 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitee.Target;
            //    CallSite<> p__Sitee = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitee;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitef == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitef = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target7(<> p__Sitee, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitef.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Sitef, worksheet.Cells[this.dgvnhomdonvi.RowCount + 10, 16]), true);
            //    int num4 = this.dgvnhomdonvi.RowCount + 10;
            //    num++;
            //    range = worksheet.get_Range("A" + num, "P" + num);
            //    range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 2] = "NỢ CÒN LẠI:";
            //    worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 16] = string.Concat(new object[]
            //    {
            //        "=SUM(P",
            //        num2,
            //        "+P",
            //        num3,
            //        "-P",
            //        num4,
            //        ")"
            //    });
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site10 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site10 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target8 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site10.Target;
            //    CallSite<> p__Site5 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site10;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site11 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target8(<> p__Site5, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site11.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site11, worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 2]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site12 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site12 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target9 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site12.Target;
            //    CallSite<> p__Site6 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site12;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site13 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site13 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target9(<> p__Site6, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site13.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site13, worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 16]), true);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site14 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site14 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Size", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, int, object> target10 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site14.Target;
            //    CallSite<> p__Site7 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site14;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site15 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target10(<> p__Site7, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site15.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site15, worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 16]), 16);
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site16 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site16 = CallSite<Func<CallSite, object, Color, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Color", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
            //        }));
            //    }
            //    Func<CallSite, object, Color, object> target11 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site16.Target;
            //    CallSite<> p__Site8 = Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site16;
            //    if (Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site17 == null)
            //    {
            //        Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site17 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmcongnophaitra), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target11(<> p__Site8, Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site17.Target(Frmcongnophaitra.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site17, worksheet.Cells[this.dgvnhomdonvi.RowCount + 11, 16]), Color.Red);
            //    num++;
            //    range = worksheet.get_Range("A" + num, "P" + num);
            //    range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    Range range2 = worksheet.get_Range("B" + 8, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("D" + 8, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 8, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("H" + 8, "H" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("P" + 8, "P" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //}
        }

        // Token: 0x0600084A RID: 2122 RVA: 0x0015D1D8 File Offset: 0x0015B3D8
        private void button4_Click(object sender, EventArgs e)
        {
            //if (this.lanhacungcap == "")
            //{
            //    Frmnhomkhachhang frmnhomkhachhang = new Frmnhomkhachhang();
            //    frmnhomkhachhang.ShowDialog();
            //    this.txtmakh.Text = Frmnhomkhachhang.madonvi;
            //    this.txttenkh.Text = Frmnhomkhachhang.tendonvi;
            //    this.lanhacungcap = Frmnhomkhachhang.nhomkhachhang;
            //}
            //if (this.txtmakh.Text != "")
            //{
            //    this.chitiet = 0;
            //    this.tongtra = 0m;
            //    DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //    DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //    string text = dateTime.ToString("MM/dd/yyyy");
            //    string text2 = dateTime2.ToString("MM/dd/yyyy");
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    this.congdauky = 0m;
            //    this.txtnodauky.Text = "0";
            //    DataTable dataTable = new DataTable();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE TB_CHITIETPHAITRA WHERE DAUKY!='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=(ISNULL((SELECT SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH, TB_KHACHHANG KH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC=KH.MAKHACHHANG AND KH.NCC='",
            //        this.txtmakh.Text,
            //        "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //        text,
            //        "'),0)+ISNULL((SELECT SUM((HN.DONGIA)*HN.SOLUONGQUYDOI) AS TONGTIEN  FROM TB_HANGHOANHAP_NL HN, TB_KHACHHANG KH WHERE KH.MAKHACHHANG=HN.NCC AND KH.NCC='",
            //        this.txtmakh.Text,
            //        "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //        text,
            //        "'),0)+ISNULL((SELECT SUM(ISNULL(SOTIENTRA,0)) FROM TB_TONDAUKY TD, TB_KHACHHANG KH WHERE TD.MaKH =KH.MAKHACHHANG AND KH.NCC='",
            //        this.txtmakh.Text,
            //        "' AND MA='TRA'),0))-ISNULL(( SELECT SUM(TIENTRANO) FROM Tb_THUCHI TC , TB_KHACHHANG KH WHERE TC.MaKH=KH.MAKHACHHANG AND KH.NCC='",
            //        this.txtmakh.Text,
            //        "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //        text,
            //        "'),0),TRA='0' WHERE DAUKY='TRUE' select ISNULL(NO,0) from TB_CHITIETPHAITRA WHERE DAUKY='TRUE'"
            //    });
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.txtnodauky.Text = dataTable.Rows[0][0].ToString();
            //    sqlConnection.Close();
            //    DataTable dataTable2 = new DataTable();
            //    string cmdText2 = string.Concat(new string[]
            //    {
            //        "SELECT ISNULL(SUM(TIENTRANO),0) FROM Tb_THUCHI TC , TB_KHACHHANG KH WHERE TC.MaKH=KH.MAKHACHHANG AND KH.NCC='",
            //        this.txtmakh.Text,
            //        "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //        text,
            //        "' AND CONVERT(DATETIME,NGAY,103)<'23:59 ",
            //        text2,
            //        "'"
            //    });
            //    SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
            //    sqlDataAdapter2.Fill(dataTable2);
            //    this.txttratrongky.Text = dataTable2.Rows[0][0].ToString();
            //    sqlConnection.Close();
            //    this.chitietnhap_nhomnhacungcap();
            //    if (this.dgvnhomdonvi.RowCount > 0)
            //    {
            //        for (int i = 1; i < this.dgvnhomdonvi.RowCount; i++)
            //        {
            //            this.dgvnhomdonvi.Rows[i].Cells[0].Value = i;
            //        }
            //        this.loadcauhinh();
            //        this.xuatexcel_chitiet_nhomkhachhang();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("BẠN CHƯA CHỌN NHÓM ĐƠN VỊ", "Thông Báo");
            //}
        }

        // Token: 0x0600084B RID: 2123 RVA: 0x0015D520 File Offset: 0x0015B720
        //private void nhomnhacungcap_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    //if (this.xem != 0)
        //    //{
        //    //    this.sodong = int.Parse(this.txtsd.Text);
        //    //    this.xem = 0;
        //    //    this.cong = 0m;
        //    //    this.tongcong = 0m;
        //    //    this.congdauky = 0m;
        //    //    this.lan = 0;
        //    //    this.numberOfItemsPrintedSoFar = 0;
        //    //    this.numberOfItemsPerPage = 0;
        //    //}
        //    //int num = 5;
        //    //int num2 = int.Parse(Settings.Default.letrai);
        //    //int num3 = 5;
        //    //StringFormat stringFormat = new StringFormat();
        //    //stringFormat.Alignment = StringAlignment.Center;
        //    //StringFormat stringFormat2 = new StringFormat();
        //    //stringFormat2.Alignment = StringAlignment.Far;
        //    //int num4 = 0;
        //    //int num5 = 40;
        //    //if (this.lan == 0)
        //    //{
        //    //    this.sodong = int.Parse(this.txtsd.Text);
        //    //    e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //    //    e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //    //    e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //    //    int num6 = num3 + num + 75 + 25;
        //    //    e.Graphics.DrawString("CHI TIẾT CÔNG NỢ PHẢI TRẢ THEO MẶT HÀNG", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num6 - 25), stringFormat);
        //    //    num6 += 25;
        //    //    e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(500 + num2, num6 - 25), stringFormat);
        //    //    e.Graphics.DrawString("NCC: " + this.txttenkh.Text, new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num6));
        //    //    e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(700 + num2, num3 + num), stringFormat);
        //    //    e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(700 + num2, num3 + num + 25), stringFormat);
        //    //    e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(700 + num2, num3 + num + 45), stringFormat);
        //    //    num5 = 40;
        //    //    num4 = num6 + 25;
        //    //}
        //    //else
        //    //{
        //    //    num4 = num3;
        //    //    num5 = 40;
        //    //}
        //    //e.Graphics.DrawString("Ngày nhập", new Font("Arial Narrow", 10f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num4 + 7));
        //    //e.Graphics.DrawString("Số HĐ", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(90 + num2, num4 + 7));
        //    //e.Graphics.DrawString("Mặt hàng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num2, num4 + 7), stringFormat);
        //    //e.Graphics.DrawString("Đơn vị", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(458 + num2, num4), stringFormat);
        //    //e.Graphics.DrawString("tính", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(458 + num2, num4 + 15), stringFormat);
        //    //e.Graphics.DrawString("Số", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(520 + num2, num4), stringFormat);
        //    //e.Graphics.DrawString("lượng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(520 + num2, num4 + 15), stringFormat);
        //    //e.Graphics.DrawString("Đơn giá", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(629 + num2, num4 + 7), stringFormat2);
        //    //e.Graphics.DrawString("Thành tiền", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(760 + num2, num4 + 7), stringFormat2);
        //    //e.Graphics.DrawString("Số tiền trả", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(880 + num2, num4 + 7), stringFormat2);
        //    //e.Graphics.DrawString("Nợ cuối kỳ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(1000 + num2, num4 + 7), stringFormat2);
        //    //int num7 = num4 + 40;
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 1020f, 40f);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //if (this.txtnodauky.Text != "0")
        //    //{
        //    //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //    {
        //    //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //    //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //    }
        //    //    e.Graphics.DrawString("Nợ đầu kỳ", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(148 + num2, num7));
        //    //    e.Graphics.DrawString(Convert.ToDecimal(this.txtnodauky.Text).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //    //    num7 += 25;
        //    //    num5 += 25;
        //    //}
        //    //for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvnhomdonvi.RowCount; i++)
        //    //{
        //    //    this.numberOfItemsPerPage++;
        //    //    if (this.numberOfItemsPerPage > this.sodong)
        //    //    {
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 280f, (float)num5);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        this.lan = 1;
        //    //        this.sodong = int.Parse(this.txtsd.Text) + 2;
        //    //        this.numberOfItemsPerPage = 0;
        //    //        e.HasMorePages = true;
        //    //        return;
        //    //    }
        //    //    this.numberOfItemsPrintedSoFar++;
        //    //    if (this.numberOfItemsPrintedSoFar <= this.dgvnhomdonvi.Rows.Count)
        //    //    {
        //    //        if (i == 0)
        //    //        {
        //    //            this.tongtra = 0m;
        //    //            this.ngaytra1 = this.dttungay.Text;
        //    //            this.ngaytra2 = this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //    //            DataTable dataTable = new DataTable();
        //    //            string cmdText = string.Concat(new string[]
        //    //            {
        //    //                "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //    //                this.txtmakh.Text,
        //    //                "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>'00:00 ",
        //    //                Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //    //                "' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //    //                Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //    //                "'"
        //    //            });
        //    //            SqlConnection sqlConnection = new SqlConnection();
        //    //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    //            SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //    //            sqlConnection.Open();
        //    //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //    //            sqlDataAdapter.Fill(dataTable);
        //    //            this.dgvdathu.DataSource = dataTable;
        //    //            if (this.dgvdathu.RowCount > 0)
        //    //            {
        //    //                for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //    //                {
        //    //                    this.numberOfItemsPerPage++;
        //    //                    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //                    {
        //    //                        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //    //                        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //                    }
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + " " + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7 + 2));
        //    //                    e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7 + 2), stringFormat2);
        //    //                    this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //    //                    num7 += 25;
        //    //                    num5 += 25;
        //    //                }
        //    //            }
        //    //            e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //    //            e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //    //            this.ngaytra1 = this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //    //        }
        //    //        else if (i > 0 && this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString() != this.dgvnhomdonvi.Rows[i - 1].Cells["NGAYNHAP"].Value.ToString())
        //    //        {
        //    //            this.ngaytra2 = this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //    //            DataTable dataTable = new DataTable();
        //    //            string cmdText = string.Concat(new string[]
        //    //            {
        //    //                "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //    //                this.txtmakh.Text,
        //    //                "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //    //                Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //    //                "' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //    //                Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //    //                "'"
        //    //            });
        //    //            SqlConnection sqlConnection = new SqlConnection();
        //    //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    //            SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //    //            sqlConnection.Open();
        //    //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //    //            sqlDataAdapter.Fill(dataTable);
        //    //            this.dgvdathu.DataSource = dataTable;
        //    //            if (this.dgvdathu.RowCount > 0)
        //    //            {
        //    //                for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //    //                {
        //    //                    this.numberOfItemsPerPage++;
        //    //                    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //                    {
        //    //                        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 25f);
        //    //                        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //                    }
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //    //                    e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7));
        //    //                    e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7), stringFormat2);
        //    //                    this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //    //                    num7 += 25;
        //    //                }
        //    //            }
        //    //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //    //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //            }
        //    //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 282f, (float)num5);
        //    //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //            }
        //    //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //    //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //            }
        //    //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //    //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //            }
        //    //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //    //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //            }
        //    //            e.Graphics.DrawString("Cộng:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //    //            e.Graphics.DrawString((this.congdauky + this.cong + Convert.ToDecimal(this.txtnodauky.Text)).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7 + 2), stringFormat2);
        //    //            e.Graphics.DrawString(Convert.ToDecimal(this.tongtra).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(900 + num2, num7 + 2), stringFormat2);
        //    //            e.Graphics.DrawString((this.congdauky + this.cong + Convert.ToDecimal(this.txtnodauky.Text) - this.tongtra).ToString("#,##0"), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(1020 + num2, num7), stringFormat2);
        //    //            this.congdauky += this.cong + Convert.ToDecimal(this.txtnodauky.Text) - this.tongtra;
        //    //            this.cong = 0m;
        //    //            num5 = -25;
        //    //            this.txtnodauky.Text = "0";
        //    //            num7 += 25;
        //    //            num5 += 25;
        //    //            e.Graphics.DrawString(Convert.ToDateTime(this.dgvnhomdonvi.Rows[i].Cells["ngaynhap"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //    //            e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //    //            num4 = num7;
        //    //            this.ngaytra1 = this.dgvnhomdonvi.Rows[i].Cells["NGAYNHAP"].Value.ToString();
        //    //            this.tongtra = 0m;
        //    //        }
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        if (this.dgvnhomdonvi.Rows[i].Cells["dvt"].Value.ToString() != this.dgvnhomdonvi.Rows[i].Cells["g4"].Value.ToString())
        //    //        {
        //    //            if (Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g5"].Value.ToString()) > 0.0)
        //    //            {
        //    //                using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //    //                {
        //    //                    RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //    //                    e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //    //                }
        //    //                e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //    //                e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g5"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //    //                e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["giavon"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    //                e.Graphics.DrawString((Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["giavon"].Value.ToString()) * Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g5"].Value.ToString())).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //    //                this.cong += Convert.ToDecimal(this.dgvnhomdonvi.Rows[i].Cells["g5"].Value.ToString()) * Convert.ToDecimal(this.dgvnhomdonvi.Rows[i].Cells["giavon"].Value.ToString());
        //    //                if (i > 0 && this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString() != this.dgvnhomdonvi.Rows[i - 1].Cells["mahoadon"].Value.ToString())
        //    //                {
        //    //                    e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //    //                }
        //    //            }
        //    //            else
        //    //            {
        //    //                num7 += -30;
        //    //                num5 -= 30;
        //    //            }
        //    //            if (Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g6"].Value.ToString()) > 0.0)
        //    //            {
        //    //                num7 += 30;
        //    //                num5 += 30;
        //    //                if (i > 0 && this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString() != this.dgvnhomdonvi.Rows[i - 1].Cells["mahoadon"].Value.ToString())
        //    //                {
        //    //                    e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["mahoadon"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7 + 2));
        //    //                }
        //    //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //                {
        //    //                    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //    //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //                }
        //    //                using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //    //                {
        //    //                    RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //    //                    e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //    //                }
        //    //                e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["g4"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //    //                e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g6"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //    //                e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g3"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    //                e.Graphics.DrawString((Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g3"].Value.ToString()) * Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g6"].Value.ToString())).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //    //                this.cong += Convert.ToDecimal(this.dgvnhomdonvi.Rows[i].Cells["g3"].Value.ToString()) * Convert.ToDecimal(this.dgvnhomdonvi.Rows[i].Cells["g6"].Value.ToString());
        //    //            }
        //    //        }
        //    //        else
        //    //        {
        //    //            using (Font font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point))
        //    //            {
        //    //                RectangleF rectangleF = new RectangleF((float)(148 + num2), (float)num7, 285f, 30f);
        //    //                e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["hanghoa"].Value.ToString(), font, Brushes.Black, rectangleF);
        //    //            }
        //    //            e.Graphics.DrawString(this.dgvnhomdonvi.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(455 + num2, num7 + 1), stringFormat);
        //    //            e.Graphics.DrawString((Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g5"].Value.ToString()) + Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["g6"].Value.ToString())).ToString("#,##0.##"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(549 + num2, num7), stringFormat2);
        //    //            e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["giavon"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    //            e.Graphics.DrawString(Convert.ToDouble(this.dgvnhomdonvi.Rows[i].Cells["thanhtienct"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //    //            this.cong += Convert.ToDecimal(this.dgvnhomdonvi.Rows[i].Cells["thanhtienct"].Value.ToString());
        //    //        }
        //    //        num7 += 30;
        //    //        num5 += 30;
        //    //    }
        //    //    else
        //    //    {
        //    //        e.HasMorePages = false;
        //    //    }
        //    //}
        //    //this.ngaytra2 = this.dtdenngay.Text;
        //    //DataTable dataTable2 = new DataTable();
        //    //string cmdText2 = string.Concat(new string[]
        //    //{
        //    //    "SELECT Mathuchi,Lydo,RIGHT(ngay,10) as ngay,chungtu,TIENTRANO FROM Tb_THUCHI WHERE MaKH='",
        //    //    this.txtmakh.Text,
        //    //    "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>'00:00 ",
        //    //    Convert.ToDateTime(this.ngaytra1).ToString("MM/dd/yyyy"),
        //    //    "' AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //    //    Convert.ToDateTime(this.ngaytra2).ToString("MM/dd/yyyy"),
        //    //    "'"
        //    //});
        //    //SqlConnection sqlConnection2 = new SqlConnection();
        //    //sqlConnection2.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    //SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection2);
        //    //sqlConnection2.Open();
        //    //SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
        //    //sqlDataAdapter2.Fill(dataTable2);
        //    //this.dgvdathu.DataSource = dataTable2;
        //    //this.tongtra = 0m;
        //    //if (this.dgvdathu.RowCount > 0)
        //    //{
        //    //    for (int j = 0; j < this.dgvdathu.RowCount; j++)
        //    //    {
        //    //        this.numberOfItemsPerPage++;
        //    //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //        {
        //    //            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //    //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //        }
        //    //        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["ngay"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7 + 2));
        //    //        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["mathuchi"].Value.ToString(), new Font("Arial Narrow", 9f, FontStyle.Regular), Brushes.Black, new Point(75 + num2, num7));
        //    //        e.Graphics.DrawString(this.dgvdathu.Rows[j].Cells["lydo"].Value.ToString() + this.dgvdathu.Rows[j].Cells["chungtu"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(148 + num2, num7));
        //    //        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString()).ToString("#,##0"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(898 + num2, num7), stringFormat2);
        //    //        this.tongtra += Convert.ToDecimal(this.dgvdathu.Rows[j].Cells["tientrano"].Value.ToString());
        //    //        num7 += 30;
        //    //    }
        //    //}
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //num5 += 30;
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(145 + num2), (float)(num4 - 5), 280f, (float)num5);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(488 + num2), (float)(num4 - 5), 1f, (float)num5);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(550 + num2), (float)(num4 - 5), 110f, (float)num5);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(780 + num2), (float)(num4 - 5), 120f, (float)num5);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //e.Graphics.DrawString("TỔNG CỘNG:", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num7));
        //    //e.Graphics.DrawString((this.congdauky + this.cong + decimal.Parse(this.txtnodauky.Text)).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7), stringFormat2);
        //    //e.Graphics.DrawString(this.tongtra.ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(900 + num2, num7), stringFormat2);
        //    //e.Graphics.DrawString((this.congdauky + decimal.Parse(this.txtnodauky.Text) + this.cong - this.tongtra).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(1020 + num2, num7), stringFormat2);
        //    //using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    //{
        //    //    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 1020f, 30f);
        //    //    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    //}
        //    //this.xem = 1;
        //}

        // Token: 0x0600084C RID: 2124 RVA: 0x00160310 File Offset: 0x0015E510
        private void txtnodauky_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtnodauky.Text != "")
            //    {
            //        this.txtnodauky.Text = double.Parse(this.txtnodauky.Text).ToString("#,##0");
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600084D RID: 2125 RVA: 0x00160380 File Offset: 0x0015E580
        private void txttratrongky_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txttratrongky.Text != "")
            //    {
            //        this.txttratrongky.Text = double.Parse(this.txttratrongky.Text).ToString("#,##0");
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600084E RID: 2126 RVA: 0x001603F0 File Offset: 0x0015E5F0
        private void button5_Click(object sender, EventArgs e)
        {
        //    if (this.lanhacungcap == "")
        //    {
        //        Frmnhomkhachhang frmnhomkhachhang = new Frmnhomkhachhang();
        //        frmnhomkhachhang.ShowDialog();
        //        this.txtmakh.Text = Frmnhomkhachhang.madonvi;
        //        this.txttenkh.Text = Frmnhomkhachhang.tendonvi;
        //        this.lanhacungcap = Frmnhomkhachhang.nhomkhachhang;
        //    }
        //    if (this.txtmakh.Text != "")
        //    {
        //        this.chitiet = 0;
        //        this.tongtra = 0m;
        //        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
        //        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
        //        string text = dateTime.ToString("MM/dd/yyyy");
        //        string text2 = dateTime2.ToString("MM/dd/yyyy");
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //        this.congdauky = 0m;
        //        this.txtnodauky.Text = "0";
        //        DataTable dataTable = new DataTable();
        //        string cmdText = string.Concat(new string[]
        //        {
        //            "DELETE TB_CHITIETPHAITRA WHERE DAUKY!='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=(ISNULL((SELECT SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH, TB_KHACHHANG KH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC=KH.MAKHACHHANG AND KH.NCC='",
        //            this.txtmakh.Text,
        //            "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
        //            text,
        //            "'),0)+ISNULL((SELECT SUM((HN.DONGIA)*HN.SOLUONGQUYDOI) AS TONGTIEN  FROM TB_HANGHOANHAP_NL HN, TB_KHACHHANG KH WHERE KH.MAKHACHHANG=HN.NCC AND KH.NCC='",
        //            this.txtmakh.Text,
        //            "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
        //            text,
        //            "'),0)+ISNULL((SELECT SUM(ISNULL(SOTIENTRA,0)) FROM TB_TONDAUKY TD, TB_KHACHHANG KH WHERE TD.MaKH =KH.MAKHACHHANG AND KH.NCC='",
        //            this.txtmakh.Text,
        //            "' AND MA='TRA'),0))-ISNULL(( SELECT SUM(TIENTRANO) FROM Tb_THUCHI TC , TB_KHACHHANG KH WHERE TC.MaKH=KH.MAKHACHHANG AND KH.NCC='",
        //            this.txtmakh.Text,
        //            "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //            text,
        //            "'),0),TRA='0' WHERE DAUKY='TRUE' select ISNULL(NO,0) from TB_CHITIETPHAITRA WHERE DAUKY='TRUE'"
        //        });
        //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //        sqlConnection.Open();
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //        sqlDataAdapter.Fill(dataTable);
        //        this.txtnodauky.Text = dataTable.Rows[0][0].ToString();
        //        sqlConnection.Close();
        //        DataTable dataTable2 = new DataTable();
        //        string cmdText2 = string.Concat(new string[]
        //        {
        //            "SELECT ISNULL(SUM(TIENTRANO),0) FROM Tb_THUCHI TC , TB_KHACHHANG KH WHERE TC.MaKH=KH.MAKHACHHANG AND KH.NCC='",
        //            this.txtmakh.Text,
        //            "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //            text,
        //            "' AND CONVERT(DATETIME,NGAY,103)<'23:59 ",
        //            text2,
        //            "'"
        //        });
        //        SqlCommand selectCommand2 = new SqlCommand(cmdText2, sqlConnection);
        //        sqlConnection.Open();
        //        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
        //        sqlDataAdapter2.Fill(dataTable2);
        //        this.txttratrongky.Text = dataTable2.Rows[0][0].ToString();
        //        sqlConnection.Close();
        //        this.chitietnhap_nhomnhacungcap_cotienmat();
        //        if (this.dgvnhomdonvi.RowCount > 0)
        //        {
        //            for (int i = 1; i < this.dgvnhomdonvi.RowCount; i++)
        //            {
        //                this.dgvnhomdonvi.Rows[i].Cells[0].Value = i;
        //            }
        //            this.loadcauhinh();
        //            this.xuatexcel_chitiet_nhomkhachhang();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("BẠN CHƯA CHỌN NHÓM ĐƠN VỊ", "Thông Báo");
        //    }
        }

        // Token: 0x0600084F RID: 2127 RVA: 0x00160738 File Offset: 0x0015E938
        private void button6_Click(object sender, EventArgs e)
        {
            //base.ControlBox = false;
            //this.trang = 0;
            //this.nodauky = decimal.Parse(this.txtnodauky.Text);
            //base.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.p_in.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.loadcauhinh();
            //this.loadmayin();
            //this.xem = 0;
            //this.xem = 0;
            //this.cong = 0m;
            //this.tongcong = 0m;
            //this.congdauky = 0m;
            //this.lan = 0;
            //this.numberOfItemsPrintedSoFar = 0;
            //this.numberOfItemsPerPage = 0;
            //this.sodong = int.Parse(this.textBox7.Text);
            //this.printPreviewControl1.Document = this.print_dc;
            //this.printPreviewControl1.Zoom = 1.1;
            //this.print_dc.DefaultPageSettings.Landscape = true;
            //this.p_in.BringToFront();
            //this.chitiet = 0;
            //this.tongtra = 0m;
        }

        // Token: 0x06000850 RID: 2128 RVA: 0x0016089C File Offset: 0x0015EA9C
        private void button7_Click(object sender, EventArgs e)
        {
            //this.p_in.SendToBack();
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //base.ControlBox = true;
        }

        // Token: 0x06000851 RID: 2129 RVA: 0x0001D111 File Offset: 0x0001B311
        private void button8_Click(object sender, EventArgs e)
        {
            this.trang++;
            this.printPreviewControl1.StartPage = this.trang;
        }

        // Token: 0x06000852 RID: 2130 RVA: 0x001608FC File Offset: 0x0015EAFC
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.trang > this.printPreviewControl1.StartPage)
            {
                this.trang = this.printPreviewControl1.StartPage;
            }
            if (this.trang > 0)
            {
                this.trang--;
            }
            else
            {
                this.trang = 0;
            }
            this.printPreviewControl1.StartPage = this.trang;
        }

        // Token: 0x06000853 RID: 2131 RVA: 0x00160970 File Offset: 0x0015EB70
        private void button10_Click(object sender, EventArgs e)
        {
            //this.txtnodauky.Text = this.nodauky.ToString();
            //this.sodong = int.Parse(this.textBox7.Text);
            //this.xem = 0;
            //this.cong = 0m;
            //this.tongcong = 0m;
            //this.congdauky = 0m;
            //this.lan = 0;
            //this.numberOfItemsPrintedSoFar = 0;
            //this.numberOfItemsPerPage = 0;
            //this.tongtientra = 0m;
            //PrintDialog printDialog = new PrintDialog();
            //PrintDocument printDocument = new PrintDocument();
            //printDialog.Document = this.print_dc;
            //DialogResult dialogResult = printDialog.ShowDialog();
            //printDocument.PrintPage += this.print_dc_PrintPage;
            //if (dialogResult == DialogResult.OK)
            //{
            //    printDocument.DefaultPageSettings.Landscape = true;
            //    printDocument.Print();
            //}
        }

        // Token: 0x06000854 RID: 2132 RVA: 0x0001D134 File Offset: 0x0001B334
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.sodong = int.Parse(this.textBox7.Text);
        }
    }
}
