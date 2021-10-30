using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TMS.Api.Helpers
{
    public class ErrorHandler
    {
        private readonly RequestDelegate _next;
    }
}
    //    public ErrorHandler(RequestDelegate next)
    //    {
    //        _next = next;
    //    }
    //    public async Task Invoke(HttpContext context)
    //    {
    //        try
    //        {
    //            await _next(context);
    //        }
    //        catch (Exception error)
    //        {
    //            var response = context.Response;
    //            response.ContentType = "application/Json";
    //            var responseModel = new Response<string>() { Succeeded = false, Message = error?.Message };
    //            switch(error)
    //            {
    //                case KeyNotFoundException:
    //                    //not found error
    //                    response.StatusCode = (int)HttpStatusCode.NotFound;
                
    //            default:
    //                //unhandled error
    //                response.StatusCode = (int)HttpStatusCode.InternalServerError;
    //            break;
               
    //        }
    //        var result = JsonConvert.SerializeObject(responseModel);
    //        await response.WriteAsync(result);

    //    }
    //}

