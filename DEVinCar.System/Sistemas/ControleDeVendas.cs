using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class ControleDeVendas
    {
        private List<IVeiculo> _historico { get; set; }
        public IEnumerable<IVeiculo> Historico { get { return _historico; } }

        public ControleDeVendas()
        {
            _historico  = new List<IVeiculo>();
        }

        public void AdicionarVendaAoHistorico(IVeiculo veiculo, int cpfComprador, DateTime dataDaVenda)
        {
            _historico.Add(veiculo);
        }
    }
}
