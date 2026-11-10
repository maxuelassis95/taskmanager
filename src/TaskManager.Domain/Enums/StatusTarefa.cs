using System.ComponentModel.DataAnnotations;

namespace TaskManager.Domain.Enums
{
    public enum StatusTarefa
    {
        [Display(Name = "Tarefa pendente")]
        Pendente = 0,

        [Display(Name = "Tarefa em execução")]        
        Executando = 1,
        
        [Display(Name = "Tarefa finalizada")]
        Finalizada = 2,

        [Display(Name = "Tarefa cancelada")]
        Cancelada = 3
    }
}