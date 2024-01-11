using System.ComponentModel.DataAnnotations.Schema;

namespace PosManager.Model.Kho
{
    public class WarehouseDetailModel
    {
        public string? MaHangHoa { get; set; }
        public string? MaDonViNhap { get; set; }
        public float? SoLuongNhap { get; set; }
        public decimal? DonGiaNhap { get; set; }
        public DateTime? HanSuDung { get; set; }
        public Guid? Id { get; set; }
        public string? MaPhieuNhapKho { get; set; }
        public string? TenHangHoa { get; set; }
        public string? TenDonViNhap { get; set; }
        public float? SoLuongTheoDonViChuan { get; set; }
        public decimal? DonGiaTheoDonViChuan { get; set; }
    }
}
