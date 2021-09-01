using MySqlConnector;
using System.Collections.Generic;
using System;


namespace parteIII.Models
{
    public class ClienteRepository
    {
         private  const string dadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";
         
         public void Inserir(Cliente user)
         {
             var conexao = new MySqlConnection(dadosConexao);
             conexao.Open();
             String QuerySql = "insert into Usuario (Nome,Login,Senha,DataNascimento) values (@Nome,@Login,@Senha,@DataNascimento)";
             var comando = new MySqlCommand(QuerySql, conexao);
             comando.Parameters.AddWithValue("@Nome", user.Nome);
             comando.Parameters.AddWithValue("@Login", user.Login);
             comando.Parameters.AddWithValue("@Senha", user.Senha);
             comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);
             comando.ExecuteNonQuery();
             conexao.Close();
         }
    }
}