using Microsoft.AspNetCore.Mvc;

namespace lojaProdutosCurso.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
