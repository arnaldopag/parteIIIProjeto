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
            HttpContext.Session.SetInt32("IdCliente", clienteValido.Id_cliente);
            HttpContext.Session.SetString("NomeCliente", clienteValido.Nome);

            return RedirectToAction("Acesso");
        }

        public IActionResult Acesso()
        {
            return View();
        }
        public IActionResult Sacar()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Sacar(int idCliente)
        {
            var buscarCliente = new ContaRepository(); 
            Conta contaLocalizada = buscarCliente.LocalizarConta(idCliente);
            var depositoConta = new Conta();
            var novoSaldo =  depositoConta.Sacar(contaLocalizada);

            buscarCliente.Saque(contaLocalizada,novoSaldo);
            
            return RedirectToAction("Acesso", "Cliente");
        }
        public IActionResult Depositar()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Depositar(int idCliente)
        {
            var buscarCliente = new ContaRepository(); 
            Conta contaLocalizada = buscarCliente.LocalizarConta(idCliente);
            var depositoConta = new Conta();
            var newSaldo =  depositoConta.Depositar(contaLocalizada);

            buscarCliente.Deposito(contaLocalizada,newSaldo);
            
            return RedirectToAction("Acesso", "Cliente");
        }
        
    }
}
