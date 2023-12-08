using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class Frm_themdonhangcongno
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
            this.textBox1 = new TextBox();
            this.txtma = new TextBox();
            this.txttienno = new TextBox();
            this.textBox8 = new TextBox();
            this.txttientra = new TextBox();
            this.textBox10 = new TextBox();
            this.button1 = new Button();
            this.textBox6 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.button2 = new Button();
            this.printDocument1 = new PrintDocument();
            this.button3 = new Button();
            this.printDocument2 = new PrintDocument();
            this.textBox2 = new TextBox();
            this.openFileDialog1 = new OpenFileDialog();
            this.ptlogo = new PictureBox();
            ((ISupportInitialize)this.ptlogo).BeginInit();
            base.SuspendLayout();
            this.textBox1.BackColor = Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new Font("Times New Roman", 16f);
            this.textBox1.Location = new Point(1, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(160, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mã số";
            this.txtma.BackColor = Color.White;
            this.txtma.Font = new Font("Times New Roman", 16f);
            this.txtma.Location = new Point(156, 29);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new Size(314, 32);
            this.txtma.TabIndex = 0;
            this.txttienno.Font = new Font("Times New Roman", 16f);
            this.txttienno.Location = new Point(156, 127);
            this.txttienno.Name = "txttienno";
            this.txttienno.Size = new Size(235, 32);
            this.txttienno.TabIndex = 2;
            this.txttienno.Text = "0";
            this.txttienno.TextChanged += this.txttienno_TextChanged;
            this.txttienno.Enter += this.txttienno_Enter;
            this.txttienno.KeyPress += this.txttienno_KeyPress;
            this.txttienno.Leave += this.txttienno_Leave;
            this.textBox8.BackColor = Color.White;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new Font("Times New Roman", 16f);
            this.textBox8.Location = new Point(1, 127);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(160, 32);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "Số tiền công nợ";
            this.txttientra.Font = new Font("Times New Roman", 16f);
            this.txttientra.Location = new Point(157, 175);
            this.txttientra.Name = "txttientra";
            this.txttientra.Size = new Size(314, 32);
            this.txttientra.TabIndex = 3;
            this.txttientra.Text = "0";
            this.txttientra.TextChanged += this.txttientra_TextChanged;
            this.txttientra.Enter += this.txttientra_Enter;
            this.txttientra.KeyPress += this.txttientra_KeyPress;
            this.txttientra.Leave += this.txttientra_Leave;
            this.textBox10.BackColor = Color.White;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new Font("Times New Roman", 16f);
            this.textBox10.Location = new Point(2, 175);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(160, 32);
            this.textBox10.TabIndex = 5;
            this.textBox10.Text = "Số tiền trả";
            this.button1.Font = new Font("Times New Roman", 16f);
            this.button1.Location = new Point(298, 213);
            this.button1.Name = "button1";
            this.button1.Size = new Size(173, 165);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.textBox6.BackColor = Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new Font("Times New Roman", 16.5f);
            this.textBox6.Location = new Point(1, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(160, 33);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Nhà cung cấp";
            this.comboBox1.BackColor = Color.White;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Popup;
            this.comboBox1.Font = new Font("Times New Roman", 16.5f);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(156, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(314, 33);
            this.comboBox1.TabIndex = 1;
            this.button2.FlatAppearance.BorderColor = Color.Black;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.Font = new Font("Times New Roman", 16f);
            this.button2.Location = new Point(388, 127);
            this.button2.Name = "button2";
            this.button2.Size = new Size(83, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trả hết";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.printDocument1.PrintPage += this.printDocument1_PrintPage;
            this.button3.Font = new Font("Times New Roman", 16f);
            this.button3.Location = new Point(298, 250);
            this.button3.Name = "button3";
            this.button3.Size = new Size(173, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "In Tem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.printDocument2.PrintPage += this.printDocument2_PrintPage;
            this.textBox2.Font = new Font("Times New Roman", 16f);
            this.textBox2.Location = new Point(486, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(50, 32);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "50";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.ptlogo.BackColor = Color.FromArgb(192, 255, 192);
            this.ptlogo.BackgroundImageLayout = ImageLayout.None;
            this.ptlogo.BorderStyle = BorderStyle.FixedSingle;
            this.ptlogo.Location = new Point(2, 213);
            this.ptlogo.Name = "ptlogo";
            this.ptlogo.Size = new Size(198, 165);
            this.ptlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptlogo.TabIndex = 12;
            this.ptlogo.TabStop = false;
            this.ptlogo.Click += this.ptlogo_Click;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(475, 384);
            base.Controls.Add(this.ptlogo);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txttientra);
            base.Controls.Add(this.textBox10);
            base.Controls.Add(this.txttienno);
            base.Controls.Add(this.textBox8);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.txtma);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button3);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_themdonhangcongno";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn hàng công nợ";
            base.Load += this.Frm_themdonhangcongno_Load;
            ((ISupportInitialize)this.ptlogo).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private TextBox textBox1;

        // Token: 0x04000F1A RID: 3866
        private TextBox txtma;

        // Token: 0x04000F1B RID: 3867
        private TextBox txttienno;

        // Token: 0x04000F1C RID: 3868
        private TextBox textBox8;

        // Token: 0x04000F1D RID: 3869
        private TextBox txttientra;

        // Token: 0x04000F1E RID: 3870
        private TextBox textBox10;

        // Token: 0x04000F1F RID: 3871
        private Button button1;

        // Token: 0x04000F20 RID: 3872
        private TextBox textBox6;

        // Token: 0x04000F21 RID: 3873
        private ComboBox comboBox1;

        // Token: 0x04000F22 RID: 3874
        private Button button2;

        // Token: 0x04000F23 RID: 3875
        private PrintDocument printDocument1;

        // Token: 0x04000F24 RID: 3876
        private Button button3;

        // Token: 0x04000F25 RID: 3877
        private PrintDocument printDocument2;

        // Token: 0x04000F26 RID: 3878
        private TextBox textBox2;

        // Token: 0x04000F27 RID: 3879
        private PictureBox ptlogo;

        // Token: 0x04000F28 RID: 3880
        private OpenFileDialog openFileDialog1;
    }
}