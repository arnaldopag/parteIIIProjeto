using MySqlConnector;
using System.Collections.Generic;
using System;
using parteIII.Models;
namespace parteIII.Models
{
    public class BancoRepository
    {
        private const string DadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";
        public BancoRepository Login(Cliente clienteLogin)
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