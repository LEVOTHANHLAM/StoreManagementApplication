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
    public partial class Frm_hinhsanpham : Form
    {
        public Frm_hinhsanpham()
        {
            InitializeComponent();
        }
        private void Frm_hinhsanpham_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string selectCommandText = "select HINH FROM TB_HINHHANGHOA WHERE MAHANG ='" + Frm_hinhsanpham.mahang + "'";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
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


        // Token: 0x04001293 RID: 4755
        public static string mahang = "";
    }
}
