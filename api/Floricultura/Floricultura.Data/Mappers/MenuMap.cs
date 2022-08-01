using Floricultura.Domain.Models.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Floricultura.Data.Mappings
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Item).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Route).IsRequired().HasMaxLength(100);
            builder.HasMany(x => x.SubMenus).WithOne().HasForeignKey(x => x.IdMenu);
        }
    }
}
