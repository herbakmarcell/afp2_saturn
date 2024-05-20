using System.ComponentModel.DataAnnotations;

namespace ASP_Core.Models.Exam
{
    public class AddExamUserModel
    {
        public string? SaturnCode { get; set; }
        [Required]
        public int ExamId { get; set; }
    }
}
