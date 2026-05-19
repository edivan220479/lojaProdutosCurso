using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lojaProdutosCurso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
