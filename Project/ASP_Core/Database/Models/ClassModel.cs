using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Core.Database.Models
{
    public class ClassModel
    {
        
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // EF
        public Course Course { get; set; }
        public Room Room { get; set; }
    }
}
