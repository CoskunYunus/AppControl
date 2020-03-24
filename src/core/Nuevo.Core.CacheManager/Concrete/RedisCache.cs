using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Core.CacheManager.Concrete
{
    public class RedisCache<T> : ICaching<T> where T : class, new()
    {
        public T Cache(Func<T> dlgt, string key = null, int cacheTime = 10)
        {
            throw new NotImplementedException();
        }

        public T CacheReset(Func<T> dlgt, string key, int cacheTime = 10)
        {
            throw new NotImplementedException();
        }

        public void CacheRemove(string key = null)
        {
            throw new NotImplementedException();
        }
    }
}
