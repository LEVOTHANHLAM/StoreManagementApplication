using Microsoft.Win32;
using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class frmLogIn
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
            txtmadanhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtmatkhau = new TextBox();
            btdangnhap = new Button();
            lbdangnhap = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtduongdan = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtmadanhap
            // 
            txtmadanhap.BackColor = Color.Gold;
            txtmadanhap.BorderStyle = BorderStyle.FixedSingle;
            txtmadanhap.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtmadanhap.ForeColor = Color.FromArgb(0, 0, 192);
            txtmadanhap.Location = new Point(157, 48);
            txtmadanhap.Name = "txtmadanhap";
            txtmadanhap.Size = new Size(192, 35);
            txtmadanhap.TabIndex = 0;
            txtmadanhap.Text = "ADMIN";
            txtmadanhap.TextChanged += txtmadanhap_TextChanged;
            txtmadanhap.KeyPress += txtmadanhap_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(1, 228);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 1;
            label1.Text = "Cấp Key";
            label1.MouseDoubleClick += label1_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(23, 106);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Mật Khẩu:";
            // 
            // txtmatkhau
            // 
            txtmatkhau.BackColor = Color.Gold;
            txtmatkhau.BorderStyle = BorderStyle.FixedSingle;
            txtmatkhau.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.ForeColor = Color.FromArgb(0, 0, 192);
            txtmatkhau.Location = new Point(157, 93);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(192, 35);
            txtmatkhau.TabIndex = 1;
            txtmatkhau.UseSystemPasswordChar = true;
            txtmatkhau.KeyPress += txtmatkhau_KeyPress;
            // 
            // btdangnhap
            // 
            btdangnhap.BackColor = Color.FromArgb(0, 162, 162);
            btdangnhap.BackgroundImageLayout = ImageLayout.Stretch;
            btdangnhap.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btdangnhap.FlatAppearance.BorderSize = 0;
            btdangnhap.FlatStyle = FlatStyle.Flat;
            btdangnhap.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btdangnhap.ForeColor = Color.White;
            btdangnhap.Location = new Point(201, 144);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(149, 61);
            btdangnhap.TabIndex = 2;
            btdangnhap.Text = "Đăng Nhập";
            btdangnhap.UseVisualStyleBackColor = false;
            btdangnhap.Click += btdangnhap_Click;
            // 
            // lbdangnhap
            // 
            lbdangnhap.AutoSize = true;
            lbdangnhap.BackColor = Color.Transparent;
            lbdangnhap.ForeColor = Color.Black;
            lbdangnhap.Location = new Point(86, 29);
            lbdangnhap.Name = "lbdangnhap";
            lbdangnhap.Size = new Size(0, 19);
            lbdangnhap.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(63, 2);
            label3.Name = "label3";
            label3.Size = new Size(277, 25);
            label3.TabIndex = 7;
            label3.Text = "PHẦN MỀM BÁN HÀNG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(495, 220);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 8;
            label4.Text = "Ẩn";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(23, 60);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 5;
            label5.Text = "Mã Đăng Nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(1, 251);
            label6.Name = "label6";
            label6.Size = new Size(61, 19);
            label6.TabIndex = 10;
            label6.Text = "Add DB";
            label6.MouseDoubleClick += label6_MouseDoubleClick;
            // 
            // txtduongdan
            // 
            txtduongdan.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtduongdan.Location = new Point(65, 250);
            txtduongdan.Name = "txtduongdan";
            txtduongdan.Size = new Size(457, 25);
            txtduongdan.TabIndex = 13;
            txtduongdan.Text = ".\\SQLEXPRESS;initial Catalog=DATASHOP;User ID=sa;Password=Sa123123";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 162, 162);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 144);
            button1.Name = "button1";
            button1.Size = new Size(139, 61);
            button1.TabIndex = 3;
            button1.Text = "Bỏ Qua";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.FlatAppearance.BorderColor = Color.Gainsboro;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1, 1);
            button2.Name = "button2";
            button2.Size = new Size(67, 47);
            button2.TabIndex = 14;
            button2.Text = "Trợ giúp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 297);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtduongdan);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbdangnhap);
            Controls.Add(btdangnhap);
            Controls.Add(label2);
            Controls.Add(txtmatkhau);
            Controls.Add(label1);
            Controls.Add(txtmadanhap);
            Controls.Add(label5);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(541, 336);
            MinimumSize = new Size(379, 238);
            Name = "frmLogIn";
            Text = "Hỗ Trợ phần mềm: 0909 774 123 - 0975 788 409";
            Load += frmLogIn_Load;
            KeyDown += frmLogIn_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RegistryKey key1;

        // Token: 0x04000335 RID: 821
        private RegistryKey key;

        // Token: 0x04000336 RID: 822
        public static DateTime ngaythang;

        // Token: 0x04000337 RID: 823
        public static string makho = "00";

        // Token: 0x04000338 RID: 824
        public static string macuahang = "1";

        // Token: 0x0400033A RID: 826
        private TextBox txtmadanhap;

        // Token: 0x0400033B RID: 827
        private Label label1;

        // Token: 0x0400033C RID: 828
        private Label label2;

        // Token: 0x0400033D RID: 829
        private TextBox txtmatkhau;

        // Token: 0x0400033E RID: 830
        private Button btdangnhap;

        // Token: 0x0400033F RID: 831
        private Label lbdangnhap;

        // Token: 0x04000340 RID: 832
        private Label label3;

        // Token: 0x04000341 RID: 833
        private Label label4;

        // Token: 0x04000342 RID: 834
        private Label label5;

        // Token: 0x04000343 RID: 835
        private Label label6;

        // Token: 0x04000344 RID: 836
        private TextBox txtduongdan;

        // Token: 0x04000345 RID: 837
        private Button button1;

        // Token: 0x04000346 RID: 838
        private Button button2;
    }
}
