namespace PosManager.Forms.UserControls.Post
{
    public partial class ThanhToanProduct : UserControl
    {
        private Panel main;
        private Panel _pan1;
        public ThanhToanProduct(Panel panel, Panel panel1)
        {
            InitializeComponent();
            main = panel;
            _pan1 = panel1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(_pan1);
        }
    }
}
