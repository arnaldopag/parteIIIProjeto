using System;
namespace parteIII.Models
{
    public class Candidato
    {
        private string nome { get; set; }
        private string email { get; set; }
        private string fone { get; set; }
        private DateTime dataNascimento { get; set; }

        public string Nome
        {
            get => nome;
            set => nome = value; 
        }
        public string Email
        {
            get => email;
            set => this.email = value;
        }
        public string Fone
        {
            get => fone;
            set => this.fone = value;
        }
        public DateTime DataNascimento
        {
            get => dataNascimento;
            set => this.dataNascimento = value;
        }

    }
}