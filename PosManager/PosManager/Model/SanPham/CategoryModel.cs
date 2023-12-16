namespace PosManager.Model.SanPham
{
    public class CategoryModel
    {
        public Guid? Id { get; set; }
        public string? MaNhomHang { get; set; }
        public string? TenNhomHang { get; set; }
        public Guid? ParentId { get; set; }
        public string? ParentCode { get; set; }
        public string? ParentName { get; set; }
        public string? CreateById { get; set; }

    }
}
