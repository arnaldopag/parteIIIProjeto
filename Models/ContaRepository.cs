using MySqlConnector;
namespace parteIII.Models
{
    public class ContaRepository
    {
        private const string DadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";
        public void Cadastro(Conta newConta)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "insert into cliente (agencia,numero_conta,saldo) values (@agencia,@numero_conta,@saldo)";
            var comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@agencia", newConta.Agencia);
            comando.Parameters.AddWithValue("@numero_conta",newConta.NumeroConta );
            comando.Parameters.AddWithValue("@saldo", newConta.Saldo);
           
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
    }
}