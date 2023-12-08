namespace PosManager.Forms.UI
{
    partial class Frmsuancc
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
            this.textBox1 = new TextBox();
            this.bttim = new Button();
            this.cobtienmat = new ComboBox();
            this.txttenncc = new TextBox();
            this.txtmancc = new TextBox();
            this.txtsohoadon = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.textBox1.BackColor = Color.White;
            this.textBox1.Location = new Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(100, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Số hóa đơn";
            this.bttim.BackColor = Color.FromArgb(224, 224, 224);
            this.bttim.FlatStyle = FlatStyle.Flat;
            this.bttim.Font = new Font("Times New Roman", 13f);
            this.bttim.Location = new Point(13, 118);
            this.bttim.Name = "bttim";
            this.bttim.Size = new Size(100, 31);
            this.bttim.TabIndex = 21;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += this.bttim_Click;
            this.cobtienmat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cobtienmat.FlatStyle = FlatStyle.Flat;
            this.cobtienmat.FormattingEnabled = true;
            this.cobtienmat.Items.AddRange(new object[]
            {
                "TIỀN MẶT",
                "CÔNG NỢ"
            });
            this.cobtienmat.Location = new Point(360, 118);
            this.cobtienmat.Name = "cobtienmat";
            this.cobtienmat.Size = new Size(227, 29);
            this.cobtienmat.TabIndex = 22;
            this.txttenncc.BackColor = Color.White;
            this.txttenncc.Location = new Point(119, 83);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.ReadOnly = true;
            this.txttenncc.Size = new Size(468, 29);
            this.txttenncc.TabIndex = 20;
            this.txttenncc.Tag = "";
            this.txtmancc.BackColor = Color.White;
            this.txtmancc.Location = new Point(119, 48);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new Size(468, 29);
            this.txtmancc.TabIndex = 19;
            this.txtmancc.Tag = "";
            this.txtmancc.TextChanged += this.txtmancc_TextChanged;
            this.txtsohoadon.BackColor = Color.White;
            this.txtsohoadon.Location = new Point(119, 13);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.ReadOnly = true;
            this.txtsohoadon.Size = new Size(468, 29);
            this.txtsohoadon.TabIndex = 23;
            this.txtsohoadon.Text = "Số hóa đơn";
            this.textBox2.BackColor = Color.White;
            this.textBox2.Location = new Point(13, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(100, 29);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Mã";
            this.textBox2.Enter += this.textBox2_Enter;
            this.textBox3.BackColor = Color.White;
            this.textBox3.Location = new Point(13, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(100, 29);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Tên";
            this.textBox3.Enter += this.textBox3_Enter;
            this.textBox4.BackColor = Color.White;
            this.textBox4.Location = new Point(119, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(235, 29);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "Hình thức thanh toán";
            this.button1.BackColor = Color.FromArgb(224, 224, 224);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new Size(190, 89);
            this.button1.TabIndex = 26;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.button2.BackColor = Color.FromArgb(224, 224, 224);
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(377, 204);
            this.button2.Name = "button2";
            this.button2.Size = new Size(210, 89);
            this.button2.TabIndex = 27;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(594, 305);
           // base.ControlBox = false;
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.txtsohoadon);
            base.Controls.Add(this.bttim);
            base.Controls.Add(this.cobtienmat);
            base.Controls.Add(this.txttenncc);
            base.Controls.Add(this.txtmancc);
            base.Controls.Add(this.textBox1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
           // base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "Frmsuancc";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin";
            base.Load += this.Frmsuancc_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        // Token: 0x04000E60 RID: 3680
        private TextBox textBox1;

        // Token: 0x04000E61 RID: 3681
        private Button bttim;

        // Token: 0x04000E62 RID: 3682
        private ComboBox cobtienmat;

        // Token: 0x04000E63 RID: 3683
        private TextBox txttenncc;

        // Token: 0x04000E64 RID: 3684
        private TextBox txtmancc;

        // Token: 0x04000E65 RID: 3685
        private TextBox txtsohoadon;

        // Token: 0x04000E66 RID: 3686
        private TextBox textBox2;

        // Token: 0x04000E67 RID: 3687
        private TextBox textBox3;

        // Token: 0x04000E68 RID: 3688
        private TextBox textBox4;

        // Token: 0x04000E69 RID: 3689
        private Button button1;

        // Token: 0x04000E6A RID: 3690
        private Button button2;
    }
}
