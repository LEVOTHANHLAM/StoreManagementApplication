using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class Frmxuathoadon
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Frmxuathoadon));
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.groupBox4 = new GroupBox();
            this.btdong = new Button();
            this.btnhapexecl = new Button();
            this.txtghichu = new TextBox();
            this.label29 = new Label();
            this.groupBox1 = new GroupBox();
            this.txttongsoluong = new TextBox();
            this.txtvat = new TextBox();
            this.txtbangchua = new TextBox();
            this.txttongthanhtoan = new TextBox();
            this.txttienvat = new TextBox();
            this.txtcongtienhang = new TextBox();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label28 = new Label();
            this.groupBox7 = new GroupBox();
            this.dgvdanhsach = new DataGridView();
            this.STT = new DataGridViewTextBoxColumn();
            this.Tenhanghoa = new DataGridViewTextBoxColumn();
            this.mahanghoa = new DataGridViewTextBoxColumn();
            this.dvt = new DataGridViewTextBoxColumn();
            this.SL = new DataGridViewTextBoxColumn();
            this.dg = new DataGridViewTextBoxColumn();
            this.Thanhtien = new DataGridViewTextBoxColumn();
            this.sort = new DataGridViewTextBoxColumn();
            this.groupBox2 = new GroupBox();
            this.txtmakh = new TextBox();
            this.label32 = new Label();
            this.txtdocaodiachi = new TextBox();
            this.txtdocao = new TextBox();
            this.cbinma = new CheckBox();
            this.cbvietnam = new CheckBox();
            this.cbinhanghoa = new CheckBox();
            this.txtcochudiachi = new TextBox();
            this.label31 = new Label();
            this.txtcochutencongty = new TextBox();
            this.label30 = new Label();
            this.txtdonvi = new ComboBox();
            this.txtnguoimuahang = new ComboBox();
            this.label23 = new Label();
            this.txtsohoadon = new TextBox();
            this.label16 = new Label();
            this.txtnam = new NumericUpDown();
            this.label15 = new Label();
            this.txtthang = new NumericUpDown();
            this.label14 = new Label();
            this.txtngay = new NumericUpDown();
            this.label13 = new Label();
            this.txtsotaikhoan = new TextBox();
            this.label12 = new Label();
            this.cobthanhtoan = new ComboBox();
            this.txtdiachi = new TextBox();
            this.txtmasothue = new TextBox();
            this.label11 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.groupBox3 = new GroupBox();
            this.txttimkiem = new TextBox();
            this.txttigia = new TextBox();
            this.label22 = new Label();
            this.txtthanhtiensauvat = new TextBox();
            this.label1 = new Label();
            this.cobhanghoa = new ComboBox();
            this.btluu = new Button();
            this.txtsoluongton = new TextBox();
            this.txtsoluong = new TextBox();
            this.txtdongia = new TextBox();
            this.txtthanhtien = new TextBox();
            this.txtdonvitinh = new TextBox();
            this.label18 = new Label();
            this.label17 = new Label();
            this.label19 = new Label();
            this.label20 = new Label();
            this.label21 = new Label();
            this.txtmahh = new TextBox();
            this.panel1 = new Panel();
            this.btinhoadon = new Button();
            this.btxem = new Button();
            this.btinhdnhap = new Button();
            this.txtnam1 = new NumericUpDown();
            this.label24 = new Label();
            this.label25 = new Label();
            this.txtngay1 = new NumericUpDown();
            this.txtthang1 = new NumericUpDown();
            this.label27 = new Label();
            this.label26 = new Label();
            this.printDocument1 = new PrintDocument();
            this.pageSetupDialog1 = new PageSetupDialog();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printDialog1 = new PrintDialog();
            this.printDocument2 = new PrintDocument();
            this.openFileDialog1 = new OpenFileDialog();
            this.PrintInmahang = new PrintDocument();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((ISupportInitialize)this.dgvdanhsach).BeginInit();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.txtnam).BeginInit();
            ((ISupportInitialize)this.txtthang).BeginInit();
            ((ISupportInitialize)this.txtngay).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.txtnam1).BeginInit();
            ((ISupportInitialize)this.txtngay1).BeginInit();
            ((ISupportInitialize)this.txtthang1).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.12951f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.87049f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36f));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 143f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162f));
            this.tableLayoutPanel1.Size = new Size(1370, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            this.groupBox4.Controls.Add(this.btdong);
            this.groupBox4.Controls.Add(this.btnhapexecl);
            this.groupBox4.Controls.Add(this.txtghichu);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Dock = DockStyle.Fill;
            this.groupBox4.Location = new Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(474, 137);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.btdong.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btdong.Location = new Point(5, 12);
            this.btdong.Name = "btdong";
            this.btdong.Size = new Size(117, 83);
            this.btdong.TabIndex = 16;
            this.btdong.Text = "THOÁT";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += this.btdong_Click;
            this.btnhapexecl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnhapexecl.BackColor = Color.FromArgb(64, 64, 64);
            this.btnhapexecl.FlatStyle = FlatStyle.Popup;
            this.btnhapexecl.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnhapexecl.ForeColor = Color.FromArgb(0, 192, 0);
            this.btnhapexecl.Location = new Point(338, 15);
            this.btnhapexecl.Name = "btnhapexecl";
            this.btnhapexecl.Size = new Size(130, 83);
            this.btnhapexecl.TabIndex = 15;
            this.btnhapexecl.Text = "NHẬP EXCEL";
            this.btnhapexecl.UseVisualStyleBackColor = false;
            this.btnhapexecl.Click += this.btnhapexecl_Click;
            this.txtghichu.Location = new Point(115, 108);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(361, 26);
            this.txtghichu.TabIndex = 13;
            this.label29.AutoSize = true;
            this.label29.Location = new Point(8, 112);
            this.label29.Name = "label29";
            this.label29.Size = new Size(111, 19);
            this.label29.TabIndex = 14;
            this.label29.Text = "Ghi chú hóa đơn:";
            this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox1.Controls.Add(this.txttongsoluong);
            this.groupBox1.Controls.Add(this.txtvat);
            this.groupBox1.Controls.Add(this.txtbangchua);
            this.groupBox1.Controls.Add(this.txttongthanhtoan);
            this.groupBox1.Controls.Add(this.txttienvat);
            this.groupBox1.Controls.Add(this.txtcongtienhang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new Point(485, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(843, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.txttongsoluong.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txttongsoluong.BackColor = Color.FromArgb(255, 255, 192);
            this.txttongsoluong.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongsoluong.Location = new Point(417, 11);
            this.txttongsoluong.Name = "txttongsoluong";
            this.txttongsoluong.Size = new Size(144, 26);
            this.txttongsoluong.TabIndex = 10;
            this.txttongsoluong.Text = "0";
            this.txttongsoluong.TextAlign = HorizontalAlignment.Right;
            this.txtvat.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtvat.BackColor = Color.FromArgb(255, 255, 192);
            this.txtvat.Location = new Point(130, 31);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new Size(38, 26);
            this.txtvat.TabIndex = 7;
            this.txtvat.Text = "10";
            this.txtvat.TextAlign = HorizontalAlignment.Center;
            this.txtvat.TextChanged += this.txtvat_TextChanged;
            this.txtbangchua.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtbangchua.BackColor = Color.FromArgb(255, 255, 192);
            this.txtbangchua.Location = new Point(147, 92);
            this.txtbangchua.Name = "txtbangchua";
            this.txtbangchua.ReadOnly = true;
            this.txtbangchua.Size = new Size(693, 26);
            this.txtbangchua.TabIndex = 0;
            this.txtbangchua.TextAlign = HorizontalAlignment.Right;
            this.txttongthanhtoan.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txttongthanhtoan.BackColor = Color.FromArgb(255, 255, 192);
            this.txttongthanhtoan.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongthanhtoan.Location = new Point(696, 65);
            this.txttongthanhtoan.Name = "txttongthanhtoan";
            this.txttongthanhtoan.Size = new Size(144, 26);
            this.txttongthanhtoan.TabIndex = 5;
            this.txttongthanhtoan.Text = "0";
            this.txttongthanhtoan.TextAlign = HorizontalAlignment.Right;
            this.txttienvat.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txttienvat.BackColor = Color.FromArgb(255, 255, 192);
            this.txttienvat.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttienvat.Location = new Point(696, 38);
            this.txttienvat.Name = "txttienvat";
            this.txttienvat.Size = new Size(144, 26);
            this.txttienvat.TabIndex = 5;
            this.txttienvat.Text = "0";
            this.txttienvat.TextAlign = HorizontalAlignment.Right;
            this.txtcongtienhang.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtcongtienhang.BackColor = Color.FromArgb(255, 255, 192);
            this.txtcongtienhang.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtcongtienhang.Location = new Point(696, 11);
            this.txtcongtienhang.Name = "txtcongtienhang";
            this.txtcongtienhang.Size = new Size(144, 26);
            this.txtcongtienhang.TabIndex = 5;
            this.txtcongtienhang.Text = "0";
            this.txtcongtienhang.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new Size(116, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thuế Suất GTGT:";
            this.label7.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label7.AutoSize = true;
            this.label7.Location = new Point(531, 68);
            this.label7.Name = "label7";
            this.label7.Size = new Size(167, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng cộng tiền thanh toán:";
            this.label8.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label8.AutoSize = true;
            this.label8.Location = new Point(589, 41);
            this.label8.Name = "label8";
            this.label8.Size = new Size(109, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền thuế GTGT:";
            this.label9.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label9.AutoSize = true;
            this.label9.Location = new Point(596, 16);
            this.label9.Name = "label9";
            this.label9.Size = new Size(102, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cộng tiền hàng:";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(2, 96);
            this.label10.Name = "label10";
            this.label10.Size = new Size(139, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số tiền viết bằng chữ:";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(209, 34);
            this.label28.Name = "label28";
            this.label28.Size = new Size(22, 19);
            this.label28.TabIndex = 8;
            this.label28.Text = "%";
            this.groupBox7.Controls.Add(this.dgvdanhsach);
            this.groupBox7.Dock = DockStyle.Fill;
            this.groupBox7.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox7.Location = new Point(485, 148);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(843, 375);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.dgvdanhsach.AllowUserToAddRows = false;
            this.dgvdanhsach.AllowUserToDeleteRows = false;
            this.dgvdanhsach.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvdanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.Tenhanghoa,
                this.mahanghoa,
                this.dvt,
                this.SL,
                this.dg,
                this.Thanhtien,
                this.sort
            });
            this.dgvdanhsach.Dock = DockStyle.Fill;
            this.dgvdanhsach.Location = new Point(3, 18);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 4;
            this.dgvdanhsach.Size = new Size(837, 354);
            this.dgvdanhsach.TabIndex = 1;
            this.dgvdanhsach.CellEndEdit += this.dgvdanhsach_CellEndEdit;
            this.dgvdanhsach.RowPrePaint += this.dgvchitiethoadon_RowPrePaint;
            this.dgvdanhsach.KeyDown += this.dgvchitiethoadon_KeyDown;
            this.STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            this.Tenhanghoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Tenhanghoa.DataPropertyName = "Tenhanghoa";
            this.Tenhanghoa.HeaderText = "Tên hàng hóa, dịch vụ";
            this.Tenhanghoa.Name = "Tenhanghoa";
            this.Tenhanghoa.Width = 250;
            this.mahanghoa.DataPropertyName = "mahanghoa";
            this.mahanghoa.HeaderText = "Mã hàng";
            this.mahanghoa.Name = "mahanghoa";
            this.dvt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt.DataPropertyName = "dvt";
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            this.dvt.Width = 80;
            this.SL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SL.DataPropertyName = "SL";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            this.SL.DefaultCellStyle = dataGridViewCellStyle3;
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.dg.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dg.DataPropertyName = "Dongia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.dg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg.HeaderText = "Đơn giá";
            this.dg.Name = "dg";
            this.Thanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.Width = 130;
            this.sort.DataPropertyName = "stt";
            this.sort.HeaderText = "sort";
            this.sort.Name = "sort";
            this.sort.Visible = false;
            this.groupBox2.Controls.Add(this.txtmakh);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.txtdocaodiachi);
            this.groupBox2.Controls.Add(this.txtdocao);
            this.groupBox2.Controls.Add(this.cbinma);
            this.groupBox2.Controls.Add(this.cbvietnam);
            this.groupBox2.Controls.Add(this.cbinhanghoa);
            this.groupBox2.Controls.Add(this.txtcochudiachi);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.txtcochutencongty);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.txtdonvi);
            this.groupBox2.Controls.Add(this.txtnguoimuahang);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtsohoadon);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtnam);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtthang);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtngay);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtsotaikhoan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cobthanhtoan);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txtmasothue);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = DockStyle.Fill;
            this.groupBox2.ForeColor = Color.FromArgb(0, 0, 192);
            this.groupBox2.Location = new Point(4, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(474, 375);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            this.txtmakh.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtmakh.Location = new Point(319, 107);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new Size(101, 25);
            this.txtmakh.TabIndex = 21;
            this.txtmakh.TextChanged += this.txtmakh_TextChanged;
            this.txtmakh.KeyPress += this.txtmakh_KeyPress;
            this.label32.AutoSize = true;
            this.label32.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label32.Location = new Point(219, 112);
            this.label32.Name = "label32";
            this.label32.Size = new Size(99, 17);
            this.label32.TabIndex = 20;
            this.label32.Text = "Mã khách hàng";
            this.txtdocaodiachi.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtdocaodiachi.Location = new Point(165, 320);
            this.txtdocaodiachi.Name = "txtdocaodiachi";
            this.txtdocaodiachi.Size = new Size(44, 26);
            this.txtdocaodiachi.TabIndex = 19;
            this.txtdocaodiachi.Text = "0";
            this.txtdocaodiachi.TextAlign = HorizontalAlignment.Center;
            this.txtdocao.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtdocao.Location = new Point(165, 293);
            this.txtdocao.Name = "txtdocao";
            this.txtdocao.Size = new Size(44, 26);
            this.txtdocao.TabIndex = 18;
            this.txtdocao.Text = "0";
            this.txtdocao.TextAlign = HorizontalAlignment.Center;
            this.cbinma.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cbinma.AutoSize = true;
            this.cbinma.Checked = true;
            this.cbinma.CheckState = CheckState.Checked;
            this.cbinma.FlatStyle = FlatStyle.Popup;
            this.cbinma.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbinma.Location = new Point(248, 322);
            this.cbinma.Name = "cbinma";
            this.cbinma.Size = new Size(172, 23);
            this.cbinma.TabIndex = 17;
            this.cbinma.Text = "In mã hàng trên hóa đơn";
            this.cbinma.UseVisualStyleBackColor = true;
            this.cbvietnam.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cbvietnam.AutoSize = true;
            this.cbvietnam.Checked = true;
            this.cbvietnam.CheckState = CheckState.Checked;
            this.cbvietnam.FlatStyle = FlatStyle.Popup;
            this.cbvietnam.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.cbvietnam.Location = new Point(248, 292);
            this.cbvietnam.Name = "cbvietnam";
            this.cbvietnam.Size = new Size(113, 26);
            this.cbvietnam.TabIndex = 16;
            this.cbvietnam.Text = "In tiền việt";
            this.cbvietnam.UseVisualStyleBackColor = true;
            this.cbvietnam.CheckedChanged += this.cbvietnam_CheckedChanged;
            this.cbinhanghoa.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cbinhanghoa.AutoSize = true;
            this.cbinhanghoa.Location = new Point(248, 349);
            this.cbinhanghoa.Name = "cbinhanghoa";
            this.cbinhanghoa.Size = new Size(171, 23);
            this.cbinhanghoa.TabIndex = 15;
            this.cbinhanghoa.Text = "In hàng hóa trên 1 dòng";
            this.cbinhanghoa.UseVisualStyleBackColor = true;
            this.cbinhanghoa.MouseClick += this.cbinhanghoa_MouseClick;
            this.txtcochudiachi.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtcochudiachi.Location = new Point(120, 320);
            this.txtcochudiachi.Name = "txtcochudiachi";
            this.txtcochudiachi.Size = new Size(44, 26);
            this.txtcochudiachi.TabIndex = 13;
            this.txtcochudiachi.Text = "11";
            this.txtcochudiachi.TextAlign = HorizontalAlignment.Center;
            this.txtcochudiachi.TextChanged += this.txtcochudiachi_TextChanged;
            this.label31.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label31.AutoSize = true;
            this.label31.Location = new Point(8, 326);
            this.label31.Name = "label31";
            this.label31.Size = new Size(101, 19);
            this.label31.TabIndex = 14;
            this.label31.Text = "Cỡ chữ địa chỉ:";
            this.txtcochutencongty.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtcochutencongty.Location = new Point(120, 293);
            this.txtcochutencongty.Name = "txtcochutencongty";
            this.txtcochutencongty.Size = new Size(44, 26);
            this.txtcochutencongty.TabIndex = 11;
            this.txtcochutencongty.Text = "11";
            this.txtcochutencongty.TextAlign = HorizontalAlignment.Center;
            this.txtcochutencongty.TextChanged += this.txtcochutencongty_TextChanged;
            this.label30.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label30.AutoSize = true;
            this.label30.Location = new Point(8, 299);
            this.label30.Name = "label30";
            this.label30.Size = new Size(114, 19);
            this.label30.TabIndex = 12;
            this.label30.Text = "Cỡ chữ Công Ty:";
            this.txtdonvi.BackColor = Color.FromArgb(192, 255, 192);
            this.txtdonvi.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtdonvi.FormattingEnabled = true;
            this.txtdonvi.Location = new Point(52, 78);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new Size(368, 25);
            this.txtdonvi.TabIndex = 2;
            this.txtdonvi.KeyDown += this.txtdonvi_KeyDown;
            this.txtnguoimuahang.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtnguoimuahang.FormattingEnabled = true;
            this.txtnguoimuahang.Location = new Point(156, 46);
            this.txtnguoimuahang.Name = "txtnguoimuahang";
            this.txtnguoimuahang.Size = new Size(264, 25);
            this.txtnguoimuahang.TabIndex = 1;
            this.txtnguoimuahang.KeyDown += this.txtnguoimuahang_KeyDown;
            this.label23.AutoSize = true;
            this.label23.Location = new Point(8, 238);
            this.label23.Name = "label23";
            this.label23.Size = new Size(127, 19);
            this.label23.TabIndex = 10;
            this.label23.Text = "Ngày xuất hóa đơn:";
            this.txtsohoadon.BackColor = Color.FromArgb(255, 255, 192);
            this.txtsohoadon.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtsohoadon.Location = new Point(156, 17);
            this.txtsohoadon.MaxLength = 30;
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.Size = new Size(139, 25);
            this.txtsohoadon.TabIndex = 0;
            this.txtsohoadon.KeyDown += this.txtsohoadon_KeyDown;
            this.label16.AutoSize = true;
            this.label16.Location = new Point(6, 23);
            this.label16.Name = "label16";
            this.label16.Size = new Size(82, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "Số hóa đơn:";
            this.txtnam.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtnam.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtnam.Location = new Point(355, 235);
            NumericUpDown numericUpDown = this.txtnam;
            int[] array = new int[4];
            array[0] = 2500;
            numericUpDown.Maximum = new decimal(array);
            NumericUpDown numericUpDown2 = this.txtnam;
            array = new int[4];
            array[0] = 18;
            numericUpDown2.Minimum = new decimal(array);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new Size(65, 32);
            this.txtnam.TabIndex = 9;
            this.txtnam.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown3 = this.txtnam;
            array = new int[4];
            array[0] = 18;
            numericUpDown3.Value = new decimal(array);
            this.label15.AutoSize = true;
            this.label15.Location = new Point(315, 241);
            this.label15.Name = "label15";
            this.label15.Size = new Size(34, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "năm";
            this.txtthang.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtthang.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtthang.Location = new Point(271, 235);
            NumericUpDown numericUpDown4 = this.txtthang;
            array = new int[4];
            array[0] = 12;
            numericUpDown4.Maximum = new decimal(array);
            NumericUpDown numericUpDown5 = this.txtthang;
            array = new int[4];
            array[0] = 1;
            numericUpDown5.Minimum = new decimal(array);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new Size(38, 32);
            this.txtthang.TabIndex = 8;
            this.txtthang.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown6 = this.txtthang;
            array = new int[4];
            array[0] = 1;
            numericUpDown6.Value = new decimal(array);
            this.label14.AutoSize = true;
            this.label14.Location = new Point(224, 243);
            this.label14.Name = "label14";
            this.label14.Size = new Size(41, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "tháng";
            this.txtngay.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtngay.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtngay.Location = new Point(175, 234);
            NumericUpDown numericUpDown7 = this.txtngay;
            array = new int[4];
            array[0] = 31;
            numericUpDown7.Maximum = new decimal(array);
            NumericUpDown numericUpDown8 = this.txtngay;
            array = new int[4];
            array[0] = 1;
            numericUpDown8.Minimum = new decimal(array);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new Size(43, 32);
            this.txtngay.TabIndex = 7;
            this.txtngay.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown9 = this.txtngay;
            array = new int[4];
            array[0] = 1;
            numericUpDown9.Value = new decimal(array);
            this.label13.AutoSize = true;
            this.label13.Location = new Point(134, 239);
            this.label13.Name = "label13";
            this.label13.Size = new Size(42, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ngày";
            this.txtsotaikhoan.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtsotaikhoan.Location = new Point(156, 171);
            this.txtsotaikhoan.Name = "txtsotaikhoan";
            this.txtsotaikhoan.Size = new Size(264, 25);
            this.txtsotaikhoan.TabIndex = 5;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(2, 178);
            this.label12.Name = "label12";
            this.label12.Size = new Size(88, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Số tài khoản:";
            this.cobthanhtoan.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cobthanhtoan.FormattingEnabled = true;
            this.cobthanhtoan.Items.AddRange(new object[]
            {
                "TM",
                "CK",
                "TM/CK",
                "TIỀN MẶT",
                "CHUYỂN KHOẢN",
                "TIỀN MẶT/CHUYỂN KHOẢN"
            });
            this.cobthanhtoan.Location = new Point(156, 203);
            this.cobthanhtoan.Name = "cobthanhtoan";
            this.cobthanhtoan.Size = new Size(264, 25);
            this.cobthanhtoan.TabIndex = 6;
            this.txtdiachi.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtdiachi.Location = new Point(52, 139);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new Size(368, 25);
            this.txtdiachi.TabIndex = 4;
            this.txtmasothue.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtmasothue.Location = new Point(84, 109);
            this.txtmasothue.Name = "txtmasothue";
            this.txtmasothue.Size = new Size(134, 25);
            this.txtmasothue.TabIndex = 3;
            this.txtmasothue.TextChanged += this.txtmasothue_TextChanged;
            this.txtmasothue.KeyDown += this.txtmasothue_KeyDown;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(1, 208);
            this.label11.Name = "label11";
            this.label11.Size = new Size(137, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hình thức thanh toán:";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(1, 142);
            this.label5.Name = "label5";
            this.label5.Size = new Size(54, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã số thuế:";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn vị:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new Size(152, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên người mua hàng:";
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.txttigia);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtthanhtiensauvat);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cobhanghoa);
            this.groupBox3.Controls.Add(this.btluu);
            this.groupBox3.Controls.Add(this.txtsoluongton);
            this.groupBox3.Controls.Add(this.txtsoluong);
            this.groupBox3.Controls.Add(this.txtdongia);
            this.groupBox3.Controls.Add(this.txtthanhtien);
            this.groupBox3.Controls.Add(this.txtdonvitinh);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtmahh);
            this.groupBox3.Dock = DockStyle.Fill;
            this.groupBox3.Location = new Point(485, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(843, 137);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.txttimkiem.BackColor = Color.FromArgb(255, 255, 192);
            this.txttimkiem.Font = new Font("Times New Roman", 14f);
            this.txttimkiem.Location = new Point(534, 39);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(143, 29);
            this.txttimkiem.TabIndex = 15;
            this.txttimkiem.Tag = "Tìm Mã";
            this.txttimkiem.Text = "Tìm Mã";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.KeyDown += this.txttimkiem_KeyDown;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.txttigia.Location = new Point(98, 109);
            this.txttigia.Name = "txttigia";
            this.txttigia.Size = new Size(144, 26);
            this.txttigia.TabIndex = 14;
            this.txttigia.Text = "22.669";
            this.txttigia.TextAlign = HorizontalAlignment.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new Point(5, 112);
            this.label22.Name = "label22";
            this.label22.Size = new Size(49, 19);
            this.label22.TabIndex = 13;
            this.label22.Text = "Tỉ Giá:";
            this.txtthanhtiensauvat.BackColor = Color.FromArgb(192, 0, 0);
            this.txtthanhtiensauvat.Font = new Font("Times New Roman", 14f);
            this.txtthanhtiensauvat.ForeColor = Color.White;
            this.txtthanhtiensauvat.Location = new Point(389, 102);
            this.txtthanhtiensauvat.Name = "txtthanhtiensauvat";
            this.txtthanhtiensauvat.Size = new Size(145, 29);
            this.txtthanhtiensauvat.TabIndex = 12;
            this.txtthanhtiensauvat.Text = "0";
            this.txtthanhtiensauvat.TextAlign = HorizontalAlignment.Right;
            this.txtthanhtiensauvat.TextChanged += this.txtthanhtiensauvat_TextChanged;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(248, 108);
            this.label1.Name = "label1";
            this.label1.Size = new Size(135, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thành Tiền Sau VAT:";
            this.cobhanghoa.FormattingEnabled = true;
            this.cobhanghoa.Location = new Point(98, 10);
            this.cobhanghoa.MaxLength = 80;
            this.cobhanghoa.Name = "cobhanghoa";
            this.cobhanghoa.Size = new Size(435, 27);
            this.cobhanghoa.TabIndex = 0;
            this.cobhanghoa.KeyDown += this.cobhanghoa_KeyDown;
            this.btluu.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btluu.BackColor = Color.FromArgb(64, 64, 64);
            this.btluu.FlatStyle = FlatStyle.Flat;
            this.btluu.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btluu.ForeColor = Color.Lime;
            this.btluu.Location = new Point(731, 11);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(109, 116);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "THÊM";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += this.btluu_Click;
            this.txtsoluongton.BackColor = Color.White;
            this.txtsoluongton.Location = new Point(540, 101);
            this.txtsoluongton.Name = "txtsoluongton";
            this.txtsoluongton.ReadOnly = true;
            this.txtsoluongton.Size = new Size(143, 26);
            this.txtsoluongton.TabIndex = 9;
            this.txtsoluongton.Text = "0";
            this.txtsoluongton.TextAlign = HorizontalAlignment.Right;
            this.txtsoluongton.Visible = false;
            this.txtsoluongton.WordWrap = false;
            this.txtsoluong.BackColor = Color.White;
            this.txtsoluong.Location = new Point(98, 40);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new Size(144, 26);
            this.txtsoluong.TabIndex = 1;
            this.txtsoluong.Text = "1";
            this.txtsoluong.TextAlign = HorizontalAlignment.Right;
            this.txtsoluong.TextChanged += this.txtsoluong_TextChanged;
            this.txtsoluong.KeyDown += this.txtsoluong_KeyDown;
            this.txtdongia.Location = new Point(98, 68);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new Size(144, 26);
            this.txtdongia.TabIndex = 2;
            this.txtdongia.Text = "0";
            this.txtdongia.TextAlign = HorizontalAlignment.Right;
            this.txtdongia.TextChanged += this.txtdongia_TextChanged;
            this.txtdongia.KeyDown += this.txtdongia_KeyDown;
            this.txtthanhtien.Location = new Point(388, 68);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new Size(145, 26);
            this.txtthanhtien.TabIndex = 5;
            this.txtthanhtien.Text = "0";
            this.txtthanhtien.TextAlign = HorizontalAlignment.Right;
            this.txtdonvitinh.Location = new Point(388, 40);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new Size(145, 26);
            this.txtdonvitinh.TabIndex = 5;
            this.txtdonvitinh.KeyDown += this.txtdonvitinh_KeyDown;
            this.label18.AutoSize = true;
            this.label18.Location = new Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new Size(93, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên hàng hóa:";
            this.label17.AutoSize = true;
            this.label17.Location = new Point(5, 71);
            this.label17.Name = "label17";
            this.label17.Size = new Size(59, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Đơn giá:";
            this.label19.AutoSize = true;
            this.label19.Location = new Point(304, 71);
            this.label19.Name = "label19";
            this.label19.Size = new Size(78, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Thành Tiền:";
            this.label20.AutoSize = true;
            this.label20.Location = new Point(305, 44);
            this.label20.Name = "label20";
            this.label20.Size = new Size(77, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Đơn vị tính:";
            this.label21.AutoSize = true;
            this.label21.Location = new Point(6, 44);
            this.label21.Name = "label21";
            this.label21.Size = new Size(67, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Số lượng:";
            this.txtmahh.BackColor = Color.FromArgb(255, 255, 192);
            this.txtmahh.Location = new Point(534, 10);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new Size(143, 26);
            this.txtmahh.TabIndex = 10;
            this.txtmahh.KeyDown += this.txtmahh_KeyDown;
            this.txtmahh.Leave += this.txtmahh_Leave;
            this.panel1.Controls.Add(this.btinhoadon);
            this.panel1.Controls.Add(this.btxem);
            this.panel1.Controls.Add(this.btinhdnhap);
            this.panel1.Controls.Add(this.txtnam1);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtngay1);
            this.panel1.Controls.Add(this.txtthang1);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(4, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(474, 156);
            this.panel1.TabIndex = 12;
            this.btinhoadon.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btinhoadon.BackColor = Color.FromArgb(64, 64, 64);
            this.btinhoadon.FlatStyle = FlatStyle.Flat;
            this.btinhoadon.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btinhoadon.ForeColor = Color.Lime;
            this.btinhoadon.Location = new Point(246, 43);
            this.btinhoadon.Name = "btinhoadon";
            this.btinhoadon.Size = new Size(184, 73);
            this.btinhoadon.TabIndex = 12;
            this.btinhoadon.Text = "LƯU HÓA ĐƠN";
            this.btinhoadon.UseVisualStyleBackColor = false;
            this.btinhoadon.Click += this.btinhoadon_Click;
            this.btxem.BackColor = Color.FromArgb(64, 64, 64);
            this.btxem.FlatStyle = FlatStyle.Flat;
            this.btxem.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btxem.ForeColor = Color.Lime;
            this.btxem.Location = new Point(5, 41);
            this.btxem.Name = "btxem";
            this.btxem.Size = new Size(171, 72);
            this.btxem.TabIndex = 19;
            this.btxem.Text = "XEM HÓA ĐƠN\r";
            this.btxem.UseVisualStyleBackColor = false;
            this.btxem.Click += this.btxem_Click;
            this.btinhdnhap.BackColor = Color.FromArgb(64, 64, 64);
            this.btinhdnhap.FlatStyle = FlatStyle.Flat;
            this.btinhdnhap.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btinhdnhap.ForeColor = Color.Lime;
            this.btinhdnhap.Location = new Point(284, 44);
            this.btinhdnhap.Name = "btinhdnhap";
            this.btinhdnhap.Size = new Size(148, 72);
            this.btinhdnhap.TabIndex = 18;
            this.btinhdnhap.Text = "IN HÓA ĐƠN\r\nNHẬP";
            this.btinhdnhap.UseVisualStyleBackColor = false;
            this.btinhdnhap.Click += this.btinhdnhap_Click;
            this.txtnam1.Location = new Point(329, 11);
            NumericUpDown numericUpDown10 = this.txtnam1;
            array = new int[4];
            array[0] = 2117;
            numericUpDown10.Maximum = new decimal(array);
            NumericUpDown numericUpDown11 = this.txtnam1;
            array = new int[4];
            array[0] = 18;
            numericUpDown11.Minimum = new decimal(array);
            this.txtnam1.Name = "txtnam1";
            this.txtnam1.Size = new Size(54, 26);
            this.txtnam1.TabIndex = 2;
            this.txtnam1.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown12 = this.txtnam1;
            array = new int[4];
            array[0] = 18;
            numericUpDown12.Value = new decimal(array);
            this.label24.AutoSize = true;
            this.label24.Location = new Point(5, 14);
            this.label24.Name = "label24";
            this.label24.Size = new Size(120, 19);
            this.label24.TabIndex = 10;
            this.label24.Text = "Ngày xuất thực tế:";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(295, 13);
            this.label25.Name = "label25";
            this.label25.Size = new Size(34, 19);
            this.label25.TabIndex = 14;
            this.label25.Text = "năm";
            this.txtngay1.Location = new Point(175, 11);
            NumericUpDown numericUpDown13 = this.txtngay1;
            array = new int[4];
            array[0] = 31;
            numericUpDown13.Maximum = new decimal(array);
            NumericUpDown numericUpDown14 = this.txtngay1;
            array = new int[4];
            array[0] = 1;
            numericUpDown14.Minimum = new decimal(array);
            this.txtngay1.Name = "txtngay1";
            this.txtngay1.Size = new Size(38, 26);
            this.txtngay1.TabIndex = 0;
            this.txtngay1.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown15 = this.txtngay1;
            array = new int[4];
            array[0] = 1;
            numericUpDown15.Value = new decimal(array);
            this.txtthang1.Location = new Point(257, 11);
            NumericUpDown numericUpDown16 = this.txtthang1;
            array = new int[4];
            array[0] = 12;
            numericUpDown16.Maximum = new decimal(array);
            NumericUpDown numericUpDown17 = this.txtthang1;
            array = new int[4];
            array[0] = 1;
            numericUpDown17.Minimum = new decimal(array);
            this.txtthang1.Name = "txtthang1";
            this.txtthang1.Size = new Size(38, 26);
            this.txtthang1.TabIndex = 1;
            this.txtthang1.TextAlign = HorizontalAlignment.Center;
            NumericUpDown numericUpDown18 = this.txtthang1;
            array = new int[4];
            array[0] = 1;
            numericUpDown18.Value = new decimal(array);
            this.label27.AutoSize = true;
            this.label27.Location = new Point(134, 13);
            this.label27.Name = "label27";
            this.label27.Size = new Size(42, 19);
            this.label27.TabIndex = 13;
            this.label27.Text = "Ngày";
            this.label26.AutoSize = true;
            this.label26.Location = new Point(215, 13);
            this.label26.Name = "label26";
            this.label26.Size = new Size(41, 19);
            this.label26.TabIndex = 12;
            this.label26.Text = "tháng";
            this.printDocument1.PrintPage += this.printDocument1_PrintPage;
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printDialog1.UseEXDialog = true;
            this.printDocument2.PrintPage += this.printDocument2_PrintPage;
            this.openFileDialog1.FileName = "openFileDialog1";
            this.PrintInmahang.PrintPage += this.PrintInmahang_PrintPage;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0, 192, 192);
            base.ClientSize = new Size(1370, 690);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
            base.Name = "Frmxuathoadon";
            ///base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "XUẤT HÓA ĐƠN";
           // base.WindowState = FormWindowState.Maximized;
           // base.FormClosed += this.Frmxuathoadon_FormClosed;
            base.Load += this.Frmxuathoadon_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((ISupportInitialize)this.dgvdanhsach).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((ISupportInitialize)this.txtnam).EndInit();
            ((ISupportInitialize)this.txtthang).EndInit();
            ((ISupportInitialize)this.txtngay).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.txtnam1).EndInit();
            ((ISupportInitialize)this.txtngay1).EndInit();
            ((ISupportInitialize)this.txtthang1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04001127 RID: 4391
        private GroupBox groupBox1;

        // Token: 0x04001128 RID: 4392
        private TextBox txtvat;

        // Token: 0x04001129 RID: 4393
        private TextBox txtbangchua;

        // Token: 0x0400112A RID: 4394
        private TextBox txttongthanhtoan;

        // Token: 0x0400112B RID: 4395
        private TextBox txttienvat;

        // Token: 0x0400112C RID: 4396
        private TextBox txtcongtienhang;

        // Token: 0x0400112D RID: 4397
        private Label label6;

        // Token: 0x0400112E RID: 4398
        private Label label7;

        // Token: 0x0400112F RID: 4399
        private Label label8;

        // Token: 0x04001130 RID: 4400
        private Label label9;

        // Token: 0x04001131 RID: 4401
        private Label label10;

        // Token: 0x04001132 RID: 4402
        private GroupBox groupBox7;

        // Token: 0x04001133 RID: 4403
        private DataGridView dgvdanhsach;

        // Token: 0x04001134 RID: 4404
        private GroupBox groupBox2;

        // Token: 0x04001135 RID: 4405
        private Label label2;

        // Token: 0x04001136 RID: 4406
        private TextBox txtsotaikhoan;

        // Token: 0x04001137 RID: 4407
        private Label label12;

        // Token: 0x04001138 RID: 4408
        private ComboBox cobthanhtoan;

        // Token: 0x04001139 RID: 4409
        private TextBox txtdiachi;

        // Token: 0x0400113A RID: 4410
        private TextBox txtmasothue;

        // Token: 0x0400113B RID: 4411
        private Label label11;

        // Token: 0x0400113C RID: 4412
        private Label label5;

        // Token: 0x0400113D RID: 4413
        private Label label4;

        // Token: 0x0400113E RID: 4414
        private Label label3;

        // Token: 0x0400113F RID: 4415
        private NumericUpDown txtthang;

        // Token: 0x04001140 RID: 4416
        private Label label14;

        // Token: 0x04001141 RID: 4417
        private NumericUpDown txtngay;

        // Token: 0x04001142 RID: 4418
        private Label label13;

        // Token: 0x04001143 RID: 4419
        private NumericUpDown txtnam;

        // Token: 0x04001144 RID: 4420
        private Label label15;

        // Token: 0x04001145 RID: 4421
        private TextBox txtsohoadon;

        // Token: 0x04001146 RID: 4422
        private Label label16;

        // Token: 0x04001147 RID: 4423
        private GroupBox groupBox3;

        // Token: 0x04001148 RID: 4424
        private TextBox txtsoluong;

        // Token: 0x04001149 RID: 4425
        private TextBox txtthanhtien;

        // Token: 0x0400114A RID: 4426
        private TextBox txtdonvitinh;

        // Token: 0x0400114B RID: 4427
        private Label label18;

        // Token: 0x0400114C RID: 4428
        private Label label19;

        // Token: 0x0400114D RID: 4429
        private Label label20;

        // Token: 0x0400114E RID: 4430
        private Label label21;

        // Token: 0x0400114F RID: 4431
        private TextBox txtdongia;

        // Token: 0x04001150 RID: 4432
        private Label label17;

        // Token: 0x04001151 RID: 4433
        private TextBox txtsoluongton;

        // Token: 0x04001152 RID: 4434
        private Button btluu;

        // Token: 0x04001153 RID: 4435
        private GroupBox groupBox4;

        // Token: 0x04001154 RID: 4436
        private ComboBox txtnguoimuahang;

        // Token: 0x04001155 RID: 4437
        private Label label23;

        // Token: 0x04001156 RID: 4438
        private Panel panel1;

        // Token: 0x04001157 RID: 4439
        private NumericUpDown txtnam1;

        // Token: 0x04001158 RID: 4440
        private Label label24;

        // Token: 0x04001159 RID: 4441
        private Label label25;

        // Token: 0x0400115A RID: 4442
        private NumericUpDown txtngay1;

        // Token: 0x0400115B RID: 4443
        private NumericUpDown txtthang1;

        // Token: 0x0400115C RID: 4444
        private Label label27;

        // Token: 0x0400115D RID: 4445
        private Label label26;

        // Token: 0x0400115E RID: 4446
        private ComboBox cobhanghoa;

        // Token: 0x0400115F RID: 4447
        private ComboBox txtdonvi;

        // Token: 0x04001160 RID: 4448
        private Button btinhoadon;

        // Token: 0x04001161 RID: 4449
        private Label label28;

        // Token: 0x04001162 RID: 4450
        private Button btinhdnhap;

        // Token: 0x04001163 RID: 4451
        private TextBox txtghichu;

        // Token: 0x04001164 RID: 4452
        private Label label29;

        // Token: 0x04001165 RID: 4453
        private PageSetupDialog pageSetupDialog1;

        // Token: 0x04001166 RID: 4454
        private Button btxem;

        // Token: 0x04001167 RID: 4455
        private PrintPreviewDialog printPreviewDialog1;

        // Token: 0x04001168 RID: 4456
        private PrintDialog printDialog1;

        // Token: 0x04001169 RID: 4457
        private PrintDocument printDocument1;

        // Token: 0x0400116A RID: 4458
        private TextBox txtcochudiachi;

        // Token: 0x0400116B RID: 4459
        private Label label31;

        // Token: 0x0400116C RID: 4460
        private TextBox txtcochutencongty;

        // Token: 0x0400116D RID: 4461
        private Label label30;

        // Token: 0x0400116E RID: 4462
        private TextBox txtmahh;

        // Token: 0x0400116F RID: 4463
        private PrintDocument printDocument2;

        // Token: 0x04001170 RID: 4464
        private TextBox txtthanhtiensauvat;

        // Token: 0x04001171 RID: 4465
        private Label label1;

        // Token: 0x04001172 RID: 4466
        private Button btnhapexecl;

        // Token: 0x04001173 RID: 4467
        private OpenFileDialog openFileDialog1;

        // Token: 0x04001174 RID: 4468
        private CheckBox cbinhanghoa;

        // Token: 0x04001175 RID: 4469
        private CheckBox cbvietnam;

        // Token: 0x04001176 RID: 4470
        private PrintDocument PrintInmahang;

        // Token: 0x04001177 RID: 4471
        private TextBox txttigia;

        // Token: 0x04001178 RID: 4472
        private Label label22;

        // Token: 0x04001179 RID: 4473
        private TextBox txttongsoluong;

        // Token: 0x0400117A RID: 4474
        private CheckBox cbinma;

        // Token: 0x0400117B RID: 4475
        private TextBox txttimkiem;

        // Token: 0x0400117C RID: 4476
        private TextBox txtdocao;

        // Token: 0x0400117D RID: 4477
        private TextBox txtdocaodiachi;

        // Token: 0x0400117E RID: 4478
        private TextBox txtmakh;

        // Token: 0x0400117F RID: 4479
        private Label label32;

        // Token: 0x04001180 RID: 4480
        private Button btdong;

        // Token: 0x04001181 RID: 4481
        private DataGridViewTextBoxColumn STT;

        // Token: 0x04001182 RID: 4482
        private DataGridViewTextBoxColumn Tenhanghoa;

        // Token: 0x04001183 RID: 4483
        private DataGridViewTextBoxColumn mahanghoa;

        // Token: 0x04001184 RID: 4484
        private DataGridViewTextBoxColumn dvt;

        // Token: 0x04001185 RID: 4485
        private DataGridViewTextBoxColumn SL;

        // Token: 0x04001186 RID: 4486
        private DataGridViewTextBoxColumn dg;

        // Token: 0x04001187 RID: 4487
        private DataGridViewTextBoxColumn Thanhtien;

        // Token: 0x04001188 RID: 4488
        private DataGridViewTextBoxColumn sort;
    }
}
