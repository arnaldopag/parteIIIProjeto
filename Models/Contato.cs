namespace parteIII.Models
{
    public class Contato
    {
        private string nome { get; set; }
        private string email { get; set; }
        private string texto { get; set; }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Texto
        {
            get => texto;
            set => texto = value;
        }
    }
}
