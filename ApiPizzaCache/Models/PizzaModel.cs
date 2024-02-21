namespace ApiPizzaCache.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Ingredientes { get; set; }
        public string Descricao { get; set; }
        public bool Vegetariana { get; set;}
        public int NivelDePicancia { get; set;}
        public List<string> CoberturasAdicionais { get; set; }
        public int Calorias { get; set;}
        public List<string> InformacoesAlergenos { get; set; }
    }
}
