using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmsodo
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Frmsodo));
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Center;
            base.ClientSize = new Size(611, 533);
            this.DoubleBuffered = true;
          //  base.MaximizeBox = false;
        //    base.MinimizeBox = false;
            base.Name = "Frmsodo";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SƠ ĐỒ BÁN HÀNG";
          //  base.TopMost = true;
            base.ResumeLayout(false);
        }

        #endregion
    }
}
