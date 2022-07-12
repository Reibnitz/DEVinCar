using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class InputInvalidoException : Exception
    {
        private const string Mensagem = "ERRO - Input inválido";

        public InputInvalidoException() : base(Mensagem)
        {

        }
    }
}
