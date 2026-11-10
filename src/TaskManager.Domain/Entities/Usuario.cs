using TaskManager.Domain.Exceptions;
using BCrypt.Net;

namespace TaskManager.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public Usuario(Guid id, bool active, DateTime dataCriacao, string nome, string email, string password) : base (id, active, dataCriacao)
        {
            if(email.IsWhiteSpace())
            {
                throw new EmailOuSenhaInvalidoException("Email inválidos");
            }

            if(password is null)
            {
                throw new EmailOuSenhaInvalidoException("Senha inválida");
            }

            if(Nome.IsWhiteSpace())
            {
                throw new ArgumentException("Nome incorreto");
            }

            var hashPassword = BCrypt.Net.BCrypt.HashPassword(password);

            Password = hashPassword;
        }
    }
}