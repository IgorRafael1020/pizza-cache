using ApiPizzaCache.Models;

namespace ApiPizzaCache.Services.Pizza
{
    public class PizzaService : IPizzaService
    {
        public List<PizzaModel> GetAll()
        {
            return new List<PizzaModel>
            {
                new PizzaModel()
                {
                    Id = 1,
                    Nome = "Margherita",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Manjericão fresco"
                    },
                    Descricao = "Uma pizza clássica italiana com molho de tomate, queijo e manjericão fresco.",
                    Vegetariana = true,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>(),
                    Calorias = 220,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 2,
                    Nome = "Pepperoni",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Pepperoni",
                        "Orégano"
                    },
                    Descricao = "Uma pizza clássica com pepperoni picante e queijo derretido.",
                    Vegetariana = false,
                    NivelDePicancia = 3,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Azeitonas"
                    },
                    Calorias = 280,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 3,
                    Nome = "Quatro Queijos",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo Mussarela",
                        "Queijo Gorgonzola",
                        "Queijo Parmesão",
                        "Queijo Provolone"
                    },
                    Descricao = "Uma deliciosa combinação de quatro tipos de queijo em uma pizza.",
                    Vegetariana = true,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>(),
                    Calorias = 300,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 4,
                    Nome = "Frango com Catupiry",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Frango desfiado",
                        "Catupiry",
                        "Milho"
                    },
                    Descricao = "Uma pizza de frango desfiado e catupiry cremoso, com um toque de milho.",
                    Vegetariana = false,
                    NivelDePicancia = 2,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Azeitonas",
                        "Cebola"
                    },
                    Calorias = 320,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 5,
                    Nome = "Portuguesa",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Presunto",
                        "Ovo",
                        "Cebola",
                        "Azeitonas"
                    },
                    Descricao = "Uma pizza com uma combinação única de ingredientes como presunto, ovos e cebolas.",
                    Vegetariana = false,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Orégano"
                    },
                    Calorias = 290,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 6,
                    Nome = "Marguerita Picante",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Pimenta Jalapeño",
                        "Manjericão fresco"
                    },
                    Descricao = "Uma versão picante da clássica pizza marguerita, com pimenta jalapeño.",
                    Vegetariana = true,
                    NivelDePicancia = 4,
                    CoberturasAdicionais = new List<string>(),
                    Calorias = 240,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 7,
                    Nome = "BBQ",
                    Ingredientes = new List<string>()
                    {
                        "Molho de barbecue",
                        "Queijo",
                        "Frango grelhado",
                        "Cebola roxa",
                        "Salsinha"
                    },
                    Descricao = "Uma pizza com molho barbecue, frango grelhado, cebola roxa e salsinha fresca.",
                    Vegetariana = false,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Azeitonas"
                    },
                    Calorias = 310,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 8,
                    Nome = "Margherita Duplo Queijo",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo Mussarela",
                        "Queijo Parmesão",
                        "Manjericão fresco"
                    },
                    Descricao = "Uma versão com queijo duplo da tradicional pizza margherita, com queijo mussarela e parmesão.",
                    Vegetariana = true,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Orégano"
                    },
                    Calorias = 260,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 9,
                    Nome = "Mexicana",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Carne moída",
                        "Pimentão",
                        "Milho",
                        "Chili em pó"
                    },
                    Descricao = "Uma pizza com inspiração mexicana, com carne moída temperada, pimentão e milho.",
                    Vegetariana = false,
                    NivelDePicancia = 3,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Azeitonas",
                        "Cebola"
                    },
                    Calorias = 320,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                },
                new PizzaModel()
                {
                    Id = 10,
                    Nome = "Hawaii",
                    Ingredientes = new List<string>()
                    {
                        "Molho de tomate",
                        "Queijo",
                        "Presunto",
                        "Abacaxi"
                    },
                    Descricao = "Uma pizza clássica com uma combinação agridoce de presunto e abacaxi.",
                    Vegetariana = false,
                    NivelDePicancia = 1,
                    CoberturasAdicionais = new List<string>()
                    {
                        "Orégano"
                    },
                    Calorias = 280,
                    InformacoesAlergenos = new List<string>()
                    {
                        "Glúten",
                        "Laticínios"
                    }
                }
            };
        }

        public PizzaModel Get(int id)
        {
            return GetAll().Find(x => x.Id == id);
        }
    }
}
