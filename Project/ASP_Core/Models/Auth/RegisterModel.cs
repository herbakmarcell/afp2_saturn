using ASP_Core.Database.Models;
using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Admin Saturn szükséges")]
        public string? AdminSaturnCode { get; set; }
        [Required(ErrorMessage = "Jelszó szükséges")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Keresztnév szükséges")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Vezetéknév szükséges")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Email szükséges")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Telefonszám szükséges")]
        public string? PhoneNumber { get; set; }
        
        public List<string> Roles { get; set; }
    }
}
