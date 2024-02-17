using ApiPizzaCache.Models;
using ApiPizzaCache.Services;

namespace ApiPizzaCache.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly IRedisService _redisService;
        public PizzaRepository(IRedisService redisService) 
        {
            _redisService = redisService;
        }

        public List<PizzaModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PizzaModel Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
