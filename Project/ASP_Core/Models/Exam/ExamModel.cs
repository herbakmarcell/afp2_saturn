using ASP_Core.Database.Models;

namespace ASP_Core.Models.Exam
{
    public class ExamModel
    {
        public int Id { get; set; }
        public int MaxSize { get; set; }
        public string Prof { get; set; }
        public Database.Models.Course Course { get; set; }
        public Semester Semester { get; set; }

    }
}
