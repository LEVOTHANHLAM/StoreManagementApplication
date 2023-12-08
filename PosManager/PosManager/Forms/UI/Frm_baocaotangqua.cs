namespace PosManager.Forms.UI
{
    public partial class Frm_baocaotangqua : Form
    {
        public Frm_baocaotangqua()
        {
            InitializeComponent();
        }
        private void Frm_baocaotangqua_Load(object sender, EventArgs e)
        {
            base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 10);
            this.dateTimePicker1.Text = DateTime.Now.ToString("01/01/yyyy");
            if (Frm_baocaotangqua.thangnam == 0)
            {
                this.panel1.BringToFront();
            }
            else
            {
                this.panel1.SendToBack();
            }
            this.button24_Click(null, null);
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00021F30 File Offset: 0x00020130
        private void load_tangnam()
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT DS.THANG,KH.TENKHACHHANG,DS.SOHOADON,DS.SOTIEN,QT.NOIDUNG,QT.NGAYTANG,QT.NHANVIEN,KH.SDT from TB_DOANHSOKHACHHANG_NAM DS LEFT JOIN TB_QUATANG_NAM QT ON DS.MAKHACHHANG=QT.MAKHACHHANG,Tb_KHACHHANG KH WHERE DS.MAKHACHHANG=KH.MAKHACHHANG", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtangqua.DataSource = dataTable;
        }

        // Token: 0x06000043 RID: 67 RVA: 0x00021F90 File Offset: 0x00020190
        private void button24_Click(object sender, EventArgs e)
        {
            //if (Frm_baocaotangqua.thangnam == 0)
            //{
            //    DataTable dataTable = new DataTable();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand("SELECT THANG,KH.TENKHACHHANG,SOHOADON,DS.SOTIEN,NOIDUNG,NGAYTANG,NHANVIEN,KH.SDT from TB_DOANHSOKHACHHANG DS,Tb_KHACHHANG KH WHERE DS.MAKHACHHANG=KH.MAKHACHHANG  ORDER BY CONVERT(DATETIME,THANG,103) DESC", sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    this.dgvtangqua.DataSource = dataTable;
            //}
            //else
            //{
            //    this.load_tangnam();
            //}
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00022010 File Offset: 0x00020210
        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            //if (this.txtmakhachhang.Text.Trim() != "")
            //{
            //    if (Frm_baocaotangqua.thangnam == 0)
            //    {
            //        DataTable dataTable = new DataTable();
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "SELECT THANG,KH.TENKHACHHANG,SOHOADON,DS.SOTIEN,NOIDUNG,NGAYTANG,NHANVIEN,KH.SDT from TB_DOANHSOKHACHHANG DS,Tb_KHACHHANG KH WHERE DS.MAKHACHHANG=KH.MAKHACHHANG  AND KH.MAKHACHHANG LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' OR  DS.MAKHACHHANG=KH.MAKHACHHANG  AND SDT LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%' OR DS.MAKHACHHANG=KH.MAKHACHHANG  AND TENKHACHHANG LIKE N'%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%' OR DS.MAKHACHHANG=KH.MAKHACHHANG   AND CHANHXE LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%' ORDER BY CONVERT(DATETIME,THANG,103) DESC"
            //        }), sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvtangqua.DataSource = dataTable;
            //    }
            //    else
            //    {
            //        DataTable dataTable = new DataTable();
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "SELECT DS.THANG,KH.TENKHACHHANG,DS.SOHOADON,DS.SOTIEN,QT.NOIDUNG,QT.NGAYTANG,QT.NHANVIEN,KH.SDT from TB_DOANHSOKHACHHANG_NAM DS LEFT JOIN TB_QUATANG_NAM QT ON DS.MAKHACHHANG=QT.MAKHACHHANG,Tb_KHACHHANG KH WHERE DS.MAKHACHHANG=KH.MAKHACHHANG  AND KH.MAKHACHHANG LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' OR  DS.MAKHACHHANG=KH.MAKHACHHANG  AND SDT LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%' OR DS.MAKHACHHANG=KH.MAKHACHHANG  AND TENKHACHHANG LIKE N'%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%' OR DS.MAKHACHHANG=KH.MAKHACHHANG   AND CHANHXE LIKE '%",
            //            this.txtmakhachhang.Text.Trim(),
            //            "%'"
            //        }), sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvtangqua.DataSource = dataTable;
            //    }
            //}
        }

        // Token: 0x06000045 RID: 69 RVA: 0x00022218 File Offset: 0x00020418
        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand("SELECT THANG,KH.TENKHACHHANG,SOHOADON,DS.SOTIEN,NOIDUNG,NGAYTANG,NHANVIEN,KH.SDT from TB_KHACHHANGQUANTAM DS,Tb_KHACHHANG KH WHERE DS.MAKHACHHANG=KH.MAKHACHHANG  ORDER BY CONVERT(DATETIME,THANG,103) DESC", sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtangqua.DataSource = dataTable;
        }

        // Token: 0x06000046 RID: 70 RVA: 0x0001B637 File Offset: 0x00019837
        private void button2_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00022278 File Offset: 0x00020478
        private void txttop_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return && this.txttop.Text != "" && frmLogIn.MADANGNHAP == "ADMIN")
            //{
            //    try
            //    {
            //        DataTable dataTable = new DataTable();
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "DELETE TB_DOANHSOKHACHHANG_NAM SELECT TOP ",
            //            this.txttop.Text,
            //            " MAKHACHHANG, ISNULL(SUM(THANHTOAN),0),ISNULL(COUNT(SOHOADON),0),'','",
            //            this.dateTimePicker1.Text,
            //            "','','' from tb_hoadonbanhang hd WHERE MAKHACHHANG!='' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //            Convert.ToDateTime(this.dateTimePicker1.Text).ToString("MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //            Convert.ToDateTime(this.dateTimePicker2.Text).ToString("MM/dd/yyyy"),
            //            "' group by  MAKHACHHANG order by SUM(THANHTOAN)DESC "
            //        }), sqlConnection);
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        for (int i = 0; i < dataTable.Rows.Count; i++)
            //        {
            //            sqlCommand = new SqlCommand(string.Concat(new string[]
            //            {
            //                "INSERT INTO [DATASHOP].[dbo].[TB_DOANHSOKHACHHANG_NAM]([MAKHACHHANG],[SOTIEN],[SOHOADON],[NOIDUNG],[THANG],[NGAYTANG],[NHANVIEN]) VALUES ('",
            //                dataTable.Rows[i][0].ToString(),
            //                "', '",
            //                dataTable.Rows[i][1].ToString(),
            //                "','",
            //                dataTable.Rows[i][2].ToString(),
            //                "','','",
            //                this.dateTimePicker1.Text,
            //                "','','')"
            //            }), sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //        sqlConnection.Close();
            //        this.load_tangnam();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            //}
        }
        public static int thangnam = 0;
    }
}
