using DEVinCar.Library;
using DEVinCar.System;

//Carro carro = new(60, 4, true, "as", "mfk-4313", 123, "vermelha", DateTime.Now);
//MotoTriciclo moto = new(60, 2, "as", "asd-1234", 100, "preta", DateTime.Now);
//List<IVeiculo> lista = new();
//lista.Add(carro);
//lista.Add(moto);
//Console.WriteLine(carro.ListarInformacoes());

//Console.WriteLine(carro.GetType().ToString() == "DEVinCar.Library.Carro"); //DEVinCar.Library.Carro

//foreach (IVeiculo item in lista)
//{
//    Console.WriteLine(item.GetType());
//}


ControleDeProducao controleDeProducao = ControleDeProducaoFactory.CriarControleDeProducao();
VeiculoFactory veiculoFactory = new(controleDeProducao);
IVeiculo carro1 = veiculoFactory.CriarCarro(120, 4, true, "Uno", "CCC-0001", 30000, "Vermelha", DateTime.Now);
carro1.VenderVeiculo(DateTime.Now, 123123123);

IVeiculo carro2 = veiculoFactory.CriarCarro(100, 2, false, "Ka", "CCC-0002", 40000, "Azul", DateTime.Now);
IVeiculo carro3 = veiculoFactory.CriarCarro(140, 4, false, "HB20", "CCC-0003", 50000, "Preta", DateTime.Now);
carro3.VenderVeiculo(DateTime.Now, 123123123);

IVeiculo carro4 = veiculoFactory.CriarCarro(160, 4, true, "Palio", "CCC-0004", 35000, "Branca", DateTime.Now);
IVeiculo carro5 = veiculoFactory.CriarCarro(110, 2, true, "Fusca", "CCC-0005", 15000, "Branca", DateTime.Now);

List<IVeiculo> lista = controleDeProducao.BuscarListaVendidosPorMaiorPreco();

foreach (var item in lista)
{
    Console.WriteLine(item.Valor);
}