using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Models.Entity
{
   public class ApplicationTracing
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
