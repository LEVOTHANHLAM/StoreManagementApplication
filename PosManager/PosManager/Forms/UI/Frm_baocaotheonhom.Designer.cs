using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_baocaotheonhom
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
            this.listBox1 = new ListBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.dateTimePicker2 = new DateTimePicker();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.dgvchitiethanghoa = new DataGridView();
            this.TT = new DataGridViewTextBoxColumn();
            this.MAHANG = new DataGridViewTextBoxColumn();
            this.tenhang = new DataGridViewTextBoxColumn();
            this.dvt = new DataGridViewTextBoxColumn();
            this.SOLUONG = new DataGridViewTextBoxColumn();
            this.dongia = new DataGridViewTextBoxColumn();
            this.Thanhtien = new DataGridViewTextBoxColumn();
            this.HOAHONG = new DataGridViewTextBoxColumn();
            this.tendonvi = new DataGridViewTextBoxColumn();
            this.textBox3 = new TextBox();
            this.txtdiem = new TextBox();
            this.button1 = new Button();
            this.txtmkh = new TextBox();
            this.button2 = new Button();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            ((ISupportInitialize)this.dgvchitiethanghoa).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            base.SuspendLayout();
            this.listBox1.Dock = DockStyle.Fill;
            this.listBox1.Font = new Font("Times New Roman", 12f);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new Point(5, 5);
            this.listBox1.Margin = new Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(174, 689);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += this.listBox1_MouseClick;
            this.dateTimePicker1.Location = new Point(67, 1);
            this.dateTimePicker1.Margin = new Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(136, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker2.Location = new Point(272, 1);
            this.dateTimePicker2.Margin = new Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(136, 26);
            this.dateTimePicker2.TabIndex = 2;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Location = new Point(2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(100, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Từ ngày";
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(204, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(100, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Đến ngày";
            this.dgvchitiethanghoa.AllowUserToAddRows = false;
            this.dgvchitiethanghoa.AllowUserToDeleteRows = false;
            this.dgvchitiethanghoa.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvchitiethanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvchitiethanghoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiethanghoa.Columns.AddRange(new DataGridViewColumn[]
            {
                this.TT,
                this.MAHANG,
                this.tenhang,
                this.dvt,
                this.SOLUONG,
                this.dongia,
                this.Thanhtien,
                this.HOAHONG,
                this.tendonvi
            });
            this.dgvchitiethanghoa.Dock = DockStyle.Fill;
            this.dgvchitiethanghoa.Location = new Point(187, 4);
            this.dgvchitiethanghoa.Name = "dgvchitiethanghoa";
            this.dgvchitiethanghoa.ReadOnly = true;
            this.dgvchitiethanghoa.RowHeadersWidth = 4;
            this.dgvchitiethanghoa.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 224, 192);
            this.dgvchitiethanghoa.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            this.dgvchitiethanghoa.RowTemplate.Height = 27;
            this.dgvchitiethanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvchitiethanghoa.Size = new Size(818, 691);
            this.dgvchitiethanghoa.TabIndex = 8;
            this.dgvchitiethanghoa.MouseClick += this.dgvchitiethanghoa_MouseClick;
            this.TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.TT.DefaultCellStyle = dataGridViewCellStyle2;
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.TT.Width = 40;
            this.MAHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHANG.DataPropertyName = "mahanghoa";
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10f);
            this.MAHANG.DefaultCellStyle = dataGridViewCellStyle3;
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.ReadOnly = true;
            this.MAHANG.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.MAHANG.Width = 120;
            this.tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenhang.DataPropertyName = "tenhanghoa";
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 11f);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.tenhang.DefaultCellStyle = dataGridViewCellStyle4;
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            this.tenhang.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.tenhang.Width = 278;
            this.dvt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt.DataPropertyName = "donvitinh";
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 11f);
            this.dvt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvt.HeaderText = "ĐVT";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dvt.Width = 80;
            this.SOLUONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOLUONG.DataPropertyName = "tongsoluong";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle6;
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.SOLUONG.Width = 99;
            this.dongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dongia.DataPropertyName = "dongiaban";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.dongia.DefaultCellStyle = dataGridViewCellStyle7;
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Thanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle8;
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Thanhtien.Width = 140;
            this.HOAHONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HOAHONG.DataPropertyName = "HOAHONG";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.HOAHONG.DefaultCellStyle = dataGridViewCellStyle9;
            this.HOAHONG.HeaderText = "Hoa Hồng";
            this.HOAHONG.Name = "HOAHONG";
            this.HOAHONG.ReadOnly = true;
            this.HOAHONG.Visible = false;
            this.HOAHONG.Width = 110;
            this.tendonvi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 11f);
            this.tendonvi.DefaultCellStyle = dataGridViewCellStyle10;
            this.tendonvi.HeaderText = "Khách hàng";
            this.tendonvi.Name = "tendonvi";
            this.tendonvi.ReadOnly = true;
            this.tendonvi.Visible = false;
            this.tendonvi.Width = 300;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Location = new Point(691, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(100, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Điểm";
            this.txtdiem.BackColor = Color.White;
            this.txtdiem.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtdiem.ForeColor = Color.Red;
            this.txtdiem.Location = new Point(784, 1);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.ReadOnly = true;
            this.txtdiem.Size = new Size(100, 26);
            this.txtdiem.TabIndex = 10;
            this.txtdiem.Text = "0";
            this.txtdiem.TextAlign = HorizontalAlignment.Center;
            this.button1.Location = new Point(886, 0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(92, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txtmkh.BackColor = Color.White;
            this.txtmkh.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtmkh.ForeColor = Color.Red;
            this.txtmkh.Location = new Point(415, 1);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new Size(194, 26);
            this.txtmkh.TabIndex = 12;
            this.txtmkh.Tag = "Mã khách hàng";
            this.txtmkh.Text = "Mã khách hàng";
            this.txtmkh.TextAlign = HorizontalAlignment.Center;
            this.txtmkh.Enter += this.txtmkh_Enter;
            this.txtmkh.Leave += this.txtmkh_Leave;
            this.button2.Font = new Font("Times New Roman", 15f, FontStyle.Bold);
            this.button2.Location = new Point(609, 0);
            this.button2.Name = "button2";
            this.button2.Size = new Size(70, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.tableLayoutPanel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.15476f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.84524f));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvchitiethanghoa, 1, 0);
            this.tableLayoutPanel1.Location = new Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            this.tableLayoutPanel1.Size = new Size(1009, 699);
            this.tableLayoutPanel1.TabIndex = 14;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 233, 244);
            base.ClientSize = new Size(1011, 729);
            base.Controls.Add(this.tableLayoutPanel1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.txtmkh);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txtdiem);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.dateTimePicker2);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.dateTimePicker1);
            base.Controls.Add(this.textBox1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
         //   base.MinimizeBox = false;
            base.Name = "Frm_baocaotheonhom";
            //base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Báo cáo theo nhóm hàng";
            base.Load += this.Frm_baocaotheonhom_Load;
            ((ISupportInitialize)this.dgvchitiethanghoa).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        // Token: 0x04000711 RID: 1809
        private ListBox listBox1;

        // Token: 0x04000712 RID: 1810
        private DateTimePicker dateTimePicker1;

        // Token: 0x04000713 RID: 1811
        private DateTimePicker dateTimePicker2;

        // Token: 0x04000714 RID: 1812
        private TextBox textBox1;

        // Token: 0x04000715 RID: 1813
        private TextBox textBox2;

        // Token: 0x04000716 RID: 1814
        private DataGridView dgvchitiethanghoa;

        // Token: 0x04000717 RID: 1815
        private TextBox textBox3;

        // Token: 0x04000718 RID: 1816
        private TextBox txtdiem;

        // Token: 0x04000719 RID: 1817
        private DataGridViewTextBoxColumn TT;

        // Token: 0x0400071A RID: 1818
        private DataGridViewTextBoxColumn MAHANG;

        // Token: 0x0400071B RID: 1819
        private DataGridViewTextBoxColumn tenhang;

        // Token: 0x0400071C RID: 1820
        private DataGridViewTextBoxColumn dvt;

        // Token: 0x0400071D RID: 1821
        private DataGridViewTextBoxColumn SOLUONG;

        // Token: 0x0400071E RID: 1822
        private DataGridViewTextBoxColumn dongia;

        // Token: 0x0400071F RID: 1823
        private DataGridViewTextBoxColumn Thanhtien;

        // Token: 0x04000720 RID: 1824
        private DataGridViewTextBoxColumn HOAHONG;

        // Token: 0x04000721 RID: 1825
        private DataGridViewTextBoxColumn tendonvi;

        // Token: 0x04000722 RID: 1826
        private Button button1;

        // Token: 0x04000723 RID: 1827
        private TextBox txtmkh;

        // Token: 0x04000724 RID: 1828
        private Button button2;

        // Token: 0x04000725 RID: 1829
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000726 RID: 1830
        private double tienck = 0.0;

        // Token: 0x04000727 RID: 1831
        private double ptck = 0.0;
    }
}
