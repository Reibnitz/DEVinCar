﻿using DEVinCar.Library;

namespace DEVinCar.System
{
    public class ListagemService
    {
        public List<IVeiculo> BuscarListaGeral(List<IVeiculo> listaVeiculos)
        {
            return listaVeiculos;
        }

        public List<IVeiculo> BuscarListaPorTipo(EVeiculo tipoVeiculo, List<IVeiculo> listaVeiculos)
        {
            List<IVeiculo> listaVeiculosPorTipo = new();

            switch (tipoVeiculo)
            {
                case EVeiculo.Carro:
                    listaVeiculosPorTipo = listaVeiculos.Where(veiculo => typeof(Veiculo).ToString() == "DEVinCar.Library.Carro").ToList();
                    break;
                case EVeiculo.Camionete:
                    listaVeiculosPorTipo = listaVeiculos.Where(veiculo => typeof(Veiculo).ToString() == "DEVinCar.Library.Camionete").ToList();
                    break;
                case EVeiculo.MotoETriciclo:
                    listaVeiculosPorTipo = listaVeiculos.Where(veiculo => typeof(Veiculo).ToString() == "DEVinCar.Library.MotoTriciclo").ToList();
                    break;
            }

            return listaVeiculosPorTipo;
        }

        public List<IVeiculo> BuscarListaDeCarrosVendidos(List<IVeiculo> listaVeiculos)
        {
            List<IVeiculo> listaVeiculosVendidos = listaVeiculos.Where(veiculo => veiculo.FoiVendido == true).ToList();

            return listaVeiculosVendidos;
        }

        public List<IVeiculo> BuscarListaDeCarrosDisponiveis(List<IVeiculo> listaVeiculos)
        {
            List<IVeiculo> listaVeiculosDisponiveis = listaVeiculos.Where(veiculo => veiculo.FoiVendido == false).ToList();

            return listaVeiculosDisponiveis;
        }

        public List<IVeiculo> BuscarListaPorMaiorPreco(List<IVeiculo> listaVeiculos)
        {
            List<IVeiculo> listaVeiculosVendidos = BuscarListaDeCarrosVendidos(listaVeiculos);
            List<IVeiculo> listaMaiorPreco = listaVeiculosVendidos.OrderByDescending(veiculo => veiculo.Valor).ToList();

            return listaMaiorPreco;
        }

        public List<IVeiculo> BuscarListaPorMenorPreco(List<IVeiculo> listaVeiculos)
        {
            List<IVeiculo> listaVeiculosVendidos = BuscarListaDeCarrosVendidos(listaVeiculos);
            List<IVeiculo> listaMenorPreco = listaVeiculosVendidos.OrderBy(veiculo => veiculo.Valor).ToList();

            return listaMenorPreco;
        }
    }
}
