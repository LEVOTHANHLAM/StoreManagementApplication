namespace PosManager.Forms.UI
{
    partial class Frmsuathanhtoan
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
            this.button1 = new Button();
            this.button2 = new Button();
            this.txtsohoadon = new TextBox();
            this.bttim = new Button();
            this.txttenncc = new TextBox();
            this.txtmancc = new TextBox();
            this.textBox1 = new TextBox();
            this.textBox5 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox6 = new TextBox();
            this.txtduatruoc = new TextBox();
            this.txtnocu = new TextBox();
            this.txttrutien = new TextBox();
            this.txtpt = new TextBox();
            this.textBox4 = new TextBox();
            this.txttongcong = new TextBox();
            this.textBox7 = new TextBox();
            this.txttt = new TextBox();
            this.textBox9 = new TextBox();
            this.button3 = new Button();
            base.SuspendLayout();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "TIỀN MẶT",
                "TÀI KHOẢN",
                "VN PAY"
            });
            this.comboBox1.Location = new Point(258, 104);
            this.comboBox1.Margin = new Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(235, 39);
            this.comboBox1.TabIndex = 0;
            this.button1.Location = new Point(499, 354);
            this.button1.Name = "button1";
            this.button1.Size = new Size(189, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.Location = new Point(499, 161);
            this.button2.Name = "button2";
            this.button2.Size = new Size(189, 127);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lưu thay đổi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.txtsohoadon.BackColor = Color.White;
            this.txtsohoadon.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtsohoadon.Location = new Point(4, 12);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.ReadOnly = true;
            this.txtsohoadon.Size = new Size(198, 32);
            this.txtsohoadon.TabIndex = 30;
            this.txtsohoadon.Text = "Số hóa đơn";
            this.bttim.BackColor = Color.FromArgb(224, 224, 224);
            this.bttim.FlatStyle = FlatStyle.Popup;
            this.bttim.Font = new Font("Times New Roman", 18f);
            this.bttim.Location = new Point(499, 12);
            this.bttim.Name = "bttim";
            this.bttim.Size = new Size(189, 78);
            this.bttim.TabIndex = 29;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Visible = false;
            this.bttim.Click += this.bttim_Click;
            this.txttenncc.BackColor = Color.White;
            this.txttenncc.Enabled = false;
            this.txttenncc.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txttenncc.Location = new Point(4, 58);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.ReadOnly = true;
            this.txttenncc.Size = new Size(489, 32);
            this.txttenncc.TabIndex = 28;
            this.txttenncc.Tag = "";
            this.txtmancc.BackColor = Color.White;
            this.txtmancc.Enabled = false;
            this.txtmancc.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtmancc.Location = new Point(208, 12);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new Size(285, 32);
            this.txtmancc.TabIndex = 27;
            this.txtmancc.Tag = "Mã khách hàng";
            this.txtmancc.Text = "Mã khách hàng";
            this.txtmancc.TextChanged += this.txtmancc_TextChanged;
            this.txtmancc.Enter += this.txtmancc_Enter;
            this.txtmancc.Leave += this.txtmancc_Leave;
            this.textBox1.BackColor = Color.White;
            this.textBox1.Font = new Font("Times New Roman", 20.5f);
            this.textBox1.Location = new Point(4, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(255, 39);
            this.textBox1.TabIndex = 33;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Hình thức thanh toán";
            this.textBox5.BackColor = Color.White;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox5.Location = new Point(4, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(255, 32);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "Đưa trước";
            this.textBox3.BackColor = Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox3.Location = new Point(4, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(255, 32);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "Nợ cũ";
            this.textBox6.BackColor = Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox6.Location = new Point(4, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new Size(255, 32);
            this.textBox6.TabIndex = 36;
            this.textBox6.Text = "Cộng trừ tiền";
            this.txtduatruoc.Enabled = false;
            this.txtduatruoc.Font = new Font("Times New Roman", 16f);
            this.txtduatruoc.Location = new Point(258, 161);
            this.txtduatruoc.Name = "txtduatruoc";
            this.txtduatruoc.Size = new Size(235, 32);
            this.txtduatruoc.TabIndex = 37;
            this.txtduatruoc.Text = "0";
            this.txtduatruoc.TextAlign = HorizontalAlignment.Right;
            this.txtduatruoc.TextChanged += this.txtduatruoc_TextChanged;
            this.txtduatruoc.KeyPress += this.txtduatruoc_KeyPress;
            this.txtduatruoc.Leave += this.txtduatruoc_Leave;
            this.txtnocu.BackColor = Color.White;
            this.txtnocu.Enabled = false;
            this.txtnocu.Font = new Font("Times New Roman", 16f);
            this.txtnocu.Location = new Point(258, 206);
            this.txtnocu.Name = "txtnocu";
            this.txtnocu.ReadOnly = true;
            this.txtnocu.Size = new Size(235, 32);
            this.txtnocu.TabIndex = 38;
            this.txtnocu.Text = "0";
            this.txtnocu.TextAlign = HorizontalAlignment.Right;
            this.txtnocu.TextChanged += this.txtnocu_TextChanged;
            this.txttrutien.Enabled = false;
            this.txttrutien.Font = new Font("Times New Roman", 16f);
            this.txttrutien.Location = new Point(258, 303);
            this.txttrutien.Name = "txttrutien";
            this.txttrutien.Size = new Size(235, 32);
            this.txttrutien.TabIndex = 39;
            this.txttrutien.Text = "0";
            this.txttrutien.TextAlign = HorizontalAlignment.Right;
            this.txttrutien.TextChanged += this.txttrutien_TextChanged;
            this.txttrutien.KeyPress += this.txttrutien_KeyPress;
            this.txttrutien.Leave += this.txttrutien_Leave;
            this.txtpt.Enabled = false;
            this.txtpt.Font = new Font("Times New Roman", 16f);
            this.txtpt.Location = new Point(258, 350);
            this.txtpt.MaxLength = 4;
            this.txtpt.Name = "txtpt";
            this.txtpt.Size = new Size(235, 32);
            this.txtpt.TabIndex = 41;
            this.txtpt.Text = "0";
            this.txtpt.TextAlign = HorizontalAlignment.Right;
            this.txtpt.TextChanged += this.txtpt_TextChanged;
            this.txtpt.KeyPress += this.txtpt_KeyPress;
            this.txtpt.Leave += this.txtpt_Leave;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox4.Location = new Point(4, 350);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(255, 32);
            this.textBox4.TabIndex = 40;
            this.textBox4.Text = "Cộng trừ %";
            this.txttongcong.BackColor = Color.White;
            this.txttongcong.Enabled = false;
            this.txttongcong.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttongcong.Location = new Point(258, 253);
            this.txttongcong.MaxLength = 4;
            this.txttongcong.Name = "txttongcong";
            this.txttongcong.ReadOnly = true;
            this.txttongcong.Size = new Size(235, 35);
            this.txttongcong.TabIndex = 43;
            this.txttongcong.Text = "0";
            this.txttongcong.TextAlign = HorizontalAlignment.Right;
            this.txttongcong.TextChanged += this.txttongcong_TextChanged;
            this.textBox7.BackColor = Color.White;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox7.Location = new Point(4, 253);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new Size(255, 35);
            this.textBox7.TabIndex = 42;
            this.textBox7.Text = "Tổng cộng";
            this.txttt.BackColor = Color.White;
            this.txttt.Enabled = false;
            this.txttt.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txttt.Location = new Point(258, 395);
            this.txttt.MaxLength = 4;
            this.txttt.Name = "txttt";
            this.txttt.ReadOnly = true;
            this.txttt.Size = new Size(235, 35);
            this.txttt.TabIndex = 45;
            this.txttt.Text = "0";
            this.txttt.TextAlign = HorizontalAlignment.Right;
            this.txttt.TextChanged += this.txttt_TextChanged;
            this.textBox9.BackColor = Color.White;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox9.Location = new Point(4, 395);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new Size(255, 35);
            this.textBox9.TabIndex = 44;
            this.textBox9.Text = "Phải thanh toán";
            this.button3.Enabled = false;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Font = new Font("Times New Roman", 14f);
            this.button3.Location = new Point(128, 206);
            this.button3.Name = "button3";
            this.button3.Size = new Size(131, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "Tính lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            base.AutoScaleDimensions = new SizeF(15f, 31f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(688, 446);
           // base.ControlBox = false;
            base.Controls.Add(this.button3);
            base.Controls.Add(this.txttt);
            base.Controls.Add(this.textBox9);
            base.Controls.Add(this.txttongcong);
            base.Controls.Add(this.textBox7);
            base.Controls.Add(this.txtpt);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.txttrutien);
            base.Controls.Add(this.txtnocu);
            base.Controls.Add(this.txtduatruoc);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox5);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.txtsohoadon);
            base.Controls.Add(this.txttenncc);
            base.Controls.Add(this.txtmancc);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.bttim);
            base.Controls.Add(this.comboBox1);
            this.Font = new Font("Times New Roman", 20f);
            base.Margin = new Padding(8, 7, 8, 7);
            base.Name = "Frmsuathanhtoan";
           // base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thay đổi hình thức thanh toán";
            base.Load += this.Frmsuathanhtoan_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000131 RID: 305
        private ComboBox comboBox1;

        // Token: 0x04000132 RID: 306
        private Button button1;

        // Token: 0x04000133 RID: 307
        private Button button2;

        // Token: 0x04000134 RID: 308
        private TextBox txtsohoadon;

        // Token: 0x04000135 RID: 309
        private Button bttim;

        // Token: 0x04000136 RID: 310
        private TextBox txttenncc;

        // Token: 0x04000137 RID: 311
        private TextBox txtmancc;

        // Token: 0x04000138 RID: 312
        private TextBox textBox1;

        // Token: 0x04000139 RID: 313
        private TextBox textBox5;

        // Token: 0x0400013A RID: 314
        private TextBox textBox3;

        // Token: 0x0400013B RID: 315
        private TextBox textBox6;

        // Token: 0x0400013C RID: 316
        private TextBox txtduatruoc;

        // Token: 0x0400013D RID: 317
        private TextBox txtnocu;

        // Token: 0x0400013E RID: 318
        private TextBox txttrutien;

        // Token: 0x0400013F RID: 319
        private TextBox txtpt;

        // Token: 0x04000140 RID: 320
        private TextBox textBox4;

        // Token: 0x04000141 RID: 321
        private TextBox txttongcong;

        // Token: 0x04000142 RID: 322
        private TextBox textBox7;

        // Token: 0x04000143 RID: 323
        private TextBox txttt;

        // Token: 0x04000144 RID: 324
        private TextBox textBox9;

        // Token: 0x04000145 RID: 325
        private Button button3;
    }
}
