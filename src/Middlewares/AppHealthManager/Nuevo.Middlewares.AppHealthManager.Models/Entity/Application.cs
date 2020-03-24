using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Models.Entity
{
  public  class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
