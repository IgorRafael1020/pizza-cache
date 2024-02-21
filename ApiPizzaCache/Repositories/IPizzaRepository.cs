using ApiPizzaCache.Models;

namespace ApiPizzaCache.Repositories
{
    public interface IPizzaRepository
    {
        public List<PizzaModel> GetAllPizza();
        public List<PizzaModel> GetAllPizzaCache();
        public PizzaModel GetPizza(int id);
        public void DeletePizza(int id);
    }
}
