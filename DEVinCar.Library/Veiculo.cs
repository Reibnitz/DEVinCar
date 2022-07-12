using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public abstract class Veiculo : IVeiculo
    {
        public DateTime DataDeFabricacao { get; private set; }
        public string Nome { get; private set; }
        public string Placa { get; private set; }
        public double Valor { get; private set; }
        public string Cor { get; private set; }
        //
        public int NumeroChassi { get; set; }
        public DateTime DataDeVenda { get; private set; }
        public int CpfComprador { get; set; }
        public bool FoiVendido { get; private set; }

        public Veiculo(string nome, string placa, double valor, string cor, DateTime dataDeFabricacao)
        {
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            DataDeFabricacao = dataDeFabricacao;
            CpfComprador = 0;
        }

        public virtual void AlterarCor(string novaCor)
        {
            Cor = novaCor;
        }

        public void AlterarValor(double novoValor)
        {
            Valor = novoValor;
        }

        public void VenderVeiculo(DateTime dataDeVenda, int cpfComprador)
        {
            CpfComprador = cpfComprador;
            DataDeVenda = dataDeVenda;
            FoiVendido = true;
        }

        public virtual string ListarInformacoes()
        {
            string mensagem = 
                $"Nome do veículo: {Nome}" +
                $"\nPreço: R$ {Valor}" +
                $"\nPlaca: {Placa}" +
                $"\nCor: {Cor};" +
                $"\nData de fabricação: {DataDeFabricacao.ToShortDateString()}";

            if (CpfComprador != 0)
                mensagem += $"\nCPF do comprador: {CpfComprador}";

            return mensagem;
        }
    }
} 