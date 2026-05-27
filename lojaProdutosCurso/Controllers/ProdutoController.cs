using lojaProdutosCurso.Services.Produto;
using Microsoft.AspNetCore.Mvc;

namespace lojaProdutosCurso.Controllers
{
    public class ProdutoController : Controller
    {
        // Injeção de dependência do serviço de produto
        private readonly IProdutoInterface _produtoInterface;
        public ProdutoController(IProdutoInterface produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoInterface.BuscarProdutos();
            return View(produtos);
        }
    }
}
