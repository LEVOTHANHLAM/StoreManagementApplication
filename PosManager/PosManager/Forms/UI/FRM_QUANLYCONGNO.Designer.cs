using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FRM_QUANLYCONGNO
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FRM_QUANLYCONGNO));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            this.button1 = new Button();
            this.button2 = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.dateTimePicker2 = new DateTimePicker();
            this.textBox4 = new TextBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.dataGridView1 = new DataGridView();
            this.dataGridView2 = new DataGridView();
            this.dataGridView3 = new DataGridView();
            this.TT = new DataGridViewTextBoxColumn();
            this.TTNO = new DataGridViewTextBoxColumn();
            this.TTTRA = new DataGridViewTextBoxColumn();
            this.TTCON = new DataGridViewTextBoxColumn();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.textBox3 = new TextBox();
            this.HINH = new DataGridViewImageColumn();
            this.MADONHANG = new DataGridViewTextBoxColumn();
            this.MANCC = new DataGridViewTextBoxColumn();
            this.TENNCC = new DataGridViewTextBoxColumn();
            this.SOTIENCONGNO = new DataGridViewTextBoxColumn();
            this.ngaycongno = new DataGridViewTextBoxColumn();
            this.SOTIENTRA = new DataGridViewTextBoxColumn();
            this.SOTIENNO = new DataGridViewTextBoxColumn();
            this.trangthai = new DataGridViewTextBoxColumn();
            this.ngay = new DataGridViewTextBoxColumn();
            this.st = new DataGridViewTextBoxColumn();
            this.IM_HINH = new DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            ((ISupportInitialize)this.dataGridView2).BeginInit();
            ((ISupportInitialize)this.dataGridView3).BeginInit();
            base.SuspendLayout();
            this.button1.BackColor = Color.RoyalBlue;
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(191, 1);
            this.button1.Name = "button1";
            this.button1.Size = new Size(265, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÊM ĐƠN HÀNG CÔNG NỢ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.button2.BackColor = Color.RoyalBlue;
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(473, 1);
            this.button2.Name = "button2";
            this.button2.Size = new Size(257, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "THÊM NHÀ CUNG CẤP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.textBox1.Location = new Point(93, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(180, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(4, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(99, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Tìm kiếm";
            this.dateTimePicker1.Location = new Point(474, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(120, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker2.Location = new Point(616, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(115, 27);
            this.dateTimePicker2.TabIndex = 8;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Location = new Point(597, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(17, 27);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "-";
            this.textBox4.TextAlign = HorizontalAlignment.Center;
            this.tableLayoutPanel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView3, 0, 1);
            this.tableLayoutPanel1.Location = new Point(1, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel1.Size = new Size(1006, 653);
            this.tableLayoutPanel1.TabIndex = 9;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12.5f);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.HINH,
                this.MADONHANG,
                this.MANCC,
                this.TENNCC,
                this.SOTIENCONGNO,
                this.ngaycongno,
                this.SOTIENTRA,
                this.SOTIENNO,
                this.trangthai
            });
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new Size(1000, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += this.dataGridView1_CellMouseClick;
            this.dataGridView1.CellMouseDoubleClick += this.dataGridView1_CellMouseDoubleClick;
            this.dataGridView1.MouseClick += this.dataGridView1_MouseClick;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = Color.FromArgb(224, 224, 224);
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new DataGridViewColumn[]
            {
                this.ngay,
                this.st,
                this.IM_HINH
            });
            this.dataGridView2.Dock = DockStyle.Fill;
            this.dataGridView2.Location = new Point(3, 471);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.Size = new Size(1000, 179);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellMouseClick += this.dataGridView2_CellMouseClick;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12.5f);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeight = 39;
            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new DataGridViewColumn[]
            {
                this.TT,
                this.TTNO,
                this.TTTRA,
                this.TTCON
            });
            this.dataGridView3.Dock = DockStyle.Fill;
            this.dataGridView3.Location = new Point(3, 426);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 35;
            this.dataGridView3.RowTemplate.Resizable = DataGridViewTriState.True;
            this.dataGridView3.ScrollBars = ScrollBars.None;
            this.dataGridView3.Size = new Size(1000, 39);
            this.dataGridView3.TabIndex = 0;
            this.TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TT.DataPropertyName = "MADONHANG";
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14f);
            this.TT.DefaultCellStyle = dataGridViewCellStyle3;
            this.TT.HeaderText = "Mã số";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Width = 200;
            this.TTNO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TTNO.DataPropertyName = "SOTIENNO";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            dataGridViewCellStyle4.Format = "N0";
            this.TTNO.DefaultCellStyle = dataGridViewCellStyle4;
            this.TTNO.HeaderText = "Tiền công nợ";
            this.TTNO.Name = "TTNO";
            this.TTNO.ReadOnly = true;
            this.TTNO.Width = 377;
            this.TTTRA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TTTRA.DataPropertyName = "SOTIENTRA";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            dataGridViewCellStyle5.Format = "N0";
            this.TTTRA.DefaultCellStyle = dataGridViewCellStyle5;
            this.TTTRA.HeaderText = "Số tiền trả";
            this.TTTRA.Name = "TTTRA";
            this.TTTRA.ReadOnly = true;
            this.TTTRA.Width = 220;
            this.TTCON.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TTCON.DataPropertyName = "SOTIENCONNO";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            dataGridViewCellStyle6.Format = "N0";
            this.TTCON.DefaultCellStyle = dataGridViewCellStyle6;
            this.TTCON.HeaderText = "Số tiền nợ";
            this.TTCON.Name = "TTCON";
            this.TTCON.ReadOnly = true;
            this.TTCON.Width = 200;
            this.button3.Location = new Point(733, 49);
            this.button3.Name = "button3";
            this.button3.Size = new Size(171, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tìm theo ngày";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button4.BackColor = Color.RoyalBlue;
            this.button4.ForeColor = Color.White;
            this.button4.Location = new Point(4, 1);
            this.button4.Name = "button4";
            this.button4.Size = new Size(90, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += this.button4_Click;
            this.button5.Location = new Point(948, 49);
            this.button5.Name = "button5";
            this.button5.Size = new Size(59, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.textBox3.Location = new Point(274, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(180, 27);
            this.textBox3.TabIndex = 13;
            this.textBox3.Tag = "Tìm nhà phân phối";
            this.textBox3.Text = "Tìm nhà phân phối";
            this.textBox3.TextChanged += this.textBox3_TextChanged;
            this.textBox3.Enter += this.textBox3_Enter;
            this.textBox3.Leave += this.textBox3_Leave;
            this.HINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HINH.HeaderText = "Hình";
            this.HINH.Image = (Image)componentResourceManager.GetObject("HINH.Image");
            this.HINH.Name = "HINH";
            this.HINH.ReadOnly = true;
            this.HINH.Width = 50;
            this.MADONHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MADONHANG.DataPropertyName = "MADONHANG";
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MADONHANG.DefaultCellStyle = dataGridViewCellStyle7;
            this.MADONHANG.HeaderText = "Mã số";
            this.MADONHANG.Name = "MADONHANG";
            this.MADONHANG.ReadOnly = true;
            this.MANCC.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã npp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.TENNCC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên nhà phân phối";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.SOTIENCONGNO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTIENCONGNO.DataPropertyName = "SOTIENNO";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.SOTIENCONGNO.DefaultCellStyle = dataGridViewCellStyle8;
            this.SOTIENCONGNO.HeaderText = "Tiền công nợ";
            this.SOTIENCONGNO.Name = "SOTIENCONGNO";
            this.SOTIENCONGNO.ReadOnly = true;
            this.SOTIENCONGNO.Width = 120;
            this.ngaycongno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngaycongno.DataPropertyName = "NGAY";
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ngaycongno.DefaultCellStyle = dataGridViewCellStyle9;
            this.ngaycongno.HeaderText = "Ngày công nợ";
            this.ngaycongno.Name = "ngaycongno";
            this.ngaycongno.ReadOnly = true;
            this.ngaycongno.Width = 120;
            this.SOTIENTRA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTIENTRA.DataPropertyName = "SOTIENTRA";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.SOTIENTRA.DefaultCellStyle = dataGridViewCellStyle10;
            this.SOTIENTRA.HeaderText = "Số tiền trả";
            this.SOTIENTRA.Name = "SOTIENTRA";
            this.SOTIENTRA.ReadOnly = true;
            this.SOTIENNO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTIENNO.DataPropertyName = "SOTIENCONNO";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.SOTIENNO.DefaultCellStyle = dataGridViewCellStyle11;
            this.SOTIENNO.HeaderText = "Số tiền nợ";
            this.SOTIENNO.Name = "SOTIENNO";
            this.SOTIENNO.ReadOnly = true;
            this.trangthai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Resizable = DataGridViewTriState.True;
            this.ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngay.DataPropertyName = "NGAYTHANHTOAN";
            this.ngay.HeaderText = "Ngày trả";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 200;
            this.st.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.st.DataPropertyName = "SOTIENTRA";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.st.DefaultCellStyle = dataGridViewCellStyle12;
            this.st.HeaderText = "Số tiền trả";
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Width = 150;
            this.IM_HINH.HeaderText = "Hình";
            this.IM_HINH.Image = (Image)componentResourceManager.GetObject("IM_HINH.Image");
            this.IM_HINH.Name = "IM_HINH";
            this.IM_HINH.ReadOnly = true;
            this.IM_HINH.Resizable = DataGridViewTriState.True;
            this.IM_HINH.SortMode = DataGridViewColumnSortMode.Automatic;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 729);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.tableLayoutPanel1);
            base.Controls.Add(this.dateTimePicker2);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.dateTimePicker1);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox2);
            this.Font = new Font("Times New Roman", 12.5f);
            base.Margin = new Padding(4, 5, 4, 5);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FRM_QUANLYCONGNO";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CÔNG NỢ";
            base.Load += this.FRM_QUANLYCONGNO_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.dataGridView1).EndInit();
            ((ISupportInitialize)this.dataGridView2).EndInit();
            ((ISupportInitialize)this.dataGridView3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x040006D5 RID: 1749
        private Button button1;

        // Token: 0x040006D6 RID: 1750
        private Button button2;

        // Token: 0x040006D7 RID: 1751
        private TextBox textBox1;

        // Token: 0x040006D8 RID: 1752
        private TextBox textBox2;

        // Token: 0x040006D9 RID: 1753
        private DateTimePicker dateTimePicker1;

        // Token: 0x040006DA RID: 1754
        private DateTimePicker dateTimePicker2;

        // Token: 0x040006DB RID: 1755
        private TextBox textBox4;

        // Token: 0x040006DC RID: 1756
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x040006DD RID: 1757
        private DataGridView dataGridView1;

        // Token: 0x040006DE RID: 1758
        private DataGridView dataGridView2;

        // Token: 0x040006DF RID: 1759
        private Button button3;

        // Token: 0x040006E0 RID: 1760
        private Button button4;

        // Token: 0x040006E1 RID: 1761
        private Button button5;

        // Token: 0x040006E2 RID: 1762
        private TextBox textBox3;

        // Token: 0x040006E3 RID: 1763
        private DataGridView dataGridView3;

        // Token: 0x040006E4 RID: 1764
        private DataGridViewTextBoxColumn TT;

        // Token: 0x040006E5 RID: 1765
        private DataGridViewTextBoxColumn TTNO;

        // Token: 0x040006E6 RID: 1766
        private DataGridViewTextBoxColumn TTTRA;

        // Token: 0x040006E7 RID: 1767
        private DataGridViewTextBoxColumn TTCON;

        // Token: 0x040006E8 RID: 1768
        private DataGridViewImageColumn HINH;

        // Token: 0x040006E9 RID: 1769
        private DataGridViewTextBoxColumn MADONHANG;

        // Token: 0x040006EA RID: 1770
        private DataGridViewTextBoxColumn MANCC;

        // Token: 0x040006EB RID: 1771
        private DataGridViewTextBoxColumn TENNCC;

        // Token: 0x040006EC RID: 1772
        private DataGridViewTextBoxColumn SOTIENCONGNO;

        // Token: 0x040006ED RID: 1773
        private DataGridViewTextBoxColumn ngaycongno;

        // Token: 0x040006EE RID: 1774
        private DataGridViewTextBoxColumn SOTIENTRA;

        // Token: 0x040006EF RID: 1775
        private DataGridViewTextBoxColumn SOTIENNO;

        // Token: 0x040006F0 RID: 1776
        private DataGridViewTextBoxColumn trangthai;

        // Token: 0x040006F1 RID: 1777
        private DataGridViewTextBoxColumn ngay;

        // Token: 0x040006F2 RID: 1778
        private DataGridViewTextBoxColumn st;

        // Token: 0x040006F3 RID: 1779
        private DataGridViewImageColumn IM_HINH;
    }
}