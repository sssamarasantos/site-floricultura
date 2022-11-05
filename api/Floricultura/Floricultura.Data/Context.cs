using Floricultura.Data.Mappers;
using Floricultura.Data.Mappings;
using Floricultura.Domain.Models.Menu;
using Floricultura.Domain.Models.Produto;
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
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoFoto> ProdutoFoto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new SubMenuMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new ProdutoFotoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
