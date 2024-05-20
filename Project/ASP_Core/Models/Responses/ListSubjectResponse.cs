using ASP_Core.Models.Subject;

namespace ASP_Core.Database.Models
{
    public class ListSubjectResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<SubjectModel>? Subjects { get; set; }
    }
}
