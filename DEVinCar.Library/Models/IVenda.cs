namespace DEVinCar.Library
{
    public interface IVenda
    {
        int CpfDoComprador { get; set; }
        string DadosDoVeiculo { get; set; }
        DateTime DataDeVenda { get; set; }
        double Valor { get; set; }
    }
}