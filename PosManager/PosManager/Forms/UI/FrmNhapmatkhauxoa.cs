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
    public partial class FrmNhapmatkhauxoa : Form
    {
        public FrmNhapmatkhauxoa()
        {
            InitializeComponent();
        }
        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    TrangChu.mk = this.txtmatkhau.Text.Trim();
            //    FrmInhoadonvat.mk = this.txtmatkhau.Text.Trim();
            //    base.Close();
            //}
        }

        // Token: 0x0600017B RID: 379 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void button1_Click(object sender, EventArgs e)
        {
            //base.Close();
        }

        // Token: 0x0600017C RID: 380 RVA: 0x0001BAFC File Offset: 0x00019CFC
        private void btok_Click(object sender, EventArgs e)
        {
            //TrangChu.mk = this.txtmatkhau.Text.Trim();
            //FrmInhoadonvat.mk = this.txtmatkhau.Text.Trim();
            //base.Close();
        }

        // Token: 0x0600017D RID: 381 RVA: 0x00033A64 File Offset: 0x00031C64
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtmatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
