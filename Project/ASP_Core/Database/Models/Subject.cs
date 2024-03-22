namespace ASP_Core.Database.Models
{
    public class Subject
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        public List<Course> GetCoursesInSemester(int id)
        {
            List<Course> temp = new List<Course>();
            foreach (var course in Courses)
            {
                if (course.CurrentSemester.Id == id)
                {
                    temp.Add(course);
                }
            }
            return temp;
        }

    }
}
