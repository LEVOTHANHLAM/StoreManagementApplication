using ComponentFactory.Krypton.Toolkit;
using PosManager.APIServices.CaiDat;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using Serilog;

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
            fLoading fLoading = new fLoading();
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text.Trim()))
                {
                    MessageCommon.ShowMessageBox("Vui Lòng Nhập thông tin!", 3);
                    return;
                }
                fLoading.StartLoading();
                SystemFunctionsController systemFunctionsController = new SystemFunctionsController();
                if (string.IsNullOrEmpty(Id))
                {
                    var result = await systemFunctionsController.Add(GlobalModel.AccsessToken, txtTen.Text.Trim(), null);
                    if (result != null)
                    {
                        fLoading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                else
                {
                    var result = await systemFunctionsController.Edit(GlobalModel.AccsessToken, Id, txtTen.Text.Trim(), null);
                    if (result != null)
                    {
                        fLoading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        fLoading.Close();
                        MessageCommon.ShowMessageBox(" Lỗi hệ thống vui lòng thử lại ", 3);
                    }
                }
                fLoading.Close();
            }
            catch (Exception ex)
            {
                fLoading.Close();
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message);
            }
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
