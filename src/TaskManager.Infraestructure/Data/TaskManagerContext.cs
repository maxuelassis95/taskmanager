using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using TaskManager.Domain.Entities;

namespace TaskManager.Infrastructure.Data
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        // Construtor do context precisa receber a config [que é passada por DI no Program.cs]
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagerContext).Assembly);
        }
    }
} 