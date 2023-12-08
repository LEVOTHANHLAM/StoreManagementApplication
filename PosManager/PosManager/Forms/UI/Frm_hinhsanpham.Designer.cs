using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_hinhsanpham
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
            this.ptlogo = new PictureBox();
            ((ISupportInitialize)this.ptlogo).BeginInit();
            base.SuspendLayout();
            this.ptlogo.BackColor = Color.FromArgb(192, 255, 192);
            this.ptlogo.BackgroundImageLayout = ImageLayout.None;
            this.ptlogo.BorderStyle = BorderStyle.FixedSingle;
            this.ptlogo.Dock = DockStyle.Fill;
            this.ptlogo.Location = new Point(0, 0);
            this.ptlogo.Name = "ptlogo";
            this.ptlogo.Size = new Size(752, 729);
            this.ptlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptlogo.TabIndex = 12;
            this.ptlogo.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(752, 729);
            base.Controls.Add(this.ptlogo);
            base.MinimizeBox = false;
            base.Name = "Frm_hinhsanpham";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hình sản phẩm";
            base.Load += this.Frm_hinhsanpham_Load;
            ((ISupportInitialize)this.ptlogo).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        private PictureBox ptlogo;
    }
}