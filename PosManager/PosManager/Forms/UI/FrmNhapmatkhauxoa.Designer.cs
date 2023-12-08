namespace PosManager.Forms.UI
{
    partial class FrmNhapmatkhauxoa
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
            this.txtmatkhau = new TextBox();
            this.textBox2 = new TextBox();
            this.btok = new Button();
            this.button1 = new Button();
            this.checkBox1 = new CheckBox();
            base.SuspendLayout();
            this.txtmatkhau.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtmatkhau.Location = new Point(3, 31);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new Size(164, 26);
            this.txtmatkhau.TabIndex = 0;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.KeyDown += this.txtmatkhau_KeyDown;
            this.textBox2.BackColor = Color.FromArgb(128, 255, 128);
            this.textBox2.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.Red;
            this.textBox2.Location = new Point(3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(164, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Nhập Mật Khẩu";
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.btok.BackColor = Color.FromArgb(128, 128, 255);
            this.btok.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btok.ForeColor = Color.White;
            this.btok.Location = new Point(3, 88);
            this.btok.Name = "btok";
            this.btok.Size = new Size(80, 50);
            this.btok.TabIndex = 2;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = false;
            this.btok.Click += this.btok_Click;
            this.button1.BackColor = Color.FromArgb(255, 128, 128);
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(89, 88);
            this.button1.Name = "button1";
            this.button1.Size = new Size(78, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "HỦY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new Font("Microsoft Sans Serif", 12.25f);
            this.checkBox1.Location = new Point(4, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(131, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Hiện nội dung";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += this.checkBox1_MouseClick;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(168, 142);
           // base.ControlBox = false;
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.btok);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.txtmatkhau);
            base.Name = "FrmNhapmatkhauxoa";
          //  base.StartPosition = FormStartPosition.CenterScreen;
          //  base.Load += this.FrmNhapmatkhauxoa_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000147 RID: 327
        private TextBox txtmatkhau;

        // Token: 0x04000148 RID: 328
        private TextBox textBox2;

        // Token: 0x04000149 RID: 329
        private Button btok;

        // Token: 0x0400014A RID: 330
        private Button button1;

        // Token: 0x0400014B RID: 331
        private CheckBox checkBox1;
    }
}
