using TaskManager.Domain.Exceptions;
using BCrypt.Net;

namespace TaskManager.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; private set; }

        // Propriedade de navageção
        public Tarefa Tarefas { get; set; }
        public Usuario(Guid id, bool ativo, DateTime dataCriacao, string nome, string email, string senha) : base (id, ativo, dataCriacao)
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

            var hashSenha = BCrypt.Net.BCrypt.HashPassword(senha);

            Senha = hashSenha;
        }
    }
}