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
    public partial class Frmdinhluong : Form
    {
        public Frmdinhluong()
        {
            InitializeComponent();
        }
        private void LOADNHOMHANG()
        {
            //try
            //{
            //    DataTable dataTable = new DataTable();
            //    string cmdText = "SELECT * FROM TB_NHOMHANG";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //    sqlDataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        this.cobnhom.DataSource = dataTable;
            //        this.cobnhom.DisplayMember = "TENNHOM";
            //        this.cobnhom.ValueMember = "MANHOM";
            //        this.cobnhom.SelectedIndex = -1;
            //    }
            //}
            //catch
            //{
            //}
        }

        // Token: 0x0600006D RID: 109 RVA: 0x00027C14 File Offset: 0x00025E14
        private void tonkho_nguyenlieu()
        {
            //DataTable dataTable = new DataTable();
            //string text = Convert.ToDateTime(DateTime.Now.ToString()).ToString("MM/dd/yyyy");
            //string text2 = Convert.ToDateTime(DateTime.Now.ToString()).ToString("MM/dd/yyyy");
            //string cmdText = string.Concat(new string[]
            //{
            //    "DELETE TB_KHONHAPHANG_DAUKY INSERT INTO TB_KHONHAPHANG_DAUKY(MAHANG,SOLUONG,DONGIA)  ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM((HN.DONGIA)*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),'",
            //    text,
            //    "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //    text,
            //    "'))-1), DATEADD(mm,-1,'",
            //    text,
            //    "')),101) GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0) DELETE TB_KHOXUAT_DAUKY1  INSERT INTO TB_KHOXUAT_DAUKY1(MAHANG,SOLUONG,DONGIA)   ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),'",
            //    text,
            //    "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //    text,
            //    "'))-1), DATEADD(mm,-1,'",
            //    text,
            //    "')),101) GROUP BY HN.MAHANGHOA)         DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT * FROM TB_TON0_NL WHERE MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),DATEADD(mm,-1,'",
            //    text,
            //    "')),101))    AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),DATEADD(mm,-1,'",
            //    text,
            //    "')),101)))      DELETE TB_KHOXUAT_DAUKY2 INSERT INTO TB_KHOXUAT_DAUKY2(MAHANG,SOLUONG, DONGIA)   (SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT_DAUKY1 X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)    DELETE TB_TON0_2 INSERT INTO TB_TON0_2(MAHANG,SOLUONG,DONGIA)   (SELECT DL.MAHANGHOA,ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0),T.DONGIA FROM TB_NGUYENLIEU DL  LEFT JOIN TB_TON0_NL T   ON T.MAHANG= DL.MAHANGHOA LEFT JOIN TB_KHOXUAT_DAUKY2 K ON DL.MAHANGHOA=K.MAHANG  WHERE T.SOLUONG>0 AND ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0)>0 AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),   DATEADD(mm,-1,'",
            //    text,
            //    "')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),DATEADD(mm,-1,'",
            //    text,
            //    "')),101)) GROUP BY DL.MAHANGHOA,ISNULL(T.SOLUONG,0),ISNULL(K.SOLUONG,0),T.DONGIA)   DELETE TB_KHOXUAT_DAUKY INSERT INTO TB_KHOXUAT_DAUKY(MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA,ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0),'0' FROM TB_NGUYENLIEU HH LEFT JOIN TB_KHOXUAT_DAUKY2 K ON HH.MAHANGHOA=K.MAHANG LEFT JOIN TB_TON0_1 T ON T.MAHANG=HH.MAHANGHOA WHERE ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)>0)  DELETE [TB_TON1]  INSERT INTO [TB_TON1](MAHANG,SOLUONG,DONGIA,NGAY)       (SELECT NL.MAHANGHOA,SUM( ISNULL(B1.SOLUONG,0))-SUM(ISNULL(B2.SOLUONG,0)),SUM(ISNULL(B1.SOLUONG,0) *ISNULL(B1.DONGIA,0))/SUM(ISNULL(B1.SOLUONG,1)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text,
            //    "')),'00:00 ",
            //    text,
            //    "'),101)  FROM TB_NGUYENLIEU NL LEFT JOIN TB_KHONHAPHANG_DAUKY B1 ON NL.MAHANGHOA=B1.MAHANG LEFT JOIN TB_KHOXUAT_DAUKY B2 ON NL.MAHANGHOA=B2.MAHANG GROUP BY NL.MAHANGHOA HAVING sum(ISNULL(B1.SOLUONG,0))-sum(ISNULL(B2.SOLUONG,0))!=0)       DELETE TB_KHONHAPHANG INSERT INTO TB_KHONHAPHANG(MAHANG,SOLUONG,DONGIA)       (SELECT HN.MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG))     FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)> CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),'",
            //    text,
            //    "'),101) AND CONVERT(datetime,ngaynhap,103)<'",
            //    text,
            //    "'GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0)       DELETE TB_KHOXUAT INSERT INTO TB_KHOXUAT(MAHANG,SOLUONG,DONGIA)      ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)>'23:59 '      +CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //    text,
            //    "')),'",
            //    text,
            //    "'),101)AND CONVERT(datetime,ngaynhap,103)<'00:00 '+'",
            //    text,
            //    "'     GROUP BY HN.MAHANGHOA)  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY D.MANGUYENLIEU)   DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)        (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)ELSE '0' END,ISNULL(B1.DONGIA ,0)    FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_2 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG    WHERE ISNULL(B1.SOLUONG,0)>0 AND ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)!=0 )         DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(T2.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0)>0  THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0)    END ELSE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0) END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG) LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG   WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)      DELETE [TB_TON3] INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END AS DONGIA      FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) WHERE CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END!=0    GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0))       DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)           (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP_NL           WHERE CONVERT(datetime,ngaynhap,103)>='",
            //    text,
            //    "' AND CONVERT(datetime,ngaynhap,103)<='",
            //    text2,
            //    "' GROUP BY MAHANGHOA HAVING SUM(SOLUONG)!=0)             DELETE [TB_XUAT_TAM] INSERT INTO [TB_XUAT_TAM](MAHANG,SOLUONG,DONGIA)       ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE  CONVERT(datetime,NGAYNHAP,103)>= '00:00 ",
            //    text,
            //    "' AND CONVERT(datetime,NGAYNHAP,103)<='23:29 ",
            //    text2,
            //    "'        GROUP BY HN.MAHANGHOA HAVING SUM(HN.SOLUONG)!=0)         DELETE [TB_XUATTAM_1] INSERT INTO [TB_XUATTAM_1](MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM [TB_XUAT_TAM] X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)       DELETE [TB_TON0_4] INSERT INTO [TB_TON0_4](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0)FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_3 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG WHERE B1.SOLUONG!=0)     DELETE [TB_TON4]    INSERT INTO [TB_TON4](MAHANG,SOLUONG,DONGIA)     (SELECT HH.MAHANGHOA ,ISNULL(B2.SOLUONG,0)-(ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),ISNULL(B1.DONGIA ,0) FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_3 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)     DELETE [TB_TON5] INSERT INTO [TB_TON5](MAHANG,SOLUONG,DONGIA)      (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>=0THEN ISNULL(B2.SOLUONG,0)ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0)END,ISNULL(B2.DONGIA ,0)     FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON4 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_TON3 B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0) HAVING (ISNULL(B1.SOLUONG,0)+SUM(ISNULL(B2.SOLUONG,0)))!=0)     DELETE [TB_TON6] INSERT INTO [TB_TON6](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B.SOLUONG,0)END,ISNULL(B1.DONGIA ,0)     FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON5 B ON HH.MAHANGHOA=B.MAHANG)LEFT JOIN [TB_TONKHOCUOI] B1 ON HH.MAHANGHOA=B1.MAHANG GROUP BY HH.MAHANGHOA,    ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B.SOLUONG,0) HAVING ISNULL(B1.SOLUONG,0)!=0 AND SUM(ISNULL(B.SOLUONG,0))!=0 )      DELETE TB_KHONHAPHANG_HIENTAI INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON0_3 WHERE SOLUONG>0)       INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT * FROM TB_TON2 WHERE SOLUONG>0)INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)     (SELECT * FROM TB_TON3 WHERE SOLUONG!=0) DELETE TB_KHOXUAT_MOI INSERT INTO TB_KHOXUAT_MOI(MAHANG,SOLUONG,DONGIA)      (SELECT MAHANG,SUM(SOLUONG),SUM(SOLUONG*DONGIA)/SUM(ISNULL(SOLUONG,0)) FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG HAVING SUM(SOLUONG)!=0)     DELETE TB_TON0_NL WHERE YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text,
            //    "')),'00:00 ",
            //    text,
            //    "'),101))      AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text,
            //    "')),'00:00 ",
            //    text,
            //    "'),101))                INSERT INTO [TB_TON0_NL](MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT HH.MAHANGHOA,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))       /(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //    text2,
            //    "')),'00:00 ",
            //    text2,
            //    "'),101)        FROM TB_NGUYENLIEU HH LEFT JOIN TB_TON1 T1 ON T1.MAHANG=HH.MAHANGHOA LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG        WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)!=0)        DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG!=0  GROUP BY MAHANG)       DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG)        FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK          WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)        (SELECT DL.MANGUYENLIEU,SUM(ISNULL(NK.SOLUONG*DL.SL,0)),0 FROM TB_DINHLUONG DL LEFT JOIN [TB_XUATTRONGKY] NK         ON DL.MAHANGHOA=NK.MAHANG WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY DL.MANGUYENLIEU having SUM(SOLUONG)!=0)     DELETE TONKHO_NL  INSERT INTO TONKHO_NL(MAHANGHOA,SOLUONG,GIAVON)(  SELECT HH.MAHANGHOA,       (ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)) AS TON,     CASE WHEN ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)!=0         THEN CASE WHEN ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)>0   THEN CASE WHEN ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)!=0 THEN  ((ISNULL(NK.DONGIA,0)*(ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0)))+(ISNULL(TK.DONGIA,0)*ISNULL(TK.SOLUONG,0)))         /(ISNULL(TK.SOLUONG,0)+ISNULL(NK.SOLUONG,0)-ISNULL(XK.SOLUONG,0))  ELSE '0' END   ELSE ISNULL(TK.DONGIA,0) END ELSE '0' END AS GIAVON                FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_DK1 NK ON HH.MAHANGHOA=NK.MAHANG )LEFT JOIN TB_TK1 TK ON HH.MAHANGHOA=TK.MAHANG )LEFT JOIN TB_XTK1 XK        ON HH.MAHANGHOA=XK.MAHANG WHERE ISNULL(NK.SOLUONG,0)+ISNULL(TK.SOLUONG,0)-ISNULL(XK.SOLUONG,0) !=0)"
            //});
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        // Token: 0x0600006E RID: 110 RVA: 0x00027EF0 File Offset: 0x000260F0
        private void Frmdinhluong_Load(object sender, EventArgs e)
        {
            //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1252) / 2, 0, 1252, Screen.PrimaryScreen.WorkingArea.Height + 5);
            //this.LOADNHOMHANG();
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT NL.MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(SOLUONG,0)AS SL,ISNULL(GIAVON,0) AS GV FROM TB_NGUYENLIEU NL LEFT JOIN TONKHO_NL TK ON NL.MAHANGHOA = TK.MAHANGHOA";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtennguyenlieu.DataSource = dataTable;
            //this.loadhh();
            //if (TrangChu.dungkhonguyenlieu == "True")
            //{
            //    this.tonkho_nguyenlieu();
            //}
        }

        // Token: 0x0600006F RID: 111 RVA: 0x00027FC0 File Offset: 0x000261C0
        private void loadhh()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(DONGIA,0)AS DONGIA FROM TB_HANGHOA";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvhanghoa.DataSource = dataTable;
        }

        // Token: 0x06000070 RID: 112 RVA: 0x00028024 File Offset: 0x00026224
        private void cobnhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(DONGIA,0)AS DONGIA FROM TB_HANGHOA WHERE MANHOM=N'" + this.cobnhom.SelectedValue.ToString() + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvhanghoa.DataSource = dataTable;
        }

        // Token: 0x06000071 RID: 113 RVA: 0x000280A4 File Offset: 0x000262A4
        private void txttimten_Leave(object sender, EventArgs e)
        {
            //if (this.txttimma.Text == "")
            //{
            //    this.txttimma.Text = this.txttimma.Tag.ToString();
            //}
        }

        // Token: 0x06000072 RID: 114 RVA: 0x000280EC File Offset: 0x000262EC
        private void txttimten_Enter(object sender, EventArgs e)
        {
            //if (this.txttimten.Text == this.txttimten.Tag.ToString())
            //{
            //    this.txttimten.Text = "";
            //}
        }

        // Token: 0x06000073 RID: 115 RVA: 0x000280A4 File Offset: 0x000262A4
        private void txttimma_Leave(object sender, EventArgs e)
        {
            //if (this.txttimma.Text == "")
            //{
            //    this.txttimma.Text = this.txttimma.Tag.ToString();
            //}
        }

        // Token: 0x06000074 RID: 116 RVA: 0x00028134 File Offset: 0x00026334
        private void txttimma_Enter(object sender, EventArgs e)
        {
            //if (this.txttimma.Text == this.txttimma.Tag.ToString())
            //{
            //    this.txttimma.Text = "";
            //}
        }

        // Token: 0x06000075 RID: 117 RVA: 0x0002817C File Offset: 0x0002637C
        private void txttimma_TextChanged(object sender, EventArgs e)
        {
            //if (this.txttimma.Text != this.txttimma.Tag.ToString())
            //{
            //    if (this.txttimma.Text != "")
            //    {
            //        DataTable dataTable = new DataTable();
            //        string cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(DONGIA,0)AS DONGIA FROM TB_HANGHOA WHERE MAHANGHOA LIKE N'%" + this.txttimma.Text + "%'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvhanghoa.DataSource = dataTable;
            //    }
            //}
        }

        // Token: 0x06000076 RID: 118 RVA: 0x00028244 File Offset: 0x00026444
        private void txttimten_TextChanged(object sender, EventArgs e)
        {
            //if (this.txttimten.Text != this.txttimten.Tag.ToString())
            //{
            //    if (this.txttimten.Text != "")
            //    {
            //        DataTable dataTable = new DataTable();
            //        string cmdText = "SELECT MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(DONGIA,0)AS DONGIA FROM TB_HANGHOA WHERE TENHANGHOA LIKE N'%" + this.txttimten.Text + "%'";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvhanghoa.DataSource = dataTable;
            //    }
            //}
        }

        // Token: 0x06000077 RID: 119 RVA: 0x0002830C File Offset: 0x0002650C
        private void txttennl_Leave(object sender, EventArgs e)
        {
            //if (this.txttennl.Text == "")
            //{
            //    this.txttennl.Text = this.txttennl.Tag.ToString();
            //}
        }

        // Token: 0x06000078 RID: 120 RVA: 0x00028354 File Offset: 0x00026554
        private void txttennl_TextChanged(object sender, EventArgs e)
        {
            //if (this.txttennl.Text != this.txttennl.Tag.ToString())
            //{
            //    if (this.txttennl.Text != "")
            //    {
            //        DataTable dataTable = new DataTable();
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "SELECT NL.MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(SOLUONG,0)AS SL,ISNULL(GIAVON,0) AS GV FROM TB_NGUYENLIEU NL LEFT JOIN TONKHO_NL TK ON NL.MAHANGHOA = TK.MAHANGHOA WHERE NL.MAHANGHOA LIKE N'%",
            //            this.txttennl.Text,
            //            "%' OR TENHANGHOA LIKE N'%",
            //            this.txttennl.Text,
            //            "%'"
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvtennguyenlieu.DataSource = dataTable;
            //    }
            //    else
            //    {
            //        DataTable dataTable = new DataTable();
            //        string cmdText = "SELECT NL.MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(SOLUONG,0)AS SL,ISNULL(GIAVON,0) AS GV FROM TB_NGUYENLIEU NL LEFT JOIN TONKHO_NL TK ON NL.MAHANGHOA = TK.MAHANGHOA";
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //        sqlDataAdapter.Fill(dataTable);
            //        this.dgvtennguyenlieu.DataSource = dataTable;
            //    }
            //}
        }

        // Token: 0x06000079 RID: 121 RVA: 0x000284A4 File Offset: 0x000266A4
        private void txttennl_Enter(object sender, EventArgs e)
        {
            //if (this.txttennl.Text == this.txttennl.Tag.ToString())
            //{
            //    this.txttennl.Text = "";
            //}
        }

        // Token: 0x0600007A RID: 122 RVA: 0x000284EC File Offset: 0x000266EC
        private void dgvhanghoa_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvhanghoa.RowCount > 0)
            //{
            //    this.txttenhang.Text = this.dgvhanghoa.CurrentRow.Cells["Tenhang"].Value.ToString();
            //    this.txtmahang.Text = this.dgvhanghoa.CurrentRow.Cells["MAHANGHOA"].Value.ToString();
            //    this.loaddinhluong();
            //    this.txttennl.Focus();
            //}
        }

        // Token: 0x0600007B RID: 123 RVA: 0x00028584 File Offset: 0x00026784
        private void loaddinhluong()
        {
            //DataTable dataTable = new DataTable();
            //string cmdText = "select DL.MANGUYENLIEU,NL.TENHANGHOA,DL.DONVITINH,DL.SL,ISNULL(TK.GIAVON,0)AS GIAVON from tb_dinhluong DL LEFT JOIN TONKHO_NL TK ON TK.MAHANGHOA=DL.MANGUYENLIEU, TB_NGUYENLIEU NL WHERE DL.MANGUYENLIEU=NL.MAHANGHOA AND dL.MAHANGHOA='" + this.txtmahang.Text + "'";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvdl.DataSource = dataTable;
            //double num = 0.0;
            //double num2 = 0.0;
            //for (int i = 0; i < this.dgvdl.RowCount; i++)
            //{
            //    num += Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //    num2 += Convert.ToDouble(this.dgvdl.Rows[i].Cells["Giavon"].Value.ToString()) * Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //}
            //this.txttsl.Text = num.ToString();
            //this.txtthanhtien.Text = num2.ToString("#,##0");
        }

        // Token: 0x0600007C RID: 124 RVA: 0x00028700 File Offset: 0x00026900
        private void dgvtennguyenlieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvtennguyenlieu.RowCount > 0)
            //{
            //    int num = 0;
            //    for (int i = 0; i < this.dgvdl.RowCount; i++)
            //    {
            //        if (this.dgvtennguyenlieu.CurrentRow.Cells["manl"].Value.ToString() == this.dgvdl.Rows[i].Cells["manguyenlieu"].Value.ToString())
            //        {
            //            num = 1;
            //            break;
            //        }
            //    }
            //    if (num == 0)
            //    {
            //        if (this.txtmahang.Text != this.txtmahang.Tag.ToString())
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "INSERT INTO TB_DINHLUONG (MAHANGHOA,MANGUYENLIEU,DONVITINH,SL) values('",
            //                this.txtmahang.Text,
            //                "','",
            //                this.dgvtennguyenlieu.CurrentRow.Cells["manl"].Value.ToString(),
            //                "',N'",
            //                this.dgvtennguyenlieu.CurrentRow.Cells["donvitinh"].Value.ToString(),
            //                "','0')"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            this.loaddinhluong();
            //            this.txttennl.Focus();
            //        }
            //    }
            //}
        }

        // Token: 0x0600007D RID: 125 RVA: 0x000288C0 File Offset: 0x00026AC0
        private void dgvdl_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgvdl.RowCount > 0)
            //{
            //    int index = this.dgvdl.CurrentRow.Index;
            //    int columnIndex = this.dgvdl.CurrentCell.ColumnIndex;
            //    if (this.dgvdl.Columns[columnIndex].Name == "sl")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = string.Concat(new object[]
            //        {
            //            "UPDATE TB_DINHLUONG SET SL='",
            //            Convert.ToDouble(this.dgvdl.Rows[index].Cells["sl"].Value.ToString()),
            //            "' WHERE manguyenlieu ='",
            //            this.dgvdl.Rows[index].Cells["manguyenlieu"].Value.ToString(),
            //            "' AND MAHANGHOA='",
            //            this.txtmahang.Text,
            //            "'"
            //        });
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        double num = 0.0;
            //        double num2 = 0.0;
            //        for (int i = 0; i < this.dgvdl.RowCount; i++)
            //        {
            //            num += Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //            num2 += Convert.ToDouble(this.dgvdl.Rows[i].Cells["Giavon"].Value.ToString()) * Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //        }
            //        this.txttsl.Text = num.ToString();
            //        this.txtthanhtien.Text = num2.ToString("#,##0");
            //    }
            //}
        }

        // Token: 0x0600007E RID: 126 RVA: 0x00028B14 File Offset: 0x00026D14
        private void dgvdl_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvdl.RowCount > 0)
            //{
            //    int index = this.dgvdl.CurrentRow.Index;
            //    int columnIndex = this.dgvdl.CurrentCell.ColumnIndex;
            //    if (this.dgvdl.Columns[columnIndex].Name == "sl")
            //    {
            //        this.dgvdl.ReadOnly = false;
            //    }
            //    else
            //    {
            //        this.dgvdl.ReadOnly = true;
            //    }
            //    if (this.dgvdl.Columns[columnIndex].Name == "xoa")
            //    {
            //        Frmyesno.caption = "THÔNG BÁO XÓA";
            //        Frmyesno.text = "Bạn có muốn xóa " + this.dgvdl.CurrentRow.Cells["tennguyenlieu"].Value + " không?";
            //        Frmyesno frmyesno = new Frmyesno();
            //        frmyesno.ShowDialog();
            //        if (Frmyesno.dongy == "ok")
            //        {
            //            SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //            sqlConnection.Open();
            //            string cmdText = string.Concat(new string[]
            //            {
            //                "DELETE TB_DINHLUONG WHERE manguyenlieu ='",
            //                this.dgvdl.Rows[index].Cells["manguyenlieu"].Value.ToString(),
            //                "' AND MAHANGHOA='",
            //                this.txtmahang.Text,
            //                "'"
            //            });
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            sqlCommand.ExecuteNonQuery();
            //            this.dgvdl.Rows.RemoveAt(index);
            //            this.txttennl.Focus();
            //            if (this.dgvdl.RowCount > 0)
            //            {
            //                double num = 0.0;
            //                double num2 = 0.0;
            //                for (int i = 0; i < this.dgvdl.RowCount; i++)
            //                {
            //                    num += Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //                    num2 += Convert.ToDouble(this.dgvdl.Rows[i].Cells["Giavon"].Value.ToString()) * Convert.ToDouble(this.dgvdl.Rows[i].Cells["sl"].Value.ToString());
            //                }
            //                this.txttsl.Text = num.ToString();
            //                this.txtthanhtien.Text = num2.ToString("#,##0");
            //            }
            //            else
            //            {
            //                this.txttsl.Text = "0";
            //                this.txtthanhtien.Text = "0";
            //            }
            //        }
            //    }
            //}
        }

        // Token: 0x0600007F RID: 127 RVA: 0x00028E38 File Offset: 0x00027038
        private void dgvtennguyenlieu_MouseClick(object sender, MouseEventArgs e)
        {
            //if (this.dgvtennguyenlieu.RowCount > 0)
            //{
            //    int columnIndex = this.dgvtennguyenlieu.CurrentCell.ColumnIndex;
            //    if (this.dgvtennguyenlieu.Columns[columnIndex].Name == "Them")
            //    {
            //        this.dgvtennguyenlieu_CellDoubleClick(null, null);
            //    }
            //}
        }

        // Token: 0x06000080 RID: 128 RVA: 0x00028EA0 File Offset: 0x000270A0
        private void txttennl_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down)
            //{
            //    this.dgvtennguyenlieu.Focus();
            //}
        }

        // Token: 0x06000081 RID: 129 RVA: 0x00028ECC File Offset: 0x000270CC
        private void dgvtennguyenlieu_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (this.dgvtennguyenlieu.RowCount > 0)
            //    {
            //        this.dgvtennguyenlieu_CellDoubleClick(null, null);
            //    }
            //}
        }

        // Token: 0x06000082 RID: 130 RVA: 0x00028F10 File Offset: 0x00027110
        private void Frmdinhluong_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1)
            //{
            //    this.txttennl.Focus();
            //}
            //if (e.KeyCode == Keys.F2)
            //{
            //    this.txttimma.Focus();
            //}
            //if (e.KeyCode == Keys.F3)
            //{
            //    this.txttimten.Focus();
            //}
        }

        // Token: 0x06000083 RID: 131 RVA: 0x00028F7C File Offset: 0x0002717C
        private void btnguyenlieu_Click(object sender, EventArgs e)
        {
            //Frmnguyenlieu frmnguyenlieu = new Frmnguyenlieu();
            //frmnguyenlieu.ShowDialog();
            //DataTable dataTable = new DataTable();
            //string cmdText = "SELECT NL.MAHANGHOA,TENHANGHOA,DONVITINH,ISNULL(SOLUONG,0)AS SL,ISNULL(GIAVON,0) AS GV FROM TB_NGUYENLIEU NL LEFT JOIN TONKHO_NL TK ON NL.MAHANGHOA = TK.MAHANGHOA";
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            //sqlDataAdapter.Fill(dataTable);
            //this.dgvtennguyenlieu.DataSource = dataTable;
        }

        // Token: 0x06000084 RID: 132 RVA: 0x00028FF0 File Offset: 0x000271F0
        private void button1_Click(object sender, EventArgs e)
        {
            //frmHangHoa frmHangHoa = new frmHangHoa();
            //frmHangHoa.ShowDialog();
            //this.txttimma.Text = frmHangHoa.Ma_hanghoa;
        }

        // Token: 0x06000085 RID: 133 RVA: 0x0001B778 File Offset: 0x00019978
        private void textBox1_Enter(object sender, EventArgs e)
        {
           // this.cobnhom.Focus();
        }
    }
}
