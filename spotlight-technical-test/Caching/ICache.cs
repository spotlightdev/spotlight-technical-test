namespace spotlight_technical_test.Caching
{
    public interface ICache
    {

        void Add(object key, object value);

        bool TryGetValue(object key, out object value);

        void Remove(object key);

    }
}
