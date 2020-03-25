using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Nuevo.Core.EfInfrastructure
{
   public class AppEfContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = Convert.ToString(ConfigurationManager.ConnectionStrings["AppConnectionStrings"]);
            optionsBuilder.UseSqlServer("Server=localHost;Database=nuevoApp;Trusted_Connection=True;");
        }

    }
}
