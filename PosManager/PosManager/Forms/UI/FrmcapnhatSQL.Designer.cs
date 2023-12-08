using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FrmcapnhatSQL
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
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            base.SuspendLayout();
            this.button1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(910, 411);
            this.button1.Name = "button1";
            this.button1.Size = new Size(95, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "THỰC HIỆN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.textBox1.Location = new Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(1002, 405);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.textBox2.Location = new Point(3, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(618, 161);
            this.textBox2.TabIndex = 2;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(7, 414);
            this.button2.Name = "button2";
            this.button2.Size = new Size(74, 97);
            this.button2.TabIndex = 3;
            this.button2.Text = "Framework 64bit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(108, 414);
            this.button3.Name = "button3";
            this.button3.Size = new Size(74, 97);
            this.button3.TabIndex = 4;
            this.button3.Text = "Framework 32bit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.button4.Font = new Font("Microsoft Sans Serif", 10f);
            this.button4.Location = new Point(209, 414);
            this.button4.Name = "button4";
            this.button4.Size = new Size(149, 97);
            this.button4.TabIndex = 5;
            this.button4.Text = "Tìm kiếm bằng ký tự đầu\r\n\r\nVD: Phần mềm bán hàng (nhập =pmbh)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.button4_Click;
            this.button5.Font = new Font("Microsoft Sans Serif", 10f);
            this.button5.Location = new Point(364, 414);
            this.button5.Name = "button5";
            this.button5.Size = new Size(110, 97);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sửa tên hàng không có nhóm vào nhóm đầu tiên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.button5_Click;
            this.button6.Font = new Font("Microsoft Sans Serif", 10f);
            this.button6.Location = new Point(480, 414);
            this.button6.Name = "button6";
            this.button6.Size = new Size(110, 97);
            this.button6.TabIndex = 7;
            this.button6.Text = "Xóa ký tự đặc biệt trong tên hàng hóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += this.button6_Click;
            this.button7.Font = new Font("Microsoft Sans Serif", 10f);
            this.button7.Location = new Point(596, 414);
            this.button7.Name = "button7";
            this.button7.Size = new Size(123, 97);
            this.button7.TabIndex = 8;
            this.button7.Text = "Xóa ký tự đặc biệt trong\r\n* Mã hàng hóa\r\n* Mã khách hàng";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += this.button7_Click;
            this.button8.Font = new Font("Microsoft Sans Serif", 10f);
            this.button8.Location = new Point(725, 414);
            this.button8.Name = "button8";
            this.button8.Size = new Size(123, 97);
            this.button8.TabIndex = 9;
            this.button8.Text = "Chuyển tên hàng hóa sang chữ Hoa";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += this.button8_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1008, 514);
            base.Controls.Add(this.button8);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox2);
           // base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "FrmcapnhatSQL";
           // base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmcapnhatSQL";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000DB8 RID: 3512
       // private IContainer components = null;

        // Token: 0x04000DB9 RID: 3513
        private Button button1;

        // Token: 0x04000DBA RID: 3514
        private TextBox textBox1;

        // Token: 0x04000DBB RID: 3515
        private TextBox textBox2;

        // Token: 0x04000DBC RID: 3516
        private Button button2;

        // Token: 0x04000DBD RID: 3517
        private Button button3;

        // Token: 0x04000DBE RID: 3518
        private Button button4;

        // Token: 0x04000DBF RID: 3519
        private Button button5;

        // Token: 0x04000DC0 RID: 3520
        private Button button6;

        // Token: 0x04000DC1 RID: 3521
        private Button button7;

        // Token: 0x04000DC2 RID: 3522
        private Button button8;
    }
}
