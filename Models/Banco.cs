using System.Collections.Generic;
namespace parteIII.Models
{
    public class Banco
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private string login { get; set; }
        private string senha { get; set; }
        public string Login
        {
            get { return login; }
            set { this.login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }

        }
        public void addClient(Cliente novoCliente)
        {
            clientes.Add(novoCliente);
        }
        public string sacar(Cliente clienteSaque, double valorSaque)
        {
            if (valorSaque > clienteSaque.Saldo)
            {
                string mensagemFalha = "----Saldo Insuficiente----\n";
                mensagemFalha += "Saldo atual: " + clienteSaque.Saldo + "\n";
                mensagemFalha += "Valor Saque: " + valorSaque + "\n";
                return mensagemFalha;
            }
            clienteSaque.Saldo -= valorSaque;
            string Mensagem = "----Saque Realizado----\n";
            Mensagem += "Saldo atual: " + clienteSaque.Saldo + "\n";
            Mensagem += "Valor Saque: " + valorSaque + "\n";
            return Mensagem;

        }
        public string depositar(Cliente clienteDeposito, double valorDeposito)
        {

            clienteDeposito.Saldo += valorDeposito;
            string mensagemDeposito = "---Deposito Realizado---\n";
            mensagemDeposito += "Valor deposito: R$" + valorDeposito + "\n";
            mensagemDeposito += "Saldo: R$" + clienteDeposito.Saldo + "\n";

            return mensagemDeposito;

        }
        public Cliente verificarLogin(Cliente clienteLogin)
        {
            Cliente clientelogin = clientes.Find(acesso => acesso.Login == this.login);
            if (clienteLogin != null)
            {
                return clienteLogin;
            }
            return null;

        }
    }
}