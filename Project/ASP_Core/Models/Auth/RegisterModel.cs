using ASP_Core.Database.Models;

namespace ASP_Core.Models.Auth
{
    public class RegisterModel
    {
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
