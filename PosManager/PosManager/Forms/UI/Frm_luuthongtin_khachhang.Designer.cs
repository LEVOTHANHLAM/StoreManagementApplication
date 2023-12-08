using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_luuthongtin_khachhang
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button1 = new Button();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.dataGridView1 = new DataGridView();
            this.textBox2 = new TextBox();
            this.button2 = new Button();
            this.button3 = new Button();
            this.flnhom = new FlowLayoutPanel();
            this.MANHOM_121 = new DataGridViewTextBoxColumn();
            this.sdt = new DataGridViewTextBoxColumn();
            this.kh = new DataGridViewTextBoxColumn();
            this.Tongtien = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.53571f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.46429f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 604);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.flnhom);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(452, 598);
            this.panel1.TabIndex = 0;
            this.button1.Location = new Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(79, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quét mã hóa đơn";
            this.textBox1.Font = new Font("Microsoft Sans Serif", 20f);
            this.textBox1.Location = new Point(185, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(264, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MANHOM_121,
                this.sdt,
                this.kh,
                this.Tongtien
            });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(461, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new Size(544, 598);
            this.dataGridView1.TabIndex = 1;
            this.textBox2.Font = new Font("Microsoft Sans Serif", 17f);
            this.textBox2.Location = new Point(83, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(245, 33);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            this.button2.Location = new Point(3, 38);
            this.button2.Name = "button2";
            this.button2.Size = new Size(79, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button3.Location = new Point(329, 3);
            this.button3.Name = "button3";
            this.button3.Size = new Size(123, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += this.button3_Click;
            this.flnhom.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            this.flnhom.AutoScroll = true;
            this.flnhom.AutoScrollMargin = new Size(1, 1);
            this.flnhom.AutoScrollMinSize = new Size(1, 1);
            this.flnhom.BackColor = SystemColors.ButtonFace;
            this.flnhom.BorderStyle = BorderStyle.FixedSingle;
            this.flnhom.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.flnhom.ForeColor = Color.White;
            this.flnhom.Location = new Point(0, 121);
            this.flnhom.Name = "flnhom";
            this.flnhom.Size = new Size(449, 478);
            this.flnhom.TabIndex = 10009;
            this.MANHOM_121.DataPropertyName = "MANHOM";
            this.MANHOM_121.HeaderText = "MANHOM";
            this.MANHOM_121.Name = "MANHOM_121";
            this.MANHOM_121.ReadOnly = true;
            this.MANHOM_121.Visible = false;
            this.sdt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sdt.DataPropertyName = "SDT";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.sdt.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 120;
            this.kh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.kh.DataPropertyName = "TENKHACHHANG";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.kh.DefaultCellStyle = dataGridViewCellStyle4;
            this.kh.HeaderText = "Khách hàng";
            this.kh.Name = "kh";
            this.kh.ReadOnly = true;
            this.Tongtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Tongtien.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            this.Tongtien.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tongtien.HeaderText = "Tổng Tiền";
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            this.Tongtien.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Tongtien.Width = 120;
            base.AutoScaleDimensions = new SizeF(12f, 23f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 604);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(6);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_luuthongtin_khachhang";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lưu thông tin hóa đơn";
            base.Load += this.Frm_luuthongtin_khachhang_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion

        // Token: 0x0400002F RID: 47
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000030 RID: 48
        private Panel panel1;

        // Token: 0x04000031 RID: 49
        private Label label1;

        // Token: 0x04000032 RID: 50
        private TextBox textBox1;

        // Token: 0x04000033 RID: 51
        private Button button1;

        // Token: 0x04000034 RID: 52
        private DataGridView dataGridView1;

        // Token: 0x04000035 RID: 53
        private TextBox textBox2;

        // Token: 0x04000036 RID: 54
        private Button button3;

        // Token: 0x04000037 RID: 55
        private Button button2;

        // Token: 0x04000038 RID: 56
        private FlowLayoutPanel flnhom;

        // Token: 0x04000039 RID: 57
        private DataGridViewTextBoxColumn MANHOM_121;

        // Token: 0x0400003A RID: 58
        private DataGridViewTextBoxColumn sdt;

        // Token: 0x0400003B RID: 59
        private DataGridViewTextBoxColumn kh;

        // Token: 0x0400003C RID: 60
        private DataGridViewTextBoxColumn Tongtien;
    }
}