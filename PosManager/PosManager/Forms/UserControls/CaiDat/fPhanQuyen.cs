using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Wordprocessing;
using PosManager.APIServices.User;
using PosManager.Forms;
using PosManager.Model;
using PosManager.Model.User;

namespace Krypton_toolKitDemo
{
    public partial class fPhanQuyen : KryptonForm
    {
        private string _idUser { get; set; }
        private UsersController _usersController;
        public fPhanQuyen(string idUser)
        {
            InitializeComponent();
            _idUser = idUser;
            _usersController = new UsersController();
        }
        private async Task loadAccount()
        {
            if (!string.IsNullOrEmpty(_idUser))
            {
                var result = await _usersController.GetPermissionsByIdUser(GlobalModel.AccsessToken, _idUser);
                if (result != null && result.Data.Count > 0)
                {
                    dtgvAccount.Rows.Clear();
                    foreach (var item in result.Data)
                    {
                        dtgvAccount.Rows.Add(item.FunctionName, item.HasView, item.HasCreate, item.HasUpdate, item.HasDelete, item.UserId, item.FunctionId);
                    }
                }
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await loadAccount();
        }

        private async void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            PermissionUpdateModel updateModel = new PermissionUpdateModel();
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cView"].Index)
            {
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cIdUser"].Value.ToString();
                updateModel.UserId = id;
                updateModel.NewValue = !(bool)dtgvAccount.Rows[e.RowIndex].Cells["cView"].Value;
                updateModel.Command = "View";
                updateModel.FunctionId = (Guid)dtgvAccount.Rows[e.RowIndex].Cells["cFunctionId"].Value;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cCreate"].Index)
            {
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cIdUser"].Value.ToString();
                updateModel.UserId = id;
                updateModel.NewValue = !(bool)dtgvAccount.Rows[e.RowIndex].Cells["cCreate"].Value;
                updateModel.Command = "Create";
                updateModel.FunctionId = (Guid)dtgvAccount.Rows[e.RowIndex].Cells["cFunctionId"].Value;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cUpdate"].Index)
            {
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cIdUser"].Value.ToString();
                updateModel.UserId = id;
                updateModel.NewValue = !(bool)dtgvAccount.Rows[e.RowIndex].Cells["cUpdate"].Value;
                updateModel.Command = "Update";
                updateModel.FunctionId = (Guid)dtgvAccount.Rows[e.RowIndex].Cells["cFunctionId"].Value;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cDelete"].Index)
            {
                var id = dtgvAccount.Rows[e.RowIndex].Cells["cIdUser"].Value.ToString();
                updateModel.UserId = id;
                updateModel.NewValue = !(bool)dtgvAccount.Rows[e.RowIndex].Cells["cDelete"].Value;
                updateModel.Command = "Delete";
                updateModel.FunctionId = (Guid)dtgvAccount.Rows[e.RowIndex].Cells["cFunctionId"].Value;
            }
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            await _usersController.UpdatePermissionsByIdUser(GlobalModel.AccsessToken, updateModel);
            await loadAccount();
            SplashScreenManager.CloseForm(false);
        }
    }
}
