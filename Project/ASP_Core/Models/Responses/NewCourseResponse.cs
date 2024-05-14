namespace ASP_Core.Database.Models
{
    public class NewCourseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public CourseModel? generatedcourse { get; set; }
    }
}
