using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Library
{
    public enum EVeiculo
    {
        Carro = 1,
        Camionete,
        MotoTricilo
    }

    public enum ETipoCombustivelCarro
    {
        Gasolina = 1,
        Flex
    }

    public enum ETipoCombustivelCamionete
    {
        Gasolina = 1,
        Diesel
    }

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
