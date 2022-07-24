namespace DEVinCar.Library
{
    public interface IVeiculo
    {
        int NumeroChassi { get; set; }
        public bool FoiVendido { get;}
        double Valor { get; }
        DateTime DataDeFabricacao { get; }
        string Nome { get; }
        string Placa { get; }
        string Cor { get; }
        DateTime DataDeVenda { get; set; }
        int CpfComprador { get; set; }


        void AlterarCor(string novaCor);
        void AlterarValor(double novoValor);
        string ListarInformacoes();
        void VenderVeiculo(DateTime dataDeVenda, int cpfComprador);
    }
}