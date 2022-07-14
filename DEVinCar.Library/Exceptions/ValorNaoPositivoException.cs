namespace DEVinCar.Library
{
    public class ValorNaoPositivoException : Exception
    {
        private const string Mensagem = "ERRO - A propriedade '{0}' não pode possuir valor negativo. Valor informado: {1}";

        public ValorNaoPositivoException(string argumento, double valor) : base(string.Format(Mensagem, argumento, valor))
        {

        }
    }
}
