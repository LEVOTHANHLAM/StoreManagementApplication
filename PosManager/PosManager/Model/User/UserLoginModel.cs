namespace PosManager.Model.User
{
    public class UserLoginModel
    {
        public string? Token { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}
