namespace ASP_Core.Database.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User User { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is string)
            {
                return this.Name == obj.ToString();
            }
            if (obj is Role)
            {
                return this.Id == (obj as Role).Id;
            }
            return false;

            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
