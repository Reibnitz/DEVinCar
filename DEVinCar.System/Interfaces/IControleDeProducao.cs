using DEVinCar.Library;

namespace DEVinCar.System
{
    public interface IControleDeProducao
    {
        IEnumerable<IVeiculo> ListaDeVeiculos { get; }

        void AdicionarVeiculo(IVeiculo veiculo);
        List<IVeiculo> BuscarListaDeCarrosDisponiveis();
        List<IVeiculo> BuscarListaDeCarrosVendidos();
        List<IVeiculo> BuscarListaGeral();
        List<IVeiculo> BuscarListaPorTipo(EVeiculo tipoVeiculo);
        List<IVeiculo> BuscarListaVendidosPorMaiorPreco();
        List<IVeiculo> BuscarListaVendidosPorMenorPreco();
    }
}