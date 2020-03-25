using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;

namespace Nuevo.Middlewares.AppHealthControl.EfBussines
{
    public class Context : AppEfContext
    {
        public DbSet<ApplicationTracing> ApplicationTracings { get; set; }
    }
}
