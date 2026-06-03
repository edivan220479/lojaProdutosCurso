using lojaProdutosCurso.Dto.Produto;
using lojaProdutosCurso.Models;

namespace lojaProdutosCurso.Services.Produto
{
    public interface IProdutoInterface
    {
        Task<List<ProdutoModel>> BuscarProdutos();
        //metodo para cadastrar um produto, recebendo os dados do produto e a foto
        Task<ProdutoModel> Cadastrar(CriarProdutoDto criarProdutoDto, IFormFile foto);
    }
}
