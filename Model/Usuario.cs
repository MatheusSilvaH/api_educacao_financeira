using educacao_financeira_api.Model.Base;


namespace educacao_financeira_api.Model
{
    public class Usuario : Entity
        {
            public string Nome { get; set; } = null!;
            public string Cpf { get; set; } = null!;
            public DateTime? Nascimento { get; set; }
            public string Endereco { get; set; } = null!;
            public string Email { get; set; }
            public string CpfResponsavel { get; set; } = null!;
            public string? NomeResponsavel { get; set; } = null!;
            public string? TelefoneResponsavel { get; set; }

            public virtual IList<Contas> Contas { get; set; } = new List<Contas>();
        }
}