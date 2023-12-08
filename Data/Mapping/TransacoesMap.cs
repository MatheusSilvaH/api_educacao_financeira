using educacao_financeira_api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace educacao_financeira_api.Data.Mapping
{
    public class TransacoesMap : IEntityTypeConfiguration<Transacoes>
    {
        public void Configure(EntityTypeBuilder<Transacoes> builder)
        {
            builder.ToTable("Transacoes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Valor).IsRequired();

            builder.Property(p => p.ContaOrigemId).IsRequired();
            builder.Property(p => p.ContaDestinoId).IsRequired();

            builder.HasOne(p => p.ContaOrigem).WithMany(p => p.Transacoes).HasForeignKey(p => p.ContaOrigemId).OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.HasOne(p => p.ContaDestino).WithMany().HasForeignKey(p => p.ContaDestinoId).OnDelete(DeleteBehavior.NoAction).IsRequired();
        }
        
    }
}