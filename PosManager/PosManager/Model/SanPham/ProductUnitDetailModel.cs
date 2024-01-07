namespace PosManager.Model.SanPham
{
    public class ProductUnitDetailModel
    {
        public Guid? Id { get; set; }
        public string? MaHangHoa { get; set; }
        public string? TenHangHoa { get; set; }
        public string? MaDonViHangHoa { get; set; }
        public string? TenDonViHangHoa { get; set; }
        public float? TyLeChuyenDoi { get; set; }
        public string? CreateById { get; set; }
    }
}
