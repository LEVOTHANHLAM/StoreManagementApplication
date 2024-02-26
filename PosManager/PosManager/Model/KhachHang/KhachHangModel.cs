namespace PosManager.Model.KhachHang
{
    public class KhachHangModel
    {
        public Guid? Id { get; set; }
        public string? TenKhachHang { get; set; }
        public string? MaKhachHang { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public string? MaNhanVien { get; set; }
        public string? Email { get; set; }
        public string? GhiChu { get; set; }
        public int? CapBac { get; set; }
        public string? CreateById { get; set; }
    }
}
