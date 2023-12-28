namespace PosManager.Model.Kho
{
    public class WarehouseModel
    {
        public string? MaKho { get; set; }
        public string? MaNhaCungCap { get; set; }
        public List<WarehouseDetailModel>? Details { get; set; }
        public string? CreateById { get; set; }
    }
}
