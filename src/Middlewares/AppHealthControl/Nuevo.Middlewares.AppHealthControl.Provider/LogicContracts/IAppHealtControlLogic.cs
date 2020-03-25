using System;
using System.Collections.Generic;
using System.Text;
using Nuevo.Core.Infrastructure;
using Nuevo.Middlewares.AppHealthControl.Models.RequestModel;
using Nuevo.Middlewares.AppHealthControl.Models.ResponseModel;

namespace Nuevo.Middlewares.AppHealthControl.Provider.LogicContracts
{
    public interface IAppHealtControlLogic
    {

        public Result<List<TracingRequestModel>> TracingHistory(int groupId);
        public Result AddTracing(TracingResponseModel model);
    }
}
