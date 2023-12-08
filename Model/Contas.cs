using educacao_financeira_api.Model.Base;

namespace educacao_financeira_api.Model
{
    public class Contas : Entity
        {
            public decimal Saldo { get; set; }
            public Guid? UsuarioId { get; set;}

            public virtual Usuario Usuario { get; set; } = null!;
            public virtual IList<Transacoes> Transacoes { get; set; } = new List<Transacoes>();
        }
}