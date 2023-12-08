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
    public partial class Frmketnoican : Form
    {
        public Frmketnoican()
        {
            InitializeComponent();
            //this.P.ReadTimeout = 100;
            //this.P.WriteTimeout = 100;
            //this.P.DataReceived += this.DataReceive;
            //this.P.RtsEnable = true;
        }

        // Token: 0x060007F2 RID: 2034 RVA: 0x0014A368 File Offset: 0x00148568
        private void DataReceive(object obj/*, SerialDataReceivedEventArgs e*/)
        {
           // this.InputData = this.P.ReadExisting();
            if (this.InputData != string.Empty)
            {
                this.SetText(this.InputData);
            }
        }

        // Token: 0x060007F3 RID: 2035 RVA: 0x0014A3B0 File Offset: 0x001485B0
        private void SetText(string text)
        {
            if (this.txtnoidung.InvokeRequired)
            {
                Frmketnoican.SetTextCallback method = new Frmketnoican.SetTextCallback(this.SetText);
                base.Invoke(method, new object[]
                {
                    text
                });
            }
            else
            {
                TextBox textBox = this.txtnoidung;
                textBox.Text += text;
            }
        }

        // Token: 0x060007F4 RID: 2036 RVA: 0x0014A410 File Offset: 0x00148610
        private void Frmketnoican_Load(object sender, EventArgs e)
        {
            //if (Settings.Default.dungcan == "1")
            //{
            //    this.checkBox1.Checked = false;
            //}
            //else
            //{
            //    this.checkBox1.Checked = true;
            //}
            this.LOAD_LIEN_TUC();
        }

        // Token: 0x060007F5 RID: 2037 RVA: 0x0014A45C File Offset: 0x0014865C
        private void SaveSetting()
        {
            int num = 0;
            if (!this.checkBox1.Checked)
            {
                num = 1;
            }
            //Settings.Default.Time = this.txttimeout.Text;
            //Settings.Default.Paritybit = this.cobprity.Text;
            //Settings.Default.stopbit = this.cobstop.Text;
            //Settings.Default.Folow = this.cobflow.Text;
            //Settings.Default.databit = this.cobdata.Text;
            //Settings.Default.PortName = this.cobtencom.Text;
            //Settings.Default.tocdo = this.cobtocdo.Text;
            //Settings.Default.dungcan = num.ToString();
            //Settings.Default.Loaican = this.comboBox1.SelectedIndex.ToString();
            //Settings.Default.Save();
        }

        // Token: 0x060007F6 RID: 2038 RVA: 0x0014A554 File Offset: 0x00148754
        private void btketnoi_Click(object sender, EventArgs e)
        {
            if (this.cobtencom.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Cổng COM", "Thông Báo", MessageBoxButtons.OK);
            }
            //else if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //    this.btketnoi.Text = "Kết Nối";
            //    this.pncauhinh.Enabled = true;
            //}
            else
            {
                //try
                //{
                //    this.P.PortName = this.cobtencom.Text;
                //    this.P.ReadTimeout = int.Parse(this.txttimeout.Text);
                //    //this.P.Parity = Parity.None;
                //  //  this.P.StopBits = StopBits.One;
                //    this.P.DataBits = int.Parse(this.cobdata.Text);
                //    this.P.BaudRate = int.Parse(this.cobtocdo.Text);
                //    if (this.P.IsOpen)
                //    {
                //        this.P.Close();
                //    }
                //    this.P.Open();
                //    this.btketnoi.Text = "Ngắt kết nối";
                //}
                //catch
                //{
                //    this.pncauhinh.Enabled = true;
                //    MessageBox.Show("Không thể mở cổng " + this.P.PortName, "Lỗi", MessageBoxButtons.OK);
                //}
            }
        }

        // Token: 0x060007F7 RID: 2039 RVA: 0x0014A6E4 File Offset: 0x001488E4
        private void LOAD_LIEN_TUC()
        {
            //this.comboBox1.SelectedIndex = 0;
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
            //bool flag = false;
            //foreach (object obj in this.cobtencom.Items)
            //{
            //    string a = (string)obj;
            //    if (a == Settings.Default.PortName)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if (flag)
            //{
            //    this.cobtencom.Text = Settings.Default.PortName;
            //    this.txttimeout.Text = Settings.Default.Time;
            //    this.cobprity.Text = Settings.Default.Paritybit;
            //    this.cobstop.Text = Settings.Default.stopbit;
            //    this.cobflow.Text = Settings.Default.Folow;
            //    this.cobdata.Text = Settings.Default.databit;
            //    this.cobtocdo.Text = Settings.Default.tocdo;
            //    this.comboBox1.SelectedIndex = int.Parse(Settings.Default.Loaican);
            //}
            //else
            //{
            //    this.pncauhinh.Enabled = true;
            //}
            this.btketnoi_Click(null, null);
        }

        // Token: 0x060007F8 RID: 2040 RVA: 0x0014A8E8 File Offset: 0x00148AE8
        private void Frmketnoican_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            this.SaveSetting();
        }

        // Token: 0x060007F9 RID: 2041 RVA: 0x0014A920 File Offset: 0x00148B20
        private void cobtencom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            //this.P.PortName = this.cobtencom.SelectedItem.ToString();
        }

        // Token: 0x060007FA RID: 2042 RVA: 0x0014A96C File Offset: 0x00148B6C
        private void cobtocdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            //this.P.BaudRate = Convert.ToInt32(this.cobtocdo.Text);
        }

        // Token: 0x060007FB RID: 2043 RVA: 0x0014A9B8 File Offset: 0x00148BB8
        private void cobdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            //this.P.DataBits = Convert.ToInt32(this.cobdata.Text);
        }

        // Token: 0x060007FC RID: 2044 RVA: 0x0014AA04 File Offset: 0x00148C04
        private void cobprity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            string text = this.cobprity.SelectedItem.ToString();
            //if (text != null)
            //{
            //    if (!(text == "Odd"))
            //    {
            //        if (!(text == "None"))
            //        {
            //            if (text == "Even")
            //            {
            //                this.P.Parity = Parity.Even;
            //            }
            //        }
            //        else
            //        {
            //            this.P.Parity = Parity.None;
            //        }
            //    }
            //    else
            //    {
            //        this.P.Parity = Parity.Odd;
            //    }
            //}
        }

        // Token: 0x060007FD RID: 2045 RVA: 0x0014AA9C File Offset: 0x00148C9C
        private void cobstop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            string text = this.cobstop.SelectedItem.ToString();
            if (text != null)
            {
                //if (!(text == "1"))
                //{
                //    if (!(text == "1.5"))
                //    {
                //        if (text == "2")
                //        {
                //            this.P.StopBits = StopBits.Two;
                //        }
                //    }
                //    else
                //    {
                //        this.P.StopBits = StopBits.OnePointFive;
                //    }
                //}
                //else
                //{
                //    this.P.StopBits = StopBits.One;
                //}
            }
        }

        // Token: 0x060007FE RID: 2046 RVA: 0x0014AB34 File Offset: 0x00148D34
        private void txtnoidung_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                if (this.txtnoidung.TextLength > 11)
                {
                    this.textBox1.Text = this.txtnoidung.Text.Trim().Substring(this.txtnoidung.TextLength - 12, 7).Trim();
                }
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                if (this.txtnoidung.TextLength > 37)
                {
                    this.textBox1.Text = this.txtnoidung.Text.Trim().Substring(this.txtnoidung.TextLength - 38, 6).Trim();
                }
            }
        }

        // Token: 0x060007FF RID: 2047 RVA: 0x0001D0AE File Offset: 0x0001B2AE
        private void dulieuden(object sender/*, SerialDataReceivedEventArgs e*/)
        {
          //  this.P.DataReceived += this.dulieuden;
        }

        // Token: 0x06000800 RID: 2048 RVA: 0x0014AC08 File Offset: 0x00148E08
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
            // byte[] array3 = new byte[bytes.LongLength / 2L];
            //long num2 = 0L;
            //for (long num = 0L; num < bytes.LongLength; num += 2L)
            //{
            //    array3[(int)(checked((IntPtr)num2))] = bytes[(int)(checked((IntPtr)num))] * 16 + bytes[(int)(checked((IntPtr)(unchecked(num + 1L))))];
            //    num2 += 1L;
            //}
            //  return array3;
            return null;
        }

        // Token: 0x06000801 RID: 2049 RVA: 0x0014AD08 File Offset: 0x00148F08
        private static void DataReceivedHandler(object sender/*, SerialDataReceivedEventArgs e*/)
        {
            //Console.WriteLine("In data receive");
            //SerialPort serialPort = (SerialPort)sender;
            //int bytesToRead = serialPort.BytesToRead;
            //byte[] array = new byte[bytesToRead];
            //if (serialPort.BytesToRead > 1)
            //{
            //    serialPort.Read(array, 0, bytesToRead);
            //}
            //foreach (byte value in array)
            //{
            //    Console.WriteLine((int)value);
            //}
        }

        // Token: 0x06000802 RID: 2050 RVA: 0x0014AD80 File Offset: 0x00148F80
        private void button2_Click(object sender, EventArgs e)
        {
            //this.txtnoidung.Text = "";
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //    this.P.Dispose();
            //}
            //this.P.PortName = this.cobtencom.Text;
            //this.P.Parity = Parity.None;
            //this.P.BaudRate = 9600;
            //this.P.DataBits = 8;
            //this.P.StopBits = StopBits.One;
            //this.P.Open();
            //byte[] array = Frmketnoican.StringToByteArray("0511");
            //this.P.Write(array, 0, array.Length);
            //this.P.DataReceived += this.DataReceive;
        }

        // Token: 0x06000803 RID: 2051 RVA: 0x000F2380 File Offset: 0x000F0580
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

        // Token: 0x06000804 RID: 2052 RVA: 0x0014AE5C File Offset: 0x0014905C
        private string AtoX(string asc)
        {
            string text = " ";
            int num;
            if (asc.Length % 16 > 0)
            {
                num = asc.Length / 16 + 1;
            }
            else
            {
                num = asc.Length / 16;
            }
            for (int i = 0; i < num; i++)
            {
                int num2 = i * 16;
                int length;
                if (asc.Length - num2 > 16)
                {
                    length = 16;
                }
                else
                {
                    length = asc.Length - num2;
                }
                text = text + this.HexLine(i, asc.Substring(num2, length)) + "\r\n";
            }
            return text;
        }

        // Token: 0x06000805 RID: 2053 RVA: 0x0014AF04 File Offset: 0x00149104
        private string HexLine(int lNum, string asc)
        {
            string text = "";
            char[] array = new char[16];
            asc.CopyTo(0, array, 0, asc.Length);
            text += string.Format("{0:X8} - {0:X8}", lNum * 16, (lNum + 1) * 16 - 1);
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
                if (array[i] < ' ' || array[i] > '~')
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


        // Token: 0x06000807 RID: 2055 RVA: 0x0014B074 File Offset: 0x00149274


        // Token: 0x040008DE RID: 2270
       // private SerialPort P = new SerialPort();

        // Token: 0x040008DF RID: 2271
        private string InputData = string.Empty;


        // Token: 0x02000068 RID: 104
        // (Invoke) Token: 0x06000809 RID: 2057
        private delegate void SetTextCallback(string text);
    }
}
