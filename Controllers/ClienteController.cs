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
            Conta.cliente.addClient(cliente1);
            ViewBag.Mensagem = "Cadastro Realizado";
            return View();

        }
        //por enquanto só fiz assim para ser mais fácil mas no projeto com banco vou fazer a validação do login;
        public IActionResult Acesso()
        {
            return View();
        }

        public IActionResult Depositar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Depositar(Cliente clienteDeposito)
        {
            Conta.cliente.depositar(clienteDeposito);
            ViewBag.Mensagem = "Desposito Realizado";
            return RedirectToAction("Acesso", "Cliente");
        }
        public IActionResult Sacar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sacar(Cliente clienteSaque)
        {
            Conta.cliente.sacar(clienteSaque);
            ViewBag.Mensagem = "Saque Realizado";
            return RedirectToAction("Acesso", "Cliente");
        }
    }
}
