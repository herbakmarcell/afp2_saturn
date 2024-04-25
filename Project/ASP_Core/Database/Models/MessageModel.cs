namespace ASP_Core.Database.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public User Sender { get; set; }
        public List<User> Receivers { get; set; }

    }
}
