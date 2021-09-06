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
            const string querySql = "insert into cliente (nome,email,fone,login,senha,cpf,rg,salario,dataNascimento,agencia,numero_conta,saldo) values (@nome,@email,@fone,@login,@senha,@cpf,@rg,@salario,@dataNascimento,@agencia,@numero_conta,@saldo)";
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
            comando.Parameters.AddWithValue("@agencia", user.Agencia);
            comando.Parameters.AddWithValue("@numero_conta", user.Numero_conta );
            comando.Parameters.AddWithValue("@saldo", user.Saldo);
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
                clienteEncontrado.Id_cliente = Reader.GetInt32("Id_cliente");

                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                    clienteEncontrado.Nome = Reader.GetString("nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("login")))
                    clienteEncontrado.Login = Reader.GetString("login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("senha")))
                    clienteEncontrado.Senha = Reader.GetString("senha");
                if (!Reader.IsDBNull(Reader.GetOrdinal("agencia")))
                    clienteEncontrado.Agencia = Reader.GetInt32("agencia");
                if (!Reader.IsDBNull(Reader.GetOrdinal("numero_conta")))
                    clienteEncontrado.Numero_conta = Reader.GetInt32("numero_conta");
                if (!Reader.IsDBNull(Reader.GetOrdinal("saldo")))
                    clienteEncontrado.Saldo = Reader.GetDouble("saldo");

                clienteEncontrado.DataNascimento = Reader.GetDateTime("dataNascimento");
            }

            conexao.Close();
            return clienteEncontrado;
        }

        public Cliente EncontrarCliente(int id)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "select * from cliente WHERE id_cliente=@id";
            var comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            var clienteEncontrado = new Cliente();
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()){
                clienteEncontrado.Id_cliente = reader.GetInt32("id_cliente");
                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    clienteEncontrado.Nome = reader.GetString("nome");
                if (!reader.IsDBNull(reader.GetOrdinal("cpf")))
                    clienteEncontrado.Cpf = reader.GetString("cpf");
                if (!reader.IsDBNull(reader.GetInt32("agencia")))
                    clienteEncontrado.Agencia = reader.GetInt32("agencia");
                if (!reader.IsDBNull(reader.GetInt32("numero_conta")))
                    clienteEncontrado.Numero_conta = reader.GetInt32("numero_conta");
                if (!reader.IsDBNull(reader.GetOrdinal("saldo")))
                    clienteEncontrado.Saldo = reader.GetDouble("saldo");
                clienteEncontrado.DataNascimento = reader.GetDateTime("dataNascimento");
            }

            return clienteEncontrado;
        }
        public void Deposito(Cliente cliente,double valorSaldo)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "UPDATE cliente SET saldo=@saldo WHERE id_cliente=@id";
            MySqlCommand comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@id", cliente.Id_cliente);
            comando.Parameters.AddWithValue("@saldo", valorSaldo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Saque(Cliente cliente,double valorSaldo)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "UPDATE cliente SET saldo=@saldo WHERE id_cliente=@id";
            MySqlCommand comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@id", cliente.Id_cliente);
            comando.Parameters.AddWithValue("@saldo", valorSaldo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}