namespace PosManager.Forms.UserControls.Kho
{
    partial class fUpdateHoaDonNhapKho
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
            panel1 = new Panel();
            lbNguoiBan = new Label();
            btnClose = new PictureBox();
            panel2 = new Panel();
            txtTongTien = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txtTienGiam = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            btnNhapKho = new Button();
            panel6 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            panel11 = new Panel();
            txtThanhTien = new TextBox();
            label6 = new Label();
            panel12 = new Panel();
            radioButton1 = new RadioButton();
            rdbChuyenKhoan = new RadioButton();
            rdbTienMat = new RadioButton();
            panel7 = new Panel();
            panel8 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNguoiBan);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 37);
            panel1.TabIndex = 93;
            // 
            // lbNguoiBan
            // 
            lbNguoiBan.AutoSize = true;
            lbNguoiBan.BackColor = Color.White;
            lbNguoiBan.Dock = DockStyle.Fill;
            lbNguoiBan.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNguoiBan.ForeColor = Color.DimGray;
            lbNguoiBan.Location = new Point(0, 0);
            lbNguoiBan.Margin = new Padding(6, 0, 6, 0);
            lbNguoiBan.Name = "lbNguoiBan";
            lbNguoiBan.Padding = new Padding(5);
            lbNguoiBan.Size = new Size(71, 28);
            lbNguoiBan.TabIndex = 86;
            lbNguoiBan.Text = "Lâm Lê";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.Location = new Point(380, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 37);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 91;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTongTien);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 10, 30, 10);
            panel2.Size = new Size(400, 46);
            panel2.TabIndex = 94;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(80, 10);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(290, 26);
            txtTongTien.TabIndex = 87;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            txtTongTien.KeyPress += txtTongTien_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 10);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(80, 24);
            label1.TabIndex = 86;
            label1.Text = "Tổng tiền:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTienGiam);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.LightCoral;
            panel3.Location = new Point(0, 83);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 30, 10);
            panel3.Size = new Size(400, 46);
            panel3.TabIndex = 95;
            // 
            // txtTienGiam
            // 
            txtTienGiam.BackColor = Color.White;
            txtTienGiam.Dock = DockStyle.Fill;
            txtTienGiam.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTienGiam.ForeColor = Color.LightCoral;
            txtTienGiam.Location = new Point(79, 10);
            txtTienGiam.Name = "txtTienGiam";
            txtTienGiam.Size = new Size(291, 26);
            txtTienGiam.TabIndex = 87;
            txtTienGiam.TextAlign = HorizontalAlignment.Right;
            txtTienGiam.Click += TextClick;
            txtTienGiam.TextChanged += TextChanged;
            txtTienGiam.KeyPress += KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 10);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(79, 24);
            label2.TabIndex = 86;
            label2.Text = "Tiền giảm:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnNhapKho);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 488);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 37);
            panel5.TabIndex = 102;
            // 
            // btnNhapKho
            // 
            btnNhapKho.BackColor = Color.DodgerBlue;
            btnNhapKho.Dock = DockStyle.Fill;
            btnNhapKho.FlatStyle = FlatStyle.Flat;
            btnNhapKho.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapKho.ForeColor = Color.White;
            btnNhapKho.Image = Properties.Resources.icons8_money_25;
            btnNhapKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapKho.Location = new Point(0, 0);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(400, 37);
            btnNhapKho.TabIndex = 1;
            btnNhapKho.Text = "Thanh Toán";
            btnNhapKho.UseVisualStyleBackColor = false;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 445);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 10, 30, 10);
            panel6.Size = new Size(400, 43);
            panel6.TabIndex = 103;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(76, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 88;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(0, 10);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(76, 24);
            label3.TabIndex = 87;
            label3.Text = "Nội dung:";
            // 
            // panel11
            // 
            panel11.Controls.Add(txtThanhTien);
            panel11.Controls.Add(label6);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 129);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(0, 10, 30, 10);
            panel11.Size = new Size(400, 46);
            panel11.TabIndex = 104;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.White;
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtThanhTien.ForeColor = Color.DodgerBlue;
            txtThanhTien.Location = new Point(87, 10);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(283, 26);
            txtThanhTien.TabIndex = 88;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            txtThanhTien.Click += TextClick;
            txtThanhTien.TextChanged += TextChanged;
            txtThanhTien.KeyPress += KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(0, 10);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(87, 24);
            label6.TabIndex = 87;
            label6.Text = "Thành tiền:";
            // 
            // panel12
            // 
            panel12.Controls.Add(radioButton1);
            panel12.Controls.Add(rdbChuyenKhoan);
            panel12.Controls.Add(rdbTienMat);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 175);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(0, 10, 30, 10);
            panel12.Size = new Size(400, 46);
            panel12.TabIndex = 105;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(272, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(15, 0, 15, 0);
            radioButton1.Size = new Size(107, 26);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "Công Nợ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbChuyenKhoan
            // 
            rdbChuyenKhoan.AutoSize = true;
            rdbChuyenKhoan.Dock = DockStyle.Left;
            rdbChuyenKhoan.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbChuyenKhoan.Location = new Point(125, 10);
            rdbChuyenKhoan.Name = "rdbChuyenKhoan";
            rdbChuyenKhoan.Padding = new Padding(15, 0, 15, 0);
            rdbChuyenKhoan.Size = new Size(147, 26);
            rdbChuyenKhoan.TabIndex = 2;
            rdbChuyenKhoan.Text = "Chuyển Khoản";
            rdbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            rdbTienMat.AutoSize = true;
            rdbTienMat.Checked = true;
            rdbTienMat.Dock = DockStyle.Left;
            rdbTienMat.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rdbTienMat.Location = new Point(0, 10);
            rdbTienMat.Name = "rdbTienMat";
            rdbTienMat.Padding = new Padding(30, 0, 15, 0);
            rdbTienMat.Size = new Size(125, 26);
            rdbTienMat.TabIndex = 1;
            rdbTienMat.TabStop = true;
            rdbTienMat.Text = "Tiền Mặt";
            rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 221);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 224);
            panel7.TabIndex = 106;
            // 
            // panel8
            // 
            panel8.Controls.Add(dateTimePicker1);
            panel8.Controls.Add(label4);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 30, 10);
            panel8.Size = new Size(400, 46);
            panel8.TabIndex = 97;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(105, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 23);
            dateTimePicker1.TabIndex = 87;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(0, 10);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(105, 24);
            label4.TabIndex = 86;
            label4.Text = "Ngày đến hạn:";
            // 
            // fUpdateHoaDonNhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel7);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fUpdateHoaDonNhapKho";
            Padding = new Padding(0, 0, 0, 20);
            Size = new Size(400, 545);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbNguoiBan;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label1;
        private TextBox txtTongTien;
        private Panel panel3;
        private TextBox txtTienGiam;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Button btnNhapKho;
        private TextBox textBox1;
        private Label label3;
        private Panel panel11;
        private TextBox txtThanhTien;
        private Label label6;
        private Panel panel12;
        private RadioButton radioButton1;
        private RadioButton rdbChuyenKhoan;
        private RadioButton rdbTienMat;
        private Panel panel7;
        private Panel panel8;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}
