using ASP_Core.Database.Models;

namespace ASP_Core.Models.Responses
{
    public class ReceivedMessageResponse
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public string Sender { get; set; }
        public List<string> Receivers { get; set; }
    }
}
