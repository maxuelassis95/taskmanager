using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities;

namespace TaskManager.Infrastructure.Data.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable<Tarefa>("tarefas");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Titulo).
                IsRequired();

            builder.Property(t => t.Descricao)
                .IsRequired();

            builder.Property(t => t.DataCriacao)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        }
    }
}