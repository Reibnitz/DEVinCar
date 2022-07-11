namespace DEVinCar.Library
{
    public interface IVeiculo
    {
        //string Cor { get; }
        //int CpfComprador { get; }
        //DateTime DataDeFabricacao { get; }
        //DateTime DataDeVenda { get; }
        //string Nome { get; }
        int NumeroChassi { get; set; }
        //string Placa { get; }
        //double Valor { get; }

        void AlterarCor(string novaCor);
        void AlterarValor(double novoValor);
        string ListarInformacoes();
        void VenderVeiculo(DateTime dataDeVenda, int cpfComprador);
    }
}