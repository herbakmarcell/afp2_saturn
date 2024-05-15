namespace ASP_Core.Database.Models
{
    public class ListCourseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<ListCourseModel> Courses { get; set; }
    }
}
