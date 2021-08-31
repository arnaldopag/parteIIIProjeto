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
            Cliente clienteAcesso = new Cliente();

            clienteAcesso = Conta.cliente.verificarLogin(clienteLogin);
            if (clienteAcesso == null)
            {
                ViewBag.Mensagem = "Erro no Login";
                return View();
            }
            return RedirectToAction("Acesso", "Cliente");

        }
        public IActionResult Produtos()
        {
            return View();
        }
    }
}