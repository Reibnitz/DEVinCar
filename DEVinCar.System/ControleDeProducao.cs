using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
O sistema também deverá apresentar os seguintes relatórios:
Listar todos os carros. O usuário deverá informar quais veículos quais tipos de veículos deseja listar:
Motos/Triciclo
Carros
Camionete
Todos
Carros disponíveis
Carros vendidos
Carro vendido com o maior preço
Carro vendido com o menor preço
*/

namespace DEVinCar.System
{
    public class ControleDeProducao
    {
        private ChassiService _chassiService;
        private List<IVeiculo> _listaDeVeiculos { get; set; }
        public IEnumerable<IVeiculo> ListaDeVeiculos { get { return _listaDeVeiculos; } }

        public ControleDeProducao(ChassiService chassiService, List<IVeiculo> listaDeVeiculos)
        {
            _chassiService = chassiService;
            _listaDeVeiculos = listaDeVeiculos;
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
    }
}
