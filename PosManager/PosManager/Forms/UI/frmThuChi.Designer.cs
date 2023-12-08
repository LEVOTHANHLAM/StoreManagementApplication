using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class frmThuChi
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmThuChi));
            this.panel1 = new Panel();
            this.txtconno = new TextBox();
            this.txtno = new TextBox();
            this.ptin = new Button();
            this.bttim = new Button();
            this.txtlydo = new ComboBox();
            this.txtchungtu = new TextBox();
            this.textBox2 = new TextBox();
            this.btthoat = new Button();
            this.cobthuchi = new ComboBox();
            this.txtghichu = new TextBox();
            this.txtngaythu = new TextBox();
            this.txtsotien = new TextBox();
            this.label5 = new Label();
            this.lbthuchi = new Label();
            this.btthem = new Button();
            this.txtmathuchi = new TextBox();
            this.button1 = new Button();
            this.btluuin = new Button();
            this.textBox4 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox5 = new TextBox();
            this.txttenkhachhang = new TextBox();
            this.txtmakhachhang = new TextBox();
            this.lbkhachhang = new TextBox();
            this.button2 = new Button();
            this.dgvtimkhachhang = new DataGridView();
            this.CHON = new DataGridViewButtonColumn();
            this.makhtimkiem = new DataGridViewTextBoxColumn();
            this.tenkh = new DataGridViewTextBoxColumn();
            this.DIACHI = new DataGridViewTextBoxColumn();
            this.btluu = new Button();
            this.panel2 = new Panel();
            this.dgvthuchi = new DataGridView();
            this.STT = new DataGridViewTextBoxColumn();
            this.Loaiphieu = new DataGridViewTextBoxColumn();
            this.SoTien = new DataGridViewTextBoxColumn();
            this.tienchi = new DataGridViewTextBoxColumn();
            this.TENDONVI = new DataGridViewTextBoxColumn();
            this.Lydo = new DataGridViewTextBoxColumn();
            this.Ngay = new DataGridViewTextBoxColumn();
            this.Chungtu = new DataGridViewTextBoxColumn();
            this.Manv = new DataGridViewTextBoxColumn();
            this.ghichu = new DataGridViewTextBoxColumn();
            this.mathuchi = new DataGridViewTextBoxColumn();
            this.MAKH = new DataGridViewTextBoxColumn();
            this.macongty = new DataGridViewTextBoxColumn();
            this.chiphi = new DataGridViewTextBoxColumn();
            this.cobabc = new Panel();
            this.txtchenhech = new TextBox();
            this.textBox20 = new TextBox();
            this.txttienmat = new TextBox();
            this.textBox18 = new TextBox();
            this.button4 = new Button();
            this.txttiencu = new TextBox();
            this.tiencu = new TextBox();
            this.txtnhaphang = new TextBox();
            this.textBox17 = new TextBox();
            this.textBox15 = new TextBox();
            this.txttimkiem = new TextBox();
            this.cobnhanvien = new ComboBox();
            this.cobloaiphieu = new ComboBox();
            this.dtdenngay = new DateTimePicker();
            this.dttungay = new DateTimePicker();
            this.button3 = new Button();
            this.btxembaocao = new Button();
            this.txttongthuchi = new TextBox();
            this.txttongchi = new TextBox();
            this.txttienbanhang = new TextBox();
            this.cobtruong = new ComboBox();
            this.txttongthu = new TextBox();
            this.textBox9 = new TextBox();
            this.textBox8 = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox10 = new TextBox();
            this.textBox11 = new TextBox();
            this.textBox13 = new TextBox();
            this.textBox12 = new TextBox();
            this.textBox14 = new TextBox();
            this.button5 = new Button();
            this.printDocument1 = new PrintDocument();
            this.printDocument2 = new PrintDocument();
            this.saveFileDialog1 = new SaveFileDialog();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.print_congno = new PrintDocument();
            this.checkBox1 = new CheckBox();
            this.pt_Image = new PictureBox();
            this.K80 = new PrintDocument();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvtimkhachhang).BeginInit();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.dgvthuchi).BeginInit();
            this.cobabc.SuspendLayout();
            ((ISupportInitialize)this.pt_Image).BeginInit();
            base.SuspendLayout();
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtconno);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.ptin);
            this.panel1.Controls.Add(this.bttim);
            this.panel1.Controls.Add(this.txtlydo);
            this.panel1.Controls.Add(this.txtchungtu);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.cobthuchi);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.txtngaythu);
            this.panel1.Controls.Add(this.txtsotien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbthuchi);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Controls.Add(this.txtmathuchi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btluuin);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.txttenkhachhang);
            this.panel1.Controls.Add(this.txtmakhachhang);
            this.panel1.Controls.Add(this.lbkhachhang);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvtimkhachhang);
            this.panel1.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.panel1.ForeColor = Color.FromArgb(0, 0, 192);
            this.panel1.Location = new Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(458, 271);
            this.panel1.TabIndex = 0;
            this.txtconno.BackColor = Color.White;
            this.txtconno.Enabled = false;
            this.txtconno.Font = new Font("Times New Roman", 14f);
            this.txtconno.ForeColor = Color.Purple;
            this.txtconno.Location = new Point(265, 123);
            this.txtconno.Name = "txtconno";
            this.txtconno.ReadOnly = true;
            this.txtconno.Size = new Size(72, 29);
            this.txtconno.TabIndex = 10009;
            this.txtconno.Text = "Phải thu:";
            this.txtno.BackColor = Color.White;
            this.txtno.Enabled = false;
            this.txtno.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtno.ForeColor = Color.Purple;
            this.txtno.Location = new Point(323, 123);
            this.txtno.Name = "txtno";
            this.txtno.Size = new Size(130, 29);
            this.txtno.TabIndex = 10008;
            this.txtno.Text = "0";
            this.txtno.TextAlign = HorizontalAlignment.Right;
            this.ptin.BackColor = Color.Gainsboro;
            this.ptin.FlatAppearance.BorderColor = Color.Gray;
            this.ptin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.ptin.FlatStyle = FlatStyle.Flat;
            this.ptin.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ptin.Location = new Point(357, 221);
            this.ptin.Name = "ptin";
            this.ptin.Size = new Size(86, 45);
            this.ptin.TabIndex = 21;
            this.ptin.Text = "In";
            this.ptin.UseVisualStyleBackColor = false;
            this.ptin.Click += this.ptin_Click;
            this.bttim.BackColor = Color.Blue;
            this.bttim.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            this.bttim.FlatAppearance.MouseOverBackColor = Color.Blue;
            this.bttim.FlatStyle = FlatStyle.Flat;
            this.bttim.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.bttim.ForeColor = Color.White;
            this.bttim.Location = new Point(411, 63);
            this.bttim.Name = "bttim";
            this.bttim.Size = new Size(42, 27);
            this.bttim.TabIndex = 18;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += this.bttim_Click;
            this.txtlydo.BackColor = Color.White;
            this.txtlydo.Enabled = false;
            this.txtlydo.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtlydo.FormattingEnabled = true;
            this.txtlydo.Items.AddRange(new object[]
            {
                "Thu nợ khách hàng",
                "Trả nợ cho nhà cung cấp",
                "Tiền Điện",
                "Tiền Nước",
                "Tiền lương (ứng lương)",
                "Chi phí"
            });
            this.txtlydo.Location = new Point(102, 156);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new Size(351, 29);
            this.txtlydo.TabIndex = 4;
            this.txtchungtu.BackColor = Color.White;
            this.txtchungtu.Enabled = false;
            this.txtchungtu.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtchungtu.ForeColor = Color.Purple;
            this.txtchungtu.Location = new Point(102, 188);
            this.txtchungtu.Name = "txtchungtu";
            this.txtchungtu.Size = new Size(351, 29);
            this.txtchungtu.TabIndex = 5;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.Purple;
            this.textBox2.Location = new Point(121, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(174, 29);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextAlign = HorizontalAlignment.Right;
            this.btthoat.BackColor = Color.Gainsboro;
            this.btthoat.FlatAppearance.BorderColor = Color.Gray;
            this.btthoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btthoat.FlatStyle = FlatStyle.Flat;
            this.btthoat.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btthoat.Location = new Point(269, 221);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new Size(86, 45);
            this.btthoat.TabIndex = 8;
            this.btthoat.Text = "Hủy";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += this.btthoat_Click;
            this.cobthuchi.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cobthuchi.DisplayMember = "0";
            this.cobthuchi.Enabled = false;
            this.cobthuchi.FlatStyle = FlatStyle.Flat;
            this.cobthuchi.Font = new Font("Times New Roman", 13f);
            this.cobthuchi.ForeColor = Color.Navy;
            this.cobthuchi.FormattingEnabled = true;
            this.cobthuchi.Items.AddRange(new object[]
            {
                "Thu Khác",
                "Thu Nợ",
                "Chi Khác",
                "Trả Nợ",
                "Thu hợp đồng"
            });
            this.cobthuchi.Location = new Point(3, 27);
            this.cobthuchi.Name = "cobthuchi";
            this.cobthuchi.Size = new Size(179, 27);
            this.cobthuchi.TabIndex = 0;
            this.cobthuchi.Text = "Thu Khác";
            this.cobthuchi.ValueMember = "0";
            this.cobthuchi.SelectedIndexChanged += this.cobthuchi_SelectedIndexChanged;
            this.txtghichu.BackColor = Color.White;
            this.txtghichu.Enabled = false;
            this.txtghichu.Font = new Font("Times New Roman", 12f);
            this.txtghichu.ForeColor = Color.Purple;
            this.txtghichu.Location = new Point(102, 93);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(351, 26);
            this.txtghichu.TabIndex = 2;
            this.txtngaythu.BackColor = Color.White;
            this.txtngaythu.Enabled = false;
            this.txtngaythu.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtngaythu.ForeColor = Color.Purple;
            this.txtngaythu.Location = new Point(313, 29);
            this.txtngaythu.Name = "txtngaythu";
            this.txtngaythu.Size = new Size(140, 29);
            this.txtngaythu.TabIndex = 9;
            this.txtngaythu.Text = "15:00 31/12/2020";
            this.txtngaythu.TextAlign = HorizontalAlignment.Right;
            this.txtngaythu.Leave += this.txtngaythu_Leave;
            this.txtsotien.BackColor = Color.White;
            this.txtsotien.Enabled = false;
            this.txtsotien.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtsotien.ForeColor = Color.Purple;
            this.txtsotien.Location = new Point(102, 123);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new Size(108, 29);
            this.txtsotien.TabIndex = 3;
            this.txtsotien.Text = "0";
            this.txtsotien.TextAlign = HorizontalAlignment.Right;
            this.txtsotien.MouseClick += this.txtsotien_MouseClick;
            this.txtsotien.TextChanged += this.txtsotien_TextChanged;
            this.txtsotien.KeyDown += this.txtsotien_KeyDown;
            this.txtsotien.KeyPress += this.txtsotien_KeyPress;
            this.txtsotien.Leave += this.txtsotien_Leave;
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
            this.label5.ForeColor = Color.Navy;
            this.label5.Location = new Point(195, 3);
            this.label5.Name = "label5";
            this.label5.Size = new Size(164, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "THÊM THU - CHI";
            this.lbthuchi.AutoSize = true;
            this.lbthuchi.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbthuchi.Location = new Point(265, 33);
            this.lbthuchi.Name = "lbthuchi";
            this.lbthuchi.Size = new Size(53, 21);
            this.lbthuchi.TabIndex = 3;
            this.lbthuchi.Text = "Ngày:";
            this.btthem.BackColor = Color.Gainsboro;
            this.btthem.FlatAppearance.BorderColor = Color.Gray;
            this.btthem.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btthem.FlatStyle = FlatStyle.Flat;
            this.btthem.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btthem.Location = new Point(2, 221);
            this.btthem.Name = "btthem";
            this.btthem.Size = new Size(86, 45);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += this.btthem_Click;
            this.txtmathuchi.Enabled = false;
            this.txtmathuchi.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtmathuchi.ForeColor = Color.Purple;
            this.txtmathuchi.Location = new Point(121, 156);
            this.txtmathuchi.Name = "txtmathuchi";
            this.txtmathuchi.Size = new Size(174, 29);
            this.txtmathuchi.TabIndex = 13;
            this.txtmathuchi.TextAlign = HorizontalAlignment.Right;
            this.button1.BackColor = Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(90, 221);
            this.button1.Name = "button1";
            this.button1.Size = new Size(86, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.btluuin.BackColor = Color.Gainsboro;
            this.btluuin.FlatAppearance.BorderColor = Color.Gray;
            this.btluuin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btluuin.FlatStyle = FlatStyle.Flat;
            this.btluuin.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btluuin.Location = new Point(180, 221);
            this.btluuin.Name = "btluuin";
            this.btluuin.Size = new Size(86, 45);
            this.btluuin.TabIndex = 6;
            this.btluuin.Text = "Lưu";
            this.btluuin.UseVisualStyleBackColor = false;
            this.btluuin.Visible = false;
            this.btluuin.Click += this.btluuin_Click;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new Font("Times New Roman", 14f);
            this.textBox4.ForeColor = Color.Purple;
            this.textBox4.Location = new Point(2, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(140, 29);
            this.textBox4.TabIndex = 10005;
            this.textBox4.Text = "Số tiền:";
            this.textBox3.BackColor = Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new Font("Times New Roman", 12f);
            this.textBox3.ForeColor = Color.Purple;
            this.textBox3.Location = new Point(2, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(140, 26);
            this.textBox3.TabIndex = 10005;
            this.textBox3.Text = "Địa chỉ:";
            this.textBox6.BackColor = Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new Font("Times New Roman", 14f);
            this.textBox6.ForeColor = Color.Purple;
            this.textBox6.Location = new Point(2, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new Size(140, 29);
            this.textBox6.TabIndex = 10007;
            this.textBox6.Text = "Chứng từ:";
            this.textBox5.BackColor = Color.White;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new Font("Times New Roman", 14f);
            this.textBox5.ForeColor = Color.Purple;
            this.textBox5.Location = new Point(2, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(140, 29);
            this.textBox5.TabIndex = 10006;
            this.textBox5.Text = "Nội dung:";
            this.txttenkhachhang.BackColor = Color.White;
            this.txttenkhachhang.Enabled = false;
            this.txttenkhachhang.Location = new Point(102, 64);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new Size(310, 26);
            this.txttenkhachhang.TabIndex = 19;
            this.txttenkhachhang.TextChanged += this.txttenkhachhang_TextChanged;
            this.txttenkhachhang.KeyDown += this.txttenkhachhang_KeyDown;
            this.txtmakhachhang.Location = new Point(121, 64);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new Size(265, 26);
            this.txtmakhachhang.TabIndex = 20;
            this.txtmakhachhang.TextChanged += this.txtmakhachhang_TextChanged;
            this.lbkhachhang.BackColor = Color.White;
            this.lbkhachhang.Enabled = false;
            this.lbkhachhang.Font = new Font("Times New Roman", 12f);
            this.lbkhachhang.ForeColor = Color.Purple;
            this.lbkhachhang.Location = new Point(2, 64);
            this.lbkhachhang.Name = "lbkhachhang";
            this.lbkhachhang.ReadOnly = true;
            this.lbkhachhang.Size = new Size(140, 26);
            this.lbkhachhang.TabIndex = 10005;
            this.lbkhachhang.Text = "Người nộp tiền:";
            this.button2.BackColor = Color.Blue;
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            this.button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(209, 123);
            this.button2.Name = "button2";
            this.button2.Size = new Size(57, 29);
            this.button2.TabIndex = 10010;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click_2;
            this.dgvtimkhachhang.AllowUserToAddRows = false;
            this.dgvtimkhachhang.AllowUserToDeleteRows = false;
            this.dgvtimkhachhang.BackgroundColor = Color.White;
            this.dgvtimkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkhachhang.ColumnHeadersVisible = false;
            this.dgvtimkhachhang.Columns.AddRange(new DataGridViewColumn[]
            {
                this.CHON,
                this.makhtimkiem,
                this.tenkh,
                this.DIACHI
            });
            this.dgvtimkhachhang.Location = new Point(102, 89);
            this.dgvtimkhachhang.Name = "dgvtimkhachhang";
            this.dgvtimkhachhang.ReadOnly = true;
            this.dgvtimkhachhang.RowHeadersVisible = false;
            this.dgvtimkhachhang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 192);
            this.dgvtimkhachhang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvtimkhachhang.RowTemplate.Height = 39;
            this.dgvtimkhachhang.Size = new Size(351, 176);
            this.dgvtimkhachhang.TabIndex = 10004;
            this.dgvtimkhachhang.Visible = false;
            this.dgvtimkhachhang.CellClick += this.dgvtimkhachhang_CellClick;
            this.dgvtimkhachhang.KeyDown += this.dgvtimkhachhang_KeyDown;
            this.dgvtimkhachhang.MouseDoubleClick += this.dgvtimkhachhang_MouseDoubleClick;
            this.dgvtimkhachhang.MouseDown += this.dgvtimkhachhang_MouseDown;
            this.CHON.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.CHON.FlatStyle = FlatStyle.Flat;
            this.CHON.HeaderText = "CHON";
            this.CHON.Name = "CHON";
            this.CHON.ReadOnly = true;
            this.CHON.Resizable = DataGridViewTriState.True;
            this.CHON.SortMode = DataGridViewColumnSortMode.Automatic;
            this.CHON.Width = 58;
            this.makhtimkiem.DataPropertyName = "makhachhang";
            this.makhtimkiem.HeaderText = "Makh";
            this.makhtimkiem.Name = "makhtimkiem";
            this.makhtimkiem.ReadOnly = true;
            this.makhtimkiem.Visible = false;
            this.tenkh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenkh.DataPropertyName = "tenkhachhang";
            dataGridViewCellStyle.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.tenkh.DefaultCellStyle = dataGridViewCellStyle;
            this.tenkh.HeaderText = "tenkh";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            this.tenkh.Width = 600;
            this.DIACHI.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.btluu.BackColor = Color.White;
            this.btluu.FlatStyle = FlatStyle.Flat;
            this.btluu.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btluu.Location = new Point(9, 15);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(95, 68);
            this.btluu.TabIndex = 5;
            this.btluu.Text = "LƯU";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Visible = false;
            this.btluu.Click += this.btluu_Click;
            this.panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.panel2.Controls.Add(this.dgvthuchi);
            this.panel2.Controls.Add(this.btluu);
            this.panel2.Controls.Add(this.pt_Image);
            this.panel2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.panel2.ForeColor = Color.Navy;
            this.panel2.Location = new Point(13, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(994, 384);
            this.panel2.TabIndex = 1;
            this.dgvthuchi.AllowUserToAddRows = false;
            this.dgvthuchi.AllowUserToDeleteRows = false;
            this.dgvthuchi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthuchi.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvthuchi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvthuchi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuchi.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.Loaiphieu,
                this.SoTien,
                this.tienchi,
                this.TENDONVI,
                this.Lydo,
                this.Ngay,
                this.Chungtu,
                this.Manv,
                this.ghichu,
                this.mathuchi,
                this.MAKH,
                this.macongty,
                this.chiphi
            });
            this.dgvthuchi.Dock = DockStyle.Fill;
            this.dgvthuchi.Location = new Point(0, 0);
            this.dgvthuchi.Name = "dgvthuchi";
            this.dgvthuchi.ReadOnly = true;
            this.dgvthuchi.RowHeadersWidth = 5;
            this.dgvthuchi.RowTemplate.Height = 28;
            this.dgvthuchi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvthuchi.Size = new Size(994, 384);
            this.dgvthuchi.TabIndex = 0;
            this.dgvthuchi.Enter += this.dgvthuchi_Enter;
            this.dgvthuchi.KeyDown += this.dgvthuchi_KeyDown;
            this.dgvthuchi.MouseClick += this.dgvthuchi_MouseClick;
            this.STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 50;
            this.Loaiphieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Loaiphieu.DataPropertyName = "thuchi";
            this.Loaiphieu.HeaderText = "Loại Phiếu";
            this.Loaiphieu.Name = "Loaiphieu";
            this.Loaiphieu.ReadOnly = true;
            this.Loaiphieu.Width = 120;
            this.SoTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SoTien.DataPropertyName = "sotien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.SoTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.SoTien.HeaderText = "Tiền Thu";
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            this.SoTien.Width = 120;
            this.tienchi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tienchi.DataPropertyName = "tientrano";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.tienchi.DefaultCellStyle = dataGridViewCellStyle5;
            this.tienchi.HeaderText = "Tiền Chi";
            this.tienchi.Name = "tienchi";
            this.tienchi.ReadOnly = true;
            this.tienchi.Width = 120;
            this.TENDONVI.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TENDONVI.DataPropertyName = "TENDONVI";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.TENDONVI.DefaultCellStyle = dataGridViewCellStyle6;
            this.TENDONVI.HeaderText = "Họ Tên";
            this.TENDONVI.Name = "TENDONVI";
            this.TENDONVI.ReadOnly = true;
            this.TENDONVI.Width = 250;
            this.Lydo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Lydo.DataPropertyName = "lydo";
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            this.Lydo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Lydo.HeaderText = "Lý Do";
            this.Lydo.Name = "Lydo";
            this.Lydo.ReadOnly = true;
            this.Lydo.Width = 200;
            this.Ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ngay.DataPropertyName = "ngay";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle8;
            this.Ngay.HeaderText = "Ngày chứng từ";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 150;
            this.Chungtu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Chungtu.DataPropertyName = "CHUNGTU";
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.Chungtu.DefaultCellStyle = dataGridViewCellStyle9;
            this.Chungtu.HeaderText = "Chứng từ";
            this.Chungtu.Name = "Chungtu";
            this.Chungtu.ReadOnly = true;
            this.Chungtu.Width = 200;
            this.Manv.DataPropertyName = "manv";
            this.Manv.HeaderText = "Manv";
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            this.Manv.Visible = false;
            this.ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.Width = 200;
            this.mathuchi.DataPropertyName = "mathuchi";
            this.mathuchi.HeaderText = "Column1";
            this.mathuchi.Name = "mathuchi";
            this.mathuchi.ReadOnly = true;
            this.mathuchi.Visible = false;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã nhân viên";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Visible = false;
            this.macongty.DataPropertyName = "macongty";
            this.macongty.HeaderText = "Mã công ty";
            this.macongty.Name = "macongty";
            this.macongty.ReadOnly = true;
            this.macongty.Visible = false;
            this.chiphi.DataPropertyName = "chiphi";
            this.chiphi.HeaderText = "chiphi";
            this.chiphi.Name = "chiphi";
            this.chiphi.ReadOnly = true;
            this.chiphi.Visible = false;
            this.cobabc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cobabc.BorderStyle = BorderStyle.FixedSingle;
            this.cobabc.Controls.Add(this.txtchenhech);
            this.cobabc.Controls.Add(this.textBox20);
            this.cobabc.Controls.Add(this.txttienmat);
            this.cobabc.Controls.Add(this.textBox18);
            this.cobabc.Controls.Add(this.button4);
            this.cobabc.Controls.Add(this.txttiencu);
            this.cobabc.Controls.Add(this.tiencu);
            this.cobabc.Controls.Add(this.txtnhaphang);
            this.cobabc.Controls.Add(this.textBox17);
            this.cobabc.Controls.Add(this.textBox15);
            this.cobabc.Controls.Add(this.txttimkiem);
            this.cobabc.Controls.Add(this.cobnhanvien);
            this.cobabc.Controls.Add(this.cobloaiphieu);
            this.cobabc.Controls.Add(this.dtdenngay);
            this.cobabc.Controls.Add(this.dttungay);
            this.cobabc.Controls.Add(this.button3);
            this.cobabc.Controls.Add(this.btxembaocao);
            this.cobabc.Controls.Add(this.txttongthuchi);
            this.cobabc.Controls.Add(this.txttongchi);
            this.cobabc.Controls.Add(this.txttienbanhang);
            this.cobabc.Controls.Add(this.cobtruong);
            this.cobabc.Controls.Add(this.txttongthu);
            this.cobabc.Controls.Add(this.textBox9);
            this.cobabc.Controls.Add(this.textBox8);
            this.cobabc.Controls.Add(this.textBox7);
            this.cobabc.Controls.Add(this.textBox10);
            this.cobabc.Controls.Add(this.textBox11);
            this.cobabc.Controls.Add(this.textBox13);
            this.cobabc.Controls.Add(this.textBox12);
            this.cobabc.Controls.Add(this.textBox14);
            this.cobabc.Controls.Add(this.button5);
            this.cobabc.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cobabc.ForeColor = Color.FromArgb(0, 0, 192);
            this.cobabc.Location = new Point(469, 3);
            this.cobabc.Name = "cobabc";
            this.cobabc.Size = new Size(538, 270);
            this.cobabc.TabIndex = 14;
            this.txtchenhech.BackColor = Color.Yellow;
            this.txtchenhech.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            this.txtchenhech.ForeColor = Color.Red;
            this.txtchenhech.Location = new Point(383, 239);
            this.txtchenhech.Name = "txtchenhech";
            this.txtchenhech.ReadOnly = true;
            this.txtchenhech.Size = new Size(154, 32);
            this.txtchenhech.TabIndex = 10022;
            this.txtchenhech.Text = "0";
            this.txtchenhech.TextAlign = HorizontalAlignment.Right;
            this.textBox20.BackColor = Color.White;
            this.textBox20.Enabled = false;
            this.textBox20.Font = new Font("Times New Roman", 12f);
            this.textBox20.ForeColor = Color.Purple;
            this.textBox20.Location = new Point(259, 239);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new Size(140, 32);
            this.textBox20.TabIndex = 10023;
            this.textBox20.Tag = "Chênh lệch:";
            this.textBox20.Text = "Chênh lệch:";
            this.txttienmat.BackColor = Color.Yellow;
            this.txttienmat.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            this.txttienmat.ForeColor = Color.Red;
            this.txttienmat.Location = new Point(383, 208);
            this.txttienmat.Name = "txttienmat";
            this.txttienmat.Size = new Size(154, 32);
            this.txttienmat.TabIndex = 10020;
            this.txttienmat.Text = "0";
            this.txttienmat.TextAlign = HorizontalAlignment.Right;
            this.txttienmat.TextChanged += this.txttienmat_TextChanged;
            this.textBox18.BackColor = Color.White;
            this.textBox18.Enabled = false;
            this.textBox18.Font = new Font("Times New Roman", 12f);
            this.textBox18.ForeColor = Color.Purple;
            this.textBox18.Location = new Point(259, 208);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new Size(140, 32);
            this.textBox18.TabIndex = 10021;
            this.textBox18.Text = "Tiền mặt thực tế:";
            this.button4.BackColor = Color.Gainsboro;
            this.button4.FlatAppearance.BorderColor = Color.Blue;
            this.button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button4.FlatStyle = FlatStyle.Popup;
            this.button4.Font = new Font("Times New Roman", 10f);
            this.button4.Location = new Point(161, 132);
            this.button4.Name = "button4";
            this.button4.Size = new Size(96, 75);
            this.button4.TabIndex = 10018;
            this.button4.Text = "Nhập tiền cũ\r\n(Tiền mặt\r\nngày hôm trước)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += this.button4_Click;
            this.txttiencu.BackColor = Color.White;
            this.txttiencu.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttiencu.ForeColor = Color.Purple;
            this.txttiencu.Location = new Point(383, 3);
            this.txttiencu.Name = "txttiencu";
            this.txttiencu.ReadOnly = true;
            this.txttiencu.Size = new Size(154, 32);
            this.txttiencu.TabIndex = 10016;
            this.txttiencu.Text = "0";
            this.txttiencu.TextAlign = HorizontalAlignment.Right;
            this.txttiencu.Enter += this.txttiencu_Enter;
            this.txttiencu.Leave += this.txttiencu_Leave;
            this.tiencu.BackColor = Color.White;
            this.tiencu.Enabled = false;
            this.tiencu.Font = new Font("Times New Roman", 16f);
            this.tiencu.ForeColor = Color.Purple;
            this.tiencu.Location = new Point(259, 3);
            this.tiencu.Name = "tiencu";
            this.tiencu.ReadOnly = true;
            this.tiencu.Size = new Size(140, 32);
            this.tiencu.TabIndex = 10017;
            this.tiencu.Text = "Tiền cũ:";
            this.txtnhaphang.BackColor = Color.White;
            this.txtnhaphang.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            this.txtnhaphang.ForeColor = Color.Purple;
            this.txtnhaphang.Location = new Point(383, 141);
            this.txtnhaphang.Name = "txtnhaphang";
            this.txtnhaphang.ReadOnly = true;
            this.txtnhaphang.Size = new Size(154, 32);
            this.txtnhaphang.TabIndex = 10014;
            this.txtnhaphang.Text = "0";
            this.txtnhaphang.TextAlign = HorizontalAlignment.Right;
            this.textBox17.BackColor = Color.White;
            this.textBox17.Enabled = false;
            this.textBox17.Font = new Font("Times New Roman", 16f);
            this.textBox17.ForeColor = Color.Purple;
            this.textBox17.Location = new Point(259, 141);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new Size(140, 32);
            this.textBox17.TabIndex = 10015;
            this.textBox17.Text = "Nhập hàng:";
            this.textBox15.BackColor = Color.White;
            this.textBox15.Location = new Point(2, 240);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Size(255, 26);
            this.textBox15.TabIndex = 10013;
            this.textBox15.Tag = "Tìm theo tên";
            this.textBox15.Text = "Tìm theo tên";
            this.textBox15.TextChanged += this.textBox15_TextChanged;
            this.textBox15.Enter += this.textBox15_Enter;
            this.textBox15.Leave += this.textBox15_Leave;
            this.txttimkiem.BackColor = Color.White;
            this.txttimkiem.Location = new Point(2, 212);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(255, 26);
            this.txttimkiem.TabIndex = 10012;
            this.txttimkiem.Tag = "Tìm mã khách hàng - ncc";
            this.txttimkiem.Text = "Tìm mã khách hàng - ncc";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.cobnhanvien.FormattingEnabled = true;
            this.cobnhanvien.Location = new Point(90, 34);
            this.cobnhanvien.Name = "cobnhanvien";
            this.cobnhanvien.Size = new Size(167, 27);
            this.cobnhanvien.TabIndex = 73;
            this.cobloaiphieu.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cobloaiphieu.DisplayMember = "0";
            this.cobloaiphieu.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
            this.cobloaiphieu.ForeColor = Color.Navy;
            this.cobloaiphieu.FormattingEnabled = true;
            this.cobloaiphieu.Items.AddRange(new object[]
            {
                "THU",
                "CHI",
                "THU + CHI",
                "THU HỢP ĐỒNG",
                "THU KHÁC"
            });
            this.cobloaiphieu.Location = new Point(90, 3);
            this.cobloaiphieu.Name = "cobloaiphieu";
            this.cobloaiphieu.Size = new Size(167, 30);
            this.cobloaiphieu.TabIndex = 0;
            this.cobloaiphieu.ValueMember = "0";
            this.dtdenngay.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dtdenngay.Format = DateTimePickerFormat.Custom;
            this.dtdenngay.Location = new Point(90, 92);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new Size(167, 29);
            this.dtdenngay.TabIndex = 16;
            this.dttungay.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dttungay.Format = DateTimePickerFormat.Custom;
            this.dttungay.Location = new Point(90, 62);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new Size(167, 29);
            this.dttungay.TabIndex = 15;
            this.button3.BackColor = Color.Gainsboro;
            this.button3.FlatAppearance.BorderColor = Color.Blue;
            this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(3, 179);
            this.button3.Name = "button3";
            this.button3.Size = new Size(153, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.btxembaocao.BackColor = Color.Gainsboro;
            this.btxembaocao.FlatAppearance.BorderColor = Color.Blue;
            this.btxembaocao.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btxembaocao.FlatStyle = FlatStyle.Popup;
            this.btxembaocao.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btxembaocao.Location = new Point(3, 132);
            this.btxembaocao.Name = "btxembaocao";
            this.btxembaocao.Size = new Size(153, 48);
            this.btxembaocao.TabIndex = 14;
            this.btxembaocao.Text = "XEM";
            this.btxembaocao.UseVisualStyleBackColor = false;
            this.btxembaocao.Click += this.btxembaocao_Click;
            this.txttongthuchi.BackColor = Color.Yellow;
            this.txttongthuchi.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            this.txttongthuchi.ForeColor = Color.Red;
            this.txttongthuchi.Location = new Point(383, 175);
            this.txttongthuchi.Name = "txttongthuchi";
            this.txttongthuchi.ReadOnly = true;
            this.txttongthuchi.Size = new Size(154, 32);
            this.txttongthuchi.TabIndex = 17;
            this.txttongthuchi.Text = "0";
            this.txttongthuchi.TextAlign = HorizontalAlignment.Right;
            this.txttongchi.BackColor = Color.White;
            this.txttongchi.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongchi.ForeColor = Color.Purple;
            this.txttongchi.Location = new Point(383, 107);
            this.txttongchi.Name = "txttongchi";
            this.txttongchi.ReadOnly = true;
            this.txttongchi.Size = new Size(154, 32);
            this.txttongchi.TabIndex = 2;
            this.txttongchi.Text = "0";
            this.txttongchi.TextAlign = HorizontalAlignment.Right;
            this.txttongchi.TextChanged += this.txttongchi_TextChanged;
            this.txttienbanhang.BackColor = Color.White;
            this.txttienbanhang.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttienbanhang.ForeColor = Color.Purple;
            this.txttienbanhang.Location = new Point(383, 38);
            this.txttienbanhang.Name = "txttienbanhang";
            this.txttienbanhang.ReadOnly = true;
            this.txttienbanhang.Size = new Size(154, 32);
            this.txttienbanhang.TabIndex = 19;
            this.txttienbanhang.Text = "0";
            this.txttienbanhang.TextAlign = HorizontalAlignment.Right;
            this.txttienbanhang.TextChanged += this.txttienbanhang_TextChanged;
            this.cobtruong.FormattingEnabled = true;
            this.cobtruong.Location = new Point(370, 220);
            this.cobtruong.Name = "cobtruong";
            this.cobtruong.Size = new Size(119, 27);
            this.cobtruong.TabIndex = 75;
            this.cobtruong.Visible = false;
            this.txttongthu.BackColor = Color.White;
            this.txttongthu.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongthu.ForeColor = Color.Purple;
            this.txttongthu.Location = new Point(383, 73);
            this.txttongthu.Name = "txttongthu";
            this.txttongthu.ReadOnly = true;
            this.txttongthu.Size = new Size(154, 32);
            this.txttongthu.TabIndex = 1;
            this.txttongthu.Text = "0";
            this.txttongthu.TextAlign = HorizontalAlignment.Right;
            this.txttongthu.TextChanged += this.txttongthu_TextChanged;
            this.textBox9.BackColor = Color.White;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new Font("Times New Roman", 14f);
            this.textBox9.ForeColor = Color.Purple;
            this.textBox9.Location = new Point(2, 62);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new Size(140, 29);
            this.textBox9.TabIndex = 10006;
            this.textBox9.Text = "Từ ngày:";
            this.textBox8.BackColor = Color.White;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new Font("Times New Roman", 13f);
            this.textBox8.ForeColor = Color.Purple;
            this.textBox8.Location = new Point(2, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new Size(140, 27);
            this.textBox8.TabIndex = 10006;
            this.textBox8.Text = "Nhân viên:";
            this.textBox7.BackColor = Color.White;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new Font("Times New Roman", 15f);
            this.textBox7.ForeColor = Color.Purple;
            this.textBox7.Location = new Point(2, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new Size(140, 30);
            this.textBox7.TabIndex = 10006;
            this.textBox7.Text = "Loại phiếu:";
            this.textBox10.BackColor = Color.White;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new Font("Times New Roman", 14f);
            this.textBox10.ForeColor = Color.Purple;
            this.textBox10.Location = new Point(2, 92);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new Size(140, 29);
            this.textBox10.TabIndex = 10007;
            this.textBox10.Text = "Đến ngày:";
            this.textBox11.BackColor = Color.White;
            this.textBox11.Enabled = false;
            this.textBox11.Font = new Font("Times New Roman", 16f);
            this.textBox11.ForeColor = Color.Purple;
            this.textBox11.Location = new Point(259, 38);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new Size(140, 32);
            this.textBox11.TabIndex = 10008;
            this.textBox11.Text = "Thu bán hàng:";
            this.textBox13.BackColor = Color.White;
            this.textBox13.Enabled = false;
            this.textBox13.Font = new Font("Times New Roman", 16f);
            this.textBox13.ForeColor = Color.Purple;
            this.textBox13.Location = new Point(259, 107);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new Size(140, 32);
            this.textBox13.TabIndex = 10010;
            this.textBox13.Text = "Chi phí:";
            this.textBox12.BackColor = Color.White;
            this.textBox12.Enabled = false;
            this.textBox12.Font = new Font("Times New Roman", 16f);
            this.textBox12.ForeColor = Color.Purple;
            this.textBox12.Location = new Point(259, 73);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new Size(140, 32);
            this.textBox12.TabIndex = 10009;
            this.textBox12.Text = "Thu khác:";
            this.textBox14.BackColor = Color.White;
            this.textBox14.Enabled = false;
            this.textBox14.Font = new Font("Times New Roman", 16f);
            this.textBox14.ForeColor = Color.Purple;
            this.textBox14.Location = new Point(259, 175);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new Size(140, 32);
            this.textBox14.TabIndex = 10011;
            this.textBox14.Text = "Tiền mặt:";
            this.button5.BackColor = Color.Gainsboro;
            this.button5.FlatAppearance.BorderColor = Color.Blue;
            this.button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button5.Location = new Point(161, 132);
            this.button5.Name = "button5";
            this.button5.Size = new Size(96, 75);
            this.button5.TabIndex = 10019;
            this.button5.Text = "LƯU TIỀN CŨ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += this.button5_Click;
            // this.printDocument1.PrintPage += this.printDocument1_PrintPage;
            //  this.printDocument2.PrintPage += this.printDocument2_PrintPage;
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            //  this.print_congno.PrintPage += this.print_congno_PrintPage;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(99, 23);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "In khổ K80";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.pt_Image.Location = new Point(296, 70);
            this.pt_Image.Name = "pt_Image";
            this.pt_Image.Size = new Size(100, 50);
            this.pt_Image.TabIndex = 15;
            this.pt_Image.TabStop = false;
            //  this.K80.PrintPage += this.K80_PrintPage;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(1008, 661);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.cobabc);
            base.Controls.Add(this.panel2);
            //  base.KeyPreview = true;
            //   base.MaximizeBox = false;
            //   base.MinimizeBox = false;
            base.Name = "frmThuChi";
            //   base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "THÊM THU CHI VÀ BÁO CÁO TỔNG KẾT";
            //   base.FormClosed += this.frmThuChi_FormClosed;
            base.Load += this.frmThuChi_Load;
            base.KeyDown += this.frmThuChi_KeyDown;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dgvtimkhachhang).EndInit();
            this.panel2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvthuchi).EndInit();
            this.cobabc.ResumeLayout(false);
            this.cobabc.PerformLayout();
            ((ISupportInitialize)this.pt_Image).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion


        // Token: 0x04000299 RID: 665
        private Panel panel1;

        // Token: 0x0400029A RID: 666
        private Label lbthuchi;

        // Token: 0x0400029B RID: 667
        private TextBox txtghichu;

        // Token: 0x0400029C RID: 668
        private TextBox txtngaythu;

        // Token: 0x0400029D RID: 669
        private TextBox txtsotien;

        // Token: 0x0400029E RID: 670
        private Label label5;

        // Token: 0x0400029F RID: 671
        private Button btthem;

        // Token: 0x040002A0 RID: 672
        private Button btluu;

        // Token: 0x040002A1 RID: 673
        private Button button1;

        // Token: 0x040002A2 RID: 674
        private ComboBox cobthuchi;

        // Token: 0x040002A3 RID: 675
        private TextBox txtmathuchi;

        // Token: 0x040002A4 RID: 676
        private Panel panel2;

        // Token: 0x040002A5 RID: 677
        private DataGridView dgvthuchi;

        // Token: 0x040002A6 RID: 678
        private Panel cobabc;

        // Token: 0x040002A7 RID: 679
        private DateTimePicker dtdenngay;

        // Token: 0x040002A8 RID: 680
        private DateTimePicker dttungay;

        // Token: 0x040002A9 RID: 681
        private ComboBox cobloaiphieu;

        // Token: 0x040002AA RID: 682
        private TextBox txttongthu;

        // Token: 0x040002AB RID: 683
        private TextBox txttongchi;

        // Token: 0x040002AC RID: 684
        private Button btxembaocao;

        // Token: 0x040002AD RID: 685
        private TextBox txttongthuchi;

        // Token: 0x040002AE RID: 686
        private TextBox txttienbanhang;

        // Token: 0x040002AF RID: 687
        private PrintDocument printDocument1;

        // Token: 0x040002B0 RID: 688
        private Button btluuin;

        // Token: 0x040002B1 RID: 689
        private Button btthoat;

        // Token: 0x040002B2 RID: 690
        private PrintDocument printDocument2;

        // Token: 0x040002B3 RID: 691
        private TextBox txtchungtu;

        // Token: 0x040002B4 RID: 692
        private TextBox textBox2;

        // Token: 0x040002B5 RID: 693
        private ComboBox cobnhanvien;

        // Token: 0x040002B6 RID: 694
        private ComboBox cobtruong;

        // Token: 0x040002B7 RID: 695
        private ComboBox txtlydo;

        // Token: 0x040002B8 RID: 696
        private Button button3;

        // Token: 0x040002B9 RID: 697
        private SaveFileDialog saveFileDialog1;

        // Token: 0x040002BA RID: 698
        private Button bttim;

        // Token: 0x040002BB RID: 699
        private TextBox txttenkhachhang;

        // Token: 0x040002BC RID: 700
        private TextBox txtmakhachhang;

        // Token: 0x040002BD RID: 701
        private Button ptin;

        // Token: 0x040002BE RID: 702
        private PrintPreviewDialog printPreviewDialog1;

        // Token: 0x040002BF RID: 703
        private DataGridView dgvtimkhachhang;

        // Token: 0x040002C0 RID: 704
        private TextBox textBox4;

        // Token: 0x040002C1 RID: 705
        private TextBox textBox3;

        // Token: 0x040002C2 RID: 706
        private TextBox lbkhachhang;

        // Token: 0x040002C3 RID: 707
        private TextBox textBox6;

        // Token: 0x040002C4 RID: 708
        private TextBox textBox5;

        // Token: 0x040002C5 RID: 709
        private TextBox textBox9;

        // Token: 0x040002C6 RID: 710
        private TextBox textBox8;

        // Token: 0x040002C7 RID: 711
        private TextBox textBox7;

        // Token: 0x040002C8 RID: 712
        private TextBox textBox10;

        // Token: 0x040002C9 RID: 713
        private TextBox textBox11;

        // Token: 0x040002CA RID: 714
        private TextBox textBox13;

        // Token: 0x040002CB RID: 715
        private TextBox textBox12;

        // Token: 0x040002CC RID: 716
        private TextBox textBox14;

        // Token: 0x040002CD RID: 717
        private TextBox txttimkiem;

        // Token: 0x040002CE RID: 718
        private TextBox textBox15;

        // Token: 0x040002CF RID: 719
        private TextBox txtconno;

        // Token: 0x040002D0 RID: 720
        private TextBox txtno;

        // Token: 0x040002D1 RID: 721
        private TextBox txtnhaphang;

        // Token: 0x040002D2 RID: 722
        private TextBox textBox17;

        // Token: 0x040002D3 RID: 723
        private TextBox txttiencu;

        // Token: 0x040002D4 RID: 724
        private TextBox tiencu;

        // Token: 0x040002D5 RID: 725
        private Button button4;

        // Token: 0x040002D6 RID: 726
        private Button button5;

        // Token: 0x040002D7 RID: 727
        private DataGridViewTextBoxColumn STT;

        // Token: 0x040002D8 RID: 728
        private DataGridViewTextBoxColumn Loaiphieu;

        // Token: 0x040002D9 RID: 729
        private DataGridViewTextBoxColumn SoTien;

        // Token: 0x040002DA RID: 730
        private DataGridViewTextBoxColumn tienchi;

        // Token: 0x040002DB RID: 731
        private DataGridViewTextBoxColumn TENDONVI;

        // Token: 0x040002DC RID: 732
        private DataGridViewTextBoxColumn Lydo;

        // Token: 0x040002DD RID: 733
        private DataGridViewTextBoxColumn Ngay;

        // Token: 0x040002DE RID: 734
        private DataGridViewTextBoxColumn Chungtu;

        // Token: 0x040002DF RID: 735
        private DataGridViewTextBoxColumn Manv;

        // Token: 0x040002E0 RID: 736
        private DataGridViewTextBoxColumn ghichu;

        // Token: 0x040002E1 RID: 737
        private DataGridViewTextBoxColumn mathuchi;

        // Token: 0x040002E2 RID: 738
        private DataGridViewTextBoxColumn MAKH;

        // Token: 0x040002E3 RID: 739
        private DataGridViewTextBoxColumn macongty;

        // Token: 0x040002E4 RID: 740
        private DataGridViewTextBoxColumn chiphi;

        // Token: 0x040002E5 RID: 741
        private TextBox txtchenhech;

        // Token: 0x040002E6 RID: 742
        private TextBox textBox20;

        // Token: 0x040002E7 RID: 743
        private TextBox txttienmat;

        // Token: 0x040002E8 RID: 744
        private TextBox textBox18;

        // Token: 0x040002E9 RID: 745
        private DataGridViewButtonColumn CHON;

        // Token: 0x040002EA RID: 746
        private DataGridViewTextBoxColumn makhtimkiem;

        // Token: 0x040002EB RID: 747
        private DataGridViewTextBoxColumn tenkh;

        // Token: 0x040002EC RID: 748
        private DataGridViewTextBoxColumn DIACHI;

        // Token: 0x040002ED RID: 749
        private Button button2;

        // Token: 0x040002EE RID: 750
        private PrintDocument print_congno;

        // Token: 0x040002EF RID: 751
        private CheckBox checkBox1;

        // Token: 0x040002F0 RID: 752
        private PictureBox pt_Image;

        // Token: 0x040002F1 RID: 753
        private PrintDocument K80;
    }
}
