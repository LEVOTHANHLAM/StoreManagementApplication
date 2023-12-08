using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmnhomhang
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.checkBox1 = new CheckBox();
            this.button3 = new Button();
            this.txtsd = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.btnhapexcel = new Button();
            this.txttimkiem = new TextBox();
            this.txttennhom = new TextBox();
            this.txtmanhom = new TextBox();
            this.button2 = new Button();
            this.button1 = new Button();
            this.dgvnhom = new DataGridView();
            this.manhom = new DataGridViewTextBoxColumn();
            this.Tennhom = new DataGridViewTextBoxColumn();
            this.HOAHONG = new DataGridViewTextBoxColumn();
            this.XOA = new DataGridViewButtonColumn();
            this.openFileDialog1 = new OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvnhom).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvnhom, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(961, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.BackColor = Color.FromArgb(230, 232, 244);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtsd);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnhapexcel);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.txttennhom);
            this.panel1.Controls.Add(this.txtmanhom);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(955, 103);
            this.panel1.TabIndex = 1;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = Color.FromArgb(222, 232, 244);
            this.checkBox1.FlatStyle = FlatStyle.Popup;
            this.checkBox1.Font = new Font("Times New Roman", 12f);
            this.checkBox1.Location = new Point(773, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(102, 42);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Tồn theo \r\nđơn vị tính lẻ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.MouseClick += this.checkBox1_MouseClick;
            this.button3.BackColor = Color.FromArgb(222, 232, 244);
            this.button3.BackgroundImageLayout = ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            this.button3.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Font = new Font("Times New Roman", 12f);
            this.button3.ForeColor = Color.Black;
            this.button3.Location = new Point(876, 1);
            this.button3.Name = "button3";
            this.button3.Size = new Size(76, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xuất Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.txtsd.Font = new Font("Times New Roman", 11f);
            this.txtsd.Location = new Point(772, 75);
            this.txtsd.Name = "txtsd";
            this.txtsd.ReadOnly = true;
            this.txtsd.Size = new Size(102, 24);
            this.txtsd.TabIndex = 9;
            this.txtsd.Tag = "0";
            this.txtsd.Text = "0";
            this.textBox2.Font = new Font("Times New Roman", 11f);
            this.textBox2.Location = new Point(433, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(334, 41);
            this.textBox2.TabIndex = 8;
            this.textBox2.Tag = "Tên nhóm";
            this.textBox2.Text = "01: 1 tấn = 40k\r\n02: 1% trên doanh thu";
            this.textBox1.Location = new Point(663, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(104, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "0";
            this.textBox1.Text = "0";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "01: Số lượng = số tiền",
                "02: Số tiền     = %"
            });
            this.comboBox1.Location = new Point(433, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(224, 27);
            this.comboBox1.TabIndex = 6;
            this.btnhapexcel.BackColor = Color.FromArgb(222, 232, 244);
            this.btnhapexcel.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnhapexcel.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            this.btnhapexcel.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.btnhapexcel.FlatStyle = FlatStyle.Flat;
            this.btnhapexcel.Font = new Font("Times New Roman", 12f);
            this.btnhapexcel.ForeColor = Color.Black;
            this.btnhapexcel.Location = new Point(876, 47);
            this.btnhapexcel.Name = "btnhapexcel";
            this.btnhapexcel.Size = new Size(76, 52);
            this.btnhapexcel.TabIndex = 5;
            this.btnhapexcel.Text = "Nhập Excel";
            this.btnhapexcel.UseVisualStyleBackColor = false;
            this.btnhapexcel.Click += this.btnhapexcel_Click;
            this.txttimkiem.BackColor = Color.Yellow;
            this.txttimkiem.Location = new Point(433, 73);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(334, 26);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.Tag = "Tìm Kiếm";
            this.txttimkiem.Text = "Tìm Kiếm";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.KeyDown += this.txttimkiem_KeyDown;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.txttennhom.Font = new Font("Times New Roman", 14f);
            this.txttennhom.Location = new Point(9, 33);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new Size(418, 29);
            this.txttennhom.TabIndex = 2;
            this.txttennhom.Tag = "Nhập tên nhóm";
            this.txttennhom.Text = "Nhập tên nhóm";
            this.txttennhom.Enter += this.txttennhom_Enter;
            this.txttennhom.KeyDown += this.txttennhom_KeyDown;
            this.txttennhom.Leave += this.txttennhom_Leave;
            this.txtmanhom.Font = new Font("Times New Roman", 14f);
            this.txtmanhom.Location = new Point(9, 3);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new Size(418, 29);
            this.txtmanhom.TabIndex = 1;
            this.txtmanhom.Tag = "Nhập mã nhóm";
            this.txtmanhom.Text = "Nhập mã nhóm";
            this.txtmanhom.TextChanged += this.txtmanhom_TextChanged;
            this.txtmanhom.Enter += this.txtmanhom_Enter;
            this.txtmanhom.KeyDown += this.txtmanhom_KeyDown;
            this.txtmanhom.Leave += this.txtmanhom_Leave;
            this.button2.BackColor = Color.FromArgb(222, 232, 244);
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            this.button2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button2.ForeColor = Color.Black;
            this.button2.Location = new Point(279, 63);
            this.button2.Name = "button2";
            this.button2.Size = new Size(148, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.button1.BackColor = Color.FromArgb(222, 232, 244);
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            this.button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.Black;
            this.button1.Location = new Point(9, 63);
            this.button1.Name = "button1";
            this.button1.Size = new Size(148, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.dgvnhom.AllowUserToAddRows = false;
            this.dgvnhom.AllowUserToDeleteRows = false;
            this.dgvnhom.BackgroundColor = Color.FromArgb(230, 232, 244);
            this.dgvnhom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhom.Columns.AddRange(new DataGridViewColumn[]
            {
                this.manhom,
                this.Tennhom,
                this.HOAHONG,
                this.XOA
            });
            this.dgvnhom.Dock = DockStyle.Fill;
            this.dgvnhom.Location = new Point(3, 112);
            this.dgvnhom.Name = "dgvnhom";
            this.dgvnhom.RowHeadersWidth = 4;
            this.dgvnhom.RowTemplate.Height = 35;
            this.dgvnhom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhom.Size = new Size(955, 373);
            this.dgvnhom.TabIndex = 0;
            this.dgvnhom.CellClick += this.dgvnhom_CellClick;
            this.dgvnhom.CellEndEdit += this.dgvnhom_CellEndEdit;
            this.dgvnhom.KeyDown += this.dgvnhom_KeyDown;
            this.dgvnhom.MouseDoubleClick += this.dgvnhom_MouseDoubleClick;
            this.manhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.manhom.DataPropertyName = "manhom";
            this.manhom.HeaderText = "Mã Nhóm";
            this.manhom.Name = "manhom";
            this.manhom.Width = 200;
            this.Tennhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Tennhom.DataPropertyName = "tennhom";
            this.Tennhom.HeaderText = "Tên Nhóm";
            this.Tennhom.Name = "Tennhom";
            this.HOAHONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HOAHONG.DataPropertyName = "HOAHONG";
            this.HOAHONG.HeaderText = "Hoa hồng";
            this.HOAHONG.Name = "HOAHONG";
            this.XOA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = Color.Blue;
            dataGridViewCellStyle.ForeColor = Color.White;
            this.XOA.DefaultCellStyle = dataGridViewCellStyle;
            this.XOA.FlatStyle = FlatStyle.Flat;
            this.XOA.HeaderText = "Xóa";
            this.XOA.Name = "XOA";
            this.XOA.Width = 45;
            this.openFileDialog1.FileName = "openFileDialog1";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(961, 488);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
           // base.MaximizeBox = false;
            //base.MinimizeBox = false;
            base.Name = "Frmnhomhang";
            //base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Nhóm hàng";
            //base.FormClosed += this.Frmnhomhang_FormClosed;
            base.Load += this.Frmnhomhang_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dgvnhom).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000C7C RID: 3196
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000C7D RID: 3197
        private Panel panel1;

        // Token: 0x04000C7E RID: 3198
        private Button button1;

        // Token: 0x04000C7F RID: 3199
        private DataGridView dgvnhom;

        // Token: 0x04000C80 RID: 3200
        private Button button2;

        // Token: 0x04000C81 RID: 3201
        private TextBox txttennhom;

        // Token: 0x04000C82 RID: 3202
        private TextBox txtmanhom;

        // Token: 0x04000C83 RID: 3203
        private TextBox txttimkiem;

        // Token: 0x04000C84 RID: 3204
        private Button btnhapexcel;

        // Token: 0x04000C85 RID: 3205
        private OpenFileDialog openFileDialog1;

        // Token: 0x04000C86 RID: 3206
        private ComboBox comboBox1;

        // Token: 0x04000C87 RID: 3207
        private TextBox textBox2;

        // Token: 0x04000C88 RID: 3208
        private TextBox textBox1;

        // Token: 0x04000C89 RID: 3209
        private DataGridViewTextBoxColumn manhom;

        // Token: 0x04000C8A RID: 3210
        private DataGridViewTextBoxColumn Tennhom;

        // Token: 0x04000C8B RID: 3211
        private DataGridViewTextBoxColumn HOAHONG;

        // Token: 0x04000C8C RID: 3212
        private DataGridViewButtonColumn XOA;

        // Token: 0x04000C8D RID: 3213
        private TextBox txtsd;

        // Token: 0x04000C8E RID: 3214
        private Button button3;

        // Token: 0x04000C8F RID: 3215
        private CheckBox checkBox1;
    }
}
