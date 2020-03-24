using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts;
using Nuevo.Web.Extensions;

namespace Nuevo.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppHealthLogic _appHealthLogic;

        public AccountController(IAppHealthLogic appHealthLogic)
        {
            this._appHealthLogic = appHealthLogic;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login model)
        {
            if (model == null || model.Email.Length < 5) return View();

            var user = _appHealthLogic.GetAccount(model.Email);
            if (user == null) return View();
            HttpContext.Session.SetAuth(new Auth.AuthModel {Email = user.Data.Email, Key = user.Data.Id});
            return Redirect("/Application");
        }

    }
}