using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model.Kho
{
    public class TonKhoViewModel
    {
        public Guid Id { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public List<TonKho_Kho> TonKho { get; set; }

    }
    public class TonKho_Kho
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public List<TonKho_SoLuong> SoLuong { get; set; }

    }
    public class TonKho_SoLuong
    {
        public float SoLuongTon { get; set; }
        public string MaDonViHangHoa { get; set; }
        public string TenDonViHangHoa { get; set; }
        public DateTime HanSuDung { get; set; }
        public DateTime? NgayNhap { get; set; }

    }
}
