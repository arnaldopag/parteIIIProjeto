using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using parteIII.Models;


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

        public IActionResult Contato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contato(Contato novoContato)
        {
            var contato = new ContatoRepository();
            contato.Cadastro(novoContato);
            ViewBag.Mensagem = "Cadastro Realizado";
            return View();
        }
    }
}
