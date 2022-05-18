using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.BLL.Responses
{
    public class Response <T>
    {
        public bool IsSuccess { get; set; }
        public int? Error { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public Response()
        {

        }
        public Response(bool isSuccess, int error, string message)
        {
            IsSuccess = isSuccess;
            Error = error;
            Message = message;
        }
    }
}
