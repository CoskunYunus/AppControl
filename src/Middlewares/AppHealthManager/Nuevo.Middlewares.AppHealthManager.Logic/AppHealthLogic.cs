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
        public readonly IAccount _userEfBussines;

        //public AppHealthLogic(IAplication aplication, IAplicationTracing aplicationTracing)
        //{
        //    _aplication = aplication;
        //    _aplicationTracing = aplicationTracing;
        //}
        public AppHealthLogic()
        {
            _aplication = new AplicationEfBusiness();
            _userEfBussines = new UserEfBussines();
        }


        public Result ApplicationAdd(AppResponsetModel model)
        {

            //VALİDAT CONTROL 
            //MAPER
            if (model != null)
            {
                _aplication.Add(new Application
                {
                    Name = model.Name,
                    UserId = model.AccountId,
                    Status = true,
                    Url = model.Url,
                    Id = model.Id,
                    Tracking = model.Tracking
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

        public Result ApplicationDelete(int key)
        {
            var _deleteData = _aplication.GetByKey(key);
            if (_deleteData == null)
            {
                return new Result
                {
                    Status = ResultType.Warning
                };
            }
            _aplication.Delete(_deleteData);
            return new Result
            {
                Status = ResultType.Success
            };
        }

        public Result ApplicationUpdate(AppResponsetModel model)
        {
            //VALİDAT CONTROL 
            if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Url) || model.AccountId < 1 || model.Id < 1)
            {
                return new Result
                {
                    Status = ResultType.Error,
                    Message = "Not İs Valid"
                };
            }

            var _data = _aplication.GetByKey(model.Id);
            if (_data == null)
                return new Result
                {
                    Status = ResultType.Error
                };
            _data.Name = model.Name;
            _data.Url = model.Url;
            _data.Status = _data.Status;
            _data.Tracking = model.Tracking;
            _aplication.Update(_data);
            return new Result
            {
                Status = ResultType.Success
            };

        }


        public Result<List<AppResponsetModel>> GetApplication(int accountKey)
        {
            //automapper ..... vb.
            var result = _aplication.List(accountKey).Select(c => new AppResponsetModel
            {
                Name = c.Name,
                Url = c.Url,
                AccountId = accountKey,
                Id = c.Id,
                Tracking =c.Tracking
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
            if (string.IsNullOrEmpty(email))
            {
                return new Result<AccountResponseModel>
                {
                    Status = ResultType.Error
                };
            }
            var data = _userEfBussines.GetEmail(email);

            if (data == null)
            {
                return new Result<AccountResponseModel>
                {
                    Status = ResultType.Error
                };
            }
            return new Result<AccountResponseModel>
            {
                Status = ResultType.Success,
                Data = new AccountResponseModel
                {
                    Email = data.Email,
                    Id = data.Id
                }
            };
        }

    }
}
