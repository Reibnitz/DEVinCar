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