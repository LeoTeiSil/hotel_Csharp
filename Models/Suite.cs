namespace ProjetoHotel.Models
{
    public class Suite
    {
        public required string Tipo { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}