using Domain.Base;
using System;


namespace Domain.Entities
{
    public class Transacoes : Entity
    {           
        public decimal? Valor { get; set; }        
        public Guid? ContaOrigemId { get; set; }       
        public Guid? ContaDestinoId { get; set; }

        public virtual Contas Contas { get; set; } = null!;     
         
        
    }
}