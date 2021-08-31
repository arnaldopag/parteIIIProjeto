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
            get { return nome; }
            set { this.nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { this.fone = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { this.dataNascimento = value; }
        }

    }
}