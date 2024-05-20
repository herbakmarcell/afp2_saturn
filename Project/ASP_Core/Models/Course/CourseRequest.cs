using ASP_Core.Database.Models;

namespace ASP_Core.Models.Course
{
    public class CourseRequest
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Prof { get; set; }
        public int Credit { get; set; }
        public int MaxSize { get; set; }
        public string SubjectCode { get; set; }
        public int CurrentSemesterId { get; set; }
    }
}
