using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_baocaotangqua
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
            this.ptangqua = new Panel();
            this.button1 = new Button();
            this.label1 = new Label();
            this.txtmakhachhang = new TextBox();
            this.dgvtangqua = new DataGridView();
            this.THANG_TOP = new DataGridViewTextBoxColumn();
            this.KHACHHANG = new DataGridViewTextBoxColumn();
            this.soluot = new DataGridViewTextBoxColumn();
            this.Sotien = new DataGridViewTextBoxColumn();
            this.QUATANG = new DataGridViewTextBoxColumn();
            this.ngay = new DataGridViewTextBoxColumn();
            this.nhanvien = new DataGridViewTextBoxColumn();
            this.SDT = new DataGridViewTextBoxColumn();
            this.button24 = new Button();
            this.label2 = new Label();
            this.txttop = new TextBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.label3 = new Label();
            this.label4 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.panel1 = new Panel();
            this.ptangqua.SuspendLayout();
            ((ISupportInitialize)this.dgvtangqua).BeginInit();
            base.SuspendLayout();
            this.ptangqua.BackColor = Color.White;
            this.ptangqua.BorderStyle = BorderStyle.FixedSingle;
            this.ptangqua.Controls.Add(this.dateTimePicker2);
            this.ptangqua.Controls.Add(this.dateTimePicker1);
            this.ptangqua.Controls.Add(this.label4);
            this.ptangqua.Controls.Add(this.txtmakhachhang);
            this.ptangqua.Controls.Add(this.label3);
            this.ptangqua.Controls.Add(this.txttop);
            this.ptangqua.Controls.Add(this.label2);
            this.ptangqua.Controls.Add(this.button1);
            this.ptangqua.Controls.Add(this.label1);
            this.ptangqua.Controls.Add(this.dgvtangqua);
            this.ptangqua.Controls.Add(this.button24);
            this.ptangqua.Controls.Add(this.panel1);
            this.ptangqua.Dock = DockStyle.Fill;
            this.ptangqua.Location = new Point(0, 0);
            this.ptangqua.Margin = new Padding(5);
            this.ptangqua.Name = "ptangqua";
            this.ptangqua.Size = new Size(1008, 461);
            this.ptangqua.TabIndex = 10028;
            this.button1.BackColor = Color.Gold;
            this.button1.FlatAppearance.BorderColor = Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            this.button1.Font = new Font("Times New Roman", 16f);
            this.button1.ForeColor = Color.Red;
            this.button1.Location = new Point(231, 6);
            this.button1.Margin = new Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(210, 35);
            this.button1.TabIndex = 10032;
            this.button1.Text = "Khách hàng quan tâm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new Size(102, 21);
            this.label1.TabIndex = 10031;
            this.label1.Text = "Khách hàng:";
            this.txtmakhachhang.Location = new Point(104, 49);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new Size(337, 29);
            this.txtmakhachhang.TabIndex = 10030;
            this.txtmakhachhang.TextChanged += this.txtmakhachhang_TextChanged;
            this.dgvtangqua.AllowUserToAddRows = false;
            this.dgvtangqua.AllowUserToDeleteRows = false;
            this.dgvtangqua.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvtangqua.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvtangqua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvtangqua.ColumnHeadersHeight = 44;
            this.dgvtangqua.Columns.AddRange(new DataGridViewColumn[]
            {
                this.THANG_TOP,
                this.KHACHHANG,
                this.soluot,
                this.Sotien,
                this.QUATANG,
                this.ngay,
                this.nhanvien,
                this.SDT
            });
            this.dgvtangqua.Location = new Point(7, 86);
            this.dgvtangqua.Margin = new Padding(5);
            this.dgvtangqua.Name = "dgvtangqua";
            this.dgvtangqua.ReadOnly = true;
            this.dgvtangqua.RowHeadersVisible = false;
            this.dgvtangqua.RowTemplate.Height = 43;
            this.dgvtangqua.Size = new Size(1000, 371);
            this.dgvtangqua.TabIndex = 10029;
            this.THANG_TOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.THANG_TOP.DataPropertyName = "thang";
            this.THANG_TOP.HeaderText = "Thời gian";
            this.THANG_TOP.Name = "THANG_TOP";
            this.THANG_TOP.ReadOnly = true;
            this.KHACHHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.KHACHHANG.DataPropertyName = "tenkhachhang";
            this.KHACHHANG.HeaderText = "Khách hàng";
            this.KHACHHANG.Name = "KHACHHANG";
            this.KHACHHANG.ReadOnly = true;
            this.KHACHHANG.Width = 200;
            this.soluot.DataPropertyName = "sohoadon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomLeft;
            this.soluot.DefaultCellStyle = dataGridViewCellStyle2;
            this.soluot.HeaderText = "SL";
            this.soluot.Name = "soluot";
            this.soluot.ReadOnly = true;
            this.soluot.Width = 50;
            this.Sotien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Sotien.DataPropertyName = "sotien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.Sotien.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sotien.HeaderText = "Số tiền";
            this.Sotien.Name = "Sotien";
            this.Sotien.ReadOnly = true;
            this.Sotien.Width = 123;
            this.QUATANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.QUATANG.DataPropertyName = "noidung";
            this.QUATANG.HeaderText = "Quà tặng";
            this.QUATANG.MinimumWidth = 300;
            this.QUATANG.Name = "QUATANG";
            this.QUATANG.ReadOnly = true;
            this.ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngay.DataPropertyName = "ngaytang";
            this.ngay.HeaderText = "Ngày";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 140;
            this.nhanvien.DataPropertyName = "nhanvien";
            this.nhanvien.HeaderText = "Nhân viên";
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.ReadOnly = true;
            this.SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "sdt";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 200;
            this.button24.BackColor = Color.Gold;
            this.button24.FlatAppearance.BorderColor = Color.Gray;
            this.button24.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            this.button24.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            this.button24.Font = new Font("Times New Roman", 16f);
            this.button24.ForeColor = Color.Red;
            this.button24.Location = new Point(7, 5);
            this.button24.Margin = new Padding(5);
            this.button24.Name = "button24";
            this.button24.Size = new Size(210, 35);
            this.button24.TabIndex = 10027;
            this.button24.Text = "Khách hàng tặng quà";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += this.button24_Click;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(682, 9);
            this.label2.Name = "label2";
            this.label2.Size = new Size(45, 21);
            this.label2.TabIndex = 10034;
            this.label2.Text = "Top:";
            this.txttop.Location = new Point(725, 6);
            this.txttop.Name = "txttop";
            this.txttop.Size = new Size(47, 29);
            this.txttop.TabIndex = 10033;
            this.txttop.Text = "449";
            this.txttop.KeyDown += this.txttop_KeyDown;
            this.dateTimePicker1.Location = new Point(855, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(148, 29);
            this.dateTimePicker1.TabIndex = 10035;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(778, 8);
            this.label3.Name = "label3";
            this.label3.Size = new Size(76, 21);
            this.label3.TabIndex = 10036;
            this.label3.Text = "Từ ngày:";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(778, 43);
            this.label4.Name = "label4";
            this.label4.Size = new Size(85, 21);
            this.label4.TabIndex = 10038;
            this.label4.Text = "Đến ngày:";
            this.dateTimePicker2.Location = new Point(855, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(148, 29);
            this.dateTimePicker2.TabIndex = 10037;
            this.panel1.Location = new Point(676, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(331, 75);
            this.panel1.TabIndex = 10039;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 461);
            base.Controls.Add(this.ptangqua);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
         //   base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frm_baocaotangqua";
        //    base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tặng quà";
            base.Load += this.Frm_baocaotangqua_Load;
            this.ptangqua.ResumeLayout(false);
            this.ptangqua.PerformLayout();
            ((ISupportInitialize)this.dgvtangqua).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x0400003F RID: 63
        private Panel ptangqua;

        // Token: 0x04000040 RID: 64
        private DataGridView dgvtangqua;

        // Token: 0x04000041 RID: 65
        private Button button24;

        // Token: 0x04000042 RID: 66
        private TextBox txtmakhachhang;

        // Token: 0x04000043 RID: 67
        private Label label1;

        // Token: 0x04000044 RID: 68
        private Button button1;

        // Token: 0x04000045 RID: 69
        private DataGridViewTextBoxColumn THANG_TOP;

        // Token: 0x04000046 RID: 70
        private DataGridViewTextBoxColumn KHACHHANG;

        // Token: 0x04000047 RID: 71
        private DataGridViewTextBoxColumn soluot;

        // Token: 0x04000048 RID: 72
        private DataGridViewTextBoxColumn Sotien;

        // Token: 0x04000049 RID: 73
        private DataGridViewTextBoxColumn QUATANG;

        // Token: 0x0400004A RID: 74
        private DataGridViewTextBoxColumn ngay;

        // Token: 0x0400004B RID: 75
        private DataGridViewTextBoxColumn nhanvien;

        // Token: 0x0400004C RID: 76
        private DataGridViewTextBoxColumn SDT;

        // Token: 0x0400004D RID: 77
        private TextBox txttop;

        // Token: 0x0400004E RID: 78
        private Label label2;

        // Token: 0x0400004F RID: 79
        private DateTimePicker dateTimePicker2;

        // Token: 0x04000050 RID: 80
        private DateTimePicker dateTimePicker1;

        // Token: 0x04000051 RID: 81
        private Label label4;

        // Token: 0x04000052 RID: 82
        private Label label3;

        // Token: 0x04000053 RID: 83
        private Panel panel1;
    }
}
