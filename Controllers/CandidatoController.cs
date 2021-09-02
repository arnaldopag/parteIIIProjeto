using Microsoft.AspNetCore.Mvc;
using parteIII.Models;

namespace parteIII.Controllers
{
    public class CandidatoController : Controller
    {

        public IActionResult Trabalhe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Trabalhe(Candidato cadastroCandidato)
        {
            var candidato = new CandidatoRepository();
            candidato.Cadastro(cadastroCandidato);
            ViewBag.Mensagem = "Curriculo Cadastrado com sucesso!!!";
            return View();
        }
    }
}