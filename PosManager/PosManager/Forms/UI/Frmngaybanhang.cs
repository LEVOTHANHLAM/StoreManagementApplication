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
    public partial class Frmngaybanhang : Form
    {
        public Frmngaybanhang()
        {
            InitializeComponent();
        }
        private void Frmngaybanhang_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = DateTime.Now.ToString("dd");
            this.comboBox2.Text = DateTime.Now.ToString("MM");
            this.comboBox3.Text = DateTime.Now.Year.ToString();
        }

        // Token: 0x06000CC0 RID: 3264 RVA: 0x001BCD50 File Offset: 0x001BAF50
        private void button2_Click(object sender, EventArgs e)
        {
            //TrangChu.ngaybanhang = string.Concat(new string[]
            //{
            //    this.comboBox1.Text,
            //    "/",
            //    this.comboBox2.Text,
            //    "/",
            //    this.comboBox3.Text
            //});
            //base.Close();
        }

        // Token: 0x06000CC1 RID: 3265 RVA: 0x001BCDB4 File Offset: 0x001BAFB4
        private void button1_Click(object sender, EventArgs e)
        {
           // TrangChu.ngaybanhang = DateTime.Now.ToString("dd/MM/yyyy");
         //   base.Close();
        }

    }
}
