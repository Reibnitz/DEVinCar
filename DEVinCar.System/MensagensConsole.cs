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
            Console.WriteLine
            ("   ___     ___   __   __    _              ___                   \n" +
            "  |   \\   | __|  \\ \\ / /   (_)    _ _     / __|   __ _      _ _\n" +
            "  | |) |  | _|    \\ V /    | |   | ' \\   | (__   / _` |    | '_| \n" +
            "  |___/   |___|   _\\_/_   _|_|_  |_||_|   \\___|  \\__,_|   _|_|_  \n" +
            "_|\"\"\"\"\"|_|\"\"\"\"\"|_| \"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|\n" +
            "\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-' ");

            Console.WriteLine("\n   Sistema de controle de veículos\n");
            Console.WriteLine("     [1] Adicionar veículo");
            Console.WriteLine("     [2] Buscar veículos no sistema");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoInicial)opcaoEscolhida;
        }

        public static EOpcaoTipoVeiculo EscolherOpcaoDeVeiculoParaAdicionar()
        {
            Console.WriteLine("\n   Adicionar veículo\n");
            Console.WriteLine("     [1] Moto/Triciclo");
            Console.WriteLine("     [2] Carro");  
            Console.WriteLine("     [3] Camionete");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 3);

            return (EOpcaoTipoVeiculo)opcaoEscolhida;
        }

        public static EOpcaoListagem EscolherOpcaoDeListagem()
        {
            Console.WriteLine("\n   Buscar veículos no sistema\n");
            Console.WriteLine("     [1] Listar todos os veículos");
            Console.WriteLine("     [2] Listar todas as Motos/Triciclos");
            Console.WriteLine("     [3] Listar todos os Carros");
            Console.WriteLine("     [4] Listar todos os Camionetes");
            Console.WriteLine("     [5] Listar veículos disponíveis");
            Console.WriteLine("     [6] Listar veículos vendidos");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 6);

            return (EOpcaoListagem)opcaoEscolhida;
        }

        public static EOpcaoOrdenacao EscolherOpcaoDeOrdenacao()
        {
            Console.WriteLine("\n   Definir ordenação da lista\n");
            Console.WriteLine("     [1] Listar por menor preço vendido");
            Console.WriteLine("     [2] Listar por maior preço vendido");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return (EOpcaoOrdenacao)opcaoEscolhida;
        }

        public static bool DesejaContinuar()
        {
            Console.WriteLine("\n   Deseja realizar outra operação?\n");
            Console.WriteLine("     [1] Sim");
            Console.WriteLine("     [2] Não");
            Console.Write("\n   Escolha a opção desejada: ");

            int opcaoEscolhida = VerificarInput(limite: 2);

            return opcaoEscolhida == 1 ? true : false;
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
