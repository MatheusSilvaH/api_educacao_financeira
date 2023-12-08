using educacao_financeira_api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace educacao_financeira_api.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(p => p.Nascimento).IsRequired(false).HasMaxLength(8);
            builder.Property(p => p.Endereco).IsRequired();
            builder.Property(p => p.Email).IsRequired(false).HasMaxLength(100);
            builder.Property(p => p.CpfResponsavel).IsRequired().HasMaxLength(11);
            builder.Property(p => p.NomeResponsavel).IsRequired();
            builder.Property(p => p.TelefoneResponsavel).IsRequired(false).HasMaxLength(12);

        }
        
    }
}