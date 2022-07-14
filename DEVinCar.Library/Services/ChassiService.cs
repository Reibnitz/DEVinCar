using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class ChassiService
    {
        public int GerarNumero()
        {
            string chassiTexto = "";

            while (chassiTexto.Count() < 9)
            {
                chassiTexto += new Random().Next(10);
            }

            int chassiNumero = int.Parse(chassiTexto);

            return chassiNumero;
        }

        public bool VerificarNumero(int numeroChassi, IEnumerable<IVeiculo> listaVeiculos)
        {
            IVeiculo? buscaDeVeiculo = listaVeiculos.FirstOrDefault(veiculo => veiculo.NumeroChassi == numeroChassi);

            bool ehUnico = buscaDeVeiculo == null;

            return ehUnico;
        }
    }
}
