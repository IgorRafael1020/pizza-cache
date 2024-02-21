using ApiPizzaCache.Models;
using ApiPizzaCache.Services.Pizza;
using ApiPizzaCache.Services.Redis;

namespace ApiPizzaCache.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly ILogger _logger;

        private readonly IRedisService _redisService;

        private readonly IPizzaService _pizzaService;
        public PizzaRepository(ILogger<IPizzaRepository> logger, IRedisService redisService, IPizzaService pizzaService) 
        {
            _logger = logger;
            _redisService = redisService;
            _pizzaService = pizzaService;
        }

        public List<PizzaModel> GetAllPizza()
        {
            return _pizzaService.GetAll();
        }

        public List<PizzaModel> GetAllPizzaCache()
        {
            return _redisService.RedisHashGetAll<PizzaModel>();
        }

        public PizzaModel GetPizza(int id)
        {
            PizzaModel pizza;

            pizza = _redisService.RedisHashGet<PizzaModel>(id.ToString());

            if(pizza != null)
            {
                _logger.LogInformation("Retorno pelo Redis");
                return pizza;
            }

            int milissegundos = 5000;
            Thread.Sleep(milissegundos);

            pizza = _pizzaService.Get(id);

            _redisService.RedisHashSet<PizzaModel>(id.ToString(), pizza);

            _logger.LogInformation("Retorno normal");
            return pizza;
        }

        public void DeletePizza(int id)
        {
            _redisService.RedisHashDelete(id.ToString());
        }
    }
}
