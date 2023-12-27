namespace PosManager.Model.ChiNhanh
{
    public class StoreModel
    {
        public Guid? Id { get; set; }
        public string? MaCuaHang { get; set; }
        public string? TenCuaHang { get; set; }
        public string? MaKho { get; set; }
        public string? TenKho { get; set; }
        public string? CreateById { get; set; }
        public string? LastModifiedById { get; set;}
    }
}
