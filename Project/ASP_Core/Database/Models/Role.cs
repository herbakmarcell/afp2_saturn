namespace ASP_Core.Database.Models
{
    public class Role
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
    }
}
