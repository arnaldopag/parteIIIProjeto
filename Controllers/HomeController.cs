using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace parteIII.Controllers
{
    public class HomeController : Controller {
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
        public IActionResult Produtos()
        {
            return View();
        }
    }
}
