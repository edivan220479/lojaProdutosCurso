using lojaProdutosCurso.Dto.Produto;
using lojaProdutosCurso.Models;

namespace lojaProdutosCurso.Services.Produto
{
    public interface IProdutoInterface
    {
        Task<List<ProdutoModel>> BuscarProdutos();
        //metodo para cadastrar um produto, recebendo os dados do produto e a foto
        Task<ProdutoModel> Cadastrar(CriarProdutoDto criarProdutoDto, IFormFile foto);
        // Método para buscar um produto por ID
        Task<ProdutoModel> BuscarProdutoPorId(int id);
        // Método para editar um produto, recebendo os dados atualizados do produto e a nova foto
        Task<ProdutoModel> Editar(EditarProdutoDto editarProdutoDto, IFormFile foto);
        // Método para remover um produto por ID
        Task<ProdutoModel> Remover(int id);
    }
}
