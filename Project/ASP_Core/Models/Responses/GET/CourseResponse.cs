using ASP_Core.Models.Course;

namespace ASP_Core.Models.Responses.GET
{
    public class CourseResponse
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
