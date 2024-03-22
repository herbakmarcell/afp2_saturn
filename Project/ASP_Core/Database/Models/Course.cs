namespace ASP_Core.Database.Models
{
    public class Course
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Prof { get; set; }
        public int Credit { get; set; }
        public int MaxSize { get; set; }

        //
        public List<ClassModel> Classes { get; set; }
        public Subject Subject { get; set; }
        public List<User> Students { get; set; }
        public List<Grade> Grades { get; set; }
        public Semester CurrentSemester { get; set; }
    }
}
