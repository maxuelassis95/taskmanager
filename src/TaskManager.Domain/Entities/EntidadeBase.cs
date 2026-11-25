namespace TaskManager.Domain.Entities
{
    public class EntidadeBase
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool Ativo { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public EntidadeBase(Guid id, bool ativo, DateTime dataCriacao)
        {
            Id = id;
            Ativo = ativo;
            DataCriacao = dataCriacao;
        }
    }
}