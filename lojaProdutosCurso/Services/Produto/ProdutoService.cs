using lojaProdutosCurso.Data;
using lojaProdutosCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace lojaProdutosCurso.Services.Produto
{
    public class ProdutoService : IProdutoInterface
    {
        // Injeção de dependência do banco de dados
        private readonly DataContext _context;
        public ProdutoService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<ProdutoModel>> BuscarProdutos()
        {
            try
            {
                return await _context.Produtos.Include(c => c.Categoria).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

