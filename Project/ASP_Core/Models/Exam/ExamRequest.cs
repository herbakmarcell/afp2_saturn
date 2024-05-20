using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses
{
    public class ExamRequest
    {
        public int Id { get; set; }
        public int MaxSize { get; set; }
        public string Prof { get; set; }
        public string Course { get; set; }
        public int Semester { get; set; }
    }
}
