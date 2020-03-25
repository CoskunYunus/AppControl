using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthControl.Models.RequestModel
{
   public class TracingRequestModel
    {
        public int ApplicationId { get; set; }
        public string CreateDate { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
