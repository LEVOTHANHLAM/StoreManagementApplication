namespace PosManager.Forms.UI
{
    partial class frmRegistration
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
            this.txtproductID = new TextBox();
            this.txtproductkey = new TextBox();
            this.label4 = new Label();
            this.label2 = new Label();
            this.btok = new Button();
            this.button1 = new Button();
            base.SuspendLayout();
            this.txtproductID.Font = new Font("Arial Narrow", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtproductID.Location = new Point(109, 9);
            this.txtproductID.Name = "txtproductID";
            this.txtproductID.Size = new Size(568, 35);
            this.txtproductID.TabIndex = 18;
            this.txtproductkey.Font = new Font("Arial Narrow", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtproductkey.Location = new Point(109, 59);
            this.txtproductkey.Name = "txtproductkey";
            this.txtproductkey.Size = new Size(568, 35);
            this.txtproductkey.TabIndex = 17;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0, 69);
            this.label4.Name = "label4";
            this.label4.Size = new Size(112, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "License Serial:";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(39, 19);
            this.label2.Name = "label2";
            this.label2.Size = new Size(53, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Serial:";
            this.btok.BackColor = Color.Yellow;
            this.btok.FlatStyle = FlatStyle.Flat;
            this.btok.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btok.ForeColor = Color.Green;
            this.btok.Location = new Point(403, 113);
            this.btok.Name = "btok";
            this.btok.Size = new Size(274, 60);
            this.btok.TabIndex = 14;
            this.btok.Text = "Đăng ký";
            this.btok.UseVisualStyleBackColor = false;
            this.btok.Click += this.btok_Click;
            this.button1.BackColor = Color.Yellow;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.Green;
            this.button1.Location = new Point(109, 114);
            this.button1.Name = "button1";
            this.button1.Size = new Size(270, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0, 192, 192);
            base.ClientSize = new Size(712, 186);
          //  base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txtproductID);
            base.Controls.Add(this.txtproductkey);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.btok);
            base.Name = "frmRegistration";
        //    base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += this.frmRegistration_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private TextBox txtproductID;

        // Token: 0x04000C76 RID: 3190
        private TextBox txtproductkey;

        // Token: 0x04000C77 RID: 3191
        private Label label4;

        // Token: 0x04000C78 RID: 3192
        private Label label2;

        // Token: 0x04000C79 RID: 3193
        private Button btok;

        // Token: 0x04000C7A RID: 3194
        private Button button1;
    }
}
