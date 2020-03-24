using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Provider.DbContracts
{
  public  interface IAplicationTracing
    {
        void Add(ApplicationTracing applicationTracing);
        void Update(ApplicationTracing applicationTracing);
        void Delete(ApplicationTracing applicationTracing);
        List<ApplicationTracing> List();
    }
}
