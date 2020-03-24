using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Models.Entity
{
   public class ApplicationTracing
    {
        public int Id { get; set; }
        public int ApplicationTracingId { get; set; }
        public DateTime StartTracing { get; set; }
        public DateTime EndTracing { get; set; }
        public int MinuteInterval { get; set; }
    }
}
