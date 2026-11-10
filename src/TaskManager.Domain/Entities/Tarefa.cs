using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities
{
    public class Tarefa : EntidadeBase
    {

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public StatusTarefa StatusTarefa{ get; set; }
        
        // Propriedade de navageção 
        public Usuario Usuario { get; set; }

        public Tarefa(Guid id, bool ativo, DateTime dataCriacao, string titulo, 
            string descricao, StatusTarefa statusTarefa) : base(id, ativo, dataCriacao)
        {
            Titulo = titulo;
            Descricao = descricao;
            StatusTarefa = statusTarefa;
        }
    }
}