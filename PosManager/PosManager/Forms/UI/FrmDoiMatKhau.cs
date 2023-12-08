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
    public partial class FrmDoiMatKhau : Form
    {
        //private string connet = "Data Source=" + frmLogIn.fileconnect;

        //// Token: 0x04000E18 RID: 3608
        //private SqlConnection conn;

        //// Token: 0x04000E19 RID: 3609
        //private SqlCommand command;

        //// Token: 0x04000E1A RID: 3610
        //private NhanVienCtro nvCrt = new NhanVienCtro();

        //// Token: 0x04000E1B RID: 3611
        //private NhanvienObj nvObj = new NhanvienObj();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        private string mahoa(string pass)
        {

            return null;// return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
        }

        // Token: 0x06000BF9 RID: 3065 RVA: 0x001B8254 File Offset: 0x001B6454
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.conn = new SqlConnection(this.connet);
            //    this.conn.Open();
            //    string cmdText = "select count(nv.mataikhoan) from tb_nguoidung nv where mataikhoan=@manv and matkhau=@matkhau";
            //    this.command = new SqlCommand(cmdText, this.conn);
            //    this.command.Parameters.Add(new SqlParameter("@manv", this.txtmadangnhap.Text));
            //    this.command.Parameters.Add(new SqlParameter("@matkhau", this.mahoa(this.txtmatkhaucu.Text)));
            //    int num = (int)this.command.ExecuteScalar();
            //    if (num == 1)
            //    {
            //        if (this.txtmatkhaumoi.Text != this.txtmatkhaumoi1.Text)
            //        {
            //            this.lbthongbao.Text = "Mật khẩu nhập lại không đúng";
            //        }
            //        else
            //        {
            //            this.nvCrt.UpdateMatkhau1(this.mahoa(this.txtmatkhaumoi.Text.Trim()), this.txtmadangnhap.Text.Trim());
            //            this.nvObj.Matkhau = this.txtmatkhaumoi.Text.Trim();
            //            MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //            base.Close();
            //        }
            //    }
            //    else
            //    {
            //        this.lbthongbao.Text = "Sai mã đăng nhập hoặc sai mật khẩu cũ";
            //        this.txtmadangnhap.Text = "";
            //        this.txtmatkhaucu.Text = "";
            //        this.txtmadangnhap.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        // Token: 0x06000BFA RID: 3066 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void btboqua_Click(object sender, EventArgs e)
        {
           /// base.Close();
        }

        // Token: 0x06000BFB RID: 3067 RVA: 0x001B8420 File Offset: 0x001B6620
        private void txtmadangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtmatkhaucu.Focus();
            }
        }

        // Token: 0x06000BFC RID: 3068 RVA: 0x001B8450 File Offset: 0x001B6650
        private void txtmatkhaucu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtmatkhaumoi.Focus();
            }
        }

        // Token: 0x06000BFD RID: 3069 RVA: 0x001B8480 File Offset: 0x001B6680
        private void txtmatkhaumoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtmatkhaumoi1.Focus();
            }
        }

        // Token: 0x06000BFE RID: 3070 RVA: 0x001B84B0 File Offset: 0x001B66B0
        private void txtmatkhaumoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.txtmatkhaumoi.Text != this.txtmatkhaumoi1.Text)
                {
                    this.lbthongbao.Text = "Mật khẩu nhập lại không đúng";
                }
                else
                {
                    this.dtdoimatkhau.Focus();
                }
            }
        }

        // Token: 0x06000BFF RID: 3071 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
           // this.txtmadangnhap.Text = frmLogIn.MADANGNHAP;
        }
    }
}
