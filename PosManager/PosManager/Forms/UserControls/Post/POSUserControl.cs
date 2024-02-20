namespace PosManager.Forms.UserControls.Post
{
    public partial class POSUserControl : UserControl
    {
        public POSUserControl()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            //panel10
            //PanelOrders
            ThanhToanProduct childForm = new ThanhToanProduct(splitContainer2.Panel2, pThanhToasn);
            childForm.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(childForm);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
