using PosManager.APIServices.ThanhToan;
using PosManager.Forms.UI;
using PosManager.Model;
using PosManager.Model.HoaDon;
using PosManager.Model.ThanhToan;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class fUpdateHoaDonNhapKho : UserControl
    {
        private Panel _main;
        private Panel _panel;
        private HoaDonNhapModel _hoaDonNhap;
        
        public fUpdateHoaDonNhapKho(Panel main, Panel panel,HoaDonNhapModel model)
        {
            _main = main;
            _panel = panel;
            _hoaDonNhap = model;
            InitializeComponent();
            txtTongTien.Text = model.TongTien.ToString("#,##0");
            txtThanhTien.Text = model.TongTien.ToString("#,##0");
            txtTienGiam.Text = "0";
            lbNguoiBan.Text = GlobalModel.UserInfo.Name;

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép nhập ký tự đó vào TextBox
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _main.Controls.Clear();
            _main.Controls.Add(_panel);
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //decimal value;
            //if (decimal.TryParse(textBox.Text, out value))
            //{
            //    textBox.Text = value.ToString("#,##0");
            //    textBox.SelectionStart = textBox.Text.Length; // Di chuyển con trỏ về cuối TextBox
            //}

            // this.txtgiacu.Text = result.ToString();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            decimal value;
            if (decimal.TryParse(textBox.Text.Replace(",", ""), out value))
            {
                textBox.TextChanged -= TextChanged; // Tạm thời tắt sự kiện TextChanged để tránh lặp vô hạn
                textBox.Text = value.ToString("#,##0");
                textBox.SelectionStart = textBox.Text.Length; // Di chuyển con trỏ về cuối TextBox
                if (textBox.Name == "txtTienGiam")
                {
                  txtThanhTien.Text =   (decimal.Parse(txtTongTien.Text) - value).ToString("#,##0");
                }
                textBox.TextChanged += TextChanged; // Bật lại sự kiện TextChanged
               
            }
        }
        private void TextClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            fNhapSo nhapSo = new fNhapSo(null);
            nhapSo.ShowDialog();
            if (!string.IsNullOrEmpty(nhapSo.SoLuong))
            {
                textBox.Text = nhapSo.SoLuong;
            }
        }
        private async void btnNhapKho_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDonController thanhToanHoaDonController = new ThanhToanHoaDonController();
            ThanhToanHoaDonModel model = new ThanhToanHoaDonModel();
            model.MaThamChieu = _hoaDonNhap.MaHoaDonNhap;
            model.LoaiHoaDon = "HDN";
            model.NoiDungThanhToan = "thanh toán hóa đơn nhập kho";
            model.CachThucGiaoDich = "Tiền Mặt";
            model.SoTienGiaoDich = 176231;
            model.MaNhanVien = (string)PosManager.Properties.Settings.Default["username"];
            //  model.MaNhanVien = GlobalModel.UserInfo.
            var result = await thanhToanHoaDonController.Add(GlobalModel.AccsessToken, model);
        }
    }
}
