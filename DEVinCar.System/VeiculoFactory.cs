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

        public IVeiculo CriarCarro(int potencia, int numeroDePortas, ETipoCombustivelCarro tipoCombustivel,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            VerificarData(dataDeFabricacao);
            VerificarSeValorEhPositivo(potencia, numeroDePortas, valor);
            
            Carro carro = new(potencia, numeroDePortas, tipoCombustivel, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(carro);

            return carro;
        }

        public IVeiculo CriarMotoTriciclo(int potencia, int numeroDeRodas,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            VerificarData(dataDeFabricacao);
            VerificarSeValorEhPositivo(potencia, valor);
            
            MotoTriciclo motoTriciclo = new(potencia, numeroDeRodas, nome, placa, valor, cor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(motoTriciclo);

            return motoTriciclo;
        }

        public IVeiculo CriarCamionete(int numeroDePortas, int capacidadeDaCacamba, int potencia, ETipoCombustivelCamionete tipoCombustivel,
            string nome, string placa, double valor, DateTime dataDeFabricacao)
        {
            VerificarData(dataDeFabricacao);
            VerificarSeValorEhPositivo(potencia, numeroDePortas, valor, capacidadeDaCacamba);
            
            Camionete camionete = new(numeroDePortas, capacidadeDaCacamba, potencia, tipoCombustivel, nome, placa, valor, dataDeFabricacao);
            _controleDeProducao.AdicionarVeiculo(camionete);

            return camionete;
        }

        private void VerificarData(DateTime dataDeFabricacao)
        {
            if (dataDeFabricacao > DateTime.Now)
                throw new ArgumentException("ERRO - A data de fabricação não pode ser maior que a data atual", nameof(dataDeFabricacao));
        }

        private void VerificarSeValorEhPositivo(params double[] valores)
        {
            foreach (var valor in valores)
            {
                if (valor <= 0)
                    throw new ArgumentOutOfRangeException($"O valor de {nameof(valor)} deve ser maior que zero", nameof(valor));
            }
        }
    }
}
