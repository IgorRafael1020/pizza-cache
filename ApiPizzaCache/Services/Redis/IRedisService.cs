namespace ApiPizzaCache.Services.Redis
{
    public interface IRedisService
    {
        public List<T> RedisHashGetAll<T>();
        public T RedisHashGet<T>(string key);
        public void RedisHashSet<T>(string key, T value);
        public void RedisHashDelete(string key);
    }
}
