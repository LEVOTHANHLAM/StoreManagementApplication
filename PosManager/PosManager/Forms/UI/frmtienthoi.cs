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
    public partial class frmtienthoi : Form
    {
        public frmtienthoi()
        {
            InitializeComponent();
        }
        private void frmtienthoi_Load(object sender, EventArgs e)
        {
            try
            {
                frmtienthoi.tennhanvienbanhang = "";
                this.txtkhachdua.Focus();
                //if (TrangChu.chonnhanvien_thanhtoan == "True")
                //{
                //    base.Height = 593;
                //    this.txtmanv.Focus();
                //}
                //this.txttt.Text = frmtienthoi.tieude;
                //this.txtphaitra.Text = frmtienthoi.thanhtoan;
                //this.txtkhachdua.Text = frmtienthoi.Khachdua;
            }
            catch
            {
            }
        }

        // Token: 0x06000226 RID: 550 RVA: 0x00088C28 File Offset: 0x00086E28
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.txtkhachdua.Text = this.txtkhachdua.Text + button.Text;
        }

        // Token: 0x06000227 RID: 551 RVA: 0x00088C60 File Offset: 0x00086E60
        private void bt50_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 50000m).ToString();
        }

        // Token: 0x06000228 RID: 552 RVA: 0x00088CA4 File Offset: 0x00086EA4
        private void bt100_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 100000m).ToString();
        }

        // Token: 0x06000229 RID: 553 RVA: 0x00088CE8 File Offset: 0x00086EE8
        private void bt200_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 200000m).ToString();
        }

        // Token: 0x0600022A RID: 554 RVA: 0x00088D2C File Offset: 0x00086F2C
        private void bt500_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 500000m).ToString();
        }

        // Token: 0x0600022B RID: 555 RVA: 0x00088D70 File Offset: 0x00086F70
        private void bt1000_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 1000000m).ToString();
        }

        // Token: 0x0600022C RID: 556 RVA: 0x00088DB4 File Offset: 0x00086FB4
        private void txtkhachdua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtkhachdua.Text == "0")
                {
                    this.txtthoilai.Text = "0";
                }
                else if (this.txtkhachdua.Text == "")
                {
                    this.txtthoilai.Text = "0";
                }
                else
                {
                    decimal d = decimal.Parse(this.txtkhachdua.Text);
                    this.txtkhachdua.Text = d.ToString("#,###");
                    this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
                    decimal d2 = decimal.Parse(this.txtphaitra.Text);
                    decimal num = d - d2;
                    this.txtthoilai.Text = num.ToString("#,##0");
                }
            }
            catch
            {
                this.txtkhachdua.Text = "0";
            }
            this.txtkhachdua.Focus();
        }

        // Token: 0x0600022D RID: 557 RVA: 0x00088ED0 File Offset: 0x000870D0
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtkhachdua.Text.Length > 0)
                {
                    this.txtkhachdua.Text = this.txtkhachdua.Text.Substring(0, this.txtkhachdua.Text.Length - 1);
                }
                this.txtkhachdua.Focus();
                this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
            }
            catch
            {
            }
        }

        // Token: 0x0600022E RID: 558 RVA: 0x00088F64 File Offset: 0x00087164
        private void btok_Click(object sender, EventArgs e)
        {
            //TrangChu.hinhthu = 1;
            //TrangChu.guitinnhansms = "True";
            //if (this.txtkhachdua.Text == "")
            //{
            //    this.txtkhachdua.Text = "0";
            //}
            //if (this.txttennv.Text == "" && TrangChu.chonnhanvien_thanhtoan == "True")
            //{
            //    this.txtmanv.Focus();
            //    MessageBox.Show("VUI LÒNG NHẬP MÃ NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else if (this.txttt.Text != "Công Nợ:")
            //{
            //    if (double.Parse(this.txtthoilai.Text) < 0.0)
            //    {
            //        MessageBox.Show("Tiền khách đưa phải lớn hơn phải thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txtkhachdua.Focus();
            //        this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
            //    }
            //    else
            //    {
            //        frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //        frmtienthoi.dongy = "ok";
            //        base.Close();
            //    }
            //}
            //else
            //{
            //    frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //    frmtienthoi.dongy = "ok";
            //    base.Close();
            //}
        }

        // Token: 0x0600022F RID: 559 RVA: 0x0001BCAB File Offset: 0x00019EAB
        private void btthoat_Click(object sender, EventArgs e)
        {
            frmtienthoi.dongy = "khongtt";
           // base.Close();
        }

        // Token: 0x06000230 RID: 560 RVA: 0x000890CC File Offset: 0x000872CC
        private void txtkhachdua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btok_Click(null, null);
            }
        }

        // Token: 0x06000231 RID: 561 RVA: 0x0001BCBF File Offset: 0x00019EBF
        private void txtthoilai_Enter(object sender, EventArgs e)
        {
            this.txtkhachdua.Focus();
        }

        // Token: 0x06000232 RID: 562 RVA: 0x0001BCBF File Offset: 0x00019EBF
        private void txttt_Enter(object sender, EventArgs e)
        {
            this.txtkhachdua.Focus();
        }

        // Token: 0x06000233 RID: 563 RVA: 0x0001BCBF File Offset: 0x00019EBF
        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.txtkhachdua.Focus();
        }

        // Token: 0x06000234 RID: 564 RVA: 0x0001BCBF File Offset: 0x00019EBF
        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.txtkhachdua.Focus();
        }

        // Token: 0x06000235 RID: 565 RVA: 0x0001BCAB File Offset: 0x00019EAB
        private void button2_Click(object sender, EventArgs e)
        {
            frmtienthoi.dongy = "khongtt";
          //  base.Close();
        }

        // Token: 0x06000236 RID: 566 RVA: 0x000890F4 File Offset: 0x000872F4
        private void button1_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(this.txtkhachdua.Text);
            this.txtkhachdua.Text = (d + 2000000m).ToString();
        }

        // Token: 0x06000237 RID: 567 RVA: 0x00089138 File Offset: 0x00087338
        private void frmtienthoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.button2_Click(null, null);
            }
        }

        // Token: 0x06000238 RID: 568 RVA: 0x0001BCCE File Offset: 0x00019ECE
        private void btlui_Click(object sender, EventArgs e)
        {
            this.txtkhachdua.Text = this.txtkhachdua.Text.Remove(this.txtkhachdua.Text.Length - 1);
        }

        // Token: 0x06000239 RID: 569 RVA: 0x00089160 File Offset: 0x00087360
        private void txtkhachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Token: 0x0600023A RID: 570 RVA: 0x00089198 File Offset: 0x00087398
        private void txtkhachdua_Leave(object sender, EventArgs e)
        {
            if (this.txtkhachdua.Text == "")
            {
                this.txtkhachdua.Text = "0";
            }
        }

        // Token: 0x0600023B RID: 571 RVA: 0x000891D8 File Offset: 0x000873D8
        private void button3_Click(object sender, EventArgs e)
        {
            //TrangChu.guitinnhansms = "True";
            //if (this.txtkhachdua.Text == "")
            //{
            //    this.txtkhachdua.Text = "0";
            //}
            //if (this.txttennv.Text.Trim() == "" && TrangChu.chonnhanvien_thanhtoan == "True")
            //{
            //    this.txtmanv.Focus();
            //    MessageBox.Show("VUI LÒNG NHẬP MÃ NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else if (this.txttt.Text != "Công Nợ:")
            //{
            //    if (double.Parse(this.txtthoilai.Text) < 0.0)
            //    {
            //        MessageBox.Show("Tiền khách đưa phải lớn hơn phải thanh toán", "Thông báo");
            //        this.txtkhachdua.Focus();
            //        this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
            //    }
            //    else
            //    {
            //        frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //        frmtienthoi.dongy = "ok";
            //        base.Close();
            //    }
            //}
            //else
            //{
            //    frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //    frmtienthoi.dongy = "ok";
            //    base.Close();
            //}
        }

        // Token: 0x0600023C RID: 572 RVA: 0x0008933C File Offset: 0x0008753C
        private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    try
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect_khachhang;
            //        string cmdText = "SELECT TENNV FROM Tb_NhanVien WHERE MaNV='" + this.txtmanv.Text.Trim() + "'";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.Read())
            //        {
            //            TrangChu.maphucvu = this.txtmanv.Text.Trim();
            //            this.txttennv.Text = sqlDataReader.GetString(0);
            //            frmtienthoi.tennhanvienbanhang = this.txttennv.Text;
            //            this.btok.Focus();
            //        }
            //        if (!sqlDataReader.HasRows)
            //        {
            //            frmtienthoi.tennhanvienbanhang = "";
            //            this.txttennv.Text = "";
            //            TrangChu.maphucvu = "";
            //        }
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        // Token: 0x0600023D RID: 573 RVA: 0x00089458 File Offset: 0x00087658
        private void button4_Click(object sender, EventArgs e)
        {
            //TrangChu.hinhthu = 4;
            //TrangChu.guitinnhansms = "True";
            //if (this.txtkhachdua.Text == "")
            //{
            //    this.txtkhachdua.Text = "0";
            //}
            //if (this.txttennv.Text == "" && TrangChu.chonnhanvien_thanhtoan == "True")
            //{
            //    this.txtmanv.Focus();
            //    MessageBox.Show("VUI LÒNG NHẬP MÃ NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else if (this.txttt.Text != "Công Nợ:")
            //{
            //    if (double.Parse(this.txtthoilai.Text) < 0.0)
            //    {
            //        MessageBox.Show("Tiền khách đưa phải lớn hơn phải thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txtkhachdua.Focus();
            //        this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
            //    }
            //    else
            //    {
            //        frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //        frmtienthoi.dongy = "ok";
            //        base.Close();
            //    }
            //}
            //else
            //{
            //    frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //    frmtienthoi.dongy = "ok";
            //    base.Close();
            //}
        }

        // Token: 0x0600023E RID: 574 RVA: 0x000895C0 File Offset: 0x000877C0
        private void button5_Click(object sender, EventArgs e)
        {
            //TrangChu.hinhthu = 5;
            //TrangChu.guitinnhansms = "True";
            //if (this.txtkhachdua.Text == "")
            //{
            //    this.txtkhachdua.Text = "0";
            //}
            //if (this.txttennv.Text == "" && TrangChu.chonnhanvien_thanhtoan == "True")
            //{
            //    this.txtmanv.Focus();
            //    MessageBox.Show("VUI LÒNG NHẬP MÃ NHÂN VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //else if (this.txttt.Text != "Công Nợ:")
            //{
            //    if (double.Parse(this.txtthoilai.Text) < 0.0)
            //    {
            //        MessageBox.Show("Tiền khách đưa phải lớn hơn phải thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txtkhachdua.Focus();
            //        this.txtkhachdua.SelectionStart = this.txtkhachdua.TextLength;
            //    }
            //    else
            //    {
            //        frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //        frmtienthoi.dongy = "ok";
            //        base.Close();
            //    }
            //}
            //else
            //{
            //    frmtienthoi.Khachdua = this.txtkhachdua.Text;
            //    frmtienthoi.dongy = "ok";
            //    base.Close();
            //}
        }
        // Token: 0x04000282 RID: 642
        public static string tennhanvienbanhang = "";

        // Token: 0x04000283 RID: 643
        public static string tieude = string.Empty;

        // Token: 0x04000284 RID: 644
        public static string thanhtoan = string.Empty;

        // Token: 0x04000285 RID: 645
        public static string dongy = string.Empty;

        // Token: 0x04000286 RID: 646
        public static string Khachdua = string.Empty;
    }
}
