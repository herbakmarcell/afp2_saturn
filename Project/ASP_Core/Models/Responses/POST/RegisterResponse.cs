using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses.POST
{
    public class RegisterResponse
    {
        public string SaturnCode { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
