using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;

namespace Nuevo.Middlewares.AppHealthManager.EfBusiness
{
  public  class Context: AppEfContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationTracing> ApplicationTracings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
