using DevExpress.Drawing.Internal.Fonts.Interop;
using Krypton_toolKitDemo;
using PosManager.Forms.UserControls;
using PosManager.Forms.UserControls.KhachHang;
using PosManager.Forms.UserControls.Kho;
using PosManager.Forms.UserControls.NhanVien;
using PosManager.Forms.UserControls.Post;
using PosManager.Forms.UserControls.SanPham;
using PosManager.Model;

namespace PosManager.Forms
{
    public partial class fHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public fHome()
        {
            InitializeComponent();
            this.Text = GlobalModel.UserInfo.StoreCode;
            this.Size = new Size(1318, 729);
            this.MinimumSize = new Size(1318, 729);
        }
        private void btnDanhSachHangHoa_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            QuanLySanPhamUserControl quanLySanPhamUserControl = new QuanLySanPhamUserControl(this);
            quanLySanPhamUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(quanLySanPhamUserControl);
        }
        private void btnDonViHangHoa_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            DonViHangHoaUserControl donViTinhHangHoaUserControl = new DonViHangHoaUserControl(this);
            donViTinhHangHoaUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(donViTinhHangHoaUserControl);

        }
        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            LoaiSanPhamUserControl loaiSanPhamUserControl = new LoaiSanPhamUserControl(this);
            loaiSanPhamUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(loaiSanPhamUserControl);

        }
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            //   FunctionsUserControl functionsUser = new FunctionsUserControl(this);
            fNhapKhoHangHoa functionsUser = new fNhapKhoHangHoa(this);
            functionsUser.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(functionsUser);
        }
        private void btnPos_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            POSUserControl pOSUserControl = new POSUserControl();
            pOSUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(pOSUserControl);

        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            pMain.Controls.Clear();
            NhaCungCapUserControl nhaCungCapUserControl = new NhaCungCapUserControl(this);
            nhaCungCapUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(nhaCungCapUserControl);

        }
        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            DanhSachKhoUserControl danhSachKhoUserControl = new DanhSachKhoUserControl(this);
            danhSachKhoUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(danhSachKhoUserControl);

        }
        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            ChiNhanhUserControl chiNhanhControl = new ChiNhanhUserControl(this);
            chiNhanhControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(chiNhanhControl);

        }
        private void LoadFunction()
        {
            foreach (var item in GlobalModel.UserInfo.Permissions)
            {
                switch (item.FunctionName)
                {
                    case "ChiNhanhControl":
                        {
                            //  btnChiNhanh.Enabled = item.HasView;
                            break;
                        }
                    case "DanhSachKhoUserControl":
                        {
                            //  btnQuanLyKho.Enabled = item.HasView;
                            break;
                        }
                    case "NhaCungCapUserControl":
                        {
                            //  btnNhaCungCap.Enabled = item.HasView;
                            break;
                        }
                    case "POSUserControl":
                        {
                            // btnPos.Enabled = item.HasView;
                            break;
                        }
                    case "FunctionsUserControl":
                        {
                            // btnCaiDat.Enabled = item.HasView;
                            break;
                        }
                    case "QuanLyNhanVienUserControl":
                        {
                            // btnDanhSachNhanVien.Enabled = item.HasView;
                            break;
                        }
                    case "LoaiSanPhamUserControl":
                        {
                            // btnLoaiSanPham.Enabled = item.HasView;
                            break;
                        }
                    case "DonViHangHoaUserControl":
                        {
                            // btnDonViHangHoa.Enabled = item.HasView;
                            break;
                        }
                    case "QuanLySanPhamUserControl":
                        {
                            //  btnDanhSachHangHoa.Enabled = item.HasView;
                            break;
                        }

                }
            }
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            QuanLyNhanVienUserControl quanLyNhanVienUserControl = new QuanLyNhanVienUserControl(this);
            quanLyNhanVienUserControl.Dock = DockStyle.Fill; // Đặt DockStyle.Fill cho UserControl
            pMain.Controls.Add(quanLyNhanVienUserControl);
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}