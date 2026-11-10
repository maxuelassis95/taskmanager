namespace TaskManager.Domain.Entities
{
    public class EntidadeBase
    {
        protected Guid Id { get; private set; } = Guid.NewGuid();
        protected bool Active { get; private set; }
        protected DateTime DataCriacao { get; private set; }

        protected EntidadeBase(Guid id, bool active, DateTime dataCriacao)
        {
            Id = id;
            Active = active;
            DataCriacao = dataCriacao;
        }
    }
}