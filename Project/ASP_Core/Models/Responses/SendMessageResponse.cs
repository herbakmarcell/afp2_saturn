using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Responses
{
    public class SendMessageResponse
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public List<string> Receivers { get; set; }
    }
}
