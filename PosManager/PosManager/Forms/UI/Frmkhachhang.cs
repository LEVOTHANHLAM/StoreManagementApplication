using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmkhachhang : Form
    {
        public Frmkhachhang()
        {
            InitializeComponent();
        }
        // Token: 0x06000D40 RID: 3392 RVA: 0x001D5B7C File Offset: 0x001D3D7C
        private void tudongcapnhatmasothue()
        {
            //this.txtmasothue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtmasothue.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //string cmdText = "Select tendonvi from Tb_khachhang";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtmasothue.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000D41 RID: 3393 RVA: 0x001D5C18 File Offset: 0x001D3E18
        private void tudongcapnhattendonvi()
        {
            //this.txttendonvi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txttendonvi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //string cmdText = "Select tendonvi from Tb_khachhang";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txttendonvi.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000D42 RID: 3394 RVA: 0x001D5CB4 File Offset: 0x001D3EB4
        private void mahanghoa()
        {
            //string selectCommandText = "select isnull(MAX(MAKHACHHANG),'KH00000') from Tb_KHACHHANG where left(MAKHACHHANG,2)='KH' and LEN(MAKHACHHANG)='7'";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //{
            //    ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang
            //});
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //string text;
            //if (dataTable.Rows.Count <= 0)
            //{
            //    text = "KH00001";
            //}
            //else
            //{
            //    string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(0, 2));
            //    text = "KH";
            //    if (a == text)
            //    {
            //        double num = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2, 5));
            //        num += 1.0;
            //        if (num < 10.0)
            //        {
            //            text += "0000";
            //        }
            //        else if (num < 100.0)
            //        {
            //            text += "000";
            //        }
            //        else if (num < 1000.0)
            //        {
            //            text += "00";
            //        }
            //        else if (num < 10000.0)
            //        {
            //            text += "0";
            //        }
            //        text += num.ToString();
            //    }
            //    else
            //    {
            //        text = "KH00001";
            //    }
            //}
            //this.txtmasothue.Text = text;
        }

        // Token: 0x06000D43 RID: 3395 RVA: 0x0009B888 File Offset: 0x00099A88
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

        // Token: 0x06000D44 RID: 3396 RVA: 0x001D5E70 File Offset: 0x001D4070
        //private void nhapthongtinkhachhang(KhachhangObj khObj)
        //{
        //    if (this.txttendonvi.Text == "")
        //    {
        //        this.txttendonvi.Text = this.txthoten.Text;
        //    }
        //    if (this.txtmasothue.Text.Trim() == "")
        //    {
        //        this.mahanghoa();
        //    }
        //    khObj.Makhachang = this.txtmasothue.Text;
        //    khObj.Tenkhachhang = this.txthoten.Text;
        //    khObj.Tendonvi = this.txthoten.Text;
        //    khObj.Gioitinh = this.cobgia.SelectedValue.ToString();
        //    khObj.Namsinh = this.dtnamsinh.Text;
        //    khObj.Diachi = this.txtdiachi.Text;
        //    khObj.Cmnd = this.txtcmnd.Text;
        //   // khObj.Ngaycap = TrangChu.ngaybanhang;
        //    khObj.Noicap = this.txtnoicap.Text;
        //    khObj.Sdt = this.txtdienthoai.Text;
        //    khObj.Email = this.txtemail.Text;
        //    khObj.Ghichu = this.txtghichu.Text;
        //    khObj.Sotaikhoan = this.txtsotaikhoan.Text;
        //    khObj.Ncc = this.comboBox1.SelectedValue.ToString();
        //    khObj.Chanh = this.NonUnicode(this.txthoten.Text);
        //}

        // Token: 0x06000D45 RID: 3397 RVA: 0x001D5FF8 File Offset: 0x001D41F8
        private void CLEAR()
        {
            try
            {
                this.dtnamsinh.Text = "";
                this.txtmasothue.Text = "";
                this.txthoten.Text = "";
                this.txttendonvi.Text = "";
                this.cobgia.SelectedIndex = 0;
                this.txtdiachi.Text = "";
                this.txtcmnd.Text = "";
                this.txtnoicap.Text = "";
                this.txtdienthoai.Text = "";
                this.txtemail.Text = "";
                this.txtghichu.Text = "";
                this.txtsotaikhoan.Text = "";
            }
            catch
            {
            }
        }

        // Token: 0x06000D46 RID: 3398 RVA: 0x001D60E8 File Offset: 0x001D42E8
        private void LOADTHONGTINKHACHHANG()
        {
            try
            {
                //string cmdText = "Select * from Tb_khachhang where makhachhang='" + this.txtmasothue.Text + "'";
                //SqlConnection sqlConnection = new SqlConnection();
                //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
                //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //sqlConnection.Open();
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //if (sqlDataReader.Read())
                //{
                //    this.txtmasothue.Text = sqlDataReader.GetString(0);
                //    this.txthoten.Text = Convert.ToString(sqlDataReader.GetValue(1));
                //    this.txttendonvi.Text = Convert.ToString(sqlDataReader.GetValue(2));
                //    this.dtnamsinh.Text = Convert.ToString(sqlDataReader.GetValue(4));
                //    this.txtdiachi.Text = Convert.ToString(sqlDataReader.GetValue(5));
                //    this.txtcmnd.Text = Convert.ToString(sqlDataReader.GetValue(6));
                //    this.dtngaycap.Text = Convert.ToString(sqlDataReader.GetValue(7));
                //    this.txtnoicap.Text = Convert.ToString(sqlDataReader.GetValue(8));
                //    this.txtdienthoai.Text = Convert.ToString(sqlDataReader.GetValue(9));
                //    this.txtemail.Text = Convert.ToString(sqlDataReader.GetValue(10));
                //    this.txtghichu.Text = Convert.ToString(sqlDataReader.GetValue(11));
                //    this.txtsotaikhoan.Text = Convert.ToString(sqlDataReader.GetValue(12));
                //    this.txtchanhxe.Text = Convert.ToString(sqlDataReader.GetValue(14));
                //    string a = Convert.ToString(sqlDataReader.GetValue(3));
                //    if (a == "MA1")
                //    {
                //        this.cobgia.SelectedIndex = 0;
                //    }
                //    if (a == "MA2")
                //    {
                //        this.cobgia.SelectedIndex = 1;
                //    }
                //    if (a == "MA3")
                //    {
                //        this.cobgia.SelectedIndex = 2;
                //    }
                //    if (a == "MA4")
                //    {
                //        this.cobgia.SelectedIndex = 3;
                //    }
                //    if (a == "MA5")
                //    {
                //        this.cobgia.SelectedIndex = 4;
                //    }
                //    if (a == "MA6")
                //    {
                //        this.cobgia.SelectedIndex = 5;
                //    }
                //    this.comboBox1.SelectedValue = Convert.ToString(sqlDataReader.GetValue(13));
                //}
                //sqlConnection.Close();
            }
            catch
            {
            }
        }

        // Token: 0x06000D47 RID: 3399 RVA: 0x001D63B4 File Offset: 0x001D45B4
        private void loadtimkhachhang()
        {
            try
            {
                DataTable dataSource = new DataTable();
            //    dataSource = this.xhdCtr.GET_KHACHHANG_TIM(this.txttimkiem.Text);
                this.dgvkhachhang.DataSource = dataSource;
                this.txtsd.Text = this.dgvkhachhang.RowCount.ToString();
            }
            catch
            {
            }
        }

        // Token: 0x06000D48 RID: 3400 RVA: 0x001D6428 File Offset: 0x001D4628
        private void loadkhachhang()
        {
            try
            {
                string text = "01";
                if (this.cobkh.Text != "System.Data.DataRowView")
                {
                    text = this.cobkh.SelectedValue.ToString();
                }
                if (text == "System.Data.DataRowView")
                {
                    text = "01";
                }
                DataTable dataSource = new DataTable();
             //   dataSource = this.xhdCtr.GET_KHACHHANG(text);
                this.dgvkhachhang.DataSource = dataSource;
                this.txtsd.Text = this.dgvkhachhang.RowCount.ToString();
            }
            catch
            {
            }
        }

        // Token: 0x06000D49 RID: 3401 RVA: 0x001D64DC File Offset: 0x001D46DC
        private void loadkhachhang_luu()
        {
            try
            {
                DataTable dataSource = new DataTable();
               // dataSource = this.xhdCtr.GET_KHACHHANG(this.txtmasothue.Text);
                this.dgvkhachhang.DataSource = dataSource;
                this.txtsd.Text = this.dgvkhachhang.RowCount.ToString();
            }
            catch
            {
            }
        }

        // Token: 0x06000D4A RID: 3402 RVA: 0x001D6550 File Offset: 0x001D4750
        private void btthem_Click(object sender, EventArgs e)
        {
            this.gbthongtin.Enabled = true;
            this.CLEAR();
            this.them = "1";
            this.btluu.Enabled = true;
            this.bthuy.Enabled = true;
            this.btthem.Enabled = false;
            this.btxoa.Enabled = false;
            this.button2.Enabled = false;
            this.txtmasothue.Focus();
        }

        // Token: 0x06000D4B RID: 3403 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void btboqua_Click(object sender, EventArgs e)
        {
         //   base.Close();
        }

        // Token: 0x06000D4C RID: 3404 RVA: 0x001D65CC File Offset: 0x001D47CC
        private void btluu_Click(object sender, EventArgs e)
        {
            //if (this.txthoten.Text != "" || this.txttendonvi.Text != "")
            //{
            //    this.nhapthongtinkhachhang(this.khObj);
            //    if (this.them == "1")
            //    {
            //        this.xhdCtr.ADD_KHACHHANG(this.khObj);
            //        this.them = "1";
            //        this.loadkhachhang_luu();
            //    }
            //    else
            //    {
            //        this.xhdCtr.UPD_KHACHHANG(this.khObj);
            //        this.them = "";
            //        this.btluu.Enabled = false;
            //        this.bthuy.Enabled = false;
            //        this.btthem.Enabled = true;
            //        this.btxoa.Enabled = true;
            //        this.button2.Enabled = true;
            //        this.loadkhachhang_luu();
            //    }
            //}
            //else
            //{
            //    this.txthoten.Focus();
            //}
        }

        // Token: 0x06000D4D RID: 3405 RVA: 0x001D66D8 File Offset: 0x001D48D8
        private void LOADGIA()
        {
            try
            {
                //SqlConnection sqlConnection = new SqlConnection();
                //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
                //string cmdText = "select * FROM TB_GIA";
                //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //sqlConnection.Open();
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
                //while (sqlDataReader.Read())
                //{
                //    bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(1)));
                //}
                //this.cobgia.Items.Clear();
                //this.cobgia.DataSource = bindingList;
                //this.cobgia.ValueMember = "Key";
                //this.cobgia.DisplayMember = "Value";
                //sqlConnection.Close();
            }
            catch
            {
            }
        }

        // Token: 0x06000D4E RID: 3406 RVA: 0x001D67B4 File Offset: 0x001D49B4
        private void Frmkhachhang_Load(object sender, EventArgs e)
        {
            this.dtngaycap.Text = "";
            this.dtnamsinh.Text = DateTime.Now.ToString("dd/MM/yyyy");
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            this.LOADGIA();
            this.LOAD1();
            this.LOAD();
            if (this.cobkh.Items.Count > 0)
            {
                if (Frmkhachhang.chon == "nk")
                {
                    this.cobkh.SelectedIndex = 1;
                    this.comboBox1.SelectedIndex = 1;
                }
                else
                {
                    this.cobkh.SelectedIndex = 0;
                }
            }
         //   this.xhdCtr.DELETE_KHACHHANG("");
            if (Frmkhachhang.chon == "1")
            {
                this.btthem_Click(null, null);
                this.txtmasothue.Text = Frmkhachhang.makhachhang;
                this.txtmasothue.Focus();
            }
            else
            {
                this.txttimkiem.Focus();
            }
        }

        // Token: 0x06000D4F RID: 3407 RVA: 0x001D68FC File Offset: 0x001D4AFC
        private void btxoa_Click(object sender, EventArgs e)
        {
            //if (this.dgvkhachhang.RowCount > 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
            //        this.txtmasothue.Text = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        string cmdText = "Select MAKHACHHANG from TB_HOADONBANHANG WHERE MAKHACHHANG='" + this.txtmasothue.Text + "' AND HUYHD='False'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.HasRows)
            //        {
            //            MessageBox.Show("Khách hàng này đã tồn tại trong HÓA ĐƠN BÁN HÀNG, Không thể xóa", "Thông báo");
            //            sqlConnection.Close();
            //        }
            //        else
            //        {
            //            sqlConnection.Close();
            //            sqlCommand = new SqlCommand("select * from TB_TONDAUKY  WHERE MAKH='" + this.txtmasothue.Text + "'", sqlConnection);
            //            sqlConnection.Open();
            //            sqlDataReader = sqlCommand.ExecuteReader();
            //            if (sqlDataReader.HasRows)
            //            {
            //                MessageBox.Show("Khách hàng này đã tồn tại trong CÔNG NỢ ĐẦU KỲ, Không thể xóa", "Thông báo");
            //                sqlConnection.Close();
            //            }
            //            else
            //            {
            //                sqlConnection.Close();
            //                sqlCommand = new SqlCommand("select * from TB_HANGHOANHAP  WHERE NCC='" + this.txtmasothue.Text + "'", sqlConnection);
            //                sqlConnection.Open();
            //                sqlDataReader = sqlCommand.ExecuteReader();
            //                if (sqlDataReader.HasRows)
            //                {
            //                    MessageBox.Show("Khách hàng này đã tồn tại trong NHẬP KHO HÀNG HÓA, Không thể xóa", "Thông báo");
            //                    sqlConnection.Close();
            //                }
            //                else
            //                {
            //                    this.xhdCtr.DELETE_KHACHHANG(this.txtmasothue.Text);
            //                    this.dgvkhachhang.Rows.RemoveAt(rowIndex);
            //                }
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000D50 RID: 3408 RVA: 0x001D6B0C File Offset: 0x001D4D0C
        private void txtmasothue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txthoten.Focus();
            }
        }

        // Token: 0x06000D51 RID: 3409 RVA: 0x001D6B3C File Offset: 0x001D4D3C
        private void dgvkhachhang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //if (Frmkhachhang.chon == "1")
                //{
                //    int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
                //    this.txtmasothue.Text = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    this.LOADTHONGTINKHACHHANG();
                //    this.MaKH(this.txtmasothue.Text, this.txttendonvi.Text, this.txtdiachi.Text, this.txtdienthoai.Text);
                //    base.Close();
                //}
                //else if (Frmkhachhang.chon == "kh")
                //{
                //    int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
                //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    base.Close();
                //}
                //else if (Frmkhachhang.chon == "nk")
                //{
                //    int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
                //    Frmnhapkhohanghoa.mancc = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    Frmsuancc.mancc = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
                //    base.Close();
                //}
                //else
                //{
                //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["MASOTHUE"].Value.ToString();
                //    Frmkhachhang.tenkhachhang = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["HOTEN"].Value.ToString();
                //    Frmkhachhang.sodienthoai = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["sdt"].Value.ToString();
                //    base.Close();
                //}
            }
            catch
            {
            }
        }

        // Token: 0x06000D52 RID: 3410 RVA: 0x001D6E38 File Offset: 0x001D5038
        private void txttendonvi_Leave(object sender, EventArgs e)
        {
            if (this.txttendonvi.Text == "" && this.txthoten.Text != "")
            {
                this.txttendonvi.Text = this.txthoten.Text;
            }
        }

        // Token: 0x06000D53 RID: 3411 RVA: 0x001D6E98 File Offset: 0x001D5098
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Frmkhachhang.chon == "1")
            //    {
            //        int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
            //        this.txtmasothue.Text = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            //        this.LOADTHONGTINKHACHHANG();
            //        this.MaKH(this.txtmasothue.Text, this.txttendonvi.Text, this.txtdiachi.Text, this.txtdienthoai.Text);
            //        base.Close();
            //    }
            //    else if (Frmkhachhang.chon == "nk")
            //    {
            //        int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
            //        Frmnhapkhohanghoa.mancc = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            //        Frmsuancc.mancc = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            //        Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            //        base.Close();
            //    }
            //    else if (!this.btthem.Enabled)
            //    {
            //        this.btluu_Click(null, null);
            //    }
            //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["MASOTHUE"].Value.ToString();
            //    Frmkhachhang.tenkhachhang = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["HOTEN"].Value.ToString();
            //    Frmkhachhang.sodienthoai = this.dgvkhachhang.Rows[this.dgvkhachhang.CurrentRow.Index].Cells["sdt"].Value.ToString();
            //    base.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D54 RID: 3412 RVA: 0x001D7118 File Offset: 0x001D5318
        private void txtmasothue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtmasothue.Text.Substring(0, 3) == "090" || (this.txtmasothue.Text.Substring(0, 3) == "091" | this.txtmasothue.Text.Substring(0, 3) == "092") || this.txtmasothue.Text.Substring(0, 3) == "093" || this.txtmasothue.Text.Substring(0, 3) == "094" || this.txtmasothue.Text.Substring(0, 3) == "096" || this.txtmasothue.Text.Substring(0, 3) == "097" || this.txtmasothue.Text.Substring(0, 3) == "098" || this.txtmasothue.Text.Substring(0, 2) == "03" || this.txtmasothue.Text.Substring(0, 2) == "02" || this.txtmasothue.Text.Substring(0, 2) == "08" || this.txtmasothue.Text.Substring(0, 2) == "07")
                {
                    this.txtdienthoai.Text = this.txtmasothue.Text;
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000D55 RID: 3413 RVA: 0x001D72E8 File Offset: 0x001D54E8
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            {
                if (this.txttimkiem.Text != "")
                {
                    this.loadtimkhachhang();
                }
            }
        }

        // Token: 0x06000D56 RID: 3414 RVA: 0x001D7344 File Offset: 0x001D5544
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
        }

        // Token: 0x06000D57 RID: 3415 RVA: 0x001D738C File Offset: 0x001D558C
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
        }

        // Token: 0x06000D58 RID: 3416 RVA: 0x001D73D4 File Offset: 0x001D55D4
        private void txtmasothue_Enter(object sender, EventArgs e)
        {
            if (this.txtmasothue.Text == "")
            {
                if (!this.btluu.Enabled)
                {
                    this.btthem_Click(null, null);
                }
            }
        }

        // Token: 0x06000D59 RID: 3417 RVA: 0x001D7418 File Offset: 0x001D5618
        private void cbncc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string dk;
                if (this.cobkh.SelectedIndex == 0)
                {
                    dk = "False";
                }
                else
                {
                    dk = "True";
                }
                DataTable dataSource = new DataTable();
               // dataSource = this.xhdCtr.GET_KHACHHANG(dk);
                this.dgvkhachhang.DataSource = dataSource;
                this.txtsd.Text = this.dgvkhachhang.RowCount.ToString();
            }
            catch
            {
            }
        }

        // Token: 0x06000D5A RID: 3418 RVA: 0x001D74AC File Offset: 0x001D56AC
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //if (Frmkhachhang.chon == "1")
                //{
                //    if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString() && this.txttimkiem.Text != "" && this.dgvkhachhang.RowCount == 1)
                //    {
                //        int index = this.dgvkhachhang.CurrentRow.Index;
                //        this.MaKH(this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["TDV"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["DC"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["SDT"].Value.ToString());
                //        base.Close();
                //    }
                //}
                //else if (Frmkhachhang.chon == "nk")
                //{
                //    if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString() && this.txttimkiem.Text != "")
                //    {
                //        int index = this.dgvkhachhang.CurrentCell.RowIndex;
                //        Frmnhapkhohanghoa.mancc = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
                //        Frmsuancc.mancc = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
                //        Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
                //        base.Close();
                //    }
                //}
            }
            if (e.KeyCode == Keys.Down)
            {
                this.dgvkhachhang.Focus();
            }
        }

        // Token: 0x06000D5B RID: 3419 RVA: 0x001D774C File Offset: 0x001D594C
        private void dgvkhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Frmkhachhang.chon == "1")
            //{
            //    if (e.KeyCode == Keys.Return)
            //    {
            //        int index = this.dgvkhachhang.CurrentRow.Index;
            //        this.MaKH(this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["TDV"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["DC"].Value.ToString(), this.dgvkhachhang.Rows[index].Cells["SDT"].Value.ToString());
            //        base.Close();
            //    }
            //}
            //else if (Frmkhachhang.chon == "nk")
            //{
            //    int index = this.dgvkhachhang.CurrentCell.RowIndex;
            //    Frmnhapkhohanghoa.mancc = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
            //    Frmkhachhang.makhachhang = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
            //    Frmsuancc.mancc = this.dgvkhachhang.Rows[index].Cells["MASOTHUE"].Value.ToString();
            //    base.Close();
            //}
        }

        // Token: 0x06000D5C RID: 3420 RVA: 0x001D791C File Offset: 0x001D5B1C
        private void cobkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.loadkhachhang();
            }
            catch
            {
            }
            this.txtmasothue.Focus();
        }

        // Token: 0x06000D5D RID: 3421 RVA: 0x001D7958 File Offset: 0x001D5B58
        private void button2_Click(object sender, EventArgs e)
        {
            this.gbthongtin.Enabled = true;
            this.btluu.Enabled = true;
            this.them = "2";
            int rowIndex = this.dgvkhachhang.CurrentCell.RowIndex;
            this.txtmasothue.Text = this.dgvkhachhang.Rows[rowIndex].Cells["MASOTHUE"].Value.ToString();
            this.LOADTHONGTINKHACHHANG();
        }

        // Token: 0x06000D5E RID: 3422 RVA: 0x001D79DC File Offset: 0x001D5BDC
        private void Frmkhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F && e.Control)
            //{
            //    this.txttimkiem.Focus();
            //}
            //else if (e.KeyCode == Keys.F1)
            //{
            //    this.btluu_Click(null, null);
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    base.Close();
            //}
        }

        // Token: 0x06000D5F RID: 3423 RVA: 0x0001E600 File Offset: 0x0001C800
        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.txttimkiem.Focus();
        }

        // Token: 0x06000D60 RID: 3424 RVA: 0x001D7A4C File Offset: 0x001D5C4C
        private void bthuy_Click(object sender, EventArgs e)
        {
            this.btluu.Enabled = false;
            this.bthuy.Enabled = false;
            this.btthem.Enabled = true;
            this.btxoa.Enabled = true;
            this.button2.Enabled = true;
            this.gbthongtin.Enabled = false;
        }

        // Token: 0x06000D61 RID: 3425 RVA: 0x001D7AA8 File Offset: 0x001D5CA8
        private void NHAPEXCEL()
        {
            //this.openFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //if (File.Exists(this.openFileDialog1.FileName))
            //{
            //    string connectionString = string.Empty;
            //    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.openFileDialog1.FileName + ";Extended Properties = Excel 12.0";
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
            //            try
            //            {
            //                this.khObj.Makhachang = dataTable.Rows[i]["MAKHACHHANG"].ToString();
            //                this.khObj.Gioitinh = dataTable.Rows[i]["MAGIA"].ToString();
            //                this.khObj.Namsinh = dataTable.Rows[i]["NAMSINH"].ToString();
            //                this.khObj.Diachi = dataTable.Rows[i]["DIACHI"].ToString();
            //                this.khObj.Cmnd = dataTable.Rows[i]["CMND"].ToString();
            //                this.khObj.Ngaycap = dataTable.Rows[i]["NGAYCAP"].ToString();
            //                this.khObj.Noicap = dataTable.Rows[i]["NOICAP"].ToString();
            //                this.khObj.Sdt = dataTable.Rows[i]["DIENTHOAI"].ToString();
            //                this.khObj.Email = dataTable.Rows[i]["EMAIL"].ToString();
            //                this.khObj.Ghichu = dataTable.Rows[i]["GHICHU"].ToString();
            //                this.khObj.Sotaikhoan = dataTable.Rows[i]["SOTAIKHOAN"].ToString();
            //                this.khObj.Ncc = dataTable.Rows[i]["NCC"].ToString();
            //                this.khObj.Chanh = dataTable.Rows[i]["CHANHXE"].ToString();
            //                this.khObj.Tenkhachhang = dataTable.Rows[i]["TENKHACHHANG"].ToString();
            //                this.khObj.Tendonvi = dataTable.Rows[i]["TENKHACHHANG"].ToString();
            //                this.xhdCtr.ADD_KHACHHANG(this.khObj);
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        MessageBox.Show("NHẬP THÀNH CÔNG");
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

        // Token: 0x06000D62 RID: 3426 RVA: 0x001D7E80 File Offset: 0x001D6080
        private void button3_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo =
                {
                    FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\KHACHHANG.xlsx"
                }
            }.Start();
            this.NHAPEXCEL();
            this.loadkhachhang();
        }

        // Token: 0x06000D63 RID: 3427 RVA: 0x001D7EC4 File Offset: 0x001D60C4
        private void button4_Click(object sender, EventArgs e)
        {
            //Frmnhomkhachhang frmnhomkhachhang = new Frmnhomkhachhang();
            //frmnhomkhachhang.ShowDialog();
            //this.LOAD();
            //this.LOAD1();
            //this.txtmasothue.Focus();
        }

        // Token: 0x06000D64 RID: 3428 RVA: 0x001D7EFC File Offset: 0x001D60FC
        private void LOAD1()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //    SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_NHOMKHACHHANG ORDER BY MANHOM", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.comboBox1.DataSource = dataTable;
            //    this.comboBox1.DisplayMember = "TENNHOM";
            //    this.comboBox1.ValueMember = "MANHOM";
            //    this.comboBox1.SelectedIndex = Frmnhomkhachhang.index;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D65 RID: 3429 RVA: 0x001D7FA8 File Offset: 0x001D61A8
        private void LOAD()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //    SqlCommand selectCommand = new SqlCommand("SELECT * FROM TB_NHOMKHACHHANG ORDER BY MANHOM", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.cobkh.DataSource = dataTable;
            //    this.cobkh.DisplayMember = "TENNHOM";
            //    this.cobkh.ValueMember = "MANHOM";
            //    this.cobkh.SelectedIndex = 0;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000D66 RID: 3430 RVA: 0x001D8050 File Offset: 0x001D6250
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
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("CẬP NHẬT THÊM VÀO BẢNG TB_CAUHINH", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000D67 RID: 3431 RVA: 0x001D8120 File Offset: 0x001D6320
        private void button5_Click(object sender, EventArgs e)
        {
            //if (this.dgvkhachhang.RowCount > 0)
            //{
            //    this.loadcauhinh();
            //    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //    Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\DANHSACHKHACHHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //    if (Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site1 == null)
            //    {
            //        Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmkhachhang)));
            //    }
            //    Worksheet worksheet = Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site1.Target(Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
            //    application.Visible = true;
            //    worksheet.Cells[1, 1] = this.chObj.Tencongty;
            //    worksheet.Cells[2, 1] = this.chObj.Diachi;
            //    worksheet.Cells[3, 1] = this.chObj.Dienthoai;
            //    int num = 5;
            //    for (int i = 0; i < this.dgvkhachhang.Rows.Count; i++)
            //    {
            //        num++;
            //        for (int j = 0; j < this.dgvkhachhang.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 6, j + 1] = this.dgvkhachhang.Rows[i].Cells[j].Value;
            //        }
            //        Range range = worksheet.get_Range("A" + num, "N" + num);
            //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    }
            //    Range range2 = worksheet.get_Range("B" + 6, "B" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("D" + 6, "D" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("F" + 6, "F" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    range2 = worksheet.get_Range("K" + 6, "K" + num);
            //    range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
            //    worksheet.Cells[num + 1, 7] = string.Concat(new object[]
            //    {
            //        "Ngày ",
            //        DateTime.Now.Day,
            //        " tháng ",
            //        DateTime.Now.Month,
            //        " năm ",
            //        DateTime.Now.Year
            //    });
            //    if (Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site2 == null)
            //    {
            //        Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmkhachhang), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
            //        }));
            //    }
            //    Func<CallSite, object, bool, object> target = Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site2.Target;
            //    CallSite<> p__Site = Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site2;
            //    if (Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site3 == null)
            //    {
            //        Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmkhachhang), new CSharpArgumentInfo[]
            //        {
            //            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
            //        }));
            //    }
            //    target(<> p__Site, Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site3.Target(Frmkhachhang.< button5_Click > o__SiteContainer0.<> p__Site3, worksheet.Cells[num + 2, 7]), true);
            //    worksheet.Cells[num + 2, 7] = "NGƯỜI LẬP";
            //}
        }

        // Token: 0x06000D68 RID: 3432 RVA: 0x0001E60F File Offset: 0x0001C80F
        private void dtnamsinh_Enter(object sender, EventArgs e)
        {
            this.dtnamsinh.SelectionStart = 0;
        }

        // Token: 0x06000D69 RID: 3433 RVA: 0x001D8600 File Offset: 0x001D6800
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvkhachhang.RowCount > 0)
            //{
            //    this.txtghichu.Text = "";
            //    if (this.checkBox1.Checked)
            //    {
            //        this.txtghichu.Text = "False";
            //    }
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "update TB_KHACHHANG set GHICHU ='",
            //        this.txtghichu.Text,
            //        "'  WHERE MAKHACHHANG='",
            //        this.dgvkhachhang.CurrentRow.Cells["MASOTHUE"].Value.ToString(),
            //        "'"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.dgvkhachhang.CurrentRow.Cells["GHICHU"].Value = this.txtghichu.Text;
            //}
        }

        // Token: 0x06000D6A RID: 3434 RVA: 0x001D8724 File Offset: 0x001D6924
        private void dgvkhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvkhachhang.RowCount > 0)
            {
                if (this.dgvkhachhang.CurrentRow.Cells["GHICHU"].Value.ToString() == "False")
                {
                    this.checkBox1.Checked = true;
                }
                else
                {
                    this.checkBox1.Checked = false;
                }
            }
        }

        // Token: 0x06000D6B RID: 3435 RVA: 0x001D879C File Offset: 0x001D699C
        private void dtnamsinh_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(this.dtnamsinh.Text);
            }
            catch
            {
                MessageBox.Show("NĂM SINH BẠN NHẬP KHÔNG ĐÚNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.dtnamsinh.Focus();
                this.dtnamsinh.SelectionStart = 0;
            }
        }

        // Token: 0x04000FA9 RID: 4009
        public static string chon = string.Empty;

        // Token: 0x04000FAA RID: 4010
        public static string makhachhang = string.Empty;

        // Token: 0x04000FAB RID: 4011
        public static string sodienthoai = string.Empty;

        // Token: 0x04000FAC RID: 4012
        public static string tenkhachhang = string.Empty;

       // // Token: 0x04000FAD RID: 4013
       // private KhachhangObj khObj = new KhachhangObj();

        // Token: 0x04000FAE RID: 4014
       // private XuathoadonCtr xhdCtr = new XuathoadonCtr();

        // Token: 0x04000FAF RID: 4015
        private string them = "";

        // Token: 0x04000FB0 RID: 4016
        public Frmkhachhang.GetData MaKH;

        // Token: 0x04000FB1 RID: 4017
     //   private CauhinhObj chObj = new CauhinhObj();

        // Token: 0x020000B3 RID: 179
        // (Invoke) Token: 0x06000D6E RID: 3438
        public delegate void GetData(string maKH, string tenkh, string diachi, string sdt);
    }
}
