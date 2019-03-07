using Microsoft.Extensions.Caching.Memory;
using System;

namespace spotlight_technical_test.Caching
{
    internal sealed class SimpleInMemoryCache : ICache
    {
        public const int MaxMinutes = 30;
        private IMemoryCache _memoryCache;
        private MemoryCacheEntryOptions _cacheOptions =>
            new MemoryCacheEntryOptions
            {
                Size = 1,
                SlidingExpiration = TimeSpan.FromMinutes(MaxMinutes)
            }
               .SetPriority(CacheItemPriority.Normal);

        public SimpleInMemoryCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public bool TryGetValue(object key, out object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            return _memoryCache.TryGetValue(key, out value);
        }

        public void Remove(object key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            _memoryCache.Remove(key);
        }

        public void Add(object key, object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            _memoryCache.Set(key, value, _cacheOptions);
        }
    }
}