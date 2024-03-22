namespace ASP_Core.Database.Models
{
    public class Room
    {
        public string Code { get; set; }
        public int MaxSize { get; set; }

        public List<ClassModel> Classes { get; set; }

    }
}
