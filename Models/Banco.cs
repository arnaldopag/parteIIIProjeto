namespace parteIII.Models
{
    public class Banco
    {
        private double valorDeposito { get; set; }
        private double valorSaque { get; set; }
        
        public double ValorDeposito
        {
            get => valorDeposito;
            set => valorDeposito = value;
        }
        public double ValorSaque
        {
            get => valorSaque;
            set => valorSaque = value;
        }

        public double Sacar()
        {
            if (valorSaque > Conta.Saldo){
                return -1;
            }
            double valorFinal = this.valorSaque - Conta.Saldo;
            return valorFinal;
        }
        public double Depositar()
        {
            Conta.Saldo += this.valorDeposito;
            return Conta.Saldo;
        }
    }
}