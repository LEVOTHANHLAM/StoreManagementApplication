namespace PosManager.Forms.UI
{
    partial class Frmduyetphieu
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
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.label4 = new Label();
            this.textBox5 = new TextBox();
            this.label5 = new Label();
            this.textBox6 = new TextBox();
            this.label6 = new Label();
            this.textBox7 = new TextBox();
            this.label7 = new Label();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu chi";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(8, 136);
            this.label2.Name = "label2";
            this.label2.Size = new Size(198, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu phiếu nhập kho";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new Size(158, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên nhập kho";
            this.button1.Location = new Point(212, 277);
            this.button1.Name = "button1";
            this.button1.Size = new Size(231, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyệt phiếu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.textBox1.BackColor = Color.Yellow;
            this.textBox1.Location = new Point(212, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(231, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += this.textBox1_TextChanged;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(212, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(231, 29);
            this.textBox2.TabIndex = 3;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Location = new Point(212, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(231, 29);
            this.textBox3.TabIndex = 3;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Location = new Point(212, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(231, 29);
            this.textBox4.TabIndex = 5;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new Size(136, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền nhập kho";
            this.textBox5.BackColor = Color.White;
            this.textBox5.Location = new Point(212, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(231, 29);
            this.textBox5.TabIndex = 7;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new Size(127, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số tiền thực chi";
            this.textBox6.BackColor = Color.Yellow;
            this.textBox6.Location = new Point(212, 239);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(231, 29);
            this.textBox6.TabIndex = 2;
            this.textBox6.UseSystemPasswordChar = true;
            this.textBox6.KeyDown += this.textBox6_KeyDown;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new Size(159, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mật mã người duyệt";
            this.textBox7.BackColor = Color.Yellow;
            this.textBox7.Location = new Point(212, 205);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Size(231, 29);
            this.textBox7.TabIndex = 1;
            this.textBox7.UseSystemPasswordChar = true;
            this.textBox7.KeyDown += this.textBox7_KeyDown;
            this.textBox7.Leave += this.textBox7_Leave;
            this.label7.AutoSize = true;
            this.label7.Location = new Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new Size(155, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã nhân viên duyệt";
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(469, 382);
            base.Controls.Add(this.textBox7);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.textBox5);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
           // base.MaximizeBox = false;
            //base.MinimizeBox = false;
            base.Name = "Frmduyetphieu";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Duyệt phiếu thu chi";
            base.Load += this.Frmduyetphieu_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        // Token: 0x04000E88 RID: 3720
        private Label label1;

        // Token: 0x04000E89 RID: 3721
        private Label label2;

        // Token: 0x04000E8A RID: 3722
        private Label label3;

        // Token: 0x04000E8B RID: 3723
        private Button button1;

        // Token: 0x04000E8C RID: 3724
        private TextBox textBox1;

        // Token: 0x04000E8D RID: 3725
        private TextBox textBox2;

        // Token: 0x04000E8E RID: 3726
        private TextBox textBox3;

        // Token: 0x04000E8F RID: 3727
        private TextBox textBox4;

        // Token: 0x04000E90 RID: 3728
        private Label label4;

        // Token: 0x04000E91 RID: 3729
        private TextBox textBox5;

        // Token: 0x04000E92 RID: 3730
        private Label label5;

        // Token: 0x04000E93 RID: 3731
        private TextBox textBox6;

        // Token: 0x04000E94 RID: 3732
        private Label label6;

        // Token: 0x04000E95 RID: 3733
        private TextBox textBox7;

        // Token: 0x04000E96 RID: 3734
        private Label label7;
    }
}
