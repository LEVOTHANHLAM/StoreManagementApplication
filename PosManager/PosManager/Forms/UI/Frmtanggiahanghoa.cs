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
    public partial class Frmtanggiahanghoa : Form
    {
        public Frmtanggiahanghoa()
        {
            InitializeComponent();
        }
        private void LOADNHOMHANG()
        {
            try
            {
                //DataTable dataTable = new DataTable();
                //string cmdText = "SELECT * FROM TB_NHOMHANG";
                //SqlConnection sqlConnection = new SqlConnection();
                //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
                //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
                //sqlConnection.Open();
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                //sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    this.cobnhom.DataSource = dataTable;
                //    this.cobnhom.DisplayMember = "TENNHOM";
                //    this.cobnhom.ValueMember = "MANHOM";
                //    this.cobnhom.SelectedIndex = -1;
                //}
            }
            catch
            {
            }
        }

        // Token: 0x06000D33 RID: 3379 RVA: 0x001D1678 File Offset: 0x001CF878
        private void Frmtanggiahanghoa_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            base.SetBounds(-10, 0, Screen.PrimaryScreen.WorkingArea.Width + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            this.LOADNHOMHANG();
            DataTable dataSource = new DataTable();
          //  dataSource = this.hhCrt.GetData();
            this.dgvhanghoa.DataSource = dataSource;
            this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
        }

        // Token: 0x06000D34 RID: 3380 RVA: 0x001D170C File Offset: 0x001CF90C
        private void cobnhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cobnhom.Text != "")
            {
                DataTable dataSource = new DataTable();
           //     dataSource = this.hhCrt.GetData_MANHOM(this.cobnhom.SelectedValue.ToString());
                this.dgvhanghoa.DataSource = dataSource;
                this.txtsodong.Text = this.dgvhanghoa.RowCount.ToString();
                if (this.dgvhanghoa.RowCount > 0)
                {
                    for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
                    {
                        this.dgvhanghoa.Rows[i].Cells[0].Value = true;
                    }
                }
            }
        }

        // Token: 0x06000D35 RID: 3381 RVA: 0x001D17E4 File Offset: 0x001CF9E4
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.dgvhanghoa.RowCount > 0)
            //    {
            //        if (this.txtgia.Text != "0")
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            if (this.rbtangnhom.Checked)
            //            {
            //                if (this.cobnhom.Text != "")
            //                {
            //                    if (this.checkBox9.Checked)
            //                    {
            //                        for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            //                        {
            //                            try
            //                            {
            //                                if (Convert.ToBoolean(this.dgvhanghoa.Rows[i].Cells[0].Value.ToString()))
            //                                {
            //                                    string text = "";
            //                                    string text2 = "";
            //                                    string text3 = "";
            //                                    string text4 = "";
            //                                    string text5 = "";
            //                                    string text6 = "";
            //                                    string text7 = "";
            //                                    string text8 = "";
            //                                    if (this.checkBox1.Checked)
            //                                    {
            //                                        text2 = string.Concat(new object[]
            //                                        {
            //                                            "DONGIA= ",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox2.Checked)
            //                                    {
            //                                        text3 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            " DONGIA2=",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox3.Checked)
            //                                    {
            //                                        text4 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            "DONGIA3=",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox4.Checked)
            //                                    {
            //                                        text5 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            "DONGIA4= ",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox5.Checked)
            //                                    {
            //                                        text6 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            "DONGIA5= ",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox6.Checked)
            //                                    {
            //                                        text7 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            "DONGIA6= ",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                    }
            //                                    if (this.checkBox10.Checked)
            //                                    {
            //                                        if (text7 != "")
            //                                        {
            //                                            text = ",";
            //                                        }
            //                                        text8 = string.Concat(new object[]
            //                                        {
            //                                            text,
            //                                            "GIANHAP= ",
            //                                            this.comboBox1.Text,
            //                                            "+",
            //                                            this.comboBox1.Text,
            //                                            "*",
            //                                            double.Parse(this.txtgia.Text) / 100.0,
            //                                            " "
            //                                        });
            //                                    }
            //                                    string cmdText = string.Concat(new string[]
            //                                    {
            //                                        "UPDATE TB_HANGHOA SET ",
            //                                        text2,
            //                                        text3,
            //                                        text4,
            //                                        text5,
            //                                        text6,
            //                                        " ",
            //                                        text7,
            //                                        " ",
            //                                        text8,
            //                                        " WHERE MAHANGHOA ='",
            //                                        this.dgvhanghoa.Rows[i].Cells["MAHANGHOA"].Value.ToString(),
            //                                        "'"
            //                                    });
            //                                    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                                    sqlCommand.ExecuteNonQuery();
            //                                }
            //                            }
            //                            catch
            //                            {
            //                                MessageBox.Show("THAY ĐỔI GIÁ BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //                            }
            //                        }
            //                        MessageBox.Show("THAY ĐỔI GIÁ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                    }
            //                    else if (this.checkBox8.Checked)
            //                    {
            //                        for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            //                        {
            //                            try
            //                            {
            //                                if (Convert.ToBoolean(this.dgvhanghoa.Rows[i].Cells[0].Value.ToString()))
            //                                {
            //                                    string text = "";
            //                                    string text2 = "";
            //                                    string text3 = "";
            //                                    string text4 = "";
            //                                    string text5 = "";
            //                                    string text6 = "";
            //                                    string text7 = "";
            //                                    if (this.checkBox1.Checked)
            //                                    {
            //                                        text2 = "DONGIA= DONGIA + DONGIA *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox2.Checked)
            //                                    {
            //                                        text3 = text + " DONGIA2= DONGIA2 + DONGIA2 *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox3.Checked)
            //                                    {
            //                                        text4 = text + "DONGIA3= DONGIA3 + DONGIA3 *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox4.Checked)
            //                                    {
            //                                        text5 = text + "DONGIA4= DONGIA4 + DONGIA4 *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox5.Checked)
            //                                    {
            //                                        text6 = text + "DONGIA5= DONGIA5 + DONGIA5 *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                        text = ",";
            //                                    }
            //                                    if (this.checkBox6.Checked)
            //                                    {
            //                                        text7 = text + " DONGIA6= DONGIA6 + DONGIA6 *" + double.Parse(this.txtgia.Text) / 100.0;
            //                                    }
            //                                    string cmdText = string.Concat(new string[]
            //                                    {
            //                                        "UPDATE TB_HANGHOA SET ",
            //                                        text2,
            //                                        text3,
            //                                        text4,
            //                                        text5,
            //                                        text6,
            //                                        text7,
            //                                        " WHERE MAHANGHOA ='",
            //                                        this.dgvhanghoa.Rows[i].Cells["MAHANGHOA"].Value.ToString(),
            //                                        "'"
            //                                    });
            //                                    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                                    sqlCommand.ExecuteNonQuery();
            //                                }
            //                            }
            //                            catch
            //                            {
            //                                MessageBox.Show("THAY ĐỔI GIÁ BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //                            }
            //                        }
            //                        MessageBox.Show("THAY ĐỔI GIÁ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                    }
            //                    else if (!this.checkBox7.Checked)
            //                    {
            //                        for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            //                        {
            //                            try
            //                            {
            //                                if (Convert.ToBoolean(this.dgvhanghoa.Rows[i].Cells[0].Value.ToString()))
            //                                {
            //                                    string text2 = "";
            //                                    string text3 = "";
            //                                    string text4 = "";
            //                                    string text5 = "";
            //                                    string text6 = "";
            //                                    string text7 = "";
            //                                    if (this.checkBox1.Checked)
            //                                    {
            //                                        text2 = "DONGIA=DONGIA+" + float.Parse(this.txtgia.Text);
            //                                    }
            //                                    if (this.checkBox2.Checked)
            //                                    {
            //                                        if (text2 != "")
            //                                        {
            //                                            text3 = ",DONGIA2=DONGIA2+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text3 = "DONGIA2=DONGIA2+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    if (this.checkBox3.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "")
            //                                        {
            //                                            text4 = ",DONGIA3=DONGIA3+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text4 = "DONGIA3=DONGIA3+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    if (this.checkBox4.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "")
            //                                        {
            //                                            text5 = ",DONGIA4=DONGIA4+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text5 = "DONGIA4=DONGIA4+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    if (this.checkBox5.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "" || text5 != "")
            //                                        {
            //                                            text6 = ",DONGIA5=DONGIA5+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text6 = "DONGIA5=DONGIA5+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    if (this.checkBox6.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "" || text5 != "" || text6 != "")
            //                                        {
            //                                            text7 = ",DONGIA6=DONGIA6+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text7 = "DONGIA6=DONGIA6+" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    string cmdText = string.Concat(new string[]
            //                                    {
            //                                        "UPDATE TB_HANGHOA SET ",
            //                                        text2,
            //                                        text3,
            //                                        text4,
            //                                        text5,
            //                                        text6,
            //                                        text7,
            //                                        " WHERE MAHANGHOA ='",
            //                                        this.dgvhanghoa.Rows[i].Cells["MAHANGHOA"].Value.ToString(),
            //                                        "'"
            //                                    });
            //                                    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                                    sqlCommand.ExecuteNonQuery();
            //                                }
            //                            }
            //                            catch
            //                            {
            //                                MessageBox.Show("THAY ĐỔI GIÁ BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //                            }
            //                        }
            //                        MessageBox.Show("THAY ĐỔI GIÁ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                    }
            //                    else
            //                    {
            //                        for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            //                        {
            //                            try
            //                            {
            //                                if (Convert.ToBoolean(this.dgvhanghoa.Rows[i].Cells[0].Value.ToString()))
            //                                {
            //                                    string text2 = "";
            //                                    string text3 = "";
            //                                    string text4 = "";
            //                                    string text5 = "";
            //                                    string text6 = "";
            //                                    string text7 = "";
            //                                    if (this.checkBox1.Checked)
            //                                    {
            //                                        text2 = "DONGIA=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                    }
            //                                    if (this.checkBox2.Checked)
            //                                    {
            //                                        if (text2 != "")
            //                                        {
            //                                            text3 = ",DONGIA2=" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                        else
            //                                        {
            //                                            text3 = "DONGIA2=" + float.Parse(this.txtgia.Text);
            //                                        }
            //                                    }
            //                                    if (this.checkBox3.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "")
            //                                        {
            //                                            text4 = ",DONGIA3=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                        else
            //                                        {
            //                                            text4 = "DONGIA3=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                    }
            //                                    if (this.checkBox4.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "")
            //                                        {
            //                                            text5 = ",DONGIA4=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                        else
            //                                        {
            //                                            text5 = "DONGIA4=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                    }
            //                                    if (this.checkBox5.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "" || text5 != "")
            //                                        {
            //                                            text6 = ",DONGIA5=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                        else
            //                                        {
            //                                            text6 = "DONGIA5=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                    }
            //                                    if (this.checkBox6.Checked)
            //                                    {
            //                                        if (text2 != "" || text3 != "" || text4 != "" || text5 != "" || text6 != "")
            //                                        {
            //                                            text7 = ",DONGIA6=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                        else
            //                                        {
            //                                            text7 = "DONGIA6=ROUND(QUYDOI1*" + float.Parse(this.txtgia.Text) + "+0,0)";
            //                                        }
            //                                    }
            //                                    string cmdText = string.Concat(new string[]
            //                                    {
            //                                        "UPDATE TB_HANGHOA SET ",
            //                                        text2,
            //                                        text3,
            //                                        text4,
            //                                        text5,
            //                                        text6,
            //                                        text7,
            //                                        " WHERE MAHANGHOA ='",
            //                                        this.dgvhanghoa.Rows[i].Cells["MAHANGHOA"].Value.ToString(),
            //                                        "'"
            //                                    });
            //                                    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                                    sqlCommand.ExecuteNonQuery();
            //                                }
            //                            }
            //                            catch
            //                            {
            //                                MessageBox.Show("THAY ĐỔI GIÁ BỊ LỖI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //                            }
            //                        }
            //                        MessageBox.Show("THAY ĐỔI GIÁ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("CHỌN NHÓM MUỐN THAY ĐỔI GIÁ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //                }
            //            }
            //            else
            //            {
            //                string text2 = "";
            //                string text3 = "";
            //                string text4 = "";
            //                string text5 = "";
            //                string text6 = "";
            //                string text7 = "";
            //                if (this.checkBox1.Checked)
            //                {
            //                    text2 = "DONGIA=DONGIA+" + float.Parse(this.txtgia.Text);
            //                }
            //                if (this.checkBox2.Checked)
            //                {
            //                    if (text2 != "")
            //                    {
            //                        text3 = ",DONGIA2=DONGIA2+" + float.Parse(this.txtgia.Text);
            //                    }
            //                    else
            //                    {
            //                        text3 = "DONGIA2=DONGIA2+" + float.Parse(this.txtgia.Text);
            //                    }
            //                }
            //                if (this.checkBox3.Checked)
            //                {
            //                    if (text2 != "" || text3 != "")
            //                    {
            //                        text4 = ",DONGIA3=DONGIA3+" + float.Parse(this.txtgia.Text);
            //                    }
            //                    else
            //                    {
            //                        text4 = "DONGIA3=DONGIA3+" + float.Parse(this.txtgia.Text);
            //                    }
            //                }
            //                if (this.checkBox4.Checked)
            //                {
            //                    if (text2 != "" || text3 != "" || text4 != "")
            //                    {
            //                        text5 = ",DONGIA4=DONGIA4+" + float.Parse(this.txtgia.Text);
            //                    }
            //                    else
            //                    {
            //                        text5 = "DONGIA4=DONGIA4+" + float.Parse(this.txtgia.Text);
            //                    }
            //                }
            //                if (this.checkBox5.Checked)
            //                {
            //                    if (text2 != "" || text3 != "" || text4 != "" || text5 != "")
            //                    {
            //                        text6 = ",DONGIA5=DONGIA5+" + float.Parse(this.txtgia.Text);
            //                    }
            //                    else
            //                    {
            //                        text6 = "DONGIA5=DONGIA5+" + float.Parse(this.txtgia.Text);
            //                    }
            //                }
            //                if (this.checkBox6.Checked)
            //                {
            //                    if (text2 != "" || text3 != "" || text4 != "" || text5 != "" || text6 != "")
            //                    {
            //                        text7 = ",DONGIA6=DONGIA6+" + float.Parse(this.txtgia.Text);
            //                    }
            //                    else
            //                    {
            //                        text7 = "DONGIA6=DONGIA6+" + float.Parse(this.txtgia.Text);
            //                    }
            //                }
            //                string cmdText = string.Concat(new string[]
            //                {
            //                    "UPDATE TB_HANGHOA SET ",
            //                    text2,
            //                    text3,
            //                    text4,
            //                    text5,
            //                    text6,
            //                    text7
            //                });
            //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //                sqlCommand.ExecuteNonQuery();
            //                MessageBox.Show("THAY ĐỔI GIÁ THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            }
            //            this.cobnhom_SelectedIndexChanged(null, null);
            //        }
            //        else
            //        {
            //            MessageBox.Show("CHƯA NHẬP SỐ TIỀN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //            this.txtgia.Focus();
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("VUI LÒNG KIỂM TRA LẠI THÔNG TIN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
        }

        // Token: 0x06000D36 RID: 3382 RVA: 0x001D2E80 File Offset: 0x001D1080
        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(this.txtgia.Text);
                if (num > 999.0)
                {
                    this.txtgia.Text = num.ToString("#,###");
                }
                this.txtgia.SelectionStart = this.txtgia.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x06000D37 RID: 3383 RVA: 0x001D2EFC File Offset: 0x001D10FC
        private void txtgia_Leave(object sender, EventArgs e)
        {
            if (this.txtgia.Text == "")
            {
                this.txtgia.Text = "0";
            }
        }

        // Token: 0x06000D38 RID: 3384 RVA: 0x0001E58E File Offset: 0x0001C78E
        private void checkBox8_MouseClick(object sender, MouseEventArgs e)
        {
            this.checkBox7.Checked = false;
            this.checkBox9.Checked = false;
        }

        // Token: 0x06000D39 RID: 3385 RVA: 0x0001E5AB File Offset: 0x0001C7AB
        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
        }

        // Token: 0x06000D3A RID: 3386 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
        private void checkBox9_MouseClick(object sender, MouseEventArgs e)
        {
            this.checkBox8.Checked = false;
            this.checkBox7.Checked = false;
        }

        // Token: 0x06000D3B RID: 3387 RVA: 0x001D2F38 File Offset: 0x001D1138
        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string currencyDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char c = Convert.ToChar(currencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(currencyDecimalSeparator) || this.txtgia.Text.IndexOf(currencyDecimalSeparator) != -1)
                {
                    if (e.KeyChar != Convert.ToChar("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        // Token: 0x04000F68 RID: 3944
      //  private HangHoaCtr hhCrt = new HangHoaCtr();
    }
}
