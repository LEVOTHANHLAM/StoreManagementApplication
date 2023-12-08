namespace PosManager.Forms.UI
{
    partial class Frmmainload
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
            base.SuspendLayout();
            this.button1.AutoSize = true;
            this.button1.BackColor = Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 48f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new Size(1073, 269);
            this.button1.TabIndex = 0;
            this.button1.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG\r\n\r\nTOÀN CẦU";
            this.button1.UseVisualStyleBackColor = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Yellow;
            base.ClientSize = new Size(1082, 488);
            //base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Name = "Frmmainload";
           // base.StartPosition = FormStartPosition.CenterScreen;
           //ase.FormClosed += this.Frmmainload_FormClosed;
        //    base.Load += this.Frmmainload_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Button button1;
    }
}
