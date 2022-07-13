namespace DEVinCar.System
{
    public enum EOpcaoInicial
    {
        AdicionarVeiculo = 1,
        ListarVeiculos
    }

    public enum EOpcaoTipoVeiculo
    {
        MotoTricilo = 1,
        Carro,
        Camionete,
        Todos
    }

    public enum EOpcaoListagem
    {
        Todos = 1,
        MotoTricilo,
        Carros,
        Camionetes,
        Disponiveis,
        Vendidos
    }

    public enum EOpcaoOrdenacao
    {
        Crescente = 1,
        Decrescente
    }
}
