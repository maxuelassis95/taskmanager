namespace TaskManager.Domain.Entities
{
    public class EntidadeBase
    {
        protected Guid Id { get; private set; } = Guid.NewGuid();
        protected bool Ativo { get; private set; }
        protected DateTime DataCriacao { get; private set; }

        protected EntidadeBase(Guid id, bool ativo, DateTime dataCriacao)
        {
            Id = id;
            Ativo = ativo;
            DataCriacao = dataCriacao;
        }
    }
}