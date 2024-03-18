namespace ASP_Core.Database.Models
{
    public class Course
    {
        public string Code { get; set; }
        public string SubjectCode { get; set; }
        public string Type { get; set; }
        public string Prof { get; set; }
        public string RoomCode { get; set; }
        public int TakenSize { get; set; }
        public int MaxSize { get; set; }
        public List<DateTime> Dates { get; set; }

    }
}
