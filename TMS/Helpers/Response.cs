using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Api.Helpers
{
    public class Response<T>
    {
        public Response()
        {

        }
        public Response(T data, string message= null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; }
        public string Message { get; }
        public List<ErrorModel> Errors { get; set; }
        public T Data { get; }
    }

   
}
