using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PosManager.Forms.UI
{
    public partial class Frmnhomhang : Form
    {
        public static string manhom_chon = "";

        // Token: 0x04000C91 RID: 3217
      //  private HangHoaCtr hhCrt = new HangHoaCtr();

        // Token: 0x04000C92 RID: 3218
        public Frmnhomhang.GetData mahang;

        // Token: 0x04000C93 RID: 3219
        private string manhomhang = "";

        // Token: 0x02000090 RID: 144
        // (Invoke) Token: 0x06000A5D RID: 2653
        public delegate void GetData(string mahang, string tenhang);
        public Frmnhomhang()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.dgvnhom.Rows.Count > 0)
            //{
            //    int index = this.dgvnhom.CurrentRow.Index;
            //    string manhom_sua = this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString();
            //    string text = this.dgvnhom.Rows[index].Cells["tennhom"].Value.ToString();
            //    Frmnhomhang.manhom_chon = manhom_sua;
            //    try
            //    {
            //        if (frmHangHoa.chon_suanhom == 0)
            //        {
            //            this.mahang(manhom_sua, text);
            //        }
            //    }
            //    catch
            //    {
            //    }
            //    frmHangHoa.manhom_sua = manhom_sua;
            //    frmHangHoa.tennhom_sua = text;
            //}
            //else
            //{
            //    SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //    sqlConnection.Open();
            //    string cmdText = "INSERT INTO TB_NHOMHANG (MANHOM,TENNHOM,MAHOAHONG,HOAHONG) VALUES('NH',N'Nhóm Hàng','0','0')";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //    this.mahang("NH", "Nhóm hàng");
            //}
            //base.Close();
        }

        // Token: 0x06000A44 RID: 2628 RVA: 0x00199CF4 File Offset: 0x00197EF4
        private void Frmnhomhang_Load(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.hhCrt.GetData_nhomhang();
            //this.dgvnhom.DataSource = dataSource;
            //if (this.dgvnhom.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dgvnhom.RowCount; i++)
            //    {
            //        this.dgvnhom["XOA", i].Value = "X";
            //    }
            //}
            //this.txtsd.Text = this.dgvnhom.RowCount + " nhóm";
            //if (TrangChu.THEMHANG == "False")
            //{
            //    this.button2.Visible = false;
            //    this.txttennhom.Visible = false;
            //    this.txtmanhom.Visible = false;
            //}
            //this.comboBox1.SelectedIndex = 0;
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 997) / 2, -10, 977, Screen.PrimaryScreen.WorkingArea.Height + 20);
        }

        // Token: 0x06000A45 RID: 2629 RVA: 0x00199E20 File Offset: 0x00198020
        private void dgvnhom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvnhom.RowCount > 0)
            //{
            //    int index = this.dgvnhom.CurrentRow.Index;
            //    string manhom_sua = this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString();
            //    string text = this.dgvnhom.Rows[index].Cells["tennhom"].Value.ToString();
            //    Frmnhomhang.manhom_chon = manhom_sua;
            //    try
            //    {
            //        if (frmHangHoa.chon_suanhom == 0)
            //        {
            //            this.mahang(manhom_sua, text);
            //        }
            //    }
            //    catch
            //    {
            //    }
            //    frmHangHoa.tennhom_sua = text;
            //    frmHangHoa.manhom_sua = manhom_sua;
            //}
            //base.Close();
        }

        // Token: 0x06000A46 RID: 2630 RVA: 0x00199F00 File Offset: 0x00198100
        private void dgvnhom_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    int index = this.dgvnhom.CurrentRow.Index;
            //    string str = this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString();
            //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhóm  " + this.dgvnhom.Rows[index].Cells["tennhom"].Value.ToString() + "   không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = "delete TB_NHOMHANG where MANHOM='" + str + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.hhCrt.GetData_nhomhang();
            //        this.dgvnhom.DataSource = dataSource;
            //        if (this.dgvnhom.RowCount > 0)
            //        {
            //            for (int i = 0; i < this.dgvnhom.RowCount; i++)
            //            {
            //                this.dgvnhom["XOA", i].Value = "X";
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000A47 RID: 2631 RVA: 0x0019A078 File Offset: 0x00198278
        private void dgvnhom_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int columnIndex = this.dgvnhom.CurrentCell.ColumnIndex;
            //if (this.dgvnhom.Columns[columnIndex].Name == "Tennhom")
            //{
            //    int index = this.dgvnhom.CurrentRow.Index;
            //    if (this.dgvnhom.Rows[index].Cells["Tennhom"].Value.ToString() != "")
            //    {
            //        string text = this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString();
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "UPDATE TB_NHOMHANG SET TENNHOM=N'",
            //            this.dgvnhom.Rows[index].Cells["Tennhom"].Value.ToString(),
            //            "' where MANHOM='",
            //            text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("MÃ NHÓM KHÔNG THỂ SỬA", "THÔNG BÁO");
            //}
        }

        // Token: 0x06000A48 RID: 2632 RVA: 0x0019A1E4 File Offset: 0x001983E4
        private void mahanghoa()
        {
            //try
            //{
            //    string text = DateTime.Now.ToString("00");
            //    string selectCommandText = string.Concat(new string[]
            //    {
            //        "select top 1 isnull(MAX(manhom),'",
            //        text,
            //        "00000') from Tb_nhomhang where left(manhom,2)='",
            //        text,
            //        "' and len(manhom)='7' group by manhom having ISNUMERIC(manhom)=1 order by manhom desc"
            //    });
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //    {
            //        ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //    });
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    string text2;
            //    if (dataTable.Rows.Count <= 0)
            //    {
            //        text2 = text + "00001";
            //    }
            //    else
            //    {
            //        string a = Convert.ToString(dataTable.Rows[0][0].ToString().Substring(0, 2));
            //        text2 = text;
            //        if (a == text2)
            //        {
            //            double num = Convert.ToDouble(dataTable.Rows[0][0].ToString().Substring(2, 5));
            //            num += 1.0;
            //            if (num < 10.0)
            //            {
            //                text2 += "0000";
            //            }
            //            else if (num < 100.0)
            //            {
            //                text2 += "000";
            //            }
            //            else if (num < 1000.0)
            //            {
            //                text2 += "00";
            //            }
            //            else if (num < 10000.0)
            //            {
            //                text2 += "0";
            //            }
            //            text2 += num.ToString();
            //        }
            //        else
            //        {
            //            text2 = text + "00001";
            //        }
            //    }
            //    this.manhomhang = text2;
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000A49 RID: 2633 RVA: 0x0009B888 File Offset: 0x00099A88
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

        // Token: 0x06000A4A RID: 2634 RVA: 0x0019A3F8 File Offset: 0x001985F8
        private void button2_Click(object sender, EventArgs e)
        {
            //if (this.txttennhom.Text != this.txttennhom.Tag.ToString())
            //{
            //    try
            //    {
            //        if (this.txtmanhom.Text != this.txtmanhom.Tag.ToString())
            //        {
            //            this.manhomhang = this.NonUnicode(this.txtmanhom.Text.Replace(" ", ""));
            //        }
            //        else
            //        {
            //            this.mahanghoa();
            //        }
            //        if (this.txttennhom.Text != "")
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new object[]
            //            {
            //                "INSERT INTO TB_NHOMHANG (MANHOM,TENNHOM,MAHOAHONG,HOAHONG) VALUES('",
            //                this.manhomhang,
            //                "',N'",
            //                this.txttennhom.Text,
            //                "','",
            //                this.comboBox1.SelectedIndex,
            //                "','",
            //                double.Parse(this.textBox1.Text),
            //                "')"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            DataTable dataSource = new DataTable();
            //            dataSource = this.hhCrt.GetData_nhomhang();
            //            this.dgvnhom.DataSource = dataSource;
            //            if (this.dgvnhom.RowCount > 0)
            //            {
            //                for (int i = 0; i < this.dgvnhom.RowCount; i++)
            //                {
            //                    this.dgvnhom["XOA", i].Value = "X";
            //                    if (this.dgvnhom["manhom", i].Value.ToString() == this.manhomhang)
            //                    {
            //                        this.dgvnhom.ClearSelection();
            //                        this.dgvnhom.Rows[i].Selected = true;
            //                        this.dgvnhom.CurrentCell = this.dgvnhom.Rows[i].Cells["manhom"];
            //                    }
            //                }
            //            }
            //            this.txtsd.Text = this.dgvnhom.RowCount + " nhóm";
            //            this.txttennhom.Text = this.txttennhom.Tag.ToString();
            //            this.txtmanhom.Text = this.txtmanhom.Tag.ToString();
            //            this.txtmanhom.Focus();
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("BẠN KIỂM TRA LẠI MÃ NHÓM BỊ TRÙNG", "THÔNG BÁO");
            //    }
            //}
            //else
            //{
            //    this.txttennhom.Text = this.txttennhom.Tag.ToString();
            //    this.txtmanhom.Text = this.txtmanhom.Tag.ToString();
            //    this.txtmanhom.Focus();
            //}
        }

        // Token: 0x06000A4B RID: 2635 RVA: 0x0019A74C File Offset: 0x0019894C
        private void txtmanhom_Leave(object sender, EventArgs e)
        {
            if (this.txtmanhom.Text == "")
            {
                this.txtmanhom.Text = this.txtmanhom.Tag.ToString();
            }
        }

        // Token: 0x06000A4C RID: 2636 RVA: 0x0019A794 File Offset: 0x00198994
        private void txtmanhom_Enter(object sender, EventArgs e)
        {
            if (this.txtmanhom.Text == this.txtmanhom.Tag.ToString())
            {
                this.txtmanhom.Text = "";
            }
        }

        // Token: 0x06000A4D RID: 2637 RVA: 0x0019A7DC File Offset: 0x001989DC
        private void dgvnhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvnhom.RowCount > 0)
            //{
            //    int columnIndex = this.dgvnhom.CurrentCell.ColumnIndex;
            //    if (this.dgvnhom.Columns[columnIndex].Name == "manhom")
            //    {
            //        this.dgvnhom.ReadOnly = true;
            //    }
            //    else
            //    {
            //        this.dgvnhom.ReadOnly = false;
            //        if (this.dgvnhom.Columns[columnIndex].Name == "XOA")
            //        {
            //            if (TrangChu.XOAHANG == "True")
            //            {
            //                int index = this.dgvnhom.CurrentRow.Index;
            //                string str = this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString();
            //                SqlConnection sqlConnection = new SqlConnection();
            //                sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //                SqlCommand sqlCommand = new SqlCommand("select count(manhom) from tb_hanghoa where manhom='" + this.dgvnhom.Rows[index].Cells["manhom"].Value.ToString() + "'", sqlConnection);
            //                sqlConnection.Open();
            //                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //                if (sqlDataReader.Read())
            //                {
            //                    double num = Convert.ToDouble(Convert.ToString(sqlDataReader.GetValue(0)));
            //                    if (num > 0.0)
            //                    {
            //                        MessageBox.Show("XÓA TÊN HÀNG HÓA TRONG NHÓM TRƯỚC", "THÔNG BÁO");
            //                    }
            //                    else
            //                    {
            //                        sqlConnection.Close();
            //                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhóm  " + this.dgvnhom.Rows[index].Cells["tennhom"].Value.ToString() + "   không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //                        if (dialogResult == DialogResult.Yes)
            //                        {
            //                            string cmdText = "delete TB_NHOMHANG where MANHOM='" + str + "'";
            //                            SqlCommand sqlCommand2 = new SqlCommand(cmdText, sqlConnection);
            //                            sqlConnection.Open();
            //                            sqlCommand2.ExecuteNonQuery();
            //                            this.dgvnhom.Rows.RemoveAt(index);
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("BẠN KHÔNG ĐƯỢC QUYỀN XÓA", "THÔNG BÁO");
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x06000A4E RID: 2638 RVA: 0x0019AA60 File Offset: 0x00198C60
        private void txttennhom_Enter(object sender, EventArgs e)
        {
            if (this.txttennhom.Text == this.txttennhom.Tag.ToString())
            {
                this.txttennhom.Text = "";
            }
        }

        // Token: 0x06000A4F RID: 2639 RVA: 0x0019AAA8 File Offset: 0x00198CA8
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == this.txttimkiem.Tag.ToString())
            {
                this.txttimkiem.Text = "";
            }
        }

        // Token: 0x06000A50 RID: 2640 RVA: 0x0019AAF0 File Offset: 0x00198CF0
        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text == "")
            {
                this.txttimkiem.Text = this.txttimkiem.Tag.ToString();
            }
        }

        // Token: 0x06000A51 RID: 2641 RVA: 0x0019AB38 File Offset: 0x00198D38
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (this.txttimkiem.Text != this.txttimkiem.Tag.ToString())
            {
                if (this.txttimkiem.Text != "")
                {
                    DataTable dataSource = new DataTable();
                   // dataSource = this.hhCrt.GetData_nhomhang_tim(this.txttimkiem.Text);
                    this.dgvnhom.DataSource = dataSource;
                    if (this.dgvnhom.RowCount > 0)
                    {
                        for (int i = 0; i < this.dgvnhom.RowCount; i++)
                        {
                            this.dgvnhom["XOA", i].Value = "X";
                        }
                    }
                }
            }
        }

        // Token: 0x06000A52 RID: 2642 RVA: 0x0019AC0C File Offset: 0x00198E0C
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.txttimkiem.Text == "")
            {
                this.Frmnhomhang_Load(null, null);
            }
        }

        // Token: 0x06000A53 RID: 2643 RVA: 0x0019AC50 File Offset: 0x00198E50
        private void txttennhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button2_Click(null, null);
            }
        }

        // Token: 0x06000A54 RID: 2644 RVA: 0x0001B637 File Offset: 0x00019837
        private void txtmanhom_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000A55 RID: 2645 RVA: 0x0019AC78 File Offset: 0x00198E78
        private void txtmanhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txttennhom.Focus();
            }
        }

        // Token: 0x06000A56 RID: 2646 RVA: 0x0001DA13 File Offset: 0x0001BC13
        private void Frmnhomhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.button1_Click(null, null);
        }

        // Token: 0x06000A57 RID: 2647 RVA: 0x0019ACA4 File Offset: 0x00198EA4
        private void btnhapexcel_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //this.openFileDialog1.FileName = "";
            //this.openFileDialog1.ShowDialog();
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //if (!File.Exists(this.openFileDialog1.FileName))
            //{
            //    try
            //    {
            //        new Process
            //        {
            //            StartInfo =
            //            {
            //                FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\NHOMHANG.xlsx"
            //            }
            //        }.Start();
            //        return;
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Không mở được file Mẫu");
            //    }
            //}
            //else
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa HẾT nhóm không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        string cmdText = "DELETE TB_NHOMHANG  WHERE MANHOM!='HH'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlConnection.Close();
            //    }
            //}
            //string connectionString = string.Empty;
            //connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.openFileDialog1.FileName + ";Extended Properties = Excel 12.0";
            //OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            //oleDbConnection.Open();
            //try
            //{
            //    OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDbConnection);
            //    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            //    oleDbDataAdapter.SelectCommand = selectCommand;
            //    DataTable dataTable = new DataTable();
            //    oleDbDataAdapter.Fill(dataTable);
            //    for (int i = 0; i < dataTable.Rows.Count; i++)
            //    {
            //        if (dataTable.Rows[i]["MANHOM"].ToString() != "")
            //        {
            //            if (sqlConnection.State == ConnectionState.Closed)
            //            {
            //                sqlConnection.Open();
            //            }
            //            string cmdText2 = string.Concat(new object[]
            //            {
            //                "INSERT INTO TB_NHOMHANG (MANHOM,TENNHOM,MAHOAHONG,HOAHONG) VALUES(N'",
            //                dataTable.Rows[i]["MANHOM"].ToString(),
            //                "',N'",
            //                dataTable.Rows[i]["TENNHOM"].ToString(),
            //                "','",
            //                dataTable.Rows[i]["MAHOAHONG"].ToString(),
            //                "','",
            //                double.Parse(dataTable.Rows[i]["HOAHONG"].ToString()),
            //                "')"
            //            });
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //            sqlCommand2.ExecuteNonQuery();
            //            sqlConnection.Close();
            //        }
            //    }
            //    MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO");
            //}
            //catch
            //{
            //    MessageBox.Show("KHÔNG NHẬP ĐƯỢC DỮ LIỆU");
            //}
            //finally
            //{
            //    oleDbConnection.Close();
            //}
            //DataTable dataSource = new DataTable();
            //dataSource = this.hhCrt.GetData_nhomhang();
            //this.dgvnhom.DataSource = dataSource;
            //if (this.dgvnhom.RowCount > 0)
            //{
            //    for (int i = 0; i < this.dgvnhom.RowCount; i++)
            //    {
            //        this.dgvnhom["XOA", i].Value = "X";
            //        if (this.dgvnhom["manhom", i].Value.ToString() == this.txtmanhom.Text)
            //        {
            //            this.dgvnhom.ClearSelection();
            //            this.dgvnhom.Rows[i].Selected = true;
            //            this.dgvnhom.CurrentCell = this.dgvnhom.Rows[i].Cells["manhom"];
            //        }
            //    }
            //}
        }

        // Token: 0x06000A58 RID: 2648 RVA: 0x0019B0E4 File Offset: 0x001992E4
        private void txttennhom_Leave(object sender, EventArgs e)
        {
            if (this.txttennhom.Text == "")
            {
                if (this.txtmanhom.Text != this.txtmanhom.Tag.ToString())
                {
                    this.txttennhom.Text = this.txtmanhom.Text;
                }
                else
                {
                    this.txttennhom.Text = this.txttennhom.Tag.ToString();
                }
            }
        }

        // Token: 0x06000A59 RID: 2649 RVA: 0x0019B16C File Offset: 0x0019936C
        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.button3.Enabled = false;
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT * FROM TB_NHOMHANG";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //        Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\NHOMHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //        if (Frmnhomhang.< button3_Click > o__SiteContainer0.<> p__Site1 == null)
            //        {
            //            Frmnhomhang.< button3_Click > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmnhomhang)));
            //        }
            //        Worksheet worksheet = Frmnhomhang.< button3_Click > o__SiteContainer0.<> p__Site1.Target(Frmnhomhang.< button3_Click > o__SiteContainer0.<> p__Site1, application.ActiveSheet);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < dataTable.Columns.Count; j++)
            //            {
            //                worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
            //            }
            //        }
            //        application.Visible = true;
            //    }
            //    else
            //    {
            //        new Process
            //        {
            //            StartInfo =
            //            {
            //                FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\NHOMHANG.xlsx"
            //            }
            //        }.Start();
            //    }
            //}
            //catch
            //{
            //    new Process
            //    {
            //        StartInfo =
            //        {
            //            FileName = System.Windows.Forms.Application.StartupPath + "\\EXCEL\\NHOMHANG.xlsx"
            //        }
            //    }.Start();
            //}
            //this.button3.Enabled = true;
        }

        // Token: 0x06000A5A RID: 2650 RVA: 0x0019B3CC File Offset: 0x001995CC
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvnhom.RowCount > 0)
            //{
            //    string text = "False";
            //    if (this.checkBox1.Checked)
            //    {
            //        text = "True";
            //    }
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //    {
            //        "UPDATE TB_HANGHOA SET TONDONVI='",
            //        text,
            //        "' WHERE MANHOM='",
            //        this.dgvnhom.Rows[this.dgvnhom.CurrentRow.Index].Cells["manhom"].Value.ToString(),
            //        "'"
            //    }), sqlConnection);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
        }
    }
}
