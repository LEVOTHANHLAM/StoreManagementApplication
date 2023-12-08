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
    public partial class Frmyesno : Form
    {
        public Frmyesno()
        {
            InitializeComponent();
        }
        private void Frmyesno_Load(object sender, EventArgs e)
        {
            this.Text = Frmyesno.caption;
            this.textBox1.Text = Frmyesno.text;
        }

        // Token: 0x06000CA1 RID: 3233 RVA: 0x0001E236 File Offset: 0x0001C436
        private void button1_Click(object sender, EventArgs e)
        {
            Frmyesno.dongy = "ok";
            base.Close();
        }

        // Token: 0x06000CA2 RID: 3234 RVA: 0x0001E24A File Offset: 0x0001C44A
        private void button2_Click(object sender, EventArgs e)
        {
            Frmyesno.dongy = "khongok";
            base.Close();
        }

        // Token: 0x06000CA3 RID: 3235 RVA: 0x001BA780 File Offset: 0x001B8980
        private void Frmyesno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Frmyesno.dongy = "khongok";
                base.Close();
            }
        }
        public static string caption = string.Empty;

        // Token: 0x04000E56 RID: 3670
        public static string text = string.Empty;

        // Token: 0x04000E57 RID: 3671
        public static string dongy = "ko";
    }
}
