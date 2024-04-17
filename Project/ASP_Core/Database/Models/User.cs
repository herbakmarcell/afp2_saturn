namespace ASP_Core.Database.Models
{
    public class User
    {
        public string SaturnCode { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Role> Roles { get; set; }
        public List<Course> Courses { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Grade> Grades { get; set; }

        public string ReturnRoles { get => string.Join(',', Roles); }
    }
}
