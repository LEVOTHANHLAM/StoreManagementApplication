using PosManager.Model.SanPham;

namespace PosManager.Forms.UserControls.Post
{
    public partial class ProductCardComponent1 : UserControl
    {
        private ProductsModel product;

        public event EventHandler<ProductsModel> ButtonAddProductClick;

        public ProductCardComponent1(ProductsModel product)
        {
            InitializeComponent();
            this.product = product;

            //ButtonAddProduct.Visible = product.IsAvailable;
            //ButtonUnavailable.Visible = !product.IsAvailable;

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (ButtonAddProductClick != null) ButtonAddProductClick(sender, product);
        }

        private void ProductCardComponent1_Load(object sender, EventArgs e)
        {
            LabelName.Text = product.TenHangHoa;
            LabelPrice.Text = "";
            LabelDonViTinh.Text = product.TenDonViCoBan;
            //PictureProductImage.ImageLocation = product.Image;
        }
    }
}
