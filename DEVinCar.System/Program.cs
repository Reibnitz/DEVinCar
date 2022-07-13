using DEVinCar.Library;
using DEVinCar.System;


ControleDeProducao controleDeProducao = ControleDeProducaoFactory.CriarControleDeProducao();
VeiculoFactory veiculoFactory = new(controleDeProducao);
ListaPadrao.CriarLista(veiculoFactory); // Lista de veículos para teste

bool continuar = true;
while (continuar)
{
    Console.Clear();
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
        List<IVeiculo> listaFiltrada = null;

        switch (opcaoListagem)
        {
            case EOpcaoListagem.Todos:
                listaFiltrada = controleDeProducao.BuscarListaGeral();
                break;

            case EOpcaoListagem.MotoTricilo:
                listaFiltrada = controleDeProducao.BuscarListaPorTipo(EVeiculo.MotoTricilo);
                break;

            case EOpcaoListagem.Carros:
                listaFiltrada = controleDeProducao.BuscarListaPorTipo(EVeiculo.Carro);
                break;

            case EOpcaoListagem.Camionetes:
                listaFiltrada = controleDeProducao.BuscarListaPorTipo(EVeiculo.Camionete);
                break;

            case EOpcaoListagem.Disponiveis:
                listaFiltrada = controleDeProducao.BuscarListaDeCarrosDisponiveis();
                break;

            case EOpcaoListagem.Vendidos:
                EOpcaoOrdenacao opcaoOrdenacao = MensagensConsole.EscolherOpcaoDeOrdenacao();
                if (opcaoOrdenacao == EOpcaoOrdenacao.Crescente)
                    listaFiltrada = controleDeProducao.BuscarListaVendidosPorMenorPreco();
                if (opcaoOrdenacao == EOpcaoOrdenacao.Decrescente)
                    listaFiltrada = controleDeProducao.BuscarListaVendidosPorMaiorPreco();
                break;
        }
        listaFiltrada.ForEach(veiculo => Console.WriteLine(veiculo));
    }
    continuar = MensagensConsole.DesejaContinuar();
}