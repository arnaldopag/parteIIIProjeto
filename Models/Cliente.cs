using System;
using System.Collections.Generic;
namespace parteIII.Models
{
    public class Cliente
    {
        private int id { get;  }
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
            get { return id; }
        }
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
        public string Login
        {
            get { return login; }
            set { this.login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { this.cpf = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { this.rg = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { this.salario = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { this.dataNascimento = value; }
        }
      

    }
}

