namespace ASP_Core.Database.Models
{
    public class User
    {
        public string SaturnCode { get; set; }
        public string Password { get; set; }
        public ICollection<Role> AccessLevel { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
