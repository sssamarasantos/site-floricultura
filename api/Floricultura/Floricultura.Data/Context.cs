using Floricultura.Data.Mappings;
using Floricultura.Domain.Models.Menu;
using Microsoft.EntityFrameworkCore;

namespace Floricultura.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<SubMenu> SubMenu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new SubMenuMap());
        }
    }
}
