using lojaProdutosCurso.Services.Categoria;
using lojaProdutosCurso.Services.Produto;
using Microsoft.AspNetCore.Mvc;

namespace lojaProdutosCurso.Controllers
{
    public class ProdutoController : Controller
    {
        // Injeção de dependência do serviço de produto
        private readonly IProdutoInterface _produtoInterface;
        private readonly ICategoriaInterface _categoriaInterface;
        public ProdutoController(IProdutoInterface produtoInterface,
                                 ICategoriaInterface categoriaInterface
                                     )
        {
            _produtoInterface = produtoInterface;
            _categoriaInterface = categoriaInterface;
        }
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoInterface.BuscarProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> Cadastrar()
        {
            ViewBag.Categorias = await _categoriaInterface.BuscarCategorias();
            return View();
        }
    }
}
