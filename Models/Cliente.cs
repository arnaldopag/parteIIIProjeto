using System;
using System.Collections.Generic;
namespace parteIII.Models
{
    public class Cliente
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private double salario { get; set; }
        private DateTime dataNascimento { get; set; }
        private int numeroConta { get; set; }
        private int agencia { get; set; }
        private double saldo { get; set; }

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
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
        public int NumeroConta
        {
            get { return numeroConta; }
            set { this.numeroConta = value; }
        }
        public int Agencia
        {
            get { return agencia; }
            set { this.agencia = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { this.saldo = value; }
        }

    }
}

