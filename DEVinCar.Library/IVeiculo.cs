namespace DEVinCar.Library
{
    public interface IVeiculo
    {
        int NumeroChassi { get; set; }
        public bool FoiVendido { get;}
        double Valor { get; }

        void AlterarCor(string novaCor);
        void AlterarValor(double novoValor);
        string ListarInformacoes();
        void VenderVeiculo(DateTime dataDeVenda, int cpfComprador);
    }
}