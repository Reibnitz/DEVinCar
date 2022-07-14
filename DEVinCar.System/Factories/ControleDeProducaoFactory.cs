using DEVinCar.Library;

namespace DEVinCar.System
{
    public class ControleDeProducaoFactory
    {
        public static ControleDeProducao CriarControleDeProducao()
        {
            List<IVeiculo> listaDeVeiculos = new();
            ListagemService listagemService  = new();

             return new ControleDeProducao(listaDeVeiculos, listagemService);
        }
    }
}
