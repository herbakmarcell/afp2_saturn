using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses
{
    public class ListClassResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<ClassModel> Classes { get; set; }
    }
}
