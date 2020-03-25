using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.EfInfrastructure;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using Nuevo.Middlewares.AppHealthManager.Provider.DbContracts;

namespace Nuevo.Middlewares.AppHealthManager.EfBusiness
{
    public class UserEfBussines : BaseRepo<User, Context>, IAccount
    {
        public User GetEmail(string email) => base.List(c => c.Email == email).FirstOrDefault();

    }
}
