using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

namespace PosManager.Forms.UI
{
    public partial class fNhapSo : Form
    {
        public string SoLuong =string.Empty;
        public fNhapSo(string? soLuong)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(soLuong))
            {
                txtgiacu.Text = soLuong;
            }
           
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.txtgiacu.Text = this.txtgiacu.Text + button.Text;
            // Sử dụng định dạng số tiền trong CultureInfo để có thể chuyển đổi số thành chuỗi có dấu phẩy
            decimal value;
            if (decimal.TryParse(this.txtgiacu.Text, out value))
            {
                this.txtgiacu.Text = value.ToString("#,##0");
            }

           // this.txtgiacu.Text = result.ToString();
        }

        // Token: 0x0600091F RID: 2335 RVA: 0x00166AD8 File Offset: 0x00164CD8
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        // Token: 0x06000920 RID: 2336 RVA: 0x00166C84 File Offset: 0x00164E84
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtgiacu.Text))
            {
                SoLuong = txtgiacu.Text;
            }
            Close();
        }

        // Token: 0x06000921 RID: 2337 RVA: 0x00166CE8 File Offset: 0x00164EE8
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Token: 0x06000922 RID: 2338 RVA: 0x0001D5BE File Offset: 0x0001B7BE
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Token: 0x06000923 RID: 2339 RVA: 0x00166D74 File Offset: 0x00164F74
        private void Frm_suagia_Load(object sender, EventArgs e)
        {
           
        }

        // Token: 0x06000924 RID: 2340 RVA: 0x00166E8C File Offset: 0x0016508C
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
            }
        }

        // Token: 0x06000925 RID: 2341 RVA: 0x00166F20 File Offset: 0x00165120
        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        // Token: 0x06000926 RID: 2342 RVA: 0x00166F48 File Offset: 0x00165148
        private void Frm_suagia_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        // Token: 0x06000927 RID: 2343 RVA: 0x00089160 File Offset: 0x00087360
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtgiacu.Text))
            {
                // Cách 1: Sử dụng phương thức Remove
                txtgiacu.Text = txtgiacu.Text.Remove(txtgiacu.Text.Length - 1);
                decimal value;
                if (decimal.TryParse(this.txtgiacu.Text, out value))
                {
                    this.txtgiacu.Text = value.ToString("#,##0");
                }
                // Cách 2: Sử dụng Substring để cắt bớt ký tự cuối cùng
                // textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }
    }
}
