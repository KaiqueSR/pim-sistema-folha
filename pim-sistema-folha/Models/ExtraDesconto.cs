namespace pim_sistema_folha.Models
{
    public class ExtraDesconto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int IdFolha { get; set; }
    }
}
