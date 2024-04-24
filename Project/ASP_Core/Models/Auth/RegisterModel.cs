using ASP_Core.Database.Models;
using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Jelszó szükséges")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "A jelszónak legalább 3 és legfeljebb 16 karakter hosszúnak kell lennie.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Vezetéknév szükséges")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű'-]+$", ErrorMessage = "A vezetéknév nem megfelelő formátumú.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Utónév szükséges")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű'-]+$", ErrorMessage = "Az utónév nem megfelelő formátumú.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Email szükséges")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Az email nem megfelelő formátumú.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Telefonszám szükséges")]
        [RegularExpression(@"^\+\d{11}$", ErrorMessage = "A telefonszám nem megfelelő formátumú.")]
        public string? PhoneNumber { get; set; }
        

        public List<string> Roles { get; set; }
    }
}
