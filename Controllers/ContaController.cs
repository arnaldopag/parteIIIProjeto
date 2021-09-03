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
        public IActionResult CadastroConta(Conta newConta,int id)
        {
            var contaCadastro = new ContaRepository();
            contaCadastro.Cadastro(newConta, id);
            return RedirectToAction("Acesso", "Cliente");
        }
    }
}