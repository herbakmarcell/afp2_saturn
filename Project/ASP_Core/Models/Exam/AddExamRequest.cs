namespace ASP_Core.Models.Exam
{
    public class AddExamRequest
    {
        public int MaxSize { get; set; }
        public string Prof { get; set; }
        public string Course { get; set; }
        public int Semester { get; set; }

    }
}
