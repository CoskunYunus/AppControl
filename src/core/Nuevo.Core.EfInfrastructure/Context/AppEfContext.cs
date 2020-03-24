using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Nuevo.Core.EfInfrastructure
{
   public class AppEfContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localHost;Database=nuevoApp;Trusted_Connection=True;");
        }

     
    }
}
