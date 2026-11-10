namespace TaskManager.Domain.Exceptions
{
    public class EmailOuSenhaInvalidoException : Exception
    {
        public EmailOuSenhaInvalidoException(string mensagem) : base (mensagem)
        {

        }
    }
}