using DocumentFormat.OpenXml.Drawing.Charts;
using PosManager.Forms.UI;
using PosManager.Forms.UserControls.Post;
using PosManager.Model.SanPham;
using System.ComponentModel;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class ItemControlProductImportKho : UserControl
    {
        private FlowLayoutPanel layoutPanel;
        public ItemControlProductImportKho(ProductsModel model, FlowLayoutPanel flowLayoutPanel)
        {
            layoutPanel = flowLayoutPanel;
            InitializeComponent();
            Dock = DockStyle.Top;
            labelMaSanPham.Text = model.MaHangHoa;
            foreach (var item in model.GiaBan)
            {
                if (!cbbTenDonViTinh.Items.Contains(item.TenDonViHangHoa))
                {
                    cbbTenDonViTinh.Items.Add(item.TenDonViHangHoa);
                }
            }
            cbbTenDonViTinh.SelectedIndex = 0;
            LabelName.Text = model.TenHangHoa;
            LabelSubtotal.Text = "0";

            //_Order = order;
            //this.Orders = Orders;
            // LabelName.Text = order.GetAllProduct().Name;
        }

        public void UpdateData()
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Remove(this);
        }

        private void LabelSubtotal_Click(object sender, EventArgs e)
        {
            fNhapSo nhapSo = new fNhapSo(null);
            nhapSo.ShowDialog();
            if (!string.IsNullOrEmpty(nhapSo.SoLuong))
            {
                LabelSubtotal.Text = nhapSo.SoLuong;
            }

        }
    }
}
