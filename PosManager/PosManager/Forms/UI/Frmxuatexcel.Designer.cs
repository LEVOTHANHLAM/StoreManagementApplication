using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmxuatexcel
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
            this.dataGridView1 = new DataGridView();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(565, 299);
            this.dataGridView1.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(565, 298);
            base.Controls.Add(this.dataGridView1);
            base.Name = "Frmxuatexcel";
            this.Text = "Frmxuatexcel";
            base.Load += this.Frmxuatexcel_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }
        #endregion

        // Token: 0x04000C31 RID: 3121
        private DataGridView dataGridView1;
    }
}
