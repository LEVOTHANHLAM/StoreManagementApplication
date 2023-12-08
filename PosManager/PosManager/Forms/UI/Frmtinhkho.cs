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
    public partial class Frmtinhkho : Form
    {
        public Frmtinhkho()
        {
            InitializeComponent();
        }
        private void Frmtinhkho_Load(object sender, EventArgs e)
        {
           // this.maskedTextBox1.Text = Settings.Default.ngayhethong;
        }

        // Token: 0x060006A5 RID: 1701 RVA: 0x00132F20 File Offset: 0x00131120
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    sqlConnection.Open();
            //    string text = "";
            //    this.button1.Enabled = false;
            //    DateTime dateTime = Convert.ToDateTime(this.maskedTextBox1.Text);
            //    while (Convert.ToDateTime(dateTime.ToString("MM/yyyy")) < Convert.ToDateTime(DateTime.Now.ToString("MM/yyyy")))
            //    {
            //        int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            //        string text2 = dateTime.ToString("MM/01/yyyy");
            //        string text3 = dateTime.ToString("MM/" + num + "/yyyy");
            //        string text4 = Convert.ToDateTime(this.maskedTextBox1.Text).AddMonths(-2).ToString("MM/01/yyyy");
            //        string text5 = dateTime.ToString("MM/01/yyyy");
            //        string text6 = dateTime.ToString("MM/" + num + "/yyyy");
            //        string text7 = "";
            //        string text8 = "";
            //        SqlCommand sqlCommand = new SqlCommand("DELETE FROM TB_KHONHAPHANG_DAUKY", sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT HH.MAHANGHOA as MAHANG,SUM( HN.SOLUONGQUYDOI ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA,HN.LOAI AS MAKHO FROM TB_HANGHOANHAP HN,TB_HANGHOA HH WHERE ",
            //            text7,
            //            " HN.MAHANGHOA=HH.MAHANGHOA AND convert(datetime, ngaynhap,103) >= '",
            //            text5,
            //            "' AND convert(datetime, ngaynhap,103)<='",
            //            text6,
            //            "' GROUP BY HH.MAHANGHOA,HH.QUYDOI1,HN.LOAI having SUM( HN.SOLUONGQUYDOI )!=0"
            //        }), sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT HN.MAHANG,SUM( HN.SOLUONG ) AS SOLUONG,(SUM((HN.DONGIA/HH.QUYDOI1)*HN.SOLUONG)/SUM(HN.SOLUONG))*HH.QUYDOI1 AS DONGIA,HN.MAKHO FROM TB_TON0 HN,TB_HANGHOA HH WHERE ",
            //            text,
            //            " HN.MAHANG=HH.MAHANGHOA AND  NGAY = '",
            //            text4,
            //            "' GROUP BY HN.MAHANG,HH.QUYDOI1,HN.MAKHO having SUM( HN.SOLUONG)!=0"
            //        }), sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlCommand = new SqlCommand(string.Concat(new string[]
            //        {
            //            "INSERT INTO TB_KHONHAPHANG_DAUKY SELECT CT.MAHANGHOA,CASE WHEN CT.LOAI='A'THEN \tCASE WHEN ((HH.DONVITINH))=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)ELSE SUM(CT.TONGSOLUONG) END  WHEN CT.LOAI='B'THEN CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1) ELSE SUM(CT.TONGSOLUONG)+SUM(CT.TONGSOLUONG)* (HH.QUYDOI1-",
            //            TrangChu.tile,
            //            ")/HH.QUYDOI1 END WHEN CT.LOAI='C'THEN  CASE WHEN (HH.DONVITINH)=(CT.DONVITINH) THEN SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
            //            TrangChu.doicm,
            //            " ELSE SUM(CT.TONGSOLUONG*HH.QUYDOI1)/",
            //            TrangChu.doicm,
            //            " END END AS SL, '0' , CT.NCC  FROM TB_CHITIETHOADON CT,TB_HANGHOA HH WHERE ",
            //            text8,
            //            " CT.HUY='FALSE' AND HH.MAHANGHOA=CT.MAHANGHOA AND convert(datetime,  CT.NGAYXUAT,103) >= '00:00 ",
            //            text5,
            //            "' AND  convert(datetime,  CT.NGAYXUAT,103) <='23:59 ",
            //            text6,
            //            "' GROUP BY CT.MAHANGHOA,CT.DONVITINH,HH.DONVITINH,CT.LOAI,HH.QUYDOI1,CT.NCC"
            //        }), sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlCommand = new SqlCommand("DELETE FROM TB_TON0 WHERE NGAY='" + text5 + "'", sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        sqlCommand = new SqlCommand("INSERT INTO TB_TON0 SELECT MAHANG, SUM(SOLUONG) AS SOLUONG ,DONGIA,'" + text5 + "' AS NGAY, MAKHO FROM TB_KHONHAPHANG_DAUKY  GROUP BY MAHANG, DONGIA, MAKHO", sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        sqlCommand.Dispose();
            //        dateTime = dateTime.AddMonths(1);
            //    }
            //    MessageBox.Show("TÍNH THÀNH CÔNG", "THÔNG BÁO");
            //    TrangChu.ngaybanhang = DateTime.Now.ToString("dd/MM/yyyy");
            //    base.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("TÍNH KHÔNG THÀNH CÔNG", "THÔNG BÁO");
            //}
        }

        // Token: 0x060006A6 RID: 1702 RVA: 0x00133278 File Offset: 0x00131478
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.button1.Enabled = false;
            //    DateTime dateTime = Convert.ToDateTime(this.maskedTextBox1.Text);
            //    while (Convert.ToDateTime(dateTime.ToString("MM/yyyy")) < Convert.ToDateTime(DateTime.Now.ToString("MM/yyyy")))
            //    {
            //        int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            //        string text = dateTime.ToString("MM/01/yyyy");
            //        string text2 = dateTime.ToString("MM/" + num + "/yyyy");
            //        string cmdText = string.Concat(new string[]
            //        {
            //            "DELETE TB_KHONHAPHANG_DAUKY INSERT INTO TB_KHONHAPHANG_DAUKY(MAHANG,SOLUONG,DONGIA)  ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM((HN.DONGIA)*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),'",
            //            text,
            //            "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,-1,'",
            //            text,
            //            "'))-1),DATEADD(mm,-1,'",
            //            text,
            //            "')),101) GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0) DELETE TB_KHOXUAT_DAUKY1  INSERT INTO TB_KHOXUAT_DAUKY1(MAHANG,SOLUONG,DONGIA)   ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)<= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),'",
            //            text,
            //            "'),101) AND CONVERT(datetime,ngaynhap,103)>=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,'",
            //            text,
            //            "'))-1), DATEADD(mm,-1,'",
            //            text,
            //            "')),101) GROUP BY HN.MAHANGHOA)         DELETE TB_TON0_1  INSERT INTO TB_TON0_1(MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT * FROM TB_TON0_NL WHERE MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),DATEADD(mm,-1,'",
            //            text,
            //            "')),101))    AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),DATEADD(mm,-1,'",
            //            text,
            //            "')),101)))      DELETE TB_KHOXUAT_DAUKY2 INSERT INTO TB_KHOXUAT_DAUKY2(MAHANG,SOLUONG, DONGIA)   (SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT_DAUKY1 X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)    DELETE TB_TON0_2 INSERT INTO TB_TON0_2(MAHANG,SOLUONG,DONGIA)   (SELECT DL.MAHANGHOA,ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0),T.DONGIA FROM TB_NGUYENLIEU DL  LEFT JOIN TB_TON0_NL T   ON T.MAHANG= DL.MAHANGHOA LEFT JOIN TB_KHOXUAT_DAUKY2 K ON DL.MAHANGHOA=K.MAHANG  WHERE T.SOLUONG>0 AND ISNULL(T.SOLUONG,0)-ISNULL(K.SOLUONG,0)>0 AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),   DATEADD(mm,-1,'",
            //            text,
            //            "')),101)) AND YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),DATEADD(mm,-1,'",
            //            text,
            //            "')),101)) GROUP BY DL.MAHANGHOA,ISNULL(T.SOLUONG,0),ISNULL(K.SOLUONG,0),T.DONGIA)   DELETE TB_KHOXUAT_DAUKY INSERT INTO TB_KHOXUAT_DAUKY(MAHANG,SOLUONG,DONGIA)  (SELECT HH.MAHANGHOA,ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0),'0' FROM TB_NGUYENLIEU HH LEFT JOIN TB_KHOXUAT_DAUKY2 K ON HH.MAHANGHOA=K.MAHANG LEFT JOIN TB_TON0_1 T ON T.MAHANG=HH.MAHANGHOA WHERE ISNULL(K.SOLUONG,0)-ISNULL(T.SOLUONG,0)>0)  DELETE [TB_TON1]  INSERT INTO [TB_TON1](MAHANG,SOLUONG,DONGIA,NGAY)       (SELECT NL.MAHANGHOA,SUM( ISNULL(B1.SOLUONG,0))-SUM(ISNULL(B2.SOLUONG,0)),SUM(ISNULL(B1.SOLUONG,0) *ISNULL(B1.DONGIA,0))/SUM(ISNULL(B1.SOLUONG,1)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //            text,
            //            "')),'00:00 ",
            //            text,
            //            "'),101)  FROM TB_NGUYENLIEU NL LEFT JOIN TB_KHONHAPHANG_DAUKY B1 ON NL.MAHANGHOA=B1.MAHANG LEFT JOIN TB_KHOXUAT_DAUKY B2 ON NL.MAHANGHOA=B2.MAHANG GROUP BY NL.MAHANGHOA HAVING sum(ISNULL(B1.SOLUONG,0))-sum(ISNULL(B2.SOLUONG,0))!=0)       DELETE TB_KHONHAPHANG INSERT INTO TB_KHONHAPHANG(MAHANG,SOLUONG,DONGIA)       (SELECT HN.MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG))     FROM TB_HANGHOANHAP_NL HN WHERE CONVERT(datetime,ngaynhap,103)> CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),'",
            //            text,
            //            "'),101) AND CONVERT(datetime,ngaynhap,103)<'",
            //            text,
            //            "'GROUP BY HN.MAHANGHOA HAVING SUM(SOLUONG)!=0)       DELETE TB_KHOXUAT INSERT INTO TB_KHOXUAT(MAHANG,SOLUONG,DONGIA)      ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE CONVERT(datetime,ngaynhap,103)>'23:59 '      +CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('",
            //            text,
            //            "')),'",
            //            text,
            //            "'),101)AND CONVERT(datetime,ngaynhap,103)<'00:00 '+'",
            //            text,
            //            "'     GROUP BY HN.MAHANGHOA)  DELETE TB_KHOXUAT_1 INSERT INTO TB_KHOXUAT_1(MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM TB_KHOXUAT X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY D.MANGUYENLIEU)   DELETE [TB_TON0_3] INSERT INTO [TB_TON0_3](MAHANG,SOLUONG,DONGIA)        (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)ELSE '0' END,ISNULL(B1.DONGIA ,0)    FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_2 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG    WHERE ISNULL(B1.SOLUONG,0)>0 AND ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0)!=0 )         DELETE [TB_TON2] INSERT INTO [TB_TON2](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(T2.SOLUONG,0)>0 THEN CASE WHEN ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0)>0  THEN ISNULL(B1.SOLUONG,0)-(ISNULL(B2.SOLUONG,0)-ISNULL(T2.SOLUONG,0))ELSE ISNULL(B1.SOLUONG,0)    END ELSE ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0) END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG) LEFT JOIN TB_KHOXUAT_1 B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG   WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)      DELETE [TB_TON3] INSERT INTO [TB_TON3](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END,CASE WHEN ISNULL(B2.DONGIA ,0) >0 THEN ISNULL(B2.DONGIA ,0)ELSE ISNULL(B1.DONGIA ,0) END AS DONGIA      FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON2 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_KHONHAPHANG B2 ON HH.MAHANGHOA=B2.MAHANG) WHERE CASE WHEN ISNULL(B1.SOLUONG,0)>0 THEN ISNULL(B2.SOLUONG,0) ELSE (ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0))END!=0    GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0))       DELETE [TB_TONKHOCUOI] INSERT INTO [TB_TONKHOCUOI](MAHANG,SOLUONG,DONGIA)           (SELECT MAHANGHOA,SUM(ISNULL(SOLUONGQUYDOI,0)),SUM(ISNULL(SOLUONGQUYDOI,0)*ISNULL(DONGIA,0))/SUM(ISNULL(SOLUONGQUYDOI,1)) FROM TB_HANGHOANHAP_NL           WHERE CONVERT(datetime,ngaynhap,103)>='",
            //            text,
            //            "' AND CONVERT(datetime,ngaynhap,103)<='",
            //            text2,
            //            "' GROUP BY MAHANGHOA HAVING SUM(SOLUONG)!=0)             DELETE [TB_XUAT_TAM] INSERT INTO [TB_XUAT_TAM](MAHANG,SOLUONG,DONGIA)       ( SELECT HN.MAHANGHOA,SUM(ISNULL(HN.SOLUONGQUYDOI,0)),(SUM(HN.DONGIA*HN.SOLUONG)/SUM(HN.SOLUONG)) FROM TB_HANGHOANHAP HN WHERE  CONVERT(datetime,NGAYNHAP,103)>= '00:00 ",
            //            text,
            //            "' AND CONVERT(datetime,NGAYNHAP,103)<='23:29 ",
            //            text2,
            //            "'        GROUP BY HN.MAHANGHOA HAVING SUM(HN.SOLUONG)!=0)         DELETE [TB_XUATTAM_1] INSERT INTO [TB_XUATTAM_1](MAHANG,SOLUONG,DONGIA)(SELECT D.MANGUYENLIEU,SUM(SOLUONG*D.SL),'0' FROM [TB_XUAT_TAM] X,TB_DINHLUONG D WHERE X.MAHANG=D.MAHANGHOA GROUP BY MANGUYENLIEU)       DELETE [TB_TON0_4] INSERT INTO [TB_TON0_4](MAHANG,SOLUONG,DONGIA)       (SELECT HH.MAHANGHOA ,ISNULL(B1.SOLUONG,0)-ISNULL(B2.SOLUONG,0),ISNULL(B1.DONGIA ,0)FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON0_3 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG WHERE B1.SOLUONG!=0)     DELETE [TB_TON4]    INSERT INTO [TB_TON4](MAHANG,SOLUONG,DONGIA)     (SELECT HH.MAHANGHOA ,ISNULL(B2.SOLUONG,0)-(ISNULL(B1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),ISNULL(B1.DONGIA ,0) FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON1 B1 ON HH.MAHANGHOA= B1.MAHANG)LEFT JOIN [TB_XUATTAM_1] B2 ON HH.MAHANGHOA=B2.MAHANG LEFT JOIN TB_TON0_3 T2 ON HH.MAHANGHOA=T2.MAHANG WHERE (ISNULL(B1.SOLUONG,0)-ISNULL(T2.SOLUONG,0))- ISNULL(B2.SOLUONG,0)!=0)     DELETE [TB_TON5] INSERT INTO [TB_TON5](MAHANG,SOLUONG,DONGIA)      (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>=0THEN ISNULL(B2.SOLUONG,0)ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B2.SOLUONG,0)END,ISNULL(B2.DONGIA ,0)     FROM ((TB_NGUYENLIEU HH LEFT JOIN TB_TON4 B1 ON HH.MAHANGHOA=B1.MAHANG)LEFT JOIN TB_TON3 B2 ON HH.MAHANGHOA=B2.MAHANG) GROUP BY HH.MAHANGHOA,ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B2.DONGIA ,0),ISNULL(B2.SOLUONG,0) HAVING (ISNULL(B1.SOLUONG,0)+SUM(ISNULL(B2.SOLUONG,0)))!=0)     DELETE [TB_TON6] INSERT INTO [TB_TON6](MAHANG,SOLUONG,DONGIA)    (SELECT HH.MAHANGHOA ,CASE WHEN ISNULL(B1.SOLUONG,0)>0THEN ISNULL(B1.SOLUONG,0) ELSE ISNULL(B1.SOLUONG,0)+ISNULL(B.SOLUONG,0)END,ISNULL(B1.DONGIA ,0)     FROM (TB_NGUYENLIEU HH LEFT JOIN TB_TON5 B ON HH.MAHANGHOA=B.MAHANG)LEFT JOIN [TB_TONKHOCUOI] B1 ON HH.MAHANGHOA=B1.MAHANG GROUP BY HH.MAHANGHOA,    ISNULL(B1.DONGIA ,0),ISNULL(B1.SOLUONG,0),ISNULL(B.SOLUONG,0) HAVING ISNULL(B1.SOLUONG,0)!=0 AND SUM(ISNULL(B.SOLUONG,0))!=0 )      DELETE TB_KHONHAPHANG_HIENTAI INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA) (SELECT * FROM TB_TON0_3 WHERE SOLUONG>0)       INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)(SELECT * FROM TB_TON2 WHERE SOLUONG>0)INSERT INTO TB_KHONHAPHANG_HIENTAI(MAHANG,SOLUONG,DONGIA)     (SELECT * FROM TB_TON3 WHERE SOLUONG!=0) DELETE TB_KHOXUAT_MOI INSERT INTO TB_KHOXUAT_MOI(MAHANG,SOLUONG,DONGIA)      (SELECT MAHANG,SUM(SOLUONG),SUM(SOLUONG*DONGIA)/SUM(ISNULL(SOLUONG,0)) FROM TB_KHONHAPHANG_HIENTAI GROUP BY MAHANG HAVING SUM(SOLUONG)!=0)     DELETE TB_TON0_NL WHERE YEAR(NGAY)=YEAR(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //            text,
            //            "')),'00:00 ",
            //            text,
            //            "'),101))      AND MONTH(NGAY)=MONTH(CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //            text,
            //            "')),'00:00 ",
            //            text,
            //            "'),101))                INSERT INTO [TB_TON0_NL](MAHANG,SOLUONG,DONGIA,NGAY)      (SELECT HH.MAHANGHOA,ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0),(ISNULL(T1.SOLUONG,0)*ISNULL(T1.DONGIA,0)+ISNULL(T2.DONGIA,0)*ISNULL(T2.SOLUONG,0))       /(ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)),CONVERT(VARCHAR(25),DATEADD(dd,-(DAY('00:00 ",
            //            text2,
            //            "')),'00:00 ",
            //            text2,
            //            "'),101)        FROM TB_NGUYENLIEU HH LEFT JOIN TB_TON1 T1 ON T1.MAHANG=HH.MAHANGHOA LEFT JOIN TB_TON0_2 T2 ON HH.MAHANGHOA=T2.MAHANG        WHERE ISNULL(T1.SOLUONG,0)+ISNULL(T2.SOLUONG,0)!=0)        DELETE [TB_XUATTRONGKY] INSERT INTO [TB_XUATTRONGKY] (MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(SOLUONG),SUM(DONGIA/SOLUONG) FROM TB_XUAT_TAM WHERE SOLUONG!=0  GROUP BY MAHANG)       DELETE TB_DK1 INSERT INTO TB_DK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG)        FROM TB_KHOXUAT_MOI NK  WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_TK1 INSERT INTO TB_TK1(MAHANG,SOLUONG,DONGIA)       (SELECT MAHANG,SUM(ISNULL(NK.SOLUONG,0)),SUM(ISNULL(NK.DONGIA,0)*ISNULL(NK.SOLUONG,0))/SUM(SOLUONG) FROM TB_TONKHOCUOI NK          WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY NK.MAHANG)        DELETE TB_XTK1 INSERT INTO TB_XTK1(MAHANG,SOLUONG,DONGIA)        (SELECT DL.MANGUYENLIEU,SUM(ISNULL(NK.SOLUONG*DL.SL,0)),0 FROM TB_DINHLUONG DL LEFT JOIN [TB_XUATTRONGKY] NK         ON DL.MAHANGHOA=NK.MAHANG WHERE ISNULL(NK.SOLUONG,0)!=0 GROUP BY DL.MANGUYENLIEU having SUM(SOLUONG)!=0) "
            //        });
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlConnection.Open();
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        sqlConnection.Close();
            //        dateTime = dateTime.AddMonths(1);
            //    }
            //    MessageBox.Show("TÍNH THÀNH CÔNG", "THÔNG BÁO");
            //    TrangChu.ngaybanhang = DateTime.Now.ToString("dd/MM/yyyy");
            //    base.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("TÍNH KHÔNG THÀNH CÔNG", "THÔNG BÁO");
            //}
        }
    }
}
