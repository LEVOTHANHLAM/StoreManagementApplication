using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmdinhluong
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button1 = new Button();
            this.txttimten = new TextBox();
            this.txttimma = new TextBox();
            this.textBox1 = new TextBox();
            this.cobnhom = new ComboBox();
            this.dgvhanghoa = new DataGridView();
            this.panel2 = new Panel();
            this.textBox2 = new TextBox();
            this.dgvdl = new DataGridView();
            this.manguyenlieu = new DataGridViewTextBoxColumn();
            this.tennguyenlieu = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.sl = new DataGridViewTextBoxColumn();
            this.Giavon = new DataGridViewTextBoxColumn();
            this.xoa = new DataGridViewButtonColumn();
            this.txttsl = new TextBox();
            this.btnguyenlieu = new Button();
            this.txtmahang = new TextBox();
            this.dgvtennguyenlieu = new DataGridView();
            this.txttenhang = new TextBox();
            this.txttennl = new TextBox();
            this.txtthanhtien = new TextBox();
            this.MAHANGHOA = new DataGridViewTextBoxColumn();
            this.tenhang = new DataGridViewTextBoxColumn();
            this.ĐVT = new DataGridViewTextBoxColumn();
            this.dg = new DataGridViewTextBoxColumn();
            this.manl = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.donvitinh = new DataGridViewTextBoxColumn();
            this.TON = new DataGridViewTextBoxColumn();
            this.gv = new DataGridViewTextBoxColumn();
            this.Them = new DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvhanghoa).BeginInit();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)this.dgvdl).BeginInit();
            ((ISupportInitialize)this.dgvtennguyenlieu).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.36066f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.63934f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            this.tableLayoutPanel1.Size = new Size(1220, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txttimten);
            this.panel1.Controls.Add(this.txttimma);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cobnhom);
            this.panel1.Controls.Add(this.dgvhanghoa);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(582, 476);
            this.panel1.TabIndex = 0;
            this.button1.Location = new Point(465, 33);
            this.button1.Name = "button1";
            this.button1.Size = new Size(115, 29);
            this.button1.TabIndex = 68;
            this.button1.Text = "Thêm hàng hóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txttimten.BackColor = Color.White;
            this.txttimten.Location = new Point(167, 35);
            this.txttimten.Name = "txttimten";
            this.txttimten.Size = new Size(294, 26);
            this.txttimten.TabIndex = 58;
            this.txttimten.Tag = "Tìm tên hàng - F3";
            this.txttimten.Text = "Tìm tên hàng - F3";
            this.txttimten.TextChanged += this.txttimten_TextChanged;
            this.txttimten.Enter += this.txttimten_Enter;
            this.txttimten.Leave += this.txttimten_Leave;
            this.txttimma.BackColor = Color.White;
            this.txttimma.Location = new Point(4, 35);
            this.txttimma.Name = "txttimma";
            this.txttimma.Size = new Size(157, 26);
            this.txttimma.TabIndex = 57;
            this.txttimma.Tag = "Tìm mã hàng - F2";
            this.txttimma.Text = "Tìm mã hàng - F2";
            this.txttimma.TextChanged += this.txttimma_TextChanged;
            this.txttimma.Enter += this.txttimma_Enter;
            this.txttimma.Leave += this.txttimma_Leave;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Location = new Point(4, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(157, 26);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "Nhóm hàng";
            this.textBox1.Enter += this.textBox1_Enter;
            this.cobnhom.BackColor = Color.White;
            this.cobnhom.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobnhom.FlatStyle = FlatStyle.Flat;
            this.cobnhom.Font = new Font("Times New Roman", 11f);
            this.cobnhom.FormattingEnabled = true;
            this.cobnhom.Location = new Point(167, 8);
            this.cobnhom.Name = "cobnhom";
            this.cobnhom.Size = new Size(412, 25);
            this.cobnhom.TabIndex = 55;
            this.cobnhom.Tag = "Chọn Nhóm";
            this.cobnhom.SelectedIndexChanged += this.cobnhom_SelectedIndexChanged;
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AllowUserToDeleteRows = false;
            this.dgvhanghoa.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvhanghoa.BackgroundColor = Color.LightSteelBlue;
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
                this.MAHANGHOA,
                this.tenhang,
                this.ĐVT,
                this.dg
            });
            this.dgvhanghoa.Location = new Point(4, 67);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.ReadOnly = true;
            this.dgvhanghoa.RowHeadersVisible = false;
            this.dgvhanghoa.RowTemplate.Height = 30;
            this.dgvhanghoa.Size = new Size(575, 406);
            this.dgvhanghoa.TabIndex = 0;
            this.dgvhanghoa.MouseClick += this.dgvhanghoa_MouseClick;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.dgvdl);
            this.panel2.Controls.Add(this.txttsl);
            this.panel2.Controls.Add(this.btnguyenlieu);
            this.panel2.Controls.Add(this.txtmahang);
            this.panel2.Controls.Add(this.dgvtennguyenlieu);
            this.panel2.Controls.Add(this.txttenhang);
            this.panel2.Controls.Add(this.txttennl);
            this.panel2.Controls.Add(this.txtthanhtien);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(593, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(623, 476);
            this.panel2.TabIndex = 1;
            this.textBox2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.textBox2.BackColor = Color.FromArgb(222, 232, 244);
            this.textBox2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox2.Location = new Point(0, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(157, 29);
            this.textBox2.TabIndex = 70;
            this.textBox2.Text = "Tổng Cộng:";
            this.dgvdl.AllowUserToAddRows = false;
            this.dgvdl.AllowUserToDeleteRows = false;
            this.dgvdl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvdl.BackgroundColor = Color.LightSteelBlue;
            this.dgvdl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdl.Columns.AddRange(new DataGridViewColumn[]
            {
                this.manguyenlieu,
                this.tennguyenlieu,
                this.dataGridViewTextBoxColumn3,
                this.sl,
                this.Giavon,
                this.xoa
            });
            this.dgvdl.Location = new Point(0, 371);
            this.dgvdl.Name = "dgvdl";
            this.dgvdl.ReadOnly = true;
            this.dgvdl.RowHeadersVisible = false;
            this.dgvdl.RowTemplate.Height = 30;
            this.dgvdl.Size = new Size(622, 81);
            this.dgvdl.TabIndex = 62;
            this.dgvdl.CellEndEdit += this.dgvdl_CellEndEdit;
            this.dgvdl.MouseClick += this.dgvdl_MouseClick;
            this.manguyenlieu.DataPropertyName = "MANGUYENLIEU";
            this.manguyenlieu.HeaderText = "manguyenlieu";
            this.manguyenlieu.Name = "manguyenlieu";
            this.manguyenlieu.ReadOnly = true;
            this.manguyenlieu.Visible = false;
            this.tennguyenlieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tennguyenlieu.DataPropertyName = "tenhanghoa";
            this.tennguyenlieu.HeaderText = "Tên Hàng";
            this.tennguyenlieu.Name = "tennguyenlieu";
            this.tennguyenlieu.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "donvitinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đvt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            this.sl.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sl.DataPropertyName = "SL";
            this.sl.HeaderText = "Sốlượng";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 70;
            this.Giavon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Giavon.DataPropertyName = "giavon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.Giavon.DefaultCellStyle = dataGridViewCellStyle2;
            this.Giavon.HeaderText = "Giá vốn";
            this.Giavon.Name = "Giavon";
            this.Giavon.ReadOnly = true;
            this.Giavon.Width = 110;
            this.xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 50;
            this.txttsl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txttsl.BackColor = Color.FromArgb(222, 232, 244);
            this.txttsl.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
            this.txttsl.ForeColor = Color.Red;
            this.txttsl.Location = new Point(0, 451);
            this.txttsl.Name = "txttsl";
            this.txttsl.ReadOnly = true;
            this.txttsl.Size = new Size(459, 29);
            this.txttsl.TabIndex = 68;
            this.txttsl.TextAlign = HorizontalAlignment.Right;
            this.btnguyenlieu.Location = new Point(454, 30);
            this.btnguyenlieu.Name = "btnguyenlieu";
            this.btnguyenlieu.Size = new Size(167, 27);
            this.btnguyenlieu.TabIndex = 67;
            this.btnguyenlieu.Text = "Thêm tên nguyên liệu";
            this.btnguyenlieu.UseVisualStyleBackColor = true;
            this.btnguyenlieu.Click += this.btnguyenlieu_Click;
            this.txtmahang.BackColor = Color.White;
            this.txtmahang.Location = new Point(0, 3);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.ReadOnly = true;
            this.txtmahang.Size = new Size(180, 26);
            this.txtmahang.TabIndex = 59;
            this.txtmahang.Tag = "Mã hàng";
            this.txtmahang.Text = "Mã hàng";
            this.dgvtennguyenlieu.AllowUserToAddRows = false;
            this.dgvtennguyenlieu.AllowUserToDeleteRows = false;
            this.dgvtennguyenlieu.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvtennguyenlieu.BackgroundColor = Color.LightSteelBlue;
            this.dgvtennguyenlieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtennguyenlieu.Columns.AddRange(new DataGridViewColumn[]
            {
                this.manl,
                this.dataGridViewTextBoxColumn4,
                this.donvitinh,
                this.TON,
                this.gv,
                this.Them
            });
            this.dgvtennguyenlieu.Location = new Point(1, 59);
            this.dgvtennguyenlieu.Name = "dgvtennguyenlieu";
            this.dgvtennguyenlieu.ReadOnly = true;
            this.dgvtennguyenlieu.RowHeadersVisible = false;
            this.dgvtennguyenlieu.RowTemplate.Height = 30;
            this.dgvtennguyenlieu.Size = new Size(622, 306);
            this.dgvtennguyenlieu.TabIndex = 66;
            this.dgvtennguyenlieu.CellDoubleClick += this.dgvtennguyenlieu_CellDoubleClick;
            this.dgvtennguyenlieu.KeyDown += this.dgvtennguyenlieu_KeyDown;
            this.dgvtennguyenlieu.MouseClick += this.dgvtennguyenlieu_MouseClick;
            this.txttenhang.BackColor = Color.White;
            this.txttenhang.Location = new Point(179, 3);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.ReadOnly = true;
            this.txttenhang.Size = new Size(441, 26);
            this.txttenhang.TabIndex = 61;
            this.txttenhang.Tag = "Tên hàng";
            this.txttenhang.Text = "Tên hàng";
            this.txttennl.BackColor = Color.White;
            this.txttennl.Location = new Point(0, 31);
            this.txttennl.Name = "txttennl";
            this.txttennl.Size = new Size(180, 26);
            this.txttennl.TabIndex = 60;
            this.txttennl.Tag = "Lọc nguyên liệu - F1";
            this.txttennl.Text = "Lọc nguyên liệu - F1";
            this.txttennl.TextChanged += this.txttennl_TextChanged;
            this.txttennl.Enter += this.txttennl_Enter;
            this.txttennl.KeyDown += this.txttennl_KeyDown;
            this.txttennl.Leave += this.txttennl_Leave;
            this.txtthanhtien.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtthanhtien.BackColor = Color.FromArgb(222, 232, 244);
            this.txtthanhtien.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
            this.txtthanhtien.ForeColor = Color.Red;
            this.txtthanhtien.Location = new Point(454, 451);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new Size(122, 29);
            this.txtthanhtien.TabIndex = 69;
            this.txtthanhtien.TextAlign = HorizontalAlignment.Right;
            this.MAHANGHOA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHANGHOA.DataPropertyName = "mahanghoa";
            this.MAHANGHOA.HeaderText = "Mã Hàng";
            this.MAHANGHOA.Name = "MAHANGHOA";
            this.MAHANGHOA.ReadOnly = true;
            this.MAHANGHOA.Width = 120;
            this.tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenhang.DataPropertyName = "tenhanghoa";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            this.tenhang.Width = 278;
            this.ĐVT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ĐVT.DataPropertyName = "donvitinh";
            this.ĐVT.HeaderText = "Đvt";
            this.ĐVT.Name = "ĐVT";
            this.ĐVT.ReadOnly = true;
            this.ĐVT.Width = 60;
            this.dg.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dg.DataPropertyName = "DONGIA";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.dg.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg.HeaderText = "Đơn Giá";
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Width = 85;
            this.manl.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.manl.DataPropertyName = "mahanghoa";
            this.manl.HeaderText = "Mã nguyên liệu";
            this.manl.Name = "manl";
            this.manl.ReadOnly = true;
            this.manl.Width = 150;
            this.dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tenhanghoa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên nguyên liệu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            this.donvitinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đvt";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.ReadOnly = true;
            this.donvitinh.Width = 60;
            this.TON.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TON.DataPropertyName = "sl";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            this.TON.DefaultCellStyle = dataGridViewCellStyle4;
            this.TON.HeaderText = "SLTồn";
            this.TON.Name = "TON";
            this.TON.ReadOnly = true;
            this.TON.Width = 70;
            this.gv.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.gv.DataPropertyName = "gv";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.gv.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv.HeaderText = "Giá vốn";
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.Width = 90;
            this.Them.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Them.HeaderText = "Chọn";
            this.Them.Name = "Them";
            this.Them.ReadOnly = true;
            this.Them.Text = "Chọn";
            this.Them.UseColumnTextForButtonValue = true;
            this.Them.Width = 70;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(1220, 484);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
          //  base.KeyPreview = true;
            base.Margin = new Padding(4);
           // base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frmdinhluong";
           // base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Định mức hàng hóa";
            base.Load += this.Frmdinhluong_Load;
            base.KeyDown += this.Frmdinhluong_KeyDown;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dgvhanghoa).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((ISupportInitialize)this.dgvdl).EndInit();
            ((ISupportInitialize)this.dgvtennguyenlieu).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000092 RID: 146
      //  private IContainer components = null;

        // Token: 0x04000093 RID: 147
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000094 RID: 148
        private Panel panel1;

        // Token: 0x04000095 RID: 149
        private Panel panel2;

        // Token: 0x04000096 RID: 150
        private DataGridView dgvhanghoa;

        // Token: 0x04000097 RID: 151
        private ComboBox cobnhom;

        // Token: 0x04000098 RID: 152
        private TextBox textBox1;

        // Token: 0x04000099 RID: 153
        private TextBox txttimten;

        // Token: 0x0400009A RID: 154
        private TextBox txttimma;

        // Token: 0x0400009B RID: 155
        private TextBox txttenhang;

        // Token: 0x0400009C RID: 156
        private TextBox txttennl;

        // Token: 0x0400009D RID: 157
        private DataGridView dgvdl;

        // Token: 0x0400009E RID: 158
        private DataGridView dgvtennguyenlieu;

        // Token: 0x0400009F RID: 159
        private TextBox txtmahang;

        // Token: 0x040000A0 RID: 160
        private Button btnguyenlieu;

        // Token: 0x040000A1 RID: 161
        private Button button1;

        // Token: 0x040000A2 RID: 162
        private TextBox txtthanhtien;

        // Token: 0x040000A3 RID: 163
        private TextBox txttsl;

        // Token: 0x040000A4 RID: 164
        private DataGridViewTextBoxColumn manguyenlieu;

        // Token: 0x040000A5 RID: 165
        private DataGridViewTextBoxColumn tennguyenlieu;

        // Token: 0x040000A6 RID: 166
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        // Token: 0x040000A7 RID: 167
        private DataGridViewTextBoxColumn sl;

        // Token: 0x040000A8 RID: 168
        private DataGridViewTextBoxColumn Giavon;

        // Token: 0x040000A9 RID: 169
        private DataGridViewButtonColumn xoa;

        // Token: 0x040000AA RID: 170
        private TextBox textBox2;

        // Token: 0x040000AB RID: 171
        private DataGridViewTextBoxColumn MAHANGHOA;

        // Token: 0x040000AC RID: 172
        private DataGridViewTextBoxColumn tenhang;

        // Token: 0x040000AD RID: 173
        private DataGridViewTextBoxColumn ĐVT;

        // Token: 0x040000AE RID: 174
        private DataGridViewTextBoxColumn dg;

        // Token: 0x040000AF RID: 175
        private DataGridViewTextBoxColumn manl;

        // Token: 0x040000B0 RID: 176
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        // Token: 0x040000B1 RID: 177
        private DataGridViewTextBoxColumn donvitinh;

        // Token: 0x040000B2 RID: 178
        private DataGridViewTextBoxColumn TON;

        // Token: 0x040000B3 RID: 179
        private DataGridViewTextBoxColumn gv;

        // Token: 0x040000B4 RID: 180
        private DataGridViewButtonColumn Them;
    }
}
