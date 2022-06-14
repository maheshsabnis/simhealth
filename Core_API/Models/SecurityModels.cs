namespace Core_API.Models
{
    public class RegisterUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ResponseData
    {
        public string Message { get; set; }
    }
}
