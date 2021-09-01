namespace parteIII.Models
{
    public class CandidatoRepository
    {
        private const string DadosConexao = "Database=parte_iii; Data Source=localhost;User id=root";
        public void Cadastro(Candidato candidato)
        {
            var conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            String QuerySql = "insert into candidato (nome,email,fone,dataNascimento)";
            QuerySql += "values (@nome,@email,@fone,@dataNascimento)";
            var comando = new MySqlCommand(QuerySql, conexao);
            comando.Parameters.AddWithValue("@nome", candidato.Nome);
            comando.Parameters.AddWithValue("@email", candidato.Email);
            comando.Parameters.AddWithValue("@fone", candidato.Fone);
            comando.Parameters.AddWithValue("@dataNascimento", candidato.DataNascimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}