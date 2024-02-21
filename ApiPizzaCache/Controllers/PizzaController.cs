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

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_pizzaRepository.GetAllPizza());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("Cache")]
        public ActionResult GetCache()
        {
            try
            {
                return Ok(_pizzaRepository.GetAllPizzaCache());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            try
            {   
                PizzaModel pizza = _pizzaRepository.GetPizza(id);
                return pizza == null ? NotFound(id) : Ok(pizza);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _pizzaRepository.DeletePizza(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
