using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmtinhkho
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
            this.maskedTextBox1 = new MaskedTextBox();
            this.label1 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.maskedTextBox1.Font = new Font("Times New Roman", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.maskedTextBox1.Location = new Point(152, 14);
            this.maskedTextBox1.Margin = new Padding(6, 5, 6, 5);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new Size(196, 48);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(DateTime);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày:";
            this.button1.Location = new Point(7, 97);
            this.button1.Name = "button1";
            this.button1.Size = new Size(205, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tồn kho hàng hóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.Location = new Point(250, 97);
            this.button2.Name = "button2";
            this.button2.Size = new Size(205, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tồn kho nguyên liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(12f, 23f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(493, 159);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.maskedTextBox1);
            this.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(6, 5, 6, 5);
            //  base.MaximizeBox = false;
            //  base.MinimizeBox = false;
            base.Name = "Frmtinhkho";
            //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TÍNH LẠI TỒN KHO";
            base.Load += this.Frmtinhkho_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        #endregion

        // Token: 0x040007C3 RID: 1987
        private MaskedTextBox maskedTextBox1;

        // Token: 0x040007C4 RID: 1988
        private Label label1;

        // Token: 0x040007C5 RID: 1989
        private Button button1;

        // Token: 0x040007C6 RID: 1990
        private Button button2;
    }
}
