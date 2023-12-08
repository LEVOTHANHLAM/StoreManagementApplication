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
    public partial class FrmInhoadonvat : Form
    {
        public FrmInhoadonvat()
        {
            InitializeComponent();
        }
        private void btkhachhang_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x0600073D RID: 1853 RVA: 0x00140DC0 File Offset: 0x0013EFC0
        private void btnhaphoadon_Click(object sender, EventArgs e)
        {
            //Frmxuathoadon.hoadon = "nhap";
            //Frmxuathoadon frmxuathoadon = new Frmxuathoadon();
            //base.Hide();
            //  frmxuathoadon.Show();
        }

        // Token: 0x0600073E RID: 1854 RVA: 0x00140DEC File Offset: 0x0013EFEC
        private void btmenu_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
            frmDoiMatKhau.Show();
        }

        // Token: 0x0600073F RID: 1855 RVA: 0x00140E08 File Offset: 0x0013F008
        private void FrmInhoadonvat_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string cmdText = string.Concat(new string[]
            //{
            //    "BACKUP DATABASE [CAN] TO DISK='",
            //    Application.StartupPath,
            //    "\\BACKUP",
            //    DateTime.Now.ToString("ddMMyy"),
            //    ".bak'"
            //});
            //SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            Application.Exit();
        }

        // Token: 0x06000740 RID: 1856 RVA: 0x00140E8C File Offset: 0x0013F08C
        private void btxuathoadon_Click(object sender, EventArgs e)
        {
            //Frmxuathoadon.hoadon = "xuat";
            //Frmxuathoadon frmxuathoadon = new Frmxuathoadon();
            //base.Hide();
            //frmxuathoadon.Show();
        }

        // Token: 0x06000741 RID: 1857 RVA: 0x00140EB8 File Offset: 0x0013F0B8
        private void btcaocaohoadon_Click_1(object sender, EventArgs e)
        {
            //Frmxuatnhaphoadon frmxuatnhaphoadon = new Frmxuatnhaphoadon();
            //base.Hide();
            //frmxuatnhaphoadon.Show();
        }

        // Token: 0x06000742 RID: 1858 RVA: 0x0001CDAB File Offset: 0x0001AFAB
        private void FrmInhoadonvat_Load(object sender, EventArgs e)
        {
            this.btxuathoadon.Focus();
        }

        // Token: 0x06000743 RID: 1859 RVA: 0x000B565C File Offset: 0x000B385C
        private void bt_Click(object sender, EventArgs e)
        {
            //Frmsohoadon frmsohoadon = new Frmsohoadon();
            //frmsohoadon.ShowDialog();
        }

        // Token: 0x06000744 RID: 1860 RVA: 0x00140EDC File Offset: 0x0013F0DC
        private void bttonkho_Click(object sender, EventArgs e)
        {
            //Frmhangtonkho frmhangtonkho = new Frmhangtonkho();
            //frmhangtonkho.ShowDialog();
        }

        // Token: 0x06000745 RID: 1861 RVA: 0x00140EF8 File Offset: 0x0013F0F8
        private void btkhachhang_Click_1(object sender, EventArgs e)
        {
            //Frmkhachhang frmkhachhang = new Frmkhachhang();
            //frmkhachhang.ShowDialog();
        }

        // Token: 0x06000746 RID: 1862 RVA: 0x00140F14 File Offset: 0x0013F114
        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn khởi tạo không", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    FrmNhapmatkhauxoa frmNhapmatkhauxoa = new FrmNhapmatkhauxoa();
            //    frmNhapmatkhauxoa.ShowDialog();
            //    if (FrmInhoadonvat.mk == "phanmemtoancau")
            //    {
            //        SqlConnection sqlConnection = new SqlConnection("Data Source=" + frmLogIn.fileconnect);
            //        sqlConnection.Open();
            //        string cmdText = "DELETE FROM TB_HANGHOANHAP";
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        sqlCommand.ExecuteNonQuery();
            //        string cmdText2 = "DELETE FROM TB_HANGHOAXUAT";
            //        SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection);
            //        sqlCommand2.ExecuteNonQuery();
            //        string cmdText3 = "DELETE FROM TB_HOADONNHAP";
            //        SqlCommand sqlCommand3 = new SqlCommand(cmdText3, sqlConnection);
            //        sqlCommand3.ExecuteNonQuery();
            //        string cmdText4 = "DELETE FROM TB_HOADONXUAT";
            //        SqlCommand sqlCommand4 = new SqlCommand(cmdText4, sqlConnection);
            //        sqlCommand4.ExecuteNonQuery();
            //        string cmdText5 = "DELETE FROM TB_KHACHHANG";
            //        SqlCommand sqlCommand5 = new SqlCommand(cmdText5, sqlConnection);
            //        sqlCommand5.ExecuteNonQuery();
            //        string cmdText6 = "DELETE FROM TB_HOADON";
            //        SqlCommand sqlCommand6 = new SqlCommand(cmdText6, sqlConnection);
            //        sqlCommand6.ExecuteNonQuery();
            //        MessageBox.Show("Xóa Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK);
            //    }
            //}
        }

        // Token: 0x06000747 RID: 1863 RVA: 0x0001B637 File Offset: 0x00019837
        private void smtimkiem_Click(object sender, EventArgs e)
        {
        }


        // Token: 0x06000749 RID: 1865 RVA: 0x00141080 File Offset: 0x0013F280


        // Token: 0x04000848 RID: 2120
        public static string mk = string.Empty;
    }
}
