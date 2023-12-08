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
    public partial class Frmbaosinhnhat : Form
    {
        public Frmbaosinhnhat()
        {
            InitializeComponent();
        }
        private void load_sinhnhat()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = string.Concat(new string[]
            //    {
            //        "select KH.MAKHACHHANG,TENKHACHHANG,TENDONVI,Namsinh,ISNULL(SDT,'')AS SDT,Diachi,Email,kh.Ghichu,isnull(SUM(DIEMCONG),0)+ isnull(SUM(DIEM),0) - isnull(SUM(DIEMTRU),0) as DIEM from Tb_KHACHHANG KH LEFT JOIN TB_DIEMKM D ON D.MAKHACHHANG=KH.MAKHACHHANG WHERE DAY(CONVERT(DATETIME,NAMSINH,103))>='",
            //        Convert.ToDateTime(this.dateTimePicker1.Text).ToString("dd"),
            //        "' AND DAY(CONVERT(DATETIME,NAMSINH,103))<='",
            //        Convert.ToDateTime(this.dateTimePicker2.Text).ToString("dd"),
            //        "' AND MONTH(CONVERT(DATETIME,NAMSINH,103))='",
            //        Convert.ToDateTime(this.dateTimePicker2.Text).ToString("MM"),
            //        "' AND NAMSINH!='  /  /' AND NAMSINH!='01/01/1900' GROUP BY KH.MAKHACHHANG,TENKHACHHANG,TENDONVI,Namsinh,ISNULL(SDT,''),Diachi,Email,kh.Ghichu ORDER BY DAY(CONVERT(DATETIME,NAMSINH,103))"
            //    });
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvkhachhang.DataSource = dataTable;
            //    for (int i = 0; i < this.dgvkhachhang.RowCount; i++)
            //    {
            //        this.dgvkhachhang.Rows[i].Cells["chon"].Value = true;
            //    }
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060002CF RID: 719 RVA: 0x0009B6E8 File Offset: 0x000998E8
        private void Frmbaosinhnhat_Load(object sender, EventArgs e)
        {
            //base.SetBounds(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + 10);
            //this.dateTimePicker2.Text = Convert.ToDateTime(this.dateTimePicker2.Text).AddDays((double)Frmbaosinhnhat.songay).ToString();
            //if (TrangChu.guimai == "True")
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand("SELECT NOIDUNG FROM TB_NOIDUNGTINNHAN WHERE ID='2'", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        this.txtnd.Text = sqlDataReader.GetString(0);
            //    }
            //    sqlConnection.Close();
            //    if (this.P.IsOpen)
            //    {
            //        this.P.Close();
            //    }
            //    else
            //    {
            //        try
            //        {
            //            //this.P.PortName = Settings.Default.PortName;
            //            //this.P.Parity = Parity.None;
            //            //this.P.BaudRate = 9600;
            //            //this.P.DataBits = 8;
            //            //this.P.StopBits = StopBits.One;
            //            //this.P.Open();
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Không thể mở cổng COM", "Lỗi", MessageBoxButtons.OK);
            //        }
            //    }
            //}
        }

        // Token: 0x060002D0 RID: 720 RVA: 0x0001BF46 File Offset: 0x0001A146
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.load_sinhnhat();
        }

        // Token: 0x060002D1 RID: 721 RVA: 0x0001BF46 File Offset: 0x0001A146
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.load_sinhnhat();
        }

        // Token: 0x060002D2 RID: 722 RVA: 0x0009B888 File Offset: 0x00099A88
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

        // Token: 0x060002D3 RID: 723 RVA: 0x0009BE1C File Offset: 0x0009A01C
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!this.P.IsOpen)
            //    {
            //        this.P.Open();
            //    }
            //    if (this.P.IsOpen)
            //    {
            //        this.P.Handshake = Handshake.RequestToSend;
            //        this.P.DtrEnable = true;
            //        try
            //        {
            //            for (int i = 0; i < this.dgvkhachhang.RowCount; i++)
            //            {
            //                if (this.dgvkhachhang.Rows[i].Cells["SDT"].Value.ToString() != "")
            //                {
            //                    if (Convert.ToBoolean(this.dgvkhachhang.Rows[i].Cells["chon"].Value.ToString()))
            //                    {
            //                        string str = "+84" + this.dgvkhachhang.Rows[i].Cells["SDT"].Value.ToString().Substring(1, this.dgvkhachhang.Rows[i].Cells["SDT"].Value.ToString().Trim().Length - 1);
            //                        this.P.WriteLine("AT" + Environment.NewLine);
            //                        Thread.Sleep(100);
            //                        this.P.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //                        Thread.Sleep(100);
            //                        this.P.WriteLine("AT+CSCS=\"Unicode\"" + Environment.NewLine);
            //                        Thread.Sleep(100);
            //                        this.P.WriteLine("AT+CMGS=\"" + str + "\"" + Environment.NewLine);
            //                        Thread.Sleep(100);
            //                        this.P.WriteLine(this.txtnd.Text.Trim());
            //                        Thread.Sleep(100);
            //                        this.P.Write(new byte[]
            //                        {
            //                            26
            //                        }, 0, 1);
            //                        Thread.Sleep(100);
            //                    }
            //                }
            //            }
            //        }
            //        catch
            //        {
            //        }
            //       // this.P.Close();
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x060002D4 RID: 724 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
        private void Frmbaosinhnhat_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (this.P.IsOpen)
            //{
            //    this.P.Close();
            //}
        }

        // Token: 0x060002D5 RID: 725 RVA: 0x0009C0E4 File Offset: 0x0009A2E4
        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand("update TB_NOIDUNGTINNHAN set NOIDUNG='" + this.txtnd.Text.Trim() + "' WHERE ID='2'", sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //sqlConnection.Close();
        }

        // Token: 0x060002D6 RID: 726 RVA: 0x0009C14C File Offset: 0x0009A34C
        private void dgvkhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            int columnIndex = this.dgvkhachhang.CurrentCell.ColumnIndex;
            if (this.dgvkhachhang.Columns[columnIndex].Name == "chon")
            {
                this.dgvkhachhang.ReadOnly = false;
            }
            else
            {
                this.dgvkhachhang.ReadOnly = true;
            }
        }
    }
}
