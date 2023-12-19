namespace PosManager.Model.SanPham
{
    public class ProductsModel
    {
        public Guid? Id { get; set; }
        public string? MaHangHoa { get; set; }
        public string? TenHangHoa { get; set; }
        public string? TenHangHoaKhongDau { get; set; }
        public string? MaNhomHang { get; set; }
        public string? TenNhomHang { get; set; }
        public double? VAT { get; set; }
        public string? GhiChu { get; set; }
        public string? MaVach { get; set; }
        public string? MaQR { get; set; }
    }
}
