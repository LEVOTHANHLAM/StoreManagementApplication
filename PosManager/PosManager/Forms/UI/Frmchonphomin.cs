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
    public partial class Frmchonphomin : Form
    {
        public Frmchonphomin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //base.Close();
            //Frmchonphomin.boqua = "1";
        }

        // Token: 0x060005D6 RID: 1494 RVA: 0x0011C568 File Offset: 0x0011A768
        private void Frmchonphomin_Load(object sender, EventArgs e)
        {
            //string cmdText = "SELECT HOADON1,HOADON2 FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    this.btin1.Text = Convert.ToString(sqlDataReader.GetValue(0));
            //    this.btin2.Text = Convert.ToString(sqlDataReader.GetValue(1));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x060005D7 RID: 1495 RVA: 0x0001C88B File Offset: 0x0001AA8B
        private void btin1_Click(object sender, EventArgs e)
        {
            //Frmchonphomin.boqua = "2";
            //TrangChu.mayin = "1";
            //FrmBangkehoadon.mayin = "1";
            //base.Close();
        }

        // Token: 0x060005D8 RID: 1496 RVA: 0x0001C8B3 File Offset: 0x0001AAB3
        private void btin2_Click(object sender, EventArgs e)
        {
            //Frmchonphomin.boqua = "2";
            //FrmBangkehoadon.mayin = "2";
            //TrangChu.mayin = "2";
            //base.Close();
        }

        // Token: 0x060005D9 RID: 1497 RVA: 0x0011C608 File Offset: 0x0011A808
        private void Frmchonphomin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.button1_Click(null, null);
            }
        }

    }
}
