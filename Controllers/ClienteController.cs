using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return RedirectToAction("Login");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Cliente clienteLogin)
        { 
            var loginCliente = new ClienteRepository();
            var clienteValido =  loginCliente.Login(clienteLogin);
            if (clienteValido == null)
            {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
            HttpContext.Session.SetInt32("IdCliente", clienteValido.Id_cliente);
            HttpContext.Session.SetString("NomeCliente", clienteValido.Nome);

            return RedirectToAction("Acesso");
        }

        public IActionResult Acesso(int id)
        {
            
            var buscarCliente = new ClienteRepository();
            var clienteEncontrado = buscarCliente.EncontrarCliente(id);
          
            return View(clienteEncontrado);
        }
        public IActionResult Sacar()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Sacar(int id)
        {
            
            var buscarCliente = new ClienteRepository(); 
            var contaLocalizada = buscarCliente.EncontrarCliente(id);
            var depositoConta = new Cliente();
            var novoSaldo =  depositoConta.Sacar(contaLocalizada);

            buscarCliente.Saque(contaLocalizada,novoSaldo);
            
            return RedirectToAction("Acesso", "Cliente");
        }
        public IActionResult Depositar()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Depositar(int id)
        {
            var buscarCliente = new ClienteRepository(); 
            var contaLocalizada = buscarCliente.EncontrarCliente(id);
            var depositoConta = new Cliente();
            var novoSaldo =  depositoConta.Depositar(contaLocalizada);

            buscarCliente.Deposito(contaLocalizada,novoSaldo);
            
            return RedirectToAction("Acesso", "Cliente");
        }
        
    }
}
