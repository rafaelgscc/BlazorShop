using System;

namespace BlazorShop.Api.Enitites;

public class Carrinho
{
    public int Id { get; set; }

    //workaround
    public string UsuarioId { get; set; } = string.Empty;

    public ICollection<CarrinhoItem> Itens {get; set;} = new List<CarrinhoItem>();
}
