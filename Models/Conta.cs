namespace parteIII.Models
{
    public class Conta
    {
        private int id_conta { get; }
        private int numeroConta { get; set; }
        private int agencia { get; set; }
        private double saldo { get; set; }

        public int Id_conta => id_conta;

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