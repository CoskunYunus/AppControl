using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthControl.Models.ResponseModel
{
   public class TracingResponseModel
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
