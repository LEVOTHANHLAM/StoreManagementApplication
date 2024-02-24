using ComponentFactory.Krypton.Toolkit;
using DevExpress.XtraSplashScreen;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.VisualBasic.ApplicationServices;
using PosManager.APIServices.CaiDat;
using PosManager.APIServices.ChiNhanh;
using PosManager.APIServices.User;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.ChiNhanh;
using PosManager.Model.Kho;
using PosManager.Model.User;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace PosManager
{
    public partial class fChiTietTonKho : KryptonForm
    {
        private TonKhoViewModel _TonKhoViewModel { get; set; }
        public fChiTietTonKho(TonKhoViewModel model)
        {
            _TonKhoViewModel = model;
            InitializeComponent();
            lbTenSanPham.Text = _TonKhoViewModel.TenHangHoa;
            lbMaSanPham.Text = _TonKhoViewModel.MaHangHoa;
            cbbKho.Items.Clear();
            foreach (var item in _TonKhoViewModel.TonKho)
            {
                cbbKho.Items.Add(item.TenKho);
            }
            cbbKho.SelectedIndex = 0;
            cbbKho_SelectedIndexChanged(null, null);
        }
        private void LoadDataGridView()
        {
            float tong = 0;
            var kho = _TonKhoViewModel.TonKho.FirstOrDefault(x => x.TenKho == cbbKho.SelectedItem.ToString());
            dtgvAccount.Rows.Clear();
            int i = 1;
            foreach (var item in kho.SoLuong)
            {
                dtgvAccount.Rows.Add(i, item.TenDonViHangHoa, item.SoLuongTon.ToString(), item.HanSuDung, item.NgayNhap, "IN");
                tong = tong + item.SoLuongTon;
                i++;
            }
            lbTongTonKho.Text = tong.ToString();

        }
        private async void Form1_Load(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvAccount.Columns["cInQRCode"].Index)
            {
                try
                {
                    var date = DateTime.Parse(dtgvAccount.Rows[e.RowIndex].Cells[4].Value.ToString());
                    var dateTime = date.ToString("yyyyMMddHHmmss");
                    var content = $"{_TonKhoViewModel.MaHangHoa}NGAYNHAP{dateTime}";
                    var Logo = QRCodeHelper.GenerateQRCodeWithLogo(content, Properties.Resources._326559583_468268058851274_8797007794984294310_n, 10);
                    if (!Directory.Exists(Path.Combine($"QRCode")))
                    {
                        Directory.CreateDirectory(Path.Combine($"QRCode"));
                    }
                    Logo.Save(Path.Combine($"QRCode\\{content}.png"));
                    Process.Start(new ProcessStartInfo(Path.GetFullPath(Path.Combine("QRCode", $"{content}.png"))) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageCommon.ShowMessageBox(ex.Message, 3);
                }


            }
        }
    }
}
