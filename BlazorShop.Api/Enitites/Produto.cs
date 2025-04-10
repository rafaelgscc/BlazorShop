using System;

namespace BlazorShop.Api.Enitites;

public class Produto
{
     public int Id { get; set; }
     public string Nome { get; set; } = string.Empty;
     public string Descricao { get; set; } = string.Empty;
     public string ImagemUrl { get; set; } = string.Empty;
     public decimal Preco {get; set; }
     public int Quantidade {get; set; }

     public int CategoriaId {get; set;}

     //explicitação de produto com categoria
     public Categoria? Categoria {get; set;}

    public ICollection<CarrinhoItem> Itens {get; set;} = new List<CarrinhoItem>();
}
