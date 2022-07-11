using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class VeiculoFactory
    {
        private ControleDeProducao _controleDeProducao;

        public VeiculoFactory(ControleDeProducao controleDeProducao)
        {
            _controleDeProducao = controleDeProducao;
        }

        public IVeiculo CriarCarro(int potencia, int numeroDePortas, bool ehFlex, string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            // TODO: adicionar validações
            Carro carro = new(potencia, numeroDePortas, ehFlex, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(carro);

            return carro;
        }
    }
}
