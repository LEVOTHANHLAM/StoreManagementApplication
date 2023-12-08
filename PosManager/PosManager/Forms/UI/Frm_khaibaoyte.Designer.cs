using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace PosManager.Forms.UI
{
    partial class Frm_khaibaoyte
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
            this.components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Frm_khaibaoyte));
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.pictureBox1 = new PictureBox();
            this.button1 = new Button();
            this.panel1 = new Panel();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            this.textBox2 = new TextBox();
            this.button3 = new Button();
            this.button4 = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.dateTimePicker2 = new DateTimePicker();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.button5 = new Button();
            this.dataGridView1 = new DataGridView();
            this.timer1 = new Timer(this.components);
            this.Thongtin = new DataGridViewTextBoxColumn();
            this.Thoigian = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.03571f));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.96429f));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(587, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.92798f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.12743f));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9446f));
            this.tableLayoutPanel2.Size = new Size(418, 723);
            this.tableLayoutPanel2.TabIndex = 0;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(4, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(410, 455);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.button1.BackColor = Color.Yellow;
            this.button1.Dock = DockStyle.Fill;
            this.button1.Font = new Font("Arial", 26.25f, FontStyle.Bold);
            this.button1.ForeColor = Color.Red;
            this.button1.Location = new Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(410, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thế giới sữa Mẹ Xíu";
            this.button1.UseVisualStyleBackColor = false;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(578, 723);
            this.panel1.TabIndex = 0;
            this.textBox1.Font = new Font("Times New Roman", 20f);
            this.textBox1.Location = new Point(10, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(392, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.button2.Font = new Font("Times New Roman", 19f);
            this.button2.Location = new Point(409, 9);
            this.button2.Name = "button2";
            this.button2.Size = new Size(166, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Font = new Font("Times New Roman", 20f);
            this.textBox2.ForeColor = Color.Red;
            this.textBox2.Location = new Point(10, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(565, 133);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.button3.Font = new Font("Times New Roman", 19f);
            this.button3.Location = new Point(10, 189);
            this.button3.Name = "button3";
            this.button3.Size = new Size(137, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thống kê";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button4.BackColor = Color.Yellow;
            this.button4.Dock = DockStyle.Fill;
            this.button4.Font = new Font("Arial", 26.25f, FontStyle.Bold);
            this.button4.ForeColor = Color.Red;
            this.button4.Location = new Point(4, 581);
            this.button4.Name = "button4";
            this.button4.Size = new Size(410, 138);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cảm ơn Quý khách";
            this.button4.UseVisualStyleBackColor = false;
            this.dateTimePicker1.Location = new Point(246, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(156, 29);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker2.Location = new Point(246, 223);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(156, 29);
            this.dateTimePicker2.TabIndex = 5;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Location = new Point(161, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(100, 29);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Từ ngày:";
            this.textBox4.BackColor = Color.White;
            this.textBox4.Location = new Point(161, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(100, 29);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Đến ngày:";
            this.textBox5.BackColor = Color.White;
            this.textBox5.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox5.ForeColor = Color.Red;
            this.textBox5.Location = new Point(408, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(167, 29);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = HorizontalAlignment.Center;
            this.button5.Font = new Font("Times New Roman", 14f);
            this.button5.Location = new Point(408, 189);
            this.button5.Name = "button5";
            this.button5.Size = new Size(168, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Xuất Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.Thongtin,
                this.Thoigian
            });
            this.dataGridView1.Location = new Point(10, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new Size(565, 462);
            this.dataGridView1.TabIndex = 10;
            this.timer1.Tick += this.timer1_Tick;
            this.Thongtin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thongtin.DataPropertyName = "noidung";
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.Thongtin.DefaultCellStyle = dataGridViewCellStyle;
            this.Thongtin.HeaderText = "Thông tin";
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.ReadOnly = true;
            this.Thongtin.Width = 422;
            this.Thoigian.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thoigian.DataPropertyName = "ngay";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.Thoigian.DefaultCellStyle = dataGridViewCellStyle2;
            this.Thoigian.HeaderText = "Ngày giờ";
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.ReadOnly = true;
            this.Thoigian.Width = 140;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 729);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5, 5, 5, 5);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_khaibaoyte";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Khai báo y tế";
            base.Load += this.Frm_khaibaoyte_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000A7E RID: 2686
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000A7F RID: 2687
        private TableLayoutPanel tableLayoutPanel2;

        // Token: 0x04000A80 RID: 2688
        private PictureBox pictureBox1;

        // Token: 0x04000A81 RID: 2689
        private Button button1;

        // Token: 0x04000A82 RID: 2690
        private Panel panel1;

        // Token: 0x04000A83 RID: 2691
        private TextBox textBox1;

        // Token: 0x04000A84 RID: 2692
        private Button button2;

        // Token: 0x04000A85 RID: 2693
        private TextBox textBox2;

        // Token: 0x04000A86 RID: 2694
        private Button button4;

        // Token: 0x04000A87 RID: 2695
        private Button button3;

        // Token: 0x04000A88 RID: 2696
        private TextBox textBox5;

        // Token: 0x04000A89 RID: 2697
        private DateTimePicker dateTimePicker2;

        // Token: 0x04000A8A RID: 2698
        private DateTimePicker dateTimePicker1;

        // Token: 0x04000A8B RID: 2699
        private TextBox textBox3;

        // Token: 0x04000A8C RID: 2700
        private TextBox textBox4;

        // Token: 0x04000A8D RID: 2701
        private Button button5;

        // Token: 0x04000A8E RID: 2702
        private DataGridView dataGridView1;

        // Token: 0x04000A8F RID: 2703
        private Timer timer1;

        // Token: 0x04000A90 RID: 2704
        private DataGridViewTextBoxColumn Thongtin;

        // Token: 0x04000A91 RID: 2705
        private DataGridViewTextBoxColumn Thoigian;

    }
}