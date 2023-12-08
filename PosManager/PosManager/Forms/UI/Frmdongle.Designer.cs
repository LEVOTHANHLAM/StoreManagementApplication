namespace PosManager.Forms.UI
{
    partial class Frmdongle
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
            this.listView1 = new ListView();
            base.SuspendLayout();
            this.listView1.Location = new Point(12, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(723, 366);
            base.Controls.Add(this.listView1);
            base.Name = "Frmdongle";
            this.Text = "Frmdongle";
            base.Load += this.Frmdongle_Load;
            base.ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
    }
}
