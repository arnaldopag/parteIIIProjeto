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
        public void sacar(Cliente clienteSaque)
        {

        }
        public void depositar(Cliente clienteDeposito, double valorDeposito)
        {

            clienteDeposito.Saldo += valorDeposito;

        }


    }
}