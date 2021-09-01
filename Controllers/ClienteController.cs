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
            cl.Cadastro(cliente1);
            ViewBag.Mensagem = "Cadastro Realizado";
            return RedirectToAction("CadastroConta", "Conta");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Cliente clienteLogin)
        {
            ClienteRepository loginCliente = new ClienteRepository();
            Cliente clienteValido =  loginCliente.Login(clienteLogin);
            if (clienteValido == null)
            {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
            HttpContext.Session.SetInt32("IdCliente", clienteValido.Id);
            HttpContext.Session.SetString("NomeCliente", clienteValido.Nome);

            return RedirectToAction("Acesso");
        }

        public IActionResult Acesso()
        {
            return View();
        }
        public IActionResult Sacar()
        {
            throw new NotImplementedException();
        }
        public IActionResult Depositar()
        {
            throw new NotImplementedException();
        }
    }
}
