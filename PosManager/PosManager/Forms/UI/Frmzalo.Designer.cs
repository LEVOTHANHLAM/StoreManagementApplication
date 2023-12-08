namespace PosManager.Forms.UI
{
    partial class Frmzalo
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
            this.textBox2 = new TextBox();
            base.SuspendLayout();
            this.textBox1.Location = new Point(21, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox2.Location = new Point(21, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(130, 20);
            this.textBox2.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(284, 261);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Name = "Frmzalo";
            this.Text = "Frmzalo";
         //   base.Load += this.Frmzalo_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        #endregion

        // Token: 0x04001233 RID: 4659
        private TextBox textBox1;

        // Token: 0x04001234 RID: 4660
        private TextBox textBox2;
    }
}
