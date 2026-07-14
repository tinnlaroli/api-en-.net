using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Response
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }

        public ApiResponse(int statusCode, string message, object? data = null)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }

        public static ApiResponse Success(object? data = null, string message = "Succes")
        {
            return new ApiResponse(200, message, data);
        }
    }
}
