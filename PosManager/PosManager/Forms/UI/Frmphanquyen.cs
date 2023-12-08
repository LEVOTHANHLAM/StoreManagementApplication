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
    public partial class Frmphanquyen : Form
    {
        // Token: 0x0400064B RID: 1611
        private string HETHONG;

        // Token: 0x0400064C RID: 1612
        private string KHACHHANG;

        // Token: 0x0400064D RID: 1613
        private string CHANHXE;

        // Token: 0x0400064E RID: 1614
        private string NHAPKHO;

        // Token: 0x0400064F RID: 1615
        private string TONKHO;

        // Token: 0x04000650 RID: 1616
        private string INTEM;

        // Token: 0x04000651 RID: 1617
        private string CONGNO;

        // Token: 0x04000652 RID: 1618
        private string THUCHI;

        // Token: 0x04000653 RID: 1619
        private string BAOCAO;

        // Token: 0x04000654 RID: 1620
        private string THEMHANG;

        // Token: 0x04000655 RID: 1621
        private string SUAHANG;

        // Token: 0x04000656 RID: 1622
        private string XOAHANG;

        // Token: 0x04000657 RID: 1623
        private string HOADON;

        // Token: 0x04000658 RID: 1624
        private string XOAHOADON;

        // Token: 0x04000659 RID: 1625
        private string SUAHOADON;

        // Token: 0x0400065A RID: 1626
        private string ANMUCBAN;

        // Token: 0x0400065B RID: 1627
        private string DONVITINH;

        // Token: 0x0400065C RID: 1628
        private string XOANHAP;

        // Token: 0x0400065D RID: 1629
        private string XEMGIAVON;

        // Token: 0x0400065E RID: 1630
        private string XEMLAILO;

        // Token: 0x0400065F RID: 1631
        private string INBAOCAO;

        // Token: 0x04000660 RID: 1632
        private string GIA1;

        // Token: 0x04000661 RID: 1633
        private string GIA2;

        // Token: 0x04000662 RID: 1634
        private string GIA3;

        // Token: 0x04000663 RID: 1635
        private string GIA4;

        // Token: 0x04000664 RID: 1636
        private string GIA5;

        // Token: 0x04000665 RID: 1637
        private string GIA6;

        // Token: 0x04000666 RID: 1638
        private string CK;

        // Token: 0x04000667 RID: 1639
        private int ma = 0;
        public Frmphanquyen()
        {
            InitializeComponent();
        }
        private void LOAD_QUYEN()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "SELECT HETHONG,KHACHHANG,CHANHXE,NHAPKHO,TONKHO,INTEM,CONGNO,THUCHI,BAOCAO,THEMHANG,SUAHANG,XOAHANG,HOADON,XOAHOADON,SUAHOADON,ANMUCBAN,DONVITINH,XOANHAP,XEMGIAVON,XEMLAILO,INBAOCAO,CLEAR,[THUTUBANHAGN],GIA1,GIA2,GIA3,GIA4,GIA5,GIA6,CK,GIAMO,SUANGAYBAN,CAPNHATSQL,HIENGIAVON,NGAYHOMNAY,MOKET,XEMHD,GIAMTIEN,GIAMPHANTRAM,VAT,NGUYENLIEU,HIENDOANHTHU,LAILOKHIBAN,GIAVON2,TIENNHAPHANG,CANHBAOKHO,HIENTENNHOM,ANCHIEURONG,MASON,ISNULL(MUAA_TANGB,'False'),ISNULL(INLAIHOADON,'False'),ISNULL(BANTHEM,'False'),  ISNULL(COPYHOADON,'False'),ISNULL(BANNHIEUKHO,'False') ,ISNULL(DOANHTHUNHANVIEN,'False') ,ISNULL(TRAHANG,'False') ,ISNULL(KHUYENMAI,'False'),HINHSANPHAN,ISNULL(GIALE,'2')  FROM TB_PHANQUYEN WHERE NGUOIDUNG='" + this.ma + "'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.HETHONG = Convert.ToString(sqlDataReader.GetValue(0));
            //    this.KHACHHANG = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.CHANHXE = Convert.ToString(sqlDataReader.GetValue(2));
            //    this.NHAPKHO = Convert.ToString(sqlDataReader.GetValue(3));
            //    this.TONKHO = Convert.ToString(sqlDataReader.GetValue(4));
            //    this.INTEM = Convert.ToString(sqlDataReader.GetValue(5));
            //    this.CONGNO = Convert.ToString(sqlDataReader.GetValue(6));
            //    this.THUCHI = Convert.ToString(sqlDataReader.GetValue(7));
            //    this.BAOCAO = Convert.ToString(sqlDataReader.GetValue(8));
            //    this.THEMHANG = Convert.ToString(sqlDataReader.GetValue(9));
            //    this.SUAHANG = Convert.ToString(sqlDataReader.GetValue(10));
            //    this.XOAHANG = Convert.ToString(sqlDataReader.GetValue(11));
            //    this.HOADON = Convert.ToString(sqlDataReader.GetValue(12));
            //    this.XOAHOADON = Convert.ToString(sqlDataReader.GetValue(13));
            //    this.SUAHOADON = Convert.ToString(sqlDataReader.GetValue(14));
            //    this.ANMUCBAN = Convert.ToString(sqlDataReader.GetValue(15));
            //    this.DONVITINH = Convert.ToString(sqlDataReader.GetValue(16));
            //    this.XOANHAP = Convert.ToString(sqlDataReader.GetValue(17));
            //    this.XEMGIAVON = Convert.ToString(sqlDataReader.GetValue(18));
            //    this.XEMLAILO = Convert.ToString(sqlDataReader.GetValue(19));
            //    this.INBAOCAO = Convert.ToString(sqlDataReader.GetValue(20));
            //    this.txttt.Text = Convert.ToString(sqlDataReader.GetValue(22));
            //    string a = Convert.ToString(sqlDataReader.GetValue(21));
            //    this.GIA1 = Convert.ToString(sqlDataReader.GetValue(23));
            //    this.GIA2 = Convert.ToString(sqlDataReader.GetValue(24));
            //    this.GIA3 = Convert.ToString(sqlDataReader.GetValue(25));
            //    this.GIA4 = Convert.ToString(sqlDataReader.GetValue(26));
            //    this.GIA5 = Convert.ToString(sqlDataReader.GetValue(27));
            //    this.GIA6 = Convert.ToString(sqlDataReader.GetValue(28));
            //    this.CK = Convert.ToString(sqlDataReader.GetValue(29));
            //    string a2 = Convert.ToString(sqlDataReader.GetValue(30));
            //    string a3 = Convert.ToString(sqlDataReader.GetValue(31));
            //    string a4 = Convert.ToString(sqlDataReader.GetValue(32));
            //    string a5 = Convert.ToString(sqlDataReader.GetValue(33));
            //    if (Convert.ToString(sqlDataReader.GetValue(34)) == "True")
            //    {
            //        this.checkBox34.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox34.Checked = false;
            //    }
            //    if (a5 == "True")
            //    {
            //        this.checkBox33.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox33.Checked = false;
            //    }
            //    if (a4 == "True")
            //    {
            //        this.checkBox32.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox32.Checked = false;
            //    }
            //    if (a3 == "True")
            //    {
            //        this.checkBox31.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox31.Checked = false;
            //    }
            //    if (a2 == "True")
            //    {
            //        this.checkBox30.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox30.Checked = false;
            //    }
            //    if (this.CK == "True")
            //    {
            //        this.checkBox29.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox29.Checked = false;
            //    }
            //    if (this.GIA1 == "True")
            //    {
            //        this.checkBox22.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox22.Checked = false;
            //    }
            //    if (this.GIA2 == "True")
            //    {
            //        this.checkBox24.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox24.Checked = false;
            //    }
            //    if (this.GIA3 == "True")
            //    {
            //        this.checkBox25.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox25.Checked = false;
            //    }
            //    if (this.GIA4 == "True")
            //    {
            //        this.checkBox26.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox26.Checked = false;
            //    }
            //    if (this.GIA5 == "True")
            //    {
            //        this.checkBox27.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox27.Checked = false;
            //    }
            //    if (this.GIA6 == "True")
            //    {
            //        this.checkBox28.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox28.Checked = false;
            //    }
            //    if (a == "True")
            //    {
            //        this.checkBox23.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox23.Checked = false;
            //    }
            //    if (this.HETHONG == "True")
            //    {
            //        this.checkBox1.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox1.Checked = false;
            //    }
            //    if (this.KHACHHANG == "True")
            //    {
            //        this.checkBox10.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox10.Checked = false;
            //    }
            //    if (this.CHANHXE == "True")
            //    {
            //        this.checkBox9.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox9.Checked = false;
            //    }
            //    if (this.NHAPKHO == "True")
            //    {
            //        this.checkBox7.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox7.Checked = false;
            //    }
            //    if (this.TONKHO == "True")
            //    {
            //        this.checkBox6.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox6.Checked = false;
            //    }
            //    if (this.INTEM == "True")
            //    {
            //        this.checkBox5.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox5.Checked = false;
            //    }
            //    if (this.CONGNO == "True")
            //    {
            //        this.checkBox3.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox3.Checked = false;
            //    }
            //    if (this.THUCHI == "True")
            //    {
            //        this.checkBox2.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox2.Checked = false;
            //    }
            //    if (this.BAOCAO == "True")
            //    {
            //        this.checkBox11.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox11.Checked = false;
            //    }
            //    if (this.THEMHANG == "True")
            //    {
            //        this.checkBox8.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox8.Checked = false;
            //    }
            //    if (this.SUAHANG == "True")
            //    {
            //        this.checkBox12.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox12.Checked = false;
            //    }
            //    if (this.XOAHANG == "True")
            //    {
            //        this.checkBox13.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox13.Checked = false;
            //    }
            //    if (this.HOADON == "True")
            //    {
            //        this.checkBox4.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox4.Checked = false;
            //    }
            //    if (this.XOAHOADON == "True")
            //    {
            //        this.checkBox14.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox14.Checked = false;
            //    }
            //    if (this.SUAHOADON == "True")
            //    {
            //        this.checkBox15.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox15.Checked = false;
            //    }
            //    if (this.ANMUCBAN == "True")
            //    {
            //        this.checkBox16.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox16.Checked = false;
            //    }
            //    if (this.DONVITINH == "True")
            //    {
            //        this.checkBox17.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox17.Checked = false;
            //    }
            //    if (this.XOANHAP == "True")
            //    {
            //        this.checkBox18.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox18.Checked = false;
            //    }
            //    if (this.XEMGIAVON == "True")
            //    {
            //        this.checkBox19.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox19.Checked = false;
            //    }
            //    if (this.XEMLAILO == "True")
            //    {
            //        this.checkBox20.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox20.Checked = false;
            //    }
            //    if (this.INBAOCAO == "True")
            //    {
            //        this.checkBox21.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox21.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(35)) == "True")
            //    {
            //        this.checkBox35.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox35.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(36)) == "True")
            //    {
            //        this.checkBox36.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox36.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(37)) == "True")
            //    {
            //        this.checkBox37.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox37.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(38)) == "True")
            //    {
            //        this.checkBox38.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox38.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(39)) == "True")
            //    {
            //        this.checkBox39.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox39.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(40)) == "True")
            //    {
            //        this.checkBox40.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox40.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(41)) == "True")
            //    {
            //        this.checkBox41.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox41.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(42)) == "True")
            //    {
            //        this.checkBox42.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox42.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(43)) == "True")
            //    {
            //        this.checkBox43.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox43.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(44)) == "True")
            //    {
            //        this.checkBox44.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox44.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(45)) == "True")
            //    {
            //        this.checkBox45.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox45.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(46)) == "True")
            //    {
            //        this.checkBox46.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox46.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(47)) == "True")
            //    {
            //        this.checkBox47.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox47.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(48)) == "True")
            //    {
            //        this.checkBox48.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox48.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(49)) == "True")
            //    {
            //        this.checkBox49.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox49.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(50)) == "True")
            //    {
            //        this.checkBox50.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox50.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(51)) == "True")
            //    {
            //        this.checkBox51.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox51.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(52)) == "True")
            //    {
            //        this.checkBox52.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox52.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(53)) == "True")
            //    {
            //        this.checkBox53.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox53.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(54)) == "True")
            //    {
            //        this.checkBox54.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox54.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(55)) == "True")
            //    {
            //        this.checkBox55.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox55.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(56)) == "True")
            //    {
            //        this.checkBox56.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox56.Checked = false;
            //    }
            //    if (Convert.ToString(sqlDataReader.GetValue(57)) == "True")
            //    {
            //        this.checkBox57.Checked = true;
            //    }
            //    else
            //    {
            //        this.checkBox57.Checked = false;
            //    }
            //    this.textBox3.Text = Convert.ToString(sqlDataReader.GetValue(58));
            //}
        }

        // Token: 0x06000597 RID: 1431 RVA: 0x0001C82A File Offset: 0x0001AA2A
        private void Frmphanquyen_Load(object sender, EventArgs e)
        {
            this.LOAD_QUYEN();
            this.cobnhom.SelectedIndex = 0;
        }

        // Token: 0x06000598 RID: 1432 RVA: 0x00118FD0 File Offset: 0x001171D0
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox1.Checked)
            //{
            //    this.checkBox1.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HETHONG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox1.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HETHONG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000599 RID: 1433 RVA: 0x0001C841 File Offset: 0x0001AA41
        private void cobnhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ma = this.cobnhom.SelectedIndex + 1;
            this.LOAD_QUYEN();
        }

        // Token: 0x0600059A RID: 1434 RVA: 0x001190B8 File Offset: 0x001172B8
        private void checkBox10_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox10.Checked)
            //{
            //    this.checkBox10.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET KHACHHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox10.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET KHACHHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600059B RID: 1435 RVA: 0x001191A0 File Offset: 0x001173A0
        private void checkBox9_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox9.Checked)
            //{
            //    this.checkBox9.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CHANHXE='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox9.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CHANHXE='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600059C RID: 1436 RVA: 0x00119288 File Offset: 0x00117488
        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox7.Checked)
            //{
            //    this.checkBox7.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NHAPKHO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox7.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NHAPKHO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600059D RID: 1437 RVA: 0x00119370 File Offset: 0x00117570
        private void checkBox6_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox6.Checked)
            //{
            //    this.checkBox6.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TONKHO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox6.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TONKHO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600059E RID: 1438 RVA: 0x00119458 File Offset: 0x00117658
        private void checkBox5_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox5.Checked)
            //{
            //    this.checkBox5.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INTEM='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox5.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INTEM='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600059F RID: 1439 RVA: 0x00119540 File Offset: 0x00117740
        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox3.Checked)
            //{
            //    this.checkBox3.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CONGNO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox3.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CONGNO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A0 RID: 1440 RVA: 0x00119628 File Offset: 0x00117828
        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox2.Checked)
            //{
            //    this.checkBox2.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET THUCHI='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox2.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET THUCHI='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A1 RID: 1441 RVA: 0x00119710 File Offset: 0x00117910
        private void checkBox11_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox11.Checked)
            //{
            //    this.checkBox11.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BAOCAO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox11.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BAOCAO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A2 RID: 1442 RVA: 0x001197F8 File Offset: 0x001179F8
        private void checkBox8_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox8.Checked)
            //{
            //    this.checkBox8.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET THEMHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox8.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET THEMHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A3 RID: 1443 RVA: 0x001198E0 File Offset: 0x00117AE0
        private void checkBox12_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox12.Checked)
            //{
            //    this.checkBox12.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUAHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox12.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUAHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A4 RID: 1444 RVA: 0x001199C8 File Offset: 0x00117BC8
        private void checkBox13_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox13.Checked)
            //{
            //    this.checkBox13.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOAHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox13.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOAHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A5 RID: 1445 RVA: 0x00119AB0 File Offset: 0x00117CB0
        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox4.Checked)
            //{
            //    this.checkBox4.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HOADON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox14.Checked = false;
            //    this.checkBox15.Checked = false;
            //    this.checkBox4.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    string cmdText2 = "UPDATE TB_PHANQUYEN SET XOAHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlCommand2.ExecuteNonQuery();
            //    string cmdText3 = "UPDATE TB_PHANQUYEN SET SUAHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //    sqlCommand3.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A6 RID: 1446 RVA: 0x00119C14 File Offset: 0x00117E14
        private void checkBox14_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox14.Checked)
            //{
            //    this.checkBox14.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOAHOADON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox14.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOAHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A7 RID: 1447 RVA: 0x00119CFC File Offset: 0x00117EFC
        private void checkBox15_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox15.Checked)
            //{
            //    this.checkBox15.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUAHOADON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox15.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUAHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A8 RID: 1448 RVA: 0x00119DE4 File Offset: 0x00117FE4
        private void checkBox17_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox17.Checked)
            //{
            //    this.checkBox17.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET DONVITINH='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox17.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET DONVITINH='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005A9 RID: 1449 RVA: 0x00119ECC File Offset: 0x001180CC
        private void checkBox16_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox16.Checked)
            //{
            //    this.checkBox16.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET ANMUCBAN='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox16.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET ANMUCBAN='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AA RID: 1450 RVA: 0x00119FB4 File Offset: 0x001181B4
        private void checkBox18_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox18.Checked)
            //{
            //    this.checkBox18.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOANHAP='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox18.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XOANHAP='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AB RID: 1451 RVA: 0x0011A09C File Offset: 0x0011829C
        private void checkBox19_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox19.Checked)
            //{
            //    this.checkBox19.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMGIAVON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox19.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMGIAVON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AC RID: 1452 RVA: 0x0011A184 File Offset: 0x00118384
        private void checkBox20_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox20.Checked)
            //{
            //    this.checkBox20.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMLAILO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox20.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMLAILO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AD RID: 1453 RVA: 0x0011A26C File Offset: 0x0011846C
        private void checkBox21_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox21.Checked)
            //{
            //    this.checkBox21.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INBAOCAO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox21.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INBAOCAO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AE RID: 1454 RVA: 0x0011A354 File Offset: 0x00118554
        private void checkBox23_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox23.Checked)
            //{
            //    this.checkBox23.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CLEAR='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox23.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CLEAR='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005AF RID: 1455 RVA: 0x0011A43C File Offset: 0x0011863C
        private void txttt_TextChanged(object sender, EventArgs e)
        {
            //if (this.txttt.Text != "")
            //{
            //    string cmdText = string.Concat(new object[]
            //    {
            //        "UPDATE TB_PHANQUYEN SET THUTUBANHAGN='",
            //        this.txttt.Text.Trim(),
            //        "' WHERE NGUOIDUNG='",
            //        this.ma,
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B0 RID: 1456 RVA: 0x0011A4F4 File Offset: 0x001186F4
        private void checkBox22_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox22.Checked)
            //{
            //    this.checkBox22.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA1='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox22.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA1='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B1 RID: 1457 RVA: 0x0011A5DC File Offset: 0x001187DC
        private void checkBox24_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox24.Checked)
            //{
            //    this.checkBox24.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA2='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox24.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA2='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B2 RID: 1458 RVA: 0x0011A6C4 File Offset: 0x001188C4
        private void checkBox25_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox25.Checked)
            //{
            //    this.checkBox25.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA3='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox25.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA3='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B3 RID: 1459 RVA: 0x0011A7AC File Offset: 0x001189AC
        private void checkBox26_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox26.Checked)
            //{
            //    this.checkBox26.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA4='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox26.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA4='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B4 RID: 1460 RVA: 0x0011A894 File Offset: 0x00118A94
        private void checkBox27_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox27.Checked)
            //{
            //    this.checkBox27.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA5='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox27.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA5='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B5 RID: 1461 RVA: 0x0011A97C File Offset: 0x00118B7C
        private void checkBox28_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox28.Checked)
            //{
            //    this.checkBox28.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA6='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox28.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIA6='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B6 RID: 1462 RVA: 0x0011AA64 File Offset: 0x00118C64
        private void checkBox29_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox29.Checked)
            //{
            //    this.checkBox29.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CK='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox29.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CK='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B7 RID: 1463 RVA: 0x0011AB4C File Offset: 0x00118D4C
        private void checkBox30_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox30.Checked)
            //{
            //    this.checkBox30.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox30.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B8 RID: 1464 RVA: 0x0011AC34 File Offset: 0x00118E34
        private void checkBox31_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox31.Checked)
            //{
            //    this.checkBox31.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUANGAYBAN='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox31.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET SUANGAYBAN='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005B9 RID: 1465 RVA: 0x0011AD1C File Offset: 0x00118F1C
        private void checkBox32_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox32.Checked)
            //{
            //    this.checkBox32.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CAPNHATSQL='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox32.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CAPNHATSQL='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BA RID: 1466 RVA: 0x0011AE04 File Offset: 0x00119004
        private void checkBox33_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox33.Checked)
            //{
            //    this.checkBox33.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENGIAVON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox33.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENGIAVON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BB RID: 1467 RVA: 0x0011AEEC File Offset: 0x001190EC
        private void checkBox34_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox34.Checked)
            //{
            //    this.checkBox34.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NGAYHOMNAY='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox34.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NGAYHOMNAY='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BC RID: 1468 RVA: 0x0011AFD4 File Offset: 0x001191D4
        private void checkBox35_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox35.Checked)
            //{
            //    this.checkBox35.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MOKET='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox35.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MOKET='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BD RID: 1469 RVA: 0x0011B0BC File Offset: 0x001192BC
        private void checkBox36_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox36.Checked)
            //{
            //    this.checkBox36.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMHD='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox36.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET XEMHD='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BE RID: 1470 RVA: 0x0011B1A4 File Offset: 0x001193A4
        private void checkBox39_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox39.Checked)
            //{
            //    this.checkBox39.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET VAT='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox39.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET VAT='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005BF RID: 1471 RVA: 0x0011B28C File Offset: 0x0011948C
        private void checkBox38_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox38.Checked)
            //{
            //    this.checkBox38.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMPHANTRAM='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox38.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMPHANTRAM='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C0 RID: 1472 RVA: 0x0011B374 File Offset: 0x00119574
        private void checkBox37_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox37.Checked)
            //{
            //    this.checkBox37.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMTIEN='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox37.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAMTIEN='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C1 RID: 1473 RVA: 0x0011B45C File Offset: 0x0011965C
        private void checkBox40_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox40.Checked)
            //{
            //    this.checkBox40.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NGUYENLIEU='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox40.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET NGUYENLIEU='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C2 RID: 1474 RVA: 0x0011B544 File Offset: 0x00119744
        private void checkBox41_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox41.Checked)
            //{
            //    this.checkBox41.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENDOANHTHU='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox41.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENDOANHTHU='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C3 RID: 1475 RVA: 0x0011B62C File Offset: 0x0011982C
        private void checkBox42_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox42.Checked)
            //{
            //    this.checkBox42.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET [LAILOKHIBAN]='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox42.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET [LAILOKHIBAN]='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C4 RID: 1476 RVA: 0x0011B714 File Offset: 0x00119914
        private void checkBox43_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox43.Checked)
            //{
            //    this.checkBox43.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAVON2='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox43.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET GIAVON2='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C5 RID: 1477 RVA: 0x0011B7FC File Offset: 0x001199FC
        private void checkBox44_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox44.Checked)
            //{
            //    this.checkBox44.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TIENNHAPHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox44.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TIENNHAPHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C6 RID: 1478 RVA: 0x0011B8E4 File Offset: 0x00119AE4
        private void checkBox45_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox45.Checked)
            //{
            //    this.checkBox45.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CANHBAOKHO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox45.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET CANHBAOKHO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C7 RID: 1479 RVA: 0x0011B9CC File Offset: 0x00119BCC
        private void checkBox46_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox46.Checked)
            //{
            //    this.checkBox46.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENTENNHOM='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox46.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HIENTENNHOM='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C8 RID: 1480 RVA: 0x0011BAB4 File Offset: 0x00119CB4
        private void checkBox47_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox47.Checked)
            //{
            //    this.checkBox47.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET ANCHIEURONG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox47.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET ANCHIEURONG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005C9 RID: 1481 RVA: 0x0011BB9C File Offset: 0x00119D9C
        private void checkBox48_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox48.Checked)
            //{
            //    this.checkBox48.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MASON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox48.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MASON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
          //  }
        }

        // Token: 0x060005CA RID: 1482 RVA: 0x0011BC84 File Offset: 0x00119E84
        private void checkBox49_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox49.Checked)
            //{
            //    this.checkBox49.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MUAA_TANGB='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox49.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET MUAA_TANGB='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005CB RID: 1483 RVA: 0x0011BD6C File Offset: 0x00119F6C
        private void checkBox50_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox50.Checked)
            //{
            //    this.checkBox50.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INLAIHOADON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox50.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET INLAIHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005CC RID: 1484 RVA: 0x0011BE54 File Offset: 0x0011A054
        private void checkBox51_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox51.Checked)
            //{
            //    this.checkBox51.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BANTHEM='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox51.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BANTHEM='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005CD RID: 1485 RVA: 0x0011BF3C File Offset: 0x0011A13C
        private void checkBox52_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox52.Checked)
            //{
            //    this.checkBox52.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET COPYHOADON='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox52.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET COPYHOADON='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005CE RID: 1486 RVA: 0x0011C024 File Offset: 0x0011A224
        private void checkBox53_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox53.Checked)
            //{
            //    this.checkBox53.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BANNHIEUKHO='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox53.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET BANNHIEUKHO='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005CF RID: 1487 RVA: 0x0011C10C File Offset: 0x0011A30C
        private void checkBox54_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox54.Checked)
            //{
            //    this.checkBox54.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET DOANHTHUNHANVIEN='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox54.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET DOANHTHUNHANVIEN='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005D0 RID: 1488 RVA: 0x0011C1F4 File Offset: 0x0011A3F4
        private void checkBox55_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox55.Checked)
            //{
            //    this.checkBox55.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TRAHANG='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox55.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET TRAHANG='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005D1 RID: 1489 RVA: 0x0011C2DC File Offset: 0x0011A4DC
        private void checkBox56_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox56.Checked)
            //{
            //    this.checkBox56.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET KHUYENMAI='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox56.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET KHUYENMAI='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005D2 RID: 1490 RVA: 0x0011C3C4 File Offset: 0x0011A5C4
        private void checkBox57_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox57.Checked)
            //{
            //    this.checkBox57.Checked = true;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HINHSANPHAN='TRUE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox57.Checked = false;
            //    string cmdText = "UPDATE TB_PHANQUYEN SET HINHSANPHAN='FALSE' WHERE NGUOIDUNG='" + this.ma + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x060005D3 RID: 1491 RVA: 0x0011C4AC File Offset: 0x0011A6AC
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox3.Text.Trim() != "")
            //{
            //    string cmdText = string.Concat(new object[]
            //    {
            //        "UPDATE TB_PHANQUYEN SET GIALE='",
            //        this.textBox3.Text.Trim(),
            //        "' WHERE NGUOIDUNG='",
            //        this.ma,
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }
    }
}
