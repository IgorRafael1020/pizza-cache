using ApiPizzaCache.Models;

namespace ApiPizzaCache.Services.Pizza
{
    public interface IPizzaService
    {
        public List<PizzaModel> GetAll();
        public PizzaModel Get(int id);
    }
}
