using DEVinCar.Library;

namespace DEVinCar.System
{
    public class ControleDeProducao : IControleDeProducao
    {
        private ChassiService _chassiService;
        private ListagemService _listagemService;
        private List<IVeiculo> _listaDeVeiculos { get; set; }

        public IEnumerable<IVeiculo> ListaDeVeiculos { get { return _listaDeVeiculos; } }

        public ControleDeProducao(List<IVeiculo> listaDeVeiculos, ChassiService chassiService, ListagemService listagemService)
        {
            _listaDeVeiculos = listaDeVeiculos; // new List<IVeiculo>();
            _chassiService = chassiService;
            _listagemService = listagemService;
        }

        public void AdicionarVeiculo(IVeiculo veiculo)
        {
            int numeroChassi = _chassiService.GerarNumero();
            bool chassiEhUnico = _chassiService.VerificarNumero(numeroChassi, _listaDeVeiculos);

            while (!chassiEhUnico)
            {
                numeroChassi = _chassiService.GerarNumero();
                chassiEhUnico = _chassiService.VerificarNumero(numeroChassi, _listaDeVeiculos);
            }

            veiculo.NumeroChassi = numeroChassi;
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
