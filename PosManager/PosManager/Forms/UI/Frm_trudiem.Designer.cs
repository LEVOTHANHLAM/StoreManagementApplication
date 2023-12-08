namespace PosManager.Forms.UI
{
    partial class Frm_trudiem
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
            this.txtghichu = new TextBox();
            this.txtdiem = new TextBox();
            this.comboBox1 = new ComboBox();
            this.textBox3 = new TextBox();
            this.textBox1 = new TextBox();
            this.txtdiemhientai = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.txtghichu.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtghichu.Location = new Point(2, 144);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new Size(329, 32);
            this.txtghichu.TabIndex = 17;
            this.txtghichu.Tag = "Ghi chú";
            this.txtghichu.Text = "Ghi chú";
            this.txtghichu.Enter += this.txtghichu_Enter;
            this.txtghichu.Leave += this.txtghichu_Leave;
            this.txtdiem.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtdiem.Location = new Point(222, 106);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new Size(109, 32);
            this.txtdiem.TabIndex = 0;
            this.txtdiem.Tag = "";
            this.txtdiem.Text = "0";
            this.txtdiem.TextAlign = HorizontalAlignment.Center;
            this.txtdiem.KeyPress += this.txtdiem_KeyPress;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "+",
                "-"
            });
            this.comboBox1.Location = new Point(156, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(67, 32);
            this.comboBox1.TabIndex = 14;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox3.Location = new Point(2, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(199, 32);
            this.textBox3.TabIndex = 15;
            this.textBox3.Tag = "Mã khách hàng";
            this.textBox3.Text = "Cộng trừ điểm:";
            this.textBox1.BackColor = Color.White;
            this.textBox1.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.Location = new Point(2, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(156, 32);
            this.textBox1.TabIndex = 18;
            this.textBox1.Tag = "Mã khách hàng";
            this.textBox1.Text = "Điểm hiện tại:";
            this.txtdiemhientai.BackColor = Color.White;
            this.txtdiemhientai.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtdiemhientai.Location = new Point(156, 59);
            this.txtdiemhientai.Name = "txtdiemhientai";
            this.txtdiemhientai.ReadOnly = true;
            this.txtdiemhientai.Size = new Size(175, 32);
            this.txtdiemhientai.TabIndex = 19;
            this.txtdiemhientai.Tag = "";
            this.txtdiemhientai.Text = "0";
            this.txtdiemhientai.TextAlign = HorizontalAlignment.Center;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(338, 59);
            this.button1.Name = "button1";
            this.button1.Size = new Size(131, 117);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(156, 3);
            this.button2.Name = "button2";
            this.button2.Size = new Size(177, 47);
            this.button2.TabIndex = 21;
            this.button2.Text = "Đổi hết điểm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(470, 178);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txtdiemhientai);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.txtghichu);
            base.Controls.Add(this.txtdiem);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.textBox3);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_trudiem";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cộng từ điểm thưởng";
            base.Load += this.Frm_trudiem_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        #endregion
        private TextBox txtghichu;

        // Token: 0x04000F0E RID: 3854
        private TextBox txtdiem;

        // Token: 0x04000F0F RID: 3855
        private ComboBox comboBox1;

        // Token: 0x04000F10 RID: 3856
        private TextBox textBox3;

        // Token: 0x04000F11 RID: 3857
        private TextBox textBox1;

        // Token: 0x04000F12 RID: 3858
        private TextBox txtdiemhientai;

        // Token: 0x04000F13 RID: 3859
        private Button button1;

        // Token: 0x04000F14 RID: 3860
        private Button button2;
    }
}