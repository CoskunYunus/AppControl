using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Provider.DbContracts
{
   public interface IAplication
    {
        void Add(Application application);
        void Update(Application application);
        void Delete(Application application);
        List<Application> List();
        List<Application> List(int accountId);
        Application GetByKey(object key);
    }
}
