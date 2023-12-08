using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmdiemkhachhang
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.textBox2 = new TextBox();
            this.button2 = new Button();
            this.button1 = new Button();
            this.txttongdiem = new TextBox();
            this.textBox4 = new TextBox();
            this.btthuchien = new Button();
            this.txtdiem = new TextBox();
            this.comboBox1 = new ComboBox();
            this.textBox3 = new TextBox();
            this.txttenkhachhang = new TextBox();
            this.textBox1 = new TextBox();
            this.panel2 = new Panel();
            this.dgvtonghop = new DataGridView();
            this.dgvdiem = new DataGridView();
            this.MAKHACHHANG = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.tongdiem = new DataGridViewTextBoxColumn();
            this.tongdiemcong = new DataGridViewTextBoxColumn();
            this.tongdiemtru = new DataGridViewTextBoxColumn();
            this.diemtong = new DataGridViewTextBoxColumn();
            this.MAHOADON = new DataGridViewTextBoxColumn();
            this.NGAY = new DataGridViewTextBoxColumn();
            this.diem = new DataGridViewTextBoxColumn();
            this.diemcong = new DataGridViewTextBoxColumn();
            this.diemtru = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.txtghichu = new TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.dgvtonghop).BeginInit();
            ((ISupportInitialize)this.dgvdiem).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 129f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(922, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txttongdiem);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.btthuchien);
            this.panel1.Controls.Add(this.txtdiem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txttenkhachhang);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.panel1.Location = new Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(914, 123);
            this.panel1.TabIndex = 0;
            this.button3.BackColor = Color.Blue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button3.ForeColor = Color.White;
            this.button3.Location = new Point(159, 3);
            this.button3.Name = "button3";
            this.button3.Size = new Size(65, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.dateTimePicker1.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(448, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(163, 32);
            this.dateTimePicker1.TabIndex = 10;
            this.textBox2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox2.Location = new Point(358, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(164, 32);
            this.textBox2.TabIndex = 11;
            this.textBox2.Tag = "Mã khách hàng";
            this.textBox2.Text = "Đến ngày:";
            this.button2.BackColor = Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(765, 68);
            this.button2.Name = "button2";
            this.button2.Size = new Size(144, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Điểm tổng hợp";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.button1.BackColor = Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(765, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(144, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Điểm chi tiết";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.txttongdiem.BackColor = Color.FromArgb(255, 255, 128);
            this.txttongdiem.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongdiem.Location = new Point(158, 90);
            this.txttongdiem.Name = "txttongdiem";
            this.txttongdiem.Size = new Size(164, 32);
            this.txttongdiem.TabIndex = 7;
            this.txttongdiem.Tag = "";
            this.txttongdiem.Text = "0";
            this.txttongdiem.TextAlign = HorizontalAlignment.Center;
            this.textBox4.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox4.Location = new Point(3, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(176, 32);
            this.textBox4.TabIndex = 6;
            this.textBox4.Tag = "Mã khách hàng";
            this.textBox4.Text = "Tổng điểm:";
            this.btthuchien.BackColor = Color.Blue;
            this.btthuchien.FlatAppearance.BorderSize = 0;
            this.btthuchien.FlatStyle = FlatStyle.Popup;
            this.btthuchien.ForeColor = Color.White;
            this.btthuchien.Location = new Point(617, 3);
            this.btthuchien.Name = "btthuchien";
            this.btthuchien.Size = new Size(114, 65);
            this.btthuchien.TabIndex = 5;
            this.btthuchien.Text = "Thực hiện";
            this.btthuchien.UseVisualStyleBackColor = false;
            this.btthuchien.Click += this.btthuchien_Click;
            this.txtdiem.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtdiem.Location = new Point(224, 36);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new Size(98, 32);
            this.txtdiem.TabIndex = 4;
            this.txtdiem.Tag = "";
            this.txtdiem.Text = "0";
            this.txtdiem.TextAlign = HorizontalAlignment.Center;
            this.txtdiem.KeyDown += this.txtdiem_KeyDown;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "+",
                "-"
            });
            this.comboBox1.Location = new Point(158, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(67, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += this.comboBox1_TextChanged;
            this.textBox3.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox3.Location = new Point(4, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(199, 32);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "Mã khách hàng";
            this.textBox3.Text = "Cộng trừ điểm:";
            this.txttenkhachhang.BackColor = Color.White;
            this.txttenkhachhang.Location = new Point(225, 3);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.ReadOnly = true;
            this.txttenkhachhang.Size = new Size(386, 29);
            this.txttenkhachhang.TabIndex = 1;
            this.txttenkhachhang.Tag = "Tên khách hàng";
            this.txttenkhachhang.Text = "Tên khách hàng";
            this.textBox1.Location = new Point(4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(163, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "Mã khách hàng";
            this.textBox1.Text = "Mã khách hàng";
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.textBox1.Enter += this.textBox1_Enter;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.textBox1.Leave += this.textBox1_Leave;
            this.panel2.Controls.Add(this.dgvdiem);
            this.panel2.Controls.Add(this.dgvtonghop);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(4, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(914, 473);
            this.panel2.TabIndex = 1;
            this.dgvtonghop.AllowUserToAddRows = false;
            this.dgvtonghop.AllowUserToDeleteRows = false;
            this.dgvtonghop.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvtonghop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvtonghop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtonghop.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MAKHACHHANG,
                this.dataGridViewTextBoxColumn2,
                this.tongdiem,
                this.tongdiemcong,
                this.tongdiemtru,
                this.diemtong
            });
            this.dgvtonghop.Dock = DockStyle.Fill;
            this.dgvtonghop.Location = new Point(0, 0);
            this.dgvtonghop.Name = "dgvtonghop";
            this.dgvtonghop.ReadOnly = true;
            this.dgvtonghop.Size = new Size(914, 473);
            this.dgvtonghop.TabIndex = 1;
            this.dgvtonghop.CellDoubleClick += this.dgvtonghop_CellDoubleClick;
            this.dgvdiem.AllowUserToAddRows = false;
            this.dgvdiem.AllowUserToDeleteRows = false;
            this.dgvdiem.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvdiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiem.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MAHOADON,
                this.NGAY,
                this.diem,
                this.diemcong,
                this.diemtru,
                this.GHICHU
            });
            this.dgvdiem.Dock = DockStyle.Fill;
            this.dgvdiem.Location = new Point(0, 0);
            this.dgvdiem.Name = "dgvdiem";
            this.dgvdiem.ReadOnly = true;
            this.dgvdiem.Size = new Size(914, 473);
            this.dgvdiem.TabIndex = 0;
            this.MAKHACHHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAKHACHHANG.DataPropertyName = "MAKHACHHANG";
            this.MAKHACHHANG.HeaderText = "Mã khách hàng";
            this.MAKHACHHANG.Name = "MAKHACHHANG";
            this.MAKHACHHANG.ReadOnly = true;
            this.MAKHACHHANG.Width = 150;
            this.dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENDONVI";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 279;
            this.tongdiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tongdiem.DataPropertyName = "diem";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.tongdiem.DefaultCellStyle = dataGridViewCellStyle4;
            this.tongdiem.HeaderText = "Điểm";
            this.tongdiem.Name = "tongdiem";
            this.tongdiem.ReadOnly = true;
            this.tongdiemcong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tongdiemcong.DataPropertyName = "diemcong";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            this.tongdiemcong.DefaultCellStyle = dataGridViewCellStyle5;
            this.tongdiemcong.HeaderText = "Điểm cộng";
            this.tongdiemcong.Name = "tongdiemcong";
            this.tongdiemcong.ReadOnly = true;
            this.tongdiemtru.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tongdiemtru.DataPropertyName = "diemtru";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N3";
            this.tongdiemtru.DefaultCellStyle = dataGridViewCellStyle6;
            this.tongdiemtru.HeaderText = "Điểm Trừ";
            this.tongdiemtru.Name = "tongdiemtru";
            this.tongdiemtru.ReadOnly = true;
            this.diemtong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diemtong.DataPropertyName = "tongdiem";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.diemtong.DefaultCellStyle = dataGridViewCellStyle7;
            this.diemtong.HeaderText = "Tổng điểm";
            this.diemtong.Name = "diemtong";
            this.diemtong.ReadOnly = true;
            this.diemtong.Width = 139;
            this.MAHOADON.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHOADON.DataPropertyName = "MAHOADON";
            this.MAHOADON.HeaderText = "Số hóa đơn";
            this.MAHOADON.Name = "MAHOADON";
            this.MAHOADON.ReadOnly = true;
            this.MAHOADON.Width = 150;
            this.NGAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NGAY.DataPropertyName = "NGAY";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.NGAY.DefaultCellStyle = dataGridViewCellStyle8;
            this.NGAY.HeaderText = "Ngày";
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            this.NGAY.Width = 138;
            this.diem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diem.DataPropertyName = "diem";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = null;
            this.diem.DefaultCellStyle = dataGridViewCellStyle9;
            this.diem.HeaderText = "Điểm";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            this.diemcong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diemcong.DataPropertyName = "diemcong";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N3";
            this.diemcong.DefaultCellStyle = dataGridViewCellStyle10;
            this.diemcong.HeaderText = "Điểm cộng";
            this.diemcong.Name = "diemcong";
            this.diemcong.ReadOnly = true;
            this.diemtru.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diemtru.DataPropertyName = "diemtru";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N3";
            this.diemtru.DefaultCellStyle = dataGridViewCellStyle11;
            this.diemtru.HeaderText = "Điểm Trừ";
            this.diemtru.Name = "diemtru";
            this.diemtru.ReadOnly = true;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.txtghichu.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtghichu.Location = new Point(321, 36);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(290, 32);
            this.txtghichu.TabIndex = 13;
            this.txtghichu.Tag = "Ghi chú";
            this.txtghichu.Text = "Ghi chú";
            this.txtghichu.Enter += this.txtghichu_Enter;
            this.txtghichu.Leave += this.txtghichu_Leave;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(192, 192, 255);
            base.ClientSize = new Size(922, 611);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
         //   base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "Frmdiemkhachhang";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chi tiết điểm khách hàng";
            base.Load += this.Frmdiemkhachhang_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvtonghop).EndInit();
            ((ISupportInitialize)this.dgvdiem).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000863 RID: 2147
      

        // Token: 0x04000864 RID: 2148
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000865 RID: 2149
        private Panel panel1;

        // Token: 0x04000866 RID: 2150
        private TextBox textBox1;

        // Token: 0x04000867 RID: 2151
        private Button btthuchien;

        // Token: 0x04000868 RID: 2152
        private TextBox txtdiem;

        // Token: 0x04000869 RID: 2153
        private ComboBox comboBox1;

        // Token: 0x0400086A RID: 2154
        private TextBox textBox3;

        // Token: 0x0400086B RID: 2155
        private TextBox txttenkhachhang;

        // Token: 0x0400086C RID: 2156
        private TextBox txttongdiem;

        // Token: 0x0400086D RID: 2157
        private TextBox textBox4;

        // Token: 0x0400086E RID: 2158
        private Panel panel2;

        // Token: 0x0400086F RID: 2159
        private DataGridView dgvdiem;

        // Token: 0x04000870 RID: 2160
        private Button button2;

        // Token: 0x04000871 RID: 2161
        private Button button1;

        // Token: 0x04000872 RID: 2162
        private DateTimePicker dateTimePicker1;

        // Token: 0x04000873 RID: 2163
        private TextBox textBox2;

        // Token: 0x04000874 RID: 2164
        private DataGridView dgvtonghop;

        // Token: 0x04000875 RID: 2165
        private Button button3;

        // Token: 0x04000876 RID: 2166
        private DataGridViewTextBoxColumn MAKHACHHANG;

        // Token: 0x04000877 RID: 2167
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        // Token: 0x04000878 RID: 2168
        private DataGridViewTextBoxColumn tongdiem;

        // Token: 0x04000879 RID: 2169
        private DataGridViewTextBoxColumn tongdiemcong;

        // Token: 0x0400087A RID: 2170
        private DataGridViewTextBoxColumn tongdiemtru;

        // Token: 0x0400087B RID: 2171
        private DataGridViewTextBoxColumn diemtong;

        // Token: 0x0400087C RID: 2172
        private DataGridViewTextBoxColumn MAHOADON;

        // Token: 0x0400087D RID: 2173
        private DataGridViewTextBoxColumn NGAY;

        // Token: 0x0400087E RID: 2174
        private DataGridViewTextBoxColumn diem;

        // Token: 0x0400087F RID: 2175
        private DataGridViewTextBoxColumn diemcong;

        // Token: 0x04000880 RID: 2176
        private DataGridViewTextBoxColumn diemtru;

        // Token: 0x04000881 RID: 2177
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x04000882 RID: 2178
        private TextBox txtghichu;
    }
}
