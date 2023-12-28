using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model.Kho
{
    public class WarehouseDetailModel
    {
        public string? MaHangHoa { get; set; }
        public string? MaDonViNhap { get; set; }
        public float? SoLuongNhap { get; set; }
        public decimal? DonGiaNhap { get; set; }
        public DateTime? HanSuDung { get; set; }
    }
}
