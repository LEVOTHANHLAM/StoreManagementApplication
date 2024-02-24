using PosManager.APIServices.Kho;
using PosManager.APIServices.SanPham;
using PosManager.Forms.UserControls.Kho;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.SanPham;
using System.Windows.Forms;

namespace PosManager.Forms.UserControls.SanPham
{
    public partial class ItemProduct : UserControl
    {
        public ProductsModel _ProductsModel { get; set; }
        private FlowLayoutPanel _FlowLayoutPanel { get; set; }
        private ProductsController _productsController = new ProductsController();
        public ItemProduct(ProductsModel productsModel, FlowLayoutPanel layoutPanel)
        {
            _ProductsModel = productsModel;
            _FlowLayoutPanel = layoutPanel;
            InitializeComponent();
            lbDonViTinh.Text = _ProductsModel.TenDonViCoBan;
            picQRCode.Image = QRCodeHelper.GenerateQRCodeWithLogo(_ProductsModel.MaHangHoa, new Bitmap(Properties.Resources._326559583_468268058851274_8797007794984294310_n));
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            lbTenSanPham.Text = _ProductsModel.TenHangHoa;
            lbMaSanPham.Text = _ProductsModel.MaHangHoa;
        }

        private async void btnTonKho_Click(object sender, EventArgs e)
        {
            TonKhoController tonKhoController = new TonKhoController();
            var result = await tonKhoController.Search(GlobalModel.AccsessToken, "1", "9999999", "", "", _ProductsModel.MaHangHoa);
            if (result != null && result.StatusCode == 200)
            {
                if (result.Data.Total > 0)
                {
                    fChiTietTonKho fChiTietTonKho = new fChiTietTonKho(result.Data.Result.FirstOrDefault());
                    fChiTietTonKho.ShowDialog();
                }
                else
                {
                    MessageCommon.ShowMessageBox("trong kho chưa có sản phẩm này", 1);
                }

            }
            else
            {
                MessageCommon.ShowMessageBox("Đã xảy ra lỗi vui lòng thử lại sau", 3);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageCommon.ShowConfirmationBox($"Bạn thật sự muốn xóa sản phẩm {_ProductsModel.TenHangHoa}!") == DialogResult.Yes)
            {
                var result = await _productsController.Delete(GlobalModel.AccsessToken, _ProductsModel.Id.ToString());
                if (result != null && result.StatusCode == 200)
                {
                    _FlowLayoutPanel.Controls.Remove(this);
                }
                else
                {
                    MessageCommon.ShowMessageBox("Đã xảy ra lỗi vui lòng thử lại sau", 3);
                }

            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
