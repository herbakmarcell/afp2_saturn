namespace ASP_Core.Models.Responses
{
    public class ClassResponse
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Course { get; set; }
        public string Room { get; set; }
    }
}
