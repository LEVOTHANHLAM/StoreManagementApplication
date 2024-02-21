using DocumentFormat.OpenXml.Drawing.Charts;
using PosManager.Forms.UserControls.Post;
using System.ComponentModel;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class UserControl1 : UserControl
    {
        public Order _Order;

        private BindingList<OrderItemComponent> Orders;

        public event EventHandler<OrderItemComponent> OnOrderIncrement;

        public UserControl1(string name, string id, string code, List<string> cbb)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            label1.Text = code;
            foreach(var item in cbb)
            {
                cbbMaKho.Items.Add(item);
            }
            LabelName.Text = name;
            LabelSubtotal.Text = id;

            //_Order = order;
            //this.Orders = Orders;
            // LabelName.Text = order.GetProduct().Name;
        }

        public void UpdateData()
        {
            //   LabelQuantity.Text = _Order.Quantity.ToString();
            // LabelSubtotal.Text = _Order.Subtotal.ToString() + "PHP";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           // if (OnOrderIncrement != null) OnOrderIncrement(1, this);
            /*
            _Order.Quantity++;
            Orders.ResetBindings();
             */
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
           // if (OnOrderIncrement != null) OnOrderIncrement(-1, this);
        }
    }
}
