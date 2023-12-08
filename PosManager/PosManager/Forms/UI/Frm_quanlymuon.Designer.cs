using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_quanlymuon
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Frm_quanlymuon));
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button6 = new Button();
            this.button5 = new Button();
            this.button4 = new Button();
            this.button3 = new Button();
            this.dt2 = new DateTimePicker();
            this.textBox4 = new TextBox();
            this.dt1 = new DateTimePicker();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            this.button1 = new Button();
            this.textBox2 = new TextBox();
            this.dataGridView1 = new DataGridView();
            this.MADONHANG = new DataGridViewTextBoxColumn();
            this.ten = new DataGridViewTextBoxColumn();
            this.ngay = new DataGridViewTextBoxColumn();
            this.nd = new DataGridViewTextBoxColumn();
            this.Hinh = new DataGridViewImageColumn();
            this.ngaytra = new DataGridViewTextBoxColumn();
            this.Ndtra = new DataGridViewTextBoxColumn();
            this.hinhtra = new DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dt2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.dt1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1002, 81);
            this.panel1.TabIndex = 0;
            this.button6.BackColor = Color.RoyalBlue;
            this.button6.ForeColor = Color.White;
            this.button6.Location = new Point(131, -1);
            this.button6.Name = "button6";
            this.button6.Size = new Size(94, 46);
            this.button6.TabIndex = 24;
            this.button6.Text = "Đang mượn";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += this.button6_Click;
            this.button5.Location = new Point(944, 49);
            this.button5.Name = "button5";
            this.button5.Size = new Size(59, 29);
            this.button5.TabIndex = 23;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.button4.BackColor = Color.RoyalBlue;
            this.button4.ForeColor = Color.White;
            this.button4.Location = new Point(-3, -1);
            this.button4.Name = "button4";
            this.button4.Size = new Size(94, 46);
            this.button4.TabIndex = 22;
            this.button4.Text = "Đã trả";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += this.button4_Click;
            this.button3.Location = new Point(746, 49);
            this.button3.Name = "button3";
            this.button3.Size = new Size(154, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Tìm theo ngày";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.dt2.Location = new Point(612, 50);
            this.dt2.Name = "dt2";
            this.dt2.Size = new Size(115, 26);
            this.dt2.TabIndex = 20;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Location = new Point(593, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(17, 26);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "-";
            this.textBox4.TextAlign = HorizontalAlignment.Center;
            this.dt1.Location = new Point(470, 50);
            this.dt1.Name = "dt1";
            this.dt1.Size = new Size(120, 26);
            this.dt1.TabIndex = 18;
            this.textBox1.Location = new Point(89, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(349, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.button2.BackColor = Color.RoyalBlue;
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(746, 0);
            this.button2.Name = "button2";
            this.button2.Size = new Size(257, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "THÊM NHÀ CUNG CẤP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.button1.BackColor = Color.RoyalBlue;
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(470, 0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(265, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "THÊM ĐƠN HÀNG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(0, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(99, 26);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Tìm kiếm";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MADONHANG,
                this.ten,
                this.ngay,
                this.nd,
                this.Hinh,
                this.ngaytra,
                this.Ndtra,
                this.hinhtra
            });
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(3, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new Size(1002, 636);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += this.dataGridView1_CellMouseClick;
            this.MADONHANG.DataPropertyName = "MADONHANG";
            this.MADONHANG.HeaderText = "Mã";
            this.MADONHANG.Name = "MADONHANG";
            this.MADONHANG.ReadOnly = true;
            this.MADONHANG.Visible = false;
            this.ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "TENNCC";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngay.DataPropertyName = "NGAY";
            this.ngay.HeaderText = "Ngày mượn";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 126;
            this.nd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nd.DataPropertyName = "NOIDUNGMUON";
            this.nd.HeaderText = "Nội dung";
            this.nd.Name = "nd";
            this.nd.ReadOnly = true;
            this.nd.Width = 225;
            this.Hinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Hinh.HeaderText = "Hình";
            this.Hinh.Image = (Image)componentResourceManager.GetObject("Hinh.Image");
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            this.Hinh.Width = 50;
            this.ngaytra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngaytra.DataPropertyName = "NGAYTRA";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.ReadOnly = true;
            this.ngaytra.Resizable = DataGridViewTriState.True;
            this.ngaytra.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.ngaytra.Width = 126;
            this.Ndtra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ndtra.DataPropertyName = "NOIDUNGTRA";
            this.Ndtra.HeaderText = "Nội dung trả";
            this.Ndtra.Name = "Ndtra";
            this.Ndtra.ReadOnly = true;
            this.Ndtra.Resizable = DataGridViewTriState.True;
            this.Ndtra.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Ndtra.Width = 225;
            this.hinhtra.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.hinhtra.HeaderText = "Hình";
            this.hinhtra.Image = (Image)componentResourceManager.GetObject("hinhtra.Image");
            this.hinhtra.Name = "hinhtra";
            this.hinhtra.ReadOnly = true;
            this.hinhtra.Width = 50;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 729);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_quanlymuon";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Danh sách mượn";
            base.Load += this.Frm_quanlymuon_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion

        // Token: 0x040012CD RID: 4813
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x040012CE RID: 4814
        private Panel panel1;

        // Token: 0x040012CF RID: 4815
        private Button button5;

        // Token: 0x040012D0 RID: 4816
        private Button button4;

        // Token: 0x040012D1 RID: 4817
        private Button button3;

        // Token: 0x040012D2 RID: 4818
        private DateTimePicker dt2;

        // Token: 0x040012D3 RID: 4819
        private TextBox textBox4;

        // Token: 0x040012D4 RID: 4820
        private DateTimePicker dt1;

        // Token: 0x040012D5 RID: 4821
        private TextBox textBox1;

        // Token: 0x040012D6 RID: 4822
        private Button button2;

        // Token: 0x040012D7 RID: 4823
        private Button button1;

        // Token: 0x040012D8 RID: 4824
        private TextBox textBox2;

        // Token: 0x040012D9 RID: 4825
        private DataGridView dataGridView1;

        // Token: 0x040012DA RID: 4826
        private Button button6;

        // Token: 0x040012DB RID: 4827
        private DataGridViewTextBoxColumn MADONHANG;

        // Token: 0x040012DC RID: 4828
        private DataGridViewTextBoxColumn ten;

        // Token: 0x040012DD RID: 4829
        private DataGridViewTextBoxColumn ngay;

        // Token: 0x040012DE RID: 4830
        private DataGridViewTextBoxColumn nd;

        // Token: 0x040012DF RID: 4831
        private DataGridViewImageColumn Hinh;

        // Token: 0x040012E0 RID: 4832
        private DataGridViewTextBoxColumn ngaytra;

        // Token: 0x040012E1 RID: 4833
        private DataGridViewTextBoxColumn Ndtra;

        // Token: 0x040012E2 RID: 4834
        private DataGridViewImageColumn hinhtra;
    }
}