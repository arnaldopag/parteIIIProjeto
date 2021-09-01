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
            String QuerySql = "insert into cliente (nome,email,fone,login,senha,cpf,rg,salario,dataNascimento)";
            QuerySql += "values (@nome,@email,@fone,@login,@senha,@cpf,@rg,@salario,@dataNascimento)";
            var comando = new MySqlCommand(QuerySql, conexao);
            comando.Parameters.AddWithValue("@nome", user.Nome);
            comando.Parameters.AddWithValue("@nome", user.Email);
            comando.Parameters.AddWithValue("@nome", user.Fone);
            comando.Parameters.AddWithValue("@login", user.Login);
            comando.Parameters.AddWithValue("@senha", user.Senha);
            comando.Parameters.AddWithValue("@nome", user.Cpf);
            comando.Parameters.AddWithValue("@nome", user.Rg);
            comando.Parameters.AddWithValue("@nome", user.Salario);
            comando.Parameters.AddWithValue("@dataNascimento", user.DataNascimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
        public ClienteRepository Login(Cliente clienteLogin)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            String QuerySql = "select * from cliente WHERE login=@login and senha=@senha";
            var comando = new MySqlCommand(QuerySql, Conexao);


            comando.Parameters.AddWithValue("@login", clienteLogin.Login);
            comando.Parameters.AddWithValue("@senha", clienteLogin.Senha);


            MySqlDataReader Reader = comando.ExecuteReader();

            Cliente clienteEncontrado = null;

            if (Reader.Read())
            {
                clienteEncontrado = new Cliente();
                clienteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");

                clienteEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            conexao.Close();
            return clienteEncontrado;
        }
    }
}