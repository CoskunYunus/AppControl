using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuevo.Core.Infrastructure;
using Nuevo.Middlewares.AppHealthControl.EfBussines;
using Nuevo.Middlewares.AppHealthControl.Models.RequestModel;
using Nuevo.Middlewares.AppHealthControl.Models.ResponseModel;
using Nuevo.Middlewares.AppHealthControl.Provider.DbConracts;
using Nuevo.Middlewares.AppHealthControl.Provider.LogicContracts;
using Nuevo.Middlewares.AppHealthManager.Models.Entity;

namespace Nuevo.Middlewares.AppHealthControl.Logic
{
    public class AppHealtControlLogic : IAppHealtControlLogic
    {
        public readonly IAplicationTracing _aplicationTracing;

        //public AppHealtControlLogic(IAplicationTracing aplicationTracing)
        //{
        //    this.aplicationTracing = aplicationTracing;
        //}
        public AppHealtControlLogic()
        {
            this._aplicationTracing = new ApplicationTracingEfBusines();
        }

        public Result<List<TracingRequestModel>> TracingHistory(int groupId)
        {
            if (groupId>0)
            {
                var _data = _aplicationTracing.List(groupId)?.Select(c=> new TracingRequestModel
                {
                    Status = c.Status ? "Successful": "Unsuccessful",
                    ApplicationId=c.ApplicationId,
                    Message = c.Message,
                    CreateDate= c.CreateDate.ToString("dd-MM-yyyy")
                }).ToList();
                return new Result<List<TracingRequestModel>>
                {
                    Status = ResultType.Success,
                    Data= _data
                };
            }
            else
            {
                return  new Result<List<TracingRequestModel>>
                {
                    Status = ResultType.Warning
                };
            }
            throw new NotImplementedException();
        }

        public Result AddTracing(TracingResponseModel model)
        {
            _aplicationTracing.Add(new ApplicationTracing
            {
                ApplicationId = model.ApplicationId,
                CreateDate= DateTime.Now,
                Message= model.Message,
                Status = model.Status
            });
            return new Result
            {
                Status =ResultType.Success
            };
        }
    }
}
