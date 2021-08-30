using System.Collections.Generic;
namespace parteIII.Models
{
    public class Banco
    {
        private static List<Cliente> clientes = new List<Cliente>();

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
    }
}