using System.ComponentModel.DataAnnotations.Schema;

namespace Floricultura.Domain.Models.Menu
{
    [Table("Menu")]
    public class Menu
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Route { get; set; }
    }
}
