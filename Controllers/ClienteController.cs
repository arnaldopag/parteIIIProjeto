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
    public class ClienteController : Controller
    {
        public IActionResult Cadastro()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Cliente cliente1)
        {
            var cl = new ClienteRepository();
            cl.Inserir(cliente1);
            ViewBag.Mensagem = "Cadastro Realizado";
            return RedirectToAction("CadastroConta", "Conta");

        }

    }
}
