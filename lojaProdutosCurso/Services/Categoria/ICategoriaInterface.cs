using lojaProdutosCurso.Models;

namespace lojaProdutosCurso.Services.Categoria
{
    public interface ICategoriaInterface
    {
        Task<List<CategoriaModel>> BuscarCategorias();
    }
}
