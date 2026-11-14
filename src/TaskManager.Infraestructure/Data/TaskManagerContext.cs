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
            // define o nome da tabela, a chave primaria
            modelBuilder.Entity<Usuario>(entity => {
                entity.ToTable("usuarios");
                entity.HasKey(u => u.Id);

                // define o relacionamento
                entity.HasMany<Tarefa>(u => u.Tarefas)
                .WithOne(t => t.Usuario)
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

                // Guid também é criado automatica pelo EF Core
                // informa que o Id é tem a coluna com tipo binary(16) pode ser que o Pomelo mantenha maior, informando assim pode economizar byte
                entity.Property(u => u.Id)
                .HasColumnType("binary(16)");

                entity.Property(u => u.Nome)
                .IsRequired();

                entity.Property(u => u.Senha)
                .IsRequired();

                entity.Property(u => u.Senha)
                .IsRequired();

                entity.Property(u => u.Ativo)
                .IsRequired();

                entity.Property(u => u.DataCriacao)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });
        }
    }
} 