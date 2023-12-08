using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmxuathoadon : Form
    {
        // Token: 0x040010F1 RID: 4337
        private string tenusd = "VND";

        // Token: 0x040010F2 RID: 4338
        private string mayin = "";

        // Token: 0x040010F3 RID: 4339
        private int CAOTONGSOLUONG = 0;

        // Token: 0x040010F4 RID: 4340
        private int mauin = 2;

        // Token: 0x040010F5 RID: 4341
        private int TIGIA = 0;

        // Token: 0x040010F6 RID: 4342
        private int LEMAHANG = 0;

        // Token: 0x040010F7 RID: 4343
        private int DODAIHANGHOA = 0;

        // Token: 0x040010F8 RID: 4344
        private int DODAIMAHANG = 0;

        // Token: 0x040010F9 RID: 4345
        private int COCHUHANGHOA = 0;

        // Token: 0x040010FA RID: 4346
        private int COCHU = 0;

        // Token: 0x040010FB RID: 4347
        private int a = 0;

        // Token: 0x040010FC RID: 4348
        private int left = 0;

        // Token: 0x040010FD RID: 4349
        private int ngaythangcao = 0;

        // Token: 0x040010FE RID: 4350
        private int lengay = 0;

        // Token: 0x040010FF RID: 4351
        private int lethang = 0;

        // Token: 0x04001100 RID: 4352
        private int lenam = 0;

        // Token: 0x04001101 RID: 4353
        private int caokh = 0;

        // Token: 0x04001102 RID: 4354
        private int caonguoimuahang = 0;

        // Token: 0x04001103 RID: 4355
        private int caodonvi = 0;

        // Token: 0x04001104 RID: 4356
        private int caomasothue = 0;

        // Token: 0x04001105 RID: 4357
        private int caothanhtoan = 0;

        // Token: 0x04001106 RID: 4358
        private int caosotaikhoan = 0;

        // Token: 0x04001107 RID: 4359
        private int caodiachi = 0;

        // Token: 0x04001108 RID: 4360
        private int lenguoimuahang = 0;

        // Token: 0x04001109 RID: 4361
        private int ledonvi = 0;

        // Token: 0x0400110A RID: 4362
        private int lemasothue = 0;

        // Token: 0x0400110B RID: 4363
        private int lethanhtoan = 0;

        // Token: 0x0400110C RID: 4364
        private int lesotaikhoan = 0;

        // Token: 0x0400110D RID: 4365
        private int lediachi = 0;

        // Token: 0x0400110E RID: 4366
        private int caohanghoa = 0;

        // Token: 0x0400110F RID: 4367
        private int lethutu = 0;

        // Token: 0x04001110 RID: 4368
        private int lehanghoa = 0;

        // Token: 0x04001111 RID: 4369
        private int lesoluong = 0;

        // Token: 0x04001112 RID: 4370
        private int ledongia = 0;

        // Token: 0x04001113 RID: 4371
        private int lethanhtien = 0;

        // Token: 0x04001114 RID: 4372
        private int ledonvitinh = 0;

        // Token: 0x04001115 RID: 4373
        private int caotongcong = 0;

        // Token: 0x04001116 RID: 4374
        private int caobangchu = 0;

        // Token: 0x04001117 RID: 4375
        private int letongcong = 0;

        // Token: 0x04001118 RID: 4376
        private int levat = 0;

        // Token: 0x04001119 RID: 4377
        private int lebangchu = 0;

        // Token: 0x0400111A RID: 4378
        private int caodong = 0;

        // Token: 0x0400111B RID: 4379
        private int numberOfItemsPerPage = 0;

        // Token: 0x0400111C RID: 4380
        private int numberOfItemsPrintedSoFar = 0;

        // Token: 0x0400111D RID: 4381
        public static string hoadon = string.Empty;

        // Token: 0x0400111E RID: 4382
        //private Hanghoaxuat hhxObj = new Hanghoaxuat();

        //// Token: 0x0400111F RID: 4383
        //private HanghoanhapObj hhnObj = new HanghoanhapObj();

        //// Token: 0x04001120 RID: 4384
        //private NhaphoadonObj nhdObj = new NhaphoadonObj();

        //// Token: 0x04001121 RID: 4385
        //private xuathoadonObj xhdObj = new xuathoadonObj();

        //// Token: 0x04001122 RID: 4386
        //private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        //// Token: 0x04001123 RID: 4387
        //private KhachhangObj khObj = new KhachhangObj();

        //// Token: 0x04001124 RID: 4388
        //private HanghoaHdObj hhObj = new HanghoaHdObj();
        public Frmxuathoadon()
        {
            InitializeComponent();
            this.tudongcapnhathanghoaxuat();
            this.tudongcapnhattendonvi();
            if (Frmxuathoadon.hoadon == "xuat")
            {
                this.tudongcapnhatsohoadon();
            }
        }
        private void tudongcapnhatsohoadon()
        {
            //this.txtsohoadon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtsohoadon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select SOHOADON from Tb_HOADON WHERE DAXUAT='false'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtsohoadon.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000EBB RID: 3771 RVA: 0x001F3694 File Offset: 0x001F1894
        private void tudongcapnhathanghoaxuat()
        {
            //this.cobhanghoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.cobhanghoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select TENHANGHOA from Tb_HANGHOA";
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

        // Token: 0x06000EBC RID: 3772 RVA: 0x001F3730 File Offset: 0x001F1930
        private void tudongcapnhattendonvi()
        {
            //this.txtdonvi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtdonvi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select tendonvi from Tb_khachhang";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtdonvi.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000EBD RID: 3773 RVA: 0x0001E9E3 File Offset: 0x0001CBE3
        private void button2_Click(object sender, EventArgs e)
        {
            //Settings.Default.Tigia = this.txttigia.Text;
            //Settings.Default.Save();
            //base.Close();
        }

        //// Token: 0x06000EBE RID: 3774 RVA: 0x001F37CC File Offset: 0x001F19CC
        //private void xuathoadon(xuathoadonObj xhdObj)
        //{
        //    string text = this.txtnam.Value.ToString();
        //    if (this.txtnam.Value < 100m)
        //    {
        //        text = "20" + this.txtnam.Value.ToString();
        //    }
        //    xhdObj.Sohoadon = this.txtsohoadon.Text;
        //    xhdObj.Khachhang = this.txtmakh.Text;
        //    xhdObj.Ngayhoadon = string.Concat(new object[]
        //    {
        //        this.txtngay.Value,
        //        "/",
        //        this.txtthang.Value,
        //        "/",
        //        text
        //    });
        //    xhdObj.Ngayxuat = string.Concat(new object[]
        //    {
        //        this.txtngay1.Value,
        //        "/",
        //        this.txtthang1.Value,
        //        "/",
        //        this.txtnam1.Value
        //    });
        //    xhdObj.Hinhthucthanhtoan = this.cobthanhtoan.Text;
        //    xhdObj.Vat = this.txtvat.Text;
        //    xhdObj.Ghichu = this.txtghichu.Text;
        //    xhdObj.Cochudiachi = this.txtcochudiachi.Text;
        //    xhdObj.Cochudonvi = this.txtcochutencongty.Text;
        //    if (this.txttigia.Text == "")
        //    {
        //        xhdObj.Tigia = "0";
        //    }
        //    else
        //    {
        //        xhdObj.Tigia = this.txttigia.Text;
        //    }
        //    if (this.cbinma.Checked)
        //    {
        //        xhdObj.Inmahang = "True";
        //    }
        //    else
        //    {
        //        xhdObj.Inmahang = "False";
        //    }
        //    if (this.cbvietnam.Checked)
        //    {
        //        xhdObj.Intienviet = "True";
        //    }
        //    else
        //    {
        //        xhdObj.Intienviet = "False";
        //    }
        //}

        //// Token: 0x06000EBF RID: 3775 RVA: 0x001F39F0 File Offset: 0x001F1BF0
        //private void nhaphoadon(NhaphoadonObj nhdObj)
        //{
        //    string text = this.txtnam.Value.ToString();
        //    if (this.txtnam.Value < 100m)
        //    {
        //        text = "20" + this.txtnam.Value.ToString();
        //    }
        //    nhdObj.Sohoadon = this.txtsohoadon.Text;
        //    nhdObj.Khachhang = this.txtmasothue.Text;
        //    nhdObj.Ngayhoadon = string.Concat(new object[]
        //    {
        //        this.txtngay.Value,
        //        "/",
        //        this.txtthang.Value,
        //        "/",
        //        text
        //    });
        //    nhdObj.Ngaynhap = string.Concat(new object[]
        //    {
        //        this.txtngay1.Value,
        //        "/",
        //        this.txtthang1.Value,
        //        "/",
        //        this.txtnam1.Value
        //    });
        //    nhdObj.Hinhthucthanhtoan = this.cobthanhtoan.Text;
        //    nhdObj.Vat = this.txtvat.Text;
        //    nhdObj.Ghichu = this.txtghichu.Text;
        //}

        //// Token: 0x06000EC0 RID: 3776 RVA: 0x001F3B58 File Offset: 0x001F1D58
        //private void khachhang(KhachhangObj khObj)
        //{
        //    if (this.txtmakh.Text == "")
        //    {
        //        this.txtmakh.Text = DateTime.Now.ToString("yyMMddHHmm");
        //    }
        //    khObj.Makhachang = this.txtmakh.Text;
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
        //    khObj.Makhachang = this.txtmasothue.Text;
        //}

        //// Token: 0x06000EC1 RID: 3777 RVA: 0x001F3C70 File Offset: 0x001F1E70
        //private void nhaphanghoa(HanghoanhapObj hhnObj)
        //{
        //    for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
        //    {
        //        hhnObj.Stt = int.Parse(this.dgvdanhsach.Rows[i].Cells["stt"].Value.ToString());
        //        hhnObj.Mahoadon = this.txtsohoadon.Text;
        //        hhnObj.Mahanghoa = this.dgvdanhsach.Rows[i].Cells["Mahanghoa"].Value.ToString();
        //        double num = double.Parse(this.dgvdanhsach.Rows[i].Cells["sl"].Value.ToString());
        //        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //        string text = num.ToString("", cultureInfo.NumberFormat);
        //        hhnObj.Soluong = text.ToString();
        //        hhnObj.Dongia = float.Parse(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString();
        //        hhnObj.Ngaynhap = string.Concat(new object[]
        //        {
        //            this.txtngay1.Value,
        //            "/",
        //            this.txtthang1.Value,
        //            "/",
        //            this.txtnam1.Value
        //        });
        //        hhnObj.Ghichu = "";
        //        this.xhdCtr.ADD_HANGHOANHAP(hhnObj);
        //    }
        //}

        //// Token: 0x06000EC2 RID: 3778 RVA: 0x001F3E34 File Offset: 0x001F2034
        //private void xuathanghoa(Hanghoaxuat hhxObj)
        //{
        //    try
        //    {
        //        for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
        //        {
        //            hhxObj.Stt = int.Parse(this.dgvdanhsach.Rows[i].Cells["stt"].Value.ToString());
        //            hhxObj.Mahoadon = this.txtsohoadon.Text;
        //            hhxObj.Mahanghoa = this.dgvdanhsach.Rows[i].Cells["Mahanghoa"].Value.ToString();
        //            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //            if (this.dgvdanhsach.Rows[i].Cells["sl"].Value.ToString() != "")
        //            {
        //                string text = double.Parse(this.dgvdanhsach.Rows[i].Cells["sl"].Value.ToString()).ToString("", cultureInfo.NumberFormat);
        //                hhxObj.Soluong = text.ToString();
        //            }
        //            else
        //            {
        //                hhxObj.Soluong = "";
        //            }
        //            if (this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString() != "")
        //            {
        //                string text2 = double.Parse(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString("", cultureInfo.NumberFormat);
        //                hhxObj.Dongia = text2.ToString();
        //            }
        //            else
        //            {
        //                hhxObj.Dongia = "";
        //            }
        //            double num = 0.0;
        //            if (this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString() != "")
        //            {
        //                num = double.Parse(this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString());
        //                string text3 = num.ToString("", cultureInfo.NumberFormat);
        //                hhxObj.Thanhtien = text3.ToString();
        //            }
        //            else
        //            {
        //                hhxObj.Thanhtien = "";
        //            }
        //            hhxObj.Vat = Math.Round(num * 10.0 / 100.0, 2).ToString();
        //            hhxObj.Ngayxuat = string.Concat(new object[]
        //            {
        //                this.txtngay1.Value,
        //                "/",
        //                this.txtthang1.Value,
        //                "/",
        //                this.txtnam1.Value
        //            });
        //            hhxObj.Ghichu = "";
        //            this.xhdCtr.ADD_HANGHOAXUAT(hhxObj);
        //        }
        //        MessageBox.Show("LƯU THÀNH CÔNG");
        //    }
        //    catch
        //    {
        //    }
        //}

        // Token: 0x06000EC3 RID: 3779 RVA: 0x001F41B0 File Offset: 0x001F23B0
        private void LOADTHONGTINKHACHHANG()
        {
            //try
            //{
            //    string cmdText = "Select MASOTHUE,DIACHI,SOTAIKHOAN from Tb_khachhang where makhachhang='" + this.txtdonvi.SelectedValue.ToString() + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txtmasothue.Text = sqlDataReader.GetString(0);
            //        this.txtdiachi.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtsotaikhoan.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.txtmakh.Text = this.txtdonvi.SelectedValue.ToString();
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000EC4 RID: 3780 RVA: 0x001F42A0 File Offset: 0x001F24A0
        private void LOADTHONGTINKHACHHANGTHEOMA()
        {
            //string cmdText = "Select MASOTHUE,DIACHI,SOTAIKHOAN,TENDONVI from Tb_khachhang where makhachhang='" + this.txtmakh.Text.Trim() + "'";
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
            //    this.txtdonvi.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txtmasothue.Text = "";
            //    this.txtdiachi.Text = "";
            //    this.txtsotaikhoan.Text = "";
            //    this.txtdonvi.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000EC5 RID: 3781 RVA: 0x001F43C4 File Offset: 0x001F25C4
        private void LOADTHONGTINKHACHHANGTHEOMASOTHUE()
        {
            //string cmdText = "Select MASOTHUE,DIACHI,SOTAIKHOAN,TENDONVI,MAKHACHHANG from Tb_khachhang where MASOTHUE='" + this.txtmasothue.Text.Trim() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdiachi.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.txtsotaikhoan.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //    this.txtdonvi.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //    this.txtmakh.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txtdiachi.Text = "";
            //    this.txtsotaikhoan.Text = "";
            //    this.txtdonvi.Text = "";
            //    this.txtmakh.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000EC6 RID: 3782 RVA: 0x001F44F0 File Offset: 0x001F26F0
        private void LOADTHONGTINHANGHOA()
        {
            //string cmdText = "SELECT hh.donvitinh,hh.dongia FROM tb_hanghoa hh  where hh.mahanghoa='" + this.cobhanghoa.SelectedValue.ToString() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000EC7 RID: 3783 RVA: 0x001F4594 File Offset: 0x001F2794
        private void ADD_HANGHOA()
        {
            try
            {
                this.dgvdanhsach.Rows.Add(1);
                int rowIndex = this.dgvdanhsach.Rows.Count - 1;
                this.dgvdanhsach["tenhanghoa", rowIndex].Value = this.cobhanghoa.Text;
                this.dgvdanhsach["dvt", rowIndex].Value = this.txtdonvitinh.Text;
                this.dgvdanhsach["SL", rowIndex].Value = this.txtsoluong.Text;
                this.dgvdanhsach["DG", rowIndex].Value = this.txtdongia.Text;
                this.dgvdanhsach["Thanhtien", rowIndex].Value = this.txtthanhtien.Text;
                this.dgvdanhsach["mahanghoa", rowIndex].Value = this.txtmahh.Text;
            }
            catch
            {
            }
        }

        // Token: 0x06000EC8 RID: 3784 RVA: 0x001F46B0 File Offset: 0x001F28B0
        private void tinhtinhtong()
        {
            double num = 0.0;
            double num2 = 0.0;
            for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
            {
                if (this.dgvdanhsach["Thanhtien", i].Value.ToString() != "")
                {
                    if (this.cbvietnam.Checked)
                    {
                        this.dgvdanhsach["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvdanhsach["Thanhtien", i].Value.ToString()));
                    }
                    else
                    {
                        this.dgvdanhsach["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvdanhsach["Thanhtien", i].Value.ToString()), 2);
                    }
                }
                if (this.dgvdanhsach["SL", i].Value.ToString() != "")
                {
                    num += double.Parse(this.dgvdanhsach["SL", i].Value.ToString());
                }
                if (this.dgvdanhsach["Thanhtien", i].Value.ToString() != "")
                {
                    num2 += double.Parse(this.dgvdanhsach["Thanhtien", i].Value.ToString());
                }
            }
            string text = num.ToString("#,##0.##");
            string[] array = text.Split(new char[]
            {
                '.'
            });
            string str = array[0];
            string text2;
            if (array.Length <= 1)
            {
                text2 = str + ".00";
            }
            else if (array[1].Length == 1)
            {
                text2 = str + "." + array[1] + "0";
            }
            else
            {
                text2 = str + "." + array[1];
            }
            this.txttongsoluong.Text = text2.ToString();
            int num3 = int.Parse(this.txtvat.Text);
            if (this.cbvietnam.Checked)
            {
                double num4 = num2 * (double)num3 / 100.0;
                double num5 = num2 + num4;
                this.txttienvat.Text = num4.ToString("#,##0");
                this.txttongthanhtoan.Text = num5.ToString("#,##0");
                this.txtcongtienhang.Text = num2.ToString("#,##0");
                this.txtbangchua.Text = Frmxuathoadon.So_chu(double.Parse(this.txttongthanhtoan.Text));
            }
            else
            {
                double num4 = num2 * (double)num3 / 100.0;
                double num5 = num2 + num4;
                if (num4 > 0.0)
                {
                    string text3 = num4.ToString("#,##0.##");
                    string[] array2 = text3.Split(new char[]
                    {
                        '.'
                    });
                    string text4;
                    if (array2.Length <= 1)
                    {
                        text4 = array2[0] + ".00";
                    }
                    else if (array2[1].Length == 1)
                    {
                        text4 = array2[0] + "." + array2[1] + "0";
                    }
                    else
                    {
                        text4 = array2[0] + "." + array2[1];
                    }
                    this.txttienvat.Text = text4;
                }
                else
                {
                    this.txttienvat.Text = "0";
                }
                string text5 = num5.ToString("#,##0.##");
                string[] array3 = text5.Split(new char[]
                {
                    '.'
                });
                string text6;
                if (array3.Length <= 1)
                {
                    text6 = array3[0] + ".00";
                }
                else if (array3[1].Length == 1)
                {
                    text6 = array3[0] + "." + array3[1] + "0";
                }
                else
                {
                    text6 = array3[0] + "." + array3[1];
                }
                this.txttongthanhtoan.Text = text6;
                string text7 = num2.ToString("#,##0.##");
                string[] array4 = text5.Split(new char[]
                {
                    '.'
                });
                string text8;
                if (array4.Length <= 1)
                {
                    text8 = array4[0] + ".00";
                }
                else if (array3[1].Length == 1)
                {
                    text8 = array4[0] + "." + array4[1] + "0";
                }
                else
                {
                    text8 = array4[0] + "." + array4[1];
                }
                this.txtcongtienhang.Text = text8;
                this.txtbangchua.Text = Frmxuathoadon.So_chu_usd(Math.Floor(double.Parse(this.txttongthanhtoan.Text)));
                double num6 = num5 - Math.Floor(num5);
                string s = (num6 * 100.0).ToString("#,##0");
                if (int.Parse(s) > 0)
                {
                    this.txtbangchua.Text = Frmxuathoadon.So_chu_usd(Math.Floor(double.Parse(this.txttongthanhtoan.Text))) + " " + Frmxuathoadon.So_chu_sen((double)int.Parse(s));
                }
            }
        }

        // Token: 0x06000EC9 RID: 3785 RVA: 0x001F4C9C File Offset: 0x001F2E9C
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        // Token: 0x06000ECA RID: 3786 RVA: 0x0012E25C File Offset: 0x0012C45C
        private static string Donvi(string so)
        {
            string result = "";
            if (so.Equals("1"))
            {
                result = "";
            }
            if (so.Equals("2"))
            {
                result = "ngàn";
            }
            if (so.Equals("3"))
            {
                result = "triệu";
            }
            if (so.Equals("4"))
            {
                result = "tỷ";
            }
            if (so.Equals("5"))
            {
                result = "ngàn tỷ";
            }
            if (so.Equals("6"))
            {
                result = "triệu tỷ";
            }
            if (so.Equals("7"))
            {
                result = "tỷ tỷ";
            }
            return result;
        }

        // Token: 0x06000ECB RID: 3787 RVA: 0x001F4DE4 File Offset: 0x001F2FE4
        private static string Tach(string tach3)
        {
            string text = "";
            string result;
            if (tach3.Equals("000"))
            {
                result = "";
            }
            else
            {
                if (tach3.Length == 3)
                {
                    string text2 = tach3.Trim().Substring(0, 1).ToString().Trim();
                    string text3 = tach3.Trim().Substring(1, 1).ToString().Trim();
                    string text4 = tach3.Trim().Substring(2, 1).ToString().Trim();
                    if (text2.Equals("0") && text3.Equals("0"))
                    {
                        text = " không trăm lẻ " + Frmxuathoadon.Chu(text4.ToString().Trim()) + " ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && text4.Equals("0"))
                    {
                        text = Frmxuathoadon.Chu(text2.ToString().Trim()).Trim() + " trăm ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && !text4.Equals("0"))
                    {
                        text = Frmxuathoadon.Chu(text2.ToString().Trim()).Trim() + " trăm lẻ " + Frmxuathoadon.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            " không trăm ",
                            Frmxuathoadon.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frmxuathoadon.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
                    {
                        text = " không trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
                    {
                        text = " không trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("1"))
                    {
                        text = " không trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = " không trăm mười " + Frmxuathoadon.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = " không trăm mười ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = " không trăm mười lăm ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && Convert.ToDouble(text4) > 0.0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            Frmxuathoadon.Chu(text2.Trim()).Trim(),
                            " trăm ",
                            Frmxuathoadon.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frmxuathoadon.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("0"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("5"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("1"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuathoadon.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && Convert.ToDouble(text4) > 0.0 && !text4.Equals("5"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm mười " + Frmxuathoadon.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm mười ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = Frmxuathoadon.Chu(text2.Trim()).Trim() + " trăm mười lăm ";
                    }
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000ECC RID: 3788 RVA: 0x001F54A4 File Offset: 0x001F36A4
        public static string So_chu(double gNum)
        {
            string result;
            if (gNum == 0.0)
            {
                result = "Không đồng";
            }
            else
            {
                string text = "";
                string tach = "";
                string text2 = "";
                double value = Math.Round(gNum, 0);
                string text3 = Convert.ToString(value);
                int num = Convert.ToInt32(text3.Length / 3);
                int num2 = text3.Length - num * 3;
                if (gNum < 0.0)
                {
                }
                string text4 = "";
                if (num2.Equals(1))
                {
                    tach = "00" + Convert.ToString(value.ToString().Trim().Substring(0, 1)).Trim();
                }
                if (num2.Equals(2))
                {
                    tach = "0" + Convert.ToString(value.ToString().Trim().Substring(0, 2)).Trim();
                }
                if (num2.Equals(0))
                {
                    tach = "000";
                }
                if (value.ToString().Length > 2)
                {
                    text2 = Convert.ToString(value.ToString().Trim().Substring(num2, value.ToString().Length - num2)).Trim();
                }
                int num3 = num + 1;
                if (num2 > 0)
                {
                    text = Frmxuathoadon.Tach(tach).ToString().Trim() + " " + Frmxuathoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuathoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuathoadon.Donvi(num.ToString().Trim()).Trim();
                    }
                    text2 = text2.Trim().Substring(3, text2.Trim().Length - 3);
                    i--;
                    num5++;
                }
                if (text.Trim().Substring(0, 1).Equals("k"))
                {
                    text = text.Trim().Substring(10, text.Trim().Length - 10).Trim();
                }
                if (text.Trim().Substring(0, 1).Equals("l"))
                {
                    text = text.Trim().Substring(2, text.Trim().Length - 2).Trim();
                }
                if (text.Trim().Length > 0)
                {
                    text = string.Concat(new string[]
                    {
                        text4.Trim(),
                        " ",
                        text.Trim().Substring(0, 1).Trim().ToUpper(),
                        text.Trim().Substring(1, text.Trim().Length - 1).Trim(),
                        " đồng chẵn."
                    });
                }
                result = text.ToString().Trim();
            }
            return result;
        }

        // Token: 0x06000ECD RID: 3789 RVA: 0x001F5830 File Offset: 0x001F3A30
        public static string So_chu_usd(double gNum)
        {
            string result;
            if (gNum == 0.0)
            {
                result = "Không đô";
            }
            else
            {
                string text = "";
                string tach = "";
                string text2 = "";
                double value = Math.Round(gNum, 0);
                string text3 = Convert.ToString(value);
                int num = Convert.ToInt32(text3.Length / 3);
                int num2 = text3.Length - num * 3;
                if (gNum < 0.0)
                {
                }
                string text4 = "";
                if (num2.Equals(1))
                {
                    tach = "00" + Convert.ToString(value.ToString().Trim().Substring(0, 1)).Trim();
                }
                if (num2.Equals(2))
                {
                    tach = "0" + Convert.ToString(value.ToString().Trim().Substring(0, 2)).Trim();
                }
                if (num2.Equals(0))
                {
                    tach = "000";
                }
                if (value.ToString().Length > 2)
                {
                    text2 = Convert.ToString(value.ToString().Trim().Substring(num2, value.ToString().Length - num2)).Trim();
                }
                int num3 = num + 1;
                if (num2 > 0)
                {
                    text = Frmxuathoadon.Tach(tach).ToString().Trim() + " " + Frmxuathoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuathoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuathoadon.Donvi(num.ToString().Trim()).Trim();
                    }
                    text2 = text2.Trim().Substring(3, text2.Trim().Length - 3);
                    i--;
                    num5++;
                }
                if (text.Trim().Substring(0, 1).Equals("k"))
                {
                    text = text.Trim().Substring(10, text.Trim().Length - 10).Trim();
                }
                if (text.Trim().Substring(0, 1).Equals("l"))
                {
                    text = text.Trim().Substring(2, text.Trim().Length - 2).Trim();
                }
                if (text.Trim().Length > 0)
                {
                    text = string.Concat(new string[]
                    {
                        text4.Trim(),
                        " ",
                        text.Trim().Substring(0, 1).Trim().ToUpper(),
                        text.Trim().Substring(1, text.Trim().Length - 1).Trim(),
                        " đô"
                    });
                }
                result = text.ToString().Trim();
            }
            return result;
        }

        // Token: 0x06000ECE RID: 3790 RVA: 0x001F5BBC File Offset: 0x001F3DBC
        public static string So_chu_sen(double gNum)
        {
            string result;
            if (gNum == 0.0)
            {
                result = "cent";
            }
            else
            {
                string text = "";
                string tach = "";
                string text2 = "";
                double value = Math.Round(gNum, 0);
                string text3 = Convert.ToString(value);
                int num = Convert.ToInt32(text3.Length / 3);
                int num2 = text3.Length - num * 3;
                if (gNum < 0.0)
                {
                }
                string text4 = "";
                if (num2.Equals(1))
                {
                    tach = "00" + Convert.ToString(value.ToString().Trim().Substring(0, 1)).Trim();
                }
                if (num2.Equals(2))
                {
                    tach = "0" + Convert.ToString(value.ToString().Trim().Substring(0, 2)).Trim();
                }
                if (num2.Equals(0))
                {
                    tach = "000";
                }
                if (value.ToString().Length > 2)
                {
                    text2 = Convert.ToString(value.ToString().Trim().Substring(num2, value.ToString().Length - num2)).Trim();
                }
                int num3 = num + 1;
                if (num2 > 0)
                {
                    text = Frmxuathoadon.Tach(tach).ToString().Trim() + " " + Frmxuathoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuathoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuathoadon.Donvi(num.ToString().Trim()).Trim();
                    }
                    text2 = text2.Trim().Substring(3, text2.Trim().Length - 3);
                    i--;
                    num5++;
                }
                if (text.Trim().Substring(0, 1).Equals("k"))
                {
                    text = text.Trim().Substring(10, text.Trim().Length - 10).Trim();
                }
                if (text.Trim().Substring(0, 1).Equals("l"))
                {
                    text = text.Trim().Substring(2, text.Trim().Length - 2).Trim();
                }
                if (text.Trim().Length > 0)
                {
                    text = string.Concat(new string[]
                    {
                        text4.Trim(),
                        " ",
                        text.Trim().Substring(0, 1).Trim(),
                        text.Trim().Substring(1, text.Trim().Length - 1).Trim(),
                        " cent"
                    });
                }
                result = text.ToString().Trim();
            }
            return result;
        }

        // Token: 0x06000ECF RID: 3791 RVA: 0x00139098 File Offset: 0x00137298
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

        // Token: 0x06000ED0 RID: 3792 RVA: 0x001F5F40 File Offset: 0x001F4140
        private void canhle()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select * from tb_canhlehoadon", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.a = int.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //    this.left = int.Parse(Convert.ToString(sqlDataReader.GetValue(1)));
            //    this.ngaythangcao = int.Parse(Convert.ToString(sqlDataReader.GetValue(2)));
            //    this.lengay = int.Parse(Convert.ToString(sqlDataReader.GetValue(3)));
            //    this.lethang = int.Parse(Convert.ToString(sqlDataReader.GetValue(4)));
            //    this.lenam = int.Parse(Convert.ToString(sqlDataReader.GetValue(5)));
            //    this.caokh = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
            //    this.caonguoimuahang = int.Parse(Convert.ToString(sqlDataReader.GetValue(7)));
            //    this.caodonvi = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
            //    this.caomasothue = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
            //    this.caothanhtoan = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
            //    this.caosotaikhoan = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
            //    this.caodiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(12)));
            //    this.lenguoimuahang = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
            //    this.ledonvi = int.Parse(Convert.ToString(sqlDataReader.GetValue(14)));
            //    this.lemasothue = int.Parse(Convert.ToString(sqlDataReader.GetValue(15)));
            //    this.lethanhtoan = int.Parse(Convert.ToString(sqlDataReader.GetValue(16)));
            //    this.lesotaikhoan = int.Parse(Convert.ToString(sqlDataReader.GetValue(17)));
            //    this.lediachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(18)));
            //    this.caohanghoa = int.Parse(Convert.ToString(sqlDataReader.GetValue(19)));
            //    this.lethutu = int.Parse(Convert.ToString(sqlDataReader.GetValue(20)));
            //    this.lehanghoa = int.Parse(Convert.ToString(sqlDataReader.GetValue(21)));
            //    this.lesoluong = int.Parse(Convert.ToString(sqlDataReader.GetValue(22)));
            //    this.ledongia = int.Parse(Convert.ToString(sqlDataReader.GetValue(23)));
            //    this.lethanhtien = int.Parse(Convert.ToString(sqlDataReader.GetValue(24)));
            //    this.ledonvitinh = int.Parse(Convert.ToString(sqlDataReader.GetValue(25)));
            //    this.caotongcong = int.Parse(Convert.ToString(sqlDataReader.GetValue(26)));
            //    this.caobangchu = int.Parse(Convert.ToString(sqlDataReader.GetValue(27)));
            //    this.letongcong = int.Parse(Convert.ToString(sqlDataReader.GetValue(28)));
            //    this.levat = int.Parse(Convert.ToString(sqlDataReader.GetValue(29)));
            //    this.lebangchu = int.Parse(Convert.ToString(sqlDataReader.GetValue(30)));
            //    this.caodong = int.Parse(Convert.ToString(sqlDataReader.GetValue(31)));
            //    this.COCHU = int.Parse(Convert.ToString(sqlDataReader.GetValue(32)));
            //    this.COCHUHANGHOA = int.Parse(Convert.ToString(sqlDataReader.GetValue(33)));
            //    string text = Convert.ToString(sqlDataReader.GetValue(34));
            //    if (text == "True")
            //    {
            //        this.cbinhanghoa.Checked = true;
            //    }
            //    else
            //    {
            //        this.cbinhanghoa.Checked = false;
            //    }
            //    this.TIGIA = int.Parse(Convert.ToString(sqlDataReader.GetValue(35)));
            //    this.DODAIHANGHOA = int.Parse(Convert.ToString(sqlDataReader.GetValue(36)));
            //    this.LEMAHANG = int.Parse(Convert.ToString(sqlDataReader.GetValue(37)));
            //    this.CAOTONGSOLUONG = int.Parse(Convert.ToString(sqlDataReader.GetValue(38)));
            //    this.DODAIMAHANG = int.Parse(Convert.ToString(sqlDataReader.GetValue(39)));
            //    this.mauin = int.Parse(Convert.ToString(sqlDataReader.GetValue(40)));
            //    this.mayin = sqlDataReader.GetString(41);
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000ED1 RID: 3793 RVA: 0x001F63A4 File Offset: 0x001F45A4
        private bool kiemtratontaihoadon(string mahoadon)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select LTRIM(RTRIM(sohoadon)) from Tb_hoadonxuat", sqlConnection);
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

        // Token: 0x06000ED2 RID: 3794 RVA: 0x001391EC File Offset: 0x001373EC
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

        // Token: 0x06000ED3 RID: 3795 RVA: 0x001F6424 File Offset: 0x001F4624
        private bool kiemtratontaihanghoa(string mahanghoa)
        {
            bool result = true;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("Select LTRIM(RTRIM(MAHANGHOA)) from Tb_HANGHOA", sqlConnection);
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

        // Token: 0x06000ED4 RID: 3796 RVA: 0x001F64A4 File Offset: 0x001F46A4
        private void Frmxuathoadon_Load(object sender, EventArgs e)
        {
            //this.txttigia.Text = Settings.Default.Tigia;
            this.cobthanhtoan.SelectedIndex = 5;
            this.txtngay.Value = DateTime.Now.Day;
            this.txtngay1.Value = DateTime.Now.Day;
            this.txtthang.Value = DateTime.Now.Month;
            this.txtthang1.Value = DateTime.Now.Month;
            this.txtnam.Value = Convert.ToDecimal(DateTime.Now.ToString("yy"));
            this.txtnam1.Value = Convert.ToDecimal(DateTime.Now.ToString("yy"));
            if (Frmxuathoadon.hoadon == "xuat")
            {
                this.btinhoadon.Visible = true;
                this.btinhdnhap.Visible = false;
            }
            else
            {
                this.btinhoadon.Visible = false;
                this.btinhdnhap.Visible = true;
            }
            this.txtsohoadon.Focus();
        }

        // Token: 0x06000ED5 RID: 3797 RVA: 0x001F65F0 File Offset: 0x001F47F0
        //private void themhanghoa(HanghoaHdObj hhObj)
        //{
        //    hhObj.Mahanghoa = this.txtmahh.Text;
        //    hhObj.Tenhanghoa = this.cobhanghoa.Text;
        //    hhObj.Dongia = this.txtdongia.Text;
        //    hhObj.Ghichu = "";
        //    hhObj.Donvitinh = this.txtdonvitinh.Text;
        //    this.xhdCtr.ADD_HANGHOA(hhObj);
        //}

        // Token: 0x06000ED6 RID: 3798 RVA: 0x001F6660 File Offset: 0x001F4860
        private void btluu_Click(object sender, EventArgs e)
        {
            if (this.cobhanghoa.Text != "")
            {
                if (this.dgvdanhsach.RowCount > 19)
                {
                    MessageBox.Show("Đã đủ 18 dòng trên 1 hóa đơn", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (this.txtdonvitinh.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Đơn Vị Tính", "Thông Báo");
                    this.txtdonvitinh.Focus();
                }
                else
                {
                    if (this.txtmahh.Text == "")
                    {
                        this.txtmahh.Text = "hh" + DateTime.Now.ToString("yyMMddHHmmsstt");
                      //  this.themhanghoa(this.hhObj);
                    }
                    this.ADD_HANGHOA();
                    this.tinhtinhtong();
                    this.cobhanghoa.Focus();
                    this.txtsoluong.Text = "1";
                    this.txtdongia.Text = "0";
                    this.txtdonvitinh.Text = "";
                    this.cobhanghoa.Text = "";
                    this.txtsoluongton.Text = "0";
                    this.txtthanhtien.Text = "0";
                    this.txtmahh.Text = "";
                    this.txtthanhtiensauvat.Text = "0";
                    this.cobhanghoa.BackColor = Color.LightGreen;
                }
            }
        }

        // Token: 0x06000ED7 RID: 3799 RVA: 0x00140EDC File Offset: 0x0013F0DC
        private void bthanghoa_Click(object sender, EventArgs e)
        {
            Frmhangtonkho frmhangtonkho = new Frmhangtonkho();
          //  frmhangtonkho.ShowDialog();
        }

        // Token: 0x06000ED8 RID: 3800 RVA: 0x001F6804 File Offset: 0x001F4A04
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

        // Token: 0x06000ED9 RID: 3801 RVA: 0x001F6878 File Offset: 0x001F4A78
        private void cobhanghoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtsoluong.Focus();
                this.txtsoluong.BackColor = Color.LightGreen;
                this.cobhanghoa.BackColor = Color.White;
            }
        }

        // Token: 0x06000EDA RID: 3802 RVA: 0x001F68C8 File Offset: 0x001F4AC8
        private void LUUTHONGTINHOADON()
        {
            if (this.kiemtratontaihoadon(this.txtsohoadon.Text.Trim()))
            {
                //this.xuathoadon(this.xhdObj);
                //if (this.xhdCtr.ADD_XUATHOADON(this.xhdObj))
                //{
                //    this.xuathanghoa(this.hhxObj);
                //    this.xhdCtr.UPDATE_SOHOADON(this.txtsohoadon.Text, string.Concat(new object[]
                //    {
                //        this.txtngay.Value,
                //        "/",
                //        this.txtthang.Value,
                //        "/",
                //        this.txtnam.Value
                //    }));
                //}
                //else
                //{
                //    MessageBox.Show("KHÔNG LƯU ĐƯỢC HÓA ĐƠN", "VUI LÒNG KIỂM TRA LẠI SỐ HÓA ĐƠN", MessageBoxButtons.OK);
                //}
            }
            else
            {
                MessageBox.Show("SỐ HÓA ĐƠN    " + this.txtsohoadon.Text.Trim() + "     ĐÃ TỒN TẠI", "VUI LÒNG KIỂM TRA LẠI SỐ HÓA ĐƠN", MessageBoxButtons.OK);
            }
        }

        // Token: 0x06000EDB RID: 3803 RVA: 0x001F69E0 File Offset: 0x001F4BE0
        private void btinhoadon_Click(object sender, EventArgs e)
        {
            if (this.dgvdanhsach.RowCount > 0)
            {
                if (this.txtsohoadon.Text != "")
                {
                  //  this.khachhang(this.khObj);
                  //  this.xhdCtr.ADD_KHACHHANG(this.khObj);
                    this.LUUTHONGTINHOADON();
                }
                else
                {
                    MessageBox.Show("CHUA CO SO HOA DON", "VUI LÒNG CHỌN SỐ HÓA ĐƠN", MessageBoxButtons.OK);
                    this.txtsohoadon.Focus();
                }
            }
            else
            {
                MessageBox.Show("CHUA CO HANG HOA TRONG HOA DON", "VUI LÒNG NHAP HANG HOA CAN XUAT", MessageBoxButtons.OK);
            }
        }

        // Token: 0x06000EDC RID: 3804 RVA: 0x001F6A80 File Offset: 0x001F4C80
        private void dgvchitiethoadon_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int index = this.dgvdanhsach.CurrentRow.Index;
                    this.dgvdanhsach.Rows.RemoveAt(index);
                    this.tinhtinhtong();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000EDD RID: 3805 RVA: 0x001F6AE8 File Offset: 0x001F4CE8
        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdongia.Focus();
                this.txtsoluong.BackColor = Color.White;
            }
        }

        // Token: 0x06000EDE RID: 3806 RVA: 0x001F6B28 File Offset: 0x001F4D28
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtsoluong.Text);
                double num2 = double.Parse(this.txtdongia.Text);
                double num3 = num * num2;
                this.txtthanhtien.Text = num3.ToString("#,##0");
            }
            catch
            {
            }
        }

        // Token: 0x06000EDF RID: 3807 RVA: 0x001F6B90 File Offset: 0x001F4D90
        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtsoluong.Text);
                double num2 = double.Parse(this.txtdongia.Text);
                double num3 = num * num2;
                this.txtthanhtien.Text = num3.ToString("#,##0.##");
            }
            catch
            {
            }
        }

        // Token: 0x06000EE0 RID: 3808 RVA: 0x001F6BF8 File Offset: 0x001F4DF8
        private void btinhdnhap_Click(object sender, EventArgs e)
        {
            //if (this.dgvdanhsach.RowCount > 0)
            //{
            //    if (this.txtsohoadon.Text != "")
            //    {
            //        if (this.kiemtratontai(this.txtmasothue.Text))
            //        {
            //            this.khachhang(this.khObj);
            //            if (this.xhdCtr.ADD_KHACHHANG(this.khObj))
            //            {
            //                if (this.kiemtratontaihoadonnhap(this.txtsohoadon.Text))
            //                {
            //                    this.nhaphoadon(this.nhdObj);
            //                    if (this.xhdCtr.ADD_NHAPHOADON(this.nhdObj))
            //                    {
            //                        this.nhaphanghoa(this.hhnObj);
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("SỐ HÓA ĐƠN NÀY ĐÃ ĐƯỢC NHẬP", "VUI LÒNG KIỂM TRA LẠI SỐ HÓA ĐƠN", MessageBoxButtons.OK);
            //                }
            //            }
            //        }
            //        else if (this.kiemtratontaihoadonnhap(this.txtsohoadon.Text))
            //        {
            //            this.nhaphoadon(this.nhdObj);
            //            if (this.xhdCtr.ADD_NHAPHOADON(this.nhdObj))
            //            {
            //                this.nhaphanghoa(this.hhnObj);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("SỐ HÓA ĐƠN NÀY ĐÃ ĐƯỢC NHẬP", "VUI LÒNG KIỂM TRA LẠI SỐ HÓA ĐƠN", MessageBoxButtons.OK);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("CHUA CO SO HOA DON", "VUI LÒNG CHỌN SỐ HÓA ĐƠN", MessageBoxButtons.OK);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("CHUA CO HANG HOA TRONG HOA DON", "VUI LÒNG NHAP HANG HOA CAN XUAT", MessageBoxButtons.OK);
            //}
        }

        // Token: 0x06000EE1 RID: 3809 RVA: 0x001F6D78 File Offset: 0x001F4F78
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int num = 90;
                int num2 = 55;
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                StringFormat stringFormat2 = new StringFormat();
                stringFormat2.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(this.txtngay.Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(240 + num2, num + 15));
                e.Graphics.DrawString(this.txtthang.Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(350 + num2, num + 15));
                e.Graphics.DrawString(this.txtnam.Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(450 + num2, num + 15));
                int num3 = num + 195;
                e.Graphics.DrawString(this.txtnguoimuahang.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(200 + num2, num3 - 3));
                e.Graphics.DrawString(this.txtdonvi.Text, new Font("Arial", (float)int.Parse(this.txtcochutencongty.Text), FontStyle.Regular), Brushes.Black, new Point(90 + num2, num3 + 22));
                e.Graphics.DrawString(this.txtmasothue.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(90 + num2, num3 + 50));
                e.Graphics.DrawString(this.cobthanhtoan.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(170 + num2, num3 + 128));
                e.Graphics.DrawString(this.txtsotaikhoan.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(450 + num2, num3 + 128));
                using (Font font = new Font("Arial", (float)int.Parse(this.txtcochudiachi.Text), FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF layoutRectangle = new RectangleF((float)(num2 + 80), (float)(num3 + 75), 680f, 40f);
                    e.Graphics.DrawString(this.txtdiachi.Text, font, Brushes.Black, layoutRectangle);
                }
                int num4 = num3 + 233;
                this.numberOfItemsPerPage = 0;
                this.numberOfItemsPrintedSoFar = 0;
                for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvdanhsach.RowCount; i++)
                {
                    this.numberOfItemsPerPage++;
                    if (this.numberOfItemsPerPage > 25)
                    {
                        this.numberOfItemsPerPage = 0;
                        e.HasMorePages = true;
                        return;
                    }
                    this.numberOfItemsPrintedSoFar++;
                    if (this.numberOfItemsPrintedSoFar <= this.dgvdanhsach.Rows.Count)
                    {
                        e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(12 + num2, num4), stringFormat);
                        using (Font font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            RectangleF layoutRectangle = new RectangleF((float)(num2 + 45), (float)num4, (float)(this.ledonvitinh - 10), 40f);
                            e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
                        }
                        e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(315 + num2, num4));
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.##"), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(390 + num2, num4), stringFormat);
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString("#,##0"), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(530 + num2, num4), stringFormat2);
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString()).ToString("#,##0"), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(680 + num2, num4), stringFormat2);
                        num4 += 26;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                int num5 = num + 718 - 33;
                e.Graphics.DrawString(this.txtcongtienhang.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(680 + num2, num5), stringFormat2);
                e.Graphics.DrawString(this.txtvat.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(160 + num2, num5 + 27));
                e.Graphics.DrawString(this.txttienvat.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(680 + num2, num5 + 27), stringFormat2);
                e.Graphics.DrawString(this.txttongthanhtoan.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(680 + num2, num5 + 54), stringFormat2);
                using (Font font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF layoutRectangle = new RectangleF((float)(160 + num2), (float)(num5 + 83), 680f, 40f);
                    e.Graphics.DrawString(this.txtbangchua.Text, font, Brushes.Black, layoutRectangle);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000EE2 RID: 3810 RVA: 0x001F75AC File Offset: 0x001F57AC
        private void txtdongia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btluu.Focus();
            }
        }

        // Token: 0x06000EE3 RID: 3811 RVA: 0x001F75DC File Offset: 0x001F57DC
        private void btxem_Click(object sender, EventArgs e)
        {
            this.canhle();
            if (this.mauin == 3)
            {
                this.PrintInmahang.PrinterSettings.PrinterName = this.mayin;
                this.printPreviewDialog1.Document = this.PrintInmahang;
            }
            else if (this.mauin == 1)
            {
                this.printDocument1.PrinterSettings.PrinterName = this.mayin;
                this.printPreviewDialog1.Document = this.printDocument1;
            }
            else if (this.mauin == 2)
            {
                this.printDocument2.PrinterSettings.PrinterName = this.mayin;
                this.printPreviewDialog1.Document = this.printDocument2;
            }
            this.printPreviewDialog1.ShowDialog();
        }

        // Token: 0x06000EE4 RID: 3812 RVA: 0x001F75AC File Offset: 0x001F57AC
        private void txtdonvitinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btluu.Focus();
            }
        }

        // Token: 0x06000EE5 RID: 3813 RVA: 0x001F76B4 File Offset: 0x001F58B4
        private void txtsohoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtnguoimuahang.Focus();
            }
        }

        // Token: 0x06000EE6 RID: 3814 RVA: 0x001F76E4 File Offset: 0x001F58E4
        private void txtnguoimuahang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdonvi.Focus();
            }
        }

        // Token: 0x06000EE7 RID: 3815 RVA: 0x001F7714 File Offset: 0x001F5914
        private void dgvchitiethoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
            {
                this.dgvdanhsach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000EE8 RID: 3816 RVA: 0x001F7768 File Offset: 0x001F5968
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                StringFormat stringFormat2 = new StringFormat();
                stringFormat2.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(this.txtngay.Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lengay + this.left, this.a + this.ngaythangcao));
                e.Graphics.DrawString(this.txtthang.Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethang + this.left, this.a + this.ngaythangcao));
                e.Graphics.DrawString(this.txtnam.Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenam + this.left, this.a + this.ngaythangcao));
                int num = this.a + this.caokh;
                e.Graphics.DrawString(this.txtnguoimuahang.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenguoimuahang + this.left, num + this.caonguoimuahang));
                e.Graphics.DrawString(this.txtdonvi.Text, new Font("Arial", (float)int.Parse(this.txtcochutencongty.Text), FontStyle.Regular), Brushes.Black, new Point(this.ledonvi + this.left, num + this.caodonvi + int.Parse(this.txtdocao.Text)));
                e.Graphics.DrawString(this.txtmasothue.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lemasothue + this.left, num + this.caomasothue));
                e.Graphics.DrawString(this.cobthanhtoan.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtoan + this.left, num + this.caothanhtoan));
                e.Graphics.DrawString(this.txtsotaikhoan.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesotaikhoan + this.left, num + this.caosotaikhoan));
                using (Font font = new Font("Arial", (float)int.Parse(this.txtcochudiachi.Text), FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lediachi), (float)(num + this.caodiachi + int.Parse(this.txtdocaodiachi.Text)), (float)(this.letongcong - 70), 40f);
                    e.Graphics.DrawString(this.txtdiachi.Text, font, Brushes.Black, layoutRectangle);
                }
                int num2 = this.a + this.caohanghoa;
                this.numberOfItemsPerPage = 0;
                this.numberOfItemsPrintedSoFar = 0;
                for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvdanhsach.RowCount; i++)
                {
                    this.numberOfItemsPerPage++;
                    if (this.numberOfItemsPerPage > 25)
                    {
                        this.numberOfItemsPerPage = 0;
                        e.HasMorePages = true;
                        return;
                    }
                    this.numberOfItemsPrintedSoFar++;
                    if (this.numberOfItemsPrintedSoFar <= this.dgvdanhsach.Rows.Count)
                    {
                        e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethutu + this.left, num2), stringFormat);
                        if (this.cbinhanghoa.Checked)
                        {
                            using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
                            {
                                RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lehanghoa), (float)num2, (float)(this.ledonvitinh - 10), 40f);
                                e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
                            }
                        }
                        else
                        {
                            e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString(), new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular), Brushes.Black, new Point(this.lehanghoa + this.left, num2));
                        }
                        e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledonvitinh + this.left, num2));
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.##"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + this.left, num2), stringFormat);
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString("#,##0.##"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
                        e.Graphics.DrawString(Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString()).ToString("#,##0"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
                        num2 += this.caodong;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                int num3 = this.a + this.caotongcong;
                e.Graphics.DrawString(this.txtcongtienhang.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3), stringFormat2);
                e.Graphics.DrawString(this.txtvat.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.levat + this.left, num3 + 27));
                e.Graphics.DrawString(this.txttienvat.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3 + 27), stringFormat2);
                e.Graphics.DrawString(this.txttongthanhtoan.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3 + 54), stringFormat2);
                using (Font font = new Font("Arial", (float)this.COCHU, FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF layoutRectangle = new RectangleF((float)(this.lebangchu + this.left), (float)(num3 + this.caobangchu), (float)(this.letongcong - this.lebangchu + this.left), 40f);
                    e.Graphics.DrawString(this.txtbangchua.Text, font, Brushes.Black, layoutRectangle);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000EE9 RID: 3817 RVA: 0x001F812C File Offset: 0x001F632C
        private void txtthanhtiensauvat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtthanhtiensauvat.Text);
                double num2 = double.Parse(this.txtsoluong.Text);
                double num3 = num / num2 / 1.1;
                this.txtdongia.Text = num3.ToString("#,##0.#");
                this.txtthanhtiensauvat.Text = num.ToString("#,###");
                this.txtthanhtiensauvat.SelectionStart = this.txtthanhtiensauvat.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000EEA RID: 3818 RVA: 0x001F81CC File Offset: 0x001F63CC
        private void btnhapexecl_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.Filter = "Excel File(2003)|*.xls|Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
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
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        DataTable dataTable = new DataTable();
            //        oleDbDataAdapter.Fill(dataTable);
            //        string filterExpression = "stt>0";
            //        DataRow[] source = dataTable.Select(filterExpression);
            //        DataTable dataSource = source.CopyToDataTable<DataRow>();
            //        this.dgvdanhsach.DataSource = dataSource;
            //        this.dgvdanhsach.Sort(this.dgvdanhsach.Columns["sort"], ListSortDirection.Ascending);
            //        if (this.dgvdanhsach.RowCount > 0)
            //        {
            //            for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
            //            {
            //                this.hhObj.Mahanghoa = this.dgvdanhsach.Rows[i].Cells["Mahanghoa"].Value.ToString();
            //                this.hhObj.Tenhanghoa = this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString();
            //                this.hhObj.Dongia = this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString();
            //                this.hhObj.Ghichu = "";
            //                this.hhObj.Donvitinh = this.dgvdanhsach.Rows[i].Cells["dvt"].Value.ToString();
            //                if (this.hhObj.Tenhanghoa != "" && this.hhObj.Mahanghoa != "")
            //                {
            //                    if (this.kiemtratontaihanghoa(this.dgvdanhsach.Rows[i].Cells["Mahanghoa"].Value.ToString().Trim()))
            //                    {
            //                        this.xhdCtr.ADD_HANGHOA(this.hhObj);
            //                    }
            //                }
            //            }
            //        }
            //        this.tinhtinhtong();
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

        // Token: 0x06000EEB RID: 3819 RVA: 0x001F8554 File Offset: 0x001F6754
        private void cbinhanghoa_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbinhanghoa.Checked)
            //{
            //    string cmdText = "UPDATE TB_CANHLEHOADON SET IN1DONG='true'";
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //}
            //else
            //{
            //    string cmdText = "UPDATE TB_CANHLEHOADON SET IN1DONG='false'";
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //}
        }

        // Token: 0x06000EEC RID: 3820 RVA: 0x001F85DC File Offset: 0x001F67DC
        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(this.txtvat.Text);
                double num2 = double.Parse(this.txtcongtienhang.Text);
                if (this.txtvat.Text == "")
                {
                    this.txtvat.Text = "0";
                    this.txttienvat.Text = "0";
                    this.txttongthanhtoan.Text = this.txtcongtienhang.Text;
                }
                if (this.cbvietnam.Checked)
                {
                    double num3 = num2 * num / 100.0;
                    this.txttienvat.Text = num3.ToString("#,##0");
                    this.txttongthanhtoan.Text = (num2 + num3).ToString("#,##0");
                    this.txtbangchua.Text = Frmxuathoadon.So_chu(double.Parse(this.txttongthanhtoan.Text));
                }
                else
                {
                    double num3 = num2 * num / 100.0;
                    this.txttienvat.Text = num3.ToString("#,##0.##");
                    this.txttongthanhtoan.Text = (num2 + num3).ToString("#,##0.##");
                    this.txtbangchua.Text = Frmxuathoadon.So_chu_usd(double.Parse(this.txttongthanhtoan.Text));
                }
            }
            catch
            {
                this.txtvat.Text = "0";
            }
        }

        // Token: 0x06000EED RID: 3821 RVA: 0x001F877C File Offset: 0x001F697C
        private void PrintInmahang_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            StringFormat stringFormat2 = new StringFormat();
            stringFormat2.Alignment = StringAlignment.Far;
            decimal value = this.txtngay.Value;
            string s = value.ToString();
            if (value < 10m)
            {
                s = "0" + value;
            }
            decimal value2 = this.txtthang.Value;
            string s2 = value2.ToString();
            if (value2 < 10m)
            {
                s2 = "0" + value2;
            }
            e.Graphics.DrawString(s, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lengay + this.left, this.a + this.ngaythangcao));
            e.Graphics.DrawString(s2, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethang + this.left, this.a + this.ngaythangcao));
            e.Graphics.DrawString(this.txtnam.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenam + this.left, this.a + this.ngaythangcao));
            int num = this.a + this.caokh;
            e.Graphics.DrawString(this.txtnguoimuahang.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenguoimuahang + this.left, num + this.caonguoimuahang));
            e.Graphics.DrawString(this.txtdonvi.Text, new Font("Arial", (float)int.Parse(this.txtcochutencongty.Text), FontStyle.Regular), Brushes.Black, new Point(this.ledonvi + this.left, num + this.caodonvi + int.Parse(this.txtdocao.Text)));
            string text = "";
            string text2 = this.txtmasothue.Text;
            for (int i = 0; i < text2.Length; i++)
            {
                text = text + text2[i] + " ";
            }
            string text3 = "";
            string text4 = this.txtsotaikhoan.Text;
            for (int i = 0; i < text4.Length; i++)
            {
                text3 = text3 + text4[i] + " ";
            }
            e.Graphics.DrawString(text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lemasothue + this.left, num + this.caomasothue));
            e.Graphics.DrawString(this.cobthanhtoan.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtoan + this.left, num + this.caothanhtoan));
            e.Graphics.DrawString(text3, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesotaikhoan + this.left, num + this.caosotaikhoan));
            if (this.txttigia.Text != "")
            {
                if (this.txttigia.Text != "0")
                {
                    e.Graphics.DrawString(this.txttigia.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lemasothue + this.left, num + this.caothanhtoan + 25));
                }
            }
            using (Font font = new Font("Arial", (float)int.Parse(this.txtcochudiachi.Text), FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lediachi), (float)(num + this.caodiachi + int.Parse(this.txtdocaodiachi.Text)), (float)(this.letongcong - 70), 40f);
                e.Graphics.DrawString(this.txtdiachi.Text, font, Brushes.Black, layoutRectangle);
            }
            int num2 = this.a + this.caohanghoa;
            int num3 = 0;
            if (this.COCHUHANGHOA < this.COCHU)
            {
                num3 = this.COCHU - this.COCHUHANGHOA;
            }
            this.numberOfItemsPerPage = 0;
            this.numberOfItemsPrintedSoFar = 0;
            e.Graphics.DrawString(this.tenusd, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2 - this.caodong - 5), stringFormat2);
            e.Graphics.DrawString(this.tenusd, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2 - this.caodong - 5), stringFormat2);
            for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvdanhsach.RowCount; i++)
            {
                this.numberOfItemsPerPage++;
                if (this.numberOfItemsPerPage > 25)
                {
                    this.numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
                this.numberOfItemsPrintedSoFar++;
                if (this.numberOfItemsPrintedSoFar <= this.dgvdanhsach.Rows.Count)
                {
                    e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethutu + this.left, num2), stringFormat);
                    if (this.cbinhanghoa.Checked)
                    {
                        using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lehanghoa), (float)(num2 + num3), (float)this.DODAIHANGHOA, 17f);
                            e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
                        }
                    }
                    else
                    {
                        using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lehanghoa), (float)(num2 + num3), (float)this.DODAIHANGHOA, 40f);
                            e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
                        }
                    }
                    if (this.cbinma.Checked)
                    {
                        using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
                        {
                            RectangleF layoutRectangle = new RectangleF((float)(this.left + this.LEMAHANG), (float)(num2 + num3), (float)this.DODAIMAHANG, 17f);
                            e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["mahanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
                        }
                    }
                    e.Graphics.DrawString(this.dgvdanhsach.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular), Brushes.Black, new Point(this.ledonvitinh + this.left, num2 + num3));
                    if (this.dgvdanhsach.Rows[i].Cells["SL"].Value.ToString() != "")
                    {
                        string text5 = Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.##");
                        string[] array = text5.Split(new char[]
                        {
                            '.'
                        });
                        string str = array[0].Replace(",", ".");
                        string s3;
                        if (array.Length <= 1)
                        {
                            s3 = str + ",00";
                        }
                        else if (array[1].Length == 1)
                        {
                            s3 = str + "," + array[1] + "0";
                        }
                        else
                        {
                            s3 = str + "," + array[1];
                        }
                        string text6;
                        string text7;
                        if (this.cbvietnam.Checked)
                        {
                            text6 = Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString("#,##0");
                            text7 = Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString()).ToString("#,##0");
                        }
                        else
                        {
                            text6 = Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["dg"].Value.ToString()).ToString("#,##0.######");
                            text7 = Convert.ToDecimal(this.dgvdanhsach.Rows[i].Cells["Thanhtien"].Value.ToString()).ToString("#,##0.##");
                        }
                        string[] array2 = text6.Split(new char[]
                        {
                            '.'
                        });
                        string text8 = array2[0].Replace(",", ".");
                        string s4;
                        if (!this.cbvietnam.Checked)
                        {
                            if (array2[1].Length < 1)
                            {
                                s4 = text8 + ",000000";
                            }
                            else if (array2[1].Length == 1)
                            {
                                s4 = text8 + "," + array2[1] + "00000";
                            }
                            else if (array2[1].Length == 2)
                            {
                                s4 = text8 + "," + array2[1] + "0000";
                            }
                            else if (array2[1].Length == 3)
                            {
                                s4 = text8 + "," + array2[1] + "000";
                            }
                            else if (array2[1].Length == 4)
                            {
                                s4 = text8 + "," + array2[1] + "00";
                            }
                            else if (array2[1].Length == 5)
                            {
                                s4 = text8 + "," + array2[1] + "0";
                            }
                            else
                            {
                                s4 = text8 + "," + array2[1];
                            }
                        }
                        else if (array2.Length <= 1)
                        {
                            s4 = text8 + ",00";
                        }
                        else
                        {
                            s4 = text8 + "," + array2[1];
                        }
                        string[] array3 = text7.Split(new char[]
                        {
                            '.'
                        });
                        string text9 = array3[0].Replace(",", ".");
                        string s5;
                        if (array3.Length <= 1)
                        {
                            s5 = text9 + ",00";
                        }
                        else if (array3[1].Length == 1)
                        {
                            s5 = text9 + "," + array3[1] + "0";
                        }
                        else
                        {
                            s5 = text9 + "," + array3[1];
                        }
                        if (this.cbvietnam.Checked)
                        {
                            e.Graphics.DrawString(text8, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
                            e.Graphics.DrawString(text9, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
                        }
                        else
                        {
                            e.Graphics.DrawString(s4, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
                            e.Graphics.DrawString(s5, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
                        }
                        e.Graphics.DrawString(s3, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + 5 + this.left, num2), stringFormat2);
                    }
                    num2 += this.caodong;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            int num4 = this.a + this.caotongcong;
            string text10 = this.txttongsoluong.Text;
            string[] array4 = text10.Split(new char[]
            {
                '.'
            });
            string text11 = array4[0].Replace(",", ".");
            string s6;
            if (array4.Length <= 1)
            {
                s6 = text11;
            }
            else
            {
                s6 = text11 + "," + array4[1];
            }
            string text12 = this.txtcongtienhang.Text;
            string[] array5 = text12.Split(new char[]
            {
                '.'
            });
            string text13 = array5[0].Replace(",", ".");
            string s7;
            if (array5.Length <= 1)
            {
                s7 = text13;
            }
            else
            {
                s7 = text13 + "," + array5[1];
            }
            string text14 = this.txttienvat.Text;
            string[] array6 = text14.Split(new char[]
            {
                '.'
            });
            string text15 = array6[0].Replace(",", ".");
            string s8;
            if (array6.Length <= 1)
            {
                s8 = text15;
            }
            else
            {
                s8 = text15 + "," + array6[1];
            }
            string text16 = this.txttongthanhtoan.Text;
            string[] array7 = text16.Split(new char[]
            {
                '.'
            });
            string text17 = array7[0].Replace(",", ".");
            string s9;
            if (array7.Length <= 1)
            {
                s9 = text17;
            }
            else
            {
                s9 = text17 + "," + array7[1];
            }
            e.Graphics.DrawString(s6, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + this.left, num4 - 25), stringFormat2);
            e.Graphics.DrawString(s7, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num4), stringFormat2);
            e.Graphics.DrawString(this.txtvat.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.levat + this.left, num4 + 27));
            e.Graphics.DrawString(s8, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num4 + 27), stringFormat2);
            e.Graphics.DrawString(s9, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num4 + 54), stringFormat2);
            if (this.cbvietnam.Checked)
            {
                using (Font font = new Font("Arial", (float)(this.COCHU + 1), FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF layoutRectangle = new RectangleF((float)(this.lebangchu + this.left), (float)(num4 + this.caobangchu), (float)(this.letongcong - this.lebangchu + this.left), 40f);
                    e.Graphics.DrawString(this.txtbangchua.Text + "(VND)", font, Brushes.Black, layoutRectangle);
                }
                return;
            }
            using (Font font = new Font("Arial", (float)(this.COCHU + 1), FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF layoutRectangle = new RectangleF((float)(this.lebangchu + this.left), (float)(num4 + this.caobangchu), (float)(this.letongcong - this.lebangchu + this.left), 40f);
                e.Graphics.DrawString(this.txtbangchua.Text, font, Brushes.Black, layoutRectangle);
            }
        }

        // Token: 0x06000EEE RID: 3822 RVA: 0x001F9B4C File Offset: 0x001F7D4C
        private void cbvietnam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbvietnam.Checked)
            {
                this.tenusd = "VND";
                this.txtvat.Text = "10";
            }
            else
            {
                this.tenusd = "USD";
                this.txtvat.Text = "0";
            }
            this.tinhtinhtong();
        }

        // Token: 0x06000EEF RID: 3823 RVA: 0x001F9BB4 File Offset: 0x001F7DB4
        private void txtmahh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtsoluong.Focus();
            }
        }

        // Token: 0x06000EF0 RID: 3824 RVA: 0x001F9BE0 File Offset: 0x001F7DE0
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
        }

        // Token: 0x06000EF1 RID: 3825 RVA: 0x001F9C28 File Offset: 0x001F7E28
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
        }

        // Token: 0x06000EF2 RID: 3826 RVA: 0x001F9C70 File Offset: 0x001F7E70
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //string cmdText = "SELECT hh.donvitinh,hh.dongia,hh.tenhanghoa,hh.mahanghoa FROM tb_hanghoa hh  where hh.mahanghoa='" + this.txttimkiem.Text.Trim() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtdonvitinh.Text = sqlDataReader.GetString(0);
            //    this.txtdongia.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.cobhanghoa.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //    this.txtmahh.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txtdonvitinh.Text = "";
            //    this.txtdongia.Text = "";
            //    this.cobhanghoa.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000EF3 RID: 3827 RVA: 0x001F9BB4 File Offset: 0x001F7DB4
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtsoluong.Focus();
            }
        }

        // Token: 0x06000EF4 RID: 3828 RVA: 0x0001B637 File Offset: 0x00019837
        private void txtmahh_Leave(object sender, EventArgs e)
        {
        }

        // Token: 0x06000EF5 RID: 3829 RVA: 0x001F9D84 File Offset: 0x001F7F84
        private void txtcochutencongty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtcochutencongty.Text) < 11)
                {
                    this.txtdocao.Text = (11 - int.Parse(this.txtcochutencongty.Text)).ToString();
                }
                else
                {
                    this.txtdocao.Text = "0";
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000EF6 RID: 3830 RVA: 0x001F9E04 File Offset: 0x001F8004
        private void txtcochudiachi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtcochudiachi.Text) < 11)
                {
                    this.txtdocaodiachi.Text = (11 - int.Parse(this.txtcochudiachi.Text)).ToString();
                }
                else
                {
                    this.txtdocaodiachi.Text = "0";
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000EF7 RID: 3831 RVA: 0x0001B637 File Offset: 0x00019837
        private void txtmakh_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        // Token: 0x06000EF8 RID: 3832 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void btdong_Click(object sender, EventArgs e)
        {
           // base.Close();
        }

        // Token: 0x06000EF9 RID: 3833 RVA: 0x001F9E84 File Offset: 0x001F8084
        private void Frmxuathoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Settings.Default.Tigia = this.txttigia.Text;
           // Settings.Default.Save();
            FrmInhoadonvat frmInhoadonvat = new FrmInhoadonvat();
            frmInhoadonvat.Show();
        }

        // Token: 0x06000EFA RID: 3834 RVA: 0x001F9EC0 File Offset: 0x001F80C0
        private void dgvdanhsach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvdanhsach.CurrentRow.Index;
            if (this.dgvdanhsach.CurrentCell.ColumnIndex == 4 || this.dgvdanhsach.CurrentCell.ColumnIndex == 5)
            {
                double num = 0.0;
                double num2 = 0.0;
                for (int i = 0; i < this.dgvdanhsach.RowCount; i++)
                {
                    if (this.cbvietnam.Checked)
                    {
                        this.dgvdanhsach["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvdanhsach["SL", i].Value.ToString()) * double.Parse(this.dgvdanhsach["dg", i].Value.ToString()));
                    }
                    else
                    {
                        this.dgvdanhsach["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvdanhsach["SL", i].Value.ToString()) * double.Parse(this.dgvdanhsach["dg", i].Value.ToString()), 2);
                    }
                    num += double.Parse(this.dgvdanhsach["SL", i].Value.ToString());
                    num2 += double.Parse(this.dgvdanhsach["Thanhtien", i].Value.ToString());
                }
                string text = num.ToString("#,##0.##");
                string[] array = text.Split(new char[]
                {
                    '.'
                });
                string str = array[0];
                string text2;
                if (array.Length <= 1)
                {
                    text2 = str + ".00";
                }
                else if (array[1].Length == 1)
                {
                    text2 = str + "." + array[1] + "0";
                }
                else
                {
                    text2 = str + "." + array[1];
                }
                this.txttongsoluong.Text = text2.ToString();
                int num3 = int.Parse(this.txtvat.Text);
                if (this.cbvietnam.Checked)
                {
                    double num4 = num2 * (double)num3 / 100.0;
                    double num5 = num2 + num4;
                    this.txttienvat.Text = num4.ToString("#,##0");
                    this.txttongthanhtoan.Text = num5.ToString("#,##0");
                    this.txtcongtienhang.Text = num2.ToString("#,##0");
                    this.txtbangchua.Text = Frmxuathoadon.So_chu(double.Parse(this.txttongthanhtoan.Text));
                }
                else
                {
                    double num4 = num2 * (double)num3 / 100.0;
                    double num5 = num2 + num4;
                    if (num4 > 0.0)
                    {
                        string text3 = num4.ToString("#,##0.##");
                        string[] array2 = text3.Split(new char[]
                        {
                            '.'
                        });
                        string text4;
                        if (array2.Length <= 1)
                        {
                            text4 = array2[0] + ".00";
                        }
                        else if (array2[1].Length == 1)
                        {
                            text4 = array2[0] + "." + array2[1] + "0";
                        }
                        else
                        {
                            text4 = array2[0] + "." + array2[1];
                        }
                        this.txttienvat.Text = text4;
                    }
                    else
                    {
                        this.txttienvat.Text = "0";
                    }
                    string text5 = num5.ToString("#,##0.##");
                    string[] array3 = text5.Split(new char[]
                    {
                        '.'
                    });
                    string text6;
                    if (array3.Length <= 1)
                    {
                        text6 = array3[0] + ".00";
                    }
                    else if (array3[1].Length == 1)
                    {
                        text6 = array3[0] + "." + array3[1] + "0";
                    }
                    else
                    {
                        text6 = array3[0] + "." + array3[1];
                    }
                    this.txttongthanhtoan.Text = text6;
                    string text7 = num2.ToString("#,##0.##");
                    string[] array4 = text5.Split(new char[]
                    {
                        '.'
                    });
                    string text8;
                    if (array4.Length <= 1)
                    {
                        text8 = array4[0] + ".00";
                    }
                    else if (array3[1].Length == 1)
                    {
                        text8 = array4[0] + "." + array4[1] + "0";
                    }
                    else
                    {
                        text8 = array4[0] + "." + array4[1];
                    }
                    this.txtcongtienhang.Text = text8;
                    this.txtbangchua.Text = Frmxuathoadon.So_chu_usd(Math.Floor(double.Parse(this.txttongthanhtoan.Text)));
                    double num6 = num5 - Math.Floor(num5);
                    string s = (num6 * 100.0).ToString("#,##0");
                    if (int.Parse(s) > 0)
                    {
                        this.txtbangchua.Text = Frmxuathoadon.So_chu_usd(Math.Floor(double.Parse(this.txttongthanhtoan.Text))) + " " + Frmxuathoadon.So_chu_sen((double)int.Parse(s));
                    }
                }
            }
        }

        // Token: 0x06000EFB RID: 3835 RVA: 0x001FA4A8 File Offset: 0x001F86A8
        private void txtmasothue_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdonvi.Text == "")
            {
                this.LOADTHONGTINKHACHHANGTHEOMASOTHUE();
            }
        }

        // Token: 0x06000EFC RID: 3836 RVA: 0x001FA4DC File Offset: 0x001F86DC
        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdonvi.Text == "")
            {
                this.LOADTHONGTINKHACHHANGTHEOMA();
            }
        }

        // Token: 0x06000EFD RID: 3837 RVA: 0x001FA510 File Offset: 0x001F8710
        private void txtmasothue_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtmasothue.Text == "")
            {
                this.txtdiachi.Text = "";
                this.txtsotaikhoan.Text = "";
                this.txtdonvi.Text = "";
            }
        }
    }
}
