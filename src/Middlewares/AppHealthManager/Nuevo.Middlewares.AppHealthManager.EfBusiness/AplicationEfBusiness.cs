﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using Nuevo.Middlewares.AppHealthManager.Provider.DbContracts;

namespace Nuevo.Middlewares.AppHealthManager.EfBusiness
{
    public class AplicationEfBusiness : BaseRepo<Application, Context>, IAplication
    {
        public void Add(Application application) => base.Add(application);

        public void Update(Application application) => base.Update(application);

        public void Delete(Application application) => base.Delete(application.Id);

        public List<Application> List() => base.List(c => true).ToList();
    }
}
