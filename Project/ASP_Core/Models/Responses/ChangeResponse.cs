namespace ASP_Core.Models.Responses
{
    public class ChangeResponse
    {
        public string SaturnCode { get; set; }
        public string NewPassword { get; set; }
        public string NewLastName { get; set; }
        public string NewFirstName { get; set; }
        public string NewEmail { get; set; }
        public string NewPhone { get; set; }
        public List<string> NewRoles { get; set; }
    }
}
