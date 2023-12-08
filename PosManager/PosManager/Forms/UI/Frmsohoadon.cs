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
    public partial class Frmsohoadon : Form
    {
        public Frmsohoadon()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.txtshdtu.Text != "")
            //{
            //    DialogResult dialogResult = MessageBox.Show("THÊM SỐ HÓA ĐƠN TỪ " + this.txtshdtu.Text + " ĐẾN " + this.txtshdden.Text, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        for (int i = int.Parse(this.txtshdtu.Text); i <= int.Parse(this.txtshdden.Text); i++)
            //        {
            //            string text = "";
            //            if (i < 10)
            //            {
            //                text = "000000" + i.ToString();
            //            }
            //            else if (i < 100)
            //            {
            //                text = "00000" + i.ToString();
            //            }
            //            else if (i < 1000)
            //            {
            //                text = "0000" + i.ToString();
            //            }
            //            else if (i < 10000)
            //            {
            //                text = "000" + i.ToString();
            //            }
            //            else if (i < 100000)
            //            {
            //                text = "00" + i.ToString();
            //            }
            //            else if (i < 1000000)
            //            {
            //                text = "0" + i.ToString();
            //            }
            //            else if (i < 10000000)
            //            {
            //                text = i.ToString();
            //            }
            //            this.thdObj.Sohoadon = text;
            //            this.thdObj.Daxuat = "False";
            //            this.thdObj.Ngayhuy = "";
            //            this.thdObj.Huy = "False";
            //            this.thdObj.Ngayhuy = "";
            //            this.xhdCtr.ADD_SOHOADON(this.thdObj);
            //        }
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.xhdCtr.GET_SOHOADON();
            //        this.dgvsohoadon.DataSource = dataSource;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("NHẬP SỐ HÓA ĐƠN VÀO Ô");
            //}
        }

        // Token: 0x06000A2B RID: 2603 RVA: 0x0019734C File Offset: 0x0019554C
        private void Frmsohoadon_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataSource = new DataTable();
               // dataSource = this.xhdCtr.GET_SOHOADON();
                this.dgvsohoadon.DataSource = dataSource;
            }
            catch
            {
            }
        }

        // Token: 0x06000A2C RID: 2604 RVA: 0x00197394 File Offset: 0x00195594
        private void dgvsohoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvsohoadon.RowCount; i++)
            {
                this.dgvsohoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000A2D RID: 2605 RVA: 0x001973E8 File Offset: 0x001955E8
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON();
            //this.dgvsohoadon.DataSource = dataSource;
        }

        // Token: 0x06000A2E RID: 2606 RVA: 0x00197418 File Offset: 0x00195618
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON_DAXUAT();
            //this.dgvsohoadon.DataSource = dataSource;
        }

        // Token: 0x06000A2F RID: 2607 RVA: 0x00197448 File Offset: 0x00195648
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON_CHUAXUAT();
            //this.dgvsohoadon.DataSource = dataSource;
        }

        // Token: 0x06000A30 RID: 2608 RVA: 0x00197478 File Offset: 0x00195678
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON_HUY();
            //this.dgvsohoadon.DataSource = dataSource;
        }

        // Token: 0x06000A31 RID: 2609 RVA: 0x0001D9B7 File Offset: 0x0001BBB7
        private void txttim_MouseDown(object sender, MouseEventArgs e)
        {
            this.txttim.Text = "";
        }

        // Token: 0x06000A32 RID: 2610 RVA: 0x001974A8 File Offset: 0x001956A8
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON_TIM(this.txttim.Text);
            //this.dgvsohoadon.DataSource = dataSource;
        }

        // Token: 0x06000A33 RID: 2611 RVA: 0x001974E0 File Offset: 0x001956E0
        private void button2_Click(object sender, EventArgs e)
        {
            //int index = this.dgvsohoadon.CurrentRow.Index;
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //string cmdText = string.Concat(new object[]
            //{
            //    "Update tb_hoadon set huy='True', Ngayhuy='",
            //    DateTime.Now.ToString("dd/MM/yyyy"),
            //    "' WHERE SOHOADON='",
            //    this.dgvsohoadon["SOHOADON", index].Value,
            //    "' and Daxuat='True'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //DataTable dataSource = new DataTable();
            //dataSource = this.xhdCtr.GET_SOHOADON_HUY();
            //this.dgvsohoadon.DataSource = dataSource;
        }


        // Token: 0x06000A35 RID: 2613 RVA: 0x001975E0 File Offset: 0x001957E0


        // Token: 0x04000C5D RID: 3165
      //  private ThemhoadonObj thdObj = new ThemhoadonObj();

        // Token: 0x04000C5E RID: 3166
      //  private XuathoadonCtr xhdCtr = new XuathoadonCtr();

    }
}
