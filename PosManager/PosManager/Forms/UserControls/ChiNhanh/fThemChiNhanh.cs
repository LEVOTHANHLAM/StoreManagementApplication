using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using PosManager.Model.ChiNhanh;

namespace Krypton_toolKitDemo
{
    public partial class fThemChiNhanh : KryptonForm
    {
        private ChiNhanhModel _chiNhanhModel;
        public fThemChiNhanh(ChiNhanhModel? chiNhanhModel)
        {
            InitializeComponent();
            if (chiNhanhModel != null)
            {
                _chiNhanhModel = chiNhanhModel;
                txtDiaChi.Text = _chiNhanhModel.Address;
                txtSDT.Text = _chiNhanhModel.SDT;
                txtTen.Text = _chiNhanhModel.Name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
