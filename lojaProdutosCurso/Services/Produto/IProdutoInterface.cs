using lojaProdutosCurso.Models;

namespace lojaProdutosCurso.Services.Produto
{
    public interface IProdutoInterface
    {
        Task<List<ProdutoModel>> BuscarProdutos();
    }
}
