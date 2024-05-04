using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Message
{
    public class DeleteMessageModelRequest
    {
        public string? SaturnCode { get; set; }
        [Required(ErrorMessage = "Az üzenet azonosítójának megadása kötelező.")]
        public int MessageId { get; set; }
    }
}
