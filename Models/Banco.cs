using parteIII.Models;
namespace parteIIIProjeto.Models
{
    namespace parteIII.Models
    {
        public class Banco {
            
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

            public double Sacar(Conta setSaldo)
            {
                if (this.valorSaque > setSaldo.Saldo){
                    return -1;
                }
                return setSaldo.Saldo -= this.valorSaque;


            }
            public double Depositar(Conta setSaldo)
            {
                setSaldo.Saldo += this.valorDeposito;
                
                return setSaldo.Saldo;
            }
        }
    }
 }
