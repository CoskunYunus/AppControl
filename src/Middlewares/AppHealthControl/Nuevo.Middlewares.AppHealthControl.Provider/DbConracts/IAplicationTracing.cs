using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using System.Collections.Generic;

namespace Nuevo.Middlewares.AppHealthControl.Provider.DbConracts
{
  public  interface IAplicationTracing
    {
        void Add(ApplicationTracing applicationTracing);
        void Update(ApplicationTracing applicationTracing);
        void Delete(ApplicationTracing applicationTracing);
        List<ApplicationTracing> List(int appId);
    }
}
