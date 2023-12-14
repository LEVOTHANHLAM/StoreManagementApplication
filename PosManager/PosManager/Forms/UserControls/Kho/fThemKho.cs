using ComponentFactory.Krypton.Toolkit;
using DocumentFormat.OpenXml.Office2010.Excel;
using PosManager.APIServices.CaiDat;
using PosManager.APIServices.Kho;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.Kho;

namespace Krypton_toolKitDemo
{
    public partial class fThemKho : KryptonForm
    {
        private StocksController _stocksController;
        private StockModel _stock { get; set; }
        public fThemKho(StockModel? stock)
        {
            InitializeComponent();
            _stock = stock;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_stock != null)
            {
                txtDiaChi.Text = _stock.MaKho;
                txtTen.Text = _stock.TenKho;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập đủ thông tin!");
                return;
            }
            _stocksController = new StocksController();
            if (_stock != null)
            {
                _stock.TenKho = txtTen.Text;
                _stock.MaKho = txtDiaChi.Text;
                var result = await _stocksController.Edit(GlobalModel.AccsessToken, _stock);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
            else
            {
                StockModel stock = new StockModel();
                stock.TenKho = txtTen.Text;
                stock.MaKho = txtDiaChi.Text;
                var result = await _stocksController.Add(GlobalModel.AccsessToken, stock);
                if (result != null)
                {
                    MessageCommon.ShowMessageBox(result.Message);
                }
            }
        }
    }
}
