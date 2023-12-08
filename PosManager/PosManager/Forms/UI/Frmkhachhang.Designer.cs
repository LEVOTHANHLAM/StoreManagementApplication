using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmkhachhang
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Frmkhachhang));
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            this.gbthongtin = new GroupBox();
            this.cobgia = new ComboBox();
            this.checkBox1 = new CheckBox();
            this.dtnamsinh = new MaskedTextBox();
            this.txtsd = new TextBox();
            this.comboBox1 = new ComboBox();
            this.button4 = new Button();
            this.txtchanhxe = new TextBox();
            this.dtngaycap = new DateTimePicker();
            this.txtsotaikhoan = new TextBox();
            this.label6 = new Label();
            this.txtdienthoai = new TextBox();
            this.label5 = new Label();
            this.txtdiachi = new TextBox();
            this.label3 = new Label();
            this.txtghichu = new TextBox();
            this.txttendonvi = new TextBox();
            this.label2 = new Label();
            this.txtemail = new TextBox();
            this.txthoten = new TextBox();
            this.label12 = new Label();
            this.label1 = new Label();
            this.label8 = new Label();
            this.txtcmnd = new TextBox();
            this.label10 = new Label();
            this.txtnoicap = new TextBox();
            this.label11 = new Label();
            this.label9 = new Label();
            this.txtmasothue = new TextBox();
            this.label16 = new Label();
            this.label14 = new Label();
            this.label7 = new Label();
            this.cobkh = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.button5 = new Button();
            this.button3 = new Button();
            this.bthuy = new Button();
            this.button2 = new Button();
            this.txttimkiem = new TextBox();
            this.button1 = new Button();
            this.btboqua = new Button();
            this.btthem = new Button();
            this.btxoa = new Button();
            this.btluu = new Button();
            this.textBox1 = new TextBox();
            this.groupBox3 = new GroupBox();
            this.dgvkhachhang = new DataGridView();
            this.STT = new DataGridViewTextBoxColumn();
            this.MASOTHUE = new DataGridViewTextBoxColumn();
            this.HOTEN = new DataGridViewTextBoxColumn();
            this.TDV = new DataGridViewTextBoxColumn();
            this.DC = new DataGridViewTextBoxColumn();
            this.SDT = new DataGridViewTextBoxColumn();
            this.SOTAIKHOAN = new DataGridViewTextBoxColumn();
            this.NAMSINH = new DataGridViewTextBoxColumn();
            this.GIOITINH = new DataGridViewTextBoxColumn();
            this.CMND = new DataGridViewTextBoxColumn();
            this.NGAYCAP = new DataGridViewTextBoxColumn();
            this.NOICAP = new DataGridViewTextBoxColumn();
            this.EMAIL = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.SOTIEN = new DataGridViewTextBoxColumn();
            this.openFileDialog1 = new OpenFileDialog();
            this.gbthongtin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize)this.dgvkhachhang).BeginInit();
            base.SuspendLayout();
            this.gbthongtin.Controls.Add(this.cobgia);
            this.gbthongtin.Controls.Add(this.checkBox1);
            this.gbthongtin.Controls.Add(this.dtnamsinh);
            this.gbthongtin.Controls.Add(this.txtsd);
            this.gbthongtin.Controls.Add(this.comboBox1);
            this.gbthongtin.Controls.Add(this.button4);
            this.gbthongtin.Controls.Add(this.txtchanhxe);
            this.gbthongtin.Controls.Add(this.dtngaycap);
            this.gbthongtin.Controls.Add(this.txtsotaikhoan);
            this.gbthongtin.Controls.Add(this.label6);
            this.gbthongtin.Controls.Add(this.txtdienthoai);
            this.gbthongtin.Controls.Add(this.label5);
            this.gbthongtin.Controls.Add(this.txtdiachi);
            this.gbthongtin.Controls.Add(this.label3);
            this.gbthongtin.Controls.Add(this.txtghichu);
            this.gbthongtin.Controls.Add(this.txttendonvi);
            this.gbthongtin.Controls.Add(this.label2);
            this.gbthongtin.Controls.Add(this.txtemail);
            this.gbthongtin.Controls.Add(this.txthoten);
            this.gbthongtin.Controls.Add(this.label12);
            this.gbthongtin.Controls.Add(this.label1);
            this.gbthongtin.Controls.Add(this.label8);
            this.gbthongtin.Controls.Add(this.txtcmnd);
            this.gbthongtin.Controls.Add(this.label10);
            this.gbthongtin.Controls.Add(this.txtnoicap);
            this.gbthongtin.Controls.Add(this.label11);
            this.gbthongtin.Controls.Add(this.label9);
            this.gbthongtin.Controls.Add(this.txtmasothue);
            this.gbthongtin.Controls.Add(this.label16);
            this.gbthongtin.Controls.Add(this.label14);
            this.gbthongtin.Controls.Add(this.label7);
            this.gbthongtin.Enabled = false;
            this.gbthongtin.Location = new Point(3, -8);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new Size(993, 157);
            this.gbthongtin.TabIndex = 0;
            this.gbthongtin.TabStop = false;
            this.cobgia.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobgia.FlatStyle = FlatStyle.Popup;
            this.cobgia.FormattingEnabled = true;
            this.cobgia.Location = new Point(768, 121);
            this.cobgia.Name = "cobgia";
            this.cobgia.Size = new Size(226, 27);
            this.cobgia.TabIndex = 6;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new Font("Times New Roman", 12f);
            this.checkBox1.Location = new Point(709, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(123, 42);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Khách hàng\r\nkhông giao dịch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += this.checkBox1_MouseClick;
            this.dtnamsinh.Font = new Font("Times New Roman", 18f);
            this.dtnamsinh.Location = new Point(96, 121);
            this.dtnamsinh.Mask = "00/00/0000";
            this.dtnamsinh.Name = "dtnamsinh";
            this.dtnamsinh.Size = new Size(151, 35);
            this.dtnamsinh.TabIndex = 20;
            this.dtnamsinh.ValidatingType = typeof(DateTime);
            this.dtnamsinh.Enter += this.dtnamsinh_Enter;
            this.dtnamsinh.Leave += this.dtnamsinh_Leave;
            this.txtsd.BackColor = Color.White;
            this.txtsd.BorderStyle = BorderStyle.None;
            this.txtsd.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtsd.ForeColor = Color.Red;
            this.txtsd.Location = new Point(910, 11);
            this.txtsd.Name = "txtsd";
            this.txtsd.ReadOnly = true;
            this.txtsd.Size = new Size(81, 25);
            this.txtsd.TabIndex = 21;
            this.txtsd.Tag = "0";
            this.txtsd.Text = "0";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(254, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(245, 27);
            this.comboBox1.TabIndex = 19;
            this.button4.BackColor = Color.Blue;
            this.button4.FlatAppearance.BorderColor = Color.Blue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.ForeColor = Color.White;
            this.button4.Location = new Point(505, 11);
            this.button4.Name = "button4";
            this.button4.Size = new Size(198, 27);
            this.button4.TabIndex = 18;
            this.button4.Text = "Thêm nhóm đơn vị";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += this.button4_Click;
            this.txtchanhxe.Location = new Point(765, 94);
            this.txtchanhxe.Name = "txtchanhxe";
            this.txtchanhxe.Size = new Size(228, 26);
            this.txtchanhxe.TabIndex = 16;
            this.dtngaycap.Format = DateTimePickerFormat.Custom;
            this.dtngaycap.Location = new Point(573, 69);
            this.dtngaycap.Name = "dtngaycap";
            this.dtngaycap.Size = new Size(130, 26);
            this.dtngaycap.TabIndex = 9;
            this.txtsotaikhoan.Location = new Point(573, 125);
            this.txtsotaikhoan.Name = "txtsotaikhoan";
            this.txtsotaikhoan.Size = new Size(130, 26);
            this.txtsotaikhoan.TabIndex = 5;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(501, 128);
            this.label6.Name = "label6";
            this.label6.Size = new Size(50, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số Tk:";
            this.txtdienthoai.Location = new Point(96, 94);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new Size(403, 26);
            this.txtdienthoai.TabIndex = 4;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(15, 102);
            this.label5.Name = "label5";
            this.label5.Size = new Size(78, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Điện Thoại:";
            this.txtdiachi.Location = new Point(96, 67);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new Size(403, 26);
            this.txtdiachi.TabIndex = 3;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new Size(58, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Địa Chỉ:";
            this.txtghichu.Font = new Font("Times New Roman", 7f);
            this.txtghichu.Location = new Point(783, 99);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(26, 18);
            this.txtghichu.TabIndex = 12;
            this.txttendonvi.Location = new Point(447, 145);
            this.txttendonvi.Name = "txttendonvi";
            this.txttendonvi.Size = new Size(403, 26);
            this.txttendonvi.TabIndex = 2;
            this.txttendonvi.Visible = false;
            this.txttendonvi.Leave += this.txttendonvi_Leave;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(366, 158);
            this.label2.Name = "label2";
            this.label2.Size = new Size(83, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Đơn Vị:";
            this.label2.Visible = false;
            this.txtemail.Location = new Point(765, 65);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new Size(228, 26);
            this.txtemail.TabIndex = 11;
            this.txthoten.Location = new Point(96, 40);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new Size(403, 26);
            this.txthoten.TabIndex = 1;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(707, 68);
            this.label12.Name = "label12";
            this.label12.Size = new Size(45, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Email:";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên:";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(15, 131);
            this.label8.Name = "label8";
            this.label8.Size = new Size(75, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày Sinh:";
            this.txtcmnd.Location = new Point(573, 41);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new Size(130, 26);
            this.txtcmnd.TabIndex = 8;
            this.label10.AutoSize = true;
            this.label10.Location = new Point(501, 43);
            this.label10.Name = "label10";
            this.label10.Size = new Size(60, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "CMND:";
            this.txtnoicap.Location = new Point(573, 97);
            this.txtnoicap.Name = "txtnoicap";
            this.txtnoicap.Size = new Size(130, 26);
            this.txtnoicap.TabIndex = 10;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(501, 100);
            this.label11.Name = "label11";
            this.label11.Size = new Size(50, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Nhóm:";
            this.label9.AutoSize = true;
            this.label9.Location = new Point(501, 72);
            this.label9.Name = "label9";
            this.label9.Size = new Size(75, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Cấp:";
            this.txtmasothue.Location = new Point(96, 12);
            this.txtmasothue.Name = "txtmasothue";
            this.txtmasothue.Size = new Size(151, 26);
            this.txtmasothue.TabIndex = 0;
            this.txtmasothue.Enter += this.txtmasothue_Enter;
            this.txtmasothue.KeyDown += this.txtmasothue_KeyDown;
            this.txtmasothue.Leave += this.txtmasothue_Leave;
            this.label16.AutoSize = true;
            this.label16.Location = new Point(18, 15);
            this.label16.Name = "label16";
            this.label16.Size = new Size(33, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Mã:";
            this.label14.AutoSize = true;
            this.label14.Location = new Point(700, 98);
            this.label14.Name = "label14";
            this.label14.Size = new Size(69, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chành xe:";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(707, 127);
            this.label7.Name = "label7";
            this.label7.Size = new Size(59, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giá bán:";
            this.cobkh.BackColor = Color.WhiteSmoke;
            this.cobkh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobkh.FlatStyle = FlatStyle.Flat;
            this.cobkh.FormattingEnabled = true;
            this.cobkh.Items.AddRange(new object[]
            {
                "KHÁCH HÀNG",
                "NHÀ CUNG CẤP"
            });
            this.cobkh.Location = new Point(161, 22);
            this.cobkh.Name = "cobkh";
            this.cobkh.Size = new Size(211, 27);
            this.cobkh.TabIndex = 17;
            this.cobkh.SelectedIndexChanged += this.cobkh_SelectedIndexChanged;
            this.groupBox2.Controls.Add(this.cobkh);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.bthuy);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btboqua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btluu);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new Point(3, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(1260, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.button5.BackColor = Color.Blue;
            this.button5.BackgroundImageLayout = ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Font = new Font("Times New Roman", 12f);
            this.button5.ForeColor = Color.White;
            this.button5.Location = new Point(910, 13);
            this.button5.Name = "button5";
            this.button5.Size = new Size(81, 48);
            this.button5.TabIndex = 20;
            this.button5.Text = "In Excel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += this.button5_Click;
            this.button3.BackColor = Color.Blue;
            this.button3.BackgroundImageLayout = ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Font = new Font("Times New Roman", 12f);
            this.button3.ForeColor = Color.White;
            this.button3.Location = new Point(812, 13);
            this.button3.Name = "button3";
            this.button3.Size = new Size(95, 48);
            this.button3.TabIndex = 19;
            this.button3.Text = "Nhập Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.bthuy.BackColor = Color.Blue;
            this.bthuy.BackgroundImageLayout = ImageLayout.Stretch;
            this.bthuy.Enabled = false;
            this.bthuy.FlatAppearance.BorderColor = Color.Silver;
            this.bthuy.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.bthuy.FlatStyle = FlatStyle.Flat;
            this.bthuy.Font = new Font("Times New Roman", 15f);
            this.bthuy.ForeColor = Color.White;
            this.bthuy.Location = new Point(730, 13);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new Size(79, 48);
            this.bthuy.TabIndex = 18;
            this.bthuy.Text = "Bỏ qua";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += this.bthuy_Click;
            this.button2.BackColor = Color.Blue;
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 15f);
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(447, 14);
            this.button2.Name = "button2";
            this.button2.Size = new Size(57, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.txttimkiem.BackColor = Color.White;
            this.txttimkiem.BorderStyle = BorderStyle.None;
            this.txttimkiem.Font = new Font("Times New Roman", 12f, FontStyle.Italic);
            this.txttimkiem.ForeColor = Color.Red;
            this.txttimkiem.Location = new Point(9, 27);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(158, 19);
            this.txttimkiem.TabIndex = 15;
            this.txttimkiem.Tag = "Tìm kiếm - Ctr + F";
            this.txttimkiem.Text = "Tìm kiếm - Ctr + F";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.KeyDown += this.txttimkiem_KeyDown;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.button1.BackColor = Color.Red;
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 15f);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(603, 13);
            this.button1.Name = "button1";
            this.button1.Size = new Size(61, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.btboqua.BackColor = Color.White;
            this.btboqua.BackgroundImage = (Image)componentResourceManager.GetObject("btboqua.BackgroundImage");
            this.btboqua.BackgroundImageLayout = ImageLayout.Zoom;
            this.btboqua.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btboqua.ForeColor = Color.Lime;
            this.btboqua.Location = new Point(1178, 11);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new Size(32, 48);
            this.btboqua.TabIndex = 13;
            this.btboqua.UseVisualStyleBackColor = false;
            this.btboqua.Visible = false;
            this.btboqua.Click += this.btboqua_Click;
            this.btthem.BackColor = Color.Blue;
            this.btthem.BackgroundImageLayout = ImageLayout.Stretch;
            this.btthem.FlatAppearance.BorderColor = Color.Silver;
            this.btthem.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btthem.FlatStyle = FlatStyle.Flat;
            this.btthem.Font = new Font("Times New Roman", 15f);
            this.btthem.ForeColor = Color.White;
            this.btthem.Location = new Point(378, 14);
            this.btthem.Name = "btthem";
            this.btthem.Size = new Size(67, 48);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += this.btthem_Click;
            this.btxoa.BackColor = Color.Blue;
            this.btxoa.BackgroundImageLayout = ImageLayout.Stretch;
            this.btxoa.FlatAppearance.BorderColor = Color.Silver;
            this.btxoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btxoa.FlatStyle = FlatStyle.Flat;
            this.btxoa.Font = new Font("Times New Roman", 15f);
            this.btxoa.ForeColor = Color.White;
            this.btxoa.Location = new Point(667, 13);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new Size(61, 48);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += this.btxoa_Click;
            this.btluu.BackColor = Color.Red;
            this.btluu.BackgroundImageLayout = ImageLayout.Stretch;
            this.btluu.Enabled = false;
            this.btluu.FlatAppearance.BorderColor = Color.Silver;
            this.btluu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            this.btluu.FlatStyle = FlatStyle.Flat;
            this.btluu.Font = new Font("Times New Roman", 15f);
            this.btluu.ForeColor = Color.White;
            this.btluu.Location = new Point(506, 14);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(95, 48);
            this.btluu.TabIndex = 0;
            this.btluu.Text = "F1 - Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += this.btluu_Click;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Font = new Font("Times New Roman", 14f, FontStyle.Italic);
            this.textBox1.ForeColor = Color.Red;
            this.textBox1.Location = new Point(3, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(374, 49);
            this.textBox1.TabIndex = 17;
            this.textBox1.Tag = "Tìm kiếm - Ctr + F";
            this.textBox1.Enter += this.textBox1_Enter;
            this.groupBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox3.Controls.Add(this.dgvkhachhang);
            this.groupBox3.Location = new Point(3, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(1000, 461);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AllowUserToDeleteRows = false;
            this.dgvkhachhang.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvkhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.MASOTHUE,
                this.HOTEN,
                this.TDV,
                this.DC,
                this.SDT,
                this.SOTAIKHOAN,
                this.NAMSINH,
                this.GIOITINH,
                this.CMND,
                this.NGAYCAP,
                this.NOICAP,
                this.EMAIL,
                this.GHICHU,
                this.SOTIEN
            });
            this.dgvkhachhang.Dock = DockStyle.Fill;
            this.dgvkhachhang.Location = new Point(3, 22);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.RowHeadersWidth = 4;
            this.dgvkhachhang.Size = new Size(994, 436);
            this.dgvkhachhang.TabIndex = 0;
            this.dgvkhachhang.KeyDown += this.dgvkhachhang_KeyDown;
            this.dgvkhachhang.MouseClick += this.dgvkhachhang_MouseClick;
            this.dgvkhachhang.MouseDoubleClick += this.dgvkhachhang_MouseDoubleClick;
            this.STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 40;
            this.MASOTHUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MASOTHUE.DataPropertyName = "MAKHACHHANG";
            this.MASOTHUE.HeaderText = "Mã kh";
            this.MASOTHUE.Name = "MASOTHUE";
            this.MASOTHUE.ReadOnly = true;
            this.MASOTHUE.Width = 120;
            this.HOTEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HOTEN.DataPropertyName = "TENKHACHHANG";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.HOTEN.DefaultCellStyle = dataGridViewCellStyle3;
            this.HOTEN.HeaderText = "Tên khách hàng";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 250;
            this.TDV.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TDV.DataPropertyName = "TENDONVI";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.TDV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TDV.HeaderText = "Tên công ty";
            this.TDV.Name = "TDV";
            this.TDV.ReadOnly = true;
            this.TDV.Visible = false;
            this.TDV.Width = 300;
            this.DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DC.DataPropertyName = "DIACHI";
            this.DC.HeaderText = "Địa chỉ";
            this.DC.Name = "DC";
            this.DC.ReadOnly = true;
            this.DC.Width = 200;
            this.SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SOTAIKHOAN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTAIKHOAN.DataPropertyName = "SOTAIKHOAN";
            this.SOTAIKHOAN.HeaderText = "Số tài khoản";
            this.SOTAIKHOAN.Name = "SOTAIKHOAN";
            this.SOTAIKHOAN.ReadOnly = true;
            this.SOTAIKHOAN.Visible = false;
            this.NAMSINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NAMSINH.DataPropertyName = "NAMSINH";
            this.NAMSINH.HeaderText = "Năm sinh";
            this.NAMSINH.Name = "NAMSINH";
            this.NAMSINH.ReadOnly = true;
            this.GIOITINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Mã giá";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            this.GIOITINH.Visible = false;
            this.CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Visible = false;
            this.NGAYCAP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NGAYCAP.DataPropertyName = "NGAYCAP";
            this.NGAYCAP.HeaderText = "Ngày cấp";
            this.NGAYCAP.Name = "NGAYCAP";
            this.NGAYCAP.ReadOnly = true;
            this.NGAYCAP.Visible = false;
            this.NOICAP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NOICAP.DataPropertyName = "NOICAP";
            this.NOICAP.HeaderText = "Nơi cấp";
            this.NOICAP.Name = "NOICAP";
            this.NOICAP.ReadOnly = true;
            this.NOICAP.Visible = false;
            this.EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Visible = false;
            this.SOTIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTIEN.DataPropertyName = "sotien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.SOTIEN.DefaultCellStyle = dataGridViewCellStyle5;
            this.SOTIEN.HeaderText = "Số tiền";
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.ReadOnly = true;
            this.SOTIEN.Width = 80;
            this.openFileDialog1.FileName = "openFileDialog1";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.PowderBlue;
            base.ClientSize = new Size(1008, 640);
            base.Controls.Add(this.gbthongtin);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox3);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.FromArgb(0, 0, 192);
            //base.KeyPreview = true;
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "Frmkhachhang";
         //   base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN KHÁCH HÀNG - NHÀ CUNG CẤP";
            base.Load += this.Frmkhachhang_Load;
            base.KeyDown += this.Frmkhachhang_KeyDown;
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize)this.dgvkhachhang).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000F6A RID: 3946
        private GroupBox gbthongtin;

        // Token: 0x04000F6B RID: 3947
        private TextBox txtdiachi;

        // Token: 0x04000F6C RID: 3948
        private Label label3;

        // Token: 0x04000F6D RID: 3949
        private TextBox txttendonvi;

        // Token: 0x04000F6E RID: 3950
        private Label label2;

        // Token: 0x04000F6F RID: 3951
        private TextBox txthoten;

        // Token: 0x04000F70 RID: 3952
        private Label label1;

        // Token: 0x04000F71 RID: 3953
        private TextBox txtmasothue;

        // Token: 0x04000F72 RID: 3954
        private Label label16;

        // Token: 0x04000F73 RID: 3955
        private TextBox txtsotaikhoan;

        // Token: 0x04000F74 RID: 3956
        private Label label6;

        // Token: 0x04000F75 RID: 3957
        private TextBox txtdienthoai;

        // Token: 0x04000F76 RID: 3958
        private Label label5;

        // Token: 0x04000F77 RID: 3959
        private DateTimePicker dtngaycap;

        // Token: 0x04000F78 RID: 3960
        private ComboBox cobgia;

        // Token: 0x04000F79 RID: 3961
        private TextBox txtghichu;

        // Token: 0x04000F7A RID: 3962
        private TextBox txtemail;

        // Token: 0x04000F7B RID: 3963
        private Label label7;

        // Token: 0x04000F7C RID: 3964
        private Label label12;

        // Token: 0x04000F7D RID: 3965
        private Label label8;

        // Token: 0x04000F7E RID: 3966
        private TextBox txtcmnd;

        // Token: 0x04000F7F RID: 3967
        private Label label10;

        // Token: 0x04000F80 RID: 3968
        private TextBox txtnoicap;

        // Token: 0x04000F81 RID: 3969
        private Label label11;

        // Token: 0x04000F82 RID: 3970
        private Label label9;

        // Token: 0x04000F83 RID: 3971
        private GroupBox groupBox2;

        // Token: 0x04000F84 RID: 3972
        private Button btboqua;

        // Token: 0x04000F85 RID: 3973
        private Button btthem;

        // Token: 0x04000F86 RID: 3974
        private Button btxoa;

        // Token: 0x04000F87 RID: 3975
        private Button btluu;

        // Token: 0x04000F88 RID: 3976
        private GroupBox groupBox3;

        // Token: 0x04000F89 RID: 3977
        private DataGridView dgvkhachhang;

        // Token: 0x04000F8A RID: 3978
        private Button button1;

        // Token: 0x04000F8B RID: 3979
        private TextBox txttimkiem;

        // Token: 0x04000F8C RID: 3980
        private TextBox txtchanhxe;

        // Token: 0x04000F8D RID: 3981
        private Label label14;

        // Token: 0x04000F8E RID: 3982
        private ComboBox cobkh;

        // Token: 0x04000F8F RID: 3983
        private Button button2;

        // Token: 0x04000F90 RID: 3984
        private TextBox textBox1;

        // Token: 0x04000F91 RID: 3985
        private Button bthuy;

        // Token: 0x04000F92 RID: 3986
        private Button button3;

        // Token: 0x04000F93 RID: 3987
        private OpenFileDialog openFileDialog1;

        // Token: 0x04000F94 RID: 3988
        private Button button4;

        // Token: 0x04000F95 RID: 3989
        private ComboBox comboBox1;

        // Token: 0x04000F96 RID: 3990
        private Button button5;

        // Token: 0x04000F97 RID: 3991
        private MaskedTextBox dtnamsinh;

        // Token: 0x04000F98 RID: 3992
        private TextBox txtsd;

        // Token: 0x04000F99 RID: 3993
        private CheckBox checkBox1;

        // Token: 0x04000F9A RID: 3994
        private DataGridViewTextBoxColumn STT;

        // Token: 0x04000F9B RID: 3995
        private DataGridViewTextBoxColumn MASOTHUE;

        // Token: 0x04000F9C RID: 3996
        private DataGridViewTextBoxColumn HOTEN;

        // Token: 0x04000F9D RID: 3997
        private DataGridViewTextBoxColumn TDV;

        // Token: 0x04000F9E RID: 3998
        private DataGridViewTextBoxColumn DC;

        // Token: 0x04000F9F RID: 3999
        private DataGridViewTextBoxColumn SDT;

        // Token: 0x04000FA0 RID: 4000
        private DataGridViewTextBoxColumn SOTAIKHOAN;

        // Token: 0x04000FA1 RID: 4001
        private DataGridViewTextBoxColumn NAMSINH;

        // Token: 0x04000FA2 RID: 4002
        private DataGridViewTextBoxColumn GIOITINH;

        // Token: 0x04000FA3 RID: 4003
        private DataGridViewTextBoxColumn CMND;

        // Token: 0x04000FA4 RID: 4004
        private DataGridViewTextBoxColumn NGAYCAP;

        // Token: 0x04000FA5 RID: 4005
        private DataGridViewTextBoxColumn NOICAP;

        // Token: 0x04000FA6 RID: 4006
        private DataGridViewTextBoxColumn EMAIL;

        // Token: 0x04000FA7 RID: 4007
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x04000FA8 RID: 4008
        private DataGridViewTextBoxColumn SOTIEN;
    }
}
