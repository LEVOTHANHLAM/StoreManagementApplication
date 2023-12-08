using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class FrmInmavach
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmInmavach));
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            this.button1 = new Button();
            this.printDocument1 = new PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.txttieude = new TextBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.dgvHangHoa = new DataGridView();
            this.STT = new DataGridViewCheckBoxColumn();
            this.mahanghoa = new DataGridViewTextBoxColumn();
            this.Tenhang = new DataGridViewTextBoxColumn();
            this.DVT = new DataGridViewTextBoxColumn();
            this.dongia = new DataGridViewTextBoxColumn();
            this.SLTEM = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.MANHOM = new DataGridViewTextBoxColumn();
            this.X = new DataGridViewButtonColumn();
            this.panel1 = new Panel();
            this.checkBox2 = new CheckBox();
            this.checkBox1 = new CheckBox();
            this.txtghichu = new TextBox();
            this.txtdong = new TextBox();
            this.txtlegia = new TextBox();
            this.txtlehang = new TextBox();
            this.txtleten = new TextBox();
            this.txtgia = new TextBox();
            this.txtcotenhang = new TextBox();
            this.txtcoten = new TextBox();
            this.txtleghichu = new TextBox();
            this.txtcoghichu = new TextBox();
            this.btluu = new Button();
            this.cbingia = new CheckBox();
            this.dtngay = new DateTimePicker();
            this.button3 = new Button();
            this.txtsodong = new TextBox();
            this.textBox8 = new TextBox();
            this.txtso = new TextBox();
            this.textBox17 = new TextBox();
            this.cobma = new ComboBox();
            this.textBox14 = new TextBox();
            this.cobmauin = new ComboBox();
            this.cbinten = new CheckBox();
            this.textBox2 = new TextBox();
            this.cobtenhang = new ComboBox();
            this.cobgia = new ComboBox();
            this.cobten = new ComboBox();
            this.cbgia = new CheckBox();
            this.txtmayin = new TextBox();
            this.txtleftma = new TextBox();
            this.textBox7 = new TextBox();
            this.txttopm = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox16 = new TextBox();
            this.textBox15 = new TextBox();
            this.txthd = new TextBox();
            this.textBox12 = new TextBox();
            this.txthm = new TextBox();
            this.textBox4 = new TextBox();
            this.txtwm = new TextBox();
            this.textBox13 = new TextBox();
            this.txtleft = new TextBox();
            this.textBox9 = new TextBox();
            this.txtletop = new TextBox();
            this.textBox11 = new TextBox();
            this.txth = new TextBox();
            this.textBox5 = new TextBox();
            this.txtw = new TextBox();
            this.textBox3 = new TextBox();
            this.txtsotem = new TextBox();
            this.textBox1 = new TextBox();
            this.txttimkiem = new TextBox();
            this.button2 = new Button();
            this.richTextBox1 = new RichTextBox();
            this.cbinpm = new CheckBox();
            this.textBox18 = new TextBox();
            this.button4 = new Button();
            this.cbgia2 = new CheckBox();
            this.cbxemin = new CheckBox();
            this.printDocument2 = new PrintDocument();
            this.printDocument3 = new PrintDocument();
            this.printDocument4 = new PrintDocument();
            this.printDocument5 = new PrintDocument();
            this.printDocument6 = new PrintDocument();
            this.txtso_kytu = new TextBox();
            this.textBox19 = new TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.dgvHangHoa).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(893, 69);
            this.button1.Margin = new Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(103, 103);
            this.button1.TabIndex = 19;
            this.button1.Text = "In tem\r\nmã vạch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
           // this.printDocument1.PrintPage += this.printDocument1_PrintPage;
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.txttieude.ForeColor = Color.FromArgb(64, 64, 64);
            this.txttieude.Location = new Point(426, 3);
            this.txttieude.Margin = new Padding(4);
            this.txttieude.MaxLength = 50;
            this.txttieude.Name = "txttieude";
            this.txttieude.Size = new Size(181, 26);
            this.txttieude.TabIndex = 31;
            this.txttieude.Text = "NS Đặng Phúc Vinh";
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.dgvHangHoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 570);
            this.tableLayoutPanel1.TabIndex = 102;
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.mahanghoa,
                this.Tenhang,
                this.DVT,
                this.dongia,
                this.SLTEM,
                this.GHICHU,
                this.MANHOM,
                this.X
            });
            this.dgvHangHoa.Dock = DockStyle.Fill;
            this.dgvHangHoa.Location = new Point(4, 185);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14f);
            this.dgvHangHoa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangHoa.RowTemplate.Height = 32;
            this.dgvHangHoa.Size = new Size(1000, 381);
            this.dgvHangHoa.TabIndex = 52;
            this.dgvHangHoa.CellClick += this.dgvHangHoa_CellClick;
            this.dgvHangHoa.CellEndEdit += this.dgvHangHoa_CellEndEdit_1;
            this.dgvHangHoa.CellMouseClick += this.dgvHangHoa_CellMouseClick;
            this.STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "chon";
            this.STT.HeaderText = "In";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = DataGridViewTriState.True;
            this.STT.SortMode = DataGridViewColumnSortMode.Automatic;
            this.STT.Width = 50;
            this.mahanghoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.mahanghoa.DataPropertyName = "MAHANGHOA";
            this.mahanghoa.HeaderText = "Mã Hàng";
            this.mahanghoa.Name = "mahanghoa";
            this.mahanghoa.ReadOnly = true;
            this.mahanghoa.Width = 158;
            this.Tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Tenhang.DataPropertyName = "TENHANGHOA";
            this.Tenhang.HeaderText = "Tên Hàng";
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.ReadOnly = true;
            this.Tenhang.Width = 339;
            this.DVT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DVT.DataPropertyName = "DONVITINH";
            this.DVT.HeaderText = "ĐVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.dongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dongia.DataPropertyName = "DONGIA";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.dongia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Width = 128;
            this.SLTEM.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SLTEM.DataPropertyName = "SL";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SLTEM.DefaultCellStyle = dataGridViewCellStyle4;
            this.SLTEM.HeaderText = "SL";
            this.SLTEM.Name = "SLTEM";
            this.SLTEM.ReadOnly = true;
            this.SLTEM.Width = 68;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.GHICHU.DataPropertyName = "ghichu";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.MANHOM.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MANHOM.DataPropertyName = "MANHOM";
            this.MANHOM.HeaderText = "Mã Nhóm";
            this.MANHOM.Name = "MANHOM";
            this.MANHOM.ReadOnly = true;
            this.MANHOM.Visible = false;
            this.X.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = DataGridViewTriState.True;
            this.X.SortMode = DataGridViewColumnSortMode.Automatic;
            this.X.Text = "x";
            this.X.UseColumnTextForButtonValue = true;
            this.X.Width = 35;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.txtdong);
            this.panel1.Controls.Add(this.txtlegia);
            this.panel1.Controls.Add(this.txtlehang);
            this.panel1.Controls.Add(this.txtleten);
            this.panel1.Controls.Add(this.txtgia);
            this.panel1.Controls.Add(this.txtcotenhang);
            this.panel1.Controls.Add(this.txtcoten);
            this.panel1.Controls.Add(this.txtleghichu);
            this.panel1.Controls.Add(this.txtcoghichu);
            this.panel1.Controls.Add(this.btluu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbingia);
            this.panel1.Controls.Add(this.dtngay);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtsodong);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.txtso);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.cobma);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.cobmauin);
            this.panel1.Controls.Add(this.cbinten);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cobtenhang);
            this.panel1.Controls.Add(this.cobgia);
            this.panel1.Controls.Add(this.cobten);
            this.panel1.Controls.Add(this.cbgia);
            this.panel1.Controls.Add(this.txtmayin);
            this.panel1.Controls.Add(this.txtleftma);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.txttopm);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.txthd);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.txthm);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.txtwm);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.txtleft);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.txtletop);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.txttieude);
            this.panel1.Controls.Add(this.txth);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.txtw);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtsotem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.cbinpm);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.cbgia2);
            this.panel1.Controls.Add(this.cbxemin);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.txtso_kytu);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1000, 174);
            this.panel1.TabIndex = 0;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(767, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(106, 23);
            this.checkBox2.TabIndex = 64;
            this.checkBox2.Text = "In đơn vị tính";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.MouseClick += this.checkBox2_MouseClick;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(766, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(94, 23);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "In mã hàng";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.txtghichu.BackColor = Color.Yellow;
            this.txtghichu.ForeColor = Color.FromArgb(64, 64, 64);
            this.txtghichu.Location = new Point(480, 103);
            this.txtghichu.Margin = new Padding(4);
            this.txtghichu.MaxLength = 20;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(220, 26);
            this.txtghichu.TabIndex = 32;
            this.txtghichu.Text = "đ";
            this.txtdong.Location = new Point(585, 78);
            this.txtdong.Name = "txtdong";
            this.txtdong.Size = new Size(63, 26);
            this.txtdong.TabIndex = 41;
            this.txtdong.Text = "1";
            this.txtdong.TextAlign = HorizontalAlignment.Center;
            this.txtlegia.Location = new Point(616, 28);
            this.txtlegia.Margin = new Padding(4);
            this.txtlegia.Name = "txtlegia";
            this.txtlegia.Size = new Size(32, 26);
            this.txtlegia.TabIndex = 16;
            this.txtlegia.Text = "0";
            this.txtlegia.TextAlign = HorizontalAlignment.Right;
            this.txtlehang.Location = new Point(616, 53);
            this.txtlehang.Margin = new Padding(4);
            this.txtlehang.Name = "txtlehang";
            this.txtlehang.Size = new Size(32, 26);
            this.txtlehang.TabIndex = 17;
            this.txtlehang.Text = "0";
            this.txtlehang.TextAlign = HorizontalAlignment.Right;
            this.txtleten.Location = new Point(616, 3);
            this.txtleten.Margin = new Padding(4);
            this.txtleten.Name = "txtleten";
            this.txtleten.Size = new Size(32, 26);
            this.txtleten.TabIndex = 14;
            this.txtleten.Text = "0";
            this.txtleten.TextAlign = HorizontalAlignment.Right;
            this.txtgia.Location = new Point(585, 28);
            this.txtgia.Margin = new Padding(4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new Size(32, 26);
            this.txtgia.TabIndex = 12;
            this.txtgia.Text = "10";
            this.txtgia.TextAlign = HorizontalAlignment.Right;
            this.txtcotenhang.Location = new Point(585, 53);
            this.txtcotenhang.Margin = new Padding(4);
            this.txtcotenhang.Name = "txtcotenhang";
            this.txtcotenhang.Size = new Size(32, 26);
            this.txtcotenhang.TabIndex = 13;
            this.txtcotenhang.Text = "8";
            this.txtcotenhang.TextAlign = HorizontalAlignment.Right;
            this.txtcoten.Location = new Point(585, 3);
            this.txtcoten.Margin = new Padding(4);
            this.txtcoten.Name = "txtcoten";
            this.txtcoten.Size = new Size(32, 26);
            this.txtcoten.TabIndex = 10;
            this.txtcoten.Text = "9";
            this.txtcoten.TextAlign = HorizontalAlignment.Right;
            this.txtleghichu.Location = new Point(728, 103);
            this.txtleghichu.Margin = new Padding(4);
            this.txtleghichu.Name = "txtleghichu";
            this.txtleghichu.Size = new Size(32, 26);
            this.txtleghichu.TabIndex = 15;
            this.txtleghichu.Text = "0";
            this.txtleghichu.TextAlign = HorizontalAlignment.Right;
            this.txtcoghichu.Location = new Point(697, 103);
            this.txtcoghichu.Margin = new Padding(4);
            this.txtcoghichu.Name = "txtcoghichu";
            this.txtcoghichu.Size = new Size(32, 26);
            this.txtcoghichu.TabIndex = 11;
            this.txtcoghichu.Text = "9";
            this.txtcoghichu.TextAlign = HorizontalAlignment.Right;
            this.btluu.BackgroundImageLayout = ImageLayout.Stretch;
            this.btluu.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btluu.Location = new Point(893, 4);
            this.btluu.Margin = new Padding(4);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(103, 50);
            this.btluu.TabIndex = 18;
            this.btluu.Text = "Lưu\r\ncấu hình";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += this.btluu_Click;
            this.cbingia.AutoSize = true;
            this.cbingia.Location = new Point(767, 80);
            this.cbingia.Name = "cbingia";
            this.cbingia.Size = new Size(61, 23);
            this.cbingia.TabIndex = 59;
            this.cbingia.Text = "In giá";
            this.cbingia.UseVisualStyleBackColor = true;
            this.cbingia.CheckedChanged += this.cbingia_CheckedChanged;
            this.dtngay.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dtngay.Location = new Point(513, 143);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new Size(106, 29);
            this.dtngay.TabIndex = 49;
            this.dtngay.ValueChanged += this.dtngay_ValueChanged;
            this.button3.BackColor = Color.Blue;
            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.Font = new Font("Times New Roman", 14f);
            this.button3.ForeColor = Color.White;
            this.button3.Location = new Point(335, 127);
            this.button3.Name = "button3";
            this.button3.Size = new Size(82, 44);
            this.button3.TabIndex = 56;
            this.button3.Text = "Chọn lại";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.txtsodong.BackColor = Color.White;
            this.txtsodong.ForeColor = Color.FromArgb(64, 64, 64);
            this.txtsodong.Location = new Point(190, 76);
            this.txtsodong.Margin = new Padding(4);
            this.txtsodong.Name = "txtsodong";
            this.txtsodong.Size = new Size(58, 26);
            this.txtsodong.TabIndex = 36;
            this.txtsodong.Text = "12";
            this.txtsodong.TextAlign = HorizontalAlignment.Right;
            this.textBox8.BackColor = Color.White;
            this.textBox8.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox8.Location = new Point(130, 76);
            this.textBox8.Margin = new Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new Size(68, 26);
            this.textBox8.TabIndex = 52;
            this.textBox8.Text = "Số dòng:";
            this.txtso.Location = new Point(130, 100);
            this.txtso.Margin = new Padding(4);
            this.txtso.Name = "txtso";
            this.txtso.Size = new Size(32, 26);
            this.txtso.TabIndex = 51;
            this.txtso.Text = "0";
            this.txtso.TextAlign = HorizontalAlignment.Right;
            this.textBox17.BackColor = Color.White;
            this.textBox17.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox17.Location = new Point(4, 100);
            this.textBox17.Margin = new Padding(4);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new Size(158, 26);
            this.textBox17.TabIndex = 50;
            this.textBox17.Text = "In từ dòng số:";
            this.cobma.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobma.FlatStyle = FlatStyle.Flat;
            this.cobma.Font = new Font("Times New Roman", 12f);
            this.cobma.FormattingEnabled = true;
            this.cobma.Location = new Point(619, 144);
            this.cobma.Name = "cobma";
            this.cobma.Size = new Size(141, 27);
            this.cobma.TabIndex = 48;
            this.cobma.SelectedIndexChanged += this.cobma_SelectedIndexChanged;
            this.textBox14.BackColor = Color.Yellow;
            this.textBox14.Font = new Font("Times New Roman", 14f);
            this.textBox14.ForeColor = Color.Black;
            this.textBox14.Location = new Point(426, 143);
            this.textBox14.Margin = new Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new Size(110, 29);
            this.textBox14.TabIndex = 47;
            this.textBox14.Text = "Phiếu nhập";
            this.textBox14.TextChanged += this.textBox14_TextChanged;
            this.cobmauin.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobmauin.FlatStyle = FlatStyle.Flat;
            this.cobmauin.Font = new Font("Times New Roman", 11f);
            this.cobmauin.FormattingEnabled = true;
            this.cobmauin.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            });
            this.cobmauin.Location = new Point(916, 105);
            this.cobmauin.Name = "cobmauin";
            this.cobmauin.Size = new Size(46, 25);
            this.cobmauin.TabIndex = 45;
            this.cobmauin.SelectedIndexChanged += this.cobmauin_SelectedIndexChanged;
            this.cbinten.AutoSize = true;
            this.cbinten.Location = new Point(767, 42);
            this.cbinten.Name = "cbinten";
            this.cbinten.Size = new Size(67, 23);
            this.cbinten.TabIndex = 43;
            this.cbinten.Text = "In Tên";
            this.cbinten.UseVisualStyleBackColor = true;
            this.textBox2.BackColor = Color.White;
            this.textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox2.Location = new Point(426, 78);
            this.textBox2.Margin = new Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(190, 26);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = "Số dòng của tên hàng";
            this.cobtenhang.Font = new Font("Times New Roman", 11f);
            this.cobtenhang.FormattingEnabled = true;
            this.cobtenhang.Items.AddRange(new object[]
            {
                "Arial",
                "Arial Narrow",
                "Tahoma",
                "VNI-Times",
                "VNI-Helve-Condense"
            });
            this.cobtenhang.Location = new Point(649, 53);
            this.cobtenhang.Name = "cobtenhang";
            this.cobtenhang.Size = new Size(111, 25);
            this.cobtenhang.TabIndex = 40;
            this.cobgia.Font = new Font("Times New Roman", 11f);
            this.cobgia.FormattingEnabled = true;
            this.cobgia.Items.AddRange(new object[]
            {
                "Arial",
                "Arial Narrow",
                "Tahoma",
                "VNI-Times",
                "VNI-Helve-Condense"
            });
            this.cobgia.Location = new Point(649, 27);
            this.cobgia.Name = "cobgia";
            this.cobgia.Size = new Size(111, 25);
            this.cobgia.TabIndex = 39;
            this.cobten.Font = new Font("Times New Roman", 11f);
            this.cobten.FormattingEnabled = true;
            this.cobten.Items.AddRange(new object[]
            {
                "Arial",
                "Arial Narrow",
                "Tahoma",
                "Haettenschweiler"
            });
            this.cobten.Location = new Point(649, 3);
            this.cobten.Name = "cobten";
            this.cobten.Size = new Size(111, 25);
            this.cobten.TabIndex = 38;
            this.cobten.SelectedIndexChanged += this.cobten_SelectedIndexChanged;
            this.cbgia.AutoSize = true;
            this.cbgia.Location = new Point(766, 3);
            this.cbgia.Name = "cbgia";
            this.cbgia.Size = new Size(110, 23);
            this.cbgia.TabIndex = 37;
            this.cbgia.Text = "Giá nằm dưới";
            this.cbgia.UseVisualStyleBackColor = true;
            this.txtmayin.Location = new Point(4, 75);
            this.txtmayin.Margin = new Padding(4);
            this.txtmayin.Name = "txtmayin";
            this.txtmayin.Size = new Size(118, 26);
            this.txtmayin.TabIndex = 35;
            this.txtmayin.Text = "may in";
            this.txtmayin.TextAlign = HorizontalAlignment.Center;
            this.txtleftma.Location = new Point(365, 75);
            this.txtleftma.Margin = new Padding(4);
            this.txtleftma.Name = "txtleftma";
            this.txtleftma.Size = new Size(52, 26);
            this.txtleftma.TabIndex = 9;
            this.txtleftma.Text = "0";
            this.txtleftma.TextAlign = HorizontalAlignment.Right;
            this.textBox7.BackColor = Color.White;
            this.textBox7.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox7.Location = new Point(259, 75);
            this.textBox7.Margin = new Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new Size(108, 26);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "Left mã vạch:";
            this.txttopm.Location = new Point(365, 50);
            this.txttopm.Margin = new Padding(4);
            this.txttopm.Name = "txttopm";
            this.txttopm.Size = new Size(52, 26);
            this.txttopm.TabIndex = 8;
            this.txttopm.Text = "0";
            this.txttopm.TextAlign = HorizontalAlignment.Right;
            this.textBox6.BackColor = Color.White;
            this.textBox6.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox6.Location = new Point(259, 50);
            this.textBox6.Margin = new Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new Size(108, 26);
            this.textBox6.TabIndex = 29;
            this.textBox6.Text = "Top mã vạch:";
            this.textBox16.BackColor = Color.White;
            this.textBox16.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox16.Location = new Point(426, 28);
            this.textBox16.Margin = new Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new Size(190, 26);
            this.textBox16.TabIndex = 33;
            this.textBox16.Text = "Cỡ chữ giá / lề:";
            this.textBox15.BackColor = Color.White;
            this.textBox15.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox15.Location = new Point(426, 53);
            this.textBox15.Margin = new Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new Size(190, 26);
            this.textBox15.TabIndex = 34;
            this.textBox15.Text = "Cỡ chữ tên hàng / lề:";
            this.txthd.Location = new Point(76, 50);
            this.txthd.Margin = new Padding(4);
            this.txthd.Name = "txthd";
            this.txthd.Size = new Size(46, 26);
            this.txthd.TabIndex = 2;
            this.txthd.Text = "14";
            this.txthd.TextAlign = HorizontalAlignment.Right;
            this.textBox12.BackColor = Color.White;
            this.textBox12.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox12.Location = new Point(4, 50);
            this.textBox12.Margin = new Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new Size(81, 26);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "Cách dòng:";
            this.txthm.Location = new Point(365, 27);
            this.txthm.Margin = new Padding(4);
            this.txthm.Name = "txthm";
            this.txthm.Size = new Size(52, 26);
            this.txthm.TabIndex = 7;
            this.txthm.Text = "32";
            this.txthm.TextAlign = HorizontalAlignment.Right;
            this.textBox4.BackColor = Color.White;
            this.textBox4.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox4.Location = new Point(259, 27);
            this.textBox4.Margin = new Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(108, 26);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "Height mã vạch:";
            this.txtwm.Location = new Point(365, 4);
            this.txtwm.Margin = new Padding(4);
            this.txtwm.Name = "txtwm";
            this.txtwm.Size = new Size(52, 26);
            this.txtwm.TabIndex = 6;
            this.txtwm.Text = "110";
            this.txtwm.TextAlign = HorizontalAlignment.Right;
            this.textBox13.BackColor = Color.White;
            this.textBox13.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox13.Location = new Point(259, 4);
            this.textBox13.Margin = new Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new Size(108, 26);
            this.textBox13.TabIndex = 27;
            this.textBox13.Text = "Width mã vạch:";
            this.txtleft.Location = new Point(76, 26);
            this.txtleft.Margin = new Padding(4);
            this.txtleft.Name = "txtleft";
            this.txtleft.Size = new Size(46, 26);
            this.txtleft.TabIndex = 1;
            this.txtleft.Text = "0";
            this.txtleft.TextAlign = HorizontalAlignment.Right;
            this.textBox9.BackColor = Color.White;
            this.textBox9.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox9.Location = new Point(4, 26);
            this.textBox9.Margin = new Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new Size(81, 26);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "Lề Left:";
            this.txtletop.Location = new Point(76, 3);
            this.txtletop.Margin = new Padding(4);
            this.txtletop.Name = "txtletop";
            this.txtletop.Size = new Size(46, 26);
            this.txtletop.TabIndex = 0;
            this.txtletop.Text = "0";
            this.txtletop.TextAlign = HorizontalAlignment.Right;
            this.textBox11.BackColor = Color.White;
            this.textBox11.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox11.Location = new Point(4, 3);
            this.textBox11.Margin = new Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new Size(81, 26);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "Lề Top:";
            this.txth.Location = new Point(190, 51);
            this.txth.Margin = new Padding(4);
            this.txth.Name = "txth";
            this.txth.Size = new Size(58, 26);
            this.txth.TabIndex = 5;
            this.txth.Text = "2.2";
            this.txth.TextAlign = HorizontalAlignment.Right;
            this.textBox5.BackColor = Color.White;
            this.textBox5.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox5.Location = new Point(130, 51);
            this.textBox5.Margin = new Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(68, 26);
            this.textBox5.TabIndex = 26;
            this.textBox5.Text = "Height:";
            this.txtw.Location = new Point(190, 26);
            this.txtw.Margin = new Padding(4);
            this.txtw.Name = "txtw";
            this.txtw.Size = new Size(58, 26);
            this.txtw.TabIndex = 4;
            this.txtw.Text = "3.5";
            this.txtw.TextAlign = HorizontalAlignment.Right;
            this.textBox3.BackColor = Color.White;
            this.textBox3.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox3.Location = new Point(130, 26);
            this.textBox3.Margin = new Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(68, 26);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Width:";
            this.txtsotem.Location = new Point(190, 3);
            this.txtsotem.Margin = new Padding(4);
            this.txtsotem.Name = "txtsotem";
            this.txtsotem.Size = new Size(58, 26);
            this.txtsotem.TabIndex = 3;
            this.txtsotem.Text = "3";
            this.txtsotem.TextAlign = HorizontalAlignment.Right;
            this.textBox1.BackColor = Color.White;
            this.textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox1.Location = new Point(130, 3);
            this.textBox1.Margin = new Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(68, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Số tem:";
            this.txttimkiem.BackColor = Color.Yellow;
            this.txttimkiem.Font = new Font("Times New Roman", 14f);
            this.txttimkiem.Location = new Point(4, 142);
            this.txttimkiem.Margin = new Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(329, 29);
            this.txttimkiem.TabIndex = 20;
            this.txttimkiem.Tag = "Tìm mã hàng, tên hàng cần IN TEM";
            this.txttimkiem.Text = "Tìm mã hàng, tên hàng cần IN TEM";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.button2.Location = new Point(916, 86);
            this.button2.Name = "button2";
            this.button2.Size = new Size(61, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.richTextBox1.Location = new Point(53, 55);
            this.richTextBox1.MaxLength = 13;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(251, 36);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.cbinpm.AutoSize = true;
            this.cbinpm.Location = new Point(767, 122);
            this.cbinpm.Name = "cbinpm";
            this.cbinpm.Size = new Size(104, 23);
            this.cbinpm.TabIndex = 54;
            this.cbinpm.Text = "In từ Access";
            this.cbinpm.UseVisualStyleBackColor = true;
            this.cbinpm.CheckedChanged += this.cbinpm_CheckedChanged;
            this.textBox18.BackColor = Color.White;
            this.textBox18.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox18.Location = new Point(426, 103);
            this.textBox18.Margin = new Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new Size(108, 26);
            this.textBox18.TabIndex = 61;
            this.textBox18.Text = "Ghi chú:";
            this.button4.Font = new Font("Times New Roman", 14f);
            this.button4.Location = new Point(160, 100);
            this.button4.Name = "button4";
            this.button4.Size = new Size(258, 27);
            this.button4.TabIndex = 58;
            this.button4.Text = "Thêm tên mặt hàng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.button4_Click;
            this.cbgia2.AutoSize = true;
            this.cbgia2.Font = new Font("Times New Roman", 16f);
            this.cbgia2.Location = new Point(767, 143);
            this.cbgia2.Name = "cbgia2";
            this.cbgia2.Size = new Size(102, 29);
            this.cbgia2.TabIndex = 63;
            this.cbgia2.Text = "In Giá 2";
            this.cbgia2.UseVisualStyleBackColor = true;
            this.cbgia2.MouseClick += this.cbgia2_MouseClick;
            this.cbxemin.AutoSize = true;
            this.cbxemin.Location = new Point(767, 61);
            this.cbxemin.Name = "cbxemin";
            this.cbxemin.Size = new Size(130, 23);
            this.cbxemin.TabIndex = 44;
            this.cbxemin.Text = "Xem trước khi in";
            this.cbxemin.UseVisualStyleBackColor = true;
            //this.printDocument2.PrintPage += this.printDocument2_PrintPage;
            //this.printDocument3.PrintPage += this.printDocument3_PrintPage_1;
            //this.printDocument4.PrintPage += this.printDocument4_PrintPage;
            //this.printDocument5.PrintPage += this.printDocument5_PrintPage;
            //this.printDocument6.PrintPage += this.printDocument6_PrintPage;
            this.txtso_kytu.Location = new Point(728, 79);
            this.txtso_kytu.Margin = new Padding(4);
            this.txtso_kytu.MaxLength = 2;
            this.txtso_kytu.Name = "txtso_kytu";
            this.txtso_kytu.Size = new Size(32, 26);
            this.txtso_kytu.TabIndex = 65;
            this.txtso_kytu.Text = "26";
            this.txtso_kytu.TextAlign = HorizontalAlignment.Right;
            this.textBox19.BackColor = Color.White;
            this.textBox19.ForeColor = Color.FromArgb(64, 64, 64);
            this.textBox19.Location = new Point(649, 79);
            this.textBox19.Margin = new Padding(4);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new Size(80, 26);
            this.textBox19.TabIndex = 66;
            this.textBox19.Text = "Số ký tự";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(192, 192, 255);
            base.ClientSize = new Size(1008, 570);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "FrmInmavach";
         //   base.StartPosition = FormStartPosition.Manual;
            this.Text = "In mã vạch";
         //   base.FormClosed += this.FrmInmavach_FormClosed;
            base.Load += this.FrmInmavach_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvHangHoa).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion

        // Token: 0x04000158 RID: 344
        private Button button1;

        // Token: 0x04000159 RID: 345
        private PrintDocument printDocument1;

        // Token: 0x0400015A RID: 346
        private PrintPreviewDialog printPreviewDialog1;

        // Token: 0x0400015B RID: 347
        private TextBox txttieude;

        // Token: 0x0400015C RID: 348
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x0400015D RID: 349
        private Panel panel1;

        // Token: 0x0400015E RID: 350
        private TextBox txttimkiem;

        // Token: 0x0400015F RID: 351
        private TextBox txtsotem;

        // Token: 0x04000160 RID: 352
        private TextBox txth;

        // Token: 0x04000161 RID: 353
        private TextBox textBox5;

        // Token: 0x04000162 RID: 354
        private TextBox txtw;

        // Token: 0x04000163 RID: 355
        private TextBox textBox3;

        // Token: 0x04000164 RID: 356
        private TextBox textBox1;

        // Token: 0x04000165 RID: 357
        private TextBox txtghichu;

        // Token: 0x04000166 RID: 358
        private TextBox txtleft;

        // Token: 0x04000167 RID: 359
        private TextBox textBox9;

        // Token: 0x04000168 RID: 360
        private TextBox txtletop;

        // Token: 0x04000169 RID: 361
        private TextBox textBox11;

        // Token: 0x0400016A RID: 362
        private TextBox txthm;

        // Token: 0x0400016B RID: 363
        private TextBox textBox4;

        // Token: 0x0400016C RID: 364
        private TextBox txtwm;

        // Token: 0x0400016D RID: 365
        private TextBox textBox13;

        // Token: 0x0400016E RID: 366
        private TextBox txthd;

        // Token: 0x0400016F RID: 367
        private TextBox textBox12;

        // Token: 0x04000170 RID: 368
        private TextBox txtcoghichu;

        // Token: 0x04000171 RID: 369
        private TextBox txtcoten;

        // Token: 0x04000172 RID: 370
        private TextBox txtcotenhang;

        // Token: 0x04000173 RID: 371
        private TextBox textBox15;

        // Token: 0x04000174 RID: 372
        private TextBox txtgia;

        // Token: 0x04000175 RID: 373
        private TextBox textBox16;

        // Token: 0x04000176 RID: 374
        private TextBox txtlegia;

        // Token: 0x04000177 RID: 375
        private TextBox txtlehang;

        // Token: 0x04000178 RID: 376
        private TextBox txtleghichu;

        // Token: 0x04000179 RID: 377
        private TextBox txtleten;

        // Token: 0x0400017A RID: 378
        private Button btluu;

        // Token: 0x0400017B RID: 379
        private TextBox txttopm;

        // Token: 0x0400017C RID: 380
        private TextBox textBox6;

        // Token: 0x0400017D RID: 381
        private TextBox txtleftma;

        // Token: 0x0400017E RID: 382
        private TextBox textBox7;

        // Token: 0x0400017F RID: 383
        private TextBox txtmayin;

        // Token: 0x04000180 RID: 384
        private CheckBox cbgia;

        // Token: 0x04000181 RID: 385
        private ComboBox cobtenhang;

        // Token: 0x04000182 RID: 386
        private ComboBox cobgia;

        // Token: 0x04000183 RID: 387
        private ComboBox cobten;

        // Token: 0x04000184 RID: 388
        private TextBox txtdong;

        // Token: 0x04000185 RID: 389
        private TextBox textBox2;

        // Token: 0x04000186 RID: 390
        private PrintDocument printDocument2;

        // Token: 0x04000187 RID: 391
        private CheckBox cbinten;

        // Token: 0x04000188 RID: 392
        private CheckBox cbxemin;

        // Token: 0x04000189 RID: 393
        private ComboBox cobmauin;

        // Token: 0x0400018A RID: 394
        private ComboBox cobma;

        // Token: 0x0400018B RID: 395
        private TextBox textBox14;

        // Token: 0x0400018C RID: 396
        private DateTimePicker dtngay;

        // Token: 0x0400018D RID: 397
        private TextBox txtso;

        // Token: 0x0400018E RID: 398
        private TextBox textBox17;

        // Token: 0x0400018F RID: 399
        private PrintDocument printDocument3;

        // Token: 0x04000190 RID: 400
        private DataGridView dgvHangHoa;

        // Token: 0x04000191 RID: 401
        private TextBox textBox8;

        // Token: 0x04000192 RID: 402
        private Button button2;

        // Token: 0x04000193 RID: 403
        private CheckBox cbinpm;

        // Token: 0x04000194 RID: 404
        private PrintDocument printDocument4;

        // Token: 0x04000195 RID: 405
        private RichTextBox richTextBox1;

        // Token: 0x04000196 RID: 406
        private Button button3;

        // Token: 0x04000197 RID: 407
        private Button button4;

        // Token: 0x04000198 RID: 408
        private CheckBox cbingia;

        // Token: 0x04000199 RID: 409
        private TextBox textBox18;

        // Token: 0x0400019A RID: 410
        private PrintDocument printDocument5;

        // Token: 0x0400019B RID: 411
        private PrintDocument printDocument6;

        // Token: 0x0400019C RID: 412
        private DataGridViewCheckBoxColumn STT;

        // Token: 0x0400019D RID: 413
        private DataGridViewTextBoxColumn mahanghoa;

        // Token: 0x0400019E RID: 414
        private DataGridViewTextBoxColumn Tenhang;

        // Token: 0x0400019F RID: 415
        private DataGridViewTextBoxColumn DVT;

        // Token: 0x040001A0 RID: 416
        private DataGridViewTextBoxColumn dongia;

        // Token: 0x040001A1 RID: 417
        private DataGridViewTextBoxColumn SLTEM;

        // Token: 0x040001A2 RID: 418
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x040001A3 RID: 419
        private DataGridViewTextBoxColumn MANHOM;

        // Token: 0x040001A4 RID: 420
        private DataGridViewButtonColumn X;

        // Token: 0x040001A5 RID: 421
        private CheckBox checkBox1;

        // Token: 0x040001A6 RID: 422
        private CheckBox cbgia2;

        // Token: 0x040001A7 RID: 423
        private TextBox txtsodong;

        // Token: 0x040001A8 RID: 424
        private CheckBox checkBox2;

        // Token: 0x040001A9 RID: 425
        private TextBox textBox19;

        // Token: 0x040001AA RID: 426
        private TextBox txtso_kytu;
    }
}
