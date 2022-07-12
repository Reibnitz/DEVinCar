using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class OpcaoNaoExistenteException : Exception
    {
        private const string Mensagem = "ERRO - Opção {0} não é válida";

        public OpcaoNaoExistenteException(int opcaoEscolhida) : base(string.Format(Mensagem, opcaoEscolhida))
        {

        }
    }
}
