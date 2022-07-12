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

        public IVeiculo CriarCarro(int potencia, int numeroDePortas, bool ehFlex,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            // TODO: adicionar validações
            Carro carro = new(potencia, numeroDePortas, ehFlex, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(carro);

            return carro;
        }

        public IVeiculo CriarMotoTriciclo(int potencia, int numeroDeRodas,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            // TODO: adicionar validações
            MotoTriciclo motoTriciclo = new(potencia, numeroDeRodas, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(motoTriciclo);

            return motoTriciclo;
        }

        public IVeiculo CriarCamionete(int numeroDePortas, int capacidadeDaCacamba, int potencia, string tipoCombustivel,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            // TODO: adicionar validações
            Camionete camionete = new(numeroDePortas, capacidadeDaCacamba, potencia, tipoCombustivel, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(camionete);

            return camionete;
        }
    }
}
