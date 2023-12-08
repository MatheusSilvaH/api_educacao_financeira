using educacao_financeira_api.Model.Base;

namespace educacao_financeira_api.Model
{
    public class Transacoes : Entity
        {
            public decimal Valor { get; set; }
            public Guid? ContaOrigemId { get; set; }
            public Guid? ContaDestinoId { get; set; }

            public virtual Contas ContaOrigem { get; set; } = null!;
            public virtual Contas ContaDestino { get; set; } = null!;
        }
}