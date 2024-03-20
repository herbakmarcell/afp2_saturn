namespace ASP_Core.Database.Models
{
    public class Course
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Prof { get; set; }
        public int MaxSize { get; set; }

        //
        public List<ClassModel> Classes { get; set; }
        public Subject Subject { get; set; }
        public Semester CurrentSemester { get; set; }
    }
}
