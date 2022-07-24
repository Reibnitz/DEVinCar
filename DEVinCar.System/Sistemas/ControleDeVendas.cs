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
        private List<IVenda> _historico { get; set; } = new List<IVenda>();
        public IEnumerable<IVenda> Historico { get { return _historico; } }

        public void AdicionarVenda(IVeiculo veiculo)
        {
            if (veiculo.CpfComprador == 0)
                throw new VeiculoNaoVendidoException(veiculo.Nome, veiculo.NumeroChassi);

            string dadosDoVeiculo = veiculo.ToString();
            int cpfDoComprador = veiculo.CpfComprador;
            double valor = veiculo.Valor;
            DateTime dataDeVenda = veiculo.DataDeVenda;

            IVenda registroDeVenda = new Venda(dadosDoVeiculo, cpfDoComprador, valor, dataDeVenda);
            _historico.Add(registroDeVenda);
        }
    }
}
