using PosManager.Model.ChiNhanh;
using PosManager.Model.User;

namespace PosManager.Model
{
    public class GlobalModel
    {
        public static string AccsessToken { get; set; }
        public static TokenInfo UserInfo { get; set; }
        public class TokenInfo
        {
            public List<PermissionModel>? Permissions { get; set; }
            public string? StoreCode { get; set; }
            public string? Id {  get; set; }
            public string? Name { get; set; }
        }
    }
}
