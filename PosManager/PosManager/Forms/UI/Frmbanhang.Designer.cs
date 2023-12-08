using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmbanhang
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
            this.checkBox1 = new CheckBox();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.checkBox2 = new CheckBox();
            this.textBox3 = new TextBox();
            this.checkBox3 = new CheckBox();
            this.textBox4 = new TextBox();
            this.checkBox4 = new CheckBox();
            this.button1 = new Button();
            this.textBox5 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox8 = new TextBox();
            base.SuspendLayout();
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(12, 19);
            this.checkBox1.Margin = new Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.textBox1.Location = new Point(34, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(237, 26);
            this.textBox1.TabIndex = 1;
            this.textBox2.Location = new Point(34, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(237, 26);
            this.textBox2.TabIndex = 3;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new Point(12, 51);
            this.checkBox2.Margin = new Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(15, 14);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.textBox3.Location = new Point(34, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(237, 26);
            this.textBox3.TabIndex = 5;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new Point(12, 83);
            this.checkBox3.Margin = new Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(15, 14);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.textBox4.Location = new Point(34, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(237, 26);
            this.textBox4.TabIndex = 7;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new Point(12, 115);
            this.checkBox4.Margin = new Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(15, 14);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.button1.Font = new Font("Times New Roman", 24f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(34, 155);
            this.button1.Name = "button1";
            this.button1.Size = new Size(237, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
           // this.button1.Click += this.button1_Click;
            this.textBox5.BackColor = Color.White;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new Point(277, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(307, 26);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Số lượng x ( Dài + Rộng)x2 x Đơn giá";
            this.textBox6.BackColor = Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new Point(277, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(307, 26);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Số lượng x Dài x Rộng x Đơn giá";
            this.textBox7.BackColor = Color.White;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new Point(277, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Size(307, 26);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Số lượng x Dài x rộng x Đơn giá/5 (5 có thể đổi)";
            this.textBox8.BackColor = Color.White;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new Point(277, 13);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(307, 26);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Số lượng x Đơn giá";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(586, 233);
            base.Controls.Add(this.textBox5);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.textBox7);
            base.Controls.Add(this.textBox8);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.checkBox4);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.checkBox3);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.checkBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.checkBox1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frmbanhang";
         //   base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chọn mục cần dùng";
          //  base.TopMost = true;
         //   base.Load += this.Frmbanhang_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x040000B5 RID: 181
     //   private IContainer components = null;

        // Token: 0x040000B6 RID: 182
        private CheckBox checkBox1;

        // Token: 0x040000B7 RID: 183
        private TextBox textBox1;

        // Token: 0x040000B8 RID: 184
        private TextBox textBox2;

        // Token: 0x040000B9 RID: 185
        private CheckBox checkBox2;

        // Token: 0x040000BA RID: 186
        private TextBox textBox3;

        // Token: 0x040000BB RID: 187
        private CheckBox checkBox3;

        // Token: 0x040000BC RID: 188
        private TextBox textBox4;

        // Token: 0x040000BD RID: 189
        private CheckBox checkBox4;

        // Token: 0x040000BE RID: 190
        private Button button1;

        // Token: 0x040000BF RID: 191
        private TextBox textBox5;

        // Token: 0x040000C0 RID: 192
        private TextBox textBox6;

        // Token: 0x040000C1 RID: 193
        private TextBox textBox7;

        // Token: 0x040000C2 RID: 194
        private TextBox textBox8;
    }
}
