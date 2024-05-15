using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Core.Database.Models
{
    public class EditClassModel
    {
        
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // EF
        public string CourseCode { get; set; }
        public string RoomCode { get; set; }
    }
}
