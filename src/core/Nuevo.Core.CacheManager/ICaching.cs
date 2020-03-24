using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Core.CacheManager
{
    public interface ICaching<T> where T : class, new()
    {
        T Cache(Func<T> dlgt, string key = null, int cacheTime = 10);
        T CacheReset(Func<T> dlgt, string key, int cacheTime = 10);
        void CacheRemove(string key = null);
    }
}
