namespace parteIII.Models
{
    public class Conta
    {
        private int id_conta { get; set; }
        private int numeroConta { get; set; }
        private int agencia { get; set; }
        private double saldo { get; set; }
        private double valorDeposito { get; set; }
        private double valorSaque { get; set; }

        public int Id_conta
        {
            get => id_conta;
            set => id_conta = value;
        }

        public int NumeroConta
        {
            get => numeroConta;
            set => numeroConta = value;
        }
        public int Agencia
        {
            get => agencia;
            set => agencia = value;
        }
        public double Saldo
        {
            get => saldo;
            set => saldo = value;
        }
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

        public double Sacar(Conta setSaldo)
        {
            if (this.valorSaque > setSaldo.Saldo){
                return -1;
            }
            double saldoFinal = setSaldo.Saldo - this.valorSaque;
            return saldoFinal;


        }
        public double Depositar(Conta setSaldo)
        {
            double saldoFinal = setSaldo.saldo + this.saldo;
            return saldoFinal;
        }
    }
}