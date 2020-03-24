using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Nuevo.Web.Auth;

namespace Nuevo.Web.Extensions
{
    public static class SessionExt
    {
        public static readonly string AuthKey = "AuthUser";
        public static AuthModel GetAuth(this ISession session)
        {
            var value = session.GetString(AuthKey);
            return value == null ? default(AuthModel) :
                JsonConvert.DeserializeObject<AuthModel>(value);
        }
        public static void SetAuth(this ISession session, AuthModel auth)
        {
            session.SetString(AuthKey, JsonConvert.SerializeObject(auth));

        }

        public static bool IsOnline(this ISession session)
        {
            return session.GetAuth() != null;
        }
    }
}
