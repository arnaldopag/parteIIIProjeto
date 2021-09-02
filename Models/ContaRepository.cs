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

        public Conta LocalizarConta(int id)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "select * from conta WHERE id_cliente=@id";
            MySqlCommand Comando = new MySqlCommand(querySql, conexao);
            Comando.Parameters.AddWithValue("@Id", id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            var contaEncontrada = new Conta();
            if (Reader.Read())
            {
                contaEncontrada.Id_conta = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Agencia")))
                    contaEncontrada.Agencia = Reader.GetInt32("Agencia");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    contaEncontrada.NumeroConta = Reader.GetInt32("NumeroConta");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Saldo")))
                    contaEncontrada.Saldo = Reader.GetDouble("Saldo");
            }
            conexao.Close();
            return contaEncontrada;
        }

        public void Deposito(Conta conta,double valorSaldo)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "UPDATE conta SET saldo=@saldo WHERE id_conta=@id";
            MySqlCommand comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@id", conta.Id_conta);
            comando.Parameters.AddWithValue("@saldo", valorSaldo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void Saque(Conta conta,double valorSaldo)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "UPDATE conta SET saldo=@saldo WHERE id_conta=@id";
            MySqlCommand comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@id", conta.Id_conta);
            comando.Parameters.AddWithValue("@saldo", valorSaldo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}