using DevExpress.Diagram.Core.Shapes;
using PosManager.Forms.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class fUpdateHoaDonNhapKho : UserControl
    {
        private Panel _main;
        private Panel _panel;
        public fUpdateHoaDonNhapKho(Panel main, Panel panel)
        {
            _main = main;
            _panel = panel;
            InitializeComponent();
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
        private void txtTienGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            decimal value;
            if (decimal.TryParse(this.txtTienGiam.Text, out value))
            {
                this.txtTienGiam.Text = value.ToString("#,##0");
                txtTienGiam.SelectionStart = txtTienGiam.Text.Length; // Di chuyển con trỏ về cuối TextBox
            }
        }

    
    }
}
