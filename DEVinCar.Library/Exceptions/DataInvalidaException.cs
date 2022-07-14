namespace DEVinCar.Library
{
    public class DataInvalidaException : Exception
    {
        private const string Mensagem = "ERRO - A data de fabricação não pode ser maior que a data atual";

        public DataInvalidaException() : base(Mensagem)
        {

        }
    }
}
