namespace ASP_Core.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Resource { get; set; }

        public Response(T resource)
        {
            Success = true;
            Message = string.Empty;
            Resource = resource;
        }

        public Response(string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }
    }
}
