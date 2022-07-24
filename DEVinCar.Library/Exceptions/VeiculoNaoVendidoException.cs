using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class VeiculoNaoVendidoException : Exception
    {
        private const string Mensagem = "ERRO - Veículo {0} de chassi número {1} não foi vendido";

        public VeiculoNaoVendidoException(string nome, int chassi) : base(string.Format(Mensagem, nome, chassi))
        {
            
        }
    }
}
