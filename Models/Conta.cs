namespace parteIII.Models
{
    public class Conta
    {
        private int id_conta { get; set; }
        private int numeroConta { get; set; }
        private int agencia { get; set; }
        private double saldo { get; set; }

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
    }
}