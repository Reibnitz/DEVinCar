using DEVinCar.Library;

namespace DEVinCar.System
{
    public interface IVeiculoFactory
    {
        IVeiculo CriarCamionete(int numeroDePortas, int capacidadeDaCacamba, int potencia, ETipoCombustivelCamionete tipoCombustivel, string nome, string placa, double valor, DateTime dataDeFabricacao);
        IVeiculo CriarCarro(int potencia, int numeroDePortas, ETipoCombustivelCarro tipoCombustivel, string nome, string placa, double valor, string cor, DateTime dataDeFabricacao);
        IVeiculo CriarMotoTriciclo(int potencia, int numeroDeRodas, string nome, string placa, double valor, string cor, DateTime dataDeFabricacao);
    }
}