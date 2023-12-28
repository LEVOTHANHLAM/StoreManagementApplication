namespace PosManager.Model.User
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? MaCuaHang { get; set; }
        public string? TenCuaHang { get; set; }
        public bool IsDelete { get; set; }
        public string? Role { get; set; }
        public string? Password { get; set; }
        public string? CCCD { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? CreateByName { get; set; }
        public string? CreateDate { get; set; }
        public string? LastModifiedByName { get; set; }
        public string? LastModifiedDate { get; set; }
    }
}
