using ComponentFactory.Krypton.Toolkit;
using PosManager.Forms;
using PosManager.Forms.UserControls;
using PosManager.Forms.UserControls.KhachHang;
using PosManager.Forms.UserControls.Kho;
using PosManager.Forms.UserControls.NhanVien;
using PosManager.Forms.UserControls.Post;
using PosManager.Forms.UserControls.SanPham;
using PosManager.Model;
using System.Windows.Forms;

namespace Krypton_toolKitDemo
{
    public partial class fMain : KryptonForm
    {
        private fLoading loading = new fLoading();
        private readonly fLogin _fLogin;
        bool khachHangCollapse = true;
        bool hangHoaCollapse = true;
        bool khoCollapse = true;
        bool MenuCollapse = true;
        bool NhanVienCollapse = true;
        bool HoaDonCollapse = true;
        bool CongNoCollapse = true;
        bool BaoCaoCollapse = true;

        private int startPosition = 0;
        private string displayText = "Cảm Ơn Quý Khách Đã Tin Tưởng Chúng Tôi!";
        public fMain(fLogin login)
        {
            _fLogin = login;
            InitializeComponent();

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.Yellow; // Màu mới khi di chuột vào
            }

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.White; // Màu mặc định
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (displayText.Length < 250)
            {
                // Tạo chuỗi mới chỉ chứa khoảng trắng để đạt đến độ dài 250
                int spacesToAdd = 250 - displayText.Length;
                string spaces = new string(' ', spacesToAdd);
                displayText += spaces;
            }
            HieuUngTimer.Start();
            pMain.Controls.Clear();
            POSUserControl pOSUserControl = new POSUserControl();
            pOSUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(pOSUserControl);
            LoadFunction();
            lbHander.Text = $"Chi Nhánh {GlobalModel.UserInfo.StoreCode}";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //  MenuTimer.Start();
            if (MenuCollapse)
            {
                pbLogoMeXiu.Width = pbLogoMeXiu.MinimumSize.Width;
                flpMain.Width = flpMain.MinimumSize.Width;
                MenuCollapse = false;
            }
            else
            {
                pbLogoMeXiu.Width = pbLogoMeXiu.MaximumSize.Width;
                flpMain.Width = flpMain.MaximumSize.Width;
                MenuCollapse = true;
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHangCollapse)
            {
                KhachHangContainer.Height = KhachHangContainer.MaximumSize.Height;
                khachHangCollapse = false;
            }
            else
            {
                KhachHangContainer.Height = KhachHangContainer.MinimumSize.Height;
                khachHangCollapse = true;
            }
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            if (hangHoaCollapse)
            {
                HangHoaContainer.Height = HangHoaContainer.MaximumSize.Height;
                hangHoaCollapse = false;
            }
            else
            {
                HangHoaContainer.Height = HangHoaContainer.MinimumSize.Height;
                hangHoaCollapse = true;
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            if (khoCollapse)
            {
                KhoContainer.Height = KhoContainer.MaximumSize.Height;
                khoCollapse = false;
            }
            else
            {
                KhoContainer.Height = KhoContainer.MinimumSize.Height;
                khoCollapse = true;
            }

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (BaoCaoCollapse)
            {
                BaoCaoContainer.Height = BaoCaoContainer.MaximumSize.Height;
                BaoCaoCollapse = false;
            }
            else
            {
                BaoCaoContainer.Height = BaoCaoContainer.MinimumSize.Height;
                BaoCaoCollapse = true;
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDonCollapse)
            {
                HoaDonContainer.Height = HoaDonContainer.MaximumSize.Height;
                HoaDonCollapse = false;
            }
            else
            {
                HoaDonContainer.Height = HoaDonContainer.MinimumSize.Height;
                HoaDonCollapse = true;
            }
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            if (CongNoCollapse)
            {
                CongNoContainer.Height = CongNoContainer.MaximumSize.Height;
                CongNoCollapse = false;
            }
            else
            {
                CongNoContainer.Height = CongNoContainer.MinimumSize.Height;
                CongNoCollapse = true;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (NhanVienCollapse)
            {
                NhanVienContainer.Height = NhanVienContainer.MaximumSize.Height;
                NhanVienCollapse = false;
            }
            else
            {
                NhanVienContainer.Height = NhanVienContainer.MinimumSize.Height;
                NhanVienCollapse = true;
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
        private void pbProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _fLogin.Show();
          
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            ChiNhanhUserControl chiNhanhControl = new ChiNhanhUserControl();
            chiNhanhControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(chiNhanhControl);
            loading.StopLoading();
        }

        private void flpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            DanhSachKhoUserControl danhSachKhoUserControl = new DanhSachKhoUserControl();
            danhSachKhoUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(danhSachKhoUserControl);
            loading.StopLoading();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            NhaCungCapUserControl nhaCungCapUserControl = new NhaCungCapUserControl();
            nhaCungCapUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(nhaCungCapUserControl);
            loading.StopLoading();
        }

        private void pbLogoMeXiu_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            POSUserControl pOSUserControl = new POSUserControl();
            pOSUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(pOSUserControl);
            loading.StopLoading();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            POSUserControl pOSUserControl = new POSUserControl();
            pOSUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(pOSUserControl);
            loading.StopLoading();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            FunctionsUserControl functionsUser = new FunctionsUserControl();
            functionsUser.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(functionsUser);
            loading.StopLoading();
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            QuanLyNhanVienUserControl quanLyNhanVienUserControl = new QuanLyNhanVienUserControl();
            quanLyNhanVienUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(quanLyNhanVienUserControl);
            loading.StopLoading();
        }

