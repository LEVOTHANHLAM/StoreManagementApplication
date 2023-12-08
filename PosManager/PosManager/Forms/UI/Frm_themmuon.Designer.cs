using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class Frm_themmuon
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
            this.openFileDialog1 = new OpenFileDialog();
            this.comboBox1 = new ComboBox();
            this.button1 = new Button();
            this.txttra = new TextBox();
            this.textBox10 = new TextBox();
            this.textBox8 = new TextBox();
            this.txtmuon = new TextBox();
            this.printDocument2 = new PrintDocument();
            this.textBox6 = new TextBox();
            this.txtma = new TextBox();
            this.textBox1 = new TextBox();
            this.printDocument1 = new PrintDocument();
            this.ptlogo = new PictureBox();
            this.openFileDialog2 = new OpenFileDialog();
            ((ISupportInitialize)this.ptlogo).BeginInit();
            base.SuspendLayout();
            this.openFileDialog1.FileName = "openFileDialog1";
            this.comboBox1.BackColor = Color.White;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Popup;
            this.comboBox1.Font = new Font("Times New Roman", 16.5f);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(150, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(596, 33);
            this.comboBox1.TabIndex = 16;
            this.button1.Font = new Font("Times New Roman", 26f);
            this.button1.Location = new Point(573, 207);
            this.button1.Name = "button1";
            this.button1.Size = new Size(173, 165);
            this.button1.TabIndex = 20;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.txttra.Font = new Font("Times New Roman", 16f);
            this.txttra.Location = new Point(151, 169);
            this.txttra.Name = "txttra";
            this.txttra.ReadOnly = true;
            this.txttra.Size = new Size(595, 32);
            this.txttra.TabIndex = 18;
            this.textBox10.BackColor = Color.White;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new Font("Times New Roman", 16f);
            this.textBox10.Location = new Point(13, 169);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(160, 32);
            this.textBox10.TabIndex = 22;
            this.textBox10.Text = "Nội dung trả";
            this.textBox8.BackColor = Color.White;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new Font("Times New Roman", 16f);
            this.textBox8.Location = new Point(12, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(160, 32);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "Nội dung mượn";
            this.txtmuon.Font = new Font("Times New Roman", 16f);
            this.txtmuon.Location = new Point(150, 121);
            this.txtmuon.Name = "txtmuon";
            this.txtmuon.ReadOnly = true;
            this.txtmuon.Size = new Size(596, 32);
            this.txtmuon.TabIndex = 17;
            this.textBox6.BackColor = Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new Font("Times New Roman", 16.5f);
            this.textBox6.Location = new Point(12, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(139, 33);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Người mượn";
            this.txtma.BackColor = Color.White;
            this.txtma.Font = new Font("Times New Roman", 16f);
            this.txtma.Location = new Point(150, 23);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new Size(256, 32);
            this.txtma.TabIndex = 13;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new Font("Times New Roman", 16f);
            this.textBox1.Location = new Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(160, 32);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Mã số";
            this.ptlogo.BackColor = Color.FromArgb(192, 255, 192);
            this.ptlogo.BackgroundImageLayout = ImageLayout.None;
            this.ptlogo.BorderStyle = BorderStyle.FixedSingle;
            this.ptlogo.Location = new Point(13, 207);
            this.ptlogo.Name = "ptlogo";
            this.ptlogo.Size = new Size(198, 165);
            this.ptlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptlogo.TabIndex = 25;
            this.ptlogo.TabStop = false;
            this.ptlogo.Click += this.ptlogo_Click;
            this.openFileDialog2.FileName = "openFileDialog2";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(748, 392);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.txttra);
            base.Controls.Add(this.txtmuon);
            base.Controls.Add(this.ptlogo);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox10);
            base.Controls.Add(this.textBox8);
            base.Controls.Add(this.txtma);
            base.Controls.Add(this.textBox1);
            base.Name = "Frm_themmuon";
            this.Text = "Frm_themmuon";
            base.Load += this.Frm_themmuon_Load;
            ((ISupportInitialize)this.ptlogo).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private PictureBox ptlogo;

        // Token: 0x04000C1C RID: 3100
        private OpenFileDialog openFileDialog1;

        // Token: 0x04000C1D RID: 3101
        private ComboBox comboBox1;

        // Token: 0x04000C1E RID: 3102
        private Button button1;

        // Token: 0x04000C1F RID: 3103
        private TextBox txttra;

        // Token: 0x04000C20 RID: 3104
        private TextBox textBox10;

        // Token: 0x04000C21 RID: 3105
        private TextBox textBox8;

        // Token: 0x04000C22 RID: 3106
        private TextBox txtmuon;

        // Token: 0x04000C23 RID: 3107
        private PrintDocument printDocument2;

        // Token: 0x04000C24 RID: 3108
        private TextBox textBox6;

        // Token: 0x04000C25 RID: 3109
        private TextBox txtma;

        // Token: 0x04000C26 RID: 3110
        private TextBox textBox1;

        // Token: 0x04000C27 RID: 3111
        private PrintDocument printDocument1;

        // Token: 0x04000C28 RID: 3112
        private OpenFileDialog openFileDialog2;
    }
}