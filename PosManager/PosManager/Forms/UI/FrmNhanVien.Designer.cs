using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FrmNhanVien
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
            this.groupBox1 = new GroupBox();
            this.button1 = new Button();
            this.btchon = new Button();
            this.cobcuahang = new ComboBox();
            this.label14 = new Label();
            this.txtPhongban = new TextBox();
            this.label13 = new Label();
            this.dtpNamsinh = new DateTimePicker();
            this.cobgioitinh = new ComboBox();
            this.label12 = new Label();
            this.txtGhichu = new TextBox();
            this.label11 = new Label();
            this.TxtMST = new TextBox();
            this.label4 = new Label();
            this.dtpNgaycap = new DateTimePicker();
            this.txtSDT = new TextBox();
            this.label10 = new Label();
            this.label8 = new Label();
            this.txtCMND = new TextBox();
            this.label6 = new Label();
            this.txtnoicap = new TextBox();
            this.txtNguyenQuan = new TextBox();
            this.label9 = new Label();
            this.txtDiachi = new TextBox();
            this.label7 = new Label();
            this.txtTenNV = new TextBox();
            this.label5 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.txtMaNV = new TextBox();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.dgvNhanvien = new DataGridView();
            this.btThem = new Button();
            this.btSua = new Button();
            this.btXoa = new Button();
            this.btLuu = new Button();
            this.bthuy = new Button();
            this.Stt = new DataGridViewTextBoxColumn();
            this.MaNV = new DataGridViewTextBoxColumn();
            this.mnv = new DataGridViewTextBoxColumn();
            this.dt = new DataGridViewTextBoxColumn();
            this.diachi = new DataGridViewTextBoxColumn();
            this.Phongban = new DataGridViewTextBoxColumn();
            this.gt = new DataGridViewTextBoxColumn();
            this.namsinh = new DataGridViewTextBoxColumn();
            this.nguyenquan = new DataGridViewTextBoxColumn();
            this.CMND = new DataGridViewTextBoxColumn();
            this.ngaycap = new DataGridViewTextBoxColumn();
            this.Nc = new DataGridViewTextBoxColumn();
            this.sdt = new DataGridViewTextBoxColumn();
            this.Ghichu = new DataGridViewTextBoxColumn();
            this.Matkhau = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.dgvNhanvien).BeginInit();
            base.SuspendLayout();
            this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btchon);
            this.groupBox1.Controls.Add(this.cobcuahang);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPhongban);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpNamsinh);
            this.groupBox1.Controls.Add(this.cobgioitinh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMST);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgaycap);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnoicap);
            this.groupBox1.Controls.Add(this.txtNguyenQuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(8, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(986, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.button1.BackColor = SystemColors.ControlLightLight;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = SystemColors.HotTrack;
            this.button1.Location = new Point(815, 154);
            this.button1.Name = "button1";
            this.button1.Size = new Size(93, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.btchon.BackColor = Color.FromArgb(192, 255, 192);
            this.btchon.FlatStyle = FlatStyle.Flat;
            this.btchon.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btchon.ForeColor = SystemColors.HotTrack;
            this.btchon.Location = new Point(698, 154);
            this.btchon.Name = "btchon";
            this.btchon.Size = new Size(93, 39);
            this.btchon.TabIndex = 14;
            this.btchon.Text = "CHỌN";
            this.btchon.UseVisualStyleBackColor = false;
            this.btchon.Click += this.btchon_Click;
            this.cobcuahang.FormattingEnabled = true;
            this.cobcuahang.Location = new Point(314, 119);
            this.cobcuahang.Name = "cobcuahang";
            this.cobcuahang.Size = new Size(227, 27);
            this.cobcuahang.TabIndex = 15;
            this.label14.AutoSize = true;
            this.label14.Location = new Point(216, 123);
            this.label14.Name = "label14";
            this.label14.Size = new Size(72, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cửa Hàng";
            this.txtPhongban.Enabled = false;
            this.txtPhongban.Location = new Point(102, 117);
            this.txtPhongban.Name = "txtPhongban";
            this.txtPhongban.Size = new Size(107, 26);
            this.txtPhongban.TabIndex = 12;
            this.label13.AutoSize = true;
            this.label13.Location = new Point(6, 121);
            this.label13.Name = "label13";
            this.label13.Size = new Size(75, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Phòng Ban";
            this.dtpNamsinh.Enabled = false;
            this.dtpNamsinh.Format = DateTimePickerFormat.Short;
            this.dtpNamsinh.Location = new Point(622, 19);
            this.dtpNamsinh.Name = "dtpNamsinh";
            this.dtpNamsinh.Size = new Size(131, 26);
            this.dtpNamsinh.TabIndex = 3;
            this.dtpNamsinh.Value = new DateTime(2016, 11, 28, 0, 0, 0, 0);
            this.dtpNamsinh.KeyPress += this.dtpNamsinh_KeyPress;
            this.cobgioitinh.Enabled = false;
            this.cobgioitinh.FormattingEnabled = true;
            this.cobgioitinh.Location = new Point(844, 83);
            this.cobgioitinh.Name = "cobgioitinh";
            this.cobgioitinh.Size = new Size(131, 27);
            this.cobgioitinh.TabIndex = 11;
            this.cobgioitinh.KeyPress += this.cobgioitinh_KeyPress;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(756, 87);
            this.label12.Name = "label12";
            this.label12.Size = new Size(59, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Giới tính";
            this.txtGhichu.Enabled = false;
            this.txtGhichu.Location = new Point(622, 121);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new Size(356, 26);
            this.txtGhichu.TabIndex = 12;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(547, 124);
            this.label11.Name = "label11";
            this.label11.Size = new Size(55, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ghi chú";
            this.TxtMST.Enabled = false;
            this.TxtMST.Location = new Point(622, 83);
            this.TxtMST.Name = "TxtMST";
            this.TxtMST.Size = new Size(128, 26);
            this.TxtMST.TabIndex = 10;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(547, 89);
            this.label4.Name = "label4";
            this.label4.Size = new Size(77, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã số thuế";
            this.dtpNgaycap.Enabled = false;
            this.dtpNgaycap.Format = DateTimePickerFormat.Short;
            this.dtpNgaycap.Location = new Point(844, 51);
            this.dtpNgaycap.Name = "dtpNgaycap";
            this.dtpNgaycap.Size = new Size(131, 26);
            this.dtpNgaycap.TabIndex = 7;
            this.dtpNgaycap.Value = new DateTime(2016, 11, 28, 0, 0, 0, 0);
            this.dtpNgaycap.KeyPress += this.dtpNgaycap_KeyPress;
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new Point(312, 86);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new Size(228, 26);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.KeyPress += this.txtSDT_KeyPress;
            this.label10.AutoSize = true;
            this.label10.Location = new Point(216, 90);
            this.label10.Name = "label10";
            this.label10.Size = new Size(88, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số điện thoại";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(753, 54);
            this.label8.Name = "label8";
            this.label8.Size = new Size(72, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Cấp";
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new Point(622, 48);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new Size(128, 26);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.KeyPress += this.txtCMND_KeyPress;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(547, 54);
            this.label6.Name = "label6";
            this.label6.Size = new Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CMND";
            this.txtnoicap.Enabled = false;
            this.txtnoicap.Location = new Point(103, 83);
            this.txtnoicap.Name = "txtnoicap";
            this.txtnoicap.Size = new Size(107, 26);
            this.txtnoicap.TabIndex = 8;
            this.txtnoicap.KeyPress += this.txtnoicap_KeyPress;
            this.txtNguyenQuan.Enabled = false;
            this.txtNguyenQuan.Location = new Point(844, 18);
            this.txtNguyenQuan.Name = "txtNguyenQuan";
            this.txtNguyenQuan.Size = new Size(131, 26);
            this.txtNguyenQuan.TabIndex = 4;
            this.txtNguyenQuan.KeyPress += this.txtNguyenQuan_KeyPress;
            this.label9.AutoSize = true;
            this.label9.Location = new Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new Size(62, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nơi Cấp";
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Location = new Point(103, 51);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new Size(437, 26);
            this.txtDiachi.TabIndex = 5;
            this.txtDiachi.KeyPress += this.txtDiachi_KeyPress;
            this.label7.AutoSize = true;
            this.label7.Location = new Point(749, 22);
            this.label7.Name = "label7";
            this.label7.Size = new Size(89, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nguyên quán";
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new Point(314, 18);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new Size(226, 26);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.KeyPress += this.txtTenNV_KeyPress;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(547, 22);
            this.label5.Name = "label5";
            this.label5.Size = new Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new Size(51, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(216, 23);
            this.label3.Name = "label3";
            this.label3.Size = new Size(92, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên";
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new Point(103, 19);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new Size(107, 26);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.KeyPress += this.txtMaNV_KeyPress;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvNhanvien);
            this.groupBox2.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(8, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(986, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.dgvNhanvien.AllowDrop = true;
            this.dgvNhanvien.AllowUserToAddRows = false;
            this.dgvNhanvien.AllowUserToDeleteRows = false;
            this.dgvNhanvien.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvNhanvien.ColumnHeadersHeight = 27;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanvien.Columns.AddRange(new DataGridViewColumn[]
            {
                this.Stt,
                this.MaNV,
                this.mnv,
                this.dt,
                this.diachi,
                this.Phongban,
                this.gt,
                this.namsinh,
                this.nguyenquan,
                this.CMND,
                this.ngaycap,
                this.Nc,
                this.sdt,
                this.Ghichu,
                this.Matkhau,
                this.Column1,
                this.Column2
            });
            this.dgvNhanvien.Location = new Point(7, 25);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 4;
            this.dgvNhanvien.RowTemplate.Height = 39;
            this.dgvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new Size(973, 473);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.RowPrePaint += this.dgvNhanvien_RowPrePaint;
            this.dgvNhanvien.MouseDoubleClick += this.dgvNhanvien_MouseDoubleClick;
            this.btThem.BackColor = SystemColors.ControlLightLight;
            this.btThem.FlatStyle = FlatStyle.Flat;
            this.btThem.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btThem.ForeColor = SystemColors.HotTrack;
            this.btThem.Location = new Point(134, 142);
            this.btThem.Name = "btThem";
            this.btThem.Size = new Size(93, 39);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += this.btThem_Click;
            this.btSua.BackColor = SystemColors.ControlLightLight;
            this.btSua.FlatStyle = FlatStyle.Flat;
            this.btSua.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btSua.ForeColor = SystemColors.HotTrack;
            this.btSua.Location = new Point(242, 142);
            this.btSua.Name = "btSua";
            this.btSua.Size = new Size(93, 39);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "SỬA";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += this.btSua_Click;
            this.btXoa.BackColor = SystemColors.ControlLightLight;
            this.btXoa.FlatStyle = FlatStyle.Flat;
            this.btXoa.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btXoa.ForeColor = SystemColors.HotTrack;
            this.btXoa.Location = new Point(354, 142);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new Size(93, 39);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += this.btXoa_Click;
            this.btLuu.BackColor = SystemColors.ControlLightLight;
            this.btLuu.Enabled = false;
            this.btLuu.FlatStyle = FlatStyle.Flat;
            this.btLuu.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btLuu.ForeColor = SystemColors.HotTrack;
            this.btLuu.Location = new Point(466, 142);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new Size(93, 39);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "LƯU";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += this.btLuu_Click;
            this.bthuy.BackColor = SystemColors.ControlLightLight;
            this.bthuy.Enabled = false;
            this.bthuy.FlatStyle = FlatStyle.Flat;
            this.bthuy.Font = new Font("Times New Roman", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.bthuy.ForeColor = SystemColors.HotTrack;
            this.bthuy.Location = new Point(582, 142);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new Size(93, 39);
            this.bthuy.TabIndex = 2;
            this.bthuy.Text = "HỦY";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += this.bthuy_Click;
            this.Stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Stt.HeaderText = "Số TT";
            this.Stt.Name = "Stt";
            this.Stt.Width = 40;
            this.MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MaNV.DataPropertyName = "manv";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MaNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 80;
            this.mnv.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.mnv.DataPropertyName = "TenNV";
            this.mnv.HeaderText = "Tên Nhân Viên";
            this.mnv.Name = "mnv";
            this.mnv.Width = 180;
            this.dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dt.DataPropertyName = "sdt";
            this.dt.HeaderText = "Điện Thoại";
            this.dt.Name = "dt";
            this.dt.Width = 101;
            this.diachi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 200;
            this.Phongban.DataPropertyName = "phongban";
            this.Phongban.HeaderText = "Phòng Ban";
            this.Phongban.Name = "Phongban";
            this.Phongban.Visible = false;
            this.gt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gt.DataPropertyName = "GioiTinh";
            this.gt.HeaderText = "Giới Tính";
            this.gt.Name = "gt";
            this.gt.Width = 60;
            this.namsinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm Sinh";
            this.namsinh.Name = "namsinh";
            this.namsinh.Width = 102;
            this.nguyenquan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nguyenquan.DataPropertyName = "nguyenquan";
            this.nguyenquan.HeaderText = "Nguyên Quán";
            this.nguyenquan.Name = "nguyenquan";
            this.nguyenquan.Width = 102;
            this.CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.CMND.DataPropertyName = "cmnd";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            this.CMND.DefaultCellStyle = dataGridViewCellStyle3;
            this.CMND.HeaderText = "Số CMND";
            this.CMND.Name = "CMND";
            this.CMND.Width = 90;
            this.ngaycap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngaycap.DataPropertyName = "ngaycap";
            this.ngaycap.HeaderText = "Ngày Cấp";
            this.ngaycap.Name = "ngaycap";
            this.ngaycap.Width = 102;
            this.Nc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Nc.DataPropertyName = "Noicap";
            this.Nc.HeaderText = "Nơi Cấp";
            this.Nc.Name = "Nc";
            this.Nc.Width = 102;
            this.sdt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sdt.DataPropertyName = "mst";
            this.sdt.HeaderText = "Mã Số Thuế";
            this.sdt.Name = "sdt";
            this.sdt.Visible = false;
            this.sdt.Width = 103;
            this.Ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ghichu.DataPropertyName = "ghichu";
            this.Ghichu.HeaderText = "Ghi Chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Width = 101;
            this.Matkhau.DataPropertyName = "matkhau";
            this.Matkhau.HeaderText = "Mật khẩu";
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Visible = false;
            this.Column1.DataPropertyName = "creationdate";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column2.DataPropertyName = "lasteditdate";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(998, 651);
            base.Controls.Add(this.bthuy);
            base.Controls.Add(this.btLuu);
            base.Controls.Add(this.btXoa);
            base.Controls.Add(this.btSua);
            base.Controls.Add(this.btThem);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox2);
          //  base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            this.MinimumSize = new Size(1014, 491);
            base.Name = "FrmNhanVien";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += this.FrmNhanVien_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvNhanvien).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x0400005B RID: 91
        private GroupBox groupBox1;

        // Token: 0x0400005C RID: 92
        private TextBox txtMaNV;

        // Token: 0x0400005D RID: 93
        private Label label1;

        // Token: 0x0400005E RID: 94
        private GroupBox groupBox2;

        // Token: 0x0400005F RID: 95
        private TextBox txtGhichu;

        // Token: 0x04000060 RID: 96
        private Label label11;

        // Token: 0x04000061 RID: 97
        private TextBox TxtMST;

        // Token: 0x04000062 RID: 98
        private Label label4;

        // Token: 0x04000063 RID: 99
        private DateTimePicker dtpNgaycap;

        // Token: 0x04000064 RID: 100
        private TextBox txtSDT;

        // Token: 0x04000065 RID: 101
        private Label label10;

        // Token: 0x04000066 RID: 102
        private Label label8;

        // Token: 0x04000067 RID: 103
        private TextBox txtCMND;

        // Token: 0x04000068 RID: 104
        private Label label6;

        // Token: 0x04000069 RID: 105
        private TextBox txtnoicap;

        // Token: 0x0400006A RID: 106
        private TextBox txtNguyenQuan;

        // Token: 0x0400006B RID: 107
        private Label label9;

        // Token: 0x0400006C RID: 108
        private TextBox txtDiachi;

        // Token: 0x0400006D RID: 109
        private Label label7;

        // Token: 0x0400006E RID: 110
        private TextBox txtTenNV;

        // Token: 0x0400006F RID: 111
        private Label label5;

        // Token: 0x04000070 RID: 112
        private Label label2;

        // Token: 0x04000071 RID: 113
        private Label label3;

        // Token: 0x04000072 RID: 114
        private DataGridView dgvNhanvien;

        // Token: 0x04000073 RID: 115
        private ComboBox cobgioitinh;

        // Token: 0x04000074 RID: 116
        private Label label12;

        // Token: 0x04000075 RID: 117
        private Button btThem;

        // Token: 0x04000076 RID: 118
        private Button btSua;

        // Token: 0x04000077 RID: 119
        private Button btXoa;

        // Token: 0x04000078 RID: 120
        private Button btLuu;

        // Token: 0x04000079 RID: 121
        private Button bthuy;

        // Token: 0x0400007A RID: 122
        private DateTimePicker dtpNamsinh;

        // Token: 0x0400007B RID: 123
        private TextBox txtPhongban;

        // Token: 0x0400007C RID: 124
        private Label label13;

        // Token: 0x0400007D RID: 125
        private ComboBox cobcuahang;

        // Token: 0x0400007E RID: 126
        private Label label14;

        // Token: 0x0400007F RID: 127
        private Button btchon;

        // Token: 0x04000080 RID: 128
        private Button button1;

        // Token: 0x04000081 RID: 129
        private DataGridViewTextBoxColumn Stt;

        // Token: 0x04000082 RID: 130
        private DataGridViewTextBoxColumn MaNV;

        // Token: 0x04000083 RID: 131
        private DataGridViewTextBoxColumn mnv;

        // Token: 0x04000084 RID: 132
        private DataGridViewTextBoxColumn dt;

        // Token: 0x04000085 RID: 133
        private DataGridViewTextBoxColumn diachi;

        // Token: 0x04000086 RID: 134
        private DataGridViewTextBoxColumn Phongban;

        // Token: 0x04000087 RID: 135
        private DataGridViewTextBoxColumn gt;

        // Token: 0x04000088 RID: 136
        private DataGridViewTextBoxColumn namsinh;

        // Token: 0x04000089 RID: 137
        private DataGridViewTextBoxColumn nguyenquan;

        // Token: 0x0400008A RID: 138
        private DataGridViewTextBoxColumn CMND;

        // Token: 0x0400008B RID: 139
        private DataGridViewTextBoxColumn ngaycap;

        // Token: 0x0400008C RID: 140
        private DataGridViewTextBoxColumn Nc;

        // Token: 0x0400008D RID: 141
        private DataGridViewTextBoxColumn sdt;

        // Token: 0x0400008E RID: 142
        private DataGridViewTextBoxColumn Ghichu;

        // Token: 0x0400008F RID: 143
        private DataGridViewTextBoxColumn Matkhau;

        // Token: 0x04000090 RID: 144
        private DataGridViewTextBoxColumn Column1;

        // Token: 0x04000091 RID: 145
        private DataGridViewTextBoxColumn Column2;
    }
}
