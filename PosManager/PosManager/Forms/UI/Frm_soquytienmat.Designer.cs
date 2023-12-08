using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_soquytienmat
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

        #region Windows Form Designer generated code

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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.dataGridView1 = new DataGridView();
            this.panel1 = new Panel();
            this.comboBox1 = new ComboBox();
            this.textBox2 = new TextBox();
            this.button5 = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.button4 = new Button();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.NGAY = new DataGridViewTextBoxColumn();
            this.sct = new DataGridViewTextBoxColumn();
            this.Diengiai = new DataGridViewTextBoxColumn();
            this.thu = new DataGridViewTextBoxColumn();
            this.thutienmat = new DataGridViewTextBoxColumn();
            this.Thutaikhoan = new DataGridViewTextBoxColumn();
            this.vnpay = new DataGridViewTextBoxColumn();
            this.Chi = new DataGridViewTextBoxColumn();
            this.chitienmat = new DataGridViewTextBoxColumn();
            this.chitaikhoan = new DataGridViewTextBoxColumn();
            this.Ton = new DataGridViewTextBoxColumn();
            this.nn = new DataGridViewTextBoxColumn();
            this.ghichu = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 92f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel1.Size = new Size(1006, 773);
            this.tableLayoutPanel1.TabIndex = 0;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.NGAY,
                this.sct,
                this.Diengiai,
                this.thu,
                this.thutienmat,
                this.Thutaikhoan,
                this.vnpay,
                this.Chi,
                this.chitienmat,
                this.chitaikhoan,
                this.Ton,
                this.nn,
                this.ghichu
            });
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.GridColor = Color.DimGray;
            this.dataGridView1.Location = new Point(3, 95);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.Size = new Size(1000, 675);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowLeave += this.dataGridView1_RowLeave;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1000, 86);
            this.panel1.TabIndex = 1;
            this.comboBox1.BackColor = Color.White;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(9, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(268, 29);
            this.comboBox1.TabIndex = 12;
            this.textBox2.Location = new Point(355, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(278, 29);
            this.textBox2.TabIndex = 11;
            this.textBox2.Tag = "Nội dung";
            this.textBox2.Text = "Nội dung";
            this.textBox2.Enter += this.textBox2_Enter;
            this.textBox2.Leave += this.textBox2_Leave;
            this.button5.Font = new Font("Times New Roman", 16f);
            this.button5.Location = new Point(881, 4);
            this.button5.Name = "button5";
            this.button5.Size = new Size(117, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "Xem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.dateTimePicker1.Location = new Point(734, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(146, 29);
            this.dateTimePicker1.TabIndex = 8;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(283, 8);
            this.label1.Name = "label1";
            this.label1.Size = new Size(66, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số tiền:";
            this.textBox1.Location = new Point(355, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(278, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.textBox1.Leave += this.textBox1_Leave;
            this.button4.Font = new Font("Times New Roman", 16f);
            this.button4.Location = new Point(639, 2);
            this.button4.Name = "button4";
            this.button4.Size = new Size(72, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.button4_Click_1;
            this.button3.Font = new Font("Times New Roman", 16f);
            this.button3.Location = new Point(1237, 2);
            this.button3.Name = "button3";
            this.button3.Size = new Size(12, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Chuyển khoản";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += this.button3_Click;
            this.button2.Font = new Font("Times New Roman", 16f);
            this.button2.Location = new Point(1237, 2);
            this.button2.Name = "button2";
            this.button2.Size = new Size(12, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += this.button2_Click;
            this.button1.Font = new Font("Times New Roman", 16f);
            this.button1.Location = new Point(881, 43);
            this.button1.Name = "button1";
            this.button1.Size = new Size(117, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xuất Excle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click_1;
            this.NGAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NGAY.DataPropertyName = "ngay";
            this.NGAY.Frozen = true;
            this.NGAY.HeaderText = "Ngày ghi sổ";
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            this.NGAY.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.NGAY.Width = 120;
            this.sct.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sct.DataPropertyName = "chungtu";
            this.sct.Frozen = true;
            this.sct.HeaderText = "Số chứng từ";
            this.sct.Name = "sct";
            this.sct.ReadOnly = true;
            this.sct.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.sct.Width = 120;
            this.Diengiai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Diengiai.DataPropertyName = "diengiai";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.Diengiai.DefaultCellStyle = dataGridViewCellStyle2;
            this.Diengiai.HeaderText = "Diễn giải";
            this.Diengiai.MinimumWidth = 200;
            this.Diengiai.Name = "Diengiai";
            this.Diengiai.ReadOnly = true;
            this.Diengiai.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Diengiai.Width = 250;
            this.thu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.thu.DataPropertyName = "sotienthu";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.thu.DefaultCellStyle = dataGridViewCellStyle3;
            this.thu.HeaderText = "Thu";
            this.thu.Name = "thu";
            this.thu.ReadOnly = true;
            this.thu.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.thu.Visible = false;
            this.thu.Width = 130;
            this.thutienmat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.thutienmat.DataPropertyName = "thutienmat";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.thutienmat.DefaultCellStyle = dataGridViewCellStyle4;
            this.thutienmat.HeaderText = "Thu tiền mặt";
            this.thutienmat.Name = "thutienmat";
            this.thutienmat.ReadOnly = true;
            this.thutienmat.Width = 130;
            this.Thutaikhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thutaikhoan.DataPropertyName = "thutaikhoan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Thutaikhoan.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thutaikhoan.HeaderText = "Thu tài khoản";
            this.Thutaikhoan.Name = "Thutaikhoan";
            this.Thutaikhoan.ReadOnly = true;
            this.Thutaikhoan.Width = 130;
            this.vnpay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.vnpay.DefaultCellStyle = dataGridViewCellStyle6;
            this.vnpay.HeaderText = "VN Pay";
            this.vnpay.Name = "vnpay";
            this.vnpay.ReadOnly = true;
            this.Chi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Chi.DataPropertyName = "sotienchi";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.Chi.DefaultCellStyle = dataGridViewCellStyle7;
            this.Chi.HeaderText = "Chi";
            this.Chi.Name = "Chi";
            this.Chi.ReadOnly = true;
            this.Chi.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Chi.Visible = false;
            this.Chi.Width = 130;
            this.chitienmat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.chitienmat.DataPropertyName = "chitienmat";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.chitienmat.DefaultCellStyle = dataGridViewCellStyle8;
            this.chitienmat.HeaderText = "Chi tiền mặt";
            this.chitienmat.Name = "chitienmat";
            this.chitienmat.ReadOnly = true;
            this.chitienmat.Width = 130;
            this.chitaikhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.chitaikhoan.DataPropertyName = "chitaikhoan";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.chitaikhoan.DefaultCellStyle = dataGridViewCellStyle9;
            this.chitaikhoan.HeaderText = "Chi tài khoản";
            this.chitaikhoan.Name = "chitaikhoan";
            this.chitaikhoan.ReadOnly = true;
            this.chitaikhoan.Width = 130;
            this.Ton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ton.DataPropertyName = "ton";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.Ton.DefaultCellStyle = dataGridViewCellStyle10;
            this.Ton.HeaderText = "Tồn";
            this.Ton.Name = "Ton";
            this.Ton.ReadOnly = true;
            this.Ton.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Ton.Width = 150;
            this.nn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nn.DataPropertyName = "nguoinhan";
            this.nn.HeaderText = "Người nhận/ nộp";
            this.nn.Name = "nn";
            this.nn.ReadOnly = true;
            this.nn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.nn.Width = 200;
            this.ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.SortMode = DataGridViewColumnSortMode.NotSortable;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1006, 773);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
            base.MaximizeBox = false;
            this.MaximumSize = new Size(1366, 1024);
            base.MinimizeBox = false;
            base.Name = "Frm_soquytienmat";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sổ quỹ tiền mặt";
            base.Load += this.Frm_soquytienmat_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.dataGridView1).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x0400023C RID: 572
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x0400023D RID: 573
        private DataGridView dataGridView1;

        // Token: 0x0400023E RID: 574
        private Panel panel1;

        // Token: 0x0400023F RID: 575
        private Button button1;

        // Token: 0x04000240 RID: 576
        private Button button3;

        // Token: 0x04000241 RID: 577
        private Button button2;

        // Token: 0x04000242 RID: 578
        private Button button4;

        // Token: 0x04000243 RID: 579
        private Label label1;

        // Token: 0x04000244 RID: 580
        private TextBox textBox1;

        // Token: 0x04000245 RID: 581
        private Button button5;

        // Token: 0x04000246 RID: 582
        private DateTimePicker dateTimePicker1;

        // Token: 0x04000247 RID: 583
        private TextBox textBox2;

        // Token: 0x04000248 RID: 584
        private ComboBox comboBox1;

        // Token: 0x04000249 RID: 585
        private DataGridViewTextBoxColumn NGAY;

        // Token: 0x0400024A RID: 586
        private DataGridViewTextBoxColumn sct;

        // Token: 0x0400024B RID: 587
        private DataGridViewTextBoxColumn Diengiai;

        // Token: 0x0400024C RID: 588
        private DataGridViewTextBoxColumn thu;

        // Token: 0x0400024D RID: 589
        private DataGridViewTextBoxColumn thutienmat;

        // Token: 0x0400024E RID: 590
        private DataGridViewTextBoxColumn Thutaikhoan;

        // Token: 0x0400024F RID: 591
        private DataGridViewTextBoxColumn vnpay;

        // Token: 0x04000250 RID: 592
        private DataGridViewTextBoxColumn Chi;

        // Token: 0x04000251 RID: 593
        private DataGridViewTextBoxColumn chitienmat;

        // Token: 0x04000252 RID: 594
        private DataGridViewTextBoxColumn chitaikhoan;

        // Token: 0x04000253 RID: 595
        private DataGridViewTextBoxColumn Ton;

        // Token: 0x04000254 RID: 596
        private DataGridViewTextBoxColumn nn;

        // Token: 0x04000255 RID: 597
        private DataGridViewTextBoxColumn ghichu;
    }
}