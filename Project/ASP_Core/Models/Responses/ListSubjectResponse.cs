namespace ASP_Core.Database.Models
{
    public class ListSubjectResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<SubjectModel>? Subjects { get; set; }
    }
}
