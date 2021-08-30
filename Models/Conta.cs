namespace parteIII.Models
{
    public static class Conta
    {
        public static Banco cliente { get; set; }
        static Conta()
        {
            cliente = new Banco();
        }
    }
}