using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.CaiDat;
using PosManager.Helper;
using PosManager.Model;

namespace Krypton_toolKitDemo
{
    public partial class fThemFunctions : KryptonForm
    {
        private string? Id { get; set; }
        public fThemFunctions(string? id, string? name)
        {
            InitializeComponent();
            Id = id;
            txtTen.Text = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text.Trim()))
            {
                MessageCommon.ShowMessageBox("Vui Lòng Nhập thông tin!", 3);
                return;
            }
            SystemFunctionsController systemFunctionsController = new SystemFunctionsController();
            if (string.IsNullOrEmpty(Id))
            {
                var result = await systemFunctionsController.Add(GlobalModel.AccsessToken, txtTen.Text.Trim(), null);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
            else
            {
                var result = await systemFunctionsController.Edit(GlobalModel.AccsessToken, Id, txtTen.Text.Trim(), null);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
