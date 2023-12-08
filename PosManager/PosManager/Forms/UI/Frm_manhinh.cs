using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frm_manhinh : Form
    {
        public Frm_manhinh()
        {
            InitializeComponent();
            this.P.ReadTimeout = 100;
            this.P.WriteTimeout = 100;
            this.P.DataReceived += this.DataReceive;
            this.P.RtsEnable = true;
        }

        // Token: 0x06000EA8 RID: 3752 RVA: 0x001F1778 File Offset: 0x001EF978
        private void Frm_manhinh_Load(object sender, EventArgs e)
        {
            //string[] portNames = SerialPort.GetPortNames();
            //int[] array = new int[portNames.Length];
            //for (int i = 0; i < portNames.Length; i++)
            //{
            //    array[i] = int.Parse(portNames[i].Substring(3));
            //}
            //Array.Sort<int>(array);
            //foreach (int num in array)
            //{
            //    this.cobtencom.Items.Add("COM" + num.ToString());
            //}
            //string cmdText = "SELECT * FROM TB_MANHINH WHERE MA='" + frmLogIn.macongty + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.cobtencom.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //    this.txttimeout.Text = Convert.ToString(sqlDataReader.GetValue(7));
            //    this.cobprity.Text = Convert.ToString(sqlDataReader.GetValue(4));
            //    this.cobstop.Text = Convert.ToString(sqlDataReader.GetValue(5));
            //    this.cobflow.Text = Convert.ToString(sqlDataReader.GetValue(6));
            //    this.cobdata.Text = Convert.ToString(sqlDataReader.GetValue(3));
            //    this.cobtocdo.Text = Convert.ToString(sqlDataReader.GetValue(2));
            //    this.txt1.Text = Convert.ToString(sqlDataReader.GetValue(8));
            //    this.txt2.Text = Convert.ToString(sqlDataReader.GetValue(9));
            //}
            //sqlConnection.Close();
            //bool flag = false;
            //foreach (object obj in this.cobtencom.Items)
            //{
            //    string a = (string)obj;
            //    if (a == this.cobtencom.Text)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if (!flag)
            //{
            //    MessageBox.Show("Không tìm thấy cổng COM");
            //}
            this.btketnoi_Click(null, null);
        }

        // Token: 0x06000EA9 RID: 3753 RVA: 0x001F1A08 File Offset: 0x001EFC08
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            this.InputData = this.P.ReadExisting();
            if (this.InputData != string.Empty)
            {
                this.SetText(this.InputData);
            }
        }

        // Token: 0x06000EAA RID: 3754 RVA: 0x0001B637 File Offset: 0x00019837
        private void SetText(string text)
        {
        }

        // Token: 0x06000EAB RID: 3755 RVA: 0x001F1A50 File Offset: 0x001EFC50
        private void btketnoi_Click(object sender, EventArgs e)
        {
            if (this.cobtencom.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Cổng COM", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (this.P.IsOpen)
            {
                this.P.Close();
                this.btketnoi.Text = "Kết Nối";
                this.pncauhinh.Enabled = true;
            }
            else
            {
                try
                {
                    this.P.PortName = this.cobtencom.Text;
                    this.P.ReadTimeout = int.Parse(this.txttimeout.Text);
                    this.P.Parity = Parity.None;
                    this.P.StopBits = StopBits.One;
                    this.P.DataBits = int.Parse(this.cobdata.Text);
                    this.P.BaudRate = int.Parse(this.cobtocdo.Text);
                    if (this.P.IsOpen)
                    {
                        this.P.Close();
                    }
                    this.P.Open();
                    this.btketnoi.Text = "Ngắt kết nối";
                }
                catch
                {
                    this.pncauhinh.Enabled = true;
                    MessageBox.Show("Không thể mở cổng " + this.P.PortName, "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        // Token: 0x06000EAC RID: 3756 RVA: 0x001F1BE0 File Offset: 0x001EFDE0
        private void button3_Click(object sender, EventArgs e)
        {
            string cmdText = string.Concat(new string[]
            {
                "UPDATE [DATASHOP].[dbo].[TB_MANHINH]\r\n   SET [COM] = '",
                this.cobtencom.Text,
                "' ,[TOCDO] = '",
                this.cobtocdo.Text,
                "' ,[DATABIT] = '",
                this.cobdata.Text,
                "' ,[PARITYBIT] = '",
                this.cobprity.Text,
                "',[STOPBIT] = '",
                this.cobstop.Text,
                "'   ,[FLOW] = '",
                this.cobflow.Text,
                "' ,[TIME] = '",
                this.txttimeout.Text,
                "',[GHICHU1] = '",
                this.txt1.Text,
                "',[GHICHU2] = '",
                this.txt2.Text,
                "' WHERE [MA] ='",
                frmLogIn.macongty,
                "' "
            });
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        // Token: 0x06000EAD RID: 3757 RVA: 0x001F1D20 File Offset: 0x001EFF20
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.P.IsOpen)
                {
                    this.P.Open();
                }
            }
            catch
            {
            }
            try
            {
                string text = this.txt1.Text + this.txt2.Text;
                this.P.Write(text);
                this.P.Close();
            }
            catch (FormatException)
            {
            }
        }

        // Token: 0x06000EAE RID: 3758 RVA: 0x000F2380 File Offset: 0x000F0580
        public static byte[] StringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] array = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return array;
        }

        // Token: 0x06000EAF RID: 3759 RVA: 0x001F1DB4 File Offset: 0x001EFFB4
        private void Frm_manhinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.P.IsOpen)
            {
                this.P.Close();
            }
        }

        // Token: 0x06000EB0 RID: 3760 RVA: 0x001F1DE4 File Offset: 0x001EFFE4
        private string AtoX(string asc)
        {
            string text = " ";
            int num;
            if (asc.Length % 20 > 0)
            {
                num = asc.Length / 20 + 1;
            }
            else
            {
                num = asc.Length / 20;
            }
            for (int i = 0; i < num; i++)
            {
                int num2 = i * 20;
                int length;
                if (asc.Length - num2 > 20)
                {
                    length = 20;
                }
                else
                {
                    length = asc.Length - num2;
                }
                text = text + this.HexLine(i, asc.Substring(num2, length)) + "\r\n";
            }
            return text;
        }

        // Token: 0x06000EB1 RID: 3761 RVA: 0x001F1E8C File Offset: 0x001F008C
        private string HexLine(int lNum, string asc)
        {
            string text = "";
            char[] array = new char[20];
            asc.CopyTo(0, array, 0, asc.Length);
            text += string.Format("{0:X8} - {0:X8}", lNum * 20, (lNum + 1) * 20 - 1);
            text += " ";
            for (int i = 0; i < asc.Length; i++)
            {
                if (i != 0 && i % 4 == 0)
                {
                    text += " ";
                }
                text += string.Format("{0:X2}", (int)array[i]);
            }
            int num = 62 - text.Length;
            for (int i = 0; i < num; i++)
            {
                text += " ";
            }
            for (int i = 0; i < asc.Length; i++)
            {
                if (array[i] < '(' || array[i] > '~')
                {
                    text += ".";
                }
                else
                {
                    text += array[i].ToString();
                }
            }
            return text;
        }

        // Token: 0x06000EB2 RID: 3762 RVA: 0x0014AC08 File Offset: 0x00148E08
        public static byte[] HexStringToByteAray(string hexString)
        {
            //ASCIIEncoding asciiencoding = new ASCIIEncoding();
            //byte[] bytes = asciiencoding.GetBytes(hexString.ToLower());
            //for (long num = 0L; num < bytes.LongLength; num += 1L)
            //{
            //    checked
            //    {
            //        if (bytes[(int)((IntPtr)num)] >= 48 && bytes[(int)((IntPtr)num)] <= 57)
            //        {
            //            byte[] array = bytes;
            //            IntPtr intPtr = (IntPtr)num;
            //            array[(int)intPtr] = unchecked(array[(int)intPtr] - 48);
            //        }
            //        else
            //        {
            //            if (bytes[(int)((IntPtr)num)] < 97 || bytes[(int)((IntPtr)num)] > 102)
            //            {
            //                return null;
            //            }
            //            byte[] array2 = bytes;
            //            IntPtr intPtr2 = (IntPtr)num;
            //            array2[(int)intPtr2] = unchecked(array2[(int)intPtr2] - 87);
            //        }
            //    }
            //}
            //byte[] array3 = new byte[bytes.LongLength / 2L];
            //long num2 = 0L;
            //for (long num = 0L; num < bytes.LongLength; num += 2L)
            //{
            //    array3[(int)(checked((IntPtr)num2))] = (bytes[(int)(checked((IntPtr)num))] * 16) + bytes[(int)(checked((IntPtr)(unchecked(num + 1L))))];
            //    num2 += 1L;
            //}
            //return array3;
            return null;
        }
        private SerialPort P = new SerialPort();

        // Token: 0x040010D4 RID: 4308
        private string InputData = string.Empty;

        // (Invoke) Token: 0x06000EB6 RID: 3766
        private delegate void SetTextCallback(string text);
    }
}
