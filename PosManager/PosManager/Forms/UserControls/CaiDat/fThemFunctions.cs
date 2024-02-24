using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using PosManager.APIServices.CaiDat;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using Serilog;

namespace PosManager
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
            
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text.Trim()))
                {
                    MessageCommon.ShowMessageBox("Vui Lòng Nhập thông tin!", 3);
                    return;
                }
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                SystemFunctionsController systemFunctionsController = new SystemFunctionsController();
                if (string.IsNullOrEmpty(Id))
                {
                    var result = await systemFunctionsController.Add(GlobalModel.AccsessToken, txtTen.Text.Trim(), null);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                }
                else
                {
                    var result = await systemFunctionsController.Edit(GlobalModel.AccsessToken, Id, txtTen.Text.Trim(), null);
                    if (result != null)
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false);
                        MessageCommon.ShowMessageBox(" Lỗi hệ thống vui lòng thử lại ", 3);
                    }
                }
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
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
