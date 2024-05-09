namespace ASP_Core.Database.Models
{
    public class ExamModel
    {
        public int Id { get; set; }
        public int MaxSize { get; set; }
        public string Prof { get; set; }
        public Course Course { get; set; }
        public Semester Semester { get; set; }

    }
}
