using TaskManager.Domain.Exceptions;
using BC = BCrypt.Net;

namespace TaskManager.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; private set; }

        // Propriedade de navageção precisa ser tipo ICollection e ser inicializada
        public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
        public Usuario(Guid id, bool ativo, DateTime dataCriacao, string nome, 
            string email, string senha) : base (id, ativo, dataCriacao)
        {
            if(email.IsWhiteSpace())
            {
                throw new EmailOuSenhaInvalidoException("Email inválidos");
            }

            if(senha is null)
            {
                throw new EmailOuSenhaInvalidoException("Senha inválida");
            }

            if(Nome.IsWhiteSpace())
            {
                throw new ArgumentException("Nome incorreto");
            }

            var hashSenha = BC.BCrypt.HashPassword(senha);

            Senha = hashSenha;
        }
    }
}