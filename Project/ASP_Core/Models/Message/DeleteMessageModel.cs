using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Message
{
    public class DeleteMessageModel
    {
        public string? SaturnCode { get; set; }
        [Required(ErrorMessage = "Az üzenet tárgyának megadása szükséges.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Szükséges tudni, hogy kimenő vagy bejövő az üzenet.")]
        public bool IsSent { get; set; }
    }
}
