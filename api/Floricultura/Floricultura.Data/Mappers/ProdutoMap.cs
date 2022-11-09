using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Floricultura.Domain.Models.Produto;

namespace Floricultura.Data.Mappers
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Descricao).HasMaxLength(500);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Quantidade).IsRequired();
            builder.HasMany(x => x.Fotos).WithOne(x => x.Produto);
            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);
        }
    }
}
