using System;
using System.Collections.Generic;
using System.Text;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;

namespace Nuevo.Middlewares.AppHealthManager.Provider.DbContracts
{
    public interface IAccount
    {
        public User GetEmail(string email);
    }
}
