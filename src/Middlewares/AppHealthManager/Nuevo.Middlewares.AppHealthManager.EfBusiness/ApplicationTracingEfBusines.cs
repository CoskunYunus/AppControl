using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using Nuevo.Middlewares.AppHealthManager.Provider.DbContracts;

namespace Nuevo.Middlewares.AppHealthManager.EfBusiness
{
    public class ApplicationTracingEfBusines : BaseRepo<ApplicationTracing, Context>, IAplicationTracing
    {
        public void Add(ApplicationTracing application) => base.Add(application);

        public void Update(ApplicationTracing application) => base.Update(application);

        public void Delete(ApplicationTracing application) => base.Delete(application.Id);

        public List<ApplicationTracing> List() => base.List(c => true).ToList();
    }
}
