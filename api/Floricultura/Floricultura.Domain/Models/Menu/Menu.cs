namespace Floricultura.Domain.Models.Menu
{
    public class Menu
    {
        public int Id { get; set; }
        public string? Item { get; set; }
        public string? Rota { get; set; }
        public int Ordem { get; set; }
        public IEnumerable<SubMenu>? SubMenus { get; set; }
    }
}
