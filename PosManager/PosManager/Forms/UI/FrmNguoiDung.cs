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
    public partial class FrmNguoiDung : Form
    {
        public FrmNguoiDung()
        {
            InitializeComponent();
        }
        public string mahoa(string pass)
        {
            // return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
            return null;
        }

        // Token: 0x0600029F RID: 671 RVA: 0x00097A64 File Offset: 0x00095C64
        private void Bingding()
        {
            this.txtMataikhoan.DataBindings.Clear();
            this.txtMataikhoan.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "Mataikhoan");
            this.txtTentaikhoan.DataBindings.Clear();
            this.txtTentaikhoan.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "Tentaikhoan");
            this.txtmatkhau.DataBindings.Clear();
            this.txtmatkhau.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "Matkhau");
            this.cobks.DataBindings.Clear();
            this.cobks.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "Macongty");
            this.cobmaytinh.DataBindings.Clear();
            this.cobmaytinh.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "Mamay");
            int rowIndex = this.dgvnguoidung.CurrentCell.RowIndex;
            string a = this.dgvnguoidung.Rows[rowIndex].Cells["Quyen"].Value.ToString().Trim();
            if (a == "1")
            {
                this.cobquyen.SelectedIndex = 0;
            }
            else if (a == "2")
            {
                this.cobquyen.SelectedIndex = 1;
            }
            else if (a == "3")
            {
                this.cobquyen.SelectedIndex = 2;
            }
            else if (a == "4")
            {
                this.cobquyen.SelectedIndex = 3;
            }
            this.comboBox1.DataBindings.Clear();
            this.comboBox1.DataBindings.Add("Text", this.dgvnguoidung.DataSource, "MACUAHANG");
        }

        // Token: 0x060002A0 RID: 672 RVA: 0x00097C88 File Offset: 0x00095E88
        private void En_Dis(bool e)
        {
            this.btthem.Visible = e;
            this.btsua.Visible = e;
            this.btxoa.Visible = e;
            this.btluu.Visible = !e;
            this.dgvnguoidung.Enabled = e;
            this.txtMataikhoan.Enabled = !e;
            this.txtmatkhau.Enabled = !e;
            this.cobquyen.Enabled = !e;
            this.txtTentaikhoan.Enabled = !e;
        }

        // Token: 0x060002A1 RID: 673 RVA: 0x00097D1C File Offset: 0x00095F1C
        private void Clear()
        {
            this.txtMataikhoan.Text = "";
            this.txtmatkhau.Text = "";
            this.txtTentaikhoan.Text = "";
            this.cobquyen.Text = "Nhân Viên";
        }

        // Token: 0x060002A2 RID: 674 RVA: 0x00097D70 File Offset: 0x00095F70
        //private void gandulieu(LogInObj liObj)
        //{
        //    liObj.Matk = this.txtMataikhoan.Text.Trim();
        //    liObj.Tentk = this.txtTentaikhoan.Text.Trim();
        //    liObj.Matkhau = this.mahoa(this.txtmatkhau.Text.Trim());
        //    liObj.Macongty = this.cobks.Text;
        //    if (this.cobquyen.SelectedIndex == 0)
        //    {
        //        liObj.Phanquyen = "1";
        //    }
        //    else if (this.cobquyen.SelectedIndex == 1)
        //    {
        //        liObj.Phanquyen = "2";
        //    }
        //    else if (this.cobquyen.SelectedIndex == 2)
        //    {
        //        liObj.Phanquyen = "3";
        //    }
        //    else if (this.cobquyen.SelectedIndex == 3)
        //    {
        //        liObj.Phanquyen = "4";
        //    }
        //    liObj.Maytinh = this.cobmaytinh.Text;
        //    liObj.Macuahang = this.comboBox1.Text;
        //}

        // Token: 0x060002A3 RID: 675 RVA: 0x00097E94 File Offset: 0x00096094
        private void LOAD_kho()
        {
            //try
            //{
            //    BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
            //    string cmdText = "SELECT MAKHO FROM TB_KHO ORDER BY MAKHO";
            //    SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //    sqlConnection.Open();
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(0)));
            //    }
            //    this.cobmaytinh.DataSource = null;
            //    this.cobmaytinh.DataSource = bindingList;
            //    this.cobmaytinh.ValueMember = "Key";
            //    this.cobmaytinh.DisplayMember = "Value";
            //    sqlConnection.Close();
            //}
            //catch
            //{
            //    Frm_kho frm_kho = new Frm_kho();
            //    frm_kho.ShowDialog();
            //}
        }

        // Token: 0x060002A4 RID: 676 RVA: 0x00097F80 File Offset: 0x00096180
        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
           // this.LOAD_kho();
           // BindingList<KeyValuePair<string, string>> bindingList = new BindingList<KeyValuePair<string, string>>();
           // SqlConnection sqlConnection = new SqlConnection();
           // sqlConnection.ConnectionString = "Data Source=" + frmLogIn.fileconnect;
           // SqlCommand sqlCommand = new SqlCommand("SELECT MACUAHANG FROM TB_CUAHANG ORDER BY MACUAHANG", sqlConnection);
           // sqlConnection.Open();
           // SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
           // while (sqlDataReader.Read())
           // {
           //     bindingList.Add(new KeyValuePair<string, string>(sqlDataReader.GetString(0), sqlDataReader.GetString(0)));
           // }
           // this.comboBox1.DataSource = null;
           // this.comboBox1.DataSource = bindingList;
           // this.comboBox1.ValueMember = "Key";
           // this.comboBox1.DisplayMember = "Value";
           // DataTable dataSource = new DataTable();
           //// dataSource = this.ctCtr.GetData();
           // this.cobks.DataSource = dataSource;
           // this.cobks.DisplayMember = "Macongty";
           // this.cobks.ValueMember = "Macongty";
           // DataTable dataSource2 = new DataTable();
           // dataSource2 = this.lictr.getData_Login();
           // this.dgvnguoidung.DataSource = dataSource2;
           // this.En_Dis(true);
           // this.Bingding();
           // if (frmLogIn.phanquyen != "1")
           // {
           //     this.btthem.Enabled = false;
           // }
        }

        // Token: 0x060002A5 RID: 677 RVA: 0x0001BE6A File Offset: 0x0001A06A
        private void btthem_Click(object sender, EventArgs e)
        {
            this.En_Dis(false);
            this.Clear();
         //   this.them = 0f;
            this.txtMataikhoan.Focus();
        }

        // Token: 0x060002A6 RID: 678 RVA: 0x000980D4 File Offset: 0x000962D4
        private void btsua_Click(object sender, EventArgs e)
        {
            this.En_Dis(false);
           // this.them = 1f;
            this.txtMataikhoan.Focus();
            this.txtMataikhoan.Enabled = false;
            if (frmLogIn.phanquyen != "1")
            {
                this.cobquyen.Enabled = false;
            }
        }

        // Token: 0x060002A7 RID: 679 RVA: 0x00098134 File Offset: 0x00096334
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (this.txtMataikhoan.Text == "admin")
            {
                MessageBox.Show("Không thể xóa người dùng này");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn người dùng từ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //if (this.lictr.DeleteDaTa_LogIn(this.txtMataikhoan.Text.Trim()))
                    //{
                    //    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //}
                }
                this.FrmNguoiDung_Load(sender, e);
            }
        }

        // Token: 0x060002A8 RID: 680 RVA: 0x000981E4 File Offset: 0x000963E4
        private void btluu_Click(object sender, EventArgs e)
        {
            //if (this.txtMataikhoan.Text == "")
            //{
            //    MessageBox.Show("Mã Người Dùng Không Được Rỗng");
            //    this.txtMataikhoan.Focus();
            //}
            //if (this.txtTentaikhoan.Text == "")
            //{
            //    MessageBox.Show("Tên Người Dùng Không Được Rỗng");
            //    this.txtTentaikhoan.Focus();
            //}
            //else
            //{
            //    this.gandulieu(this.liObj);
            //    if (this.them == 0f)
            //    {
            //        this.lictr.AddData_Login(this.liObj);
            //        this.FrmNguoiDung_Load(sender, e);
            //    }
            //    else if (this.txtmatkhau.TextLength > 15)
            //    {
            //        MessageBox.Show("VUI LÒNG NHẬP LẠI MẬT KHẨU", "THÔNG BÁO");
            //        this.txtmatkhau.Text = "";
            //        this.txtmatkhau.Focus();
            //    }
            //    else
            //    {
            //        this.lictr.UpdateData_logIn(this.liObj);
            //        this.FrmNguoiDung_Load(sender, e);
            //    }
            //}
        }

        // Token: 0x060002A9 RID: 681 RVA: 0x0009830C File Offset: 0x0009650C
        private void dgvnguoidung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvnguoidung.RowCount; i++)
            {
                this.dgvnguoidung.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x060002AA RID: 682 RVA: 0x00098360 File Offset: 0x00096560
        private void dgvnguoidung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
            }
        }

        // Token: 0x060002AB RID: 683 RVA: 0x00098384 File Offset: 0x00096584
        private void txtMataikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        // Token: 0x060002AC RID: 684 RVA: 0x0001BE93 File Offset: 0x0001A093
        private void dgvnguoidung_Click(object sender, EventArgs e)
        {
            this.Bingding();
        }
    }
}
