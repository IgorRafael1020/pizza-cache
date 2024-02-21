using StackExchange.Redis;
using System.Text.Json;

namespace ApiPizzaCache.Services.Redis
{
    public class RedisService : IRedisService
    {
        private readonly IDatabase _db;

        private readonly string? _hash;

        public RedisService(IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
            _hash = Environment.GetEnvironmentVariable("HASH_REDIS");
        }
        
        public List<T> RedisHashGetAll<T>()
        {
            List<T> lista = new List<T>();
            
            var values = _db.HashGetAll(_hash);

            foreach (var value in values)
            {
                T item = JsonSerializer.Deserialize<T>(value.Value);
                lista.Add(item);
            }
            return lista;
        }

        public T RedisHashGet<T>(string key)
        {
            var value = _db.HashGet(_hash, key);
            return value.IsNullOrEmpty ? default(T) : JsonSerializer.Deserialize<T>(value);
        }

        public void RedisHashSet<T>(string key, T value)
        {
            var valueRedis = JsonSerializer.Serialize<T>(value);
            HashEntry[] hashEntry = [new HashEntry(key, valueRedis)];
            _db.HashSet(_hash, hashEntry);
        }

        public void RedisHashDelete(string key)
        {
            _db.HashDelete(_hash, key);
        }
    }
}
