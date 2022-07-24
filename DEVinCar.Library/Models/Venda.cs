using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public class Venda : IVenda
    {
        public string DadosDoVeiculo { get; set; }
        public int CpfDoComprador { get; set; }
        public double Valor { get; set; }
        public DateTime DataDeVenda { get; set; }

        public Venda(string dadosDoVeiculo, int cpfDoComprador, double valor, DateTime dataDeVenda)
        {
            DadosDoVeiculo = dadosDoVeiculo;
            CpfDoComprador = cpfDoComprador;
            Valor = valor;
            DataDeVenda = dataDeVenda;
        }
    }
}
