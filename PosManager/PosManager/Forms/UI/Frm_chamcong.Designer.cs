using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_chamcong
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
            this.components = new Container();
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.cob_thang = new ComboBox();
            this.button2 = new Button();
            this.button1 = new Button();
            this.txttong = new TextBox();
            this.txtthoigian = new TextBox();
            this.txtmara = new TextBox();
            this.txtmavao = new TextBox();
            this.panel2 = new Panel();
            this.dgvtonghop = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.nhanvien = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.sogio = new DataGridViewTextBoxColumn();
            this.sophut = new DataGridViewTextBoxColumn();
            this.dgv_chamcong = new DataGridView();
            this.TT = new DataGridViewTextBoxColumn();
            this.manhanvien = new DataGridViewTextBoxColumn();
            this.tennhanvien = new DataGridViewTextBoxColumn();
            this.Ngay = new DataGridViewTextBoxColumn();
            this.vao1 = new DataGridViewTextBoxColumn();
            this.Ra1 = new DataGridViewTextBoxColumn();
            this.vao2 = new DataGridViewTextBoxColumn();
            this.Ra2 = new DataGridViewTextBoxColumn();
            this.vao3 = new DataGridViewTextBoxColumn();
            this.Ra3 = new DataGridViewTextBoxColumn();
            this.Tonggio = new DataGridViewTextBoxColumn();
            this.PHUT = new DataGridViewTextBoxColumn();
         //   this.timer1 = new Timer(this.components);
            this.textBox1 = new TextBox();
            this.button3 = new Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.dgvtonghop).BeginInit();
            ((ISupportInitialize)this.dgv_chamcong).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 148f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1006, 678);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cob_thang);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txttong);
            this.panel1.Controls.Add(this.txtthoigian);
            this.panel1.Controls.Add(this.txtmara);
            this.panel1.Controls.Add(this.txtmavao);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1000, 142);
            this.panel1.TabIndex = 0;
            this.cob_thang.Font = new Font("Times New Roman", 20f);
            this.cob_thang.FormattingEnabled = true;
            this.cob_thang.Location = new Point(276, 103);
            this.cob_thang.Name = "cob_thang";
            this.cob_thang.Size = new Size(149, 39);
            this.cob_thang.TabIndex = 6;
            this.button2.Location = new Point(9, 101);
            this.button2.Name = "button2";
            this.button2.Size = new Size(261, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tổng giờ nhân viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(563, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(157, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "CHẤM CÔNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txttong.Font = new Font("Times New Roman", 20f);
            this.txttong.Location = new Point(763, 100);
            this.txttong.Name = "txttong";
            this.txttong.Size = new Size(240, 38);
            this.txttong.TabIndex = 3;
            this.txttong.Tag = "Tổng giờ";
            this.txttong.Text = "Tổng giờ";
            this.txtthoigian.BackColor = Color.White;
            this.txtthoigian.Font = new Font("Times New Roman", 20f);
            this.txtthoigian.Location = new Point(760, 2);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.ReadOnly = true;
            this.txtthoigian.Size = new Size(240, 38);
            this.txtthoigian.TabIndex = 2;
            this.txtthoigian.TextAlign = HorizontalAlignment.Center;
            this.txtmara.BackColor = Color.Yellow;
            this.txtmara.Font = new Font("Times New Roman", 50f);
            this.txtmara.ForeColor = Color.Red;
            this.txtmara.Location = new Point(276, 3);
            this.txtmara.Name = "txtmara";
            this.txtmara.Size = new Size(263, 84);
            this.txtmara.TabIndex = 1;
            this.txtmara.Tag = "Giờ ra";
            this.txtmara.Text = "Giờ ra";
            this.txtmara.Enter += this.txtmara_Enter;
            this.txtmara.KeyDown += this.txtmara_KeyDown;
            this.txtmara.Leave += this.txtmara_Leave;
            this.txtmavao.BackColor = Color.Yellow;
            this.txtmavao.Font = new Font("Times New Roman", 50f);
            this.txtmavao.ForeColor = Color.Red;
            this.txtmavao.Location = new Point(9, 3);
            this.txtmavao.Name = "txtmavao";
            this.txtmavao.Size = new Size(261, 84);
            this.txtmavao.TabIndex = 0;
            this.txtmavao.Tag = "Giờ vào";
            this.txtmavao.Text = "Giờ vào";
            this.txtmavao.Enter += this.txtmavao_Enter;
            this.txtmavao.KeyDown += this.txtmavao_KeyDown;
            this.txtmavao.Leave += this.txtmavao_Leave;
            this.panel2.Controls.Add(this.dgv_chamcong);
            this.panel2.Controls.Add(this.dgvtonghop);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(3, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1000, 524);
            this.panel2.TabIndex = 1;
            this.dgvtonghop.AllowUserToAddRows = false;
            this.dgvtonghop.AllowUserToDeleteRows = false;
            this.dgvtonghop.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvtonghop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvtonghop.ColumnHeadersHeight = 38;
            this.dgvtonghop.Columns.AddRange(new DataGridViewColumn[]
            {
                this.dataGridViewTextBoxColumn1,
                this.nhanvien,
                this.dataGridViewTextBoxColumn3,
                this.sogio,
                this.sophut
            });
            this.dgvtonghop.Dock = DockStyle.Fill;
            this.dgvtonghop.Location = new Point(0, 0);
            this.dgvtonghop.Name = "dgvtonghop";
            this.dgvtonghop.ReadOnly = true;
            this.dgvtonghop.RowHeadersVisible = false;
            this.dgvtonghop.RowTemplate.Height = 39;
            this.dgvtonghop.Size = new Size(1000, 524);
            this.dgvtonghop.TabIndex = 2;
            this.dgvtonghop.CellMouseDoubleClick += this.dgvtonghop_CellMouseDoubleClick;
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "TT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 44;
            this.nhanvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nhanvien.DataPropertyName = "MANV";
            this.nhanvien.HeaderText = "Mã NV";
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên NV";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            this.sogio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N1";
            this.sogio.DefaultCellStyle = dataGridViewCellStyle2;
            this.sogio.HeaderText = "Tổng giờ";
            this.sogio.Name = "sogio";
            this.sogio.ReadOnly = true;
            this.sophut.DataPropertyName = "TONGGIO";
            this.sophut.HeaderText = "PHUT";
            this.sophut.Name = "sophut";
            this.sophut.ReadOnly = true;
            this.sophut.Visible = false;
            this.dgv_chamcong.AllowUserToAddRows = false;
            this.dgv_chamcong.AllowUserToDeleteRows = false;
            this.dgv_chamcong.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dgv_chamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_chamcong.ColumnHeadersHeight = 38;
            this.dgv_chamcong.Columns.AddRange(new DataGridViewColumn[]
            {
                this.TT,
                this.manhanvien,
                this.tennhanvien,
                this.Ngay,
                this.vao1,
                this.Ra1,
                this.vao2,
                this.Ra2,
                this.vao3,
                this.Ra3,
                this.Tonggio,
                this.PHUT
            });
            this.dgv_chamcong.Dock = DockStyle.Fill;
            this.dgv_chamcong.Location = new Point(0, 0);
            this.dgv_chamcong.Name = "dgv_chamcong";
            this.dgv_chamcong.ReadOnly = true;
            this.dgv_chamcong.RowHeadersVisible = false;
            this.dgv_chamcong.RowTemplate.Height = 39;
            this.dgv_chamcong.Size = new Size(1000, 524);
            this.dgv_chamcong.TabIndex = 1;
            this.dgv_chamcong.RowPrePaint += this.dgv_chamcong_RowPrePaint;
            this.TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Width = 44;
            this.manhanvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.manhanvien.DataPropertyName = "MANV";
            this.manhanvien.HeaderText = "Mã NV";
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.ReadOnly = true;
            this.manhanvien.Visible = false;
            this.tennhanvien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tennhanvien.DataPropertyName = "TenNV";
            this.tennhanvien.HeaderText = "Tên NV";
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.ReadOnly = true;
            this.tennhanvien.Width = 200;
            this.Ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ngay.DataPropertyName = "ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 120;
            this.vao1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.vao1.DataPropertyName = "vao1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.vao1.DefaultCellStyle = dataGridViewCellStyle4;
            this.vao1.HeaderText = "Giờ vào1";
            this.vao1.Name = "vao1";
            this.vao1.ReadOnly = true;
            this.vao1.Width = 88;
            this.Ra1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ra1.DataPropertyName = "ra1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Ra1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ra1.HeaderText = "Giờ Ra1";
            this.Ra1.Name = "Ra1";
            this.Ra1.ReadOnly = true;
            this.Ra1.Width = 88;
            this.vao2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.vao2.DataPropertyName = "vao2";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.vao2.DefaultCellStyle = dataGridViewCellStyle6;
            this.vao2.HeaderText = "Giờ vào2";
            this.vao2.Name = "vao2";
            this.vao2.ReadOnly = true;
            this.vao2.Width = 88;
            this.Ra2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ra2.DataPropertyName = "ra2";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Ra2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Ra2.HeaderText = "Giờ ra2";
            this.Ra2.Name = "Ra2";
            this.Ra2.ReadOnly = true;
            this.Ra2.Width = 88;
            this.vao3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.vao3.DataPropertyName = "vao3";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.vao3.DefaultCellStyle = dataGridViewCellStyle8;
            this.vao3.HeaderText = "Giờ vào3";
            this.vao3.Name = "vao3";
            this.vao3.ReadOnly = true;
            this.vao3.Width = 88;
            this.Ra3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ra3.DataPropertyName = "ra3";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Ra3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Ra3.HeaderText = "Giờ ra3";
            this.Ra3.Name = "Ra3";
            this.Ra3.ReadOnly = true;
            this.Ra3.Width = 88;
            this.Tonggio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N1";
            this.Tonggio.DefaultCellStyle = dataGridViewCellStyle10;
            this.Tonggio.HeaderText = "Tổng giờ";
            this.Tonggio.Name = "Tonggio";
            this.Tonggio.ReadOnly = true;
            this.Tonggio.Width = 88;
            this.PHUT.DataPropertyName = "TONGGIO";
            this.PHUT.HeaderText = "PHUT";
            this.PHUT.Name = "PHUT";
            this.PHUT.ReadOnly = true;
            this.PHUT.Visible = false;
           // this.timer1.Interval = 1000;
           // this.timer1.Tick += this.timer1_Tick;
            this.textBox1.Font = new Font("Times New Roman", 20f);
            this.textBox1.Location = new Point(563, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(157, 38);
            this.textBox1.TabIndex = 10;
            this.textBox1.Tag = "Mã NV";
            this.textBox1.Text = "Mã NV";
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.textBox1.Enter += this.textBox1_Enter;
            this.textBox1.Leave += this.textBox1_Leave;
            this.button3.Location = new Point(433, 102);
            this.button3.Name = "button3";
            this.button3.Size = new Size(107, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xuất Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1006, 678);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
          //  base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frm_chamcong";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chọn thời gian làm việc";
            base.Load += this.Frm_chamcong_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvtonghop).EndInit();
            ((ISupportInitialize)this.dgv_chamcong).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x040005DC RID: 1500
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x040005DD RID: 1501
        private Panel panel1;

        // Token: 0x040005DE RID: 1502
        private TextBox txtmavao;

        // Token: 0x040005DF RID: 1503
        private TextBox txtmara;

        // Token: 0x040005E0 RID: 1504
        private TextBox txtthoigian;

        // Token: 0x040005E1 RID: 1505
        private DataGridView dgv_chamcong;

        // Token: 0x040005E2 RID: 1506
        private TextBox txttong;

        // Token: 0x040005E3 RID: 1507
        private Button button1;

        // Token: 0x040005E4 RID: 1508
       //rivate Timer timer1;

        // Token: 0x040005E5 RID: 1509
        private DataGridViewTextBoxColumn TT;

        // Token: 0x040005E6 RID: 1510
        private DataGridViewTextBoxColumn manhanvien;

        // Token: 0x040005E7 RID: 1511
        private DataGridViewTextBoxColumn tennhanvien;

        // Token: 0x040005E8 RID: 1512
        private DataGridViewTextBoxColumn Ngay;

        // Token: 0x040005E9 RID: 1513
        private DataGridViewTextBoxColumn vao1;

        // Token: 0x040005EA RID: 1514
        private DataGridViewTextBoxColumn Ra1;

        // Token: 0x040005EB RID: 1515
        private DataGridViewTextBoxColumn vao2;

        // Token: 0x040005EC RID: 1516
        private DataGridViewTextBoxColumn Ra2;

        // Token: 0x040005ED RID: 1517
        private DataGridViewTextBoxColumn vao3;

        // Token: 0x040005EE RID: 1518
        private DataGridViewTextBoxColumn Ra3;

        // Token: 0x040005EF RID: 1519
        private DataGridViewTextBoxColumn Tonggio;

        // Token: 0x040005F0 RID: 1520
        private DataGridViewTextBoxColumn PHUT;

        // Token: 0x040005F1 RID: 1521
        private Panel panel2;

        // Token: 0x040005F2 RID: 1522
        private DataGridView dgvtonghop;

        // Token: 0x040005F3 RID: 1523
        private Button button2;

        // Token: 0x040005F4 RID: 1524
        private ComboBox cob_thang;

        // Token: 0x040005F5 RID: 1525
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        // Token: 0x040005F6 RID: 1526
        private DataGridViewTextBoxColumn nhanvien;

        // Token: 0x040005F7 RID: 1527
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        // Token: 0x040005F8 RID: 1528
        private DataGridViewTextBoxColumn sogio;

        // Token: 0x040005F9 RID: 1529
        private DataGridViewTextBoxColumn sophut;

        // Token: 0x040005FA RID: 1530
        private TextBox textBox1;

        // Token: 0x040005FB RID: 1531
        private Button button3;
    }
}
