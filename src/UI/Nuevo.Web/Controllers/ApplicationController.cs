using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Middlewares.AppHealthManager.Models;
using Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts;
using Nuevo.Web.Extensions;

namespace Nuevo.Web.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IAppHealthLogic _appHealthLogic;

        public ApplicationController(IAppHealthLogic appHealthLogic)
        {
            this._appHealthLogic = appHealthLogic;
        }


        public IActionResult Index()
        {
            var accountKey = HttpContext.Session.GetAuth().Key;
            var model = _appHealthLogic.GetApplication(accountKey);
            return View(model);
        }

        public IActionResult ApplicationTracingList(int appKey)
        {
            return View();
        }
        public IActionResult ApplicationTracingSet(int appKey)
        {
            return View();
        }
        public IActionResult ApplicationTracingRemove(int appKey)
        {
            return View();
        }



        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AppResponsetModel model)
        {
            var result = _appHealthLogic.ApplicationAdd(model);
            if (result.Status == Core.Infrastructure.ResultType.Success)
                return RedirectToAction("Index");
            return View(result);
        }

        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(AppResponsetModel model)
        {
            var result = _appHealthLogic.ApplicationUpdate(model);
            if (result.Status == Core.Infrastructure.ResultType.Success)
                return RedirectToAction("Index");
            return View(result);
        }



    }
}