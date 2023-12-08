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
    public partial class frmThuChi : Form
    {
        public frmThuChi()
        {
            InitializeComponent();
        }
        private void loadnhanvien()
        {
            DataTable dataSource = new DataTable();
          //  dataSource = this.ndctr.getData_Login();
            this.cobnhanvien.DataSource = dataSource;
            this.cobnhanvien.DisplayMember = "Tentaikhoan";
            this.cobnhanvien.ValueMember = "mataikhoan";
            this.cobnhanvien.SelectedIndex = -1;
        }

        // Token: 0x06000242 RID: 578 RVA: 0x00089808 File Offset: 0x00087A08
        private void tudongcapnhattennhanvien()
        {
            //this.cobnhanvien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.cobnhanvien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select tentaikhoan from Tb_nguoidung";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.cobnhanvien.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000243 RID: 579 RVA: 0x000898A4 File Offset: 0x00087AA4
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

        // Token: 0x06000244 RID: 580 RVA: 0x00062194 File Offset: 0x00060394
        private static string Donvi(string so)
        {
            string result = "";
            if (so.Equals("1"))
            {
                result = "";
            }
            if (so.Equals("2"))
            {
                result = "nghìn";
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
                result = "nghìn tỷ";
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

        // Token: 0x06000245 RID: 581 RVA: 0x000899EC File Offset: 0x00087BEC
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
                        text = " không trăm lẻ " + frmThuChi.Chu(text4.ToString().Trim()) + " ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && text4.Equals("0"))
                    {
                        text = frmThuChi.Chu(text2.ToString().Trim()).Trim() + " trăm ";
                    }
                    if (!text2.Equals("0") && text3.Equals("0") && !text4.Equals("0"))
                    {
                        text = frmThuChi.Chu(text2.ToString().Trim()).Trim() + " trăm lẻ " + frmThuChi.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            " không trăm ",
                            frmThuChi.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            frmThuChi.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
                    {
                        text = " không trăm " + frmThuChi.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
                    {
                        text = " không trăm " + frmThuChi.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = " không trăm mười " + frmThuChi.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = " không trăm mười ";
                    }
                    if (text2.Equals("0") && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = " không trăm mười lăm ";
                    }
                    if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = string.Concat(new string[]
                        {
                            frmThuChi.Chu(text2.Trim()).Trim(),
                            " trăm ",
                            frmThuChi.Chu(text3.Trim()).Trim(),
                            " mươi ",
                            frmThuChi.Chu(text4.Trim()).Trim(),
                            " "
                        });
                    }
                    if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
                    {
                        text = frmThuChi.Chu(text2.Trim()).Trim() + " trăm " + frmThuChi.Chu(text3.Trim()).Trim() + " mươi ";
                    }
                    if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
                    {
                        text = frmThuChi.Chu(text2.Trim()).Trim() + " trăm " + frmThuChi.Chu(text3.Trim()).Trim() + " mươi lăm ";
                    }
                    if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
                    {
                        text = frmThuChi.Chu(text2.Trim()).Trim() + " trăm mười " + frmThuChi.Chu(text4.Trim()).Trim() + " ";
                    }
                    if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && text4.Equals("0"))
                    {
                        text = frmThuChi.Chu(text2.Trim()).Trim() + " trăm mười ";
                    }
                    if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && text4.Equals("5"))
                    {
                        text = frmThuChi.Chu(text2.Trim()).Trim() + " trăm mười lăm ";
                    }
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000246 RID: 582 RVA: 0x00089FA0 File Offset: 0x000881A0
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
                    text = frmThuChi.Tach(tach).ToString().Trim() + " " + frmThuChi.Donvi(num3.ToString().Trim());
                }
                int i = num;
                int num4 = num;
                int num5 = 1;
                while (i > 0)
                {
                    string text5 = text2.Trim().Substring(0, 3).Trim();
                    string text6 = text5;
                    text = text.Trim() + " " + frmThuChi.Tach(text5.Trim()).Trim();
                    num = num4 + 1 - num5;
                    if (!text6.Equals("000"))
                    {
                        text = text.Trim() + " " + frmThuChi.Donvi(num.ToString().Trim()).Trim();
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

        // Token: 0x06000247 RID: 583 RVA: 0x0008A32C File Offset: 0x0008852C
        private void Bingding()
        {
            try
            {
                this.txtlydo.DataBindings.Clear();
                this.txtlydo.DataBindings.Add("Text", this.dgvthuchi.DataSource, "lydo");
                this.txtghichu.DataBindings.Clear();
                this.txtghichu.DataBindings.Add("Text", this.dgvthuchi.DataSource, "ghichu");
                this.txtngaythu.DataBindings.Clear();
                this.txtngaythu.DataBindings.Add("Text", this.dgvthuchi.DataSource, "ngay");
                this.txtmathuchi.DataBindings.Clear();
                this.txtmathuchi.DataBindings.Add("Text", this.dgvthuchi.DataSource, "mathuchi");
                this.txtchungtu.DataBindings.Clear();
                this.txtchungtu.DataBindings.Add("Text", this.dgvthuchi.DataSource, "CHUNGTU");
                this.txtmakhachhang.Text = this.dgvthuchi.CurrentRow.Cells["MAKH"].Value.ToString();
                this.txttenkhachhang.DataBindings.Clear();
                this.txttenkhachhang.DataBindings.Add("Text", this.dgvthuchi.DataSource, "TENDONVI");
            }
            catch
            {
            }
        }

        // Token: 0x06000248 RID: 584 RVA: 0x0008A4DC File Offset: 0x000886DC
        private void mathuchihd()
        {
            //string selectCommandText = string.Concat(new object[]
            //{
            //    "select mathuchi from Tb_Thuchi where left(mathuchi,1)='",
            //    this.cobthuchi.SelectedIndex,
            //    "' and SUBSTRING(mathuchi,2,4)='",
            //    DateTime.Now.ToString("MMyy"),
            //    "'"
            //});
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //{
            //    ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //});
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //string text;
            //if (dataTable.Rows.Count <= 0)
            //{
            //    text = this.cobthuchi.SelectedIndex + DateTime.Now.ToString("MMyy") + "00001";
            //    this.k = 1.0;
            //}
            //else
            //{
            //    string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(1, 4));
            //    text = DateTime.Now.ToString("MMyy");
            //    if (a == text)
            //    {
            //        this.k = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(5, 5));
            //        this.k += 1.0;
            //        if (this.k < 10.0)
            //        {
            //            text += "0000";
            //        }
            //        else if (this.k < 100.0)
            //        {
            //            text += "000";
            //        }
            //        else if (this.k < 1000.0)
            //        {
            //            text += "00";
            //        }
            //        else if (this.k < 10000.0)
            //        {
            //            text += "0";
            //        }
            //        text = this.cobthuchi.SelectedIndex + text + this.k.ToString();
            //    }
            //    else
            //    {
            //        text = this.cobthuchi.SelectedIndex + DateTime.Now.ToString("MMyy") + "00001";
            //        this.k = 1.0;
            //    }
            //}
            //this.matc = text;
        }

        // Token: 0x06000249 RID: 585 RVA: 0x0008A790 File Offset: 0x00088990
        //private void NHAPLIEU(ThuchiObj tcObj)
        //{
        //    this.mathuchihd();
        //    tcObj.Mathuchi = this.matc;
        //    if (this.cobthuchi.SelectedIndex == 0)
        //    {
        //        tcObj.Chiphi = "1";
        //        tcObj.Chungtu = this.txttenkhachhang.Text + "; " + this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuhopdong = "False";
        //        tcObj.Thuchi = "THU";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 2)
        //    {
        //        tcObj.Chiphi = "1";
        //        tcObj.Chungtu = this.txttenkhachhang.Text + "; " + this.txtchungtu.Text;
        //        tcObj.Thuchi = "CHI";
        //        tcObj.Sotien = 0m;
        //        tcObj.Tienchi = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 1)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuchi = "THU";
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 3)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Thuchi = "CHI";
        //        tcObj.Sotien = 0m;
        //        tcObj.Tienchi = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 4)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuchi = "THU";
        //        tcObj.Thuhopdong = "True";
        //    }
        //    tcObj.Ngay = this.txtngaythu.Text;
        //    tcObj.Lydo = this.txtlydo.Text;
        //    tcObj.Ghichu = this.txtghichu.Text;
        //    tcObj.Makh = this.txtmakhachhang.Text;
        //    tcObj.Manv = frmLogIn.MADANGNHAP;
        //    this.tcCtr.ADD_THUCHI(tcObj);
        //}

        // Token: 0x0600024A RID: 586 RVA: 0x0008AA84 File Offset: 0x00088C84
        //private void SUANHAPLIEU(ThuchiObj tcObj)
        //{
        //    tcObj.Makh = this.txtmakhachhang.Text;
        //    tcObj.Manv = frmLogIn.MADANGNHAP;
        //    tcObj.Mathuchi = this.txtmathuchi.Text;
        //    if (this.cobthuchi.SelectedIndex == 0)
        //    {
        //        tcObj.Chungtu = this.txttenkhachhang.Text + "; " + this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuchi = "THU";
        //        tcObj.Chiphi = "1";
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 2)
        //    {
        //        tcObj.Chungtu = this.txttenkhachhang.Text + "; " + this.txtchungtu.Text;
        //        tcObj.Thuchi = "CHI";
        //        tcObj.Sotien = 0m;
        //        tcObj.Tienchi = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Chiphi = "1";
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 1)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuchi = "THU";
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 3)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Thuchi = "CHI";
        //        tcObj.Sotien = 0m;
        //        tcObj.Tienchi = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Thuhopdong = "False";
        //    }
        //    else if (this.cobthuchi.SelectedIndex == 4)
        //    {
        //        tcObj.Chiphi = "0";
        //        tcObj.Chungtu = this.txtchungtu.Text;
        //        tcObj.Sotien = Convert.ToDecimal(this.txtsotien.Text);
        //        tcObj.Tienchi = 0m;
        //        tcObj.Thuchi = "THU";
        //        tcObj.Thuhopdong = "True";
        //    }
        //    tcObj.Ngay = this.txtngaythu.Text;
        //    tcObj.Lydo = this.txtlydo.Text;
        //    tcObj.Ghichu = this.txtghichu.Text;
        //    tcObj.Thuchi = this.cobthuchi.Text;
        //    tcObj.Chungtu = this.txtchungtu.Text;
        //    //this.tcCtr.UP_THUCHI(tcObj);
        //}

        // Token: 0x0600024B RID: 587 RVA: 0x0008AD9C File Offset: 0x00088F9C
        private void btthem_Click(object sender, EventArgs e)
        {
            this.bttim.Visible = true;
            this.cobthuchi.SelectedIndex = frmThuChi.sophieu;
            this.txtmathuchi.Text = "";
            this.txtghichu.Text = "";
            this.txtsotien.Text = "0";
            this.txtlydo.Text = "";
            this.txtchungtu.Text = "";
            this.txtngaythu.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            this.Dis_en(false);
            this.txttenkhachhang.Text = frmThuChi.tenkhachhang;
            this.txtmakhachhang.Text = frmThuChi.makhachhang;
            if (this.txttenkhachhang.Text != "")
            {
                this.dgvtimkhachhang.Visible = false;
                this.txtsotien.Focus();
            }
            else
            {
                this.txttenkhachhang.Focus();
            }
        }

        // Token: 0x0600024C RID: 588 RVA: 0x0008AEAC File Offset: 0x000890AC
        private void btluu_Click(object sender, EventArgs e)
        {
            //if (this.txtsotien.Text != "0" && this.txtlydo.Text != "")
            //{
            //    if (this.txtmathuchi.Text == "")
            //    {
            //        this.NHAPLIEU(this.tcObj);
            //        this.Dis_en(true);
            //    }
            //    else
            //    {
            //        this.SUANHAPLIEU(this.tcObj);
            //    }
            //    this.txttenkhachhang.Text = "";
            //    this.txtmakhachhang.Text = "";
            //    this.txtmathuchi.Text = "";
            //    this.txtghichu.Text = "";
            //    this.txtsotien.Text = "0";
            //    this.txtlydo.Text = "";
            //    this.txtngaythu.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //    this.LOADDULIEUTHUCHI();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa nhập số tiền hoặc nội dung");
            //}
        }

        // Token: 0x0600024D RID: 589 RVA: 0x0008AFD4 File Offset: 0x000891D4
        private void cobthuchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!this.btthem.Visible)
                {
                    if (this.cobthuchi.SelectedIndex == 2)
                    {
                        this.txttenkhachhang.Enabled = true;
                        this.lbthuchi.Text = "Ngày Chi:";
                        this.lbkhachhang.Text = "Người nhận tiền:";
                    }
                    else if (this.cobthuchi.SelectedIndex == 0)
                    {
                        this.txttenkhachhang.Enabled = true;
                        this.lbthuchi.Text = "Ngày Thu:";
                        this.lbkhachhang.Text = "Người nộp tiền:";
                    }
                    else if (this.cobthuchi.SelectedIndex == 1)
                    {
                        this.txttenkhachhang.Enabled = true;
                        this.lbthuchi.Text = "Ngày Thu:";
                        this.lbkhachhang.Text = "Người nộp tiền:";
                    }
                    if (this.cobthuchi.SelectedIndex == 3)
                    {
                        this.txttenkhachhang.Enabled = true;
                        this.lbthuchi.Text = "Ngày Chi:";
                        this.lbkhachhang.Text = "Người nhận tiền:";
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            this.txttenkhachhang.Focus();
        }

        // Token: 0x0600024E RID: 590 RVA: 0x0008B150 File Offset: 0x00089350
        private void load_nhaphang()
        {
            //if (TrangChu.tien_nhaphang == "True")
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            //    this.tiennhaphang = "0";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "SELECT ISNULL(SUM((HHN.SOLUONG/HH.QUYDOI1)*HHN.DONGIA),0) FROM TB_HANGHOA HH,TB_HANGHOANHAP HHN WHERE HH.MAHANGHOA=HHN.MAHANGHOA AND HHN.MALOAI='0'  AND CONVERT(DATETIME,NGAYNHAP,103) >='",
            //        dateTime2.ToString("MM/dd/yyyy"),
            //        "' AND CONVERT(DATETIME,NGAYNHAP,103) <='",
            //        dateTime.ToString("MM/dd/yyyy"),
            //        "'"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.tiennhaphang = sqlDataReader.GetValue(0).ToString();
            //    }
            //    sqlConnection.Close();
            //    string s = "0";
            //    string cmdText2 = string.Concat(new string[]
            //    {
            //        "SELECT ISNULL(SUM(HHN.SOLUONG*HHN.DONGIA),0) FROM TB_HANGHOANHAP_NL HHN WHERE HHN.MALOAI='0'  AND CONVERT(DATETIME,NGAYNHAP,103) >='",
            //        dateTime2.ToString("MM/dd/yyyy"),
            //        "' AND CONVERT(DATETIME,NGAYNHAP,103) <='",
            //        dateTime.ToString("MM/dd/yyyy"),
            //        "'"
            //    });
            //    SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    if (sqlConnection.State == ConnectionState.Closed)
            //    {
            //        sqlConnection.Open();
            //    }
            //    sqlDataReader = sqlCommand2.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        s = sqlDataReader.GetValue(0).ToString();
            //    }
            //    sqlConnection.Close();
            //    string s2 = "0";
            //    try
            //    {
            //        string cmdText3 = string.Concat(new string[]
            //        {
            //            " select isnull( sum(tientrano),0) from tb_thuchi where CHIPHI='0' AND thuchi='CHI'and convert(datetime,ngay,103)>='",
            //            dateTime2.ToString("yyyy/MM/dd 00:00"),
            //            "' and convert(datetime,ngay,103)<='",
            //            dateTime.ToString("yyyy/MM/dd 23:59"),
            //            "'"
            //        });
            //        SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //        sqlConnection.Open();
            //        sqlDataReader = sqlCommand3.ExecuteReader();
            //        while (sqlDataReader.Read())
            //        {
            //            s2 = sqlDataReader.GetSqlValue(0).ToString();
            //        }
            //        sqlConnection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        string message = ex.Message;
            //    }
            //    this.txtnhaphang.Text = (decimal.Parse(s) + decimal.Parse(s2) + decimal.Parse(this.tiennhaphang)).ToString("#,##0");
            //}
            //else
            //{
            //    this.txtnhaphang.Text = "0";
            //}
        }

        // Token: 0x0600024F RID: 591 RVA: 0x0008B404 File Offset: 0x00089604
        private void frmThuChi_Load(object sender, EventArgs e)
        {
            try
            {
                //if (TrangChu.baocaok80 == "True")
                //{
                //    this.checkBox1.Checked = true;
                //}
                this.dgvtimkhachhang.BringToFront();
                base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
                this.dttungay.Text = DateTime.Now.ToString("dd/MM/yyyy");
                this.dtdenngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
                this.cobthuchi.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cobloaiphieu.DropDownStyle = ComboBoxStyle.DropDownList;
                this.txtngaythu.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                this.cobloaiphieu.SelectedIndex = 2;
                this.LOADDULIEUTHUCHI();
                this.loadnhanvien();
                this.btthem_Click(null, null);
            }
            catch
            {
            }
        }

        // Token: 0x06000250 RID: 592 RVA: 0x0008B53C File Offset: 0x0008973C
        private void tongthuchi()
        {
            try
            {
                decimal d = decimal.Parse(this.txttongchi.Text);
                decimal d2 = decimal.Parse(this.txttongthu.Text);
                decimal d3 = decimal.Parse(this.txttienbanhang.Text);
                decimal d4 = decimal.Parse(this.txtnhaphang.Text);
                decimal d5 = decimal.Parse(this.txttiencu.Text);
                decimal d6 = d5 + d3 + d2 - d - d4;
                if (d6 != 0m)
                {
                    this.txttongthuchi.Text = d6.ToString("#,##0");
                }
                else
                {
                    this.txttongthuchi.Text = "0";
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000251 RID: 593 RVA: 0x0008B628 File Offset: 0x00089828
        private void LOADDULIEU()
        {
            DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            DataTable dataSource = new DataTable();
         //   dataSource = this.tcCtr.GET_THUCHI(this.cobloaiphieu.Text, dateTime2.ToString("yyyy/MM/dd"), dateTime.ToString("yyyy/MM/dd"));
            this.dgvthuchi.DataSource = dataSource;
        }

        // Token: 0x06000252 RID: 594 RVA: 0x0008B69C File Offset: 0x0008989C
        private void LOADDULIEU_THU(string hd, string nv)
        {
            DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            DataTable dataSource = new DataTable();
        //    dataSource = this.tcCtr.GET_THUCHI_THUHOPDONG("THU", dateTime2.ToString("yyyy/MM/dd"), dateTime.ToString("yyyy/MM/dd"), hd, nv);
            this.dgvthuchi.DataSource = dataSource;
        }

        // Token: 0x06000253 RID: 595 RVA: 0x0008B70C File Offset: 0x0008990C
        private void LOADDULIEU_nhanvien()
        {
            DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            DataTable dataSource = new DataTable();
           // dataSource = this.tcCtr.GET_THUCHI_nhanvien(this.cobloaiphieu.Text, dateTime2.ToString("yyyy/MM/dd"), dateTime.ToString("yyyy/MM/dd"), this.cobnhanvien.SelectedValue.ToString());
            this.dgvthuchi.DataSource = dataSource;
        }

        // Token: 0x06000254 RID: 596 RVA: 0x0008B790 File Offset: 0x00089990
        private void Tongtienthu()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        " select sum(sotien), count(sotien) from tb_thuchi where thuchi='THU' and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        string s = Convert.ToString(sqlDataReader.GetSqlValue(1));
            //        if (int.Parse(s) > 0)
            //        {
            //            this.txttongthu.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //            decimal num = Convert.ToDecimal(this.txttongthu.Text);
            //            this.txttongthu.Text = num.ToString("#,##0");
            //        }
            //        else
            //        {
            //            this.txttongthu.Text = "0";
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000255 RID: 597 RVA: 0x0008B908 File Offset: 0x00089B08
        private void Tongtienthu_hd()
        {
            //try
            //{
            //    string text = "";
            //    if (this.cobnhanvien.Text != "")
            //    {
            //        text = "AND MANV='" + this.cobnhanvien.SelectedValue.ToString() + "'";
            //    }
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            //    string cmdText;
            //    if (this.cobloaiphieu.SelectedIndex == 3)
            //    {
            //        cmdText = string.Concat(new string[]
            //        {
            //            " select sum(sotien), count(sotien) from tb_thuchi where hopdong='True' and thuchi='THU' and convert(datetime,ngay,103)>='",
            //            dateTime2.ToString("yyyy/MM/dd 00:00"),
            //            "' and convert(datetime,ngay,103)<='",
            //            dateTime.ToString("yyyy/MM/dd 23:59"),
            //            "' ",
            //            text
            //        });
            //    }
            //    else
            //    {
            //        cmdText = string.Concat(new string[]
            //        {
            //            " select sum(sotien), count(sotien) from tb_thuchi where hopdong='False' and thuchi='THU' and convert(datetime,ngay,103)>='",
            //            dateTime2.ToString("yyyy/MM/dd 00:00"),
            //            "' and convert(datetime,ngay,103)<='",
            //            dateTime.ToString("yyyy/MM/dd 23:59"),
            //            "' ",
            //            text
            //        });
            //    }
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        string s = Convert.ToString(sqlDataReader.GetSqlValue(1));
            //        if (int.Parse(s) > 0)
            //        {
            //            this.txttongthu.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //            decimal num = Convert.ToDecimal(this.txttongthu.Text);
            //            this.txttongthu.Text = num.ToString("#,##0");
            //        }
            //        else
            //        {
            //            this.txttongthu.Text = "0";
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000256 RID: 598 RVA: 0x0008BB38 File Offset: 0x00089D38
        private void Tongtienthu_nhanvien()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        " select sum(sotien), count(sotien) from tb_thuchi where thuchi='THU' and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "' and manv='",
            //        this.cobnhanvien.SelectedValue.ToString(),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        string s = Convert.ToString(sqlDataReader.GetSqlValue(1));
            //        if (int.Parse(s) > 0)
            //        {
            //            this.txttongthu.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //            decimal num = Convert.ToDecimal(this.txttongthu.Text);
            //            this.txttongthu.Text = num.ToString("#,##0");
            //        }
            //        else
            //        {
            //            this.txttongthu.Text = "0";
            //        }
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000257 RID: 599 RVA: 0x0008BCCC File Offset: 0x00089ECC
        private void TongtienChi()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        " select isnull( sum(tientrano),0) from tb_thuchi where CHIPHI='1' AND thuchi='CHI'and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txttongchi.Text = Convert.ToDecimal(Convert.ToString(sqlDataReader.GetSqlValue(0))).ToString("#,##0");
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000258 RID: 600 RVA: 0x0008BDE4 File Offset: 0x00089FE4
        private void TongtienChinhanvien()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        " select isnull( sum(tientrano),0) from tb_thuchi where thuchi='CHI'and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "'and MaNV='",
            //        this.cobnhanvien.SelectedValue.ToString(),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txttongchi.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //        decimal num = Convert.ToDecimal(this.txttongchi.Text);
            //        this.txttongchi.Text = num.ToString("#,##0");
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000259 RID: 601 RVA: 0x0008BF3C File Offset: 0x0008A13C
        private void TongtienBANHANG()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "Select isnull(sum(thanhtoan),0) from tb_hoadonbanhang where HINHTHUC='1' and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txttienbanhang.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //        decimal num = Convert.ToDecimal(this.txttienbanhang.Text);
            //        this.txttienbanhang.Text = num.ToString("#,##0");
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x0600025A RID: 602 RVA: 0x0008C078 File Offset: 0x0008A278
        private void TongtienBANHANG_nhanvien()
        {
            //try
            //{
            //    DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //    string cmdText = string.Concat(new string[]
            //    {
            //        " select isnull(sum(thanhtoan),0) from tb_hoadonbanhang where HINHTHUC='1' and convert(datetime,ngay,103)>='",
            //        DateTime.Parse(this.dttungay.Text).ToString("yyyy/MM/dd 00:00"),
            //        "' and convert(datetime,ngay,103)<='",
            //        dateTime.ToString("yyyy/MM/dd 23:59"),
            //        "' and nhanvien='",
            //        this.cobnhanvien.SelectedValue.ToString(),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txttienbanhang.Text = Convert.ToString(sqlDataReader.GetSqlValue(0));
            //        decimal num = Convert.ToDecimal(this.txttienbanhang.Text);
            //        this.txttienbanhang.Text = num.ToString("#,##0");
            //    }
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x0600025B RID: 603 RVA: 0x0008C1D0 File Offset: 0x0008A3D0
        private void LOADDULIEUTHUCHI()
        {
            //DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            //DataTable dataSource = new DataTable();
            //dataSource = this.tcCtr.GET_THUVACHI(dateTime2.ToString("yyyy/MM/dd"), dateTime.ToString("yyyy/MM/dd"), "00:00", "23:59");
            //this.dgvthuchi.DataSource = dataSource;
            //this.dgvthuchi.AutoResizeRows();
        }

        // Token: 0x0600025C RID: 604 RVA: 0x0008C250 File Offset: 0x0008A450
        private void TIMKIEMTEN()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT tc.Mathuchi,tc.Sotien,kh.tendonvi,tc.Lydo,tc.Ngay,tc.Ghichu,tc.Thuchi, tc.MaNV,tc.Macongty,tc.CHUNGTU,tc.TIENTRANO,tc.CHIPHI,TC.MAKH from tb_thuchi tc left join tb_khachhang kh on tc.MaKH=kh.MAKHACHHANG WHERE KH.TENDONVI LIKE N'%",
            //    this.textBox15.Text,
            //    "%' OR TC.CHUNGTU LIKE N'%",
            //    this.textBox15.Text,
            //    "%' order by convert(datetime,right(ngay,10),103)"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvthuchi.DataSource = dataTable;
        }

        // Token: 0x0600025D RID: 605 RVA: 0x0008C2F8 File Offset: 0x0008A4F8
        private void TIMKIEMMA()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT tc.Mathuchi,tc.Sotien,kh.tendonvi,tc.Lydo,tc.Ngay,tc.Ghichu,tc.Thuchi, tc.MaNV,tc.Macongty,tc.CHUNGTU,tc.TIENTRANO,tc.CHIPHI,TC.MAKH from tb_thuchi tc left join tb_khachhang kh on tc.MaKH=kh.MAKHACHHANG WHERE TC.MAKH LIKE '%" + this.txttimkiem.Text + "%'  order by convert(datetime,right(ngay,10),103)";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvthuchi.DataSource = dataTable;
        }

        // Token: 0x0600025E RID: 606 RVA: 0x0008C370 File Offset: 0x0008A570
        private void LOADDULIEUTHUCHI_nhanvien()
        {
            //DateTime dateTime = DateTime.Parse(this.dtdenngay.Text);
            //DateTime dateTime2 = DateTime.Parse(this.dttungay.Text);
            //DataTable dataSource = new DataTable();
            //dataSource = this.tcCtr.GET_THUVACHI_nhanvien(dateTime2.ToString("yyyy/MM/dd"), dateTime.ToString("yyyy/MM/dd"), "00:00", "23:59", this.cobnhanvien.SelectedValue.ToString());
            //this.dgvthuchi.DataSource = dataSource;
        }

        // Token: 0x0600025F RID: 607 RVA: 0x0008C3F4 File Offset: 0x0008A5F4
        private void Dis_en(bool e)
        {
            this.txtchungtu.Enabled = !e;
            this.txtmakhachhang.Enabled = !e;
            this.txttenkhachhang.Enabled = !e;
            this.cobthuchi.Enabled = !e;
            this.txtghichu.Enabled = !e;
            this.txtsotien.Enabled = !e;
            this.txtlydo.Enabled = !e;
            this.txtngaythu.Enabled = !e;
            this.btluu.Visible = !e;
            this.btluuin.Visible = !e;
            this.btthoat.Visible = !e;
            this.button1.Visible = e;
            this.btthem.Visible = e;
            this.bttim.Visible = !e;
        }

        // Token: 0x06000260 RID: 608 RVA: 0x0008C4DC File Offset: 0x0008A6DC
        private void btxembaocao_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.txttongthu.Text = "0";
            //    this.txttongthuchi.Text = "0";
            //    this.txttienbanhang.Text = "0";
            //    this.txttongchi.Text = "0";
            //    this.txttienbanhang.Text = "0";
            //    this.txttongthu.Text = "0";
            //    this.txttongthuchi.Text = "0";
            //    this.txttongchi.Text = "0";
            //    this.load_nhaphang();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "SELECT ISNULL(SOTIEN,0) FROM TB_TIENCU WHERE NGAY='" + DateTime.Parse(this.dttungay.Text).AddDays(-1.0).ToString("dd/MM/yyyy") + "'";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            //        this.txttiencu.Text = decimal.Parse(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0");
            //    }
            //    if (!sqlDataReader.HasRows)
            //    {
            //        this.txttiencu.Text = "0";
            //    }
            //    sqlConnection.Close();
            //    if (this.cobloaiphieu.SelectedIndex == 3)
            //    {
            //        string nv = "";
            //        if (this.cobnhanvien.Text != "")
            //        {
            //            nv = " AND MANV='" + this.cobnhanvien.SelectedValue.ToString() + "'";
            //        }
            //        this.TongtienBANHANG();
            //        this.LOADDULIEU_THU("True", nv);
            //        this.TongtienChi();
            //        this.Tongtienthu_hd();
            //        this.tongthuchi();
            //    }
            //    else if (this.cobloaiphieu.SelectedIndex == 4)
            //    {
            //        string nv = "";
            //        if (this.cobnhanvien.Text != "")
            //        {
            //            nv = " AND MANV='" + this.cobnhanvien.SelectedValue.ToString() + "'";
            //        }
            //        this.TongtienBANHANG();
            //        this.LOADDULIEU_THU("False", nv);
            //        this.TongtienChi();
            //        this.Tongtienthu_hd();
            //        this.tongthuchi();
            //    }
            //    else if (this.cobloaiphieu.SelectedIndex == 2)
            //    {
            //        if (this.cobnhanvien.Text == "")
            //        {
            //            this.TongtienBANHANG();
            //            this.LOADDULIEUTHUCHI();
            //            this.TongtienChi();
            //            this.Tongtienthu();
            //            this.tongthuchi();
            //        }
            //        else
            //        {
            //            this.TongtienBANHANG_nhanvien();
            //            this.LOADDULIEUTHUCHI_nhanvien();
            //            this.TongtienChinhanvien();
            //            this.Tongtienthu_nhanvien();
            //            this.tongthuchi();
            //        }
            //    }
            //    else if (this.cobloaiphieu.SelectedIndex == 1)
            //    {
            //        if (this.cobnhanvien.Text == "")
            //        {
            //            this.LOADDULIEU();
            //            this.TongtienChi();
            //            this.tongthuchi();
            //        }
            //        else
            //        {
            //            this.LOADDULIEU_nhanvien();
            //            this.TongtienChi();
            //            this.tongthuchi();
            //        }
            //    }
            //    else if (this.cobnhanvien.Text == "")
            //    {
            //        this.TongtienBANHANG();
            //        this.LOADDULIEU();
            //        this.Tongtienthu();
            //        this.tongthuchi();
            //    }
            //    else
            //    {
            //        this.TongtienBANHANG_nhanvien();
            //        this.LOADDULIEU_nhanvien();
            //        this.Tongtienthu();
            //        this.tongthuchi();
            //    }
            //    this.dgvthuchi.AutoResizeRows();
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000261 RID: 609 RVA: 0x0001B637 File Offset: 0x00019837
        private void dgvthuchi_Enter(object sender, EventArgs e)
        {
        }

        // Token: 0x06000262 RID: 610 RVA: 0x0001BD33 File Offset: 0x00019F33
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dis_en(false);
        }

        // Token: 0x06000263 RID: 611 RVA: 0x0008C8F4 File Offset: 0x0008AAF4
        private void txttienbanhang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttienbanhang.Text == "")
                {
                    this.txttienbanhang.Text = "0";
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000264 RID: 612 RVA: 0x0008C954 File Offset: 0x0008AB54
        private void txttongthu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttongthu.Text == "")
                {
                    this.txttongthu.Text = "0";
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000265 RID: 613 RVA: 0x0008C9B4 File Offset: 0x0008ABB4
        private void txttongchi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txttongchi.Text == "")
                {
                    this.txttongchi.Text = "0";
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000266 RID: 614 RVA: 0x0008CA14 File Offset: 0x0008AC14
        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal num = decimal.Parse(this.txtsotien.Text);
                this.txtsotien.Text = num.ToString("#,##0");
                this.txtsotien.SelectionStart = this.txtsotien.Text.Length;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        // Token: 0x06000267 RID: 615 RVA: 0x0008CA88 File Offset: 0x0008AC88
        private void btluuin_Click(object sender, EventArgs e)
        {
            //if (this.txtsotien.Text != "0" && this.txtlydo.Text != "")
            //{
            //    if (this.txtmathuchi.Text == "")
            //    {
            //        this.NHAPLIEU(this.tcObj);
            //        this.inlai = 0;
            //        this.ptin_Click(null, null);
            //    }
            //    else
            //    {
            //        this.SUANHAPLIEU(this.tcObj);
            //    }
            //    this.Dis_en(true);
            //    this.txttenkhachhang.Text = "";
            //    this.txtmakhachhang.Text = "";
            //    this.txtmathuchi.Text = "";
            //    this.txtghichu.Text = "";
            //    this.txtsotien.Text = "0";
            //    this.txtlydo.Text = "";
            //    this.txtngaythu.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //    this.LOADDULIEUTHUCHI();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa nhập số tiền hoặc nội dung");
            //}
        }

        // Token: 0x06000268 RID: 616 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
        private void loadcauhinh()
        {
            //string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.chObj.Tencongty = sqlDataReader.GetString(1);
            //    this.chObj.Diachi = sqlDataReader.GetString(2);
            //    this.chObj.Dienthoai = sqlDataReader.GetString(3);
            //    this.chObj.Kyten = sqlDataReader.GetString(4);
            //    this.chObj.Canhle = sqlDataReader.GetString(5);
            //    this.chObj.Sotrangin = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
            //    this.chObj.Ghichu = sqlDataReader.GetString(7);
            //    this.chObj.Cochuten = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
            //    this.chObj.Cochudienthoai = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
            //    this.chObj.Cochukyten = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
            //    this.chObj.Cochudiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
            //    this.chObj.Letrai = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
            //    this.chObj.Mayin = sqlDataReader.GetString(12);
            //    this.chObj.Tenmayin = sqlDataReader.GetString(14);
            //    this.chObj.Hoadon = sqlDataReader.GetString(15);
            //    this.chObj.Tieude1 = sqlDataReader.GetString(16);
            //    this.chObj.Tieude2 = sqlDataReader.GetString(17);
            //    this.chObj.Tieude3 = sqlDataReader.GetString(18);
            //    this.font_name = Convert.ToString(sqlDataReader.GetValue(73));
            //    this.chObj.Diachi1 = Convert.ToString(sqlDataReader.GetValue(20));
            //    this.chObj.Diachi2 = Convert.ToString(sqlDataReader.GetValue(21));
            //    this.inlogo = Convert.ToString(sqlDataReader.GetValue(79));
            //    try
            //    {
            //        this.mydata = (byte[])sqlDataReader.GetValue(19);
            //        MemoryStream stream = new MemoryStream(this.mydata);
            //        this.pt_Image.Image = Image.FromStream(stream);
            //    }
            //    catch
            //    {
            //    }
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000269 RID: 617 RVA: 0x0001BD3E File Offset: 0x00019F3E
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Dis_en(true);
        }

        // Token: 0x0600026A RID: 618 RVA: 0x0008CE74 File Offset: 0x0008B074
        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        int num = 5;
        //        int letrai = this.chObj.Letrai;
        //        StringFormat stringFormat = new StringFormat();
        //        stringFormat.Alignment = StringAlignment.Center;
        //        StringFormat stringFormat2 = new StringFormat();
        //        stringFormat2.Alignment = StringAlignment.Far;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 50));
        //        e.Graphics.DrawString("Mẫu số 01-TT", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(610 + letrai, num), stringFormat);
        //        e.Graphics.DrawString("(Ban hành theo QĐ số: 15/2016/QĐ-BTC", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(610 + letrai, num + 15), stringFormat);
        //        e.Graphics.DrawString("Ngày 20/03/2006 của bộ trưởng BTC", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(610 + letrai, num + 30), stringFormat);
        //        e.Graphics.DrawString("PHIẾU THU", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(350 + letrai, 70), stringFormat);
        //        e.Graphics.DrawString("Số: " + this.k, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(450 + letrai, 80), stringFormat);
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(350 + letrai, 100), stringFormat);
        //        e.Graphics.DrawString("Họ tên người nộp tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 130));
        //        e.Graphics.DrawString("Địa chỉ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 155));
        //        e.Graphics.DrawString("Lý do nộp:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 180));
        //        e.Graphics.DrawString("Số Tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 205));
        //        e.Graphics.DrawString("(viết bằng chữ)", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + letrai, 205));
        //        e.Graphics.DrawString("Kèm theo: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 255));
        //        e.Graphics.DrawString("chứng từ gốc", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, 255), stringFormat2);
        //        e.Graphics.DrawString(this.txtchungtu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(100 + letrai, 253));
        //        e.Graphics.DrawString("..................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(154 + letrai, 138));
        //        e.Graphics.DrawString(".........................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 163));
        //        e.Graphics.DrawString("...................................... ..................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 188));
        //        e.Graphics.DrawString("..................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 213));
        //        e.Graphics.DrawString("..................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(420 + letrai, 213));
        //        e.Graphics.DrawString(".......................................................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 238));
        //        e.Graphics.DrawString("..........................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 261));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 128));
        //        e.Graphics.DrawString(this.txtghichu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 153));
        //        e.Graphics.DrawString(this.txtlydo.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 178));
        //        e.Graphics.DrawString(Convert.ToDecimal(this.txtsotien.Text).ToString("#,##0") + "   VNĐ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(130 + letrai, 203));
        //        e.Graphics.DrawString(frmThuChi.So_chu(Convert.ToDouble(this.txtsotien.Text)), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(90 + letrai, 230));
        //        int num2 = 288;
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, num2), stringFormat2);
        //        e.Graphics.DrawString("Người nộp tiền                                  Thủ quỹ                                   Người lập phiếu", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(380 + letrai, num2 + 25), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(115 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(375 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(640 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("Đã nhận đủ số tiền (viết bằng chữ):", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num2 + 172));
        //        e.Graphics.DrawString("..........................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, num2 + 180), stringFormat2);
        //        e.Graphics.DrawString(this.chObj.Ghichu, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num2 + 200));
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = ex.Message;
        //    }
        //}

        // Token: 0x0600026B RID: 619 RVA: 0x0008D894 File Offset: 0x0008BA94
        //private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        int num = 5;
        //        int letrai = this.chObj.Letrai;
        //        StringFormat stringFormat = new StringFormat();
        //        stringFormat.Alignment = StringAlignment.Center;
        //        StringFormat stringFormat2 = new StringFormat();
        //        stringFormat2.Alignment = StringAlignment.Far;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, num + 50));
        //        e.Graphics.DrawString("Mẫu số 01-TT", new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(610 + letrai, num), stringFormat);
        //        e.Graphics.DrawString("(Ban hành theo QĐ số: 15/2016/QĐ-BTC", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(610 + letrai, num + 15), stringFormat);
        //        e.Graphics.DrawString("Ngày 20/03/2006 của bộ trưởng BTC", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(610 + letrai, num + 30), stringFormat);
        //        e.Graphics.DrawString("PHIẾU CHI", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(350 + letrai, 70), stringFormat);
        //        e.Graphics.DrawString("Số: " + this.k, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(450 + letrai, 80), stringFormat);
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(350 + letrai, 100), stringFormat);
        //        e.Graphics.DrawString("Họ tên người nhận tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 130));
        //        e.Graphics.DrawString("Địa chỉ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 155));
        //        e.Graphics.DrawString("Lý do chi:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 180));
        //        e.Graphics.DrawString("Số Tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 205));
        //        e.Graphics.DrawString("(viết bằng chữ)", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + letrai, 205));
        //        e.Graphics.DrawString("Kèm theo: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 255));
        //        e.Graphics.DrawString("chứng từ gốc", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, 255), stringFormat2);
        //        e.Graphics.DrawString("..................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(154 + letrai, 138));
        //        e.Graphics.DrawString(".........................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 163));
        //        e.Graphics.DrawString("...................................... ..................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 188));
        //        e.Graphics.DrawString("..................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 213));
        //        e.Graphics.DrawString("..................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(420 + letrai, 213));
        //        e.Graphics.DrawString(".......................................................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(5 + letrai, 238));
        //        e.Graphics.DrawString(".............................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + letrai, 261));
        //        e.Graphics.DrawString(this.txtchungtu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(100 + letrai, 253));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 128));
        //        e.Graphics.DrawString(this.txtghichu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 153));
        //        e.Graphics.DrawString(this.txtlydo.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + letrai, 178));
        //        e.Graphics.DrawString(Convert.ToDecimal(this.txtsotien.Text).ToString("#,##0") + "   VNĐ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(130 + letrai, 203));
        //        e.Graphics.DrawString(frmThuChi.So_chu(Convert.ToDouble(this.txtsotien.Text)), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(90 + letrai, 230));
        //        int num2 = 288;
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, num2), stringFormat2);
        //        e.Graphics.DrawString("Người nhận tiền                                  Thủ quỹ                                   Người lập phiếu", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(380 + letrai, num2 + 25), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(115 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(375 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(640 + letrai, num2 + 45), stringFormat);
        //        e.Graphics.DrawString("Đã nhận đủ số tiền (viết bằng chữ):", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num2 + 172));
        //        e.Graphics.DrawString(".....................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(720 + letrai, num2 + 180), stringFormat2);
        //        e.Graphics.DrawString(this.chObj.Ghichu, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + letrai, num2 + 200));
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = ex.Message;
        //    }
        //}

        // Token: 0x0600026C RID: 620 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button2_Click(object sender, EventArgs e)
        {
          //  base.Close();
        }

        // Token: 0x0600026D RID: 621
      //  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(int handle, out int processId);

        // Token: 0x0600026E RID: 622 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
        private void xuatexcel()
        {
            //DataTable dataTable = new DataTable();
            //Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\BAOCAOTHUCHI.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site1 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(frmThuChi)));
            //}
            //Worksheet worksheet = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site1.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //application.Visible = true;
            //worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //worksheet.Cells[2, 1] = this.chObj.Diachi;
            //worksheet.Cells[3, 1] = this.chObj.Dienthoai;
            //worksheet.Cells[5, 1] = "Từ " + this.dttungay.Text + " đến  " + this.dtdenngay.Text;
            //worksheet.Cells[8, 5] = this.txttiencu.Text;
            //worksheet.Cells[9, 5] = this.txttienbanhang.Text;
            //worksheet.Cells[10, 5] = this.txttongthu.Text;
            //string cmdText = string.Concat(new string[]
            //{
            //    "SELECT kh.tendonvi,tc.Lydo+tc.chungtu,tc.Ngay,tc.Sotien from tb_thuchi tc LEFT JOIN TB_KHACHHANG KH ON TC.MAKH=KH.MAKHACHHANG where tc.thuchi='THU' and convert(datetime,tc.ngay,103)>='",
            //    Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //    " 00:00' and convert(datetime,tc.ngay,103)<='",
            //    Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
            //    " 23:59'"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //int num = 10;
            //Range range2;
            //if (dataTable.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < dataTable.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 11, j + 2] = dataTable.Rows[i][j].ToString();
            //        }
            //        Range range = worksheet.get_Range("B" + num, "E" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    range2 = worksheet.get_Range("C" + 11, "C" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //}
            //sqlConnection.Close();
            //num++;
            //int num2 = num + 1;
            //worksheet.Cells[num, 5] = this.txttongchi.Text;
            //worksheet.Cells[num, 1] = "IV. Chi phí";
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site2 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site2.Target;
            //CallSite<> p__Site = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site2;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site3 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target(<> p__Site, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site3.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site3, worksheet.Cells[num, 1]), true);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site4 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target2 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site4.Target;
            //CallSite<> p__Site2 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site4;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site5 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target2(<> p__Site2, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site5.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site5, worksheet.Cells[num, 5]), true);
            //range2 = worksheet.get_Range("A" + num, "E" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //DataTable dataTable2 = new DataTable();
            //string cmdText2 = string.Concat(new string[]
            //{
            //    "SELECT kh.tendonvi,tc.Lydo+tc.chungtu,tc.Ngay,tc.tientrano from tb_thuchi tc LEFT JOIN TB_KHACHHANG KH ON TC.MAKH=KH.MAKHACHHANG where tc.thuchi='CHI' and convert(datetime,tc.ngay,103)>='",
            //    Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //    " 00:00' and convert(datetime,tc.ngay,103)<='",
            //    Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
            //    " 23:59'"
            //});
            //selectCommand = new SqlCommand(cmdText2, sqlConnection);
            //sqlConnection.Open();
            //sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable2);
            //if (dataTable2.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dataTable2.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataTable2.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + num2, j + 2] = dataTable2.Rows[i][j].ToString();
            //        }
            //        Range range = worksheet.get_Range("B" + num, "E" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //        num++;
            //    }
            //    range2 = worksheet.get_Range("C" + num2, "C" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //}
            //num++;
            //worksheet.Cells[num, 5] = this.txtnhaphang.Text;
            //worksheet.Cells[num, 1] = "V. Nhập hàng";
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site6 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target3 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site6.Target;
            //CallSite<> p__Site3 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site6;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site7 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target3(<> p__Site3, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site7.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site7, worksheet.Cells[num, 1]), true);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site8 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site8 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target4 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site8.Target;
            //CallSite<> p__Site4 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site8;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site9 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target4(<> p__Site4, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site9.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site9, worksheet.Cells[num, 5]), true);
            //range2 = worksheet.get_Range("A" + num, "E" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //num++;
            //worksheet.Cells[num, 5] = this.txttongthuchi.Text;
            //worksheet.Cells[num, 1] = "VI. TIỀN MẶT";
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitea == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitea = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target5 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitea.Target;
            //CallSite<> p__Sitea = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitea;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Siteb == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Siteb = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target5(<> p__Sitea, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Siteb.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Siteb, worksheet.Cells[num, 1]), true);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitec == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitec = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target6 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitec.Target;
            //CallSite<> p__Sitec = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitec;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sited == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sited = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target6(<> p__Sitec, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sited.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sited, worksheet.Cells[num, 5]), true);
            //range2 = worksheet.get_Range("A" + num, "E" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("A" + 9, "A" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //range2 = worksheet.get_Range("E" + 9, "E" + num);
            //range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //num++;
            //worksheet.Cells[num, 3] = string.Concat(new object[]
            //{
            //    "Ngày ",
            //    DateTime.Now.Day,
            //    " tháng ",
            //    DateTime.Now.Month,
            //    " năm ",
            //    DateTime.Now.Year
            //});
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitee == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitee = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target7 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitee.Target;
            //CallSite<> p__Sitee = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitee;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitef == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitef = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target7(<> p__Sitee, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitef.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Sitef, worksheet.Cells[num, 3]), true);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site10 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site10 = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, HorizontalAlignment, object> target8 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site10.Target;
            //CallSite<> p__Site5 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site10;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site11 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site11 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target8(<> p__Site5, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site11.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site11, worksheet.Cells[num, 3]), HorizontalAlignment.Center);
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site12 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site12 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //    }));
            //}
            //Func<CallSite, object, bool, object> target9 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site12.Target;
            //CallSite<> p__Site6 = frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site12;
            //if (frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site13 == null)
            //{
            //    frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site13 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(frmThuChi), new CSharpArgumentInfo[]
            //    {
            //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //    }));
            //}
            //target9(<> p__Site6, frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site13.Target(frmThuChi.< xuatexcel > o__SiteContainer0.<> p__Site13, worksheet.Cells[num + 1, 3]), true);
            //worksheet.Cells[num + 1, 3] = "NGƯỜI LẬP";
            //application.WindowState = XlWindowState.xlMaximized;
        }

        // Token: 0x0600026F RID: 623 RVA: 0x0008F288 File Offset: 0x0008D488
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.loadcauhinh();
                this.xuatexcel();
            }
            catch
            {
            }
        }

        // Token: 0x06000270 RID: 624 RVA: 0x0001BD49 File Offset: 0x00019F49
        private void GETMAKH(string Makh, string tenkh, string diachi, string sdt)
        {
            this.txtmakhachhang.Text = Makh;
            this.txttenkhachhang.Text = tenkh;
            this.txtghichu.Text = diachi;
        }

        // Token: 0x06000271 RID: 625 RVA: 0x0008F2C0 File Offset: 0x0008D4C0
        private void bttim_Click(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //Frmkhachhang.chon = "1";
            //frmkhachhang.MaKH = new Frmkhachhang.GetData(this.GETMAKH);
            //frmkhachhang.ShowDialog();
            //this.dgvtimkhachhang.Visible = false;
            //this.txtsotien.Focus();
        }

        // Token: 0x06000272 RID: 626 RVA: 0x0008F310 File Offset: 0x0008D510
        private void txtsotien_Leave(object sender, EventArgs e)
        {
            if (this.txtsotien.Text == "")
            {
                this.txtsotien.Text = "0";
            }
        }

        // Token: 0x06000273 RID: 627 RVA: 0x0008F34C File Offset: 0x0008D54C
        private void dgvthuchi_KeyDown(object sender, KeyEventArgs e)
        {
            //if (this.dgvthuchi.RowCount > 0)
            //{
            //    if (e.KeyCode == Keys.Delete)
            //    {
            //        DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            int rowIndex = this.dgvthuchi.CurrentCell.RowIndex;
            //            string str = this.dgvthuchi.Rows[rowIndex].Cells["mathuchi"].Value.ToString();
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = "DELETE Tb_THUCHI WHERE Mathuchi ='" + str + "'";
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            this.LOADDULIEUTHUCHI();
            //        }
            //    }
            //}
        }

        // Token: 0x06000274 RID: 628 RVA: 0x0008F438 File Offset: 0x0008D638
        private void txtsotien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtlydo.Focus();
            }
        }

        // Token: 0x06000275 RID: 629 RVA: 0x0008F464 File Offset: 0x0008D664
        private void ptin_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog();
            //PrintDocument printDocument = new PrintDocument();
            //printDialog.Document = printDocument;
            //DialogResult dialogResult = printDialog.ShowDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    this.loadcauhinh();
            //    if (this.cobthuchi.SelectedIndex == 0 || this.cobthuchi.SelectedIndex == 1 || this.cobthuchi.SelectedIndex == 4)
            //    {
            //        if (this.cobthuchi.SelectedIndex != 1)
            //        {
            //            printDocument.PrintPage += this.printDocument1_PrintPage;
            //            printDocument.Print();
            //        }
            //        else
            //        {
            //            if (!this.checkBox1.Checked)
            //            {
            //                printDocument.PrintPage += this.print_congno_PrintPage;
            //            }
            //            else
            //            {
            //                printDocument.PrintPage += this.K80_PrintPage;
            //            }
            //            printDocument.Print();
            //        }
            //    }
            //    else
            //    {
            //        this.printDocument2.Print();
            //        printDocument.Print();
            //    }
            //}
        }

        // Token: 0x06000276 RID: 630 RVA: 0x0008F560 File Offset: 0x0008D760
        private void dgvthuchi_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvthuchi.Rows.Count > 0)
            {
                this.inlai = 1;
                this.txtmakhachhang.Text = "";
                this.Bingding();
                this.txtsotien.Text = "0";
                string a = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["Loaiphieu"].Value.ToString();
                string a2 = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["chiphi"].Value.ToString();
                if (a == "THU" && a2 == "0")
                {
                    this.txtsotien.Text = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["SoTien"].Value.ToString();
                    this.cobthuchi.SelectedIndex = 1;
                }
                if (a == "THU" && a2 == "1")
                {
                    this.cobthuchi.SelectedIndex = 0;
                    this.txtsotien.Text = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["SoTien"].Value.ToString();
                }
                if (a == "CHI" && a2 == "0")
                {
                    this.txtsotien.Text = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["tienchi"].Value.ToString();
                    this.cobthuchi.SelectedIndex = 2;
                }
                if (a == "CHI" && a2 == "1")
                {
                    this.txtsotien.Text = this.dgvthuchi.Rows[this.dgvthuchi.CurrentCell.RowIndex].Cells["tienchi"].Value.ToString();
                    this.cobthuchi.SelectedIndex = 3;
                }
            }
            this.dgvtimkhachhang.Visible = false;
        }

        // Token: 0x06000277 RID: 631 RVA: 0x0008F818 File Offset: 0x0008DA18
        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {
            if (this.txttenkhachhang.Text != "")
            {
                this.loadmakh();
            }
            else
            {
                this.dgvtimkhachhang.Visible = false;
                this.txtmakhachhang.Text = "";
                this.txtghichu.Text = "";
                this.txtno.Text = "0";
            }
        }

        // Token: 0x06000278 RID: 632 RVA: 0x0008F890 File Offset: 0x0008DA90
        private void loadmakh()
        {
            //try
            //{
            //    if (this.txttenkhachhang.Enabled)
            //    {
            //        this.dgvtimkhachhang.Visible = true;
            //        DataTable dataTable = new DataTable();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "SELECT MAKHACHHANG,TENKHACHHANG,DIACHI FROM TB_KHACHHANG WHERE MAKHACHHANG LIKE '%",
            //            this.txttenkhachhang.Text,
            //            "%' OR TENDONVI LIKE N'%",
            //            this.txttenkhachhang.Text,
            //            "%' OR SDT LIKE '%",
            //            this.txttenkhachhang.Text,
            //            "%'"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvtimkhachhang.DataSource = dataTable;
            //        if (dataTable.Rows.Count > 0)
            //        {
            //            if (this.txttenkhachhang.Text == this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["tenkh"].Value.ToString())
            //            {
            //                this.dgvtimkhachhang.Visible = false;
            //            }
            //        }
            //        else
            //        {
            //            this.dgvtimkhachhang.Visible = false;
            //            this.txtmakhachhang.Text = "";
            //            this.txtghichu.Text = "";
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000279 RID: 633 RVA: 0x0008FA48 File Offset: 0x0008DC48
        private void dgvtim()
        {
            this.dgvtimkhachhang.AllowUserToAddRows = false;
            this.dgvtimkhachhang.AllowUserToDeleteRows = false;
            this.dgvtimkhachhang.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvtimkhachhang.BackgroundColor = Color.White;
            this.dgvtimkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkhachhang.ColumnHeadersVisible = false;
            this.dgvtimkhachhang.Columns.AddRange(new DataGridViewColumn[]
            {
                this.makhtimkiem,
                this.tenkh
            });
            this.dgvtimkhachhang.ReadOnly = true;
            this.dgvtimkhachhang.RowHeadersVisible = false;
            this.dgvtimkhachhang.Size = new Size(347, 298);
        }

        // Token: 0x0600027A RID: 634 RVA: 0x0008FB0C File Offset: 0x0008DD0C
        private void tudongloadkhachhangtheoma()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "select TENDONVI,MAKHACHHANG,DIACHI from tb_khachhang WHERE makhachhang=N'" + this.txtmakhachhang.Text.Trim() + "'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.txttenkhachhang.Text = sqlDataReader.GetString(0);
            //    this.txtmakhachhang.Text = sqlDataReader.GetString(1);
            //    this.txtghichu.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txtmakhachhang.Text = "";
            //    this.txtghichu.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x0600027B RID: 635 RVA: 0x0008FBF4 File Offset: 0x0008DDF4
        private void dgvtimkhachhang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvtimkhachhang.RowCount > 0)
            {
                this.txtmakhachhang.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["makhtimkiem"].Value.ToString();
                this.txttenkhachhang.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["tenkh"].Value.ToString();
                this.txtghichu.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["diachi"].Value.ToString();
                this.dgvtimkhachhang.Visible = false;
                this.txtsotien.Focus();
            }
        }

        // Token: 0x0600027C RID: 636 RVA: 0x0008FD04 File Offset: 0x0008DF04
        private void dgvtimkhachhang_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvtimkhachhang.Visible = false;
                this.txtmakhachhang.Focus();
            }
        }

        // Token: 0x0600027D RID: 637 RVA: 0x0008FD44 File Offset: 0x0008DF44
        private void dgvtimkhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.dgvtimkhachhang.RowCount > 0)
                {
                    this.txtmakhachhang.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["makhtimkiem"].Value.ToString();
                    this.txttenkhachhang.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["tenkh"].Value.ToString();
                    this.txtghichu.Text = this.dgvtimkhachhang.Rows[this.dgvtimkhachhang.CurrentRow.Index].Cells["diachi"].Value.ToString();
                    this.dgvtimkhachhang.Visible = false;
                    this.txtsotien.Focus();
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (this.dgvtimkhachhang.CurrentRow.Index == 0)
                {
                    this.txttenkhachhang.Focus();
                    this.txttenkhachhang.SelectionStart = this.txttenkhachhang.TextLength;
                }
            }
        }

        // Token: 0x0600027E RID: 638 RVA: 0x0008FEBC File Offset: 0x0008E0BC
        private void frmThuChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.dgvtimkhachhang.Visible = false;
            }
        }

        // Token: 0x0600027F RID: 639 RVA: 0x0008FEEC File Offset: 0x0008E0EC
        private void txttenkhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.dgvtimkhachhang.Focus();
            }
        }

        // Token: 0x06000280 RID: 640 RVA: 0x0008FF1C File Offset: 0x0008E11C
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
        }

        // Token: 0x06000281 RID: 641 RVA: 0x0008FF64 File Offset: 0x0008E164
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
        }

        // Token: 0x06000282 RID: 642 RVA: 0x0008FFAC File Offset: 0x0008E1AC
        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (this.textBox15.Text == "")
            {
                this.textBox15.Text = this.textBox15.Tag.ToString();
            }
        }

        // Token: 0x06000283 RID: 643 RVA: 0x0008FFF4 File Offset: 0x0008E1F4
        private void textBox15_Enter(object sender, EventArgs e)
        {
            if (this.textBox15.Text == this.textBox15.Tag.ToString())
            {
                this.textBox15.Text = "";
            }
        }

        // Token: 0x06000284 RID: 644 RVA: 0x0009003C File Offset: 0x0008E23C
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox15.Text != this.textBox15.Tag.ToString())
            {
                if (this.textBox15.Text != "")
                {
                    this.TIMKIEMTEN();
                }
            }
        }

        // Token: 0x06000285 RID: 645 RVA: 0x00090098 File Offset: 0x0008E298
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            {
                if (this.txttimkiem.Text != "")
                {
                    this.TIMKIEMMA();
                }
            }
        }

        // Token: 0x06000286 RID: 646 RVA: 0x000900F4 File Offset: 0x0008E2F4
        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            //if (this.txtmakhachhang.Text != "")
            //{
            //    try
            //    {
            //        if (this.cobthuchi.SelectedIndex == 3)
            //        {
            //            string text = this.txtmakhachhang.Text;
            //            this.txtconno.Text = "Phải trả:";
            //            string text2 = DateTime.Now.ToString("MM/dd/yyyy");
            //            string text3 = DateTime.Now.ToString("MM/dd/yyyy");
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "DELETE TB_CHITIETPHAITRA WHERE DAUKY!='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=ISNULL((SELECT SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI) AS TONGTIEN\r\nFROM TB_HANGHOANHAP HN, TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC='",
            //                text,
            //                "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //                text2,
            //                "'),0)  + ISNULL((SELECT SUM(HN.DONGIA*HN.SOLUONGQUYDOI) AS TONGTIEN FROM TB_HANGHOANHAP_NL HN WHERE HN.NCC='",
            //                text,
            //                "' AND MALOAI='1'AND CONVERT(DATETIME,NGAYNHAP,103)<'",
            //                text2,
            //                "'),0) -ISNULL(( SELECT SUM(TIENTRANO) FROM Tb_THUCHI WHERE MaKH='",
            //                text,
            //                "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //                text2,
            //                "'),0),TRA='0' WHERE DAUKY='TRUE' UPDATE TB_CHITIETPHAITRA SET NO=NO+ISNULL((select SUM(ISNULL(SOTIENTRA,0)) from TB_TONDAUKY where ma='tra' AND MAKH='",
            //                text,
            //                "'),0) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MAHOADON,NGAYNHAP,SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONGQUYDOI),'0','FALSE' FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE HH.MAHANGHOA=HN.MAHANGHOA AND HN.NCC='",
            //                text,
            //                "' AND MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //                text2,
            //                "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //                text3,
            //                "' GROUP BY MAHOADON,NGAYNHAP) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MAHOADON,NGAYNHAP,SUM(HN.DONGIA*HN.SOLUONGQUYDOI),'0','FALSE' FROM TB_HANGHOANHAP_NL HN WHERE HN.NCC='",
            //                text,
            //                "' AND MALOAI='1' AND CONVERT(DATETIME,NGAYNHAP,103)>='",
            //                text2,
            //                "' AND CONVERT(DATETIME,NGAYNHAP,103)<='",
            //                text3,
            //                "' GROUP BY MAHOADON,NGAYNHAP) INSERT INTO TB_CHITIETPHAITRA(CHUNGTU,NGAY,NO,TRA,DAUKY)( SELECT MATHUCHI,NGAY,'0',SUM(TIENTRANO),'FALSE' FROM Tb_THUCHI WHERE MaKH='",
            //                text,
            //                "' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //                text2,
            //                "' AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //                text3,
            //                "' GROUP BY MATHUCHI,NGAY) SELECT SUM(ISNULL(NO,0))-SUM(ISNULL(TRA,0)) FROM TB_CHITIETPHAITRA"
            //            });
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlConnection.Open();
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.Read())
            //            {
            //                this.txtno.Text = decimal.Parse(Convert.ToString(sqlDataReader.GetValue(0))).ToString("#,##0");
            //            }
            //            if (!sqlDataReader.HasRows)
            //            {
            //                this.txtno.Text = "0";
            //            }
            //            sqlConnection.Close();
            //        }
            //        else if (this.cobthuchi.SelectedIndex == 1)
            //        {
            //            this.txtconno.Text = "Phải thu:";
            //            this.txtno.Text = "0";
            //            this.loadcongno();
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //            sqlConnection.Open();
            //            string cmdText2 = string.Concat(new string[]
            //            {
            //                "INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(SELECT ngay,'','','', SUM(sotien+tientrano) as dathu FROM Tb_THUCHI where MaKH=N'",
            //                this.txtmakhachhang.Text.Trim(),
            //                "' AND THUCHI='THU' AND CHIPHI='0' AND CONVERT(DATETIME,NGAY,103)>='",
            //                Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //                "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //                Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //                "' group by ngay)"
            //            });
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //            sqlCommand2.ExecuteNonQuery();
            //            string cmdText = "SELECT SUM(TIENNO-DATHU) FROM TB_CONGNOPHAITHUTHEOKHACHHANG";
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.Read())
            //            {
            //                string s = Convert.ToString(sqlDataReader.GetValue(0));
            //                this.txtno.Text = (decimal.Parse(this.txtno.Text) + decimal.Parse(s)).ToString("#,##0");
            //            }
            //            if (!sqlDataReader.HasRows)
            //            {
            //                this.txtno.Text = "0";
            //            }
            //            sqlConnection.Close();
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
            //else
            //{
            //    this.txtno.Text = "0";
            //}
        }

        // Token: 0x06000287 RID: 647 RVA: 0x00090518 File Offset: 0x0008E718
        private void loadcongno()
        {
            //this.loadtranotrongky();
            //this.loadcongnodauky();
            //string cmdText = "select case when hinhthuc='2' then isnull(SUM(THANHTOAN-DUATRUOC),0) when hinhthuc='3' then isnull(SUM(THANHTOAN),0) else '0' end from tb_hoadonbanhang where MAKHACHHANG =N'" + this.txtmakhachhang.Text + "' and HUYHD ='false' group by hinhthuc";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //double num = 0.0;
            //while (sqlDataReader.Read())
            //{
            //    num += double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //this.txtno.Text = (num + this.tientondau - this.tiennodatra).ToString("#,##0");
            //sqlConnection.Close();
        }

        // Token: 0x06000288 RID: 648 RVA: 0x000905E4 File Offset: 0x0008E7E4
        private void loadcongnodauky()
        {
            //string cmdText = "select isnull(SUM(SOTIEN),0) from tb_TONDAUKY where MA='thu' and MAKH =N'" + this.txtmakhachhang.Text.Trim() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tientondau = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000289 RID: 649 RVA: 0x00090674 File Offset: 0x0008E874
        private void loadtranotrongky()
        {
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE FROM TB_CONGNOPHAITHUTHEOKHACHHANG DELETE FROM TB_DATHU DELETE FROM TB_CONGNO select isnull(SUM(SOTIEN),0)+ isnull(SUM(TIENTRANO),0) from Tb_THUCHI where MAKH =N'",
            //    this.txtmakhachhang.Text.Trim(),
            //    "' AND Thuchi='THU' AND CHIPHI='0' and CONVERT(DATETIME,NGAY,103)<'",
            //    Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //    "'"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tiennodatra = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x0600028A RID: 650 RVA: 0x0001BD73 File Offset: 0x00019F73
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.txtsotien.Text = this.txtno.Text;
        }

        // Token: 0x0600028B RID: 651 RVA: 0x00089160 File Offset: 0x00087360
        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x0600028C RID: 652 RVA: 0x0001BD8D File Offset: 0x00019F8D
        private void frmThuChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.txttenkhachhang.Text = "";
            this.txtmakhachhang.Text = "";
            frmThuChi.makhachhang = "";
            frmThuChi.tenkhachhang = "";
        }

        // Token: 0x0600028D RID: 653 RVA: 0x00090744 File Offset: 0x0008E944
        private void txtngaythu_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtngaythu.Text = Convert.ToDateTime(this.txtngaythu.Text).ToString("HH:mm dd/MM/yyyy");
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai định dạng ngày tháng năm", "HH:mm dd/MM/yyyy");
                this.txtngaythu.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                this.txtngaythu.Focus();
            }
        }

        // Token: 0x0600028E RID: 654 RVA: 0x0001BDC6 File Offset: 0x00019FC6
        private void txttiencu_Enter(object sender, EventArgs e)
        {
            this.txttiencu.BackColor = Color.Yellow;
        }

        // Token: 0x0600028F RID: 655 RVA: 0x0001BDDA File Offset: 0x00019FDA
        private void txttiencu_Leave(object sender, EventArgs e)
        {
            this.txttiencu.BackColor = Color.White;
        }

        // Token: 0x06000290 RID: 656 RVA: 0x000907D0 File Offset: 0x0008E9D0
        private void button4_Click(object sender, EventArgs e)
        {
            this.txttiencu.Focus();
            this.dttungay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txttiencu.ReadOnly = false;
            this.button4.SendToBack();
        }

        // Token: 0x06000291 RID: 657 RVA: 0x00090824 File Offset: 0x0008EA24
        private void button5_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn LƯU số tiền ngày  " + Convert.ToDateTime(this.dttungay.Text).AddDays(-1.0).ToString("dd/MM/yyyy") + "  không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = string.Concat(new object[]
            //    {
            //        "DELETE TB_TIENCU WHERE NGAY='",
            //        Convert.ToDateTime(this.dttungay.Text).AddDays(-1.0).ToString("dd/MM/yyyy"),
            //        "'  INSERT INTO TB_TIENCU (NGAY,SOTIEN) VALUES('",
            //        Convert.ToDateTime(this.dttungay.Text).AddDays(-1.0).ToString("dd/MM/yyyy"),
            //        "','",
            //        decimal.Parse(this.txttiencu.Text),
            //        "')"
            //    });
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //}
            //this.txttiencu.ReadOnly = true;
            //this.button5.SendToBack();
        }

        // Token: 0x06000292 RID: 658 RVA: 0x0009098C File Offset: 0x0008EB8C
        private void txttienmat_TextChanged(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txttienmat.Text);
            decimal d2 = decimal.Parse(this.txttongthuchi.Text);
            this.txtchenhech.Text = (d2 - d).ToString("#,##0");
            this.txttienmat.Text = d.ToString("#,##0");
            this.txttienmat.SelectionStart = this.txttienmat.TextLength;
            if (this.txtchenhech.Text == "0")
            {
                this.textBox20.Text = this.textBox20.Tag.ToString() + "  Khớp";
            }
            else
            {
                this.textBox20.Text = this.textBox20.Tag.ToString();
            }
        }

        // Token: 0x06000293 RID: 659 RVA: 0x00090A6C File Offset: 0x0008EC6C
        private void txtsotien_MouseClick(object sender, MouseEventArgs e)
        {
            //Frmbangso.tieude = "Số tiền";
            //Frmbangso frmbangso = new Frmbangso();
            //frmbangso.ShowDialog();
            //this.txtsotien.Text = Frmbangso.soluong;
        }

        // Token: 0x06000294 RID: 660 RVA: 0x00090AA4 File Offset: 0x0008ECA4
        private void dgvtimkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.CHON.Index)
                {
                    this.dgvtimkhachhang_MouseDoubleClick(null, null);
                }
            }
        }

        // Token: 0x06000295 RID: 661 RVA: 0x0001BDEE File Offset: 0x00019FEE
        private void button2_Click_2(object sender, EventArgs e)
        {
            this.txtsotien.Text = this.txtno.Text;
            this.txtlydo.Focus();
        }

        // Token: 0x06000296 RID: 662 RVA: 0x00090AE4 File Offset: 0x0008ECE4
        //private void print_congno_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        int num = 5;
        //        int num2 = this.chObj.Letrai + 125;
        //        StringFormat stringFormat = new StringFormat();
        //        stringFormat.Alignment = StringAlignment.Center;
        //        StringFormat stringFormat2 = new StringFormat();
        //        stringFormat2.Alignment = StringAlignment.Far;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(250 + num2, num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + num2, num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + num2, num + 48), stringFormat);
        //        e.Graphics.DrawString("PHIẾU THU TIỀN", new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(250 + num2, 70), stringFormat);
        //        e.Graphics.DrawString("Số: " + this.k, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(450 + num2, 80), stringFormat);
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + num2, 100), stringFormat);
        //        int num3 = 125;
        //        e.Graphics.DrawString("Khách hàng: " + this.txttenkhachhang.Text, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3));
        //        num3 += 30;
        //        e.Graphics.DrawString("Nợ cũ: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3));
        //        if (this.inlai == 0)
        //        {
        //            e.Graphics.DrawString(this.txtno.Text + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num3), stringFormat2);
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString((decimal.Parse(this.txtno.Text) + decimal.Parse(this.txtsotien.Text)).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num3), stringFormat2);
        //        }
        //        e.Graphics.DrawString(".........................................................................................................................................................................................", new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + 10));
        //        num3 += 30;
        //        e.Graphics.DrawString("Thanh toán: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3));
        //        e.Graphics.DrawString(this.txtsotien.Text + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num3), stringFormat2);
        //        e.Graphics.DrawString(".........................................................................................................................................................................................", new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + 10));
        //        num3 += 30;
        //        e.Graphics.DrawString("Còn nợ: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3));
        //        if (this.inlai == 0)
        //        {
        //            e.Graphics.DrawString((decimal.Parse(this.txtno.Text) - decimal.Parse(this.txtsotien.Text)).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num3), stringFormat2);
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString(decimal.Parse(this.txtno.Text).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num3), stringFormat2);
        //        }
        //        e.Graphics.DrawString(".........................................................................................................................................................................................", new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + 10));
        //        num3 += 30;
        //        e.Graphics.DrawString("Lý do nộp: " + this.txtlydo.Text, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3));
        //        e.Graphics.DrawString(".........................................................................................................................................................................................", new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + 10));
        //        num3 += 30;
        //        e.Graphics.DrawString("Người nộp tiền                                         Người lập phiếu", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(250 + num2, num3), stringFormat);
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = ex.Message;
        //    }
        //}

        // Token: 0x06000297 RID: 663 RVA: 0x000911A4 File Offset: 0x0008F3A4
        //private void K80_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        int num = 0;
        //        int num2 = 0;
        //        int num3 = int.Parse(this.chObj.Canhle);
        //        StringFormat stringFormat = new StringFormat();
        //        stringFormat.Alignment = StringAlignment.Center;
        //        StringFormat stringFormat2 = new StringFormat();
        //        stringFormat2.Alignment = StringAlignment.Far;
        //        int num4 = 0;
        //        if (this.inlogo == "True")
        //        {
        //            e.Graphics.DrawImage(this.pt_Image.Image, num + 5, num2, 277, 138);
        //            num2 += 145;
        //        }
        //        if (this.chObj.Tencongty.Length > 42)
        //        {
        //            using (Font font = new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(2 + num), (float)(num2 + num3), 275f, 50f);
        //                e.Graphics.DrawString(this.chObj.Tencongty, font, Brushes.Black, rectangleF, stringFormat);
        //            }
        //            num3 += 30;
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString(this.chObj.Tencongty, new Font(this.font_name, (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(139 + num, num3 + num2), stringFormat);
        //        }
        //        if (this.chObj.Diachi.Length > 39)
        //        {
        //            using (Font font = new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(2 + num), (float)(num2 + 25 + num3), 275f, 40f);
        //                e.Graphics.DrawString(this.chObj.Diachi, font, Brushes.Black, rectangleF, stringFormat);
        //            }
        //            using (Font font = new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(2 + num), (float)(num2 + 60 + num3), 275f, 40f);
        //                e.Graphics.DrawString(this.chObj.Dienthoai, font, Brushes.Black, rectangleF, stringFormat);
        //            }
        //            num4 = num3 + num2 + 120;
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(139 + num, num3 + num2 + 25), stringFormat);
        //            using (Font font = new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(2 + num), (float)(num2 + 45 + num3), 275f, 40f);
        //                e.Graphics.DrawString(this.chObj.Dienthoai, font, Brushes.Black, rectangleF, stringFormat);
        //            }
        //            num4 = num3 + num2 + 100;
        //        }
        //        if (this.chObj.Dienthoai.Length > 39)
        //        {
        //            num4 += 10;
        //        }
        //        if (this.chObj.Diachi1.Trim().Length > 0)
        //        {
        //            num4 += 16;
        //            decimal num5 = Math.Ceiling(Convert.ToDecimal(this.chObj.Diachi1.Trim().Length) / 42m);
        //            using (Font font = new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(2 + num), (float)(num4 - 50), 275f, (float)(int.Parse(num5.ToString()) * 15));
        //                e.Graphics.DrawString(this.chObj.Diachi1, font, Brushes.Black, rectangleF, stringFormat);
        //            }
        //            num4 = num4 + int.Parse(num5.ToString()) * 15 - 15;
        //        }
        //        num4 -= 20;
        //        e.Graphics.DrawString("PHIẾU THU TIỀN", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(139 + num, num4), stringFormat);
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            DateTime.Now.ToString("HH:mm"),
        //            " Ngày ",
        //            DateTime.Now.ToString("dd"),
        //            " tháng ",
        //            DateTime.Now.ToString("MM"),
        //            " năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(139 + num, num4 + 22), stringFormat);
        //        int num6 = num4 + 50;
        //        using (Font font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(2 + num), (float)num6, 275f, 60f);
        //            e.Graphics.DrawString("Khách hàng: " + this.txttenkhachhang.Text, font, Brushes.Black, rectangleF);
        //        }
        //        num6 += 50;
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num), (float)(num6 - 5), 277f, 30f);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        e.Graphics.DrawString("Nợ cũ: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num, num6));
        //        if (this.inlai == 0)
        //        {
        //            e.Graphics.DrawString(this.txtno.Text + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(277 + num, num6), stringFormat2);
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString((decimal.Parse(this.txtno.Text) + decimal.Parse(this.txtsotien.Text)).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(277 + num, num6), stringFormat2);
        //        }
        //        num6 += 30;
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num), (float)(num6 - 5), 277f, 30f);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        e.Graphics.DrawString("Thanh toán: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num, num6));
        //        e.Graphics.DrawString(this.txtsotien.Text + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(277 + num, num6), stringFormat2);
        //        num6 += 30;
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num), (float)(num6 - 5), 277f, 30f);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        e.Graphics.DrawString("Còn nợ: ", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num, num6));
        //        if (this.inlai == 0)
        //        {
        //            e.Graphics.DrawString((decimal.Parse(this.txtno.Text) - decimal.Parse(this.txtsotien.Text)).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(277 + num, num6), stringFormat2);
        //        }
        //        else
        //        {
        //            e.Graphics.DrawString(decimal.Parse(this.txtno.Text).ToString("#,##0") + " đồng", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(277 + num, num6), stringFormat2);
        //        }
        //        num6 += 30;
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num), (float)(num6 - 5), 277f, 60f);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (Font font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num), (float)num6, 275f, 60f);
        //            e.Graphics.DrawString("Lý do nộp: " + this.txtlydo.Text, font, Brushes.Black, rectangleF);
        //        }
        //        num6 += 60;
        //        e.Graphics.DrawString("Người nộp tiền        Người lập phiếu", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(139 + num, num6), stringFormat);
        //        num6 += 120;
        //        e.Graphics.DrawString("    ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(139 + num, num6), stringFormat);
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = ex.Message;
        //    }
        //}

        // Token: 0x06000299 RID: 665 RVA: 0x00091E04 File Offset: 0x00090004


        // Token: 0x04000287 RID: 647
        public static int sophieu = 1;

        // Token: 0x04000288 RID: 648
        public static string makhachhang = string.Empty;

        // Token: 0x04000289 RID: 649
        public static string tenkhachhang = string.Empty;

        // Token: 0x0400028A RID: 650
        private string tiennhaphang = "";

        // Token: 0x0400028B RID: 651
        private double tientondau;

        // Token: 0x0400028C RID: 652
        private double tiennodatra;

        // Token: 0x0400028D RID: 653
        private string matc;

        // Token: 0x0400028E RID: 654
        private double k;

        //// Token: 0x0400028F RID: 655
        //private CauhinhObj chObj = new CauhinhObj();

        //// Token: 0x04000290 RID: 656
        //private LogInCtr ndctr = new LogInCtr();

        //// Token: 0x04000291 RID: 657
        //private ThuchiObj tcObj = new ThuchiObj();

        //// Token: 0x04000292 RID: 658
        //private Thuchictr tcCtr = new Thuchictr();

        //// Token: 0x04000293 RID: 659
        //private KhachHangCtr khctr = new KhachHangCtr();

        // Token: 0x04000294 RID: 660
        private int inlai = 0;

        // Token: 0x04000295 RID: 661
        private string inlogo = "False";

        // Token: 0x04000296 RID: 662
        private byte[] mydata = new byte[0];

        // Token: 0x04000297 RID: 663
        private string font_name;
    }
}
