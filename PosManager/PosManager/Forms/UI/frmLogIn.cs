using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class frmLogIn : Form
    {

        // Token: 0x04000326 RID: 806
        public static string tentaikhoan = string.Empty;

        // Token: 0x04000327 RID: 807
        public static string MAMAY = "00";

        // Token: 0x04000328 RID: 808
        public static string SAOLUU = "";

        // Token: 0x04000329 RID: 809
        public static string a = "WƯư@*#123/*+-`~%$&^6^*()ơ{";

        // Token: 0x0400032A RID: 810
        public static string MADANGNHAP = string.Empty;

        // Token: 0x0400032B RID: 811
        public static string phanquyen = string.Empty;

        // Token: 0x0400032C RID: 812
        public static string macongty = string.Empty;

        // Token: 0x0400032D RID: 813
        public static string fileconnect = "";

        // Token: 0x0400032E RID: 814
        public static string fileconnect_khachhang = "";

        // Token: 0x0400032F RID: 815
        public static string tensql = "";

        // Token: 0x04000330 RID: 816
        public static string sokhachhang = "10";

        // Token: 0x04000331 RID: 817
        private string connet = "Data Source=" + frmLogIn.fileconnect;

        //// Token: 0x04000332 RID: 818
        //private SqlConnection conn;

        //// Token: 0x04000333 RID: 819
        //private SqlCommand command;

        public frmLogIn()
        {
            InitializeComponent();
            this.key = Registry.CurrentUser.OpenSubKey("System\\system64bit", true);
            this.key1 = Registry.CurrentUser.OpenSubKey("Software\\Software", true);
            if (this.key == null && this.key1 == null)
            {
                this.key = Registry.CurrentUser.CreateSubKey("System\\system64bit");
                this.key.SetValue("GameDVR_FSEBehaviorMode", frmLogIn.Encrypt(DateTime.Now.ToString("dd/MM/yyyy")));
                this.key1 = Registry.CurrentUser.CreateSubKey("Software\\Software");
                this.key1.SetValue("Rde", frmLogIn.Encrypt(DateTime.Now.ToString("dd/MM/yyyy")));
            }
        }
        private void Connet()
        {
            try
            {
                string[] array = File.ReadAllLines(Application.StartupPath + "\\Connect.txt");
                frmLogIn.fileconnect = array[0];
                frmLogIn.MAMAY = array[1];
                frmLogIn.SAOLUU = array[2];
                frmLogIn.fileconnect_khachhang = array[3];
                frmLogIn.sokhachhang = array[4];
            }
            catch
            {
                frmLogIn.fileconnect_khachhang = frmLogIn.fileconnect;
                MessageBox.Show("FILE CONNECT BỊ LỖI", "THÔNG BÁO");
            }
        }

        // Token: 0x060002AE RID: 686 RVA: 0x00098434 File Offset: 0x00096634
        public static string Encrypt(string toEncrypt)
        {
            string s = frmLogIn.a;
            bool flag = true;
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] array;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                array = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            else
            {
                array = Encoding.UTF8.GetBytes(s);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = array,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateEncryptor();
            byte[] array2 = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(array2, 0, array2.Length);
        }

        // Token: 0x060002AF RID: 687 RVA: 0x000984D8 File Offset: 0x000966D8
        public static string Decrypt(string toDecrypt)
        {
            string s = frmLogIn.a;
            bool flag = true;
            byte[] array = Convert.FromBase64String(toDecrypt);
            byte[] array2;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                array2 = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            else
            {
                array2 = Encoding.UTF8.GetBytes(s);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = array2,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateDecryptor();
            byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
            return Encoding.UTF8.GetString(bytes);
        }
        // Token: 0x060002B1 RID: 689 RVA: 0x00098670 File Offset: 0x00096870
        private static void add_sql()
        {
            //try
            //{
            //    string[] array = frmLogIn.fileconnect.Split(new char[]
            //    {
            //        ';'
            //    });
            //    string[] array2 = array;
            //    int num = 0;
            //    if (num < array2.Length)
            //    {
            //        string text = array2[num];
            //        frmLogIn.tensql = text.ToString();
            //    }
            //    string connectionString = "Data Source=" + frmLogIn.tensql + ";Integrated Security=true";
            //    SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
            //    Console.WriteLine("Original: " + sqlConnectionStringBuilder.ConnectionString);
            //    Console.WriteLine("AttachDBFileName={0}", sqlConnectionStringBuilder.AttachDBFilename);
            //    sqlConnectionStringBuilder.AttachDBFilename = Application.StartupPath + "\\DATASHOP.mdf";
            //    Console.WriteLine("Modified: " + sqlConnectionStringBuilder.ConnectionString);
            //    using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            //    {
            //        sqlConnection.Open();
            //        string cmdText = "ALTER DATABASE [" + Application.StartupPath + "\\DATASHOP.mdf] MODIFY NAME = DATASHOP";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("PHÂN QUYỀN DỮ LIỆU SQL TRƯỚC KHI CHẠY", "THÔNG BÁO", MessageBoxButtons.OK);
            //    Application.Exit();
            //}
        }

        // Token: 0x060002B2 RID: 690 RVA: 0x0001BE9D File Offset: 0x0001A09D
        private void btHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x060002B3 RID: 691 RVA: 0x00097A40 File Offset: 0x00095C40
        public string mahoa(string pass)
        {
            //return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
            return null;
        }

        // Token: 0x060002B4 RID: 692 RVA: 0x000987E0 File Offset: 0x000969E0
        public void furntionlogin()
        {
            //try
            //{
            //    this.connet = "Data Source=" + frmLogIn.fileconnect;
            //    this.conn = new SqlConnection(this.connet);
            //    this.conn.Open();
            //    string cmdText = "select count(nv.mataikhoan) from Tb_NGUOIDUNG nv where mataikhoan=@manv and matkhau=@matkhau";
            //    this.command = new SqlCommand(cmdText, this.conn);
            //    this.command.Parameters.Add(new SqlParameter("@manv", this.txtmadanhap.Text));
            //    this.command.Parameters.Add(new SqlParameter("@matkhau", this.mahoa(this.txtmatkhau.Text)));
            //    int num = (int)this.command.ExecuteScalar();
            //    if (num == 1)
            //    {
            //        KeyManager keyManager = new KeyManager(ComputerInfo.GetComputerId());
            //        LicenseInfo licenseInfo = new LicenseInfo();
            //        int num2 = keyManager.LoadSuretyFile(string.Format("{0}\\CrystalDecisions.ReportAp.lic", Application.StartupPath), ref licenseInfo);
            //        string productKey = licenseInfo.ProductKey;
            //        if (keyManager.ValidKey(ref productKey))
            //        {
            //            KeyValuesClass keyValuesClass = new KeyValuesClass();
            //            if (keyManager.DisassembleKey(productKey, ref keyValuesClass))
            //            {
            //                if (keyValuesClass.Type == 1)
            //                {
            //                    this.loadcauhinh();
            //                    TrangChu trangChu = new TrangChu();
            //                    base.Hide();
            //                    trangChu.Show();
            //                    base.Hide();
            //                }
            //                else if (this.key != null && this.key1 != null && frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString()) == frmLogIn.Decrypt(this.key1.GetValue("Rde").ToString()) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) >= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).AddDays(8.0))
            //                {
            //                    this.loadcauhinh();
            //                    TrangChu trangChu = new TrangChu();
            //                    base.Hide();
            //                    trangChu.Show();
            //                    base.Hide();
            //                }
            //                else if (keyValuesClass.Type == 0)
            //                {
            //                    this.label4.Text = string.Format("{0} days", (keyValuesClass.Expiration - DateTime.Now.Date).Days);
            //                    int days = (keyValuesClass.Expiration - DateTime.Now.Date).Days;
            //                    if (days <= 0)
            //                    {
            //                        MessageBox.Show("VUI LÒNG LIÊN HỆ 0975 788 409 ĐỂ KÍCH HOẠT", "PHẦN MỀM HẾT THỜI GIAN DÙNG THỬ", MessageBoxButtons.OK);
            //                    }
            //                    else
            //                    {
            //                        this.loadcauhinh();
            //                        TrangChu trangChu = new TrangChu();
            //                        base.Hide();
            //                        trangChu.Show();
            //                        base.Hide();
            //                    }
            //                }
            //            }
            //        }
            //        else if (this.key != null && this.key1 != null && frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString()) == frmLogIn.Decrypt(this.key1.GetValue("Rde").ToString()) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) >= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).AddDays(8.0))
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //            base.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("VUI LÒNG LIÊN HỆ 0975 788 409 ĐỂ KÍCH HOẠT", "PHẦN MỀM HẾT THỜI GIAN DÙNG THỬ", MessageBoxButtons.OK);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai mã đăng nhập hoặc mật khẩu");
            //        this.txtmatkhau.Text = "";
            //        this.lbdangnhap.Text = "";
            //        this.txtmatkhau.Focus();
            //    }
            //}
            //catch
            //{
            //    this.lbdangnhap.Text = "";
            //}
        }

        // Token: 0x060002B5 RID: 693 RVA: 0x00098D18 File Offset: 0x00096F18
        public static string Encrypt_Lan2(string toEncrypt)
        {
            string s = frmLogIn.a + "ư}ơ&%$#";
            bool flag = true;
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] array;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                array = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            else
            {
                array = Encoding.UTF8.GetBytes(s);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = array,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateEncryptor();
            byte[] array2 = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(array2, 0, array2.Length);
        }

        // Token: 0x060002B6 RID: 694 RVA: 0x00098DC4 File Offset: 0x00096FC4
        private void loadbanquyen()
        {
            //this.connet = "Data Source=" + frmLogIn.fileconnect;
            //this.conn = new SqlConnection(this.connet);
            //this.conn.Open();
            //string cmdText = "select count(nv.mataikhoan) from Tb_NGUOIDUNG nv where mataikhoan=@manv and matkhau=@matkhau";
            //this.command = new SqlCommand(cmdText, this.conn);
            //this.command.Parameters.Add(new SqlParameter("@manv", this.txtmadanhap.Text));
            //this.command.Parameters.Add(new SqlParameter("@matkhau", this.mahoa(this.txtmatkhau.Text)));
            //int num = (int)this.command.ExecuteScalar();
            //if (num == 1)
            //{
            //    if (!File.Exists("CrystalDecisions.ReportAp.txt"))
            //    {
            //        if (this.key != null && this.key1 != null && frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString()) == frmLogIn.Decrypt(this.key1.GetValue("Rde").ToString()) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) >= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) && Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("GameDVR_FSEBehaviorMode").ToString())).AddDays(7.0) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")).AddDays(8.0))
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //        }
            //        else if (SystemInformation.ComputerName == "PC112233-PC")
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //        }
            //        else if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) < Convert.ToDateTime(Settings.Default.ngayhethong).AddDays(7.0))
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //        }
            //        else
            //        {
            //            this.lbdangnhap.Text = "Đăng nhập không thành công";
            //            MessageBox.Show("VUI LÒNG KÍCH HOẠT PHẦN MỀM", "THÔNG BÁO", MessageBoxButtons.OK);
            //        }
            //    }
            //    else
            //    {
            //        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            //        HardDrive hardDrive = new HardDrive();
            //        foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
            //        {
            //            ManagementObject managementObject = (ManagementObject)managementBaseObject;
            //            hardDrive.SerialNo = managementObject["ProcessorID"].ToString();
            //        }
            //        FileStream stream = new FileStream("CrystalDecisions.ReportAp.txt", FileMode.Open);
            //        StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            //        string b = streamReader.ReadLine();
            //        streamReader.Close();
            //        if (frmLogIn.Encrypt_Lan2(frmLogIn.Encrypt(hardDrive.SerialNo)) == b)
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //        }
            //        else
            //        {
            //            this.lbdangnhap.Text = "Đăng nhập không thành công";
            //            MessageBox.Show("VUI LÒNG KÍCH HOẠT PHẦN MỀM", "THÔNG BÁO", MessageBoxButtons.OK);
            //        }
            //    }
            //    Settings.Default.DANGNHAP = this.txtmadanhap.Text;
            //    Settings.Default.matkhaunho = this.txtmatkhau.Text;
            //    Settings.Default.Save();
            //}
            //else
            //{
            //    this.lbdangnhap.Text = "Đăng nhập không thành công";
            //    MessageBox.Show("TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU KHÔNG ĐÚNG", "THÔNG BÁO", MessageBoxButtons.OK);
            //    this.txtmatkhau.Focus();
            //}
            //this.lbdangnhap.Text = "Đăng nhập không thành công";
        }

        // Token: 0x060002B7 RID: 695 RVA: 0x0009922C File Offset: 0x0009742C
        private void furntionlogin1()
        {
            //Generate generate = new Generate();
            //try
            //{
            //    this.connet = "Data Source=" + frmLogIn.fileconnect;
            //    this.conn = new SqlConnection(this.connet);
            //    this.conn.Open();
            //    string cmdText = "select count(nv.mataikhoan) from Tb_NGUOIDUNG nv where mataikhoan=@manv and matkhau=@matkhau";
            //    this.command = new SqlCommand(cmdText, this.conn);
            //    this.command.Parameters.Add(new SqlParameter("@manv", this.txtmadanhap.Text));
            //    this.command.Parameters.Add(new SqlParameter("@matkhau", this.mahoa(this.txtmatkhau.Text)));
            //    int num = (int)this.command.ExecuteScalar();
            //    if (num == 1)
            //    {
            //        KeyManager keyManager = new KeyManager(ComputerInfo.GetComputerId());
            //        LicenseInfo licenseInfo = new LicenseInfo();
            //        int num2 = keyManager.LoadSuretyFile(string.Format("{0}\\abcsender.lic", Application.StartupPath), ref licenseInfo);
            //        string productKey = licenseInfo.ProductKey;
            //        if (keyManager.ValidKey(ref productKey))
            //        {
            //            KeyValuesClass keyValuesClass = new KeyValuesClass();
            //            if (keyManager.DisassembleKey(productKey, ref keyValuesClass))
            //            {
            //                if (keyValuesClass.Type == 1)
            //                {
            //                    this.loadcauhinh();
            //                    TrangChu trangChu = new TrangChu();
            //                    base.Hide();
            //                    trangChu.Show();
            //                    base.Hide();
            //                }
            //                else if (Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("datedk").ToString())).AddDays(7.0) >= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            //                {
            //                    this.loadcauhinh();
            //                    TrangChu trangChu = new TrangChu();
            //                    base.Hide();
            //                    trangChu.Show();
            //                    base.Hide();
            //                }
            //                else if (keyValuesClass.Type == 0)
            //                {
            //                    this.label4.Text = string.Format("{0} days", (keyValuesClass.Expiration - DateTime.Now.Date).Days);
            //                    int days = (keyValuesClass.Expiration - DateTime.Now.Date).Days;
            //                    if (days <= 0)
            //                    {
            //                        MessageBox.Show("PHẦN MỀM HẾT THỜI GIAN DÙNG THỬ VUI LÒNG LIÊN HỆ HOTLINE: 0975 788 409 ĐỂ MUA BẢN QUYỀN", "THÔNG BÁO", MessageBoxButtons.OK);
            //                    }
            //                    else
            //                    {
            //                        this.loadcauhinh();
            //                        TrangChu trangChu = new TrangChu();
            //                        base.Hide();
            //                        trangChu.Show();
            //                        base.Hide();
            //                    }
            //                }
            //            }
            //        }
            //        else if (Convert.ToDateTime(frmLogIn.Decrypt(this.key.GetValue("datedk").ToString())).AddDays(7.0) >= Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
            //        {
            //            this.loadcauhinh();
            //            TrangChu trangChu = new TrangChu();
            //            base.Hide();
            //            trangChu.Show();
            //            base.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("PHẦN MỀM HẾT THỜI GIAN DÙNG THỬ VUI LÒNG LIÊN HỆ HOTLINE: 0975 788 409 ĐỂ MUA BẢN QUYỀN", "THÔNG BÁO", MessageBoxButtons.OK);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai mã đăng nhập hoặc mật khẩu");
            //        this.txtmatkhau.Text = "";
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("CHƯA ADD DATABASE");
            //}
        }

        // Token: 0x060002B8 RID: 696 RVA: 0x0001BEA6 File Offset: 0x0001A0A6
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            this.lbdangnhap.Text = "Đang kết nối dữ liệu . . .";
            frmLogIn.MADANGNHAP = this.txtmadanhap.Text;
            this.loadbanquyen();
        }

        // Token: 0x060002B9 RID: 697 RVA: 0x000995D8 File Offset: 0x000977D8
        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btdangnhap_Click(null, null);
            }
        }

        // Token: 0x060002BA RID: 698 RVA: 0x00099604 File Offset: 0x00097804
        private void txtmadanhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtmatkhau.Focus();
            }
        }

        // Token: 0x060002BB RID: 699 RVA: 0x00099634 File Offset: 0x00097834
        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //frmRegistration frmRegistration = new frmRegistration();
            //frmRegistration.ShowDialog();
        }

        // Token: 0x060002BC RID: 700 RVA: 0x00099650 File Offset: 0x00097850
        private void CheckforExitstingInstance()
        {
            if (Process.GetProcessesByName("QLSHOP").Length > 1)
            {
                MessageBox.Show("PHẦN MỀM ĐANG MỞ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        // Token: 0x060002BD RID: 701 RVA: 0x00099690 File Offset: 0x00097890
        private void kiemtra_ngay()
        {
            try
            {
                using (WebResponse response = WebRequest.Create("https://www.google.com/").GetResponse())
                {
                    frmLogIn.ngaythang = DateTime.ParseExact(response.Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
                }
            }
            catch (WebException)
            {
                frmLogIn.ngaythang = DateTime.Now;
                try
                {
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.Microsoft.com");
                    WebResponse response = httpWebRequest.GetResponse();
                    string s = response.Headers["date"];
                    frmLogIn.ngaythang = DateTime.ParseExact(s, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
                }
                catch
                {
                    frmLogIn.ngaythang = DateTime.Now;
                }
            }
        }

        // Token: 0x060002BE RID: 702 RVA: 0x00099780 File Offset: 0x00097980
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.kiemtra_ngay();
            if (frmLogIn.ngaythang.ToString("dd/MM/yyyy") != DateTime.Now.ToString("dd/MM/yyyy"))
            {
                this.txtmatkhau.Enabled = false;
                this.btdangnhap.Enabled = false;
                MessageBox.Show("NGÀY MÁY TÍNH BỊ SAI - HÔM NAY LÀ NGÀY " + frmLogIn.ngaythang.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //TrangChu.ngaybanhang = frmLogIn.ngaythang.ToString("dd/MM/yyyy");
                //this.txtmadanhap.Text = Settings.Default.DANGNHAP;
                //base.Width = 379;
                //base.Height = 268;
                //this.Connet();
                //if (Settings.Default.matkhau == "true")
                //{
                //    this.txtmatkhau.Text = Settings.Default.matkhaunho;
                //}
            }
        }

        // Token: 0x060002BF RID: 703 RVA: 0x00099888 File Offset: 0x00097A88
        private void loadcauhinh()
        {
            //string cmdText = "SELECT macongty,PHANQUYEN,TENTAIKHOAN,MAMAY,MACUAHANG FROM TB_NGUOIDUNG WHERE Mataikhoan='" + this.txtmadanhap.Text + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    frmLogIn.macongty = Convert.ToString(sqlDataReader.GetString(0));
            //    frmLogIn.phanquyen = Convert.ToString(sqlDataReader.GetString(1));
            //    frmLogIn.tentaikhoan = Convert.ToString(sqlDataReader.GetString(2));
            //    frmLogIn.makho = Convert.ToString(sqlDataReader.GetValue(3));
            //    frmLogIn.macuahang = Convert.ToString(sqlDataReader.GetValue(4));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060002C0 RID: 704 RVA: 0x0001BED1 File Offset: 0x0001A0D1
        private void label4_Click(object sender, EventArgs e)
        {
            base.Width = 347;
            base.Height = 190;
        }

        // Token: 0x060002C1 RID: 705 RVA: 0x00099950 File Offset: 0x00097B50
        private void frmLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                base.Width = 543;
                base.Height = 290;
            }
        }

        // Token: 0x060002C2 RID: 706 RVA: 0x0009998C File Offset: 0x00097B8C
        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!File.Exists("Connect.txt"))
            {
                FileStream fileStream = new FileStream("Connect.txt", FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                streamWriter.WriteLine(this.txtduongdan.Text);
                streamWriter.Flush();
                fileStream.Close();
            }
            else
            {
                StreamWriter streamWriter2 = new StreamWriter("Connect.txt", false);
                streamWriter2.WriteLine(this.txtduongdan.Text);
                streamWriter2.Flush();
            }
            frmLogIn.add_sql();
            this.LOADMADANGNHAP();
        }

        // Token: 0x060002C3 RID: 707 RVA: 0x00099A18 File Offset: 0x00097C18
        private void LOADMADANGNHAP()
        {
            //try
            //{
            //    this.txtmadanhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    this.txtmadanhap.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "Select mataikhoan from Tb_NGUOIDUNG";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //    }
            //    this.txtmadanhap.AutoCompleteCustomSource = autoCompleteStringCollection;
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060002C4 RID: 708 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button1_Click(object sender, EventArgs e)
        {
            //base.Close();
        }

        // Token: 0x060002C5 RID: 709 RVA: 0x0001BEEC File Offset: 0x0001A0EC
        private void txtmadanhap_TextChanged(object sender, EventArgs e)
        {
            this.txtmadanhap.Text = this.txtmadanhap.Text.ToUpper();
            this.txtmadanhap.SelectionStart = this.txtmadanhap.TextLength;
        }

        // Token: 0x060002C6 RID: 710 RVA: 0x00099AD0 File Offset: 0x00097CD0
        private void button2_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo =
                {
                    FileName = Application.StartupPath + "\\TeamViewerQS_vi.exe"
                }
            }.Start();
        }
    }
}
