using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.Infrastructure;
using Nuevo.Middlewares.AppHealthManager.EfBusiness;
using Nuevo.Middlewares.AppHealthManager.Models;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;
using Nuevo.Middlewares.AppHealthManager.Provider.DbContracts;
using Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts;

namespace Nuevo.Middlewares.AppHealthManager.Logic
{
    public class AppHealthLogic : IAppHealthLogic
    {
        public readonly IAplication _aplication;
        public readonly IAplicationTracing _aplicationTracing;

        //public AppHealthLogic(IAplication aplication, IAplicationTracing aplicationTracing)
        //{
        //    _aplication = aplication;
        //    _aplicationTracing = aplicationTracing;
        //}
        public AppHealthLogic()
        {
            _aplication = new AplicationEfBusiness();
            _aplicationTracing = new ApplicationTracingEfBusines();
        }
      

        public Result ApplicationAdd(AppResponsetModel model)
        {

            //VALİDAT CONTROL 
            //MAPER
            if (model != null)
            {
                _aplication.Add(new Application
                {
                    Name = "",
                    //.....
                });
                return new Result
                {
                    Status = ResultType.Success
                };
            }
            else
                return new Result
                {
                    Status = ResultType.Error
                };
        }

        public Result ApplicationUpdate(AppResponsetModel model)
        {
            //VALİDAT CONTROL 
            throw new NotImplementedException();
        }


        public Result<List<AppResponsetModel>> GetApplication(int accountKey)
        {
            //automapper ..... vb.
            var result = _aplication.List().Select(c => new AppResponsetModel
            {
                Name = c.Name,
                Url = c.Url
            }).ToList();
            
            
            return result == null ?
                new Result<List<AppResponsetModel>>
                {
                    Status = ResultType.Warning
                } :
                new Result<List<AppResponsetModel>>
                {
                    Data = result,
                    Status = ResultType.Success
                };
        }

        public Result<AccountResponseModel> GetAccount(string email)
        {
            throw new NotImplementedException();
        }

    }
}
