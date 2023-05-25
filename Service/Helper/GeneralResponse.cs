using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helper
{
    public sealed class GeneralResponse<T>  {
        public GeneralResponse(bool success, bool error, string? message, string? resultMessage, T? result) 
        {
            Success = success;
            Error = error;
            Message = message;
            ResultMessage = resultMessage;
            Result = result;
        }

        public bool Success { get; set; }
        public bool Error { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }
        public string? ResultMessage { get; set; }

        public static GeneralResponse<T> CreateSuccess(T result)
        {
            return new GeneralResponse<T>(true, false, null, null, result);
        }
        public static GeneralResponse<T> CreateFailure(string message)
        {
            return new GeneralResponse<T>(false, false, null, message, default(T));
        }
        public static GeneralResponse<T> CreateError(string message)
        {
            return new GeneralResponse<T>(false, true, message, null, default(T));
        }
    }
}
