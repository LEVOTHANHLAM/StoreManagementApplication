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
    public partial class Frmchitietcongnophaithu : Form
    {
        public Frmchitietcongnophaithu()
        {
            InitializeComponent();
        }
        // Token: 0x06000CCD RID: 3277 RVA: 0x001BDD94 File Offset: 0x001BBF94
        private void tudongcapnhattendonvi()
        {
            //this.txtmakhachhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.txtmakhachhang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "Select tendonvi from Tb_khachhang";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    autoCompleteStringCollection.Add(sqlDataReader.GetString(0));
            //}
            //this.txtmakhachhang.AutoCompleteCustomSource = autoCompleteStringCollection;
            //sqlConnection.Close();
        }

        // Token: 0x06000CCE RID: 3278 RVA: 0x001BDE30 File Offset: 0x001BC030
        private void tudongloadkhachhang()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = string.Concat(new string[]
            //{
            //    "select MAKHACHHANG,TENDONVI,DIACHI,SDT from tb_khachhang WHERE makhachhang='",
            //    this.txtmakhachhang.Text,
            //    "' or Tendonvi =N'",
            //    this.txtmakhachhang.Text,
            //    "'"
            //});
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txtmakhachhang.Text = sqlDataReader.GetString(0);
            //    this.txttenkhachhang.Text = sqlDataReader.GetString(1) + " " + sqlDataReader.GetString(3);
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000CCF RID: 3279 RVA: 0x001BDF08 File Offset: 0x001BC108
        private void tudongloadkhachhangtheoma()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //string cmdText = "select TENDONVI,DIACHI,SDT from tb_khachhang WHERE makhachhang='" + this.txtmakhachhang.Text + "'";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.txttenkhachhang.Text = sqlDataReader.GetString(0) + " " + sqlDataReader.GetString(2);
            //}
            //if (!sqlDataReader.HasRows)
            //{
            //    this.txttenkhachhang.Text = "";
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000CD0 RID: 3280 RVA: 0x001BDFC0 File Offset: 0x001BC1C0
        private void Frmchitietcongnophaithu_Load(object sender, EventArgs e)
        {
            //this.dtdenngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //this.dttungay.Text = DateTime.Now.ToString("01/MM/yyyy");
            //if (Settings.Default.ina4 == "True")
            //{
            //    this.Cbsum.Checked = true;
            //}
            //else
            //{
            //    this.Cbsum.Checked = false;
            //}
            //this.txtletrai.Text = Settings.Default.letrai;
            //this.txtsodong.Text = Settings.Default.sdcongno;
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1024) / 2, 0, 1024, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.cobcongno.SelectedIndex = 0;
            //this.txtmakhachhang.Focus();
            //this.button1_Click(null, null);
        }

        // Token: 0x06000CD1 RID: 3281 RVA: 0x001BE0CC File Offset: 0x001BC2CC
        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtmakhachhang.Text != "")
                {
                    this.tudongloadkhachhangtheoma();
                }
                else
                {
                    this.lanhomkhachhang = "";
                    this.txtmakhachhang.Text = "";
                    this.txttenkhachhang.Text = "";
                    this.button1_Click(null, null);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000CD2 RID: 3282 RVA: 0x0001E39D File Offset: 0x0001C59D
        private void GETMAKH(string Makh, string tenkh, string diachi, string sdt)
        {
            this.txtmakhachhang.Text = Makh;
            this.txttenkhachhang.Text = tenkh + " " + sdt;
        }

        // Token: 0x06000CD3 RID: 3283 RVA: 0x001BE154 File Offset: 0x001BC354
        private void txtmakhachhang_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.txtmakhachhang, "Bấm chuột phải để tìm khách hàng");
        }

        // Token: 0x06000CD4 RID: 3284 RVA: 0x001BE17C File Offset: 0x001BC37C
        private void txtmakhachhang_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    Frmkhachhang.chon = "1";
            //    new Frmkhachhang
            //    {
            //        MaKH = new Frmkhachhang.GetData(this.GETMAKH)
            //    }.ShowDialog();
            //}
        }

        // Token: 0x06000CD5 RID: 3285 RVA: 0x001BE1CC File Offset: 0x001BC3CC
        private void txtmakhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    this.tudongloadkhachhang();
                    if (this.txttenkhachhang.Text != "")
                    {
                        this.button1_Click(null, null);
                    }
                }
                catch
                {
                }
            }
        }

        // Token: 0x06000CD6 RID: 3286 RVA: 0x0001BAD9 File Offset: 0x00019CD9
        private void btthoat_Click(object sender, EventArgs e)
        {
          //  base.Close();
        }

        // Token: 0x06000CD7 RID: 3287 RVA: 0x001BE234 File Offset: 0x001BC434
        private void dgvcongnokhachhang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvcongnokhachhang.RowCount; i++)
            {
                this.dgvcongnokhachhang.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000CD8 RID: 3288 RVA: 0x001BE288 File Offset: 0x001BC488
        private void loadcongno()
        {
            //this.loadtranotrongky();
            //this.loadcongnodauky();
            //string cmdText = string.Concat(new string[]
            //{
            //    "select CASE WHEN hinhthuc='2' THEN isnull(SUM(THANHTOAN-DUATRUOC),0) WHEN hinhthuc='3' THEN SUM(ISNULL(THANHTOAN,0)) ELSE '0' END from tb_hoadonbanhang where MAKHACHHANG ='",
            //    this.txtmakhachhang.Text,
            //    "' and CONVERT(DATETIME,NGAY,103)<'",
            //    Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //    "' and HUYHD ='false' GROUP BY HINHTHUC"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //double num = 0.0;
            //while (sqlDataReader.Read())
            //{
            //    num += double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //this.txtnodauky.Text = (num + this.tientondau - this.tiennodatra).ToString("#,##0");
            //sqlConnection.Close();
        }

        // Token: 0x06000CD9 RID: 3289 RVA: 0x001BE394 File Offset: 0x001BC594
        private void loadcongnodauky()
        {
            //string cmdText = "select isnull(SUM(SOTIEN),0) from tb_TONDAUKY where MA='thu' and MAKH ='" + this.txtmakhachhang.Text.Trim() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tientondau = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000CDA RID: 3290 RVA: 0x001BE424 File Offset: 0x001BC624
        private void loadtranotrongky()
        {
            //string cmdText = string.Concat(new string[]
            //{
            //    "select isnull(SUM(SOTIEN),0)+ isnull(SUM(TIENTRANO),0) from Tb_THUCHI where MAKH ='",
            //    this.txtmakhachhang.Text.Trim(),
            //    "'  AND Thuchi='THU' and CONVERT(DATETIME,NGAY,103)<'",
            //    Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //    "'"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.tiennodatra = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000CDB RID: 3291 RVA: 0x001BE4F4 File Offset: 0x001BC6F4
        private void button1_Click(object sender, EventArgs e)
        {
            //this.txtnodauky.Text = "0";
            //this.txtdathu.Text = "0";
            //this.txtphaithu.Text = "0";
            //this.txttongno.Text = "0";
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //string cmdText = "DELETE FROM TB_CONGNOPHAITHUTHEOKHACHHANG DELETE FROM TB_DATHU DELETE FROM TB_CONGNO ";
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            //if (this.txttenkhachhang.Text == "")
            //{
            //    this.loaiin = 0;
            //    string dk = "";
            //    if (this.cobcongno.SelectedIndex == 0)
            //    {
            //        dk = "(ISNULL(TD.SOTIEN,0)+SUM(ISNULL(CN.TIENNO,0)+ISNULL(CN.DATHU,0)+ISNULL(CN.CONLAI,0))) !=0";
            //    }
            //    else if (this.cobcongno.SelectedIndex == 1)
            //    {
            //        dk = "(ISNULL(TD.SOTIEN,0)+SUM(ISNULL(CN.TIENNO,0)-ISNULL(CN.DATHU,0)-ISNULL(CN.CONLAI,0))) >0";
            //    }
            //    else if (this.cobcongno.SelectedIndex == 2)
            //    {
            //        dk = "(ISNULL(TD.SOTIEN,0)+SUM(ISNULL(CN.TIENNO,0)-ISNULL(CN.DATHU,0)-ISNULL(CN.CONLAI,0))) <0";
            //    }
            //    string cmdText2 = string.Concat(new string[]
            //    {
            //        "DELETE TB_DATHU_DK INSERT INTO TB_DATHU_DK(MAKH,SOTIEN)(SELECT MAKH,ISNULL(SUM(Sotien+TIENTRANO),0) FROM Tb_THUCHI WHERE MAKH!='' AND THUCHI='THU'  AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "' GROUP BY MaKH ) INSERT INTO TB_DATHU(MAKH,SOTIEN)(SELECT MAKH,ISNULL(SUM(Sotien+TIENTRANO),0) FROM Tb_THUCHI WHERE MAKH!='' AND THUCHI='THU' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "'  AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //        Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
            //        "'GROUP BY MaKH )"
            //    });
            //    SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //    sqlCommand2.ExecuteNonQuery();
            //    string cmdText3 = string.Concat(new string[]
            //    {
            //        "INSERT INTO TB_CONGNO(MAKH,TENKH,TIENNO,DATHU,CONLAI)(select kh.makhachhang,kh.TENDONVI, ISNULL(sum(hd.thanhtoan),0) as tienno,ISNULL(sum( hd.duatruoc),0) as dathu,'0'as sotien \r\nfrom tb_hoadonbanhang hd ,tb_khachhang kh where hd.hinhthuc='2' AND kh.MAKHACHHANG =hd.makhachhang and hd.huyhd='False' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "'  AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //        Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
            //        "' group by kh.makhachhang,kh.TENDONVI) INSERT INTO TB_CONGNO(MAKH,TENKH,TIENNO,DATHU,CONLAI)(select kh.makhachhang,kh.TENDONVI, ISNULL(sum(hd.thanhtoan),0) as tienno,'0' as dathu,'0'as sotien  from tb_hoadonbanhang hd ,tb_khachhang kh where hd.hinhthuc='3' AND kh.MAKHACHHANG =hd.makhachhang and hd.huyhd='False' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "'  AND CONVERT(DATETIME,NGAY,103)<='23:59 ",
            //        Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
            //        "' group by kh.makhachhang,kh.TENDONVI)  DELETE TB_CONGNODAUKY_TAM INSERT INTO TB_CONGNODAUKY_TAM(MAKH,SOTIEN)(select  HD.MAKHACHHANG, ISNULL(sum(hd.thanhtoan-hd.duatruoc),0)from tb_hoadonbanhang hd where hd.hinhthuc='2' and hd.huyhd='False' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "' group by HD.makhachhang)  INSERT INTO TB_CONGNODAUKY_TAM(MAKH,SOTIEN)(select  HD.MAKHACHHANG, ISNULL(sum(hd.thanhtoan),0)from tb_hoadonbanhang hd where hd.hinhthuc='3' and hd.huyhd='False' AND CONVERT(DATETIME,NGAY,103)<'00:00 ",
            //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
            //        "' group by HD.makhachhang) DELETE TB_CONGNODAUKY INSERT INTO TB_CONGNODAUKY(MAKH,SOTIEN)(select  HD.MAKH, ISNULL(sum(SOTIEN),0)from TB_CONGNODAUKY_TAM hd group by HD.makh) INSERT INTO TB_CONGNO(MAKH,TENKH,TIENNO,DATHU,CONLAI)(select kh.makhachhang,kh.TENDONVI,'0'as tienno,'0'as dathu,isnull(tb_dathu.sotien,0)as sotien from tb_khachhang kh, tb_dathu where kh.MAKHACHHANG =tb_dathu.makh group by kh.makhachhang,kh.TENDONVI ,tb_dathu.sotien) DELETE TB_CONGNO_DK1 INSERT INTO TB_CONGNO_DK1(MAKH,SOTIEN)(SELECT KH.MAKHACHHANG,SUM(ISNULL(DK.SOTIEN,0))+ISNULL(CNDK.SOTIEN,0)-ISNULL(DTDK.SOTIEN,0) FROM ((Tb_KHACHHANG KH LEFT JOIN TB_TONDAUKY DK ON KH.MAKHACHHANG=DK.MAKH) LEFT JOIN TB_CONGNODAUKY CNDK ON KH.MAKHACHHANG=CNDK.MAKH)LEFT JOIN TB_DATHU_DK DTDK ON KH.MAKHACHHANG=DTDK.MAKH GROUP BY KH.MAKHACHHANG,ISNULL(DTDK.SOTIEN,0),ISNULL(CNDK.SOTIEN,0) HAVING SUM(ISNULL(DK.SOTIEN,0))+ISNULL(CNDK.SOTIEN,0)-ISNULL(DTDK.SOTIEN,0)!=0)"
            //    });
            //    SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //    sqlCommand3.ExecuteNonQuery();
            //    DataTable dataSource = new DataTable();
            //    dataSource = this.hdCtr.GET_CONGNOPHAITHU(dk, "");
            //    this.dgvcongno.DataSource = dataSource;
            //    this.dgvcongno.BringToFront();
            //    double num = 0.0;
            //    double num2 = 0.0;
            //    double num3 = 0.0;
            //    double num4 = 0.0;
            //    for (int i = 0; i < this.dgvcongno.RowCount; i++)
            //    {
            //        if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString()) > 0.0)
            //        {
            //            num3 += Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString());
            //        }
            //        if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nomoi"].Value.ToString()) > 0.0)
            //        {
            //            num += Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nomoi"].Value.ToString());
            //        }
            //        if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodathu"].Value.ToString()) > 0.0)
            //        {
            //            num2 += Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodathu"].Value.ToString());
            //        }
            //        if (Convert.ToDouble(this.dgvcongno.Rows[i].Cells["conlai"].Value.ToString()) > 0.0)
            //        {
            //            num4 += Convert.ToDouble(this.dgvcongno.Rows[i].Cells["conlai"].Value.ToString());
            //        }
            //    }
            //    this.txttongno.Text = num.ToString("#,##0");
            //    this.txtdathu.Text = num2.ToString("#,##0");
            //    this.txtnodauky.Text = num3.ToString("#,##0");
            //    this.txtphaithu.Text = num4.ToString("#,##0");
            //}
            //else
            //{
            //    if (this.cbhienthichitiet.Checked)
            //    {
            //        this.loaiin = 1;
            //        this.loadcongno();
            //        string cmdText2 = string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(select ngay,'','', thanhtoan as tienno, duatruoc as dathu from tb_hoadonbanhang where hinhthuc!='1' and huyhd='False' AND MAKHACHHANG ='",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' AND CONVERT(DATETIME,NGAY,103)>='",
            //            Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //            Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //            "')"
            //        });
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //        sqlCommand2.ExecuteNonQuery();
            //        string cmdText3 = string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(SELECT ngay,'','','', SUM(sotien+tientrano) as dathu FROM Tb_THUCHI where MaKH='",
            //            this.txtmakhachhang.Text.Trim(),
            //            "'AND Thuchi='THU' AND CONVERT(DATETIME,NGAY,103)>='",
            //            Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //            Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //            "' group by ngay)"
            //        });
            //        SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //        sqlCommand3.ExecuteNonQuery();
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.hdCtr.GET_CONGNOCHITIETKHACHHANGCHITIET();
            //        this.dgvcongnokhachhang.DataSource = dataSource;
            //        this.dgvcongnokhachhang.BringToFront();
            //        double num = 0.0;
            //        double num2 = 0.0;
            //        for (int i = 0; i < this.dgvcongnokhachhang.RowCount; i++)
            //        {
            //            num += Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["tienno"].Value.ToString());
            //            num2 += Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["dathu"].Value.ToString());
            //        }
            //        double num3 = double.Parse(this.txtnodauky.Text);
            //        this.txttongno.Text = num.ToString("#,##0");
            //        this.txtdathu.Text = num2.ToString("#,##0");
            //        this.txtphaithu.Text = (num3 + num - num2).ToString("#,##0");
            //    }
            //    if (this.cbchitiethanghoa.Checked)
            //    {
            //        this.loaiin = 2;
            //        this.loadcongno();
            //        string cmdText2 = string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(select ngay,'','', thanhtoan as tienno, duatruoc as dathu from tb_hoadonbanhang where hinhthuc='2' and huyhd='False' AND MAKHACHHANG ='",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' AND CONVERT(DATETIME,NGAY,103)>='",
            //            Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //            Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //            "') INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(select ngay,'','',isnull( thanhtoan,0) as tienno, '0' as dathu from tb_hoadonbanhang where hinhthuc='3' and huyhd='False' AND MAKHACHHANG ='",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' AND CONVERT(DATETIME,NGAY,103)>='",
            //            Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //            Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //            "')"
            //        });
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //        sqlCommand2.ExecuteNonQuery();
            //        string cmdText3 = string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_CONGNOPHAITHUTHEOKHACHHANG (NGAY,THANG,NAM,TIENNO,DATHU)(SELECT ngay,'','','', SUM(sotien+tientrano) as dathu FROM Tb_THUCHI where MaKH='",
            //            this.txtmakhachhang.Text.Trim(),
            //            "' AND Thuchi='THU' AND CONVERT(DATETIME,NGAY,103)>='",
            //            Convert.ToDateTime(this.dttungay.Text).ToString("00:00 MM/dd/yyyy"),
            //            "'  AND CONVERT(DATETIME,NGAY,103) <='",
            //            Convert.ToDateTime(this.dtdenngay.Text).ToString("23:59 MM/dd/yyyy"),
            //            "' group by ngay)"
            //        });
            //        SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //        sqlCommand3.ExecuteNonQuery();
            //        DataTable dataSource2 = new DataTable();
            //        dataSource2 = this.hdCtr.GET_CONGNOCHITIETKHACHHANGCHITIET();
            //        this.dgvcongnokhachhang.DataSource = dataSource2;
            //        double num = 0.0;
            //        double num2 = 0.0;
            //        for (int i = 0; i < this.dgvcongnokhachhang.RowCount; i++)
            //        {
            //            num += Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["tienno"].Value.ToString());
            //            num2 += Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["dathu"].Value.ToString());
            //        }
            //        double num3 = double.Parse(this.txtnodauky.Text);
            //        this.txttongno.Text = num.ToString("#,##0");
            //        this.txtdathu.Text = num2.ToString("#,##0");
            //        this.txtphaithu.Text = (num3 + num - num2).ToString("#,##0");
            //        DataTable dataSource = new DataTable();
            //        dataSource = this.hdCtr.GET_CONGNOCHITIETHANGHOA(Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"), this.txtmakhachhang.Text);
            //        this.dgvhanghoa.DataSource = dataSource;
            //        this.dgvhanghoa.BringToFront();
            //    }
            //    if (!this.cbchitiethanghoa.Checked && !this.cbhienthichitiet.Checked)
            //    {
            //    }
            //}
        }

        // Token: 0x06000CDC RID: 3292 RVA: 0x001BF0F4 File Offset: 0x001BD2F4
        private void cbhienthichitiet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbhienthichitiet.Checked)
            {
                this.cbchitiethanghoa.Checked = false;
            }
        }

        // Token: 0x06000CDD RID: 3293 RVA: 0x001BF124 File Offset: 0x001BD324
        private void cbchitiethanghoa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbchitiethanghoa.Checked)
            {
                this.cbhienthichitiet.Checked = false;
            }
        }

        // Token: 0x06000CDE RID: 3294 RVA: 0x001BF154 File Offset: 0x001BD354
        private void dgvhanghoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvhanghoa.RowCount; i++)
            {
                this.dgvhanghoa.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000CDF RID: 3295
        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(int handle, out int processId);

        // Token: 0x06000CE0 RID: 3296 RVA: 0x001BF1A8 File Offset: 0x001BD3A8
        private void xuatexcel1()
        {
            //try
            //{
            //    this.saveFileDialog1.InitialDirectory = "C";
            //    this.saveFileDialog1.Title = "Sever as Excel File";
            //    this.saveFileDialog1.FileName = "TONGHOP";
            //    this.saveFileDialog1.Filter = "Excel File(2007)|*.xlsx|Excel File(2010)|*.xlsx";
            //    if (this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //    {
            //        Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            //        application.Application.Workbooks.Add(Type.Missing);
            //        application.Columns.ColumnWidth = 30;
            //        for (int i = 1; i < this.dgvhanghoa.Columns.Count + 1; i++)
            //        {
            //            application.Cells[1, i] = this.dgvhanghoa.Columns[i - 1].HeaderText;
            //        }
            //        for (int i = 0; i < this.dgvhanghoa.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < this.dgvhanghoa.Columns.Count; j++)
            //            {
            //                if (this.dgvhanghoa.Rows[i].Cells[j].Value != null)
            //                {
            //                    application.Cells[i + 2, j + 1] = this.dgvhanghoa.Rows[i].Cells[j].Value.ToString();
            //                }
            //            }
            //        }
            //        application.ActiveWorkbook.SaveCopyAs(this.saveFileDialog1.FileName.ToString());
            //        application.ActiveWorkbook.Saved = true;
            //        application.Quit();
            //        int num;
            //        Frmchitietcongnophaithu.GetWindowThreadProcessId(application.Hwnd, out num);
            //        Process[] processesByName = Process.GetProcessesByName("excel");
            //        foreach (Process process in processesByName)
            //        {
            //            if (process.Id == num)
            //            {
            //                process.Kill();
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x06000CE1 RID: 3297 RVA: 0x0001B637 File Offset: 0x00019837
        private void btexcel_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000CE2 RID: 3298 RVA: 0x001BF420 File Offset: 0x001BD620
        private void loadcauhinh()
        {
            //string cmdText = "SELECT * FROM TB_CAUHINH WHERE MACONGTY='" + frmLogIn.macongty + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.chObj.Tencongty = sqlDataReader.GetString(1);
            //    this.chObj.Diachi = sqlDataReader.GetString(2);
            //    this.chObj.Dienthoai = sqlDataReader.GetString(3);
            //    this.chObj.Kyten = sqlDataReader.GetString(4);
            //    this.chObj.Canhle = sqlDataReader.GetString(5);
            //    this.chObj.Sotrangin = int.Parse(Convert.ToString(sqlDataReader.GetValue(6)));
            //    this.chObj.Ghichu = sqlDataReader.GetString(7);
            //    this.chObj.Cochuten = int.Parse(Convert.ToString(sqlDataReader.GetValue(8)));
            //    this.chObj.Cochudienthoai = int.Parse(Convert.ToString(sqlDataReader.GetValue(9)));
            //    this.chObj.Cochukyten = int.Parse(Convert.ToString(sqlDataReader.GetValue(10)));
            //    this.chObj.Cochudiachi = int.Parse(Convert.ToString(sqlDataReader.GetValue(11)));
            //    this.chObj.Letrai = int.Parse(Convert.ToString(sqlDataReader.GetValue(13)));
            //    this.chObj.Mayin = sqlDataReader.GetString(12);
            //    this.chObj.Tenmayin = sqlDataReader.GetString(14);
            //    this.chObj.Hoadon = sqlDataReader.GetString(15);
            //    this.chObj.Tieude1 = sqlDataReader.GetString(16);
            //    this.chObj.Tieude2 = sqlDataReader.GetString(17);
            //    this.chObj.Tieude3 = sqlDataReader.GetString(18);
            //    this.chObj.Kytu = Convert.ToString(sqlDataReader.GetValue(44));
            //}
            //sqlConnection.Close();
        }

        // Token: 0x06000CE3 RID: 3299 RVA: 0x001BF648 File Offset: 0x001BD848
        private void dgvcongno_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvcongno.RowCount; i++)
            {
                this.dgvcongno.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000CE4 RID: 3300 RVA: 0x001BF69C File Offset: 0x001BD89C
        //private void phieuthu_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.congdauky = 0m;
        //        this.tongtienhh = 0m;
        //        this.tongngay = 0m;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.lanin = 0;
        //    }
        //    try
        //    {
        //        int rowIndex = this.dgvcongnokhachhang.CurrentCell.RowIndex;
        //        string text = this.dgvcongnokhachhang.Rows[rowIndex].Cells["mahoadon"].Value.ToString();
        //        double num = double.Parse(this.dgvcongnokhachhang.Rows[rowIndex].Cells["tienno"].Value.ToString());
        //        double num2 = double.Parse(this.dgvcongnokhachhang.Rows[rowIndex].Cells["dathu"].Value.ToString());
        //        string value = (num - num2).ToString("#,##0");
        //        int num3 = 5;
        //        int num4 = 15;
        //        StringFormat stringFormat = new StringFormat();
        //        stringFormat.Alignment = StringAlignment.Center;
        //        StringFormat stringFormat2 = new StringFormat();
        //        stringFormat2.Alignment = StringAlignment.Far;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(5 + num4, num3));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num4, num3 + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num4, num3 + 50));
        //        e.Graphics.DrawString("PHIẾU THU", new Font("Arial", 14f, FontStyle.Bold), Brushes.Black, new Point(350 + num4, 70), stringFormat);
        //        e.Graphics.DrawString("Số: " + this.k, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, new Point(450 + num4, 80), stringFormat);
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(350 + num4, 100), stringFormat);
        //        e.Graphics.DrawString("Họ tên người nộp tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 130));
        //        e.Graphics.DrawString("Địa chỉ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 155));
        //        e.Graphics.DrawString("Lý do nộp:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 180));
        //        e.Graphics.DrawString("Số Tiền:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 205));
        //        e.Graphics.DrawString("(viết bằng chữ)", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(250 + num4, 205));
        //        e.Graphics.DrawString("Kèm theo: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 255));
        //        e.Graphics.DrawString("chứng từ gốc", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + num4, 255), stringFormat2);
        //        e.Graphics.DrawString(text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(100 + num4, 253));
        //        e.Graphics.DrawString("..................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(154 + num4, 138));
        //        e.Graphics.DrawString(".........................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num4, 163));
        //        e.Graphics.DrawString("...................................... ..................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num4, 188));
        //        e.Graphics.DrawString("..................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num4, 213));
        //        e.Graphics.DrawString("..................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(420 + num4, 213));
        //        e.Graphics.DrawString(".......................................................................................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(5 + num4, 238));
        //        e.Graphics.DrawString(".....................................................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(90 + num4, 261));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num4, 128));
        //        e.Graphics.DrawString("", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num4, 153));
        //        e.Graphics.DrawString("Thu nợ số hóa đơn số: " + text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num4, 178));
        //        e.Graphics.DrawString(Convert.ToDecimal(value).ToString("#,##0") + "   VNĐ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(120 + num4, 203));
        //        e.Graphics.DrawString(Frmchitietcongnophaithu.So_chu(Convert.ToDouble(value)), new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(90 + num4, 230));
        //        int num5 = 288;
        //        e.Graphics.DrawString(string.Concat(new string[]
        //        {
        //            "Ngày   ",
        //            DateTime.Now.ToString("dd"),
        //            "   tháng   ",
        //            DateTime.Now.ToString("MM"),
        //            "   năm   ",
        //            DateTime.Now.ToString("yyyy")
        //        }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(720 + num4, num5), stringFormat2);
        //        e.Graphics.DrawString("Người nộp tiền                                  Thủ quỹ                                   Người lập phiếu", new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(380 + num4, num5 + 25), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(115 + num4, num5 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(375 + num4, num5 + 45), stringFormat);
        //        e.Graphics.DrawString("(Ký,họ tên)", new Font("Arial", 9f, FontStyle.Italic), Brushes.Black, new Point(640 + num4, num5 + 45), stringFormat);
        //        e.Graphics.DrawString("Đã nhận đủ số tiền (viết bằng chữ):", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(5 + num4, num5 + 172));
        //        e.Graphics.DrawString("..........................................................................................................................................................................", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, new Point(720 + num4, num5 + 180), stringFormat2);
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = ex.Message;
        //    }
        //    this.xem = 1;
        //}

        // Token: 0x06000CE5 RID: 3301 RVA: 0x001C00E4 File Offset: 0x001BE2E4
        private void mathuchihd()
        {
            //string selectCommandText = "select mathuchi from Tb_Thuchi where left(mathuchi,3)='THU' and SUBSTRING(mathuchi,4,4)='" + DateTime.Now.ToString("MMyy") + "'";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, new SqlConnection
            //{
            //    ConnectionString = "Data Source=" + frmLogIn.fileconnect
            //});
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //string text;
            //if (dataTable.Rows.Count <= 0)
            //{
            //    text = "THU" + DateTime.Now.ToString("MMyy") + "00001";
            //    this.k = 1.0;
            //}
            //else
            //{
            //    string a = Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3, 4));
            //    text = DateTime.Now.ToString("MMyy");
            //    if (a == text)
            //    {
            //        this.k = Convert.ToDouble(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(7, 5));
            //        this.k += 1.0;
            //        if (this.k < 10.0)
            //        {
            //            text += "0000";
            //        }
            //        else if (this.k < 100.0)
            //        {
            //            text += "000";
            //        }
            //        else if (this.k < 1000.0)
            //        {
            //            text += "00";
            //        }
            //        else if (this.k < 10000.0)
            //        {
            //            text += "0";
            //        }
            //        text = "THU" + text + this.k.ToString();
            //    }
            //    else
            //    {
            //        text = "THU" + DateTime.Now.ToString("MMyy") + "00001";
            //        this.k = 1.0;
            //    }
            //}
            //this.matc = text;
        }

        // Token: 0x06000CE6 RID: 3302 RVA: 0x001C0344 File Offset: 0x001BE544
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        // Token: 0x06000CE7 RID: 3303 RVA: 0x00062194 File Offset: 0x00060394
        private static string Donvi(string so)
        {
            string result = "";
            if (so.Equals("1"))
            {
                result = "";
            }
            if (so.Equals("2"))
            {
                result = "nghìn";
            }
            if (so.Equals("3"))
            {
                result = "triệu";
            }
            if (so.Equals("4"))
            {
                result = "tỷ";
            }
            if (so.Equals("5"))
            {
                result = "nghìn tỷ";
            }
            if (so.Equals("6"))
            {
                result = "triệu tỷ";
            }
            if (so.Equals("7"))
            {
                result = "tỷ tỷ";
            }
            return result;
        }

        // Token: 0x06000CE8 RID: 3304 RVA: 0x001C048C File Offset: 0x001BE68C
        //private static string Tach(string tach3)
        //{
        //    string text = "";
        //    string result;
        //    if (tach3.Equals("000"))
        //    {
        //        result = "";
        //    }
        //    else
        //    {
        //        if (tach3.Length == 3)
        //        {
        //            string text2 = tach3.Trim().Substring(0, 1).ToString().Trim();
        //            string text3 = tach3.Trim().Substring(1, 1).ToString().Trim();
        //            string text4 = tach3.Trim().Substring(2, 1).ToString().Trim();
        //            if (text2.Equals("0") && text3.Equals("0"))
        //            {
        //                text = " không trăm lẻ " + Frmchitietcongnophaithu.Chu(text4.ToString().Trim()) + " ";
        //            }
        //            if (!text2.Equals("0") && text3.Equals("0") && text4.Equals("0"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.ToString().Trim()).Trim() + " trăm ";
        //            }
        //            if (!text2.Equals("0") && text3.Equals("0") && !text4.Equals("0"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.ToString().Trim()).Trim() + " trăm lẻ " + Frmchitietcongnophaithu.Chu(text4.Trim()).Trim() + " ";
        //            }
        //            if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
        //            {
        //                text = string.Concat(new string[]
        //                {
        //                    " không trăm ",
        //                    Frmchitietcongnophaithu.Chu(text3.Trim()).Trim(),
        //                    " mươi ",
        //                    Frmchitietcongnophaithu.Chu(text4.Trim()).Trim(),
        //                    " "
        //                });
        //            }
        //            if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
        //            {
        //                text = " không trăm " + Frmchitietcongnophaithu.Chu(text3.Trim()).Trim() + " mươi ";
        //            }
        //            if (text2.Equals("0") && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
        //            {
        //                text = " không trăm " + Frmchitietcongnophaithu.Chu(text3.Trim()).Trim() + " mươi lăm ";
        //            }
        //            if (text2.Equals("0") && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
        //            {
        //                text = " không trăm mười " + Frmchitietcongnophaithu.Chu(text4.Trim()).Trim() + " ";
        //            }
        //            if (text2.Equals("0") && text3.Equals("1") && text4.Equals("0"))
        //            {
        //                text = " không trăm mười ";
        //            }
        //            if (text2.Equals("0") && text3.Equals("1") && text4.Equals("5"))
        //            {
        //                text = " không trăm mười lăm ";
        //            }
        //            if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
        //            {
        //                text = string.Concat(new string[]
        //                {
        //                    Frmchitietcongnophaithu.Chu(text2.Trim()).Trim(),
        //                    " trăm ",
        //                    Frmchitietcongnophaithu.Chu(text3.Trim()).Trim(),
        //                    " mươi ",
        //                    Frmchitietcongnophaithu.Chu(text4.Trim()).Trim(),
        //                    " "
        //                });
        //            }
        //            if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && text4.Equals("0"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.Trim()).Trim() + " trăm " + Frmchitietcongnophaithu.Chu(text3.Trim()).Trim() + " mươi ";
        //            }
        //            if (Convert.ToInt32(text2) > 0 && Convert.ToInt32(text3) > 1 && text4.Equals("5"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.Trim()).Trim() + " trăm " + Frmchitietcongnophaithu.Chu(text3.Trim()).Trim() + " mươi lăm ";
        //            }
        //            if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && Convert.ToInt32(text4) > 0 && !text4.Equals("5"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.Trim()).Trim() + " trăm mười " + Frmchitietcongnophaithu.Chu(text4.Trim()).Trim() + " ";
        //            }
        //            if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && text4.Equals("0"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.Trim()).Trim() + " trăm mười ";
        //            }
        //            if (Convert.ToInt32(text2) > 0 && text3.Equals("1") && text4.Equals("5"))
        //            {
        //                text = Frmchitietcongnophaithu.Chu(text2.Trim()).Trim() + " trăm mười lăm ";
        //            }
        //        }
        //        result = text;
        //    }
        //    return result;
        //}

        // Token: 0x06000CE9 RID: 3305 RVA: 0x001C0A40 File Offset: 0x001BEC40
        public static string So_chu(double gNum)
        {
            string result = string.Empty;
            //if (gNum == 0.0)
            //{
            //    result = "Không đồng";
            //}
            //else
            //{
            //    string text = "";
            //    string tach = "";
            //    string text2 = "";
            //    double value = Math.Round(gNum, 0);
            //    string text3 = Convert.ToString(value);
            //    int num = Convert.ToInt32(text3.Length / 3);
            //    int num2 = text3.Length - num * 3;
            //    if (gNum < 0.0)
            //    {
            //    }
            //    string text4 = "";
            //    if (num2.Equals(1))
            //    {
            //        tach = "00" + Convert.ToString(value.ToString().Trim().Substring(0, 1)).Trim();
            //    }
            //    if (num2.Equals(2))
            //    {
            //        tach = "0" + Convert.ToString(value.ToString().Trim().Substring(0, 2)).Trim();
            //    }
            //    if (num2.Equals(0))
            //    {
            //        tach = "000";
            //    }
            //    if (value.ToString().Length > 2)
            //    {
            //        text2 = Convert.ToString(value.ToString().Trim().Substring(num2, value.ToString().Length - num2)).Trim();
            //    }
            //    int num3 = num + 1;
            //    if (num2 > 0)
            //    {
            //        text = Frmchitietcongnophaithu.Tach(tach).ToString().Trim() + " " + Frmchitietcongnophaithu.Donvi(num3.ToString().Trim());
            //    }
            //    int i = num;
            //    int num4 = num;
            //    int num5 = 1;
            //    while (i > 0)
            //    {
            //        string text5 = text2.Trim().Substring(0, 3).Trim();
            //        string text6 = text5;
            //        text = text.Trim() + " " + Frmchitietcongnophaithu.Tach(text5.Trim()).Trim();
            //        num = num4 + 1 - num5;
            //        if (!text6.Equals("000"))
            //        {
            //            text = text.Trim() + " " + Frmchitietcongnophaithu.Donvi(num.ToString().Trim()).Trim();
            //        }
            //        text2 = text2.Trim().Substring(3, text2.Trim().Length - 3);
            //        i--;
            //        num5++;
            //    }
            //    if (text.Trim().Substring(0, 1).Equals("k"))
            //    {
            //        text = text.Trim().Substring(10, text.Trim().Length - 10).Trim();
            //    }
            //    if (text.Trim().Substring(0, 1).Equals("l"))
            //    {
            //        text = text.Trim().Substring(2, text.Trim().Length - 2).Trim();
            //    }
            //    if (text.Trim().Length > 0)
            //    {
            //        text = string.Concat(new string[]
            //        {
            //            text4.Trim(),
            //            " ",
            //            text.Trim().Substring(0, 1).Trim().ToUpper(),
            //            text.Trim().Substring(1, text.Trim().Length - 1).Trim(),
            //            " đồng chẵn."
            //        });
            //    }
            //    result = text.ToString().Trim();
            //}
            return result;
        }

        // Token: 0x06000CEA RID: 3306 RVA: 0x001C0DCC File Offset: 0x001BEFCC
        private void bttim_Click(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //Frmkhachhang.chon = "1";
            //frmkhachhang.MaKH = new Frmkhachhang.GetData(this.GETMAKH);
            //frmkhachhang.ShowDialog();
            //this.lanhomkhachhang = "";
        }

        // Token: 0x06000CEB RID: 3307 RVA: 0x001C0E10 File Offset: 0x001BF010
        //private void A4_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.tongtienhh = 0m;
        //        this.tongngay = 0m;
        //        this.congdauky = 0m;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.lanin = 0;
        //    }
        //    int num = 5;
        //    int num2 = int.Parse(this.txtletrai.Text);
        //    int num3 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num4 = 0;
        //    int num5 = 0;
        //    if (this.lanin == 0)
        //    {
        //        this.dong = int.Parse(this.txtsodong.Text);
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //        int num6 = num3 + num + 75 + 25;
        //        e.Graphics.DrawString("BẢNG ĐỐI CHIẾU CÔNG NỢ", new Font("Arial", 16f, FontStyle.Bold), Brushes.Black, new Point(370 + num2, num6 - 25), stringFormat);
        //        num6 += 27;
        //        e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(350 + num2, num6 - 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(620 + num2, num3 + num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 45), stringFormat);
        //        e.Graphics.DrawString("Khách Hàng: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num6));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(100 + num2, num6));
        //        num4 = num6 + 25;
        //        num5 = 30;
        //    }
        //    else
        //    {
        //        num4 = num3;
        //        num5 = 30;
        //    }
        //    e.Graphics.DrawString("Ngày", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(7 + num2, num4));
        //    e.Graphics.DrawString("Tên Hàng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(120 + num2, num4));
        //    e.Graphics.DrawString("ĐVT", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(395 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("SL", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(455 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("Đơn Giá", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(553 + num2, num4), stringFormat2);
        //    e.Graphics.DrawString("Thành Tiền", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(655 + num2, num4), stringFormat2);
        //    e.Graphics.DrawString("Nợ cuối kỳ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(770 + num2, num4), stringFormat2);
        //    int num7 = num4 + 30;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 780f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    if (this.lanin == 0)
        //    {
        //        if (this.txtnodauky.Text != "0")
        //        {
        //            e.Graphics.DrawString(this.txtnodauky.Text, new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(780 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString("Nợ đầu kỳ", new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //            num7 += 25;
        //            num5 += 25;
        //        }
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvhanghoa.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > this.dong)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(365 + num2), (float)(num4 - 5), 55f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(420 + num2), (float)(num4 - 5), 65f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(560 + num2), (float)(num4 - 5), 100f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(660 + num2), (float)(num4 - 5), 125f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            this.lanin = 1;
        //            this.dong = int.Parse(this.txtsodong.Text) + 4;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvhanghoa.Rows.Count)
        //        {
        //            int length = this.dgvhanghoa.Rows[i].Cells["tenhang"].Value.ToString().Length;
        //            decimal num8 = Math.Ceiling(Convert.ToDecimal(length) / int.Parse(this.chObj.Kytu));
        //            if (i == 0)
        //            {
        //                e.Graphics.DrawString(Convert.ToDateTime(this.dgvhanghoa.Rows[i].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //            }
        //            else if (i > 0 && Convert.ToDateTime(this.dgvhanghoa.Rows[i].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy") != Convert.ToDateTime(this.dgvhanghoa.Rows[i - 1].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy"))
        //            {
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(365 + num2), (float)(num4 - 5), 55f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(420 + num2), (float)(num4 - 5), 65f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(560 + num2), (float)(num4 - 5), 100f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //                {
        //                    RectangleF rectangleF = new RectangleF((float)(660 + num2), (float)(num4 - 5), 125f, (float)num5);
        //                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //                }
        //                e.Graphics.DrawString("Cộng", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7));
        //                e.Graphics.DrawString(Convert.ToDouble(this.tongngay).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //                e.Graphics.DrawString((this.congdauky + this.tongngay + Convert.ToDecimal(this.txtnodauky.Text)).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7), stringFormat2);
        //                this.congdauky += this.tongngay;
        //                this.tongngay = 0m;
        //                num5 = -25;
        //                num5 += 17 * int.Parse(num8.ToString()) + 8;
        //                num7 += 17 * int.Parse(num8.ToString()) + 8;
        //                e.Graphics.DrawString(Convert.ToDateTime(this.dgvhanghoa.Rows[i].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num7));
        //                int num9 = num7;
        //                num4 = num9;
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, (float)(17 * int.Parse(num8.ToString()) + 8));
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            using (Font font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(80 + num2), (float)num7, 250f, (float)(17 * int.Parse(num8.ToString())));
        //                e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["tenhang"].Value.ToString(), font, Brushes.Black, rectangleF);
        //            }
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["donvitinh"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(395 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.###"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(460 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(560 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //            this.tongtienhh += Convert.ToDecimal(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
        //            this.tongngay += Convert.ToDecimal(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
        //            num5 += 17 * int.Parse(num8.ToString()) + 8;
        //            num7 += 17 * int.Parse(num8.ToString()) + 8;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, 25f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 70f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(365 + num2), (float)(num4 - 5), 55f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(420 + num2), (float)(num4 - 5), 65f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(560 + num2), (float)(num4 - 5), 100f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(660 + num2), (float)(num4 - 5), 125f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    e.Graphics.DrawString("TỔNG CỘNG:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7));
        //    e.Graphics.DrawString(Convert.ToDouble(this.tongngay).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString((Convert.ToDecimal(this.txtnodauky.Text) + this.congdauky + this.tongngay).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7), stringFormat2);
        //    num7 -= 25;
        //    DataTable dataTable = new DataTable();
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    string cmdText = string.Concat(new string[]
        //    {
        //        "SELECT isnull(SUM(GIAMTIEN),0) AS CONGGIAM,isnull(SUM(CASE WHEN PHANTRAM<0 THEN -TIENPHANTRAM ELSE TIENPHANTRAM END),0) AS PHANTRAM,isnull(SUM(TIENVAT),0) AS TIENVAT\r\nfrom TB_HOADONBANHANG HD\r\nWHERE HD.HINHTHUC!='1' AND HD.HUYHD='FALSE' AND HD.MAKHACHHANG='",
        //        this.txtmakhachhang.Text,
        //        "' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //        "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //        Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
        //        "'"
        //    });
        //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //    sqlConnection.Open();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //    sqlDataAdapter.Fill(dataTable);
        //    double num10 = double.Parse(dataTable.Rows[0][0].ToString());
        //    double num11 = double.Parse(dataTable.Rows[0][1].ToString());
        //    double num12 = double.Parse(dataTable.Rows[0][2].ToString());
        //    if (num10 + num11 > 0.0)
        //    {
        //        e.Graphics.DrawString("CỘNG TIỀN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num10 + num11).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    if (num10 + num11 < 0.0)
        //    {
        //        e.Graphics.DrawString("TRỪ TIỀN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num10 + num11).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    if (num12 > 0.0)
        //    {
        //        e.Graphics.DrawString("TIỀN VAT:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num12).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    e.Graphics.DrawString("ĐÃ TRẢ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //    e.Graphics.DrawString(Convert.ToDecimal(this.txtdathu.Text).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 50), stringFormat2);
        //    e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //    if (Convert.ToDecimal(this.txtphaithu.Text) > 0m)
        //    {
        //        e.Graphics.DrawString("PHẢI THANH TOÁN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 77));
        //        e.Graphics.DrawString(Convert.ToDecimal(this.txtphaithu.Text).ToString("#,##0"), new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 75), stringFormat2);
        //    }
        //    else
        //    {
        //        e.Graphics.DrawString("CÒN LẠI:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 77));
        //        e.Graphics.DrawString((0m - Convert.ToDecimal(this.txtphaithu.Text)).ToString("#,##0"), new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(780 + num2, num7 + 75), stringFormat2);
        //    }
        //    e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 87));
        //    e.Graphics.DrawString(string.Concat(new object[]
        //    {
        //        "                                                              Ngày ",
        //        DateTime.Now.Day,
        //        " tháng ",
        //        DateTime.Now.Month,
        //        " năm ",
        //        DateTime.Now.Year
        //    }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7 + 100), stringFormat2);
        //    e.Graphics.DrawString("                 KHÁCH HÀNG                                                             NGƯỜI LẬP PHIẾU", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(350 + num2, num7 + 125), stringFormat);
        //    this.xem = 1;
        //}

        // Token: 0x06000CEC RID: 3308 RVA: 0x001C2B0C File Offset: 0x001C0D0C
        private void dgvcongno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvcongno.Rows.Count > 0)
            {
                int index = this.dgvcongno.CurrentRow.Index;
                this.txtmakhachhang.Text = this.dgvcongno.Rows[index].Cells["makhachhang"].Value.ToString();
                this.cbchitiethanghoa.Checked = true;
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000CED RID: 3309 RVA: 0x001C2B94 File Offset: 0x001C0D94
        private void Frmchitietcongnophaithu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string ina = "False";
            //Settings.Default.letrai = this.txtletrai.Text;
            //Settings.Default.sdcongno = this.txtsodong.Text;
            //if (this.Cbsum.Checked)
            //{
            //    ina = "True";
            //}
            //Settings.Default.ina4 = ina;
            //Settings.Default.Save();
        }

        // Token: 0x06000CEE RID: 3310 RVA: 0x0001E3C6 File Offset: 0x0001C5C6
        private void txtmakhachhang_Leave(object sender, EventArgs e)
        {
            this.txtmakhachhang.BackColor = Color.White;
        }

        // Token: 0x06000CEF RID: 3311 RVA: 0x0001E3DA File Offset: 0x0001C5DA
        private void txtmakhachhang_Enter(object sender, EventArgs e)
        {
            this.txtmakhachhang.BackColor = Color.Yellow;
        }

        // Token: 0x06000CF0 RID: 3312 RVA: 0x0001E3EE File Offset: 0x0001C5EE
        private void textBox10_Enter(object sender, EventArgs e)
        {
            this.txtmakhachhang.Focus();
        }

        // Token: 0x06000CF1 RID: 3313 RVA: 0x001C2C04 File Offset: 0x001C0E04
        private void button3_Click(object sender, EventArgs e)
        {
            //if (this.txtmakhachhang.Text != "")
            //{
            //    frmThuChi.makhachhang = this.txtmakhachhang.Text;
            //    frmThuChi.tenkhachhang = this.txttenkhachhang.Text;
            //    frmThuChi.sophieu = 1;
            //    frmThuChi frmThuChi = new frmThuChi();
            //    frmThuChi.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo");
            //}
        }

        // Token: 0x06000CF2 RID: 3314 RVA: 0x001C2C78 File Offset: 0x001C0E78
        private void button2_Click_2(object sender, EventArgs e)
        {
            //this.xem = 0;
            //this.tongtienhh = 0m;
            //this.tongngay = 0m;
            //this.numberOfItemsPrintedSoFar = 0;
            //this.numberOfItemsPerPage = 0;
            //this.lanin = 0;
            //this.congdauky = 0m;
            //this.loadcauhinh();
            //if (this.loaiin == 2)
            //{
            //    if (this.dgvhanghoa.RowCount > 0)
            //    {
            //        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            //        if (this.Cbsum.Checked)
            //        {
            //            printPreviewDialog.Document = this.A4;
            //        }
            //        else
            //        {
            //            printPreviewDialog.Document = this.A4_1;
            //        }
            //        printPreviewDialog.WindowState = FormWindowState.Maximized;
            //        printPreviewDialog.PrintPreviewControl.Zoom = 1.2;
            //        printPreviewDialog.ShowDialog();
            //    }
            //}
            //else if (this.loaiin == 0)
            //{
            //    if (this.dgvcongno.RowCount > 0)
            //    {
            //        new PrintPreviewDialog
            //        {
            //            Document = this.In_congno,
            //            WindowState = FormWindowState.Maximized,
            //            PrintPreviewControl =
            //            {
            //                Zoom = 1.2
            //            }
            //        }.ShowDialog();
            //    }
            //}
            //else if (this.loaiin == 1)
            //{
            //    if (this.dgvcongnokhachhang.RowCount > 0)
            //    {
            //        new PrintPreviewDialog
            //        {
            //            Document = this.Print_ls,
            //            WindowState = FormWindowState.Maximized,
            //            PrintPreviewControl =
            //            {
            //                Zoom = 1.2
            //            }
            //        }.ShowDialog();
            //    }
            //}
        }

        // Token: 0x06000CF3 RID: 3315 RVA: 0x001C2E18 File Offset: 0x001C1018
        private void btin_Click_1(object sender, EventArgs e)
        {
            //this.xem = 0;
            //this.congdauky = 0m;
            //this.tongtienhh = 0m;
            //this.tongngay = 0m;
            //this.numberOfItemsPrintedSoFar = 0;
            //this.numberOfItemsPerPage = 0;
            //this.lanin = 0;
            //this.loadcauhinh();
            //PrintDialog printDialog = new PrintDialog();
            //PrintDocument printDocument = new PrintDocument();
            //if (this.cbinngang.Checked)
            //{
            //    printDocument.DefaultPageSettings.Landscape = true;
            //}
            //printDialog.Document = printDocument;
            //DialogResult dialogResult = printDialog.ShowDialog();
            //if (this.loaiin == 2)
            //{
            //    if (this.dgvhanghoa.RowCount > 0)
            //    {
            //        if (this.Cbsum.Checked)
            //        {
            //            printDocument.PrintPage += this.A4_PrintPage;
            //        }
            //        else
            //        {
            //            printDocument.PrintPage += this.A4_1_PrintPage;
            //        }
            //        if (dialogResult == DialogResult.OK)
            //        {
            //            printDocument.Print();
            //        }
            //    }
            //}
            //else if (this.loaiin == 0)
            //{
            //    if (this.dgvcongno.RowCount > 0)
            //    {
            //        printDocument.PrintPage += this.In_congno_PrintPage;
            //        if (dialogResult == DialogResult.OK)
            //        {
            //            printDocument.Print();
            //        }
            //    }
            //}
            //else if (this.loaiin == 1)
            //{
            //    if (this.dgvcongnokhachhang.RowCount > 0)
            //    {
            //        printDocument.PrintPage += this.Print_ls_PrintPage;
            //        if (dialogResult == DialogResult.OK)
            //        {
            //            printDocument.Print();
            //        }
            //    }
            //}
        }

        // Token: 0x06000CF4 RID: 3316 RVA: 0x001C2B0C File Offset: 0x001C0D0C
        private void dgvcongno_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvcongno.Rows.Count > 0)
            {
                int index = this.dgvcongno.CurrentRow.Index;
                this.txtmakhachhang.Text = this.dgvcongno.Rows[index].Cells["makhachhang"].Value.ToString();
                this.cbchitiethanghoa.Checked = true;
                this.button1_Click(null, null);
            }
        }

        // Token: 0x06000CF5 RID: 3317 RVA: 0x001C2C04 File Offset: 0x001C0E04
        private void button3_Click_1(object sender, EventArgs e)
        {
            //if (this.txtmakhachhang.Text != "")
            //{
            //    frmThuChi.makhachhang = this.txtmakhachhang.Text;
            //    frmThuChi.tenkhachhang = this.txttenkhachhang.Text;
            //    frmThuChi.sophieu = 1;
            //    frmThuChi frmThuChi = new frmThuChi();
            //    frmThuChi.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo");
            //}
        }

        // Token: 0x06000CF6 RID: 3318 RVA: 0x001C2FC8 File Offset: 0x001C11C8
        //private void In_congno_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.tongtienhh = 0m;
        //        this.tongngay = 0m;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.lanin = 0;
        //    }
        //    int num = 5;
        //    int num2 = int.Parse(this.txtletrai.Text);
        //    int num3 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num4 = 0;
        //    int num5 = 40;
        //    if (this.lanin == 0)
        //    {
        //        this.dong = 28;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //        int num6 = num3 + num + 75 + 25;
        //        e.Graphics.DrawString("BẢNG CÔNG NỢ KHÁCH HÀNG", new Font("Arial", 16f, FontStyle.Bold), Brushes.Black, new Point(370 + num2, num6 - 25), stringFormat);
        //        num6 += 25;
        //        e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(350 + num2, num6 - 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(620 + num2, num3 + num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 45), stringFormat);
        //        num5 = 40;
        //        num4 = num6 + 15;
        //    }
        //    else
        //    {
        //        num4 = num3;
        //        num5 = 70;
        //    }
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num4 + 7));
        //    e.Graphics.DrawString("Mã", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(80 + num2, num4 + 7));
        //    e.Graphics.DrawString("Khách Hàng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num2, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("Nợ đ.kỳ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(455 + num2, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("Nợ mới", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(573 + num2, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Đã thu", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(655 + num2, num4 + 7), stringFormat2);
        //    e.Graphics.DrawString("Còn lại", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(760 + num2, num4 + 7), stringFormat2);
        //    int num7 = num4 + 40;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 780f, 40f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvcongno.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > this.dong)
        //        {
        //            this.lanin = 1;
        //            this.dong = 32;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvcongno.Rows.Count)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, 30f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //            }
        //            e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["STT"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["makhachhang"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(35 + num2, num7));
        //            using (Font font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point))
        //            {
        //                RectangleF rectangleF = new RectangleF((float)(141 + num2), (float)num7, 285f, 30f);
        //                e.Graphics.DrawString(this.dgvcongno.Rows[i].Cells["tenkhachhang"].Value.ToString(), font, Brushes.Black, rectangleF);
        //            }
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodauky"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(500 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nomoi"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(589 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongno.Rows[i].Cells["nodathu"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(690 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongno.Rows[i].Cells["conlai"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(775 + num2, num7), stringFormat2);
        //            num7 += 30;
        //            num5 += 30;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num4 - 5), 30f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(140 + num2), (float)(num4 - 5), 270f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(410 + num2), (float)(num4 - 5), 90f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF rectangleF = new RectangleF((float)(590 + num2), (float)(num4 - 5), 100f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //        }
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF rectangleF = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
        //    }
        //    e.Graphics.DrawString("Tổng Công:", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(200 + num2, num7));
        //    e.Graphics.DrawString(this.txtnodauky.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString(this.txttongno.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(589 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString(this.txtdathu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(690 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString(this.txtphaithu.Text, new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(779 + num2, num7), stringFormat2);
        //    this.xem = 1;
        //}

        // Token: 0x06000CF7 RID: 3319 RVA: 0x001C3C90 File Offset: 0x001C1E90
        //private void A4_1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.tongtienhh = 0m;
        //        this.tongngay = 0m;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.lanin = 0;
        //    }
        //    int num = 5;
        //    int num2 = int.Parse(this.txtletrai.Text);
        //    int num3 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num4 = 0;
        //    int num5 = 0;
        //    if (this.lanin == 0)
        //    {
        //        this.dong = int.Parse(this.txtsodong.Text);
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //        int num6 = num3 + num + 75 + 25;
        //        e.Graphics.DrawString("BẢNG ĐỐI CHIẾU CÔNG NỢ", new Font("Arial", 16f, FontStyle.Bold), Brushes.Black, new Point(370 + num2, num6 - 25), stringFormat);
        //        num6 += 27;
        //        e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(350 + num2, num6 - 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(620 + num2, num3 + num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 45), stringFormat);
        //        e.Graphics.DrawString("Khách Hàng: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num6));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(100 + num2, num6));
        //        num4 = num6 + 25;
        //        num5 = 30;
        //    }
        //    else
        //    {
        //        num4 = num3;
        //        num5 = 30;
        //    }
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num4));
        //    e.Graphics.DrawString("Tên Hàng", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(80 + num2, num4));
        //    e.Graphics.DrawString("ĐVT", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(395 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("SL", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(455 + num2, num4), stringFormat);
        //    e.Graphics.DrawString("Đơn Giá", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(553 + num2, num4), stringFormat2);
        //    e.Graphics.DrawString("Thành Tiền", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(655 + num2, num4), stringFormat2);
        //    e.Graphics.DrawString("Ngày", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(740 + num2, num4), stringFormat2);
        //    int num7 = num4 + 30;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + num2), (float)(num4 - 5), 780f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvhanghoa.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > this.dong)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + num2), (float)(num4 - 5), 30f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(365 + num2), (float)(num4 - 5), 55f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(420 + num2), (float)(num4 - 5), 65f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(560 + num2), (float)(num4 - 5), 100f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(660 + num2), (float)(num4 - 5), 125f, (float)num5);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            this.lanin = 1;
        //            this.dong = int.Parse(this.txtsodong.Text) + 4;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvhanghoa.Rows.Count)
        //        {
        //            e.Graphics.DrawString(Convert.ToDateTime(this.dgvhanghoa.Rows[i].Cells["NGAYTT"].Value.ToString()).ToString("dd/MM/yyyy"), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(730 + num2, num7), stringFormat2);
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, 25f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["sott"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(18 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["tenhang"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(35 + num2, num7));
        //            e.Graphics.DrawString(this.dgvhanghoa.Rows[i].Cells["donvitinh"].Value.ToString(), new Font("Arial", 9f, FontStyle.Regular), Brushes.Black, new Point(395 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["SL"].Value.ToString()).ToString("#,##0.###"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(460 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["dongia"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(560 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString()).ToString("#,##0"), new Font("Arial", 10f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //            this.tongtienhh += Convert.ToDecimal(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
        //            this.tongngay += Convert.ToDecimal(this.dgvhanghoa.Rows[i].Cells["thanhtien"].Value.ToString());
        //            num7 += 25;
        //            num5 += 25;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + num2), (float)(num7 - 5), 780f, 25f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + num2), (float)(num4 - 5), 30f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(365 + num2), (float)(num4 - 5), 55f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(420 + num2), (float)(num4 - 5), 65f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(560 + num2), (float)(num4 - 5), 100f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(660 + num2), (float)(num4 - 5), 125f, (float)num5);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    e.Graphics.DrawString("CỘNG:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7));
        //    e.Graphics.DrawString(Convert.ToDouble(this.tongngay).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    num7 += 25;
        //    e.Graphics.DrawString("TỔNG CỘNG:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7));
        //    e.Graphics.DrawString(this.tongtienhh.ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 12));
        //    num7 -= 25;
        //    DataTable dataTable = new DataTable();
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    string cmdText = string.Concat(new string[]
        //    {
        //        "SELECT isnull(SUM(GIAMTIEN),0) AS CONGGIAM,isnull(SUM(CASE WHEN PHANTRAM<0 THEN -TIENPHANTRAM ELSE TIENPHANTRAM END),0) AS PHANTRAM,isnull(SUM(TIENVAT),0) AS TIENVAT\r\nfrom TB_HOADONBANHANG HD\r\nWHERE HD.HINHTHUC='2' AND HD.HUYHD='FALSE' AND HD.MAKHACHHANG='",
        //        this.txtmakhachhang.Text,
        //        "' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //        Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //        "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //        Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
        //        "'"
        //    });
        //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //    sqlConnection.Open();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //    sqlDataAdapter.Fill(dataTable);
        //    double num8 = double.Parse(dataTable.Rows[0][0].ToString());
        //    double num9 = double.Parse(dataTable.Rows[0][1].ToString());
        //    double num10 = double.Parse(dataTable.Rows[0][2].ToString());
        //    if (num8 + num9 > 0.0)
        //    {
        //        e.Graphics.DrawString("CỘNG TIỀN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num8 + num9).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    if (num8 + num9 < 0.0)
        //    {
        //        e.Graphics.DrawString("TRỪ TIỀN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num8 + num9).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    if (num10 > 0.0)
        //    {
        //        e.Graphics.DrawString("TIỀN VAT:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //        e.Graphics.DrawString(Convert.ToDecimal(num10).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 50), stringFormat2);
        //        e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //        num7 += 25;
        //    }
        //    num7 += 25;
        //    e.Graphics.DrawString("NỢ CŨ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 25));
        //    e.Graphics.DrawString(Convert.ToDecimal(this.txtnodauky.Text).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 25), stringFormat2);
        //    e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 37));
        //    e.Graphics.DrawString("ĐÃ TRẢ:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 50));
        //    e.Graphics.DrawString(Convert.ToDecimal(this.txtdathu.Text).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 50), stringFormat2);
        //    e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 62));
        //    e.Graphics.DrawString("PHẢI THANH TOÁN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7 + 77));
        //    e.Graphics.DrawString(Convert.ToDecimal(this.txtphaithu.Text).ToString("#,##0"), new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(660 + num2, num7 + 75), stringFormat2);
        //    e.Graphics.DrawString("--------------------------------------------------------------------------------", new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, new Point(380 + num2, num7 + 87));
        //    e.Graphics.DrawString(string.Concat(new object[]
        //    {
        //        "                                                              Ngày ",
        //        DateTime.Now.Day,
        //        " tháng ",
        //        DateTime.Now.Month,
        //        " năm ",
        //        DateTime.Now.Year
        //    }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7 + 100), stringFormat2);
        //    e.Graphics.DrawString("                 KHÁCH HÀNG                                                             NGƯỜI LẬP PHIẾU", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(350 + num2, num7 + 125), stringFormat);
        //    this.xem = 1;
        //}

        //// Token: 0x06000CF8 RID: 3320 RVA: 0x001C5438 File Offset: 0x001C3638
        //private void Print_ls_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    if (this.xem != 0)
        //    {
        //        this.xem = 0;
        //        this.tongtienhh = 0m;
        //        this.tongngay = 0m;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        this.numberOfItemsPerPage = 0;
        //        this.lanin = 0;
        //    }
        //    int num = 5;
        //    int num2 = int.Parse(this.txtletrai.Text);
        //    int num3 = 5;
        //    StringFormat stringFormat = new StringFormat();
        //    stringFormat.Alignment = StringAlignment.Center;
        //    StringFormat stringFormat2 = new StringFormat();
        //    stringFormat2.Alignment = StringAlignment.Far;
        //    int num4 = 0;
        //    int num5 = 0;
        //    if (this.lanin == 0)
        //    {
        //        this.dong = 28;
        //        this.numberOfItemsPerPage = 0;
        //        this.numberOfItemsPrintedSoFar = 0;
        //        e.Graphics.DrawString(this.chObj.Tencongty, new Font("Arial", (float)this.chObj.Cochuten, FontStyle.Bold), Brushes.Black, new Point(5 + num2, num3 + num));
        //        e.Graphics.DrawString(this.chObj.Diachi, new Font("Arial", (float)this.chObj.Cochudiachi, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 25));
        //        e.Graphics.DrawString(this.chObj.Dienthoai, new Font("Arial", (float)this.chObj.Cochudienthoai, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num3 + num + 50));
        //        int num6 = num3 + num + 75 + 25;
        //        e.Graphics.DrawString(this.chObj.Tieude1, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(620 + num2, num3 + num), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude2, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 25), stringFormat);
        //        e.Graphics.DrawString(this.chObj.Tieude3, new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(620 + num2, num3 + num + 45), stringFormat);
        //        e.Graphics.DrawString("CHI TIẾT CÔNG NỢ", new Font("Arial", 16f, FontStyle.Bold), Brushes.Black, new Point(370 + num2, num6 - 25), stringFormat);
        //        num6 += 27;
        //        e.Graphics.DrawString("Từ ngày " + this.dttungay.Text + " đến ngày " + this.dtdenngay.Text, new Font("Arial", 11f, FontStyle.Italic), Brushes.Black, new Point(350 + num2, num6 - 25), stringFormat);
        //        e.Graphics.DrawString("Khách Hàng: ", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num6));
        //        e.Graphics.DrawString(this.txttenkhachhang.Text, new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(100 + num2, num6));
        //        num4 = num6 + 30;
        //        num5 = 40;
        //    }
        //    else
        //    {
        //        num4 = num3;
        //        num5 = 70;
        //    }
        //    e.Graphics.DrawString("TT", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(5 + num2, num4 + 7));
        //    e.Graphics.DrawString("NGÀY GIAO DỊCH", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(50 + num2, num4 + 7));
        //    e.Graphics.DrawString("SỐ TIỀN NỢ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(300 + num2, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("SỐ TIỀN TRẢ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(500 + num2, num4 + 7), stringFormat);
        //    e.Graphics.DrawString("GHI CHÚ", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(680 + num2, num4 + 7), stringFormat2);
        //    int num7 = num4 + 40;
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + num2), (float)(num4 - 5), 700f, 40f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    if (this.lanin == 0)
        //    {
        //        if (this.txtnodauky.Text != "0")
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + num2), (float)(num7 - 5), 700f, 30f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            e.Graphics.DrawString("Nợ đầu kỳ", new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(35 + num2, num7));
        //            e.Graphics.DrawString(Convert.ToDecimal(this.txtnodauky.Text).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, new Point(400 + num2, num7), stringFormat2);
        //            num7 = num4 + 70;
        //            num5 += 30;
        //        }
        //        else
        //        {
        //            num7 = num4 + 40;
        //        }
        //    }
        //    for (int i = this.numberOfItemsPrintedSoFar; i < this.dgvcongnokhachhang.RowCount; i++)
        //    {
        //        this.numberOfItemsPerPage++;
        //        if (this.numberOfItemsPerPage > 30)
        //        {
        //            this.lanin = 1;
        //            this.dong = 32;
        //            this.numberOfItemsPerPage = 0;
        //            e.HasMorePages = true;
        //            return;
        //        }
        //        this.numberOfItemsPrintedSoFar++;
        //        if (this.numberOfItemsPrintedSoFar <= this.dgvcongnokhachhang.Rows.Count)
        //        {
        //            using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //            {
        //                RectangleF value = new RectangleF((float)(5 + num2), (float)(num7 - 5), 700f, 30f);
        //                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //            }
        //            e.Graphics.DrawString(this.dgvcongnokhachhang.Rows[i].Cells["tt"].Value.ToString(), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(18 + num2, num7), stringFormat);
        //            e.Graphics.DrawString(this.dgvcongnokhachhang.Rows[i].Cells["NGAY"].Value.ToString(), new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(35 + num2, num7));
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["TIENNO"].Value.ToString()).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(400 + num2, num7), stringFormat2);
        //            e.Graphics.DrawString(Convert.ToDouble(this.dgvcongnokhachhang.Rows[i].Cells["DATHU"].Value.ToString()).ToString("#,##0"), new Font("Arial", 12f, FontStyle.Regular), Brushes.Black, new Point(600 + num2, num7), stringFormat2);
        //            num7 += 30;
        //            num5 += 30;
        //        }
        //        else
        //        {
        //            e.HasMorePages = false;
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF value = new RectangleF((float)(5 + num2), (float)(num4 - 5), 30f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF value = new RectangleF((float)(200 + num2), (float)(num4 - 5), 200f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //        }
        //        using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //        {
        //            RectangleF value = new RectangleF((float)(600 + num2), (float)(num4 - 5), 1f, (float)num5);
        //            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //        }
        //    }
        //    using (new Font("Arial", 11f, FontStyle.Italic, GraphicsUnit.Point))
        //    {
        //        RectangleF value = new RectangleF((float)(5 + num2), (float)(num7 - 5), 700f, 30f);
        //        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(value));
        //    }
        //    e.Graphics.DrawString("PHẢI THANH TOÁN:", new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(35 + num2, num7));
        //    e.Graphics.DrawString(Convert.ToDecimal(this.txtphaithu.Text).ToString("#,##0"), new Font("Arial", 13f, FontStyle.Bold), Brushes.Black, new Point(600 + num2, num7), stringFormat2);
        //    e.Graphics.DrawString(string.Concat(new object[]
        //    {
        //        "                                                              Ngày ",
        //        DateTime.Now.Day,
        //        " tháng ",
        //        DateTime.Now.Month,
        //        " năm ",
        //        DateTime.Now.Year
        //    }), new Font("Arial", 11f, FontStyle.Regular), Brushes.Black, new Point(660 + num2, num7 + 30), stringFormat2);
        //    e.Graphics.DrawString("                 KHÁCH HÀNG                                                             NGƯỜI LẬP PHIẾU", new Font("Arial", 11f, FontStyle.Bold), Brushes.Black, new Point(350 + num2, num7 + 50), stringFormat);
        //    this.xem = 1;
        //}

        //// Token: 0x06000CF9 RID: 3321 RVA: 0x001C6090 File Offset: 0x001C4290
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    if (this.lanhomkhachhang == "")
        //    {
        //        Frmnhomkhachhang frmnhomkhachhang = new Frmnhomkhachhang();
        //        frmnhomkhachhang.ShowDialog();
        //        this.txtmakhachhang.Text = Frmnhomkhachhang.madonvi;
        //        this.txttenkhachhang.Text = Frmnhomkhachhang.tendonvi;
        //        this.lanhomkhachhang = Frmnhomkhachhang.nhomkhachhang;
        //    }
        //    this.doanhthu_nhomkhachhang();
        //    this.xuatexcel_chitiet_nhomkhachhang();
        //}

        //// Token: 0x06000CFA RID: 3322 RVA: 0x001C6100 File Offset: 0x001C4300
        //private void xuatexcel_chitiet_nhomkhachhang()
        //{
        //    this.loadcauhinh();
        //    if (this.dgvnhomkhachhang.RowCount > 0)
        //    {
        //        Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
        //        Workbook workbook = application.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "\\EXCEL\\CHITIETBANHANG_KHACHHANG.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1 = CallSite<Func<CallSite, object, Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Worksheet), typeof(Frmchitietcongnophaithu)));
        //        }
        //        Worksheet worksheet = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1.Target(Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site1, workbook.Worksheets.get_Item(1));
        //        application.Visible = true;
        //        worksheet.Cells[1, 1] = this.chObj.Tencongty;
        //        worksheet.Cells[2, 1] = this.chObj.Diachi;
        //        worksheet.Cells[3, 1] = this.chObj.Dienthoai;
        //        worksheet.Cells[5, 1] = "Từ 00:00 " + this.dttungay.Text + " đến 23:59 " + this.dtdenngay.Text;
        //        worksheet.Cells[6, 1] = "Khách Hàng: " + this.txttenkhachhang.Text;
        //        int num = 7;
        //        Range range;
        //        for (int i = 0; i < this.dgvnhomkhachhang.Rows.Count; i++)
        //        {
        //            num++;
        //            for (int j = 0; j < this.dgvnhomkhachhang.Columns.Count; j++)
        //            {
        //                worksheet.Cells[i + 8, j + 1] = this.dgvnhomkhachhang.Rows[i].Cells[j].Value;
        //            }
        //            if (this.dgvnhomkhachhang.Rows[i].Cells[2].Value == null && this.dgvnhomkhachhang.Rows[i].Cells[3].Value != null)
        //            {
        //                if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2 == null)
        //                {
        //                    Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //                    {
        //                        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
        //                        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
        //                    }));
        //                }
        //                Func<CallSite, object, bool, object> target = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2.Target;
        //                CallSite<> p__Site = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site2;
        //                if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3 == null)
        //                {
        //                    Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //                    {
        //                        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
        //                    }));
        //                }
        //                target(<> p__Site, Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3.Target(Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site3, worksheet.Cells[i + 8, 4]), true);
        //            }
        //            range = worksheet.get_Range("A" + num, "H" + num);
        //            range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        }
        //        range = worksheet.get_Range("A" + num, "H" + num);
        //        range.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        Range range2 = worksheet.get_Range("B" + 8, "B" + num);
        //        range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        range2 = worksheet.get_Range("D" + 8, "D" + num);
        //        range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        range2 = worksheet.get_Range("F" + 8, "F" + num);
        //        range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        range2 = worksheet.get_Range("H" + 8, "H" + num);
        //        range2.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        //        worksheet.Cells[this.dgvnhomkhachhang.RowCount + 9, 6] = string.Concat(new object[]
        //        {
        //            "Ngày ",
        //            DateTime.Now.Day,
        //            " tháng ",
        //            DateTime.Now.Month,
        //            " năm ",
        //            DateTime.Now.Year
        //        });
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
        //            }));
        //        }
        //        Func<CallSite, object, bool, object> target2 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4.Target;
        //        CallSite<> p__Site2 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site4;
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
        //            }));
        //        }
        //        target2(<> p__Site2, Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5.Target(Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site5, worksheet.Cells[this.dgvnhomkhachhang.RowCount + 10, 6]), true);
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Bold", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
        //            }));
        //        }
        //        Func<CallSite, object, bool, object> target3 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6.Target;
        //        CallSite<> p__Site3 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site6;
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Font", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
        //            }));
        //        }
        //        target3(<> p__Site3, Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7.Target(Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site7, worksheet.Cells[this.dgvnhomkhachhang.RowCount + 9, 6]), true);
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8 = CallSite<Func<CallSite, object, HorizontalAlignment, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "HorizontalAlignment", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
        //            }));
        //        }
        //        Func<CallSite, object, HorizontalAlignment, object> target4 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8.Target;
        //        CallSite<> p__Site4 = Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site8;
        //        if (Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9 == null)
        //        {
        //            Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Style", typeof(Frmchitietcongnophaithu), new CSharpArgumentInfo[]
        //            {
        //                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
        //            }));
        //        }
        //        target4(<> p__Site4, Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9.Target(Frmchitietcongnophaithu.< xuatexcel_chitiet_nhomkhachhang > o__SiteContainer0.<> p__Site9, worksheet.Cells[this.dgvnhomkhachhang.RowCount + 10, 6]), HorizontalAlignment.Center);
        //        worksheet.Cells[this.dgvnhomkhachhang.RowCount + 10, 6] = "NGƯỜI LẬP";
        //    }
        //}

        //// Token: 0x06000CFB RID: 3323 RVA: 0x001C6980 File Offset: 0x001C4B80
        //private void doanhthu_nhomkhachhang()
        //{
        //    if (this.dgvnhomkhachhang.Rows.Count > 0)
        //    {
        //        this.dgvnhomkhachhang.Rows.Clear();
        //        this.dgvnhomkhachhang.Refresh();
        //    }
        //    DataTable dataTable = new DataTable();
        //    string text = Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy");
        //    string text2 = Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy");
        //    string cmdText = string.Concat(new string[]
        //    {
        //        "SELECT KH.TENDONVI,RIGHT(CT.NGAYXUAT,10)+CASE WHEN HD.HINHTHUC='2' THEN N' -Nợ' else '' end AS Ngaytra,CT.MAHANGHOA, CT.TENHANGHOA,CT.DONVITINH,SUM(CT.TONGSOLUONG)AS TONGSOLUONG, SUM(CT.DONGIABAN*TONGSOLUONG)/SUM(TONGSOLUONG)AS DONGIABAN, SUM(THANHTIEN)AS THANHTIEN \r\nfrom TB_CHITIETHOADON CT, TB_HANGHOA HH,TB_HOADONBANHANG HD,Tb_KHACHHANG KH,TB_NHOMKHACHHANG NKH\r\nWHERE HD.HINHTHUC='2' AND HD.MAKHACHHANG=KH.MAKHACHHANG AND KH.NCC=NKH.MANHOM AND CT.HUY='FALSE' AND CT.MAHANGHOA=HH.MAHANGHOA AND HD.SOHOADON=CT.MAHOADON AND NKH.MANHOM='",
        //        this.txtmakhachhang.Text,
        //        "' AND CONVERT(DATETIME,NGAYXUAT,103)>='00:00 ",
        //        text,
        //        "' and CONVERT(DATETIME,NGAYXUAT,103)<='23:59 ",
        //        text2,
        //        "' GROUP BY KH.TENDONVI,HD.HINHTHUC,RIGHT(CT.NGAYXUAT,10), CT.TENHANGHOA,CT.DONVITINH,CT.MAHANGHOA HAVING SUM(TONGSOLUONG)!=0 ORDER BY KH.TENDONVI,HD.HINHTHUC,CONVERT(DATETIME, RIGHT(CT.NGAYXUAT,10),103)"
        //    });
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
        //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
        //    sqlConnection.Open();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        //    sqlDataAdapter.Fill(dataTable);
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        double num = 0.0;
        //        double num2 = 0.0;
        //        int num3 = 0;
        //        double num4 = 0.0;
        //        double num5 = 0.0;
        //        int num6 = 0;
        //        for (int i = 0; i < dataTable.Rows.Count; i++)
        //        {
        //            num3++;
        //            this.dgvnhomkhachhang.Rows.Add(1);
        //            num6 = this.dgvnhomkhachhang.Rows.Count - 1;
        //            if (i > 0 && dataTable.Rows[i][0].ToString() != dataTable.Rows[i - 1][0].ToString())
        //            {
        //                this.dgvnhomkhachhang["nngay", this.dgvnhomkhachhang.Rows.Count - 1].Value = "CỘNG";
        //                this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.BackColor = Color.Yellow;
        //                this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
        //                this.dgvnhomkhachhang["nthanhtien", num6].Value = num.ToString("#,##0");
        //                this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //                this.dgvnhomkhachhang["nsoluong", this.dgvnhomkhachhang.Rows.Count - 1].Value = num4.ToString("#,##0");
        //                num2 += num;
        //                num5 += num4;
        //                num4 = 0.0;
        //                num = 0.0;
        //                num3 = 1;
        //                num6++;
        //                this.dgvnhomkhachhang.Rows.Add(1);
        //            }
        //            if (i == 0 || dataTable.Rows[i][0].ToString() != dataTable.Rows[i - 1][0].ToString())
        //            {
        //                this.dgvnhomkhachhang["ntenhang", num6].Value = dataTable.Rows[i][0].ToString().ToUpper();
        //                this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
        //                this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //                this.dgvnhomkhachhang.Rows.Add(1);
        //                num6++;
        //            }
        //            this.dgvnhomkhachhang["ntt", num6].Value = num3;
        //            this.dgvnhomkhachhang["nngay", num6].Value = dataTable.Rows[i][1].ToString();
        //            this.dgvnhomkhachhang["nmahang", num6].Value = dataTable.Rows[i][2].ToString();
        //            this.dgvnhomkhachhang["ntenhang", num6].Value = dataTable.Rows[i][3].ToString();
        //            this.dgvnhomkhachhang["ndonvitinh", num6].Value = dataTable.Rows[i][4].ToString();
        //            this.dgvnhomkhachhang["nsoluong", num6].Value = double.Parse(dataTable.Rows[i][5].ToString()).ToString("#,##0.##");
        //            if (dataTable.Rows[i][1].ToString().Length > 10)
        //            {
        //                this.dgvnhomkhachhang["ndongia", num6].Value = double.Parse(dataTable.Rows[i][6].ToString()).ToString("#,##0.##");
        //                this.dgvnhomkhachhang["nthanhtien", num6].Value = double.Parse(dataTable.Rows[i][7].ToString()).ToString("#,##0.##");
        //                num += Convert.ToDouble(dataTable.Rows[i][7].ToString());
        //            }
        //            else
        //            {
        //                this.dgvnhomkhachhang["ndongia", num6].Value = 0;
        //                this.dgvnhomkhachhang["nthanhtien", num6].Value = 0;
        //            }
        //            num4 += double.Parse(dataTable.Rows[i][5].ToString());
        //        }
        //        this.dgvnhomkhachhang.Rows.Add(1);
        //        num6++;
        //        this.dgvnhomkhachhang["nngay", this.dgvnhomkhachhang.Rows.Count - 1].Value = "CỘNG";
        //        this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.BackColor = Color.Yellow;
        //        this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.ForeColor = Color.Red;
        //        this.dgvnhomkhachhang["nthanhtien", num6].Value = num.ToString("#,##0");
        //        this.dgvnhomkhachhang.Rows[num6].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //        this.dgvnhomkhachhang["nsoluong", this.dgvnhomkhachhang.Rows.Count - 1].Value = num4.ToString("#,##0");
        //        num2 += num;
        //        num5 += num4;
        //        num6++;
        //        this.dgvnhomkhachhang.Rows.Add(1);
        //        int num7 = this.dgvnhomkhachhang.Rows.Count - 1;
        //        this.dgvnhomkhachhang["ntenhang", num7].Value = "TỔNG";
        //        this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //        this.dgvnhomkhachhang["nthanhtien", num7].Value = num2.ToString("#,##0");
        //        this.dgvnhomkhachhang["nsoluong", num7].Value = num5.ToString("#,##0");
        //        this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //        this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
        //        this.dgvnhomkhachhang.BringToFront();
        //        if (TrangChu.CONGNO == "True")
        //        {
        //            sqlConnection.Close();
        //            double num8 = 0.0;
        //            double num9 = 0.0;
        //            double num10 = 0.0;
        //            double num11 = 0.0;
        //            string cmdText2 = "select isnull(SUM(SOTIEN),0) from tb_TONDAUKY TD,Tb_KHACHHANG kh where MA='thu' and TD.MAKH =KH.MAKHACHHANG AND KH.NCC='" + this.txtmakhachhang.Text + "'";
        //            SqlCommand sqlCommand = new SqlCommand(cmdText2, sqlConnection);
        //            sqlConnection.Open();
        //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //            while (sqlDataReader.Read())
        //            {
        //                num8 = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
        //            }
        //            sqlConnection.Close();
        //            string cmdText3 = string.Concat(new string[]
        //            {
        //                "DELETE FROM TB_CONGNOPHAITHUTHEOKHACHHANG DELETE FROM TB_DATHU DELETE FROM TB_CONGNO select isnull(SUM(SOTIEN),0)+ isnull(SUM(TIENTRANO),0) from Tb_THUCHI TC,Tb_KHACHHANG kh  where TC.MAKH=KH.MAKHACHHANG AND KH.NCC='",
        //                this.txtmakhachhang.Text,
        //                "' AND Thuchi='THU' and CONVERT(DATETIME,NGAY,103)<'",
        //                Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //                "'"
        //            });
        //            SqlCommand sqlCommand2 = new SqlCommand(cmdText3, sqlConnection);
        //            sqlConnection.Open();
        //            sqlDataReader = sqlCommand2.ExecuteReader();
        //            while (sqlDataReader.Read())
        //            {
        //                num9 = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
        //            }
        //            sqlConnection.Close();
        //            string cmdText4 = string.Concat(new string[]
        //            {
        //                "select isnull(SUM(THANHTOAN-DUATRUOC),0) from tb_hoadonbanhang bh,Tb_KHACHHANG kh  where hinhthuc='2' AND BH.MAKHACHHANG=KH.MAKHACHHANG AND KH.NCC ='",
        //                this.txtmakhachhang.Text,
        //                "' and CONVERT(DATETIME,NGAY,103)<'00:00 ",
        //                Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //                "' and HUYHD ='false'"
        //            });
        //            SqlCommand sqlCommand3 = new SqlCommand(cmdText4, sqlConnection);
        //            sqlConnection.Open();
        //            sqlDataReader = sqlCommand3.ExecuteReader();
        //            while (sqlDataReader.Read())
        //            {
        //                double num12 = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
        //                num10 = num12 + num8 - num9;
        //            }
        //            sqlConnection.Close();
        //            string cmdText5 = string.Concat(new string[]
        //            {
        //                "DELETE FROM TB_CONGNOPHAITHUTHEOKHACHHANG DELETE FROM TB_DATHU DELETE FROM TB_CONGNO select isnull(SUM(SOTIEN),0)+ isnull(SUM(TIENTRANO),0) from Tb_THUCHI TC,Tb_KHACHHANG kh  where TC.MAKH=KH.MAKHACHHANG AND KH.NCC='",
        //                this.txtmakhachhang.Text,
        //                "' AND Thuchi='THU' and CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //                Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //                "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //                Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
        //                "'"
        //            });
        //            SqlCommand sqlCommand4 = new SqlCommand(cmdText5, sqlConnection);
        //            sqlConnection.Open();
        //            sqlDataReader = sqlCommand4.ExecuteReader();
        //            while (sqlDataReader.Read())
        //            {
        //                num11 = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
        //            }
        //            sqlConnection.Close();
        //            string cmdText6 = string.Concat(new string[]
        //            {
        //                "select isnull(SUM(DUATRUOC),0) from tb_hoadonbanhang bh,Tb_KHACHHANG kh  where hinhthuc='2' AND BH.MAKHACHHANG=KH.MAKHACHHANG AND KH.NCC ='",
        //                this.txtmakhachhang.Text,
        //                "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //                Convert.ToDateTime(this.dtdenngay.Text).ToString("MM/dd/yyyy"),
        //                "' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //                Convert.ToDateTime(this.dttungay.Text).ToString("MM/dd/yyyy"),
        //                "' and HUYHD ='false'"
        //            });
        //            SqlCommand sqlCommand5 = new SqlCommand(cmdText6, sqlConnection);
        //            sqlConnection.Open();
        //            sqlDataReader = sqlCommand5.ExecuteReader();
        //            while (sqlDataReader.Read())
        //            {
        //                double num13 = double.Parse(Convert.ToString(sqlDataReader.GetValue(0)));
        //                num11 += num13;
        //            }
        //            sqlConnection.Close();
        //            DataTable dataTable2 = new DataTable();
        //            sqlConnection.Close();
        //            string cmdText7 = string.Concat(new string[]
        //            {
        //                "SELECT ISNULL(SUM(GIAMTIEN),0) AS CONGGIAM,ISNULL(SUM(CASE WHEN PHANTRAM<0 THEN -TIENPHANTRAM ELSE TIENPHANTRAM END),0) AS PHANTRAM,ISNULL(SUM(TIENVAT),0) AS TIENVAT\r\nfrom TB_HOADONBANHANG HD,Tb_KHACHHANG KH\r\nWHERE KH.MAKHACHHANG=HD.MAKHACHHANG AND HD.HINHTHUC='2' AND HD.HUYHD='FALSE' AND KH.NCC='",
        //                this.txtmakhachhang.Text,
        //                "' AND CONVERT(DATETIME,NGAY,103)>='00:00 ",
        //                text,
        //                "' and CONVERT(DATETIME,NGAY,103)<='23:59 ",
        //                text2,
        //                "'"
        //            });
        //            SqlCommand selectCommand2 = new SqlCommand(cmdText7, sqlConnection);
        //            sqlConnection.Open();
        //            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(selectCommand2);
        //            sqlDataAdapter2.Fill(dataTable2);
        //            double num14 = double.Parse(dataTable2.Rows[0][0].ToString());
        //            double num15 = double.Parse(dataTable2.Rows[0][1].ToString());
        //            double num16 = double.Parse(dataTable2.Rows[0][2].ToString());
        //            if (num14 + num15 > 0.0)
        //            {
        //                this.dgvnhomkhachhang.Rows.Add(1);
        //                num7++;
        //                this.dgvnhomkhachhang["ntenhang", num7].Value = "CỘNG TIỀN";
        //                this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //                this.dgvnhomkhachhang["nthanhtien", num7].Value = (num14 + num15).ToString("#,##0");
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //            }
        //            if (num14 + num15 < 0.0)
        //            {
        //                this.dgvnhomkhachhang.Rows.Add(1);
        //                num7++;
        //                this.dgvnhomkhachhang["ntenhang", num7].Value = "TRỪ TIỀN";
        //                this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //                this.dgvnhomkhachhang["nthanhtien", num7].Value = (num14 + num15).ToString("#,##0");
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //            }
        //            if (num16 > 0.0)
        //            {
        //                this.dgvnhomkhachhang.Rows.Add(1);
        //                num7++;
        //                this.dgvnhomkhachhang["ntenhang", num7].Value = "TIỀN VAT";
        //                this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //                this.dgvnhomkhachhang["nthanhtien", num7].Value = num16.ToString("#,##0");
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //                this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold);
        //            }
        //            this.dgvnhomkhachhang.Rows.Add(1);
        //            num7++;
        //            this.dgvnhomkhachhang["ntenhang", num7].Value = "NỢ ĐẦU KỲ";
        //            this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //            this.dgvnhomkhachhang["nthanhtien", num7].Value = num10.ToString("#,##0");
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
        //            this.dgvnhomkhachhang.Rows.Add(1);
        //            num7++;
        //            this.dgvnhomkhachhang["ntenhang", num7].Value = "ĐÃ TRẢ - TẠM ỨNG";
        //            this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //            this.dgvnhomkhachhang["nthanhtien", num7].Value = num11.ToString("#,##0");
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
        //            this.dgvnhomkhachhang.Rows.Add(1);
        //            num7++;
        //            this.dgvnhomkhachhang["ntenhang", num7].Value = "NỢ CÒN LẠI";
        //            this.dgvnhomkhachhang.Rows[num7].DefaultCellStyle.BackColor = Color.DarkBlue;
        //            this.dgvnhomkhachhang["nthanhtien", num7].Value = (num2 + num10 - num11 + num14 + num15 + num16).ToString("#,##0");
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
        //            this.dgvnhomkhachhang.Rows[this.dgvnhomkhachhang.Rows.Count - 1].DefaultCellStyle.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
        //        }
        //    }
        //}

        // Token: 0x06000CFC RID: 3324 RVA: 0x0001E3FD File Offset: 0x0001C5FD
        private void button5_Click(object sender, EventArgs e)
        {
            this.cbhienthichitiet.Checked = true;
            this.button1_Click(null, null);
        }

        // Token: 0x06000CFD RID: 3325 RVA: 0x0001E416 File Offset: 0x0001C616
        private void button6_Click(object sender, EventArgs e)
        {
            this.cbchitiethanghoa.Checked = true;
            this.button1_Click(null, null);
        }
    }
}
