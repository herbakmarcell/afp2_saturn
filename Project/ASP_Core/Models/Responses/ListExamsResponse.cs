using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses
{
    public class ListExamsResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<ExamModel> Exams { get; set; }
    }
}
