using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Floricultura.Domain.Models.Produto;

namespace Floricultura.Data.Mappers
{
    public class ProdutoFotoMap : IEntityTypeConfiguration<ProdutoFoto>
    {
        public void Configure(EntityTypeBuilder<ProdutoFoto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Foto).IsRequired().HasMaxLength(1000);
            builder.HasOne(x => x.Produto).WithMany(x => x.Fotos).HasForeignKey(x => x.IdProduto);
        }
    }
}
