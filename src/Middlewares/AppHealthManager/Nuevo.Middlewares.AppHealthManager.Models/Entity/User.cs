using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Models.Entity
{
  public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
