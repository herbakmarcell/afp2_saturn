namespace ASP_Core.Database.Models
{
    public class CreateExamRequestModel
    {
        public int MaxSize { get; set; }
        public string Prof { get; set; }
        public string CourseCode { get; set; }
        public int SemesterId { get; set; }

    }
}
