namespace ASP_Core.Database.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int MaxSize { get; set; }
        public List<Grade> Grades { get; set; }
        public string Prof { get; set; }
        public List<User> Students { get; set; }
        public Course Course { get; set; }
        public Semester Semester { get; set; }

    }
}
