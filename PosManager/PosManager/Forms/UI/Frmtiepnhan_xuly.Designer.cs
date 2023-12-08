using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmtiepnhan_xuly
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
            this.txttenkhachhang = new TextBox();
            this.txtsdt = new TextBox();
            this.txtnoidung = new TextBox();
            this.txtsdt_nhanviennhan = new TextBox();
            this.txtnhanvien_nhan = new TextBox();
            this.txtma = new TextBox();
            this.txtma_nhanvien_nhan = new TextBox();
            this.txtma_nhanvienxuly = new TextBox();
            this.txtsdt_nhanvienxuly = new TextBox();
            this.txtnhanvien_xuly = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.txttimkiem = new TextBox();
            this.dataGridView1 = new DataGridView();
            this.button6 = new Button();
            this.textBox1 = new TextBox();
            this.button7 = new Button();
            this.textBox2 = new TextBox();
            this.txt_songay = new TextBox();
            this.tenkhachhang = new DataGridViewTextBoxColumn();
            this.nhanviennhan = new DataGridViewTextBoxColumn();
            this.ngaynhan = new DataGridViewTextBoxColumn();
            this.Noidungnhan = new DataGridViewTextBoxColumn();
            this.nhanvienxuly = new DataGridViewTextBoxColumn();
            this.ngayxuly = new DataGridViewTextBoxColumn();
            this.noidungxuly = new DataGridViewTextBoxColumn();
            this.Tinhtrang = new DataGridViewCheckBoxColumn();
            this.gui_nv = new DataGridViewCheckBoxColumn();
            this.gui_kh = new DataGridViewCheckBoxColumn();
            this.MA = new DataGridViewTextBoxColumn();
            this.sdt_kh = new DataGridViewTextBoxColumn();
            this.sdtvn_nhan = new DataGridViewTextBoxColumn();
            this.sdt_nvxl = new DataGridViewTextBoxColumn();
            this.makhachhang = new DataGridViewTextBoxColumn();
            this.tennvn = new DataGridViewTextBoxColumn();
            this.ten_nvxl = new DataGridViewTextBoxColumn();
            this.songay = new DataGridViewTextBoxColumn();
            this.hanxuly = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.txttenkhachhang.BackColor = Color.White;
            this.txttenkhachhang.Font = new Font("Times New Roman", 14f);
            this.txttenkhachhang.Location = new Point(4, 3);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.ReadOnly = true;
            this.txttenkhachhang.Size = new Size(322, 29);
            this.txttenkhachhang.TabIndex = 0;
            this.txttenkhachhang.Tag = "Tên khách hàng";
            this.txttenkhachhang.Text = "Tên khách hàng";
            this.txttenkhachhang.MouseDoubleClick += this.txttenkhachhang_MouseDoubleClick;
            this.txtsdt.BackColor = Color.White;
            this.txtsdt.Font = new Font("Times New Roman", 14f);
            this.txtsdt.Location = new Point(325, 3);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.ReadOnly = true;
            this.txtsdt.Size = new Size(133, 29);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.Tag = "Số điện thoại";
            this.txtsdt.Text = "Số điện thoại";
            this.txtnoidung.BackColor = Color.White;
            this.txtnoidung.Font = new Font("Times New Roman", 14f);
            this.txtnoidung.Location = new Point(461, 3);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new Size(468, 29);
            this.txtnoidung.TabIndex = 2;
            this.txtnoidung.Tag = "Nội dung tiếp nhận";
            this.txtnoidung.Text = "Nội dung tiếp nhận";
            this.txtnoidung.Enter += this.txtnoidung_Enter;
            this.txtnoidung.Leave += this.txtnoidung_Leave;
            this.txtsdt_nhanviennhan.BackColor = Color.White;
            this.txtsdt_nhanviennhan.Font = new Font("Times New Roman", 14f);
            this.txtsdt_nhanviennhan.Location = new Point(325, 33);
            this.txtsdt_nhanviennhan.Name = "txtsdt_nhanviennhan";
            this.txtsdt_nhanviennhan.ReadOnly = true;
            this.txtsdt_nhanviennhan.Size = new Size(133, 29);
            this.txtsdt_nhanviennhan.TabIndex = 4;
            this.txtsdt_nhanviennhan.Tag = "Số điện thoại";
            this.txtsdt_nhanviennhan.Text = "Số điện thoại";
            this.txtnhanvien_nhan.BackColor = Color.White;
            this.txtnhanvien_nhan.Font = new Font("Times New Roman", 14f);
            this.txtnhanvien_nhan.Location = new Point(4, 33);
            this.txtnhanvien_nhan.Name = "txtnhanvien_nhan";
            this.txtnhanvien_nhan.ReadOnly = true;
            this.txtnhanvien_nhan.Size = new Size(322, 29);
            this.txtnhanvien_nhan.TabIndex = 3;
            this.txtnhanvien_nhan.Tag = "Nhân viên tiếp nhận";
            this.txtnhanvien_nhan.Text = "Nhân viên tiếp nhận";
            this.txtnhanvien_nhan.MouseDoubleClick += this.txtnhanvien_nhan_MouseDoubleClick;
            this.txtma.BackColor = Color.White;
            this.txtma.Font = new Font("Times New Roman", 14f);
            this.txtma.Location = new Point(143, 3);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new Size(180, 29);
            this.txtma.TabIndex = 6;
            this.txtma.Text = "mã";
            this.txtma_nhanvien_nhan.BackColor = Color.White;
            this.txtma_nhanvien_nhan.Font = new Font("Times New Roman", 14f);
            this.txtma_nhanvien_nhan.Location = new Point(143, 33);
            this.txtma_nhanvien_nhan.Name = "txtma_nhanvien_nhan";
            this.txtma_nhanvien_nhan.ReadOnly = true;
            this.txtma_nhanvien_nhan.Size = new Size(180, 29);
            this.txtma_nhanvien_nhan.TabIndex = 7;
            this.txtma_nhanvien_nhan.Text = "mã";
            this.txtma_nhanvienxuly.BackColor = Color.White;
            this.txtma_nhanvienxuly.Font = new Font("Times New Roman", 14f);
            this.txtma_nhanvienxuly.Location = new Point(615, 33);
            this.txtma_nhanvienxuly.Name = "txtma_nhanvienxuly";
            this.txtma_nhanvienxuly.ReadOnly = true;
            this.txtma_nhanvienxuly.Size = new Size(122, 29);
            this.txtma_nhanvienxuly.TabIndex = 10;
            this.txtma_nhanvienxuly.Text = "mã";
            this.txtsdt_nhanvienxuly.BackColor = Color.White;
            this.txtsdt_nhanvienxuly.Font = new Font("Times New Roman", 14f);
            this.txtsdt_nhanvienxuly.Location = new Point(769, 33);
            this.txtsdt_nhanvienxuly.Name = "txtsdt_nhanvienxuly";
            this.txtsdt_nhanvienxuly.ReadOnly = true;
            this.txtsdt_nhanvienxuly.Size = new Size(160, 29);
            this.txtsdt_nhanvienxuly.TabIndex = 9;
            this.txtsdt_nhanvienxuly.Tag = "Số điện thoại";
            this.txtsdt_nhanvienxuly.Text = "Số điện thoại";
            this.txtnhanvien_xuly.BackColor = Color.White;
            this.txtnhanvien_xuly.Font = new Font("Times New Roman", 14f);
            this.txtnhanvien_xuly.Location = new Point(461, 33);
            this.txtnhanvien_xuly.Name = "txtnhanvien_xuly";
            this.txtnhanvien_xuly.ReadOnly = true;
            this.txtnhanvien_xuly.Size = new Size(311, 29);
            this.txtnhanvien_xuly.TabIndex = 8;
            this.txtnhanvien_xuly.Tag = "Nhân viên xử lý";
            this.txtnhanvien_xuly.Text = "Nhân viên xử lý";
            this.txtnhanvien_xuly.MouseDoubleClick += this.txtnhanvien_xuly_MouseDoubleClick;
            this.button1.Font = new Font("Times New Roman", 14f);
            this.button1.Location = new Point(930, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(77, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.FlatAppearance.BorderColor = Color.Gray;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(61, 109);
            this.button2.Name = "button2";
            this.button2.Size = new Size(123, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Chờ xử lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button3.FlatAppearance.BorderColor = Color.Gray;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(192, 109);
            this.button3.Name = "button3";
            this.button3.Size = new Size(123, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Đã xử lý";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button4.FlatAppearance.BorderColor = Color.Gray;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(461, 109);
            this.button4.Name = "button4";
            this.button4.Size = new Size(123, 48);
            this.button4.TabIndex = 16;
            this.button4.Text = "Gửi tin nhắn cho nhân viên xử lý";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.button4_Click;
            this.button5.FlatAppearance.BorderColor = Color.Gray;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.Location = new Point(326, 109);
            this.button5.Name = "button5";
            this.button5.Size = new Size(123, 48);
            this.button5.TabIndex = 15;
            this.button5.Text = "Gửi tin nhắn cho khách hàng";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.txttimkiem.BackColor = Color.White;
            this.txttimkiem.Font = new Font("Times New Roman", 14f);
            this.txttimkiem.Location = new Point(4, 160);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new Size(580, 29);
            this.txttimkiem.TabIndex = 17;
            this.txttimkiem.Tag = "Tìm thông tin khách hàng";
            this.txttimkiem.Text = "Tìm thông tin khách hàng";
            this.txttimkiem.TextChanged += this.txttimkiem_TextChanged;
            this.txttimkiem.Enter += this.txttimkiem_Enter;
            this.txttimkiem.Leave += this.txttimkiem_Leave;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.tenkhachhang,
                this.nhanviennhan,
                this.ngaynhan,
                this.Noidungnhan,
                this.nhanvienxuly,
                this.ngayxuly,
                this.noidungxuly,
                this.Tinhtrang,
                this.gui_nv,
                this.gui_kh,
                this.MA,
                this.sdt_kh,
                this.sdtvn_nhan,
                this.sdt_nvxl,
                this.makhachhang,
                this.tennvn,
                this.ten_nvxl,
                this.songay,
                this.hanxuly
            });
            this.dataGridView1.Location = new Point(4, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 39;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            this.dataGridView1.Size = new Size(1310, 536);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += this.dataGridView1_CellDoubleClick;
            this.button6.FlatAppearance.BorderColor = Color.Gray;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Location = new Point(4, 109);
            this.button6.Name = "button6";
            this.button6.Size = new Size(51, 48);
            this.button6.TabIndex = 18;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += this.button6_Click;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Font = new Font("Times New Roman", 14f);
            this.textBox1.Location = new Point(743, 109);
            this.textBox1.MaxLength = 320;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(263, 79);
            this.textBox1.TabIndex = 19;
            this.textBox1.Tag = "Nội dung xử lý";
            this.textBox1.Text = "Nội dung xử lý";
            this.textBox1.Enter += this.textBox1_Enter;
            this.textBox1.Leave += this.textBox1_Leave;
            this.button7.FlatAppearance.BorderColor = Color.Gray;
            this.button7.FlatStyle = FlatStyle.Flat;
            this.button7.Font = new Font("Times New Roman", 13f);
            this.button7.Location = new Point(615, 109);
            this.button7.Name = "button7";
            this.button7.Size = new Size(122, 79);
            this.button7.TabIndex = 20;
            this.button7.Text = "Lưu nội dung xử lý";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += this.button7_Click;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Font = new Font("Times New Roman", 14f);
            this.textBox2.Location = new Point(4, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(322, 29);
            this.textBox2.TabIndex = 21;
            this.textBox2.Tag = "Số ngày cần xử lý";
            this.textBox2.Text = "Số ngày cần xử lý";
            this.txt_songay.BackColor = Color.White;
            this.txt_songay.Font = new Font("Times New Roman", 14f);
            this.txt_songay.Location = new Point(325, 63);
            this.txt_songay.Name = "txt_songay";
            this.txt_songay.Size = new Size(133, 29);
            this.txt_songay.TabIndex = 4;
            this.txt_songay.Tag = "1";
            this.txt_songay.Text = "1";
            this.txt_songay.TextAlign = HorizontalAlignment.Center;
            this.txt_songay.KeyDown += this.txt_songay_KeyDown;
            this.tenkhachhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenkhachhang.DataPropertyName = "tenkhachhang";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.tenkhachhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            this.tenkhachhang.Width = 163;
            this.nhanviennhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nhanviennhan.DataPropertyName = "TENNHANVIEN_NHAN";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.nhanviennhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.nhanviennhan.HeaderText = "N.viên tiếp nhận";
            this.nhanviennhan.Name = "nhanviennhan";
            this.nhanviennhan.ReadOnly = true;
            this.nhanviennhan.Width = 120;
            this.ngaynhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngaynhan.DataPropertyName = "NGAYNHAN";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.ngaynhan.DefaultCellStyle = dataGridViewCellStyle4;
            this.ngaynhan.HeaderText = "Ngày nhận";
            this.ngaynhan.Name = "ngaynhan";
            this.ngaynhan.ReadOnly = true;
            this.ngaynhan.Width = 95;
            this.Noidungnhan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Noidungnhan.DataPropertyName = "NOIDUNGYEUCAU";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.Noidungnhan.DefaultCellStyle = dataGridViewCellStyle5;
            this.Noidungnhan.HeaderText = "Nội dung tiếp nhận";
            this.Noidungnhan.Name = "Noidungnhan";
            this.Noidungnhan.ReadOnly = true;
            this.Noidungnhan.Width = 168;
            this.nhanvienxuly.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nhanvienxuly.DataPropertyName = "TENNHANVIEN_XULY";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.nhanvienxuly.DefaultCellStyle = dataGridViewCellStyle6;
            this.nhanvienxuly.HeaderText = "Nhân viên xử lý";
            this.nhanvienxuly.Name = "nhanvienxuly";
            this.nhanvienxuly.ReadOnly = true;
            this.nhanvienxuly.Width = 120;
            this.ngayxuly.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngayxuly.DataPropertyName = "ngayxuly";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            this.ngayxuly.DefaultCellStyle = dataGridViewCellStyle7;
            this.ngayxuly.HeaderText = "Ngày xử lý";
            this.ngayxuly.Name = "ngayxuly";
            this.ngayxuly.ReadOnly = true;
            this.ngayxuly.Width = 95;
            this.noidungxuly.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.noidungxuly.DataPropertyName = "NOIDUNGXULY";
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            this.noidungxuly.DefaultCellStyle = dataGridViewCellStyle8;
            this.noidungxuly.HeaderText = "Nội dung xử lý";
            this.noidungxuly.Name = "noidungxuly";
            this.noidungxuly.ReadOnly = true;
            this.noidungxuly.Width = 168;
            this.Tinhtrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Tinhtrang.DataPropertyName = "Tinhtrang";
            this.Tinhtrang.HeaderText = "Xử lý";
            this.Tinhtrang.Name = "Tinhtrang";
            this.Tinhtrang.ReadOnly = true;
            this.Tinhtrang.Resizable = DataGridViewTriState.True;
            this.Tinhtrang.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Tinhtrang.Visible = false;
            this.Tinhtrang.Width = 35;
            this.gui_nv.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gui_nv.DataPropertyName = "GUINHANVIEN";
            this.gui_nv.HeaderText = "nv";
            this.gui_nv.Name = "gui_nv";
            this.gui_nv.ReadOnly = true;
            this.gui_nv.Resizable = DataGridViewTriState.True;
            this.gui_nv.SortMode = DataGridViewColumnSortMode.Automatic;
            this.gui_nv.Width = 35;
            this.gui_kh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gui_kh.DataPropertyName = "GUIKHACHHANG";
            this.gui_kh.HeaderText = "kh";
            this.gui_kh.Name = "gui_kh";
            this.gui_kh.ReadOnly = true;
            this.gui_kh.Resizable = DataGridViewTriState.True;
            this.gui_kh.SortMode = DataGridViewColumnSortMode.Automatic;
            this.gui_kh.Width = 35;
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "MÃ";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Visible = false;
            this.sdt_kh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sdt_kh.DataPropertyName = "sdt_kh";
            this.sdt_kh.HeaderText = "Sđt khách hàng";
            this.sdt_kh.Name = "sdt_kh";
            this.sdt_kh.ReadOnly = true;
            this.sdt_kh.Width = 150;
            this.sdtvn_nhan.DataPropertyName = "sdt_nvn";
            this.sdtvn_nhan.HeaderText = "số điện thoại nhân viên tiếp nhận";
            this.sdtvn_nhan.Name = "sdtvn_nhan";
            this.sdtvn_nhan.ReadOnly = true;
            this.sdtvn_nhan.Visible = false;
            this.sdt_nvxl.DataPropertyName = "sdt_nvxl";
            this.sdt_nvxl.HeaderText = "số điện thoại nhân viên xử lý";
            this.sdt_nvxl.Name = "sdt_nvxl";
            this.sdt_nvxl.ReadOnly = true;
            this.sdt_nvxl.Visible = false;
            this.makhachhang.DataPropertyName = "makhachhang";
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.Name = "makhachhang";
            this.makhachhang.ReadOnly = true;
            this.makhachhang.Visible = false;
            this.tennvn.DataPropertyName = "MANHANVIENNHAN";
            this.tennvn.HeaderText = "MÃ nhân viên nhận";
            this.tennvn.Name = "tennvn";
            this.tennvn.ReadOnly = true;
            this.tennvn.Visible = false;
            this.ten_nvxl.DataPropertyName = "MANHANVIENXULY";
            this.ten_nvxl.HeaderText = "MÃ nhân viên xử lý";
            this.ten_nvxl.Name = "ten_nvxl";
            this.ten_nvxl.ReadOnly = true;
            this.ten_nvxl.Visible = false;
            this.songay.DataPropertyName = "songay";
            this.songay.HeaderText = "songay";
            this.songay.Name = "songay";
            this.songay.ReadOnly = true;
            this.songay.Visible = false;
            this.hanxuly.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.hanxuly.DataPropertyName = "hanxuly";
            this.hanxuly.HeaderText = "Hạn xử lý";
            this.hanxuly.Name = "hanxuly";
            this.hanxuly.ReadOnly = true;
            this.hanxuly.Width = 142;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1316, 729);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.txttimkiem);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.txtsdt_nhanvienxuly);
            base.Controls.Add(this.txtnhanvien_xuly);
            base.Controls.Add(this.txt_songay);
            base.Controls.Add(this.txtsdt_nhanviennhan);
            base.Controls.Add(this.txtnhanvien_nhan);
            base.Controls.Add(this.txtnoidung);
            base.Controls.Add(this.txtsdt);
            base.Controls.Add(this.txttenkhachhang);
            base.Controls.Add(this.txtma_nhanvienxuly);
            base.Controls.Add(this.txtma_nhanvien_nhan);
            base.Controls.Add(this.txtma);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
            //  base.MaximizeBox = false;
            //   base.MinimizeBox = false;
            base.Name = "Frmtiepnhan_xuly";
            // base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận và xử lý yêu cầu khách hàng";
            base.Load += this.Frmtiepnhan_xuly_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        private TextBox txttenkhachhang;

        // Token: 0x0400118C RID: 4492
        private TextBox txtsdt;

        // Token: 0x0400118D RID: 4493
        private TextBox txtnoidung;

        // Token: 0x0400118E RID: 4494
        private TextBox txtsdt_nhanviennhan;

        // Token: 0x0400118F RID: 4495
        private TextBox txtnhanvien_nhan;

        // Token: 0x04001190 RID: 4496
        private TextBox txtma;

        // Token: 0x04001191 RID: 4497
        private TextBox txtma_nhanvien_nhan;

        // Token: 0x04001192 RID: 4498
        private TextBox txtma_nhanvienxuly;

        // Token: 0x04001193 RID: 4499
        private TextBox txtsdt_nhanvienxuly;

        // Token: 0x04001194 RID: 4500
        private TextBox txtnhanvien_xuly;

        // Token: 0x04001195 RID: 4501
        private Button button1;

        // Token: 0x04001196 RID: 4502
        private Button button2;

        // Token: 0x04001197 RID: 4503
        private Button button3;

        // Token: 0x04001198 RID: 4504
        private Button button4;

        // Token: 0x04001199 RID: 4505
        private Button button5;

        // Token: 0x0400119A RID: 4506
        private TextBox txttimkiem;

        // Token: 0x0400119B RID: 4507
        private DataGridView dataGridView1;

        // Token: 0x0400119C RID: 4508
        private Button button6;

        // Token: 0x0400119D RID: 4509
        private TextBox textBox1;

        // Token: 0x0400119E RID: 4510
        private Button button7;

        // Token: 0x0400119F RID: 4511
        private TextBox textBox2;

        // Token: 0x040011A0 RID: 4512
        private TextBox txt_songay;

        // Token: 0x040011A1 RID: 4513
        private DataGridViewTextBoxColumn tenkhachhang;

        // Token: 0x040011A2 RID: 4514
        private DataGridViewTextBoxColumn nhanviennhan;

        // Token: 0x040011A3 RID: 4515
        private DataGridViewTextBoxColumn ngaynhan;

        // Token: 0x040011A4 RID: 4516
        private DataGridViewTextBoxColumn Noidungnhan;

        // Token: 0x040011A5 RID: 4517
        private DataGridViewTextBoxColumn nhanvienxuly;

        // Token: 0x040011A6 RID: 4518
        private DataGridViewTextBoxColumn ngayxuly;

        // Token: 0x040011A7 RID: 4519
        private DataGridViewTextBoxColumn noidungxuly;

        // Token: 0x040011A8 RID: 4520
        private DataGridViewCheckBoxColumn Tinhtrang;

        // Token: 0x040011A9 RID: 4521
        private DataGridViewCheckBoxColumn gui_nv;

        // Token: 0x040011AA RID: 4522
        private DataGridViewCheckBoxColumn gui_kh;

        // Token: 0x040011AB RID: 4523
        private DataGridViewTextBoxColumn MA;

        // Token: 0x040011AC RID: 4524
        private DataGridViewTextBoxColumn sdt_kh;

        // Token: 0x040011AD RID: 4525
        private DataGridViewTextBoxColumn sdtvn_nhan;

        // Token: 0x040011AE RID: 4526
        private DataGridViewTextBoxColumn sdt_nvxl;

        // Token: 0x040011AF RID: 4527
        private DataGridViewTextBoxColumn makhachhang;

        // Token: 0x040011B0 RID: 4528
        private DataGridViewTextBoxColumn tennvn;

        // Token: 0x040011B1 RID: 4529
        private DataGridViewTextBoxColumn ten_nvxl;

        // Token: 0x040011B2 RID: 4530
        private DataGridViewTextBoxColumn songay;

        // Token: 0x040011B3 RID: 4531
        private DataGridViewTextBoxColumn hanxuly;
    }
}
