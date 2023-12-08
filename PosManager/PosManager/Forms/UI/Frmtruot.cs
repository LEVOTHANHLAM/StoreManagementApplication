using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmtruot : Form
    {
        public Frmtruot()
        {
            InitializeComponent();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
            }
        }

        // Token: 0x0600069F RID: 1695 RVA: 0x00132D64 File Offset: 0x00130F64
        private void Frmtruot_Load(object sender, EventArgs e)
        {
            if (this.backgroundWorker1.IsBusy)
            {
            }
        }

        // Token: 0x060006A0 RID: 1696 RVA: 0x0001CC32 File Offset: 0x0001AE32
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.progressBar1.Update();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

    }
}
