using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_themmuon : Form
    {
        public Frm_themmuon()
        {
            InitializeComponent();
        }
        private void mahoadontieptheo()
        {
            //try
            //{
            //    string selectCommandText = "select isnull(MAX(RIGHT(MADONHANG,5)),'0') from TB_DONHANGCONGNO_MUON where CONVERT(DATETIME,LEFT(NGAY,10),103)='" + DateTime.Now.ToString("MM/dd/yyyy") + "'";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    string text = "";
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        text = "00001";
            //    }
            //    else
            //    {
            //        double num = Convert.ToDouble(dataTable.Rows[0][0].ToString());
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
            //    this.txtma.Text = DateTime.Now.ToString("ddMMyyyy") + text;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A08 RID: 2568 RVA: 0x00193C98 File Offset: 0x00191E98
        private void loadncc()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //SqlCommand selectCommand = new SqlCommand("SELECT MAKHACHHANG, TENDONVI FROM TB_KHACHHANG WHERE NCC='MH' ORDER BY TENDONVI", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    this.comboBox1.DataSource = dataTable;
            //    this.comboBox1.DisplayMember = "TENDONVI";
            //    this.comboBox1.ValueMember = "MAKHACHHANG";
            //    this.comboBox1.SelectedIndex = -1;
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000A09 RID: 2569 RVA: 0x00193D48 File Offset: 0x00191F48
        private void Frm_themmuon_Load(object sender, EventArgs e)
        {
            try
            {
                if (Frm_themmuon.themmoi == 0)
                {
                    this.txtmuon.ReadOnly = false;
                    this.txtmuon.Focus();
                    this.loadncc();
                    this.mahoadontieptheo();
                }
                else
                {
                    BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
                    bindingList.Add(new KeyValuePair<string, string>("A", Frm_themmuon.ten));
                    this.comboBox1.Items.Clear();
                    this.comboBox1.DataSource = bindingList;
                    this.comboBox1.ValueMember = "Key";
                    this.comboBox1.DisplayMember = "Value";
                    this.txtmuon.Text = Frm_themmuon.nd;
                    this.txtma.Text = Frm_themmuon.maso;
                    this.txttra.ReadOnly = false;
                    this.txttra.Focus();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000A0A RID: 2570 RVA: 0x00193E48 File Offset: 0x00192048
        private void luu()
        {
            //if (this.comboBox1.Text == "")
            //{
            //    MessageBox.Show("BẠN CHƯA CHỌN NHÀ CUNG CẤP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.comboBox1.Focus();
            //}
            //else if (this.txtmuon.Text.Trim() == "")
            //{
            //    MessageBox.Show("BẠN PHẢI NHẬP NỘI DUNG MƯỢN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.txtmuon.Focus();
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    if (Frm_themmuon.themmoi == 0)
            //    {
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "INSERT INTO [DATASHOP].[dbo].[TB_DONHANGCONGNO_MUON]([MADONHANG],[MANCC],[TENNCC],[NGAY],[NHANVIEN],NOIDUNGMUON,[NGAYTRA],[NHANVIENTRA],NOIDUNGTRA)  VALUES\r\n              ('",
            //            this.txtma.Text,
            //            "','",
            //            this.comboBox1.SelectedValue.ToString(),
            //            "',N'",
            //            this.comboBox1.Text,
            //            "','",
            //            DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            //            "','",
            //            frmLogIn.MADANGNHAP,
            //            "',N'",
            //            this.txtmuon.Text,
            //            "','','','')"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        if (this.ptlogo.Image != null)
            //        {
            //            byte[] buffer;
            //            try
            //            {
            //                MemoryStream memoryStream = new MemoryStream();
            //                this.ptlogo.Image.Save(memoryStream, ImageFormat.Jpeg);
            //                buffer = memoryStream.GetBuffer();
            //                memoryStream.Close();
            //            }
            //            catch
            //            {
            //                MemoryStream memoryStream = new MemoryStream();
            //                this.ptlogo.Image = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
            //                Bitmap bitmap = new Bitmap(this.ptlogo.Image);
            //                bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //                buffer = memoryStream.GetBuffer();
            //                memoryStream.Close();
            //            }
            //            string cmdText2 = "UPDATE TB_DONHANGCONGNO_MUON SET HINH=@HINH WHERE MADONHANG='" + this.txtma.Text + "'";
            //            sqlConnection.Open();
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //            sqlCommand2.Parameters.AddWithValue("@mahang", this.txtma.Text);
            //            sqlCommand2.Parameters.AddWithValue("@hinh", buffer);
            //            sqlCommand2.ExecuteNonQuery();
            //            sqlConnection.Dispose();
            //            sqlConnection.Close();
            //        }
            //    }
            //    else if (this.txttra.Text.Trim() == "")
            //    {
            //        MessageBox.Show("BẠN PHẢI NHẬP NỘI DUNG TRẢ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txttra.Focus();
            //    }
            //    else
            //    {
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "UPDATE [TB_DONHANGCONGNO_MUON] SET [NGAYTRA]='",
            //            DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
            //            "',[NHANVIENTRA]='",
            //            frmLogIn.MADANGNHAP,
            //            "',NOIDUNGTRA=N'",
            //            this.txttra.Text,
            //            "' WHERE MADONHANG='",
            //            this.txtma.Text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        if (this.ptlogo.Image != null)
            //        {
            //            byte[] buffer;
            //            try
            //            {
            //                MemoryStream memoryStream = new MemoryStream();
            //                this.ptlogo.Image.Save(memoryStream, ImageFormat.Jpeg);
            //                buffer = memoryStream.GetBuffer();
            //                memoryStream.Close();
            //            }
            //            catch
            //            {
            //                MemoryStream memoryStream = new MemoryStream();
            //                this.ptlogo.Image = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
            //                Bitmap bitmap = new Bitmap(this.ptlogo.Image);
            //                bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //                buffer = memoryStream.GetBuffer();
            //                memoryStream.Close();
            //            }
            //            string cmdText2 = "UPDATE TB_DONHANGCONGNO_MUON SET HINHTRA=@HINHTRA WHERE MADONHANG='" + this.txtma.Text + "'";
            //            sqlConnection.Open();
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //            sqlCommand2.Parameters.AddWithValue("@mahang", this.txtma.Text);
            //            sqlCommand2.Parameters.AddWithValue("@HINHTRA", buffer);
            //            sqlCommand2.ExecuteNonQuery();
            //            sqlConnection.Dispose();
            //            sqlConnection.Close();
            //        }
            //    }
            //}
        }

        // Token: 0x06000A0B RID: 2571 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
        private void button1_Click(object sender, EventArgs e)
        {
            this.luu();
            base.Close();
        }

        // Token: 0x06000A0C RID: 2572 RVA: 0x00194320 File Offset: 0x00192520
        private void ptlogo_Click(object sender, EventArgs e)
        {
            if (this.txtma.Text != "")
            {
                try
                {
                    this.openFileDialog1.Filter = "Select Images |*.jpg||*.png";
                    if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.ptlogo.Load(this.openFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }
        public static string maso = "";

        // Token: 0x04000C2A RID: 3114
        public static string ten = "";

        // Token: 0x04000C2B RID: 3115
        public static string nd = "";

        // Token: 0x04000C2C RID: 3116
        public static int themmoi = 0;
    }
}
