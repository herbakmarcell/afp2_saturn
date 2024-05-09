using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses
{
    public class ExamUserCountResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int usercount { get; set; }
    }
}
