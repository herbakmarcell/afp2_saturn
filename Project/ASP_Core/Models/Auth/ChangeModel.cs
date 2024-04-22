using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace ASP_Core.Models.Auth
{
    public class ChangeModel
    {
        [StringLength(6, MinimumLength = 6, ErrorMessage = "A Saturn kód 6 karakter hosszú.")]
        public string? SaturnCode { get; set; }

        [StringLength(16, MinimumLength = 3, ErrorMessage = "Az új jelszó legfeljebb 16 karakter hosszú lehet.")]
        public string? NewPassword { get; set; }

        [RegularExpression(@"^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű'-]+$", ErrorMessage = "Az új utónév nem megfelelő formátumú.")]
        public string? NewLastName { get; set; }

        [RegularExpression(@"^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű'-]+$", ErrorMessage = "Az új vezetéknév nem megfelelő formátumú.")]
        public string? NewFirstName { get; set; }

        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Az új email nem megfelelő formátumú.")]
        public string? NewEmail { get; set; }

        [RegularExpression(@"^\+\d{11}$", ErrorMessage = "Az új telefonszám nem megfelelő formátumú.")]
        public string? NewPhoneNumber { get; set; }

        public List<string>? NewRoles { get; set; }
    }
}
