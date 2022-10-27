namespace Floricultura.Domain.Models.Menu
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string? Item { get; set; }
        public string? Rota { get; set; }
        public int Ordem { get; set; }
        public int IdMenu { get; set; }
    }
}
