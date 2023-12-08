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
    public partial class Frm_phonghinhcongno : Form
    {
        public Frm_phonghinhcongno()
        {
            InitializeComponent();
        }
        private void Frm_phonghinhcongno_Load(object sender, EventArgs e)
        {
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - Screen.PrimaryScreen.WorkingArea.Height) / 2, 0, Screen.PrimaryScreen.WorkingArea.Height + 15, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Frm_phonghinhcongno.mahang, sqlConnection);
            //    DataTable dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        byte[] buffer = new byte[0];
            //        buffer = (byte[])dataTable.Rows[0][0];
            //        MemoryStream stream = new MemoryStream(buffer);
            //        this.ptlogo.Image = Image.FromStream(stream);
            //    }
            //}
            //catch
            //{
            //}
        }
        public static string mahang = "";
    }
}
