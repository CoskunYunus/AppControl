using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Middlewares.AppHealthControl.Models.ResponseModel;
using Nuevo.Middlewares.AppHealthControl.Provider.LogicContracts;
using Nuevo.Middlewares.AppHealthManager.Models;
using Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts;
using Nuevo.Web.Extensions;
using Nuevo.Web.QuartzManager;

namespace Nuevo.Web.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IAppHealthLogic _appHealthLogic;
        private readonly IAppHealtControlLogic _abAppHealtControlLogic;

        public ApplicationController(IAppHealthLogic appHealthLogic, IAppHealtControlLogic abAppHealtControlLogic)
        {
            _appHealthLogic = appHealthLogic;
            _abAppHealtControlLogic = abAppHealtControlLogic;
        }


        public IActionResult Index()
        {
            ViewBag.userName = HttpContext.Session.GetAuth().Email;
            var accountKey = HttpContext.Session.GetAuth().Key;
            var model = _appHealthLogic.GetApplication(accountKey);
            return View(model);
        }

        public IActionResult ApplicationTracingList(int appKey)
        {
            var model = _abAppHealtControlLogic.TracingHistory(appKey);
            return View(model);
        }


        public void Add(AppResponsetModel model)
        {
            model.AccountId = HttpContext.Session.GetAuth().Key;

            if (model.Id > 0)
                _appHealthLogic.ApplicationUpdate(model);
            else
                _appHealthLogic.ApplicationAdd(model);
        }

        public void Delete(int id)
        {
            var result = _appHealthLogic.ApplicationDelete(id);
        }

    }
}