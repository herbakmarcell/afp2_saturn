using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Message
{
    public class SendMessageModel
    {
        public string? Sender { get; set; }
        [Required(ErrorMessage = "Tárgy megadása szükséges")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Üzenet megadása")]
        [StringLength(5000, MinimumLength = 1, ErrorMessage = "Az üzenetnek tartalmaznia kell legalább 1 karaktert.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Címzett(ek) megadása szükséges")]
        public List<string> Receivers { get; set; }
    }
}
