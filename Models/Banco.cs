using parteIII.Models;

namespace parteIII.Models
{
    public static class Banco
    {

        public static double sacar(double valorSaque)
        {
            if (valorSaque > Conta.Saldo)
            {
                return null;
            }
            double valorFinal = valorSaque - Conta.Saldo;
            return valorFinal;
        }
        public static string depositar(double valorDeposito)
        {
            double valorFinal = valorDeposito + Conta.Saldo;
            return valorFinal;
        }
    }
}