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
   
    public partial class FrmNhanVien : Form
    {
        // Token: 0x04000054 RID: 84
        public string maphucvu = "";

        // Token: 0x04000055 RID: 85
        public string sodienthoai = "";

        // Token: 0x04000056 RID: 86
        public string tenphucvu = "";

        // Token: 0x04000057 RID: 87
       // private NhanVienCtro nvCrt = new NhanVienCtro();

        // Token: 0x04000058 RID: 88
       // private NhanvienObj nvObj = new NhanvienObj();

        // Token: 0x04000059 RID: 89
        private int flag = 0;
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void KTtext()
        {
            if (this.txtMaNV.Text.Trim() == string.Empty)
            {
                this.txtMaNV.Focus();
            }
            if (this.txtTenNV.Text.Trim() == string.Empty)
            {
                this.txtTenNV.Focus();
            }
            if (this.txtNguyenQuan.Text.Trim() == string.Empty)
            {
                this.txtNguyenQuan.Focus();
            }
            if (this.txtDiachi.Text.Trim() == string.Empty)
            {
                this.txtDiachi.Focus();
            }
            if (this.txtCMND.Text.Trim() == string.Empty)
            {
                this.txtCMND.Focus();
            }
            if (this.txtnoicap.Text.Trim() == string.Empty)
            {
                this.txtnoicap.Focus();
            }
            if (this.cobgioitinh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.cobgioitinh.Focus();
            }
            if (this.dtpNamsinh.Text.Trim() == DateTime.Now.Date.ToLongDateString())
            {
                this.dtpNamsinh.Focus();
            }
            if (this.dtpNgaycap.Text.Trim() == DateTime.Now.Date.ToLongDateString())
            {
                MessageBox.Show("Ngày cấp phải nhỏ hơn ngày hiện tại", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.dtpNgaycap.Focus();
            }
        }

        // Token: 0x0600004D RID: 77 RVA: 0x00023510 File Offset: 0x00021710
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //base.SetBounds((Screen.PrimaryScreen.WorkingArea.Width - 1014) / 2, 0, 1014, Screen.PrimaryScreen.WorkingArea.Height + 10);
                //DataTable dataSource = new DataTable();
                //dataSource = this.nvCrt.getData();
                //this.dgvNhanvien.DataSource = dataSource;
                //DataTable dataSource2 = new DataTable();
                //dataSource2 = this.nvCrt.getDataTHONGTINCONGTY();
                //this.cobcuahang.DataSource = dataSource2;
                //this.cobcuahang.DisplayMember = "Tencongty";
                //this.cobcuahang.ValueMember = "Macongty";
                //this.cobcuahang.SelectedIndex = 0;
                //this.bingding();
            }
            catch
            {
            }
        }

        // Token: 0x0600004E RID: 78 RVA: 0x000235E8 File Offset: 0x000217E8
        private void bingding()
        {
            this.txtMaNV.DataBindings.Clear();
            this.txtMaNV.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "MaNV");
            this.txtTenNV.DataBindings.Clear();
            this.txtTenNV.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "TenNV");
            this.txtPhongban.DataBindings.Clear();
            this.txtPhongban.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "PhongBan");
            this.cobgioitinh.DataBindings.Clear();
            this.cobgioitinh.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "GioiTinh");
            this.dtpNamsinh.DataBindings.Clear();
            this.dtpNamsinh.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "NamSinh");
            this.txtNguyenQuan.DataBindings.Clear();
            this.txtNguyenQuan.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "NguyenQuan");
            this.txtDiachi.DataBindings.Clear();
            this.txtDiachi.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "Diachi");
            this.txtCMND.DataBindings.Clear();
            this.txtCMND.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "CMND");
            this.dtpNgaycap.DataBindings.Clear();
            this.dtpNgaycap.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "Ngaycap");
            this.txtnoicap.DataBindings.Clear();
            this.txtnoicap.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "Noicap");
            this.txtSDT.DataBindings.Clear();
            this.txtSDT.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "SDT");
            this.TxtMST.DataBindings.Clear();
            this.TxtMST.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "MST");
            this.txtGhichu.DataBindings.Clear();
            this.txtGhichu.DataBindings.Add("Text", this.dgvNhanvien.DataSource, "GhiChu");
        }

        // Token: 0x0600004F RID: 79 RVA: 0x000238C4 File Offset: 0x00021AC4
        private void dis_en(bool e)
        {
            this.txtMaNV.Enabled = e;
            this.txtTenNV.Enabled = e;
            this.txtPhongban.Enabled = e;
            this.cobgioitinh.Enabled = e;
            this.dtpNamsinh.Enabled = e;
            this.txtNguyenQuan.Enabled = e;
            this.txtDiachi.Enabled = e;
            this.txtCMND.Enabled = e;
            this.dtpNgaycap.Enabled = e;
            this.txtnoicap.Enabled = e;
            this.txtSDT.Enabled = e;
            this.TxtMST.Enabled = e;
            this.txtGhichu.Enabled = e;
            this.btThem.Enabled = !e;
            this.btSua.Enabled = !e;
            this.btXoa.Enabled = !e;
            this.btLuu.Enabled = e;
            this.bthuy.Enabled = e;
        }

        // Token: 0x06000050 RID: 80 RVA: 0x000239C8 File Offset: 0x00021BC8
        //private void ganDulieu(NhanvienObj nvObj)
        //{
        //    nvObj.MaNhanvien = this.txtMaNV.Text.Trim();
        //    nvObj.TenNhanVien = this.txtTenNV.Text.Trim();
        //    nvObj.Phongban = this.txtPhongban.Text.Trim();
        //    nvObj.Gioitinh = this.cobgioitinh.Text.Trim();
        //    nvObj.Namsinh = this.dtpNamsinh.Text.Trim();
        //    nvObj.Nguyenquan = this.txtNguyenQuan.Text.Trim();
        //    nvObj.Diachi = this.txtDiachi.Text.Trim();
        //    nvObj.Cmnd = this.txtCMND.Text.Trim();
        //    nvObj.Ngaycap = this.dtpNgaycap.Text.Trim();
        //    nvObj.Noicap = this.txtnoicap.Text.Trim();
        //    nvObj.Sdt = this.txtSDT.Text.Trim();
        //    nvObj.Mst = this.TxtMST.Text.Trim();
        //    nvObj.Ghichu = this.txtGhichu.Text.Trim();
        //    nvObj.Matkhau = "";
        //    nvObj.N1 = this.cobcuahang.SelectedValue.ToString();
        //}

        // Token: 0x06000051 RID: 81 RVA: 0x0001B678 File Offset: 0x00019878
        private void loadcontrol()
        {
            this.cobgioitinh.Items.Clear();
            this.cobgioitinh.Items.Add("Nam");
            this.cobgioitinh.Items.Add("Nữ");
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00023B24 File Offset: 0x00021D24
        private void cleardata()
        {
            this.txtMaNV.Text = "";
            this.txtTenNV.Text = "";
            this.txtPhongban.Text = "";
            this.loadcontrol();
            this.txtNguyenQuan.Text = "";
            this.txtDiachi.Text = "";
            this.txtCMND.Text = "";
            this.dtpNamsinh.Text = "";
            this.dtpNgaycap.Text = "";
            this.txtnoicap.Text = "";
            this.txtSDT.Text = "";
            this.TxtMST.Text = "";
            this.txtGhichu.Text = "";
        }

        // Token: 0x06000053 RID: 83 RVA: 0x00023C08 File Offset: 0x00021E08
        private void btThem_Click(object sender, EventArgs e)
        {
            this.flag = 0;
            this.dis_en(true);
            this.cleardata();
            this.loadcontrol();
            this.dtpNamsinh.Text = DateTime.Now.Date.ToShortDateString();
            this.dtpNgaycap.Text = DateTime.Now.Date.ToShortDateString();
            this.txtMaNV.Focus();
        }

        // Token: 0x06000054 RID: 84 RVA: 0x0001B6B8 File Offset: 0x000198B8
        private void btSua_Click(object sender, EventArgs e)
        {
            this.flag = 1;
            this.dis_en(true);
            this.loadcontrol();
        }

        // Token: 0x06000055 RID: 85 RVA: 0x00023C84 File Offset: 0x00021E84
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaNV.Text == "admin")
            {
                MessageBox.Show("Không thể xóa được tên nhân viên này", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //if (this.nvCrt.delData(this.txtMaNV.Text.Trim()))
                    //{
                    //    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Thêm không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //}
                    //this.FrmNhanVien_Load(sender, e);
                }
            }
        }

        // Token: 0x06000056 RID: 86 RVA: 0x00023D40 File Offset: 0x00021F40
        private void btLuu_Click(object sender, EventArgs e)
        {
            //if (this.txtMaNV.Text.Trim() == "")
            //{
            //    this.txtMaNV.Focus();
            //}
            //else
            //{
            //  //  this.ganDulieu(this.nvObj);
            //    if (this.flag == 0)
            //    {
            //        if (this.nvCrt.AddData(this.nvObj))
            //        {
            //            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thêm không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }
            //    }
            //    else if (this.nvCrt.UpdateData(this.nvObj))
            //    {
            //        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sửa không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //    this.FrmNhanVien_Load(sender, e);
            //    this.dis_en(false);
            //}
        }

        // Token: 0x06000057 RID: 87 RVA: 0x00023E38 File Offset: 0x00022038
        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy thao tác đang làm không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.FrmNhanVien_Load(sender, e);
                this.dis_en(false);
            }
        }

        // Token: 0x06000058 RID: 88 RVA: 0x00023E7C File Offset: 0x0002207C
        private void dgvNhanvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < this.dgvNhanvien.RowCount; i++)
            {
                this.dgvNhanvien.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Token: 0x06000059 RID: 89 RVA: 0x00023ED0 File Offset: 0x000220D0
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.txtMaNV.Text == "")
                {
                    this.txtMaNV.Focus();
                }
                else
                {
                    this.txtTenNV.Focus();
                }
            }
        }

        // Token: 0x0600005A RID: 90 RVA: 0x00023F2C File Offset: 0x0002212C
        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.dtpNamsinh.Focus();
            }
        }

        // Token: 0x0600005B RID: 91 RVA: 0x00023F5C File Offset: 0x0002215C
        private void dtpNamsinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtNguyenQuan.Focus();
            }
        }

        // Token: 0x0600005C RID: 92 RVA: 0x00023F8C File Offset: 0x0002218C
        private void txtNguyenQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtDiachi.Focus();
            }
        }

        // Token: 0x0600005D RID: 93 RVA: 0x00023FBC File Offset: 0x000221BC
        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtCMND.Focus();
            }
        }

        // Token: 0x0600005E RID: 94 RVA: 0x00023FEC File Offset: 0x000221EC
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.dtpNgaycap.Focus();
            }
        }

        // Token: 0x0600005F RID: 95 RVA: 0x0002401C File Offset: 0x0002221C
        private void dtpNgaycap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtnoicap.Focus();
            }
        }

        // Token: 0x06000060 RID: 96 RVA: 0x0002404C File Offset: 0x0002224C
        private void txtnoicap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtSDT.Focus();
            }
        }

        // Token: 0x06000061 RID: 97 RVA: 0x0002407C File Offset: 0x0002227C
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.cobgioitinh.Focus();
            }
        }

        // Token: 0x06000062 RID: 98 RVA: 0x000240AC File Offset: 0x000222AC
        private void cobgioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btLuu.Focus();
            }
        }

        // Token: 0x06000063 RID: 99 RVA: 0x0001B6D1 File Offset: 0x000198D1
        private void btchon_Click(object sender, EventArgs e)
        {
            //FrmNhanVien.sodienthoai = this.txtSDT.Text;
            //FrmNhanVien.maphucvu = this.txtMaNV.Text;
            //FrmNhanVien.tenphucvu = this.txtTenNV.Text;
            //base.Close();
        }

        // Token: 0x06000064 RID: 100 RVA: 0x0001B70B File Offset: 0x0001990B
        private void button1_Click(object sender, EventArgs e)
        {
            //FrmNhanVien.sodienthoai = "";
            //FrmNhanVien.maphucvu = "";
            //FrmNhanVien.tenphucvu = "";
            //base.Close();
        }

        // Token: 0x06000065 RID: 101 RVA: 0x0001B733 File Offset: 0x00019933
        private void dgvNhanvien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btchon_Click(null, null);
        }
    }
  

}
