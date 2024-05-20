using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Core.Models.Class
{
    public class AddClassRequest
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string Room { get; set; }
    }
}
