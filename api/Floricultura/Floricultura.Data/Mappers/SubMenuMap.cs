using Floricultura.Domain.Models.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Floricultura.Data.Mappings
{
    public class SubMenuMap : IEntityTypeConfiguration<SubMenu>
    {
        public void Configure(EntityTypeBuilder<SubMenu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Item).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Rota).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Ordem).IsRequired();
            builder.Property(x => x.IdMenu).IsRequired();
        }
    }
}
