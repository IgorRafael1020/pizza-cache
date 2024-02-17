using ApiPizzaCache.Models;

namespace ApiPizzaCache.Repositories
{
    public interface IPizzaRepository
    {
        public List<PizzaModel> GetAll();
        public PizzaModel Get(int id);
    }
}
