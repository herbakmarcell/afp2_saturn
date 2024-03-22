namespace ASP_Core.Database.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public string Year { get; set; } 
        public bool EvenSemester { get; set; }

        public List<Course> SemesterCourses { get; set; }
        public List<Exam> SemesterExams { get; set; }
    }
}
