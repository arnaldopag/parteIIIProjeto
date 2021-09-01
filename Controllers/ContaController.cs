using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public IActionResult CadastrConta(Conta newConta)
        {
            var contaCadastro = new ContaRepository();
            contaCadastro.Inserir(newConta);
            return RedirectToAction("Login", "Banco");
        }
    }
}