namespace BlogBLL.Response
{
    public class Response<T> : IResponse<T> where T : class
    {
        public bool IsSucceeded { get; set; }//true or false
        public string Message { get; set; }
        public int? Error { get; set; }
        public T Data { get; set; }
        public Response(bool isSucceeded, T data, string message, int? error)
        {
            IsSucceeded = isSucceeded;
            Data = data;
            Message = message;
            Error = error;
        }

        public Response(bool isSucceeded, T data)
        {
            IsSucceeded = isSucceeded;
            Data = data;
        }
    }
}
