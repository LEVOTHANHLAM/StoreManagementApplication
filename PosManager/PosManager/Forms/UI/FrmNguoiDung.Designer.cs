using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FrmNguoiDung
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            this.btthem = new Button();
            this.label1 = new Label();
            this.cobquyen = new ComboBox();
            this.txtMataikhoan = new TextBox();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.txtTentaikhoan = new TextBox();
            this.txtmatkhau = new TextBox();
            this.btsua = new Button();
            this.btluu = new Button();
            this.btxoa = new Button();
            this.groupBox1 = new GroupBox();
            this.dgvnguoidung = new DataGridView();
            this.cobks = new ComboBox();
            this.label5 = new Label();
            this.cobmaytinh = new ComboBox();
            this.label6 = new Label();
            this.comboBox1 = new ComboBox();
            this.label7 = new Label();
            this.stt = new DataGridViewTextBoxColumn();
            this.MATK = new DataGridViewTextBoxColumn();
            this.tentaikhoan = new DataGridViewTextBoxColumn();
            this.Matkhau = new DataGridViewTextBoxColumn();
            this.Quyen = new DataGridViewTextBoxColumn();
            this.MAYMAY = new DataGridViewTextBoxColumn();
            this.macongty = new DataGridViewTextBoxColumn();
            this.MACUAHANG = new DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.dgvnguoidung).BeginInit();
            base.SuspendLayout();
            this.btthem.BackColor = Color.White;
            this.btthem.FlatStyle = FlatStyle.Flat;
            this.btthem.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btthem.ForeColor = Color.FromArgb(0, 0, 192);
            this.btthem.Location = new Point(542, 19);
            this.btthem.Margin = new Padding(4, 5, 4, 5);
            this.btthem.Name = "btthem";
            this.btthem.Size = new Size(118, 71);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "THÊM";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += this.btthem_Click;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(25, 25);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đăng nhập:";
            this.cobquyen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobquyen.FormattingEnabled = true;
            this.cobquyen.Items.AddRange(new object[]
            {
                "QUẢN LÝ",
                "BÁN HÀNG",
                "KẾ TOÁN",
                "NHÂN VIÊN"
            });
            this.cobquyen.Location = new Point(123, 108);
            this.cobquyen.Margin = new Padding(4, 5, 4, 5);
            this.cobquyen.Name = "cobquyen";
            this.cobquyen.Size = new Size(275, 28);
            this.cobquyen.TabIndex = 2;
            this.txtMataikhoan.Location = new Point(123, 20);
            this.txtMataikhoan.Margin = new Padding(4, 5, 4, 5);
            this.txtMataikhoan.MaxLength = 10;
            this.txtMataikhoan.Name = "txtMataikhoan";
            this.txtMataikhoan.Size = new Size(275, 26);
            this.txtMataikhoan.TabIndex = 3;
            this.txtMataikhoan.KeyPress += this.txtMataikhoan_KeyPress;
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(25, 50);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(25, 82);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(74, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu:";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(25, 115);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(86, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phân Quyền:";
            this.txtTentaikhoan.Location = new Point(123, 49);
            this.txtTentaikhoan.Margin = new Padding(4, 5, 4, 5);
            this.txtTentaikhoan.Name = "txtTentaikhoan";
            this.txtTentaikhoan.Size = new Size(275, 26);
            this.txtTentaikhoan.TabIndex = 4;
            this.txtmatkhau.Location = new Point(123, 79);
            this.txtmatkhau.Margin = new Padding(4, 5, 4, 5);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new Size(275, 26);
            this.txtmatkhau.TabIndex = 5;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.btsua.BackColor = Color.White;
            this.btsua.FlatStyle = FlatStyle.Flat;
            this.btsua.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btsua.ForeColor = Color.FromArgb(0, 0, 192);
            this.btsua.Location = new Point(542, 100);
            this.btsua.Margin = new Padding(4, 5, 4, 5);
            this.btsua.Name = "btsua";
            this.btsua.Size = new Size(118, 68);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "SỬA";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += this.btsua_Click;
            this.btluu.BackColor = Color.White;
            this.btluu.FlatStyle = FlatStyle.Flat;
            this.btluu.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            this.btluu.ForeColor = Color.FromArgb(0, 0, 192);
            this.btluu.Location = new Point(673, 100);
            this.btluu.Margin = new Padding(4, 5, 4, 5);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(118, 68);
            this.btluu.TabIndex = 7;
            this.btluu.Text = "LƯU";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += this.btluu_Click;
            this.btxoa.BackColor = Color.White;
            this.btxoa.FlatStyle = FlatStyle.Flat;
            this.btxoa.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btxoa.ForeColor = Color.FromArgb(0, 0, 192);
            this.btxoa.Location = new Point(673, 20);
            this.btxoa.Margin = new Padding(4, 5, 4, 5);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new Size(118, 70);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += this.btxoa_Click;
            this.groupBox1.Controls.Add(this.dgvnguoidung);
            this.groupBox1.Location = new Point(13, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(828, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            this.dgvnguoidung.AllowUserToAddRows = false;
            this.dgvnguoidung.AllowUserToDeleteRows = false;
            this.dgvnguoidung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnguoidung.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvnguoidung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvnguoidung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguoidung.Columns.AddRange(new DataGridViewColumn[]
            {
                this.stt,
                this.MATK,
                this.tentaikhoan,
                this.Matkhau,
                this.Quyen,
                this.MAYMAY,
                this.macongty,
                this.MACUAHANG
            });
            this.dgvnguoidung.Dock = DockStyle.Fill;
            this.dgvnguoidung.Location = new Point(3, 22);
            this.dgvnguoidung.Name = "dgvnguoidung";
            this.dgvnguoidung.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvnguoidung.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnguoidung.RowHeadersWidth = 4;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvnguoidung.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvnguoidung.RowTemplate.Height = 40;
            this.dgvnguoidung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvnguoidung.Size = new Size(822, 277);
            this.dgvnguoidung.TabIndex = 0;
            this.dgvnguoidung.RowPrePaint += this.dgvnguoidung_RowPrePaint;
            this.dgvnguoidung.Click += this.dgvnguoidung_Click;
            this.dgvnguoidung.KeyDown += this.dgvnguoidung_KeyDown;
            this.cobks.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobks.FormattingEnabled = true;
            this.cobks.Items.AddRange(new object[]
            {
                "QUẢN LÝ",
                "NHÂN VIÊN"
            });
            this.cobks.Location = new Point(123, 140);
            this.cobks.Margin = new Padding(4, 5, 4, 5);
            this.cobks.Name = "cobks";
            this.cobks.Size = new Size(105, 28);
            this.cobks.TabIndex = 11;
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(25, 144);
            this.label5.Margin = new Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(86, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã hóa đơn:";
            this.cobmaytinh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobmaytinh.FormattingEnabled = true;
            this.cobmaytinh.Items.AddRange(new object[]
            {
                "00",
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10"
            });
            this.cobmaytinh.Location = new Point(318, 140);
            this.cobmaytinh.Margin = new Padding(4, 5, 4, 5);
            this.cobmaytinh.Name = "cobmaytinh";
            this.cobmaytinh.Size = new Size(80, 28);
            this.cobmaytinh.TabIndex = 13;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(260, 145);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã kho:";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "QUẢN LÝ",
                "NHÂN VIÊN"
            });
            this.comboBox1.Location = new Point(123, 178);
            this.comboBox1.Margin = new Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(105, 28);
            this.comboBox1.TabIndex = 15;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(25, 182);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(72, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chi nhánh:";
            this.stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.stt.HeaderText = "Số TT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 70;
            this.MATK.DataPropertyName = "mataikhoan";
            this.MATK.HeaderText = "Mã Tài Khoản";
            this.MATK.Name = "MATK";
            this.MATK.ReadOnly = true;
            this.tentaikhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tentaikhoan.DataPropertyName = "tentaikhoan";
            this.tentaikhoan.HeaderText = "Tên Tài Khoản";
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.ReadOnly = true;
            this.tentaikhoan.Width = 200;
            this.Matkhau.DataPropertyName = "matkhau";
            this.Matkhau.HeaderText = "Mật Khẩu";
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.ReadOnly = true;
            this.Matkhau.Visible = false;
            this.Quyen.DataPropertyName = "phanquyen";
            this.Quyen.HeaderText = "Phân Quyền";
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            this.MAYMAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAYMAY.DataPropertyName = "MAMAY";
            this.MAYMAY.HeaderText = "Mã Kho";
            this.MAYMAY.Name = "MAYMAY";
            this.MAYMAY.ReadOnly = true;
            this.macongty.DataPropertyName = "macongty";
            this.macongty.HeaderText = "macongty";
            this.macongty.Name = "macongty";
            this.macongty.ReadOnly = true;
            this.macongty.Visible = false;
            this.MACUAHANG.DataPropertyName = "MACUAHANG";
            this.MACUAHANG.HeaderText = "MACUAHANG";
            this.MACUAHANG.Name = "MACUAHANG";
            this.MACUAHANG.ReadOnly = true;
            this.MACUAHANG.Visible = false;
            base.AutoScaleDimensions = new SizeF(9f, 20f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(192, 192, 255);
            base.ClientSize = new Size(853, 538);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.cobmaytinh);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.cobks);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btxoa);
            base.Controls.Add(this.btluu);
            base.Controls.Add(this.txtmatkhau);
            base.Controls.Add(this.txtTentaikhoan);
            base.Controls.Add(this.txtMataikhoan);
            base.Controls.Add(this.cobquyen);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.btthem);
            base.Controls.Add(this.btsua);
            this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.FromArgb(0, 0, 192);
            base.Margin = new Padding(4, 5, 4, 5);
          //  base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "FrmNguoiDung";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản đăng nhập";
            base.Load += this.FrmNguoiDung_Load;
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvnguoidung).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000306 RID: 774
        private Button btthem;

        // Token: 0x04000307 RID: 775
        private Label label1;

        // Token: 0x04000308 RID: 776
        private ComboBox cobquyen;

        // Token: 0x04000309 RID: 777
        private TextBox txtMataikhoan;

        // Token: 0x0400030A RID: 778
        private Label label2;

        // Token: 0x0400030B RID: 779
        private Label label3;

        // Token: 0x0400030C RID: 780
        private Label label4;

        // Token: 0x0400030D RID: 781
        private TextBox txtTentaikhoan;

        // Token: 0x0400030E RID: 782
        private TextBox txtmatkhau;

        // Token: 0x0400030F RID: 783
        private Button btsua;

        // Token: 0x04000310 RID: 784
        private Button btluu;

        // Token: 0x04000311 RID: 785
        private Button btxoa;

        // Token: 0x04000312 RID: 786
        private GroupBox groupBox1;

        // Token: 0x04000313 RID: 787
        private DataGridView dgvnguoidung;

        // Token: 0x04000314 RID: 788
        private ComboBox cobks;

        // Token: 0x04000315 RID: 789
        private Label label5;

        // Token: 0x04000316 RID: 790
        private ComboBox cobmaytinh;

        // Token: 0x04000317 RID: 791
        private Label label6;

        // Token: 0x04000318 RID: 792
        private ComboBox comboBox1;

        // Token: 0x04000319 RID: 793
        private Label label7;

        // Token: 0x0400031A RID: 794
        private DataGridViewTextBoxColumn stt;

        // Token: 0x0400031B RID: 795
        private DataGridViewTextBoxColumn MATK;

        // Token: 0x0400031C RID: 796
        private DataGridViewTextBoxColumn tentaikhoan;

        // Token: 0x0400031D RID: 797
        private DataGridViewTextBoxColumn Matkhau;

        // Token: 0x0400031E RID: 798
        private DataGridViewTextBoxColumn Quyen;

        // Token: 0x0400031F RID: 799
        private DataGridViewTextBoxColumn MAYMAY;

        // Token: 0x04000320 RID: 800
        private DataGridViewTextBoxColumn macongty;

        // Token: 0x04000321 RID: 801
        private DataGridViewTextBoxColumn MACUAHANG;
    }
}
