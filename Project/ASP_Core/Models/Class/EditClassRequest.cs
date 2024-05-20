using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Core.Models.Class
{
    public class EditClassRequest
    {
        [Required]
        public int Id { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string? Course { get; set; }

        public string? Room { get; set; }
    }
}
