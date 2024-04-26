namespace ASP_Core.Models.Responses
{
    public class DeleteMessageResponse
    {
        public string? SaturnCode { get; set; }
        public string? Subject { get; set; }
        public bool IsDeleted { get; set; }
    }
}
