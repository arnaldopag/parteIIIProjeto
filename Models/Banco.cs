using System.Collections.Generic;
namespace parteIII.Models
{
    public class Banco
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private string login { get; set; }
        private string senha { get; set; }
        private double deposito { get; set; }
        private double saque { get; set; }
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
        public double Deposito
        {
            get { return deposito; }
            set { this.deposito = value; }
        }
        public double Saque
        {
            get { return saque; }
            set { this.saque = value; }
        }
        public void addClient(Cliente novoCliente)
        {
            clientes.Add(novoCliente);
        }
        public string sacar(Cliente clienteSaque)
        {
            if (this.Saque > clienteSaque.Saldo)
            {
                string mensagemFalha = "----Saldo Insuficiente----\n";
                mensagemFalha += "Saldo atual: " + clienteSaque.Saldo + "\n";
                mensagemFalha += "Valor Saque: " + this.Saque + "\n";
                return mensagemFalha;
            }
            clienteSaque.Saldo -= this.Saque;
            string Mensagem = "----Saque Realizado----\n";
            Mensagem += "Saldo atual: " + clienteSaque.Saldo + "\n";
            Mensagem += "Valor Saque: " + this.Saque + "\n";
            return Mensagem;

        }
        public string depositar(Cliente clienteDeposito)
        {

            clienteDeposito.Saldo += this.Deposito;
            string mensagemDeposito = "---Deposito Realizado---\n";
            mensagemDeposito += "Valor deposito: R$" + this.Deposito + "\n";
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