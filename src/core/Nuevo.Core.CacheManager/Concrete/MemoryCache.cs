using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Core.CacheManager.Concrete
{
    public class HttpCaching<T> : ICaching<T> where T : class, new()
    {
        private IMemoryCache _cache;

        public HttpCaching(IMemoryCache cache)
        {
            _cache = cache;
        }
        public T Cache(Func<T> dlgt, string key = null, int cacheTime = 10)
        {
            T _data = new T();
            if (!_cache.TryGetValue(InitKey(key), out _data))
            {
                if (_data == null)
                {
                    _data = (T)dlgt.Invoke();
                    _cache.Set(key, _data, TimeSpan.FromMinutes(cacheTime));
                }
                return _data;
            }
            return _data;
        }
        public T CacheReset(Func<T> dlgt, string key, int cacheTime = 10)
        {
            CacheRemove(key);
            return Cache(dlgt, key, cacheTime);
        }
        public void CacheRemove(string key = null) => _cache.Remove(InitKey(key));
        private string InitKey(string key = null) => string.IsNullOrEmpty(key) ? "Cache-" + typeof(T).Assembly.FullName : "Cache-" + key;


    }
}
