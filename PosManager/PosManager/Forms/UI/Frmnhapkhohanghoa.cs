using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmnhapkhohanghoa : Form
    {

        // Token: 0x0400082F RID: 2095
       // private Chitiethoadonbanhang cthdObj = new Chitiethoadonbanhang();

        // Token: 0x04000830 RID: 2096
        private string g1;

        // Token: 0x04000831 RID: 2097
        private string g2;

        // Token: 0x04000832 RID: 2098
        private string g3;

        // Token: 0x04000833 RID: 2099
        private string g4;

        // Token: 0x04000834 RID: 2100
        private string g5;

        // Token: 0x04000835 RID: 2101
        private string g6;

        // Token: 0x04000836 RID: 2102
        public static string nhapkh = "True";

        // Token: 0x04000837 RID: 2103
        public static string ngaynhapkho = "Ngày nhập kho:";

        // Token: 0x04000838 RID: 2104
       // private HangHoaCtr hhCrt = new HangHoaCtr();

        // Token: 0x04000839 RID: 2105
    //    private HoadonBanhangCtr hdCtr = new HoadonBanhangCtr();

        // Token: 0x0400083A RID: 2106
        public static string mancc = "";

        // Token: 0x0400083B RID: 2107
        private string scan = "";

        // Token: 0x0400083C RID: 2108
        private string luutenhang = "";

        // Token: 0x0400083D RID: 2109
     //   private HanghoanhapObj hhnObj = new HanghoanhapObj();

        // Token: 0x0400083E RID: 2110
     //   private NhaphoadonObj nhdObj = new NhaphoadonObj();

        // Token: 0x0400083F RID: 2111
   //     private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        // Token: 0x04000840 RID: 2112
      //  private KhachhangObj khObj = new KhachhangObj();

        // Token: 0x04000841 RID: 2113
      //  private HanghoaHdObj hhObj = new HanghoaHdObj();

        // Token: 0x04000842 RID: 2114
        private string mahang = "";

        // Token: 0x04000843 RID: 2115
        private string manhom = "";

        // Token: 0x04000844 RID: 2116
        private string tondonvi_le = "False";

        // Token: 0x04000845 RID: 2117
        private double nhogiacu = 0.0;
        public Frmnhapkhohanghoa()
        {
            InitializeComponent();
            //this.scan = TrangChu.scan;
            this.tudongcapnhattendonvi();
            this.tudongcapnhathanghoaxuat();
        }

        // Token: 0x060006AC RID: 1708 RVA: 0x000394BC File Offset: 0x000376BC
        private void bthanghoa_Click(object sender, EventArgs e)
        {
            //frmHangHoa frmHangHoa = new frmHangHoa();
            //frmHangHoa.ShowDialog();
        }

        // Token: 0x060006AD RID: 1709 RVA: 0x000394BC File Offset: 0x000376BC
        private void button2_Click(object sender, EventArgs e)
        {
            //frmHangHoa frmHangHoa = new frmHangHoa();
            //frmHangHoa.ShowDialog();
        }

        // Token: 0x060006AE RID: 1710 RVA: 0x00138CEC File Offset: 0x00136EEC
        private void tudongcapnhathanghoaxuat()
        {
            //this.cobhanghoa.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.cobhanghoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText;
            //if (Frmnhapkhohanghoa.nhapkh == "True1" || Frmnhapkhohanghoa.nhapkh == "True2")
            //{
            //    cmdText = "Select TENHANGHOA from Tb_NGUYENLIEU";
            //}
            //else
            //{
            //    cmdText = "Select TENHANGHOA from Tb_HANGHOA";
            //}
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.cobhanghoa.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x060006AF RID: 1711 RVA: 0x00138DC4 File Offset: 0x00136FC4
        private void LOADTHONGTINKHACHHANG()
        {
            //string cmdText = "Select MAKHACHHANG,DIACHI,SOTAIKHOAN from Tb_khachhang where makhachhang='" + this.txtdonvi.SelectedValue.ToString() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtmasothue.Text = sqlDataReader.GetString(0);
            //    this.txtdiachi.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.txtsotaikhoan.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006B0 RID: 1712 RVA: 0x00138E80 File Offset: 0x00137080
        private void LOADTHONGTINHANGHOA()
        {
            //string cmdText = "SELECT DONVITINH,DONGIA,QUYDOI,DONVITINHLON ,DONVITINHLON3,QUYDOI1 FROM tb_hanghoa where mahanghoa='" + this.cobhanghoa.SelectedValue.ToString() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.txtdonvi2.Text = sqlDataReader.GetString(3);
            //    this.lbdonvi3.Text = sqlDataReader.GetString(4);
            //    this.txtquycach.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    MessageBox.Show("Không tìm thấy tên hàng này", "Thông báo");
            //    this.txtdonvitinh.Text = "Đvt";
            //    this.txtdongia.Text = "0";
            //    this.txtsoluongton.Text = "0";
            //    this.txtquycach.Text = "1";
            //    this.txtdonvitinh2.Text = "0";
            //    this.txtsoluongquydoi.Text = "0";
            //    this.txtdonvi2.Text = "Đvt2";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006B1 RID: 1713 RVA: 0x00138FFC File Offset: 0x001371FC
        private void tudongcapnhattendonvi()
        {
            //this.txttenncc.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.txttenncc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select tendonvi from Tb_khachhang WHERE NCC='02'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txttenncc.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x060006B2 RID: 1714 RVA: 0x00139098 File Offset: 0x00137298
        private bool kiemtratontai(string makhachhang)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select makhachhang from Tb_khachhang", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    if (makhachhang == sqlDataReader.GetString(0))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //sqlConnection.Close();
            return result;
        }

        // Token: 0x060006B3 RID: 1715 RVA: 0x00139118 File Offset: 0x00137318
        //private void khachhang(KhachhangObj khObj)
        //{
        //    khObj.Makhachang = this.txtmasothue.Text;
        //    khObj.Tenkhachhang = this.txtnguoimuahang.Text;
        //    khObj.Tendonvi = this.txtdonvi.Text;
        //    khObj.Gioitinh = "";
        //    khObj.Namsinh = "";
        //    khObj.Diachi = this.txtdiachi.Text;
        //    khObj.Cmnd = "";
        //    khObj.Ngaycap = "";
        //    khObj.Noicap = "";
        //    khObj.Sdt = "";
        //    khObj.Email = "";
        //    khObj.Ghichu = "";
        //    khObj.Sotaikhoan = this.txtsotaikhoan.Text;
        //    khObj.Ncc = "True";
        //}

        // Token: 0x060006B4 RID: 1716 RVA: 0x001391EC File Offset: 0x001373EC
        private bool kiemtratontaihoadonnhap(string mahoadon)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select sohoadon from Tb_hoadonnhap", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    if (mahoadon == sqlDataReader.GetString(0))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //sqlConnection.Close();
            return result;
        }

        // Token: 0x060006B5 RID: 1717 RVA: 0x0013926C File Offset: 0x0013746C
        private bool kiemtranhaphang(string mahoadon, string mahang, double soluong)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("select mahoadon,mahanghoa,soluong from tb_hanghoanhap where mahoadon='" + this.txtsohoadon.Text + "'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    if (mahoadon == sqlDataReader.GetString(0) && mahang == sqlDataReader.GetString(1) && soluong == double.Parse(Convert.ToString(sqlDataReader.GetValue(2))))
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //sqlConnection.Close();
            return result;
        }

        // Token: 0x060006B6 RID: 1718 RVA: 0x00139328 File Offset: 0x00137528
        //private void xuathuykhohang(Chitiethoadonbanhang cthdObj)
        //{
        //    if (float.Parse(this.txtsoluongquydoi.Text) <= float.Parse(this.txtsoluongton.Text) * float.Parse(this.txtquycach.Text))
        //    {
        //        cthdObj.Mahanghoa = this.txtmahh.Text;
        //        cthdObj.Tenhanghoa = this.cobhanghoa.Text;
        //        cthdObj.Loai = "A";
        //        cthdObj.Donvitinh = this.txtdonvitinh.Text;
        //        cthdObj.Quycach = "1";
        //        cthdObj.Soluong = (float.Parse(this.txtsoluongquydoi.Text) / float.Parse(this.txtquycach.Text)).ToString();
        //        cthdObj.Soluong3 = (float.Parse(this.txtsoluongquydoi.Text) / float.Parse(this.txtquycach.Text)).ToString();
        //        cthdObj.Soluong2 = "0";
        //        cthdObj.Soluong1 = "0";
        //        cthdObj.Soluong4 = "0";
        //        cthdObj.Soluong5 = "0";
        //        cthdObj.Soluong6 = "0";
        //        cthdObj.Tongsoluong = (float.Parse(this.txtsoluongquydoi.Text) / float.Parse(this.txtquycach.Text)).ToString();
        //        cthdObj.Dongia = float.Parse(this.txtdongiack.Text).ToString();
        //        cthdObj.Chietkhau = "0";
        //        cthdObj.Giavon = float.Parse(this.txtdongiack.Text);
        //        cthdObj.Dongiaban = "0";
        //        cthdObj.Thanhtien = decimal.Parse(this.txtthanhtien.Text).ToString();
        //        cthdObj.Ghichu = "Xuất hủy";
        //        cthdObj.Ncc = this.comboBox1.SelectedValue.ToString();
        //        cthdObj.Maloai = this.cobloai.SelectedIndex.ToString();
        //        cthdObj.Mahoadon = this.txtsohoadon.Text;
        //        cthdObj.Ngay = DateTime.Now.ToString("HH:mm ") + TrangChu.ngaybanhang;
        //        cthdObj.Huy = "False";
        //        cthdObj.Nhanvien = frmLogIn.MADANGNHAP;
        //        cthdObj.Xb = "XH";
        //        if (this.hdCtr.Add_chiHoadon(cthdObj))
        //        {
        //            this.ADD_HANGHOA();
        //        }
        //        else
        //        {
        //            MessageBox.Show("KHÔNG XUẤT HỦY KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("SỐ LƯỢNG HỦY PHẢI NHỎ HƠN SỐ LƯỢNG TỒN", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006B7 RID: 1719 RVA: 0x001395D8 File Offset: 0x001377D8
        //private void xuatkhohang(HanghoanhapObj hhnObj)
        //{
        //    int num = 0;
        //    hhnObj.Stt = num + 1;
        //    hhnObj.Mahoadon = this.txtsohoadon.Text;
        //    hhnObj.Mahanghoa = this.txtmahh.Text.ToUpper();
        //    hhnObj.Soluong2 = "0";
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Soluong = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString();
        //    hhnObj.Dongia = float.Parse(this.txtdongiack.Text).ToString();
        //    hhnObj.Giavon2 = "0";
        //    hhnObj.Ngaynhap = this.dateTimePicker1.Text;
        //    hhnObj.Ghichu = "";
        //    hhnObj.Soluongquydoi = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString();
        //    hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
        //    hhnObj.Vat = this.txtvat.Text;
        //    hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
        //    hhnObj.Nhanvien = this.cobnhanvien.SelectedValue.ToString();
        //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
        //    {
        //        if (this.txtmancc.Text != "")
        //        {
        //            hhnObj.Ncc = this.txtmancc.Text;
        //        }
        //        else
        //        {
        //            hhnObj.Ncc = "CTY";
        //        }
        //    }
        //    else
        //    {
        //        hhnObj.Ncc = "CTY";
        //    }
        //    if (this.xhdCtr.ADD_HANGHOANHAP(hhnObj))
        //    {
        //        this.ADD_HANGHOA();
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006B8 RID: 1720 RVA: 0x001397F8 File Offset: 0x001379F8
        //private void nhaphanghoa(HanghoanhapObj hhnObj)
        //{
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    hhnObj.Stt = 1;
        //    hhnObj.Mahoadon = this.txtsohoadon.Text;
        //    if (this.txtmahh.Text == "")
        //    {
        //        hhnObj.Mahanghoa = this.mahang;
        //    }
        //    else
        //    {
        //        hhnObj.Mahanghoa = this.txtmahh.Text.ToUpper();
        //    }
        //    hhnObj.Soluong2 = "0";
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Soluong = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Dongia = float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Ngaynhap = this.dateTimePicker1.Text;
        //    hhnObj.Ghichu = this.txtghichu.Text;
        //    hhnObj.Soluongquydoi = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Giavon2 = float.Parse(this.txtgiavon2.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
        //    hhnObj.Vat = this.txtvat.Text;
        //    hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
        //    hhnObj.Nhanvien = this.cobnhanvien.SelectedValue.ToString();
        //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
        //    {
        //        if (this.txtmancc.Text != "")
        //        {
        //            hhnObj.Ncc = this.txtmancc.Text;
        //        }
        //        else
        //        {
        //            hhnObj.Ncc = "CTY";
        //        }
        //    }
        //    else
        //    {
        //        hhnObj.Ncc = "CTY";
        //    }
        //    if (this.xhdCtr.ADD_HANGHOANHAP(hhnObj))
        //    {
        //        this.ADD_HANGHOA();
        //        if (this.txtmahh.Text == "")
        //        {
        //            string text = this.mahang;
        //        }
        //        else
        //        {
        //            string text = this.txtmahh.Text;
        //        }
        //        string text2 = "";
        //        if (float.Parse(this.txtdongiack.Text) > 0f && float.Parse(this.txtsoluong.Text) > 0f)
        //        {
        //            text2 = " ,GIANHAP='" + float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat) + "'";
        //        }
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
        //        {
        //            "DELETE FROM TB_TONGHANGHOANHAP  where MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1    FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND HN.MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1) DELETE FROM TB_TONKHO WHERE MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' DELETE FROM TB_XUATTAM WHERE MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' DELETE FROM TB_TONGHANGHOANHAP  WHERE MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1       FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND HH.MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0) ELSE '0' END WHEN LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) END AS SOLUONGTONG,case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
        //            TrangChu.tile,
        //            ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN '0' END   END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' AND HH.MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_TONGHANGHOANHAP HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHANGHOA=HHX.MAHANGHOA WHERE HHN.MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "' group by hhn.mahanghoa,isnull(hhn.soluongTONG,0)) "
        //        }), sqlConnection);
        //        sqlConnection.Open();
        //        sqlCommand.ExecuteNonQuery();
        //        sqlCommand = new SqlCommand(string.Concat(new string[]
        //        {
        //            "UPDATE TB_HANGHOA SET DONVITINHLON3 = isnull((SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA),0) ",
        //            text2,
        //            " where MAHANGHOA='",
        //            this.txtmahh.Text,
        //            "'"
        //        }), sqlConnection);
        //        sqlCommand.ExecuteReader();
        //        sqlConnection.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006B9 RID: 1721 RVA: 0x00139CB4 File Offset: 0x00137EB4
        //private void nhaphanghoa_chuyenkho(HanghoanhapObj hhnObj)
        //{
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    hhnObj.Stt = 1;
        //    hhnObj.Mahoadon = this.txtsohoadon.Text;
        //    if (this.txtmahh.Text == "")
        //    {
        //        hhnObj.Mahanghoa = this.mahang;
        //    }
        //    else
        //    {
        //        hhnObj.Mahanghoa = this.txtmahh.Text.ToUpper();
        //    }
        //    hhnObj.Soluong2 = "0";
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Dongia = float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Ngaynhap = this.dateTimePicker1.Text;
        //    hhnObj.Ghichu = this.txtghichu.Text;
        //    hhnObj.Soluongquydoi = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Soluong = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Giavon2 = float.Parse(this.txtgiavon2.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Loai = this.comboBox2.SelectedValue.ToString();
        //    hhnObj.Vat = this.txtvat.Text;
        //    hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
        //    hhnObj.Nhanvien = this.cobnhanvien.SelectedValue.ToString();
        //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
        //    {
        //        if (this.txtmancc.Text != "")
        //        {
        //            hhnObj.Ncc = this.txtmancc.Text;
        //        }
        //        else
        //        {
        //            hhnObj.Ncc = "CTY";
        //        }
        //    }
        //    else
        //    {
        //        hhnObj.Ncc = "CTY";
        //    }
        //    if (this.xhdCtr.ADD_HANGHOANHAP(hhnObj))
        //    {
        //        this.ADD_HANGHOA();
        //        hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
        //        hhnObj.Soluongquydoi = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //        hhnObj.Soluong = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //        this.xhdCtr.ADD_HANGHOANHAP(hhnObj);
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006BA RID: 1722 RVA: 0x00139FC4 File Offset: 0x001381C4
        //private void TRU_nhapnguyenlieu(HanghoanhapObj hhnObj)
        //{
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    hhnObj.Stt = 1;
        //    hhnObj.Mahoadon = this.txtsohoadon.Text;
        //    hhnObj.Mahanghoa = this.txtmahh.Text.ToUpper();
        //    hhnObj.Soluong2 = this.txtsohaohut.Text.Trim();
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Soluong = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Dongia = float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Ngaynhap = this.dateTimePicker1.Text;
        //    hhnObj.Ghichu = "";
        //    hhnObj.Soluongquydoi = "-" + float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
        //    hhnObj.Vat = this.txtvat.Text;
        //    hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
        //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
        //    {
        //        if (this.txtmancc.Text != "")
        //        {
        //            hhnObj.Ncc = this.txtmancc.Text;
        //        }
        //        else
        //        {
        //            hhnObj.Ncc = "CTY";
        //        }
        //    }
        //    else
        //    {
        //        hhnObj.Ncc = "CTY";
        //    }
        //    if (this.xhdCtr.ADD_HANGHOANHAP_NL(hhnObj))
        //    {
        //        this.ADD_HANGHOA();
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006BB RID: 1723 RVA: 0x0013A1F4 File Offset: 0x001383F4
        //private void nhapnguyenlieu(HanghoanhapObj hhnObj)
        //{
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    int num = 0;
        //    hhnObj.Stt = num + 1;
        //    hhnObj.Mahoadon = this.txtsohoadon.Text;
        //    hhnObj.Mahanghoa = this.txtmahh.Text.ToUpper();
        //    hhnObj.Soluong2 = this.txtsohaohut.Text.Trim();
        //    hhnObj.Soluong3 = "0";
        //    hhnObj.Soluong4 = "0";
        //    hhnObj.Soluong5 = "0";
        //    hhnObj.Soluong6 = "0";
        //    hhnObj.Soluong = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Dongia = float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Ngaynhap = this.dateTimePicker1.Text;
        //    hhnObj.Ghichu = "";
        //    hhnObj.Soluongquydoi = float.Parse(this.txtsoluongquydoi.Text).ToString("", cultureInfo.NumberFormat);
        //    hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
        //    hhnObj.Vat = this.txtvat.Text;
        //    hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
        //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
        //    {
        //        if (this.txtmancc.Text != "")
        //        {
        //            hhnObj.Ncc = this.txtmancc.Text;
        //        }
        //        else
        //        {
        //            hhnObj.Ncc = "CTY";
        //        }
        //    }
        //    else
        //    {
        //        hhnObj.Ncc = "CTY";
        //    }
        //    if (this.xhdCtr.ADD_HANGHOANHAP_NL(hhnObj))
        //    {
        //        this.ADD_HANGHOA();
        //    }
        //    else
        //    {
        //        MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
        //    }
        //}

        // Token: 0x060006BC RID: 1724 RVA: 0x0013A418 File Offset: 0x00138618
        private void ADD_HANGHOA()
        {
            try
            {
                this.dgvchitiethoadon.Rows.Add(1);
                int rowIndex = this.dgvchitiethoadon.Rows.Count - 1;
                this.dgvchitiethoadon[0, rowIndex].Value = this.dgvchitiethoadon.RowCount;
                this.dgvchitiethoadon["tenhanghoa", rowIndex].Value = this.cobhanghoa.Text;
                if (this.txtsoluong.Text != "0")
                {
                    this.dgvchitiethoadon["dvt", rowIndex].Value = this.txtdonvitinh.Text;
                    this.dgvchitiethoadon["SL", rowIndex].Value = this.txtsoluong.Text;
                }
                else
                {
                    this.dgvchitiethoadon["dvt", rowIndex].Value = this.txtdonvi2.Text;
                    this.dgvchitiethoadon["SL", rowIndex].Value = this.txtquydoi.Text;
                }
                this.dgvchitiethoadon["DG", rowIndex].Value = this.txtdongiack.Text;
                this.dgvchitiethoadon["Thanhtien1", rowIndex].Value = this.txtthanhtien.Text;
                if (this.txtmahh.Text == "")
                {
                    this.dgvchitiethoadon["mahanghoa", rowIndex].Value = this.mahang;
                }
                else
                {
                    this.dgvchitiethoadon["mahanghoa", rowIndex].Value = this.txtmahh.Text;
                }
                this.dgvchitiethoadon["SLqd", rowIndex].Value = this.txtsoluongquydoi.Text;
                this.dgvchitiethoadon["Ghichu", rowIndex].Value = "   ";
                this.dgvchitiethoadon["Loai", rowIndex].Value = this.cobloai.Text;
                this.dgvchitiethoadon["mahoadon", rowIndex].Value = this.txtsohoadon.Text;
            }
            catch
            {
            }
        }

        // Token: 0x060006BD RID: 1725 RVA: 0x0013A684 File Offset: 0x00138884
        //private void themhanghoa(HanghoaHdObj hhObj)
        //{
        //    hhObj.Mahanghoa = this.txtmahh.Text;
        //    hhObj.Tenhanghoa = this.cobhanghoa.Text;
        //    hhObj.Dongia = this.txtdongia.Text;
        //    hhObj.Ghichu = "";
        //    hhObj.Donvitinh = this.txtdonvitinh.Text;
        //    this.xhdCtr.ADD_HANGHOA(hhObj);
        //}

        // Token: 0x060006BE RID: 1726 RVA: 0x0013A6F4 File Offset: 0x001388F4
        private void tinhtinhtong()
        {
            try
            {
                double num = 0.0;
                for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
                {
                    num += double.Parse(this.dgvchitiethoadon["Thanhtien1", i].Value.ToString());
                }
                if (num > 0.0)
                {
                    this.txttienhang.Text = num.ToString("#,###");
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006BF RID: 1727 RVA: 0x0013A790 File Offset: 0x00138990
        private void btluu_Click(object sender, EventArgs e)
        {
            //if (Frmnhapkhohanghoa.nhapkh == "True")
            //{
            //    if (this.luutenhang == "1")
            //    {
            //        this.mahang = "";
            //        this.themhangmoi();
            //    }
            //}
            //if (this.cobhanghoa.Text == "")
            //{
            //    MessageBox.Show("VUI LÒNG NHẬP TÊN HÀNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //    this.cobhanghoa.Focus();
            //}
            //else if (this.txtmahh.Text == "" && this.mahang == "")
            //{
            //    MessageBox.Show("VUI LÒNG NHẬP MÃ HÀNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //    this.txtmahh.Focus();
            //}
            //else
            //{
            //    if (double.Parse(this.txtsoluong.Text) + double.Parse(this.txtquydoi.Text) == 0.0)
            //    {
            //        MessageBox.Show("VUI LÒNG NHẬP SỐ LƯỢNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //        this.txtsoluong.Focus();
            //    }
            //    else
            //    {
            //        if (Frmnhapkhohanghoa.nhapkh == "True")
            //        {
            //            this.nhaphanghoa(this.hhnObj);
            //        }
            //        else if (Frmnhapkhohanghoa.nhapkh == "False")
            //        {
            //            float num = float.Parse(this.txtsoluongton.Text) * float.Parse(this.txtquycach.Text);
            //            if (float.Parse(this.txtsoluongquydoi.Text) <= num)
            //            {
            //                this.xuatkhohang(this.hhnObj);
            //            }
            //        }
            //        else if (Frmnhapkhohanghoa.nhapkh == "True1")
            //        {
            //            this.nhapnguyenlieu(this.hhnObj);
            //        }
            //        else if (Frmnhapkhohanghoa.nhapkh == "True2")
            //        {
            //            this.TRU_nhapnguyenlieu(this.hhnObj);
            //        }
            //        else if (Frmnhapkhohanghoa.nhapkh == "False1")
            //        {
            //            float num = float.Parse(this.txtsoluongton.Text) * float.Parse(this.txtquycach.Text);
            //            if (float.Parse(this.txtsoluongquydoi.Text) <= num)
            //            {
            //                this.xuathuykhohang(this.cthdObj);
            //            }
            //        }
            //        else if (Frmnhapkhohanghoa.nhapkh == "chuyenkho")
            //        {
            //            float num = float.Parse(this.txtsoluongton.Text) * float.Parse(this.txtquycach.Text);
            //            if (float.Parse(this.txtsoluongquydoi.Text) <= num)
            //            {
            //                this.nhaphanghoa_chuyenkho(this.hhnObj);
            //            }
            //        }
            //        this.tinhtinhtong();
            //        this.dgvchitiethoadon.AutoResizeRows();
            //        this.txtsoluong.Text = "1";
            //        this.txtdongia.Text = "0";
            //        this.txtquydoi.Text = "0";
            //        this.txtdonvitinh.Text = "Đvt";
            //        this.txtsoluongton.Text = "0";
            //        this.txtsoluongquydoi.Text = "0";
            //        this.txtthanhtien.Text = "0";
            //        this.txtdongianhap.Text = "0";
            //        this.txtmahh.Text = "";
            //        this.txtquycach.Text = "1";
            //        this.txtgiaton.Text = "0";
            //        this.txtvat.Text = "0";
            //        this.txtgiavon2.Text = "0";
            //        this.txtchietkhau.Text = "0";
            //        this.txtck2.Text = "0";
            //        this.txtck3.Text = "0";
            //        this.cobhanghoa.BackColor = Color.LightGreen;
            //        if (Settings.Default.mahangtudong == "True")
            //        {
            //            this.cobhanghoa.Focus();
            //        }
            //        else
            //        {
            //            this.txtmahh.Focus();
            //        }
            //    }
            //    this.mahang = "";
            //}
        }

        // Token: 0x060006C0 RID: 1728 RVA: 0x0013ABE8 File Offset: 0x00138DE8
        private void txtdonvi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DataTable dataSource = new DataTable();
              //  dataSource = this.xhdCtr.GET_TENDONVI(this.txtdonvi.Text);
                this.txtdonvi.DataSource = dataSource;
                this.txtdonvi.DisplayMember = "Tendonvi";
                this.txtdonvi.ValueMember = "makhachhang";
                this.LOADTHONGTINKHACHHANG();
            }
        }

        // Token: 0x060006C1 RID: 1729 RVA: 0x0013AC5C File Offset: 0x00138E5C
        private void cobhanghoa_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.cobhanghoa.Text != "")
            //    {
            //        DataTable dataTable = new DataTable();
            //        dataTable = this.xhdCtr.GET_TENHANGHOA(this.cobhanghoa.Text);
            //        this.cobhanghoa.DataSource = dataTable;
            //        if (dataTable.Rows.Count > 0)
            //        {
            //            this.cobhanghoa.DisplayMember = "TENHANGHOA";
            //            this.cobhanghoa.ValueMember = "MAHANGHOA";
            //            this.txtmahh.Text = this.cobhanghoa.SelectedValue.ToString();
            //            this.txtsoluong.BackColor = Color.LightGreen;
            //            this.cobhanghoa.BackColor = Color.LemonChiffon;
            //        }
            //        else
            //        {
            //            this.luutenhang = "1";
            //            this.g1 = "0";
            //            this.g2 = "0";
            //            this.g3 = "0";
            //            this.g4 = "0";
            //            this.g5 = "0";
            //            this.g6 = "0";
            //            this.txtdonvitinh.ReadOnly = false;
            //            this.txtdongia.Text = "0";
            //            this.txtdonvi2.ReadOnly = false;
            //            this.txtdongia.ReadOnly = false;
            //            this.txtdonvi2.Visible = true;
            //            this.lbqd.Visible = true;
            //            this.txtquycach.Visible = true;
            //            this.txtsoluongton.Text = "0";
            //            this.cobnhom.Visible = true;
            //        }
            //        this.txtsoluong.Focus();
            //    }
            //    else
            //    {
            //        this.txtmahh.Focus();
            //    }
            //}
        }

        // Token: 0x060006C2 RID: 1730 RVA: 0x0013AE30 File Offset: 0x00139030
        private void dgvchitiethoadon_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Delete)
            //    {
            //        int rowIndex = this.dgvchitiethoadon.CurrentCell.RowIndex;
            //        string text = this.dgvchitiethoadon.Rows[rowIndex].Cells["MAHANGHOA"].Value.ToString();
            //        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa   " + text + "   không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "DELETE TB_HANGHOANHAP WHERE MAHOADON='",
            //                this.txtsohoadon.Text,
            //                "' AND MAHANGHOA='",
            //                text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            this.dgvchitiethoadon.Rows.RemoveAt(rowIndex);
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006C3 RID: 1731 RVA: 0x0013AF68 File Offset: 0x00139168
        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.txtdonvitinh.ReadOnly)
                {
                    this.txtdonvitinh.Focus();
                }
                else if (this.txtquydoi.Visible)
                {
                    this.txtquydoi.Focus();
                }
                else
                {
                    this.txtdongianhap.Focus();
                }
            }
        }

        // Token: 0x060006C4 RID: 1732 RVA: 0x0013AFD8 File Offset: 0x001391D8
        private void tinhsoluong()
        {
            double num = double.Parse(this.txtquycach.Text);
            double num2 = double.Parse(this.txtsoluong.Text);
            double num3 = double.Parse(this.txtquydoi.Text);
            double num4;
            if (this.tondonvi_le == "False")
            {
                num4 = num2 * num + num3;
            }
            else
            {
                num4 = num2 + num3;
            }
            this.txtsoluongquydoi.Text = num4.ToString("#,##0.###");
        }

        // Token: 0x060006C5 RID: 1733 RVA: 0x0013B060 File Offset: 0x00139260
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.tinhsoluong();
                if (this.txtsoluong.Text != "")
                {
                    this.thanhtien();
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006C6 RID: 1734 RVA: 0x0013B0B4 File Offset: 0x001392B4
        private void txtdongia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtdongia.ReadOnly)
                {
                    this.btluu.Focus();
                }
                else
                {
                    this.txtdongianhap.Focus();
                }
            }
        }

        // Token: 0x060006C7 RID: 1735 RVA: 0x0013B104 File Offset: 0x00139304
        private void txtsohoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtnguoimuahang.Focus();
            }
        }

        // Token: 0x060006C8 RID: 1736 RVA: 0x0013B134 File Offset: 0x00139334
        private void txtnguoimuahang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdonvi.Focus();
            }
        }

        // Token: 0x060006C9 RID: 1737 RVA: 0x0013B164 File Offset: 0x00139364
        private void txtthanhtien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btluu.Focus();
            }
        }

        // Token: 0x060006CA RID: 1738 RVA: 0x0013B194 File Offset: 0x00139394
        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtthanhtien.Text);
                if (num != 0.0)
                {
                    this.txtthanhtien.Text = num.ToString("#,##0.##");
                    this.txtthanhtien.SelectionStart = this.txtthanhtien.TextLength;
                }
                if (this.txtthanhtien.Text == "")
                {
                    this.txtthanhtien.Text = "0";
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006CB RID: 1739 RVA: 0x0013B23C File Offset: 0x0013943C
        private void LOADGIA()
        {
            DataTable dataSource = new DataTable();
           // dataSource = this.hdCtr.GET_GIA();
            this.cobloai.DataSource = dataSource;
            this.cobloai.DisplayMember = "TEN";
            this.cobloai.ValueMember = "MA";
        }

        // Token: 0x060006CC RID: 1740 RVA: 0x0013B28C File Offset: 0x0013948C
        private void nhacungcap()
        {
            try
            {
                DataTable dataSource = new DataTable();
              //  dataSource = this.hhCrt.GetData_NHACUNGCAP();
                this.cobnhacungcap.DataSource = dataSource;
                this.cobnhacungcap.DisplayMember = "TENDONVI";
                this.cobnhacungcap.ValueMember = "MAKHACHHANG";
            }
            catch
            {
                this.cobnhacungcap.DisplayMember = "Nhà Cung Cấp";
                this.cobnhacungcap.ValueMember = "CTY";
            }
        }

        // Token: 0x060006CD RID: 1741 RVA: 0x0013B318 File Offset: 0x00139518
        private void loadnhomhang()
        {
            DataTable dataSource = new DataTable();
           // dataSource = this.xhdCtr.GET_NHOMHANG();
            this.cobnhom.DataSource = dataSource;
            this.cobnhom.DisplayMember = "TENNHOM";
            this.cobnhom.ValueMember = "MANHOM";
        }

        // Token: 0x060006CE RID: 1742 RVA: 0x0013B368 File Offset: 0x00139568
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
            //    this.comboBox1.Items.Clear();
            //    this.comboBox1.DataSource = bindingList;
            //    this.comboBox1.ValueMember = "Key";
            //    this.comboBox1.DisplayMember = "Value";
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    Frm_kho frm_kho = new Frm_kho();
            //    frm_kho.ShowDialog();
            //}
        }

        // Token: 0x060006CF RID: 1743 RVA: 0x0013B48C File Offset: 0x0013968C
        private void LOAD_khochuyen()
        {
            //try
            //{
            //    BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    if (TrangChu.dungnhieukho == "True")
            //    {
            //        string cmdText = "SELECT * FROM TB_KHO ORDER BY MAKHO";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        while (sqlDataReader.Read())
            //        {
            //            bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(1)));
            //        }
            //        this.comboBox2.Items.Clear();
            //        this.comboBox2.DataSource = bindingList;
            //        this.comboBox2.ValueMember = "Key";
            //        this.comboBox2.DisplayMember = "Value";
            //        sqlConnection.Close();
            //    }
            //}
            //catch
            //{
            //    Frm_kho frm_kho = new Frm_kho();
            //    frm_kho.ShowDialog();
            //}
        }

        // Token: 0x060006D0 RID: 1744 RVA: 0x0013B59C File Offset: 0x0013979C
        private void Frmnhapkhohanghoa_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT MaNV,TenNV FROM Tb_NhanVien";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.cobnhanvien.DataSource = dataTable;
            //    this.cobnhanvien.DisplayMember = "TENNV";
            //    this.cobnhanvien.ValueMember = "MANV";
            //}
            //catch
            //{
            //    MessageBox.Show("BẠN PHẢI TẠO 1 NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //this.LOAD_kho();
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //if (TrangChu.dungkhonguyenlieu == "True" && Frmnhapkhohanghoa.nhapkh == "True1")
            //{
            //    string text = DateTime.Now.ToString("MM/dd/yyyy");
            //    string text2 = DateTime.Now.ToString("MM/dd/yyyy");
            //    string cmdText2 = string.Concat(new string[]
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
            //        "')),101) GROUP BY HN.MAHANGHOA HAVING SUM(HN.SOLUONG)!=0)         DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT * FROM TB_TON0_NL WHERE MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
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
            //        "'     GROUP BY HN.MAHANGHOA  having  SUM(HN.SOLUONG)!=0)  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY D.MANGUYENLIEU)   DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)        (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)ELSE '0' END,ISNULL(B1.DONGIA ,0)    FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_2 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG    WHERE ISNULL(B1.SOLUONG,0)>0 AND ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)!=0 )         DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(T2.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0)>0  THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0)    END ELSE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0) END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG) LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG   WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)      DELETE [TB_TON3] INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END AS DONGIA      FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) WHERE CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END!=0    GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0))       DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)           (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP_NL           WHERE CONVERT(datetime,ngaynhap,103)>='",
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
            //        "'),101))                INSERT INTO [TB_TON0_NL](MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT HH.MAHANGHOA,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))       /(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //        text2,
            //        "')),'00:00 ",
            //        text2,
            //        "'),101)        FROM TB_NGUYENLIEU HH LEFT JOIN TB_TON1 T1 ON T1.MAHANG=HH.MAHANGHOA LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG        WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)!=0)        DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG!=0  GROUP BY MAHANG)       DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG)        FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK          WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)        (SELECT DL.MANGUYENLIEU,SUM(ISNULL(NK.SOLUONG*DL.SL,0)),0 FROM TB_DINHLUONG DL LEFT JOIN [TB_XUATTRONGKY] NK         ON DL.MAHANGHOA=NK.MAHANG WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY DL.MANGUYENLIEU having SUM(SOLUONG)!=0)  DELETE TB_GIAVON INSERT INTO TB_GIAVON (MAHANG,GIAVON)(SELECT HH.MAHANGHOA,CASE WHEN ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)!=0         THEN CASE WHEN ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)>0   THEN CASE WHEN ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)!=0 THEN  ((ISNULL(NK.DONGIA,0)*(ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)))+(ISNULL(TK.DONGIA,0)*ISNULL(TK.SOLUONG,0)))         /(ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))  ELSE '0' END   ELSE ISNULL(TK.DONGIA,0) END ELSE '0' END AS GIAVON                FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_DK1 NK ON HH.MAHANGHOA=NK.MAHANG )LEFT JOIN TB_TK1 TK ON HH.MAHANGHOA=TK.MAHANG )LEFT JOIN TB_XTK1 XK        ON HH.MAHANGHOA=XK.MAHANG WHERE ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0) != 0)     DELETE TONKHO_NL  INSERT INTO TONKHO_NL(MAHANGHOA,SOLUONG,GIAVON)(  SELECT HH.MAHANGHOA,       (ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)) AS TON,     CASE WHEN ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)!=0         THEN CASE WHEN ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)>0   THEN CASE WHEN ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)!=0 THEN  ((ISNULL(NK.DONGIA,0)*(ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)))+(ISNULL(TK.DONGIA,0)*ISNULL(TK.SOLUONG,0)))         /(ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))  ELSE '0' END   ELSE ISNULL(TK.DONGIA,0) END ELSE '0' END AS GIAVON                FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_DK1 NK ON HH.MAHANGHOA=NK.MAHANG )LEFT JOIN TB_TK1 TK ON HH.MAHANGHOA=TK.MAHANG )LEFT JOIN TB_XTK1 XK        ON HH.MAHANGHOA=XK.MAHANG WHERE ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0) !=0)"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText2, sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteReader();
            //    sqlConnection.Close();
            //}
            //if (Frmnhapkhohanghoa.nhapkh == "True")
            //{
            //    this.Text = "NHẬP KHO HÀNG HÓA";
            //}
            //else if (Frmnhapkhohanghoa.nhapkh == "True1")
            //{
            //    this.Text = "NHẬP KHO NGUYÊN LIỆU";
            //    this.txtpthh.Visible = true;
            //    this.txtsohaohut.Visible = true;
            //}
            //else if (Frmnhapkhohanghoa.nhapkh == "True2")
            //{
            //    this.Text = "XUẤT KHO NGUYÊN LIỆU";
            //    this.txtpthh.Visible = true;
            //    this.txtsohaohut.Visible = true;
            //}
            //else if (Frmnhapkhohanghoa.nhapkh == "False")
            //{
            //    this.Text = "Xuất KHO HÀNG HÓA";
            //}
            //else if (Frmnhapkhohanghoa.nhapkh == "False1")
            //{
            //    this.Text = "Xuất HỦY KHO HÀNG HÓA";
            //}
            //else if (Frmnhapkhohanghoa.nhapkh == "chuyenkho")
            //{
            //    this.Text = "XUẤT CHUYỂN KHO";
            //    this.comboBox2.Visible = true;
            //    this.comboBox2.BringToFront();
            //    this.LOAD_khochuyen();
            //}
            //this.txtngaynhapkho.Text = Frmnhapkhohanghoa.ngaynhapkho;
            //this.loadnhomhang();
            //this.cobtienmat.SelectedIndex = 0;
            //if (TrangChu.mancc == "False")
            //{
            //    this.cobnhacungcap.Visible = false;
            //}
            //this.nhacungcap();
            //this.LOADGIA();
            //this.mahoadontieptheo();
            //if (TrangChu.giavon2 == "True")
            //{
            //    this.txtgiavon2.Visible = true;
            //    this.txtgv2.Visible = true;
            //}
            //this.loadtenhanghoa();
            //if (Settings.Default.mahangtudong == "True")
            //{
            //    this.cobhanghoa.Focus();
            //}
            //else
            //{
            //    this.txtmahh.Focus();
            //}
        }

        // Token: 0x060006D1 RID: 1745 RVA: 0x0013BB9C File Offset: 0x00139D9C
        private void loadtenhanghoa()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText;
            //    if (Frmnhapkhohanghoa.nhapkh == "True1" || Frmnhapkhohanghoa.nhapkh == "True2")
            //    {
            //        cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,'0' AS DONGIA FROM TB_NGUYENLIEU";
            //    }
            //    else
            //    {
            //        cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,DONGIA FROM TB_HANGHOA";
            //    }
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvhh.DataSource = dataTable;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006D2 RID: 1746 RVA: 0x0013BC58 File Offset: 0x00139E58
        private void cobloai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtthanhtien.Focus();
            }
        }

        // Token: 0x060006D3 RID: 1747 RVA: 0x0013BC84 File Offset: 0x00139E84
        private void loadgia1()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D4 RID: 1748 RVA: 0x0013BD44 File Offset: 0x00139F44
        private void loadgia2()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA2,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D5 RID: 1749 RVA: 0x0013BE04 File Offset: 0x0013A004
        private void loadgia3()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA3,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D6 RID: 1750 RVA: 0x0013BEC4 File Offset: 0x0013A0C4
        private void loadgia4()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA4,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D7 RID: 1751 RVA: 0x0013BF84 File Offset: 0x0013A184
        private void loadgia5()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA5,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D8 RID: 1752 RVA: 0x0013C044 File Offset: 0x0013A244
        private void loadgia6()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT ISNULL(DONGIA6,0) FROM TB_DONGIA WHERE MAHANGHOA='",
            //    this.txtmahh.Text,
            //    "' AND NCC='",
            //    this.cobnhacungcap.SelectedValue.ToString(),
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060006D9 RID: 1753 RVA: 0x0013C104 File Offset: 0x0013A304
        private void cobloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cobhanghoa.Text != "")
                {
                    if (this.cobloai.SelectedIndex == 0)
                    {
                        this.txtdongia.Text = this.g1;
                        this.txtdongia.Focus();
                    }
                    if (this.cobloai.SelectedIndex == 1)
                    {
                        this.txtdongia.Text = this.g2;
                        this.txtdongia.Focus();
                    }
                    if (this.cobloai.SelectedIndex == 2)
                    {
                        this.txtdongia.Text = this.g3;
                        this.txtdongia.Focus();
                    }
                    if (this.cobloai.SelectedIndex == 3)
                    {
                        this.txtdongia.Text = this.g4;
                        this.txtdongia.Focus();
                    }
                    if (this.cobloai.SelectedIndex == 4)
                    {
                        this.txtdongia.Text = this.g5;
                        this.txtdongia.Focus();
                    }
                    if (this.cobloai.SelectedIndex == 5)
                    {
                        this.txtdongia.Focus();
                        this.txtdongia.Text = this.g6;
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006DA RID: 1754 RVA: 0x0013C298 File Offset: 0x0013A498
        private void txtquydoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.tinhsoluong();
                if (this.txtquydoi.Text != "")
                {
                    this.thanhtien();
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006DB RID: 1755 RVA: 0x0001CC85 File Offset: 0x0001AE85
        private void GETHANGHOA(string mahang, string tenhang)
        {
            this.cobhanghoa.ValueMember = mahang;
            this.cobhanghoa.DisplayMember = tenhang;
            this.cobhanghoa.Text = tenhang;
        }

        // Token: 0x060006DC RID: 1756 RVA: 0x0013C2EC File Offset: 0x0013A4EC
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            //frmHangHoa frmHangHoa = new frmHangHoa();
            //frmHangHoa.chon = "chon";
            //frmHangHoa.mahang = new frmHangHoa.GetData(this.GETHANGHOA);
            //frmHangHoa.ShowDialog();
            //this.txtsoluong.Focus();
        }

        // Token: 0x060006DD RID: 1757 RVA: 0x0013C330 File Offset: 0x0013A530
        private void txtquydoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.txtdonvi2.ReadOnly)
                {
                    this.txtdonvi2.Focus();
                }
                else
                {
                    this.txtdongianhap.Focus();
                }
            }
        }

        // Token: 0x060006DE RID: 1758 RVA: 0x0001CCAF File Offset: 0x0001AEAF
        private void txtmahh_Enter(object sender, EventArgs e)
        {
            this.txtmahh.BackColor = Color.Yellow;
        }

        // Token: 0x060006DF RID: 1759 RVA: 0x0013C378 File Offset: 0x0013A578
        private void txtmahh_Leave(object sender, EventArgs e)
        {
            this.txtmahh.BackColor = Color.LemonChiffon;
            if (this.txtmahh.Text == "")
            {
                this.cobhanghoa.Focus();
            }
        }

        // Token: 0x060006E0 RID: 1760 RVA: 0x0013C3C0 File Offset: 0x0013A5C0
        private void txtmahh_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.txtquycach.Text = "1";
            //    if (Frmnhapkhohanghoa.nhapkh == "True" || Frmnhapkhohanghoa.nhapkh == "False1" || Frmnhapkhohanghoa.nhapkh == "chuyenkho")
            //    {
            //        string cmdText = "SELECT DONVITINH,ISNULL(DONGIA,0),DONVITINHLON ,DONVITINHLON3,ISNULL(QUYDOI1,1),TENHANGHOA,ISNULL(DONGIA2,0),ISNULL(DONGIA3,0),ISNULL(DONGIA4,0),ISNULL(DONGIA5,0),ISNULL(DONGIA6,0),ISNULL(CHIETKHAU,0),ISNULL(TONDONVI,'FALSE'),ISNULL(GIANHAP,0)  FROM tb_hanghoa where mahanghoa='" + this.txtmahh.Text + "'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //            this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //            this.txtdonvi2.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //            this.lbdonvi3.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //            this.txtquycach.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //            this.cobhanghoa.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //            this.g2 = Convert.ToString(sqlDataReader.GetValue(6));
            //            this.g3 = Convert.ToString(sqlDataReader.GetValue(7));
            //            this.g4 = Convert.ToString(sqlDataReader.GetValue(8));
            //            this.g5 = Convert.ToString(sqlDataReader.GetValue(9));
            //            this.g6 = Convert.ToString(sqlDataReader.GetValue(10));
            //            this.g1 = Convert.ToString(sqlDataReader.GetValue(1));
            //            if (this.txtdonvitinh.Text.Trim() == this.txtdonvi2.Text.Trim())
            //            {
            //                this.txtdonvi2.Visible = false;
            //                this.txtquydoi.Visible = false;
            //            }
            //            else
            //            {
            //                this.txtdonvi2.Visible = true;
            //                this.txtquydoi.Visible = true;
            //            }
            //            this.tondonvi_le = Convert.ToString(sqlDataReader.GetValue(12));
            //            this.txtgiaton.Text = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(13))).ToString("#,##0.##");
            //            this.txtdongianhap.Text = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(13))).ToString("#,##0.##");
            //            this.tonkho();
            //            this.luutenhang = "0";
            //            if (TrangChu.dungkhonguyenlieu == "True" && Frmnhapkhohanghoa.nhapkh == "True1")
            //            {
            //                string cmdText2 = "SELECT isnull(SUM(ISNULL(GV.GIAVON,0)*DL.SL),0) FROM TB_GIAVON GV ,TB_DINHLUONG DL WHERE GV.MAHANG=DL.MANGUYENLIEU AND DL.MAHANGHOA='" + this.txtmahh.Text + "'";
            //                sqlConnection.Close();
            //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //                sqlConnection.Open();
            //                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            //                if (sqlDataReader2.Read())
            //                {
            //                    this.txtdongianhap.Text = Convert.ToDecimal(Convert.ToString(sqlDataReader2.GetValue(0))).ToString("#,##0");
            //                }
            //                sqlConnection.Close();
            //            }
            //            this.txtdonvitinh.ReadOnly = true;
            //            this.txtdonvi2.ReadOnly = true;
            //            this.txtdongia.ReadOnly = true;
            //            this.lbqd.Visible = false;
            //            this.txtquycach.Visible = false;
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.cobloai.SelectedIndex = 0;
            //            this.luutenhang = "1";
            //            this.cobhanghoa.Text = "";
            //            this.lbdonvi3.Text = "Đvt";
            //            this.txtdonvitinh.Text = "Đvt";
            //            this.txtdongia.Text = "0";
            //            this.txtsoluongton.Text = "0";
            //            this.txtquycach.Text = "1";
            //            this.txtdonvi2.Text = "Đvt2";
            //        }
            //        sqlConnection.Close();
            //    }
            //    else if (Frmnhapkhohanghoa.nhapkh == "False")
            //    {
            //        this.xuatkho();
            //    }
            //    else if (Frmnhapkhohanghoa.nhapkh == "True1")
            //    {
            //        this.nhapkhonguyenlieu();
            //    }
            //    else if (Frmnhapkhohanghoa.nhapkh == "True2")
            //    {
            //        this.xuatkho_nl();
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E1 RID: 1761 RVA: 0x0013C890 File Offset: 0x0013AA90
        private void xuatkho_nl()
        {
            //try
            //{
            //    string cmdText = "SELECT TOP 1 DONVITINH,ISNULL(hn.DONGIA,0),DONVITINH ,DONVITINH,'1',TENHANGHOA,'0','0','0','0','0',isnull(hn.dongia,0) \r\nFROM tb_nguyenlieu hh, TB_HANGHOANHAP_NL hn where hh.MAHANGHOA=hn.MAHANGHOA and hh.mahanghoa='" + this.txtmahh.Text + "'  order by mahoadon DESC";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //        this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtdonvi2.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.lbdonvi3.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //        this.txtquycach.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //        this.cobhanghoa.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.g2 = Convert.ToString(sqlDataReader.GetValue(6));
            //        this.g3 = Convert.ToString(sqlDataReader.GetValue(7));
            //        this.g4 = Convert.ToString(sqlDataReader.GetValue(8));
            //        this.g5 = Convert.ToString(sqlDataReader.GetValue(9));
            //        this.g6 = Convert.ToString(sqlDataReader.GetValue(10));
            //        this.txtdongianhap.Text = Convert.ToString(sqlDataReader.GetValue(11));
            //        this.g1 = Convert.ToString(sqlDataReader.GetValue(1));
            //        if (this.txtdonvitinh.Text.Trim() == this.txtdonvi2.Text.Trim())
            //        {
            //            this.txtdonvi2.Visible = false;
            //            this.txtquydoi.Visible = false;
            //        }
            //        else
            //        {
            //            this.txtdonvi2.Visible = true;
            //            this.txtquydoi.Visible = true;
            //        }
            //        this.tonkho_nl();
            //        this.luutenhang = "0";
            //        this.txtdonvitinh.ReadOnly = true;
            //        this.txtdonvi2.ReadOnly = true;
            //        this.txtdongia.ReadOnly = true;
            //        this.lbqd.Visible = false;
            //        this.txtquycach.Visible = false;
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.cobloai.SelectedIndex = 0;
            //        this.luutenhang = "1";
            //        this.cobhanghoa.Text = "";
            //        this.lbdonvi3.Text = "0";
            //        this.txtdonvitinh.Text = "Đvt";
            //        this.txtdongia.Text = "0";
            //        this.txtsoluongton.Text = "0";
            //        this.txtquycach.Text = "1";
            //        this.txtdonvi2.Text = "Đvt2";
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E2 RID: 1762 RVA: 0x0013CB9C File Offset: 0x0013AD9C
        private void nhapkhonguyenlieu()
        {
            //try
            //{
            //    string cmdText = "SELECT DONVITINH,'0','' ,'','1',TENHANGHOA,'0','0','0','0','0','0' FROM tb_nguyenlieu where mahanghoa='" + this.txtmahh.Text + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //        this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtdonvi2.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.lbdonvi3.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //        this.txtquycach.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //        this.cobhanghoa.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.g2 = Convert.ToString(sqlDataReader.GetValue(6));
            //        this.g3 = Convert.ToString(sqlDataReader.GetValue(7));
            //        this.g4 = Convert.ToString(sqlDataReader.GetValue(8));
            //        this.g5 = Convert.ToString(sqlDataReader.GetValue(9));
            //        this.g6 = Convert.ToString(sqlDataReader.GetValue(10));
            //        this.txtdongianhap.Text = Convert.ToString(sqlDataReader.GetValue(11));
            //        this.g1 = Convert.ToString(sqlDataReader.GetValue(1));
            //        if (this.txtdonvitinh.Text.Trim() == this.txtdonvi2.Text.Trim())
            //        {
            //            this.txtdonvi2.Visible = false;
            //            this.txtquydoi.Visible = false;
            //        }
            //        else
            //        {
            //            this.txtdonvi2.Visible = true;
            //            this.txtquydoi.Visible = true;
            //        }
            //        this.tonkho_nl();
            //        this.luutenhang = "0";
            //        this.txtdonvitinh.ReadOnly = true;
            //        this.txtdonvi2.ReadOnly = true;
            //        this.txtdongia.ReadOnly = true;
            //        this.lbqd.Visible = false;
            //        this.txtquycach.Visible = false;
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.cobloai.SelectedIndex = 0;
            //        this.luutenhang = "1";
            //        this.cobhanghoa.Text = "";
            //        this.lbdonvi3.Text = "Đvt";
            //        this.txtdonvitinh.Text = "Đvt";
            //        this.txtdongia.Text = "0";
            //        this.txtsoluongton.Text = "0";
            //        this.txtquycach.Text = "1";
            //        this.txtdonvi2.Text = "Đvt2";
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E3 RID: 1763 RVA: 0x0013CEA8 File Offset: 0x0013B0A8
        private void xuatkho()
        {
            //try
            //{
            //    string cmdText = "SELECT DONVITINH,ISNULL(hn.DONGIA,0),DONVITINHLON ,DONVITINHLON3,ISNULL(QUYDOI1,1),TENHANGHOA,ISNULL(DONGIA2,0),ISNULL(DONGIA3,0),ISNULL(DONGIA4,0),ISNULL(DONGIA5,0),ISNULL(DONGIA6,0),isnull(hn.dongia,0) \r\nFROM tb_hanghoa hh, TB_HANGHOANHAP hn where hh.MAHANGHOA=hn.MAHANGHOA and hh.mahanghoa='" + this.txtmahh.Text + "'  order by mahoadon DESC";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //        this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtdonvi2.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.lbdonvi3.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //        this.txtquycach.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //        this.cobhanghoa.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.g2 = Convert.ToString(sqlDataReader.GetValue(6));
            //        this.g3 = Convert.ToString(sqlDataReader.GetValue(7));
            //        this.g4 = Convert.ToString(sqlDataReader.GetValue(8));
            //        this.g5 = Convert.ToString(sqlDataReader.GetValue(9));
            //        this.g6 = Convert.ToString(sqlDataReader.GetValue(10));
            //        this.txtdongianhap.Text = Convert.ToString(sqlDataReader.GetValue(11));
            //        this.g1 = Convert.ToString(sqlDataReader.GetValue(1));
            //        if (this.txtdonvitinh.Text.Trim() == this.txtdonvi2.Text.Trim())
            //        {
            //            this.txtdonvi2.Visible = false;
            //            this.txtquydoi.Visible = false;
            //        }
            //        else
            //        {
            //            this.txtdonvi2.Visible = true;
            //            this.txtquydoi.Visible = true;
            //        }
            //        this.tonkho();
            //        this.luutenhang = "0";
            //        this.txtdonvitinh.ReadOnly = true;
            //        this.txtdonvi2.ReadOnly = true;
            //        this.txtdongia.ReadOnly = true;
            //        this.lbqd.Visible = false;
            //        this.txtquycach.Visible = false;
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.cobloai.SelectedIndex = 0;
            //        this.luutenhang = "1";
            //        this.cobhanghoa.Text = "";
            //        this.lbdonvi3.Text = "Đvt";
            //        this.txtdonvitinh.Text = "Đvt";
            //        this.txtdongia.Text = "0";
            //        this.txtsoluongton.Text = "0";
            //        this.txtquycach.Text = "1";
            //        this.txtdonvi2.Text = "Đvt2";
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E4 RID: 1764 RVA: 0x0013D1B4 File Offset: 0x0013B3B4
        private void tonkho()
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1    FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND HH.MAHANGHOA='",
            //        this.txtmahh.Text.Trim(),
            //        "' AND HN.LOAI='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.NCC) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "', CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        " ELSE '0' END END AS SOLUONGTONG,  CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when HHX.DONVITINH!=HH.DONVITINH THEN CASE WHEN HH.TONDONVI='FALSE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END ELSE CASE WHEN HH.TONDONVI='TRUE' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)ELSE '0' END END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        " ELSE '0' END END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' AND HH.MAHANGHOA='",
            //        this.txtmahh.Text.Trim(),
            //        "' AND HHX.NCC='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1,HHX.NCC,HH.TONDONVI) DELETE TB_LAILO INSERT INTO TB_LAILO(MAHOADON,KHACHHANG,THANHTIEN,LAILO)(SELECT MAHANGHOA,NCC,SUM(ISNULL(SOLUONGTONG,0)),'0' FROM TB_TONGHANGHOANHAP GROUP BY MAHANGHOA,NCC) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT CASE WHEN isnull(hhn.THANHTIEN,0)!=0 THEN hhn.MAHOADON ELSE HHX.MAHANGHOA END AS MAHANG,  CASE WHEN isnull(hhn.THANHTIEN,0)!=0 THEN hhn.KHACHHANG ELSE HHX.TENDONVI END AS MAKHO , '0', '0', '0', '0', '0', '0',(isnull(hhn.THANHTIEN,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_LAILO HHN FULL JOIN TB_XUATTAM HHX  ON HHN.MAHOADON=HHX.MAHANGHOA  group by hhn.MAHOADON,isnull(hhn.THANHTIEN,0),HHN.KHACHHANG,HHX.MAHANGHOA,HHX.TENDONVI)  SELECT isnull(soluongTONG,0) FROM TB_TONKHO WHERE MAHANGHOA='",
            //        this.txtmahh.Text.Trim(),
            //        "' AND NCC='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "' "
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        if (this.tondonvi_le == "False")
            //        {
            //            this.txtsoluongton.Text = (Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(0))) / double.Parse(this.txtquycach.Text)).ToString("#,##0.##");
            //        }
            //        else
            //        {
            //            this.txtsoluongton.Text = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0.##");
            //        }
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.txtsoluongton.Text = "0";
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E5 RID: 1765 RVA: 0x0013D404 File Offset: 0x0013B604
        private void tonkho_nl()
        {
            //if (TrangChu.dungkhonguyenlieu == "True")
            //{
            //    try
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = "SELECT isnull(SOLUONG,0), isnull(GIAVON,0) FROM TONKHO_NL WHERE mahanghoa='" + this.txtmahh.Text + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txtsoluongton.Text = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0.##");
            //            this.txtgiaton.Text = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(1))).ToString("#,##0");
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            this.txtgiaton.Text = "0";
            //            this.txtsoluongton.Text = "0";
            //        }
            //        sqlConnection.Close();
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x060006E6 RID: 1766 RVA: 0x0009B888 File Offset: 0x00099A88
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

        // Token: 0x060006E7 RID: 1767 RVA: 0x0013D530 File Offset: 0x0013B730
        private void loadhanghoatheoma()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText;
            //    if (Frmnhapkhohanghoa.nhapkh == "True1" || Frmnhapkhohanghoa.nhapkh == "True2")
            //    {
            //        cmdText = string.Concat(new string[]
            //        {
            //            "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,'0' AS DONGIA FROM TB_NGUYENLIEU WHERE MAHANGHOA LIKE N'%",
            //            this.txtchuoi.Text.Trim(),
            //            "%' or TENHANGHOA LIKE N'%",
            //            this.txtchuoi.Text,
            //            "%'"
            //        });
            //    }
            //    else
            //    {
            //        cmdText = string.Concat(new string[]
            //        {
            //            "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,DONGIA FROM TB_HANGHOA WHERE MAHANGHOA LIKE N'%",
            //            this.txtchuoi.Text.Trim(),
            //            "%' or TENHANGHOA LIKE N'%",
            //            this.txtchuoi.Text,
            //            "%' OR TENHANGHOA_KHONGDAU LIKE N'%",
            //            this.txtchuoi.Text,
            //            "%'"
            //        });
            //    }
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvhh.DataSource = dataTable;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060006E8 RID: 1768 RVA: 0x0013D6A0 File Offset: 0x0013B8A0
        private void txtmahh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.cobhanghoa.Text != "")
                {
                    this.txtsoluong.Focus();
                }
                else
                {
                    this.cobhanghoa.Focus();
                }
            }
        }

        // Token: 0x060006E9 RID: 1769 RVA: 0x0013D6FC File Offset: 0x0013B8FC
        private void txtthanhtien_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtthanhtien.Text == "")
                {
                    this.txtthanhtien.Text = "0";
                }
                if (this.txtdongianhap.Text == "0")
                {
                    decimal d = decimal.Parse(this.txtthanhtien.Text);
                    decimal d2 = decimal.Parse(this.txtsoluongquydoi.Text);
                    decimal d3 = decimal.Parse(this.txtquycach.Text);
                    decimal num = d / d2 * d3;
                    this.txtdongianhap.Text = num.ToString();
                }
                this.txtthanhtien.BackColor = Color.LemonChiffon;
            }
            catch
            {
            }
        }

        // Token: 0x060006EA RID: 1770 RVA: 0x0001CCC3 File Offset: 0x0001AEC3
        private void cobhanghoa_Enter(object sender, EventArgs e)
        {
            this.cobhanghoa.BackColor = Color.Yellow;
        }

        // Token: 0x060006EB RID: 1771 RVA: 0x0001CCD7 File Offset: 0x0001AED7
        private void cobhanghoa_Leave(object sender, EventArgs e)
        {
            this.cobhanghoa.BackColor = Color.LemonChiffon;
        }

        // Token: 0x060006EC RID: 1772 RVA: 0x0013D7D8 File Offset: 0x0013B9D8
        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(this.txtdongia.Text) > 999.0)
                {
                    this.txtdongia.Text = double.Parse(this.txtdongia.Text).ToString("#,##0");
                    this.txtdongia.SelectionStart = this.txtdongia.TextLength;
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006ED RID: 1773 RVA: 0x0013D864 File Offset: 0x0013BA64
        private void txtchietkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtck2.Focus();
            }
        }

        // Token: 0x060006EE RID: 1774 RVA: 0x0013D890 File Offset: 0x0013BA90
        private void thanhtien()
        {
            try
            {
                if (this.cobhanghoa.Text != "")
                {
                    if (this.txtdongianhap.Text != "")
                    {
                        if (double.Parse(this.txtsoluong.Text) + double.Parse(this.txtquydoi.Text) != 0.0)
                        {
                            double num = double.Parse(this.txtvat.Text);
                            double num2 = double.Parse(this.txtsoluongquydoi.Text);
                            double num3 = double.Parse(this.txtquycach.Text);
                            double num4 = double.Parse(this.txtdongianhap.Text);
                            if (this.txtsoluong.Text == "0")
                            {
                                num4 *= num3;
                            }
                            double num5 = num4 - num4 * (double.Parse(this.txtchietkhau.Text) / 100.0);
                            double num6 = num5 - num5 * (double.Parse(this.txtck2.Text) / 100.0);
                            double num7 = num6 - num6 * (double.Parse(this.txtck3.Text) / 100.0);
                            double num8 = num7 * (double.Parse(this.txtvat.Text) / 100.0);
                            this.txtdongiack.Text = (num7 + num8).ToString("#,##0.##");
                            this.txtthanhtien.Text = ((num7 + num8) * (num2 / num3)).ToString();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x060006EF RID: 1775 RVA: 0x0001CCEB File Offset: 0x0001AEEB
        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            this.thanhtien();
        }

        // Token: 0x060006F0 RID: 1776 RVA: 0x0013DA88 File Offset: 0x0013BC88
        private void txtchietkhau_Leave(object sender, EventArgs e)
        {
            if (this.txtchietkhau.Text == "")
            {
                this.txtchietkhau.Text = "0";
            }
        }

        // Token: 0x060006F1 RID: 1777 RVA: 0x0013DAC4 File Offset: 0x0013BCC4
        private void txtsoluong_Leave(object sender, EventArgs e)
        {
            if (this.txtsoluong.Text == "")
            {
                this.txtsoluong.Text = "0";
            }
            else
            {
                try
                {
                    this.tinhsoluong();
                }
                catch
                {
                }
            }
            this.txtsoluong.BackColor = Color.LemonChiffon;
        }

        // Token: 0x060006F2 RID: 1778 RVA: 0x0013DB38 File Offset: 0x0013BD38
        private void txtquydoi_Leave(object sender, EventArgs e)
        {
            if (this.txtquydoi.Text == "")
            {
                this.txtquydoi.Text = "0";
            }
            if (double.Parse(this.txtquydoi.Text) + double.Parse(this.txtsoluong.Text) == 0.0)
            {
                this.txtsoluong.Focus();
            }
        }

        // Token: 0x060006F3 RID: 1779 RVA: 0x0013DBB8 File Offset: 0x0013BDB8
        private void dgvhh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvhh.RowCount > 0)
            {
                int index = this.dgvhh.CurrentRow.Index;
                string text = this.dgvhh["Mahang", index].Value.ToString();
                this.txtmahh.Text = text;
                this.txtsoluong.Text = "1";
                this.txtsoluong.Focus();
            }
        }

        // Token: 0x060006F4 RID: 1780 RVA: 0x0013DC34 File Offset: 0x0013BE34
        private void txtchuoi_TextChanged(object sender, EventArgs e)
        {
            if (this.txtchuoi.Text != this.txtchuoi.Tag.ToString())
            {
                if (this.txtchuoi.Text != "")
                {
                    this.loadhanghoatheoma();
                }
            }
        }

        // Token: 0x060006F5 RID: 1781 RVA: 0x0013DBB8 File Offset: 0x0013BDB8
        private void dgvhh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvhh.RowCount > 0)
            {
                int index = this.dgvhh.CurrentRow.Index;
                string text = this.dgvhh["Mahang", index].Value.ToString();
                this.txtmahh.Text = text;
                this.txtsoluong.Text = "1";
                this.txtsoluong.Focus();
            }
        }

        // Token: 0x060006F6 RID: 1782 RVA: 0x0013DC90 File Offset: 0x0013BE90
        private void txtsoluongquydoi_TextChanged(object sender, EventArgs e)
        {
            if (this.txtsoluongquydoi.Text == "0")
            {
                this.txtsoluongquydoi.Text = "1";
            }
            if (this.txtsoluongquydoi.Text == "")
            {
                this.txtsoluongquydoi.Text = "1";
            }
        }

        // Token: 0x060006F7 RID: 1783 RVA: 0x0013DCF8 File Offset: 0x0013BEF8
        private void txtdongianhap_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtdongianhap.Text == "")
                {
                    this.txtdongianhap.Text = "0";
                }
                double num = double.Parse(this.txtdongianhap.Text);
                if (num != 0.0)
                {
                    this.txtdongianhap.Text = num.ToString("#,##0.##");
                    this.txtdongianhap.SelectionStart = this.txtdongianhap.TextLength;
                }
                if (this.txtthanhtien.Text == "0")
                {
                    this.thanhtien();
                }
            }
            catch
            {
            }
            this.txtdongianhap.BackColor = Color.LemonChiffon;
        }

        // Token: 0x060006F8 RID: 1784 RVA: 0x0013DDD8 File Offset: 0x0013BFD8
        private void txtdongianhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtdongianhap.Text == "0")
                {
                    this.txtthanhtien.Focus();
                }
                else if (!this.txtgiavon2.Visible)
                {
                    this.txtchietkhau.Focus();
                }
                else
                {
                    this.txtgiavon2.Focus();
                }
            }
        }

        // Token: 0x060006F9 RID: 1785 RVA: 0x0001CCF5 File Offset: 0x0001AEF5
        private void btluu_Enter(object sender, EventArgs e)
        {
            this.btluu.BackColor = Color.Red;
        }

        // Token: 0x060006FA RID: 1786 RVA: 0x0001CD09 File Offset: 0x0001AF09
        private void btluu_Leave(object sender, EventArgs e)
        {
            this.btluu.BackColor = Color.Blue;
        }

        // Token: 0x060006FB RID: 1787 RVA: 0x0013DE50 File Offset: 0x0013C050
        private void txtck3_Leave(object sender, EventArgs e)
        {
            if (this.txtck3.Text == "")
            {
                this.txtck3.Text = "0";
            }
        }

        // Token: 0x060006FC RID: 1788 RVA: 0x0013DE8C File Offset: 0x0013C08C
        private void txtck2_Leave(object sender, EventArgs e)
        {
            if (this.txtck2.Text == "")
            {
                this.txtck2.Text = "0";
            }
        }

        // Token: 0x060006FD RID: 1789 RVA: 0x0013DEC8 File Offset: 0x0013C0C8
        private void txtck2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtck3.Focus();
            }
        }

        // Token: 0x060006FE RID: 1790 RVA: 0x0013DEF4 File Offset: 0x0013C0F4
        private void txtck3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtvat.Focus();
            }
        }

        // Token: 0x060006FF RID: 1791 RVA: 0x0013DF20 File Offset: 0x0013C120
        private void txtdongianhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.thanhtien();
            }
            catch
            {
            }
        }

        // Token: 0x06000700 RID: 1792 RVA: 0x0001CCEB File Offset: 0x0001AEEB
        private void txtck2_TextChanged(object sender, EventArgs e)
        {
            this.thanhtien();
        }

        // Token: 0x06000701 RID: 1793 RVA: 0x0001CCEB File Offset: 0x0001AEEB
        private void txtck3_TextChanged(object sender, EventArgs e)
        {
            this.thanhtien();
        }

        // Token: 0x06000702 RID: 1794 RVA: 0x0013DF50 File Offset: 0x0013C150
        private void txtdongiack_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdongiack.Text == "")
            {
                this.txtdongiack.Text = "0";
            }
        }

        // Token: 0x06000703 RID: 1795 RVA: 0x0013DF8C File Offset: 0x0013C18C
        private void txtmancc_Leave(object sender, EventArgs e)
        {
            if (this.txtmancc.Text == "")
            {
                this.txtmancc.Text = this.txtmancc.Tag.ToString();
            }
        }

        // Token: 0x06000704 RID: 1796 RVA: 0x0013DFD4 File Offset: 0x0013C1D4
        private void txtmancc_Enter(object sender, EventArgs e)
        {
            if (this.txtmancc.Text == this.txtmancc.Tag.ToString())
            {
                this.txtmancc.Text = "";
            }
        }

        // Token: 0x06000705 RID: 1797 RVA: 0x0013E01C File Offset: 0x0013C21C
        private void txttenncc_Leave(object sender, EventArgs e)
        {
            if (this.txttenncc.Text == "")
            {
                this.txttenncc.Text = this.txttenncc.Tag.ToString();
            }
        }

        // Token: 0x06000706 RID: 1798 RVA: 0x0013E064 File Offset: 0x0013C264
        private void txttenncc_Enter(object sender, EventArgs e)
        {
            if (this.txttenncc.Text == this.txttenncc.Tag.ToString())
            {
                this.txttenncc.Text = "";
                this.txtmancc.Text = "";
            }
        }

        // Token: 0x06000707 RID: 1799 RVA: 0x0013E0C0 File Offset: 0x0013C2C0
        private void txtchuoi_Leave(object sender, EventArgs e)
        {
            if (this.txtchuoi.Text == "")
            {
                this.txtchuoi.Text = this.txtchuoi.Tag.ToString();
            }
        }

        // Token: 0x06000708 RID: 1800 RVA: 0x0013E108 File Offset: 0x0013C308
        private void txtchuoi_Enter(object sender, EventArgs e)
        {
            if (this.txtchuoi.Text == this.txtchuoi.Tag.ToString())
            {
                this.txtchuoi.Text = "";
            }
        }

        // Token: 0x06000709 RID: 1801 RVA: 0x0013E150 File Offset: 0x0013C350
        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //    {
            //        if (this.txtmancc.Text != "")
            //        {
            //            string cmdText = "SELECT TENDONVI FROM tb_KHACHHANG where MAKHACHHANG=N'" + this.txtmancc.Text + "'";
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.Read())
            //            {
            //                this.txttenncc.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //            }
            //            if (!sqlDataReader.HasRows)
            //            {
            //                this.txttenncc.Text = "";
            //            }
            //            sqlConnection.Close();
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600070A RID: 1802 RVA: 0x0013E268 File Offset: 0x0013C468
        private void txtmancc_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        string cmdText = "SELECT MAKHACHHANG, TENDONVI FROM tb_KHACHHANG where TENDONVI LIKE N'%" + this.txtmancc.Text + "%'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            this.txtmancc.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //            this.txttenncc.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            MessageBox.Show("Không tìm thấy NHÀ CUNG CẤP này", "Thông Báo");
            //        }
            //        sqlConnection.Close();
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x0600070B RID: 1803 RVA: 0x0013E35C File Offset: 0x0013C55C
        private void bttim_Click(object sender, EventArgs e)
        {
            Frmkhachhang.chon = "nk";
            Frmkhachhang frmkhachhang = new Frmkhachhang();
           // frmkhachhang.ShowDialog();
            this.txtmancc.Text = Frmnhapkhohanghoa.mancc;
            this.txtmahh.Focus();
            this.mahoadontieptheo();
        }

        // Token: 0x0600070C RID: 1804 RVA: 0x0013E3A8 File Offset: 0x0013C5A8
        private void dgvchitiethoadon_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    int rowIndex = this.dgvchitiethoadon.CurrentCell.RowIndex;
            //    string text = this.dgvchitiethoadon.Rows[rowIndex].Cells["mahanghoa"].Value.ToString();
            //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa   " + text + "   không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE TB_HANGHOANHAP WHERE MAHOADON='",
            //            this.txtsohoadon.Text,
            //            "' AND MAHANGHOA='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        this.dgvchitiethoadon.Rows.RemoveAt(rowIndex);
            //    }
            //}
        }

        // Token: 0x0600070D RID: 1805 RVA: 0x0013E4C0 File Offset: 0x0013C6C0
        private void Frmnhapkhohanghoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.btluu_Click(null, null);
            }
        }

        // Token: 0x0600070E RID: 1806 RVA: 0x0013E4E8 File Offset: 0x0013C6E8
        private void dgvchitiethoadon_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.dgvchitiethoadon, "Nhấn Chuột Phải hoặc Phím Delete <Del> Để Xóa");
        }

        // Token: 0x0600070F RID: 1807 RVA: 0x0013E510 File Offset: 0x0013C710
        private void mahoadontieptheo()
        {
            //try
            //{
            //    string selectCommandText;
            //    if (Frmnhapkhohanghoa.nhapkh == "True1")
            //    {
            //        selectCommandText = "select isnull(MAX(MAHOADON),'000000000') from TB_HANGHOANHAP_NL where CONVERT(DATETIME,NGAYNHAP,103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            //    }
            //    else
            //    {
            //        selectCommandText = "select isnull(MAX(MAHOADON),'000000000') from TB_HANGHOANHAP where CONVERT(DATETIME,NGAYNHAP,103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            //    }
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
            //        string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(0, 6));
            //        text = DateTime.Now.ToString("ddMMyy");
            //        if (a == text)
            //        {
            //            if (dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Length == 6)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6, 2));
            //            }
            //            if (dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Length == 7)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6, 3));
            //            }
            //            if (dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Length == 8)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6, 4));
            //            }
            //            if (dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Length == 9)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6, 5));
            //            }
            //            if (dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Length > 9)
            //            {
            //                num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6, 5));
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
            //    this.txtsohoadon.Text = text;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000710 RID: 1808 RVA: 0x0013E968 File Offset: 0x0013CB68
        private void themhangmoi()
        {
            //if (this.cobhanghoa.Text != "")
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    if (this.txtmanhom.Text != "")
            //    {
            //        this.manhom = this.txtmanhom.Text;
            //    }
            //    else if (this.cobnhom.Text == "")
            //    {
            //        string cmdText = "INSERT INTO [TB_NHOMHANG]([MANHOM],[TENNHOM])values('NH',N'NHÓM HÀNG')";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        this.manhom = "NH";
            //    }
            //    else
            //    {
            //        string selectCommandText = "select isnull(MAX(MANHOM),'MN000') from Tb_NHOMHANG where left(MANHOM,2)='MN' and len(MANHOM)='5'";
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
            //        DataTable dataTable = new DataTable();
            //        sqlDataAdapter.Fill(dataTable);
            //        if (dataTable.Rows.Count <= 0)
            //        {
            //            this.manhom = "MN001";
            //        }
            //        else
            //        {
            //            string a = Convert.ToString(dataTable.Rows[0][0].ToString().Substring(0, 2));
            //            string text = "MN";
            //            if (a == text)
            //            {
            //                double num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(2, 3));
            //                num += 1.0;
            //                if (num < 10.0)
            //                {
            //                    text += "00";
            //                }
            //                else if (num < 100.0)
            //                {
            //                    text += "0";
            //                }
            //                text += num.ToString();
            //            }
            //            else
            //            {
            //                text = "MN001";
            //            }
            //            this.manhom = text;
            //        }
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "INSERT INTO [TB_NHOMHANG]([MANHOM],[TENNHOM])values('",
            //            this.manhom,
            //            "',N'",
            //            this.cobnhom.Text,
            //            "')"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        this.txtmanhom.Text = this.manhom;
            //    }
            //    if (this.txtmahh.Text == "")
            //    {
            //        string selectCommandText = "select isnull(MAX(mahanghoa),'0') from Tb_HANGHOA where len(mahanghoa)='5' group by MAHANGHOA having ISNUMERIC(mahanghoa)=1 order by MAHANGHOA desc";
            //        if (sqlConnection.State == ConnectionState.Open)
            //        {
            //            sqlConnection.Close();
            //        }
            //        if (sqlConnection.State == ConnectionState.Closed)
            //        {
            //            sqlConnection.Open();
            //        }
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
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
            //        this.mahang = text;
            //    }
            //    else
            //    {
            //        this.mahang = this.txtmahh.Text.Trim().ToUpper();
            //    }
            //    string text2 = this.txtdonvi2.Text;
            //    if (this.txtdonvi2.Text == this.txtdonvi2.Tag.ToString())
            //    {
            //        text2 = this.txtdonvitinh.Text;
            //    }
            //    else if (this.txtdonvi2.Text == "")
            //    {
            //        text2 = this.txtdonvitinh.Text;
            //    }
            //    if (this.txtquycach.Text == "")
            //    {
            //        this.txtquycach.Text = "1";
            //    }
            //    if (this.txtquycach.Text == "0")
            //    {
            //        this.txtquycach.Text = "1";
            //    }
            //    string text3 = this.NonUnicode(this.cobhanghoa.Text);
            //    string text4 = "";
            //    string[] array = text3.Split(new char[]
            //    {
            //        ' '
            //    });
            //    foreach (string text5 in array)
            //    {
            //        text4 += text5.ToString().Substring(0, 1);
            //    }
            //    string cmdText2 = string.Concat(new object[]
            //    {
            //        "INSERT INTO [TB_HANGHOA]([MANHOM],[MAHANGHOA],[TENHANGHOA],[DONVITINH],[DONGIA],[DONGIA2],[DONGIA3],[DONGIA4],[DONGIA5],[DONGIA6],[VAT],[GHICHU],[QUYDOI],[DONVITINHLON],[CHIETKHAU],[NCC],[QUYDOI1],[DONVITINHLON3],Diem,TENHANGHOA_KHONGDAU,SL1,SL2,SL3,SL4,SL5,SL6,SL_CANHBAO,SLBAN,SLTANG,MAHANG,GIANHAP,KYTUDAU,TONDONVI)\r\nVALUES ('",
            //        this.manhom,
            //        "',N'",
            //        this.mahang,
            //        "',N'",
            //        this.cobhanghoa.Text,
            //        "',N'",
            //        this.txtdonvitinh.Text,
            //        "','",
            //        double.Parse(this.g1),
            //        "','",
            //        double.Parse(this.g2),
            //        "','",
            //        double.Parse(this.g3),
            //        "','",
            //        double.Parse(this.g4),
            //        "','",
            //        double.Parse(this.g5),
            //        "','",
            //        double.Parse(this.g6),
            //        "','0','','1',N'",
            //        text2,
            //        "','0','CTY','",
            //        this.txtquycach.Text,
            //        "','0','0',N'",
            //        text3,
            //        "','0','0','0','0','0','0','0','0','0','0','",
            //        double.Parse(this.txtdongiack.Text),
            //        "','",
            //        text4,
            //        "','FALSE')"
            //    });
            //    SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlCommand2.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //this.cobnhom.Visible = false;
        }

        // Token: 0x06000711 RID: 1809 RVA: 0x0013F068 File Offset: 0x0013D268
        private void txtdonvitinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.txtquydoi.Visible)
                {
                    this.txtquydoi.Focus();
                }
                else
                {
                    this.txtdonvi2.Focus();
                }
            }
        }

        // Token: 0x06000712 RID: 1810 RVA: 0x0013F0B4 File Offset: 0x0013D2B4
        private void txtdonvi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtquycach.Focus();
            }
        }

        // Token: 0x06000713 RID: 1811 RVA: 0x0013F0E0 File Offset: 0x0013D2E0
        private void txtquycach_Leave(object sender, EventArgs e)
        {
            if (this.txtquycach.Text == "")
            {
                this.txtquycach.Text = "1";
            }
            if (this.txtquycach.Text == "0")
            {
                this.txtquycach.Text = "1";
            }
        }

        // Token: 0x06000714 RID: 1812 RVA: 0x0013F148 File Offset: 0x0013D348
        private void txtquycach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdongia.Focus();
            }
        }

        // Token: 0x06000715 RID: 1813 RVA: 0x0013F174 File Offset: 0x0013D374
        private void txtdongia_Leave(object sender, EventArgs e)
        {
            if (this.txtdongia.Text == "")
            {
                this.txtdongia.Text = "0";
            }
            else
            {
                if (this.cobloai.SelectedIndex == 0)
                {
                    this.g1 = this.txtdongia.Text;
                }
                if (this.cobloai.SelectedIndex == 1)
                {
                    this.g2 = this.txtdongia.Text;
                }
                if (this.cobloai.SelectedIndex == 2)
                {
                    this.g3 = this.txtdongia.Text;
                }
                if (this.cobloai.SelectedIndex == 3)
                {
                    this.g4 = this.txtdongia.Text;
                }
                if (this.cobloai.SelectedIndex == 4)
                {
                    this.g5 = this.txtdongia.Text;
                }
                if (this.cobloai.SelectedIndex == 5)
                {
                    this.g6 = this.txtdongia.Text;
                }
            }
        }

        // Token: 0x06000716 RID: 1814 RVA: 0x0013F2A8 File Offset: 0x0013D4A8
        private void txtquycach_TextChanged(object sender, EventArgs e)
        {
            if (this.txtquycach.Visible)
            {
                try
                {
                    this.tinhsoluong();
                }
                catch
                {
                }
            }
        }

        // Token: 0x06000717 RID: 1815 RVA: 0x0013F2EC File Offset: 0x0013D4EC
        private void NHAPEXCEL()
        {
            //this.openFileDialog1.Filter = "Excel File(2003)|*.xls|Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //if (!File.Exists(this.openFileDialog1.FileName))
            //{
            //    new Process
            //    {
            //        StartInfo =
            //        {
            //            FileName = Application.StartupPath + "\\EXCEL\\NHAPKHO.xlsx"
            //        }
            //    }.Start();
            //}
            //else
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
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        DataTable dataTable = new DataTable();
            //        oleDbDataAdapter.Fill(dataTable);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            if (dataTable.Rows[i]["SỐ LƯỢNG"].ToString() != "")
            //            {
            //                int num = 0;
            //                this.hhnObj.Stt = num + 1;
            //                this.hhnObj.Mahoadon = this.txtsohoadon.Text;
            //                this.hhnObj.Mahanghoa = dataTable.Rows[i]["MÃ HÀNG"].ToString();
            //                this.hhnObj.Soluong2 = "0";
            //                this.hhnObj.Soluong3 = "0";
            //                this.hhnObj.Soluong4 = "0";
            //                this.hhnObj.Soluong5 = "0";
            //                this.hhnObj.Soluong6 = "0";
            //                this.hhnObj.Soluong = float.Parse(dataTable.Rows[i]["SỐ LƯỢNG"].ToString()).ToString();
            //                this.hhnObj.Dongia = float.Parse(dataTable.Rows[i]["ĐƠN GIÁ"].ToString()).ToString();
            //                this.hhnObj.Ngaynhap = this.dateTimePicker1.Text;
            //                this.hhnObj.Ghichu = "";
            //                this.hhnObj.Soluongquydoi = float.Parse(dataTable.Rows[i]["SỐ LƯỢNG"].ToString()).ToString();
            //                this.hhnObj.Vat = float.Parse(dataTable.Rows[i]["VAT"].ToString()).ToString();
            //                this.hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
            //                this.hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
            //                if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //                {
            //                    if (this.txtmancc.Text != "")
            //                    {
            //                        this.hhnObj.Ncc = this.txtmancc.Text;
            //                    }
            //                    else
            //                    {
            //                        this.hhnObj.Ncc = "CTY";
            //                    }
            //                }
            //                else
            //                {
            //                    this.hhnObj.Ncc = "CTY";
            //                }
            //                if (!this.xhdCtr.ADD_HANGHOANHAP(this.hhnObj))
            //                {
            //                    MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
            //                }
            //            }
            //        }
            //        MessageBox.Show("NHẬP THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
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

        // Token: 0x06000718 RID: 1816 RVA: 0x0013F7A4 File Offset: 0x0013D9A4
        private void NHAPEXCEL_NL()
        {
            //this.openFileDialog1.Filter = "Excel File(2003)|*.xls|Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //if (!File.Exists(this.openFileDialog1.FileName))
            //{
            //    new Process
            //    {
            //        StartInfo =
            //        {
            //            FileName = Application.StartupPath + "\\EXCEL\\NHAPKHO.xlsx"
            //        }
            //    }.Start();
            //}
            //else
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
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        DataTable dataTable = new DataTable();
            //        oleDbDataAdapter.Fill(dataTable);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            if (dataTable.Rows[i]["SỐ LƯỢNG"].ToString() != "")
            //            {
            //                int num = 0;
            //                this.hhnObj.Stt = num + 1;
            //                this.hhnObj.Mahoadon = this.txtsohoadon.Text;
            //                this.hhnObj.Mahanghoa = dataTable.Rows[i]["MÃ HÀNG"].ToString();
            //                this.hhnObj.Soluong2 = "0";
            //                this.hhnObj.Soluong3 = "0";
            //                this.hhnObj.Soluong4 = "0";
            //                this.hhnObj.Soluong5 = "0";
            //                this.hhnObj.Soluong6 = "0";
            //                this.hhnObj.Soluong = float.Parse(dataTable.Rows[i]["SỐ LƯỢNG"].ToString()).ToString();
            //                this.hhnObj.Dongia = float.Parse(dataTable.Rows[i]["ĐƠN GIÁ"].ToString()).ToString();
            //                this.hhnObj.Ngaynhap = this.dateTimePicker1.Text;
            //                this.hhnObj.Ghichu = "";
            //                this.hhnObj.Soluongquydoi = float.Parse(dataTable.Rows[i]["SỐ LƯỢNG"].ToString()).ToString();
            //                this.hhnObj.Vat = float.Parse(dataTable.Rows[i]["VAT"].ToString()).ToString();
            //                this.hhnObj.Loai = this.comboBox1.SelectedValue.ToString();
            //                this.hhnObj.Maloai = this.cobtienmat.SelectedIndex.ToString();
            //                if (this.txtmancc.Text != this.txtmancc.Tag.ToString())
            //                {
            //                    if (this.txtmancc.Text != "")
            //                    {
            //                        this.hhnObj.Ncc = this.txtmancc.Text;
            //                    }
            //                    else
            //                    {
            //                        this.hhnObj.Ncc = "CTY";
            //                    }
            //                }
            //                else
            //                {
            //                    this.hhnObj.Ncc = "CTY";
            //                }
            //                if (!this.xhdCtr.ADD_HANGHOANHAP_NL(this.hhnObj))
            //                {
            //                    MessageBox.Show("KHÔNG NHẬP KHO ĐƯỢC VUI LÒNG XEM LẠI", "THÔNG BÁO", MessageBoxButtons.OK);
            //                }
            //            }
            //        }
            //        MessageBox.Show("NHẬP THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
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

        // Token: 0x06000719 RID: 1817 RVA: 0x0013FC5C File Offset: 0x0013DE5C
        private void button1_Click(object sender, EventArgs e)
        {
            if (Frmnhapkhohanghoa.nhapkh == "True")
            {
                this.NHAPEXCEL();
            }
            else if (Frmnhapkhohanghoa.nhapkh == "True1")
            {
                this.NHAPEXCEL_NL();
            }
        }

        // Token: 0x0600071A RID: 1818 RVA: 0x0013FCA8 File Offset: 0x0013DEA8
        private void cobnhom_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtmanhom.Text = this.cobnhom.SelectedValue.ToString();
            }
            catch
            {
            }
        }

        // Token: 0x0600071B RID: 1819 RVA: 0x0013FCEC File Offset: 0x0013DEEC
        private void cobnhom_TextChanged(object sender, EventArgs e)
        {
            if (this.cobnhom.Text == "")
            {
                this.txtmanhom.Text = "";
            }
        }

        // Token: 0x0600071C RID: 1820 RVA: 0x0013FD28 File Offset: 0x0013DF28
        private void Frmnhapkhohanghoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //{
            //    "DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM DELETE FROM TB_TONGHANGHOANHAP INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONGQUYDOI),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1 \r\n                             FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0) ELSE '0' END WHEN LOAI='C' THEN case when (HHX.DONVITINH)=(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //    TrangChu.doicm,
            //    " ELSE '0' END END AS SOLUONGTONG,case when (HHX.DONVITINH)!=(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //    TrangChu.tile,
            //    ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //    TrangChu.doicm,
            //    "*HH.QUYDOI1 END   END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,(HHX.DONVITINH),(HH.DONVITINH),HH.QUYDOI1) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hhn.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_TONGHANGHOANHAP HHN LEFT JOIN TB_XUATTAM HHX  ON HHN.MAHANGHOA=HHX.MAHANGHOA group by hhn.mahanghoa,isnull(hhn.soluongTONG,0)) UPDATE TB_HANGHOA  SET DONVITINHLON3 = (SELECT ISNULL(TK.SOLUONGTONG,0) FROM TB_TONKHO TK WHERE TB_HANGHOA.MAHANGHOA=TK.MAHANGHOA)"
            //}), sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //sqlConnection.Close();
        }

        // Token: 0x0600071D RID: 1821 RVA: 0x0013FDB4 File Offset: 0x0013DFB4
        private void txtvat_Leave(object sender, EventArgs e)
        {
            if (this.txtvat.Text == "")
            {
                this.txtvat.Text = "0";
            }
        }

        // Token: 0x0600071E RID: 1822 RVA: 0x0013FDF0 File Offset: 0x0013DFF0
        private void txtvat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btluu.Focus();
            }
        }

        // Token: 0x0600071F RID: 1823 RVA: 0x0013FE1C File Offset: 0x0013E01C
        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtvat.Text != "")
                {
                    this.thanhtien();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000720 RID: 1824 RVA: 0x0001CD1D File Offset: 0x0001AF1D
        private void txtdongianhap_Enter(object sender, EventArgs e)
        {
            this.txtdongianhap.BackColor = Color.Yellow;
        }

        // Token: 0x06000721 RID: 1825 RVA: 0x0001CD31 File Offset: 0x0001AF31
        private void txtthanhtien_Enter(object sender, EventArgs e)
        {
            this.txtthanhtien.BackColor = Color.Yellow;
        }

        // Token: 0x06000722 RID: 1826 RVA: 0x0001CD45 File Offset: 0x0001AF45
        private void txtsoluong_Enter(object sender, EventArgs e)
        {
            this.txtsoluong.BackColor = Color.Yellow;
        }

        // Token: 0x06000723 RID: 1827 RVA: 0x0001B637 File Offset: 0x00019837
        private void txtsoluongton_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000724 RID: 1828 RVA: 0x0013FE68 File Offset: 0x0013E068
        private void txtdongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtdongianhap.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    if (e.KeyChar != Convert.ToChar("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // Token: 0x06000725 RID: 1829 RVA: 0x0013FF10 File Offset: 0x0013E110
        private void txtthanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtthanhtien.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x06000726 RID: 1830 RVA: 0x0013FF9C File Offset: 0x0013E19C
        private void txtchietkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtchietkhau.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x06000727 RID: 1831 RVA: 0x00140028 File Offset: 0x0013E228
        private void txtck2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtck2.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x06000728 RID: 1832 RVA: 0x001400B4 File Offset: 0x0013E2B4
        private void txtck3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtck3.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x06000729 RID: 1833 RVA: 0x00140140 File Offset: 0x0013E340
        private void txtvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtvat.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x0600072A RID: 1834 RVA: 0x001401CC File Offset: 0x0013E3CC
        private void txtquycach_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtquycach.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x0600072B RID: 1835 RVA: 0x00140258 File Offset: 0x0013E458
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtdongia.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        // Token: 0x0600072C RID: 1836 RVA: 0x001402E4 File Offset: 0x0013E4E4
        private void txttenncc_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        if (this.txttenncc.Text != "")
            //        {
            //            string cmdText = "SELECT MAKHACHHANG, TENDONVI FROM tb_KHACHHANG where TENDONVI = N'" + this.txttenncc.Text + "'";
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.Read())
            //            {
            //                this.txtmancc.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //                this.txttenncc.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //            }
            //            if (!sqlDataReader.HasRows)
            //            {
            //                this.txtmancc.Text = "";
            //                MessageBox.Show("Không tìm thấy NHÀ CUNG CẤP này", "Thông Báo");
            //            }
            //            sqlConnection.Close();
            //        }
            //        else
            //        {
            //            this.txtmancc.Text = "";
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x0600072D RID: 1837 RVA: 0x00140420 File Offset: 0x0013E620
        private void txtsoluong_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số Lượng";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsoluong.Text = Frmbangso.soluong.Replace("-", "");
        }

        // Token: 0x0600072E RID: 1838 RVA: 0x00140468 File Offset: 0x0013E668
        private void txtquydoi_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số Lượng";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtquydoi.Text = Frmbangso.soluong;
        }

        // Token: 0x0600072F RID: 1839 RVA: 0x001404A0 File Offset: 0x0013E6A0
        private void txtdongianhap_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Đơn giá nhập";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtdongianhap.Text = Frmbangso.soluong;
        }

        // Token: 0x06000730 RID: 1840 RVA: 0x001404D8 File Offset: 0x0013E6D8
        private void txtdongia_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.txtdongia.Text != "0")
            //{
            //    this.nhogiacu = double.Parse(this.txtdongia.Text);
            //}
            //else
            //{
            //    this.nhogiacu = 0.0;
            //}
            //Frmbangso.tieude = "Đơn giá bán";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //if (Frmbangso.ok == "ok")
            //{
            //    this.txtdongia.Text = Frmbangso.soluong;
            //    try
            //    {
            //        if (decimal.Parse(this.txtdongia.Text) > 0m)
            //        {
            //            decimal num = decimal.Parse(this.txtdongia.Text);
            //            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = "";
            //            if (this.cobloai.SelectedIndex == 0)
            //            {
            //                cmdText = string.Concat(new object[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "',GHICHU=GHICHU +', ",
            //                    this.nhogiacu,
            //                    "'  WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            else if (this.cobloai.SelectedIndex == 1)
            //            {
            //                cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA2='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "' WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            else if (this.cobloai.SelectedIndex == 2)
            //            {
            //                cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA3='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "' WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            else if (this.cobloai.SelectedIndex == 3)
            //            {
            //                cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA4='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "' WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            else if (this.cobloai.SelectedIndex == 4)
            //            {
            //                cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA5='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "' WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            else if (this.cobloai.SelectedIndex == 5)
            //            {
            //                cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET DONGIA6='",
            //                    num.ToString("", cultureInfo.NumberFormat),
            //                    "' WHERE MAHANGHOA='",
            //                    this.txtmahh.Text,
            //                    "'"
            //                });
            //            }
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Sửa không thành công", "Thông báo");
            //    }
            //    if (this.luutenhang == "0")
            //    {
            //        this.btluu.Focus();
            //    }
            //    else
            //    {
            //        this.txtdongianhap.Focus();
            //    }
            //}
        }

        // Token: 0x06000731 RID: 1841 RVA: 0x00140908 File Offset: 0x0013EB08
        private void txtthanhtien_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Tổng tiền nhập hàng";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtthanhtien.Text = Frmbangso.soluong;
        }

        // Token: 0x06000732 RID: 1842 RVA: 0x00140940 File Offset: 0x0013EB40
        private void txtchietkhau_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Chiết khấu";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtchietkhau.Text = Frmbangso.soluong;
        }

        // Token: 0x06000733 RID: 1843 RVA: 0x00140978 File Offset: 0x0013EB78
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //char c = Convert.ToChar(currencyDecimalSeparator);
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtsoluong.Text.IndexOf(currencyDecimalSeparator) != -1)
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        // Token: 0x06000734 RID: 1844 RVA: 0x00140A04 File Offset: 0x0013EC04
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.mahoadontieptheo();
            //if (this.txtmahh.Text != "")
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE FROM TB_TONGHANGHOANHAP DELETE FROM TB_TONKHO DELETE FROM TB_XUATTAM INSERT INTO TB_TONGHANGHOANHAP (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA) (SELECT HH.MAHANGHOA,'',ISNULL(SUM(HN.SOLUONG),0),'0','0','0','0','0',ISNULL(SUM(HN.SOLUONG),0),ISNULL(MAX(HN.DONGIA),0)/HH.QUYDOI1 \r\n                             FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HN.MAHANGHOA=HH.MAHANGHOA AND HH.MAHANGHOA='",
            //        this.txtmahh.Text,
            //        "' AND HN.LOAI='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1) INSERT INTO [DATASHOP].[dbo].[TB_XUATTAM] ([MAHANGHOA] ,[TENHANGHOA] ,[DONVITINH] ,[TENDONVI] ,[SOLUONGTONG] ,[SOLUONGLE],[QUIDOI]) (SELECT hhx.MAHANGHOA,hhx.TENHANGHOA,'','',CASE WHEN hhx.LOAI='A' OR  hhx.LOAI='B' THEN case when dbo.fuConvertToUnsign2(HHX.DONVITINH)=dbo.fuConvertToUnsign2(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0) ELSE '0' END WHEN LOAI='C' THEN case when dbo.fuConvertToUnsign2(HHX.DONVITINH)=dbo.fuConvertToUnsign2(HH.DONVITINH) THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        " ELSE '0' END END AS SOLUONGTONG,case when dbo.fuConvertToUnsign2(HHX.DONVITINH)!=dbo.fuConvertToUnsign2(HH.DONVITINH) THEN  CASE WHEN HHX.LOAI='B' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)+ISNULL(SUM(HHX.TONGSOLUONG),0)*(HH.QUYDOI1- ",
            //        TrangChu.tile,
            //        ")/HH.QUYDOI1  WHEN HHX.LOAI='A' THEN ISNULL(SUM(HHX.TONGSOLUONG),0) WHEN HHX.LOAI='C' THEN ISNULL(SUM(HHX.TONGSOLUONG),0)/",
            //        TrangChu.doicm,
            //        "*HH.QUYDOI1 END   END AS SOLUONGLE,HH.QUYDOI1 FROM TB_CHITIETHOADON hhx,TB_HANGHOA HH WHERE HH.MAHANGHOA=HHX.MAHANGHOA AND HHX.HUY='FALSE' AND HH.MAHANGHOA='",
            //        this.txtmahh.Text,
            //        "' AND HHX.NCC='",
            //        this.comboBox1.SelectedValue.ToString(),
            //        "' GROUP BY hhx.MAHANGHOA,HHX.LOAI,hhx.TENHANGHOA,dbo.fuConvertToUnsign2(HHX.DONVITINH),dbo.fuConvertToUnsign2(HH.DONVITINH),HH.QUYDOI1) INSERT INTO TB_TONKHO (MAHANGHOA,NCC,SOLUONG,SOLUONG2,SOLUONG3,SOLUONG4,SOLUONG5,SOLUONG6,SOLUONGTONG,DONGIA)  (SELECT hh.mahanghoa,'', '0', '0', '0', '0', '0', '0',(isnull(hhn.soluongTONG,0)-SUM(isnull(hhx.soluongTONG*HHX.QUIDOI,0)) -SUM(ISNULL(HHX.SOLUONGLE,0))) as SOLUONGTONG,'0'FROM TB_HANGHOA HH LEFT JOIN TB_TONGHANGHOANHAP HHN ON HH.MAHANGHOA=HHN.MAHANGHOA LEFT JOIN TB_XUATTAM HHX  ON HH.MAHANGHOA=HHX.MAHANGHOA WHERE HH.MAHANGHOA='",
            //        this.txtmahh.Text,
            //        "' group by hh.mahanghoa,isnull(hhn.soluongTONG,0))  SELECT isnull(hhn.soluongTONG,0), isnull(hhn.soluongTONG/",
            //        this.txtquycach.Text,
            //        ",0) as SOLUONGTONG,'0' FROM TB_TONKHO hhn WHERE HHN.MAHANGHOA='",
            //        this.txtmahh.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        string value = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtsoluongton.Text = Convert.ToDouble(value).ToString("#,##0.##");
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.txtsoluongton.Text = "0";
            //    }
            //    sqlConnection.Close();
            //}
        }
    }
}
