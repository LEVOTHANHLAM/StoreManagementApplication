namespace PosManager.Model.Kho
{
    public class WarehouseModel
    {
        public string? MaKho { get; set; }
        public string? MaNhaCungCap { get; set; }
        public List<WarehouseDetailModel>? Details { get; set; }
        public string? GhiChu { get; set; }
        public string? CreateById { get; set; }
        public string? LastModifiedById { get; set; }
        public Guid? Id { get; set; }
        public string? MaPhieuNhapKho { get; set; }
        public string? TenKho { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string? TenNhaCungCap { get; set; }
        public List<WarehouseDetailModel>? ChiTiet { get; set; }
    }
}
