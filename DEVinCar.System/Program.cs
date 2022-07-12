using DEVinCar.Library;
using DEVinCar.System;


ControleDeProducao controleDeProducao = ControleDeProducaoFactory.CriarControleDeProducao();
VeiculoFactory veiculoFactory = new(controleDeProducao);
ListaPadrao.CriarLista(veiculoFactory); // Lista de veículos para teste


List<IVeiculo> lista = controleDeProducao.BuscarListaVendidosPorMaiorPreco();

foreach (var item in lista)
{
    Console.WriteLine(item.ListarInformacoes());
}



while (true)
{
    EOpcaoInicial opcaoInicial = MensagensConsole.EscolherOpcaoInicial();
    if (opcaoInicial == EOpcaoInicial.AdicionarVeiculo)
    {
        EOpcaoTipoVeiculo opcaoVeiculo = MensagensConsole.EscolherOpcaoDeVeiculoParaAdicionar();
        switch (opcaoVeiculo)
        {
            case EOpcaoTipoVeiculo.MotoTricilo:
                // TODO criar mensagens para adição de veículos
                break;
            case EOpcaoTipoVeiculo.Carro:
                break;
            case EOpcaoTipoVeiculo.Camionete:
                break;
        }
    }
    if (opcaoInicial == EOpcaoInicial.ListarVeiculos)
    {
        EOpcaoListagem opcaoListagem = MensagensConsole.EscolherOpcaoDeListagem();
        switch (opcaoListagem)
        {
            // TODO adicionar método ToString às listagens

            case EOpcaoListagem.Todos:
                controleDeProducao.BuscarListaGeral();
                break;

            case EOpcaoListagem.Disponiveis:
                controleDeProducao.BuscarListaDeCarrosDisponiveis();
                break;

            case EOpcaoListagem.Vendidos:
                EOpcaoOrdenacao opcaoOrdenacao = MensagensConsole.EscolherOpcaoDeOrdenacao();
                if (opcaoOrdenacao == EOpcaoOrdenacao.Crescente)
                    controleDeProducao.BuscarListaVendidosPorMenorPreco();
                if (opcaoOrdenacao == EOpcaoOrdenacao.Decrescente)
                    controleDeProducao.BuscarListaVendidosPorMaiorPreco();
                break;
        }
    }
}