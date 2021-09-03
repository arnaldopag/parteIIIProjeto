using Microsoft.AspNetCore.Mvc;
using parteIII.Models;
namespace parteIII.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult CadastroConta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroConta(Conta newConta)
        {
            var contaCadastro = new ContaRepository();
            contaCadastro.Cadastro(newConta);
            return RedirectToAction("Login", "Cliente");
        }
    }
}