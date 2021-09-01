using System;
using System.Collections.Generic;
namespace parteIII.Models
{
    public class Cliente
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string fone { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private double salario { get; set; }
        private DateTime dataNascimento { get; set; }


        public int Id
        {
            get => id;
            set => this.id = value;
        }
        public string Nome
        {
            get => nome;
            set => this.nome = value;
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
        public string Login
        {
            get => login;
            set => this.login = value;
        }
        public string Senha
        {
            get => senha;
            set => this.senha = value;
        }
        public string Cpf
        {
            get => cpf;
            set => this.cpf = value;
        }
        public string Rg
        {
            get => rg;
            set => this.rg = value;
        }
        public double Salario
        {
            get => salario;
            set => this.salario = value;
        }
        public DateTime DataNascimento
        {
            get => dataNascimento;
            set => this.dataNascimento = value;
        }
      

    }
}

