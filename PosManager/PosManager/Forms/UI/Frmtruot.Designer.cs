using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmtruot
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
            this.backgroundWorker1 = new BackgroundWorker();
            this.progressBar1 = new ProgressBar();
            base.SuspendLayout();
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += this.backgroundWorker1_DoWork;
            this.backgroundWorker1.ProgressChanged += this.backgroundWorker1_ProgressChanged;
            this.backgroundWorker1.RunWorkerCompleted += this.backgroundWorker1_RunWorkerCompleted;
            this.progressBar1.Dock = DockStyle.Fill;
            this.progressBar1.Location = new Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(595, 45);
            this.progressBar1.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(595, 45);
           // base.ControlBox = false;
            base.Controls.Add(this.progressBar1);
            base.Name = "Frmtruot";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += this.Frmtruot_Load;
            base.ResumeLayout(false);
        }


        #endregion

        // Token: 0x040007C0 RID: 1984
        private BackgroundWorker backgroundWorker1;

        // Token: 0x040007C1 RID: 1985
        private ProgressBar progressBar1;
    }
}
