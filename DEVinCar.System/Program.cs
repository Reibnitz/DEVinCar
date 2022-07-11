using DEVinCar.Library;
using DEVinCar.System;

Carro carro = new(60, 4, true, "as", "mfk-4313", 123, "vermelha", DateTime.Now);
MotoTriciclo moto = new(60, 2, "as", "asd-1234", 100, "preta", DateTime.Now);
List<IVeiculo> lista = new();
lista.Add(carro);
lista.Add(moto);
Console.WriteLine(carro.ListarInformacoes());

Console.WriteLine(carro.GetType()); //DEVinCar.Library.Carro

foreach (IVeiculo item in lista)
{
    Console.WriteLine(item.GetType());
}
