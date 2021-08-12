using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Institucional()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}