        private void HangHoaContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            LoaiSanPhamUserControl loaiSanPhamUserControl = new LoaiSanPhamUserControl();
            loaiSanPhamUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(loaiSanPhamUserControl);
            loading.StopLoading();
        }

        private void btnDonViHangHoa_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            DonViHangHoaUserControl donViTinhHangHoaUserControl = new DonViHangHoaUserControl();
            donViTinhHangHoaUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(donViTinhHangHoaUserControl);
            loading.StopLoading();
        }

        private void btnDanhSachHangHoa_Click(object sender, EventArgs e)
        {
            loading.StartLoading();
            pMain.Controls.Clear();
            QuanLySanPhamUserControl quanLySanPhamUserControl = new QuanLySanPhamUserControl();
            quanLySanPhamUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(quanLySanPhamUserControl);
            loading.StopLoading();
        }
        private void LoadFunction()
        {
            foreach (var item in GlobalModel.UserInfo.Permissions)
            {
                switch (item.FunctionName)
                {
                    case "ChiNhanhControl":
                        {
                            btnChiNhanh.Enabled = item.HasView;
                            break;
                        }
                    case "DanhSachKhoUserControl":
                        {
                            btnQuanLyKho.Enabled = item.HasView;
                            break;
                        }
                    case "NhaCungCapUserControl":
                        {
                            btnNhaCungCap.Enabled = item.HasView;
                            break;
                        }
                    case "POSUserControl":
                        {
                            btnPos.Enabled = item.HasView;
                            break;
                        }
                    case "FunctionsUserControl":
                        {
                            btnCaiDat.Enabled = item.HasView;
                            break;
                        }
                    case "QuanLyNhanVienUserControl":
                        {
                            btnDanhSachNhanVien.Enabled = item.HasView;
                            break;
                        }
                    case "LoaiSanPhamUserControl":
                        {
                            btnLoaiSanPham.Enabled = item.HasView;
                            break;
                        }
                    case "DonViHangHoaUserControl":
                        {
                            btnDonViHangHoa.Enabled = item.HasView;
                            break;
                        }
                    case "QuanLySanPhamUserControl":
                        {
                            btnDanhSachHangHoa.Enabled = item.HasView;
                            break;
                        }

                }
            }
        }
    }
}
