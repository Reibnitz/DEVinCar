using DEVinCar.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.System
{
    public class MensagensConsole
    {
        public static EOpcaoInicial EscolherOpcaoInicial()
        {
            Console.WriteLine("---------- Bem-vindo ao sistema DEVinCar ----------");
            Console.WriteLine("1- Adicionar veículo");
            Console.WriteLine("2- Buscar veículos no sistema");
            Console.Write("\nEscolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoInicial)opcaoEscolhida;
        }

        public static EOpcaoTipoVeiculo EscolherOpcaoDeVeiculoParaAdicionar()
        {
            Console.WriteLine("\n1- Moto/Triciclo");
            Console.WriteLine("2- Carro");  
            Console.WriteLine("3- Camionete");
            Console.Write("\nEscolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 3);

            return (EOpcaoTipoVeiculo)opcaoEscolhida;
        }

        public static EOpcaoListagem EscolherOpcaoDeListagem()
        {
            Console.WriteLine("\n1- Listar todos os veículos");
            Console.WriteLine("2- Listar veículos disponíveis");
            Console.WriteLine("3- Listar veículos vendidos");
            Console.Write("\nEscolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 3);

            return (EOpcaoListagem)opcaoEscolhida;
        }

        public static EOpcaoTipoVeiculo EscolherVeiculoParaListagem()
        {
            Console.WriteLine("\n1- Motos/Triciclos");
            Console.WriteLine("2- Carros");
            Console.WriteLine("3- Camionetes");
            Console.WriteLine("4- Todos");
            Console.Write("\nEscolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 4);

            return (EOpcaoTipoVeiculo)opcaoEscolhida;
        }

        public static EOpcaoOrdenacao EscolherOpcaoDeOrdenacao()
        {
            Console.WriteLine("\n1- Listar por menor preço vendido");
            Console.WriteLine("2- Listar por maior preço vendido");
            Console.Write("\nEscolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoOrdenacao)opcaoEscolhida;
        }

        private static int VerificarInput(int limite)
        {
            bool respostaValida = int.TryParse(Console.ReadLine(), out int opcaoEscolhida);
            if (!respostaValida)
                throw new InputInvalidoException();
            if (opcaoEscolhida > limite)
                throw new OpcaoNaoExistenteException(opcaoEscolhida);

            return opcaoEscolhida;
        }
    }
}
