using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace Greg.Estetica.Core.Cache
{
    public class Cache
    {
        public static void Set(Object obj,CacheItemEnum cacheItemType)
        {
            var cache = MemoryCache.Default;

            CacheItemPolicy policy = new CacheItemPolicy();

            policy.Priority = CacheItemPriority.NotRemovable;
            
            cache.Set(cacheItemType.ToString(),obj,policy);
            
        }

        public static T Get<T>(CacheItemEnum cacheItemType)
        {
            T returnCacheItem;

            var cache = MemoryCache.Default;

            var cacheItem = cache[cacheItemType.ToString()];

            return ConvertObject<T>(cacheItem);

        }
    }

    
}
