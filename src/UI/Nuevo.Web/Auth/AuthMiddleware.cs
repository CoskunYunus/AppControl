using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Nuevo.Web.Extensions;

namespace Nuevo.Web.Auth
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public static readonly List<string> NotAuthLink = new List<string> { "/Account/Index", "/Account" };
        public async Task Invoke(HttpContext context)
        {

            if (!NotAuthLink.Contains(context.Request.Path))
                if (context.Session.IsOnline() == false)
                    context.Response.Redirect("/Account");
            await _next.Invoke(context);
        }
    }
}
