namespace ApiPizzaCache.Models
{
    public class PizzaModel
    {
        public string Nome { get; set; }
        public List<string> Ingredientes { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set;}
        public bool Vegetariana { get; set;}
        public int NivelDePicancia { get; set;}
        public List<string> CoberturasAdicionais { get; set; }
        public int Calorias { get; set;}
        public string InformacoesAlergenos { get; set; }
        public string TempoDePreparacao { get; set; }
    }
}
