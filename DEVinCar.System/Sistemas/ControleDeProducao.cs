using DEVinCar.Library;

namespace DEVinCar.System
{
    public class ControleDeProducao : IControleDeProducao
    {
        private ListagemService _listagemService;
        private List<IVeiculo> _listaDeVeiculos { get; set; }

        public IEnumerable<IVeiculo> ListaDeVeiculos { get { return _listaDeVeiculos; } }

        public ControleDeProducao(List<IVeiculo> listaDeVeiculos, ListagemService listagemService)
        {
            _listaDeVeiculos = listaDeVeiculos;
            _listagemService = listagemService;
        }

        public void AdicionarVeiculo(IVeiculo veiculo)
        {
            _listaDeVeiculos.Add(veiculo);
        }

        public List<IVeiculo> BuscarListaGeral()
        {
            return _listagemService.BuscarListaGeral(_listaDeVeiculos);
        }

        public List<IVeiculo> BuscarListaPorTipo(EVeiculo tipoVeiculo)
        {
            return _listagemService.BuscarListaPorTipo(tipoVeiculo, _listaDeVeiculos);
        }

        public List<IVeiculo> BuscarListaDeCarrosVendidos()
        {
            return _listagemService.BuscarListaDeCarrosVendidos(_listaDeVeiculos);
        }

        public List<IVeiculo> BuscarListaDeCarrosDisponiveis()
        {
            return _listagemService.BuscarListaDeCarrosDisponiveis(_listaDeVeiculos);
        }

        public List<IVeiculo> BuscarListaVendidosPorMaiorPreco()
        {
            return _listagemService.BuscarListaVendidosPorMaiorPreco(_listaDeVeiculos);
        }

        public List<IVeiculo> BuscarListaVendidosPorMenorPreco()
        {
            return _listagemService.BuscarListaVendidosPorMenorPreco(_listaDeVeiculos);
        }
    }
}
