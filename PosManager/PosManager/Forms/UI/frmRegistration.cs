using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void btok_Click(object sender, EventArgs e)
        {
            //if (!File.Exists("CrystalDecisions.ReportAp.txt"))
            //{
            //    FileStream fileStream = new FileStream("CrystalDecisions.ReportAp.txt", FileMode.Create);
            //    StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            //    streamWriter.WriteLine(this.txtproductkey.Text);
            //    streamWriter.Flush();
            //    fileStream.Close();
            //    MessageBox.Show("Đăng ký thành công");
            //    base.Close();
            //}
            //else
            //{
            //    StreamWriter streamWriter2 = new StreamWriter("CrystalDecisions.ReportAp.txt", false);
            //    streamWriter2.WriteLine(this.txtproductkey.Text);
            //    streamWriter2.Flush();
            //    streamWriter2.Close();
            //    MessageBox.Show("Đăng ký thành công");
            //    base.Close();
            //}
        }

        // Token: 0x06000A3A RID: 2618 RVA: 0x00098434 File Offset: 0x00096634
        public static string Encrypt(string toEncrypt)
        {
            string a = frmLogIn.a;
            bool flag = true;
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] key;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(a));
            }
            else
            {
                key = Encoding.UTF8.GetBytes(a);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateEncryptor();
            byte[] array = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(array, 0, array.Length);
        }

        // Token: 0x06000A3B RID: 2619 RVA: 0x000984D8 File Offset: 0x000966D8
        public static string Decrypt(string toDecrypt)
        {
            string a = frmLogIn.a;
            bool flag = true;
            byte[] array = Convert.FromBase64String(toDecrypt);
            byte[] key;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(a));
            }
            else
            {
                key = Encoding.UTF8.GetBytes(a);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateDecryptor();
            byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        // Token: 0x06000A3C RID: 2620 RVA: 0x001987F8 File Offset: 0x001969F8
        public static string Decrypt2018(string toDecrypt)
        {
            string s = "GFWw()[ư}@*#123/*+-`~";
            bool flag = true;
            byte[] array = Convert.FromBase64String(toDecrypt);
            byte[] key;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            else
            {
                key = Encoding.UTF8.GetBytes(s);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateDecryptor();
            byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        // Token: 0x06000A3D RID: 2621 RVA: 0x00198894 File Offset: 0x00196A94
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            //ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            //foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
            //{
            //    ManagementObject managementObject = (ManagementObject)managementBaseObject;
            //    HardDrive hardDrive = new HardDrive();
            //    hardDrive.SerialNo = managementObject["ProcessorID"].ToString();
            //    this.txtproductID.Text = frmRegistration.Encrypt(hardDrive.SerialNo);
            //}
        }

        // Token: 0x06000A3E RID: 2622 RVA: 0x00198930 File Offset: 0x00196B30
        public static string Encrypt2018(string toEncrypt)
        {
            string s = "GFWw()[ư}@*#123/*+-`~";
            bool flag = true;
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] key;
            if (flag)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            else
            {
                key = Encoding.UTF8.GetBytes(s);
            }
            ICryptoTransform cryptoTransform = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            }.CreateEncryptor();
            byte[] array = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(array, 0, array.Length);
        }

        // Token: 0x06000A3F RID: 2623 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button1_Click(object sender, EventArgs e)
        {
          //  base.Close();
        }

        // Token: 0x04000C73 RID: 3187
        private const int productCode = 1;
    }
}
