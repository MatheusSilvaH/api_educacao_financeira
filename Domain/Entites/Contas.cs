using Domain.Base;
using System;


namespace Domain.Entities
{
    public class Contas : Entity
    {           
        public decimal? Saldo { get; set; }
        public Guid? UsuarioId { get; set; }       
        public Guid? TransacoesId { get; set; }

        public virtual Usuarios Usuarios { get; set; } = null!;      
        public virtual Transacoes Transacoes { get; set; } = null!;      
        
    }
}