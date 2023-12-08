using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmsuanhapkho : Form
    {
        public Frmsuanhapkho()
        {
            InitializeComponent();
        }
        private void loadthongtin()
        {
            //string cmdText;
            //if (Frmhangtonkho.nl == "1")
            //{
            //    cmdText = "SELECT DONVITINH,DONVITINHLON,ISNULL(QUYDOI1,1) FROM tb_hanghoa where mahanghoa='" + this.txtmahang.Text + "'";
            //}
            //else
            //{
            //    cmdText = "SELECT DONVITINH,DONVITINH,'1' FROM tb_nguyenlieu where mahanghoa='" + this.txtmahang.Text + "'";
            //}
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //    this.txtdonvitinh3.Text = sqlDataReader.GetString(1);
            //    this.txtquydoi.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000A1B RID: 2587 RVA: 0x00196450 File Offset: 0x00194650
        private void thanhtien()
        {
            try
            {
                if (this.txtmahang.Text != "")
                {
                    if (this.txtdongianhap.Text != "")
                    {
                        if (double.Parse(this.txtsltong.Text) + double.Parse(this.txtslle.Text) != 0.0)
                        {
                            double num = double.Parse(this.txtsltong.Text) * double.Parse(this.txtquydoi.Text) + double.Parse(this.txtslle.Text);
                            this.txtsoluongtong.Text = num.ToString();
                            double num2 = double.Parse(this.txtquydoi.Text);
                            double num3 = double.Parse(this.txtdongianhap.Text);
                            double num4 = num3 - num3 * (double.Parse(this.txtchietkhau.Text) / 100.0);
                            double num5 = num4 - num4 * (double.Parse(this.txtck2.Text) / 100.0);
                            double num6 = num5 - num5 * (double.Parse(this.txtck3.Text) / 100.0);
                            this.txtdongiack.Text = num6.ToString("#,##0.##");
                            this.txtthanhtien.Text = (num6 * (num / num2)).ToString("#,##0.##");
                        }
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000A1C RID: 2588 RVA: 0x0001D96E File Offset: 0x0001BB6E
        private void button1_Click(object sender, EventArgs e)
        {
            Frmsuanhapkho.ok_luu = 0;
           // base.Close();
        }

        // Token: 0x06000A1D RID: 2589 RVA: 0x0001D97E File Offset: 0x0001BB7E
        private void txtmahang_TextChanged(object sender, EventArgs e)
        {
            this.loadthongtin();
        }

        // Token: 0x06000A1E RID: 2590 RVA: 0x00196624 File Offset: 0x00194824
        private void Frmsuanhapkho_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT MaNV,TenNV FROM Tb_NhanVien";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.cobnhanvien.DataSource = dataTable;
            //    this.cobnhanvien.DisplayMember = "TENNV";
            //    this.cobnhanvien.ValueMember = "MANV";
            //}
            //catch
            //{
            //    MessageBox.Show("BẠN PHẢI TẠO 1 NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //if (Frmsuanhapkho.suachitietnhap == 0)
            //{
            //    if (TrangChu.giavon2 == "True")
            //    {
            //        this.txtgiavon2.Visible = true;
            //        this.lbgiavon2.Visible = true;
            //    }
            //    this.txtgiavon2.Text = Frmsuanhapkho.gia_von2;
            //    this.textBox1.Text = Frmsuanhapkho.mancc;
            //    this.txtsohoadon.Text = Frmsuanhapkho.mahoadon;
            //    this.txtmahang.Text = Frmsuanhapkho.mahanghoa;
            //    this.txtsltong.Text = Frmsuanhapkho.soluongtong;
            //    this.txtslle.Text = Frmsuanhapkho.soluongle;
            //    this.txttenhang.Text = Frmsuanhapkho.tenhanghoa;
            //    this.txtdongianhap.Text = Frmsuanhapkho.dongia;
            //    this.txtngaynhap.Text = Frmsuanhapkho.ngaynhap;
            //}
            //else
            //{
            //    this.txtquydoi.Visible = false;
            //    this.txtdonvitinh3.Visible = false;
            //    this.txtslle.Visible = false;
            //    this.txtgiavon2.Text = "0";
            //    this.textBox1.Text = "";
            //    this.txtsohoadon.Text = Frmsuanhapkho.mahoadon;
            //    this.txtmahang.Text = Frmsuanhapkho.mahanghoa;
            //    this.txtsltong.Text = "0";
            //    this.txtslle.Text = "0";
            //    this.txttenhang.Text = Frmsuanhapkho.tenhanghoa;
            //    this.txtdongianhap.Text = Frmsuanhapkho.dongia;
            //    this.txtngaynhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //}
            //this.txtsltong.Focus();
        }

        // Token: 0x06000A1F RID: 2591 RVA: 0x0019689C File Offset: 0x00194A9C
        private void txtdongianhap_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdongianhap.Text == "")
            {
                this.txtdongianhap.Text = "0";
            }
            else
            {
                this.txtdongianhap.Text = Convert.ToDouble(this.txtdongianhap.Text).ToString("#,##0.##");
                this.txtdongianhap.SelectionStart = this.txtdongianhap.TextLength;
                this.thanhtien();
            }
        }

        // Token: 0x06000A20 RID: 2592 RVA: 0x00196924 File Offset: 0x00194B24
        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            if (this.txtchietkhau.Text == "")
            {
                this.txtchietkhau.Text = "0";
            }
            else
            {
                this.thanhtien();
            }
        }

        // Token: 0x06000A21 RID: 2593 RVA: 0x0019696C File Offset: 0x00194B6C
        private void txtck2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtck2.Text == "")
            {
                this.txtck2.Text = "0";
            }
            else
            {
                this.thanhtien();
            }
        }

        // Token: 0x06000A22 RID: 2594 RVA: 0x001969B4 File Offset: 0x00194BB4
        private void txtck3_TextChanged(object sender, EventArgs e)
        {
            if (this.txtck3.Text == "")
            {
                this.txtck3.Text = "0";
            }
            else
            {
                this.thanhtien();
            }
        }

        // Token: 0x06000A23 RID: 2595 RVA: 0x001969FC File Offset: 0x00194BFC
        private void btluu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Frmsuanhapkho.ok_luu = 1;
            //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    if (Frmsuanhapkho.suachitietnhap == 0)
            //    {
            //        string cmdText;
            //        if (Frmhangtonkho.nl == "1")
            //        {
            //            cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOANHAP SET DONGIA='",
            //                float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat),
            //                "',SOLUONG='",
            //                float.Parse(this.txtsoluongtong.Text).ToString("", cultureInfo.NumberFormat),
            //                "', SOLUONGQUYDOI='",
            //                float.Parse(this.txtsoluongtong.Text).ToString("", cultureInfo.NumberFormat),
            //                "', GIAVON2='",
            //                float.Parse(this.txtgiavon2.Text).ToString("", cultureInfo.NumberFormat),
            //                "', NGAYNHAP='",
            //                this.txtngaynhap.Text,
            //                "' WHERE MAHANGHOA='",
            //                this.txtmahang.Text,
            //                "' AND MAHOADON='",
            //                Frmsuanhapkho.mahoadon,
            //                "' AND NCC='",
            //                Frmsuanhapkho.mancc,
            //                "'"
            //            });
            //        }
            //        else
            //        {
            //            cmdText = string.Concat(new string[]
            //            {
            //                "UPDATE TB_HANGHOANHAP_NL SET DONGIA='",
            //                float.Parse(this.txtdongiack.Text).ToString("", cultureInfo.NumberFormat),
            //                "',SOLUONG='",
            //                float.Parse(this.txtsoluongtong.Text).ToString("", cultureInfo.NumberFormat),
            //                "', SOLUONGQUYDOI='",
            //                float.Parse(this.txtsoluongtong.Text).ToString("", cultureInfo.NumberFormat),
            //                "' WHERE MAHANGHOA='",
            //                this.txtmahang.Text,
            //                "' AND MAHOADON='",
            //                Frmsuanhapkho.mahoadon,
            //                "' AND NCC='",
            //                Frmsuanhapkho.mancc,
            //                "'"
            //            });
            //        }
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //    else
            //    {
            //        double num = double.Parse(this.txtsoluongtong.Text);
            //        double num2 = double.Parse(this.txtdongiack.Text);
            //        string cmdText2 = string.Concat(new object[]
            //        {
            //            "INSERT INTO [DATASHOP].[dbo].[TB_HANGHOANHAP] ([STT] ,[MAHOADON] ,[MAHANGHOA] ,[SOLUONG] ,[SOLUONG2] ,[SOLUONG3] ,[SOLUONG4] ,[SOLUONG5] ,[SOLUONG6] ,[DONGIA] ,[NGAYNHAP] ,[GHICHU] ,[SOLUONGQUYDOI] ,[LOAI] ,[NCC] ,[MALOAI],VAT,GIAVON2,NHANVIEN) VALUES  ('1',N'",
            //            Frmsuanhapkho.mahoadon,
            //            "','",
            //            Frmsuanhapkho.mahanghoa,
            //            "','",
            //            num,
            //            "','0','0','0','0','0','",
            //            num2,
            //            "','",
            //            this.txtngaynhap.Text,
            //            "','','",
            //            num,
            //            "','",
            //            Frmsuanhapkho.makho,
            //            "','CTY','0','0','0','",
            //            this.cobnhanvien.SelectedValue.ToString(),
            //            "')"
            //        });
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //        sqlCommand2.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //    Frmsuanhapkho.soluongtong = this.txtsltong.Text;
            //    Frmsuanhapkho.soluongle = this.txtslle.Text;
            //    Frmsuanhapkho.dongia = this.txtdongiack.Text;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            //base.Close();
        }

        // Token: 0x06000A24 RID: 2596 RVA: 0x00196E40 File Offset: 0x00195040
        private void txtsltong_TextChanged(object sender, EventArgs e)
        {
            if (this.txtsltong.Text == "")
            {
                this.txtsltong.Text = "0";
            }
            else
            {
                this.thanhtien();
            }
        }

        // Token: 0x06000A25 RID: 2597 RVA: 0x00196E88 File Offset: 0x00195088
        private void txtslle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtslle.Text == "")
            {
                this.txtslle.Text = "0";
            }
            else
            {
                this.thanhtien();
            }
        }

        // Token: 0x06000A26 RID: 2598 RVA: 0x00196ED0 File Offset: 0x001950D0
        private void txtngaynhap_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtngaynhap.Text = Convert.ToDateTime(this.txtngaynhap.Text).ToString();
                if (Convert.ToDateTime(this.txtngaynhap.Text) < Convert.ToDateTime(DateTime.Now.ToString("01/MM/yyyy")).AddMonths(-1))
                {
                    MessageBox.Show("Không được thay đổi phiếu nhập của tháng " + Convert.ToDateTime(this.txtngaynhap.Text).ToString("MM/yyyy"), "Thông báo");
                    this.txtngaynhap.Focus();
                }
                if (Convert.ToDateTime(this.txtngaynhap.Text) > Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    MessageBox.Show("Ngày nhập kho không được lớn hơn ngày hiện tại", "Thông báo");
                    this.txtngaynhap.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Bạn nhập ngày tháng không đúng ", "Thông báo");
                this.txtngaynhap.Focus();
            }
        }

        // Token: 0x06000A27 RID: 2599 RVA: 0x0019700C File Offset: 0x0019520C
        private void txtdongianhap_Leave(object sender, EventArgs e)
        {
            //if (double.Parse(this.txtdongianhap.Text) != 999.0)
            //{
            //    this.txtdongianhap.Text = double.Parse(this.txtdongianhap.Text).ToString("#,##0.##");
            //    this.txtdongianhap.SelectionStart = this.txtdongianhap.TextLength;
            //}
        }


        // Token: 0x04000C51 RID: 3153
        public static int suachitietnhap = 0;

        // Token: 0x04000C52 RID: 3154
        public static int ok_luu = 0;

        // Token: 0x04000C53 RID: 3155
        public static string mahoadon = "";

        // Token: 0x04000C54 RID: 3156
        public static string ngaynhap = "";

        // Token: 0x04000C55 RID: 3157
        public static string mahanghoa = "";

        // Token: 0x04000C56 RID: 3158
        public static string tenhanghoa = "";

        // Token: 0x04000C57 RID: 3159
        public static string soluongtong = "0";

        // Token: 0x04000C58 RID: 3160
        public static string soluongle = "0";

        // Token: 0x04000C59 RID: 3161
        public static string dongia = "0";

        // Token: 0x04000C5A RID: 3162
        public static string gia_von2 = "0";

        // Token: 0x04000C5B RID: 3163
        public static string mancc = string.Empty;

        // Token: 0x04000C5C RID: 3164
        public static string makho = "00";
    }
}
