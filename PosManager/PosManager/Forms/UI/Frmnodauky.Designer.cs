using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmnodauky
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button3 = new Button();
            this.button2 = new Button();
            this.btxoa = new Button();
            this.button1 = new Button();
            this.txtghichu = new TextBox();
            this.txtsotien = new TextBox();
            this.txttenkhachhang = new TextBox();
            this.bttim = new Button();
            this.txtmakhachhang = new TextBox();
            this.rbnophaitra = new RadioButton();
            this.rbnophaithu = new RadioButton();
            this.label1 = new Label();
            this.lbkhachhang = new Label();
            this.panel2 = new Panel();
            this.dgvtondau = new DataGridView();
            this.MA = new DataGridViewTextBoxColumn();
            this.NOIDUNG = new DataGridViewTextBoxColumn();
            this.MAKH = new DataGridViewTextBoxColumn();
            this.TENKH = new DataGridViewTextBoxColumn();
            this.SOTIEN = new DataGridViewTextBoxColumn();
            this.STT = new DataGridViewTextBoxColumn();
            this.ghichu = new DataGridViewTextBoxColumn();
            this.NHANVIEN = new DataGridViewTextBoxColumn();
            this.openFileDialog1 = new OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvtondau).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvtondau, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 121f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.BackColor = Color.PaleTurquoise;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.txtsotien);
            this.panel1.Controls.Add(this.txttenkhachhang);
            this.panel1.Controls.Add(this.bttim);
            this.panel1.Controls.Add(this.txtmakhachhang);
            this.panel1.Controls.Add(this.rbnophaitra);
            this.panel1.Controls.Add(this.rbnophaithu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbkhachhang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1002, 115);
            this.panel1.TabIndex = 0;
            this.button3.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(883, 57);
            this.button3.Name = "button3";
            this.button3.Size = new Size(92, 54);
            this.button3.TabIndex = 24;
            this.button3.Text = "Nhập từ Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(816, 57);
            this.button2.Name = "button2";
            this.button2.Size = new Size(62, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "TÌM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.btxoa.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btxoa.Location = new Point(749, 57);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new Size(63, 55);
            this.btxoa.TabIndex = 4;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += this.btxoa_Click;
            this.button1.FlatAppearance.MouseDownBackColor = Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(345, 57);
            this.button1.Name = "button1";
            this.button1.Size = new Size(164, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "LƯU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txtghichu.Location = new Point(510, 28);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(579, 26);
            this.txtghichu.TabIndex = 2;
            this.txtghichu.Tag = "Ghi chú";
            this.txtghichu.Text = "Ghi chú";
            this.txtghichu.Enter += this.txtghichu_Enter;
            this.txtghichu.KeyDown += this.txtghichu_KeyDown;
            this.txtghichu.Leave += this.txtghichu_Leave;
            this.txtsotien.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtsotien.Location = new Point(345, 28);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new Size(164, 26);
            this.txtsotien.TabIndex = 1;
            this.txtsotien.TextAlign = HorizontalAlignment.Right;
            this.txtsotien.MouseClick += this.txtsotien_MouseClick;
            this.txtsotien.TextChanged += this.txtsotien_TextChanged;
            this.txtsotien.Enter += this.txtsotien_Enter;
            this.txtsotien.KeyDown += this.txtsotien_KeyDown;
            this.txtsotien.KeyPress += this.txtsotien_KeyPress;
            this.txtsotien.Leave += this.txtsotien_Leave;
            this.txttenkhachhang.BackColor = Color.White;
            this.txttenkhachhang.Location = new Point(510, 1);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.ReadOnly = true;
            this.txttenkhachhang.Size = new Size(579, 26);
            this.txttenkhachhang.TabIndex = 23;
            this.bttim.BackColor = Color.Blue;
            this.bttim.FlatAppearance.BorderColor = Color.Gray;
            this.bttim.FlatStyle = FlatStyle.Popup;
            this.bttim.Font = new Font("Times New Roman", 14f);
            this.bttim.ForeColor = Color.White;
            this.bttim.Location = new Point(8, 1);
            this.bttim.Name = "bttim";
            this.bttim.Size = new Size(254, 49);
            this.bttim.TabIndex = 6;
            this.bttim.Text = "Chọn khách hàng";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += this.bttim_Click;
            this.txtmakhachhang.Location = new Point(345, 1);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new Size(164, 26);
            this.txtmakhachhang.TabIndex = 0;
            this.txtmakhachhang.TextChanged += this.txtmakhachhang_TextChanged;
            this.txtmakhachhang.KeyDown += this.txtmakhachhang_KeyDown;
            this.rbnophaitra.AutoSize = true;
            this.rbnophaitra.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.rbnophaitra.Location = new Point(12, 84);
            this.rbnophaitra.Name = "rbnophaitra";
            this.rbnophaitra.Size = new Size(111, 25);
            this.rbnophaitra.TabIndex = 10;
            this.rbnophaitra.Text = "Nợ phải trả";
            this.rbnophaitra.UseVisualStyleBackColor = true;
            this.rbnophaitra.CheckedChanged += this.rbnophaitra_CheckedChanged;
            this.rbnophaithu.AutoSize = true;
            this.rbnophaithu.Checked = true;
            this.rbnophaithu.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.rbnophaithu.Location = new Point(12, 55);
            this.rbnophaithu.Name = "rbnophaithu";
            this.rbnophaithu.Size = new Size(115, 25);
            this.rbnophaithu.TabIndex = 9;
            this.rbnophaithu.TabStop = true;
            this.rbnophaithu.Text = "Nợ phải thu";
            this.rbnophaithu.UseVisualStyleBackColor = true;
            this.rbnophaithu.CheckedChanged += this.rbnophaithu_CheckedChanged;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(268, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(72, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Tiền:";
            this.lbkhachhang.AutoSize = true;
            this.lbkhachhang.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbkhachhang.Location = new Point(267, 3);
            this.lbkhachhang.Name = "lbkhachhang";
            this.lbkhachhang.Size = new Size(81, 21);
            this.lbkhachhang.TabIndex = 8;
            this.lbkhachhang.Text = "Nhập mã:";
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Location = new Point(7, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(254, 57);
            this.panel2.TabIndex = 25;
            this.dgvtondau.AllowUserToAddRows = false;
            this.dgvtondau.AllowUserToDeleteRows = false;
            this.dgvtondau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvtondau.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvtondau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvtondau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtondau.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MA,
                this.NOIDUNG,
                this.MAKH,
                this.TENKH,
                this.SOTIEN,
                this.STT,
                this.ghichu,
                this.NHANVIEN
            });
            this.dgvtondau.Dock = DockStyle.Fill;
            this.dgvtondau.Location = new Point(3, 124);
            this.dgvtondau.Name = "dgvtondau";
            this.dgvtondau.ReadOnly = true;
            this.dgvtondau.RowHeadersWidth = 4;
            this.dgvtondau.Size = new Size(1002, 437);
            this.dgvtondau.TabIndex = 1;
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "MÃ";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Visible = false;
            this.NOIDUNG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội Dung";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.ReadOnly = true;
            this.NOIDUNG.Width = 150;
            this.MAKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 139;
            this.TENKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên đơn vị";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 379;
            this.SOTIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOTIEN.DataPropertyName = "SOTIEN";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.SOTIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.SOTIEN.HeaderText = "Số Tiền";
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.ReadOnly = true;
            this.SOTIEN.Width = 139;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.ghichu.DataPropertyName = "GHICHU";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.Width = 300;
            this.NHANVIEN.DataPropertyName = "NHANVIEN";
            this.NHANVIEN.HeaderText = "MÃ NHAN VIÊN";
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.ReadOnly = true;
            this.NHANVIEN.Visible = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(1008, 564);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
           // base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "Frmnodauky";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Công nợ đầu kỳ";
            base.Load += this.Frmnodauky_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dgvtondau).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000A93 RID: 2707


        // Token: 0x04000A96 RID: 2710
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000A97 RID: 2711
        private Panel panel1;

        // Token: 0x04000A98 RID: 2712
        private RadioButton rbnophaithu;

        // Token: 0x04000A99 RID: 2713
        private RadioButton rbnophaitra;

        // Token: 0x04000A9A RID: 2714
        private TextBox txttenkhachhang;

        // Token: 0x04000A9B RID: 2715
        private Button bttim;

        // Token: 0x04000A9C RID: 2716
        private Label lbkhachhang;

        // Token: 0x04000A9D RID: 2717
        private TextBox txtmakhachhang;

        // Token: 0x04000A9E RID: 2718
        private TextBox txtghichu;

        // Token: 0x04000A9F RID: 2719
        private TextBox txtsotien;

        // Token: 0x04000AA0 RID: 2720
        private Label label1;

        // Token: 0x04000AA1 RID: 2721
        private Button button1;

        // Token: 0x04000AA2 RID: 2722
        private DataGridView dgvtondau;

        // Token: 0x04000AA3 RID: 2723
        private Button btxoa;

        // Token: 0x04000AA4 RID: 2724
        private DataGridViewTextBoxColumn MA;

        // Token: 0x04000AA5 RID: 2725
        private DataGridViewTextBoxColumn NOIDUNG;

        // Token: 0x04000AA6 RID: 2726
        private DataGridViewTextBoxColumn MAKH;

        // Token: 0x04000AA7 RID: 2727
        private DataGridViewTextBoxColumn TENKH;

        // Token: 0x04000AA8 RID: 2728
        private DataGridViewTextBoxColumn SOTIEN;

        // Token: 0x04000AA9 RID: 2729
        private DataGridViewTextBoxColumn STT;

        // Token: 0x04000AAA RID: 2730
        private DataGridViewTextBoxColumn ghichu;

        // Token: 0x04000AAB RID: 2731
        private DataGridViewTextBoxColumn NHANVIEN;

        // Token: 0x04000AAC RID: 2732
        private Button button2;

        // Token: 0x04000AAD RID: 2733
        private Button button3;

        // Token: 0x04000AAE RID: 2734
        private OpenFileDialog openFileDialog1;

        // Token: 0x04000AAF RID: 2735
        private Panel panel2;
    }
}
