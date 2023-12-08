using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_tientang
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

        #region Windows Form Designer generated code

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
            this.button1 = new Button();
            this.txtghichu = new TextBox();
            this.txtdiem = new TextBox();
            this.comboBox1 = new ComboBox();
            this.txttenkhachhang = new TextBox();
            this.txtmakh = new TextBox();
            this.dgvdiem = new DataGridView();
            this.NGAY = new DataGridViewTextBoxColumn();
            this.sotien = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.btsotien = new Button();
            this.button3 = new Button();
            this.button2 = new Button();
            this.panel2 = new Panel();
            this.dgvtien = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.sotien2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.button4 = new Button();
            ((ISupportInitialize)this.dgvdiem).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.dgvtien).BeginInit();
            base.SuspendLayout();
            this.button1.Font = new Font("Microsoft Sans Serif", 14f);
            this.button1.Location = new Point(818, 81);
            this.button1.Name = "button1";
            this.button1.Size = new Size(184, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bảng kê\r\nTất cả khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txtghichu.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtghichu.Location = new Point(362, 46);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(440, 32);
            this.txtghichu.TabIndex = 21;
            this.txtghichu.Tag = "Ghi chú";
            this.txtghichu.Text = "Ghi chú";
            this.txtghichu.Enter += this.txtghichu_Enter;
            this.txtghichu.Leave += this.txtghichu_Leave;
            this.txtdiem.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtdiem.Location = new Point(223, 46);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new Size(130, 32);
            this.txtdiem.TabIndex = 18;
            this.txtdiem.Tag = "";
            this.txtdiem.Text = "0";
            this.txtdiem.TextAlign = HorizontalAlignment.Center;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Popup;
            this.comboBox1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "Trừ tiền",
                "Cộng tiền"
            });
            this.comboBox1.Location = new Point(3, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(221, 32);
            this.comboBox1.TabIndex = 16;
            this.txttenkhachhang.BackColor = Color.White;
            this.txttenkhachhang.Font = new Font("Microsoft Sans Serif", 15f);
            this.txttenkhachhang.Location = new Point(223, 6);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.ReadOnly = true;
            this.txttenkhachhang.Size = new Size(579, 30);
            this.txttenkhachhang.TabIndex = 15;
            this.txttenkhachhang.Tag = "Tên khách hàng";
            this.txttenkhachhang.Text = "Tên khách hàng";
            this.txtmakh.Font = new Font("Microsoft Sans Serif", 15f);
            this.txtmakh.Location = new Point(3, 6);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new Size(221, 30);
            this.txtmakh.TabIndex = 14;
            this.txtmakh.Tag = "Mã khách hàng";
            this.txtmakh.Text = "Mã khách hàng";
            this.txtmakh.TextChanged += this.txtmakh_TextChanged;
            this.txtmakh.Enter += this.txtmakh_Enter;
            this.txtmakh.Leave += this.txtmakh_Leave;
            this.dgvdiem.AllowUserToAddRows = false;
            this.dgvdiem.AllowUserToDeleteRows = false;
            this.dgvdiem.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvdiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvdiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiem.Columns.AddRange(new DataGridViewColumn[]
            {
                this.NGAY,
                this.sotien,
                this.GHICHU
            });
            this.dgvdiem.Dock = DockStyle.Fill;
            this.dgvdiem.Location = new Point(0, 0);
            this.dgvdiem.Name = "dgvdiem";
            this.dgvdiem.ReadOnly = true;
            this.dgvdiem.RowHeadersVisible = false;
            this.dgvdiem.RowTemplate.Height = 35;
            this.dgvdiem.Size = new Size(1002, 571);
            this.dgvdiem.TabIndex = 22;
            this.NGAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NGAY.DataPropertyName = "NGAY";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.NGAY.DefaultCellStyle = dataGridViewCellStyle2;
            this.NGAY.HeaderText = "Ngày";
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            this.NGAY.Width = 138;
            this.sotien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sotien.DataPropertyName = "sotien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.sotien.DefaultCellStyle = dataGridViewCellStyle3;
            this.sotien.HeaderText = "Số tiền";
            this.sotien.Name = "sotien";
            this.sotien.ReadOnly = true;
            this.sotien.Width = 200;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 152f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 23;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btsotien);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txttenkhachhang);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtmakh);
            this.panel1.Controls.Add(this.txtdiem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1002, 146);
            this.panel1.TabIndex = 0;
            this.btsotien.Font = new Font("Microsoft Sans Serif", 14f);
            this.btsotien.Location = new Point(283, 93);
            this.btsotien.Name = "btsotien";
            this.btsotien.Size = new Size(397, 53);
            this.btsotien.TabIndex = 24;
            this.btsotien.UseVisualStyleBackColor = true;
            this.button3.Font = new Font("Microsoft Sans Serif", 14f);
            this.button3.Location = new Point(3, 93);
            this.button3.Name = "button3";
            this.button3.Size = new Size(221, 53);
            this.button3.TabIndex = 23;
            this.button3.Text = "Thực hiện";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button2.Font = new Font("Microsoft Sans Serif", 14f);
            this.button2.Location = new Point(818, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(184, 73);
            this.button2.TabIndex = 22;
            this.button2.Text = "Tìm khách hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.panel2.Controls.Add(this.dgvtien);
            this.panel2.Controls.Add(this.dgvdiem);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(3, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1002, 571);
            this.panel2.TabIndex = 1;
            this.dgvtien.AllowUserToAddRows = false;
            this.dgvtien.AllowUserToDeleteRows = false;
            this.dgvtien.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.dgvtien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtien.Columns.AddRange(new DataGridViewColumn[]
            {
                this.dataGridViewTextBoxColumn1,
                this.sotien2,
                this.dataGridViewTextBoxColumn3
            });
            this.dgvtien.Dock = DockStyle.Fill;
            this.dgvtien.Location = new Point(0, 0);
            this.dgvtien.Name = "dgvtien";
            this.dgvtien.ReadOnly = true;
            this.dgvtien.RowHeadersVisible = false;
            this.dgvtien.RowTemplate.Height = 35;
            this.dgvtien.Size = new Size(1002, 571);
            this.dgvtien.TabIndex = 23;
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENKHACHHANG";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 438;
            this.sotien2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sotien2.DataPropertyName = "sotien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.sotien2.DefaultCellStyle = dataGridViewCellStyle6;
            this.sotien2.HeaderText = "Số tiền";
            this.sotien2.Name = "sotien2";
            this.sotien2.ReadOnly = true;
            this.sotien2.Width = 200;
            this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.button4.Font = new Font("Microsoft Sans Serif", 14f);
            this.button4.Location = new Point(734, 94);
            this.button4.Name = "button4";
            this.button4.Size = new Size(68, 53);
            this.button4.TabIndex = 25;
            this.button4.Text = "> 0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.button4_Click;
            base.AutoScaleDimensions = new SizeF(9f, 20f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 729);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4, 5, 4, 5);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_tientang";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tiền khuyến mãi";
            base.Load += this.Frm_tientang_Load;
            ((ISupportInitialize)this.dgvdiem).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvtien).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x0400010F RID: 271
        private Button button1;

        // Token: 0x04000110 RID: 272
        private TextBox txtghichu;

        // Token: 0x04000111 RID: 273
        private TextBox txtdiem;

        // Token: 0x04000112 RID: 274
        private ComboBox comboBox1;

        // Token: 0x04000113 RID: 275
        private TextBox txttenkhachhang;

        // Token: 0x04000114 RID: 276
        private TextBox txtmakh;

        // Token: 0x04000115 RID: 277
        private DataGridView dgvdiem;

        // Token: 0x04000116 RID: 278
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000117 RID: 279
        private Panel panel1;

        // Token: 0x04000118 RID: 280
        private Button button2;

        // Token: 0x04000119 RID: 281
        private Panel panel2;

        // Token: 0x0400011A RID: 282
        private Button button3;

        // Token: 0x0400011B RID: 283
        private Button btsotien;

        // Token: 0x0400011C RID: 284
        private DataGridView dgvtien;

        // Token: 0x0400011D RID: 285
        private DataGridViewTextBoxColumn NGAY;

        // Token: 0x0400011E RID: 286
        private DataGridViewTextBoxColumn sotien;

        // Token: 0x0400011F RID: 287
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x04000120 RID: 288
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        // Token: 0x04000121 RID: 289
        private DataGridViewTextBoxColumn sotien2;

        // Token: 0x04000122 RID: 290
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        // Token: 0x04000123 RID: 291
        private Button button4;
    }
}