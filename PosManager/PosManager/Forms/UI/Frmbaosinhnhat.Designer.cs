using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmbaosinhnhat
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.dgvkhachhang = new DataGridView();
            this.panel1 = new Panel();
            this.button2 = new Button();
            this.txtnd = new TextBox();
            this.button1 = new Button();
            this.label2 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.label1 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.chon = new DataGridViewCheckBoxColumn();
            this.NAMSINH = new DataGridViewTextBoxColumn();
            this.MASOTHUE = new DataGridViewTextBoxColumn();
            this.HOTEN = new DataGridViewTextBoxColumn();
            this.TDV = new DataGridViewTextBoxColumn();
            this.SDT = new DataGridViewTextBoxColumn();
            this.DC = new DataGridViewTextBoxColumn();
            this.EMAIL = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.diem = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.dgvkhachhang).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.dgvkhachhang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AllowUserToDeleteRows = false;
            this.dgvkhachhang.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14f);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvkhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new DataGridViewColumn[]
            {
                this.chon,
                this.NAMSINH,
                this.MASOTHUE,
                this.HOTEN,
                this.TDV,
                this.SDT,
                this.DC,
                this.EMAIL,
                this.GHICHU,
                this.diem
            });
            this.dgvkhachhang.Dock = DockStyle.Fill;
            this.dgvkhachhang.Location = new Point(3, 94);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.RowHeadersWidth = 4;
            this.dgvkhachhang.RowTemplate.Height = 39;
            this.dgvkhachhang.Size = new Size(1002, 323);
            this.dgvkhachhang.TabIndex = 1;
            this.dgvkhachhang.MouseClick += this.dgvkhachhang_MouseClick;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtnd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1002, 85);
            this.panel1.TabIndex = 2;
            this.button2.Location = new Point(915, 2);
            this.button2.Name = "button2";
            this.button2.Size = new Size(84, 80);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.txtnd.Location = new Point(471, 3);
            this.txtnd.Multiline = true;
            this.txtnd.Name = "txtnd";
            this.txtnd.Size = new Size(438, 79);
            this.txtnd.TabIndex = 5;
            this.button1.Location = new Point(313, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(152, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gửi Tin Nhắn SMS chúc mừng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new Size(85, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            this.dateTimePicker2.Location = new Point(95, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(200, 29);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += this.dateTimePicker2_ValueChanged;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày:";
            this.dateTimePicker1.Location = new Point(95, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(200, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += this.dateTimePicker1_ValueChanged;
            this.chon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.chon.DataPropertyName = "TRUE";
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.ReadOnly = true;
            this.chon.Resizable = DataGridViewTriState.True;
            this.chon.SortMode = DataGridViewColumnSortMode.Automatic;
            this.chon.Width = 58;
            this.NAMSINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.NAMSINH.DataPropertyName = "NAMSINH";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.NAMSINH.DefaultCellStyle = dataGridViewCellStyle2;
            this.NAMSINH.HeaderText = "Năm sinh";
            this.NAMSINH.Name = "NAMSINH";
            this.NAMSINH.ReadOnly = true;
            this.NAMSINH.Width = 139;
            this.MASOTHUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MASOTHUE.DataPropertyName = "MAKHACHHANG";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.MASOTHUE.DefaultCellStyle = dataGridViewCellStyle3;
            this.MASOTHUE.HeaderText = "Mã kh";
            this.MASOTHUE.Name = "MASOTHUE";
            this.MASOTHUE.ReadOnly = true;
            this.MASOTHUE.Visible = false;
            this.MASOTHUE.Width = 130;
            this.HOTEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HOTEN.DataPropertyName = "TENKHACHHANG";
            this.HOTEN.HeaderText = "Tên khách hàng";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 279;
            this.TDV.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TDV.DataPropertyName = "TENDONVI";
            this.TDV.HeaderText = "Tên công ty";
            this.TDV.Name = "TDV";
            this.TDV.ReadOnly = true;
            this.TDV.Visible = false;
            this.TDV.Width = 300;
            this.SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
            this.DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DC.DataPropertyName = "DIACHI";
            this.DC.HeaderText = "Địa chỉ";
            this.DC.Name = "DC";
            this.DC.ReadOnly = true;
            this.DC.Width = 200;
            this.EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Visible = false;
            this.diem.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.diem.DataPropertyName = "DIEM";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.diem.DefaultCellStyle = dataGridViewCellStyle4;
            this.diem.HeaderText = "Điểm";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            this.diem.Width = 179;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.PaleTurquoise;
            base.ClientSize = new Size(1008, 420);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 14f);
            base.Margin = new Padding(7, 4, 7, 4);
          //  base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frmbaosinhnhat";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Báo Sinh nhật khách hàng";
          //  base.FormClosed += this.Frmbaosinhnhat_FormClosed;
            base.Load += this.Frmbaosinhnhat_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvkhachhang).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000347 RID: 839
    //    private IContainer components = null;

        // Token: 0x04000348 RID: 840
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x04000349 RID: 841
        private DataGridView dgvkhachhang;

        // Token: 0x0400034A RID: 842
        private Panel panel1;

        // Token: 0x0400034B RID: 843
        private Label label2;

        // Token: 0x0400034C RID: 844
        private DateTimePicker dateTimePicker2;

        // Token: 0x0400034D RID: 845
        private Label label1;

        // Token: 0x0400034E RID: 846
        private DateTimePicker dateTimePicker1;

        // Token: 0x0400034F RID: 847
        private Button button1;

        // Token: 0x04000350 RID: 848
        private TextBox txtnd;

        // Token: 0x04000351 RID: 849
        private Button button2;

        // Token: 0x04000352 RID: 850
        private DataGridViewCheckBoxColumn chon;

        // Token: 0x04000353 RID: 851
        private DataGridViewTextBoxColumn NAMSINH;

        // Token: 0x04000354 RID: 852
        private DataGridViewTextBoxColumn MASOTHUE;

        // Token: 0x04000355 RID: 853
        private DataGridViewTextBoxColumn HOTEN;

        // Token: 0x04000356 RID: 854
        private DataGridViewTextBoxColumn TDV;

        // Token: 0x04000357 RID: 855
        private DataGridViewTextBoxColumn SDT;

        // Token: 0x04000358 RID: 856
        private DataGridViewTextBoxColumn DC;

        // Token: 0x04000359 RID: 857
        private DataGridViewTextBoxColumn EMAIL;

        // Token: 0x0400035A RID: 858
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x0400035B RID: 859
        private DataGridViewTextBoxColumn diem;

        // Token: 0x0400035C RID: 860
        public static int songay = 0;

        // Token: 0x0400035D RID: 861
        //private SerialPort P = new SerialPort();
    }
}
