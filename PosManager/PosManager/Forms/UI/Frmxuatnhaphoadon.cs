using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmxuatnhaphoadon : Form
    {
        public Frmxuatnhaphoadon()
        {
            InitializeComponent();
            this.tudongcapnhattendonvi();
        }
        private void tudongcapnhattendonvi()
        {
            //this.txtnhacungcap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtnhacungcap.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            //this.txtnhacungcap.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000672 RID: 1650 RVA: 0x0012DF20 File Offset: 0x0012C120
        private void GETXUATHOADONNGAY()
        {
            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            DataTable dataSource = new DataTable();
           // dataSource = this.xhd.GET_HOADONXUAT(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
            this.dgvhoadon.DataSource = dataSource;
        }

        // Token: 0x06000673 RID: 1651 RVA: 0x0012DF88 File Offset: 0x0012C188
        private void GETNHAPHOADONNGAY()
        {
            DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            DataTable dataSource = new DataTable();
           // dataSource = this.xhd.GET_HOADONNHAP(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"));
            this.dgvhoadon.DataSource = dataSource;
        }

        // Token: 0x06000674 RID: 1652 RVA: 0x0012DFF0 File Offset: 0x0012C1F0
        private void tinhtinhtong()
        {
            this.tongsoluong = 0.0;
            double num = 0.0;
            for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
            {
                this.tongsoluong += double.Parse(this.dgvchitiethoadon["SL", i].Value.ToString());
                num += double.Parse(this.dgvchitiethoadon["Thanhtien", i].Value.ToString());
            }
            int num2 = int.Parse(this.txtptthue.Text);
            double num3 = num * (double)num2 / 100.0;
            double num4 = num + num3;
            this.txtphantramtien.Text = num3.ToString("#,##0");
            this.txtthanhtoan.Text = num4.ToString("#,##0");
            this.txtcongtienhang.Text = num.ToString("#,##0");
            this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu(double.Parse(this.txtthanhtoan.Text));
        }

        // Token: 0x06000675 RID: 1653 RVA: 0x0012E114 File Offset: 0x0012C314
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

        // Token: 0x06000676 RID: 1654 RVA: 0x0012E25C File Offset: 0x0012C45C
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

        // Token: 0x06000677 RID: 1655 RVA: 0x0012E320 File Offset: 0x0012C520
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
                        text = " không trăm lẻ " + Frmxuatnhaphoadon.Chu(text4.ToString().Trim()) + " ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && text4.Equals("0"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.ToString().Trim()).Trim() + " trăm ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && !text4.Equals("0"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.ToString().Trim()).Trim() + " trăm lẻ " + Frmxuatnhaphoadon.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            " không trăm ",
                            Frmxuatnhaphoadon.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frmxuatnhaphoadon.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
                    {
                        text = " không trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
                    {
                        text = " không trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("1"))
                    {
                        text = " không trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = " không trăm mười " + Frmxuatnhaphoadon.Chu(text4.Trim()).Trim() + " ";
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
                            Frmxuatnhaphoadon.Chu(text2.Trim()).Trim(),
                            " trăm ",
                            Frmxuatnhaphoadon.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            Frmxuatnhaphoadon.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("0"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("5"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && Convert.ToDouble(text3) > 1.0 && text4.Equals("1"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm " + Frmxuatnhaphoadon.Chu(text3.Trim()).Trim() + " mươi mốt ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && Convert.ToDouble(text4) > 0.0 && !text4.Equals("5"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm mười " + Frmxuatnhaphoadon.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm mười ";
                    }
                    if (Convert.ToDouble(text2) > 0.0 && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = Frmxuatnhaphoadon.Chu(text2.Trim()).Trim() + " trăm mười lăm ";
                    }
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000678 RID: 1656 RVA: 0x0012E9E0 File Offset: 0x0012CBE0
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
                    text = Frmxuatnhaphoadon.Tach(tach).ToString().Trim() + " " + Frmxuatnhaphoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuatnhaphoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuatnhaphoadon.Donvi(num.ToString().Trim()).Trim();
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

        // Token: 0x06000679 RID: 1657 RVA: 0x0001CB94 File Offset: 0x0001AD94
        private void Frmxuatnhaphoadon_Load(object sender, EventArgs e)
        {
            this.cobtienmat.SelectedIndex = 4;
            this.cobnhapxuat.SelectedIndex = 0;
        }

        // Token: 0x0600067A RID: 1658 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button5_Click(object sender, EventArgs e)
        {
           // base.Close();
        }

        // Token: 0x0600067B RID: 1659 RVA: 0x0012ED6C File Offset: 0x0012CF6C
        private void cobnhapxuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cobnhapxuat.SelectedIndex == 0)
            {
                this.GETXUATHOADONNGAY();
            }
            else
            {
                this.GETNHAPHOADONNGAY();
            }
        }

        // Token: 0x0600067C RID: 1660 RVA: 0x0012ED6C File Offset: 0x0012CF6C
        private void btxem_Click(object sender, EventArgs e)
        {
            if (this.cobnhapxuat.SelectedIndex == 0)
            {
                this.GETXUATHOADONNGAY();
            }
            else
            {
                this.GETNHAPHOADONNGAY();
            }
        }

        // Token: 0x0600067D RID: 1661 RVA: 0x0012EDA4 File Offset: 0x0012CFA4
        private void txtnhacungcap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.rbnhacungcap.Checked)
                {
                    if (this.cobnhapxuat.SelectedIndex == 0)
                    {
                        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                        DataTable dataSource = new DataTable();
                       // dataSource = this.xhd.GET_HOADONXUAT_DONVI(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txtnhacungcap.Text);
                        this.dgvhoadon.DataSource = dataSource;
                    }
                    else
                    {
                        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                        DataTable dataSource = new DataTable();
                      //  dataSource = this.xhd.GET_HOADONNHAP_DONVI(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txtnhacungcap.Text);
                        this.dgvhoadon.DataSource = dataSource;
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600067E RID: 1662 RVA: 0x0012EEC8 File Offset: 0x0012D0C8
        private void txtsohoadon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (this.rbsohoadon.Checked)
                //{
                //    if (this.cobnhapxuat.SelectedIndex == 0)
                //    {
                //        DataTable dataSource = new DataTable();
                //        dataSource = this.xhd.GET_HOADONXUAT_SOHOADON(this.txtsohoadon.Text);
                //        this.dgvhoadon.DataSource = dataSource;
                //    }
                //    else
                //    {
                //        DataTable dataSource = new DataTable();
                //        dataSource = this.xhd.GET_HOADONNHAP_SOHOADON(this.txtsohoadon.Text);
                //        this.dgvhoadon.DataSource = dataSource;
                //    }
                //}
            }
            catch
            {
            }
        }

        // Token: 0x0600067F RID: 1663 RVA: 0x0012EF74 File Offset: 0x0012D174
        private void cobtienmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.rbthanhtoan.Checked)
            //{
            //    if (this.cobnhapxuat.SelectedIndex == 0)
            //    {
            //        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.xhd.GET_HOADONXUAT_THANHTOAN(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.cobtienmat.Text);
            //        this.dgvhoadon.DataSource = dataSource;
            //    }
            //    else
            //    {
            //        DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //        DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.xhd.GET_HOADONNHAP_THANHTOAN(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.cobtienmat.Text);
            //        this.dgvhoadon.DataSource = dataSource;
            //    }
            //}
        }

        // Token: 0x06000680 RID: 1664 RVA: 0x0012F07C File Offset: 0x0012D27C
        private void tinhtinhtong1()
        {
            this.tongsoluong = 0.0;
            decimal d = 0m;
            for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
            {
                if (this.intienviet == "True")
                {
                    this.dgvchitiethoadon["Thanhtien", i].Value = Math.Round(decimal.Parse(this.dgvchitiethoadon["Thanhtien", i].Value.ToString()));
                }
                else
                {
                    this.dgvchitiethoadon["Thanhtien", i].Value = Math.Round(decimal.Parse(this.dgvchitiethoadon["Thanhtien", i].Value.ToString()), 2);
                }
                this.tongsoluong += double.Parse(this.dgvchitiethoadon["SL", i].Value.ToString());
                d += decimal.Parse(this.dgvchitiethoadon["Thanhtien", i].Value.ToString());
            }
            int value = int.Parse(this.txtptthue.Text);
            if (this.intienviet == "True")
            {
                decimal d2 = d * value / 100m;
                decimal num = d + d2;
                this.txtphantramtien.Text = d2.ToString("#,##0");
                this.txtthanhtoan.Text = num.ToString("#,##0");
                this.txtcongtienhang.Text = d.ToString("#,##0");
                this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu(double.Parse(this.txtthanhtoan.Text));
            }
            else
            {
                decimal d2 = d * value / 100m;
                decimal num = d + d2;
                this.txtphantramtien.Text = d2.ToString("#,##0.##");
                string text = num.ToString("#,##0.##");
                string[] array = text.Split(new char[]
                {
                    '.'
                });
                string text2;
                if (array.Length <= 1)
                {
                    text2 = array[0] + ".00";
                }
                else if (array[1].Length == 1)
                {
                    text2 = array[0] + "." + array[1] + "0";
                }
                else
                {
                    text2 = array[0] + "." + array[1];
                }
                this.txtthanhtoan.Text = text2;
                string text3 = d.ToString("#,##0.##");
                string[] array2 = text.Split(new char[]
                {
                    '.'
                });
                string text4;
                if (array2.Length <= 1)
                {
                    text4 = array2[0] + ".00";
                }
                else if (array[1].Length == 1)
                {
                    text4 = array2[0] + "." + array2[1] + "0";
                }
                else
                {
                    text4 = array2[0] + "." + array2[1];
                }
                this.txtcongtienhang.Text = text4;
                this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu_usd(Math.Floor(double.Parse(this.txtthanhtoan.Text)));
                decimal d3 = num - Math.Floor(num);
                string s = (d3 * 100m).ToString("#,##0");
                if (int.Parse(s) > 0)
                {
                    this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu_usd(Math.Floor(double.Parse(this.txtthanhtoan.Text))) + " " + Frmxuatnhaphoadon.So_chu_sen((double)int.Parse(s));
                }
            }
        }

        // Token: 0x06000681 RID: 1665 RVA: 0x0012F4A8 File Offset: 0x0012D6A8
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
                    text = Frmxuatnhaphoadon.Tach(tach).ToString().Trim() + " " + Frmxuatnhaphoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuatnhaphoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuatnhaphoadon.Donvi(num.ToString().Trim()).Trim();
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

        // Token: 0x06000682 RID: 1666 RVA: 0x0012F834 File Offset: 0x0012DA34
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
                    text = Frmxuatnhaphoadon.Tach(tach).ToString().Trim() + " " + Frmxuatnhaphoadon.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + Frmxuatnhaphoadon.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + Frmxuatnhaphoadon.Donvi(num.ToString().Trim()).Trim();
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

        // Token: 0x06000683 RID: 1667 RVA: 0x0012FBB8 File Offset: 0x0012DDB8
        private void txtnhacungcap_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        if (this.rbnhacungcap.Checked)
            //        {
            //            if (this.cobnhapxuat.SelectedIndex == 0)
            //            {
            //                DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //                DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //                DataTable dataSource = new DataTable();
            //                dataSource = this.xhd.GET_HOADONXUAT_DONVI(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txtnhacungcap.Text);
            //                this.dgvhoadon.DataSource = dataSource;
            //            }
            //            else
            //            {
            //                DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
            //                DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
            //                DataTable dataSource = new DataTable();
            //                dataSource = this.xhd.GET_HOADONNHAP_DONVI(dateTime.ToString("MM/dd/yyyy"), dateTime2.ToString("MM/dd/yyyy"), this.txtnhacungcap.Text);
            //                this.dgvhoadon.DataSource = dataSource;
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000684 RID: 1668 RVA: 0x0012FCF0 File Offset: 0x0012DEF0
        private void txtsohoadon_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        if (this.rbsohoadon.Checked)
            //        {
            //            if (this.cobnhapxuat.SelectedIndex == 0)
            //            {
            //                DataTable dataSource = new DataTable();
            //                dataSource = this.xhd.GET_HOADONXUAT_SOHOADON(this.txtsohoadon.Text);
            //                this.dgvhoadon.DataSource = dataSource;
            //            }
            //            else
            //            {
            //                DataTable dataSource = new DataTable();
            //                dataSource = this.xhd.GET_HOADONNHAP_SOHOADON(this.txtsohoadon.Text);
            //                this.dgvhoadon.DataSource = dataSource;
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000685 RID: 1669 RVA: 0x0012FDB4 File Offset: 0x0012DFB4
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
            //    this.TIGIA = int.Parse(Convert.ToString(sqlDataReader.GetValue(35)));
            //    this.DODAIHANGHOA = int.Parse(Convert.ToString(sqlDataReader.GetValue(36)));
            //    this.LEMAHANG = int.Parse(Convert.ToString(sqlDataReader.GetValue(37)));
            //    this.CAOTONGSOLUONG = int.Parse(Convert.ToString(sqlDataReader.GetValue(38)));
            //    this.DODAIMAHANG = int.Parse(Convert.ToString(sqlDataReader.GetValue(39)));
            //    this.mayin = sqlDataReader.GetString(41);
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000686 RID: 1670 RVA: 0x001301D0 File Offset: 0x0012E3D0
        private void btinhoadon_Click(object sender, EventArgs e)
        {
            this.canhle();
            this.LOADTHONGTINKHACHHANG();
            this.printInmahang.PrinterSettings.PrinterName = this.mayin;
            this.printPreviewDialog1.Document = this.printInmahang;
            this.printPreviewDialog1.ShowDialog();
        }

        // Token: 0x06000687 RID: 1671 RVA: 0x00130224 File Offset: 0x0012E424
        private void LOADTHONGTINKHACHHANG()
        {
            //try
            //{
            //    string cmdText = "Select * from Tb_khachhang where makhachhang='" + this.makhachhang + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.khobj.Makhachang = sqlDataReader.GetString(13);
            //        this.khobj.Tenkhachhang = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.khobj.Tendonvi = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.khobj.Diachi = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.khobj.Sotaikhoan = Convert.ToString(sqlDataReader.GetValue(12));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000688 RID: 1672 RVA: 0x00130324 File Offset: 0x0012E524
        private void printInmahang_PrintPage(object sender, PrintPageEventArgs e)
        {
            //try
            //{
            //    StringFormat stringFormat = new StringFormat();
            //    stringFormat.Alignment = StringAlignment.Center;
            //    StringFormat stringFormat2 = new StringFormat();
            //    stringFormat2.Alignment = StringAlignment.Far;
            //    DateTime dateTime = Convert.ToDateTime(this.ngayxuathoadon);
            //    e.Graphics.DrawString(dateTime.ToString("dd"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lengay + this.left, this.a + this.ngaythangcao));
            //    e.Graphics.DrawString(dateTime.ToString("MM"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethang + this.left, this.a + this.ngaythangcao));
            //    e.Graphics.DrawString(Convert.ToDateTime(this.ngayxuathoadon).ToString("yy"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenam + this.left, this.a + this.ngaythangcao));
            //    int num = this.a + this.caokh;
            //    string text = "";
            //    string makhachang = this.khobj.Makhachang;
            //    for (int i = 0; i < makhachang.Length; i++)
            //    {
            //        text = text + makhachang[i] + " ";
            //    }
            //    string text2 = "";
            //    string sotaikhoan = this.khobj.Sotaikhoan;
            //    for (int i = 0; i < sotaikhoan.Length; i++)
            //    {
            //        text2 = text2 + sotaikhoan[i] + " ";
            //    }
            //    e.Graphics.DrawString(this.khobj.Tenkhachhang, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lenguoimuahang + this.left, num + this.caonguoimuahang));
            //    e.Graphics.DrawString(this.khobj.Tendonvi, new Font("Arial", (float)int.Parse(this.txtcochudonvi.Text), FontStyle.Regular), Brushes.Black, new Point(this.ledonvi + this.left, num + this.caodonvi + int.Parse(this.txtdocao.Text)));
            //    e.Graphics.DrawString(text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lemasothue + this.left, num + this.caomasothue));
            //    e.Graphics.DrawString(this.hinhthucthanhtoan, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtoan + this.left, num + this.caothanhtoan));
            //    e.Graphics.DrawString(text2, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesotaikhoan + this.left, num + this.caosotaikhoan));
            //    if (this.tigiausd != 0.0)
            //    {
            //        e.Graphics.DrawString(this.tigiausd.ToString("#,##0.###"), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lemasothue + this.left, num + this.caothanhtoan + 25));
            //    }
            //    using (Font font = new Font("Arial", (float)int.Parse(this.txtcochudiachi.Text), FontStyle.Regular, GraphicsUnit.Point))
            //    {
            //        RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lediachi), (float)(num + this.caodiachi + int.Parse(this.txtdocaodiachi.Text)), (float)(this.letongcong - 70), 40f);
            //        e.Graphics.DrawString(this.khobj.Diachi, font, Brushes.Black, layoutRectangle);
            //    }
            //    int num2 = this.a + this.caohanghoa;
            //    this.numberOfItemsPerPage = 0;
            //    this.numberOfItemsPrintedSoFar = 0;
            //    if (this.intienviet == "True")
            //    {
            //        this.tenusd = "VNĐ";
            //    }
            //    else
            //    {
            //        this.tenusd = "USD";
            //    }
            //    e.Graphics.DrawString(this.tenusd, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2 - this.caodong - 5), stringFormat2);
            //    e.Graphics.DrawString(this.tenusd, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2 - this.caodong - 5), stringFormat2);
            //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvchitiethoadon.RowCount; i++)
            //    {
            //        this.numberOfItemsPerPage++;
            //        if (this.numberOfItemsPerPage > 25)
            //        {
            //            this.numberOfItemsPerPage = 0;
            //            e.HasMorePages = true;
            //            return;
            //        }
            //        this.numberOfItemsPrintedSoFar++;
            //        if (this.numberOfItemsPrintedSoFar <= this.dgvchitiethoadon.Rows.Count)
            //        {
            //            e.Graphics.DrawString(this.dgvchitiethoadon.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethutu + this.left, num2), stringFormat);
            //            if (this.inmahang == "True")
            //            {
            //                using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
            //                {
            //                    RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lehanghoa), (float)(num2 + this.COCHU - this.COCHUHANGHOA), (float)this.DODAIHANGHOA, 17f);
            //                    e.Graphics.DrawString(this.dgvchitiethoadon.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
            //                }
            //                using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
            //                {
            //                    RectangleF layoutRectangle = new RectangleF((float)(this.left + this.LEMAHANG), (float)(num2 + this.COCHU - this.COCHUHANGHOA), (float)this.DODAIMAHANG, 17f);
            //                    e.Graphics.DrawString(this.dgvchitiethoadon.Rows[i].Cells["mahanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
            //                }
            //            }
            //            else
            //            {
            //                using (Font font = new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular, GraphicsUnit.Point))
            //                {
            //                    RectangleF layoutRectangle = new RectangleF((float)(this.left + this.lehanghoa), (float)(num2 + this.COCHU - this.COCHUHANGHOA), (float)(this.DODAIHANGHOA + this.DODAIMAHANG), 17f);
            //                    e.Graphics.DrawString(this.dgvchitiethoadon.Rows[i].Cells["Tenhanghoa"].Value.ToString(), font, Brushes.Black, layoutRectangle);
            //                }
            //            }
            //            e.Graphics.DrawString(this.dgvchitiethoadon.Rows[i].Cells["dvt"].Value.ToString(), new Font("Arial", (float)this.COCHUHANGHOA, FontStyle.Regular), Brushes.Black, new Point(this.ledonvitinh + this.left, num2 + this.COCHU - this.COCHUHANGHOA));
            //            string text3 = Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.##");
            //            string[] array = text3.Split(new char[]
            //            {
            //                '.'
            //            });
            //            string str = array[0].Replace(",", ".");
            //            string s;
            //            if (array.Length <= 1)
            //            {
            //                s = str + ",00";
            //            }
            //            else if (array[1].Length == 1)
            //            {
            //                s = str + "," + array[1] + "0";
            //            }
            //            else
            //            {
            //                s = str + "," + array[1];
            //            }
            //            string text4;
            //            if (this.intienviet == "True")
            //            {
            //                text4 = Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["DONGIA"].Value.ToString()).ToString("#,##0");
            //            }
            //            else
            //            {
            //                text4 = Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["DONGIA"].Value.ToString()).ToString("#,##0.######");
            //            }
            //            string[] array2 = text4.Split(new char[]
            //            {
            //                '.'
            //            });
            //            string text5 = array2[0].Replace(",", ".");
            //            string s2;
            //            if (this.intienviet == "False")
            //            {
            //                if (array2[1].Length <= 1)
            //                {
            //                    s2 = text5 + ",000000";
            //                }
            //                else if (array2[1].Length == 1)
            //                {
            //                    s2 = text5 + "," + array2[1] + "00000";
            //                }
            //                else if (array2[1].Length == 2)
            //                {
            //                    s2 = text5 + "," + array2[1] + "0000";
            //                }
            //                else if (array2[1].Length == 3)
            //                {
            //                    s2 = text5 + "," + array2[1] + "000";
            //                }
            //                else if (array2[1].Length == 4)
            //                {
            //                    s2 = text5 + "," + array2[1] + "00";
            //                }
            //                else if (array2[1].Length == 5)
            //                {
            //                    s2 = text5 + "," + array2[1] + "0";
            //                }
            //                else
            //                {
            //                    s2 = text5 + "," + array2[1];
            //                }
            //            }
            //            else if (array2.Length <= 1)
            //            {
            //                s2 = text5 + ",00";
            //            }
            //            else
            //            {
            //                s2 = text5 + "," + array2[1];
            //            }
            //            string text6 = Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["Thanhtien"].Value.ToString()).ToString("#,##0.##");
            //            string[] array3 = text6.Split(new char[]
            //            {
            //                '.'
            //            });
            //            string text7 = array3[0].Replace(",", ".");
            //            string s3;
            //            if (array3.Length <= 1)
            //            {
            //                s3 = text7 + ",00";
            //            }
            //            else if (array3[1].Length == 1)
            //            {
            //                s3 = text7 + "," + array3[1] + "0";
            //            }
            //            else
            //            {
            //                s3 = text7 + "," + array3[1];
            //            }
            //            if (Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["SL"].Value.ToString()) == 0m)
            //            {
            //                if (!this.cbin.Checked)
            //                {
            //                    e.Graphics.DrawString(s, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + this.left + 5, num2), stringFormat2);
            //                }
            //            }
            //            else
            //            {
            //                e.Graphics.DrawString(s, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + this.left + 5, num2), stringFormat2);
            //            }
            //            if (Convert.ToDecimal(this.dgvchitiethoadon.Rows[i].Cells["SL"].Value.ToString()) == 0m)
            //            {
            //                if (!this.cbin.Checked)
            //                {
            //                    if (this.intienviet == "True")
            //                    {
            //                        e.Graphics.DrawString(text5, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
            //                        e.Graphics.DrawString(text7, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
            //                    }
            //                    else
            //                    {
            //                        e.Graphics.DrawString(s2, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
            //                        e.Graphics.DrawString(s3, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
            //                    }
            //                }
            //            }
            //            else if (this.intienviet == "True")
            //            {
            //                e.Graphics.DrawString(text5, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
            //                e.Graphics.DrawString(text7, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
            //            }
            //            else
            //            {
            //                e.Graphics.DrawString(s2, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.ledongia + this.left, num2), stringFormat2);
            //                e.Graphics.DrawString(s3, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lethanhtien + this.left, num2), stringFormat2);
            //            }
            //            num2 += this.caodong;
            //        }
            //        else
            //        {
            //            e.HasMorePages = false;
            //        }
            //    }
            //    int num3 = this.a + this.caotongcong;
            //    string text8 = this.tongsoluong.ToString("#,##0.##");
            //    string[] array4 = text8.Split(new char[]
            //    {
            //        '.'
            //    });
            //    string str2 = array4[0].Replace(",", ".");
            //    string s4;
            //    if (array4.Length <= 1)
            //    {
            //        s4 = str2 + ",00";
            //    }
            //    else if (array4[1].Length == 1)
            //    {
            //        s4 = str2 + "," + array4[1] + "0";
            //    }
            //    else
            //    {
            //        s4 = str2 + "," + array4[1];
            //    }
            //    string text9 = this.txtcongtienhang.Text;
            //    string[] array5 = text9.Split(new char[]
            //    {
            //        '.'
            //    });
            //    string text10 = array5[0].Replace(",", ".");
            //    string s5;
            //    if (array5.Length <= 1)
            //    {
            //        s5 = text10;
            //    }
            //    else
            //    {
            //        s5 = text10 + "," + array5[1];
            //    }
            //    string text11 = this.txtphantramtien.Text;
            //    string[] array6 = text11.Split(new char[]
            //    {
            //        '.'
            //    });
            //    string text12 = array6[0].Replace(",", ".");
            //    string s6;
            //    if (array6.Length <= 1)
            //    {
            //        s6 = text12;
            //    }
            //    else
            //    {
            //        s6 = text12 + "," + array6[1];
            //    }
            //    string text13 = this.txtthanhtoan.Text;
            //    string[] array7 = text13.Split(new char[]
            //    {
            //        '.'
            //    });
            //    string text14 = array7[0].Replace(",", ".");
            //    string s7;
            //    if (array7.Length <= 1)
            //    {
            //        s7 = text14;
            //    }
            //    else
            //    {
            //        s7 = text14 + "," + array7[1];
            //    }
            //    e.Graphics.DrawString(s4, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.lesoluong + this.left, num3 - 25), stringFormat2);
            //    e.Graphics.DrawString(s5, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3), stringFormat2);
            //    e.Graphics.DrawString(this.txtptthue.Text, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.levat + this.left, num3 + 27));
            //    e.Graphics.DrawString(s6, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3 + 27), stringFormat2);
            //    e.Graphics.DrawString(s7, new Font("Arial", (float)this.COCHU, FontStyle.Regular), Brushes.Black, new Point(this.letongcong + this.left, num3 + 54), stringFormat2);
            //    if (this.intienviet == "True")
            //    {
            //        using (Font font = new Font("Arial", (float)(this.COCHU + 1), FontStyle.Regular, GraphicsUnit.Point))
            //        {
            //            RectangleF layoutRectangle = new RectangleF((float)(this.lebangchu + this.left), (float)(num3 + this.caobangchu), (float)(this.letongcong - this.lebangchu + this.left), 40f);
            //            e.Graphics.DrawString(this.txtbangchu.Text + "(VND)", font, Brushes.Black, layoutRectangle);
            //        }
            //    }
            //    else
            //    {
            //        using (Font font = new Font("Arial", (float)(this.COCHU + 1), FontStyle.Regular, GraphicsUnit.Point))
            //        {
            //            RectangleF layoutRectangle = new RectangleF((float)(this.lebangchu + this.left), (float)(num3 + this.caobangchu), (float)(this.letongcong - this.lebangchu + this.left), 40f);
            //            e.Graphics.DrawString(this.txtbangchu.Text, font, Brushes.Black, layoutRectangle);
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000689 RID: 1673 RVA: 0x001318F8 File Offset: 0x0012FAF8
        private void dgvhoadon_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = this.dgvhoadon.CurrentCell.RowIndex;
                this.ma = this.dgvhoadon.Rows[rowIndex].Cells["SOHOADON"].Value.ToString().Trim();
                this.textBox1.Text = this.ma;
                this.txtptthue.Text = this.dgvhoadon.Rows[rowIndex].Cells["VAT"].Value.ToString().Trim();
                this.inmahang = this.dgvhoadon.Rows[rowIndex].Cells["InMahanghoa"].Value.ToString().Trim();
                this.intienviet = this.dgvhoadon.Rows[rowIndex].Cells["Intienviet1"].Value.ToString().Trim();
                this.ngayxuathoadon = this.dgvhoadon.Rows[rowIndex].Cells["ngayhoadon"].Value.ToString().Trim();
                this.makhachhang = this.dgvhoadon.Rows[rowIndex].Cells["makhachhang1"].Value.ToString().Trim();
                this.hinhthucthanhtoan = this.dgvhoadon.Rows[rowIndex].Cells["HINHTHUCTHANHTOAN1"].Value.ToString().Trim();
                this.tigiausd = double.Parse(this.dgvhoadon.Rows[rowIndex].Cells["TIGIADO"].Value.ToString());
                this.txtcochudiachi.Text = this.dgvhoadon.Rows[rowIndex].Cells["COCHUDIACHI"].Value.ToString().Trim();
                this.txtcochudonvi.Text = this.dgvhoadon.Rows[rowIndex].Cells["COCHUDONVI"].Value.ToString().Trim();
                this.ngaysuahoadon = this.dgvhoadon.Rows[rowIndex].Cells["Ngayhoadon"].Value.ToString().Trim();
                this.hinhthuc = this.dgvhoadon.Rows[rowIndex].Cells["hinhthucthanhtoan1"].Value.ToString().Trim();
                if (this.cobnhapxuat.SelectedIndex == 0)
                {
                    DataTable dataSource = new DataTable();
                   // dataSource = this.xhd.GET_HOADONXUAT_CHITIETHOADON(this.ma.Trim());
                    this.dgvchitiethoadon.DataSource = dataSource;
                }
                else
                {
                    DataTable dataSource = new DataTable();
                  //  dataSource = this.xhd.GET_HOADONNHAP_CHITIETHOADON(this.ma.Trim());
                    this.dgvchitiethoadon.DataSource = dataSource;
                }
                this.tinhtinhtong1();
            }
            catch
            {
            }
        }

        // Token: 0x0600068A RID: 1674 RVA: 0x00131C54 File Offset: 0x0012FE54
        private void dgvhoadon_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvhoadon.RowCount; i++)
            {
                this.dgvhoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x0600068B RID: 1675 RVA: 0x00131CA8 File Offset: 0x0012FEA8
        private void btsuahoadon_Click(object sender, EventArgs e)
        {
            if (this.dgvhoadon.RowCount > 0)
            {
                int rowIndex = this.dgvhoadon.CurrentCell.RowIndex;
                this.ma = this.dgvhoadon.Rows[rowIndex].Cells["SOHOADON"].Value.ToString();
                this.txtmahoadon.Text = this.ma;
                this.btsuahoadon.SendToBack();
                this.btluu.BringToFront();
                this.txtmahoadon.Visible = true;
                this.bthuy.BringToFront();
                this.dgvhoadon.ReadOnly = false;
            }
        }

        // Token: 0x0600068C RID: 1676 RVA: 0x00131D64 File Offset: 0x0012FF64
        private void btluu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "UPDATE TB_HANGHOAXUAT SET MAHOADON='",
            //        this.ma,
            //        "' WHERE MAHOADON='",
            //        this.txtmahoadon.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    string cmdText2 = string.Concat(new string[]
            //    {
            //        "UPDATE Tb_HOADONXUAT SET SOHOADON='",
            //        this.ma,
            //        "',NGAYHOADON='",
            //        this.ngaysuahoadon,
            //        "',HINHTHUCTHANHTOAN=N'",
            //        this.hinhthuc,
            //        "' WHERE SOHOADON='",
            //        this.txtmahoadon.Text,
            //        "'"
            //    });
            //    SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlCommand2.ExecuteNonQuery();
            //    this.dgvhoadon.ReadOnly = true;
            //    this.btsuahoadon.BringToFront();
            //    this.btluu.SendToBack();
            //    this.txtmahoadon.Visible = false;
            //    this.bthuy.SendToBack();
            //    this.txtsohoadon.Text = "";
            //    this.ngaysuahoadon = "";
            //    this.hinhthuc = "";
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600068D RID: 1677 RVA: 0x00131EE8 File Offset: 0x001300E8
        private void bthuy_Click(object sender, EventArgs e)
        {
            this.btsuahoadon.BringToFront();
            this.btluu.SendToBack();
            this.txtmahoadon.Visible = false;
            this.bthuy.SendToBack();
            this.txtsohoadon.Text = "";
            this.dgvhoadon.ReadOnly = true;
            this.ngaysuahoadon = "";
            this.hinhthuc = "";
        }

        // Token: 0x0600068E RID: 1678 RVA: 0x00131F5C File Offset: 0x0013015C
        //private void xuathanghoa(Hanghoaxuat hhxObj)
        //{
        //    try
        //    {
        //        for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
        //        {
        //            double num = double.Parse(this.dgvchitiethoadon.Rows[i].Cells["sl"].Value.ToString());
        //            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //            string text = num.ToString("", cultureInfo.NumberFormat);
        //            hhxObj.Soluong = text.ToString();
        //            string text2 = double.Parse(this.dgvchitiethoadon.Rows[i].Cells["DONGIA"].Value.ToString()).ToString("", cultureInfo.NumberFormat);
        //            double num2 = double.Parse(this.dgvchitiethoadon.Rows[i].Cells["Thanhtien"].Value.ToString());
        //            string text3 = num2.ToString("", cultureInfo.NumberFormat);
        //            double num3 = num2 * 10.0 / 100.0;
        //            string cmdText = string.Concat(new string[]
        //            {
        //                "update TB_HANGHOAXUAT set MAHANGHOA='",
        //                this.dgvchitiethoadon.Rows[i].Cells["Mahanghoa"].Value.ToString(),
        //                "',SOLUONG='",
        //                text.ToString(),
        //                "',DONGIA='",
        //                text2.ToString(),
        //                "',THANHTIEN='",
        //                text3.ToString(),
        //                "',VAT='",
        //                num3.ToString(),
        //                "' WHERE STT='",
        //                this.dgvchitiethoadon.Rows[i].Cells["stt1"].Value.ToString(),
        //                "' AND MAHOADON='",
        //                this.textBox1.Text,
        //                "'"
        //            });
        //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
        //            sqlConnection.Open();
        //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //            sqlCommand.ExecuteNonQuery();
        //            string cmdText2 = "select * from TB_HANGHOA where mahanghoa='" + this.dgvchitiethoadon.Rows[i].Cells["Mahanghoa"].Value.ToString() + "'";
        //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
        //            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
        //            if (!sqlDataReader.HasRows)
        //            {
        //                this.hhObj.Mahanghoa = this.dgvchitiethoadon.Rows[i].Cells["Mahanghoa"].Value.ToString();
        //                this.hhObj.Tenhanghoa = this.dgvchitiethoadon.Rows[i].Cells["Tenhanghoa"].Value.ToString();
        //                this.hhObj.Dongia = this.dgvchitiethoadon.Rows[i].Cells["DONGIA"].Value.ToString();
        //                this.hhObj.Ghichu = "";
        //                this.hhObj.Donvitinh = this.dgvchitiethoadon.Rows[i].Cells["DVT"].Value.ToString();
        //                this.xhdCtr.ADD_HANGHOA(this.hhObj);
        //            }
        //            sqlConnection.Close();
        //        }
        //        MessageBox.Show("LƯU THÀNH CÔNG");
        //    }
        //    catch
        //    {
        //    }
        //}

        // Token: 0x0600068F RID: 1679 RVA: 0x0001CBB1 File Offset: 0x0001ADB1
        private void button1_Click(object sender, EventArgs e)
        {
            this.dgvchitiethoadon.ReadOnly = false;
            this.button3.BringToFront();
            this.button2.BringToFront();
            this.button1.SendToBack();
        }

        // Token: 0x06000690 RID: 1680 RVA: 0x00132348 File Offset: 0x00130548
        private void button3_Click(object sender, EventArgs e)
        {
            //this.dgvchitiethoadon.ReadOnly = false;
            //this.button1.BringToFront();
            //this.button2.SendToBack();
            //this.button3.SendToBack();
            //this.xuathanghoa(this.hhxObj);
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhd.GET_HOADONXUAT_CHITIETHOADON(this.ma);
            //this.dgvchitiethoadon.DataSource = dataSource;
        }

        // Token: 0x06000691 RID: 1681 RVA: 0x0001CBE5 File Offset: 0x0001ADE5
        private void button2_Click(object sender, EventArgs e)
        {
            this.dgvchitiethoadon.ReadOnly = true;
            this.button1.BringToFront();
            this.button2.SendToBack();
            this.button3.SendToBack();
        }

        // Token: 0x06000692 RID: 1682 RVA: 0x001323BC File Offset: 0x001305BC
        private void dgvchitiethoadon_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    int rowIndex = this.dgvchitiethoadon.CurrentCell.RowIndex;
            //    string text = this.dgvchitiethoadon.Rows[rowIndex].Cells["STT1"].Value.ToString();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "DELETE FROM TB_HANGHOAXUAT WHERE MAHOADON='",
            //        this.textBox1.Text,
            //        "' AND STT='",
            //        text,
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.xhd.GET_HOADONXUAT_CHITIETHOADON(this.ma);
            //    this.dgvchitiethoadon.DataSource = dataSource;
            //}
        }

        // Token: 0x06000693 RID: 1683 RVA: 0x001324B4 File Offset: 0x001306B4
        private void dgvchitiethoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
            {
                this.dgvchitiethoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000694 RID: 1684 RVA: 0x00132508 File Offset: 0x00130708
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

        // Token: 0x06000695 RID: 1685 RVA: 0x00132588 File Offset: 0x00130788
        private void txtcochudonvi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtcochudonvi.Text) < 11)
                {
                    this.txtdocao.Text = (11 - int.Parse(this.txtcochudonvi.Text)).ToString();
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

        // Token: 0x06000696 RID: 1686 RVA: 0x00132608 File Offset: 0x00130808
        private void btxoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int rowIndex = this.dgvhoadon.CurrentCell.RowIndex;
            //    string text = this.dgvhoadon.Rows[rowIndex].Cells["sohoadon"].Value.ToString();
            //    DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn   " + text, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE FROM TB_HANGHOAXUAT WHERE MAHOADON='",
            //            text,
            //            "' DELETE FROM TB_HOADONXUAT WHERE SOHOADON='",
            //            text,
            //            "' "
            //        });
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        this.GETXUATHOADONNGAY();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Không xóa đc hóa đơn này");
            //}
        }

        // Token: 0x06000697 RID: 1687 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button4_Click(object sender, EventArgs e)
        {
          //  base.Close();
        }

        // Token: 0x06000698 RID: 1688 RVA: 0x00132714 File Offset: 0x00130914
        private void Frmxuatnhaphoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInhoadonvat frmInhoadonvat = new FrmInhoadonvat();
            frmInhoadonvat.Show();
        }

        // Token: 0x06000699 RID: 1689 RVA: 0x00132730 File Offset: 0x00130930
        private void dgvchitiethoadon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvchitiethoadon.CurrentRow.Index;
            if (this.dgvchitiethoadon.CurrentCell.ColumnIndex == 4 || this.dgvchitiethoadon.CurrentCell.ColumnIndex == 5)
            {
                this.intienviet = this.dgvhoadon.Rows[index].Cells["Intienviet1"].Value.ToString();
                this.tongsoluong = 0.0;
                double num = 0.0;
                for (int i = 0; i < this.dgvchitiethoadon.RowCount; i++)
                {
                    if (this.intienviet == "True")
                    {
                        this.dgvchitiethoadon["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvchitiethoadon["SL", i].Value.ToString()) * double.Parse(this.dgvchitiethoadon["DONGIA", i].Value.ToString()));
                    }
                    else
                    {
                        this.dgvchitiethoadon["Thanhtien", i].Value = Math.Round(double.Parse(this.dgvchitiethoadon["SL", i].Value.ToString()) * double.Parse(this.dgvchitiethoadon["DONGIA", i].Value.ToString()), 2);
                    }
                    this.tongsoluong += double.Parse(this.dgvchitiethoadon["SL", i].Value.ToString());
                    num += double.Parse(this.dgvchitiethoadon["Thanhtien", i].Value.ToString());
                }
                int num2 = int.Parse(this.txtptthue.Text);
                if (this.intienviet == "True")
                {
                    double num3 = num * (double)num2 / 100.0;
                    double num4 = num + num3;
                    this.txtphantramtien.Text = num3.ToString("#,##0");
                    this.txtthanhtoan.Text = num4.ToString("#,##0");
                    this.txtcongtienhang.Text = num.ToString("#,##0");
                    this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu(double.Parse(this.txtthanhtoan.Text));
                }
                else
                {
                    double num3 = num * (double)num2 / 100.0;
                    double num4 = num + num3;
                    this.txtphantramtien.Text = num3.ToString("#,##0.##");
                    this.txtthanhtoan.Text = num4.ToString("#,##0.##");
                    this.txtcongtienhang.Text = num.ToString("#,##0.##");
                    this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu_usd(Math.Floor(double.Parse(this.txtthanhtoan.Text)));
                    double num5 = num4 - Math.Floor(num4);
                    string s = (num5 * 100.0).ToString("#,##0");
                    if (int.Parse(s) > 0)
                    {
                        this.txtbangchu.Text = Frmxuatnhaphoadon.So_chu_usd(Math.Floor(double.Parse(this.txtthanhtoan.Text))) + " " + Frmxuatnhaphoadon.So_chu_sen((double)int.Parse(s));
                    }
                }
            }
        }

        // Token: 0x0600069A RID: 1690 RVA: 0x00132ADC File Offset: 0x00130CDC
        public void GhiDuLieuVaoText(DataGridView data, string teptext)
        {
            StreamWriter streamWriter = File.AppendText(teptext);
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                string text = "";
                for (int j = 0; j < data.Columns.Count - 1; j++)
                {
                    text = text + data[j, i].Value.ToString() + "#";
                }
                text += data[data.Columns.Count - 1, i].Value.ToString();
                streamWriter.WriteLine(text);
            }
            streamWriter.Close();
        }

        // Token: 0x0600069B RID: 1691 RVA: 0x00132B8C File Offset: 0x00130D8C
        private void bttxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "WAP Files (*.txt)|*.txt";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(File.Create(saveFileDialog.FileName));
                DateTime dateTime = Convert.ToDateTime(this.dttungay.Text);
                DateTime dateTime2 = Convert.ToDateTime(this.dtdenngay.Text);
                DataTable dataSource = new DataTable();
                this.dgvfiletxt.DataSource = dataSource;
                string text = "";
                int count = this.dgvfiletxt.Rows.Count;
                int count2 = this.dgvfiletxt.Rows[1].Cells.Count;
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count2; j++)
                    {
                        if (this.dgvfiletxt.Rows[i].Cells[j].Value == null)
                        {
                            this.dgvfiletxt.Rows[i].Cells[j].Value = "null";
                        }
                        text = text + this.dgvfiletxt.Rows[i].Cells[j].Value.ToString() + "  ";
                    }
                    text += Environment.NewLine;
                }
                streamWriter.WriteLine(text);
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }

        //// Token: 0x04000785 RID: 1925
        //private Hanghoaxuat hhxObj = new Hanghoaxuat();

        //// Token: 0x04000786 RID: 1926
        //private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        // Token: 0x04000787 RID: 1927
        private string ma = "";

        // Token: 0x04000788 RID: 1928
        private string hinhthucthanhtoan = "";

        // Token: 0x04000789 RID: 1929
        private string ngaysuahoadon = "";

        // Token: 0x0400078A RID: 1930
        private string mayin = "";

        // Token: 0x0400078B RID: 1931
        private string hinhthuc = "";

        // Token: 0x0400078C RID: 1932
        private string ngayxuathoadon = "";

        // Token: 0x0400078D RID: 1933
        private string makhachhang = "";

        // Token: 0x0400078E RID: 1934
        private double tigiausd = 0.0;

        // Token: 0x0400078F RID: 1935
        private double tongsoluong = 0.0;

        // Token: 0x04000790 RID: 1936
        private string inmahang = "True";

        // Token: 0x04000791 RID: 1937
        private string intienviet = "True";

        // Token: 0x04000792 RID: 1938
        private string tenusd = "VND";

        // Token: 0x04000793 RID: 1939
        private int CAOTONGSOLUONG = 0;

        // Token: 0x04000794 RID: 1940
        private int TIGIA = 0;

        // Token: 0x04000795 RID: 1941
        private int LEMAHANG = 0;

        // Token: 0x04000796 RID: 1942
        private int DODAIHANGHOA = 0;

        // Token: 0x04000797 RID: 1943
        private int DODAIMAHANG = 0;

        // Token: 0x04000798 RID: 1944
        private int COCHUHANGHOA = 0;

        // Token: 0x04000799 RID: 1945
        private int COCHU = 0;

        // Token: 0x0400079A RID: 1946
        private int a = 0;

        // Token: 0x0400079B RID: 1947
        private int left = 0;

        // Token: 0x0400079C RID: 1948
        private int ngaythangcao = 0;

        // Token: 0x0400079D RID: 1949
        private int lengay = 0;

        // Token: 0x0400079E RID: 1950
        private int lethang = 0;

        // Token: 0x0400079F RID: 1951
        private int lenam = 0;

        // Token: 0x040007A0 RID: 1952
        private int caokh = 0;

        // Token: 0x040007A1 RID: 1953
        private int caonguoimuahang = 0;

        // Token: 0x040007A2 RID: 1954
        private int caodonvi = 0;

        // Token: 0x040007A3 RID: 1955
        private int caomasothue = 0;

        // Token: 0x040007A4 RID: 1956
        private int caothanhtoan = 0;

        // Token: 0x040007A5 RID: 1957
        private int caosotaikhoan = 0;

        // Token: 0x040007A6 RID: 1958
        private int caodiachi = 0;

        // Token: 0x040007A7 RID: 1959
        private int lenguoimuahang = 0;

        // Token: 0x040007A8 RID: 1960
        private int ledonvi = 0;

        // Token: 0x040007A9 RID: 1961
        private int lemasothue = 0;

        // Token: 0x040007AA RID: 1962
        private int lethanhtoan = 0;

        // Token: 0x040007AB RID: 1963
        private int lesotaikhoan = 0;

        // Token: 0x040007AC RID: 1964
        private int lediachi = 0;

        // Token: 0x040007AD RID: 1965
        private int caohanghoa = 0;

        // Token: 0x040007AE RID: 1966
        private int lethutu = 0;

        // Token: 0x040007AF RID: 1967
        private int lehanghoa = 0;

        // Token: 0x040007B0 RID: 1968
        private int lesoluong = 0;

        // Token: 0x040007B1 RID: 1969
        private int ledongia = 0;

        // Token: 0x040007B2 RID: 1970
        private int lethanhtien = 0;

        // Token: 0x040007B3 RID: 1971
        private int ledonvitinh = 0;

        // Token: 0x040007B4 RID: 1972
        private int caotongcong = 0;

        // Token: 0x040007B5 RID: 1973
        private int caobangchu = 0;

        // Token: 0x040007B6 RID: 1974
        private int letongcong = 0;

        // Token: 0x040007B7 RID: 1975
        private int levat = 0;

        // Token: 0x040007B8 RID: 1976
        private int lebangchu = 0;

        // Token: 0x040007B9 RID: 1977
        private int caodong = 0;

        // Token: 0x040007BA RID: 1978
        private int numberOfItemsPerPage = 0;

        // Token: 0x040007BB RID: 1979
        private int numberOfItemsPrintedSoFar = 0;

        //// Token: 0x040007BC RID: 1980
        //private XuathoadonCtr xhd = new XuathoadonCtr();

        //// Token: 0x040007BD RID: 1981
        //private KhachhangObj khobj = new KhachhangObj();

        //// Token: 0x040007BE RID: 1982
        //private HanghoaHdObj hhObj = new HanghoaHdObj();
    }
}
