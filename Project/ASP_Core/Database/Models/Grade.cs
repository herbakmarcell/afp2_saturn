namespace ASP_Core.Database.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }

    }
}
