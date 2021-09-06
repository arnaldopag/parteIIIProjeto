using MySqlConnector;

namespace parteIII.Models
{
    public class ContatoRepository
    {
        private const string DadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";
        public void Cadastro(Contato contato)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            const string querySql = "insert into contato (nome,email,texto) VALUES (@nome,@email,@texto)";
            var comando = new MySqlCommand(querySql, conexao);
            comando.Parameters.AddWithValue("@nome", contato.Nome);
            comando.Parameters.AddWithValue("@email", contato.Email);
            comando.Parameters.AddWithValue("@texto", contato.Texto);
            
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}