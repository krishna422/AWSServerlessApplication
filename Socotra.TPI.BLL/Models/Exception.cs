using System;
using System.Collections.Generic;
using System.Text;

namespace Socotra.TPI.BLL.Models
{
    public class CustomException
    {
        public CustomException()
        {
            ExceptionId = Guid.NewGuid().ToString();
        }
        private string ExceptionId { get; set; }
        public int StatusCode { get; set; }
        public int SubStatusCode { get; set; }
        public string StatusType { get; set; }
        public string CustomMessage { get; set; }
        public string InnerException { get; set; }
        public string ExceptionType { get; set; }
        public string Message { get; set; }       
        public string BaseException { get; set; }
        public string Source { get; set; }
        public string Request { get; set; }
    }
}
