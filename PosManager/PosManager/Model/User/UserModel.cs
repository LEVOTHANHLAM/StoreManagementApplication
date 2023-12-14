namespace PosManager.Model.User
{
    public class UserModel
    {
        public string? Email { get; set; }

        public string? Username { get; set; }
        public string? Fullname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CCCD { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Id { get; set; }
        public string? CreateByName { get; set; }
        public string? CreateDate { get; set; }
        public string? LastModifiedByName { get; set; }
        public string? LastModifiedDate { get; set; }
    }
}
