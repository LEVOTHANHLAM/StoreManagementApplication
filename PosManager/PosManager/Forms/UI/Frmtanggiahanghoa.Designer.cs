using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmtanggiahanghoa
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.dgvhanghoa = new DataGridView();
            this.STT = new DataGridViewCheckBoxColumn();
            this.MAHANGHOA = new DataGridViewTextBoxColumn();
            this.tenhang = new DataGridViewTextBoxColumn();
            this.Đvt1 = new DataGridViewTextBoxColumn();
            this.dvt2 = new DataGridViewTextBoxColumn();
            this.gia1 = new DataGridViewTextBoxColumn();
            this.Gia2 = new DataGridViewTextBoxColumn();
            this.Gia3 = new DataGridViewTextBoxColumn();
            this.Gia4 = new DataGridViewTextBoxColumn();
            this.gia5 = new DataGridViewTextBoxColumn();
            this.gia6 = new DataGridViewTextBoxColumn();
            this.Ck = new DataGridViewTextBoxColumn();
            this.Ghichu = new DataGridViewTextBoxColumn();
            this.Nhom = new DataGridViewTextBoxColumn();
            this.nh = new DataGridViewTextBoxColumn();
            this.dvt3 = new DataGridViewTextBoxColumn();
            this.vat = new DataGridViewTextBoxColumn();
            this.QD1 = new DataGridViewTextBoxColumn();
            this.quydoi1 = new DataGridViewTextBoxColumn();
            this.cc = new DataGridViewTextBoxColumn();
            this.giavon = new DataGridViewTextBoxColumn();
            this.donvitinhlon3 = new DataGridViewTextBoxColumn();
            this.diem = new DataGridViewTextBoxColumn();
            this.sl1 = new DataGridViewTextBoxColumn();
            this.sl2 = new DataGridViewTextBoxColumn();
            this.sl3 = new DataGridViewTextBoxColumn();
            this.sl4 = new DataGridViewTextBoxColumn();
            this.sl5 = new DataGridViewTextBoxColumn();
            this.sl6 = new DataGridViewTextBoxColumn();
            this.sl_canhbao = new DataGridViewTextBoxColumn();
            this.slban = new DataGridViewTextBoxColumn();
            this.sltang = new DataGridViewTextBoxColumn();
            this.mahang = new DataGridViewTextBoxColumn();
            this.slton = new DataGridViewTextBoxColumn();
            this.panel1 = new Panel();
            this.panel3 = new Panel();
            this.checkBox9 = new CheckBox();
            this.checkBox8 = new CheckBox();
            this.checkBox7 = new CheckBox();
            this.checkBox6 = new CheckBox();
            this.checkBox5 = new CheckBox();
            this.checkBox4 = new CheckBox();
            this.checkBox3 = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.checkBox1 = new CheckBox();
            this.txtgia = new TextBox();
            this.label1 = new Label();
            this.radioButton1 = new RadioButton();
            this.rbtangnhom = new RadioButton();
            this.button1 = new Button();
            this.txtsodong = new TextBox();
            this.cobnhom = new ComboBox();
            this.panel2 = new Panel();
            this.comboBox1 = new ComboBox();
            this.checkBox10 = new CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.dgvhanghoa).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.dgvhanghoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AllowUserToDeleteRows = false;
            this.dgvhanghoa.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvhanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.MAHANGHOA,
                this.tenhang,
                this.Đvt1,
                this.dvt2,
                this.gia1,
                this.Gia2,
                this.Gia3,
                this.Gia4,
                this.gia5,
                this.gia6,
                this.Ck,
                this.Ghichu,
                this.Nhom,
                this.nh,
                this.dvt3,
                this.vat,
                this.QD1,
                this.quydoi1,
                this.cc,
                this.giavon,
                this.donvitinhlon3,
                this.diem,
                this.sl1,
                this.sl2,
                this.sl3,
                this.sl4,
                this.sl5,
                this.sl6,
                this.sl_canhbao,
                this.slban,
                this.sltang,
                this.mahang,
                this.slton
            });
            this.dgvhanghoa.Dock = DockStyle.Fill;
            this.dgvhanghoa.Location = new Point(3, 100);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.RowHeadersWidth = 4;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 192);
            this.dgvhanghoa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvhanghoa.Size = new Size(1002, 362);
            this.dgvhanghoa.TabIndex = 56;
            this.STT.FalseValue = "";
            this.STT.HeaderText = "Chọn";
            this.STT.Name = "STT";
            this.STT.Resizable = DataGridViewTriState.True;
            this.STT.SortMode = DataGridViewColumnSortMode.Automatic;
            this.STT.Width = 45;
            this.MAHANGHOA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHANGHOA.DataPropertyName = "MAHANGhoa";
            this.MAHANGHOA.HeaderText = "Mã hàng";
            this.MAHANGHOA.Name = "MAHANGHOA";
            this.MAHANGHOA.Width = 150;
            this.tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenhang.DataPropertyName = "tenhanghoa";
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.Width = 250;
            this.Đvt1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Đvt1.DataPropertyName = "donvitinh";
            this.Đvt1.HeaderText = "ĐVT1";
            this.Đvt1.Name = "Đvt1";
            this.Đvt1.Width = 80;
            this.dvt2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt2.DataPropertyName = "donvitinhlon";
            this.dvt2.HeaderText = "Đvt 2";
            this.dvt2.Name = "dvt2";
            this.dvt2.Width = 80;
            this.gia1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gia1.DataPropertyName = "dongia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.gia1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gia1.HeaderText = "Giá 1";
            this.gia1.Name = "gia1";
            this.gia1.Width = 80;
            this.Gia2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Gia2.DataPropertyName = "dongia2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.Gia2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Gia2.HeaderText = "Giá 2";
            this.Gia2.Name = "Gia2";
            this.Gia2.Width = 80;
            this.Gia3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Gia3.DataPropertyName = "dongia3";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Gia3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gia3.HeaderText = "Gia3";
            this.Gia3.Name = "Gia3";
            this.Gia3.Width = 80;
            this.Gia4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Gia4.DataPropertyName = "dongia4";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.Gia4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Gia4.HeaderText = "Giá 4";
            this.Gia4.Name = "Gia4";
            this.Gia4.Width = 80;
            this.gia5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gia5.DataPropertyName = "dongia5";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.gia5.DefaultCellStyle = dataGridViewCellStyle7;
            this.gia5.HeaderText = "Giá 5";
            this.gia5.Name = "gia5";
            this.gia5.Width = 80;
            this.gia6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gia6.DataPropertyName = "dongia6";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.gia6.DefaultCellStyle = dataGridViewCellStyle8;
            this.gia6.HeaderText = "Giá 6";
            this.gia6.Name = "gia6";
            this.gia6.Width = 80;
            this.Ck.DataPropertyName = "chietkhau";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Ck.DefaultCellStyle = dataGridViewCellStyle9;
            this.Ck.HeaderText = "CK%";
            this.Ck.Name = "Ck";
            this.Ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ghichu.DataPropertyName = "ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Visible = false;
            this.Ghichu.Width = 60;
            this.Nhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Nhom.DataPropertyName = "tennhom";
            this.Nhom.HeaderText = "Nhóm";
            this.Nhom.Name = "Nhom";
            this.Nhom.Visible = false;
            this.Nhom.Width = 200;
            this.nh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nh.DataPropertyName = "manhom";
            this.nh.HeaderText = "Nhóm hàng";
            this.nh.Name = "nh";
            this.nh.Visible = false;
            this.dvt3.DataPropertyName = "donvitinhlon";
            this.dvt3.HeaderText = "dvt3";
            this.dvt3.Name = "dvt3";
            this.dvt3.Visible = false;
            this.vat.DataPropertyName = "vat";
            this.vat.HeaderText = "vat";
            this.vat.Name = "vat";
            this.vat.Visible = false;
            this.QD1.DataPropertyName = "quydoi";
            this.QD1.HeaderText = "Quy đổi ";
            this.QD1.Name = "QD1";
            this.QD1.Visible = false;
            this.quydoi1.DataPropertyName = "quydoi1";
            this.quydoi1.HeaderText = "Quy đổi";
            this.quydoi1.Name = "quydoi1";
            this.cc.DataPropertyName = "ncc";
            this.cc.HeaderText = "ncc";
            this.cc.Name = "cc";
            this.cc.Visible = false;
            this.giavon.DataPropertyName = "giavon";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.giavon.DefaultCellStyle = dataGridViewCellStyle10;
            this.giavon.HeaderText = "Giá vốn";
            this.giavon.Name = "giavon";
            this.donvitinhlon3.DataPropertyName = "donvitinhlon3";
            this.donvitinhlon3.HeaderText = "Column1";
            this.donvitinhlon3.Name = "donvitinhlon3";
            this.donvitinhlon3.Visible = false;
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Column1";
            this.diem.Name = "diem";
            this.diem.Visible = false;
            this.sl1.DataPropertyName = "sl1";
            this.sl1.HeaderText = "Column1";
            this.sl1.Name = "sl1";
            this.sl1.Visible = false;
            this.sl2.DataPropertyName = "sl2";
            this.sl2.HeaderText = "Column1";
            this.sl2.Name = "sl2";
            this.sl2.Visible = false;
            this.sl3.DataPropertyName = "sl3";
            this.sl3.HeaderText = "Column1";
            this.sl3.Name = "sl3";
            this.sl3.Visible = false;
            this.sl4.DataPropertyName = "sl4";
            this.sl4.HeaderText = "Column1";
            this.sl4.Name = "sl4";
            this.sl4.Visible = false;
            this.sl5.DataPropertyName = "sl5";
            this.sl5.HeaderText = "Column1";
            this.sl5.Name = "sl5";
            this.sl5.Visible = false;
            this.sl6.DataPropertyName = "sl6";
            this.sl6.HeaderText = "Column1";
            this.sl6.Name = "sl6";
            this.sl6.Visible = false;
            this.sl_canhbao.DataPropertyName = "sl_canhbao";
            this.sl_canhbao.HeaderText = "Column1";
            this.sl_canhbao.Name = "sl_canhbao";
            this.sl_canhbao.Visible = false;
            this.slban.DataPropertyName = "slban";
            this.slban.HeaderText = "Column1";
            this.slban.Name = "slban";
            this.slban.Visible = false;
            this.sltang.DataPropertyName = "sltang";
            this.sltang.HeaderText = "Column1";
            this.sltang.Name = "sltang";
            this.sltang.Visible = false;
            this.mahang.DataPropertyName = "mahang";
            this.mahang.HeaderText = "Column1";
            this.mahang.Name = "mahang";
            this.mahang.Visible = false;
            this.slton.DataPropertyName = "slton";
            this.slton.HeaderText = "Column1";
            this.slton.Name = "slton";
            this.slton.Visible = false;
            this.panel1.BackColor = Color.PowderBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtsodong);
            this.panel1.Controls.Add(this.cobnhom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1002, 91);
            this.panel1.TabIndex = 57;
            this.panel3.BorderStyle = BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBox10);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.txtgia);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new Point(249, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(604, 85);
            this.panel3.TabIndex = 71;
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = Color.Yellow;
            this.checkBox9.Font = new Font("Times New Roman", 12f);
            this.checkBox9.ForeColor = Color.Red;
            this.checkBox9.Location = new Point(179, 31);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new Size(192, 23);
            this.checkBox9.TabIndex = 72;
            this.checkBox9.Text = "Giá bán = Giá nhập x số %";
            this.checkBox9.UseVisualStyleBackColor = false;
            this.checkBox9.MouseClick += this.checkBox9_MouseClick;
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = Color.Yellow;
            this.checkBox8.ForeColor = Color.Red;
            this.checkBox8.Location = new Point(461, 1);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new Size(128, 23);
            this.checkBox8.TabIndex = 71;
            this.checkBox8.Text = "Thay đổi theo %";
            this.checkBox8.UseVisualStyleBackColor = false;
            this.checkBox8.MouseClick += this.checkBox8_MouseClick;
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = Color.Yellow;
            this.checkBox7.Font = new Font("Times New Roman", 12f);
            this.checkBox7.ForeColor = Color.Red;
            this.checkBox7.Location = new Point(179, 1);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new Size(239, 23);
            this.checkBox7.TabIndex = 70;
            this.checkBox7.Text = "Giá bán = Số tiền x Quy đổi đơn vị";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.MouseClick += this.checkBox7_MouseClick;
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new Point(375, 59);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new Size(61, 23);
            this.checkBox6.TabIndex = 69;
            this.checkBox6.Text = "Giá 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new Point(292, 59);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new Size(61, 23);
            this.checkBox5.TabIndex = 68;
            this.checkBox5.Text = "Giá 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new Point(211, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(61, 23);
            this.checkBox4.TabIndex = 67;
            this.checkBox4.Text = "Giá 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new Point(136, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(61, 23);
            this.checkBox3.TabIndex = 66;
            this.checkBox3.Text = "Giá 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(66, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(61, 23);
            this.checkBox2.TabIndex = 65;
            this.checkBox2.Text = "Giá 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox1.Location = new Point(1, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(61, 23);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "Giá 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.txtgia.BackColor = Color.Yellow;
            this.txtgia.Font = new Font("Times New Roman", 16f);
            this.txtgia.Location = new Point(59, 1);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new Size(113, 32);
            this.txtgia.TabIndex = 59;
            this.txtgia.Text = "0";
            this.txtgia.TextAlign = HorizontalAlignment.Right;
            this.txtgia.TextChanged += this.txtgia_TextChanged;
            this.txtgia.KeyPress += this.txtgia_KeyPress;
            this.txtgia.Leave += this.txtgia_Leave;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 12f);
            this.label1.Location = new Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(55, 38);
            this.label1.TabIndex = 60;
            this.label1.Text = "Số tiền\r\nhoặc %";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new Font("Times New Roman", 14f);
            this.radioButton1.Location = new Point(171, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(75, 25);
            this.radioButton1.TabIndex = 62;
            this.radioButton1.Text = "Tất cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.rbtangnhom.AutoSize = true;
            this.rbtangnhom.Checked = true;
            this.rbtangnhom.Font = new Font("Times New Roman", 14f);
            this.rbtangnhom.Location = new Point(2, 3);
            this.rbtangnhom.Name = "rbtangnhom";
            this.rbtangnhom.Size = new Size(114, 25);
            this.rbtangnhom.TabIndex = 61;
            this.rbtangnhom.TabStop = true;
            this.rbtangnhom.Text = "Theo nhóm";
            this.rbtangnhom.UseVisualStyleBackColor = true;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(875, 0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(124, 87);
            this.button1.TabIndex = 58;
            this.button1.Text = "THAY ĐỔI\r\nGIÁ BÁN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txtsodong.BackColor = Color.Yellow;
            this.txtsodong.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtsodong.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtsodong.Location = new Point(5, 59);
            this.txtsodong.Name = "txtsodong";
            this.txtsodong.ReadOnly = true;
            this.txtsodong.Size = new Size(52, 29);
            this.txtsodong.TabIndex = 57;
            this.txtsodong.Tag = "";
            this.txtsodong.Text = "0";
            this.cobnhom.BackColor = Color.White;
            this.cobnhom.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobnhom.Font = new Font("Times New Roman", 12f);
            this.cobnhom.FormattingEnabled = true;
            this.cobnhom.Location = new Point(5, 4);
            this.cobnhom.Name = "cobnhom";
            this.cobnhom.Size = new Size(243, 27);
            this.cobnhom.TabIndex = 56;
            this.cobnhom.Tag = "Chọn Nhóm";
            this.cobnhom.SelectedIndexChanged += this.cobnhom_SelectedIndexChanged;
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtangnhom);
            this.panel2.Location = new Point(56, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(192, 29);
            this.panel2.TabIndex = 70;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "GIANHAP",
                "DONGIA",
                "DONGIA2",
                "DONGIA3",
                "DONGIA4",
                "DONGIA5",
                "DONGIA6"
            });
            this.comboBox1.Location = new Point(375, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(214, 27);
            this.comboBox1.TabIndex = 72;
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new Point(461, 59);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new Size(82, 23);
            this.checkBox10.TabIndex = 73;
            this.checkBox10.Text = "Giá nhập";
            this.checkBox10.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 465);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
        //    base.MaximizeBox = false;
            //base.MinimizeBox = false;
            base.Name = "Frmtanggiahanghoa";
            //base.StartPosition = FormStartPosition.Manual;
            this.Text = "Tăng bảng giá hàng hóa";
            base.Load += this.Frmtanggiahanghoa_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvhanghoa).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000F30 RID: 3888
        private DataGridView dgvhanghoa;

        // Token: 0x04000F31 RID: 3889
        private Panel panel1;

        // Token: 0x04000F32 RID: 3890
        private ComboBox cobnhom;

        // Token: 0x04000F33 RID: 3891
        private TextBox txtsodong;

        // Token: 0x04000F34 RID: 3892
        private Button button1;

        // Token: 0x04000F35 RID: 3893
        private TextBox txtgia;

        // Token: 0x04000F36 RID: 3894
        private Label label1;

        // Token: 0x04000F37 RID: 3895
        private RadioButton radioButton1;

        // Token: 0x04000F38 RID: 3896
        private RadioButton rbtangnhom;

        // Token: 0x04000F39 RID: 3897
        private CheckBox checkBox6;

        // Token: 0x04000F3A RID: 3898
        private CheckBox checkBox5;

        // Token: 0x04000F3B RID: 3899
        private CheckBox checkBox4;

        // Token: 0x04000F3C RID: 3900
        private CheckBox checkBox3;

        // Token: 0x04000F3D RID: 3901
        private CheckBox checkBox2;

        // Token: 0x04000F3E RID: 3902
        private CheckBox checkBox1;

        // Token: 0x04000F3F RID: 3903
        private Panel panel3;

        // Token: 0x04000F40 RID: 3904
        private Panel panel2;

        // Token: 0x04000F41 RID: 3905
        private CheckBox checkBox7;

        // Token: 0x04000F42 RID: 3906
        private CheckBox checkBox8;

        // Token: 0x04000F43 RID: 3907
        private CheckBox checkBox9;

        // Token: 0x04000F44 RID: 3908
        private DataGridViewCheckBoxColumn STT;

        // Token: 0x04000F45 RID: 3909
        private DataGridViewTextBoxColumn MAHANGHOA;

        // Token: 0x04000F46 RID: 3910
        private DataGridViewTextBoxColumn tenhang;

        // Token: 0x04000F47 RID: 3911
        private DataGridViewTextBoxColumn Đvt1;

        // Token: 0x04000F48 RID: 3912
        private DataGridViewTextBoxColumn dvt2;

        // Token: 0x04000F49 RID: 3913
        private DataGridViewTextBoxColumn gia1;

        // Token: 0x04000F4A RID: 3914
        private DataGridViewTextBoxColumn Gia2;

        // Token: 0x04000F4B RID: 3915
        private DataGridViewTextBoxColumn Gia3;

        // Token: 0x04000F4C RID: 3916
        private DataGridViewTextBoxColumn Gia4;

        // Token: 0x04000F4D RID: 3917
        private DataGridViewTextBoxColumn gia5;

        // Token: 0x04000F4E RID: 3918
        private DataGridViewTextBoxColumn gia6;

        // Token: 0x04000F4F RID: 3919
        private DataGridViewTextBoxColumn Ck;

        // Token: 0x04000F50 RID: 3920
        private DataGridViewTextBoxColumn Ghichu;

        // Token: 0x04000F51 RID: 3921
        private DataGridViewTextBoxColumn Nhom;

        // Token: 0x04000F52 RID: 3922
        private DataGridViewTextBoxColumn nh;

        // Token: 0x04000F53 RID: 3923
        private DataGridViewTextBoxColumn dvt3;

        // Token: 0x04000F54 RID: 3924
        private DataGridViewTextBoxColumn vat;

        // Token: 0x04000F55 RID: 3925
        private DataGridViewTextBoxColumn QD1;

        // Token: 0x04000F56 RID: 3926
        private DataGridViewTextBoxColumn quydoi1;

        // Token: 0x04000F57 RID: 3927
        private DataGridViewTextBoxColumn cc;

        // Token: 0x04000F58 RID: 3928
        private DataGridViewTextBoxColumn giavon;

        // Token: 0x04000F59 RID: 3929
        private DataGridViewTextBoxColumn donvitinhlon3;

        // Token: 0x04000F5A RID: 3930
        private DataGridViewTextBoxColumn diem;

        // Token: 0x04000F5B RID: 3931
        private DataGridViewTextBoxColumn sl1;

        // Token: 0x04000F5C RID: 3932
        private DataGridViewTextBoxColumn sl2;

        // Token: 0x04000F5D RID: 3933
        private DataGridViewTextBoxColumn sl3;

        // Token: 0x04000F5E RID: 3934
        private DataGridViewTextBoxColumn sl4;

        // Token: 0x04000F5F RID: 3935
        private DataGridViewTextBoxColumn sl5;

        // Token: 0x04000F60 RID: 3936
        private DataGridViewTextBoxColumn sl6;

        // Token: 0x04000F61 RID: 3937
        private DataGridViewTextBoxColumn sl_canhbao;

        // Token: 0x04000F62 RID: 3938
        private DataGridViewTextBoxColumn slban;

        // Token: 0x04000F63 RID: 3939
        private DataGridViewTextBoxColumn sltang;

        // Token: 0x04000F64 RID: 3940
        private DataGridViewTextBoxColumn mahang;

        // Token: 0x04000F65 RID: 3941
        private DataGridViewTextBoxColumn slton;

        // Token: 0x04000F66 RID: 3942
        private ComboBox comboBox1;

        // Token: 0x04000F67 RID: 3943
        private CheckBox checkBox10;
    }
}
