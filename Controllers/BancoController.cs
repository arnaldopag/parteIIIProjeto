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
    public class BancoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Cliente clienteLogin)
        {
            var loginCliente = new BancoRepository();
            loginCliente.Login(clienteLogin);
            if (loginCliente == null)
            {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
            HttpContext.Session.SetInt32("IdCliente", loginCliente.Id);
            HttpContext.Session.SetString("NomeCliente", loginCliente.Nome);

            return RedirectToAction("Acesso", "Cliente");
        }

        public IActionResult Produtos()
        {
            return View();
        }
    }
}