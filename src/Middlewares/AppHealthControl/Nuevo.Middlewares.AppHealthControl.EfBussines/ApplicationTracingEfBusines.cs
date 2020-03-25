using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthControl.EfBussines;
using Nuevo.Middlewares.AppHealthControl.Provider.DbConracts;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;

namespace Nuevo.Middlewares.AppHealthControl.EfBussines
{
    
    public class ApplicationTracingEfBusines : BaseRepo<ApplicationTracing, Context>, IAplicationTracing
    {
        public void Add(ApplicationTracing application) => base.Add(application);

        public void Update(ApplicationTracing application) => base.Update(application);

        public void Delete(ApplicationTracing application) => base.Delete(application.Id);

        public List<ApplicationTracing> List(int appId) => base.List(c => c.ApplicationId == appId).OrderBy(c=> c.CreateDate).ToList();
    }
}
