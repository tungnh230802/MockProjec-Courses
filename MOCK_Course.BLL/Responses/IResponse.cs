namespace BlogBLL.Response
{
    public interface IResponse<T> where T : class
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
        public int? Error { get; set; }
        public T Data { get; set; }
    }
}