using Newtonsoft.Json;
using Socotra.TPI.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Socotra.TPI.BLL.Services
{
    public static class ExceptionService
    {
        public static void LogException(Exception ex, dynamic request, string customMessage = "")
        {
            CustomException customException = new CustomException();
            customException.StatusCode = 500;
            customException.SubStatusCode = 500;
            customException.CustomMessage = customMessage;
            customException.Message = ex.Message;
            customException.InnerException = JsonConvert.SerializeObject(ex.InnerException);
            customException.ExceptionType = ex.GetType().Name;
            customException.Source = ""; 
            customException.BaseException = JsonConvert.SerializeObject(ex.GetBaseException().InnerException);
            customException.Request = JsonConvert.SerializeObject(request);
        }
    }
}
