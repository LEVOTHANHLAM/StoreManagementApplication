using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model.ThanhToan
{
    public class ThanhToanHoaDonModel
    {
        public string LoaiHoaDon { get; set; }
        public string MaThamChieu { get; set; }
        public string NoiDungThanhToan { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SoTienGiaoDich { get; set; }
        public string CachThucGiaoDich { get; set; }
        public string MaNhanVien { get; set; }
    }
}
