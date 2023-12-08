namespace PosManager.Forms.UI
{
    partial class FrmInhoadonvat
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnhaphoadon = new Button();
            btmenu = new Button();
            btthoat = new Button();
            btkhachhang = new Button();
            btcaocaohoadon = new Button();
            btxuathoadon = new Button();
            bt = new Button();
            bttonkho = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.08167F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.65336F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.355717F));
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.927798F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.51986F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.37184F));
            tableLayoutPanel1.Size = new Size(1102, 554);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 192, 0);
            textBox1.Location = new Point(58, 493);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(992, 44);
            textBox1.TabIndex = 0;
            textBox1.Text = "PHẦN MỀM TOÀN CẦU - HOTLINE: 0975 788 409";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(btnhaphoadon, 1, 0);
            tableLayoutPanel2.Controls.Add(btmenu, 0, 2);
            tableLayoutPanel2.Controls.Add(btthoat, 2, 2);
            tableLayoutPanel2.Controls.Add(btkhachhang, 1, 2);
            tableLayoutPanel2.Controls.Add(btcaocaohoadon, 2, 0);
            tableLayoutPanel2.Controls.Add(btxuathoadon, 0, 0);
            tableLayoutPanel2.Controls.Add(bt, 0, 1);
            tableLayoutPanel2.Controls.Add(bttonkho, 1, 1);
            tableLayoutPanel2.Controls.Add(button1, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(58, 58);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(992, 429);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnhaphoadon
            // 
            btnhaphoadon.Dock = DockStyle.Fill;
            btnhaphoadon.FlatStyle = FlatStyle.Flat;
            btnhaphoadon.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnhaphoadon.ForeColor = Color.White;
            btnhaphoadon.Location = new Point(333, 3);
            btnhaphoadon.Name = "btnhaphoadon";
            btnhaphoadon.Size = new Size(324, 137);
            btnhaphoadon.TabIndex = 1;
            btnhaphoadon.Text = "NHẬP HÓA ĐƠN";
            btnhaphoadon.UseVisualStyleBackColor = true;
            btnhaphoadon.Click += btnhaphoadon_Click;
            // 
            // btmenu
            // 
            btmenu.Dock = DockStyle.Fill;
            btmenu.FlatStyle = FlatStyle.Flat;
            btmenu.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btmenu.ForeColor = Color.White;
            btmenu.Location = new Point(3, 289);
            btmenu.Name = "btmenu";
            btmenu.Size = new Size(324, 137);
            btmenu.TabIndex = 6;
            btmenu.Text = "ĐỔI MẬT KHẨU";
            btmenu.UseVisualStyleBackColor = true;
            btmenu.Click += btmenu_Click;
            // 
            // btthoat
            // 
            btthoat.Dock = DockStyle.Fill;
            btthoat.FlatStyle = FlatStyle.Flat;
            btthoat.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btthoat.ForeColor = Color.White;
            btthoat.Location = new Point(663, 289);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(326, 137);
            btthoat.TabIndex = 2;
            btthoat.Text = "THOÁT";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btkhachhang_Click;
            // 
            // btkhachhang
            // 
            btkhachhang.Dock = DockStyle.Fill;
            btkhachhang.FlatStyle = FlatStyle.Flat;
            btkhachhang.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btkhachhang.ForeColor = Color.White;
            btkhachhang.Location = new Point(333, 289);
            btkhachhang.Name = "btkhachhang";
            btkhachhang.Size = new Size(324, 137);
            btkhachhang.TabIndex = 5;
            btkhachhang.Text = "KHÁCH HÀNG";
            btkhachhang.UseVisualStyleBackColor = true;
            btkhachhang.Click += btkhachhang_Click_1;
            // 
            // btcaocaohoadon
            // 
            btcaocaohoadon.Dock = DockStyle.Fill;
            btcaocaohoadon.FlatStyle = FlatStyle.Flat;
            btcaocaohoadon.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btcaocaohoadon.ForeColor = Color.White;
            btcaocaohoadon.Location = new Point(663, 3);
            btcaocaohoadon.Name = "btcaocaohoadon";
            btcaocaohoadon.Size = new Size(326, 137);
            btcaocaohoadon.TabIndex = 7;
            btcaocaohoadon.Text = "BẢNG KÊ HÓA ĐƠN";
            btcaocaohoadon.UseVisualStyleBackColor = true;
            btcaocaohoadon.Click += btcaocaohoadon_Click_1;
            // 
            // btxuathoadon
            // 
            btxuathoadon.Dock = DockStyle.Fill;
            btxuathoadon.FlatStyle = FlatStyle.Flat;
            btxuathoadon.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btxuathoadon.ForeColor = Color.White;
            btxuathoadon.Location = new Point(3, 3);
            btxuathoadon.Name = "btxuathoadon";
            btxuathoadon.Size = new Size(324, 137);
            btxuathoadon.TabIndex = 0;
            btxuathoadon.Text = "XUẤT HÓA ĐƠN";
            btxuathoadon.UseVisualStyleBackColor = true;
            btxuathoadon.Click += btxuathoadon_Click;
            // 
            // bt
            // 
            bt.Dock = DockStyle.Fill;
            bt.FlatStyle = FlatStyle.Flat;
            bt.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt.ForeColor = Color.White;
            bt.Location = new Point(3, 146);
            bt.Name = "bt";
            bt.Size = new Size(324, 137);
            bt.TabIndex = 8;
            bt.Text = "SỐ HÓA ĐƠN";
            bt.UseVisualStyleBackColor = true;
            bt.Click += bt_Click;
            // 
            // bttonkho
            // 
            bttonkho.Dock = DockStyle.Fill;
            bttonkho.FlatStyle = FlatStyle.Flat;
            bttonkho.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttonkho.ForeColor = Color.White;
            bttonkho.Location = new Point(333, 146);
            bttonkho.Name = "bttonkho";
            bttonkho.Size = new Size(324, 137);
            bttonkho.TabIndex = 9;
            bttonkho.Text = "TỒN KHO HÀNG HÓA";
            bttonkho.UseVisualStyleBackColor = true;
            bttonkho.Click += bttonkho_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(663, 146);
            button1.Name = "button1";
            button1.Size = new Size(326, 137);
            button1.TabIndex = 10;
            button1.Text = "TẠO MỚI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmInhoadonvat
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmInhoadonvat";
            Size = new Size(1102, 554);
            Load += FrmInhoadonvat_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        // Token: 0x0400084A RID: 2122
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x0400084B RID: 2123
        private TextBox textBox1;

        // Token: 0x0400084C RID: 2124
        private TableLayoutPanel tableLayoutPanel2;

        // Token: 0x0400084D RID: 2125
        private Button btthoat;

        // Token: 0x0400084E RID: 2126
        private Button btnhaphoadon;

        // Token: 0x0400084F RID: 2127
        private Button btxuathoadon;

        // Token: 0x04000850 RID: 2128
        private Button btkhachhang;

        // Token: 0x04000851 RID: 2129
        private Button btmenu;

        // Token: 0x04000852 RID: 2130
        private Button btcaocaohoadon;

        // Token: 0x04000853 RID: 2131
        private Button bt;

        // Token: 0x04000854 RID: 2132
        private Button bttonkho;

        // Token: 0x04000855 RID: 2133
        private Button button1;
    }
}
