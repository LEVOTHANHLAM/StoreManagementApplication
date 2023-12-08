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
    public partial class FrmGuitinnhan : Form
    {
        public FrmGuitinnhan()
        {
            InitializeComponent();
        }
        // Token: 0x04000856 RID: 2134
      //  private SerialPort P = new SerialPort();
        private void FrmGuitinnhan_Load(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT TENDONVI,SDT,Diachi,'True' as chon FROM TB_KHACHHANG where SDT!=''";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //sqlConnection.Close();
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
            //        this.dataGridView1.Rows[i].Cells["chon"].Value = true;
            //    }
            //}
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 939) / 2, 0, 939, Screen.PrimaryScreen.WorkingArea.Height + 10);
            //if (Settings.Default.PortName == "")
            //{
            //    Frmketnoican frmketnoican = new Frmketnoican();
            //    frmketnoican.ShowDialog();
            //}
            //else if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
            //else
            //{
            //    try
            //    {
            //        this.P.PortName = Settings.Default.PortName;
            //        this.P.Parity = Parity.None;
            //        this.P.BaudRate = int.Parse(Settings.Default.tocdo);
            //        this.P.DataBits = int.Parse(Settings.Default.databit);
            //        this.P.StopBits = StopBits.One;
            //        this.P.Open();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Không thể mở cổng COM", "Lỗi", MessageBoxButtons.OK);
            //    }
            //}
        }

        // Token: 0x0600074D RID: 1869 RVA: 0x00141FF0 File Offset: 0x001401F0
        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == this.textBox1.Tag.ToString())
            //{
            //    this.textBox1.Text = "";
            //}
        }

        // Token: 0x0600074E RID: 1870 RVA: 0x00142038 File Offset: 0x00140238
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == "")
            //{
            //    this.textBox1.Text = this.textBox1.Tag.ToString();
            //}
        }

        // Token: 0x0600074F RID: 1871 RVA: 0x00142080 File Offset: 0x00140280
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.textBox1.Text == this.textBox1.Tag.ToString())
            //{
            //    MessageBox.Show("Bạn chưa nhập nội dung tin nhắn", "Thông báo");
            //}
            //else
            //{
            //    if (!this.P.IsOpen)
            //    {
            //        this.P.Open();
            //    }
            //    if (this.P.IsOpen)
            //    {
            //        this.P.Handshake = Handshake.RequestToSend;
            //        this.P.DtrEnable = true;
            //        int num = 0;
            //        for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //        {
            //            try
            //            {
            //                string text = this.dataGridView1.Rows[i].Cells["Sdt"].Value.ToString().Trim();
            //                if (Convert.ToBoolean(this.dataGridView1.Rows[i].Cells["chon"].Value.ToString()) && text != "")
            //                {
            //                    if (text != "")
            //                    {
            //                        text = "+84" + text.Substring(1, text.Length - 1);
            //                    }
            //                    num++;
            //                    this.P.WriteLine("AT" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CSCS=\"Unicode\"" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine("AT+CMGS=\"" + text + "\"" + Environment.NewLine);
            //                    Thread.Sleep(100);
            //                    this.P.WriteLine(this.textBox1.Text);
            //                    Thread.Sleep(100);
            //                    this.P.Write(new byte[]
            //                    {
            //                        26
            //                    }, 0, 1);
            //                    Thread.Sleep(100);
            //                }
            //            }
            //            catch
            //            {
            //            }
            //        }
            //        MessageBox.Show("Gửi Thành Công " + num + " Tin Nhắn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.P.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("COM chưa mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //}
        }

        // Token: 0x06000750 RID: 1872 RVA: 0x0001B637 File Offset: 0x00019837
        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000751 RID: 1873 RVA: 0x0014232C File Offset: 0x0014052C
        private void button2_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        this.dataGridView1.Rows[i].Cells["chon"].Value = true;
            //    }
            //}
        }

        // Token: 0x06000752 RID: 1874 RVA: 0x0014239C File Offset: 0x0014059C
        private void button3_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dataGridView1.RowCount; i++)
            //    {
            //        this.dataGridView1.Rows[i].Cells["chon"].Value = false;
            //    }
            //}
        }

        // Token: 0x06000753 RID: 1875 RVA: 0x0001B637 File Offset: 0x00019837
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Token: 0x06000754 RID: 1876 RVA: 0x0014240C File Offset: 0x0014060C
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (this.dataGridView1.RowCount > 0)
            //{
            //    try
            //    {
            //        int columnIndex = this.dataGridView1.CurrentCell.ColumnIndex;
            //        if (this.dataGridView1.Columns[columnIndex].Name == "chon")
            //        {
            //            int index = this.dataGridView1.CurrentRow.Index;
            //            if (!Convert.ToBoolean(this.dataGridView1.Rows[index].Cells["chon"].Value))
            //            {
            //                this.dataGridView1.Rows[index].Cells["chon"].Value = "True";
            //                this.dataGridView1.Rows[index].Cells["chon"].Value = true;
            //            }
            //            else
            //            {
            //                this.dataGridView1.Rows[index].Cells["chon"].Value = "False";
            //                this.dataGridView1.Rows[index].Cells["chon"].Value = false;
            //            }
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x06000755 RID: 1877 RVA: 0x0014258C File Offset: 0x0014078C
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (!this.P.IsOpen)
            //    {
            //        this.P.Open();
            //    }
            //    if (this.P.IsOpen)
            //    {
            //        this.P.Handshake = Handshake.RequestToSend;
            //        this.P.DtrEnable = true;
            //        this.P.WriteLine("AT" + Environment.NewLine);
            //        Thread.Sleep(100);
            //        this.P.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //        Thread.Sleep(100);
            //        this.P.WriteLine("AT+CSCS=\"Unicode\"" + Environment.NewLine);
            //        Thread.Sleep(100);
            //        this.P.WriteLine("AT+CMGS=\"" + this.textBox2.Text + "\"" + Environment.NewLine);
            //        Thread.Sleep(100);
            //        this.P.WriteLine(this.textBox2.Text);
            //        Thread.Sleep(100);
            //        this.P.Write(new byte[]
            //        {
            //            26
            //        }, 0, 1);
            //        Thread.Sleep(100);
            //    }
            //    MessageBox.Show("Gửi Thành Công Tin Nhắn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.P.Close();
            //}
        }
    }
}
