using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ASP_Core.Database.Models
{
    public class CreateClassRequestModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Coursecode { get; set; }
        public string Roomcode { get; set; }
    }
}
