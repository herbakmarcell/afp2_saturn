using ASP_Core.Database.Models;

namespace ASP_Core.Models.Course
{
    public class CourseModel
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Prof { get; set; }
        public int Credit { get; set; }
        public int MaxSize { get; set; }
        public Database.Models.Subject Subject { get; set; }
        public Semester CurrentSemester { get; set; }
    }
}
