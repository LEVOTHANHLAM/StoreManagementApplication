namespace PosManager.Model.SanPham
{
    public class DonViHangHoaModel
    {
        public Guid? Id { get; set; }
        public string? MaDonViHangHoa { get; set; }
        public string? TenDonViHangHoa { get; set; }
        public string? MaHangHoa { get; set; }
        public float? TyLeChuyenDoi { get; set; }
        public string? CreateById { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedById { get; set; }
    }
}
