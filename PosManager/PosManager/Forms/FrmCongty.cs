using PosManager.Forms.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms
{
    public partial class FrmCongty : Form
    {
        public FrmCongty()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x0600080E RID: 2062 RVA: 0x0014C53C File Offset: 0x0014A73C
        public void LOADCAUHINH()
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
            //        this.txtmacty.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //        this.txttencongty.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //        this.txtdiachi.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //        this.txtdienthoai.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //        this.txtkyten.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //        this.txttop.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //        this.txttrangin.Text = Convert.ToString(sqlDataReader.GetValue(6));
            //        this.txtghichu.Text = Convert.ToString(sqlDataReader.GetValue(7));
            //        this.txtcochuten.Text = Convert.ToString(sqlDataReader.GetValue(8));
            //        this.txtcochudienthoai.Text = Convert.ToString(sqlDataReader.GetValue(9));
            //        this.txtcochukyten.Text = Convert.ToString(sqlDataReader.GetValue(10));
            //        this.txtcochudiachi.Text = Convert.ToString(sqlDataReader.GetValue(11));
            //        this.cobmayin.Text = Convert.ToString(sqlDataReader.GetValue(12));
            //        this.txtletrai.Text = Convert.ToString(sqlDataReader.GetValue(13));
            //        this.txttenmayin.Text = Convert.ToString(sqlDataReader.GetValue(14));
            //        this.txttenbill.Text = Convert.ToString(sqlDataReader.GetValue(15));
            //        this.txttieude1.Text = Convert.ToString(sqlDataReader.GetValue(16));
            //        this.txttieude2.Text = Convert.ToString(sqlDataReader.GetValue(17));
            //        this.txttieude3.Text = Convert.ToString(sqlDataReader.GetValue(18));
            //        this.txtdiachi1.Text = Convert.ToString(sqlDataReader.GetValue(20));
            //        this.txtdiachi2.Text = Convert.ToString(sqlDataReader.GetValue(21));
            //        string a = Convert.ToString(sqlDataReader.GetValue(22));
            //        string a2 = Convert.ToString(sqlDataReader.GetValue(23));
            //        string a3 = Convert.ToString(sqlDataReader.GetValue(24));
            //        if (a == "True")
            //        {
            //            this.cbquydoi.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbquydoi.Checked = false;
            //        }
            //        if (a2 == "True")
            //        {
            //            this.cbncc.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbncc.Checked = false;
            //        }
            //        if (a3 == "True")
            //        {
            //            this.cbnhaxe.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbnhaxe.Checked = false;
            //        }
            //        string a4 = Convert.ToString(sqlDataReader.GetValue(25));
            //        if (a4 == "True")
            //        {
            //            this.cbtonkho.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbtonkho.Checked = false;
            //        }
            //        this.txtcm.Text = Convert.ToString(sqlDataReader.GetValue(26));
            //        string a5 = Convert.ToString(sqlDataReader.GetValue(27));
            //        if (a5 == "True")
            //        {
            //            this.cbscan.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbscan.Checked = false;
            //        }
            //        this.txttile.Text = Convert.ToString(sqlDataReader.GetValue(28));
            //        string a6 = Convert.ToString(sqlDataReader.GetValue(29));
            //        if (a6 == "True")
            //        {
            //            this.checkBox1.Checked = true;
            //        }
            //        else
            //        {
            //            this.checkBox1.Checked = false;
            //        }
            //        this.textBox1.Text = Convert.ToString(sqlDataReader.GetValue(30));
            //        string a7 = Convert.ToString(sqlDataReader.GetValue(31));
            //        if (a7 == "0")
            //        {
            //            this.comboBox1.SelectedIndex = 0;
            //        }
            //        else if (a7 == "1")
            //        {
            //            this.comboBox1.SelectedIndex = 1;
            //        }
            //        else if (a7 == "2")
            //        {
            //            this.comboBox1.SelectedIndex = 2;
            //        }
            //        this.txttungay.Text = Convert.ToString(sqlDataReader.GetValue(32));
            //        this.txtdenngay.Text = Convert.ToString(sqlDataReader.GetValue(33));
            //        string a8 = Convert.ToString(sqlDataReader.GetValue(34));
            //        if (a8 == "True")
            //        {
            //            this.cbvat.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbvat.Checked = false;
            //        }
            //        this.txtpt.Text = Convert.ToString(sqlDataReader.GetValue(35));
            //        string a9 = Convert.ToString(sqlDataReader.GetValue(36));
            //        if (a9 == "True")
            //        {
            //            this.cbbanamkho.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbbanamkho.Checked = false;
            //        }
            //        this.txtmayin2.Text = Convert.ToString(sqlDataReader.GetValue(37));
            //        this.txtletrai2.Text = Convert.ToString(sqlDataReader.GetValue(38));
            //        this.txtlanin2.Text = Convert.ToString(sqlDataReader.GetValue(39));
            //        this.txttop2.Text = Convert.ToString(sqlDataReader.GetValue(40));
            //        this.cobmauin.Text = Convert.ToString(sqlDataReader.GetValue(41));
            //        this.txtbill2.Text = Convert.ToString(sqlDataReader.GetValue(42));
            //        this.txtkytu.Text = Convert.ToString(sqlDataReader.GetValue(43));
            //        this.txtkytu2.Text = Convert.ToString(sqlDataReader.GetValue(44));
            //        string a10 = Convert.ToString(sqlDataReader.GetValue(45));
            //        if (a10 == "True")
            //        {
            //            this.cbhdcu.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbhdcu.Checked = false;
            //        }
            //        string a11 = Convert.ToString(sqlDataReader.GetValue(46));
            //        if (a11 == "True")
            //        {
            //            this.cblamtron.Checked = true;
            //        }
            //        else
            //        {
            //            this.cblamtron.Checked = false;
            //        }
            //        string a12 = Convert.ToString(sqlDataReader.GetValue(48));
            //        if (a12 == "True")
            //        {
            //            this.cbinhoadon.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbinhoadon.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(47)) == "0")
            //        {
            //            this.checkBox8.Checked = false;
            //        }
            //        else
            //        {
            //            this.checkBox8.Checked = true;
            //        }
            //        this.txtt1.Text = Convert.ToString(sqlDataReader.GetValue(49));
            //        this.txtt2.Text = Convert.ToString(sqlDataReader.GetValue(50));
            //        if (this.txtt2.Text == "1")
            //        {
            //            this.checkBox7.Checked = true;
            //        }
            //        this.txtt21.Text = Convert.ToString(sqlDataReader.GetValue(51));
            //        this.txtt22.Text = Convert.ToString(sqlDataReader.GetValue(52));
            //        if (this.txtt22.Text == "1")
            //        {
            //            this.checkBox6.Checked = false;
            //        }
            //        else
            //        {
            //            this.checkBox6.Checked = true;
            //        }
            //        this.txttienmat.Text = Convert.ToString(sqlDataReader.GetValue(53));
            //        this.txtno.Text = Convert.ToString(sqlDataReader.GetValue(54));
            //        this.txttongcong.Text = Convert.ToString(sqlDataReader.GetValue(55));
            //        string a13 = Convert.ToString(sqlDataReader.GetValue(56));
            //        if (a13 == "True")
            //        {
            //            this.cbsl.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbsl.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(57)) == "True")
            //        {
            //            this.cbguimail.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbguimail.Checked = false;
            //        }
            //        this.txtmailgui.Text = Convert.ToString(sqlDataReader.GetValue(58));
            //        this.txtmatkhau.Text = Convert.ToString(sqlDataReader.GetValue(59));
            //        this.txtmailnhan.Text = Convert.ToString(sqlDataReader.GetValue(60));
            //        this.txtgio.Text = Convert.ToString(sqlDataReader.GetValue(61));
            //        if (Convert.ToString(sqlDataReader.GetValue(62)) == "True")
            //        {
            //            this.cbhanghoa.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbhanghoa.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(63)) == "True")
            //        {
            //            this.cbhoadon.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbhoadon.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(64)) == "True")
            //        {
            //            this.cbhangbanll.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbhangbanll.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(65)) == "True")
            //        {
            //            this.cbtuxa.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbtuxa.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(66)) == "True")
            //        {
            //            this.cbkhoidong.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbkhoidong.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(67)) == "True")
            //        {
            //            this.cbcongdon.Checked = true;
            //        }
            //        else
            //        {
            //            this.cbcongdon.Checked = false;
            //        }
            //        this.txtquangcao.Text = Convert.ToString(sqlDataReader.GetValue(68));
            //        this.txttiengiam.Text = Convert.ToString(sqlDataReader.GetValue(69));
            //        this.txtgiamphantram.Text = Convert.ToString(sqlDataReader.GetValue(70));
            //        this.txttiemgiam2.Text = Convert.ToString(sqlDataReader.GetValue(71));
            //        this.txtgiamphantram2.Text = Convert.ToString(sqlDataReader.GetValue(72));
            //        this.txtfont.Text = Convert.ToString(sqlDataReader.GetValue(73));
            //        if (Convert.ToString(sqlDataReader.GetValue(74)) == "True")
            //        {
            //            this.checkBox2.Checked = true;
            //        }
            //        else
            //        {
            //            this.checkBox2.Checked = false;
            //        }
            //        if (Convert.ToString(sqlDataReader.GetValue(75)) == "True")
            //        {
            //            this.checkBox3.Checked = true;
            //        }
            //        else
            //        {
            //            this.checkBox3.Checked = false;
            //        }
            //        this.textBox2.Text = Convert.ToString(sqlDataReader.GetValue(76));
            //        this.txt_sinhnhat.Text = Convert.ToString(sqlDataReader.GetValue(78));
            //        if (Convert.ToString(sqlDataReader.GetValue(79)) == "True")
            //        {
            //            this.checkBox4.Checked = true;
            //        }
            //        else
            //        {
            //            this.checkBox4.Checked = false;
            //        }
            //        this.txttenmayin1.Text = Convert.ToString(sqlDataReader.GetValue(80));
            //        this.txttenmayin2.Text = Convert.ToString(sqlDataReader.GetValue(81));
            //        if (Convert.ToString(sqlDataReader.GetValue(82)) == "True")
            //        {
            //            this.checkBox5.Checked = true;
            //        }
            //        this.txtsolecan.Text = Convert.ToString(sqlDataReader.GetValue(84));
            //        this.txtdaucan.Text = Convert.ToString(sqlDataReader.GetValue(83));
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600080F RID: 2063 RVA: 0x0014D230 File Offset: 0x0014B430
        //private void LUUCAUHINH(CauhinhObj chObj)
        //{
        //    decimal num = decimal.Parse(this.textBox1.Text);
        //    CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-us");
        //    chObj.Macongty = this.txtmacty.Text;
        //    chObj.Tencongty = this.txttencongty.Text;
        //    chObj.Diachi = this.txtdiachi.Text;
        //    chObj.Dienthoai = this.txtdienthoai.Text;
        //    chObj.Kyten = this.txtkyten.Text;
        //    chObj.Canhle = this.txttop.Text;
        //    chObj.Sotrangin = int.Parse(this.txttrangin.Text);
        //    chObj.Ghichu = this.txtghichu.Text;
        //    chObj.Cochuten = int.Parse(this.txtcochuten.Text);
        //    chObj.Cochudienthoai = int.Parse(this.txtcochudienthoai.Text);
        //    chObj.Cochukyten = int.Parse(this.txtcochukyten.Text);
        //    chObj.Cochudiachi = int.Parse(this.txtcochudiachi.Text);
        //    chObj.Letrai = int.Parse(this.txtletrai.Text);
        //    chObj.Mayin = this.cobmayin.Text;
        //    chObj.Tenmayin = this.txttenmayin.Text;
        //    chObj.Tieude1 = this.txttieude1.Text;
        //    chObj.Tieude2 = this.txttieude2.Text;
        //    chObj.Tieude3 = this.txttieude3.Text;
        //    chObj.Hoadon = this.txttenbill.Text;
        //    chObj.Diachi1 = this.txtdiachi1.Text;
        //    chObj.Diachi2 = this.txtdiachi2.Text;
        //    chObj.Cm = this.txtcm.Text;
        //    chObj.Tile = this.txttile.Text;
        //    chObj.Tiendiem = num.ToString("", cultureInfo.NumberFormat);
        //    chObj.Chondiem = this.comboBox1.SelectedIndex.ToString();
        //    chObj.Tungay = this.txttungay.Text;
        //    chObj.Denngay = this.txtdenngay.Text;
        //    chObj.Vat = this.txtpt.Text;
        //    chObj.MAYIN21 = this.txtmayin2.Text;
        //    chObj.MAUIN21 = this.cobmauin.Text;
        //    chObj.LETOP21 = this.txttop2.Text;
        //    chObj.LETRAI21 = this.txtletrai2.Text;
        //    chObj.LANIN21 = this.txtlanin2.Text;
        //    chObj.BILL21 = this.txtbill2.Text;
        //    chObj.Kytu = this.txtkytu.Text;
        //    chObj.Kytu2 = this.txtkytu2.Text;
        //    chObj.Goiy = "1";
        //    if (!this.checkBox8.Checked)
        //    {
        //        chObj.Goiy = "0";
        //    }
        //}

        // Token: 0x06000810 RID: 2064 RVA: 0x0014D538 File Offset: 0x0014B738
        private void FrmCongty_Load(object sender, EventArgs e)
        {
            //base.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.txtbd.Text = Settings.Default.ngayhethong;
            //if (Settings.Default.matkhau == "true")
            //{
            //    this.cbnho.Checked = true;
            //}
            //this.LOADCAUHINH();
            //try
            //{
            //    string selectCommandText = "select logo from tb_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    byte[] buffer = new byte[0];
            //    buffer = (byte[])dataTable.Rows[0][0];
            //    MemoryStream stream = new MemoryStream(buffer);
            //    this.ptlogo.Image = Image.FromStream(stream);
            //}
            //catch (Exception ex)
            //{
            //    string message = ex.Message;
            //}
        }

        // Token: 0x06000811 RID: 2065 RVA: 0x0014D674 File Offset: 0x0014B874
        private void btluu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Settings.Default.ngayhethong = this.txtbd.Text;
            //    Settings.Default.Save();
            //    this.LUUCAUHINH(this.chObj);
            //    if (this.canctr.UPDATE_CAUHINH(this.chObj))
            //    {
            //        string text = "False";
            //        if (this.cbtuxa.Checked)
            //        {
            //            text = "True";
            //        }
            //        string text2 = "False";
            //        if (this.cbhoadon.Checked)
            //        {
            //            text2 = "True";
            //        }
            //        string text3 = "False";
            //        if (this.cbhanghoa.Checked)
            //        {
            //            text3 = "True";
            //        }
            //        string text4 = "False";
            //        if (this.cbhangbanll.Checked)
            //        {
            //            text4 = "True";
            //        }
            //        string text5 = "False";
            //        if (this.cbguimail.Checked)
            //        {
            //            text5 = "True";
            //        }
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_CAUHINH SET HOADON1=N'",
            //            this.txttenmayin1.Text,
            //            "',HOADON2=N'",
            //            this.txttenmayin2.Text,
            //            "', T1='",
            //            this.txtt1.Text,
            //            "',T2='",
            //            this.txtt2.Text,
            //            "',T21='",
            //            this.txtt21.Text,
            //            "',T22='",
            //            this.txtt22.Text,
            //            "',TIENMAT=N'",
            //            this.txttienmat.Text,
            //            "',NO=N'",
            //            this.txtno.Text,
            //            "',TONGCONG=N'",
            //            this.txttongcong.Text,
            //            "',GUIMAI='",
            //            text5,
            //            "',MAILGUI='",
            //            this.txtmailgui.Text,
            //            "',MATKHAU='",
            //            this.txtmatkhau.Text,
            //            "',MAILNHAN='",
            //            this.txtmailnhan.Text,
            //            "',GIOGUI='",
            //            this.txtgio.Text,
            //            "',GUIHOADON='",
            //            text2,
            //            "',CHITIETHANGHOA='",
            //            text3,
            //            "',CHITIETLAILO='",
            //            text4,
            //            "' ,TUXA='",
            //            text,
            //            "',QUANGCAO=N'",
            //            this.txtquangcao.Text,
            //            "',TIENGIAM='",
            //            float.Parse(this.txttiengiam.Text),
            //            "',PHANTRAM='",
            //            this.txtgiamphantram.Text,
            //            "',TIENGIAM2='",
            //            float.Parse(this.txttiemgiam2.Text),
            //            "',PHANTRAM2='",
            //            this.txtgiamphantram2.Text,
            //            "',FONT='",
            //            this.txtfont.Text,
            //            "',COCHU_BILL='",
            //            this.textBox2.Text,
            //            "',BAOSINHNHAT='",
            //            this.txt_sinhnhat.Text,
            //            "',DAUCAN='",
            //            this.txtdaucan.Text,
            //            "',SOLECAN='",
            //            this.txtsolecan.Text,
            //            "' WHERE MACONGTY='",
            //            frmLogIn.macongty,
            //            "'"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        base.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("CẬP NHẬT KHÔNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("CẬP NHẬT KHÔNG THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //}
        }

        // Token: 0x06000812 RID: 2066 RVA: 0x0014DAE0 File Offset: 0x0014BCE0
        private void ptlogo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.openFileDialog1.Filter = "Select Images |*.jpg||*.png";
            //    if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        this.ptlogo.Load(this.openFileDialog1.FileName);
            //    }
            //    byte[] buffer;
            //    try
            //    {
            //        MemoryStream memoryStream = new MemoryStream();
            //        this.ptlogo.Image.Save(memoryStream, ImageFormat.Jpeg);
            //        buffer = memoryStream.GetBuffer();
            //        memoryStream.Close();
            //    }
            //    catch
            //    {
            //        MemoryStream memoryStream = new MemoryStream();
            //        this.ptlogo.Image = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
            //        Bitmap bitmap = new Bitmap(this.ptlogo.Image);
            //        bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //        buffer = memoryStream.GetBuffer();
            //        memoryStream.Close();
            //    }
            //    string cmdText = "update tb_CAUHINH set logo=@logo  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.Parameters.AddWithValue("@logo", buffer);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        // Token: 0x06000813 RID: 2067 RVA: 0x0014DC6C File Offset: 0x0014BE6C
        private void cbquydoi_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.cbquydoi.Checked)
            //{
            //    string cmdText = "update TB_CAUHINH set QUYDOI ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //}
            //else
            //{
            //    string cmdText = "update TB_CAUHINH set QUYDOI ='True'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //}
        }

        // Token: 0x06000814 RID: 2068 RVA: 0x0014DD20 File Offset: 0x0014BF20
        private void cbncc_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.cbncc.Checked)
            //{
            //    string cmdText = "update TB_CAUHINH set NCC ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    string cmdText = "update TB_CAUHINH set NCC ='True'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000815 RID: 2069 RVA: 0x0014DDE4 File Offset: 0x0014BFE4
        private void cbtonkho_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.cbtonkho.Checked)
            //{
            //    string cmdText = "update TB_CAUHINH set TONKHO ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    string cmdText = "update TB_CAUHINH set TONKHO ='True'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000816 RID: 2070 RVA: 0x0014DEA8 File Offset: 0x0014C0A8
        private void cbnhaxe_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.cbnhaxe.Checked)
            //{
            //    string cmdText = "update TB_CAUHINH set NHAXE ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    string cmdText = "update TB_CAUHINH set NHAXE ='True'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000817 RID: 2071 RVA: 0x0014DF6C File Offset: 0x0014C16C
        private void cbscan_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbscan.Checked)
            //{
            //    this.cbscan.Checked = true;
            //    string cmdText = "update TB_CAUHINH set SCAN ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbscan.Checked = false;
            //    string cmdText = "update TB_CAUHINH set SCAN ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000818 RID: 2072 RVA: 0x0014E048 File Offset: 0x0014C248
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox1.Checked)
            //{
            //    this.checkBox1.Checked = true;
            //    string cmdText = "update TB_CAUHINH set ANDAIRONG ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
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
            //    string cmdText = "update TB_CAUHINH set ANDAIRONG ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000819 RID: 2073 RVA: 0x0014E124 File Offset: 0x0014C324
        private void cbvat_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbvat.Checked)
            //{
            //    this.cbvat.Checked = true;
            //    string cmdText = "update TB_CAUHINH set VAT ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbvat.Checked = false;
            //    string cmdText = "update TB_CAUHINH set VAT ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600081A RID: 2074 RVA: 0x0014E200 File Offset: 0x0014C400
        private void cbbanamkho_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbbanamkho.Checked)
            //{
            //    this.cbbanamkho.Checked = true;
            //    string cmdText = "update TB_CAUHINH set BANAMKHO ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbbanamkho.Checked = false;
            //    string cmdText = "update TB_CAUHINH set BANAMKHO ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600081B RID: 2075 RVA: 0x0014E2DC File Offset: 0x0014C4DC
        private void cbhdcu_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbhdcu.Checked)
            //{
            //    this.cbhdcu.Checked = true;
            //    string cmdText = "update TB_CAUHINH set HOADONCU ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbhdcu.Checked = false;
            //    string cmdText = "update TB_CAUHINH set HOADONCU ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600081C RID: 2076 RVA: 0x0014E3B8 File Offset: 0x0014C5B8
        private void cblamtron_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cblamtron.Checked)
            //{
            //    this.cblamtron.Checked = true;
            //    string cmdText = "update TB_CAUHINH set LAMTRONCK ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cblamtron.Checked = false;
            //    string cmdText = "update TB_CAUHINH set LAMTRONCK ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600081D RID: 2077 RVA: 0x0014E494 File Offset: 0x0014C694
        private void cbinhoadon_Click(object sender, EventArgs e)
        {
            //if (this.cbinhoadon.Checked)
            //{
            //    this.cbinhoadon.Checked = true;
            //    string cmdText = "update TB_CAUHINH set INHOADON ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbinhoadon.Checked = false;
            //    string cmdText = "update TB_CAUHINH set INHOADON ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600081E RID: 2078 RVA: 0x0014E570 File Offset: 0x0014C770
        private void cbnho_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbnho.Checked)
            //{
            //    Settings.Default.matkhau = "true";
            //    Settings.Default.Save();
            //}
            //else
            //{
            //    Settings.Default.matkhau = "false";
            //    Settings.Default.Save();
            //}
        }

        // Token: 0x0600081F RID: 2079 RVA: 0x0014E5CC File Offset: 0x0014C7CC
        private void cbsl_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbsl.Checked)
            //{
            //    this.cbsl.Checked = true;
            //    string cmdText = "update TB_CAUHINH set ENTERSOLUONG ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbsl.Checked = false;
            //    string cmdText = "update TB_CAUHINH set ENTERSOLUONG ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000820 RID: 2080 RVA: 0x0014E6A8 File Offset: 0x0014C8A8
        private void guimail()
        {
            //try
            //{
            //    if (this.txtmailnhan.Text != "")
            //    {
            //        string[] array = this.txtmailnhan.Text.Split(new char[]
            //        {
            //            ','
            //        });
            //        MailMessage mailMessage = new MailMessage(this.txtmailgui.Text, array[0], "KIỂM TRA EMAIL", "KIỂM TRA EMAIL");
            //        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //        smtpClient.Port = 587;
            //        smtpClient.Credentials = new NetworkCredential(this.txtmailgui.Text, this.txtmatkhau.Text);
            //        smtpClient.EnableSsl = true;
            //        foreach (string text in array)
            //        {
            //            string text2 = text.ToString();
            //            if (text2 != array[0])
            //            {
            //                mailMessage.CC.Add(text2);
            //            }
            //        }
            //        smtpClient.Send(mailMessage);
            //        mailMessage.Dispose();
            //        MessageBox.Show("Gửi File Thành Công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Không gửi được File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }

        // Token: 0x06000821 RID: 2081 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
        private void button1_Click(object sender, EventArgs e)
        {
            this.guimail();
        }

        // Token: 0x06000822 RID: 2082 RVA: 0x0014E804 File Offset: 0x0014CA04
        private void cbkhoidong_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbkhoidong.Checked)
            //{
            //    this.cbkhoidong.Checked = true;
            //    string cmdText = "update TB_CAUHINH set EAN13 ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbkhoidong.Checked = false;
            //    string cmdText = "update TB_CAUHINH set EAN13 ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000823 RID: 2083 RVA: 0x0014E8E0 File Offset: 0x0014CAE0
        private void cbcongdon_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.cbcongdon.Checked)
            //{
            //    this.cbcongdon.Checked = true;
            //    string cmdText = "update TB_CAUHINH set CONGDON ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.cbcongdon.Checked = false;
            //    string cmdText = "update TB_CAUHINH set CONGDON ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000824 RID: 2084 RVA: 0x0014E9BC File Offset: 0x0014CBBC
        private void button2_Click(object sender, EventArgs e)
        {
            Frmketnoican frmketnoican = new Frmketnoican();
            frmketnoican.ShowDialog();
        }

        // Token: 0x06000825 RID: 2085 RVA: 0x0014E9D8 File Offset: 0x0014CBD8
        private void checkBox2_Click(object sender, EventArgs e)
        {
            //if (this.checkBox2.Checked)
            //{
            //    this.checkBox2.Checked = true;
            //    string cmdText = "update TB_CAUHINH set HIENKHACHHANG ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
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
            //    string cmdText = "update TB_CAUHINH set HIENKHACHHANG ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000826 RID: 2086 RVA: 0x0014EAB4 File Offset: 0x0014CCB4
        private void checkBox3_Click(object sender, EventArgs e)
        {
            //if (this.checkBox3.Checked)
            //{
            //    this.checkBox3.Checked = true;
            //    string cmdText = "update TB_CAUHINH set GIAM1LAN ='True'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
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
            //    string cmdText = "update TB_CAUHINH set GIAM1LAN ='False'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000827 RID: 2087 RVA: 0x0014EB90 File Offset: 0x0014CD90
        private void cobmayin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cobmayin.SelectedIndex == 0)
            {
                this.textBox2.Text = "11";
            }
            else
            {
                this.textBox2.Text = "9";
            }
        }

        // Token: 0x06000828 RID: 2088 RVA: 0x0014EBD8 File Offset: 0x0014CDD8
        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox4.Checked)
            //{
            //    this.checkBox4.Checked = true;
            //    string cmdText = "update TB_CAUHINH set INLOGO ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
            //else
            //{
            //    this.checkBox4.Checked = false;
            //    string cmdText = "update TB_CAUHINH set INLOGO ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x06000829 RID: 2089 RVA: 0x0014ECB4 File Offset: 0x0014CEB4
        private void button3_Click(object sender, EventArgs e)
        {
            Frm_manhinh frm_manhinh = new Frm_manhinh();
            frm_manhinh.ShowDialog();
        }

        // Token: 0x0600082A RID: 2090 RVA: 0x0014ECD0 File Offset: 0x0014CED0
        private void checkBox5_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.checkBox5.Checked)
            //{
            //    this.checkBox5.Checked = true;
            //    string cmdText = "update TB_CAUHINH set MANHINH ='true'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
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
            //    string cmdText = "update TB_CAUHINH set MANHINH ='false'  WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }

        // Token: 0x0600082B RID: 2091 RVA: 0x0014EDAC File Offset: 0x0014CFAC
        private void checkBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.checkBox6.Checked)
            {
                this.txtt22.Text = "0";
            }
            else
            {
                this.txtt22.Text = "1";
            }
        }

        // Token: 0x0600082C RID: 2092 RVA: 0x0014EDF0 File Offset: 0x0014CFF0
        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtt2.Text = "0";
            if (this.checkBox7.Checked)
            {
                this.txtt2.Text = "1";
            }
        }

        //private CanCtr canctr = new CanCtr();

        // Token: 0x040008FD RID: 2301
      //  private CauhinhObj chObj = new CauhinhObj();

    }
}
