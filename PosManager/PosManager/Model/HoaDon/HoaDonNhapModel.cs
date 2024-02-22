using System.ComponentModel.DataAnnotations.Schema;

namespace PosManager.Model.HoaDon
{
    public class HoaDonNhapModel
    {
        public Guid Id { get; set; }
        public string MaHoaDonNhap { get; set; }
        public string MaPhieuNhapKho { get; set; }
        public string? GhiChu { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTien { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TienGiam { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TienDaThanhToan { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal TienChuaThanhToan { get; set; }
        public DateTime? NgayDenHan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string TrangThai { get; set; }
        public string? CreateById { get; set; }
        public string? CreateByName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedById { get; set; }
        public string? LastModifiedByName { get; set; }
    }
}
