namespace spotlight_technical_test.Caching
{
    internal sealed class SimpleInMemoryCache : ICache
    {
        public bool TryGetValue(object key, out object value)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new System.NotImplementedException();
        }

        public void Add(object key, object value)
        {
            throw new System.NotImplementedException();
        }
    }
}