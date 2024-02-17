using ApiPizzaCache.Models;
using ApiPizzaCache.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiPizzaCache.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(ILogger<PizzaController> logger, IPizzaRepository pizzaRepository)
        {
            _logger = logger;
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet(Name = "ListaDePizza")]
        public List<PizzaModel> Get()
        {
            return _pizzaRepository.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public PizzaModel Get(int id)
        {
            _logger.LogInformation( $"Pizza {id}");
            return _pizzaRepository.Get(id);
        }
    }
}
