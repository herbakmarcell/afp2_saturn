namespace Saturn_Client
{
    public class Response<T>
    {
        public bool success { get; set; }

        public string message { get; set; }

        public T resource { get; set; }

        public Response(T resource)
        {
            success = true;
            message = string.Empty;
            this.resource = resource;
        }

        public Response(string message)
        {
            success = false;
            this.message = message;
            resource = default;
        }
        public Response()
        {
        }
    }
}
