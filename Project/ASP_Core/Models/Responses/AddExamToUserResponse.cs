namespace ASP_Core.Models.Responses
{
    public class AddExamToUserResponse
    {
        public string StudentSaturnCode { get; set; }
        public int ExamsId { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
