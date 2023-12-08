using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Krypton_toolKitDemo
{
    public partial class fMain : KryptonForm
    {
        private fLogin _fLogin;
        bool khachHangCollapse = true;
        bool hangHoaCollapse = true;
        bool khoCollapse = true;
        bool MenuCollapse = true;
        bool NhanVienCollapse = true;
        bool HoaDonCollapse = true;
        bool CongNoCollapse = true;
        bool BaoCaoCollapse = true;

        private int startPosition = 0;
        private string displayText = "Cảm Ơn Quý Khách Đã Tin Tưởng Chúng Tôi!               ";
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HieuUngTimer.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangTimer.Start();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaTimer.Start();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            KhoTimer.Start();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoTimer.Start();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonTimer.Start();
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            CongNoTimer.Start();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienTimer.Start();
        }

        private void KhoTimer_Tick(object sender, EventArgs e)
        {
            if (khoCollapse)
            {
                KhoContainer.Height += 10;
                if (KhoContainer.Height == KhoContainer.MaximumSize.Height)
                {
                    khoCollapse = false;
                    KhoTimer.Stop();
                }
            }
            else
            {
                KhoContainer.Height -= 10;
                if (KhoContainer.Height == KhoContainer.MinimumSize.Height)
                {
                    khoCollapse = true;
                    KhoTimer.Stop();
                }
            }
        }

        private void HieuUngTimer_Tick(object sender, EventArgs e)
        {
            //// Di chuyển vị trí hiện tại của chuỗi sang phải
            startPosition++;

            if (startPosition < displayText.Length)
            {
                txtHieuUng.Text = displayText.Substring(startPosition) + displayText.Substring(0, startPosition);
            }
            else
            {
                startPosition = 0; // Nếu đã hiển thị hết chuỗi, bắt đầu lại từ đầu
            }
        }

        private void HoaDonTimer_Tick(object sender, EventArgs e)
        {
            if (HoaDonCollapse)
            {
                HoaDonContainer.Height += 10;
                if (HoaDonContainer.Height == HoaDonContainer.MaximumSize.Height)
                {
                    HoaDonCollapse = false;
                    HoaDonTimer.Stop();
                }
            }
            else
            {
                HoaDonContainer.Height -= 10;
                if (HoaDonContainer.Height == HoaDonContainer.MinimumSize.Height)
                {
                    HoaDonCollapse = true;
                    HoaDonTimer.Stop();
                }
            }
        }

        private void HangHoaTimer_Tick(object sender, EventArgs e)
        {
            if (hangHoaCollapse)
            {
                HangHoaContainer.Height += 10;
                if (HangHoaContainer.Height == HangHoaContainer.MaximumSize.Height)
                {
                    hangHoaCollapse = false;
                    HangHoaTimer.Stop();
                }
            }
            else
            {
                HangHoaContainer.Height -= 10;
                if (HangHoaContainer.Height == HangHoaContainer.MinimumSize.Height)
                {
                    hangHoaCollapse = true;
                    HangHoaTimer.Stop();
                }
            }
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (MenuCollapse)
            {
                pbLogoMeXiu.Width -= 10;
                flpMain.Width -= 10;
                // txtHieuUng.Width += 10;
                if (pbLogoMeXiu.Width == pbLogoMeXiu.MinimumSize.Width && flpMain.Width == flpMain.MinimumSize.Width /*&& txtHieuUng.Width == txtHieuUng.MaximumSize.Width*/)
                {
                    MenuCollapse = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                pbLogoMeXiu.Width += 10;
                flpMain.Width += 10;
                // txtHieuUng.Width -= 10;
                if (pbLogoMeXiu.Width == pbLogoMeXiu.MaximumSize.Width && flpMain.Width == flpMain.MaximumSize.Width /*&& txtHieuUng.Width == txtHieuUng.MinimumSize.Width*/)
                {
                    MenuCollapse = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void NhanVienTimer_Tick(object sender, EventArgs e)
        {
            if (NhanVienCollapse)
            {
                NhanVienContainer.Height += 10;
                if (NhanVienContainer.Height == NhanVienContainer.MaximumSize.Height)
                {
                    NhanVienCollapse = false;
                    NhanVienTimer.Stop();
                }
            }
            else
            {
                NhanVienContainer.Height -= 10;
                if (NhanVienContainer.Height == NhanVienContainer.MinimumSize.Height)
                {
                    NhanVienCollapse = true;
                    NhanVienTimer.Stop();
                }
            }
        }

        private void CongNoTimer_Tick(object sender, EventArgs e)
        {
            if (CongNoCollapse)
            {
                CongNoContainer.Height += 10;
                if (CongNoContainer.Height == CongNoContainer.MaximumSize.Height)
                {
                    CongNoCollapse = false;
                    CongNoTimer.Stop();
                }
            }
            else
            {
                CongNoContainer.Height -= 10;
                if (CongNoContainer.Height == CongNoContainer.MinimumSize.Height)
                {
                    CongNoCollapse = true;
                    CongNoTimer.Stop();
                }
            }
        }

        private void BaoCaoTimer_Tick(object sender, EventArgs e)
        {
            if (BaoCaoCollapse)
            {
                BaoCaoContainer.Height += 10;
                if (BaoCaoContainer.Height == BaoCaoContainer.MaximumSize.Height)
                {
                    BaoCaoCollapse = false;
                    BaoCaoTimer.Stop();
                }
            }
            else
            {
                BaoCaoContainer.Height -= 10;
                if (BaoCaoContainer.Height == BaoCaoContainer.MinimumSize.Height)
                {
                    BaoCaoCollapse = true;
                    BaoCaoTimer.Stop();
                }
            }
        }

        private void KhachHangTimer_Tick(object sender, EventArgs e)
        {
            if (khachHangCollapse)
            {
                KhachHangContainer.Height += 10;
                if (KhachHangContainer.Height == KhachHangContainer.MaximumSize.Height)
                {
                    khachHangCollapse = false;
                    KhachHangTimer.Stop();
                }
            }
            else
            {
                KhachHangContainer.Height -= 10;
                if (KhachHangContainer.Height == KhachHangContainer.MinimumSize.Height)
                {
                    khachHangCollapse = true;
                    KhachHangTimer.Stop();
                }
            }
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            if (pbProfile.Visible)
            {
                Point newLocation = pProfile.Location;
                newLocation.X = pbProfile.Location.X;
                pProfile.Location = newLocation;
            }
            pProfile.Visible = !pProfile.Visible;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

            _fLogin = new fLogin();
            _fLogin.Show();
            Close();
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_fLogin == null)
            {
                Application.Exit();
            }
          
        }
    }
}
