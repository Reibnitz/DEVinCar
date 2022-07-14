using DEVinCar.Library;

namespace DEVinCar.System
{
    public class ControleDeProducaoFactory
    {
        public static ControleDeProducao CriarControleDeProducao()
        {
            List<IVeiculo> listaDeVeiculos = new();
            ChassiService chassiService = new();
            ListagemService listagemService  = new();

             return new ControleDeProducao(listaDeVeiculos, chassiService, listagemService);
        }
    }
}
