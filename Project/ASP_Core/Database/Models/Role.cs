namespace ASP_Core.Database.Models
{
    public class Role
    {
        public int Id { get; set; }
        public User OneUser { get; set; }
        public string RoleName { get; set; }
    }
}
