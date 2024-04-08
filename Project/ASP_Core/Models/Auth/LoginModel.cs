using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Saturn Kód szükséges")]
        public string? SaturnCode { get; set; }

        [Required(ErrorMessage = "Jelszó szükséges")]
        public string? Password { get; set; }
    }
}
