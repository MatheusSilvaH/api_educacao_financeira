using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mappings
{
    public class UsuariosMap : EntityMap<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");
            builder.Property(p => p.Nome).IsRequired(); 
            builder.Property(p => p.Cpf).IsRequired().HasMaxLength(11); 
            builder.Property(p => p.DataNascimento).IsRequired(); 
            builder.Property(p => p.Endereco).IsRequired(); 
            builder.Property(p => p.Email).IsRequired(); 
            builder.Property(p => p.CpfResponsavel).IsRequired().HasMaxLength(11); 
            builder.Property(p => p.NomeResponsavel).IsRequired(); 
            builder.Property(p => p.TelefoneResponsavel).IsRequired();            
        }
    }
}
