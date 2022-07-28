namespace Floricultura.Domain.Models.Menu
{
    public class SubMenu : Menu
    {
        public int IdMenu { get; set; }
        public Menu Menu { get; set; }
    }
}
