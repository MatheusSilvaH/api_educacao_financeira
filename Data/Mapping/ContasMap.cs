using educacao_financeira_api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace educacao_financeira_api.Data.Mapping
{
    public class ContasMap : IEntityTypeConfiguration<Contas>
    {
        public void Configure(EntityTypeBuilder<Contas> builder)
        {
            builder.ToTable("Contas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Saldo).IsRequired();

            builder.Property(p => p.UsuarioId).IsRequired();

            builder.HasOne(p => p.Usuario).WithMany(p=> p.Contas).HasForeignKey(p => p.UsuarioId).IsRequired(false);
        }
        
    }
}