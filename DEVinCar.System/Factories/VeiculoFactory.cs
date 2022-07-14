using DEVinCar.Library;

namespace DEVinCar.System
{
    public class VeiculoFactory : IVeiculoFactory
    {
        private IControleDeProducao _controleDeProducao;
        private ChassiService _chassiService;

        public VeiculoFactory(IControleDeProducao controleDeProducao)
        {
            _controleDeProducao = controleDeProducao;
            _chassiService = new ChassiService();
        }

        public IVeiculo CriarCarro(int potencia, int numeroDePortas, ETipoCombustivelCarro tipoCombustivel,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            if (dataDeFabricacao > DateTime.Now) throw new DataInvalidaException();
            if (potencia <= 0) throw new ValorNaoPositivoException(nameof(potencia), potencia);
            if (numeroDePortas <= 0) throw new ValorNaoPositivoException(nameof(numeroDePortas), numeroDePortas);
            if (valor <= 0) throw new ValorNaoPositivoException(nameof(valor), valor);

            Carro carro = new(potencia, numeroDePortas, tipoCombustivel, nome, placa, valor, cor, dataDeFabricacao);

            carro.NumeroChassi = GerarNumeroChassi(carro);
            _controleDeProducao.AdicionarVeiculo(carro);

            return carro;
        }

        public IVeiculo CriarMotoTriciclo(int potencia, int numeroDeRodas,
            string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            if (dataDeFabricacao > DateTime.Now) throw new DataInvalidaException();
            if (potencia <= 0) throw new ValorNaoPositivoException(nameof(potencia), potencia);
            if (valor <= 0) throw new ValorNaoPositivoException(nameof(valor), valor);

            MotoTriciclo motoTriciclo = new(potencia, numeroDeRodas, nome, placa, valor, cor, dataDeFabricacao);

            motoTriciclo.NumeroChassi = GerarNumeroChassi(motoTriciclo);
            _controleDeProducao.AdicionarVeiculo(motoTriciclo);

            return motoTriciclo;
        }

        public IVeiculo CriarCamionete(int numeroDePortas, int capacidadeDaCacamba, int potencia, ETipoCombustivelCamionete tipoCombustivel,
            string nome, string placa, double valor, DateTime dataDeFabricacao)
        {
            if (dataDeFabricacao > DateTime.Now) throw new DataInvalidaException();
            if (potencia <= 0) throw new ValorNaoPositivoException(nameof(potencia), potencia);
            if (numeroDePortas <= 0) throw new ValorNaoPositivoException(nameof(numeroDePortas), numeroDePortas);
            if (valor <= 0) throw new ValorNaoPositivoException(nameof(valor), valor);
            if (valor <= 0) throw new ValorNaoPositivoException(nameof(capacidadeDaCacamba), capacidadeDaCacamba);

            Camionete camionete = new(numeroDePortas, capacidadeDaCacamba, potencia, tipoCombustivel, nome, placa, valor, dataDeFabricacao);

            camionete.NumeroChassi = GerarNumeroChassi(camionete);
            _controleDeProducao.AdicionarVeiculo(camionete);

            return camionete;
        }

        private int GerarNumeroChassi(IVeiculo veiculo)
        {
            int numeroChassi = _chassiService.GerarNumero();
            bool chassiEhUnico = _chassiService.VerificarNumero(numeroChassi, _controleDeProducao.ListaDeVeiculos);

            while (!chassiEhUnico)
            {
                numeroChassi = _chassiService.GerarNumero();
                chassiEhUnico = _chassiService.VerificarNumero(numeroChassi, _controleDeProducao.ListaDeVeiculos);
            }

            return numeroChassi;
        }
    }
}
