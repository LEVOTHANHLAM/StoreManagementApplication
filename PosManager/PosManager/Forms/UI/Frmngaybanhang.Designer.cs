namespace PosManager.Forms.UI
{
    partial class Frmngaybanhang
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
            this.comboBox1 = new ComboBox();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.comboBox2 = new ComboBox();
            this.comboBox3 = new ComboBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.comboBox1.DropDownHeight = 369;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 42;
            this.comboBox1.Items.AddRange(new object[]
            {
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30",
                "31"
            });
            this.comboBox1.Location = new Point(203, 65);
            this.comboBox1.Margin = new Padding(21, 10, 11, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(149, 50);
            this.comboBox1.TabIndex = 0;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new Point(7, 65);
            this.textBox1.Margin = new Padding(11, 10, 11, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(219, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "NGÀY";
            this.textBox2.BackColor = Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new Point(7, 120);
            this.textBox2.Margin = new Padding(11, 10, 11, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(219, 50);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "THÁNG";
            this.comboBox2.DropDownHeight = 369;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[]
            {
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12"
            });
            this.comboBox2.Location = new Point(203, 120);
            this.comboBox2.Margin = new Padding(11, 10, 11, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(149, 50);
            this.comboBox2.TabIndex = 2;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[]
            {
                "2019",
                "2020",
                "2021",
                "2022",
                "2023",
                "2024",
                "2025",
                "2026",
                "2027",
                "2028",
                "2029",
                "2030"
            });
            this.comboBox3.Location = new Point(203, 175);
            this.comboBox3.Margin = new Padding(11, 10, 11, 10);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new Size(149, 50);
            this.comboBox3.TabIndex = 4;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new Point(7, 175);
            this.textBox3.Margin = new Padding(11, 10, 11, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(219, 50);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "NĂM";
            this.textBox4.BackColor = Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new Font("Times New Roman", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox4.Location = new Point(7, 19);
            this.textBox4.Margin = new Padding(11, 10, 11, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(345, 39);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "NGÀY BÁN HÀNG";
            this.textBox4.TextAlign = HorizontalAlignment.Center;
            this.button1.Location = new Point(7, 238);
            this.button1.Name = "button1";
            this.button1.Size = new Size(166, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.Location = new Point(187, 238);
            this.button2.Name = "button2";
            this.button2.Size = new Size(166, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "CHỌN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(22f, 42f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(362, 304);
          //  base.ControlBox = false;
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.comboBox3);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.comboBox2);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            this.Font = new Font("Times New Roman", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            base.Margin = new Padding(11, 10, 11, 10);
          //  base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "Frmngaybanhang";
           // base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += this.Frmngaybanhang_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;

        // Token: 0x04000E7F RID: 3711
        private TextBox textBox1;

        // Token: 0x04000E80 RID: 3712
        private TextBox textBox2;

        // Token: 0x04000E81 RID: 3713
        private ComboBox comboBox2;

        // Token: 0x04000E82 RID: 3714
        private ComboBox comboBox3;

        // Token: 0x04000E83 RID: 3715
        private TextBox textBox3;

        // Token: 0x04000E84 RID: 3716
        private TextBox textBox4;

        // Token: 0x04000E85 RID: 3717
        private Button button1;

        // Token: 0x04000E86 RID: 3718
        private Button button2;
    }
}
