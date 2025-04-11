using System;
using BlazorShop.Api.Enitites;

namespace BlazorShop.Api.Reopositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetItens();
    Task<Produto> GetItem(int id);
    Task<IEnumerable<Produto>> GetItensPorCategoria(int id);
}
