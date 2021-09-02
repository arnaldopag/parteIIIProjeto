using MySqlConnector;
using System.Collections.Generic;
using System;


namespace parteIII.Models
{
    public class ClienteRepository
    {
        private const string DadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";

        public void Cadastro(Cliente user)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "insert into cliente (nome,email,fone,login,senha,cpf,rg,salario,dataNascimento) values (@nome,@email,@fone,@login,@senha,@cpf,@rg,@salario,@dataNascimento)";
            var comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@nome", user.Nome);
            comando.Parameters.AddWithValue("@email", user.Email);
            comando.Parameters.AddWithValue("@fone", user.Fone);
            comando.Parameters.AddWithValue("@login", user.Login);
            comando.Parameters.AddWithValue("@senha", user.Senha);
            comando.Parameters.AddWithValue("@cpf", user.Cpf);
            comando.Parameters.AddWithValue("@rg", user.Rg);
            comando.Parameters.AddWithValue("@salario", user.Salario);
            comando.Parameters.AddWithValue("@dataNascimento", user.DataNascimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
        public Cliente Login(Cliente clienteLogin)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "select * from cliente WHERE login=@login and senha=@senha";
            var comando = new MySqlCommand(querySql, conexao);


            comando.Parameters.AddWithValue("@login", clienteLogin.Login);
            comando.Parameters.AddWithValue("@senha", clienteLogin.Senha);


            MySqlDataReader Reader = comando.ExecuteReader();

            Cliente clienteEncontrado = null;

            if (Reader.Read())
            {
                clienteEncontrado = new Cliente();
                clienteEncontrado.Id_cliente = Reader.GetInt32("id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                    clienteEncontrado.Nome = Reader.GetString("nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("login")))
                    clienteEncontrado.Login = Reader.GetString("login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("senha")))
                    clienteEncontrado.Senha = Reader.GetString("senha");

                clienteEncontrado.DataNascimento = Reader.GetDateTime("dataNascimento");
            }

            conexao.Close();
            return clienteEncontrado;
        }
    }
}