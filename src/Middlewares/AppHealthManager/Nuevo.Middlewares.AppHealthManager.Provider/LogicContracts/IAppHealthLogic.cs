using System;
using System.Collections.Generic;
using System.Text;
using Nuevo.Core.Infrastructure;
using Nuevo.Middlewares.AppHealthManager.Models;

namespace Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts
{
    public interface IAppHealthLogic
    {
         Result ApplicationAdd(AppResponsetModel  model);
         Result ApplicationUpdate(AppResponsetModel model);
         Result<List<AppResponsetModel>> GetApplication(int accountKey);

        Result<AccountResponseModel> GetAccount(string email);
    }
}
