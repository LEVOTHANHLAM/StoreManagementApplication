using DocumentFormat.OpenXml.Drawing.Charts;
using System.ComponentModel;

namespace PosManager.Forms.UserControls.Post
{
    public partial class OrderItemComponent : UserControl
    {
        public Order _Order;

        private BindingList<OrderItemComponent> Orders;

        public event EventHandler<OrderItemComponent> OnOrderIncrement;

        public OrderItemComponent(BindingList<OrderItemComponent> Orders, Order order)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            _Order = order;
            this.Orders = Orders;
            // LabelName.Text = order.GetAllProduct().Name;
        }

        public void UpdateData()
        {
            //   LabelQuantity.Text = _Order.Quantity.ToString();
            // LabelSubtotal.Text = _Order.Subtotal.ToString() + "PHP";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (OnOrderIncrement != null) OnOrderIncrement(1, this);
            /*
            _Order.Quantity++;
            Orders.ResetBindings();
             */
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (OnOrderIncrement != null) OnOrderIncrement(-1, this);
        }
    }
}
