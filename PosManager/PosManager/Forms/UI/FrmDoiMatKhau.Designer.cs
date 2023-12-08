using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FrmDoiMatKhau
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
            this.lbthongbao = new Label();
            this.btboqua = new Button();
            this.dtdoimatkhau = new Button();
            this.label2 = new Label();
            this.txtmatkhaumoi = new TextBox();
            this.label3 = new Label();
            this.txtmatkhaumoi1 = new TextBox();
            this.label4 = new Label();
            this.txtmadangnhap = new TextBox();
            this.label1 = new Label();
            this.txtmatkhaucu = new TextBox();
            base.SuspendLayout();
            this.lbthongbao.AutoSize = true;
            this.lbthongbao.ForeColor = Color.FromArgb(192, 0, 0);
            this.lbthongbao.Location = new Point(9, 202);
            this.lbthongbao.Margin = new Padding(4, 0, 4, 0);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new Size(0, 20);
            this.lbthongbao.TabIndex = 13;
            this.btboqua.BackColor = Color.FromArgb(128, 255, 128);
            this.btboqua.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btboqua.ForeColor = Color.OrangeRed;
            this.btboqua.Location = new Point(152, 160);
            this.btboqua.Margin = new Padding(4, 5, 4, 5);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new Size(100, 33);
            this.btboqua.TabIndex = 6;
            this.btboqua.Text = "Hủy Bỏ";
            this.btboqua.UseVisualStyleBackColor = false;
            this.btboqua.Click += this.btboqua_Click;
            this.dtdoimatkhau.BackColor = Color.FromArgb(128, 255, 128);
            this.dtdoimatkhau.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.dtdoimatkhau.ForeColor = Color.OrangeRed;
            this.dtdoimatkhau.Location = new Point(32, 160);
            this.dtdoimatkhau.Margin = new Padding(4, 5, 4, 5);
            this.dtdoimatkhau.Name = "dtdoimatkhau";
            this.dtdoimatkhau.Size = new Size(112, 33);
            this.dtdoimatkhau.TabIndex = 5;
            this.dtdoimatkhau.Text = "Đổi mật khẩu";
            this.dtdoimatkhau.UseVisualStyleBackColor = false;
            this.dtdoimatkhau.Click += this.btdangnhap_Click;
            this.label2.AutoSize = true;
            this.label2.ForeColor = Color.FromArgb(0, 0, 192);
            this.label2.Location = new Point(9, 85);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu mới:";
            this.txtmatkhaumoi.BackColor = Color.GreenYellow;
            this.txtmatkhaumoi.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtmatkhaumoi.Location = new Point(125, 82);
            this.txtmatkhaumoi.Margin = new Padding(4, 5, 4, 5);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new Size(150, 26);
            this.txtmatkhaumoi.TabIndex = 3;
            this.txtmatkhaumoi.UseSystemPasswordChar = true;
            this.txtmatkhaumoi.KeyPress += this.txtmatkhaumoi_KeyPress;
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.FromArgb(0, 0, 192);
            this.label3.Location = new Point(9, 119);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(97, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập lại MK:";
            this.txtmatkhaumoi1.BackColor = Color.GreenYellow;
            this.txtmatkhaumoi1.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtmatkhaumoi1.Location = new Point(125, 116);
            this.txtmatkhaumoi1.Margin = new Padding(4, 5, 4, 5);
            this.txtmatkhaumoi1.Name = "txtmatkhaumoi1";
            this.txtmatkhaumoi1.Size = new Size(150, 26);
            this.txtmatkhaumoi1.TabIndex = 4;
            this.txtmatkhaumoi1.UseSystemPasswordChar = true;
            this.txtmatkhaumoi1.KeyPress += this.txtmatkhaumoi1_KeyPress;
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.FromArgb(0, 0, 192);
            this.label4.Location = new Point(9, 13);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(115, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã đăng nhập:";
            this.txtmadangnhap.BackColor = Color.PaleGoldenrod;
            this.txtmadangnhap.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtmadangnhap.Location = new Point(126, 10);
            this.txtmadangnhap.Margin = new Padding(4, 5, 4, 5);
            this.txtmadangnhap.Name = "txtmadangnhap";
            this.txtmadangnhap.Size = new Size(150, 26);
            this.txtmadangnhap.TabIndex = 1;
            this.txtmadangnhap.KeyPress += this.txtmadangnhap_KeyPress;
            this.label1.AutoSize = true;
            this.label1.ForeColor = Color.FromArgb(0, 0, 192);
            this.label1.Location = new Point(9, 49);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(100, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mật khẩu cũ:";
            this.txtmatkhaucu.BackColor = Color.PaleGoldenrod;
            this.txtmatkhaucu.ForeColor = Color.FromArgb(0, 0, 192);
            this.txtmatkhaucu.Location = new Point(126, 46);
            this.txtmatkhaucu.Margin = new Padding(4, 5, 4, 5);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.Size = new Size(150, 26);
            this.txtmatkhaucu.TabIndex = 2;
            this.txtmatkhaucu.UseSystemPasswordChar = true;
            this.txtmatkhaucu.KeyPress += this.txtmatkhaucu_KeyPress;
            base.AutoScaleDimensions = new SizeF(9f, 20f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(292, 229);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.txtmatkhaucu);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.txtmadangnhap);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.txtmatkhaumoi1);
            base.Controls.Add(this.lbthongbao);
            base.Controls.Add(this.btboqua);
            base.Controls.Add(this.dtdoimatkhau);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.txtmatkhaumoi);
            this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4, 5, 4, 5);
            base.Name = "FrmDoiMatKhau";
          ///  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmDoiMatKhau";
            base.Load += this.FrmDoiMatKhau_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000E0B RID: 3595
       // private IContainer components = null;

        // Token: 0x04000E0C RID: 3596
        private Label lbthongbao;

        // Token: 0x04000E0D RID: 3597
        private Button btboqua;

        // Token: 0x04000E0E RID: 3598
        private Button dtdoimatkhau;

        // Token: 0x04000E0F RID: 3599
        private Label label2;

        // Token: 0x04000E10 RID: 3600
        private TextBox txtmatkhaumoi;

        // Token: 0x04000E11 RID: 3601
        private Label label3;

        // Token: 0x04000E12 RID: 3602
        private TextBox txtmatkhaumoi1;

        // Token: 0x04000E13 RID: 3603
        private Label label4;

        // Token: 0x04000E14 RID: 3604
        private TextBox txtmadangnhap;

        // Token: 0x04000E15 RID: 3605
        private Label label1;

        // Token: 0x04000E16 RID: 3606
        private TextBox txtmatkhaucu;

        // Token: 0x04000E17 RID: 3607
       
    }
}
